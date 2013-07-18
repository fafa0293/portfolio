'' <summary>
'' Formulario Buscar Usuarios: Realiza una busqueda de los usuarios
'' </summary>
'' <remarks>Autor: Jonathan Jara Morales/remarks>
Imports solLogica.Gestor

Public Class frmBuscarUsuarios

    Private Sub frmBuscarUsuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarListas()
        rbdTodos.Checked = True
    End Sub

    '' <summary>
    '' cargarListas: Carga la Lista para el comboBox
    '' </summary>
    '' <remarks>Autor: Jonathan Jara Morales</remarks>
    Private Sub cargarListas()
        Try
            cmbRol.DataSource = GestorRol.listarRoles()
            cmbRol.ValueMember = "Nombre"
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If validarBotonesRadio() Then
            If validarComboBox() Then
                realizarBusquedas()
            Else
                MessageBox.Show("Debe ingresar un registro.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            seleccionarTodosUsuarios()
        End If

    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Function validarBotonesRadio() As Boolean
        If rdbNombre.Checked Then
            Return True
        End If

        If rdbCedula.Checked Then
            Return True
        End If

        If rdbRol.Checked Then
            Return True
        End If

        If rbdTodos.Checked Then
            Return True
        End If

        Return False
    End Function

    Private Function validarComboBox() As Boolean
        If rdbCedula.Checked Then
            If txtCedula.Text.Trim.Length = 0 Then
                txtCedula.Focus()
                Return False
            End If
        End If

        If rdbRol.Checked Then
            If cmbRol.SelectedIndex = -1 Then
                cmbRol.Focus()
                Return False
            End If
        End If

        Return True
    End Function

    Private Sub realizarBusquedas()
        If rdbNombre.Checked Then
            Try
                dgDatosUsuario.AutoGenerateColumns = False
                dgDatosUsuario.DataSource = GestorUsuario.buscarUsuarioPorNombre(txtNombre.Text)
            Catch ex As Exception
                MsgBox("Error: " & ex.ToString(), MsgBoxStyle.Information, "Error")
            End Try
            txtNombre.Focus()
        End If


        If rdbCedula.Checked Then
            Try
                dgDatosUsuario.AutoGenerateColumns = False
                dgDatosUsuario.DataSource = GestorUsuario.buscarUsuarioPorCedula(txtCedula.Text)
            Catch ex As Exception
                MsgBox("Error: " & ex.ToString(), MsgBoxStyle.Information, "Error")
            End Try
            txtCedula.Focus()
        End If

        If rdbRol.Checked Then
            Try
                dgDatosUsuario.AutoGenerateColumns = False
                dgDatosUsuario.DataSource = GestorUsuario.buscarUsuarioPorRol(cmbRol.SelectedValue)
            Catch ex As Exception
                MsgBox("Error: " & ex.ToString(), MsgBoxStyle.Information, "Error")
            End Try
            txtCedula.Focus()
        End If

        If rbdTodos.Checked Then
            seleccionarTodosUsuarios()
        End If
    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click

        Try
            'Intentar generar el documento.
            'Se adjunta un texto debajo del encabezado con la fecha actual del sistema.
            ExportarDatosExcel(dgDatosUsuario, "FECHA: " + Now.Date())
        Catch ex As Exception
            'Si el intento es fallido, mostrar MsgBox.
            MessageBox.Show("No se puede generar el documento Excel.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim titulo As String = "Eliminar Usuario"
        Dim registroSeleccionado As DataGridViewRow = dgDatosUsuario.CurrentRow

        If validarPermiso("eliminarUsuario") = False Then
            Return
        End If

        If registroSeleccionado Is Nothing Then
            MessageBox.Show("Debe seleccionar un registro.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' insertar codigo de obtener id de carrera aqui
        Dim dresult As DialogResult = MessageBox.Show("¿Desea realizar la eliminación del usuario?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        Try
            If dresult = Windows.Forms.DialogResult.Yes Then
                ' insertar codigo de eliminar aqui
                GestorUsuario.eliminarUsuario(registroSeleccionado.Cells(0).Value)
                btnBuscar.PerformClick()
                MessageBox.Show("Se ha eliminado el usuario.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmRegistrarUsuario.ShowDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim registroSeleccionado As DataGridViewRow = dgDatosUsuario.CurrentRow()

        If validarPermiso("modificarUsuario") = False Then
            Return
        End If

        If registroSeleccionado Is Nothing Then
            MessageBox.Show("Debe seleccionar un registro.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim idUsuario As Integer = registroSeleccionado.Cells(0).Value
        Dim contrasenna As String = registroSeleccionado.Cells(1).Value
        Dim nombre As String = registroSeleccionado.Cells(2).Value
        Dim apellido1 As String = registroSeleccionado.Cells(3).Value
        Dim apellido2 As String = registroSeleccionado.Cells(4).Value
        Dim cedula As String = registroSeleccionado.Cells(5).Value
        Dim carnet As String = registroSeleccionado.Cells(6).Value
        Dim genero As String = registroSeleccionado.Cells(7).Value
        Dim correoElectronico As String = registroSeleccionado.Cells(8).Value
        Dim fechaNacimiento As String = registroSeleccionado.Cells(9).Value
        Dim direccion As String = registroSeleccionado.Cells(10).Value
        Dim telefonoFijo As String = registroSeleccionado.Cells(11).Value
        Dim telefonoCelular As String = registroSeleccionado.Cells(12).Value

        Dim frm As frmModificarUsuario = New frmModificarUsuario(
                                         idUsuario, nombre, apellido1, apellido2,
                                         carnet, cedula, genero, correoElectronico,
                                         fechaNacimiento, direccion, telefonoFijo, telefonoCelular,
                                         contrasenna)

        If frm.ShowDialog() Then
            btnBuscar.PerformClick()
        End If

    End Sub

    Private Sub seleccionarTodosUsuarios()
        Try
            dgDatosUsuario.AutoGenerateColumns = False
            dgDatosUsuario.DataSource = GestorUsuario.buscarTodosUsuarios()
        Catch ex As Exception
            MsgBox("Error: " & ex.ToString(), MsgBoxStyle.Information, "Error")
        End Try
        txtCedula.Focus()
    End Sub


    Private Sub rdbNombre_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbNombre.CheckedChanged
        If rdbNombre.Checked = True Then
            txtNombre.Enabled = True
        Else
            txtNombre.Enabled = False
            txtNombre.Text = ""
        End If
    End Sub



    Private Sub rdbCedula_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbCedula.CheckedChanged
        If rdbCedula.Checked = True Then
            txtCedula.Enabled = True
        Else
            txtCedula.Enabled = False
            txtCedula.Text = ""
        End If
    End Sub

    Private Sub btnBitacora_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBitacora.Click
        Dim registroSeleccionado As DataGridViewRow = dgDatosUsuario.CurrentRow()

        If validarPermiso("mostrarBitacora") = False Then
            Return
        End If

        If registroSeleccionado Is Nothing Then
            MessageBox.Show("Debe seleccionar un registro.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim idUsuario As Integer = registroSeleccionado.Cells(0).Value
        Dim frmMostrarBitacora As frmMostrarBitacora = New frmMostrarBitacora(idUsuario)
        frmMostrarBitacora.Show()
    End Sub

End Class