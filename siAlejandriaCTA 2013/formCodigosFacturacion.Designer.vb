<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formCodigosFacturacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formCodigosFacturacion))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbDenominacion = New System.Windows.Forms.TextBox()
        Me.tbPrecio = New System.Windows.Forms.TextBox()
        Me.btRegistrarActualizar = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.cbxCodigo = New System.Windows.Forms.ComboBox()
        Me.btVer = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Denominación:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(49, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Precio:"
        '
        'tbDenominacion
        '
        Me.tbDenominacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbDenominacion.Location = New System.Drawing.Point(98, 43)
        Me.tbDenominacion.Name = "tbDenominacion"
        Me.tbDenominacion.Size = New System.Drawing.Size(259, 23)
        Me.tbDenominacion.TabIndex = 4
        '
        'tbPrecio
        '
        Me.tbPrecio.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbPrecio.Location = New System.Drawing.Point(98, 72)
        Me.tbPrecio.Name = "tbPrecio"
        Me.tbPrecio.Size = New System.Drawing.Size(76, 23)
        Me.tbPrecio.TabIndex = 5
        '
        'btRegistrarActualizar
        '
        Me.btRegistrarActualizar.Location = New System.Drawing.Point(124, 112)
        Me.btRegistrarActualizar.Name = "btRegistrarActualizar"
        Me.btRegistrarActualizar.Size = New System.Drawing.Size(137, 23)
        Me.btRegistrarActualizar.TabIndex = 8
        Me.btRegistrarActualizar.Text = "Registrar / Actualizar"
        Me.btRegistrarActualizar.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TextBox1.Location = New System.Drawing.Point(180, 72)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(20, 23)
        Me.TextBox1.TabIndex = 9
        Me.TextBox1.Text = "€"
        '
        'cbxCodigo
        '
        Me.cbxCodigo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cbxCodigo.FormattingEnabled = True
        Me.cbxCodigo.Location = New System.Drawing.Point(98, 12)
        Me.cbxCodigo.Name = "cbxCodigo"
        Me.cbxCodigo.Size = New System.Drawing.Size(76, 23)
        Me.cbxCodigo.TabIndex = 10
        '
        'btVer
        '
        Me.btVer.Location = New System.Drawing.Point(180, 11)
        Me.btVer.Name = "btVer"
        Me.btVer.Size = New System.Drawing.Size(39, 24)
        Me.btVer.TabIndex = 11
        Me.btVer.Text = "Ver"
        Me.btVer.UseVisualStyleBackColor = True
        '
        'formCodigosFacturacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Peru
        Me.ClientSize = New System.Drawing.Size(383, 158)
        Me.Controls.Add(Me.btVer)
        Me.Controls.Add(Me.cbxCodigo)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btRegistrarActualizar)
        Me.Controls.Add(Me.tbPrecio)
        Me.Controls.Add(Me.tbDenominacion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "formCodigosFacturacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Códigos de Facturación"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbDenominacion As System.Windows.Forms.TextBox
    Friend WithEvents tbPrecio As System.Windows.Forms.TextBox
    Friend WithEvents btRegistrarActualizar As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents cbxCodigo As System.Windows.Forms.ComboBox
    Friend WithEvents btVer As System.Windows.Forms.Button
End Class
