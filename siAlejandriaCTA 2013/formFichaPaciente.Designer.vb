<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formFichaPaciente
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formFichaPaciente))
        Me.gbxDatosPaciente = New System.Windows.Forms.GroupBox()
        Me.cbxSexo = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbTlfnoMovil = New System.Windows.Forms.TextBox()
        Me.tbProvincia = New System.Windows.Forms.TextBox()
        Me.lbProvincia = New System.Windows.Forms.Label()
        Me.tbMail = New System.Windows.Forms.TextBox()
        Me.tbTlfnoFijo = New System.Windows.Forms.TextBox()
        Me.tbLocalidad = New System.Windows.Forms.TextBox()
        Me.tbCP = New System.Windows.Forms.TextBox()
        Me.tbDireccion = New System.Windows.Forms.TextBox()
        Me.tbFechaNacimiento = New System.Windows.Forms.TextBox()
        Me.cbxEstadoCivil = New System.Windows.Forms.ComboBox()
        Me.tbDNI = New System.Windows.Forms.TextBox()
        Me.tbNombre = New System.Windows.Forms.TextBox()
        Me.tbHistoria = New System.Windows.Forms.TextBox()
        Me.lbEdad = New System.Windows.Forms.Label()
        Me.lbEstadoCivil = New System.Windows.Forms.Label()
        Me.lbTelefono = New System.Windows.Forms.Label()
        Me.lbMail = New System.Windows.Forms.Label()
        Me.lbLocalidad = New System.Windows.Forms.Label()
        Me.lbCP = New System.Windows.Forms.Label()
        Me.lbDireccion = New System.Windows.Forms.Label()
        Me.lbDNI = New System.Windows.Forms.Label()
        Me.lbNombre = New System.Windows.Forms.Label()
        Me.lbHistoria = New System.Windows.Forms.Label()
        Me.gbxDatosInicioTT = New System.Windows.Forms.GroupBox()
        Me.tbTToActual = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbTToAnterior = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbFechaPrestDesempl = New System.Windows.Forms.TextBox()
        Me.lbFechaPrestDesempl = New System.Windows.Forms.Label()
        Me.tbFechaDesempleo = New System.Windows.Forms.TextBox()
        Me.lbFechaDesempleo = New System.Windows.Forms.Label()
        Me.tbFechaAdmisionTTo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbDemandaInicial = New System.Windows.Forms.Label()
        Me.cbxDemandaInicial = New System.Windows.Forms.ComboBox()
        Me.btHistPs = New System.Windows.Forms.Button()
        Me.btHsSocial = New System.Windows.Forms.Button()
        Me.btHsMedica = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbxDatosFactur = New System.Windows.Forms.GroupBox()
        Me.cmsFacturacion = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ExportarFacturaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btActualizarFac = New System.Windows.Forms.Button()
        Me.tbCantidad = New System.Windows.Forms.TextBox()
        Me.cbxPagosAlDia = New System.Windows.Forms.ComboBox()
        Me.lbPagosAlDia = New System.Windows.Forms.Label()
        Me.lbCantidad = New System.Windows.Forms.Label()
        Me.lbCodigo = New System.Windows.Forms.Label()
        Me.dgvFac = New System.Windows.Forms.DataGridView()
        Me.tbCodFac = New System.Windows.Forms.TextBox()
        Me.btRegistrarAlta = New System.Windows.Forms.Button()
        Me.btAltaTerapeutica = New System.Windows.Forms.Button()
        Me.lbExpdteCerrado = New System.Windows.Forms.Label()
        Me.lklbReapertura = New System.Windows.Forms.LinkLabel()
        Me.btReapertura = New System.Windows.Forms.Button()
        Me.btActualizar = New System.Windows.Forms.Button()
        Me.cbxCodigo = New System.Windows.Forms.ComboBox()
        Me.gbxDatosPaciente.SuspendLayout()
        Me.gbxDatosInicioTT.SuspendLayout()
        Me.gbxDatosFactur.SuspendLayout()
        Me.cmsFacturacion.SuspendLayout()
        CType(Me.dgvFac, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbxDatosPaciente
        '
        Me.gbxDatosPaciente.BackColor = System.Drawing.Color.Khaki
        Me.gbxDatosPaciente.Controls.Add(Me.cbxSexo)
        Me.gbxDatosPaciente.Controls.Add(Me.Label4)
        Me.gbxDatosPaciente.Controls.Add(Me.tbTlfnoMovil)
        Me.gbxDatosPaciente.Controls.Add(Me.tbProvincia)
        Me.gbxDatosPaciente.Controls.Add(Me.lbProvincia)
        Me.gbxDatosPaciente.Controls.Add(Me.tbMail)
        Me.gbxDatosPaciente.Controls.Add(Me.tbTlfnoFijo)
        Me.gbxDatosPaciente.Controls.Add(Me.tbLocalidad)
        Me.gbxDatosPaciente.Controls.Add(Me.tbCP)
        Me.gbxDatosPaciente.Controls.Add(Me.tbDireccion)
        Me.gbxDatosPaciente.Controls.Add(Me.tbFechaNacimiento)
        Me.gbxDatosPaciente.Controls.Add(Me.cbxEstadoCivil)
        Me.gbxDatosPaciente.Controls.Add(Me.tbDNI)
        Me.gbxDatosPaciente.Controls.Add(Me.tbNombre)
        Me.gbxDatosPaciente.Controls.Add(Me.tbHistoria)
        Me.gbxDatosPaciente.Controls.Add(Me.lbEdad)
        Me.gbxDatosPaciente.Controls.Add(Me.lbEstadoCivil)
        Me.gbxDatosPaciente.Controls.Add(Me.lbTelefono)
        Me.gbxDatosPaciente.Controls.Add(Me.lbMail)
        Me.gbxDatosPaciente.Controls.Add(Me.lbLocalidad)
        Me.gbxDatosPaciente.Controls.Add(Me.lbCP)
        Me.gbxDatosPaciente.Controls.Add(Me.lbDireccion)
        Me.gbxDatosPaciente.Controls.Add(Me.lbDNI)
        Me.gbxDatosPaciente.Controls.Add(Me.lbNombre)
        Me.gbxDatosPaciente.Controls.Add(Me.lbHistoria)
        Me.gbxDatosPaciente.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxDatosPaciente.Location = New System.Drawing.Point(12, 12)
        Me.gbxDatosPaciente.Name = "gbxDatosPaciente"
        Me.gbxDatosPaciente.Size = New System.Drawing.Size(846, 180)
        Me.gbxDatosPaciente.TabIndex = 0
        Me.gbxDatosPaciente.TabStop = False
        Me.gbxDatosPaciente.Text = "Datos del Paciente"
        '
        'cbxSexo
        '
        Me.cbxSexo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cbxSexo.FormattingEnabled = True
        Me.cbxSexo.Items.AddRange(New Object() {"", "Varón", "Mujer"})
        Me.cbxSexo.Location = New System.Drawing.Point(740, 81)
        Me.cbxSexo.Name = "cbxSexo"
        Me.cbxSexo.Size = New System.Drawing.Size(79, 23)
        Me.cbxSexo.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(695, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 15)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Sexo:"
        '
        'tbTlfnoMovil
        '
        Me.tbTlfnoMovil.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbTlfnoMovil.Location = New System.Drawing.Point(235, 141)
        Me.tbTlfnoMovil.Name = "tbTlfnoMovil"
        Me.tbTlfnoMovil.Size = New System.Drawing.Size(100, 23)
        Me.tbTlfnoMovil.TabIndex = 11
        '
        'tbProvincia
        '
        Me.tbProvincia.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbProvincia.Location = New System.Drawing.Point(382, 111)
        Me.tbProvincia.Name = "tbProvincia"
        Me.tbProvincia.Size = New System.Drawing.Size(100, 23)
        Me.tbProvincia.TabIndex = 9
        '
        'lbProvincia
        '
        Me.lbProvincia.AutoSize = True
        Me.lbProvincia.Location = New System.Drawing.Point(320, 114)
        Me.lbProvincia.Name = "lbProvincia"
        Me.lbProvincia.Size = New System.Drawing.Size(59, 15)
        Me.lbProvincia.TabIndex = 20
        Me.lbProvincia.Text = "Provincia:"
        '
        'tbMail
        '
        Me.tbMail.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbMail.Location = New System.Drawing.Point(382, 140)
        Me.tbMail.Name = "tbMail"
        Me.tbMail.Size = New System.Drawing.Size(190, 23)
        Me.tbMail.TabIndex = 12
        '
        'tbTlfnoFijo
        '
        Me.tbTlfnoFijo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbTlfnoFijo.Location = New System.Drawing.Point(104, 140)
        Me.tbTlfnoFijo.Name = "tbTlfnoFijo"
        Me.tbTlfnoFijo.Size = New System.Drawing.Size(100, 23)
        Me.tbTlfnoFijo.TabIndex = 10
        '
        'tbLocalidad
        '
        Me.tbLocalidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbLocalidad.Location = New System.Drawing.Point(104, 111)
        Me.tbLocalidad.Name = "tbLocalidad"
        Me.tbLocalidad.Size = New System.Drawing.Size(100, 23)
        Me.tbLocalidad.TabIndex = 8
        '
        'tbCP
        '
        Me.tbCP.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbCP.Location = New System.Drawing.Point(382, 82)
        Me.tbCP.Name = "tbCP"
        Me.tbCP.Size = New System.Drawing.Size(74, 23)
        Me.tbCP.TabIndex = 7
        '
        'tbDireccion
        '
        Me.tbDireccion.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbDireccion.Location = New System.Drawing.Point(104, 81)
        Me.tbDireccion.Name = "tbDireccion"
        Me.tbDireccion.Size = New System.Drawing.Size(231, 23)
        Me.tbDireccion.TabIndex = 6
        '
        'tbFechaNacimiento
        '
        Me.tbFechaNacimiento.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbFechaNacimiento.Location = New System.Drawing.Point(740, 53)
        Me.tbFechaNacimiento.Name = "tbFechaNacimiento"
        Me.tbFechaNacimiento.Size = New System.Drawing.Size(79, 23)
        Me.tbFechaNacimiento.TabIndex = 5
        '
        'cbxEstadoCivil
        '
        Me.cbxEstadoCivil.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cbxEstadoCivil.FormattingEnabled = True
        Me.cbxEstadoCivil.Items.AddRange(New Object() {"", "Soltero/a", "Casado/a", "Viudo", "Divorc./a", "Pj. Hecho", "Separado/a", "Conv. Pj"})
        Me.cbxEstadoCivil.Location = New System.Drawing.Point(572, 53)
        Me.cbxEstadoCivil.Name = "cbxEstadoCivil"
        Me.cbxEstadoCivil.Size = New System.Drawing.Size(103, 23)
        Me.cbxEstadoCivil.TabIndex = 4
        '
        'tbDNI
        '
        Me.tbDNI.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbDNI.Location = New System.Drawing.Point(382, 53)
        Me.tbDNI.Name = "tbDNI"
        Me.tbDNI.Size = New System.Drawing.Size(106, 23)
        Me.tbDNI.TabIndex = 3
        '
        'tbNombre
        '
        Me.tbNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbNombre.Location = New System.Drawing.Point(104, 53)
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.Size = New System.Drawing.Size(231, 23)
        Me.tbNombre.TabIndex = 2
        '
        'tbHistoria
        '
        Me.tbHistoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbHistoria.Location = New System.Drawing.Point(104, 25)
        Me.tbHistoria.Name = "tbHistoria"
        Me.tbHistoria.ReadOnly = True
        Me.tbHistoria.Size = New System.Drawing.Size(100, 23)
        Me.tbHistoria.TabIndex = 1
        '
        'lbEdad
        '
        Me.lbEdad.AutoSize = True
        Me.lbEdad.Location = New System.Drawing.Point(695, 57)
        Me.lbEdad.Name = "lbEdad"
        Me.lbEdad.Size = New System.Drawing.Size(40, 15)
        Me.lbEdad.TabIndex = 9
        Me.lbEdad.Text = "F.Nac."
        '
        'lbEstadoCivil
        '
        Me.lbEstadoCivil.AutoSize = True
        Me.lbEstadoCivil.Location = New System.Drawing.Point(501, 57)
        Me.lbEstadoCivil.Name = "lbEstadoCivil"
        Me.lbEstadoCivil.Size = New System.Drawing.Size(71, 15)
        Me.lbEstadoCivil.TabIndex = 8
        Me.lbEstadoCivil.Text = "Estado Civil:"
        '
        'lbTelefono
        '
        Me.lbTelefono.AutoSize = True
        Me.lbTelefono.Location = New System.Drawing.Point(35, 144)
        Me.lbTelefono.Name = "lbTelefono"
        Me.lbTelefono.Size = New System.Drawing.Size(67, 15)
        Me.lbTelefono.TabIndex = 7
        Me.lbTelefono.Text = "Teléfono/s:"
        '
        'lbMail
        '
        Me.lbMail.AutoSize = True
        Me.lbMail.Location = New System.Drawing.Point(338, 144)
        Me.lbMail.Name = "lbMail"
        Me.lbMail.Size = New System.Drawing.Size(42, 15)
        Me.lbMail.TabIndex = 6
        Me.lbMail.Text = "E-mail:"
        '
        'lbLocalidad
        '
        Me.lbLocalidad.AutoSize = True
        Me.lbLocalidad.Location = New System.Drawing.Point(41, 115)
        Me.lbLocalidad.Name = "lbLocalidad"
        Me.lbLocalidad.Size = New System.Drawing.Size(59, 15)
        Me.lbLocalidad.TabIndex = 5
        Me.lbLocalidad.Text = "Localidad:"
        '
        'lbCP
        '
        Me.lbCP.AutoSize = True
        Me.lbCP.Location = New System.Drawing.Point(352, 85)
        Me.lbCP.Name = "lbCP"
        Me.lbCP.Size = New System.Drawing.Size(23, 15)
        Me.lbCP.TabIndex = 4
        Me.lbCP.Text = "CP:"
        '
        'lbDireccion
        '
        Me.lbDireccion.AutoSize = True
        Me.lbDireccion.Location = New System.Drawing.Point(42, 85)
        Me.lbDireccion.Name = "lbDireccion"
        Me.lbDireccion.Size = New System.Drawing.Size(61, 15)
        Me.lbDireccion.TabIndex = 3
        Me.lbDireccion.Text = "Dirección:"
        '
        'lbDNI
        '
        Me.lbDNI.AutoSize = True
        Me.lbDNI.Location = New System.Drawing.Point(347, 57)
        Me.lbDNI.Name = "lbDNI"
        Me.lbDNI.Size = New System.Drawing.Size(33, 15)
        Me.lbDNI.TabIndex = 2
        Me.lbDNI.Text = "DNI:"
        '
        'lbNombre
        '
        Me.lbNombre.AutoSize = True
        Me.lbNombre.Location = New System.Drawing.Point(50, 57)
        Me.lbNombre.Name = "lbNombre"
        Me.lbNombre.Size = New System.Drawing.Size(50, 15)
        Me.lbNombre.TabIndex = 1
        Me.lbNombre.Text = "Nombre:"
        '
        'lbHistoria
        '
        Me.lbHistoria.AutoSize = True
        Me.lbHistoria.Location = New System.Drawing.Point(37, 28)
        Me.lbHistoria.Name = "lbHistoria"
        Me.lbHistoria.Size = New System.Drawing.Size(69, 15)
        Me.lbHistoria.TabIndex = 0
        Me.lbHistoria.Text = "Nº Historia:"
        '
        'gbxDatosInicioTT
        '
        Me.gbxDatosInicioTT.BackColor = System.Drawing.Color.Khaki
        Me.gbxDatosInicioTT.Controls.Add(Me.tbTToActual)
        Me.gbxDatosInicioTT.Controls.Add(Me.Label6)
        Me.gbxDatosInicioTT.Controls.Add(Me.tbTToAnterior)
        Me.gbxDatosInicioTT.Controls.Add(Me.Label5)
        Me.gbxDatosInicioTT.Controls.Add(Me.tbFechaPrestDesempl)
        Me.gbxDatosInicioTT.Controls.Add(Me.lbFechaPrestDesempl)
        Me.gbxDatosInicioTT.Controls.Add(Me.tbFechaDesempleo)
        Me.gbxDatosInicioTT.Controls.Add(Me.lbFechaDesempleo)
        Me.gbxDatosInicioTT.Controls.Add(Me.tbFechaAdmisionTTo)
        Me.gbxDatosInicioTT.Controls.Add(Me.Label1)
        Me.gbxDatosInicioTT.Controls.Add(Me.lbDemandaInicial)
        Me.gbxDatosInicioTT.Controls.Add(Me.cbxDemandaInicial)
        Me.gbxDatosInicioTT.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxDatosInicioTT.Location = New System.Drawing.Point(12, 198)
        Me.gbxDatosInicioTT.Name = "gbxDatosInicioTT"
        Me.gbxDatosInicioTT.Size = New System.Drawing.Size(846, 127)
        Me.gbxDatosInicioTT.TabIndex = 1
        Me.gbxDatosInicioTT.TabStop = False
        Me.gbxDatosInicioTT.Text = "Datos al Inicio del TTº"
        '
        'tbTToActual
        '
        Me.tbTToActual.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbTToActual.Location = New System.Drawing.Point(405, 85)
        Me.tbTToActual.Name = "tbTToActual"
        Me.tbTToActual.Size = New System.Drawing.Size(182, 23)
        Me.tbTToActual.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(297, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 15)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Tratamiento Actual:"
        '
        'tbTToAnterior
        '
        Me.tbTToAnterior.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbTToAnterior.Location = New System.Drawing.Point(405, 59)
        Me.tbTToAnterior.Name = "tbTToAnterior"
        Me.tbTToAnterior.Size = New System.Drawing.Size(182, 23)
        Me.tbTToAnterior.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(286, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 15)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Tratamiento Anterior:"
        '
        'tbFechaPrestDesempl
        '
        Me.tbFechaPrestDesempl.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbFechaPrestDesempl.Location = New System.Drawing.Point(133, 85)
        Me.tbFechaPrestDesempl.Name = "tbFechaPrestDesempl"
        Me.tbFechaPrestDesempl.Size = New System.Drawing.Size(103, 23)
        Me.tbFechaPrestDesempl.TabIndex = 16
        '
        'lbFechaPrestDesempl
        '
        Me.lbFechaPrestDesempl.AutoSize = True
        Me.lbFechaPrestDesempl.Location = New System.Drawing.Point(11, 88)
        Me.lbFechaPrestDesempl.Name = "lbFechaPrestDesempl"
        Me.lbFechaPrestDesempl.Size = New System.Drawing.Size(121, 15)
        Me.lbFechaPrestDesempl.TabIndex = 6
        Me.lbFechaPrestDesempl.Text = "Prestación Desempleo:"
        '
        'tbFechaDesempleo
        '
        Me.tbFechaDesempleo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbFechaDesempleo.Location = New System.Drawing.Point(133, 59)
        Me.tbFechaDesempleo.Name = "tbFechaDesempleo"
        Me.tbFechaDesempleo.Size = New System.Drawing.Size(103, 23)
        Me.tbFechaDesempleo.TabIndex = 15
        '
        'lbFechaDesempleo
        '
        Me.lbFechaDesempleo.AutoSize = True
        Me.lbFechaDesempleo.Location = New System.Drawing.Point(31, 62)
        Me.lbFechaDesempleo.Name = "lbFechaDesempleo"
        Me.lbFechaDesempleo.Size = New System.Drawing.Size(97, 15)
        Me.lbFechaDesempleo.TabIndex = 4
        Me.lbFechaDesempleo.Text = "Fecha Desempleo:"
        '
        'tbFechaAdmisionTTo
        '
        Me.tbFechaAdmisionTTo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbFechaAdmisionTTo.Location = New System.Drawing.Point(133, 33)
        Me.tbFechaAdmisionTTo.Name = "tbFechaAdmisionTTo"
        Me.tbFechaAdmisionTTo.Size = New System.Drawing.Size(103, 23)
        Me.tbFechaAdmisionTTo.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Fecha Admisión a TTº:"
        '
        'lbDemandaInicial
        '
        Me.lbDemandaInicial.AutoSize = True
        Me.lbDemandaInicial.Location = New System.Drawing.Point(311, 36)
        Me.lbDemandaInicial.Name = "lbDemandaInicial"
        Me.lbDemandaInicial.Size = New System.Drawing.Size(94, 15)
        Me.lbDemandaInicial.TabIndex = 1
        Me.lbDemandaInicial.Text = "Demanda Inicial:"
        '
        'cbxDemandaInicial
        '
        Me.cbxDemandaInicial.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cbxDemandaInicial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cbxDemandaInicial.FormattingEnabled = True
        Me.cbxDemandaInicial.Location = New System.Drawing.Point(405, 33)
        Me.cbxDemandaInicial.Name = "cbxDemandaInicial"
        Me.cbxDemandaInicial.Size = New System.Drawing.Size(182, 23)
        Me.cbxDemandaInicial.TabIndex = 14
        '
        'btHistPs
        '
        Me.btHistPs.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btHistPs.Location = New System.Drawing.Point(526, 429)
        Me.btHistPs.Name = "btHistPs"
        Me.btHistPs.Size = New System.Drawing.Size(107, 23)
        Me.btHistPs.TabIndex = 20
        Me.btHistPs.Text = "Hª Psicológica"
        Me.btHistPs.UseVisualStyleBackColor = True
        '
        'btHsSocial
        '
        Me.btHsSocial.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btHsSocial.Location = New System.Drawing.Point(639, 429)
        Me.btHsSocial.Name = "btHsSocial"
        Me.btHsSocial.Size = New System.Drawing.Size(107, 23)
        Me.btHsSocial.TabIndex = 21
        Me.btHsSocial.Text = "Hª Social"
        Me.btHsSocial.UseVisualStyleBackColor = True
        '
        'btHsMedica
        '
        Me.btHsMedica.BackColor = System.Drawing.SystemColors.Control
        Me.btHsMedica.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btHsMedica.Location = New System.Drawing.Point(752, 429)
        Me.btHsMedica.Name = "btHsMedica"
        Me.btHsMedica.Size = New System.Drawing.Size(107, 23)
        Me.btHsMedica.TabIndex = 22
        Me.btHsMedica.Text = "Hª Médica"
        Me.btHsMedica.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Codigo Facturación:"
        '
        'gbxDatosFactur
        '
        Me.gbxDatosFactur.BackColor = System.Drawing.Color.Khaki
        Me.gbxDatosFactur.ContextMenuStrip = Me.cmsFacturacion
        Me.gbxDatosFactur.Controls.Add(Me.cbxCodigo)
        Me.gbxDatosFactur.Controls.Add(Me.btActualizarFac)
        Me.gbxDatosFactur.Controls.Add(Me.tbCantidad)
        Me.gbxDatosFactur.Controls.Add(Me.cbxPagosAlDia)
        Me.gbxDatosFactur.Controls.Add(Me.lbPagosAlDia)
        Me.gbxDatosFactur.Controls.Add(Me.lbCantidad)
        Me.gbxDatosFactur.Controls.Add(Me.lbCodigo)
        Me.gbxDatosFactur.Controls.Add(Me.dgvFac)
        Me.gbxDatosFactur.Controls.Add(Me.tbCodFac)
        Me.gbxDatosFactur.Controls.Add(Me.Label2)
        Me.gbxDatosFactur.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxDatosFactur.Location = New System.Drawing.Point(13, 331)
        Me.gbxDatosFactur.Name = "gbxDatosFactur"
        Me.gbxDatosFactur.Size = New System.Drawing.Size(846, 92)
        Me.gbxDatosFactur.TabIndex = 4
        Me.gbxDatosFactur.TabStop = False
        Me.gbxDatosFactur.Text = "Datos de Facturación"
        '
        'cmsFacturacion
        '
        Me.cmsFacturacion.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportarFacturaciónToolStripMenuItem})
        Me.cmsFacturacion.Name = "cmsFacturacion"
        Me.cmsFacturacion.Size = New System.Drawing.Size(183, 26)
        '
        'ExportarFacturaciónToolStripMenuItem
        '
        Me.ExportarFacturaciónToolStripMenuItem.Name = "ExportarFacturaciónToolStripMenuItem"
        Me.ExportarFacturaciónToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.ExportarFacturaciónToolStripMenuItem.Text = "Exportar Facturación"
        '
        'btActualizarFac
        '
        Me.btActualizarFac.Location = New System.Drawing.Point(733, 54)
        Me.btActualizarFac.Name = "btActualizarFac"
        Me.btActualizarFac.Size = New System.Drawing.Size(95, 23)
        Me.btActualizarFac.TabIndex = 25
        Me.btActualizarFac.Text = "Actualizar Fac"
        Me.btActualizarFac.UseVisualStyleBackColor = True
        '
        'tbCantidad
        '
        Me.tbCantidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbCantidad.Location = New System.Drawing.Point(635, 54)
        Me.tbCantidad.Name = "tbCantidad"
        Me.tbCantidad.Size = New System.Drawing.Size(56, 23)
        Me.tbCantidad.TabIndex = 24
        '
        'cbxPagosAlDia
        '
        Me.cbxPagosAlDia.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cbxPagosAlDia.FormattingEnabled = True
        Me.cbxPagosAlDia.Items.AddRange(New Object() {"", "Sí", "No"})
        Me.cbxPagosAlDia.Location = New System.Drawing.Point(772, 25)
        Me.cbxPagosAlDia.Name = "cbxPagosAlDia"
        Me.cbxPagosAlDia.Size = New System.Drawing.Size(56, 23)
        Me.cbxPagosAlDia.TabIndex = 22
        '
        'lbPagosAlDia
        '
        Me.lbPagosAlDia.AutoSize = True
        Me.lbPagosAlDia.Location = New System.Drawing.Point(694, 28)
        Me.lbPagosAlDia.Name = "lbPagosAlDia"
        Me.lbPagosAlDia.Size = New System.Drawing.Size(72, 15)
        Me.lbPagosAlDia.TabIndex = 21
        Me.lbPagosAlDia.Text = "Pagos al Día:"
        '
        'lbCantidad
        '
        Me.lbCantidad.AutoSize = True
        Me.lbCantidad.Location = New System.Drawing.Point(574, 57)
        Me.lbCantidad.Name = "lbCantidad"
        Me.lbCantidad.Size = New System.Drawing.Size(55, 15)
        Me.lbCantidad.TabIndex = 20
        Me.lbCantidad.Text = "Cantidad:"
        '
        'lbCodigo
        '
        Me.lbCodigo.AutoSize = True
        Me.lbCodigo.Location = New System.Drawing.Point(584, 25)
        Me.lbCodigo.Name = "lbCodigo"
        Me.lbCodigo.Size = New System.Drawing.Size(45, 15)
        Me.lbCodigo.TabIndex = 19
        Me.lbCodigo.Text = "Código:"
        '
        'dgvFac
        '
        Me.dgvFac.AllowUserToAddRows = False
        Me.dgvFac.AllowUserToDeleteRows = False
        Me.dgvFac.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvFac.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.dgvFac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFac.Location = New System.Drawing.Point(238, 11)
        Me.dgvFac.Name = "dgvFac"
        Me.dgvFac.ReadOnly = True
        Me.dgvFac.RowHeadersVisible = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.dgvFac.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvFac.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvFac.Size = New System.Drawing.Size(333, 74)
        Me.dgvFac.TabIndex = 18
        '
        'tbCodFac
        '
        Me.tbCodFac.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbCodFac.Location = New System.Drawing.Point(132, 22)
        Me.tbCodFac.Name = "tbCodFac"
        Me.tbCodFac.ReadOnly = True
        Me.tbCodFac.Size = New System.Drawing.Size(100, 23)
        Me.tbCodFac.TabIndex = 17
        '
        'btRegistrarAlta
        '
        Me.btRegistrarAlta.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btRegistrarAlta.Location = New System.Drawing.Point(597, 447)
        Me.btRegistrarAlta.Name = "btRegistrarAlta"
        Me.btRegistrarAlta.Size = New System.Drawing.Size(107, 23)
        Me.btRegistrarAlta.TabIndex = 19
        Me.btRegistrarAlta.Text = "Registrar Alta"
        Me.btRegistrarAlta.UseVisualStyleBackColor = True
        Me.btRegistrarAlta.Visible = False
        '
        'btAltaTerapeutica
        '
        Me.btAltaTerapeutica.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAltaTerapeutica.Location = New System.Drawing.Point(413, 429)
        Me.btAltaTerapeutica.Name = "btAltaTerapeutica"
        Me.btAltaTerapeutica.Size = New System.Drawing.Size(107, 23)
        Me.btAltaTerapeutica.TabIndex = 24
        Me.btAltaTerapeutica.Text = "Alta Terapéutica"
        Me.btAltaTerapeutica.UseVisualStyleBackColor = True
        '
        'lbExpdteCerrado
        '
        Me.lbExpdteCerrado.AutoSize = True
        Me.lbExpdteCerrado.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbExpdteCerrado.ForeColor = System.Drawing.Color.Maroon
        Me.lbExpdteCerrado.Location = New System.Drawing.Point(9, 434)
        Me.lbExpdteCerrado.Name = "lbExpdteCerrado"
        Me.lbExpdteCerrado.Size = New System.Drawing.Size(230, 15)
        Me.lbExpdteCerrado.TabIndex = 7
        Me.lbExpdteCerrado.Text = "El paciente no se encuentra en Tratamiento."
        Me.lbExpdteCerrado.Visible = False
        '
        'lklbReapertura
        '
        Me.lklbReapertura.AutoSize = True
        Me.lklbReapertura.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lklbReapertura.Location = New System.Drawing.Point(244, 433)
        Me.lklbReapertura.Name = "lklbReapertura"
        Me.lklbReapertura.Size = New System.Drawing.Size(147, 15)
        Me.lklbReapertura.TabIndex = 25
        Me.lklbReapertura.TabStop = True
        Me.lklbReapertura.Text = "¿Desea reabrir la Historia?"
        Me.lklbReapertura.Visible = False
        '
        'btReapertura
        '
        Me.btReapertura.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btReapertura.Location = New System.Drawing.Point(12, 429)
        Me.btReapertura.Name = "btReapertura"
        Me.btReapertura.Size = New System.Drawing.Size(107, 23)
        Me.btReapertura.TabIndex = 9
        Me.btReapertura.Text = "Reabrir Historia"
        Me.btReapertura.UseVisualStyleBackColor = True
        Me.btReapertura.Visible = False
        '
        'btActualizar
        '
        Me.btActualizar.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btActualizar.Location = New System.Drawing.Point(12, 429)
        Me.btActualizar.Name = "btActualizar"
        Me.btActualizar.Size = New System.Drawing.Size(107, 23)
        Me.btActualizar.TabIndex = 23
        Me.btActualizar.Text = "Actualizar Datos"
        Me.btActualizar.UseVisualStyleBackColor = True
        Me.btActualizar.Visible = False
        '
        'cbxCodigo
        '
        Me.cbxCodigo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cbxCodigo.FormattingEnabled = True
        Me.cbxCodigo.Location = New System.Drawing.Point(635, 22)
        Me.cbxCodigo.Name = "cbxCodigo"
        Me.cbxCodigo.Size = New System.Drawing.Size(56, 23)
        Me.cbxCodigo.TabIndex = 26
        '
        'formFichaPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Peru
        Me.ClientSize = New System.Drawing.Size(875, 470)
        Me.Controls.Add(Me.btActualizar)
        Me.Controls.Add(Me.btReapertura)
        Me.Controls.Add(Me.lklbReapertura)
        Me.Controls.Add(Me.lbExpdteCerrado)
        Me.Controls.Add(Me.btAltaTerapeutica)
        Me.Controls.Add(Me.btRegistrarAlta)
        Me.Controls.Add(Me.gbxDatosFactur)
        Me.Controls.Add(Me.btHsMedica)
        Me.Controls.Add(Me.btHsSocial)
        Me.Controls.Add(Me.btHistPs)
        Me.Controls.Add(Me.gbxDatosInicioTT)
        Me.Controls.Add(Me.gbxDatosPaciente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "formFichaPaciente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ficha de Paciente"
        Me.gbxDatosPaciente.ResumeLayout(False)
        Me.gbxDatosPaciente.PerformLayout()
        Me.gbxDatosInicioTT.ResumeLayout(False)
        Me.gbxDatosInicioTT.PerformLayout()
        Me.gbxDatosFactur.ResumeLayout(False)
        Me.gbxDatosFactur.PerformLayout()
        Me.cmsFacturacion.ResumeLayout(False)
        CType(Me.dgvFac, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbxDatosPaciente As System.Windows.Forms.GroupBox
    Friend WithEvents tbMail As System.Windows.Forms.TextBox
    Friend WithEvents tbTlfnoFijo As System.Windows.Forms.TextBox
    Friend WithEvents tbLocalidad As System.Windows.Forms.TextBox
    Friend WithEvents tbCP As System.Windows.Forms.TextBox
    Friend WithEvents tbDireccion As System.Windows.Forms.TextBox
    Friend WithEvents tbFechaNacimiento As System.Windows.Forms.TextBox
    Friend WithEvents cbxEstadoCivil As System.Windows.Forms.ComboBox
    Friend WithEvents tbDNI As System.Windows.Forms.TextBox
    Friend WithEvents tbNombre As System.Windows.Forms.TextBox
    Friend WithEvents tbHistoria As System.Windows.Forms.TextBox
    Friend WithEvents lbEdad As System.Windows.Forms.Label
    Friend WithEvents lbEstadoCivil As System.Windows.Forms.Label
    Friend WithEvents lbTelefono As System.Windows.Forms.Label
    Friend WithEvents lbMail As System.Windows.Forms.Label
    Friend WithEvents lbLocalidad As System.Windows.Forms.Label
    Friend WithEvents lbCP As System.Windows.Forms.Label
    Friend WithEvents lbDireccion As System.Windows.Forms.Label
    Friend WithEvents lbDNI As System.Windows.Forms.Label
    Friend WithEvents lbNombre As System.Windows.Forms.Label
    Friend WithEvents lbHistoria As System.Windows.Forms.Label
    Friend WithEvents gbxDatosInicioTT As System.Windows.Forms.GroupBox
    Friend WithEvents btHistPs As System.Windows.Forms.Button
    Friend WithEvents btHsSocial As System.Windows.Forms.Button
    Friend WithEvents btHsMedica As System.Windows.Forms.Button
    Friend WithEvents tbFechaAdmisionTTo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbDemandaInicial As System.Windows.Forms.Label
    Friend WithEvents cbxDemandaInicial As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents gbxDatosFactur As System.Windows.Forms.GroupBox
    Friend WithEvents tbCodFac As System.Windows.Forms.TextBox
    Friend WithEvents tbProvincia As System.Windows.Forms.TextBox
    Friend WithEvents lbProvincia As System.Windows.Forms.Label
    Friend WithEvents btRegistrarAlta As System.Windows.Forms.Button
    Friend WithEvents tbTlfnoMovil As System.Windows.Forms.TextBox
    Friend WithEvents tbFechaPrestDesempl As System.Windows.Forms.TextBox
    Friend WithEvents lbFechaPrestDesempl As System.Windows.Forms.Label
    Friend WithEvents tbFechaDesempleo As System.Windows.Forms.TextBox
    Friend WithEvents lbFechaDesempleo As System.Windows.Forms.Label
    Friend WithEvents btAltaTerapeutica As System.Windows.Forms.Button
    Friend WithEvents lbExpdteCerrado As System.Windows.Forms.Label
    Friend WithEvents lklbReapertura As System.Windows.Forms.LinkLabel
    Friend WithEvents btReapertura As System.Windows.Forms.Button
    Friend WithEvents btActualizar As System.Windows.Forms.Button
    Friend WithEvents cbxSexo As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbTToActual As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tbTToAnterior As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btActualizarFac As System.Windows.Forms.Button
    Friend WithEvents tbCantidad As System.Windows.Forms.TextBox
    Friend WithEvents cbxPagosAlDia As System.Windows.Forms.ComboBox
    Friend WithEvents lbPagosAlDia As System.Windows.Forms.Label
    Friend WithEvents lbCantidad As System.Windows.Forms.Label
    Friend WithEvents lbCodigo As System.Windows.Forms.Label
    Friend WithEvents dgvFac As System.Windows.Forms.DataGridView
    Friend WithEvents cmsFacturacion As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ExportarFacturaciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cbxCodigo As System.Windows.Forms.ComboBox
End Class
