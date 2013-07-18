Imports solLogica.Gestor
Public Class ReporteCantAportesEstudianteForoGrafico
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            cargarListas()
        Else
            ReportViewer1.LocalReport.Refresh()
        End If
    End Sub

    Private Sub cargarListas()
        ddGrupos.DataValueField = "IdGrupo"
        ddGrupos.DataTextField = "Nombre"
        ddGrupos.DataSource = GestorGrupo.listarGrupos()
        ddGrupos.DataBind()
    End Sub

End Class