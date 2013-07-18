Imports solLogica.Gestor

Public Class Reportes
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Page.Title = generarTitulo("Reportes")

        If Not (GestorSesion.usuarioTieneRol("director académico") Or
            GestorSesion.usuarioTieneRol("encargado de registro") Or
            GestorSesion.usuarioTieneRol("rector")) Then
            mostrarError(Me, "Usted no cuenta con los permisos necesarios para acceder a esta página")
        End If
    End Sub

End Class