<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formSeleccionTecnico
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formSeleccionTecnico))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbxTecnicos = New System.Windows.Forms.ComboBox()
        Me.btExportar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Seleccione Técnico:"
        '
        'cbxTecnicos
        '
        Me.cbxTecnicos.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cbxTecnicos.FormattingEnabled = True
        Me.cbxTecnicos.Location = New System.Drawing.Point(152, 26)
        Me.cbxTecnicos.Name = "cbxTecnicos"
        Me.cbxTecnicos.Size = New System.Drawing.Size(162, 23)
        Me.cbxTecnicos.TabIndex = 1
        '
        'btExportar
        '
        Me.btExportar.Location = New System.Drawing.Point(128, 73)
        Me.btExportar.Name = "btExportar"
        Me.btExportar.Size = New System.Drawing.Size(93, 23)
        Me.btExportar.TabIndex = 2
        Me.btExportar.Text = "Generar Excel"
        Me.btExportar.UseVisualStyleBackColor = True
        '
        'formSeleccionTecnico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Peru
        Me.ClientSize = New System.Drawing.Size(349, 122)
        Me.Controls.Add(Me.btExportar)
        Me.Controls.Add(Me.cbxTecnicos)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "formSeleccionTecnico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Exportar Agenda"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbxTecnicos As System.Windows.Forms.ComboBox
    Friend WithEvents btExportar As System.Windows.Forms.Button
End Class
