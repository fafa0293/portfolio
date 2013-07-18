Imports solLogica.Gestor
Public Class frmListarRol
    '' <summary>
    '' Método de la clase encargado de la funcionalidad del boton de modificar
    ''</summary>
    '' <param name="btnModificar_Click"></param>
    '' <remarks>Autor: Fabián Vega Ramírez</remarks>
    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If validarPermiso("modificarRol") = False Then
            Return
        End If

        If validarResul() Then
            Try
                Dim sn As Boolean = False
                Dim form As frmModificarRol = New frmModificarRol(dgResul.Item(0, dgResul.CurrentRow.Index).Value.ToString,
                  dgResul.Item(1, dgResul.CurrentRow.Index).Value.ToString)
                sn = form.ShowDialog()
                If sn = True Then
                    OnLoad(Nothing)
                End If
            Catch ex As Exception
                MessageBox.Show("Debe seleccionar un registro.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        End If
    End Sub
    '' <summary>
    '' Método de la clase encargado de la funcionalidad del boton de eliminar
    ''</summary>
    '' <param name="btnModificar_Click"></param>
    '' <remarks>Autor: Fabián Vega Ramírez</remarks>
    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

        If validarPermiso("eliminarRol") = False Then
            Return
        End If

        If validarResul() Then
            Try
                Dim rol As String
                rol = dgResul.SelectedRows(0).Cells(0).Value
                ''
                Dim button As DialogResult = MessageBox.Show("¿Desea realizar la eliminación del rol?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If button = DialogResult.Yes Then
                    Try
                        GestorRol.eliminarRol(dgResul.SelectedRows(0).Cells(0).Value)
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                    GestorRol.listarRoles()
                End If
                OnLoad(Nothing)
                ''
            Catch ex As Exception
                MessageBox.Show("Debe seleccionar un registro.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            End Try
        End If
    End Sub
    '' <summary>
    '' Método de la clase encargado de la accion de cierre
    ''</summary>
    '' <param name="frmListarRol_FormClosing"></param>
    '' <remarks>Autor: Fabián Vega Ramírez</remarks>
    Private Sub frmListarRol_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Dim button As DialogResult = MessageBox.Show("¿Desea cancelar la búsqueda de los Roles?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If button = DialogResult.Yes Then
            e.Cancel = False
            frmPrincipal.CloseCurrentTab()
        Else
            e.Cancel = True
        End If
    End Sub
    '' <summary>
    '' Método de la clase encargado de la funcionalidad del boton de Cancelar
    ''</summary>
    '' <param name="btnCancelar_Click"></param>
    '' <remarks>Autor: Fabián Vega Ramírez</remarks>
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
    '' <summary>
    '' Método de la clase encargado de la funcionalidad del boton de exportar
    ''</summary>
    '' <param name="btnExportar_Click"></param>
    '' <remarks>Autor: Jonathan Jara </remarks>
    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        If validarResul() Then
            Try
                ExportarDatosExcel(dgResul, "FECHA: " + Now.Date())
            Catch ex As Exception
                MessageBox.Show("No se puede generar el documento Excel.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
    '' <summary>
    '' Metodo para validar que hayan registros cargados.
    '' </summary>
    '' <returns>Valor booleano.</returns>
    '' <remarks>Autor: Fabian Vega</remarks>
    Private Function validarResul()
        If dgResul.Rows.Count > 0 Then
            Return True
        Else
            MessageBox.Show("Debe de realizar una busqueda.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Return False
        End If
    End Function
    '' <summary>
    '' Método de la clase encargada de ejecurtar acciones al ejecutar la ventana
    '' </summary>
    '' <param name="frmListarRol_Load"></param>
    '' <remarks>Autor: Fabián Vega Ramírez</remarks>
    Private Sub frmListarRol_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ''
        Try
            dgResul.DataSource = GestorRol.listarRoles()
        Catch ex As Exception
            Dim ms As DialogResult = MessageBox.Show(ex.Message.ToString, "Registrar", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        ''
    End Sub

    Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim form As frmRegistrarRol = New frmRegistrarRol()
        Dim sn As Boolean = False
        sn = form.ShowDialog()
        If sn = True Then
            OnLoad(Nothing)
        End If

    End Sub

    Private Sub btnAsignarPermisos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsignarPermisos.Click
        If validarPermiso("modificarPermisoRol") = False Then
            Return
        End If

        Dim registroSeleccionado As DataGridViewRow = dgResul.CurrentRow

        If registroSeleccionado Is Nothing Then
            MessageBox.Show("Debe seleccionar un registro.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim frm As frmAsignarPermisosRol = New frmAsignarPermisosRol(registroSeleccionado.Cells(0).Value)
        frm.ShowDialog()
    End Sub
End Class