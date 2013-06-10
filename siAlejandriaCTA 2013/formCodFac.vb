Imports System.Data.Objects
Imports System.Data.Objects.DataClasses


Public Class formCodFac

    Private Sub btGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btGuardar.Click

        'comprobamos que existe el nº de historia
        Dim hist As ObjectSet(Of HISTORIA) = bdAlej.HISTORIA
        Dim comprobandoNum = (From h In hist Where h.IdHistoria = tbHistoria.Text.Trim Select h).FirstOrDefault
        Dim encontrado As Boolean = False
        If IsNothing(comprobandoNum) Then
            MsgBox("El número de historia no está registrado")
            Exit Sub
        Else
            Dim pac As ObjectSet(Of PACIENTES) = bdAlej.PACIENTES

            If String.IsNullOrWhiteSpace(tbHistoria.Text) Then
                MsgBox("Introduzca el número de historia")
                Exit Sub
            Else

                'buscamos el idPaciente
                Dim pacienteActivo As String
                Dim hs As ObjectSet(Of HISTORIA) = bdAlej.HISTORIA
                Dim query2 = (From p In hs Where p.IdHistoria = tbHistoria.Text.Trim Select New With {p.IdPaciente})
                For Each s In query2
                    pacienteActivo = s.IdPaciente
                Next

                'comprobamos si ya se ha grabado un codigo de facturación
                Dim comprobandoFact = (From p In pac Join h In hs On p.IdPaciente Equals h.IdPaciente Where h.IdHistoria = tbHistoria.Text.Trim Select p.CodFacturacion)
                If String.IsNullOrWhiteSpace(comprobandoFact.FirstOrDefault) Then

                    'insertamos el campo CodFacturacion en PACIENTES
                    Dim actualizarEnPacientes = (From p In pac Join h In hs On p.IdPaciente Equals h.IdPaciente Where h.IdHistoria = tbHistoria.Text.Trim Select p).FirstOrDefault
                    actualizarEnPacientes.CodFacturacion = "CF" & tbHistoria.Text.Trim

                    'creamos el nuevo registro en la tabla FACTURACION
                    Dim nuevaFacturacion As FACTURACION = FACTURACION.CreateFACTURACION(codFacturacion:="CF" & tbHistoria.Text.Trim)
                    bdAlej.AddToFACTURACION(nuevaFacturacion)

                    Try
                        bdAlej.SaveChanges()
                        MessageBox.Show("Facturación añadida con éxito")
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try
                    Me.Close()
                Else
                    MsgBox("No puede modificar el Código de Facturación del paciente")
                End If

            End If
        End If
    End Sub

End Class