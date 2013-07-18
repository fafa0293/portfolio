Imports solLogica.Gestor

Public Class frmListarPermisos

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If validarResul() Then
            Try
                Dim rol As String
                rol = dgResul.SelectedRows(0).Cells(0).Value
            Catch ex As Exception
                MessageBox.Show("Debe seleccionar un registro.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        End If
    End Sub

    Private Function validarResul() As Boolean
        If dgResul.Rows.Count > 0 Then
            Return True
        Else
            MessageBox.Show("Debe de seleccionar un registro.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Return False
        End If
    End Function

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If validarResul() Then
            Try
                Dim rol As String
                rol = dgResul.SelectedRows(0).Cells(0).Value
                Dim button As DialogResult = MessageBox.Show("¿Desea realizar la eliminación del permiso?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If button = DialogResult.Yes Then
                    dgResul.Rows.Remove(dgResul.CurrentRow)
                End If
            Catch ex As Exception
                MessageBox.Show("Debe seleccionar un registro.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        End If
    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        If validarResul() Then
            Try
                ExportarDatosExcel(dgResul, "FECHA: " + Now.Date())
            Catch ex As Exception
                MessageBox.Show("No se puede generar el documento Excel.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If frmRegistrarRol.ShowDialog() Then
            OnLoad(Nothing)
        End If
    End Sub

    Private Sub frmListarPermisos_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Dim button As DialogResult = MessageBox.Show("¿Desea cancelar la búsqueda de los permisos?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If button = DialogResult.Yes Then
            e.Cancel = False
            frmPrincipal.CloseCurrentTab()
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub frmListarPermisos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            dgResul.DataSource = GestorPermiso.listarPermiso()
        Catch ex As Exception
            MsgBox("Error: " & ex.ToString(), MsgBoxStyle.Information, "Error")
        End Try
    End Sub
End Class