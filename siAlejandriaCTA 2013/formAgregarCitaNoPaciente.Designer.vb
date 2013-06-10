<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formAgregarCitaNoPaciente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formAgregarCitaNoPaciente))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbNombreCita = New System.Windows.Forms.TextBox()
        Me.tbFecha = New System.Windows.Forms.TextBox()
        Me.tbHora = New System.Windows.Forms.TextBox()
        Me.cbxTecnico = New System.Windows.Forms.ComboBox()
        Me.btAñadir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Técnico:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fecha:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(45, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Hora:"
        '
        'tbNombreCita
        '
        Me.tbNombreCita.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbNombreCita.Location = New System.Drawing.Point(86, 18)
        Me.tbNombreCita.Name = "tbNombreCita"
        Me.tbNombreCita.Size = New System.Drawing.Size(165, 23)
        Me.tbNombreCita.TabIndex = 0
        '
        'tbFecha
        '
        Me.tbFecha.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbFecha.Location = New System.Drawing.Point(86, 78)
        Me.tbFecha.Name = "tbFecha"
        Me.tbFecha.Size = New System.Drawing.Size(100, 23)
        Me.tbFecha.TabIndex = 2
        '
        'tbHora
        '
        Me.tbHora.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbHora.Location = New System.Drawing.Point(86, 108)
        Me.tbHora.Name = "tbHora"
        Me.tbHora.Size = New System.Drawing.Size(49, 23)
        Me.tbHora.TabIndex = 3
        '
        'cbxTecnico
        '
        Me.cbxTecnico.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cbxTecnico.FormattingEnabled = True
        Me.cbxTecnico.Location = New System.Drawing.Point(86, 48)
        Me.cbxTecnico.Name = "cbxTecnico"
        Me.cbxTecnico.Size = New System.Drawing.Size(165, 23)
        Me.cbxTecnico.TabIndex = 1
        '
        'btAñadir
        '
        Me.btAñadir.Location = New System.Drawing.Point(93, 147)
        Me.btAñadir.Name = "btAñadir"
        Me.btAñadir.Size = New System.Drawing.Size(94, 23)
        Me.btAñadir.TabIndex = 4
        Me.btAñadir.Text = "Añadir Cita"
        Me.btAñadir.UseVisualStyleBackColor = True
        '
        'formAgregarCitaNoPaciente
        '
        Me.AcceptButton = Me.btAñadir
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Peru
        Me.ClientSize = New System.Drawing.Size(280, 182)
        Me.Controls.Add(Me.btAñadir)
        Me.Controls.Add(Me.cbxTecnico)
        Me.Controls.Add(Me.tbHora)
        Me.Controls.Add(Me.tbFecha)
        Me.Controls.Add(Me.tbNombreCita)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "formAgregarCitaNoPaciente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Cita"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbNombreCita As System.Windows.Forms.TextBox
    Friend WithEvents tbFecha As System.Windows.Forms.TextBox
    Friend WithEvents tbHora As System.Windows.Forms.TextBox
    Friend WithEvents cbxTecnico As System.Windows.Forms.ComboBox
    Friend WithEvents btAñadir As System.Windows.Forms.Button
End Class
