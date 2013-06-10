<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formGruposTerapia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formGruposTerapia))
        Me.btAñadirTerapia = New System.Windows.Forms.Button()
        Me.btAñadirPac = New System.Windows.Forms.Button()
        Me.btAsistencia = New System.Windows.Forms.Button()
        Me.lbNombre = New System.Windows.Forms.Label()
        Me.lbTecnico = New System.Windows.Forms.Label()
        Me.tbNombreGrupo = New System.Windows.Forms.TextBox()
        Me.cbxTecnico = New System.Windows.Forms.ComboBox()
        Me.btCrearGrupo = New System.Windows.Forms.Button()
        Me.cbxGrupos = New System.Windows.Forms.ComboBox()
        Me.btVerGrupo = New System.Windows.Forms.Button()
        Me.lbHistoria = New System.Windows.Forms.Label()
        Me.lbFecha = New System.Windows.Forms.Label()
        Me.lbHora = New System.Windows.Forms.Label()
        Me.btIncluir = New System.Windows.Forms.Button()
        Me.tbHistoria = New System.Windows.Forms.TextBox()
        Me.tbHoraTerapia = New System.Windows.Forms.TextBox()
        Me.dtpFechaTerapia = New System.Windows.Forms.DateTimePicker()
        Me.lbTerapia = New System.Windows.Forms.Label()
        Me.cbxGruposTerap = New System.Windows.Forms.ComboBox()
        Me.lbGrTrp = New System.Windows.Forms.Label()
        Me.dtpAsistenTerap = New System.Windows.Forms.DateTimePicker()
        Me.lbFechaAsistTerap = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btAñadirTerapia
        '
        Me.btAñadirTerapia.Location = New System.Drawing.Point(12, 12)
        Me.btAñadirTerapia.Name = "btAñadirTerapia"
        Me.btAñadirTerapia.Size = New System.Drawing.Size(79, 57)
        Me.btAñadirTerapia.TabIndex = 0
        Me.btAñadirTerapia.Text = "Añadir Grupo de Terapia"
        Me.btAñadirTerapia.UseVisualStyleBackColor = True
        '
        'btAñadirPac
        '
        Me.btAñadirPac.Location = New System.Drawing.Point(12, 75)
        Me.btAñadirPac.Name = "btAñadirPac"
        Me.btAñadirPac.Size = New System.Drawing.Size(79, 57)
        Me.btAñadirPac.TabIndex = 3
        Me.btAñadirPac.Text = "Incluir Paciente en Terapia"
        Me.btAñadirPac.UseVisualStyleBackColor = True
        '
        'btAsistencia
        '
        Me.btAsistencia.Location = New System.Drawing.Point(12, 138)
        Me.btAsistencia.Name = "btAsistencia"
        Me.btAsistencia.Size = New System.Drawing.Size(79, 57)
        Me.btAsistencia.TabIndex = 9
        Me.btAsistencia.Text = "Validar Asistencia a Terapia"
        Me.btAsistencia.UseVisualStyleBackColor = True
        '
        'lbNombre
        '
        Me.lbNombre.AutoSize = True
        Me.lbNombre.Location = New System.Drawing.Point(98, 32)
        Me.lbNombre.Name = "lbNombre"
        Me.lbNombre.Size = New System.Drawing.Size(102, 15)
        Me.lbNombre.TabIndex = 3
        Me.lbNombre.Text = "Nombre del Grupo:"
        Me.lbNombre.Visible = False
        '
        'lbTecnico
        '
        Me.lbTecnico.AutoSize = True
        Me.lbTecnico.Location = New System.Drawing.Point(345, 32)
        Me.lbTecnico.Name = "lbTecnico"
        Me.lbTecnico.Size = New System.Drawing.Size(114, 15)
        Me.lbTecnico.TabIndex = 4
        Me.lbTecnico.Text = "Técnico que imparte:"
        Me.lbTecnico.Visible = False
        '
        'tbNombreGrupo
        '
        Me.tbNombreGrupo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbNombreGrupo.Location = New System.Drawing.Point(206, 28)
        Me.tbNombreGrupo.Name = "tbNombreGrupo"
        Me.tbNombreGrupo.Size = New System.Drawing.Size(116, 23)
        Me.tbNombreGrupo.TabIndex = 1
        Me.tbNombreGrupo.Visible = False
        '
        'cbxTecnico
        '
        Me.cbxTecnico.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cbxTecnico.FormattingEnabled = True
        Me.cbxTecnico.Location = New System.Drawing.Point(465, 28)
        Me.cbxTecnico.Name = "cbxTecnico"
        Me.cbxTecnico.Size = New System.Drawing.Size(175, 23)
        Me.cbxTecnico.TabIndex = 2
        Me.cbxTecnico.Visible = False
        '
        'btCrearGrupo
        '
        Me.btCrearGrupo.Location = New System.Drawing.Point(659, 26)
        Me.btCrearGrupo.Name = "btCrearGrupo"
        Me.btCrearGrupo.Size = New System.Drawing.Size(56, 25)
        Me.btCrearGrupo.TabIndex = 2
        Me.btCrearGrupo.Text = "Crear"
        Me.btCrearGrupo.UseVisualStyleBackColor = True
        Me.btCrearGrupo.Visible = False
        '
        'cbxGrupos
        '
        Me.cbxGrupos.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cbxGrupos.FormattingEnabled = True
        Me.cbxGrupos.Location = New System.Drawing.Point(206, 154)
        Me.cbxGrupos.Name = "cbxGrupos"
        Me.cbxGrupos.Size = New System.Drawing.Size(223, 23)
        Me.cbxGrupos.TabIndex = 10
        Me.cbxGrupos.Visible = False
        '
        'btVerGrupo
        '
        Me.btVerGrupo.Location = New System.Drawing.Point(661, 154)
        Me.btVerGrupo.Name = "btVerGrupo"
        Me.btVerGrupo.Size = New System.Drawing.Size(54, 25)
        Me.btVerGrupo.TabIndex = 12
        Me.btVerGrupo.Text = "Ver"
        Me.btVerGrupo.UseVisualStyleBackColor = True
        Me.btVerGrupo.Visible = False
        '
        'lbHistoria
        '
        Me.lbHistoria.AutoSize = True
        Me.lbHistoria.Location = New System.Drawing.Point(98, 82)
        Me.lbHistoria.Name = "lbHistoria"
        Me.lbHistoria.Size = New System.Drawing.Size(69, 15)
        Me.lbHistoria.TabIndex = 10
        Me.lbHistoria.Text = "Nº Historia:"
        Me.lbHistoria.Visible = False
        '
        'lbFecha
        '
        Me.lbFecha.AutoSize = True
        Me.lbFecha.Location = New System.Drawing.Point(98, 112)
        Me.lbFecha.Name = "lbFecha"
        Me.lbFecha.Size = New System.Drawing.Size(83, 15)
        Me.lbFecha.TabIndex = 11
        Me.lbFecha.Text = "Fecha Terapia:"
        Me.lbFecha.Visible = False
        '
        'lbHora
        '
        Me.lbHora.AutoSize = True
        Me.lbHora.Location = New System.Drawing.Point(339, 112)
        Me.lbHora.Name = "lbHora"
        Me.lbHora.Size = New System.Drawing.Size(78, 15)
        Me.lbHora.TabIndex = 12
        Me.lbHora.Text = "Hora Terapia:"
        Me.lbHora.Visible = False
        '
        'btIncluir
        '
        Me.btIncluir.Location = New System.Drawing.Point(659, 107)
        Me.btIncluir.Name = "btIncluir"
        Me.btIncluir.Size = New System.Drawing.Size(56, 25)
        Me.btIncluir.TabIndex = 8
        Me.btIncluir.Text = "Incluir"
        Me.btIncluir.UseVisualStyleBackColor = True
        Me.btIncluir.Visible = False
        '
        'tbHistoria
        '
        Me.tbHistoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbHistoria.Location = New System.Drawing.Point(197, 78)
        Me.tbHistoria.Name = "tbHistoria"
        Me.tbHistoria.Size = New System.Drawing.Size(96, 23)
        Me.tbHistoria.TabIndex = 4
        Me.tbHistoria.Visible = False
        '
        'tbHoraTerapia
        '
        Me.tbHoraTerapia.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbHoraTerapia.Location = New System.Drawing.Point(430, 108)
        Me.tbHoraTerapia.Name = "tbHoraTerapia"
        Me.tbHoraTerapia.Size = New System.Drawing.Size(63, 23)
        Me.tbHoraTerapia.TabIndex = 7
        Me.tbHoraTerapia.Visible = False
        '
        'dtpFechaTerapia
        '
        Me.dtpFechaTerapia.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.dtpFechaTerapia.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaTerapia.Location = New System.Drawing.Point(197, 108)
        Me.dtpFechaTerapia.Name = "dtpFechaTerapia"
        Me.dtpFechaTerapia.Size = New System.Drawing.Size(96, 23)
        Me.dtpFechaTerapia.TabIndex = 6
        Me.dtpFechaTerapia.Visible = False
        '
        'lbTerapia
        '
        Me.lbTerapia.AutoSize = True
        Me.lbTerapia.Location = New System.Drawing.Point(314, 82)
        Me.lbTerapia.Name = "lbTerapia"
        Me.lbTerapia.Size = New System.Drawing.Size(99, 15)
        Me.lbTerapia.TabIndex = 17
        Me.lbTerapia.Text = "Grupo de Terapia:"
        Me.lbTerapia.Visible = False
        '
        'cbxGruposTerap
        '
        Me.cbxGruposTerap.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cbxGruposTerap.FormattingEnabled = True
        Me.cbxGruposTerap.Location = New System.Drawing.Point(430, 78)
        Me.cbxGruposTerap.Name = "cbxGruposTerap"
        Me.cbxGruposTerap.Size = New System.Drawing.Size(175, 23)
        Me.cbxGruposTerap.TabIndex = 5
        Me.cbxGruposTerap.Visible = False
        '
        'lbGrTrp
        '
        Me.lbGrTrp.AutoSize = True
        Me.lbGrTrp.Location = New System.Drawing.Point(98, 158)
        Me.lbGrTrp.Name = "lbGrTrp"
        Me.lbGrTrp.Size = New System.Drawing.Size(99, 15)
        Me.lbGrTrp.TabIndex = 19
        Me.lbGrTrp.Text = "Grupo de Terapia:"
        Me.lbGrTrp.Visible = False
        '
        'dtpAsistenTerap
        '
        Me.dtpAsistenTerap.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.dtpAsistenTerap.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpAsistenTerap.Location = New System.Drawing.Point(544, 154)
        Me.dtpAsistenTerap.Name = "dtpAsistenTerap"
        Me.dtpAsistenTerap.Size = New System.Drawing.Size(96, 23)
        Me.dtpAsistenTerap.TabIndex = 11
        Me.dtpAsistenTerap.Visible = False
        '
        'lbFechaAsistTerap
        '
        Me.lbFechaAsistTerap.AutoSize = True
        Me.lbFechaAsistTerap.Location = New System.Drawing.Point(455, 158)
        Me.lbFechaAsistTerap.Name = "lbFechaAsistTerap"
        Me.lbFechaAsistTerap.Size = New System.Drawing.Size(83, 15)
        Me.lbFechaAsistTerap.TabIndex = 20
        Me.lbFechaAsistTerap.Text = "Fecha Terapia:"
        Me.lbFechaAsistTerap.Visible = False
        '
        'formGruposTerapia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Peru
        Me.ClientSize = New System.Drawing.Size(734, 208)
        Me.Controls.Add(Me.dtpAsistenTerap)
        Me.Controls.Add(Me.lbFechaAsistTerap)
        Me.Controls.Add(Me.lbGrTrp)
        Me.Controls.Add(Me.cbxGruposTerap)
        Me.Controls.Add(Me.lbTerapia)
        Me.Controls.Add(Me.dtpFechaTerapia)
        Me.Controls.Add(Me.tbHoraTerapia)
        Me.Controls.Add(Me.tbHistoria)
        Me.Controls.Add(Me.btIncluir)
        Me.Controls.Add(Me.lbHora)
        Me.Controls.Add(Me.lbFecha)
        Me.Controls.Add(Me.lbHistoria)
        Me.Controls.Add(Me.btVerGrupo)
        Me.Controls.Add(Me.cbxGrupos)
        Me.Controls.Add(Me.btCrearGrupo)
        Me.Controls.Add(Me.cbxTecnico)
        Me.Controls.Add(Me.tbNombreGrupo)
        Me.Controls.Add(Me.lbTecnico)
        Me.Controls.Add(Me.lbNombre)
        Me.Controls.Add(Me.btAsistencia)
        Me.Controls.Add(Me.btAñadirPac)
        Me.Controls.Add(Me.btAñadirTerapia)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "formGruposTerapia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Grupos de Terapia"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btAñadirTerapia As System.Windows.Forms.Button
    Friend WithEvents btAñadirPac As System.Windows.Forms.Button
    Friend WithEvents btAsistencia As System.Windows.Forms.Button
    Friend WithEvents lbNombre As System.Windows.Forms.Label
    Friend WithEvents lbTecnico As System.Windows.Forms.Label
    Friend WithEvents tbNombreGrupo As System.Windows.Forms.TextBox
    Friend WithEvents cbxTecnico As System.Windows.Forms.ComboBox
    Friend WithEvents btCrearGrupo As System.Windows.Forms.Button
    Friend WithEvents cbxGrupos As System.Windows.Forms.ComboBox
    Friend WithEvents btVerGrupo As System.Windows.Forms.Button
    Friend WithEvents lbHistoria As System.Windows.Forms.Label
    Friend WithEvents lbFecha As System.Windows.Forms.Label
    Friend WithEvents lbHora As System.Windows.Forms.Label
    Friend WithEvents btIncluir As System.Windows.Forms.Button
    Friend WithEvents tbHistoria As System.Windows.Forms.TextBox
    Friend WithEvents tbHoraTerapia As System.Windows.Forms.TextBox
    Friend WithEvents dtpFechaTerapia As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbTerapia As System.Windows.Forms.Label
    Friend WithEvents cbxGruposTerap As System.Windows.Forms.ComboBox
    Friend WithEvents lbGrTrp As System.Windows.Forms.Label
    Friend WithEvents dtpAsistenTerap As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbFechaAsistTerap As System.Windows.Forms.Label
End Class
