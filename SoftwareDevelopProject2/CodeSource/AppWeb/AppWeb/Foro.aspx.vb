Imports System
Imports solLogica.Gestor
Imports solLogica.Estructura
Imports System.Globalization

Public Class Foro
    Inherits System.Web.UI.Page
    Private foro As StrForo
    Private idForo As Integer

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        ModuloUtilitario.iniciarSesion(Me)

        idForo = CType(Request.QueryString("ID"), Integer)

        If Not GestorForo.usuarioLogPuedeVerForo(idForo) Then
            mostrarError(Me, "Usted no tiene permiso para acceder a este foro")
        End If

        If Not IsPostBack Then
            cargarListas()
        End If

        Try
            foro = GestorForo.buscarForoPorIdGrupo(idForo)
            lblNombreForo.Text = foro.NombreForo
            Page.Title = generarTitulo(foro.NombreForo & " :: Foros")
        Catch ex As Exception
            mostrarError(Me, "No se encontró el foro especificado.")
        End Try

        If GestorSesion.usuarioTienePermiso("verEstudiantesGrupo") Then
            linkEstGrupo.Text = "Ver Estudiantes"
            linkEstGrupo.Visible = True
            linkEstGrupo.NavigateUrl = "EstudiantesGrupo.aspx?ID=" & foro.IdGrupo
        End If

        If GestorForo.usuarioLogPuedeVerForo(idForo) And GestorSesion.usuarioTieneRol("profesor") Then
            pnlNuevoTema.Visible = True
            linkEstGrupo.Visible = False
            linkMostrarRegTema.Visible = True

        End If

    End Sub

    Private Sub cargarListas()
        listaTemas.DataSource = GestorTema.buscarTemasPorForo(idForo)
        listaTemas.DataBind()
    End Sub

    Protected Sub btnBuscar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBuscar.Click
        listaTemas.DataSource = GestorTema.buscarTemas(idForo, "", txtTituloTema.Text)
        listaTemas.DataBind()
    End Sub

    Protected Sub btnRegistrarTema_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRegistrarTema.Click
        Dim idUsuarioLog As Integer = GestorSesion.getIdUsuario()

        If CInt(foro.IdUsuario) = idUsuarioLog Then
            Try
                GestorTema.agregarTema(idUsuarioLog, idForo, txtTitulo.Text, 0, CInt(txtAportesMaximos.Text),
                                       DateTime.ParseExact(txtFechaInicio.Text, "dd/mm/yyyy", CultureInfo.InvariantCulture),
                                         DateTime.ParseExact(txtFechaFin.Text, "dd/mm/yyyy", CultureInfo.InvariantCulture))
            Catch ex As Exception
                mostrarError(Me, "No se pudo agregar el tema")
            End Try
        End If

        cargarListas()
    End Sub
End Class