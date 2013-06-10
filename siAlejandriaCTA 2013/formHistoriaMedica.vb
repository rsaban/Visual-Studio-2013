Imports System.Data.Objects
Imports System.Data.Objects.DataClasses
Imports Microsoft.Office.Interop

Public Class formHistoriaMedica
    Private WithEvents ApWord As Word.Application
    Private doc As Word.Document
    Private Sub btControlCitas_Click(sender As System.Object, e As System.EventArgs) Handles btControlCitas.Click
        Dim tecnico As ObjectSet(Of TECNICOS) = bdAlej.TECNICOS
        Dim query = (From tec In tecnico Where tec.Profesion <> "INVITADO" Select New With {tec.NombreTecnico})
        For Each x In query
            formControlCitas.cbxTecnico.Items.Add(x.NombreTecnico)
        Next

        formControlCitas.tbHistoria.Text = tbHistoria.Text

        formControlCitas.ShowDialog()
    End Sub

    Private Sub btActualizar_Click(sender As System.Object, e As System.EventArgs) Handles btActualizar.Click

        'Antes de guardar cambios, compruebo si el usuario es médico
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

            Dim hsMd As ObjectSet(Of HISTORIA_MEDICA) = bdAlej.HISTORIA_MEDICA

            Dim query = (From d In hsMd Where tbHistoria.Text = d.IdHistoria Select d).FirstOrDefault

            query.SeguimientoMedico = tbSeguimiento.Text
            query.ObservacionesMedico = tbObservaciones.Text
            query.VIH = tbVIH.Text
            query.VHB = tbVHB.Text
            query.VHC = tbVHC.Text
            query.SEROLOGIA_LUES = tbLUES.Text
            query.MANTOUX = tbMantoux.Text
            query.Pruebas_Hepaticas = tbPruebasHepaticas.Text
            query.Hemograma = tbHemograma.Text
            query.Bioquimica = tbBioquimica.Text
            query.Patologias_Somaticas_Asociadas = tbPatSomaticas.Text
            query.Patologias_Psiquiatricas = tbPatPsiquiatricas.Text
            query.Antecedentes_Interes = tbAntecedentesInteres.Text
            query.Alergias = tbAlergias.Text
            query.Hospitalizaciones = cbxHospitalizaciones.Text
            query.Cirugia = tbCirugia.Text
            query.Peso = tbPeso.Text
            query.Talla = tbTalla.Text
            query.Tension_Arterial = tbTA.Text
            query.Pulso = tbPulso.Text
            query.Temperatura = tbTemperatura.Text
            query.Adenopatias = tbAdenopatias.Text
            query.Venopuncion = cbxVenopuncion.Text
            query.Caries = cbxCaries.Text
            query.Tatuajes = cbxTatuajes.Text
            query.TTo_General = tbTToGeneral.Text
            query.TTo_Especifico = tbTToEspecifico.Text
            query.TTo_Psiquiatra = tbTToPsiquiatrico.Text
            query.Desintoxicacion = cbxDesintox.Text
            query.Reduccion = cbxReduccion.Text
            query.Programa_Libre_Drogas = cbxProgLibreDrogas.Text
            query.Otras_Patologias_Somaticas = tbOtrasPatSomaticas.Text

            Try
                bdAlej.SaveChanges()
                MessageBox.Show("Historia Médica actualizada con éxito")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

            'Me.Close()
        Else
            MsgBox("No tiene permiso suficiente para realizar cambios")
        End If

    End Sub

    Private Sub btHsPs_Click(sender As System.Object, e As System.EventArgs) Handles btHsPs.Click
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

        formHistoriaPsicologica.Text = "Historia Psicológica " & nombrePaciente
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
        'consulta para conseguir la situacion laboral actual
        Dim pacs As ObjectSet(Of PACIENTES) = bdAlej.PACIENTES
        Dim history As ObjectSet(Of HISTORIA) = bdAlej.HISTORIA
        Dim query2 = (From datoSuelto In pacs Join datoHistoria In history On datoSuelto.IdPaciente Equals datoHistoria.IdPaciente _
                      Select New With {datoSuelto.SitLabInicioTTo})
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

    Private Sub RecargarÚltimaCitaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RecargarÚltimaCitaToolStripMenuItem.Click
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
                    tbUltimaCita.Text = x.FechaCita
                Next
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub ExportarHistoriaMédicaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExportarHistoriaMédicaToolStripMenuItem.Click
        'consulta para obtener los datos de identificacion--------------------------------------------------------------
        Dim hs As ObjectSet(Of HISTORIA) = bdAlej.HISTORIA
        Dim pac As ObjectSet(Of PACIENTES) = bdAlej.PACIENTES

        Dim query = (From h In hs Join p In pac On h.IdPaciente Equals p.IdPaciente Where h.IdHistoria = tbHistoria.Text.Trim _
                     Select p).FirstOrDefault


        'crear documento de texto--------------------------------------------------------------
        ApWord = New Word.Application
        ApWord.Visible = True
        doc = ApWord.Documents.Add
        Dim siguienteParrafo As Integer = doc.Paragraphs.Count

        doc.Range.Font.Bold = 1
        doc.Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter
        doc.Range.Font.Name = "Andalus"
        doc.Range.Font.Size = 14
        doc.Range.InsertAfter("Historia Médica" & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 0
        doc.Paragraphs(siguienteParrafo).Range.Font.Size = 10
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineNone

        'aqui los datos de identificación--------------------------------------------------------------
        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineSingle
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 1
        doc.Range.InsertAfter("1. Datos de identificación. " & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)


        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineNone
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 0
        doc.Range.InsertAfter("- Nombre: " & query.NombrePaciente.ToString & vbNewLine)
        doc.Range.InsertAfter("- DNI: " & query.DNI.ToString & vbNewLine)
        doc.Range.InsertAfter("- Fecha de Nacimiento: " & query.FechaNacimiento & vbNewLine)
        doc.Range.InsertAfter("- Estado Civil: " & query.EstadoCivil.ToString & vbNewLine)
        doc.Range.InsertAfter("- Dirección: " & query.Direccion.ToString & vbNewLine)
        doc.Range.InsertAfter("- Localidad: " & query.Localidad.ToString & " (" & query.Provincia.Trim.ToString & ")" & vbNewLine)
        doc.Range.InsertAfter("- Código Postal: " & query.CP.ToString & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        'aqui el resto del informe----------------------------------------------------------------------------------
        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineSingle
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 1
        doc.Range.InsertAfter("2. Antecedentes. " & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineSingle
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 0
        doc.Range.InsertAfter("2.1 Antecedentes de interes: " & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineNone
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 0
        doc.Range.InsertAfter(tbAntecedentesInteres.Text & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineSingle
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 0
        doc.Range.InsertAfter("2.2 Alergias: " & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineNone
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 0
        doc.Range.InsertAfter(tbAlergias.Text & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineSingle
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 0
        doc.Range.InsertAfter("2.3 Hospitalizaciones: " & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineNone
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 0
        doc.Range.InsertAfter(cbxHospitalizaciones.Text & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineSingle
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 0
        doc.Range.InsertAfter("2.4 Cirugía: " & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineNone
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 0
        doc.Range.InsertAfter(tbCirugia.Text & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineSingle
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 1
        doc.Range.InsertAfter("3. Exploración. " & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineNone
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 0
        doc.Range.InsertAfter("- Peso: " & tbPeso.Text & vbNewLine)
        'doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineNone
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 0
        doc.Range.InsertAfter("- Talla: " & tbTalla.Text & vbNewLine)
        ' doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineNone
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 0
        doc.Range.InsertAfter("- Pulso: " & tbPulso.Text & vbNewLine)
        ' doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineNone
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 0
        doc.Range.InsertAfter("- T.A.: " & tbTA.Text & vbNewLine)
        'doc.Range.InsertAfter(vbNewLine)
       
        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineNone
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 0
        doc.Range.InsertAfter("- Temperatura: " & tbTemperatura.Text & vbNewLine)
        ' doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineNone
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 0
        doc.Range.InsertAfter("- Adenopatías: " & tbAdenopatias.Text & vbNewLine)
        'doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineNone
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 0
        doc.Range.InsertAfter("- Signos de Venopunción: " & cbxVenopuncion.Text & vbNewLine)
        ' doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineNone
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 0
        doc.Range.InsertAfter("- Caries: " & cbxCaries.Text & vbNewLine)
        'doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineNone
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 0
        doc.Range.InsertAfter("- Tatuajes: " & cbxTatuajes.Text & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineSingle
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 1
        doc.Range.InsertAfter("4. Resultados Analíticos Destacables. " & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineNone
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 0
        doc.Range.InsertAfter("- VIH: " & tbVIH.Text & vbNewLine)
        'doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineNone
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 0
        doc.Range.InsertAfter("- VHB: " & tbVHB.Text & vbNewLine)
        'doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineNone
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 0
        doc.Range.InsertAfter("- VHC: " & tbVHC.Text & vbNewLine)
        'doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineNone
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 0
        doc.Range.InsertAfter("- Serología LUES: " & tbLUES.Text & vbNewLine)
        'doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineNone
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 0
        doc.Range.InsertAfter("- MANTOUX: " & tbMantoux.Text & vbNewLine)
        'doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineNone
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 0
        doc.Range.InsertAfter("- Prueba Hepáticas: " & tbPruebasHepaticas.Text & vbNewLine)
        ' doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineNone
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 0
        doc.Range.InsertAfter("- Hemograma: " & tbHemograma.Text & vbNewLine)
        ' doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineNone
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 0
        doc.Range.InsertAfter("- Bioquímica: " & tbBioquimica.Text & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineSingle
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 1
        doc.Range.InsertAfter("5. Patologías Somáticas Asociadas. " & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineNone
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 0
        doc.Range.InsertAfter(tbPatSomaticas.Text & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineSingle
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 1
        doc.Range.InsertAfter("6. Otras Patologías Somáticas. " & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineNone
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 0
        doc.Range.InsertAfter(tbOtrasPatSomaticas.Text & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineSingle
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 1
        doc.Range.InsertAfter("7. Patologías Psiquiátricas. " & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineNone
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 0
        doc.Range.InsertAfter(tbPatPsiquiatricas.Text & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineSingle
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 1
        doc.Range.InsertAfter("8. Tratamiento Actual. " & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineSingle
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 0
        doc.Range.InsertAfter("8.1 Tratamiento General: " & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineNone
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 0
        doc.Range.InsertAfter(tbTToGeneral.Text & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineSingle
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 0
        doc.Range.InsertAfter("8.2 Tratamiento Específico: " & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineNone
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 0
        doc.Range.InsertAfter(tbTToEspecifico.Text & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineSingle
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 0
        doc.Range.InsertAfter("8.3 Tratamiento Psiquiátrico: " & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineNone
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 0
        doc.Range.InsertAfter(tbTToPsiquiatrico.Text & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineSingle
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 1
        doc.Range.InsertAfter("9. ¿Desea desintoxicación?. " & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineNone
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 0
        doc.Range.InsertAfter(cbxDesintox.Text & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineSingle
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 1
        doc.Range.InsertAfter("10. ¿Desea reducción?. " & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineNone
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 0
        doc.Range.InsertAfter(cbxReduccion.Text & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineSingle
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 1
        doc.Range.InsertAfter("11. ¿Desea Programa Libre de Drogas?. " & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineNone
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 0
        doc.Range.InsertAfter(cbxProgLibreDrogas.Text & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineSingle
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 1
        doc.Range.InsertAfter("12. Seguimiento. " & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineNone
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 0
        doc.Range.InsertAfter(tbSeguimiento.Text & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineSingle
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 1
        doc.Range.InsertAfter("13. Observaciones. " & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineNone
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 0
        doc.Range.InsertAfter(tbObservaciones.Text & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        'aqui la fecha y firma
        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight
        doc.Range.InsertAfter(vbNewLine)
        doc.Range.InsertAfter("Almería, " & Date.Now.ToLongDateString & vbNewLine)
        doc.Range.InsertAfter(vbNewLine & vbNewLine)
        doc.Range.InsertAfter(vbNewLine & vbNewLine)
        doc.Range.InsertAfter(vbNewLine & vbNewLine)
        doc.Range.InsertAfter("Fdo. ___________________________________" & vbNewLine)
        doc.Range.InsertAfter("Médico" & vbNewLine)

        ApWord = Nothing
    End Sub

    Private Sub formHistoriaMedica_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If (Not ApWord Is Nothing) Then
            doc.Close()
            ApWord.Quit()
            ApWord = Nothing
        End If
    End Sub

  
End Class