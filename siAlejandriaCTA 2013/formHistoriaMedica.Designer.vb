<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formHistoriaMedica
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formHistoriaMedica))
        Me.btControlCitas = New System.Windows.Forms.Button()
        Me.btHsPs = New System.Windows.Forms.Button()
        Me.btHsSocial = New System.Windows.Forms.Button()
        Me.lbFechaUltCita = New System.Windows.Forms.Label()
        Me.tbUltimaCita = New System.Windows.Forms.TextBox()
        Me.cmsRecargarCitaMd = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RecargarÚltimaCitaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tbHistoria = New System.Windows.Forms.TextBox()
        Me.btActualizar = New System.Windows.Forms.Button()
        Me.cmsWord = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ExportarHistoriaMédicaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPageAntecedentesYExploracion = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbAdenopatias = New System.Windows.Forms.TextBox()
        Me.cbxTatuajes = New System.Windows.Forms.ComboBox()
        Me.cbxCaries = New System.Windows.Forms.ComboBox()
        Me.cbxVenopuncion = New System.Windows.Forms.ComboBox()
        Me.tbTemperatura = New System.Windows.Forms.TextBox()
        Me.tbTA = New System.Windows.Forms.TextBox()
        Me.tbPulso = New System.Windows.Forms.TextBox()
        Me.tbTalla = New System.Windows.Forms.TextBox()
        Me.tbPeso = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.tbCirugia = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cbxHospitalizaciones = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tbAlergias = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tbAntecedentesInteres = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TabPageAnalitcaYPatologias = New System.Windows.Forms.TabPage()
        Me.tbPatPsiquiatricas = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.tbOtrasPatSomaticas = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbPatSomaticas = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.gbxResultadosAnaliticos = New System.Windows.Forms.GroupBox()
        Me.tbBioquimica = New System.Windows.Forms.TextBox()
        Me.tbHemograma = New System.Windows.Forms.TextBox()
        Me.tbPruebasHepaticas = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbMantoux = New System.Windows.Forms.TextBox()
        Me.tbLUES = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbVHC = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbVHB = New System.Windows.Forms.TextBox()
        Me.tbVIH = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPageTToActual = New System.Windows.Forms.TabPage()
        Me.cbxProgLibreDrogas = New System.Windows.Forms.ComboBox()
        Me.cbxReduccion = New System.Windows.Forms.ComboBox()
        Me.cbxDesintox = New System.Windows.Forms.ComboBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.tbTToPsiquiatrico = New System.Windows.Forms.TextBox()
        Me.tbTToEspecifico = New System.Windows.Forms.TextBox()
        Me.tbTToGeneral = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.TabPageSeguimiento = New System.Windows.Forms.TabPage()
        Me.lbSeguimiento = New System.Windows.Forms.Label()
        Me.lbObservaciones = New System.Windows.Forms.Label()
        Me.tbSeguimiento = New System.Windows.Forms.TextBox()
        Me.tbObservaciones = New System.Windows.Forms.TextBox()
        Me.cmsRecargarCitaMd.SuspendLayout()
        Me.cmsWord.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPageAntecedentesYExploracion.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPageAnalitcaYPatologias.SuspendLayout()
        Me.gbxResultadosAnaliticos.SuspendLayout()
        Me.TabPageTToActual.SuspendLayout()
        Me.TabPageSeguimiento.SuspendLayout()
        Me.SuspendLayout()
        '
        'btControlCitas
        '
        Me.btControlCitas.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btControlCitas.Location = New System.Drawing.Point(94, 566)
        Me.btControlCitas.Name = "btControlCitas"
        Me.btControlCitas.Size = New System.Drawing.Size(100, 23)
        Me.btControlCitas.TabIndex = 5
        Me.btControlCitas.Text = "Control de Citas"
        Me.btControlCitas.UseVisualStyleBackColor = True
        '
        'btHsPs
        '
        Me.btHsPs.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btHsPs.Location = New System.Drawing.Point(405, 538)
        Me.btHsPs.Name = "btHsPs"
        Me.btHsPs.Size = New System.Drawing.Size(94, 23)
        Me.btHsPs.TabIndex = 2
        Me.btHsPs.Text = "Hª Psicológica"
        Me.btHsPs.UseVisualStyleBackColor = True
        '
        'btHsSocial
        '
        Me.btHsSocial.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btHsSocial.Location = New System.Drawing.Point(505, 538)
        Me.btHsSocial.Name = "btHsSocial"
        Me.btHsSocial.Size = New System.Drawing.Size(75, 23)
        Me.btHsSocial.TabIndex = 3
        Me.btHsSocial.Text = "Hª Social"
        Me.btHsSocial.UseVisualStyleBackColor = True
        '
        'lbFechaUltCita
        '
        Me.lbFechaUltCita.AutoSize = True
        Me.lbFechaUltCita.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFechaUltCita.Location = New System.Drawing.Point(20, 543)
        Me.lbFechaUltCita.Name = "lbFechaUltCita"
        Me.lbFechaUltCita.Size = New System.Drawing.Size(67, 15)
        Me.lbFechaUltCita.TabIndex = 15
        Me.lbFechaUltCita.Text = "Última Cita:"
        '
        'tbUltimaCita
        '
        Me.tbUltimaCita.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbUltimaCita.ContextMenuStrip = Me.cmsRecargarCitaMd
        Me.tbUltimaCita.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbUltimaCita.Location = New System.Drawing.Point(94, 540)
        Me.tbUltimaCita.Name = "tbUltimaCita"
        Me.tbUltimaCita.ReadOnly = True
        Me.tbUltimaCita.Size = New System.Drawing.Size(100, 23)
        Me.tbUltimaCita.TabIndex = 6
        '
        'cmsRecargarCitaMd
        '
        Me.cmsRecargarCitaMd.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RecargarÚltimaCitaToolStripMenuItem})
        Me.cmsRecargarCitaMd.Name = "cmsRecargarCitaMd"
        Me.cmsRecargarCitaMd.Size = New System.Drawing.Size(183, 26)
        '
        'RecargarÚltimaCitaToolStripMenuItem
        '
        Me.RecargarÚltimaCitaToolStripMenuItem.Name = "RecargarÚltimaCitaToolStripMenuItem"
        Me.RecargarÚltimaCitaToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.RecargarÚltimaCitaToolStripMenuItem.Text = "Recargar Última Cita"
        '
        'tbHistoria
        '
        Me.tbHistoria.Location = New System.Drawing.Point(238, 573)
        Me.tbHistoria.Name = "tbHistoria"
        Me.tbHistoria.Size = New System.Drawing.Size(100, 20)
        Me.tbHistoria.TabIndex = 19
        Me.tbHistoria.Visible = False
        '
        'btActualizar
        '
        Me.btActualizar.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btActualizar.Location = New System.Drawing.Point(405, 566)
        Me.btActualizar.Name = "btActualizar"
        Me.btActualizar.Size = New System.Drawing.Size(175, 23)
        Me.btActualizar.TabIndex = 4
        Me.btActualizar.Text = "Actualizar Cambios"
        Me.btActualizar.UseVisualStyleBackColor = True
        '
        'cmsWord
        '
        Me.cmsWord.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportarHistoriaMédicaToolStripMenuItem})
        Me.cmsWord.Name = "cmsWord"
        Me.cmsWord.Size = New System.Drawing.Size(204, 48)
        '
        'ExportarHistoriaMédicaToolStripMenuItem
        '
        Me.ExportarHistoriaMédicaToolStripMenuItem.Name = "ExportarHistoriaMédicaToolStripMenuItem"
        Me.ExportarHistoriaMédicaToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.ExportarHistoriaMédicaToolStripMenuItem.Text = "Exportar Historia Médica"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPageAntecedentesYExploracion)
        Me.TabControl1.Controls.Add(Me.TabPageAnalitcaYPatologias)
        Me.TabControl1.Controls.Add(Me.TabPageTToActual)
        Me.TabControl1.Controls.Add(Me.TabPageSeguimiento)
        Me.TabControl1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(602, 533)
        Me.TabControl1.TabIndex = 20
        '
        'TabPageAntecedentesYExploracion
        '
        Me.TabPageAntecedentesYExploracion.BackColor = System.Drawing.Color.Khaki
        Me.TabPageAntecedentesYExploracion.Controls.Add(Me.GroupBox1)
        Me.TabPageAntecedentesYExploracion.Controls.Add(Me.tbCirugia)
        Me.TabPageAntecedentesYExploracion.Controls.Add(Me.Label14)
        Me.TabPageAntecedentesYExploracion.Controls.Add(Me.cbxHospitalizaciones)
        Me.TabPageAntecedentesYExploracion.Controls.Add(Me.Label13)
        Me.TabPageAntecedentesYExploracion.Controls.Add(Me.tbAlergias)
        Me.TabPageAntecedentesYExploracion.Controls.Add(Me.Label12)
        Me.TabPageAntecedentesYExploracion.Controls.Add(Me.tbAntecedentesInteres)
        Me.TabPageAntecedentesYExploracion.Controls.Add(Me.Label11)
        Me.TabPageAntecedentesYExploracion.Location = New System.Drawing.Point(4, 24)
        Me.TabPageAntecedentesYExploracion.Name = "TabPageAntecedentesYExploracion"
        Me.TabPageAntecedentesYExploracion.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageAntecedentesYExploracion.Size = New System.Drawing.Size(594, 505)
        Me.TabPageAntecedentesYExploracion.TabIndex = 4
        Me.TabPageAntecedentesYExploracion.Text = "Antecedentes y Exploración"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tbAdenopatias)
        Me.GroupBox1.Controls.Add(Me.cbxTatuajes)
        Me.GroupBox1.Controls.Add(Me.cbxCaries)
        Me.GroupBox1.Controls.Add(Me.cbxVenopuncion)
        Me.GroupBox1.Controls.Add(Me.tbTemperatura)
        Me.GroupBox1.Controls.Add(Me.tbTA)
        Me.GroupBox1.Controls.Add(Me.tbPulso)
        Me.GroupBox1.Controls.Add(Me.tbTalla)
        Me.GroupBox1.Controls.Add(Me.tbPeso)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 269)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(557, 177)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Exploración:"
        '
        'tbAdenopatias
        '
        Me.tbAdenopatias.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbAdenopatias.Location = New System.Drawing.Point(88, 65)
        Me.tbAdenopatias.Name = "tbAdenopatias"
        Me.tbAdenopatias.Size = New System.Drawing.Size(221, 23)
        Me.tbAdenopatias.TabIndex = 29
        '
        'cbxTatuajes
        '
        Me.cbxTatuajes.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cbxTatuajes.FormattingEnabled = True
        Me.cbxTatuajes.Items.AddRange(New Object() {"", "Sí", "No"})
        Me.cbxTatuajes.Location = New System.Drawing.Point(76, 135)
        Me.cbxTatuajes.Name = "cbxTatuajes"
        Me.cbxTatuajes.Size = New System.Drawing.Size(61, 23)
        Me.cbxTatuajes.TabIndex = 28
        '
        'cbxCaries
        '
        Me.cbxCaries.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cbxCaries.FormattingEnabled = True
        Me.cbxCaries.Items.AddRange(New Object() {"", "Sí", "No"})
        Me.cbxCaries.Location = New System.Drawing.Point(76, 98)
        Me.cbxCaries.Name = "cbxCaries"
        Me.cbxCaries.Size = New System.Drawing.Size(61, 23)
        Me.cbxCaries.TabIndex = 27
        '
        'cbxVenopuncion
        '
        Me.cbxVenopuncion.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cbxVenopuncion.FormattingEnabled = True
        Me.cbxVenopuncion.Items.AddRange(New Object() {"", "Sí", "No"})
        Me.cbxVenopuncion.Location = New System.Drawing.Point(480, 65)
        Me.cbxVenopuncion.Name = "cbxVenopuncion"
        Me.cbxVenopuncion.Size = New System.Drawing.Size(61, 23)
        Me.cbxVenopuncion.TabIndex = 26
        '
        'tbTemperatura
        '
        Me.tbTemperatura.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbTemperatura.Location = New System.Drawing.Point(492, 27)
        Me.tbTemperatura.Name = "tbTemperatura"
        Me.tbTemperatura.Size = New System.Drawing.Size(49, 23)
        Me.tbTemperatura.TabIndex = 20
        '
        'tbTA
        '
        Me.tbTA.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbTA.Location = New System.Drawing.Point(361, 27)
        Me.tbTA.Name = "tbTA"
        Me.tbTA.Size = New System.Drawing.Size(49, 23)
        Me.tbTA.TabIndex = 19
        '
        'tbPulso
        '
        Me.tbPulso.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbPulso.Location = New System.Drawing.Point(260, 27)
        Me.tbPulso.Name = "tbPulso"
        Me.tbPulso.Size = New System.Drawing.Size(49, 23)
        Me.tbPulso.TabIndex = 18
        '
        'tbTalla
        '
        Me.tbTalla.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbTalla.Location = New System.Drawing.Point(160, 27)
        Me.tbTalla.Name = "tbTalla"
        Me.tbTalla.Size = New System.Drawing.Size(49, 23)
        Me.tbTalla.TabIndex = 17
        '
        'tbPeso
        '
        Me.tbPeso.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbPeso.Location = New System.Drawing.Point(59, 27)
        Me.tbPeso.Name = "tbPeso"
        Me.tbPeso.Size = New System.Drawing.Size(49, 23)
        Me.tbPeso.TabIndex = 16
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(19, 138)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(54, 15)
        Me.Label23.TabIndex = 15
        Me.Label23.Text = "Tatuajes:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(19, 101)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(43, 15)
        Me.Label22.TabIndex = 14
        Me.Label22.Text = "Caries:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(351, 68)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(128, 15)
        Me.Label21.TabIndex = 13
        Me.Label21.Text = "Signos de Venopunción:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(19, 68)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(73, 15)
        Me.Label20.TabIndex = 12
        Me.Label20.Text = "Adenopatias:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(221, 31)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(36, 15)
        Me.Label19.TabIndex = 11
        Me.Label19.Text = "Pulso:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(416, 31)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(75, 15)
        Me.Label18.TabIndex = 10
        Me.Label18.Text = "Temperatura:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(325, 31)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(31, 15)
        Me.Label17.TabIndex = 9
        Me.Label17.Text = "T.A.:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(121, 31)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(35, 15)
        Me.Label16.TabIndex = 8
        Me.Label16.Text = "Talla:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(19, 31)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(33, 15)
        Me.Label15.TabIndex = 7
        Me.Label15.Text = "Peso:"
        '
        'tbCirugia
        '
        Me.tbCirugia.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbCirugia.Location = New System.Drawing.Point(258, 167)
        Me.tbCirugia.Multiline = True
        Me.tbCirugia.Name = "tbCirugia"
        Me.tbCirugia.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbCirugia.Size = New System.Drawing.Size(318, 80)
        Me.tbCirugia.TabIndex = 7
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(198, 170)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(48, 15)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "Cirugía:"
        '
        'cbxHospitalizaciones
        '
        Me.cbxHospitalizaciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cbxHospitalizaciones.FormattingEnabled = True
        Me.cbxHospitalizaciones.Items.AddRange(New Object() {"", "Sí", "No"})
        Me.cbxHospitalizaciones.Location = New System.Drawing.Point(112, 167)
        Me.cbxHospitalizaciones.Name = "cbxHospitalizaciones"
        Me.cbxHospitalizaciones.Size = New System.Drawing.Size(61, 23)
        Me.cbxHospitalizaciones.TabIndex = 5
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(14, 170)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(101, 15)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Hospitalizaciones:"
        '
        'tbAlergias
        '
        Me.tbAlergias.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbAlergias.Location = New System.Drawing.Point(110, 106)
        Me.tbAlergias.Multiline = True
        Me.tbAlergias.Name = "tbAlergias"
        Me.tbAlergias.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbAlergias.Size = New System.Drawing.Size(466, 41)
        Me.tbAlergias.TabIndex = 3
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(16, 109)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 15)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Alergias:"
        '
        'tbAntecedentesInteres
        '
        Me.tbAntecedentesInteres.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbAntecedentesInteres.Location = New System.Drawing.Point(110, 20)
        Me.tbAntecedentesInteres.Multiline = True
        Me.tbAntecedentesInteres.Name = "tbAntecedentesInteres"
        Me.tbAntecedentesInteres.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbAntecedentesInteres.Size = New System.Drawing.Size(466, 80)
        Me.tbAntecedentesInteres.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(16, 23)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(91, 30)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Antecedentes de" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Interés:"
        '
        'TabPageAnalitcaYPatologias
        '
        Me.TabPageAnalitcaYPatologias.BackColor = System.Drawing.Color.Khaki
        Me.TabPageAnalitcaYPatologias.Controls.Add(Me.tbPatPsiquiatricas)
        Me.TabPageAnalitcaYPatologias.Controls.Add(Me.Label24)
        Me.TabPageAnalitcaYPatologias.Controls.Add(Me.tbOtrasPatSomaticas)
        Me.TabPageAnalitcaYPatologias.Controls.Add(Me.Label10)
        Me.TabPageAnalitcaYPatologias.Controls.Add(Me.tbPatSomaticas)
        Me.TabPageAnalitcaYPatologias.Controls.Add(Me.Label9)
        Me.TabPageAnalitcaYPatologias.Controls.Add(Me.gbxResultadosAnaliticos)
        Me.TabPageAnalitcaYPatologias.Location = New System.Drawing.Point(4, 24)
        Me.TabPageAnalitcaYPatologias.Name = "TabPageAnalitcaYPatologias"
        Me.TabPageAnalitcaYPatologias.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageAnalitcaYPatologias.Size = New System.Drawing.Size(594, 505)
        Me.TabPageAnalitcaYPatologias.TabIndex = 2
        Me.TabPageAnalitcaYPatologias.Text = "Analítica y Patologías"
        '
        'tbPatPsiquiatricas
        '
        Me.tbPatPsiquiatricas.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbPatPsiquiatricas.Location = New System.Drawing.Point(133, 413)
        Me.tbPatPsiquiatricas.Multiline = True
        Me.tbPatPsiquiatricas.Name = "tbPatPsiquiatricas"
        Me.tbPatPsiquiatricas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbPatPsiquiatricas.Size = New System.Drawing.Size(431, 76)
        Me.tbPatPsiquiatricas.TabIndex = 15
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(16, 416)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(77, 30)
        Me.Label24.TabIndex = 14
        Me.Label24.Text = "Patologías" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Psiquíatricas:"
        '
        'tbOtrasPatSomaticas
        '
        Me.tbOtrasPatSomaticas.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbOtrasPatSomaticas.Location = New System.Drawing.Point(133, 331)
        Me.tbOtrasPatSomaticas.Multiline = True
        Me.tbOtrasPatSomaticas.Name = "tbOtrasPatSomaticas"
        Me.tbOtrasPatSomaticas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbOtrasPatSomaticas.Size = New System.Drawing.Size(431, 76)
        Me.tbOtrasPatSomaticas.TabIndex = 13
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(16, 334)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(118, 75)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Otras" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Patologías Somáticas:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Digestivas," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Respiratorias," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cardiocirculatorias)"
        '
        'tbPatSomaticas
        '
        Me.tbPatSomaticas.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbPatSomaticas.Location = New System.Drawing.Point(133, 249)
        Me.tbPatSomaticas.Multiline = True
        Me.tbPatSomaticas.Name = "tbPatSomaticas"
        Me.tbPatSomaticas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbPatSomaticas.Size = New System.Drawing.Size(431, 76)
        Me.tbPatSomaticas.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(16, 252)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(118, 30)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Patologías" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Somáticas Asociadas:"
        '
        'gbxResultadosAnaliticos
        '
        Me.gbxResultadosAnaliticos.Controls.Add(Me.tbBioquimica)
        Me.gbxResultadosAnaliticos.Controls.Add(Me.tbHemograma)
        Me.gbxResultadosAnaliticos.Controls.Add(Me.tbPruebasHepaticas)
        Me.gbxResultadosAnaliticos.Controls.Add(Me.Label8)
        Me.gbxResultadosAnaliticos.Controls.Add(Me.tbMantoux)
        Me.gbxResultadosAnaliticos.Controls.Add(Me.tbLUES)
        Me.gbxResultadosAnaliticos.Controls.Add(Me.Label7)
        Me.gbxResultadosAnaliticos.Controls.Add(Me.tbVHC)
        Me.gbxResultadosAnaliticos.Controls.Add(Me.Label6)
        Me.gbxResultadosAnaliticos.Controls.Add(Me.tbVHB)
        Me.gbxResultadosAnaliticos.Controls.Add(Me.tbVIH)
        Me.gbxResultadosAnaliticos.Controls.Add(Me.Label5)
        Me.gbxResultadosAnaliticos.Controls.Add(Me.Label4)
        Me.gbxResultadosAnaliticos.Controls.Add(Me.Label3)
        Me.gbxResultadosAnaliticos.Controls.Add(Me.Label2)
        Me.gbxResultadosAnaliticos.Controls.Add(Me.Label1)
        Me.gbxResultadosAnaliticos.Location = New System.Drawing.Point(8, 16)
        Me.gbxResultadosAnaliticos.Name = "gbxResultadosAnaliticos"
        Me.gbxResultadosAnaliticos.Size = New System.Drawing.Size(577, 219)
        Me.gbxResultadosAnaliticos.TabIndex = 0
        Me.gbxResultadosAnaliticos.TabStop = False
        Me.gbxResultadosAnaliticos.Text = "Resultados Analíticos Destacables:"
        '
        'tbBioquimica
        '
        Me.tbBioquimica.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbBioquimica.Location = New System.Drawing.Point(125, 165)
        Me.tbBioquimica.Multiline = True
        Me.tbBioquimica.Name = "tbBioquimica"
        Me.tbBioquimica.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbBioquimica.Size = New System.Drawing.Size(431, 40)
        Me.tbBioquimica.TabIndex = 12
        '
        'tbHemograma
        '
        Me.tbHemograma.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbHemograma.Location = New System.Drawing.Point(125, 119)
        Me.tbHemograma.Multiline = True
        Me.tbHemograma.Name = "tbHemograma"
        Me.tbHemograma.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbHemograma.Size = New System.Drawing.Size(431, 40)
        Me.tbHemograma.TabIndex = 11
        '
        'tbPruebasHepaticas
        '
        Me.tbPruebasHepaticas.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbPruebasHepaticas.Location = New System.Drawing.Point(125, 73)
        Me.tbPruebasHepaticas.Multiline = True
        Me.tbPruebasHepaticas.Name = "tbPruebasHepaticas"
        Me.tbPruebasHepaticas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbPruebasHepaticas.Size = New System.Drawing.Size(431, 40)
        Me.tbPruebasHepaticas.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 168)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 15)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Bioquímica:"
        '
        'tbMantoux
        '
        Me.tbMantoux.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbMantoux.Location = New System.Drawing.Point(507, 31)
        Me.tbMantoux.Name = "tbMantoux"
        Me.tbMantoux.Size = New System.Drawing.Size(49, 23)
        Me.tbMantoux.TabIndex = 9
        '
        'tbLUES
        '
        Me.tbLUES.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbLUES.Location = New System.Drawing.Point(385, 31)
        Me.tbLUES.Name = "tbLUES"
        Me.tbLUES.Size = New System.Drawing.Size(49, 23)
        Me.tbLUES.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 122)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 15)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Hemograma:"
        '
        'tbVHC
        '
        Me.tbVHC.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbVHC.Location = New System.Drawing.Point(239, 31)
        Me.tbVHC.Name = "tbVHC"
        Me.tbVHC.Size = New System.Drawing.Size(49, 23)
        Me.tbVHC.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 76)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Pruebas Hepáticas:"
        '
        'tbVHB
        '
        Me.tbVHB.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbVHB.Location = New System.Drawing.Point(146, 31)
        Me.tbVHB.Name = "tbVHB"
        Me.tbVHB.Size = New System.Drawing.Size(49, 23)
        Me.tbVHB.TabIndex = 6
        '
        'tbVIH
        '
        Me.tbVIH.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbVIH.Location = New System.Drawing.Point(53, 31)
        Me.tbVIH.Name = "tbVIH"
        Me.tbVIH.Size = New System.Drawing.Size(49, 23)
        Me.tbVIH.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(440, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "MANTOUX:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(294, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Serologia LUES:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(201, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "VHC:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(108, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "VHB:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "VIH:"
        '
        'TabPageTToActual
        '
        Me.TabPageTToActual.BackColor = System.Drawing.Color.Khaki
        Me.TabPageTToActual.Controls.Add(Me.cbxProgLibreDrogas)
        Me.TabPageTToActual.Controls.Add(Me.cbxReduccion)
        Me.TabPageTToActual.Controls.Add(Me.cbxDesintox)
        Me.TabPageTToActual.Controls.Add(Me.Label30)
        Me.TabPageTToActual.Controls.Add(Me.Label29)
        Me.TabPageTToActual.Controls.Add(Me.Label28)
        Me.TabPageTToActual.Controls.Add(Me.tbTToPsiquiatrico)
        Me.TabPageTToActual.Controls.Add(Me.tbTToEspecifico)
        Me.TabPageTToActual.Controls.Add(Me.tbTToGeneral)
        Me.TabPageTToActual.Controls.Add(Me.Label27)
        Me.TabPageTToActual.Controls.Add(Me.Label26)
        Me.TabPageTToActual.Controls.Add(Me.Label25)
        Me.TabPageTToActual.Location = New System.Drawing.Point(4, 24)
        Me.TabPageTToActual.Name = "TabPageTToActual"
        Me.TabPageTToActual.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageTToActual.Size = New System.Drawing.Size(594, 505)
        Me.TabPageTToActual.TabIndex = 5
        Me.TabPageTToActual.Text = "Tratamiento Actual"
        '
        'cbxProgLibreDrogas
        '
        Me.cbxProgLibreDrogas.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cbxProgLibreDrogas.FormattingEnabled = True
        Me.cbxProgLibreDrogas.Items.AddRange(New Object() {"", "Sí", "No"})
        Me.cbxProgLibreDrogas.Location = New System.Drawing.Point(207, 367)
        Me.cbxProgLibreDrogas.Name = "cbxProgLibreDrogas"
        Me.cbxProgLibreDrogas.Size = New System.Drawing.Size(61, 23)
        Me.cbxProgLibreDrogas.TabIndex = 11
        '
        'cbxReduccion
        '
        Me.cbxReduccion.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cbxReduccion.FormattingEnabled = True
        Me.cbxReduccion.Items.AddRange(New Object() {"", "Sí", "No"})
        Me.cbxReduccion.Location = New System.Drawing.Point(159, 327)
        Me.cbxReduccion.Name = "cbxReduccion"
        Me.cbxReduccion.Size = New System.Drawing.Size(61, 23)
        Me.cbxReduccion.TabIndex = 10
        '
        'cbxDesintox
        '
        Me.cbxDesintox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cbxDesintox.FormattingEnabled = True
        Me.cbxDesintox.Items.AddRange(New Object() {"", "Sí", "No"})
        Me.cbxDesintox.Location = New System.Drawing.Point(159, 289)
        Me.cbxDesintox.Name = "cbxDesintox"
        Me.cbxDesintox.Size = New System.Drawing.Size(61, 23)
        Me.cbxDesintox.TabIndex = 9
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(16, 370)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(185, 15)
        Me.Label30.TabIndex = 8
        Me.Label30.Text = "¿Desea Programa Libre de Drogas?"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(16, 330)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(106, 15)
        Me.Label29.TabIndex = 7
        Me.Label29.Text = "¿Desea Reducción?"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(16, 292)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(137, 15)
        Me.Label28.TabIndex = 6
        Me.Label28.Text = "¿Desea Desintoxicación?"
        '
        'tbTToPsiquiatrico
        '
        Me.tbTToPsiquiatrico.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbTToPsiquiatrico.Location = New System.Drawing.Point(102, 190)
        Me.tbTToPsiquiatrico.Multiline = True
        Me.tbTToPsiquiatrico.Name = "tbTToPsiquiatrico"
        Me.tbTToPsiquiatrico.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbTToPsiquiatrico.Size = New System.Drawing.Size(474, 63)
        Me.tbTToPsiquiatrico.TabIndex = 5
        '
        'tbTToEspecifico
        '
        Me.tbTToEspecifico.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbTToEspecifico.Location = New System.Drawing.Point(102, 103)
        Me.tbTToEspecifico.Multiline = True
        Me.tbTToEspecifico.Name = "tbTToEspecifico"
        Me.tbTToEspecifico.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbTToEspecifico.Size = New System.Drawing.Size(474, 63)
        Me.tbTToEspecifico.TabIndex = 4
        '
        'tbTToGeneral
        '
        Me.tbTToGeneral.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbTToGeneral.Location = New System.Drawing.Point(102, 23)
        Me.tbTToGeneral.Multiline = True
        Me.tbTToGeneral.Name = "tbTToGeneral"
        Me.tbTToGeneral.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbTToGeneral.Size = New System.Drawing.Size(474, 63)
        Me.tbTToGeneral.TabIndex = 3
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(16, 106)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(66, 15)
        Me.Label27.TabIndex = 2
        Me.Label27.Text = "Específico:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(16, 193)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(72, 15)
        Me.Label26.TabIndex = 1
        Me.Label26.Text = "Psiquiátrico:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(16, 26)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(50, 15)
        Me.Label25.TabIndex = 0
        Me.Label25.Text = "General:"
        '
        'TabPageSeguimiento
        '
        Me.TabPageSeguimiento.BackColor = System.Drawing.Color.Khaki
        Me.TabPageSeguimiento.Controls.Add(Me.lbSeguimiento)
        Me.TabPageSeguimiento.Controls.Add(Me.lbObservaciones)
        Me.TabPageSeguimiento.Controls.Add(Me.tbSeguimiento)
        Me.TabPageSeguimiento.Controls.Add(Me.tbObservaciones)
        Me.TabPageSeguimiento.Location = New System.Drawing.Point(4, 24)
        Me.TabPageSeguimiento.Name = "TabPageSeguimiento"
        Me.TabPageSeguimiento.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageSeguimiento.Size = New System.Drawing.Size(594, 505)
        Me.TabPageSeguimiento.TabIndex = 3
        Me.TabPageSeguimiento.Text = "Seguimiento"
        '
        'lbSeguimiento
        '
        Me.lbSeguimiento.AutoSize = True
        Me.lbSeguimiento.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSeguimiento.Location = New System.Drawing.Point(8, 3)
        Me.lbSeguimiento.Name = "lbSeguimiento"
        Me.lbSeguimiento.Size = New System.Drawing.Size(74, 15)
        Me.lbSeguimiento.TabIndex = 10
        Me.lbSeguimiento.Text = "Seguimiento:"
        '
        'lbObservaciones
        '
        Me.lbObservaciones.AutoSize = True
        Me.lbObservaciones.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbObservaciones.Location = New System.Drawing.Point(8, 257)
        Me.lbObservaciones.Name = "lbObservaciones"
        Me.lbObservaciones.Size = New System.Drawing.Size(86, 15)
        Me.lbObservaciones.TabIndex = 11
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
        Me.tbSeguimiento.TabIndex = 0
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
        Me.tbObservaciones.TabIndex = 1
        '
        'formHistoriaMedica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Peru
        Me.ClientSize = New System.Drawing.Size(601, 605)
        Me.ContextMenuStrip = Me.cmsWord
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btActualizar)
        Me.Controls.Add(Me.btControlCitas)
        Me.Controls.Add(Me.btHsPs)
        Me.Controls.Add(Me.btHsSocial)
        Me.Controls.Add(Me.lbFechaUltCita)
        Me.Controls.Add(Me.tbHistoria)
        Me.Controls.Add(Me.tbUltimaCita)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "formHistoriaMedica"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "formHistoriaMedica"
        Me.cmsRecargarCitaMd.ResumeLayout(False)
        Me.cmsWord.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPageAntecedentesYExploracion.ResumeLayout(False)
        Me.TabPageAntecedentesYExploracion.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPageAnalitcaYPatologias.ResumeLayout(False)
        Me.TabPageAnalitcaYPatologias.PerformLayout()
        Me.gbxResultadosAnaliticos.ResumeLayout(False)
        Me.gbxResultadosAnaliticos.PerformLayout()
        Me.TabPageTToActual.ResumeLayout(False)
        Me.TabPageTToActual.PerformLayout()
        Me.TabPageSeguimiento.ResumeLayout(False)
        Me.TabPageSeguimiento.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btControlCitas As System.Windows.Forms.Button
    Friend WithEvents btHsPs As System.Windows.Forms.Button
    Friend WithEvents btHsSocial As System.Windows.Forms.Button
    Friend WithEvents lbFechaUltCita As System.Windows.Forms.Label
    Friend WithEvents tbUltimaCita As System.Windows.Forms.TextBox
    Friend WithEvents tbHistoria As System.Windows.Forms.TextBox
    Friend WithEvents btActualizar As System.Windows.Forms.Button
    Friend WithEvents cmsRecargarCitaMd As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RecargarÚltimaCitaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsWord As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ExportarHistoriaMédicaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPageAnalitcaYPatologias As System.Windows.Forms.TabPage
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents gbxResultadosAnaliticos As System.Windows.Forms.GroupBox
    Friend WithEvents tbMantoux As System.Windows.Forms.TextBox
    Friend WithEvents tbLUES As System.Windows.Forms.TextBox
    Friend WithEvents tbVHC As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tbVHB As System.Windows.Forms.TextBox
    Friend WithEvents tbVIH As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TabPageSeguimiento As System.Windows.Forms.TabPage
    Friend WithEvents lbSeguimiento As System.Windows.Forms.Label
    Friend WithEvents lbObservaciones As System.Windows.Forms.Label
    Friend WithEvents tbSeguimiento As System.Windows.Forms.TextBox
    Friend WithEvents tbObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents tbBioquimica As System.Windows.Forms.TextBox
    Friend WithEvents tbHemograma As System.Windows.Forms.TextBox
    Friend WithEvents tbPruebasHepaticas As System.Windows.Forms.TextBox
    Friend WithEvents tbOtrasPatSomaticas As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tbPatSomaticas As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TabPageAntecedentesYExploracion As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tbAdenopatias As System.Windows.Forms.TextBox
    Friend WithEvents cbxTatuajes As System.Windows.Forms.ComboBox
    Friend WithEvents cbxCaries As System.Windows.Forms.ComboBox
    Friend WithEvents cbxVenopuncion As System.Windows.Forms.ComboBox
    Friend WithEvents tbTemperatura As System.Windows.Forms.TextBox
    Friend WithEvents tbTA As System.Windows.Forms.TextBox
    Friend WithEvents tbPulso As System.Windows.Forms.TextBox
    Friend WithEvents tbTalla As System.Windows.Forms.TextBox
    Friend WithEvents tbPeso As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents tbCirugia As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cbxHospitalizaciones As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents tbAlergias As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents tbAntecedentesInteres As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tbPatPsiquiatricas As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents TabPageTToActual As System.Windows.Forms.TabPage
    Friend WithEvents cbxProgLibreDrogas As System.Windows.Forms.ComboBox
    Friend WithEvents cbxReduccion As System.Windows.Forms.ComboBox
    Friend WithEvents cbxDesintox As System.Windows.Forms.ComboBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents tbTToPsiquiatrico As System.Windows.Forms.TextBox
    Friend WithEvents tbTToEspecifico As System.Windows.Forms.TextBox
    Friend WithEvents tbTToGeneral As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
End Class
