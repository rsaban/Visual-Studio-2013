Imports System.Data.Objects
Imports System.Data.Objects.DataClasses
Imports Microsoft.Office.Interop

Public Class formConsultasVarias
    Private WithEvents ApExcel As Excel.Application
    Private WithEvents LibroExcel As Excel.Workbook
    Private WithEvents HojaExcel As Excel.Worksheet
    Private Sub btVer_Click(sender As System.Object, e As System.EventArgs) Handles btVer.Click
        Dim hs As ObjectSet(Of HISTORIA) = bdAlej.HISTORIA
        Dim hSoc As ObjectSet(Of HISTORIA_SOCIAL) = bdAlej.HISTORIA_SOCIAL
        Dim pac As ObjectSet(Of PACIENTES) = bdAlej.PACIENTES
        Dim alt As ObjectSet(Of ALTA) = bdAlej.ALTA
        Dim ing As ObjectSet(Of INGRESO) = bdAlej.INGRESO

        If Me.Text = "Comparativa Situaciones Laborales" Then
            If rbHistoria.Checked Then
                Dim query = (From hsc In hSoc Where hsc.IdHistoria = tbHistoria.Text.Trim Select New With {hsc.SitLabActual})
                Dim query2 = (From p In pac Join h In hs On p.IdPaciente Equals h.IdPaciente Where h.IdHistoria = tbHistoria.Text.Trim _
                              Select New With {p.SitLabInicioTTo})
                dgvConsulta1.DataSource = query2
                dgvConsulta2.DataSource = query

            ElseIf rbTodos.Checked Then
                Dim query = (From hsc In hSoc Order By hsc.IdHistoria Select New With {hsc.SitLabActual, hsc.IdHistoria})
                Dim query2 = (From p In pac Join h In hs On p.IdPaciente Equals h.IdPaciente Order By h.IdHistoria _
                              Select New With {h.IdHistoria, p.SitLabInicioTTo})
                dgvConsulta1.DataSource = query2
                dgvConsulta2.DataSource = query

            End If

        ElseIf Me.Text = "Control de Admisiones y Readmisiones" Then
            Dim query3 = (From a In alt Order By a.FechaAlta Ascending Where a.IdHistoria = tbHistoria.Text.Trim Select New With {a.FechaAlta, a.MotivoAlta})
            Dim query4 = (From i In ing Order By i.FechaAdmisionTTo Ascending Where i.IdHistoria = tbHistoria.Text.Trim Select New With {i.FechaAdmisionTTo})
            dgvConsulta1.DataSource = query4
            dgvConsulta2.DataSource = query3

        End If


    End Sub

    Private Sub rbTodos_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbTodos.CheckedChanged
        If rbTodos.Checked = True Then
            btExcel.Enabled = True
            tbHistoria.ReadOnly = True
            tbHistoria.Text = ""
        End If
    End Sub

    Private Sub rbHistoria_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbHistoria.CheckedChanged
        If rbHistoria.Checked = True Then
            btExcel.Enabled = False
            tbHistoria.ReadOnly = False
        End If
    End Sub

    Private Sub btExcel_Click(sender As System.Object, e As System.EventArgs) Handles btExcel.Click

        If Me.Text = "Comparativa Situaciones Laborales" Then
            '---------------------GENERANDO EXCEL----------------------------------
            'crear hoja de calculo
            ApExcel = New Excel.Application
            ApExcel.Visible = True
            LibroExcel = ApExcel.Workbooks.Add
            HojaExcel = CType(LibroExcel.Sheets(1), Excel.Worksheet)
            Dim rango As Excel.Range

            'fila en la que empezaremos a escribir
            Dim f As Integer = 3
            Dim g As Integer = 3

            'Título del documento(en la primera fila)
            HojaExcel.Cells(1, 1) = "Comparativa de Situaciones Labores"
            rango = CType(HojaExcel.Cells(1, 1), Excel.Range)
            rango.EntireRow.Font.Bold = True
            rango.EntireRow.Font.Underline = True

            'Titulos de columna
            HojaExcel.Cells(2, 1) = "Nº Historia"
            rango = CType(HojaExcel.Cells(2, 1), Excel.Range)
            rango.EntireRow.Font.Bold = True
            HojaExcel.Cells(2, 2) = "Situacion Laboral Inicio TTº"
            rango = CType(HojaExcel.Cells(2, 2), Excel.Range)
            rango.EntireRow.Font.Bold = True
            HojaExcel.Cells(2, 3) = "Nº Historia"
            rango = CType(HojaExcel.Cells(2, 3), Excel.Range)
            rango.EntireRow.Font.Bold = True
            HojaExcel.Cells(2, 4) = "Situacion Laboral Actual"
            rango = CType(HojaExcel.Cells(2, 4), Excel.Range)
            rango.EntireRow.Font.Bold = True

            For Each fila As DataGridViewRow In dgvConsulta1.Rows
                HojaExcel.Cells(f, 1) = fila.Cells(0).Value.ToString
                If String.IsNullOrWhiteSpace(fila.Cells(1).Value) Then
                    HojaExcel.Cells(f, 2) = ""
                Else
                    HojaExcel.Cells(f, 2) = fila.Cells(1).Value.ToString
                End If
                f += 1
            Next
            For Each fila2 As DataGridViewRow In dgvConsulta2.Rows
                HojaExcel.Cells(g, 3) = fila2.Cells(1).Value.ToString
                If String.IsNullOrWhiteSpace(fila2.Cells(0).Value) Then
                    HojaExcel.Cells(g, 4) = ""
                Else
                    HojaExcel.Cells(g, 4) = fila2.Cells(0).Value.ToString
                End If
                g += 1
            Next
            ApExcel = Nothing

        ElseIf Me.Text = "Control de Admisiones y Readmisiones" Then
            'crear hoja de calculo
            ApExcel = New Excel.Application
            ApExcel.Visible = True
            LibroExcel = ApExcel.Workbooks.Add
            HojaExcel = CType(LibroExcel.Sheets(1), Excel.Worksheet)
            Dim rango As Excel.Range

            'fila en la que empezaremos a escribir
            Dim f As Integer = 3
            Dim g As Integer = 3

            'Título del documento(en la primera fila)
            HojaExcel.Cells(1, 1) = "Control de Admisiones y Readmisiones"
            rango = CType(HojaExcel.Cells(1, 1), Excel.Range)
            rango.EntireRow.Font.Bold = True
            rango.EntireRow.Font.Underline = True

            'Titulos de columna
            HojaExcel.Cells(2, 1) = "Fecha de Admisión a TTº"
            rango = CType(HojaExcel.Cells(2, 1), Excel.Range)
            rango.EntireRow.Font.Bold = True
            HojaExcel.Cells(2, 2) = "Fecha de Baja del TTº"
            rango = CType(HojaExcel.Cells(2, 2), Excel.Range)
            rango.EntireRow.Font.Bold = True
            HojaExcel.Cells(2, 3) = "Motivo de la Baja"
            rango = CType(HojaExcel.Cells(2, 3), Excel.Range)
            rango.EntireRow.Font.Bold = True
            

            For Each fila As DataGridViewRow In dgvConsulta1.Rows
                HojaExcel.Cells(f, 1) = Convert.ToDateTime(fila.Cells(0).Value)
                f += 1
            Next
            For Each fila2 As DataGridViewRow In dgvConsulta2.Rows
                HojaExcel.Cells(g, 2) = Convert.ToDateTime(fila2.Cells(0).Value)
                HojaExcel.Cells(g, 3) = fila2.Cells(1).Value.ToString
                g += 1
            Next
            ApExcel = Nothing
        End If

    End Sub

    Private Sub formConsultasVarias_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        tbHistoria.Text = ""
        dgvConsulta1.DataSource = Nothing
        dgvConsulta2.DataSource = Nothing

        If (Not ApExcel Is Nothing) Then
            ApExcel.Quit()
            ApExcel = Nothing
        End If
    End Sub
End Class