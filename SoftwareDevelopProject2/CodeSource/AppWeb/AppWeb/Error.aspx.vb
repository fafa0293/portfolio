Public Class _Error
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("ErrorMostrado") Is Nothing Then
            Session("ErrorMostrado") = "Error desconocido."
        End If
        Page.Title = generarTitulo("Error")
        lblError.Text = CType(Session("ErrorMostrado"), String)
    End Sub

End Class