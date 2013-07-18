Imports System
Imports solLogica.Gestor
Imports solLogica.Estructura

Public Class AsignarProfeAGrupo
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ModuloUtilitario.iniciarSesion(Me)
        If GestorSesion.usuarioTienePermiso("asignarProfesorGrupo") = False Then
            mostrarError(Me, "Usted no cuenta con los permisos necesarios para acceder a esta página.")
        End If

        Page.Title = generarTitulo("Asignar Profesor A Grupo")

        pnlAlert.Visible = False
        pnlSuccess.Visible = False
        lblAlert.Text = ""
        lblSuccess.Text = ""

        If Not IsPostBack Then
            cargarListas()

        End If
    End Sub

    Protected Sub btnAsignar_Click(sender As Object, e As EventArgs) Handles btnAsignar.Click
        Dim _usuario As New Int32
        Dim _grupo As New Int32

        If (validar()) = True Then
            'a = Me.gvEstudiantes.SelectedValue
            _usuario = Convert.ToInt32(Me.gvProfesor.SelectedValue)
            _grupo = Convert.ToInt32(gvGrupos.SelectedValue)
            Try
                GestorGrupo.asignarProfesorAGrupo(_usuario, _grupo)
                lblSuccess.Text = "Se ha asignado correctamente el profesor al grupo."
                pnlSuccess.Visible = True
            Catch ex As Exception
                mostrarError(Me, "No se puede asignar el profesor porque ya está asignado al grupo.")
            End Try
        End If
    End Sub

    Protected Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If ddlCurso.Text = "" Then
            lblAlert.Text = "El criterio de busqueda es un dato requerido para poder realizar la búsqueda."
            pnlAlert.Visible = True

        Else
            Try
                Dim _curso As New Integer

                _curso = CInt(ddlCurso.SelectedValue)
                gvGrupos.DataSource = GestorGrupo.listarGruposPorCursoId(_curso)
                gvGrupos.DataBind()
            Catch ex As Exception
                mostrarError(Me, "No se encontro el grupo con el curso seleccionado")
            End Try
        End If
    End Sub
    ''' <summary>
    ''' Método de clase, encarga de evaluar que se seleccione un grupo y profesor
    ''' </summary>
    ''' <returns name="_result">retorna un valor boolean</returns>
    ''' <remarks>Autor:Christopher Vargas</remarks>
    Private Function validar() As Boolean
        Dim _result As Boolean = False

        If gvGrupos.SelectedIndex = -1 Then
            lblAlert.Text = "Debe seleccionar un grupo, es un dato requerido."
            pnlAlert.Visible = True
        ElseIf gvProfesor.Rows.Count = -1 Then
            lblAlert.Text = "Debe seleccionar un Profesor, es un dato requerido."
            pnlAlert.Visible = True
        Else
            _result = True
        End If
        Return _result

    End Function

    ''' <summary>
    ''' Metodo que carga las listas
    ''' </summary>
    ''' <remarks>Autor:Christopher Vargas</remarks>
    Private Sub cargarListas()
        Try
            ddlCurso.DataSource = GestorCurso.listarCursos()
            ddlCurso.DataBind()

            gvProfesor.AutoGenerateColumns = False
            gvProfesor.DataSource = GestorUsuario.buscarUsuarioPorRol("Profesor")
            gvProfesor.DataBind()


        Catch ex As Exception
            mostrarError(Me, "No se Cargaron las listas correctamente")
        End Try
    End Sub
End Class