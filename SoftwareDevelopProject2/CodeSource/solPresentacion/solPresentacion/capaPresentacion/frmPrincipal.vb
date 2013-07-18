'' <summary>
'' Formulario Principal: Formulario Principal de la aplicacion 
'' Debe de heredar del formulario padre
'' </summary>
'' <remarks>Autor: Jonathan Jara Morales/remarks>
Imports solLogica.Gestor
Public Class frmPrincipal
    Inherits frmPadre

    '' <summary>
    '' Metodo showForm: Se encarga de mostra en pantalla el formulario respectivo
    '' </summary>
    '' <param name="formulario"></param>
    '' <remarks>Autor: Jonathan Jara Morales</remarks>
    Private Sub mostrarFormulario(ByVal formulario As Integer, ByVal nodoPrincipal As Integer)
        Dim r As New Random()
        Static i As Integer
        i += 1
        Dim key As String = "f" + i.ToString()

        Dim f = crearFormulario(formulario, nodoPrincipal)

        'Crea el tab que lo contiene
        Me.ExtendedTabControl1.TabPages.Add(key, f.Text)
        f.TopLevel = False
        f.Dock = DockStyle.Fill
        Me.ExtendedTabControl1.TabPages(key).Controls.Add(f)
        ''ExtendedTabControl1.HideTabPage(Me.ExtendedTabControl1); 
        ''TAB().HideTabPage(Me.ExtendedTabControl1)

        'Crea el nuevo form
        f.Text = String.Format(" ", i)

        'asigna el menu contextual
        Me.ExtendedTabControl1.ContextMenuStrip = cmenu
        Me.ExtendedTabControl1.TabPages(key).ContextMenuStrip = cmenu
        Me.ExtendedTabControl1.SelectedTab = Me.ExtendedTabControl1.TabPages(key)

        'Asigna el nuevo form al tag del tabpage
        Me.ExtendedTabControl1.TabPages(key).Tag = f

        'Por si desde el propio form quieres cerrar y eliminar el tab
        f.Tag = Me.ExtendedTabControl1.TabPages(key)
        f.Show()


    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        CloseCurrentTab()
    End Sub

    Public Sub CloseCurrentTab()
        If Me.ExtendedTabControl1.TabPages.Count = 0 Then Exit Sub
        ''CType(Me.ExtendedTabControl1.SelectedTab.Tag, Form).Close()
        Me.ExtendedTabControl1.TabPages.Remove(Me.ExtendedTabControl1.SelectedTab)
    End Sub

    Private Sub mclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mclose.Click
        CloseCurrentTab()
    End Sub

    Private Sub mcloseallbutthis_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mcloseallbutthis.Click
        For Each t As TabPage In Me.ExtendedTabControl1.TabPages
            If Not Me.ExtendedTabControl1.SelectedTab Is t Then
                CType(t.Tag, Form).Close()
                Me.ExtendedTabControl1.TabPages.Remove(t)
            End If
        Next
    End Sub

    '' <summary>
    '' crearFormulario: Se encarga de crear los distintos tipos de formularios a utilizar
    '' </summary>
    '' <param name="opcion"></param>
    '' <returns name="System.Windows.Forms.Form">Retorna un formulario</returns>
    '' <remarks>Autor: Jonathan Jara Morales</remarks>

    ''Recordar pasar a un switch
    Private Function crearFormulario(ByVal opcion As Integer, ByVal nodoPrincipal As Integer) As System.Windows.Forms.Form


        If nodoPrincipal = 0 Then ''Usuarios
            Return (crearFormulariosUsuario(opcion))

        End If

        If nodoPrincipal = 1 Then ''Carreras
            Return (crearFormulariosCarrera(opcion))
        End If

        If nodoPrincipal = 2 Then ''Cursos
            Return (crearFormulariosCursos(opcion))
        End If

        If nodoPrincipal = 3 Then ''Grupos
            Return (crearFormulariosGrupo(opcion))
        End If

        If nodoPrincipal = 4 Then ''Tema
            ''Return (crearFormulariosTema(opcion))
        End If

        If nodoPrincipal = 5 Then ''Permiso
            Return (crearFormulariosPermiso(opcion))
        End If

        If nodoPrincipal = 6 Then ''Rol
            Return (crearFormulariosRol(opcion))
        End If

        If nodoPrincipal = 7 Then ''Asignar
            Return (crearFormulariosAsignar(opcion))
        End If

        If nodoPrincipal = 8 Then ''Ayuda
            Return (crearFormulariosAyuda(opcion))
        End If

        If nodoPrincipal = 9 Then ''Cerrar Sesion
            Return (cerrarSesion(opcion))
        End If


        Return Nothing
    End Function

    Private Sub cambiarTituloDescripcion(ByVal titulo As String, ByVal descripcion As String)
        setTitulo(titulo)
        setDescripcion(descripcion)
    End Sub

    Private Sub frmPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cambiarTituloDescripcion("StarSolutionCommunity", "Bienvenido, " & GestorSesion.getNombreCompletoUsuario())
        Me.Show()
    End Sub

    Private Sub ExtendedTabControl1_ControlRemoved(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ControlEventArgs) Handles ExtendedTabControl1.ControlRemoved
        CloseCurrentTab()
    End Sub

    Private Sub TreeView_NodeMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles TreeViewPrincipal.NodeMouseDoubleClick
        Dim nodoPrincipal As String
        Dim nodoSecundario As Integer

        Try
            nodoPrincipal = e.Node.Parent.Index
            nodoSecundario = e.Node.Index
            mostrarFormulario(nodoSecundario, nodoPrincipal)
        Catch ex As Exception
        End Try
    End Sub

    Private Function crearFormulariosUsuario(ByVal opcion As Integer) As Object

        If opcion = 0 Then
            Return frmRegistrarUsuario
        End If

        If opcion = 1 Then
            Return frmBuscarUsuarios
        End If

        If opcion = 2 Then
            Return frmRegistrarUsuarioTxt
        End If
        Return Nothing

    End Function

    Private Function crearFormulariosCarrera(ByVal opcion As Integer) As Object

        If opcion = 0 Then
            Return frmRegistrarCarrera
        End If

        If opcion = 1 Then
            Return frmBuscarCarrera
        End If


        If opcion = 2 Then
            Return frmBuscarDirectorAcademicoCarrera
        End If

        If opcion = 3 Then
            Return frmAsignarCursoCarrera
        End If

        If opcion = 4 Then
            Return frmAsignarDirectorAcademicoCarrera
        End If

        Return Nothing

    End Function

    Private Function crearFormulariosCursos(ByVal opcion As Integer) As Form

        If opcion = 0 Then
            Return frmRegistrarCurso
        End If

        If opcion = 1 Then
            Return frmBuscarCurso
        End If

        If opcion = 2 Then
            Return frmBuscarCursoCarrera
        End If

        If opcion = 3 Then
            Return frmRegistrarCursosBatch
        End If

        Return Nothing
    End Function

    Private Function crearFormulariosGrupo(ByVal opcion As Integer) As Form
        If opcion = 0 Then
            Return frmRegistrarGrupo
        End If

        If opcion = 1 Then
            Return frmBuscarGrupo
        End If

        If opcion = 2 Then
            Return frmBuscarGruposCurso
        End If

        If opcion = 3 Then
            Return frmBuscarEstudiantesGrupo
        End If

        If opcion = 4 Then
            Return frmBuscarProfesorAsociadoGrupo
        End If

        If opcion = 5 Then
            Return frmAsignarEstudianteGrupo
        End If


        If opcion = 6 Then
            Return frmAsignarProfesor
        End If

        If opcion = 7 Then
            Return frmListarForos
        End If


        Return Nothing
    End Function


    Private Function crearFormulariosPermiso(ByVal opcion As Integer) As Form
        If opcion = 0 Then
            Return frmListarPermisos
        End If

        Return Nothing
    End Function

    Private Function crearFormulariosRol(ByVal opcion As Integer) As Form
        If opcion = 0 Then
            Return frmRegistrarRol
        End If

        If opcion = 1 Then
            Return frmListarRol
        End If


        If opcion = 2 Then
            Return frmAsignarRolAUsuario
        End If

        Return Nothing
    End Function

    Private Function crearFormulariosAsignar(ByVal opcion As Integer) As Form
        If opcion = 0 Then
            Return frmAsignarEstudianteGrupo
        End If

        If opcion = 1 Then
            Return frmAsignarProfesor
        End If

        If opcion = 2 Then
            Return frmAsignarEstudianteTema
        End If

        If opcion = 3 Then
            Return frmAsignarCursoCarrera
        End If

        If opcion = 4 Then
            Return frmAsignarDirectorAcademicoCarrera
        End If

        If opcion = 5 Then
            Return frmAsignarRolAUsuario
        End If



        Return Nothing
    End Function

    Private Function crearFormulariosAyuda(ByVal opcion As Integer) As Form
        If opcion = 0 Then
            Return frmAyuda
        End If

        If opcion = 1 Then
             Return frmAyuda
        End If

        Return Nothing
    End Function

    Private Function cerrarSesion(ByVal opcion As Integer) As Form
        If opcion = 0 Then
            GestorSesion.cerrarSesion() ''Cierra la sesion activa
            Me.Hide() ''Se debe oculatar
            frmInicioSesion.Show() ''Muestra el formulario de inicio
            TreeViewPrincipal.SelectedNode = TreeViewPrincipal.Nodes(0) ''Selecciona por default el primer nodo
            TreeViewPrincipal.CollapseAll() '' Cierra Todos los nodos abiertos en la sesion anterios
        End If

        Return Nothing
    End Function


    Private Sub TreeViewPrincipal_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeViewPrincipal.AfterSelect

    End Sub
End Class
