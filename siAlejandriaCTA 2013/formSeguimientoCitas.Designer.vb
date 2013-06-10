<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formSeguimientoCitas
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formSeguimientoCitas))
        Me.btVer = New System.Windows.Forms.Button()
        Me.lbHistoria = New System.Windows.Forms.Label()
        Me.lbTecnico = New System.Windows.Forms.Label()
        Me.dgvCitas = New System.Windows.Forms.DataGridView()
        Me.tbHistoria = New System.Windows.Forms.TextBox()
        Me.cbxTecnico = New System.Windows.Forms.ComboBox()
        Me.btExcel = New System.Windows.Forms.Button()
        CType(Me.dgvCitas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btVer
        '
        Me.btVer.Location = New System.Drawing.Point(512, 24)
        Me.btVer.Name = "btVer"
        Me.btVer.Size = New System.Drawing.Size(45, 24)
        Me.btVer.TabIndex = 2
        Me.btVer.Text = "Ver"
        Me.btVer.UseVisualStyleBackColor = True
        '
        'lbHistoria
        '
        Me.lbHistoria.AutoSize = True
        Me.lbHistoria.Location = New System.Drawing.Point(14, 28)
        Me.lbHistoria.Name = "lbHistoria"
        Me.lbHistoria.Size = New System.Drawing.Size(69, 15)
        Me.lbHistoria.TabIndex = 1
        Me.lbHistoria.Text = "Nº Historia:"
        '
        'lbTecnico
        '
        Me.lbTecnico.AutoSize = True
        Me.lbTecnico.Location = New System.Drawing.Point(225, 28)
        Me.lbTecnico.Name = "lbTecnico"
        Me.lbTecnico.Size = New System.Drawing.Size(51, 15)
        Me.lbTecnico.TabIndex = 2
        Me.lbTecnico.Text = "Técnico:"
        '
        'dgvCitas
        '
        Me.dgvCitas.AllowUserToAddRows = False
        Me.dgvCitas.AllowUserToDeleteRows = False
        Me.dgvCitas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCitas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.dgvCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCitas.Location = New System.Drawing.Point(17, 54)
        Me.dgvCitas.Name = "dgvCitas"
        Me.dgvCitas.ReadOnly = True
        Me.dgvCitas.RowHeadersVisible = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.dgvCitas.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCitas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvCitas.Size = New System.Drawing.Size(540, 253)
        Me.dgvCitas.TabIndex = 3
        '
        'tbHistoria
        '
        Me.tbHistoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbHistoria.Location = New System.Drawing.Point(91, 24)
        Me.tbHistoria.Name = "tbHistoria"
        Me.tbHistoria.Size = New System.Drawing.Size(116, 23)
        Me.tbHistoria.TabIndex = 0
        '
        'cbxTecnico
        '
        Me.cbxTecnico.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cbxTecnico.FormattingEnabled = True
        Me.cbxTecnico.Location = New System.Drawing.Point(286, 24)
        Me.cbxTecnico.Name = "cbxTecnico"
        Me.cbxTecnico.Size = New System.Drawing.Size(206, 23)
        Me.cbxTecnico.TabIndex = 1
        '
        'btExcel
        '
        Me.btExcel.Location = New System.Drawing.Point(463, 323)
        Me.btExcel.Name = "btExcel"
        Me.btExcel.Size = New System.Drawing.Size(94, 24)
        Me.btExcel.TabIndex = 4
        Me.btExcel.Text = "Generar Excel"
        Me.btExcel.UseVisualStyleBackColor = True
        '
        'formSeguimientoCitas
        '
        Me.AcceptButton = Me.btVer
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Peru
        Me.ClientSize = New System.Drawing.Size(579, 361)
        Me.Controls.Add(Me.btExcel)
        Me.Controls.Add(Me.cbxTecnico)
        Me.Controls.Add(Me.tbHistoria)
        Me.Controls.Add(Me.dgvCitas)
        Me.Controls.Add(Me.lbTecnico)
        Me.Controls.Add(Me.lbHistoria)
        Me.Controls.Add(Me.btVer)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "formSeguimientoCitas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seguimiento de citas por paciente"
        CType(Me.dgvCitas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btVer As System.Windows.Forms.Button
    Friend WithEvents lbHistoria As System.Windows.Forms.Label
    Friend WithEvents lbTecnico As System.Windows.Forms.Label
    Friend WithEvents dgvCitas As System.Windows.Forms.DataGridView
    Friend WithEvents tbHistoria As System.Windows.Forms.TextBox
    Friend WithEvents cbxTecnico As System.Windows.Forms.ComboBox
    Friend WithEvents btExcel As System.Windows.Forms.Button
End Class
