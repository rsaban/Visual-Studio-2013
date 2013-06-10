Imports System.Data.Objects
Imports System.Data.Objects.DataClasses


Public Class formBusqueda

    Private Sub formBusqueda_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        tbBuscar.Focus()
    End Sub


#Region "BUSCAR"
    Private Sub btBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btBuscar.Click

        bdAlej = New bdAlejandriaCTAEntities1
    
        Dim history As ObjectSet(Of HISTORIA) = bdAlej.HISTORIA
        Dim pacients As ObjectSet(Of PACIENTES) = bdAlej.PACIENTES

        If rbHistoria.Checked Then
            Try
                dgvBusqueda.DataSource = (From hist In history Join pac In pacients On hist.IdPaciente Equals pac.IdPaciente _
                          Where hist.IdHistoria.Contains(tbBuscar.Text) _
                          Select New With {hist.IdHistoria, pac.NombrePaciente, pac.DNI})
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        ElseIf rbDNI.Checked Then
            Try
                dgvBusqueda.DataSource = (From hist In history Join pac In pacients On hist.IdPaciente Equals pac.IdPaciente _
                          Where pac.DNI.Contains(tbBuscar.Text) _
                          Select New With {hist.IdHistoria, pac.NombrePaciente, pac.DNI})
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        ElseIf rbNombre.Checked Then
            Try
                dgvBusqueda.DataSource = (From hist In history Join pac In pacients On hist.IdPaciente Equals pac.IdPaciente _
                          Where pac.NombrePaciente.Contains(tbBuscar.Text) _
                          Select New With {hist.IdHistoria, pac.NombrePaciente, pac.DNI})
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If

    End Sub
#End Region

#Region "VER HISTORIA"
    Private Sub btVerHistoria_Click(sender As System.Object, e As System.EventArgs) Handles btVerHistoria.Click

        formFichaPaciente.btActualizar.Visible = True
        Dim buscandoHistoria As String
        Try
            buscandoHistoria = dgvBusqueda.CurrentRow.Cells.Item("IdHistoria").Value.ToString
        Catch ex As Exception
            MsgBox("No hay resultados para mostrar")
            Exit Sub
        End Try

        'compruebo el nivel de acceso del usuario (para mostrar lo que tenga permitido)
        Dim nivelTecnico As Integer
        Dim usu As ObjectSet(Of USUGES) = bdAlej.USUGES
        Dim consultaNivel = (From tec In usu Where tec.NombreUsuGes = nombreUsuarioActivo.Trim Select New With {tec.Nivel})
        For Each r In consultaNivel
            nivelTecnico = r.Nivel
        Next

        '------------------------------------------
        'Recuperamos la fecha de admision a TTº y la Fecha de Alta Terapeutica para saber si el paciente está en tratamiento
        Dim alta As ObjectSet(Of ALTA) = bdAlej.ALTA
        Dim ingreso As ObjectSet(Of INGRESO) = bdAlej.INGRESO
        Dim fechaIngreso As Date

        Dim queryIngreso = (From ingr In ingreso Where ingr.IdHistoria = buscandoHistoria Order By ingr.FechaAdmisionTTo Descending _
                            Select New With {ingr.FechaAdmisionTTo})
        fechaIngreso = queryIngreso.First.FechaAdmisionTTo.ToShortDateString

        Dim contador = (Aggregate order In alta Where order.IdHistoria = buscandoHistoria Into Count(order.FechaAlta >= fechaIngreso))

        If contador >= 1 Then
            formFichaPaciente.btActualizar.Visible = False
            formFichaPaciente.gbxDatosPaciente.Enabled = False
            formFichaPaciente.gbxDatosInicioTT.Enabled = False
            formFichaPaciente.gbxDatosFactur.Enabled = False
            formFichaPaciente.btAltaTerapeutica.Visible = False
            formFichaPaciente.btHistPs.Enabled = False
            formFichaPaciente.btHsMedica.Enabled = False
            formFichaPaciente.btHsSocial.Enabled = False
            formFichaPaciente.lklbReapertura.Visible = True
            formFichaPaciente.lbExpdteCerrado.Visible = True
        End If

        '------------------------------------------


        Dim history As ObjectSet(Of HISTORIA) = bdAlej.HISTORIA
        Dim pacients As ObjectSet(Of PACIENTES) = bdAlej.PACIENTES
        Dim factury As ObjectSet(Of FACTURACION) = bdAlej.FACTURACION
        Dim ingres As ObjectSet(Of INGRESO) = bdAlej.INGRESO

        'PRIMERO RECUPERAMOS LOS DATOS DE LAS TABLAS HISTORIA, PACIENTES Y FACTURACION

        Dim query = (From hist In history Join pac In pacients On hist.IdPaciente Equals pac.IdPaciente _
                                             Where hist.IdHistoria = buscandoHistoria And pac.IdPaciente = hist.IdPaciente _
                                             Select New With {hist.IdHistoria, hist.DemandaIncialTTo, hist.TToAnterior, hist.TToActual, _
                                                              pac.NombrePaciente, pac.DNI, pac.Direccion, pac.Telefono, pac.Movil, pac.Mail, pac.EstadoCivil, pac.FechaNacimiento, _
                                                              pac.CP, pac.Localidad, pac.Provincia, pac.FechaDesempleo, pac.FechaPrestDesempl, pac.Sexo})


        ''PRIMERO RECUPERAMOS LOS DATOS DE LAS TABLAS HISTORIA, PACIENTES Y FACTURACION

        'Dim query = (From hist In history Join pac In pacients On hist.IdPaciente Equals pac.IdPaciente Join fac In factury _
        '                                     On pac.CodFacturacion Equals fac.CodFacturacion _
        '                                     Where hist.IdHistoria = buscandoHistoria And pac.IdPaciente = hist.IdPaciente And fac.CodFacturacion = pac.CodFacturacion _
        '                                     Select New With {hist.IdHistoria, hist.DemandaIncialTTo, _
        '                                                      pac.NombrePaciente, pac.DNI, pac.Direccion, pac.Telefono, pac.Movil, pac.Mail, pac.EstadoCivil, pac.FechaNacimiento, _
        '                                                      pac.CP, pac.Localidad, pac.Provincia, pac.FechaDesempleo, pac.FechaPrestDesempl, _
        '                                                      fac.CodFacturacion, fac.PagosAlDia})
        'repetida: Dim query2 = (From ingr In ingres Where ingr.IdHistoria = buscandoHistoria Order By ingr.FechaAdmisionTTo Descending Select New With {ingr.FechaAdmisionTTo})

        'GRABAMOS LOS VALORES EN SUS TEXTBOX CORRESPONDIENTES
        Try
            For Each d In query
                formFichaPaciente.tbHistoria.Text = d.IdHistoria
                formFichaPaciente.cbxDemandaInicial.Text = d.DemandaIncialTTo
                formFichaPaciente.tbTToAnterior.Text = d.TToAnterior
                formFichaPaciente.tbTToActual.Text = d.TToActual
                formFichaPaciente.tbNombre.Text = d.NombrePaciente
                formFichaPaciente.tbDNI.Text = d.DNI
                formFichaPaciente.tbDireccion.Text = d.Direccion
                formFichaPaciente.tbTlfnoFijo.Text = d.Telefono
                formFichaPaciente.tbTlfnoMovil.Text = d.Movil
                formFichaPaciente.tbMail.Text = d.Mail
                formFichaPaciente.cbxEstadoCivil.Text = d.EstadoCivil
                formFichaPaciente.cbxSexo.Text = d.Sexo
                If Not (IsNothing(d.FechaNacimiento)) Then
                    formFichaPaciente.tbFechaNacimiento.Text = d.FechaNacimiento
                End If
                formFichaPaciente.tbCP.Text = d.CP
                formFichaPaciente.tbLocalidad.Text = d.Localidad
                formFichaPaciente.tbProvincia.Text = d.Provincia
                If Not (IsNothing(d.FechaDesempleo)) Then
                    formFichaPaciente.tbFechaDesempleo.Text = d.FechaDesempleo
                End If
                If Not (IsNothing(d.FechaPrestDesempl)) Then
                    formFichaPaciente.tbFechaPrestDesempl.Text = d.FechaPrestDesempl
                End If
                ' formFichaPaciente.tbCodFac.Text = d.CodFacturacion
                ' formFichaPaciente.cbxPagosAlDia.Text = d.PagosAlDia
            Next


            'SEGUNDO, RECUPERAMOS LA ÚLTIMA FECHA DE INGRESO
            Dim query3 = (From ingr In ingres Where ingr.IdHistoria = buscandoHistoria Order By ingr.FechaAdmisionTTo Descending Select New With {ingr.FechaAdmisionTTo})
            'GRABAMOS SU VALOR EN EL TEXTBOX CORRESPONDIENTE
            formFichaPaciente.tbFechaAdmisionTTo.Text = query3.First.FechaAdmisionTTo.ToShortDateString

            'mostramos la facturacion sólo para la clave 3

            If nivelTecnico = 3 Then
                Dim codFac As String
                'vamos a consultar  el codigo de facturacion
                Dim query2 = (From f In factury Join p In pacients On f.CodFacturacion Equals p.CodFacturacion Join h In history On p.IdPaciente Equals h.IdPaciente Where h.IdHistoria = buscandoHistoria Select New With {f.CodFacturacion})
                If query2.Count <> 0 Then
                    formFichaPaciente.tbCodFac.Text = query2.First.CodFacturacion.Trim
                    codFac = query2.First.CodFacturacion.Trim
                Else
                    formFichaPaciente.btActualizarFac.Enabled = False
                End If

                'consultamos también la facturacion real
                Dim facReal As ObjectSet(Of FACTURACION_REAL) = bdAlej.FACTURACION_REAL
                Dim consultandoFacReal = (From fC In facReal Where fC.CodFacturacion = codFac Select fC)
                formFichaPaciente.dgvFac.DataSource = consultandoFacReal

                'llenamos el combobox de los codigos
                Dim codsFacs As ObjectSet(Of CODIGOS_FACTURACION) = bdAlej.CODIGOS_FACTURACION
                Dim consultadoCodigos = (From cf In codsFacs Select cf)
                For Each x In consultadoCodigos
                    formFichaPaciente.cbxCodigo.Items.Add(x.Codigo)
                Next

            Else
                formFichaPaciente.tbCodFac.Visible = False
                formFichaPaciente.Label2.Visible = False
                formFichaPaciente.dgvFac.Visible = False
                formFichaPaciente.lbCodigo.Visible = False
                formFichaPaciente.lbCantidad.Visible = False
                formFichaPaciente.lbPagosAlDia.Visible = False
                formFichaPaciente.cbxCodigo.Visible = False
                formFichaPaciente.tbCantidad.Visible = False
                formFichaPaciente.cbxPagosAlDia.Visible = False
                formFichaPaciente.btActualizarFac.Visible = False
                formFichaPaciente.cmsFacturacion.Enabled = False
                formFichaPaciente.gbxDatosFactur.Text = "No accesible"
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        nombrePaciente = dgvBusqueda.CurrentRow.Cells.Item("NombrePaciente").Value.ToString

        If nivelTecnico = 2 Then
            formFichaPaciente.btActualizar.Enabled = False
            formFichaPaciente.btAltaTerapeutica.Enabled = False
            formFichaPaciente.btHistPs.Enabled = False
            formFichaPaciente.btHsMedica.Enabled = False
            formFichaPaciente.btHsSocial.Enabled = False
            formFichaPaciente.btRegistrarAlta.Enabled = False
        End If

        If String.IsNullOrWhiteSpace(formFichaPaciente.tbCodFac.Text) Then
            formFichaPaciente.tbCodFac.Enabled = False
        End If

        formFichaPaciente.Show()

        Me.Close()

    End Sub
#End Region

#Region "Mostrar Resultado del Aviso en el Buscador"
    Private Sub btMostrarEnBuscador_Click(sender As System.Object, e As System.EventArgs) Handles btMostrarEnBuscador.Click
        Me.Text = "Búsqueda de Pacientes"
        btBuscar.Enabled = True
        tbBuscar.Enabled = True
        rbDNI.Enabled = True
        rbHistoria.Enabled = True
        rbNombre.Enabled = True
        btVerHistoria.Visible = True
        btMostrarEnBuscador.Visible = False

        tbBuscar.Text = dgvBusqueda.CurrentRow.Cells.Item("Historia").Value.ToString

        dgvBusqueda.DataSource = Nothing
        dgvBusqueda.Columns.Clear()
        btBuscar.PerformClick()
    End Sub
#End Region
End Class


'EJEMPLO CONSULTA

'  bdAlej = New bdAlejandriaCTAEntities

'Dim consultaCitas As ObjectQuery(Of CITAS) = From d In bdAlej.CITAS.Include(tbHistoria.Text) Order By d.IdTecnico Select d


'otra consulta
'dgvBusqueda.DataSource = (From resultadoBusqueda In bdAlej.HISTORIA Where resultadoBusqueda.IdHistoria = tbBuscar.Text _
'                                    Select New With {resultadoBusqueda.IdHistoria, _
'                                                     resultadoBusqueda.IdPaciente})