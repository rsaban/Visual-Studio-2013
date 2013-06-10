<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formSeguimientoTerapias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formSeguimientoTerapias))
        Me.cbxGruposTerapia = New System.Windows.Forms.ComboBox()
        Me.tbHistoria = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvSegTerap = New System.Windows.Forms.DataGridView()
        Me.btVer = New System.Windows.Forms.Button()
        Me.btExcel = New System.Windows.Forms.Button()
        CType(Me.dgvSegTerap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbxGruposTerapia
        '
        Me.cbxGruposTerapia.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cbxGruposTerapia.FormattingEnabled = True
        Me.cbxGruposTerapia.Location = New System.Drawing.Point(127, 63)
        Me.cbxGruposTerapia.Name = "cbxGruposTerapia"
        Me.cbxGruposTerapia.Size = New System.Drawing.Size(157, 23)
        Me.cbxGruposTerapia.TabIndex = 0
        '
        'tbHistoria
        '
        Me.tbHistoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbHistoria.Location = New System.Drawing.Point(127, 25)
        Me.tbHistoria.Name = "tbHistoria"
        Me.tbHistoria.Size = New System.Drawing.Size(87, 23)
        Me.tbHistoria.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nº Historia:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Grupo de Terapia:"
        '
        'dgvSegTerap
        '
        Me.dgvSegTerap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSegTerap.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.dgvSegTerap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSegTerap.Location = New System.Drawing.Point(12, 95)
        Me.dgvSegTerap.Name = "dgvSegTerap"
        Me.dgvSegTerap.RowHeadersVisible = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.dgvSegTerap.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSegTerap.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvSegTerap.Size = New System.Drawing.Size(338, 328)
        Me.dgvSegTerap.TabIndex = 4
        '
        'btVer
        '
        Me.btVer.Location = New System.Drawing.Point(304, 61)
        Me.btVer.Name = "btVer"
        Me.btVer.Size = New System.Drawing.Size(45, 27)
        Me.btVer.TabIndex = 5
        Me.btVer.Text = "Ver"
        Me.btVer.UseVisualStyleBackColor = True
        '
        'btExcel
        '
        Me.btExcel.Location = New System.Drawing.Point(254, 441)
        Me.btExcel.Name = "btExcel"
        Me.btExcel.Size = New System.Drawing.Size(95, 27)
        Me.btExcel.TabIndex = 6
        Me.btExcel.Text = "Generar Excel"
        Me.btExcel.UseVisualStyleBackColor = True
        '
        'formSeguimientoTerapias
        '
        Me.AcceptButton = Me.btVer
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Peru
        Me.ClientSize = New System.Drawing.Size(367, 481)
        Me.Controls.Add(Me.btExcel)
        Me.Controls.Add(Me.btVer)
        Me.Controls.Add(Me.dgvSegTerap)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbHistoria)
        Me.Controls.Add(Me.cbxGruposTerapia)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "formSeguimientoTerapias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seguimiento Terapias"
        CType(Me.dgvSegTerap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbxGruposTerapia As System.Windows.Forms.ComboBox
    Friend WithEvents tbHistoria As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgvSegTerap As System.Windows.Forms.DataGridView
    Friend WithEvents btVer As System.Windows.Forms.Button
    Friend WithEvents btExcel As System.Windows.Forms.Button
End Class
