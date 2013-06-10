<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formControlCitas
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formControlCitas))
        Me.lbHistoria = New System.Windows.Forms.Label()
        Me.tbHistoria = New System.Windows.Forms.TextBox()
        Me.dgvCitas = New System.Windows.Forms.DataGridView()
        Me.cmsMarcarNoAsistencia = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NoAcudeAÚltimaCitaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcudeAÚltimaCitaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btFormalizarCita = New System.Windows.Forms.Button()
        Me.lbProxCita = New System.Windows.Forms.Label()
        Me.tbProxCita = New System.Windows.Forms.TextBox()
        Me.lbTecnico = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbHoraCita = New System.Windows.Forms.TextBox()
        Me.cbxTecnico = New System.Windows.Forms.ComboBox()
        Me.btVer = New System.Windows.Forms.Button()
        Me.CanceladaConJustificaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BorrarCitaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgvCitas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsMarcarNoAsistencia.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbHistoria
        '
        Me.lbHistoria.AutoSize = True
        Me.lbHistoria.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbHistoria.Location = New System.Drawing.Point(23, 18)
        Me.lbHistoria.Name = "lbHistoria"
        Me.lbHistoria.Size = New System.Drawing.Size(69, 15)
        Me.lbHistoria.TabIndex = 0
        Me.lbHistoria.Text = "Nº Historia:"
        '
        'tbHistoria
        '
        Me.tbHistoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbHistoria.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbHistoria.Location = New System.Drawing.Point(89, 15)
        Me.tbHistoria.Name = "tbHistoria"
        Me.tbHistoria.ReadOnly = True
        Me.tbHistoria.Size = New System.Drawing.Size(100, 23)
        Me.tbHistoria.TabIndex = 0
        '
        'dgvCitas
        '
        Me.dgvCitas.AllowUserToAddRows = False
        Me.dgvCitas.AllowUserToDeleteRows = False
        Me.dgvCitas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCitas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCitas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCitas.ContextMenuStrip = Me.cmsMarcarNoAsistencia
        Me.dgvCitas.Location = New System.Drawing.Point(26, 42)
        Me.dgvCitas.Name = "dgvCitas"
        Me.dgvCitas.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCitas.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvCitas.RowHeadersVisible = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.dgvCitas.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvCitas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvCitas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCitas.Size = New System.Drawing.Size(485, 147)
        Me.dgvCitas.TabIndex = 3
        '
        'cmsMarcarNoAsistencia
        '
        Me.cmsMarcarNoAsistencia.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NoAcudeAÚltimaCitaToolStripMenuItem, Me.AcudeAÚltimaCitaToolStripMenuItem, Me.CanceladaConJustificaciónToolStripMenuItem, Me.BorrarCitaToolStripMenuItem})
        Me.cmsMarcarNoAsistencia.Name = "cmsMarcarNoAsistencia"
        Me.cmsMarcarNoAsistencia.Size = New System.Drawing.Size(221, 92)
        '
        'NoAcudeAÚltimaCitaToolStripMenuItem
        '
        Me.NoAcudeAÚltimaCitaToolStripMenuItem.Name = "NoAcudeAÚltimaCitaToolStripMenuItem"
        Me.NoAcudeAÚltimaCitaToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.NoAcudeAÚltimaCitaToolStripMenuItem.Text = "No acude a última cita"
        '
        'AcudeAÚltimaCitaToolStripMenuItem
        '
        Me.AcudeAÚltimaCitaToolStripMenuItem.Name = "AcudeAÚltimaCitaToolStripMenuItem"
        Me.AcudeAÚltimaCitaToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.AcudeAÚltimaCitaToolStripMenuItem.Text = "Acude a última cita"
        '
        'btFormalizarCita
        '
        Me.btFormalizarCita.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btFormalizarCita.Location = New System.Drawing.Point(423, 197)
        Me.btFormalizarCita.Name = "btFormalizarCita"
        Me.btFormalizarCita.Size = New System.Drawing.Size(88, 23)
        Me.btFormalizarCita.TabIndex = 6
        Me.btFormalizarCita.Text = "Formalizar Cita"
        Me.btFormalizarCita.UseVisualStyleBackColor = True
        '
        'lbProxCita
        '
        Me.lbProxCita.AutoSize = True
        Me.lbProxCita.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbProxCita.Location = New System.Drawing.Point(143, 200)
        Me.lbProxCita.Name = "lbProxCita"
        Me.lbProxCita.Size = New System.Drawing.Size(76, 15)
        Me.lbProxCita.TabIndex = 4
        Me.lbProxCita.Text = "Próxima Cita:"
        '
        'tbProxCita
        '
        Me.tbProxCita.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbProxCita.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbProxCita.Location = New System.Drawing.Point(217, 197)
        Me.tbProxCita.Name = "tbProxCita"
        Me.tbProxCita.Size = New System.Drawing.Size(100, 23)
        Me.tbProxCita.TabIndex = 4
        '
        'lbTecnico
        '
        Me.lbTecnico.AutoSize = True
        Me.lbTecnico.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTecnico.Location = New System.Drawing.Point(208, 18)
        Me.lbTecnico.Name = "lbTecnico"
        Me.lbTecnico.Size = New System.Drawing.Size(51, 15)
        Me.lbTecnico.TabIndex = 7
        Me.lbTecnico.Text = "Técnico:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(323, 200)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 15)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Hora:"
        '
        'tbHoraCita
        '
        Me.tbHoraCita.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbHoraCita.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbHoraCita.Location = New System.Drawing.Point(362, 197)
        Me.tbHoraCita.Name = "tbHoraCita"
        Me.tbHoraCita.Size = New System.Drawing.Size(52, 23)
        Me.tbHoraCita.TabIndex = 5
        '
        'cbxTecnico
        '
        Me.cbxTecnico.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cbxTecnico.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxTecnico.FormattingEnabled = True
        Me.cbxTecnico.Location = New System.Drawing.Point(263, 15)
        Me.cbxTecnico.Name = "cbxTecnico"
        Me.cbxTecnico.Size = New System.Drawing.Size(197, 23)
        Me.cbxTecnico.TabIndex = 1
        '
        'btVer
        '
        Me.btVer.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btVer.Location = New System.Drawing.Point(475, 15)
        Me.btVer.Name = "btVer"
        Me.btVer.Size = New System.Drawing.Size(36, 23)
        Me.btVer.TabIndex = 2
        Me.btVer.Text = "Ver"
        Me.btVer.UseVisualStyleBackColor = True
        '
        'CanceladaConJustificaciónToolStripMenuItem
        '
        Me.CanceladaConJustificaciónToolStripMenuItem.Name = "CanceladaConJustificaciónToolStripMenuItem"
        Me.CanceladaConJustificaciónToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.CanceladaConJustificaciónToolStripMenuItem.Text = "Cancelada con Justificación"
        '
        'BorrarCitaToolStripMenuItem
        '
        Me.BorrarCitaToolStripMenuItem.Name = "BorrarCitaToolStripMenuItem"
        Me.BorrarCitaToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.BorrarCitaToolStripMenuItem.Text = "Borrar Cita"
        '
        'formControlCitas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Peru
        Me.ClientSize = New System.Drawing.Size(531, 234)
        Me.Controls.Add(Me.btVer)
        Me.Controls.Add(Me.cbxTecnico)
        Me.Controls.Add(Me.tbHoraCita)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbTecnico)
        Me.Controls.Add(Me.tbProxCita)
        Me.Controls.Add(Me.lbProxCita)
        Me.Controls.Add(Me.btFormalizarCita)
        Me.Controls.Add(Me.dgvCitas)
        Me.Controls.Add(Me.tbHistoria)
        Me.Controls.Add(Me.lbHistoria)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "formControlCitas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Control de Citas"
        CType(Me.dgvCitas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsMarcarNoAsistencia.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbHistoria As System.Windows.Forms.Label
    Friend WithEvents tbHistoria As System.Windows.Forms.TextBox
    Friend WithEvents dgvCitas As System.Windows.Forms.DataGridView
    Friend WithEvents btFormalizarCita As System.Windows.Forms.Button
    Friend WithEvents lbProxCita As System.Windows.Forms.Label
    Friend WithEvents tbProxCita As System.Windows.Forms.TextBox
    Friend WithEvents lbTecnico As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbHoraCita As System.Windows.Forms.TextBox
    Friend WithEvents cbxTecnico As System.Windows.Forms.ComboBox
    Friend WithEvents btVer As System.Windows.Forms.Button
    Friend WithEvents cmsMarcarNoAsistencia As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents NoAcudeAÚltimaCitaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcudeAÚltimaCitaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CanceladaConJustificaciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BorrarCitaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
