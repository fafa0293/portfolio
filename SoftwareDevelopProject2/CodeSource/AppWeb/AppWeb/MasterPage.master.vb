Imports solLogica.Gestor
Public Class MasterPage1
    Inherits System.Web.UI.MasterPage

    Public Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If AppWeb.ModuloUtilitario.iniciarSesion(Me.Page) Then
            lblUsuarioActual.Text = GestorSesion.getNombreCompletoUsuario()

            If GestorSesion.usuarioTieneRol("director académico") Or
               GestorSesion.usuarioTieneRol("rector") Then
                lReportes.Visible = True
            End If
        End If

    End Sub

End Class