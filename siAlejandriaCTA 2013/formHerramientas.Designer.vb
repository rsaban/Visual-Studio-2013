<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formHerramientas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formHerramientas))
        Me.btTecnicos = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btSegTerapias = New System.Windows.Forms.Button()
        Me.btConsultaSitLaboral = New System.Windows.Forms.Button()
        Me.btAdmisionesAltas = New System.Windows.Forms.Button()
        Me.btAvisos = New System.Windows.Forms.Button()
        Me.btInsertarCodFact = New System.Windows.Forms.Button()
        Me.btEliminarTerapia = New System.Windows.Forms.Button()
        Me.btAboutMe = New System.Windows.Forms.Button()
        Me.btListadoPacientes = New System.Windows.Forms.Button()
        Me.btExportarAgenda = New System.Windows.Forms.Button()
        Me.btCodigosFacturacion = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btTecnicos
        '
        Me.btTecnicos.Enabled = False
        Me.btTecnicos.Location = New System.Drawing.Point(508, 39)
        Me.btTecnicos.Name = "btTecnicos"
        Me.btTecnicos.Size = New System.Drawing.Size(219, 27)
        Me.btTecnicos.TabIndex = 1
        Me.btTecnicos.Text = "Gestión de Técnicos y Usuarios"
        Me.btTecnicos.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(36, 75)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(219, 27)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Seguimiento de Citas de Pacientes"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btSegTerapias
        '
        Me.btSegTerapias.Location = New System.Drawing.Point(36, 111)
        Me.btSegTerapias.Name = "btSegTerapias"
        Me.btSegTerapias.Size = New System.Drawing.Size(219, 27)
        Me.btSegTerapias.TabIndex = 5
        Me.btSegTerapias.Text = "Control de Asistencia a Terapia"
        Me.btSegTerapias.UseVisualStyleBackColor = True
        '
        'btConsultaSitLaboral
        '
        Me.btConsultaSitLaboral.Location = New System.Drawing.Point(274, 39)
        Me.btConsultaSitLaboral.Name = "btConsultaSitLaboral"
        Me.btConsultaSitLaboral.Size = New System.Drawing.Size(219, 27)
        Me.btConsultaSitLaboral.TabIndex = 6
        Me.btConsultaSitLaboral.Text = "Comparativa Situaciones Laborales"
        Me.btConsultaSitLaboral.UseVisualStyleBackColor = True
        '
        'btAdmisionesAltas
        '
        Me.btAdmisionesAltas.Location = New System.Drawing.Point(36, 147)
        Me.btAdmisionesAltas.Name = "btAdmisionesAltas"
        Me.btAdmisionesAltas.Size = New System.Drawing.Size(219, 27)
        Me.btAdmisionesAltas.TabIndex = 7
        Me.btAdmisionesAltas.Text = "Consultar Admisiones a TTº"
        Me.btAdmisionesAltas.UseVisualStyleBackColor = True
        '
        'btAvisos
        '
        Me.btAvisos.Location = New System.Drawing.Point(36, 39)
        Me.btAvisos.Name = "btAvisos"
        Me.btAvisos.Size = New System.Drawing.Size(219, 27)
        Me.btAvisos.TabIndex = 8
        Me.btAvisos.Text = "Avisos"
        Me.btAvisos.UseVisualStyleBackColor = True
        '
        'btInsertarCodFact
        '
        Me.btInsertarCodFact.Enabled = False
        Me.btInsertarCodFact.Location = New System.Drawing.Point(508, 111)
        Me.btInsertarCodFact.Name = "btInsertarCodFact"
        Me.btInsertarCodFact.Size = New System.Drawing.Size(219, 27)
        Me.btInsertarCodFact.TabIndex = 9
        Me.btInsertarCodFact.Text = "Activar Facturación en Paciente"
        Me.btInsertarCodFact.UseVisualStyleBackColor = True
        '
        'btEliminarTerapia
        '
        Me.btEliminarTerapia.Location = New System.Drawing.Point(274, 75)
        Me.btEliminarTerapia.Name = "btEliminarTerapia"
        Me.btEliminarTerapia.Size = New System.Drawing.Size(219, 27)
        Me.btEliminarTerapia.TabIndex = 10
        Me.btEliminarTerapia.Text = "Eliminar grupo de Terapia"
        Me.btEliminarTerapia.UseVisualStyleBackColor = True
        '
        'btAboutMe
        '
        Me.btAboutMe.Location = New System.Drawing.Point(508, 147)
        Me.btAboutMe.Name = "btAboutMe"
        Me.btAboutMe.Size = New System.Drawing.Size(219, 27)
        Me.btAboutMe.TabIndex = 11
        Me.btAboutMe.Text = "Acerca de..."
        Me.btAboutMe.UseVisualStyleBackColor = True
        '
        'btListadoPacientes
        '
        Me.btListadoPacientes.Location = New System.Drawing.Point(274, 111)
        Me.btListadoPacientes.Name = "btListadoPacientes"
        Me.btListadoPacientes.Size = New System.Drawing.Size(219, 27)
        Me.btListadoPacientes.TabIndex = 12
        Me.btListadoPacientes.Text = "Generar listado de pacientes"
        Me.btListadoPacientes.UseVisualStyleBackColor = True
        '
        'btExportarAgenda
        '
        Me.btExportarAgenda.Location = New System.Drawing.Point(274, 147)
        Me.btExportarAgenda.Name = "btExportarAgenda"
        Me.btExportarAgenda.Size = New System.Drawing.Size(219, 27)
        Me.btExportarAgenda.TabIndex = 13
        Me.btExportarAgenda.Text = "Exportar Agenda"
        Me.btExportarAgenda.UseVisualStyleBackColor = True
        '
        'btCodigosFacturacion
        '
        Me.btCodigosFacturacion.Enabled = False
        Me.btCodigosFacturacion.Location = New System.Drawing.Point(508, 75)
        Me.btCodigosFacturacion.Name = "btCodigosFacturacion"
        Me.btCodigosFacturacion.Size = New System.Drawing.Size(219, 27)
        Me.btCodigosFacturacion.TabIndex = 14
        Me.btCodigosFacturacion.Text = "Códigos de Facturación"
        Me.btCodigosFacturacion.UseVisualStyleBackColor = True
        '
        'formHerramientas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Peru
        Me.ClientSize = New System.Drawing.Size(763, 212)
        Me.Controls.Add(Me.btCodigosFacturacion)
        Me.Controls.Add(Me.btExportarAgenda)
        Me.Controls.Add(Me.btListadoPacientes)
        Me.Controls.Add(Me.btAboutMe)
        Me.Controls.Add(Me.btEliminarTerapia)
        Me.Controls.Add(Me.btInsertarCodFact)
        Me.Controls.Add(Me.btAvisos)
        Me.Controls.Add(Me.btAdmisionesAltas)
        Me.Controls.Add(Me.btConsultaSitLaboral)
        Me.Controls.Add(Me.btSegTerapias)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btTecnicos)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "formHerramientas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Herramientas"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btTecnicos As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents btSegTerapias As System.Windows.Forms.Button
    Friend WithEvents btConsultaSitLaboral As System.Windows.Forms.Button
    Friend WithEvents btAdmisionesAltas As System.Windows.Forms.Button
    Friend WithEvents btAvisos As System.Windows.Forms.Button
    Friend WithEvents btInsertarCodFact As System.Windows.Forms.Button
    Friend WithEvents btEliminarTerapia As System.Windows.Forms.Button
    Friend WithEvents btAboutMe As System.Windows.Forms.Button
    Friend WithEvents btListadoPacientes As System.Windows.Forms.Button
    Friend WithEvents btExportarAgenda As System.Windows.Forms.Button
    Friend WithEvents btCodigosFacturacion As System.Windows.Forms.Button
End Class
