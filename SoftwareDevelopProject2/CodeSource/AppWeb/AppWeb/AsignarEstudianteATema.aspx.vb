Imports solLogica.Gestor
Imports solLogica.Estructura
Imports System

Public Class AsignarEstudianteATema
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ModuloUtilitario.iniciarSesion(Me)
        If GestorSesion.usuarioTienePermiso("asignarEstudianteTema") = False Then
            mostrarError(Me, "Usted no cuenta con los permisos necesarios para acceder a esta página.")
        End If

        Page.Title = generarTitulo("Asignar Estudiante A Tema")

        pnlAlert.Visible = False
        pnlSuccess.Visible = False
        lblAlert.Text = ""
        lblSuccess.Text = ""

        If Not IsPostBack Then
            cargarListas()
        End If
    End Sub

    ''' <summary>
    ''' Método de clase, encarga de cargar las listas
    ''' </summary>
    ''' <remarks>Autor:Christopher Vargas</remarks>
    Private Sub cargarListas()
        Try
            ddlGrupo.DataSource = GestorGrupo.buscarGrupos()
            ddlGrupo.DataBind()

        Catch ex As Exception
            mostrarError(Me, "No se encontró el estudiante y tema especificado.")
        End Try
    End Sub
    ''' <summary>
    ''' Método de clase, encarga de evaluar que no queden espacios en blanco ningún componente
    ''' </summary>
    ''' <returns name="_result">retorna un valor boolean</returns>
    ''' <remarks>Autor:Christopher Vargas</remarks>
    Private Function validar() As Boolean
        Dim _result As Boolean = False

        If gvTema.SelectedIndex = -1 Then
            lblAlert.Text = "Debe seleccionar un tema, es un dato requerido."
            pnlAlert.Visible = True
        ElseIf gvEstudiante.Rows.Count = -1 Then
            lblAlert.Text = "Debe seleccionar un estudiante, es un dato requerido."
            pnlAlert.Visible = True
        Else
            _result = True
        End If
        Return _result

    End Function

    Protected Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If ddlGrupo.Text = "" Then
            lblAlert.Text = "El criterio de busqueda es un dato requerido para poder realizar la búsqueda."
            pnlAlert.Visible = True
        Else

            Dim grupo As Int32 = Convert.ToInt32(ddlGrupo.SelectedValue)

            gvEstudiante.DataSource = GestorUsuario.listarEstudiantesDeGrupo(grupo)
            Me.gvEstudiante.DataBind()

            gvTema.DataSource = GestorTema.listarTemasDeGrupo(grupo)
            Me.gvTema.DataBind()

        End If
    End Sub

    Protected Sub btnAsignar_Click(sender As Object, e As EventArgs) Handles btnAsignar.Click

        Dim _usuario As New Int32
        Dim _tema As New Int32

        If (validar()) = True Then
            _usuario = Convert.ToInt32(Me.gvEstudiante.SelectedValue)
            _tema = Convert.ToInt32(gvTema.SelectedValue)

            Try
                GestorTema.asignarEstudianteATema(_usuario, _tema)
                lblSuccess.Text = "Se ha asignado correctamente el estudiante al tema."
                pnlSuccess.Visible = True
            Catch ex As Exception
                mostrarError(Me, "No se puede asignar el estudiante porque ya está asignado al tema.")
        End Try
        End If
    End Sub
End Class