Imports System.Data.Objects
Imports System.Data.Objects.DataClasses

Public Class formCodigosFacturacion


    Private Sub btRegistrarActualizar_Click(sender As System.Object, e As System.EventArgs) Handles btRegistrarActualizar.Click

        If String.IsNullOrWhiteSpace(cbxCodigo.Text) Then
            MsgBox("Debe completar el Código")
        Else
            Dim codsFacs As ObjectSet(Of CODIGOS_FACTURACION) = bdAlej.CODIGOS_FACTURACION

            Dim haberSiEsta = (From cf In codsFacs Where cf.Codigo = cbxCodigo.Text.Trim Select cf).FirstOrDefault

            If Not (IsNothing(haberSiEsta)) Then
                haberSiEsta.Denominacion = tbDenominacion.Text.Trim
                haberSiEsta.Precio = tbPrecio.Text.Trim
            Else
                Dim nuevoCodsFac As CODIGOS_FACTURACION = CODIGOS_FACTURACION.CreateCODIGOS_FACTURACION(codigo:=cbxCodigo.Text.Trim)
                bdAlej.AddToCODIGOS_FACTURACION(nuevoCodsFac)

                nuevoCodsFac.Denominacion = tbDenominacion.Text.Trim
                nuevoCodsFac.Precio = tbPrecio.Text.Trim
                bdAlej.CODIGOS_FACTURACION.AddObject(nuevoCodsFac)
            End If
            Try
                bdAlej.SaveChanges()
                MessageBox.Show("Código de Facturación grabado con éxito")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            Me.Close()
        End If
    End Sub

    Private Sub btVer_Click(sender As System.Object, e As System.EventArgs) Handles btVer.Click
        Dim codsFacs As ObjectSet(Of CODIGOS_FACTURACION) = bdAlej.CODIGOS_FACTURACION
        Dim consultadoCodigos = (From cf In codsFacs Where cf.Codigo = cbxCodigo.Text.Trim Select cf).FirstOrDefault
        If Not (IsNothing(consultadoCodigos)) Then
            tbDenominacion.Text = consultadoCodigos.Denominacion.ToString
            tbPrecio.Text = consultadoCodigos.Precio.ToString
        Else
            MsgBox("El Código no existe")
            tbDenominacion.Text = ""
            tbPrecio.Text = ""
        End If
    End Sub

    Private Sub cbxCodigo_Click(sender As System.Object, e As System.EventArgs) Handles cbxCodigo.Click
        tbDenominacion.Text = ""
        tbPrecio.Text = ""
    End Sub
End Class