Imports System.Data.Objects
Imports System.Data.Objects.DataClasses

Public Class formEliminarTerapia

    Private Sub btEliminar_Click(sender As System.Object, e As System.EventArgs) Handles btEliminar.Click
        If String.IsNullOrWhiteSpace(cbxGruposTerapia.Text) Then
            MsgBox("Seleccione un grupo de terapia")
            Exit Sub
        Else

            Dim terapias As ObjectSet(Of TERAPIAS) = bdAlej.TERAPIAS
            Dim query = (From t In terapias Where t.NombreTerapia = cbxGruposTerapia.Text.Trim Select t)

            bdAlej.TERAPIAS.DeleteObject(query.FirstOrDefault)
            Try
                bdAlej.SaveChanges()
                MessageBox.Show("Terapia eliminada con éxito")
            Catch ex As Exception
                MessageBox.Show("No se puede eliminar la terapia")
            End Try
            Me.Close()
        End If
    End Sub
End Class