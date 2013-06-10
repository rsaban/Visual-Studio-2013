Imports System.Data.Objects
Imports System.Data.Objects.DataClasses
Imports System.IO
Imports Microsoft.Office.Interop

Public Class formFichaPaciente
    Dim fechaAlta As String 'es para la reapertura. la ponglo global porque si no, no me toma el valor en la comparación

    Private WithEvents ApExcel As Excel.Application
    Private WithEvents LibroExcel As Excel.Workbook
    Private WithEvents HojaExcel As Excel.Worksheet

    Private Sub btHistPs_Click(sender As System.Object, e As System.EventArgs) Handles btHistPs.Click

        Dim historyPs As ObjectSet(Of HISTORIA_PSICOLOGICA) = bdAlej.HISTORIA_PSICOLOGICA

        Dim query = (From hist In historyPs Where hist.IdHistoria = tbHistoria.Text _
                                         Select hist).FirstOrDefault

        Try
            formHistoriaPsicologica.tb1Entrevista.Text = query.Fecha1Entrevista
            formHistoriaPsicologica.tbQuienDemanda.Text = query.QuienDemanda
            formHistoriaPsicologica.tbInformacion.Text = query.InformacionDemanda
            formHistoriaPsicologica.tbAnamnesis.Text = query.Anamnesis
            formHistoriaPsicologica.tbPercpPac.Text = query.PercpPaciente
            formHistoriaPsicologica.tbPercpEntorno.Text = query.PercpEntorno
            formHistoriaPsicologica.tbQueja.Text = query.Quejoso
            formHistoriaPsicologica.tbTToAnteriores.Text = query.TTosAnteriores
            formHistoriaPsicologica.tbSoluciones.Text = query.SolucionesIntentadas
            formHistoriaPsicologica.tbCausas.Text = query.CausasConsecuencias
            formHistoriaPsicologica.tbAnaliticas.Text = query.PruebasAnaliticas
            formHistoriaPsicologica.tbComorbilidad.Text = query.Comorbilidad
            formHistoriaPsicologica.tbDiagnostico.Text = query.Diagnostico
            formHistoriaPsicologica.tbProtocolo.Text = query.Protocolo
            formHistoriaPsicologica.tbObjetivos.Text = query.Objetivos
            formHistoriaPsicologica.tbTecnicas.Text = query.Tecnicas
            formHistoriaPsicologica.tbTareas.Text = query.Tareas
            formHistoriaPsicologica.tbSeguimiento.Text = query.SeguimientoPs
            formHistoriaPsicologica.tbObservaciones.Text = query.ObservacionesPs
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        'para mostrar la ultima cita: 1º compruebo si el usuario es psicologo/a y si lo es extraigo la ultima cita con su idtecnico
        Dim tecnicoActivo As Integer
        Dim usu As ObjectSet(Of USUGES) = bdAlej.USUGES
        Dim query2 = (From tec In usu Where tec.NombreUsuGes = nombreUsuarioActivo.Trim Select New With {tec.IdTecnico})
        For Each r In query2
            tecnicoActivo = r.IdTecnico
        Next

        Dim tecnicoNaveg As String
        Dim tecNav As ObjectSet(Of TECNICOS) = bdAlej.TECNICOS
        Dim query3 = (From d In tecNav Where d.IdTecnico = tecnicoActivo Select New With {d.Profesion})
        For Each x In query3
            tecnicoNaveg = x.Profesion
        Next

        If tecnicoNaveg = "PSICOLOGO/A" Then
            Dim cita As ObjectSet(Of CITAS) = bdAlej.CITAS
            Dim consultaCita = (From ct In cita Where ct.IdPaciente = "PAC" & tbHistoria.Text And ct.IdTecnico = tecnicoActivo _
                                Order By ct.FechaCita Descending Take 1 Select New With {ct.FechaCita})
            Try
                For Each x In consultaCita
                    formHistoriaPsicologica.tbUltimaCita.Text = x.FechaCita
                Next
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If


        formHistoriaPsicologica.Text = "Historia Psicológica " & tbNombre.Text
        formHistoriaPsicologica.tbHistoria.Text = tbHistoria.Text
        formHistoriaPsicologica.Show()

        Me.Close()

    End Sub

    Private Sub btHsSocial_Click(sender As System.Object, e As System.EventArgs) Handles btHsSocial.Click


        Dim historySc As ObjectSet(Of HISTORIA_SOCIAL) = bdAlej.HISTORIA_SOCIAL

        Dim query = (From hist In historySc Where hist.IdHistoria = tbHistoria.Text _
                                         Select New With {hist.ConsumoDrogas, hist.DrogaConsPrincipal, hist.EdadInicioCons, _
                                                          hist.ConsOtrasDrog, hist.OtrasDrog, hist.Genograma, hist.Vivienda, _
                                                          hist.SitLabActual, hist.SitEconom, hist.SitJudicial, hist.FormacionReglada, _
                                                          hist.FormacionComplem, hist.EntornoSocial, hist.OcioTiempLibre, _
                                                          hist.DemandaPresentTS, hist.AtencionPrestada, hist.AnotacionesTS, _
                                                          hist.DiagnosticoSocial, hist.ObservacionesTS})

        'consulta para conseguir la situacion laboral al inicio del tratamiento
        Dim pacs As ObjectSet(Of PACIENTES) = bdAlej.PACIENTES
        Dim history As ObjectSet(Of HISTORIA) = bdAlej.HISTORIA
        Dim query2 = (From datoSuelto In pacs Join datoHistoria In history On datoSuelto.IdPaciente Equals datoHistoria.IdPaciente _
                      Where datoHistoria.IdHistoria = tbHistoria.Text.Trim Select New With {datoSuelto.SitLabInicioTTo})
        '----------------------------------------------

        Try
            For Each d In query
                formHistoriaSocial.tbAnotaciones.Text = d.AnotacionesTS
                formHistoriaSocial.tbDemandaPlanteada.Text = d.DemandaPresentTS
                formHistoriaSocial.tbDiagnostico.Text = d.DiagnosticoSocial
                formHistoriaSocial.tbEdadInicioConsum.Text = d.EdadInicioCons
                formHistoriaSocial.tbEntornoSocial.Text = d.EntornoSocial
                formHistoriaSocial.tbFormacionCompl.Text = d.FormacionComplem
                formHistoriaSocial.tbObservaciones.Text = d.ObservacionesTS
                formHistoriaSocial.tbOcio.Text = d.OcioTiempLibre
                formHistoriaSocial.tbOtrasDrogas.Text = d.OtrasDrog
                formHistoriaSocial.cbxConsumo.Text = d.ConsumoDrogas
                formHistoriaSocial.cbxConsumPrincipal.Text = d.DrogaConsPrincipal
                formHistoriaSocial.cbxFormacionReglada.Text = d.FormacionReglada
                formHistoriaSocial.cbxOtrasDrogas.Text = d.ConsOtrasDrog
                formHistoriaSocial.cbxSitEcon.Text = d.SitEconom
                formHistoriaSocial.cbxSitJud.Text = d.SitJudicial
                formHistoriaSocial.cbxSitLabAc.Text = d.SitLabActual
                formHistoriaSocial.cbxVivienda.Text = d.Vivienda
            Next

            For Each d2 In query2
                formHistoriaSocial.cbxSitLabIn.Text = d2.SitLabInicioTTo
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


        'para mostrar la ultima cita: 1º compruebo si el usuario es trabajador social y si lo es extraigo la ultima cita con su idtecnico
        Dim tecnicoActivo As Integer
        Dim usu As ObjectSet(Of USUGES) = bdAlej.USUGES
        Dim query3 = (From tec In usu Where tec.NombreUsuGes = nombreUsuarioActivo.Trim Select New With {tec.IdTecnico})
        For Each r In query3
            tecnicoActivo = r.IdTecnico
        Next

        Dim tecnicoNaveg As String
        Dim tecNav As ObjectSet(Of TECNICOS) = bdAlej.TECNICOS
        Dim query4 = (From d In tecNav Where d.IdTecnico = tecnicoActivo Select New With {d.Profesion})
        For Each x In query4
            tecnicoNaveg = x.Profesion
        Next

        If tecnicoNaveg = "TRABAJADOR/A SOCIAL" Then
            Dim cita As ObjectSet(Of CITAS) = bdAlej.CITAS
            Dim consultaCita = (From ct In cita Where ct.IdPaciente = "PAC" & tbHistoria.Text And ct.IdTecnico = tecnicoActivo _
                                Order By ct.FechaCita Descending Take 1 Select New With {ct.FechaCita})
            Try
                For Each x In consultaCita
                    formHistoriaSocial.tbUltimaCita.Text = x.FechaCita
                Next
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If

        'completamos la unidad de convivencia
        'Esto para el dgv
        formHistoriaSocial.dgvUC.ColumnCount = 5
        formHistoriaSocial.dgvUC.ColumnHeadersVisible = True
        formHistoriaSocial.dgvUC.Columns(0).Name = "Conviviente"
        formHistoriaSocial.dgvUC.Columns(1).Name = "Año de Nac."
        formHistoriaSocial.dgvUC.Columns(2).Name = "Parentesco"
        formHistoriaSocial.dgvUC.Columns(3).Name = "Sit. Laboral"
        formHistoriaSocial.dgvUC.Columns(4).Name = "Familiar en TTº"

        Dim row() As String
        Dim uCon As ObjectSet(Of UNIDAD_CONVIVENCIA) = bdAlej.UNIDAD_CONVIVENCIA

        Dim queryUC = (From uc In uCon Where uc.IdHistoria = tbHistoria.Text Select New With {uc.NombreConviviente, uc.EdadConviviente, uc.ParentescoConviviente, uc.SitLabConvivente, uc.FamiliarEnTTo})

        For Each conviviente In queryUC
            row = {conviviente.NombreConviviente, conviviente.EdadConviviente, conviviente.ParentescoConviviente, conviviente.SitLabConvivente, conviviente.FamiliarEnTTo}
            formHistoriaSocial.dgvUC.Rows.Add(row)
        Next

        'añadimos el genograma
        Dim ms As New IO.MemoryStream
        Dim ImageBytes() As Byte

        Dim hsSc As ObjectSet(Of HISTORIA_SOCIAL) = bdAlej.HISTORIA_SOCIAL

        Dim paLaImagen = (From d In hsSc Where tbHistoria.Text = d.IdHistoria Select d.Genograma).FirstOrDefault
        If Not (IsNothing(paLaImagen)) Then
            ImageBytes = paLaImagen.ToArray
            Dim imgNew As Image
            Dim memImage As New System.IO.MemoryStream(ImageBytes)
            imgNew = Image.FromStream(memImage)
            formHistoriaSocial.pbGenograma.Image = imgNew
        End If

        formHistoriaSocial.Text = "Historia Social " & nombrePaciente
        formHistoriaSocial.tbHistoria.Text = tbHistoria.Text
        formHistoriaSocial.Show()

        Me.Close()

        formHistoriaSocial.Show()
        Me.Close()
    End Sub

    Private Sub btHsMedica_Click(sender As System.Object, e As System.EventArgs) Handles btHsMedica.Click

        Dim historyMd As ObjectSet(Of HISTORIA_MEDICA) = bdAlej.HISTORIA_MEDICA

        Dim query = (From hist In historyMd Where hist.IdHistoria = tbHistoria.Text _
                                         Select hist).FirstOrDefault
        Try
            formHistoriaMedica.tbVIH.Text = query.VIH
            formHistoriaMedica.tbVHB.Text = query.VHB
            formHistoriaMedica.tbVHC.Text = query.VHC
            formHistoriaMedica.tbLUES.Text = query.SEROLOGIA_LUES
            formHistoriaMedica.tbMantoux.Text = query.MANTOUX
            formHistoriaMedica.tbPruebasHepaticas.Text = query.Pruebas_Hepaticas
            formHistoriaMedica.tbHemograma.Text = query.Hemograma
            formHistoriaMedica.tbBioquimica.Text = query.Bioquimica
            formHistoriaMedica.tbPatSomaticas.Text = query.Patologias_Somaticas_Asociadas
            formHistoriaMedica.tbPatPsiquiatricas.Text = query.Patologias_Psiquiatricas
            formHistoriaMedica.tbAntecedentesInteres.Text = query.Antecedentes_Interes
            formHistoriaMedica.tbAlergias.Text = query.Alergias
            formHistoriaMedica.cbxHospitalizaciones.Text = query.Hospitalizaciones
            formHistoriaMedica.tbCirugia.Text = query.Cirugia
            formHistoriaMedica.tbPeso.Text = query.Peso
            formHistoriaMedica.tbTalla.Text = query.Talla
            formHistoriaMedica.tbTA.Text = query.Tension_Arterial
            formHistoriaMedica.tbPulso.Text = query.Pulso
            formHistoriaMedica.tbTemperatura.Text = query.Temperatura
            formHistoriaMedica.tbAdenopatias.Text = query.Adenopatias
            formHistoriaMedica.cbxVenopuncion.Text = query.Venopuncion
            formHistoriaMedica.cbxCaries.Text = query.Caries
            formHistoriaMedica.cbxTatuajes.Text = query.Tatuajes
            formHistoriaMedica.tbOtrasPatSomaticas.Text = query.Otras_Patologias_Somaticas
            formHistoriaMedica.tbTToGeneral.Text = query.TTo_General
            formHistoriaMedica.tbTToEspecifico.Text = query.TTo_Especifico
            formHistoriaMedica.tbTToPsiquiatrico.Text = query.TTo_Psiquiatra
            formHistoriaMedica.cbxDesintox.Text = query.Desintoxicacion
            formHistoriaMedica.cbxReduccion.Text = query.Reduccion
            formHistoriaMedica.cbxProgLibreDrogas.Text = query.Programa_Libre_Drogas
            formHistoriaMedica.tbSeguimiento.Text = query.SeguimientoMedico
            formHistoriaMedica.tbObservaciones.Text = query.ObservacionesMedico
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


        'para mostrar la ultima cita: 1º compruebo si el usuario es psicologo/a y si lo es extraigo la ultima cita con su idtecnico
        Dim tecnicoActivo As Integer
        Dim usu As ObjectSet(Of USUGES) = bdAlej.USUGES
        Dim query3 = (From tec In usu Where tec.NombreUsuGes = nombreUsuarioActivo.Trim Select New With {tec.IdTecnico})
        For Each r In query3
            tecnicoActivo = r.IdTecnico
        Next

        Dim tecnicoNaveg As String
        Dim tecNav As ObjectSet(Of TECNICOS) = bdAlej.TECNICOS
        Dim query4 = (From d In tecNav Where d.IdTecnico = tecnicoActivo Select New With {d.Profesion})
        For Each x In query4
            tecnicoNaveg = x.Profesion
        Next

        If tecnicoNaveg = "MEDICO" Then
            Dim cita As ObjectSet(Of CITAS) = bdAlej.CITAS
            Dim consultaCita = (From ct In cita Where ct.IdPaciente = "PAC" & tbHistoria.Text And ct.IdTecnico = tecnicoActivo _
                                Order By ct.FechaCita Descending Take 1 Select New With {ct.FechaCita})
            Try
                For Each x In consultaCita
                    formHistoriaMedica.tbUltimaCita.Text = x.FechaCita
                Next
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If

        formHistoriaMedica.Text = "Historia Médica " & tbNombre.Text
        formHistoriaMedica.tbHistoria.Text = tbHistoria.Text

        formHistoriaMedica.Show()
        Me.Close()
    End Sub

#Region "REGISTRAR ALTA"
    Private Sub btRegistrarAlta_Click(sender As System.Object, e As System.EventArgs) Handles btRegistrarAlta.Click

        If Not (String.IsNullOrWhiteSpace(tbHistoria.Text)) Then 'Or Not (String.IsNullOrWhiteSpace(tbCodFac.Text)) Then

            'comprobamos que no existe el nº de historia
            Dim hist As ObjectSet(Of HISTORIA) = bdAlej.HISTORIA
            Dim comprobandoNum = (From h In hist Where h.IdHistoria = tbHistoria.Text.Trim Select h).FirstOrDefault
            Dim encontrado As Boolean = False
            If Not (IsNothing(comprobandoNum)) Then
                MsgBox("El número de historia ya está registrado")
                Exit Sub
            End If

            If IsDate(tbFechaAdmisionTTo.Text) Then
                bdAlej = New bdAlejandriaCTAEntities1

                'creamos el nuevo registro en la tabla PACIENTE
                Dim nuevoPaciente As PACIENTES = PACIENTES.CreatePACIENTES(idPaciente:="PAC" & tbHistoria.Text)

                bdAlej.AddToPACIENTES(nuevoPaciente)

                nuevoPaciente.NombrePaciente = tbNombre.Text
                nuevoPaciente.DNI = tbDNI.Text
                nuevoPaciente.Direccion = tbDireccion.Text
                nuevoPaciente.Telefono = tbTlfnoFijo.Text
                nuevoPaciente.Movil = tbTlfnoMovil.Text
                nuevoPaciente.Mail = tbMail.Text
                nuevoPaciente.EstadoCivil = cbxEstadoCivil.Text
                nuevoPaciente.Sexo = cbxSexo.Text
                If Not (String.IsNullOrWhiteSpace(tbFechaNacimiento.Text)) Then
                    If IsDate(tbFechaNacimiento.Text) Then
                        nuevoPaciente.FechaNacimiento = Convert.ToDateTime(tbFechaNacimiento.Text)
                    Else
                        MsgBox("Los formatos admitidos de fecha son dd/mm/aa y dd/mm/aaaa")
                        Exit Sub
                    End If
                End If
                nuevoPaciente.CP = tbCP.Text
                nuevoPaciente.Localidad = tbLocalidad.Text
                nuevoPaciente.Provincia = tbProvincia.Text
                If Not (String.IsNullOrWhiteSpace(tbFechaDesempleo.Text)) Then
                    If IsDate(tbFechaDesempleo.Text) Then
                        nuevoPaciente.FechaDesempleo = Convert.ToDateTime(tbFechaDesempleo.Text)
                    Else
                        MsgBox("Los formatos admitidos de fecha son dd/mm/aa y dd/mm/aaaa")
                        Exit Sub
                    End If
                End If
                If Not (String.IsNullOrWhiteSpace(tbFechaPrestDesempl.Text)) Then
                    If IsDate(tbFechaPrestDesempl.Text) Then
                        nuevoPaciente.FechaPrestDesempl = Convert.ToDateTime(tbFechaPrestDesempl.Text)
                    Else
                        MsgBox("Los formatos admitidos de fecha son dd/mm/aa y dd/mm/aaaa")
                        Exit Sub
                    End If
                End If

                'nuevoPaciente.CodFacturacion = tbCodFac.Text

                bdAlej.PACIENTES.AddObject(nuevoPaciente)


                'creamos el nuevo registro en la tabla HISTORIA.
                Dim nuevaHistoria As HISTORIA = HISTORIA.CreateHISTORIA(idHistoria:=tbHistoria.Text)

                'añadimos el nuevo registro a la tabla
                bdAlej.AddToHISTORIA(nuevaHistoria)
                'definimos el resto de columnas
                nuevaHistoria.DemandaIncialTTo = cbxDemandaInicial.Text
                nuevaHistoria.IdPaciente = nuevoPaciente.IdPaciente
                nuevaHistoria.TToAnterior = tbTToAnterior.Text
                nuevaHistoria.TToActual = tbTToActual.Text
                'añadimos el resto de columnas
                bdAlej.HISTORIA.AddObject(nuevaHistoria)


                ''creamos el nuevo registro en la tabla FACTURACION
                'Dim nuevaFacturacion As FACTURACION = FACTURACION.CreateFACTURACION(codFacturacion:=tbCodFac.Text)

                'bdAlej.AddToFACTURACION(nuevaFacturacion)
                'nuevaFacturacion.PagosAlDia = cbxPagosAlDia.Text

                'bdAlej.FACTURACION.AddObject(nuevaFacturacion)


                'creamos el nuevo registro en la tabla INGRESO
                Dim nuevoIngreso As INGRESO = INGRESO.CreateINGRESO(idHistoria:=tbHistoria.Text, fechaAdmisionTTo:=Convert.ToDateTime(tbFechaAdmisionTTo.Text))

                bdAlej.AddToINGRESO(nuevoIngreso)

                'creamos la nueva HISTORIA PSICOLOGICA
                Dim nuevaHistoriaPs As HISTORIA_PSICOLOGICA = HISTORIA_PSICOLOGICA.CreateHISTORIA_PSICOLOGICA(idHistoriaPs:=AutoCompleteMode.None, idHistoria:=tbHistoria.Text)
                bdAlej.AddToHISTORIA_PSICOLOGICA(nuevaHistoriaPs)

                'creamos la nueva HISTORIA SOCIAL
                Dim nuevaHistoriaSc As HISTORIA_SOCIAL = HISTORIA_SOCIAL.CreateHISTORIA_SOCIAL(idHistoriaSocial:=AutoCompleteMode.None, idHistoria:=tbHistoria.Text)
                bdAlej.AddToHISTORIA_SOCIAL(nuevaHistoriaSc)
                'añadimos un campo vacio a EdadInicioCons para que no de fallo al cargarla vacía por primera vez
                nuevaHistoriaSc.EdadInicioCons = "0"
                bdAlej.HISTORIA_SOCIAL.AddObject(nuevaHistoriaSc)

                'creamos la nueva HISTORIA MEDICA
                Dim nuevaHistoriaMd As HISTORIA_MEDICA = HISTORIA_MEDICA.CreateHISTORIA_MEDICA(idHistoriaMedica:=AutoCompleteMode.None, idHistoria:=tbHistoria.Text)
                bdAlej.AddToHISTORIA_MEDICA(nuevaHistoriaMd)

                'ENVIAMOS LA INFORMACION A LA BASE DE DATOS
                Try
                    bdAlej.SaveChanges()
                    MessageBox.Show("Paciente registrado con éxito")

                    'lanzamos el control de citas
                    Dim tecnico As ObjectSet(Of TECNICOS) = bdAlej.TECNICOS
                    Dim query = (From tec In tecnico Where tec.Profesion <> "INVITADO" Select New With {tec.NombreTecnico})
                    For Each x In query
                        formControlCitas.cbxTecnico.Items.Add(x.NombreTecnico)
                    Next

                    formControlCitas.tbHistoria.Text = tbHistoria.Text

                    Me.Close()
                    formControlCitas.Show()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            Else
                MsgBox("La fecha de admisión a TTº es obligatoria. Los formatos admitidos de fecha son dd/mm/aa y dd/mm/aaaa")
            End If
            Else
                MsgBox("El número de historia es obligatorio")
            End If
    End Sub
#End Region


    Private Sub btAltaTerapeutica_Click(sender As System.Object, e As System.EventArgs) Handles btAltaTerapeutica.Click

        Dim caption As String = "Atención"
        If MessageBox.Show("El paciente será dado de Alta en el Sistema, ¿Desea continuar?", caption, MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            formAltaTerapeutica.tbHistoria.Text = tbHistoria.Text.Trim
            formAltaTerapeutica.Show()
        End If

    End Sub

    Private Sub lklbReapertura_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lklbReapertura.LinkClicked
        lbExpdteCerrado.Visible = False
        lklbReapertura.Visible = False
        btReapertura.Visible = True
        gbxDatosPaciente.Enabled = True
        gbxDatosInicioTT.Enabled = True
        gbxDatosFactur.Enabled = True
    End Sub

    Private Sub btReapertura_Click(sender As System.Object, e As System.EventArgs) Handles btReapertura.Click
        'comprobamos que la fecha de reapertura es válida

        Dim alta As ObjectSet(Of ALTA) = bdAlej.ALTA
        Dim query = (From a In alta Order By a.FechaAlta Descending Where a.IdHistoria = tbHistoria.Text.Trim _
                     Select a).FirstOrDefault

        ' For Each x In query
        fechaAlta = query.FechaAlta
        'Next

        If tbFechaAdmisionTTo.Text > Convert.ToDateTime(fechaAlta) Then

            'actualizar la FichaPaciente
            Dim hist As ObjectSet(Of HISTORIA) = bdAlej.HISTORIA
            Dim pac As ObjectSet(Of PACIENTES) = bdAlej.PACIENTES
            Dim fac As ObjectSet(Of FACTURACION) = bdAlej.FACTURACION

            Dim historiaParaReabrir = (From h In hist Where h.IdHistoria = tbHistoria.Text.Trim Select h).FirstOrDefault
            historiaParaReabrir.DemandaIncialTTo = cbxDemandaInicial.Text
            historiaParaReabrir.TToAnterior = tbTToAnterior.Text
            historiaParaReabrir.TToActual = tbTToActual.Text

            Dim pacientesParaReabrir = (From p In pac Join hs In hist On p.IdPaciente Equals hs.IdPaciente Where hs.IdHistoria = tbHistoria.Text.Trim _
                                        Select p).FirstOrDefault
            pacientesParaReabrir.NombrePaciente = tbNombre.Text
            pacientesParaReabrir.DNI = tbDNI.Text
            pacientesParaReabrir.Direccion = tbDireccion.Text
            pacientesParaReabrir.Telefono = tbTlfnoFijo.Text
            pacientesParaReabrir.Movil = tbTlfnoMovil.Text
            pacientesParaReabrir.Mail = tbMail.Text
            pacientesParaReabrir.EstadoCivil = cbxEstadoCivil.Text
            pacientesParaReabrir.Sexo = cbxSexo.Text
            If Not (String.IsNullOrWhiteSpace(tbFechaNacimiento.Text)) Then
                If IsDate(tbFechaNacimiento.Text) Then
                    pacientesParaReabrir.FechaNacimiento = Convert.ToDateTime(tbFechaNacimiento.Text)
                Else
                    MsgBox("Los formatos admitidos de fecha son dd/mm/aa y dd/mm/aaaa")
                    Exit Sub
                End If
            End If
                    pacientesParaReabrir.CP = tbCP.Text
                    pacientesParaReabrir.Localidad = tbLocalidad.Text
            pacientesParaReabrir.Provincia = tbProvincia.Text
            If Not (String.IsNullOrWhiteSpace(tbFechaDesempleo.Text)) Then
                If IsDate(tbFechaDesempleo.Text) Then
                    pacientesParaReabrir.FechaDesempleo = Convert.ToDateTime(tbFechaDesempleo.Text)
                Else
                    MsgBox("Los formatos admitidos de fecha son dd/mm/aa y dd/mm/aaaa")
                    Exit Sub
                End If
            End If
            If Not (String.IsNullOrWhiteSpace(tbFechaPrestDesempl.Text)) Then
                If IsDate(tbFechaPrestDesempl.Text) Then
                    pacientesParaReabrir.FechaPrestDesempl = Convert.ToDateTime(tbFechaPrestDesempl.Text)
                Else
                    MsgBox("Los formatos admitidos de fecha son dd/mm/aa y dd/mm/aaaa")
                    Exit Sub
                End If
            End If

            'pacientesParaReabrir.CodFacturacion = tbCodFac.Text

                    'Dim facturacionParaReabrir = (From f In fac Where f.CodFacturacion = tbCodFac.Text.Trim Select f).FirstOrDefault
                    'facturacionParaReabrir.PagosAlDia = cbxPagosAlDia.Text.Trim

                    Dim ingresoParaReabrir As INGRESO = INGRESO.CreateINGRESO(idHistoria:=tbHistoria.Text, fechaAdmisionTTo:=Convert.ToDateTime(tbFechaAdmisionTTo.Text))
                    bdAlej.AddToINGRESO(ingresoParaReabrir)

                    Try
                        bdAlej.SaveChanges()
                        MessageBox.Show("Historia reabierta con éxito")
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try

                    Me.Close()
                Else
                    MsgBox("La fecha de readmisión debe ser superior a la fecha de Alta Terapéutica: " & fechaAlta)
                End If
    End Sub

    Private Sub btActualizar_Click(sender As System.Object, e As System.EventArgs) Handles btActualizar.Click

        'actualizr la FichaPaciente
        Dim hist As ObjectSet(Of HISTORIA) = bdAlej.HISTORIA
        Dim pac As ObjectSet(Of PACIENTES) = bdAlej.PACIENTES
        Dim fac As ObjectSet(Of FACTURACION) = bdAlej.FACTURACION

        Dim historiaParaReabrir = (From h In hist Where h.IdHistoria = tbHistoria.Text.Trim Select h).FirstOrDefault
        historiaParaReabrir.DemandaIncialTTo = cbxDemandaInicial.Text
        historiaParaReabrir.TToAnterior = tbTToAnterior.Text
        historiaParaReabrir.TToActual = tbTToActual.Text

        Dim pacientesParaReabrir = (From p In pac Join hs In hist On p.IdPaciente Equals hs.IdPaciente Where hs.IdHistoria = tbHistoria.Text.Trim Select p).FirstOrDefault
        pacientesParaReabrir.NombrePaciente = tbNombre.Text
        pacientesParaReabrir.DNI = tbDNI.Text
        pacientesParaReabrir.Direccion = tbDireccion.Text
        pacientesParaReabrir.Telefono = tbTlfnoFijo.Text
        pacientesParaReabrir.Movil = tbTlfnoMovil.Text
        pacientesParaReabrir.Mail = tbMail.Text
        pacientesParaReabrir.EstadoCivil = cbxEstadoCivil.Text
        pacientesParaReabrir.Sexo = cbxSexo.Text
        If Not (String.IsNullOrWhiteSpace(tbFechaNacimiento.Text)) Then
            If IsDate(tbFechaNacimiento.Text) Then
                pacientesParaReabrir.FechaNacimiento = Convert.ToDateTime(tbFechaNacimiento.Text)
            Else
                MsgBox("Los formatos admitidos de fecha son dd/mm/aa y dd/mm/aaaa")
                Exit Sub
            End If
        End If
        pacientesParaReabrir.CP = tbCP.Text
        pacientesParaReabrir.Localidad = tbLocalidad.Text
        pacientesParaReabrir.Provincia = tbProvincia.Text
        If Not (String.IsNullOrWhiteSpace(tbFechaDesempleo.Text)) Then
            If IsDate(tbFechaDesempleo.Text) Then
                pacientesParaReabrir.FechaDesempleo = Convert.ToDateTime(tbFechaDesempleo.Text)
            Else
                MsgBox("Los formatos admitidos de fecha son dd/mm/aa y dd/mm/aaaa")
                Exit Sub
            End If
        End If
        If Not (String.IsNullOrWhiteSpace(tbFechaPrestDesempl.Text)) Then
            If IsDate(tbFechaPrestDesempl.Text) Then
                pacientesParaReabrir.FechaPrestDesempl = Convert.ToDateTime(tbFechaPrestDesempl.Text)
            Else
                MsgBox("Los formatos admitidos de fecha son dd/mm/aa y dd/mm/aaaa")
                Exit Sub
            End If
        End If

        'AQUI ACTUALIZA LA FACTURACION
        If Not (String.IsNullOrWhiteSpace(tbCodFac.Text)) Then
            Dim facturacionParaReabrir = (From f In fac Where f.CodFacturacion = tbCodFac.Text.Trim Select f).FirstOrDefault
            'facturacionParaReabrir.PagosAlDia = cbxPagosAlDia.Text.Trim
        End If
                Try
                    bdAlej.SaveChanges()
                    MessageBox.Show("Ficha actualizada con éxito")
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try

                ' Me.Close()

    End Sub

    Public Sub prueba(ByVal image As Image)
       
        Dim ms As New IO.MemoryStream
        Dim s As String
        Dim bytes() As Byte
        Dim hsSc As ObjectSet(Of HISTORIA_SOCIAL) = bdAlej.HISTORIA_SOCIAL
        Dim query = (From d In hsSc Where tbHistoria.Text = d.IdHistoria Select d).FirstOrDefault
        s = query.Genograma.FirstOrDefault

        bytes = Convert.FromBase64String(s)
        ms = New IO.MemoryStream(bytes, 0, bytes.Length)

        ms.Write(bytes, 0, bytes.Length)
        image = image.FromStream(ms, True)


    End Sub


    Private Sub btActualizarFac_Click(sender As System.Object, e As System.EventArgs) Handles btActualizarFac.Click
        If String.IsNullOrWhiteSpace(cbxCodigo.Text) Or String.IsNullOrWhiteSpace(tbCantidad.Text) Or String.IsNullOrWhiteSpace(cbxPagosAlDia.Text) Then
            MsgBox("Por favor, complete Código, Cantidad y estado de los Pagos.")
        Else
            Dim codFac As ObjectSet(Of FACTURACION_REAL) = bdAlej.FACTURACION_REAL

            Dim query = (From cF In codFac Where cF.CodFacturacion = tbCodFac.Text.Trim And cF.Codigo = cbxCodigo.Text.Trim Select cF).FirstOrDefault
            If Not (IsNothing(query)) Then
                'actualiza
                query.Cantidad = tbCantidad.Text.Trim
                query.PagosAlDia = cbxPagosAlDia.Text.Trim
            Else
                'inserta
                Dim nuevoCodsFacs As FACTURACION_REAL = FACTURACION_REAL.CreateFACTURACION_REAL(codFacturacion:=tbCodFac.Text.Trim, codigo:=cbxCodigo.Text.Trim)
                bdAlej.AddToFACTURACION_REAL(nuevoCodsFacs)
                nuevoCodsFacs.Cantidad = tbCantidad.Text.Trim
                nuevoCodsFacs.PagosAlDia = cbxPagosAlDia.Text.Trim
            End If
            Try
                bdAlej.SaveChanges()
                MessageBox.Show("Facturación actualizada con éxito")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            cbxCodigo.Text = ""
            tbCantidad.Text = ""
            cbxPagosAlDia.Text = ""
            ReloadDgvFac()
        End If
    End Sub

    Public Sub ReloadDgvFac()
        Dim history As ObjectSet(Of HISTORIA) = bdAlej.HISTORIA
        Dim pacients As ObjectSet(Of PACIENTES) = bdAlej.PACIENTES
        Dim factury As ObjectSet(Of FACTURACION) = bdAlej.FACTURACION
        'Dim ingres As ObjectSet(Of INGRESO) = bdAlej.INGRESO
        Dim codFac As String
        'vamos a consultar  el codigo de facturacion
        Dim query2 = (From f In factury Join p In pacients On f.CodFacturacion Equals p.CodFacturacion Join h In history On p.IdPaciente Equals h.IdPaciente Where h.IdHistoria = tbHistoria.Text.Trim Select New With {f.CodFacturacion})
        If query2.Count <> 0 Then
            codFac = query2.First.CodFacturacion.Trim
        End If
        'consultamos también la facturacion real
        Dim facReal As ObjectSet(Of FACTURACION_REAL) = bdAlej.FACTURACION_REAL
        Dim consultandoFacReal = (From fC In facReal Where fC.CodFacturacion = codFac Select fC)
        dgvFac.DataSource = consultandoFacReal
    End Sub

    Private Sub ExportarFacturaciónToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExportarFacturaciónToolStripMenuItem.Click

        Dim fact As ObjectSet(Of FACTURACION_REAL) = bdAlej.FACTURACION_REAL
        Dim pac As ObjectSet(Of PACIENTES) = bdAlej.PACIENTES
        Dim codsFac As ObjectSet(Of CODIGOS_FACTURACION) = bdAlej.CODIGOS_FACTURACION

        Dim query = (From fC In fact Join cF In codsFac On fC.Codigo Equals cF.Codigo Where fC.CodFacturacion = tbCodFac.Text.Trim Select fC, cF)

        '---------------------GENERANDO EXCEL----------------------------------
        'crear hoja de calculo
        ApExcel = New Excel.Application
        ApExcel.Visible = True
        LibroExcel = ApExcel.Workbooks.Add
        HojaExcel = CType(LibroExcel.Sheets(1), Excel.Worksheet)
        Dim rango As Excel.Range

        ' Nombre del paciente (en la primera fila)
        HojaExcel.Cells(1, 1) = "Facturación de: " & tbNombre.Text.Trim
        rango = CType(HojaExcel.Cells(1, 1), Excel.Range)
        rango.EntireRow.Font.Bold = True


        'fila en la que empezaremos a escribir
        Dim f As Integer = 3

        'Titulos de columna
        HojaExcel.Cells(2, 1) = "Código"
        rango = CType(HojaExcel.Cells(2, 1), Excel.Range)
        rango.EntireRow.Font.Bold = True
        HojaExcel.Cells(2, 2) = "Denominación"
        rango = CType(HojaExcel.Cells(2, 2), Excel.Range)
        rango.EntireRow.Font.Bold = True
        HojaExcel.Cells(2, 3) = "Cantidad"
        rango = CType(HojaExcel.Cells(2, 3), Excel.Range)
        rango.EntireRow.Font.Bold = True
        HojaExcel.Cells(2, 4) = "Pagos al Día"
        rango = CType(HojaExcel.Cells(2, 4), Excel.Range)
        rango.EntireRow.Font.Bold = True

        'datos
        For Each x In query
            HojaExcel.Cells(f, 1) = x.fC.Codigo
            HojaExcel.Cells(f, 2) = x.cF.Denominacion
            HojaExcel.Cells(f, 3) = x.fC.Cantidad
            HojaExcel.Cells(f, 4) = x.fC.PagosAlDia
            f += 1
        Next


        ApExcel = Nothing

    End Sub

    Private Sub formFichaPaciente_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If (Not ApExcel Is Nothing) Then
            ApExcel.Quit()
            ApExcel = Nothing
        End If
    End Sub
End Class

