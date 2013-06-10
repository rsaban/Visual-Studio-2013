<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formHistoriaPsicologica
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formHistoriaPsicologica))
        Me.lbSeguimiento = New System.Windows.Forms.Label()
        Me.lbObservaciones = New System.Windows.Forms.Label()
        Me.tbSeguimiento = New System.Windows.Forms.TextBox()
        Me.tbObservaciones = New System.Windows.Forms.TextBox()
        Me.tbUltimaCita = New System.Windows.Forms.TextBox()
        Me.cmsRecargarCitaPs = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ReloadUltimaCitaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbFechaUltCita = New System.Windows.Forms.Label()
        Me.btHsSocial = New System.Windows.Forms.Button()
        Me.btHsMedica = New System.Windows.Forms.Button()
        Me.btControlCitas = New System.Windows.Forms.Button()
        Me.btActualizar = New System.Windows.Forms.Button()
        Me.tbHistoria = New System.Windows.Forms.TextBox()
        Me.cmsWord = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.GenerarInformePsicológicoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportarHistoriaPsicológicaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tbpAntecedentes = New System.Windows.Forms.TabPage()
        Me.tbAnamnesis = New System.Windows.Forms.TextBox()
        Me.tb1Entrevista = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tbQueja = New System.Windows.Forms.TextBox()
        Me.tbPercpEntorno = New System.Windows.Forms.TextBox()
        Me.tbPercpPac = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbQuienDemanda = New System.Windows.Forms.TextBox()
        Me.tbInformacion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbpDiagnostico = New System.Windows.Forms.TabPage()
        Me.tbDiagnostico = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.tbComorbilidad = New System.Windows.Forms.TextBox()
        Me.tbAnaliticas = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tbCausas = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbSoluciones = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbTToAnteriores = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbpIntervencion = New System.Windows.Forms.TabPage()
        Me.tbTareas = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.tbTecnicas = New System.Windows.Forms.TextBox()
        Me.tbObjetivos = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.tbProtocolo = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.tbpObsSeg = New System.Windows.Forms.TabPage()
        Me.cmsRecargarCitaPs.SuspendLayout()
        Me.cmsWord.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tbpAntecedentes.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tbpDiagnostico.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.tbpIntervencion.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.tbpObsSeg.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbSeguimiento
        '
        Me.lbSeguimiento.AutoSize = True
        Me.lbSeguimiento.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSeguimiento.Location = New System.Drawing.Point(8, 3)
        Me.lbSeguimiento.Name = "lbSeguimiento"
        Me.lbSeguimiento.Size = New System.Drawing.Size(74, 15)
        Me.lbSeguimiento.TabIndex = 0
        Me.lbSeguimiento.Text = "Seguimiento:"
        '
        'lbObservaciones
        '
        Me.lbObservaciones.AutoSize = True
        Me.lbObservaciones.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbObservaciones.Location = New System.Drawing.Point(8, 257)
        Me.lbObservaciones.Name = "lbObservaciones"
        Me.lbObservaciones.Size = New System.Drawing.Size(86, 15)
        Me.lbObservaciones.TabIndex = 1
        Me.lbObservaciones.Text = "Observaciones:"
        '
        'tbSeguimiento
        '
        Me.tbSeguimiento.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbSeguimiento.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSeguimiento.Location = New System.Drawing.Point(30, 19)
        Me.tbSeguimiento.Multiline = True
        Me.tbSeguimiento.Name = "tbSeguimiento"
        Me.tbSeguimiento.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbSeguimiento.Size = New System.Drawing.Size(524, 210)
        Me.tbSeguimiento.TabIndex = 17
        '
        'tbObservaciones
        '
        Me.tbObservaciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbObservaciones.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbObservaciones.Location = New System.Drawing.Point(30, 273)
        Me.tbObservaciones.Multiline = True
        Me.tbObservaciones.Name = "tbObservaciones"
        Me.tbObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbObservaciones.Size = New System.Drawing.Size(524, 210)
        Me.tbObservaciones.TabIndex = 18
        '
        'tbUltimaCita
        '
        Me.tbUltimaCita.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbUltimaCita.ContextMenuStrip = Me.cmsRecargarCitaPs
        Me.tbUltimaCita.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbUltimaCita.Location = New System.Drawing.Point(86, 544)
        Me.tbUltimaCita.Name = "tbUltimaCita"
        Me.tbUltimaCita.ReadOnly = True
        Me.tbUltimaCita.Size = New System.Drawing.Size(100, 23)
        Me.tbUltimaCita.TabIndex = 2
        '
        'cmsRecargarCitaPs
        '
        Me.cmsRecargarCitaPs.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReloadUltimaCitaToolStripMenuItem})
        Me.cmsRecargarCitaPs.Name = "cmsRecargarCitaPs"
        Me.cmsRecargarCitaPs.Size = New System.Drawing.Size(173, 26)
        '
        'ReloadUltimaCitaToolStripMenuItem
        '
        Me.ReloadUltimaCitaToolStripMenuItem.Name = "ReloadUltimaCitaToolStripMenuItem"
        Me.ReloadUltimaCitaToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.ReloadUltimaCitaToolStripMenuItem.Text = "Reload Última Cita"
        '
        'lbFechaUltCita
        '
        Me.lbFechaUltCita.AutoSize = True
        Me.lbFechaUltCita.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFechaUltCita.Location = New System.Drawing.Point(12, 548)
        Me.lbFechaUltCita.Name = "lbFechaUltCita"
        Me.lbFechaUltCita.Size = New System.Drawing.Size(67, 15)
        Me.lbFechaUltCita.TabIndex = 6
        Me.lbFechaUltCita.Text = "Última Cita:"
        '
        'btHsSocial
        '
        Me.btHsSocial.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btHsSocial.Location = New System.Drawing.Point(414, 543)
        Me.btHsSocial.Name = "btHsSocial"
        Me.btHsSocial.Size = New System.Drawing.Size(75, 23)
        Me.btHsSocial.TabIndex = 20
        Me.btHsSocial.Text = "Hª Social"
        Me.btHsSocial.UseVisualStyleBackColor = True
        '
        'btHsMedica
        '
        Me.btHsMedica.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btHsMedica.Location = New System.Drawing.Point(495, 543)
        Me.btHsMedica.Name = "btHsMedica"
        Me.btHsMedica.Size = New System.Drawing.Size(75, 23)
        Me.btHsMedica.TabIndex = 21
        Me.btHsMedica.Text = "Hª Médica"
        Me.btHsMedica.UseVisualStyleBackColor = True
        '
        'btControlCitas
        '
        Me.btControlCitas.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btControlCitas.Location = New System.Drawing.Point(86, 571)
        Me.btControlCitas.Name = "btControlCitas"
        Me.btControlCitas.Size = New System.Drawing.Size(100, 23)
        Me.btControlCitas.TabIndex = 22
        Me.btControlCitas.Text = "Control de Citas"
        Me.btControlCitas.UseVisualStyleBackColor = True
        '
        'btActualizar
        '
        Me.btActualizar.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btActualizar.Location = New System.Drawing.Point(414, 571)
        Me.btActualizar.Name = "btActualizar"
        Me.btActualizar.Size = New System.Drawing.Size(156, 23)
        Me.btActualizar.TabIndex = 19
        Me.btActualizar.Text = "Actualizar Cambios"
        Me.btActualizar.UseVisualStyleBackColor = True
        '
        'tbHistoria
        '
        Me.tbHistoria.Location = New System.Drawing.Point(245, 571)
        Me.tbHistoria.Name = "tbHistoria"
        Me.tbHistoria.Size = New System.Drawing.Size(100, 20)
        Me.tbHistoria.TabIndex = 11
        Me.tbHistoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbHistoria.Visible = False
        '
        'cmsWord
        '
        Me.cmsWord.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GenerarInformePsicológicoToolStripMenuItem, Me.ExportarHistoriaPsicológicaToolStripMenuItem})
        Me.cmsWord.Name = "cmsWord"
        Me.cmsWord.Size = New System.Drawing.Size(235, 70)
        '
        'GenerarInformePsicológicoToolStripMenuItem
        '
        Me.GenerarInformePsicológicoToolStripMenuItem.Name = "GenerarInformePsicológicoToolStripMenuItem"
        Me.GenerarInformePsicológicoToolStripMenuItem.Size = New System.Drawing.Size(234, 22)
        Me.GenerarInformePsicológicoToolStripMenuItem.Text = "Generar ""Informe Psicológico"""
        '
        'ExportarHistoriaPsicológicaToolStripMenuItem
        '
        Me.ExportarHistoriaPsicológicaToolStripMenuItem.Name = "ExportarHistoriaPsicológicaToolStripMenuItem"
        Me.ExportarHistoriaPsicológicaToolStripMenuItem.Size = New System.Drawing.Size(234, 22)
        Me.ExportarHistoriaPsicológicaToolStripMenuItem.Text = "Exportar Historia Psicológica"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tbpAntecedentes)
        Me.TabControl1.Controls.Add(Me.tbpDiagnostico)
        Me.TabControl1.Controls.Add(Me.tbpIntervencion)
        Me.TabControl1.Controls.Add(Me.tbpObsSeg)
        Me.TabControl1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(601, 537)
        Me.TabControl1.TabIndex = 12
        '
        'tbpAntecedentes
        '
        Me.tbpAntecedentes.BackColor = System.Drawing.Color.Khaki
        Me.tbpAntecedentes.Controls.Add(Me.tbAnamnesis)
        Me.tbpAntecedentes.Controls.Add(Me.tb1Entrevista)
        Me.tbpAntecedentes.Controls.Add(Me.GroupBox2)
        Me.tbpAntecedentes.Controls.Add(Me.GroupBox1)
        Me.tbpAntecedentes.Controls.Add(Me.Label4)
        Me.tbpAntecedentes.Controls.Add(Me.Label1)
        Me.tbpAntecedentes.Location = New System.Drawing.Point(4, 24)
        Me.tbpAntecedentes.Name = "tbpAntecedentes"
        Me.tbpAntecedentes.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpAntecedentes.Size = New System.Drawing.Size(593, 509)
        Me.tbpAntecedentes.TabIndex = 1
        Me.tbpAntecedentes.Text = "Antecedentes"
        '
        'tbAnamnesis
        '
        Me.tbAnamnesis.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbAnamnesis.Location = New System.Drawing.Point(194, 190)
        Me.tbAnamnesis.Multiline = True
        Me.tbAnamnesis.Name = "tbAnamnesis"
        Me.tbAnamnesis.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbAnamnesis.Size = New System.Drawing.Size(340, 114)
        Me.tbAnamnesis.TabIndex = 3
        '
        'tb1Entrevista
        '
        Me.tb1Entrevista.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tb1Entrevista.Location = New System.Drawing.Point(134, 13)
        Me.tb1Entrevista.Name = "tb1Entrevista"
        Me.tb1Entrevista.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tb1Entrevista.Size = New System.Drawing.Size(100, 23)
        Me.tb1Entrevista.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tbQueja)
        Me.GroupBox2.Controls.Add(Me.tbPercpEntorno)
        Me.GroupBox2.Controls.Add(Me.tbPercpPac)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(34, 310)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(521, 182)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Percepción del Problema"
        '
        'tbQueja
        '
        Me.tbQueja.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbQueja.Location = New System.Drawing.Point(160, 123)
        Me.tbQueja.Multiline = True
        Me.tbQueja.Name = "tbQueja"
        Me.tbQueja.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbQueja.Size = New System.Drawing.Size(340, 44)
        Me.tbQueja.TabIndex = 6
        '
        'tbPercpEntorno
        '
        Me.tbPercpEntorno.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbPercpEntorno.Location = New System.Drawing.Point(160, 74)
        Me.tbPercpEntorno.Multiline = True
        Me.tbPercpEntorno.Name = "tbPercpEntorno"
        Me.tbPercpEntorno.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbPercpEntorno.Size = New System.Drawing.Size(340, 44)
        Me.tbPercpEntorno.TabIndex = 5
        '
        'tbPercpPac
        '
        Me.tbPercpPac.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbPercpPac.Location = New System.Drawing.Point(160, 25)
        Me.tbPercpPac.Multiline = True
        Me.tbPercpPac.Name = "tbPercpPac"
        Me.tbPercpPac.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbPercpPac.Size = New System.Drawing.Size(340, 44)
        Me.tbPercpPac.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Percepción del Paciente:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 77)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Percepción del Entorno:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 126)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(132, 15)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Quién presenta la queja:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.tbQuienDemanda)
        Me.GroupBox1.Controls.Add(Me.tbInformacion)
        Me.GroupBox1.Location = New System.Drawing.Point(34, 49)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(521, 135)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Procedencia"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Quién Realiza la Demanda:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Información que Aporta:"
        '
        'tbQuienDemanda
        '
        Me.tbQuienDemanda.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbQuienDemanda.Location = New System.Drawing.Point(160, 23)
        Me.tbQuienDemanda.Multiline = True
        Me.tbQuienDemanda.Name = "tbQuienDemanda"
        Me.tbQuienDemanda.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbQuienDemanda.Size = New System.Drawing.Size(340, 44)
        Me.tbQuienDemanda.TabIndex = 1
        '
        'tbInformacion
        '
        Me.tbInformacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbInformacion.Location = New System.Drawing.Point(160, 73)
        Me.tbInformacion.Multiline = True
        Me.tbInformacion.Name = "tbInformacion"
        Me.tbInformacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbInformacion.Size = New System.Drawing.Size(340, 44)
        Me.tbInformacion.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(52, 193)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Anamnesis:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha 1º Entrevista:"
        '
        'tbpDiagnostico
        '
        Me.tbpDiagnostico.BackColor = System.Drawing.Color.Khaki
        Me.tbpDiagnostico.Controls.Add(Me.tbDiagnostico)
        Me.tbpDiagnostico.Controls.Add(Me.Label13)
        Me.tbpDiagnostico.Controls.Add(Me.GroupBox3)
        Me.tbpDiagnostico.Controls.Add(Me.tbCausas)
        Me.tbpDiagnostico.Controls.Add(Me.Label10)
        Me.tbpDiagnostico.Controls.Add(Me.tbSoluciones)
        Me.tbpDiagnostico.Controls.Add(Me.Label9)
        Me.tbpDiagnostico.Controls.Add(Me.tbTToAnteriores)
        Me.tbpDiagnostico.Controls.Add(Me.Label8)
        Me.tbpDiagnostico.Location = New System.Drawing.Point(4, 24)
        Me.tbpDiagnostico.Name = "tbpDiagnostico"
        Me.tbpDiagnostico.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpDiagnostico.Size = New System.Drawing.Size(593, 509)
        Me.tbpDiagnostico.TabIndex = 2
        Me.tbpDiagnostico.Text = "TTº, Pruebas y Diagnóstico"
        '
        'tbDiagnostico
        '
        Me.tbDiagnostico.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbDiagnostico.Location = New System.Drawing.Point(115, 413)
        Me.tbDiagnostico.Multiline = True
        Me.tbDiagnostico.Name = "tbDiagnostico"
        Me.tbDiagnostico.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbDiagnostico.Size = New System.Drawing.Size(442, 73)
        Me.tbDiagnostico.TabIndex = 12
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(19, 416)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(71, 15)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "Diagnóstico:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.tbComorbilidad)
        Me.GroupBox3.Controls.Add(Me.tbAnaliticas)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Location = New System.Drawing.Point(22, 263)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(553, 138)
        Me.GroupBox3.TabIndex = 21
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Diagnóstico Diferencial"
        '
        'tbComorbilidad
        '
        Me.tbComorbilidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbComorbilidad.Location = New System.Drawing.Point(133, 77)
        Me.tbComorbilidad.Multiline = True
        Me.tbComorbilidad.Name = "tbComorbilidad"
        Me.tbComorbilidad.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbComorbilidad.Size = New System.Drawing.Size(402, 52)
        Me.tbComorbilidad.TabIndex = 11
        '
        'tbAnaliticas
        '
        Me.tbAnaliticas.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbAnaliticas.Location = New System.Drawing.Point(133, 19)
        Me.tbAnaliticas.Multiline = True
        Me.tbAnaliticas.Name = "tbAnaliticas"
        Me.tbAnaliticas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbAnaliticas.Size = New System.Drawing.Size(402, 52)
        Me.tbAnaliticas.TabIndex = 10
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(24, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(105, 15)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Pruebas Analíticas:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(24, 80)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(77, 15)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Comorbilidad:"
        '
        'tbCausas
        '
        Me.tbCausas.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbCausas.Location = New System.Drawing.Point(115, 184)
        Me.tbCausas.Multiline = True
        Me.tbCausas.Name = "tbCausas"
        Me.tbCausas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbCausas.Size = New System.Drawing.Size(442, 73)
        Me.tbCausas.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(19, 187)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 30)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Causas y" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Consecuencias:"
        '
        'tbSoluciones
        '
        Me.tbSoluciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbSoluciones.Location = New System.Drawing.Point(115, 105)
        Me.tbSoluciones.Multiline = True
        Me.tbSoluciones.Name = "tbSoluciones"
        Me.tbSoluciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbSoluciones.Size = New System.Drawing.Size(442, 73)
        Me.tbSoluciones.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(19, 108)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 30)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Soluciones" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Intentadas:"
        '
        'tbTToAnteriores
        '
        Me.tbTToAnteriores.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbTToAnteriores.Location = New System.Drawing.Point(115, 26)
        Me.tbTToAnteriores.Multiline = True
        Me.tbTToAnteriores.Name = "tbTToAnteriores"
        Me.tbTToAnteriores.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbTToAnteriores.Size = New System.Drawing.Size(442, 73)
        Me.tbTToAnteriores.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 29)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 30)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Tratamientos" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Anteriores:"
        '
        'tbpIntervencion
        '
        Me.tbpIntervencion.BackColor = System.Drawing.Color.Khaki
        Me.tbpIntervencion.Controls.Add(Me.tbTareas)
        Me.tbpIntervencion.Controls.Add(Me.Label17)
        Me.tbpIntervencion.Controls.Add(Me.GroupBox4)
        Me.tbpIntervencion.Controls.Add(Me.tbProtocolo)
        Me.tbpIntervencion.Controls.Add(Me.Label14)
        Me.tbpIntervencion.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbpIntervencion.Location = New System.Drawing.Point(4, 24)
        Me.tbpIntervencion.Name = "tbpIntervencion"
        Me.tbpIntervencion.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpIntervencion.Size = New System.Drawing.Size(593, 509)
        Me.tbpIntervencion.TabIndex = 3
        Me.tbpIntervencion.Text = "Intervención"
        '
        'tbTareas
        '
        Me.tbTareas.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbTareas.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTareas.Location = New System.Drawing.Point(119, 258)
        Me.tbTareas.Multiline = True
        Me.tbTareas.Name = "tbTareas"
        Me.tbTareas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbTareas.Size = New System.Drawing.Size(434, 73)
        Me.tbTareas.TabIndex = 16
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(20, 261)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(64, 30)
        Me.Label17.TabIndex = 23
        Me.Label17.Text = "Asignación" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de Tareas:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.tbTecnicas)
        Me.GroupBox4.Controls.Add(Me.tbObjetivos)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(13, 102)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(540, 138)
        Me.GroupBox4.TabIndex = 22
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Intervención:"
        '
        'tbTecnicas
        '
        Me.tbTecnicas.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbTecnicas.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTecnicas.Location = New System.Drawing.Point(111, 77)
        Me.tbTecnicas.Multiline = True
        Me.tbTecnicas.Name = "tbTecnicas"
        Me.tbTecnicas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbTecnicas.Size = New System.Drawing.Size(402, 52)
        Me.tbTecnicas.TabIndex = 15
        '
        'tbObjetivos
        '
        Me.tbObjetivos.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbObjetivos.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbObjetivos.Location = New System.Drawing.Point(111, 19)
        Me.tbObjetivos.Multiline = True
        Me.tbObjetivos.Name = "tbObjetivos"
        Me.tbObjetivos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbObjetivos.Size = New System.Drawing.Size(402, 52)
        Me.tbObjetivos.TabIndex = 14
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(24, 22)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(60, 15)
        Me.Label15.TabIndex = 19
        Me.Label15.Text = "Objetivos:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(24, 80)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(56, 15)
        Me.Label16.TabIndex = 20
        Me.Label16.Text = "Técnicas:"
        '
        'tbProtocolo
        '
        Me.tbProtocolo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbProtocolo.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbProtocolo.Location = New System.Drawing.Point(119, 23)
        Me.tbProtocolo.Multiline = True
        Me.tbProtocolo.Name = "tbProtocolo"
        Me.tbProtocolo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbProtocolo.Size = New System.Drawing.Size(434, 73)
        Me.tbProtocolo.TabIndex = 13
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(8, 26)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(105, 15)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "Protocolo a Seguir:"
        '
        'tbpObsSeg
        '
        Me.tbpObsSeg.BackColor = System.Drawing.Color.Khaki
        Me.tbpObsSeg.Controls.Add(Me.lbSeguimiento)
        Me.tbpObsSeg.Controls.Add(Me.lbObservaciones)
        Me.tbpObsSeg.Controls.Add(Me.tbSeguimiento)
        Me.tbpObsSeg.Controls.Add(Me.tbObservaciones)
        Me.tbpObsSeg.Location = New System.Drawing.Point(4, 24)
        Me.tbpObsSeg.Name = "tbpObsSeg"
        Me.tbpObsSeg.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpObsSeg.Size = New System.Drawing.Size(593, 509)
        Me.tbpObsSeg.TabIndex = 0
        Me.tbpObsSeg.Text = "Observaciones y Seguimiento"
        '
        'formHistoriaPsicologica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Peru
        Me.ClientSize = New System.Drawing.Size(601, 605)
        Me.ContextMenuStrip = Me.cmsWord
        Me.Controls.Add(Me.tbHistoria)
        Me.Controls.Add(Me.btActualizar)
        Me.Controls.Add(Me.btControlCitas)
        Me.Controls.Add(Me.btHsMedica)
        Me.Controls.Add(Me.btHsSocial)
        Me.Controls.Add(Me.lbFechaUltCita)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.tbUltimaCita)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "formHistoriaPsicologica"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "formHistoriaPsicologica"
        Me.cmsRecargarCitaPs.ResumeLayout(False)
        Me.cmsWord.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.tbpAntecedentes.ResumeLayout(False)
        Me.tbpAntecedentes.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tbpDiagnostico.ResumeLayout(False)
        Me.tbpDiagnostico.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.tbpIntervencion.ResumeLayout(False)
        Me.tbpIntervencion.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.tbpObsSeg.ResumeLayout(False)
        Me.tbpObsSeg.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbSeguimiento As System.Windows.Forms.Label
    Friend WithEvents lbObservaciones As System.Windows.Forms.Label
    Friend WithEvents tbSeguimiento As System.Windows.Forms.TextBox
    Friend WithEvents tbObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents tbUltimaCita As System.Windows.Forms.TextBox
    Friend WithEvents lbFechaUltCita As System.Windows.Forms.Label
    Friend WithEvents btHsSocial As System.Windows.Forms.Button
    Friend WithEvents btHsMedica As System.Windows.Forms.Button
    Friend WithEvents btControlCitas As System.Windows.Forms.Button
    Friend WithEvents btActualizar As System.Windows.Forms.Button
    Friend WithEvents tbHistoria As System.Windows.Forms.TextBox
    Friend WithEvents cmsRecargarCitaPs As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ReloadUltimaCitaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsWord As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ExportarHistoriaPsicológicaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tbpObsSeg As System.Windows.Forms.TabPage
    Friend WithEvents tbpAntecedentes As System.Windows.Forms.TabPage
    Friend WithEvents tbAnamnesis As System.Windows.Forms.TextBox
    Friend WithEvents tb1Entrevista As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents tbQueja As System.Windows.Forms.TextBox
    Friend WithEvents tbPercpEntorno As System.Windows.Forms.TextBox
    Friend WithEvents tbPercpPac As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbQuienDemanda As System.Windows.Forms.TextBox
    Friend WithEvents tbInformacion As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbpDiagnostico As System.Windows.Forms.TabPage
    Friend WithEvents tbDiagnostico As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents tbComorbilidad As System.Windows.Forms.TextBox
    Friend WithEvents tbAnaliticas As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents tbCausas As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tbSoluciones As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tbTToAnteriores As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tbpIntervencion As System.Windows.Forms.TabPage
    Friend WithEvents tbTareas As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents tbTecnicas As System.Windows.Forms.TextBox
    Friend WithEvents tbObjetivos As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents tbProtocolo As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents GenerarInformePsicológicoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
