Imports System
Imports solLogica.Gestor
Public Class EstudiantesGrupo
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
            Page.Title = generarTitulo("Estudiantes del Grupo '" & nombreGrupo & "'")
        Catch ex As Exception
            mostrarError(Me, "No se encontró el Grupo especificado.")
        End Try
    End Sub

    Private Sub cargarListas()
        listaEstudiantes.DataSource = GestorUsuario.listarEstudiantesPorGrupoId(idGrupo)
        listaEstudiantes.DataBind()
    End Sub

    Protected Sub listaEstudiantes_ItemCommand(source As Object, e As System.Web.UI.WebControls.RepeaterCommandEventArgs) Handles listaEstudiantes.ItemCommand
        If e.CommandName.ToString = "Eliminar" Then
            Try
                GestorGrupo.eliminarAsignacionEstudiante(idGrupo, CInt(e.CommandArgument.ToString))
                cargarListas()
            Catch ex As Exception
                mostrarError(Me, ex.Message)
            End Try
        End If
    End Sub
End Class