Public Class CerrarSesion
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Session("loginUsername") = Nothing
        Session("loginPassword") = Nothing

        Response.Redirect("Principal.aspx")
    End Sub

End Class