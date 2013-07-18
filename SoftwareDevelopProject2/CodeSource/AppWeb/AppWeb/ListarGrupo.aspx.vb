Imports solLogica.Gestor
Imports System

Public Class ListarGrupo
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ModuloUtilitario.iniciarSesion(Me)

        If Not (GestorSesion.usuarioTieneRol("Director Académico") Or
                 GestorSesion.usuarioTieneRol("Encargado de Registro")) Then
            mostrarError(Me, "Usted no cuenta con los permisos necesarios para acceder a esta página")
        End If

        Page.Title = generarTitulo("Grupos")
        If Not IsPostBack Then
            cargarGrupos()
            CargarCursos()

        End If
    End Sub

    Public Sub CargarCursos()
        ddlCurso.DataSource = GestorCurso.listarCursos()
        ddlCurso.DataBind()
    End Sub

    Protected Sub cargarGrupos()
        listaGrupos.DataSource = GestorGrupo.buscarGrupos
        listaGrupos.DataBind()
    End Sub

    Protected Sub btnBuscar_Click(sender As Object, e As System.EventArgs) Handles btnBuscar.Click
        listaGrupos.DataSource = Nothing
        If rbNombre.Checked Then
            listaGrupos.DataSource = GestorGrupo.buscarGrupoPorNombre(txtBuscarNombre.Text)
        ElseIf rbCodigo.Checked Then
            listaGrupos.DataSource = GestorGrupo.buscarGrupoPorCodigo(txtBuscarCodigo.Text)
        ElseIf rbCurso.Checked Then
            listaGrupos.DataSource = GestorGrupo.listarGruposPorCursoId(CInt(ddlCurso.SelectedValue))
        Else
            listaGrupos.DataSource = GestorGrupo.buscarGrupos
        End If
        listaGrupos.DataBind()
    End Sub


    Protected Sub listaGrupos_ItemCommand(source As Object, e As System.Web.UI.WebControls.RepeaterCommandEventArgs) Handles listaGrupos.ItemCommand

        If e.CommandName.ToString = "Eliminar" Then
            Try
                GestorGrupo.eliminarGrupo(CInt(e.CommandArgument.ToString))
                cargarGrupos()
            Catch ex As Exception
                mostrarError(Me, ex.Message)
            End Try
        End If
    End Sub
End Class
