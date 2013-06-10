Imports System.Data.Objects
Imports System.Data.Objects.DataClasses
Imports System.IO
Imports Microsoft.Office.Interop


Public Class formHistoriaSocial
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

        'Antes de guardar cambios, compruebo si el usuario es trabajador social
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

            Dim hsSc As ObjectSet(Of HISTORIA_SOCIAL) = bdAlej.HISTORIA_SOCIAL
            Dim pac As ObjectSet(Of PACIENTES) = bdAlej.PACIENTES
            Dim hs As ObjectSet(Of HISTORIA) = bdAlej.HISTORIA

            Dim query = (From d In hsSc Where tbHistoria.Text = d.IdHistoria Select d).FirstOrDefault

            query.AnotacionesTS = tbAnotaciones.Text
            query.DemandaPresentTS = tbDemandaPlanteada.Text
            query.DiagnosticoSocial = tbDiagnostico.Text
            query.EdadInicioCons = tbEdadInicioConsum.Text
            query.EntornoSocial = tbEntornoSocial.Text
            query.FormacionComplem = tbFormacionCompl.Text
            query.ObservacionesTS = tbObservaciones.Text
            query.OcioTiempLibre = tbOcio.Text
            query.OtrasDrog = tbOtrasDrogas.Text
            query.ConsumoDrogas = cbxConsumo.Text
            query.DrogaConsPrincipal = cbxConsumPrincipal.Text
            query.FormacionReglada = cbxFormacionReglada.Text
            query.ConsOtrasDrog = cbxOtrasDrogas.Text
            query.SitEconom = cbxSitEcon.Text
            query.SitJudicial = cbxSitJud.Text
            query.SitLabActual = cbxSitLabAc.Text
            query.Vivienda = cbxVivienda.Text

            Dim query2 = (From p In pac Join h In hs On p.IdPaciente Equals h.IdPaciente Where h.IdHistoria = tbHistoria.Text.Trim _
                          Select p).FirstOrDefault
            query2.SitLabInicioTTo = cbxSitLabIn.Text.Trim

            Try
                bdAlej.SaveChanges()
                MessageBox.Show("Historia Social actualizada con éxito")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

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


    Private Sub formHistoriaSocial_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        dgvUC.DataSource = Nothing
        dgvUC.Columns.Clear()

        If (Not ApWord Is Nothing) Then
            doc.Close()
            ApWord.Quit()
            ApWord = Nothing
        End If
    End Sub


    Private Sub tsActualizar_Click(sender As System.Object, e As System.EventArgs) Handles tsActualizar.Click

        'Antes de modificar, compruebo si el usuario es trabajador social
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

            Dim uC As ObjectSet(Of UNIDAD_CONVIVENCIA) = bdAlej.UNIDAD_CONVIVENCIA

            Dim query1 = (From c1 In uC Where c1.IdHistoria = tbHistoria.Text.Trim Select c1)
            Dim contador As Integer = 0

            For Each x In query1
                contador += 1
                If contador = 1 Then
                    formUC.tbIdUC1.Text = x.IdUnidConv
                    formUC.tbConviviente1.Text = x.NombreConviviente
                    formUC.tbNac1.Text = x.EdadConviviente
                    formUC.cbxParentesco1.Text = x.ParentescoConviviente
                    formUC.cbxSitLab1.Text = x.SitLabConvivente
                    formUC.tbFamiliarTTo1.Text = x.FamiliarEnTTo
                ElseIf contador = 2 Then
                    formUC.tbIdUC2.Text = x.IdUnidConv
                    formUC.tbConviviente2.Text = x.NombreConviviente
                    formUC.tbNac2.Text = x.EdadConviviente
                    formUC.cbxParentesco2.Text = x.ParentescoConviviente
                    formUC.cbxSitLab2.Text = x.SitLabConvivente
                    formUC.tbFamiliarTTo2.Text = x.FamiliarEnTTo
                ElseIf contador = 3 Then
                    formUC.tbIdUC3.Text = x.IdUnidConv
                    formUC.tbConviviente3.Text = x.NombreConviviente
                    formUC.tbNac3.Text = x.EdadConviviente
                    formUC.cbxParentesco3.Text = x.ParentescoConviviente
                    formUC.cbxSitLab3.Text = x.SitLabConvivente
                    formUC.tbFamiliarTTo3.Text = x.FamiliarEnTTo
                ElseIf contador = 4 Then
                    formUC.tbIdUC4.Text = x.IdUnidConv
                    formUC.tbConviviente4.Text = x.NombreConviviente
                    formUC.tbNac4.Text = x.EdadConviviente
                    formUC.cbxParentesco4.Text = x.ParentescoConviviente
                    formUC.cbxSitLab4.Text = x.SitLabConvivente
                    formUC.tbFamiliarTTo4.Text = x.FamiliarEnTTo
                ElseIf contador = 5 Then
                    formUC.tbIdUC5.Text = x.IdUnidConv
                    formUC.tbConviviente5.Text = x.NombreConviviente
                    formUC.tbNac5.Text = x.EdadConviviente
                    formUC.cbxParentesco5.Text = x.ParentescoConviviente
                    formUC.cbxSitLab5.Text = x.SitLabConvivente
                    formUC.tbFamiliarTTo5.Text = x.FamiliarEnTTo
                ElseIf contador = 6 Then
                    formUC.tbIdUC6.Text = x.IdUnidConv
                    formUC.tbConviviente6.Text = x.NombreConviviente
                    formUC.tbNac6.Text = x.EdadConviviente
                    formUC.cbxParentesco6.Text = x.ParentescoConviviente
                    formUC.cbxSitLab6.Text = x.SitLabConvivente
                    formUC.tbFamiliarTTo6.Text = x.FamiliarEnTTo
                End If
            Next

            formUC.btGuardar.Visible = False
            formUC.btActualizar.Location = New Point(670, 235)
            formUC.btActualizar.Visible = True
            formUC.tbHistoria.Text = tbHistoria.Text
            formUC.ShowDialog()
        Else
            MsgBox("No tiene permiso suficiente para realizar cambios")
        End If
    End Sub

    Private Sub tsRecargarUC_Click(sender As System.Object, e As System.EventArgs) Handles tsRecargarUC.Click
        dgvUC.DataSource = Nothing
        dgvUC.Columns.Clear()

        'completamos la unidad de convivencia
        'Esto para el dgv
        dgvUC.ColumnCount = 5
        dgvUC.ColumnHeadersVisible = True
        dgvUC.Columns(0).Name = "Conviviente"
        dgvUC.Columns(1).Name = "Año de Nac."
        dgvUC.Columns(2).Name = "Parentesco"
        dgvUC.Columns(3).Name = "Sit. Laboral"
        dgvUC.Columns(4).Name = "Familiar en TTº"

        Dim row() As String
        Dim uCon As ObjectSet(Of UNIDAD_CONVIVENCIA) = bdAlej.UNIDAD_CONVIVENCIA

        Dim queryUC = (From uc In uCon Where uc.IdHistoria = tbHistoria.Text Select New With {uc.NombreConviviente, uc.EdadConviviente, uc.ParentescoConviviente, uc.SitLabConvivente, uc.FamiliarEnTTo})

        For Each conviviente In queryUC
            row = {conviviente.NombreConviviente, conviviente.EdadConviviente, conviviente.ParentescoConviviente, conviviente.SitLabConvivente, conviviente.FamiliarEnTTo}
            dgvUC.Rows.Add(row)
        Next

    End Sub

    Private Sub GuardarImagenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GuardarImagenToolStripMenuItem.Click
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
            If ofdImagen.ShowDialog() = DialogResult.OK Then
                pbGenograma.Image = Image.FromFile(ofdImagen.FileName)
            End If
        Else
            MsgBox("No tiene permiso suficiente para realizar cambios")
        End If
    End Sub
    Private Sub GuardarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GuardarToolStripMenuItem.Click

        'Antes de modificar, compruebo si el usuario es trabajador social
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

            If Not (IsNothing(pbGenograma.Image)) Then
                Dim ms As New IO.MemoryStream
                pbGenograma.Image.Save(ms, Imaging.ImageFormat.Jpeg)
                Dim bytes() As Byte = ms.GetBuffer()

                Dim hsSc As ObjectSet(Of HISTORIA_SOCIAL) = bdAlej.HISTORIA_SOCIAL
                Dim query = (From d In hsSc Where tbHistoria.Text = d.IdHistoria Select d).FirstOrDefault

                query.Genograma = bytes

                Try
                    bdAlej.SaveChanges()
                    MessageBox.Show("Imagen guardada")
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            Else
                MsgBox("No hay genograma para guardar")
            End If
        Else
            MsgBox("No tiene permiso suficiente para realizar cambios")
        End If
    End Sub

    Private Sub VerImagenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles VerImagenToolStripMenuItem.Click
        
        Dim ms As New IO.MemoryStream
        Dim ImageBytes() As Byte

        Dim hsSc As ObjectSet(Of HISTORIA_SOCIAL) = bdAlej.HISTORIA_SOCIAL

        Dim paLaImagen = (From d In hsSc Where tbHistoria.Text = d.IdHistoria Select d.Genograma).FirstOrDefault
        If Not (IsNothing(paLaImagen)) Then
            ImageBytes = paLaImagen.ToArray
            Dim imgNew As Image
            Dim memImage As New System.IO.MemoryStream(ImageBytes)
            imgNew = Image.FromStream(memImage)

            formVisorDeImagenes.PictureBox1.Image = imgNew
            formVisorDeImagenes.ShowDialog()
        Else
            MsgBox("No hay genograma para mostrar")
        End If
    End Sub

    Private Sub tsEliminar_Click(sender As System.Object, e As System.EventArgs) Handles tsEliminar.Click
        'Antes de modificar, compruebo si el usuario es trabajador social
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

            Dim hsSc As ObjectSet(Of HISTORIA_SOCIAL) = bdAlej.HISTORIA_SOCIAL
            Dim bytes() As Byte
            Dim query = (From d In hsSc Where tbHistoria.Text = d.IdHistoria Select d).FirstOrDefault

            query.Genograma = bytes

            Try
                bdAlej.SaveChanges()
                MessageBox.Show("Imagen borrada")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            MsgBox("No tiene permiso suficiente para realizar cambios")
        End If
    End Sub

    Private Sub ReloadUltimaCItaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ReloadUltimaCItaToolStripMenuItem.Click
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
                    tbUltimaCita.Text = x.FechaCita
                Next
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If


    End Sub

    Private Sub tsReloadImagen_Click(sender As System.Object, e As System.EventArgs) Handles tsReloadImagen.Click

        Dim ms As New IO.MemoryStream
        Dim ImageBytes() As Byte

        Dim hsSc As ObjectSet(Of HISTORIA_SOCIAL) = bdAlej.HISTORIA_SOCIAL

        Dim paLaImagen = (From d In hsSc Where tbHistoria.Text = d.IdHistoria Select d.Genograma).FirstOrDefault
        If Not (IsNothing(paLaImagen)) Then
            ImageBytes = paLaImagen.ToArray
            Dim imgNew As Image
            Dim memImage As New System.IO.MemoryStream(ImageBytes)
            imgNew = Image.FromStream(memImage)
            pbGenograma.Image = imgNew
        Else
            pbGenograma.Image = Nothing
        End If
    End Sub

   
    Private Sub GenerarExcelToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GenerarExcelToolStripMenuItem.Click
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
        doc.Range.InsertAfter("Informe Social" & vbNewLine)
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

        'aquí la unidad de convivencia--------------------------------------------------------------
        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineSingle
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 1
        doc.Range.InsertAfter("2. Unidad de Convivencia. " & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 0
        Dim tablaUC As Word.Table
        Dim f As Integer = 2
        Dim g As Integer = 2 'para ir dando formato a las celdas de la tabla
        'creamos la tabla
        tablaUC = doc.Tables.Add(doc.Bookmarks.Item("\endofdoc").Range, 7, 3)
        tablaUC.Range.ParagraphFormat.SpaceAfter = 6
        tablaUC.Cell(1, 1).Range.Text = "Nombre Conviviente"
        tablaUC.Cell(1, 2).Range.Text = "Año de Nacimiento"
        tablaUC.Cell(1, 3).Range.Text = "Parentesco"

        tablaUC.Rows.Item(1).Range.Font.Bold = True
        tablaUC.Rows.Item(1).Range.Font.Italic = True
        tablaUC.Rows.Item(1).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter
        tablaUC.Rows.Item(1).Range.Font.Underline = Word.WdUnderline.wdUnderlineNone

        For Each fila As DataGridViewRow In dgvUC.Rows
            tablaUC.Rows.Item(g).Range.Font.Underline = Word.WdUnderline.wdUnderlineNone
            tablaUC.Rows.Item(g).Cells(2).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter
            tablaUC.Rows.Item(g).Cells(3).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter
            If String.IsNullOrWhiteSpace(fila.Cells(0).Value) Then
                tablaUC.Cell(f, 1).Range.Text = ""
            Else
                tablaUC.Cell(f, 1).Range.Text = fila.Cells(0).Value.ToString
            End If
            If String.IsNullOrWhiteSpace(fila.Cells(1).Value) Then
                tablaUC.Cell(f, 2).Range.Text = ""
            Else
                tablaUC.Cell(f, 2).Range.Text = fila.Cells(1).Value.ToString
            End If
            If String.IsNullOrWhiteSpace(fila.Cells(2).Value) Then
                tablaUC.Cell(f, 3).Range.Text = ""
            Else
                tablaUC.Cell(f, 3).Range.Text = fila.Cells(2).Value.ToString
            End If
            f += 1
            g += 1
        Next

        doc.Range.InsertAfter(vbNewLine)

        'aquí el resto del informe social--------------------------------------------------------------
        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineSingle
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 1
        doc.Range.InsertAfter("3. Vivienda. " & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineNone
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 0
        doc.Range.InsertAfter(cbxVivienda.Text & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineSingle
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 1
        doc.Range.InsertAfter("4. Situación Económica. " & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineNone
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 0
        doc.Range.InsertAfter(cbxSitEcon.Text & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineSingle
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 1
        doc.Range.InsertAfter("5. Demanda Planteada." & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineNone
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 0
        doc.Range.InsertAfter(tbDemandaPlanteada.Text & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineSingle
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 1
        doc.Range.InsertAfter("6. Antecedentes sobre el consumo. " & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineNone
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 0
        doc.Range.InsertAfter("- Consumo de drogas: " & cbxConsumo.Text & vbNewLine)
        doc.Range.InsertAfter("- Consumo principal: " & cbxConsumPrincipal.Text & vbNewLine)
        doc.Range.InsertAfter("- Edad de inicio: " & tbEdadInicioConsum.Text.Trim & vbNewLine)
        doc.Range.InsertAfter("- Consumo de otras drogas: " & cbxOtrasDrogas.Text & vbNewLine)
        doc.Range.InsertAfter("- Otras drogas: " & tbOtrasDrogas.Text & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineSingle
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 1
        doc.Range.InsertAfter("7. Formación. " & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineNone
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 0
        doc.Range.InsertAfter("- Formación Reglada: " & cbxFormacionReglada.Text & vbNewLine)
        doc.Range.InsertAfter("- Formación Complementaria: " & tbFormacionCompl.Text & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineSingle
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 1
        doc.Range.InsertAfter("8. Situación Laboral. " & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineNone
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 0
        doc.Range.InsertAfter("- Situación Laboral al inicio del Tratamiento: " & cbxSitLabIn.Text & vbNewLine)
        doc.Range.InsertAfter("- Situación Laboral Actual: " & cbxSitLabAc.Text & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineSingle
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 1
        doc.Range.InsertAfter("9. Situación Judicial. " & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineNone
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 0
        doc.Range.InsertAfter(cbxSitJud.Text & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineSingle
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 1
        doc.Range.InsertAfter("10. Entorno Social. " & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineNone
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 0
        doc.Range.InsertAfter(tbEntornoSocial.Text & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineSingle
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 1
        doc.Range.InsertAfter("11. Ocio y tiempo libre. " & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineNone
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 0
        doc.Range.InsertAfter(tbOcio.Text & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineSingle
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 1
        doc.Range.InsertAfter("12. Diagnóstico Social. " & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineNone
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 0
        doc.Range.InsertAfter(tbDiagnostico.Text & vbNewLine)
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
        doc.Range.InsertAfter("Trabajador/a Social" & vbNewLine)


        ApWord = Nothing
    End Sub

    Private Sub ExportarHistoriaSocialToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExportarHistoriaSocialToolStripMenuItem.Click
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
        doc.Range.InsertAfter("Historia Social" & vbNewLine)
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

        'aquí la unidad de convivencia--------------------------------------------------------------
        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineSingle
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 1
        doc.Range.InsertAfter("2. Unidad de Convivencia. " & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 0
        'Insert a 3 x 5 table, fill it with data, and make the first row
        'bold and italic.
        Dim tablaUC As Word.Table
        Dim f As Integer = 2
        Dim g As Integer = 2 'para ir dando formato a las celdas de la tabla
        'creamos la tabla
        tablaUC = doc.Tables.Add(doc.Bookmarks.Item("\endofdoc").Range, 7, 3)
        tablaUC.Range.ParagraphFormat.SpaceAfter = 6
        tablaUC.Cell(1, 1).Range.Text = "Nombre Conviviente"
        tablaUC.Cell(1, 2).Range.Text = "Año de Nacimiento"
        tablaUC.Cell(1, 3).Range.Text = "Parentesco"

        tablaUC.Rows.Item(1).Range.Font.Bold = True
        tablaUC.Rows.Item(1).Range.Font.Italic = True
        tablaUC.Rows.Item(1).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter
        tablaUC.Rows.Item(1).Range.Font.Underline = Word.WdUnderline.wdUnderlineNone

        For Each fila As DataGridViewRow In dgvUC.Rows
            tablaUC.Rows.Item(g).Range.Font.Underline = Word.WdUnderline.wdUnderlineNone
            tablaUC.Rows.Item(g).Cells(2).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter
            tablaUC.Rows.Item(g).Cells(3).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter
            If String.IsNullOrWhiteSpace(fila.Cells(0).Value) Then
                tablaUC.Cell(f, 1).Range.Text = ""
            Else
                tablaUC.Cell(f, 1).Range.Text = fila.Cells(0).Value.ToString
            End If
            If String.IsNullOrWhiteSpace(fila.Cells(1).Value) Then
                tablaUC.Cell(f, 2).Range.Text = ""
            Else
                tablaUC.Cell(f, 2).Range.Text = fila.Cells(1).Value.ToString
            End If
            If String.IsNullOrWhiteSpace(fila.Cells(2).Value) Then
                tablaUC.Cell(f, 3).Range.Text = ""
            Else
                tablaUC.Cell(f, 3).Range.Text = fila.Cells(2).Value.ToString
            End If
            f += 1
            g += 1
        Next


        doc.Range.InsertAfter(vbNewLine)

        'aquí el resto del informe social--------------------------------------------------------------
        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineSingle
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 1
        doc.Range.InsertAfter("3. Vivienda. " & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineNone
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 0
        doc.Range.InsertAfter(cbxVivienda.Text & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineSingle
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 1
        doc.Range.InsertAfter("4. Situación Económica. " & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineNone
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 0
        doc.Range.InsertAfter(cbxSitEcon.Text & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineSingle
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 1
        doc.Range.InsertAfter("5. Demanda Planteada." & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineNone
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 0
        doc.Range.InsertAfter(tbDemandaPlanteada.Text & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineSingle
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 1
        doc.Range.InsertAfter("6. Antecedentes sobre el consumo. " & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineNone
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 0
        doc.Range.InsertAfter("- Consumo de drogas: " & cbxConsumo.Text & vbNewLine)
        doc.Range.InsertAfter("- Consumo principal: " & cbxConsumPrincipal.Text & vbNewLine)
        doc.Range.InsertAfter("- Edad de inicio: " & tbEdadInicioConsum.Text.Trim & vbNewLine)
        doc.Range.InsertAfter("- Consumo de otras drogas: " & cbxOtrasDrogas.Text & vbNewLine)
        doc.Range.InsertAfter("- Otras drogas: " & tbOtrasDrogas.Text & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineSingle
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 1
        doc.Range.InsertAfter("7. Formación. " & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineNone
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 0
        doc.Range.InsertAfter("- Formación Reglada: " & cbxFormacionReglada.Text & vbNewLine)
        doc.Range.InsertAfter("- Formación Complementaria: " & tbFormacionCompl.Text & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineSingle
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 1
        doc.Range.InsertAfter("8. Situación Laboral. " & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineNone
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 0
        doc.Range.InsertAfter("- Situación Laboral al inicio del Tratamiento: " & cbxSitLabIn.Text & vbNewLine)
        doc.Range.InsertAfter("- Situación Laboral Actual: " & cbxSitLabAc.Text & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineSingle
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 1
        doc.Range.InsertAfter("9. Situación Judicial. " & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineNone
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 0
        doc.Range.InsertAfter(cbxSitJud.Text & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineSingle
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 1
        doc.Range.InsertAfter("10. Entorno Social. " & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineNone
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 0
        doc.Range.InsertAfter(tbEntornoSocial.Text & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineSingle
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 1
        doc.Range.InsertAfter("11. Ocio y tiempo libre. " & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineNone
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 0
        doc.Range.InsertAfter(tbOcio.Text & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)


        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineSingle
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 1
        doc.Range.InsertAfter("12. Diagnóstico Social. " & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineNone
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 0
        doc.Range.InsertAfter(tbDiagnostico.Text & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineSingle
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 1
        doc.Range.InsertAfter("13. Anotaciones. " & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineNone
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 0
        doc.Range.InsertAfter(tbAnotaciones.Text & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineSingle
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 1
        doc.Range.InsertAfter("14. Observaciones. " & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        siguienteParrafo = doc.Paragraphs.Count
        doc.Paragraphs(siguienteParrafo).Range.FormattedText.Underline = Word.WdUnderline.wdUnderlineNone
        doc.Paragraphs(siguienteParrafo).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify
        doc.Paragraphs(siguienteParrafo).Range.Font.Bold = 0
        doc.Range.InsertAfter(tbObservaciones.Text & vbNewLine)
        doc.Range.InsertAfter(vbNewLine)

        ApWord = Nothing

    End Sub
End Class