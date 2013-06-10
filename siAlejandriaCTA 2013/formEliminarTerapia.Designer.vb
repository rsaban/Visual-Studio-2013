<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formEliminarTerapia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formEliminarTerapia))
        Me.btEliminar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbxGruposTerapia = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btEliminar
        '
        Me.btEliminar.Location = New System.Drawing.Point(119, 84)
        Me.btEliminar.Name = "btEliminar"
        Me.btEliminar.Size = New System.Drawing.Size(125, 27)
        Me.btEliminar.TabIndex = 0
        Me.btEliminar.Text = "Eliminar Terapia"
        Me.btEliminar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Seleccionar Grupo"
        '
        'cbxGruposTerapia
        '
        Me.cbxGruposTerapia.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cbxGruposTerapia.FormattingEnabled = True
        Me.cbxGruposTerapia.Location = New System.Drawing.Point(146, 40)
        Me.cbxGruposTerapia.Name = "cbxGruposTerapia"
        Me.cbxGruposTerapia.Size = New System.Drawing.Size(189, 23)
        Me.cbxGruposTerapia.TabIndex = 2
        '
        'formEliminarTerapia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Peru
        Me.ClientSize = New System.Drawing.Size(362, 140)
        Me.Controls.Add(Me.cbxGruposTerapia)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btEliminar)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "formEliminarTerapia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Eliminar Grupo de Terapia"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btEliminar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbxGruposTerapia As System.Windows.Forms.ComboBox
End Class
