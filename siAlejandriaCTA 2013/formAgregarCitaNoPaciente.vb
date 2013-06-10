Imports System.Data.Objects
Imports System.Data.Objects.DataClasses

Public Class formAgregarCitaNoPaciente

    Private Sub btAñadir_Click(sender As System.Object, e As System.EventArgs) Handles btAñadir.Click
        If String.IsNullOrWhiteSpace(tbNombreCita.Text) Or String.IsNullOrWhiteSpace(tbFecha.Text) Or String.IsNullOrWhiteSpace(tbHora.Text) Or String.IsNullOrWhiteSpace(cbxTecnico.Text) Then
            MsgBox("Por favor, complete todos los campos")
            Exit Sub
        Else

            Dim nuevaCitaNoPac As DESCONECTADA = DESCONECTADA.CreateDESCONECTADA(idNoPaciente:=AutoCompleteMode.None)
            bdAlej.AddToDESCONECTADA(nuevaCitaNoPac)

            nuevaCitaNoPac.Nombre_Cita = tbNombreCita.Text
            nuevaCitaNoPac.Tecnico_Cita = cbxTecnico.Text
            nuevaCitaNoPac.Fecha_Cita = tbFecha.Text
            nuevaCitaNoPac.Hora_Cita = tbHora.Text

            Try
                bdAlej.SaveChanges()
                MessageBox.Show("Cita registrada con éxito")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            Me.Close()

        End If
    End Sub

    Private Sub formAgregarCitaNoPaciente_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        tbNombreCita.Text = ""
        tbFecha.Text = ""
        tbHora.Text = ""
        cbxTecnico.Items.Clear()
        cbxTecnico.Text = ""
    End Sub
End Class