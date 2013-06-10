<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formAvisos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formAvisos))
        Me.btAceptar = New System.Windows.Forms.Button()
        Me.lklbProcesoAbandono = New System.Windows.Forms.LinkLabel()
        Me.lklbAbandono = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'btAceptar
        '
        Me.btAceptar.Location = New System.Drawing.Point(140, 98)
        Me.btAceptar.Name = "btAceptar"
        Me.btAceptar.Size = New System.Drawing.Size(87, 27)
        Me.btAceptar.TabIndex = 0
        Me.btAceptar.Text = "Aceptar"
        Me.btAceptar.UseVisualStyleBackColor = True
        '
        'lklbProcesoAbandono
        '
        Me.lklbProcesoAbandono.AutoSize = True
        Me.lklbProcesoAbandono.BackColor = System.Drawing.Color.Khaki
        Me.lklbProcesoAbandono.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lklbProcesoAbandono.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.lklbProcesoAbandono.LinkColor = System.Drawing.Color.Black
        Me.lklbProcesoAbandono.Location = New System.Drawing.Point(30, 37)
        Me.lklbProcesoAbandono.Name = "lklbProcesoAbandono"
        Me.lklbProcesoAbandono.Size = New System.Drawing.Size(61, 15)
        Me.lklbProcesoAbandono.TabIndex = 1
        Me.lklbProcesoAbandono.TabStop = True
        Me.lklbProcesoAbandono.Text = "LinkLabel1"
        '
        'lklbAbandono
        '
        Me.lklbAbandono.AutoSize = True
        Me.lklbAbandono.BackColor = System.Drawing.Color.Khaki
        Me.lklbAbandono.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lklbAbandono.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.lklbAbandono.LinkColor = System.Drawing.Color.Black
        Me.lklbAbandono.Location = New System.Drawing.Point(30, 66)
        Me.lklbAbandono.Name = "lklbAbandono"
        Me.lklbAbandono.Size = New System.Drawing.Size(61, 15)
        Me.lklbAbandono.TabIndex = 2
        Me.lklbAbandono.TabStop = True
        Me.lklbAbandono.Text = "LinkLabel1"
        '
        'formAvisos
        '
        Me.AcceptButton = Me.btAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Peru
        Me.ClientSize = New System.Drawing.Size(367, 153)
        Me.Controls.Add(Me.lklbAbandono)
        Me.Controls.Add(Me.lklbProcesoAbandono)
        Me.Controls.Add(Me.btAceptar)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "formAvisos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Avisos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btAceptar As System.Windows.Forms.Button
    Friend WithEvents lklbProcesoAbandono As System.Windows.Forms.LinkLabel
    Friend WithEvents lklbAbandono As System.Windows.Forms.LinkLabel
End Class
