Imports System.Data.Objects
Imports System.Data.Objects.DataClasses

Public Class formAgenda

    Private Sub btVer_Click(sender As System.Object, e As System.EventArgs) Handles btVer.Click

        lbAvisadorTerapia.Text = ""
        lbAvisadorTerapia.Visible = False

        Dim citas As ObjectSet(Of CITAS) = bdAlej.CITAS
        Dim tecnico As ObjectSet(Of TECNICOS) = bdAlej.TECNICOS
        Dim pacient As ObjectSet(Of PACIENTES) = bdAlej.PACIENTES
        Dim terap As ObjectSet(Of TERAPIAS) = bdAlej.TERAPIAS
        Dim asisTerap As ObjectSet(Of ASISTENTES_TERAPIA) = bdAlej.ASISTENTES_TERAPIA
    
            'buscamos el tecnico que se ha seleccionado
            Dim tecnicoElegido As Integer
            ' Dim tecnico As ObjectSet(Of TECNICOS) = bdAlej.TECNICOS
            Dim query = (From tec In tecnico Where tec.NombreTecnico.Trim = cbxTecnico.Text.Trim Select New With {tec.IdTecnico})
            For Each x In query
                tecnicoElegido = x.IdTecnico
            Next

        Dim query2 = (From cit In citas Join pac In pacient On cit.IdPaciente Equals pac.IdPaciente _
                      Where cit.IdTecnico = tecnicoElegido And cit.FechaCita = dtpFechaCita.Text _
                      Select New With {cit.HoraCita, pac.NombrePaciente})

            dgvAgenda.DataSource = query2

        'buscamos si el técnico tiene terapia el día seleccionado
        Dim query3 = (From aT In asisTerap Join t In terap On t.IdTerapia Equals aT.IdTerapia _
                      Where aT.FechaTerapia = dtpFechaCita.Text And t.IdTecnico = tecnicoElegido _
                      Select aT, t).FirstOrDefault

        If Not (IsNothing(query3)) Then
            lbAvisadorTerapia.Text = "Tiene una sesión de Terapia " & query3.t.NombreTerapia & " a las " & query3.aT.HoraTerapia.Trim & " horas."
            lbAvisadorTerapia.Visible = True
        End If

    End Sub

    Private Sub formAgenda_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        cbxTecnico.Items.Clear()
        dgvAgenda.DataSource = Nothing
    End Sub

    Private Sub btControlCitas_Click(sender As System.Object, e As System.EventArgs) Handles btControlCitas.Click
        Dim tecnico As ObjectSet(Of TECNICOS) = bdAlej.TECNICOS
        Dim query = (From tec In tecnico Where tec.Profesion <> "INVITADO" Select New With {tec.NombreTecnico})
        For Each x In query
            formControlCitas.cbxTecnico.Items.Add(x.NombreTecnico)
        Next

        formControlCitas.tbHistoria.ReadOnly = False
        formControlCitas.Show()
        Me.Close()
    End Sub

   
    Private Sub btCitasNoPacientes_Click(sender As System.Object, e As System.EventArgs) Handles btCitasNoPacientes.Click
        Dim citasNoPac As ObjectSet(Of DESCONECTADA) = bdAlej.DESCONECTADA

        Dim query = (From d In citasNoPac Select d.Nombre_Cita, d.Tecnico_Cita, d.Fecha_Cita, d.Hora_Cita)

        formCitasNoPacientes.dgvCitasNoPac.DataSource = query
        formCitasNoPacientes.ShowDialog()
    End Sub
End Class