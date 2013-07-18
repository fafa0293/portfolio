Imports solLogica.Gestor
Imports solLogica.Estructura
Imports System


Public Class AsignarEstudianteAGrupo
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ModuloUtilitario.iniciarSesion(Me)
        If GestorSesion.usuarioTienePermiso("asignarEstudianteGrupo") = False Then
            mostrarError(Me, "Usted no cuenta con los permisos necesarios para acceder a esta página.")
        End If

        Page.Title = generarTitulo("Asignar Estudiante A Grupo")

        pnlAlert.Visible = False
        pnlSuccess.Visible = False

        lblAlert.Text = ""
        lblSuccess.Text = ""

        If Not IsPostBack Then
            cargarListas()

        End If
    End Sub

    ''' <summary>
    ''' Metodo que carga las listas
    ''' </summary>
    ''' <remarks>Autor:Christopher Vargas</remarks>
    Private Sub cargarListas()
        Try
            ddlCurso.DataSource = GestorCurso.listarCursos()
            ddlCurso.DataBind()

            gvEstudiantes.AutoGenerateColumns = False
            gvEstudiantes.DataSource = GestorUsuario.listarTodosUsuariosEst()
            gvEstudiantes.DataBind()


        Catch ex As Exception
            mostrarError(Me, "No se Cargaron las listas correctamente")
        End Try
    End Sub

    ''' <summary>
    ''' Método de clase, encarga de evaluar que se seleccione un grupo y estudiante
    ''' </summary>
    ''' <returns name="_result">retorna un valor boolean</returns>
    ''' <remarks>Autor:Christopher Vargas</remarks>
    Private Function validar() As Boolean
        Dim _result As Boolean = False

        If gvGrupos.SelectedIndex = -1 Then
            lblAlert.Text = "Debe seleccionar un grupo, es un dato requerido."
            pnlAlert.Visible = True
        ElseIf gvEstudiantes.Rows.Count = -1 Then
            lblAlert.Text = "Debe seleccionar un estudiante, es un dato requerido."
            pnlAlert.Visible = True
        Else
            _result = True
        End If
        Return _result

    End Function


    Protected Sub btnAsignar_Click(sender As Object, e As EventArgs) Handles btnAsignar.Click

        Dim _usuario As New Int32
        Dim _grupo As New Int32
        'Dim a As Object

        

        If (validar()) = True Then
            'a = Me.gvEstudiantes.SelectedValue
            _usuario = Convert.ToInt32(Me.gvEstudiantes.SelectedValue)
            _grupo = Convert.ToInt32(gvGrupos.SelectedValue)
            Try
                GestorGrupo.asignarEstudianteAGrupo(_usuario, _grupo)
                lblSuccess.Text = "Se ha asignado correctamente el estudiante al grupo."
                pnlSuccess.Visible = True
            Catch ex As Exception
                mostrarError(Me, "No se puede asignar el estudiante porque ya está asignado al grupo.")
            End Try
        End If
    End Sub

    Protected Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If ddlCurso.Text = "" Then
            lblAlert.Text = "El criterio de busqueda es un dato requerido para poder realizar la búsqueda."
            pnlAlert.Visible = True
           
        Else
            Dim _curso As New Integer

            _curso = CInt(ddlCurso.SelectedValue)
            gvGrupos.DataSource = GestorGrupo.listarGruposPorCursoId(_curso)
            gvGrupos.DataBind()

        End If

    End Sub
End Class