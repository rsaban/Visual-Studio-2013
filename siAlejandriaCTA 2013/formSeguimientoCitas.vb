Imports System.Data.Objects
Imports System.Data.Objects.DataClasses
Imports Microsoft.Office.Interop

Public Class formSeguimientoCitas
    Private WithEvents ApExcel As Excel.Application
    Private WithEvents LibroExcel As Excel.Workbook
    Private WithEvents HojaExcel As Excel.Worksheet
    Private Sub btVer_Click(sender As System.Object, e As System.EventArgs) Handles btVer.Click

        Dim citas As ObjectSet(Of CITAS) = bdAlej.CITAS
        Dim tecnico As ObjectSet(Of TECNICOS) = bdAlej.TECNICOS

        If cbxTecnico.Text = "Todos" Then
            Dim query = (From cit In citas Join tec In tecnico On cit.IdTecnico Equals tec.IdTecnico Order By tec.NombreTecnico _
                         Where cit.IdPaciente = "PAC" & tbHistoria.Text.Trim _
                         Select New With {tec.NombreTecnico, cit.FechaCita, cit.HoraCita, cit.Asistencia})
            dgvCitas.DataSource = query
        Else
            'buscamos el tecnico que se ha seleccionado
            Dim tecnicoElegido As Integer
            ' Dim tecnico As ObjectSet(Of TECNICOS) = bdAlej.TECNICOS
            Dim query = (From tec In tecnico Where tec.NombreTecnico.Trim = cbxTecnico.Text.Trim Select New With {tec.IdTecnico})
            For Each x In query
                tecnicoElegido = x.IdTecnico
            Next

            Dim query2 = (From cit In citas Where cit.IdTecnico = tecnicoElegido And cit.IdPaciente = "PAC" & tbHistoria.Text.Trim Select New With {cit.FechaCita, cit.HoraCita, cit.Asistencia})

            dgvCitas.DataSource = query2
        End If
    End Sub

    Private Sub btExcel_Click(sender As System.Object, e As System.EventArgs) Handles btExcel.Click
        Dim nombrePac As String
        '------------CONSULTA PARA OBTENER EL NOMBRE DEL PACIENTE--------------
        If String.IsNullOrWhiteSpace(tbHistoria.Text) Then
            MsgBox("Complete el número de historia")
            Exit Sub
        Else
            Dim hs As ObjectSet(Of HISTORIA) = bdAlej.HISTORIA
            Dim pc As ObjectSet(Of PACIENTES) = bdAlej.PACIENTES
            Dim query = (From h In hs Join p In pc On h.IdPaciente Equals p.IdPaciente Where h.IdHistoria = tbHistoria.Text.Trim Select p.NombrePaciente)
            nombrePac = query.FirstOrDefault.ToString
        End If
        '---------------------GENERANDO EXCEL----------------------------------
        'crear hoja de calculo
        ApExcel = New Excel.Application
        ApExcel.Visible = True
        LibroExcel = ApExcel.Workbooks.Add
        HojaExcel = CType(LibroExcel.Sheets(1), Excel.Worksheet)
        Dim rango As Excel.Range

        'fila en la que empezaremos a escribir
        Dim f As Integer = 3

        ' Nombre del paciente (en la primera fila)
        HojaExcel.Cells(1, 1) = "Seguimiento de Citas de: " & nombrePac
        rango = CType(HojaExcel.Cells(1, 1), Excel.Range)
        rango.EntireRow.Font.Bold = True

        'Titulos de columna
        If dgvCitas.Columns.Count = 3 Then
            HojaExcel.Cells(2, 1) = "Fecha"
            rango = CType(HojaExcel.Cells(2, 1), Excel.Range)
            rango.EntireRow.Font.Bold = True
            HojaExcel.Cells(2, 2) = "Hora"
            rango = CType(HojaExcel.Cells(2, 2), Excel.Range)
            rango.EntireRow.Font.Bold = True
            HojaExcel.Cells(2, 3) = "Asistencia"
            rango = CType(HojaExcel.Cells(2, 3), Excel.Range)
            rango.EntireRow.Font.Bold = True
        ElseIf dgvCitas.Columns.Count = 4 Then
            HojaExcel.Cells(2, 1) = "Técnico"
            rango = CType(HojaExcel.Cells(2, 1), Excel.Range)
            rango.EntireRow.Font.Bold = True
            HojaExcel.Cells(2, 2) = "Fecha"
            rango = CType(HojaExcel.Cells(2, 2), Excel.Range)
            rango.EntireRow.Font.Bold = True
            HojaExcel.Cells(2, 3) = "Hora"
            rango = CType(HojaExcel.Cells(2, 3), Excel.Range)
            rango.EntireRow.Font.Bold = True
            HojaExcel.Cells(2, 4) = "Asistencia"
            rango = CType(HojaExcel.Cells(2, 4), Excel.Range)
            rango.EntireRow.Font.Bold = True
        End If

        'datos
        For Each fila As DataGridViewRow In dgvCitas.Rows
            If dgvCitas.Columns.Count = 3 Then
                HojaExcel.Cells(f, 1) = Convert.ToDateTime(fila.Cells(0).Value).ToShortDateString
                HojaExcel.Cells(f, 2) = fila.Cells(1).Value.ToString
                HojaExcel.Cells(f, 3) = fila.Cells(2).Value.ToString
                f += 1
            ElseIf dgvCitas.Columns.Count = 4 Then
                HojaExcel.Cells(f, 1) = fila.Cells(0).Value.ToString
                HojaExcel.Cells(f, 2) = Convert.ToDateTime(fila.Cells(1).Value).ToShortDateString
                HojaExcel.Cells(f, 3) = fila.Cells(2).Value.ToString
                HojaExcel.Cells(f, 4) = fila.Cells(3).Value.ToString
                f += 1
            End If
        Next

        'ApExcel.Quit()
        ApExcel = Nothing
    End Sub

    Private Sub formSeguimientoCitas_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        tbHistoria.Text = ""
        cbxTecnico.Text = ""
        cbxTecnico.Items.Clear()
        dgvCitas.DataSource = Nothing

        If (Not ApExcel Is Nothing) Then
            ApExcel.Quit()
            ApExcel = Nothing
        End If
    End Sub
End Class
