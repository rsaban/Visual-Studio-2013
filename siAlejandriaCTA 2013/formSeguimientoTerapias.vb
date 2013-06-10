Imports System.Data.Objects
Imports System.Data.Objects.DataClasses
Imports Microsoft.Office.Interop

Public Class formSeguimientoTerapias
    Private WithEvents ApExcel As Excel.Application
    Private WithEvents LibroExcel As Excel.Workbook
    Private WithEvents HojaExcel As Excel.Worksheet
    Private Sub btVer_Click(sender As System.Object, e As System.EventArgs) Handles btVer.Click

        Dim asissTerap As ObjectSet(Of ASISTENTES_TERAPIA) = bdAlej.ASISTENTES_TERAPIA
        Dim terap As ObjectSet(Of TERAPIAS) = bdAlej.TERAPIAS


        If cbxGruposTerapia.Text.Trim = "Todos los grupos" Then
            Dim query2 = (From asist In asissTerap Join t In terap On asist.IdTerapia Equals t.IdTerapia _
                        Order By asist.FechaTerapia Where asist.IdPaciente = "PAC" & tbHistoria.Text.Trim _
                         Select New With {t.NombreTerapia, asist.FechaTerapia, asist.Asistencia})
            dgvSegTerap.DataSource = query2
        Else
            Dim query = (From asist In asissTerap Join t In terap On asist.IdTerapia Equals t.IdTerapia _
                        Order By asist.FechaTerapia Where asist.IdPaciente = "PAC" & tbHistoria.Text.Trim And t.NombreTerapia = cbxGruposTerapia.Text.Trim _
                         Select New With {asist.FechaTerapia, asist.Asistencia})

            dgvSegTerap.DataSource = query
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
        HojaExcel.Cells(1, 1) = "Asistencia a Terapia de: " & nombrePac
        rango = CType(HojaExcel.Cells(1, 1), Excel.Range)
        rango.EntireRow.Font.Bold = True
        rango.EntireRow.Font.Underline = True

        'Titulos de columna
        If dgvSegTerap.Columns.Count = 2 Then
            HojaExcel.Cells(2, 1) = "Fecha"
            rango = CType(HojaExcel.Cells(2, 1), Excel.Range)
            rango.EntireRow.Font.Bold = True
            HojaExcel.Cells(2, 2) = "Asistencia"
            rango = CType(HojaExcel.Cells(2, 2), Excel.Range)
            rango.EntireRow.Font.Bold = True
        ElseIf dgvSegTerap.Columns.Count = 3 Then
            HojaExcel.Cells(2, 1) = "Nombre Terapia"
            rango = CType(HojaExcel.Cells(2, 1), Excel.Range)
            rango.EntireRow.Font.Bold = True
            HojaExcel.Cells(2, 2) = "Fecha"
            rango = CType(HojaExcel.Cells(2, 2), Excel.Range)
            rango.EntireRow.Font.Bold = True
            HojaExcel.Cells(2, 3) = "Asistencia"
            rango = CType(HojaExcel.Cells(2, 3), Excel.Range)
            rango.EntireRow.Font.Bold = True
        End If

        For Each fila As DataGridViewRow In dgvSegTerap.Rows
            If dgvSegTerap.Columns.Count = 2 Then
                HojaExcel.Cells(f, 1) = Convert.ToDateTime(fila.Cells(0).Value)
                If String.IsNullOrWhiteSpace(fila.Cells(1).Value) Then
                    HojaExcel.Cells(f, 2) = "Sin validar"
                Else
                    HojaExcel.Cells(f, 2) = fila.Cells(1).Value.ToString
                End If
                f += 1
            ElseIf dgvSegTerap.Columns.Count = 3 Then
                HojaExcel.Cells(f, 1) = fila.Cells(0).Value.ToString
                HojaExcel.Cells(f, 2) = Convert.ToDateTime(fila.Cells(1).Value)
                If String.IsNullOrWhiteSpace(fila.Cells(2).Value) Then
                    HojaExcel.Cells(f, 3) = "Sin validar"
                Else
                    HojaExcel.Cells(f, 3) = fila.Cells(2).Value.ToString
                End If
                f += 1
            End If
        Next

        ApExcel = Nothing

    End Sub

    Private Sub formSeguimientoTerapias_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        tbHistoria.Text = ""
        cbxGruposTerapia.Items.Clear()
        dgvSegTerap.DataSource = Nothing

        If (Not ApExcel Is Nothing) Then
            ApExcel.Quit()
            ApExcel = Nothing
        End If
    End Sub
End Class