Imports solLogica.Gestor
Imports solLogica.Estructura


Public Class frmAsignarEstudianteGrupo

    Private Sub frmAsignarEstudianteGrupo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarListas()

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Dim _result As DialogResult

        _result = MessageBox.Show("¿Está seguro que desea cancelar la asignación del estudiante al grupo?", "Asignar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, 0, False)

        Try
            If _result = Windows.Forms.DialogResult.Yes Then
                Me.Close()
                frmPrincipal.CloseCurrentTab()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub bntBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bntBuscar.Click
        If cbCurso.Text = "" Then
            MsgBox("El criterio de busqueda es un dato requerido para poder realizar la busqueda.", MsgBoxStyle.Information, "Asignar")
            cbCurso.Focus()
        Else
            lbGrupos.DisplayMember = "Nombre"
            lbGrupos.ValueMember = "IdGrupo"
            lbGrupos.DataSource = GestorGrupo.listarGruposPorCursoId(cbCurso.SelectedValue().IdCurso)
        End If
    End Sub
    ''' <summary>
    ''' </summary>
    ''' <remarks>Autor:Christopher Vargas</remarks>
    Private Sub cargarListas()
        Try
            cbCurso.DataSource = GestorCurso.listarCursos()

            dgvEstudiantes.AutoGenerateColumns = False
            dgvEstudiantes.DataSource = GestorUsuario.listarTodosUsuariosEst()

        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnAsignar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsignar.Click


        Dim usuario As Integer
        Dim _result As DialogResult = validar()

        usuario = dgvEstudiantes.CurrentRow().Cells(0).Value

        If _result = True Then

            _result = MessageBox.Show("¿Está seguro que desea realizar la asignacion del estudiante al grupo?", "Asignar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, 0, False)

            Try
                If _result = Windows.Forms.DialogResult.Yes Then
                    GestorGrupo.asignarEstudianteAGrupo(usuario, lbGrupos.SelectedValue())
                    MsgBox("Se ha hecho la asignación exitosamente.", MsgBoxStyle.Information, "Asignar")

                Else
                    MsgBox("No se ha asignado el estudiante.", MsgBoxStyle.Information, "Asignar")
                End If
            Catch ex As Exception
                MsgBox("Los datos seleccionados para la asignación ya estan asignados en la base de datos.", MsgBoxStyle.Information, "Asignar")
            End Try
        End If
    End Sub
    ''' <summary>
    ''' Método de clase, encarga de evaluar que no queden espacios en blanco ningún componente
    ''' </summary>
    ''' <returns name="_result">retorna un valor boolean</returns>
    ''' <remarks>Autor:Christopher Vargas</remarks>
    Private Function validar()
        Dim _result As Boolean = False

        If lbGrupos.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar un grupo, es un dato requerido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        ElseIf dgvEstudiantes.RowCount = -1 Then
            MessageBox.Show("Debe seleccionar un estudiante, es un dato requerido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Hand)

        Else
            _result = True
        End If
        Return _result

    End Function
End Class