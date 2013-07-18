Imports System
Imports solLogica.Gestor
Public Class EstudiantesTema
    Inherits System.Web.UI.Page

    Private idTema As Integer

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ModuloUtilitario.iniciarSesion(Me)
        idTema = CType(Request.QueryString("ID"), Integer)

        If Not (GestorSesion.usuarioTieneRol("Profesor")) Then
            mostrarError(Me, "Usted no cuenta con los permisos necesarios para acceder a esta página")
        End If

        If Not IsPostBack Then
            cargarListas()
        End If

        Dim idUsuario As Integer = CInt(Request.QueryString("Bloquear"))
        If idUsuario > 0 Then
            bloquearEstudiante(idUsuario)
        End If

        Try
            Dim tituloTema As String = GestorTema.buscarTemaId(idTema).Titulo
            lblGrupo.Text = tituloTema
            HyperLink1.NavigateUrl = "Tema.aspx?ID=" & idTema
            iIdTema.Value = idTema.ToString()
            Page.Title = generarTitulo("Estudiantes del Tema '" & tituloTema & "'")
        Catch ex As Exception
            mostrarError(Me, "No se encontró el Tema especificado.")
        End Try
    End Sub

    Private Sub bloquearEstudiante(ByVal idUsuario As Integer)
        Dim justificacion As String = Request.QueryString("Justificacion")

        GestorTema.eliminarAsignacionEstudianteATema(idUsuario, idTema)
        ''' enviar correo con justificacion de bloqueo
        Response.Redirect("EstudiantesTema.aspx?ID=" & idTema)
    End Sub

    Private Sub cargarListas()
        listaEstudiantes.DataSource = GestorUsuario.buscarEstudiantesTema(idTema)
        listaEstudiantes.DataBind()
    End Sub
End Class