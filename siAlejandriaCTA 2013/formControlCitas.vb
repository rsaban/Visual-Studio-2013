Imports System.Data.Objects
Imports System.Data.Objects.DataClasses

Public Class formControlCitas

    Private Sub btConcertarCita_Click(sender As System.Object, e As System.EventArgs) Handles btFormalizarCita.Click
        If String.IsNullOrWhiteSpace(tbHistoria.Text) Then
            MsgBox("Por favor, introduzca número de historia")
            Exit Sub
        End If

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
            MsgBox("El paciente no se encuentra en tratamiento")
            Exit Sub
        End If

        If IsDate(tbProxCita.Text) Then
            'buscamos el tecnico al cual vamos a asignar la cita
            Dim tecnicoElegido As Integer
            Dim tecnico As ObjectSet(Of TECNICOS) = bdAlej.TECNICOS
            Dim query = (From tec In tecnico Where tec.NombreTecnico.Trim = cbxTecnico.Text.Trim Select New With {tec.IdTecnico})
            For Each x In query
                tecnicoElegido = x.IdTecnico
            Next

            'buscamos el idPaciente
            Dim pacienteActivo As String
            Dim hs As ObjectSet(Of HISTORIA) = bdAlej.HISTORIA
            Dim query2 = (From p In hs Where p.IdHistoria = tbHistoria.Text Select New With {p.IdPaciente})
            For Each s In query2
                pacienteActivo = s.IdPaciente
            Next

            'realizamos la consulta sobre la cita pendiente
            Dim citaAnterior As ObjectSet(Of CITAS) = bdAlej.CITAS
            Dim query3 = (From d In citaAnterior Where d.Asistencia.Trim = "PENDIENTE" And d.IdTecnico = tecnicoElegido And d.IdPaciente = pacienteActivo Select d).FirstOrDefault()

            Dim caption As String = "Control de citas"

            If Not (String.IsNullOrWhiteSpace(tbProxCita.Text)) And Not (String.IsNullOrWhiteSpace(tbHoraCita.Text)) And Not (String.IsNullOrWhiteSpace(cbxTecnico.Text)) Then
                Dim nuevaCita As CITAS = CITAS.CreateCITAS(idPaciente:=pacienteActivo, idTecnico:=tecnicoElegido, fechaCita:=Convert.ToDateTime(tbProxCita.Text))

                bdAlej.AddToCITAS(nuevaCita)
                nuevaCita.HoraCita = tbHoraCita.Text
                nuevaCita.Asistencia = "PENDIENTE"

                If Not (IsNothing(query3)) Then
                    If MessageBox.Show("¿Ha acudido el paciente a la última cita?", caption, MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                        query3.Asistencia = "ASISTE"
                    Else
                        query3.Asistencia = "NO ASISTE"
                    End If
                End If
                Try
                    bdAlej.SaveChanges()
                    MessageBox.Show("Cita programada con éxito")
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                Me.Close()
            Else
                MessageBox.Show("Debe seleccionar técnico para la próxima cita, así como insertar fecha y hora de la misma.")
            End If
        Else
            MsgBox("Los formatos admitidos de fecha son dd/mm/aa y dd/mm/aaaa")
        End If

    End Sub


    Private Sub btVer_Click(sender As System.Object, e As System.EventArgs) Handles btVer.Click
        'buscamos el tecnico que está citando
        Dim tecnicoElegido As Integer
        Dim tecnico As ObjectSet(Of TECNICOS) = bdAlej.TECNICOS
        Dim query = (From tec In tecnico Where tec.NombreTecnico.Trim = cbxTecnico.Text.Trim Select New With {tec.IdTecnico})
        For Each x In query
            tecnicoElegido = x.IdTecnico
        Next

        Dim citas As ObjectSet(Of CITAS) = bdAlej.CITAS

        Dim query2 = (From cit In citas Where cit.IdTecnico = tecnicoElegido And cit.IdPaciente = "PAC" & tbHistoria.Text.Trim Select New With {cit.FechaCita, cit.HoraCita, cit.Asistencia})

        dgvCitas.DataSource = query2

    End Sub

    Private Sub formControlCitas_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        cbxTecnico.Items.Clear()
        cbxTecnico.Text = ""
        dgvCitas.DataSource = Nothing
        tbHoraCita.Text = ""
        tbProxCita.Text = ""
        tbHistoria.Text = ""

    End Sub

    Private Sub NoAcudeAÚltimaCitaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NoAcudeAÚltimaCitaToolStripMenuItem.Click
        If IsNothing(dgvCitas.DataSource) Then
            MsgBox("No hay datos que actualizar")
        Else

            'marcamos la cita pendiente como "No Asiste"
            Dim cit As ObjectSet(Of CITAS) = bdAlej.CITAS
            Dim histori As ObjectSet(Of HISTORIA) = bdAlej.HISTORIA
            Dim pac As ObjectSet(Of PACIENTES) = bdAlej.PACIENTES

            'buscamos el tecnico que tiene la cita
            Dim tecnicoElegido As Integer
            Dim tecnico As ObjectSet(Of TECNICOS) = bdAlej.TECNICOS
            Dim query = (From tec In tecnico Where tec.NombreTecnico.Trim = cbxTecnico.Text.Trim Select New With {tec.IdTecnico})
            For Each x In query
                tecnicoElegido = x.IdTecnico
            Next
            'buscamos el paciente
            Dim averiguandoIdPac = (From h In histori Join p In pac On h.IdPaciente Equals p.IdPaciente Where h.IdHistoria = tbHistoria.Text.Trim Select New With {h.IdPaciente})
            Dim variableIdPac As String
            variableIdPac = averiguandoIdPac.First.IdPaciente.ToString

            'hacemos la consulta
            Dim query3 = (From d In cit Where d.Asistencia.Trim = "PENDIENTE" And d.IdTecnico = tecnicoElegido And d.IdPaciente = variableIdPac Select d).FirstOrDefault()
            If IsNothing(query3) Then
                MsgBox("No hay citas pendientes")
                Exit Sub
            Else
                query3.Asistencia = "NO ASISTE"
            End If

            Try
                bdAlej.SaveChanges()
                MessageBox.Show("Cita actualizada con éxito")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            Me.Close()
        End If
    End Sub

    Private Sub AcudeAÚltimaCitaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AcudeAÚltimaCitaToolStripMenuItem.Click

        If IsNothing(dgvCitas.DataSource) Then
            MsgBox("No hay datos que actualizar")
        Else
            'marcamos la cita pendiente como "No Asiste"
            Dim cit As ObjectSet(Of CITAS) = bdAlej.CITAS
            Dim histori As ObjectSet(Of HISTORIA) = bdAlej.HISTORIA
            Dim pac As ObjectSet(Of PACIENTES) = bdAlej.PACIENTES

            'buscamos el tecnico que tiene la cita
            Dim tecnicoElegido As Integer
            Dim tecnico As ObjectSet(Of TECNICOS) = bdAlej.TECNICOS
            Dim query = (From tec In tecnico Where tec.NombreTecnico.Trim = cbxTecnico.Text.Trim Select New With {tec.IdTecnico})
            For Each x In query
                tecnicoElegido = x.IdTecnico
            Next
            'buscamos el paciente
            Dim averiguandoIdPac = (From h In histori Join p In pac On h.IdPaciente Equals p.IdPaciente Where h.IdHistoria = tbHistoria.Text.Trim Select New With {h.IdPaciente})
            Dim variableIdPac As String
            variableIdPac = averiguandoIdPac.First.IdPaciente.ToString

            'hacemos la consulta
            Dim query3 = (From d In cit Where d.Asistencia.Trim = "PENDIENTE" And d.IdTecnico = tecnicoElegido And d.IdPaciente = variableIdPac Select d).FirstOrDefault()
            If IsNothing(query3) Then
                MsgBox("No hay citas pendientes")
                Exit Sub
            Else
                query3.Asistencia = "ASISTE"
            End If
            Try
                bdAlej.SaveChanges()
                MessageBox.Show("Cita actualizada con éxito")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            Me.Close()
        End If
    End Sub

    Private Sub CanceladaConJustificaciónToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CanceladaConJustificaciónToolStripMenuItem.Click
        If IsNothing(dgvCitas.DataSource) Then
            MsgBox("No hay datos que actualizar")
        Else

            'marcamos la cita pendiente como "No Asiste"
            Dim cit As ObjectSet(Of CITAS) = bdAlej.CITAS
            Dim histori As ObjectSet(Of HISTORIA) = bdAlej.HISTORIA
            Dim pac As ObjectSet(Of PACIENTES) = bdAlej.PACIENTES

            'buscamos el tecnico que tiene la cita
            Dim tecnicoElegido As Integer
            Dim tecnico As ObjectSet(Of TECNICOS) = bdAlej.TECNICOS
            Dim query = (From tec In tecnico Where tec.NombreTecnico.Trim = cbxTecnico.Text.Trim Select New With {tec.IdTecnico})
            For Each x In query
                tecnicoElegido = x.IdTecnico
            Next
            'buscamos el paciente
            Dim averiguandoIdPac = (From h In histori Join p In pac On h.IdPaciente Equals p.IdPaciente Where h.IdHistoria = tbHistoria.Text.Trim Select New With {h.IdPaciente})
            Dim variableIdPac As String
            variableIdPac = averiguandoIdPac.First.IdPaciente.ToString

            'hacemos la consulta
            Dim query3 = (From d In cit Where d.Asistencia.Trim = "PENDIENTE" And d.IdTecnico = tecnicoElegido And d.IdPaciente = variableIdPac Select d).FirstOrDefault()
            If IsNothing(query3) Then
                MsgBox("No hay citas pendientes")
                Exit Sub
            Else
                query3.Asistencia = "MOTIVADA"
            End If

            Try
                bdAlej.SaveChanges()
                MessageBox.Show("Cita actualizada con éxito")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            Me.Close()
        End If
    End Sub

    Private Sub BorrarCitaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BorrarCitaToolStripMenuItem.Click
        Dim citaACancelar As Date

        citaACancelar = Convert.ToDateTime(dgvCitas.CurrentRow.Cells.Item("FechaCita").Value)

        If IsNothing(dgvCitas.DataSource) Then
            MsgBox("No hay datos que actualizar")
        Else

            'marcamos la cita pendiente como "No Asiste"
            Dim cit As ObjectSet(Of CITAS) = bdAlej.CITAS
            Dim histori As ObjectSet(Of HISTORIA) = bdAlej.HISTORIA
            Dim pac As ObjectSet(Of PACIENTES) = bdAlej.PACIENTES

            'buscamos el tecnico que tiene la cita
            Dim tecnicoElegido As Integer
            Dim tecnico As ObjectSet(Of TECNICOS) = bdAlej.TECNICOS
            Dim query = (From tec In tecnico Where tec.NombreTecnico.Trim = cbxTecnico.Text.Trim Select New With {tec.IdTecnico})
            For Each x In query
                tecnicoElegido = x.IdTecnico
            Next
            'buscamos el paciente
            Dim averiguandoIdPac = (From h In histori Join p In pac On h.IdPaciente Equals p.IdPaciente Where h.IdHistoria = tbHistoria.Text.Trim Select New With {h.IdPaciente})
            Dim variableIdPac As String
            variableIdPac = averiguandoIdPac.First.IdPaciente.ToString

            'hacemos la consulta y borramos la cita
            Dim query3 = (From d In cit Where d.FechaCita = citaACancelar And d.IdTecnico = tecnicoElegido And d.IdPaciente = variableIdPac Select d).FirstOrDefault()
            Dim caption = "Atención"
            If MessageBox.Show("¿Desea borrar la cita?", caption, MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                bdAlej.CITAS.DeleteObject(query3)
            End If

            Try
                bdAlej.SaveChanges()
                MessageBox.Show("Agenda actualizada con éxito")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            Me.Close()
            End If
    End Sub
End Class


'COSAS A TENER EN CUENTA CON LAS CITAS
' 1. No se puede formalizar próxima cita si el textbox está vacio.
' 2. El datagrid se tiene que llenar con la fecha de la cita y si acudió o no, en orden descedente.
' 3. Al formalizar la cita se preguntará si ha acudido o no a la última cita.
' 4. Poner label y textbox del tecnico en false
