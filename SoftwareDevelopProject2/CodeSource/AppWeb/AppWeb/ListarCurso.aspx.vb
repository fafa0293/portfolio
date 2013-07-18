Imports solLogica.Gestor
Public Class ListarCurso
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ModuloUtilitario.iniciarSesion(Me)

        Page.Title = generarTitulo("Cursos")

        If Not (GestorSesion.usuarioTieneRol("Director Académico") Or
                 GestorSesion.usuarioTieneRol("Encargado de Registro")) Then
            mostrarError(Me, "Usted no cuenta con los permisos necesarios para acceder a esta página")
        End If

        If Not IsPostBack Then
            cargarCursos()
        End If
    End Sub

    Protected Sub cargarCursos()
        listaCursos.DataSource = GestorCurso.listarCursos
        listaCursos.DataBind()
    End Sub

End Class