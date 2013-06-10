<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formCitasNoPacientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formCitasNoPacientes))
        Me.dgvCitasNoPac = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btNuevaCita = New System.Windows.Forms.Button()
        Me.btLimpiar = New System.Windows.Forms.Button()
        CType(Me.dgvCitasNoPac, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvCitasNoPac
        '
        Me.dgvCitasNoPac.AllowUserToAddRows = False
        Me.dgvCitasNoPac.AllowUserToDeleteRows = False
        Me.dgvCitasNoPac.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCitasNoPac.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.dgvCitasNoPac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCitasNoPac.Location = New System.Drawing.Point(15, 27)
        Me.dgvCitasNoPac.Name = "dgvCitasNoPac"
        Me.dgvCitasNoPac.ReadOnly = True
        Me.dgvCitasNoPac.RowHeadersVisible = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.dgvCitasNoPac.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCitasNoPac.Size = New System.Drawing.Size(474, 181)
        Me.dgvCitasNoPac.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Citas Concertadas:"
        '
        'btNuevaCita
        '
        Me.btNuevaCita.Location = New System.Drawing.Point(333, 214)
        Me.btNuevaCita.Name = "btNuevaCita"
        Me.btNuevaCita.Size = New System.Drawing.Size(75, 23)
        Me.btNuevaCita.TabIndex = 2
        Me.btNuevaCita.Text = "Nueva Cita"
        Me.btNuevaCita.UseVisualStyleBackColor = True
        '
        'btLimpiar
        '
        Me.btLimpiar.Location = New System.Drawing.Point(414, 214)
        Me.btLimpiar.Name = "btLimpiar"
        Me.btLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btLimpiar.TabIndex = 3
        Me.btLimpiar.Text = "Limpiar"
        Me.btLimpiar.UseVisualStyleBackColor = True
        '
        'formCitasNoPacientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Peru
        Me.ClientSize = New System.Drawing.Size(510, 257)
        Me.Controls.Add(Me.btLimpiar)
        Me.Controls.Add(Me.btNuevaCita)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvCitasNoPac)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "formCitasNoPacientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Citas Externas"
        CType(Me.dgvCitasNoPac, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvCitasNoPac As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btNuevaCita As System.Windows.Forms.Button
    Friend WithEvents btLimpiar As System.Windows.Forms.Button
End Class
