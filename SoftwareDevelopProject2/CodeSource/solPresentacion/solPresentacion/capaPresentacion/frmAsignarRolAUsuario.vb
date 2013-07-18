Imports solLogica.Gestor
Imports solLogica.Estructura

Public Class frmAsignarRolAUsuario

    Private Sub frmAsignarRolAUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarListas()

    End Sub

    ''' <summary>
    ''' Método de clase, encarga de cargar las listas
    ''' </summary>
    ''' <remarks>Autor:Christopher Vargas</remarks>
    Private Sub cargarListas()
        Try
            lbRol.DataSource = GestorRol.listarRoles()
            dgvUsuario.AutoGenerateColumns = False
            dgvUsuario.DataSource = GestorUsuario.buscarTodosUsuarios()

        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Dim _result As DialogResult

        _result = MessageBox.Show("¿Está seguro que desea cancelar la asignación del rol al usuario?", "Asignar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, 0, False)

        Try
            If _result = Windows.Forms.DialogResult.Yes Then
                Me.Close()
                frmPrincipal.CloseCurrentTab()
            End If
        Catch ex As Exception
        End Try
    End Sub

    ''' <summary>
    ''' Método de clase, encarga de evaluar que no queden espacios en blanco ningún componente
    ''' </summary>
    ''' <returns name="_result">retorna un valor boolean</returns>
    ''' <remarks>Autor:Christopher Vargas</remarks>
    Private Function validar()
        Dim _result As Boolean = False

        If lbRol.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar un rol, es un dato requerido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        ElseIf dgvUsuario.RowCount = -1 Then
            MessageBox.Show("Debe seleccionar un usuario, es un dato requerido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Hand)

        Else
            _result = True
        End If
        Return _result

    End Function

    Private Sub btnAsignar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsignar.Click

        Dim _result As DialogResult
        Dim rol As StrRol = lbRol.SelectedValue()

        Dim usuario As Int16
        _result = validar()

        If validarPermiso("asignarRolUsuario") = False Then
            Return
        End If

        usuario = dgvUsuario.CurrentRow().Cells(0).Value

        If _result = True Then

            _result = MessageBox.Show("¿Está seguro que desea realizar la asignacion del rol al Usuario?", "Asignar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, 0, False)

            Try
                If _result = Windows.Forms.DialogResult.Yes Then
                    GestorRol.asignarRolAUsuario(usuario, rol.IdRol)
                    MsgBox("Se ha hecho la asignación exitosamente.", MsgBoxStyle.Information, "Asignar")

                Else
                    MsgBox("No se ha asignado el estudiante.", MsgBoxStyle.Information, "Asignar")
                End If
            Catch ex As Exception
                MsgBox("Los datos seleccionados para la asignación ya estan asignados en la base de datos.", MsgBoxStyle.Information, "Asignar")
            End Try
        End If
    End Sub
End Class