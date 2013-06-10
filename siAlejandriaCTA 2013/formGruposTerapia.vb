Imports System.Data.Objects
Imports System.Data.Objects.DataClasses


Public Class formGruposTerapia
 

    Private Sub btAñadirTerapia_Click(sender As System.Object, e As System.EventArgs) Handles btAñadirTerapia.Click
        lbNombre.Visible = True
        lbTecnico.Visible = True
        cbxTecnico.Visible = True
        btCrearGrupo.Visible = True
        tbNombreGrupo.Visible = True
        '-----
        cbxGrupos.Visible = False
        cbxGrupos.Text = ""
        btVerGrupo.Visible = False
        lbHistoria.Visible = False
        lbFecha.Visible = False
        lbHora.Visible = False
        tbHistoria.Visible = False
        tbHistoria.Text = ""
        dtpFechaTerapia.Visible = False
        tbHoraTerapia.Visible = False
        tbHoraTerapia.Text = ""
        btIncluir.Visible = False
        lbTerapia.Visible = False
        cbxGruposTerap.Visible = False
        cbxGruposTerap.Text = ""
        lbGrTrp.Visible = False
        lbFechaAsistTerap.Visible = False
        dtpAsistenTerap.Visible = False

        '-----
        'cargamos el cbxTecnico
        cbxTecnico.Items.Clear()
        Dim tecnico As ObjectSet(Of TECNICOS) = bdAlej.TECNICOS
        Dim query = (From tec In tecnico Where tec.Profesion <> "INVITADO" Select New With {tec.NombreTecnico})
        For Each x In query
            cbxTecnico.Items.Add(x.NombreTecnico)
        Next

    End Sub

    Private Sub btAñadirPac_Click(sender As System.Object, e As System.EventArgs) Handles btAñadirPac.Click
        lbHistoria.Visible = True
        lbFecha.Visible = True
        lbHora.Visible = True
        tbHistoria.Visible = True
        dtpFechaTerapia.Visible = True
        tbHoraTerapia.Visible = True
        btIncluir.Visible = True
        lbTerapia.Visible = True
        cbxGruposTerap.Visible = True
        '------
        lbNombre.Visible = False
        lbTecnico.Visible = False
        cbxTecnico.Visible = False
        cbxTecnico.Text = ""
        btCrearGrupo.Visible = False
        tbNombreGrupo.Visible = False
        tbNombreGrupo.Text = ""
        cbxGrupos.Visible = False
        cbxGrupos.Text = ""
        btVerGrupo.Visible = False
        lbGrTrp.Visible = False
        lbFechaAsistTerap.Visible = False
        dtpAsistenTerap.Visible = False

        'cargar el cbxGruposTerapia
        cbxGruposTerap.Items.Clear()
        Dim terapias As ObjectSet(Of TERAPIAS) = bdAlej.TERAPIAS
        Dim query = (From terap In terapias Select New With {terap.NombreTerapia})
        For Each x In query
            cbxGruposTerap.Items.Add(x.NombreTerapia.trim)
        Next

    End Sub

    Private Sub btAsistencia_Click(sender As System.Object, e As System.EventArgs) Handles btAsistencia.Click
        cbxGrupos.Visible = True
        btVerGrupo.Visible = True
        lbGrTrp.Visible = True
        lbFechaAsistTerap.Visible = True
        dtpAsistenTerap.Visible = True
        '------
        lbNombre.Visible = False
        lbTecnico.Visible = False
        cbxTecnico.Visible = False
        cbxTecnico.Text = ""
        btCrearGrupo.Visible = False
        tbNombreGrupo.Visible = False
        tbNombreGrupo.Text = ""
        lbHistoria.Visible = False
        lbFecha.Visible = False
        lbHora.Visible = False
        tbHistoria.Visible = False
        tbHistoria.Text = ""
        dtpFechaTerapia.Visible = False
        tbHoraTerapia.Visible = False
        tbHoraTerapia.Text = ""
        btIncluir.Visible = False
        lbTerapia.Visible = False
        cbxGruposTerap.Visible = False
        cbxGruposTerap.Text = ""

        'cargar el cbxGruposTerapia
        cbxGrupos.Items.Clear()
        Dim terapias As ObjectSet(Of TERAPIAS) = bdAlej.TERAPIAS
        Dim query = (From terap In terapias Select New With {terap.NombreTerapia})
        For Each x In query
            cbxGrupos.Items.Add(x.NombreTerapia.Trim)
        Next

    End Sub


    Private Sub btCrearGrupo_Click(sender As System.Object, e As System.EventArgs) Handles btCrearGrupo.Click

        If String.IsNullOrWhiteSpace(tbNombreGrupo.Text) Or String.IsNullOrWhiteSpace(cbxTecnico.Text) Then
            MsgBox("Todos los campos son requeridos")
        Else

            'buscamos el IdTecnico
            Dim tecnicoElegido As Integer
            Dim tecnico As ObjectSet(Of TECNICOS) = bdAlej.TECNICOS
            Dim query = (From tec In tecnico Where tec.NombreTecnico.Trim = cbxTecnico.Text.Trim Select New With {tec.IdTecnico})
            For Each x In query
                tecnicoElegido = x.IdTecnico
            Next


            Dim nuevaTerapia As TERAPIAS = TERAPIAS.CreateTERAPIAS(idTerapia:=AutoCompleteMode.None)

            bdAlej.AddToTERAPIAS(nuevaTerapia)

            nuevaTerapia.IdTecnico = tecnicoElegido
            nuevaTerapia.NombreTerapia = tbNombreGrupo.Text.Trim

            bdAlej.TERAPIAS.AddObject(nuevaTerapia)

            Try
                bdAlej.SaveChanges()
                MessageBox.Show("Terapia añadida con éxito")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

            Me.Close()
        End If
    End Sub


    Private Sub btIncluir_Click(sender As System.Object, e As System.EventArgs) Handles btIncluir.Click

        If String.IsNullOrWhiteSpace(tbHistoria.Text) Or String.IsNullOrWhiteSpace(tbHoraTerapia.Text) Or _
            String.IsNullOrWhiteSpace(cbxGruposTerap.Text) Or String.IsNullOrWhiteSpace(dtpFechaTerapia.Text) Then
            MsgBox("Todos los campos son requeridos")
        Else
            'comprobamos que existe el nº de historia
            Dim hist As ObjectSet(Of HISTORIA) = bdAlej.HISTORIA
            Dim comprobandoNum = (From h In hist Where h.IdHistoria = tbHistoria.Text.Trim Select h).FirstOrDefault
            Dim encontrado As Boolean = False
            If IsNothing(comprobandoNum) Then
                MsgBox("El número de historia no está registrado")
                Exit Sub
            End If

            'Recuperamos la fecha de admision a TTº y la Fecha de Alta Terapeutica para saber si el paciente está en tratamiento
            Dim alta As ObjectSet(Of ALTA) = bdAlej.ALTA
            Dim ingreso As ObjectSet(Of INGRESO) = bdAlej.INGRESO
            Dim fechaIngreso As Date

            Dim queryIngreso = (From ingr In ingreso Where ingr.IdHistoria = tbHistoria.Text.Trim Order By ingr.FechaAdmisionTTo Descending _
                                Select New With {ingr.FechaAdmisionTTo})
            fechaIngreso = queryIngreso.First.FechaAdmisionTTo.ToShortDateString

            Dim contador = (Aggregate order In alta Where order.IdHistoria = tbHistoria.Text.Trim Into Count(order.FechaAlta >= fechaIngreso))

            If contador >= 1 Then
                MsgBox("El paciente no está en tratamiento")
            Else

                'conseguir el IdTerapia
                Dim terapiaSeleccionada As Integer
                Dim terap As ObjectSet(Of TERAPIAS) = bdAlej.TERAPIAS
                Dim query = (From ter In terap Where ter.NombreTerapia.Trim = cbxGruposTerap.Text.Trim Select New With {ter.IdTerapia})
                For Each x In query
                    terapiaSeleccionada = x.IdTerapia
                Next

                'añadir nuevo registro a AsistentesTerapia
                Dim nuevoAsistenteTerapia As ASISTENTES_TERAPIA = ASISTENTES_TERAPIA.CreateASISTENTES_TERAPIA(idTerapia:=terapiaSeleccionada, idPaciente:="PAC" & tbHistoria.Text.Trim, fechaTerapia:=dtpFechaTerapia.Text.Trim)

                bdAlej.AddToASISTENTES_TERAPIA(nuevoAsistenteTerapia)

                nuevoAsistenteTerapia.FechaTerapia = dtpFechaTerapia.Text.Trim
                nuevoAsistenteTerapia.HoraTerapia = tbHoraTerapia.Text.Trim

                bdAlej.ASISTENTES_TERAPIA.AddObject(nuevoAsistenteTerapia)

                Try
                    bdAlej.SaveChanges()
                    MessageBox.Show("Paciente incluido con éxito")
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try

                tbHistoria.Text = ""
            End If
        End If
    End Sub

    Private Sub btVerGrupo_Click(sender As System.Object, e As System.EventArgs) Handles btVerGrupo.Click

        If String.IsNullOrWhiteSpace(cbxGrupos.Text) Or String.IsNullOrWhiteSpace(dtpAsistenTerap.Text) Then
            MsgBox("Todos los campos son requeridos")
        Else
            Dim pacientes As ObjectSet(Of PACIENTES) = bdAlej.PACIENTES
            Dim terap As ObjectSet(Of TERAPIAS) = bdAlej.TERAPIAS
            Dim asistentesT As ObjectSet(Of ASISTENTES_TERAPIA) = bdAlej.ASISTENTES_TERAPIA

            Dim comprobandoValidado = (From asisTer In asistentesT Join terapia In terap On asisTer.IdTerapia Equals terapia.IdTerapia _
                           Join pac In pacientes On asisTer.IdPaciente Equals pac.IdPaciente _
                           Where terapia.NombreTerapia = cbxGrupos.Text.Trim And asisTer.FechaTerapia = dtpAsistenTerap.Text _
                         Select New With {asisTer.Asistencia}).FirstOrDefault
            If Not (IsNothing(comprobandoValidado)) Then
                Dim comprobando As String = comprobandoValidado.ToString
                If Not (String.IsNullOrWhiteSpace(comprobando)) Then
                    MsgBox("La terapia ya ha sido validada. Los cambios que realize, afectarán a todo el grupo")
                End If
            End If


            Dim query = (From asisTer In asistentesT Join terapia In terap On asisTer.IdTerapia Equals terapia.IdTerapia _
                           Join pac In pacientes On asisTer.IdPaciente Equals pac.IdPaciente _
                           Where terapia.NombreTerapia = cbxGrupos.Text.Trim And asisTer.FechaTerapia = dtpAsistenTerap.Text _
                         Select New With {pac.NombrePaciente})

            formAsistentesTerapia.dgvAsistentes.DataSource = query

            Dim chk As New DataGridViewCheckBoxColumn
            formAsistentesTerapia.dgvAsistentes.Columns.Add(chk)
            chk.HeaderText = "Asistencia"
            chk.Name = "ckh"

            'Dim query2 = (From asisTer In asistentesT Join terapia In terap On asisTer.IdTerapia Equals terapia.IdTerapia _
            '              Join pac In pacientes On asisTer.IdPaciente Equals pac.IdPaciente _
            '              Where terapia.NombreTerapia = cbxGrupos.Text.Trim And asisTer.FechaTerapia = dtpAsistenTerap.Text _
            '            Select New With {asisTer.FechaTerapia, terapia.IdTerapia, asisTer.IdPaciente})
            Dim query2 = (From asisTer In asistentesT Join terapia In terap On asisTer.IdTerapia Equals terapia.IdTerapia _
                            Where terapia.NombreTerapia = cbxGrupos.Text.Trim And asisTer.FechaTerapia = dtpAsistenTerap.Text _
            Select New With {asisTer.FechaTerapia, terapia.IdTerapia, asisTer.IdPaciente})

            For Each x In query2
                formAsistentesTerapia.tbIdTerapia.Text = x.IdTerapia
                formAsistentesTerapia.tbFechaTerapia.Text = x.FechaTerapia
                'formAsistentesTerapia.tbIdPac.Text = x.IdPaciente
            Next

            formAsistentesTerapia.ShowDialog()

            End If

    End Sub

    Private Sub formGruposTerapia_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        cbxGrupos.Items.Clear()
        cbxTecnico.Items.Clear()
        tbNombreGrupo.Text = ""
        tbNombreGrupo.Text = ""
        tbHistoria.Text = ""
        tbHoraTerapia.Text = ""
        cbxGruposTerap.Items.Clear()
    End Sub
End Class

'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
'    DataGridView1.ColumnCount = 3
'    DataGridView1.Columns(0).Name = "Product ID"
'    DataGridView1.Columns(1).Name = "Product Name"
'    DataGridView1.Columns(2).Name = "Product_Price"

'    Dim row As String() = New String() {"1", "Product 1", "1000"}
'    DataGridView1.Rows.Add(row)
'    row = New String() {"2", "Product 2", "2000"}
'    DataGridView1.Rows.Add(row)
'    row = New String() {"3", "Product 3", "3000"}
'    DataGridView1.Rows.Add(row)
'    row = New String() {"4", "Product 4", "4000"}
'    DataGridView1.Rows.Add(row)

'    Dim chk As New DataGridViewCheckBoxColumn()
'    DataGridView1.Columns.Add(chk)
'    chk.HeaderText = "Check Data"
'    chk.Name = "chk"
'    DataGridView1.Rows(2).Cells(3).Value = True

'End Sub