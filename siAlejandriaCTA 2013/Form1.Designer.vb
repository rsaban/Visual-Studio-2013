<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btAcceso = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btAltaPaciente = New System.Windows.Forms.Button()
        Me.btEstadisticas = New System.Windows.Forms.Button()
        Me.btBusqueda = New System.Windows.Forms.Button()
        Me.btHerramientas = New System.Windows.Forms.Button()
        Me.btGruposTerap = New System.Windows.Forms.Button()
        Me.btSalir = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lbHora = New System.Windows.Forms.Label()
        Me.timerHora = New System.Windows.Forms.Timer(Me.components)
        Me.lbFecha = New System.Windows.Forms.Label()
        CType(Me.btAcceso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btAcceso
        '
        Me.btAcceso.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btAcceso.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.btAcceso.Image = CType(resources.GetObject("btAcceso.Image"), System.Drawing.Image)
        Me.btAcceso.Location = New System.Drawing.Point(404, 312)
        Me.btAcceso.Name = "btAcceso"
        Me.btAcceso.Size = New System.Drawing.Size(103, 70)
        Me.btAcceso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btAcceso.TabIndex = 1
        Me.btAcceso.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox1.BackColor = System.Drawing.Color.LemonChiffon
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(244, 394)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(484, 98)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'btAltaPaciente
        '
        Me.btAltaPaciente.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btAltaPaciente.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAltaPaciente.Location = New System.Drawing.Point(263, 321)
        Me.btAltaPaciente.Name = "btAltaPaciente"
        Me.btAltaPaciente.Size = New System.Drawing.Size(121, 23)
        Me.btAltaPaciente.TabIndex = 2
        Me.btAltaPaciente.Text = "Admisión al Centro"
        Me.btAltaPaciente.UseVisualStyleBackColor = True
        Me.btAltaPaciente.Visible = False
        '
        'btEstadisticas
        '
        Me.btEstadisticas.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btEstadisticas.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btEstadisticas.Location = New System.Drawing.Point(329, 350)
        Me.btEstadisticas.Name = "btEstadisticas"
        Me.btEstadisticas.Size = New System.Drawing.Size(121, 23)
        Me.btEstadisticas.TabIndex = 3
        Me.btEstadisticas.Text = "Agenda"
        Me.btEstadisticas.UseVisualStyleBackColor = True
        Me.btEstadisticas.Visible = False
        '
        'btBusqueda
        '
        Me.btBusqueda.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btBusqueda.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btBusqueda.Location = New System.Drawing.Point(390, 321)
        Me.btBusqueda.Name = "btBusqueda"
        Me.btBusqueda.Size = New System.Drawing.Size(126, 23)
        Me.btBusqueda.TabIndex = 4
        Me.btBusqueda.Text = "Búsqueda de Paciente"
        Me.btBusqueda.UseVisualStyleBackColor = True
        Me.btBusqueda.Visible = False
        '
        'btHerramientas
        '
        Me.btHerramientas.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btHerramientas.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btHerramientas.Location = New System.Drawing.Point(456, 350)
        Me.btHerramientas.Name = "btHerramientas"
        Me.btHerramientas.Size = New System.Drawing.Size(126, 23)
        Me.btHerramientas.TabIndex = 5
        Me.btHerramientas.Text = "Herramientas"
        Me.btHerramientas.UseVisualStyleBackColor = True
        Me.btHerramientas.Visible = False
        '
        'btGruposTerap
        '
        Me.btGruposTerap.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btGruposTerap.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btGruposTerap.Location = New System.Drawing.Point(522, 321)
        Me.btGruposTerap.Name = "btGruposTerap"
        Me.btGruposTerap.Size = New System.Drawing.Size(126, 23)
        Me.btGruposTerap.TabIndex = 6
        Me.btGruposTerap.Text = "Grupos de Terapia"
        Me.btGruposTerap.UseVisualStyleBackColor = True
        Me.btGruposTerap.Visible = False
        '
        'btSalir
        '
        Me.btSalir.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSalir.Location = New System.Drawing.Point(837, 486)
        Me.btSalir.Name = "btSalir"
        Me.btSalir.Size = New System.Drawing.Size(62, 21)
        Me.btSalir.TabIndex = 8
        Me.btSalir.Text = "Salir"
        Me.btSalir.UseVisualStyleBackColor = True
        Me.btSalir.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(163, 29)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(585, 220)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'lbHora
        '
        Me.lbHora.AutoSize = True
        Me.lbHora.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbHora.Location = New System.Drawing.Point(67, 469)
        Me.lbHora.Name = "lbHora"
        Me.lbHora.Size = New System.Drawing.Size(142, 23)
        Me.lbHora.TabIndex = 10
        Me.lbHora.Text = "Cargando hora..."
        '
        'timerHora
        '
        Me.timerHora.Enabled = True
        Me.timerHora.Interval = 1000
        '
        'lbFecha
        '
        Me.lbFecha.AutoSize = True
        Me.lbFecha.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFecha.Location = New System.Drawing.Point(12, 442)
        Me.lbFecha.Name = "lbFecha"
        Me.lbFecha.Size = New System.Drawing.Size(153, 23)
        Me.lbFecha.TabIndex = 11
        Me.lbFecha.Text = "Cargando Fecha..."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(911, 519)
        Me.Controls.Add(Me.lbFecha)
        Me.Controls.Add(Me.lbHora)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btSalir)
        Me.Controls.Add(Me.btGruposTerap)
        Me.Controls.Add(Me.btHerramientas)
        Me.Controls.Add(Me.btBusqueda)
        Me.Controls.Add(Me.btEstadisticas)
        Me.Controls.Add(Me.btAltaPaciente)
        Me.Controls.Add(Me.btAcceso)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "siAlejandria-CTA"
        CType(Me.btAcceso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btAcceso As System.Windows.Forms.PictureBox
    Friend WithEvents btAltaPaciente As System.Windows.Forms.Button
    Friend WithEvents btEstadisticas As System.Windows.Forms.Button
    Friend WithEvents btBusqueda As System.Windows.Forms.Button
    Friend WithEvents btHerramientas As System.Windows.Forms.Button
    Friend WithEvents btGruposTerap As System.Windows.Forms.Button
    Friend WithEvents btSalir As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents lbHora As System.Windows.Forms.Label
    Private WithEvents timerHora As System.Windows.Forms.Timer
    Friend WithEvents lbFecha As System.Windows.Forms.Label

End Class
