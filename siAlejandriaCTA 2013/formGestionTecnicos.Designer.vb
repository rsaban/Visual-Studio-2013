<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formGestionTecnicos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formGestionTecnicos))
        Me.cbxProfesionTecnico = New System.Windows.Forms.ComboBox()
        Me.btAñadirTecnico = New System.Windows.Forms.Button()
        Me.cbxSeleccionarTecnico = New System.Windows.Forms.ComboBox()
        Me.lbSeleccTecn = New System.Windows.Forms.Label()
        Me.btEliminarTécnico = New System.Windows.Forms.Button()
        Me.tbNombreTecnico = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbxNivelUsuario = New System.Windows.Forms.ComboBox()
        Me.tbPasswordUsuario = New System.Windows.Forms.TextBox()
        Me.tbNombreUsuario = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.gbxTecnico = New System.Windows.Forms.GroupBox()
        Me.gbxTecnico.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbxProfesionTecnico
        '
        Me.cbxProfesionTecnico.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cbxProfesionTecnico.FormattingEnabled = True
        Me.cbxProfesionTecnico.Items.AddRange(New Object() {"", "PSICOLOGO/A", "TRABAJADOR/A SOCIAL", "MEDICO", "INVITADO"})
        Me.cbxProfesionTecnico.Location = New System.Drawing.Point(138, 62)
        Me.cbxProfesionTecnico.Name = "cbxProfesionTecnico"
        Me.cbxProfesionTecnico.Size = New System.Drawing.Size(191, 23)
        Me.cbxProfesionTecnico.TabIndex = 2
        '
        'btAñadirTecnico
        '
        Me.btAñadirTecnico.Location = New System.Drawing.Point(223, 290)
        Me.btAñadirTecnico.Name = "btAñadirTecnico"
        Me.btAñadirTecnico.Size = New System.Drawing.Size(111, 27)
        Me.btAñadirTecnico.TabIndex = 6
        Me.btAñadirTecnico.Text = "Añadir Técnico"
        Me.btAñadirTecnico.UseVisualStyleBackColor = True
        '
        'cbxSeleccionarTecnico
        '
        Me.cbxSeleccionarTecnico.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cbxSeleccionarTecnico.FormattingEnabled = True
        Me.cbxSeleccionarTecnico.Location = New System.Drawing.Point(183, 27)
        Me.cbxSeleccionarTecnico.Name = "cbxSeleccionarTecnico"
        Me.cbxSeleccionarTecnico.Size = New System.Drawing.Size(255, 23)
        Me.cbxSeleccionarTecnico.TabIndex = 0
        '
        'lbSeleccTecn
        '
        Me.lbSeleccTecn.AutoSize = True
        Me.lbSeleccTecn.Location = New System.Drawing.Point(46, 31)
        Me.lbSeleccTecn.Name = "lbSeleccTecn"
        Me.lbSeleccTecn.Size = New System.Drawing.Size(116, 15)
        Me.lbSeleccTecn.TabIndex = 23
        Me.lbSeleccTecn.Text = "Seleccionar Técnico:"
        '
        'btEliminarTécnico
        '
        Me.btEliminarTécnico.Location = New System.Drawing.Point(341, 290)
        Me.btEliminarTécnico.Name = "btEliminarTécnico"
        Me.btEliminarTécnico.Size = New System.Drawing.Size(111, 27)
        Me.btEliminarTécnico.TabIndex = 7
        Me.btEliminarTécnico.Text = "Eliminar Técnico"
        Me.btEliminarTécnico.UseVisualStyleBackColor = True
        '
        'tbNombreTecnico
        '
        Me.tbNombreTecnico.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbNombreTecnico.Location = New System.Drawing.Point(138, 32)
        Me.tbNombreTecnico.Name = "tbNombreTecnico"
        Me.tbNombreTecnico.Size = New System.Drawing.Size(255, 23)
        Me.tbNombreTecnico.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(59, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 15)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Profesión:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(68, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 15)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Nombre:"
        '
        'cbxNivelUsuario
        '
        Me.cbxNivelUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cbxNivelUsuario.FormattingEnabled = True
        Me.cbxNivelUsuario.Items.AddRange(New Object() {"", "1", "2", "3"})
        Me.cbxNivelUsuario.Location = New System.Drawing.Point(138, 153)
        Me.cbxNivelUsuario.Name = "cbxNivelUsuario"
        Me.cbxNivelUsuario.Size = New System.Drawing.Size(63, 23)
        Me.cbxNivelUsuario.TabIndex = 5
        '
        'tbPasswordUsuario
        '
        Me.tbPasswordUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbPasswordUsuario.Location = New System.Drawing.Point(138, 123)
        Me.tbPasswordUsuario.Name = "tbPasswordUsuario"
        Me.tbPasswordUsuario.Size = New System.Drawing.Size(194, 23)
        Me.tbPasswordUsuario.TabIndex = 4
        Me.tbPasswordUsuario.UseSystemPasswordChar = True
        '
        'tbNombreUsuario
        '
        Me.tbNombreUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbNombreUsuario.Location = New System.Drawing.Point(138, 93)
        Me.tbNombreUsuario.Name = "tbNombreUsuario"
        Me.tbNombreUsuario.Size = New System.Drawing.Size(194, 23)
        Me.tbNombreUsuario.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(83, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 15)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Nivel:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(48, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 15)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Contraseña:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 15)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Nombre de usuario:"
        '
        'gbxTecnico
        '
        Me.gbxTecnico.BackColor = System.Drawing.Color.Khaki
        Me.gbxTecnico.Controls.Add(Me.Label1)
        Me.gbxTecnico.Controls.Add(Me.cbxNivelUsuario)
        Me.gbxTecnico.Controls.Add(Me.Label2)
        Me.gbxTecnico.Controls.Add(Me.tbPasswordUsuario)
        Me.gbxTecnico.Controls.Add(Me.tbNombreTecnico)
        Me.gbxTecnico.Controls.Add(Me.tbNombreUsuario)
        Me.gbxTecnico.Controls.Add(Me.cbxProfesionTecnico)
        Me.gbxTecnico.Controls.Add(Me.Label3)
        Me.gbxTecnico.Controls.Add(Me.Label5)
        Me.gbxTecnico.Controls.Add(Me.Label4)
        Me.gbxTecnico.Location = New System.Drawing.Point(29, 67)
        Me.gbxTecnico.Name = "gbxTecnico"
        Me.gbxTecnico.Size = New System.Drawing.Size(423, 207)
        Me.gbxTecnico.TabIndex = 33
        Me.gbxTecnico.TabStop = False
        Me.gbxTecnico.Text = "GroupBox1"
        '
        'formGestionTecnicos
        '
        Me.AcceptButton = Me.btAñadirTecnico
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Peru
        Me.ClientSize = New System.Drawing.Size(475, 343)
        Me.Controls.Add(Me.gbxTecnico)
        Me.Controls.Add(Me.btAñadirTecnico)
        Me.Controls.Add(Me.cbxSeleccionarTecnico)
        Me.Controls.Add(Me.lbSeleccTecn)
        Me.Controls.Add(Me.btEliminarTécnico)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "formGestionTecnicos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestión de Técnicos y Usuarios"
        Me.gbxTecnico.ResumeLayout(False)
        Me.gbxTecnico.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbxProfesionTecnico As System.Windows.Forms.ComboBox
    Friend WithEvents btAñadirTecnico As System.Windows.Forms.Button
    Friend WithEvents cbxSeleccionarTecnico As System.Windows.Forms.ComboBox
    Friend WithEvents lbSeleccTecn As System.Windows.Forms.Label
    Friend WithEvents btEliminarTécnico As System.Windows.Forms.Button
    Friend WithEvents tbNombreTecnico As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbxNivelUsuario As System.Windows.Forms.ComboBox
    Friend WithEvents tbPasswordUsuario As System.Windows.Forms.TextBox
    Friend WithEvents tbNombreUsuario As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents gbxTecnico As System.Windows.Forms.GroupBox
End Class
