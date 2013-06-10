Imports System.Data.Objects
Imports System.Data.Objects.DataClasses
Imports Microsoft.Office.Interop

Public Class formHerramientas
    Private WithEvents ApExcel As Excel.Application
    Private WithEvents LibroExcel As Excel.Workbook
    Private WithEvents HojaExcel As Excel.Worksheet
    Private Sub btTecnicos_Click(sender As System.Object, e As System.EventArgs) Handles btTecnicos.Click

        bdAlej = New bdAlejandriaCTAEntities1
        Dim tecs As ObjectSet(Of TECNICOS) = bdAlej.TECNICOS
        Dim query = (From t In tecs Select New With {t.NombreTecnico})

        For Each d In query
            formGestionTecnicos.cbxSeleccionarTecnico.Items.Add(d.NombreTecnico)
        Next

        formGestionTecnicos.Show()
        Me.Close()

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        bdAlej = New bdAlejandriaCTAEntities1
        Dim tecs As ObjectSet(Of TECNICOS) = bdAlej.TECNICOS
        Dim query = (From t In tecs Where t.Profesion <> "INVITADO" Select New With {t.NombreTecnico})

        For Each d In query
            formSeguimientoCitas.cbxTecnico.Items.Add(d.NombreTecnico)
        Next
        formSeguimientoCitas.cbxTecnico.Items.Add("Todos")

        formSeguimientoCitas.Show()
        Me.Close()
    End Sub


    Private Sub btSegTerapias_Click(sender As System.Object, e As System.EventArgs) Handles btSegTerapias.Click

        formSeguimientoTerapias.cbxGruposTerapia.Items.Clear()
        Dim terapias As ObjectSet(Of TERAPIAS) = bdAlej.TERAPIAS
        Dim query = (From terap In terapias Select New With {terap.NombreTerapia})
        For Each x In query
            formSeguimientoTerapias.cbxGruposTerapia.Items.Add(x.NombreTerapia.Trim)
        Next
        formSeguimientoTerapias.cbxGruposTerapia.Items.Add("Todos los grupos")
        formSeguimientoTerapias.Show()
        Me.Close()
    End Sub

    Private Sub btConsultaSitLaboral_Click(sender As System.Object, e As System.EventArgs) Handles btConsultaSitLaboral.Click

        formConsultasVarias.Text = "Comparativa Situaciones Laborales"
        formConsultasVarias.lbPrimerGbx.Text = "Situación Laboral al inicio del Tratamiento"
        formConsultasVarias.lbSegundoGbx.Text = "Situación Laboral Actual"
        formConsultasVarias.Show()
        Me.Close()
    End Sub

    Private Sub btAdmisionesAltas_Click(sender As System.Object, e As System.EventArgs) Handles btAdmisionesAltas.Click

        formConsultasVarias.Text = "Control de Admisiones y Readmisiones"
        formConsultasVarias.lbPrimerGbx.Text = "Admisiones a Tratamiento"
        formConsultasVarias.lbSegundoGbx.Text = "Altas/Abandono de Tratamiento"
        formConsultasVarias.rbTodos.Visible = False
        formConsultasVarias.btExcel.Enabled = True
        formConsultasVarias.Show()
        Me.Close()
    End Sub

    Private Sub btAvisos_Click(sender As System.Object, e As System.EventArgs) Handles btAvisos.Click
        formContraseña.Avisos()
        Me.Close()
    End Sub

  
    Private Sub btInsertarCodFact_Click(sender As System.Object, e As System.EventArgs) Handles btInsertarCodFact.Click
        formCodFac.Text = "Insertar Código de Facturación"
        formCodFac.Show()
        Me.Close()
    End Sub

    Private Sub btEliminarTerapia_Click(sender As System.Object, e As System.EventArgs) Handles btEliminarTerapia.Click
        formEliminarTerapia.cbxGruposTerapia.Items.Clear()
        Dim terapias As ObjectSet(Of TERAPIAS) = bdAlej.TERAPIAS
        Dim query = (From terap In terapias Select New With {terap.NombreTerapia})
        For Each x In query
            formEliminarTerapia.cbxGruposTerapia.Items.Add(x.NombreTerapia.Trim)
        Next
        formEliminarTerapia.Show()
        Me.Close()
    End Sub

    Private Sub btAboutMe_Click(sender As System.Object, e As System.EventArgs) Handles btAboutMe.Click
        formAboutMe.ShowDialog()
    End Sub

    Private Sub btListadoPacientes_Click(sender As System.Object, e As System.EventArgs) Handles btListadoPacientes.Click

        Dim hist As ObjectSet(Of HISTORIA) = bdAlej.HISTORIA
        Dim pac As ObjectSet(Of PACIENTES) = bdAlej.PACIENTES

        Dim query = (From h In hist Join p In pac On h.IdPaciente Equals p.IdPaciente Select p, h)

        '---------------------GENERANDO EXCEL----------------------------------
        'crear hoja de calculo
        ApExcel = New Excel.Application
        ApExcel.Visible = True
        LibroExcel = ApExcel.Workbooks.Add
        HojaExcel = CType(LibroExcel.Sheets(1), Excel.Worksheet)
        Dim rango As Excel.Range

        'fila en la que empezaremos a escribir
        Dim f As Integer = 3

        'Titulos de columna
        HojaExcel.Cells(2, 1) = "Nombre Paciente"
        rango = CType(HojaExcel.Cells(2, 1), Excel.Range)
        rango.EntireRow.Font.Bold = True
        HojaExcel.Cells(2, 2) = "DNI"
        rango = CType(HojaExcel.Cells(2, 2), Excel.Range)
        rango.EntireRow.Font.Bold = True
        HojaExcel.Cells(2, 3) = "Sexo"
        rango = CType(HojaExcel.Cells(2, 3), Excel.Range)
        rango.EntireRow.Font.Bold = True
        HojaExcel.Cells(2, 4) = "Estado Civil"
        rango = CType(HojaExcel.Cells(2, 4), Excel.Range)
        rango.EntireRow.Font.Bold = True
        HojaExcel.Cells(2, 5) = "Dirección"
        rango = CType(HojaExcel.Cells(2, 5), Excel.Range)
        rango.EntireRow.Font.Bold = True
        HojaExcel.Cells(2, 6) = "CP"
        rango = CType(HojaExcel.Cells(2, 6), Excel.Range)
        rango.EntireRow.Font.Bold = True
        HojaExcel.Cells(2, 7) = "Localidad"
        rango = CType(HojaExcel.Cells(2, 7), Excel.Range)
        rango.EntireRow.Font.Bold = True
        HojaExcel.Cells(2, 8) = "Provincia"
        rango = CType(HojaExcel.Cells(2, 8), Excel.Range)
        rango.EntireRow.Font.Bold = True
        HojaExcel.Cells(2, 9) = "Teléfono"
        rango = CType(HojaExcel.Cells(2, 9), Excel.Range)
        rango.EntireRow.Font.Bold = True
        HojaExcel.Cells(2, 10) = "Teléfono Móvil"
        rango = CType(HojaExcel.Cells(2, 10), Excel.Range)
        rango.EntireRow.Font.Bold = True
        HojaExcel.Cells(2, 11) = "Mail"
        rango = CType(HojaExcel.Cells(2, 11), Excel.Range)
        rango.EntireRow.Font.Bold = True
        HojaExcel.Cells(2, 12) = "Demanda Inicial al Tratamiento"
        rango = CType(HojaExcel.Cells(2, 12), Excel.Range)
        rango.EntireRow.Font.Bold = True
        HojaExcel.Cells(2, 13) = "Tratamiento Anterior"
        rango = CType(HojaExcel.Cells(2, 13), Excel.Range)
        rango.EntireRow.Font.Bold = True
        HojaExcel.Cells(2, 14) = "Tratamiento Actual al Inicio del TTº"
        rango = CType(HojaExcel.Cells(2, 14), Excel.Range)
        rango.EntireRow.Font.Bold = True

        'datos
        For Each x In query
            HojaExcel.Cells(f, 1) = x.p.NombrePaciente
            HojaExcel.Cells(f, 2) = x.p.DNI
            HojaExcel.Cells(f, 3) = x.p.Sexo
            HojaExcel.Cells(f, 4) = x.p.EstadoCivil
            HojaExcel.Cells(f, 5) = x.p.Direccion
            HojaExcel.Cells(f, 6) = x.p.CP
            HojaExcel.Cells(f, 7) = x.p.Localidad
            HojaExcel.Cells(f, 8) = x.p.Provincia
            HojaExcel.Cells(f, 9) = x.p.Telefono
            HojaExcel.Cells(f, 10) = x.p.Movil
            HojaExcel.Cells(f, 11) = x.p.Mail
            HojaExcel.Cells(f, 12) = x.h.DemandaIncialTTo
            HojaExcel.Cells(f, 13) = x.h.TToAnterior
            HojaExcel.Cells(f, 14) = x.h.TToActual
            f += 1
        Next


        ApExcel = Nothing
    End Sub

    Private Sub formHerramientas_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If (Not ApExcel Is Nothing) Then
            ApExcel.Quit()
            ApExcel = Nothing
        End If
    End Sub

    Private Sub btExportarAgenda_Click(sender As System.Object, e As System.EventArgs) Handles btExportarAgenda.Click
        Dim tecs As ObjectSet(Of TECNICOS) = bdAlej.TECNICOS
        Dim query = (From t In tecs Where t.Profesion <> "INVITADO" Select New With {t.NombreTecnico})

        For Each d In query
            formSeleccionTecnico.cbxTecnicos.Items.Add(d.NombreTecnico)
        Next

        formSeleccionTecnico.Show()
        Me.Close()
    End Sub

    Private Sub btCodigosFacturacion_Click(sender As System.Object, e As System.EventArgs) Handles btCodigosFacturacion.Click
        Dim codsFacs As ObjectSet(Of CODIGOS_FACTURACION) = bdAlej.CODIGOS_FACTURACION
        Dim consultadoCodigos = (From cf In codsFacs Select cf)
        For Each x In consultadoCodigos
            formCodigosFacturacion.cbxCodigo.Items.Add(x.Codigo)
        Next

        formCodigosFacturacion.Show()
        Me.Close()
    End Sub

   
End Class