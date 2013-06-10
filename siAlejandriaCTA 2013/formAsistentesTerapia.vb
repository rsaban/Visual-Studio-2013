Imports System.Data.Objects
Imports System.Data.Objects.DataClasses


Public Class formAsistentesTerapia

    Private Sub btValidarAsistencia_Click(sender As System.Object, e As System.EventArgs) Handles btValidarAsistencia.Click

        Dim asistentes As ObjectSet(Of ASISTENTES_TERAPIA) = bdAlej.ASISTENTES_TERAPIA
        Dim pac As ObjectSet(Of PACIENTES) = bdAlej.PACIENTES

        For Each fila As DataGridViewRow In dgvAsistentes.Rows
            Dim pc As String
            Dim idPac As String
            Dim fechaTerapia As Date = Convert.ToDateTime(tbFechaTerapia.Text.Trim)
            'averiguamos el idpaciente
            pc = fila.Cells(1).Value
            Dim queryIdPac = (From p In pac Where p.NombrePaciente = pc.Trim Select p.IdPaciente)
            idPac = queryIdPac.FirstOrDefault
            'validamos la asistencia
            Dim query = (From asis In asistentes Where asis.IdTerapia = tbIdTerapia.Text.Trim And asis.IdPaciente = idPac And asis.FechaTerapia = fechaTerapia _
                         Select asis).FirstOrDefault
            If fila.Cells("ckh").Value = True Then
                query.Asistencia = "ASISTE"
            ElseIf fila.Cells("ckh").Value = False Then
                query.Asistencia = "NO ASISTE"
            End If
        Next

        Try
            bdAlej.SaveChanges()
            MessageBox.Show("Terapia validada con éxito")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Me.Close()
       
    End Sub

    
    Private Sub formAsistentesTerapia_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        dgvAsistentes.DataSource = Nothing
        dgvAsistentes.Columns.Remove("ckh")
    End Sub
End Class