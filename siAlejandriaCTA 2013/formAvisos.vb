Imports System.Data.Objects
Imports System.Data.Objects.DataClasses

Public Class formAvisos

    Private Sub btAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btAceptar.Click
        Me.Close()
    End Sub

    Private Sub lklbProcesoAbandono_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lklbProcesoAbandono.LinkClicked
        Me.Close()
        Dim resta As Integer
        Dim fechaUltimaCita, fechaActual As Date
        fechaActual = Date.Now
        Dim cit As ObjectSet(Of CITAS) = bdAlej.CITAS
        Dim ingreso As ObjectSet(Of INGRESO) = bdAlej.INGRESO
        Dim alta As ObjectSet(Of ALTA) = bdAlej.ALTA
        Dim histori As ObjectSet(Of HISTORIA) = bdAlej.HISTORIA
        Dim pac As ObjectSet(Of PACIENTES) = bdAlej.PACIENTES

        'Esto para el dgv
        formBusqueda.dgvBusqueda.ColumnCount = 2
        formBusqueda.dgvBusqueda.ColumnHeadersVisible = True
        formBusqueda.dgvBusqueda.Columns(0).Name = "Historia"
        formBusqueda.dgvBusqueda.Columns(1).Name = "Fecha Última Cita"
        Dim row() As String

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
                                    row = {x.history, fechaUltimaCita}
                                    formBusqueda.dgvBusqueda.Rows.Add(row)
                                End If
                            End If
                        Next
                    Next
                Next
            End If
        Next
        mostrarFormBusquedaPaAvisos()
        formBusqueda.Text = "Pacientes en Proceso de Abandono de Tratamiento"
        formBusqueda.Show()
        '   Me.Close()
    End Sub

    Private Sub lklbAbandono_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lklbAbandono.LinkClicked
        Me.Close()
        Dim resta As Integer
        Dim fechaUltimaCita, fechaActual As Date
        fechaActual = Date.Now
        Dim cit As ObjectSet(Of CITAS) = bdAlej.CITAS
        Dim ingreso As ObjectSet(Of INGRESO) = bdAlej.INGRESO
        Dim alta As ObjectSet(Of ALTA) = bdAlej.ALTA
        Dim histori As ObjectSet(Of HISTORIA) = bdAlej.HISTORIA
        Dim pac As ObjectSet(Of PACIENTES) = bdAlej.PACIENTES

        'Esto para el dgv
        formBusqueda.dgvBusqueda.ColumnCount = 2
        formBusqueda.dgvBusqueda.ColumnHeadersVisible = True
        formBusqueda.dgvBusqueda.Columns(0).Name = "Historia"
        formBusqueda.dgvBusqueda.Columns(1).Name = "Fecha Última Cita"
        Dim row() As String

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
                                If resta > 180 Then
                                    row = {x.history, fechaUltimaCita}
                                    formBusqueda.dgvBusqueda.Rows.Add(row)
                                End If
                            End If
                        Next
                    Next
                Next
            End If
        Next
        mostrarFormBusquedaPaAvisos()
        formBusqueda.Text = "Pacientes en Abandono de Tratamiento"
        formBusqueda.Show()

    End Sub

    Private Sub mostrarFormBusquedaPaAvisos()
        formBusqueda.btBuscar.Enabled = False
        formBusqueda.tbBuscar.Enabled = False
        formBusqueda.rbDNI.Enabled = False
        formBusqueda.rbHistoria.Enabled = False
        formBusqueda.rbNombre.Enabled = False
        formBusqueda.btVerHistoria.Visible = False
        formBusqueda.btMostrarEnBuscador.Location = New Point(445, 248)
        formBusqueda.btMostrarEnBuscador.Visible = True
    End Sub

End Class


' DateTime.Now() // "2009-06-16 09:50:20.000 am"
' Datetime.Now().ToShortDateString() // "2009/06/16"
' Datetime.Now().ToShortTimeString() // "09:50:00 am"
' Datetime.Now().ToString("dd/MM/yyyy hh:mm:ss tt") // "2009-06-16 09:50:20 am"
'Para este último puedes usar
'dd: día
'MM: mes
'yyyy ó yy: año
'hh: horas
'mm: minutos
'ss: segundos
'tt: am/pm