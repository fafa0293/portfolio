Imports solLogica.Gestor

Public Class IniciarSesion
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Page.Title = generarTitulo("Iniciar Sesión")
    End Sub

    Protected Sub iniciarSesion(sender As Object, e As System.Web.UI.WebControls.AuthenticateEventArgs)
        If GestorSesion.iniciarSesion(Login.UserName, Login.Password, "web") Then
            e.Authenticated = True
            Session("loginUsername") = Login.UserName
            Session("loginPassword") = Login.Password

            Response.Redirect("Principal.aspx")
        End If
    End Sub
End Class