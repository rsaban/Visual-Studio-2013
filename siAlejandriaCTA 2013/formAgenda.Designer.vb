<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formAgenda
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formAgenda))
        Me.dtpFechaCita = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvAgenda = New System.Windows.Forms.DataGridView()
        Me.cbxTecnico = New System.Windows.Forms.ComboBox()
        Me.btVer = New System.Windows.Forms.Button()
        Me.btControlCitas = New System.Windows.Forms.Button()
        Me.lbAvisadorTerapia = New System.Windows.Forms.Label()
        Me.btCitasNoPacientes = New System.Windows.Forms.Button()
        CType(Me.dgvAgenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtpFechaCita
        '
        Me.dtpFechaCita.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.dtpFechaCita.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaCita.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaCita.Location = New System.Drawing.Point(77, 28)
        Me.dtpFechaCita.Name = "dtpFechaCita"
        Me.dtpFechaCita.Size = New System.Drawing.Size(107, 23)
        Me.dtpFechaCita.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Fecha:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(199, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Técnico:"
        '
        'dgvAgenda
        '
        Me.dgvAgenda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvAgenda.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAgenda.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAgenda.Location = New System.Drawing.Point(34, 55)
        Me.dgvAgenda.Name = "dgvAgenda"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAgenda.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvAgenda.RowHeadersVisible = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.dgvAgenda.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvAgenda.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvAgenda.Size = New System.Drawing.Size(451, 223)
        Me.dgvAgenda.TabIndex = 3
        '
        'cbxTecnico
        '
        Me.cbxTecnico.BackColor = System.Drawing.Color.Khaki
        Me.cbxTecnico.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxTecnico.FormattingEnabled = True
        Me.cbxTecnico.Location = New System.Drawing.Point(263, 28)
        Me.cbxTecnico.Name = "cbxTecnico"
        Me.cbxTecnico.Size = New System.Drawing.Size(178, 23)
        Me.cbxTecnico.TabIndex = 1
        '
        'btVer
        '
        Me.btVer.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btVer.Location = New System.Drawing.Point(447, 28)
        Me.btVer.Name = "btVer"
        Me.btVer.Size = New System.Drawing.Size(38, 23)
        Me.btVer.TabIndex = 2
        Me.btVer.Text = "Ver"
        Me.btVer.UseVisualStyleBackColor = True
        '
        'btControlCitas
        '
        Me.btControlCitas.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btControlCitas.Location = New System.Drawing.Point(350, 285)
        Me.btControlCitas.Name = "btControlCitas"
        Me.btControlCitas.Size = New System.Drawing.Size(104, 23)
        Me.btControlCitas.TabIndex = 4
        Me.btControlCitas.Text = "Control de Citas"
        Me.btControlCitas.UseVisualStyleBackColor = True
        '
        'lbAvisadorTerapia
        '
        Me.lbAvisadorTerapia.AutoSize = True
        Me.lbAvisadorTerapia.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbAvisadorTerapia.Location = New System.Drawing.Point(31, 289)
        Me.lbAvisadorTerapia.Name = "lbAvisadorTerapia"
        Me.lbAvisadorTerapia.Size = New System.Drawing.Size(96, 15)
        Me.lbAvisadorTerapia.TabIndex = 5
        Me.lbAvisadorTerapia.Text = "Avisador Terapia"
        Me.lbAvisadorTerapia.Visible = False
        '
        'btCitasNoPacientes
        '
        Me.btCitasNoPacientes.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCitasNoPacientes.Location = New System.Drawing.Point(460, 285)
        Me.btCitasNoPacientes.Name = "btCitasNoPacientes"
        Me.btCitasNoPacientes.Size = New System.Drawing.Size(25, 23)
        Me.btCitasNoPacientes.TabIndex = 6
        Me.btCitasNoPacientes.Text = "i"
        Me.btCitasNoPacientes.UseVisualStyleBackColor = True
        '
        'formAgenda
        '
        Me.AcceptButton = Me.btVer
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Peru
        Me.ClientSize = New System.Drawing.Size(516, 316)
        Me.Controls.Add(Me.btCitasNoPacientes)
        Me.Controls.Add(Me.lbAvisadorTerapia)
        Me.Controls.Add(Me.btControlCitas)
        Me.Controls.Add(Me.btVer)
        Me.Controls.Add(Me.cbxTecnico)
        Me.Controls.Add(Me.dgvAgenda)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpFechaCita)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "formAgenda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agenda"
        CType(Me.dgvAgenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpFechaCita As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgvAgenda As System.Windows.Forms.DataGridView
    Friend WithEvents cbxTecnico As System.Windows.Forms.ComboBox
    Friend WithEvents btVer As System.Windows.Forms.Button
    Friend WithEvents btControlCitas As System.Windows.Forms.Button
    Friend WithEvents lbAvisadorTerapia As System.Windows.Forms.Label
    Friend WithEvents btCitasNoPacientes As System.Windows.Forms.Button
End Class
