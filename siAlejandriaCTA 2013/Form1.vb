Imports System.Data.Objects
Imports System.Data.Objects.DataClasses

Public Class Form1

    Private Sub btAcceso_Click(sender As System.Object, e As System.EventArgs) Handles btAcceso.Click
        formContraseña.ShowDialog()
        formContraseña.tbUsuario.Focus()
    End Sub

    Private Sub btAltaPaciente_Click(sender As System.Object, e As System.EventArgs) Handles btAltaPaciente.Click
        formFichaPaciente.Show()
        formFichaPaciente.Text = "Nuevo paciente"
        formFichaPaciente.tbHistoria.ReadOnly = False
        formFichaPaciente.tbCodFac.ReadOnly = False
        formFichaPaciente.btHistPs.Visible = False
        formFichaPaciente.btHsMedica.Visible = False
        formFichaPaciente.btHsSocial.Visible = False
        formFichaPaciente.btAltaTerapeutica.Visible = False
        formFichaPaciente.btRegistrarAlta.Visible = True
        formFichaPaciente.btRegistrarAlta.Location = New Point(752, 429)
        formFichaPaciente.gbxDatosFactur.Enabled = False
        'quitamos la vista de la facturacion
        formFichaPaciente.tbCodFac.Visible = False
        formFichaPaciente.Label2.Visible = False
        formFichaPaciente.dgvFac.Visible = False
        formFichaPaciente.lbCodigo.Visible = False
        formFichaPaciente.lbCantidad.Visible = False
        formFichaPaciente.lbPagosAlDia.Visible = False
        formFichaPaciente.cbxCodigo.Visible = False
        formFichaPaciente.tbCantidad.Visible = False
        formFichaPaciente.cbxPagosAlDia.Visible = False
        formFichaPaciente.btActualizarFac.Visible = False
        formFichaPaciente.gbxDatosFactur.Text = "No accesible"
    End Sub

    Private Sub btBusqueda_Click(sender As System.Object, e As System.EventArgs) Handles btBusqueda.Click
        formBusqueda.Show()
    End Sub

    Private Sub btEstadisticas_Click(sender As System.Object, e As System.EventArgs) Handles btEstadisticas.Click

        Dim tecs As ObjectSet(Of TECNICOS) = bdAlej.TECNICOS
        Dim query = (From t In tecs Where t.Profesion <> "INVITADO" Select New With {t.NombreTecnico})

        For Each d In query
            formAgenda.cbxTecnico.Items.Add(d.NombreTecnico)
        Next

        formAgenda.Show()

    End Sub

    Private Sub btHerramientas_Click(sender As System.Object, e As System.EventArgs) Handles btHerramientas.Click
        'compruebo el nivel de acceso del usuario
        Dim nivelTecnico As Integer
        Dim usu As ObjectSet(Of USUGES) = bdAlej.USUGES
        Dim consultaNivel = (From tec In usu Where tec.NombreUsuGes = nombreUsuarioActivo.Trim Select New With {tec.Nivel})
        For Each r In consultaNivel
            nivelTecnico = r.Nivel
        Next

        If nivelTecnico = 2 Then
            formHerramientas.btAvisos.Enabled = False
            formHerramientas.btConsultaSitLaboral.Enabled = False
            formHerramientas.btSegTerapias.Enabled = False
            formHerramientas.btTecnicos.Enabled = False
            formHerramientas.btInsertarCodFact.Enabled = False
            formHerramientas.btEliminarTerapia.Enabled = False
            formHerramientas.btExportarAgenda.Enabled = False
            formHerramientas.btListadoPacientes.Enabled = False
        ElseIf nivelTecnico = 3 Then
            formHerramientas.btTecnicos.Enabled = True
            formHerramientas.btInsertarCodFact.Enabled = True
            formHerramientas.btCodigosFacturacion.Enabled = True
        End If

        formHerramientas.Show()
    End Sub

    Private Sub btGruposTerap_Click(sender As System.Object, e As System.EventArgs) Handles btGruposTerap.Click
        formGruposTerapia.Show()
    End Sub

    Private Sub btSalir_Click(sender As System.Object, e As System.EventArgs) Handles btSalir.Click
        btSalir.Visible = False
        btAltaPaciente.Visible = False
        btBusqueda.Visible = False
        btEstadisticas.Visible = False
        btHerramientas.Visible = False
        btGruposTerap.Visible = False
        btAcceso.Visible = True
        nombreUsuarioActivo = ""
    End Sub

    Private Sub Form1_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        nombreUsuarioActivo = ""
    End Sub

    Private Sub timerHora_Tick(sender As System.Object, e As System.EventArgs) Handles timerHora.Tick
        lbHora.Text = DateTime.Now.ToString("HH:mm:ss")
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lbFecha.Text = DateTime.Today.ToString("dd/MMMM/yyyy")
    End Sub
End Class
