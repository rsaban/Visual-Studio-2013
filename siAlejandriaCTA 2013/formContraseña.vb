Imports System.Security.Cryptography
Imports System.Data.Objects
Imports System.Data.Objects.DataClasses
Imports System.IO
Imports System.Text
Imports System.DateTime
Imports System.Linq

Public Class formContraseña

    Private Sub formContraseña_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        tbUsuario.Text = ""
        tbPassword.Text = ""
        tbUsuario.Focus()
    End Sub

    Private Sub btAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btAceptar.Click
        Dim acceso1 As Boolean = False
        Dim acceso2 As Boolean = False

        bdAlej = New bdAlejandriaCTAEntities1

        Dim usu As ObjectSet(Of USUGES) = bdAlej.USUGES

        Dim query = (From d In usu Select New With {d.NombreUsuGes, d.KeyApp, d.Nivel})

        For Each r In query
            If tbUsuario.Text.Trim = r.NombreUsuGes.Trim And (cifrar(tbPassword.Text) = r.KeyApp) Then 'aqui falla el Trim en la password
                If r.Nivel = 1 Or r.Nivel = 3 Then
                    acceso1 = True
                    nombreUsuarioActivo = r.NombreUsuGes.Trim
                    acceso2 = False
                    Exit For

                ElseIf r.Nivel = 2 Then
                    acceso2 = True
                    nombreUsuarioActivo = r.NombreUsuGes.Trim
                    acceso1 = False
                    Exit For
                End If
            Else
                acceso1 = False
                acceso2 = False
            End If

        Next

        If acceso1 = True Then
            Form1.btAcceso.Visible = False
            Form1.btAltaPaciente.Visible = True
            Form1.btAltaPaciente.Enabled = True
            Form1.btBusqueda.Visible = True
            Form1.btEstadisticas.Visible = True
            Form1.btHerramientas.Visible = True
            Form1.btHerramientas.Enabled = True
            Form1.btGruposTerap.Visible = True
            Form1.btGruposTerap.Enabled = True
            Form1.btSalir.Visible = True

            Avisos()
           
            Me.Close()
        ElseIf acceso2 = True Then
            Form1.btAcceso.Visible = False
            Form1.btAltaPaciente.Visible = True
            Form1.btAltaPaciente.Enabled = False
            Form1.btBusqueda.Visible = True
            Form1.btEstadisticas.Visible = True
            Form1.btHerramientas.Visible = True
            Form1.btHerramientas.Enabled = True
            Form1.btGruposTerap.Visible = True
            Form1.btGruposTerap.Enabled = False
            Form1.btSalir.Visible = True
            Me.Close()
        Else
            MessageBox.Show("Contraseña Incorrecta")
        End If


    End Sub

    Function cifrar(ByVal result As String)
        'Para que el resultado tenga formato ASCII
        Dim enc As ASCIIEncoding = New ASCIIEncoding
        Dim firmaMD5 As MD5 = MD5.Create
        Dim ms As MemoryStream = New MemoryStream(enc.GetBytes(result))
        result = enc.GetString(firmaMD5.ComputeHash(ms))
        'Eliminamos los objetos que hemos creado
        ms = Nothing
        firmaMD5 = Nothing
        enc = Nothing

        Return result
    End Function

    Public Sub Avisos()
        'vamos a mostrar los avisos  para aquellos que están en proceso de abandono (+ 90 días) y en Abandono (+180 días)
        Dim contadorProcesoAbandono, contadorAbandono, resta As Integer
        Dim fechaUltimaCita, fechaActual As Date
        fechaActual = Date.Now
        Dim cit As ObjectSet(Of CITAS) = bdAlej.CITAS
        Dim ingreso As ObjectSet(Of INGRESO) = bdAlej.INGRESO
        Dim alta As ObjectSet(Of ALTA) = bdAlej.ALTA
        Dim histori As ObjectSet(Of HISTORIA) = bdAlej.HISTORIA
        Dim pac As ObjectSet(Of PACIENTES) = bdAlej.PACIENTES

        Dim queryCitas = (From i In ingreso Let igr = i.IdHistoria Group i By igr Into r = Group _
                        Select New With {.history = igr, .fechaingreso = r.Max(Function(i) i.FechaAdmisionTTo)})

        For Each x In queryCitas
            Dim salidaBucle As Boolean = False
            Dim variable As String
            variable = x.history
            Dim queryAlta = (From a In alta Let alt = a.IdHistoria Where a.IdHistoria = variable Group a By alt Into s = Group _
                             Select New With {.historyalta = alt, .fechaAlta = s.Max(Function(a) a.FechaAlta)})
            For Each w In queryAlta
                If w.historyalta = variable Then
                    If w.fechaAlta > x.fechaingreso Then
                        salidaBucle = True
                        Exit For
                    End If
                End If
            Next
            If salidaBucle = False Then 'en este momento estamos sólo con los pacientes que están en TTº
                Dim averiguandoIdPac = (From h In histori Join p In pac On h.IdPaciente Equals p.IdPaciente Where h.IdHistoria = variable Select New With {h.IdPaciente})
                For Each w In averiguandoIdPac
                    Dim variableIdPac As String
                    variableIdPac = w.IdPaciente
                    Dim queryNoAsistencia = (From c In cit Let paciente = c.IdPaciente Where c.IdPaciente = variableIdPac And c.Asistencia = "NO ASISTE" Group c By paciente Into r = Group _
                             Select New With {.paciente = paciente, .fecha = r.Max(Function(c) c.FechaCita)})
                    For Each y In queryNoAsistencia
                        'tenemos que asegurarnos que despues de la no asistencia, no haya asistido otra vez
                        Dim queryAsistencia = (From c In cit Let paciente = c.IdPaciente Where c.IdPaciente = variableIdPac And c.Asistencia = "ASISTE" Group c By paciente Into r = Group _
                                Select New With {.paciente = paciente, .fecha = r.Max(Function(c) c.FechaCita)})
                        For Each z In queryAsistencia
                            Dim fechaUltimaAsistencia = z.fecha
                            fechaUltimaCita = y.fecha
                            If fechaUltimaCita > fechaUltimaAsistencia Then
                                resta = DateDiff("d", fechaUltimaCita, fechaActual)
                                If resta > 90 And resta <= 180 Then
                                    contadorProcesoAbandono += 1
                                ElseIf resta > 180 Then
                                    contadorAbandono += 1
                                End If
                            End If
                        Next
                    Next
                Next
            End If
        Next

        If contadorProcesoAbandono > 0 Or contadorAbandono > 0 Then
            formAvisos.lklbProcesoAbandono.Text = "Tiene " & contadorProcesoAbandono & " paciente/s en proceso de abandono."
            formAvisos.lklbAbandono.Text = "Tiene " & contadorAbandono & " paciente/s en abandono."
            formAvisos.ShowDialog()
            formAvisos.btAceptar.Focus()
        End If
    End Sub
End Class


'Ejemplo de prueba para restar fechas y horas

'Option Explicit
'Private Sub Command1_Click()
'    Dim t0 As Variant, t1 As Variant

'    'Text1 Tendrá una fecha anterior
'    'Text2 tendrá la nueva fecha
'    t0 = DateValue(Text1)
'    t1 = DateValue(Text2)
'Label1 = t1 – t0


'En este ejemplo se utiliza la función DateDiff para mostrar el número de días entre una fecha dada y la fecha actual.
'VB

'Dim firstDate, msg AsString
'Dim secondDate AsDate
'firstDate = InputBox("Enter a date")
'secondDate = CDate(firstDate)
'msg = "Days from today: " & DateDiff(DateInterval.Day, Now, secondDate)
'MsgBox(msg)

