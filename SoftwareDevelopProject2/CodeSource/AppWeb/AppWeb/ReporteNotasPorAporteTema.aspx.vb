Imports solLogica.Gestor
Public Class ReporteNotasPorAporteTema1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            cargarListas()
        Else
            ReportViewer1.LocalReport.Refresh()
        End If
    End Sub

    Private Sub cargarListas()
        ddUsuarios.DataValueField = "IdUsuario"
        ddUsuarios.DataTextField = "NombreCompleto"
        ddUsuarios.DataSource = GestorUsuario.listarTodosUsuariosEst()
        ddUsuarios.DataBind()
    End Sub

End Class