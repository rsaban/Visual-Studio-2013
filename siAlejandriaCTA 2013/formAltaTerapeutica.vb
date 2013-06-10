Imports System.Data.Objects
Imports System.Data.Objects.DataClasses


Public Class formAltaTerapeutica
    Dim fechaAdmision As String 'la ponglo global porque si no, no me toma el valor en la comparación

    Private Sub btAlta_Click(sender As System.Object, e As System.EventArgs) Handles btAlta.Click


        'vamos a obtener la fecha de admisión a TTº para compararla con la fecha de alta
        Dim admision As ObjectSet(Of INGRESO) = bdAlej.INGRESO
        ' Dim query = (From ad In admision Order By ad.FechaAdmisionTTo Descending Take 1 Where ad.IdHistoria = tbHistoria.Text.Trim Select New With {ad.FechaAdmisionTTo})
        Dim query = (From ad In admision Order By ad.FechaAdmisionTTo Descending Where ad.IdHistoria = tbHistoria.Text.Trim Select ad.FechaAdmisionTTo).FirstOrDefault
        fechaAdmision = query
        ' For Each x In query
        'fechaAdmision = x.FechaAdmisionTTo
        ' Next


        If dtpAltaTerap.Text > Convert.ToDateTime(fechaAdmision) Then

            Dim altaNueva As ALTA = ALTA.CreateALTA(idHistoria:=tbHistoria.Text.Trim, fechaAlta:=dtpAltaTerap.Text)

            bdAlej.AddToALTA(altaNueva)
            altaNueva.MotivoAlta = cbxMotivoAlta.Text
            bdAlej.ALTA.AddObject(altaNueva)

            Try
                bdAlej.SaveChanges()
                MessageBox.Show("Alta terapéutica grabada con éxito")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

            Me.Close()
            formFichaPaciente.Close()
        Else
            MsgBox("La fecha de Alta Terapéutica debe ser superior a la fecha de Admisión a Tratamiento: " & fechaAdmision)
        End If

    End Sub
End Class