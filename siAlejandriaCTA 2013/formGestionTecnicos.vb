Imports System.Security.Cryptography
Imports System.Data.Objects
Imports System.Data.Objects.DataClasses
Imports System.IO
Imports System.Text

Public Class formGestionTecnicos

    Private Sub cbxSeleccionarTecnico_TextChanged(sender As System.Object, e As System.EventArgs) Handles cbxSeleccionarTecnico.TextChanged

        Dim tecs As ObjectSet(Of TECNICOS) = bdAlej.TECNICOS
        Dim usu As ObjectSet(Of USUGES) = bdAlej.USUGES

        Dim query = (From d In tecs Join u In usu On d.IdTecnico Equals u.IdTecnico _
                     Where d.NombreTecnico.Trim = cbxSeleccionarTecnico.Text.Trim _
                     Select New With {d.NombreTecnico, d.Profesion, u.NombreUsuGes, u.Nivel})
     
            For Each resultado In query
                tbNombreTecnico.Text = resultado.NombreTecnico
                cbxProfesionTecnico.Text = resultado.Profesion
                tbNombreUsuario.Text = resultado.NombreUsuGes
                cbxNivelUsuario.Text = resultado.Nivel
            Next
      

        btAñadirTecnico.Text = "Actualizar"

    End Sub

    Private Sub btAñadirTecnico_Click(sender As System.Object, e As System.EventArgs) Handles btAñadirTecnico.Click

        If cbxProfesionTecnico.Text = "INVITADO" And cbxNivelUsuario.Text = "1" Then
            MsgBox("Los Invitados no pueden tener Nivel de Acceso 1")
        Else
            If String.IsNullOrWhiteSpace(tbNombreTecnico.Text) Or String.IsNullOrWhiteSpace(tbNombreUsuario.Text) Or String.IsNullOrWhiteSpace(tbPasswordUsuario.Text) Or _
                String.IsNullOrWhiteSpace(cbxProfesionTecnico.Text) Or String.IsNullOrWhiteSpace(cbxNivelUsuario.Text) Then
                MsgBox("Todos los campos son obligatorios")
            Else

                '¡¡¡¡COMPROBAR SI EL TECNICO YA ESTÁ REGISTRADO!!!!

                Dim existe As Boolean = False

                bdAlej = New bdAlejandriaCTAEntities1

                Dim tecs As ObjectSet(Of TECNICOS) = bdAlej.TECNICOS

                Dim consulta = (From d In tecs Select New With {d.NombreTecnico, d.Profesion})

                For Each r In consulta
                    If tbNombreTecnico.Text.Trim = r.NombreTecnico.Trim And cbxProfesionTecnico.Text.Trim = r.Profesion.Trim Then
                        existe = True
                        Exit For
                    End If
                Next

                If existe = False Then
                    'insertamos al tecnico
                    Dim nuevoTecnico As TECNICOS = TECNICOS.CreateTECNICOS(idTecnico:=AutoCompleteMode.None)

                    bdAlej.AddToTECNICOS(nuevoTecnico)

                    nuevoTecnico.NombreTecnico = tbNombreTecnico.Text.Trim
                    nuevoTecnico.Profesion = cbxProfesionTecnico.Text.Trim

                    Try
                        bdAlej.SaveChanges()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try


                    'obtenemos el IdTecnico
                    Dim query = (From d In bdAlej.TECNICOS Where d.NombreTecnico = tbNombreTecnico.Text Select d.IdTecnico)

                    Dim nuevoUsuario As USUGES = USUGES.CreateUSUGES(idUsuGes:=AutoCompleteMode.None)

                    bdAlej.AddToUSUGES(nuevoUsuario)

                    nuevoUsuario.NombreUsuGes = tbNombreUsuario.Text.Trim
                    nuevoUsuario.KeyApp = cifrar(tbPasswordUsuario.Text.Trim)
                    nuevoUsuario.Nivel = cbxNivelUsuario.Text
                    nuevoUsuario.IdTecnico = query.FirstOrDefault

                    Try
                        bdAlej.SaveChanges()
                        MessageBox.Show("Técnico añadido con éxito")
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try

                    Me.Close()


                ElseIf existe = True Then
                    Dim caption As String = "Atención"
                    If (MessageBox.Show("Esto actualizará la contraseña, ¿desea continuar?", caption, MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes) Then

                        'actualizamos la contraseña
                        Dim usug As ObjectSet(Of USUGES) = bdAlej.USUGES

                        Dim query = (From d In usug Where d.NombreUsuGes.Trim = tbNombreUsuario.Text.Trim _
                                     Select d).FirstOrDefault()

                        query.KeyApp = cifrar(tbPasswordUsuario.Text.Trim)
                    End If

                    Try
                        bdAlej.SaveChanges()
                        MessageBox.Show("Contraseña actualizada con éxito")
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try
                End If

            End If

        End If

    End Sub

    Private Sub btEliminarTécnico_Click(sender As System.Object, e As System.EventArgs) Handles btEliminarTécnico.Click

        Dim usu As ObjectSet(Of USUGES) = bdAlej.USUGES

        If String.IsNullOrWhiteSpace(tbNombreTecnico.Text) Or String.IsNullOrWhiteSpace(tbNombreUsuario.Text) Then
            MsgBox("Los campos 'Nombre' y 'Nombre de usuario' son obligatorios.")
            Exit Sub
        Else
            Dim query = (From d In usu Where d.NombreUsuGes = tbNombreUsuario.Text Select d)

            Dim caption As String = "Atención"
            If (MessageBox.Show("Esto borrará al usuario del sistema, ¿desea continuar?", caption, MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes) Then
                bdAlej.USUGES.DeleteObject(query.FirstOrDefault)
            End If

            Try
                bdAlej.SaveChanges()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

            Dim tecs As ObjectSet(Of TECNICOS) = bdAlej.TECNICOS

            Dim query2 = (From d In tecs Where d.NombreTecnico = tbNombreTecnico.Text Select d)

            Dim caption2 As String = "Atención"
            If (MessageBox.Show("Esto borrará al técnico del sistema, ¿desea continuar?", caption2, MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes) Then
                bdAlej.TECNICOS.DeleteObject(query2.FirstOrDefault)
            End If

            Try
                bdAlej.SaveChanges()
                MessageBox.Show("Técnico y usuario eliminados con éxito")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

            Me.Close()

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

    Private Sub formGestionTecnicos_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        cbxSeleccionarTecnico.Items.Clear()
        tbNombreTecnico.Text = ""
        tbNombreUsuario.Text = ""
        tbPasswordUsuario.Text = ""
        cbxProfesionTecnico.Text = ""
        cbxNivelUsuario.Text = ""
    End Sub
End Class