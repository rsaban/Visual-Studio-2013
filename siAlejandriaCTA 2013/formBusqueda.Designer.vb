<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formBusqueda
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formBusqueda))
        Me.dgvBusqueda = New System.Windows.Forms.DataGridView()
        Me.btBuscar = New System.Windows.Forms.Button()
        Me.tbBuscar = New System.Windows.Forms.TextBox()
        Me.rbHistoria = New System.Windows.Forms.RadioButton()
        Me.rbDNI = New System.Windows.Forms.RadioButton()
        Me.rbNombre = New System.Windows.Forms.RadioButton()
        Me.btVerHistoria = New System.Windows.Forms.Button()
        Me.btMostrarEnBuscador = New System.Windows.Forms.Button()
        CType(Me.dgvBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvBusqueda
        '
        Me.dgvBusqueda.AllowUserToAddRows = False
        Me.dgvBusqueda.AllowUserToDeleteRows = False
        Me.dgvBusqueda.AllowUserToResizeColumns = False
        Me.dgvBusqueda.AllowUserToResizeRows = False
        Me.dgvBusqueda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvBusqueda.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBusqueda.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvBusqueda.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvBusqueda.Location = New System.Drawing.Point(12, 64)
        Me.dgvBusqueda.Name = "dgvBusqueda"
        Me.dgvBusqueda.ReadOnly = True
        Me.dgvBusqueda.RowHeadersVisible = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.dgvBusqueda.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvBusqueda.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvBusqueda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBusqueda.Size = New System.Drawing.Size(567, 170)
        Me.dgvBusqueda.TabIndex = 5
        '
        'btBuscar
        '
        Me.btBuscar.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btBuscar.Location = New System.Drawing.Point(494, 23)
        Me.btBuscar.Name = "btBuscar"
        Me.btBuscar.Size = New System.Drawing.Size(85, 24)
        Me.btBuscar.TabIndex = 1
        Me.btBuscar.Text = "Buscar"
        Me.btBuscar.UseVisualStyleBackColor = True
        '
        'tbBuscar
        '
        Me.tbBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbBuscar.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbBuscar.Location = New System.Drawing.Point(196, 24)
        Me.tbBuscar.Name = "tbBuscar"
        Me.tbBuscar.Size = New System.Drawing.Size(292, 23)
        Me.tbBuscar.TabIndex = 0
        '
        'rbHistoria
        '
        Me.rbHistoria.AutoSize = True
        Me.rbHistoria.Checked = True
        Me.rbHistoria.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbHistoria.Location = New System.Drawing.Point(12, 26)
        Me.rbHistoria.Name = "rbHistoria"
        Me.rbHistoria.Size = New System.Drawing.Size(67, 19)
        Me.rbHistoria.TabIndex = 2
        Me.rbHistoria.TabStop = True
        Me.rbHistoria.Text = "Historia"
        Me.rbHistoria.UseVisualStyleBackColor = True
        '
        'rbDNI
        '
        Me.rbDNI.AutoSize = True
        Me.rbDNI.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDNI.Location = New System.Drawing.Point(78, 26)
        Me.rbDNI.Name = "rbDNI"
        Me.rbDNI.Size = New System.Drawing.Size(48, 19)
        Me.rbDNI.TabIndex = 3
        Me.rbDNI.Text = "DNI"
        Me.rbDNI.UseVisualStyleBackColor = True
        '
        'rbNombre
        '
        Me.rbNombre.AutoSize = True
        Me.rbNombre.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbNombre.Location = New System.Drawing.Point(128, 26)
        Me.rbNombre.Name = "rbNombre"
        Me.rbNombre.Size = New System.Drawing.Size(65, 19)
        Me.rbNombre.TabIndex = 4
        Me.rbNombre.Text = "Nombre"
        Me.rbNombre.UseVisualStyleBackColor = True
        '
        'btVerHistoria
        '
        Me.btVerHistoria.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btVerHistoria.Location = New System.Drawing.Point(494, 248)
        Me.btVerHistoria.Name = "btVerHistoria"
        Me.btVerHistoria.Size = New System.Drawing.Size(85, 23)
        Me.btVerHistoria.TabIndex = 6
        Me.btVerHistoria.Text = "Ver Historia"
        Me.btVerHistoria.UseVisualStyleBackColor = True
        '
        'btMostrarEnBuscador
        '
        Me.btMostrarEnBuscador.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btMostrarEnBuscador.Location = New System.Drawing.Point(283, 248)
        Me.btMostrarEnBuscador.Name = "btMostrarEnBuscador"
        Me.btMostrarEnBuscador.Size = New System.Drawing.Size(134, 23)
        Me.btMostrarEnBuscador.TabIndex = 7
        Me.btMostrarEnBuscador.Text = "Mostrar en el Buscador"
        Me.btMostrarEnBuscador.UseVisualStyleBackColor = True
        Me.btMostrarEnBuscador.Visible = False
        '
        'formBusqueda
        '
        Me.AcceptButton = Me.btBuscar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Peru
        Me.ClientSize = New System.Drawing.Size(592, 283)
        Me.Controls.Add(Me.btMostrarEnBuscador)
        Me.Controls.Add(Me.btVerHistoria)
        Me.Controls.Add(Me.rbNombre)
        Me.Controls.Add(Me.rbDNI)
        Me.Controls.Add(Me.rbHistoria)
        Me.Controls.Add(Me.tbBuscar)
        Me.Controls.Add(Me.btBuscar)
        Me.Controls.Add(Me.dgvBusqueda)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "formBusqueda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Búsqueda de Pacientes"
        CType(Me.dgvBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvBusqueda As System.Windows.Forms.DataGridView
    Friend WithEvents btBuscar As System.Windows.Forms.Button
    Friend WithEvents tbBuscar As System.Windows.Forms.TextBox
    Friend WithEvents rbHistoria As System.Windows.Forms.RadioButton
    Friend WithEvents rbDNI As System.Windows.Forms.RadioButton
    Friend WithEvents rbNombre As System.Windows.Forms.RadioButton
    Friend WithEvents btVerHistoria As System.Windows.Forms.Button
    Friend WithEvents btMostrarEnBuscador As System.Windows.Forms.Button
End Class
