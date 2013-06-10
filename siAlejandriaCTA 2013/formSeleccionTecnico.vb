Imports System.Data.Objects
Imports System.Data.Objects.DataClasses
Imports Microsoft.Office.Interop


Public Class formSeleccionTecnico
    Private WithEvents ApExcel As Excel.Application
    Private WithEvents LibroExcel As Excel.Workbook
    Private WithEvents HojaExcel As Excel.Worksheet

    Private Sub btExportar_Click(sender As System.Object, e As System.EventArgs) Handles btExportar.Click

        Dim tec As ObjectSet(Of TECNICOS) = bdAlej.TECNICOS
        Dim cit As ObjectSet(Of CITAS) = bdAlej.CITAS
        Dim pac As ObjectSet(Of PACIENTES) = bdAlej.PACIENTES
        Dim terap As ObjectSet(Of TERAPIAS) = bdAlej.TERAPIAS
        Dim asisTerap As ObjectSet(Of ASISTENTES_TERAPIA) = bdAlej.ASISTENTES_TERAPIA

        Dim query = (From c In cit Join t In tec On c.IdTecnico Equals t.IdTecnico Join p In pac On c.IdPaciente Equals p.IdPaciente _
                     Order By c.FechaCita Ascending Where t.NombreTecnico = cbxTecnicos.Text.Trim Select c, p)

        '---------------------GENERANDO EXCEL----------------------------------
        'crear hoja de calculo
        ApExcel = New Excel.Application
        ApExcel.Visible = True
        LibroExcel = ApExcel.Workbooks.Add
        HojaExcel = CType(LibroExcel.Sheets(1), Excel.Worksheet)
        HojaExcel.Name = "Agenda de Citas"
        Dim rango As Excel.Range

        ' Nombre del tecnico (en la primera fila)
        HojaExcel.Cells(1, 1) = "Agenda de citas de: " & cbxTecnicos.Text
        rango = CType(HojaExcel.Cells(1, 1), Excel.Range)
        rango.EntireRow.Font.Bold = True

        'fila en la que empezaremos a escribir
        Dim f As Integer = 4
        Dim g As Integer = 4

        'Titulos de columna
        HojaExcel.Cells(3, 1) = "Nombre Paciente"
        rango = CType(HojaExcel.Cells(3, 1), Excel.Range)
        rango.EntireRow.Font.Bold = True
        HojaExcel.Cells(3, 2) = "Fecha de Cita"
        rango = CType(HojaExcel.Cells(3, 2), Excel.Range)
        rango.EntireRow.Font.Bold = True
        HojaExcel.Cells(3, 3) = "Hora de cita"
        rango = CType(HojaExcel.Cells(3, 3), Excel.Range)
        rango.EntireRow.Font.Bold = True
        HojaExcel.Cells(3, 4) = "Asistencia"
        rango = CType(HojaExcel.Cells(2, 4), Excel.Range)
        rango.EntireRow.Font.Bold = True
        

        For Each x In query
            HojaExcel.Cells(f, 1) = x.p.NombrePaciente
            HojaExcel.Cells(f, 2) = x.c.FechaCita
            HojaExcel.Cells(f, 3) = x.c.HoraCita
            HojaExcel.Cells(f, 4) = x.c.Asistencia
            f += 1
        Next


        'ahora vamos a consultar las terapias. Esta forma, contempla solo una sesión por dia de la misma terapia.
        Dim query2 = (From t In terap Join aT In asisTerap On t.IdTerapia Equals aT.IdTerapia _
                      Join tc In tec On t.IdTecnico Equals tc.IdTecnico Order By aT.FechaTerapia Ascending _
                      Where t.IdTecnico = tc.IdTecnico Select t, tc, aT.HoraTerapia, aT.FechaTerapia Distinct)

        'creamos una nueva hoja
        HojaExcel = CType(LibroExcel.Sheets(2), Excel.Worksheet)
        HojaExcel.Name = "Agenda de Terapias"

        ' Nombre del tecnico (en la primera fila)
        HojaExcel.Cells(1, 1) = "Agenda de terapias de: " & cbxTecnicos.Text
        rango = CType(HojaExcel.Cells(1, 1), Excel.Range)
        rango.EntireRow.Font.Bold = True

        'Titulos de columna
        HojaExcel.Cells(3, 1) = "Nombre Terapia"
        rango = CType(HojaExcel.Cells(3, 1), Excel.Range)
        rango.EntireRow.Font.Bold = True
        HojaExcel.Cells(3, 2) = "Fecha Terapia"
        rango = CType(HojaExcel.Cells(3, 2), Excel.Range)
        rango.EntireRow.Font.Bold = True
        HojaExcel.Cells(3, 3) = "Hora Terapia"
        rango = CType(HojaExcel.Cells(3, 3), Excel.Range)
        rango.EntireRow.Font.Bold = True
        

        'datos
        For Each y In query2
            HojaExcel.Cells(g, 1) = y.t.NombreTerapia
            HojaExcel.Cells(g, 2) = y.FechaTerapia
            HojaExcel.Cells(g, 3) = y.HoraTerapia
            g += 1
        Next

        ApExcel = Nothing
        Me.Close()
    End Sub

    Private Sub formSeleccionTecnico_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If (Not ApExcel Is Nothing) Then
            ApExcel.Quit()
            ApExcel = Nothing
        End If
        cbxTecnicos.Items.Clear()
    End Sub
End Class