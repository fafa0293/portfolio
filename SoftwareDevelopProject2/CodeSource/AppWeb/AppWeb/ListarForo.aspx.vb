Imports solLogica.Gestor

Public Class ListarForos
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ModuloUtilitario.iniciarSesion(Me)
        Page.Title = generarTitulo("Foros")
        If Not IsPostBack Then
            cargarForos()
        End If
    End Sub

    Protected Sub cargarForos()
        Dim da As Boolean = False
        listaForos.DataSource = GestorForo.listarForosPorUsuarioLog()
        listaForos.DataBind()
    End Sub
End Class