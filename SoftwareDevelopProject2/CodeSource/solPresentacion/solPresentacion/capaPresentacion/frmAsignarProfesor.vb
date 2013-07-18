'' <summary>
'' Formulario Asignar Profesor: Asigna un profesor a un grupo
'' </summary>
'' <remarks>Autor: Jonathan Jara Morales/remarks>
Imports solLogica.Gestor
Imports solLogica.Estructura
Public Class frmAsignarProfesor
    Dim idCurso As Integer
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Dim curso As StrCurso = cmbCurso.SelectedValue()
        idCurso = curso.IdCurso
        If validar() Then
            Try
                dgResul.DataSource = GestorGrupo.listarGruposPorCursoId(idCurso)
            Catch ex As Exception
                Dim ms As DialogResult = MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    '' <summary>
    '' validar: Valida que se encuentre selecciona un registro en el comboBox
    '' </summary>
    '' <remarks>Autor: Jonathan Jara Morales</remarks>
    Private Function validar()
        If cmbCurso.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione el criterio de búsqueda", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cmbCurso.Focus()
            Return False
        End If


        Return True
    End Function


    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub frmAsignarProfesor_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Dim button As DialogResult = MessageBox.Show("¿Desea cancelar la asignación?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If button = DialogResult.Yes Then
            e.Cancel = False
            frmPrincipal.CloseCurrentTab()
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub frmAsignarProfesor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarListas()
        buscarUsuarios()
    End Sub

    '' <summary>
    '' cargarListas: Carga la Lista de los cursos
    '' </summary>
    '' <remarks>Autor: Jonathan Jara Morales</remarks>
    Private Sub cargarListas()
        Try
              cmbCurso.DataSource = GestorCurso.listarCursos()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub buscarUsuarios()
        Try
            dgDatosUsuario.AutoGenerateColumns = False
            dgDatosUsuario.DataSource = GestorUsuario.buscarUsuarioPorRol("Profesor")
        Catch ex As Exception
            MsgBox("Error: " & ex.ToString(), MsgBoxStyle.Information, "Error")
        End Try
        cmbCurso.Focus()
    End Sub

    Private Sub btnAsignar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsignar.Click
        Dim _result As DialogResult

        Dim usuario As Int16
        Dim grupo As Int16
        _result = validar()

        If _result = True Then

            If dgResul.RowCount = 0 Then
                MessageBox.Show("Seleccione el grupo", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If

            _result = MessageBox.Show("¿Está seguro que desea realizar la asignacion del profesor al grupo?", "Asignar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, 0, False)

            Try


                usuario = dgDatosUsuario.CurrentRow().Cells(0).Value
                grupo = dgResul.CurrentRow().Cells(2).Value

                If _result = Windows.Forms.DialogResult.Yes Then
                    GestorGrupo.asignarProfesorAGrupo(usuario, grupo)
                    MsgBox("Se ha hecho la asignación exitosamente.", MsgBoxStyle.Information, "Asignar")

                Else
                    MsgBox("No se ha asignado el profesor.", MsgBoxStyle.Information, "Asignar")
                End If
            Catch ex As Exception
                MsgBox("Los datos seleccionados para la asignación ya estan asignados en la base de datos.", MsgBoxStyle.Information, "Asignar")
            End Try
        End If
    End Sub

    Private Sub gbProfesor_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbProfesor.Enter

    End Sub
End Class