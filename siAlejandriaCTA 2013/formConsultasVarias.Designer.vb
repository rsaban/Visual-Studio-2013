<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formConsultasVarias
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formConsultasVarias))
        Me.dgvConsulta1 = New System.Windows.Forms.DataGridView()
        Me.rbHistoria = New System.Windows.Forms.RadioButton()
        Me.rbTodos = New System.Windows.Forms.RadioButton()
        Me.tbHistoria = New System.Windows.Forms.TextBox()
        Me.gbxParametros = New System.Windows.Forms.GroupBox()
        Me.btVer = New System.Windows.Forms.Button()
        Me.btExcel = New System.Windows.Forms.Button()
        Me.dgvConsulta2 = New System.Windows.Forms.DataGridView()
        Me.lbPrimerGbx = New System.Windows.Forms.Label()
        Me.lbSegundoGbx = New System.Windows.Forms.Label()
        CType(Me.dgvConsulta1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxParametros.SuspendLayout()
        CType(Me.dgvConsulta2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvConsulta1
        '
        Me.dgvConsulta1.AllowUserToAddRows = False
        Me.dgvConsulta1.AllowUserToDeleteRows = False
        Me.dgvConsulta1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvConsulta1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvConsulta1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvConsulta1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvConsulta1.Location = New System.Drawing.Point(12, 85)
        Me.dgvConsulta1.Name = "dgvConsulta1"
        Me.dgvConsulta1.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvConsulta1.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvConsulta1.RowHeadersVisible = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.dgvConsulta1.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvConsulta1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvConsulta1.Size = New System.Drawing.Size(256, 153)
        Me.dgvConsulta1.TabIndex = 4
        '
        'rbHistoria
        '
        Me.rbHistoria.AutoSize = True
        Me.rbHistoria.Checked = True
        Me.rbHistoria.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbHistoria.Location = New System.Drawing.Point(6, 20)
        Me.rbHistoria.Name = "rbHistoria"
        Me.rbHistoria.Size = New System.Drawing.Size(87, 19)
        Me.rbHistoria.TabIndex = 0
        Me.rbHistoria.TabStop = True
        Me.rbHistoria.Text = "Nº Historia:"
        Me.rbHistoria.UseVisualStyleBackColor = True
        '
        'rbTodos
        '
        Me.rbTodos.AutoSize = True
        Me.rbTodos.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbTodos.Location = New System.Drawing.Point(242, 20)
        Me.rbTodos.Name = "rbTodos"
        Me.rbTodos.Size = New System.Drawing.Size(55, 19)
        Me.rbTodos.TabIndex = 2
        Me.rbTodos.Text = "Todos"
        Me.rbTodos.UseVisualStyleBackColor = True
        '
        'tbHistoria
        '
        Me.tbHistoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbHistoria.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbHistoria.Location = New System.Drawing.Point(99, 18)
        Me.tbHistoria.Name = "tbHistoria"
        Me.tbHistoria.Size = New System.Drawing.Size(126, 23)
        Me.tbHistoria.TabIndex = 1
        '
        'gbxParametros
        '
        Me.gbxParametros.Controls.Add(Me.btVer)
        Me.gbxParametros.Controls.Add(Me.rbHistoria)
        Me.gbxParametros.Controls.Add(Me.tbHistoria)
        Me.gbxParametros.Controls.Add(Me.rbTodos)
        Me.gbxParametros.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxParametros.Location = New System.Drawing.Point(12, 12)
        Me.gbxParametros.Name = "gbxParametros"
        Me.gbxParametros.Size = New System.Drawing.Size(550, 54)
        Me.gbxParametros.TabIndex = 4
        Me.gbxParametros.TabStop = False
        Me.gbxParametros.Text = "Párametros de consulta"
        '
        'btVer
        '
        Me.btVer.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btVer.Location = New System.Drawing.Point(452, 18)
        Me.btVer.Name = "btVer"
        Me.btVer.Size = New System.Drawing.Size(92, 23)
        Me.btVer.TabIndex = 3
        Me.btVer.Text = "Consultar"
        Me.btVer.UseVisualStyleBackColor = True
        '
        'btExcel
        '
        Me.btExcel.Enabled = False
        Me.btExcel.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btExcel.Location = New System.Drawing.Point(464, 251)
        Me.btExcel.Name = "btExcel"
        Me.btExcel.Size = New System.Drawing.Size(92, 23)
        Me.btExcel.TabIndex = 6
        Me.btExcel.Text = "Generar Excel"
        Me.btExcel.UseVisualStyleBackColor = True
        '
        'dgvConsulta2
        '
        Me.dgvConsulta2.AllowUserToAddRows = False
        Me.dgvConsulta2.AllowUserToDeleteRows = False
        Me.dgvConsulta2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvConsulta2.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvConsulta2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvConsulta2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvConsulta2.Location = New System.Drawing.Point(306, 85)
        Me.dgvConsulta2.Name = "dgvConsulta2"
        Me.dgvConsulta2.ReadOnly = True
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvConsulta2.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvConsulta2.RowHeadersVisible = False
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.dgvConsulta2.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvConsulta2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvConsulta2.Size = New System.Drawing.Size(256, 153)
        Me.dgvConsulta2.TabIndex = 5
        '
        'lbPrimerGbx
        '
        Me.lbPrimerGbx.AutoSize = True
        Me.lbPrimerGbx.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPrimerGbx.Location = New System.Drawing.Point(15, 69)
        Me.lbPrimerGbx.Name = "lbPrimerGbx"
        Me.lbPrimerGbx.Size = New System.Drawing.Size(39, 15)
        Me.lbPrimerGbx.TabIndex = 7
        Me.lbPrimerGbx.Text = "Label1"
        '
        'lbSegundoGbx
        '
        Me.lbSegundoGbx.AutoSize = True
        Me.lbSegundoGbx.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSegundoGbx.Location = New System.Drawing.Point(303, 69)
        Me.lbSegundoGbx.Name = "lbSegundoGbx"
        Me.lbSegundoGbx.Size = New System.Drawing.Size(41, 15)
        Me.lbSegundoGbx.TabIndex = 8
        Me.lbSegundoGbx.Text = "Label2"
        '
        'formConsultasVarias
        '
        Me.AcceptButton = Me.btVer
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Peru
        Me.ClientSize = New System.Drawing.Size(574, 286)
        Me.Controls.Add(Me.lbSegundoGbx)
        Me.Controls.Add(Me.lbPrimerGbx)
        Me.Controls.Add(Me.dgvConsulta2)
        Me.Controls.Add(Me.btExcel)
        Me.Controls.Add(Me.gbxParametros)
        Me.Controls.Add(Me.dgvConsulta1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "formConsultasVarias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "formConsultasVarias"
        CType(Me.dgvConsulta1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxParametros.ResumeLayout(False)
        Me.gbxParametros.PerformLayout()
        CType(Me.dgvConsulta2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvConsulta1 As System.Windows.Forms.DataGridView
    Friend WithEvents rbHistoria As System.Windows.Forms.RadioButton
    Friend WithEvents rbTodos As System.Windows.Forms.RadioButton
    Friend WithEvents tbHistoria As System.Windows.Forms.TextBox
    Friend WithEvents gbxParametros As System.Windows.Forms.GroupBox
    Friend WithEvents btVer As System.Windows.Forms.Button
    Friend WithEvents btExcel As System.Windows.Forms.Button
    Friend WithEvents dgvConsulta2 As System.Windows.Forms.DataGridView
    Friend WithEvents lbPrimerGbx As System.Windows.Forms.Label
    Friend WithEvents lbSegundoGbx As System.Windows.Forms.Label
End Class
