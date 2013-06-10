Imports System.Data.Objects
Imports System.Data.Objects.DataClasses
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Word

Public Class formHistoriaPsicologica
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

        'Antes de guardar cambios, compruebo si el usuario es psicologo/a
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

            Dim hsPs As ObjectSet(Of HISTORIA_PSICOLOGICA) = bdAlej.HISTORIA_PSICOLOGICA

            Dim query = (From d In hsPs Where tbHistoria.Text = d.IdHistoria Select d).FirstOrDefault

            query.Fecha1Entrevista = tb1Entrevista.Text
            query.QuienDemanda = tbQuienDemanda.Text
            query.InformacionDemanda = tbInformacion.Text
            query.Anamnesis = tbAnamnesis.Text
            query.PercpPaciente = tbPercpPac.Text
            query.PercpEntorno = tbPercpEntorno.Text
            query.Quejoso = tbQueja.Text
            query.TTosAnteriores = tbTToAnteriores.Text
            query.SolucionesIntentadas = tbSoluciones.Text
            query.CausasConsecuencias = tbCausas.Text
            query.PruebasAnaliticas = tbAnaliticas.Text
            query.Comorbilidad = tbComorbilidad.Text
            query.Diagnostico = tbDiagnostico.Text
            query.Protocolo = tbProtocolo.Text
            query.Objetivos = tbObjetivos.Text
            query.Tecnicas = tbTecnicas.Text
            query.Tareas = tbTareas.Text
            query.SeguimientoPs = tbSeguimiento.Text
            query.ObservacionesPs = tbObservaciones.Text

            Try
                bdAlej.SaveChanges()
                MessageBox.Show("Historia Psicológica actualizada con éxito")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

            ' Me.Close()
        Else
            MsgBox("No tiene permiso suficiente para realizar cambios")
        End If

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

        formHistoriaMedica.Text = "Historia Médica " & nombrePaciente
        formHistoriaMedica.tbHistoria.Text = tbHistoria.Text

        formHistoriaMedica.Show()
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

    Private Sub ReloadUltimaCitaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ReloadUltimaCitaToolStripMenuItem.Click
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
                    tbUltimaCita.Text = x.FechaCita
                Next
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub ExportarHistoriaPsicológicaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExportarHistoriaPsicológicaToolStripMenuItem.Click
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
        doc.Range.InsertAfter("Historia Psicológica" & vbNewLine)
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
        doc.Range.InsertAfter("2. Fecha de la Primera Entrevista. " & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineNone
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 0
        doc.Range.InsertAfter(tb1Entrevista.Text & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineSingle
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 1
        doc.Range.InsertAfter("3. Procedencia. " & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineNone
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 0
        doc.Range.InsertAfter("- ¿Quién realiza la demanda?: " & tbQuienDemanda.Text & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineNone
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 0
        doc.Range.InsertAfter("- ¿Qué información aporta?: " & tbInformacion.Text & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineSingle
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 1
        doc.Range.InsertAfter("4. Anamnesis. " & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineNone
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 0
        doc.Range.InsertAfter(tbAnamnesis.Text & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineSingle
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 1
        doc.Range.InsertAfter("5. Percepción. " & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineNone
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 0
        doc.Range.InsertAfter("- Percepción del Paciente: " & tbPercpPac.Text & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineNone
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 0
        doc.Range.InsertAfter("- Percepción del entorno: " & tbPercpEntorno.Text & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineNone
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 0
        doc.Range.InsertAfter("- ¿Quién presenta la queja?: " & tbQueja.Text & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineSingle
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 1
        doc.Range.InsertAfter("6. Tratamientos Anteriores. " & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineNone
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 0
        doc.Range.InsertAfter(tbTToAnteriores.Text & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineSingle
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 1
        doc.Range.InsertAfter("7. Soluciones intentadas. " & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineNone
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 0
        doc.Range.InsertAfter(tbSoluciones.Text & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineSingle
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 1
        doc.Range.InsertAfter("8. Causas y Consecuencias. " & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineNone
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 0
        doc.Range.InsertAfter(tbCausas.Text & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineSingle
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 1
        doc.Range.InsertAfter("9. Diagnóstico Diferencial. " & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineNone
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 0
        doc.Range.InsertAfter("- Pruebas Analíticas: " & tbAnaliticas.Text & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineNone
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 0
        doc.Range.InsertAfter("- Comorbilidad: " & tbComorbilidad.Text & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineSingle
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 1
        doc.Range.InsertAfter("10. Diagnóstico Psicológico. " & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineNone
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 0
        doc.Range.InsertAfter(tbDiagnostico.Text & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineSingle
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 1
        doc.Range.InsertAfter("11. Seguimiento. " & vbNewLine)
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
        doc.Range.InsertAfter("12. Observaciones. " & vbNewLine)
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
        doc.Range.InsertAfter("Psicóloga. Colegiada Nº __________" & vbNewLine)

        ApWord = Nothing
    End Sub

    Private Sub formHistoriaPsicologica_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If (Not ApWord Is Nothing) Then
            doc.Close()
            ApWord.Quit()
            ApWord = Nothing
        End If
    End Sub

    Private Sub GenerarInformePsicológicoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GenerarInformePsicológicoToolStripMenuItem.Click
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

        'aquí el encabezado-------------------------------------------------------------------
        For Each section As Word.Section In ApWord.ActiveDocument.Sections
            Dim headerRange As Word.Range = section.Headers(Word.WdHeaderFooterIndex.wdHeaderFooterPrimary).Range
            headerRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
            headerRange.Font.Name = "Arial"
            headerRange.Font.Size = 15
            headerRange.Font.Color = RGB(153, 204, 0)
            headerRange.InsertAfter("ALEJANDRÍA CTA" & vbNewLine)
            
            Dim siguienteLinea As Integer = headerRange.Paragraphs.Count
            siguienteLinea = headerRange.Paragraphs.Count
            headerRange.Paragraphs(siguienteLinea).Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
            headerRange.Paragraphs(siguienteLinea).Range.Font.Name = "Arial"
            headerRange.Paragraphs(siguienteLinea).Range.Font.Size = 12
            headerRange.InsertAfter("Centro de Tratamiento para las Adicciones" & vbNewLine)

            siguienteLinea = headerRange.Paragraphs.Count
            headerRange.Paragraphs(siguienteLinea).Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
            headerRange.Paragraphs(siguienteLinea).Range.Font.Name = "Arial"
            headerRange.Paragraphs(siguienteLinea).Range.Font.Size = 12
            headerRange.InsertAfter("y otras Alteraciones del Comportamiento")

            'aquí el pie -------------------------------------------------------------------
            Dim footerRange As Word.Range = section.Footers(Word.WdHeaderFooterIndex.wdHeaderFooterPrimary).Range
            footerRange.Fields.Add(footerRange, Word.WdFieldType.wdFieldPage)
            footerRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight
        Next

        'aqui empezamos ----------------------------------------------------------------------
        doc.Range.PageSetup.TopMargin = 100
        doc.Range.Font.Bold = 1
        doc.Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter
        doc.Range.Font.Name = "Andalus"
        doc.Range.Font.Size = 14
        doc.Range.InsertAfter("Informe Clínico Psicológico" & vbNewLine)
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
        doc.Range.InsertAfter("2. Fecha de la Primera Entrevista. " & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineNone
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 0
        doc.Range.InsertAfter(tb1Entrevista.Text & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineSingle
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 1
        doc.Range.InsertAfter("3. Procedencia. " & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineNone
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 0
        doc.Range.InsertAfter("- ¿Quién realiza la demanda?: " & tbQuienDemanda.Text & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineNone
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 0
        doc.Range.InsertAfter("- ¿Qué información aporta?: " & tbInformacion.Text & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineSingle
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 1
        doc.Range.InsertAfter("4. Anamnesis. " & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineNone
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 0
        doc.Range.InsertAfter(tbAnamnesis.Text & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineSingle
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 1
        doc.Range.InsertAfter("5. Percepción. " & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineNone
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 0
        doc.Range.InsertAfter("- Percepción del Paciente: " & tbPercpPac.Text & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineNone
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 0
        doc.Range.InsertAfter("- Percepción del entorno: " & tbPercpEntorno.Text & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineNone
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 0
        doc.Range.InsertAfter("- ¿Quién presenta la queja?: " & tbQueja.Text & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineSingle
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 1
        doc.Range.InsertAfter("6. Tratamientos Anteriores. " & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineNone
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 0
        doc.Range.InsertAfter(tbTToAnteriores.Text & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineSingle
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 1
        doc.Range.InsertAfter("7. Soluciones intentadas. " & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineNone
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 0
        doc.Range.InsertAfter(tbSoluciones.Text & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineSingle
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 1
        doc.Range.InsertAfter("8. Causas y Consecuencias. " & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineNone
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 0
        doc.Range.InsertAfter(tbCausas.Text & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineSingle
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 1
        doc.Range.InsertAfter("9. Diagnóstico Diferencial. " & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineNone
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 0
        doc.Range.InsertAfter("- Pruebas Analíticas: " & tbAnaliticas.Text & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineNone
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 0
        doc.Range.InsertAfter("- Comorbilidad: " & tbComorbilidad.Text & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineSingle
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 1
        doc.Range.InsertAfter("10. Diagnóstico Psicológico. " & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineNone
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 0
        doc.Range.InsertAfter(tbDiagnostico.Text & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineSingle
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 1
        doc.Range.InsertAfter("11. Observaciones. " & vbNewLine)
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
        doc.Range.InsertAfter("Psicóloga. Colegiada Nº __________" & vbNewLine)

        ApWord = Nothing
    End Sub
End Class