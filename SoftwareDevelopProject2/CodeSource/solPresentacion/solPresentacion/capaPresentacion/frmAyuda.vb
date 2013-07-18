Public Class frmAyuda


    Public Sub setDescripcion(ByVal descripcion As String)
        lblDescripcion.Text = descripcion
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class