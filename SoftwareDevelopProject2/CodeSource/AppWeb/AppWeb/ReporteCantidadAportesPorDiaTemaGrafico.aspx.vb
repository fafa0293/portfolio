Imports solLogica.Gestor
Public Class ReporteCantidaddeAportesPorDiadeunTemaGrafico
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            cargarLista()
        Else
            ReportViewer1.LocalReport.Refresh()
        End If
    End Sub

    Protected Sub cargarLista()

        ddTemas.DataSource = GestorTema.listarTemas()
        ddTemas.DataTextField = "Titulo"
        ddTemas.DataValueField = "IdTema"
        ddTemas.DataBind()
    End Sub
End Class