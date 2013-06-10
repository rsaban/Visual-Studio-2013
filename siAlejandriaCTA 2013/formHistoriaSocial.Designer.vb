<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formHistoriaSocial
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formHistoriaSocial))
        Me.tabControl1 = New System.Windows.Forms.TabControl()
        Me.tpAntecedentes = New System.Windows.Forms.TabPage()
        Me.tbOtrasDrogas = New System.Windows.Forms.TextBox()
        Me.cbxOtrasDrogas = New System.Windows.Forms.ComboBox()
        Me.tbEdadInicioConsum = New System.Windows.Forms.TextBox()
        Me.cbxConsumPrincipal = New System.Windows.Forms.ComboBox()
        Me.cbxConsumo = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbDemandaPlanteada = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbConsumo = New System.Windows.Forms.Label()
        Me.tpConvivencia = New System.Windows.Forms.TabPage()
        Me.cbxSitEcon = New System.Windows.Forms.ComboBox()
        Me.lbEconomia = New System.Windows.Forms.Label()
        Me.cbxVivienda = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pbGenograma = New System.Windows.Forms.PictureBox()
        Me.cmsGenograma = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsReloadImagen = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerImagenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarImagenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsEliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbGenograma = New System.Windows.Forms.Label()
        Me.lbUC = New System.Windows.Forms.Label()
        Me.dgvUC = New System.Windows.Forms.DataGridView()
        Me.cmsUC = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsRecargarUC = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsActualizar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tpFyE = New System.Windows.Forms.TabPage()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbAnotaciones = New System.Windows.Forms.TextBox()
        Me.cbxSitLabAc = New System.Windows.Forms.ComboBox()
        Me.cbxSitLabIn = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbFormacionCompl = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbxFormacionReglada = New System.Windows.Forms.ComboBox()
        Me.lbFormacion = New System.Windows.Forms.Label()
        Me.tpEntorno = New System.Windows.Forms.TabPage()
        Me.tbOcio = New System.Windows.Forms.TextBox()
        Me.lbOcio = New System.Windows.Forms.Label()
        Me.tbEntornoSocial = New System.Windows.Forms.TextBox()
        Me.lbEntorno = New System.Windows.Forms.Label()
        Me.cbxSitJud = New System.Windows.Forms.ComboBox()
        Me.lbSitJud = New System.Windows.Forms.Label()
        Me.tpDiagnostico = New System.Windows.Forms.TabPage()
        Me.tbObservaciones = New System.Windows.Forms.TextBox()
        Me.lbObs = New System.Windows.Forms.Label()
        Me.tbDiagnostico = New System.Windows.Forms.TextBox()
        Me.lbDiagnostico = New System.Windows.Forms.Label()
        Me.btControlCitas = New System.Windows.Forms.Button()
        Me.btHsMedica = New System.Windows.Forms.Button()
        Me.btHsPs = New System.Windows.Forms.Button()
        Me.lbFechaUltCita = New System.Windows.Forms.Label()
        Me.tbUltimaCita = New System.Windows.Forms.TextBox()
        Me.cmsRecargarCita = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ReloadUltimaCItaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tbHistoria = New System.Windows.Forms.TextBox()
        Me.btActualizar = New System.Windows.Forms.Button()
        Me.ofdImagen = New System.Windows.Forms.OpenFileDialog()
        Me.cmsWord = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.GenerarExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportarHistoriaSocialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tabControl1.SuspendLayout()
        Me.tpAntecedentes.SuspendLayout()
        Me.tpConvivencia.SuspendLayout()
        CType(Me.pbGenograma, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsGenograma.SuspendLayout()
        CType(Me.dgvUC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsUC.SuspendLayout()
        Me.tpFyE.SuspendLayout()
        Me.tpEntorno.SuspendLayout()
        Me.tpDiagnostico.SuspendLayout()
        Me.cmsRecargarCita.SuspendLayout()
        Me.cmsWord.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabControl1
        '
        Me.tabControl1.Controls.Add(Me.tpAntecedentes)
        Me.tabControl1.Controls.Add(Me.tpConvivencia)
        Me.tabControl1.Controls.Add(Me.tpFyE)
        Me.tabControl1.Controls.Add(Me.tpEntorno)
        Me.tabControl1.Controls.Add(Me.tpDiagnostico)
        Me.tabControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.tabControl1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabControl1.Location = New System.Drawing.Point(0, 0)
        Me.tabControl1.Name = "tabControl1"
        Me.tabControl1.SelectedIndex = 0
        Me.tabControl1.Size = New System.Drawing.Size(588, 472)
        Me.tabControl1.TabIndex = 25
        '
        'tpAntecedentes
        '
        Me.tpAntecedentes.BackColor = System.Drawing.Color.Khaki
        Me.tpAntecedentes.Controls.Add(Me.tbOtrasDrogas)
        Me.tpAntecedentes.Controls.Add(Me.cbxOtrasDrogas)
        Me.tpAntecedentes.Controls.Add(Me.tbEdadInicioConsum)
        Me.tpAntecedentes.Controls.Add(Me.cbxConsumPrincipal)
        Me.tpAntecedentes.Controls.Add(Me.cbxConsumo)
        Me.tpAntecedentes.Controls.Add(Me.Label8)
        Me.tpAntecedentes.Controls.Add(Me.tbDemandaPlanteada)
        Me.tpAntecedentes.Controls.Add(Me.Label7)
        Me.tpAntecedentes.Controls.Add(Me.Label3)
        Me.tpAntecedentes.Controls.Add(Me.Label2)
        Me.tpAntecedentes.Controls.Add(Me.lbConsumo)
        Me.tpAntecedentes.Location = New System.Drawing.Point(4, 24)
        Me.tpAntecedentes.Name = "tpAntecedentes"
        Me.tpAntecedentes.Padding = New System.Windows.Forms.Padding(3)
        Me.tpAntecedentes.Size = New System.Drawing.Size(580, 444)
        Me.tpAntecedentes.TabIndex = 0
        Me.tpAntecedentes.Text = "Antecedentes"
        '
        'tbOtrasDrogas
        '
        Me.tbOtrasDrogas.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbOtrasDrogas.Location = New System.Drawing.Point(190, 284)
        Me.tbOtrasDrogas.Name = "tbOtrasDrogas"
        Me.tbOtrasDrogas.Size = New System.Drawing.Size(336, 23)
        Me.tbOtrasDrogas.TabIndex = 5
        '
        'cbxOtrasDrogas
        '
        Me.cbxOtrasDrogas.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cbxOtrasDrogas.FormattingEnabled = True
        Me.cbxOtrasDrogas.Items.AddRange(New Object() {"Sí", "No"})
        Me.cbxOtrasDrogas.Location = New System.Drawing.Point(127, 284)
        Me.cbxOtrasDrogas.Name = "cbxOtrasDrogas"
        Me.cbxOtrasDrogas.Size = New System.Drawing.Size(54, 23)
        Me.cbxOtrasDrogas.TabIndex = 4
        '
        'tbEdadInicioConsum
        '
        Me.tbEdadInicioConsum.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbEdadInicioConsum.Location = New System.Drawing.Point(127, 243)
        Me.tbEdadInicioConsum.Name = "tbEdadInicioConsum"
        Me.tbEdadInicioConsum.Size = New System.Drawing.Size(54, 23)
        Me.tbEdadInicioConsum.TabIndex = 3
        '
        'cbxConsumPrincipal
        '
        Me.cbxConsumPrincipal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cbxConsumPrincipal.FormattingEnabled = True
        Me.cbxConsumPrincipal.Items.AddRange(New Object() {"", "Alcohol", "Tabaco", "Cannabis", "Cocaína", "Heroina", "Benzodiacepinas", "Anfetaminas", "Drogas de síntesis", "Sustancias dopantes", "Fármacos", "Otros"})
        Me.cbxConsumPrincipal.Location = New System.Drawing.Point(127, 201)
        Me.cbxConsumPrincipal.Name = "cbxConsumPrincipal"
        Me.cbxConsumPrincipal.Size = New System.Drawing.Size(163, 23)
        Me.cbxConsumPrincipal.TabIndex = 2
        '
        'cbxConsumo
        '
        Me.cbxConsumo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cbxConsumo.FormattingEnabled = True
        Me.cbxConsumo.Items.AddRange(New Object() {"Sí", "No"})
        Me.cbxConsumo.Location = New System.Drawing.Point(127, 159)
        Me.cbxConsumo.Name = "cbxConsumo"
        Me.cbxConsumo.Size = New System.Drawing.Size(54, 23)
        Me.cbxConsumo.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 162)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(108, 15)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Consumo de Drogas:"
        '
        'tbDemandaPlanteada
        '
        Me.tbDemandaPlanteada.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbDemandaPlanteada.Location = New System.Drawing.Point(127, 29)
        Me.tbDemandaPlanteada.Multiline = True
        Me.tbDemandaPlanteada.Name = "tbDemandaPlanteada"
        Me.tbDemandaPlanteada.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbDemandaPlanteada.Size = New System.Drawing.Size(399, 104)
        Me.tbDemandaPlanteada.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 15)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Demanda Planteada:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 279)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 30)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Consumo de otras " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "drogas:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 239)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 30)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Edad de Inicio en " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "el consumo:"
        '
        'lbConsumo
        '
        Me.lbConsumo.AutoSize = True
        Me.lbConsumo.Location = New System.Drawing.Point(15, 201)
        Me.lbConsumo.Name = "lbConsumo"
        Me.lbConsumo.Size = New System.Drawing.Size(103, 15)
        Me.lbConsumo.TabIndex = 0
        Me.lbConsumo.Text = "Consumo Principal:"
        '
        'tpConvivencia
        '
        Me.tpConvivencia.BackColor = System.Drawing.Color.Khaki
        Me.tpConvivencia.Controls.Add(Me.cbxSitEcon)
        Me.tpConvivencia.Controls.Add(Me.lbEconomia)
        Me.tpConvivencia.Controls.Add(Me.cbxVivienda)
        Me.tpConvivencia.Controls.Add(Me.Label1)
        Me.tpConvivencia.Controls.Add(Me.pbGenograma)
        Me.tpConvivencia.Controls.Add(Me.lbGenograma)
        Me.tpConvivencia.Controls.Add(Me.lbUC)
        Me.tpConvivencia.Controls.Add(Me.dgvUC)
        Me.tpConvivencia.Location = New System.Drawing.Point(4, 24)
        Me.tpConvivencia.Name = "tpConvivencia"
        Me.tpConvivencia.Padding = New System.Windows.Forms.Padding(3)
        Me.tpConvivencia.Size = New System.Drawing.Size(580, 444)
        Me.tpConvivencia.TabIndex = 1
        Me.tpConvivencia.Text = "Situación Familiar"
        '
        'cbxSitEcon
        '
        Me.cbxSitEcon.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cbxSitEcon.DropDownWidth = 250
        Me.cbxSitEcon.FormattingEnabled = True
        Me.cbxSitEcon.Items.AddRange(New Object() {"", "Ingresos derivados del trabajo", "Ingresos derivados de Pensión", "Recibiendo ayudas / prestaciones sociales", "Aportaciones económicas de la familia", "Taller de empleo", "Caridad / Beneficencia", "No percibe ingresos económicos"})
        Me.cbxSitEcon.Location = New System.Drawing.Point(321, 327)
        Me.cbxSitEcon.Name = "cbxSitEcon"
        Me.cbxSitEcon.Size = New System.Drawing.Size(216, 23)
        Me.cbxSitEcon.TabIndex = 14
        '
        'lbEconomia
        '
        Me.lbEconomia.AutoSize = True
        Me.lbEconomia.Location = New System.Drawing.Point(296, 295)
        Me.lbEconomia.Name = "lbEconomia"
        Me.lbEconomia.Size = New System.Drawing.Size(118, 15)
        Me.lbEconomia.TabIndex = 6
        Me.lbEconomia.Text = "Situacion Económica:"
        '
        'cbxVivienda
        '
        Me.cbxVivienda.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cbxVivienda.FormattingEnabled = True
        Me.cbxVivienda.Items.AddRange(New Object() {"", "Alquilada", "Hipotecada", "VPO", "En propiedad", "Alojamiento temporal", "Inestable/precario", "Centro Residencial", "Centro Penitenciario"})
        Me.cbxVivienda.Location = New System.Drawing.Point(321, 255)
        Me.cbxVivienda.Name = "cbxVivienda"
        Me.cbxVivienda.Size = New System.Drawing.Size(216, 23)
        Me.cbxVivienda.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(296, 222)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Datos de la vivienda:"
        '
        'pbGenograma
        '
        Me.pbGenograma.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.pbGenograma.ContextMenuStrip = Me.cmsGenograma
        Me.pbGenograma.Location = New System.Drawing.Point(11, 238)
        Me.pbGenograma.Name = "pbGenograma"
        Me.pbGenograma.Size = New System.Drawing.Size(279, 189)
        Me.pbGenograma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbGenograma.TabIndex = 3
        Me.pbGenograma.TabStop = False
        '
        'cmsGenograma
        '
        Me.cmsGenograma.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsReloadImagen, Me.VerImagenToolStripMenuItem, Me.GuardarImagenToolStripMenuItem, Me.GuardarToolStripMenuItem, Me.tsEliminar})
        Me.cmsGenograma.Name = "cmsGenograma"
        Me.cmsGenograma.Size = New System.Drawing.Size(189, 136)
        '
        'tsReloadImagen
        '
        Me.tsReloadImagen.Name = "tsReloadImagen"
        Me.tsReloadImagen.Size = New System.Drawing.Size(188, 22)
        Me.tsReloadImagen.Text = "Reload Genograma"
        '
        'VerImagenToolStripMenuItem
        '
        Me.VerImagenToolStripMenuItem.Name = "VerImagenToolStripMenuItem"
        Me.VerImagenToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.VerImagenToolStripMenuItem.Text = "Ver Imagen"
        '
        'GuardarImagenToolStripMenuItem
        '
        Me.GuardarImagenToolStripMenuItem.Name = "GuardarImagenToolStripMenuItem"
        Me.GuardarImagenToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.GuardarImagenToolStripMenuItem.Text = "Importar Imagen"
        '
        'GuardarToolStripMenuItem
        '
        Me.GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
        Me.GuardarToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.GuardarToolStripMenuItem.Text = "Guardar en Alejandria"
        '
        'tsEliminar
        '
        Me.tsEliminar.Name = "tsEliminar"
        Me.tsEliminar.Size = New System.Drawing.Size(188, 22)
        Me.tsEliminar.Text = "Eliminar genograma"
        '
        'lbGenograma
        '
        Me.lbGenograma.AutoSize = True
        Me.lbGenograma.Location = New System.Drawing.Point(8, 222)
        Me.lbGenograma.Name = "lbGenograma"
        Me.lbGenograma.Size = New System.Drawing.Size(67, 15)
        Me.lbGenograma.TabIndex = 2
        Me.lbGenograma.Text = "Genograma:"
        '
        'lbUC
        '
        Me.lbUC.AutoSize = True
        Me.lbUC.Location = New System.Drawing.Point(8, 18)
        Me.lbUC.Name = "lbUC"
        Me.lbUC.Size = New System.Drawing.Size(127, 15)
        Me.lbUC.TabIndex = 1
        Me.lbUC.Text = "Unidad de Convivencia:"
        '
        'dgvUC
        '
        Me.dgvUC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvUC.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.dgvUC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUC.ContextMenuStrip = Me.cmsUC
        Me.dgvUC.Location = New System.Drawing.Point(11, 43)
        Me.dgvUC.Name = "dgvUC"
        Me.dgvUC.RowHeadersVisible = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.dgvUC.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvUC.Size = New System.Drawing.Size(561, 139)
        Me.dgvUC.TabIndex = 12
        '
        'cmsUC
        '
        Me.cmsUC.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsRecargarUC, Me.tsActualizar})
        Me.cmsUC.Name = "cmsUC"
        Me.cmsUC.Size = New System.Drawing.Size(252, 48)
        '
        'tsRecargarUC
        '
        Me.tsRecargarUC.Name = "tsRecargarUC"
        Me.tsRecargarUC.Size = New System.Drawing.Size(251, 22)
        Me.tsRecargarUC.Text = "Reload"
        '
        'tsActualizar
        '
        Me.tsActualizar.Name = "tsActualizar"
        Me.tsActualizar.Size = New System.Drawing.Size(251, 22)
        Me.tsActualizar.Text = "Actualizar Unidad de Convivencia"
        '
        'tpFyE
        '
        Me.tpFyE.BackColor = System.Drawing.Color.Khaki
        Me.tpFyE.Controls.Add(Me.Label9)
        Me.tpFyE.Controls.Add(Me.tbAnotaciones)
        Me.tpFyE.Controls.Add(Me.cbxSitLabAc)
        Me.tpFyE.Controls.Add(Me.cbxSitLabIn)
        Me.tpFyE.Controls.Add(Me.Label6)
        Me.tpFyE.Controls.Add(Me.Label5)
        Me.tpFyE.Controls.Add(Me.tbFormacionCompl)
        Me.tpFyE.Controls.Add(Me.Label4)
        Me.tpFyE.Controls.Add(Me.cbxFormacionReglada)
        Me.tpFyE.Controls.Add(Me.lbFormacion)
        Me.tpFyE.Location = New System.Drawing.Point(4, 24)
        Me.tpFyE.Name = "tpFyE"
        Me.tpFyE.Padding = New System.Windows.Forms.Padding(3)
        Me.tpFyE.Size = New System.Drawing.Size(580, 444)
        Me.tpFyE.TabIndex = 2
        Me.tpFyE.Text = "Formación y Empleo"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(183, 297)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 15)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Anotaciones:"
        '
        'tbAnotaciones
        '
        Me.tbAnotaciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbAnotaciones.Location = New System.Drawing.Point(272, 294)
        Me.tbAnotaciones.Multiline = True
        Me.tbAnotaciones.Name = "tbAnotaciones"
        Me.tbAnotaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbAnotaciones.Size = New System.Drawing.Size(224, 114)
        Me.tbAnotaciones.TabIndex = 20
        '
        'cbxSitLabAc
        '
        Me.cbxSitLabAc.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cbxSitLabAc.FormattingEnabled = True
        Me.cbxSitLabAc.Items.AddRange(New Object() {"", "Sin escolarizar", "Estudiante", "Desempleado/a", "Amo/a de casa", "Trabajador/a cuenta ajena", "Autónomo/a", "Jubilado/a"})
        Me.cbxSitLabAc.Location = New System.Drawing.Point(272, 229)
        Me.cbxSitLabAc.Name = "cbxSitLabAc"
        Me.cbxSitLabAc.Size = New System.Drawing.Size(224, 23)
        Me.cbxSitLabAc.TabIndex = 19
        '
        'cbxSitLabIn
        '
        Me.cbxSitLabIn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cbxSitLabIn.FormattingEnabled = True
        Me.cbxSitLabIn.Items.AddRange(New Object() {"", "Sin escolarizar", "Estudiante", "Desempleado/a", "Amo/a de casa", "Trabajador/a cuenta ajena", "Autónomo/a", "Jubilado/a"})
        Me.cbxSitLabIn.Location = New System.Drawing.Point(272, 192)
        Me.cbxSitLabIn.Name = "cbxSitLabIn"
        Me.cbxSitLabIn.Size = New System.Drawing.Size(224, 23)
        Me.cbxSitLabIn.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(127, 232)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(135, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Situación Laboral actual:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(84, 195)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(186, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Situación Laboral al inicio del TTº:"
        '
        'tbFormacionCompl
        '
        Me.tbFormacionCompl.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbFormacionCompl.Location = New System.Drawing.Point(272, 83)
        Me.tbFormacionCompl.Multiline = True
        Me.tbFormacionCompl.Name = "tbFormacionCompl"
        Me.tbFormacionCompl.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbFormacionCompl.Size = New System.Drawing.Size(224, 61)
        Me.tbFormacionCompl.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(115, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(147, 15)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Formación Complementaria:"
        '
        'cbxFormacionReglada
        '
        Me.cbxFormacionReglada.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cbxFormacionReglada.FormattingEnabled = True
        Me.cbxFormacionReglada.Items.AddRange(New Object() {"", "No sabe leer ni escribir", "Sin estudios", "EGB", "BUP", "ESO", "FP1/Grado Medio", "FP2/Grado Superior", "Diplomado/a", "Licenciado/a", "Doctorado/a"})
        Me.cbxFormacionReglada.Location = New System.Drawing.Point(272, 40)
        Me.cbxFormacionReglada.Name = "cbxFormacionReglada"
        Me.cbxFormacionReglada.Size = New System.Drawing.Size(224, 23)
        Me.cbxFormacionReglada.TabIndex = 16
        '
        'lbFormacion
        '
        Me.lbFormacion.AutoSize = True
        Me.lbFormacion.Location = New System.Drawing.Point(150, 43)
        Me.lbFormacion.Name = "lbFormacion"
        Me.lbFormacion.Size = New System.Drawing.Size(106, 15)
        Me.lbFormacion.TabIndex = 0
        Me.lbFormacion.Text = "Formación Reglada:"
        '
        'tpEntorno
        '
        Me.tpEntorno.BackColor = System.Drawing.Color.Khaki
        Me.tpEntorno.Controls.Add(Me.tbOcio)
        Me.tpEntorno.Controls.Add(Me.lbOcio)
        Me.tpEntorno.Controls.Add(Me.tbEntornoSocial)
        Me.tpEntorno.Controls.Add(Me.lbEntorno)
        Me.tpEntorno.Controls.Add(Me.cbxSitJud)
        Me.tpEntorno.Controls.Add(Me.lbSitJud)
        Me.tpEntorno.Location = New System.Drawing.Point(4, 24)
        Me.tpEntorno.Name = "tpEntorno"
        Me.tpEntorno.Padding = New System.Windows.Forms.Padding(3)
        Me.tpEntorno.Size = New System.Drawing.Size(580, 444)
        Me.tpEntorno.TabIndex = 3
        Me.tpEntorno.Text = "Entorno y Comunidad"
        '
        'tbOcio
        '
        Me.tbOcio.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbOcio.Location = New System.Drawing.Point(50, 290)
        Me.tbOcio.Multiline = True
        Me.tbOcio.Name = "tbOcio"
        Me.tbOcio.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbOcio.Size = New System.Drawing.Size(452, 132)
        Me.tbOcio.TabIndex = 24
        '
        'lbOcio
        '
        Me.lbOcio.AutoSize = True
        Me.lbOcio.Location = New System.Drawing.Point(25, 256)
        Me.lbOcio.Name = "lbOcio"
        Me.lbOcio.Size = New System.Drawing.Size(114, 15)
        Me.lbOcio.TabIndex = 10
        Me.lbOcio.Text = "Ocio y Tiempo Libre:"
        '
        'tbEntornoSocial
        '
        Me.tbEntornoSocial.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbEntornoSocial.Location = New System.Drawing.Point(50, 121)
        Me.tbEntornoSocial.Multiline = True
        Me.tbEntornoSocial.Name = "tbEntornoSocial"
        Me.tbEntornoSocial.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbEntornoSocial.Size = New System.Drawing.Size(453, 123)
        Me.tbEntornoSocial.TabIndex = 23
        '
        'lbEntorno
        '
        Me.lbEntorno.AutoSize = True
        Me.lbEntorno.Location = New System.Drawing.Point(25, 94)
        Me.lbEntorno.Name = "lbEntorno"
        Me.lbEntorno.Size = New System.Drawing.Size(86, 15)
        Me.lbEntorno.TabIndex = 8
        Me.lbEntorno.Text = "Entorno Social:"
        '
        'cbxSitJud
        '
        Me.cbxSitJud.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cbxSitJud.FormattingEnabled = True
        Me.cbxSitJud.Items.AddRange(New Object() {"", "Con Antecedentes judiciales", "Sin Antecedentes judiciales", "Condenas", "Sanciones administrativas"})
        Me.cbxSitJud.Location = New System.Drawing.Point(50, 48)
        Me.cbxSitJud.Name = "cbxSitJud"
        Me.cbxSitJud.Size = New System.Drawing.Size(216, 23)
        Me.cbxSitJud.TabIndex = 22
        '
        'lbSitJud
        '
        Me.lbSitJud.AutoSize = True
        Me.lbSitJud.Location = New System.Drawing.Point(25, 23)
        Me.lbSitJud.Name = "lbSitJud"
        Me.lbSitJud.Size = New System.Drawing.Size(105, 15)
        Me.lbSitJud.TabIndex = 6
        Me.lbSitJud.Text = "Situación Judicial:"
        '
        'tpDiagnostico
        '
        Me.tpDiagnostico.BackColor = System.Drawing.Color.Khaki
        Me.tpDiagnostico.Controls.Add(Me.tbObservaciones)
        Me.tpDiagnostico.Controls.Add(Me.lbObs)
        Me.tpDiagnostico.Controls.Add(Me.tbDiagnostico)
        Me.tpDiagnostico.Controls.Add(Me.lbDiagnostico)
        Me.tpDiagnostico.Location = New System.Drawing.Point(4, 24)
        Me.tpDiagnostico.Name = "tpDiagnostico"
        Me.tpDiagnostico.Padding = New System.Windows.Forms.Padding(3)
        Me.tpDiagnostico.Size = New System.Drawing.Size(580, 444)
        Me.tpDiagnostico.TabIndex = 4
        Me.tpDiagnostico.Text = "Diagnóstico Social"
        '
        'tbObservaciones
        '
        Me.tbObservaciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbObservaciones.Location = New System.Drawing.Point(31, 258)
        Me.tbObservaciones.Multiline = True
        Me.tbObservaciones.Name = "tbObservaciones"
        Me.tbObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbObservaciones.Size = New System.Drawing.Size(511, 182)
        Me.tbObservaciones.TabIndex = 27
        '
        'lbObs
        '
        Me.lbObs.AutoSize = True
        Me.lbObs.Location = New System.Drawing.Point(8, 242)
        Me.lbObs.Name = "lbObs"
        Me.lbObs.Size = New System.Drawing.Size(88, 15)
        Me.lbObs.TabIndex = 2
        Me.lbObs.Text = "Intervenciones:"
        '
        'tbDiagnostico
        '
        Me.tbDiagnostico.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbDiagnostico.Location = New System.Drawing.Point(31, 43)
        Me.tbDiagnostico.Multiline = True
        Me.tbDiagnostico.Name = "tbDiagnostico"
        Me.tbDiagnostico.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbDiagnostico.Size = New System.Drawing.Size(511, 182)
        Me.tbDiagnostico.TabIndex = 26
        '
        'lbDiagnostico
        '
        Me.lbDiagnostico.AutoSize = True
        Me.lbDiagnostico.Location = New System.Drawing.Point(8, 26)
        Me.lbDiagnostico.Name = "lbDiagnostico"
        Me.lbDiagnostico.Size = New System.Drawing.Size(107, 15)
        Me.lbDiagnostico.TabIndex = 0
        Me.lbDiagnostico.Text = "Diagnóstico Social:"
        '
        'btControlCitas
        '
        Me.btControlCitas.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btControlCitas.Location = New System.Drawing.Point(86, 504)
        Me.btControlCitas.Name = "btControlCitas"
        Me.btControlCitas.Size = New System.Drawing.Size(100, 23)
        Me.btControlCitas.TabIndex = 7
        Me.btControlCitas.Text = "Control de Citas"
        Me.btControlCitas.UseVisualStyleBackColor = True
        '
        'btHsMedica
        '
        Me.btHsMedica.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btHsMedica.Location = New System.Drawing.Point(501, 476)
        Me.btHsMedica.Name = "btHsMedica"
        Me.btHsMedica.Size = New System.Drawing.Size(75, 23)
        Me.btHsMedica.TabIndex = 9
        Me.btHsMedica.Text = "Hª Médica"
        Me.btHsMedica.UseVisualStyleBackColor = True
        '
        'btHsPs
        '
        Me.btHsPs.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btHsPs.Location = New System.Drawing.Point(400, 476)
        Me.btHsPs.Name = "btHsPs"
        Me.btHsPs.Size = New System.Drawing.Size(95, 23)
        Me.btHsPs.TabIndex = 8
        Me.btHsPs.Text = "Hª Psicológica"
        Me.btHsPs.UseVisualStyleBackColor = True
        '
        'lbFechaUltCita
        '
        Me.lbFechaUltCita.AutoSize = True
        Me.lbFechaUltCita.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFechaUltCita.Location = New System.Drawing.Point(12, 481)
        Me.lbFechaUltCita.Name = "lbFechaUltCita"
        Me.lbFechaUltCita.Size = New System.Drawing.Size(67, 15)
        Me.lbFechaUltCita.TabIndex = 11
        Me.lbFechaUltCita.Text = "Última Cita:"
        '
        'tbUltimaCita
        '
        Me.tbUltimaCita.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbUltimaCita.ContextMenuStrip = Me.cmsRecargarCita
        Me.tbUltimaCita.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbUltimaCita.Location = New System.Drawing.Point(86, 478)
        Me.tbUltimaCita.Name = "tbUltimaCita"
        Me.tbUltimaCita.ReadOnly = True
        Me.tbUltimaCita.Size = New System.Drawing.Size(100, 23)
        Me.tbUltimaCita.TabIndex = 6
        '
        'cmsRecargarCita
        '
        Me.cmsRecargarCita.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReloadUltimaCItaToolStripMenuItem})
        Me.cmsRecargarCita.Name = "cmsRecargarCita"
        Me.cmsRecargarCita.Size = New System.Drawing.Size(173, 26)
        '
        'ReloadUltimaCItaToolStripMenuItem
        '
        Me.ReloadUltimaCItaToolStripMenuItem.Name = "ReloadUltimaCItaToolStripMenuItem"
        Me.ReloadUltimaCItaToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.ReloadUltimaCItaToolStripMenuItem.Text = "Reload Ultima CIta"
        '
        'tbHistoria
        '
        Me.tbHistoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbHistoria.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbHistoria.Location = New System.Drawing.Point(263, 501)
        Me.tbHistoria.Name = "tbHistoria"
        Me.tbHistoria.Size = New System.Drawing.Size(100, 23)
        Me.tbHistoria.TabIndex = 15
        Me.tbHistoria.Visible = False
        '
        'btActualizar
        '
        Me.btActualizar.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btActualizar.Location = New System.Drawing.Point(400, 504)
        Me.btActualizar.Name = "btActualizar"
        Me.btActualizar.Size = New System.Drawing.Size(176, 23)
        Me.btActualizar.TabIndex = 10
        Me.btActualizar.Text = "Actualizar Cambios"
        Me.btActualizar.UseVisualStyleBackColor = True
        '
        'ofdImagen
        '
        Me.ofdImagen.FileName = "OpenFileDialog1"
        '
        'cmsWord
        '
        Me.cmsWord.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GenerarExcelToolStripMenuItem, Me.ExportarHistoriaSocialToolStripMenuItem})
        Me.cmsWord.Name = "cmsWord"
        Me.cmsWord.Size = New System.Drawing.Size(205, 70)
        '
        'GenerarExcelToolStripMenuItem
        '
        Me.GenerarExcelToolStripMenuItem.Name = "GenerarExcelToolStripMenuItem"
        Me.GenerarExcelToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.GenerarExcelToolStripMenuItem.Text = "Generar ""Informe Social"""
        '
        'ExportarHistoriaSocialToolStripMenuItem
        '
        Me.ExportarHistoriaSocialToolStripMenuItem.Name = "ExportarHistoriaSocialToolStripMenuItem"
        Me.ExportarHistoriaSocialToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.ExportarHistoriaSocialToolStripMenuItem.Text = "Exportar Historia Social"
        '
        'formHistoriaSocial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Peru
        Me.ClientSize = New System.Drawing.Size(588, 533)
        Me.ContextMenuStrip = Me.cmsWord
        Me.Controls.Add(Me.btActualizar)
        Me.Controls.Add(Me.tbHistoria)
        Me.Controls.Add(Me.btControlCitas)
        Me.Controls.Add(Me.btHsMedica)
        Me.Controls.Add(Me.btHsPs)
        Me.Controls.Add(Me.lbFechaUltCita)
        Me.Controls.Add(Me.tbUltimaCita)
        Me.Controls.Add(Me.tabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "formHistoriaSocial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "formHistoriaSocial"
        Me.tabControl1.ResumeLayout(False)
        Me.tpAntecedentes.ResumeLayout(False)
        Me.tpAntecedentes.PerformLayout()
        Me.tpConvivencia.ResumeLayout(False)
        Me.tpConvivencia.PerformLayout()
        CType(Me.pbGenograma, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsGenograma.ResumeLayout(False)
        CType(Me.dgvUC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsUC.ResumeLayout(False)
        Me.tpFyE.ResumeLayout(False)
        Me.tpFyE.PerformLayout()
        Me.tpEntorno.ResumeLayout(False)
        Me.tpEntorno.PerformLayout()
        Me.tpDiagnostico.ResumeLayout(False)
        Me.tpDiagnostico.PerformLayout()
        Me.cmsRecargarCita.ResumeLayout(False)
        Me.cmsWord.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tpAntecedentes As System.Windows.Forms.TabPage
    Friend WithEvents tpConvivencia As System.Windows.Forms.TabPage
    Friend WithEvents btControlCitas As System.Windows.Forms.Button
    Friend WithEvents btHsMedica As System.Windows.Forms.Button
    Friend WithEvents btHsPs As System.Windows.Forms.Button
    Friend WithEvents lbFechaUltCita As System.Windows.Forms.Label
    Friend WithEvents tbUltimaCita As System.Windows.Forms.TextBox
    Friend WithEvents tpFyE As System.Windows.Forms.TabPage
    Friend WithEvents tpEntorno As System.Windows.Forms.TabPage
    Friend WithEvents tpDiagnostico As System.Windows.Forms.TabPage
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbConsumo As System.Windows.Forms.Label
    Friend WithEvents cbxVivienda As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pbGenograma As System.Windows.Forms.PictureBox
    Friend WithEvents lbGenograma As System.Windows.Forms.Label
    Friend WithEvents lbUC As System.Windows.Forms.Label
    Friend WithEvents dgvUC As System.Windows.Forms.DataGridView
    Friend WithEvents cbxSitLabAc As System.Windows.Forms.ComboBox
    Friend WithEvents cbxSitLabIn As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbFormacionCompl As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbxFormacionReglada As System.Windows.Forms.ComboBox
    Friend WithEvents lbFormacion As System.Windows.Forms.Label
    Friend WithEvents cbxSitEcon As System.Windows.Forms.ComboBox
    Friend WithEvents lbEconomia As System.Windows.Forms.Label
    Friend WithEvents tbOcio As System.Windows.Forms.TextBox
    Friend WithEvents lbOcio As System.Windows.Forms.Label
    Friend WithEvents tbEntornoSocial As System.Windows.Forms.TextBox
    Friend WithEvents lbEntorno As System.Windows.Forms.Label
    Friend WithEvents cbxSitJud As System.Windows.Forms.ComboBox
    Friend WithEvents lbSitJud As System.Windows.Forms.Label
    Friend WithEvents tbObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents lbObs As System.Windows.Forms.Label
    Friend WithEvents tbDiagnostico As System.Windows.Forms.TextBox
    Friend WithEvents lbDiagnostico As System.Windows.Forms.Label
    Friend WithEvents cbxOtrasDrogas As System.Windows.Forms.ComboBox
    Friend WithEvents tbEdadInicioConsum As System.Windows.Forms.TextBox
    Friend WithEvents cbxConsumPrincipal As System.Windows.Forms.ComboBox
    Friend WithEvents cbxConsumo As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tbDemandaPlanteada As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tbOtrasDrogas As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tbAnotaciones As System.Windows.Forms.TextBox
    Friend WithEvents tbHistoria As System.Windows.Forms.TextBox
    Friend WithEvents btActualizar As System.Windows.Forms.Button
    Private WithEvents cmsUC As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tsRecargarUC As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsActualizar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsGenograma As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents VerImagenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GuardarImagenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ofdImagen As System.Windows.Forms.OpenFileDialog
    Friend WithEvents GuardarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsEliminar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsRecargarCita As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ReloadUltimaCItaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsReloadImagen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsWord As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents GenerarExcelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportarHistoriaSocialToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
