Imports solLogica.Gestor

Public Class ReporteCantidadEntradasDeUnBlog
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cargarUsuarios()
    End Sub

    Private Sub cargarUsuarios()
        cmbUsuario.DataSource = GestorUsuario.buscarTodosUsuarios
        cmbUsuario.DataBind()
    End Sub

End Class