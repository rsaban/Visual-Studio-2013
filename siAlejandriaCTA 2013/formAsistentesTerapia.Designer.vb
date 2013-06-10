<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formAsistentesTerapia
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formAsistentesTerapia))
        Me.dgvAsistentes = New System.Windows.Forms.DataGridView()
        Me.btValidarAsistencia = New System.Windows.Forms.Button()
        Me.tbIdTerapia = New System.Windows.Forms.TextBox()
        Me.tbFechaTerapia = New System.Windows.Forms.TextBox()
        Me.tbIdPac = New System.Windows.Forms.TextBox()
        CType(Me.dgvAsistentes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvAsistentes
        '
        Me.dgvAsistentes.AllowUserToAddRows = False
        Me.dgvAsistentes.AllowUserToDeleteRows = False
        Me.dgvAsistentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvAsistentes.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAsistentes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvAsistentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAsistentes.Location = New System.Drawing.Point(12, 21)
        Me.dgvAsistentes.Name = "dgvAsistentes"
        Me.dgvAsistentes.RowHeadersVisible = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.dgvAsistentes.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvAsistentes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvAsistentes.Size = New System.Drawing.Size(362, 397)
        Me.dgvAsistentes.TabIndex = 0
        '
        'btValidarAsistencia
        '
        Me.btValidarAsistencia.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btValidarAsistencia.Location = New System.Drawing.Point(256, 424)
        Me.btValidarAsistencia.Name = "btValidarAsistencia"
        Me.btValidarAsistencia.Size = New System.Drawing.Size(118, 23)
        Me.btValidarAsistencia.TabIndex = 1
        Me.btValidarAsistencia.Text = "Validar Asistencia"
        Me.btValidarAsistencia.UseVisualStyleBackColor = True
        '
        'tbIdTerapia
        '
        Me.tbIdTerapia.Location = New System.Drawing.Point(16, 422)
        Me.tbIdTerapia.Name = "tbIdTerapia"
        Me.tbIdTerapia.Size = New System.Drawing.Size(49, 20)
        Me.tbIdTerapia.TabIndex = 2
        Me.tbIdTerapia.Visible = False
        '
        'tbFechaTerapia
        '
        Me.tbFechaTerapia.Location = New System.Drawing.Point(71, 422)
        Me.tbFechaTerapia.Name = "tbFechaTerapia"
        Me.tbFechaTerapia.Size = New System.Drawing.Size(50, 20)
        Me.tbFechaTerapia.TabIndex = 3
        Me.tbFechaTerapia.Visible = False
        '
        'tbIdPac
        '
        Me.tbIdPac.Location = New System.Drawing.Point(127, 424)
        Me.tbIdPac.Name = "tbIdPac"
        Me.tbIdPac.Size = New System.Drawing.Size(68, 20)
        Me.tbIdPac.TabIndex = 4
        Me.tbIdPac.Visible = False
        '
        'formAsistentesTerapia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Peru
        Me.ClientSize = New System.Drawing.Size(386, 450)
        Me.Controls.Add(Me.tbIdPac)
        Me.Controls.Add(Me.tbFechaTerapia)
        Me.Controls.Add(Me.tbIdTerapia)
        Me.Controls.Add(Me.btValidarAsistencia)
        Me.Controls.Add(Me.dgvAsistentes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "formAsistentesTerapia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asistencia a Terapia"
        CType(Me.dgvAsistentes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvAsistentes As System.Windows.Forms.DataGridView
    Friend WithEvents btValidarAsistencia As System.Windows.Forms.Button
    Friend WithEvents tbIdTerapia As System.Windows.Forms.TextBox
    Friend WithEvents tbFechaTerapia As System.Windows.Forms.TextBox
    Friend WithEvents tbIdPac As System.Windows.Forms.TextBox
End Class
