<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formAltaTerapeutica
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formAltaTerapeutica))
        Me.cbxMotivoAlta = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpAltaTerap = New System.Windows.Forms.DateTimePicker()
        Me.btAlta = New System.Windows.Forms.Button()
        Me.tbHistoria = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cbxMotivoAlta
        '
        Me.cbxMotivoAlta.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cbxMotivoAlta.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxMotivoAlta.FormattingEnabled = True
        Me.cbxMotivoAlta.Items.AddRange(New Object() {"", "Alta terapéutica", "Alta voluntaria", "Abandono ", "Ingreso en prisión", "Derivacion a otro recurso", "Traslado a otro Municipio", "Traslado a otra Provincia", "Fallecimiento"})
        Me.cbxMotivoAlta.Location = New System.Drawing.Point(181, 51)
        Me.cbxMotivoAlta.Name = "cbxMotivoAlta"
        Me.cbxMotivoAlta.Size = New System.Drawing.Size(151, 23)
        Me.cbxMotivoAlta.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Fecha de Alta Terapéutica:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(89, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Motivo de Alta:"
        '
        'dtpAltaTerap
        '
        Me.dtpAltaTerap.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.dtpAltaTerap.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpAltaTerap.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpAltaTerap.Location = New System.Drawing.Point(181, 25)
        Me.dtpAltaTerap.Name = "dtpAltaTerap"
        Me.dtpAltaTerap.Size = New System.Drawing.Size(87, 23)
        Me.dtpAltaTerap.TabIndex = 3
        '
        'btAlta
        '
        Me.btAlta.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAlta.Location = New System.Drawing.Point(133, 87)
        Me.btAlta.Name = "btAlta"
        Me.btAlta.Size = New System.Drawing.Size(97, 23)
        Me.btAlta.TabIndex = 4
        Me.btAlta.Text = "Confirmar Alta"
        Me.btAlta.UseVisualStyleBackColor = True
        '
        'tbHistoria
        '
        Me.tbHistoria.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbHistoria.Location = New System.Drawing.Point(27, 96)
        Me.tbHistoria.Name = "tbHistoria"
        Me.tbHistoria.Size = New System.Drawing.Size(72, 23)
        Me.tbHistoria.TabIndex = 5
        Me.tbHistoria.Visible = False
        '
        'formAltaTerapeutica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Peru
        Me.ClientSize = New System.Drawing.Size(362, 129)
        Me.Controls.Add(Me.tbHistoria)
        Me.Controls.Add(Me.btAlta)
        Me.Controls.Add(Me.dtpAltaTerap)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbxMotivoAlta)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "formAltaTerapeutica"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alta Terapéutica"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbxMotivoAlta As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpAltaTerap As System.Windows.Forms.DateTimePicker
    Friend WithEvents btAlta As System.Windows.Forms.Button
    Friend WithEvents tbHistoria As System.Windows.Forms.TextBox
End Class
