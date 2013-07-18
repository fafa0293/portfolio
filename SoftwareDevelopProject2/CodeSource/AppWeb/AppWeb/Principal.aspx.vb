Imports solLogica.Gestor
Public Class Principal1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ModuloUtilitario.iniciarSesion(Me)
        Page.Title = generarTitulo("Principal")

        If GestorSesion.usuarioTieneRol("profesor") Then
            pnlProfesor.Visible = True
        End If

        If GestorSesion.usuarioTieneRol("encargado de registro") Then
            pnlRegistro.Visible = True
        End If

        If GestorSesion.usuarioTieneRol("director académico") Then
            pnlRegistro.Visible = True
        End If
    End Sub

End Class