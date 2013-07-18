Imports System
Imports solLogica.Gestor
Public Class ProfesorGrupo
    Inherits System.Web.UI.Page

    Private idGrupo As Integer

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ModuloUtilitario.iniciarSesion(Me)
        idGrupo = CType(Request.QueryString("ID"), Integer)

        If Not (GestorSesion.usuarioTieneRol("Director Académico") Or
                 GestorSesion.usuarioTieneRol("Encargado de Registro")) Then
            mostrarError(Me, "Usted no cuenta con los permisos necesarios para acceder a esta página")
        End If

        If Not IsPostBack Then
            cargarListas()
        End If

        Try
            Dim nombreGrupo As String = GestorGrupo.buscarGrupoPorId(idGrupo).Nombre
            lblGrupo.Text = nombreGrupo
            Page.Title = generarTitulo("Profesores del Grupo '" & nombreGrupo & "'")
        Catch ex As Exception
            mostrarError(Me, "No se encontró el Grupo especificado.")
        End Try
    End Sub

    Private Sub cargarListas()
        listaProfesores.DataSource = GestorUsuario.listarProfesoresPorGrupoId(idGrupo)
        listaProfesores.DataBind()
    End Sub

    Protected Sub listaProfesores_ItemCommand(source As Object, e As System.Web.UI.WebControls.RepeaterCommandEventArgs) Handles listaProfesores.ItemCommand
        If e.CommandName.ToString = "Eliminar" Then
            Try
                GestorGrupo.eliminarAsignacionProfesor(idGrupo, CInt(e.CommandArgument.ToString))
                cargarListas()
            Catch ex As Exception
                mostrarError(Me, ex.Message)
            End Try
        End If
    End Sub
End Class