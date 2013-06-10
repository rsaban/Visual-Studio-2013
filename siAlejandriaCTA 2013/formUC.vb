Imports System.Data.Objects
Imports System.Data.Objects.DataClasses


Public Class formUC

    'Private Sub btGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btGuardar.Click

    '    Dim uC As ObjectSet(Of UNIDAD_CONVIVENCIA) = bdAlej.UNIDAD_CONVIVENCIA
    '    Dim consultando = (From c In uC Where c.IdHistoria = tbHistoria.Text.Trim Select c)

    '    If consultando.Count = 0 Then
    '        If String.IsNullOrWhiteSpace(tbConviviente1.Text) Then
    '            MsgBox("No hay datos para guardar")
    '        Else
    '            Dim nuevoConviviente As UNIDAD_CONVIVENCIA = UNIDAD_CONVIVENCIA.CreateUNIDAD_CONVIVENCIA(idUnidConv:=AutoCompleteMode.None, idHistoria:=tbHistoria.Text)
    '            bdAlej.AddToUNIDAD_CONVIVENCIA(nuevoConviviente)

    '            nuevoConviviente.NombreConviviente = tbConviviente1.Text
    '            nuevoConviviente.EdadConviviente = tbNac1.Text
    '            nuevoConviviente.ParentescoConviviente = cbxParentesco1.Text
    '            nuevoConviviente.SitLabConvivente = cbxSitLab1.Text
    '            nuevoConviviente.FamiliarEnTTo = tbFamiliarTTo1.Text

    '            bdAlej.UNIDAD_CONVIVENCIA.AddObject(nuevoConviviente)
    '        End If

    '        If Not (String.IsNullOrWhiteSpace(tbConviviente2.Text)) Then
    '            Dim nuevoConviviente2 As UNIDAD_CONVIVENCIA = UNIDAD_CONVIVENCIA.CreateUNIDAD_CONVIVENCIA(idUnidConv:=AutoCompleteMode.None, idHistoria:=tbHistoria.Text)
    '            bdAlej.AddToUNIDAD_CONVIVENCIA(nuevoConviviente2)

    '            nuevoConviviente2.NombreConviviente = tbConviviente2.Text
    '            nuevoConviviente2.EdadConviviente = tbNac2.Text
    '            nuevoConviviente2.ParentescoConviviente = cbxParentesco2.Text
    '            nuevoConviviente2.SitLabConvivente = cbxSitLab2.Text
    '            nuevoConviviente2.FamiliarEnTTo = tbFamiliarTTo2.Text

    '            bdAlej.UNIDAD_CONVIVENCIA.AddObject(nuevoConviviente2)
    '        End If

    '        If Not (String.IsNullOrWhiteSpace(tbConviviente3.Text)) Then
    '            Dim nuevoConviviente3 As UNIDAD_CONVIVENCIA = UNIDAD_CONVIVENCIA.CreateUNIDAD_CONVIVENCIA(idUnidConv:=AutoCompleteMode.None, idHistoria:=tbHistoria.Text)
    '            bdAlej.AddToUNIDAD_CONVIVENCIA(nuevoConviviente3)

    '            nuevoConviviente3.NombreConviviente = tbConviviente3.Text
    '            nuevoConviviente3.EdadConviviente = tbNac3.Text
    '            nuevoConviviente3.ParentescoConviviente = cbxParentesco3.Text
    '            nuevoConviviente3.SitLabConvivente = cbxSitLab3.Text
    '            nuevoConviviente3.FamiliarEnTTo = tbFamiliarTTo3.Text

    '            bdAlej.UNIDAD_CONVIVENCIA.AddObject(nuevoConviviente3)
    '        End If

    '        If Not (String.IsNullOrWhiteSpace(tbConviviente4.Text)) Then
    '            Dim nuevoConviviente4 As UNIDAD_CONVIVENCIA = UNIDAD_CONVIVENCIA.CreateUNIDAD_CONVIVENCIA(idUnidConv:=AutoCompleteMode.None, idHistoria:=tbHistoria.Text)
    '            bdAlej.AddToUNIDAD_CONVIVENCIA(nuevoConviviente4)

    '            nuevoConviviente4.NombreConviviente = tbConviviente4.Text
    '            nuevoConviviente4.EdadConviviente = tbNac4.Text
    '            nuevoConviviente4.ParentescoConviviente = cbxParentesco4.Text
    '            nuevoConviviente4.SitLabConvivente = cbxSitLab4.Text
    '            nuevoConviviente4.FamiliarEnTTo = tbFamiliarTTo4.Text

    '            bdAlej.UNIDAD_CONVIVENCIA.AddObject(nuevoConviviente4)
    '        End If

    '        If Not (String.IsNullOrWhiteSpace(tbConviviente5.Text)) Then
    '            Dim nuevoConviviente5 As UNIDAD_CONVIVENCIA = UNIDAD_CONVIVENCIA.CreateUNIDAD_CONVIVENCIA(idUnidConv:=AutoCompleteMode.None, idHistoria:=tbHistoria.Text)
    '            bdAlej.AddToUNIDAD_CONVIVENCIA(nuevoConviviente5)

    '            nuevoConviviente5.NombreConviviente = tbConviviente5.Text
    '            nuevoConviviente5.EdadConviviente = tbNac5.Text
    '            nuevoConviviente5.ParentescoConviviente = cbxParentesco5.Text
    '            nuevoConviviente5.SitLabConvivente = cbxSitLab5.Text
    '            nuevoConviviente5.FamiliarEnTTo = tbFamiliarTTo5.Text

    '            bdAlej.UNIDAD_CONVIVENCIA.AddObject(nuevoConviviente5)
    '        End If

    '        If Not (String.IsNullOrWhiteSpace(tbConviviente6.Text)) Then
    '            Dim nuevoConviviente6 As UNIDAD_CONVIVENCIA = UNIDAD_CONVIVENCIA.CreateUNIDAD_CONVIVENCIA(idUnidConv:=AutoCompleteMode.None, idHistoria:=tbHistoria.Text)
    '            bdAlej.AddToUNIDAD_CONVIVENCIA(nuevoConviviente6)

    '            nuevoConviviente6.NombreConviviente = tbConviviente6.Text
    '            nuevoConviviente6.EdadConviviente = tbNac6.Text
    '            nuevoConviviente6.ParentescoConviviente = cbxParentesco6.Text
    '            nuevoConviviente6.SitLabConvivente = cbxSitLab6.Text
    '            nuevoConviviente6.FamiliarEnTTo = tbFamiliarTTo6.Text

    '            bdAlej.UNIDAD_CONVIVENCIA.AddObject(nuevoConviviente6)
    '        End If

    '        'ENVIAMOS LA INFORMACION A LA BASE DE DATOS
    '        Try
    '            bdAlej.SaveChanges()
    '            MessageBox.Show("Unidad familiar registrada con éxito")
    '        Catch ex As Exception
    '            MessageBox.Show(ex.Message)
    '        End Try
    '        Me.Close()

    '    Else
    '        MsgBox("Ya existe una Unidad de Convivencia para este paciente. Por favor, utilice la modalidad 'Actualizar'")
    '        Me.Close()
    '    End If

    'End Sub

    Private Sub formUC_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        tbConviviente1.Clear()
        tbConviviente2.Clear()
        tbConviviente3.Clear()
        tbConviviente4.Clear()
        tbConviviente5.Clear()
        tbConviviente6.Clear()
        tbNac1.Clear()
        tbNac2.Clear()
        tbNac3.Clear()
        tbNac4.Clear()
        tbNac5.Clear()
        tbNac6.Clear()
        cbxParentesco1.Text = ""
        cbxParentesco2.Text = ""
        cbxParentesco3.Text = ""
        cbxParentesco4.Text = ""
        cbxParentesco5.Text = ""
        cbxParentesco6.Text = ""
        cbxSitLab1.Text = ""
        cbxSitLab2.Text = ""
        cbxSitLab3.Text = ""
        cbxSitLab4.Text = ""
        cbxSitLab5.Text = ""
        cbxSitLab6.Text = ""
        tbFamiliarTTo1.Clear()
        tbFamiliarTTo2.Clear()
        tbFamiliarTTo3.Clear()
        tbFamiliarTTo4.Clear()
        tbFamiliarTTo5.Clear()
        tbFamiliarTTo6.Clear()
    End Sub

    Private Sub btActualizar_Click(sender As System.Object, e As System.EventArgs) Handles btActualizar.Click
        Dim uC As ObjectSet(Of UNIDAD_CONVIVENCIA) = bdAlej.UNIDAD_CONVIVENCIA

        If String.IsNullOrWhiteSpace(tbConviviente1.Text) Then
            MsgBox("No hay datos para guardar")
        Else
            Dim consultando1 = (From c In uC Where c.IdHistoria = tbHistoria.Text.Trim And c.IdUnidConv = tbIdUC1.Text.Trim _
                                    Select c)
            If consultando1.Count = 0 Then
                Dim nuevoConviviente As UNIDAD_CONVIVENCIA = UNIDAD_CONVIVENCIA.CreateUNIDAD_CONVIVENCIA(idUnidConv:=AutoCompleteMode.None, idHistoria:=tbHistoria.Text)
                bdAlej.AddToUNIDAD_CONVIVENCIA(nuevoConviviente)

                nuevoConviviente.NombreConviviente = tbConviviente1.Text
                nuevoConviviente.EdadConviviente = tbNac1.Text
                nuevoConviviente.ParentescoConviviente = cbxParentesco1.Text
                nuevoConviviente.SitLabConvivente = cbxSitLab1.Text
                nuevoConviviente.FamiliarEnTTo = tbFamiliarTTo1.Text

                bdAlej.UNIDAD_CONVIVENCIA.AddObject(nuevoConviviente)
            Else
                consultando1.FirstOrDefault.NombreConviviente = tbConviviente1.Text.Trim
                consultando1.FirstOrDefault.EdadConviviente = tbNac1.Text.Trim
                consultando1.FirstOrDefault.ParentescoConviviente = cbxParentesco1.Text.Trim
                consultando1.FirstOrDefault.SitLabConvivente = cbxSitLab1.Text.Trim
                consultando1.FirstOrDefault.FamiliarEnTTo = tbFamiliarTTo1.Text.Trim
            End If
        End If

        If Not (String.IsNullOrWhiteSpace(tbConviviente2.Text)) Then
            Dim consultando2 = (From d In uC Where d.IdHistoria = tbHistoria.Text.Trim And d.IdUnidConv = tbIdUC2.Text.Trim _
                                    Select d)
            If consultando2.Count = 0 Then
                Dim nuevoConviviente2 As UNIDAD_CONVIVENCIA = UNIDAD_CONVIVENCIA.CreateUNIDAD_CONVIVENCIA(idUnidConv:=AutoCompleteMode.None, idHistoria:=tbHistoria.Text)
                bdAlej.AddToUNIDAD_CONVIVENCIA(nuevoConviviente2)

                nuevoConviviente2.NombreConviviente = tbConviviente2.Text
                nuevoConviviente2.EdadConviviente = tbNac2.Text
                nuevoConviviente2.ParentescoConviviente = cbxParentesco2.Text
                nuevoConviviente2.SitLabConvivente = cbxSitLab2.Text
                nuevoConviviente2.FamiliarEnTTo = tbFamiliarTTo2.Text

                bdAlej.UNIDAD_CONVIVENCIA.AddObject(nuevoConviviente2)
            Else
                consultando2.FirstOrDefault.NombreConviviente = tbConviviente2.Text.Trim
                consultando2.FirstOrDefault.EdadConviviente = tbNac2.Text.Trim
                consultando2.FirstOrDefault.ParentescoConviviente = cbxParentesco2.Text.Trim
                consultando2.FirstOrDefault.SitLabConvivente = cbxSitLab2.Text.Trim
                consultando2.FirstOrDefault.FamiliarEnTTo = tbFamiliarTTo2.Text.Trim
            End If
        End If

        If Not (String.IsNullOrWhiteSpace(tbConviviente3.Text)) Then
            Dim consultando3 = (From f In uC Where f.IdHistoria = tbHistoria.Text.Trim And f.IdUnidConv = tbIdUC3.Text.Trim _
                                   Select f)
            If consultando3.Count = 0 Then
                Dim nuevoConviviente3 As UNIDAD_CONVIVENCIA = UNIDAD_CONVIVENCIA.CreateUNIDAD_CONVIVENCIA(idUnidConv:=AutoCompleteMode.None, idHistoria:=tbHistoria.Text)
                bdAlej.AddToUNIDAD_CONVIVENCIA(nuevoConviviente3)

                nuevoConviviente3.NombreConviviente = tbConviviente3.Text
                nuevoConviviente3.EdadConviviente = tbNac3.Text
                nuevoConviviente3.ParentescoConviviente = cbxParentesco3.Text
                nuevoConviviente3.SitLabConvivente = cbxSitLab3.Text
                nuevoConviviente3.FamiliarEnTTo = tbFamiliarTTo3.Text

                bdAlej.UNIDAD_CONVIVENCIA.AddObject(nuevoConviviente3)
            Else
                consultando3.FirstOrDefault.NombreConviviente = tbConviviente3.Text.Trim
                consultando3.FirstOrDefault.EdadConviviente = tbNac3.Text.Trim
                consultando3.FirstOrDefault.ParentescoConviviente = cbxParentesco3.Text.Trim
                consultando3.FirstOrDefault.SitLabConvivente = cbxSitLab3.Text.Trim
                consultando3.FirstOrDefault.FamiliarEnTTo = tbFamiliarTTo3.Text.Trim
            End If
        End If

        If Not (String.IsNullOrWhiteSpace(tbConviviente4.Text)) Then
            Dim consultando4 = (From g In uC Where g.IdHistoria = tbHistoria.Text.Trim And g.IdUnidConv = tbIdUC4.Text.Trim _
                                  Select g)
            If consultando4.Count = 0 Then
                Dim nuevoConviviente4 As UNIDAD_CONVIVENCIA = UNIDAD_CONVIVENCIA.CreateUNIDAD_CONVIVENCIA(idUnidConv:=AutoCompleteMode.None, idHistoria:=tbHistoria.Text)
                bdAlej.AddToUNIDAD_CONVIVENCIA(nuevoConviviente4)

                nuevoConviviente4.NombreConviviente = tbConviviente4.Text
                nuevoConviviente4.EdadConviviente = tbNac4.Text
                nuevoConviviente4.ParentescoConviviente = cbxParentesco4.Text
                nuevoConviviente4.SitLabConvivente = cbxSitLab4.Text
                nuevoConviviente4.FamiliarEnTTo = tbFamiliarTTo4.Text

                bdAlej.UNIDAD_CONVIVENCIA.AddObject(nuevoConviviente4)
            Else
                consultando4.FirstOrDefault.NombreConviviente = tbConviviente4.Text.Trim
                consultando4.FirstOrDefault.EdadConviviente = tbNac4.Text.Trim
                consultando4.FirstOrDefault.ParentescoConviviente = cbxParentesco4.Text.Trim
                consultando4.FirstOrDefault.SitLabConvivente = cbxSitLab4.Text.Trim
                consultando4.FirstOrDefault.FamiliarEnTTo = tbFamiliarTTo4.Text.Trim
            End If
        End If

        If Not (String.IsNullOrWhiteSpace(tbConviviente5.Text)) Then
            Dim consultando5 = (From j In uC Where j.IdHistoria = tbHistoria.Text.Trim And j.IdUnidConv = tbIdUC5.Text.Trim _
                                 Select j)
            If consultando5.Count = 0 Then
                Dim nuevoConviviente5 As UNIDAD_CONVIVENCIA = UNIDAD_CONVIVENCIA.CreateUNIDAD_CONVIVENCIA(idUnidConv:=AutoCompleteMode.None, idHistoria:=tbHistoria.Text)
                bdAlej.AddToUNIDAD_CONVIVENCIA(nuevoConviviente5)

                nuevoConviviente5.NombreConviviente = tbConviviente5.Text
                nuevoConviviente5.EdadConviviente = tbNac5.Text
                nuevoConviviente5.ParentescoConviviente = cbxParentesco5.Text
                nuevoConviviente5.SitLabConvivente = cbxSitLab5.Text
                nuevoConviviente5.FamiliarEnTTo = tbFamiliarTTo5.Text

                bdAlej.UNIDAD_CONVIVENCIA.AddObject(nuevoConviviente5)
            Else
                consultando5.FirstOrDefault.NombreConviviente = tbConviviente5.Text.Trim
                consultando5.FirstOrDefault.EdadConviviente = tbNac5.Text.Trim
                consultando5.FirstOrDefault.ParentescoConviviente = cbxParentesco5.Text.Trim
                consultando5.FirstOrDefault.SitLabConvivente = cbxSitLab5.Text.Trim
                consultando5.FirstOrDefault.FamiliarEnTTo = tbFamiliarTTo5.Text.Trim
            End If
        End If

        If Not (String.IsNullOrWhiteSpace(tbConviviente6.Text)) Then
            Dim consultando6 = (From k In uC Where k.IdHistoria = tbHistoria.Text.Trim And k.IdUnidConv = tbIdUC5.Text.Trim _
                                Select k)
            If consultando6.Count = 0 Then
                Dim nuevoConviviente6 As UNIDAD_CONVIVENCIA = UNIDAD_CONVIVENCIA.CreateUNIDAD_CONVIVENCIA(idUnidConv:=AutoCompleteMode.None, idHistoria:=tbHistoria.Text)
                bdAlej.AddToUNIDAD_CONVIVENCIA(nuevoConviviente6)

                nuevoConviviente6.NombreConviviente = tbConviviente6.Text
                nuevoConviviente6.EdadConviviente = tbNac6.Text
                nuevoConviviente6.ParentescoConviviente = cbxParentesco6.Text
                nuevoConviviente6.SitLabConvivente = cbxSitLab6.Text
                nuevoConviviente6.FamiliarEnTTo = tbFamiliarTTo6.Text

                bdAlej.UNIDAD_CONVIVENCIA.AddObject(nuevoConviviente6)
            Else
                consultando6.FirstOrDefault.NombreConviviente = tbConviviente6.Text.Trim
                consultando6.FirstOrDefault.EdadConviviente = tbNac6.Text.Trim
                consultando6.FirstOrDefault.ParentescoConviviente = cbxParentesco6.Text.Trim
                consultando6.FirstOrDefault.SitLabConvivente = cbxSitLab6.Text.Trim
                consultando6.FirstOrDefault.FamiliarEnTTo = tbFamiliarTTo6.Text.Trim
            End If
        End If

            'ENVIAMOS LA INFORMACION A LA BASE DE DATOS
            Try
                bdAlej.SaveChanges()
                MessageBox.Show("Unidad familiar actualizada con éxito")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            Me.Close()

    End Sub

   
    Private Sub pbConv2_Click(sender As System.Object, e As System.EventArgs) Handles pbConv2.Click
        Dim uC As ObjectSet(Of UNIDAD_CONVIVENCIA) = bdAlej.UNIDAD_CONVIVENCIA

        Dim query = (From x In uC Where x.IdUnidConv = tbIdUC2.Text.Trim And x.IdHistoria = tbHistoria.Text.Trim Select x)
        bdAlej.UNIDAD_CONVIVENCIA.DeleteObject(query.FirstOrDefault)
        Try
            bdAlej.SaveChanges()
            MessageBox.Show("Borrado con éxito")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Me.Close()

    End Sub


    Private Sub pbConv1_Click(sender As System.Object, e As System.EventArgs) Handles pbConv1.Click
        Dim uC As ObjectSet(Of UNIDAD_CONVIVENCIA) = bdAlej.UNIDAD_CONVIVENCIA

        Dim query = (From x In uC Where x.IdUnidConv = tbIdUC1.Text.Trim And x.IdHistoria = tbHistoria.Text.Trim Select x)
        bdAlej.UNIDAD_CONVIVENCIA.DeleteObject(query.FirstOrDefault)
        Try
            bdAlej.SaveChanges()
            MessageBox.Show("Borrado con éxito")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Me.Close()
    End Sub

    Private Sub pbConv3_Click(sender As System.Object, e As System.EventArgs) Handles pbConv3.Click
        Dim uC As ObjectSet(Of UNIDAD_CONVIVENCIA) = bdAlej.UNIDAD_CONVIVENCIA

        Dim query = (From x In uC Where x.IdUnidConv = tbIdUC3.Text.Trim And x.IdHistoria = tbHistoria.Text.Trim Select x)
        bdAlej.UNIDAD_CONVIVENCIA.DeleteObject(query.FirstOrDefault)
        Try
            bdAlej.SaveChanges()
            MessageBox.Show("Borrado con éxito")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Me.Close()
    End Sub

    Private Sub pbConv4_Click(sender As System.Object, e As System.EventArgs) Handles pbConv4.Click
        Dim uC As ObjectSet(Of UNIDAD_CONVIVENCIA) = bdAlej.UNIDAD_CONVIVENCIA

        Dim query = (From x In uC Where x.IdUnidConv = tbIdUC4.Text.Trim And x.IdHistoria = tbHistoria.Text.Trim Select x)
        bdAlej.UNIDAD_CONVIVENCIA.DeleteObject(query.FirstOrDefault)
        Try
            bdAlej.SaveChanges()
            MessageBox.Show("Borrado con éxito")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Me.Close()
    End Sub

    Private Sub pbConv5_Click(sender As System.Object, e As System.EventArgs) Handles pbConv5.Click
        Dim uC As ObjectSet(Of UNIDAD_CONVIVENCIA) = bdAlej.UNIDAD_CONVIVENCIA

        Dim query = (From x In uC Where x.IdUnidConv = tbIdUC5.Text.Trim And x.IdHistoria = tbHistoria.Text.Trim Select x)
        bdAlej.UNIDAD_CONVIVENCIA.DeleteObject(query.FirstOrDefault)
        Try
            bdAlej.SaveChanges()
            MessageBox.Show("Borrado con éxito")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Me.Close()
    End Sub

    Private Sub pbConv6_Click(sender As System.Object, e As System.EventArgs) Handles pbConv6.Click
        Dim uC As ObjectSet(Of UNIDAD_CONVIVENCIA) = bdAlej.UNIDAD_CONVIVENCIA

        Dim query = (From x In uC Where x.IdUnidConv = tbIdUC6.Text.Trim And x.IdHistoria = tbHistoria.Text.Trim Select x)
        bdAlej.UNIDAD_CONVIVENCIA.DeleteObject(query.FirstOrDefault)
        Try
            bdAlej.SaveChanges()
            MessageBox.Show("Borrado con éxito")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Me.Close()
    End Sub
End Class