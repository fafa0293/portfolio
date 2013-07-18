Imports solLogica.Gestor
Imports System

Public Class BuscarBlog1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Page.Title = AppWeb.ModuloUtilitario.generarTitulo("Blogs")
        If IsPostBack = False Then
            ''cargarGrupo()
            cargarRol()
            cargarTodosBlogs()
        End If
    End Sub

    Private Sub cargarGrupo()

    End Sub

    Private Sub cargarRol()
        cmbRol.DataSource = GestorRol.listarRoles()
        cmbRol.DataBind()
    End Sub

    Private Sub cargarTodosBlogs()
        listaBlogs.DataSource = GestorBlog.listarBlogs()
        listaBlogs.DataBind()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As System.EventArgs) Handles btnBuscar.Click
        If rdbNombre.Checked Then
            Dim nombre As String = txtNombre.Text
            listaBlogs.DataSource = GestorBlog.buscarBlogsPorNombre(nombre)
            listaBlogs.DataBind()
        End If

        If rdbRol.Checked Then
            Dim idRol As Integer = CInt(cmbRol.SelectedValue)
            listaBlogs.DataSource = GestorBlog.buscarBlogsPorIdRol(idRol)
            listaBlogs.DataBind()
        End If
    End Sub

End Class