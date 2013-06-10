Imports System.Data.Objects
Imports System.Data.Objects.DataClasses
Imports Microsoft.Office.Interop


Public Class formCitasNoPacientes
    Private WithEvents ApExcel As Excel.Application
    Private WithEvents LibroExcel As Excel.Workbook
    Private WithEvents HojaExcel As Excel.Worksheet

    Private Sub btNuevaCita_Click(sender As System.Object, e As System.EventArgs) Handles btNuevaCita.Click
        Dim tecnico As ObjectSet(Of TECNICOS) = bdAlej.TECNICOS
        Dim query = (From tec In tecnico Where tec.Profesion <> "INVITADO" Select New With {tec.NombreTecnico})
        For Each x In query
            formAgregarCitaNoPaciente.cbxTecnico.Items.Add(x.NombreTecnico)
        Next

        formAgregarCitaNoPaciente.ShowDialog()
        Me.Close()
    End Sub

    Private Sub btLimpiar_Click(sender As System.Object, e As System.EventArgs) Handles btLimpiar.Click

        Dim caption As String = "Atención"
        If (MessageBox.Show("Esto borrará la tabla y exportará los datos, ¿desea continuar?", caption, MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes) Then

            Dim desc As ObjectSet(Of DESCONECTADA) = bdAlej.DESCONECTADA

            Dim query = (From d In desc Select d)

            '---------------------GENERANDO EXCEL----------------------------------
            'crear hoja de calculo
            ApExcel = New Excel.Application
            ApExcel.Visible = True
            LibroExcel = ApExcel.Workbooks.Add
            HojaExcel = CType(LibroExcel.Sheets(1), Excel.Worksheet)
            Dim rango As Excel.Range

            ' Nombre documento (en la primera fila)
            HojaExcel.Cells(1, 1) = "Citas Externas (no pacientes)"
            rango = CType(HojaExcel.Cells(1, 1), Excel.Range)
            rango.EntireRow.Font.Bold = True

            'fila en la que empezaremos a escribir
            Dim f As Integer = 3

            'Titulos de columna
            HojaExcel.Cells(2, 1) = "Nombre de la Cita"
            rango = CType(HojaExcel.Cells(2, 1), Excel.Range)
            rango.EntireRow.Font.Bold = True
            HojaExcel.Cells(2, 2) = "Técnico"
            rango = CType(HojaExcel.Cells(2, 2), Excel.Range)
            rango.EntireRow.Font.Bold = True
            HojaExcel.Cells(2, 3) = "Fecha"
            rango = CType(HojaExcel.Cells(2, 3), Excel.Range)
            rango.EntireRow.Font.Bold = True
            HojaExcel.Cells(2, 4) = "Hora"
            rango = CType(HojaExcel.Cells(2, 4), Excel.Range)
            rango.EntireRow.Font.Bold = True


            'datos
            For Each x In query
                HojaExcel.Cells(f, 1) = x.Nombre_Cita
                HojaExcel.Cells(f, 2) = x.Tecnico_Cita
                HojaExcel.Cells(f, 3) = x.Fecha_Cita
                HojaExcel.Cells(f, 4) = x.Hora_Cita
                f += 1
            Next
            ApExcel = Nothing

            MsgBox("Exportación completada")

            'una vez exportados los datos, eliminamos los registros
            For Each y In query
                bdAlej.DESCONECTADA.DeleteObject(y)
            Next
            Try
                bdAlej.SaveChanges()
                MsgBox("Limpiado completo")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            Me.Close()
        Else
            Exit Sub
        End If

    End Sub

    Private Sub formCitasNoPacientes_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If (Not ApExcel Is Nothing) Then
            ApExcel.Quit()
            ApExcel = Nothing
        End If
    End Sub
End Class