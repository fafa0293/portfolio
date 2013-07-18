Imports solLogica.Gestor
Public Class frmListarForos
    '' <summary>
    '' Agrega tema al foro seleccionado
    ''</summary>
    '' <param name="btnAgregarTema_Click"></param>
    '' <remarks>Autor: Fabián Vega Ramírez</remarks>
    Private Sub btnAgregarTema_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarTema.Click
        If validarResul() Then
            Try
                Dim sn As Boolean = False
                Dim form As frmAgregarTema = New frmAgregarTema(dgResul.SelectedRows(0).Cells(0).Value)
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
    '' Método de la clase encargado de la accion de cierre
    ''</summary>
    '' <param name="frmListarRol_FormClosing"></param>
    '' <remarks>Autor: Fabián Vega Ramírez</remarks>
    Private Sub frmListarRol_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Dim button As DialogResult = MessageBox.Show("¿Desea cancelar la búsqueda de los Foros?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
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
            MessageBox.Show("El usuario no posee foros.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Return False
        End If
    End Function
    '' <summary>
    '' Método de la clase encargada de ejecurtar acciones al ejecutar la ventana
    '' </summary>
    '' <param name="frmListarForos_Load"></param>
    '' <remarks>Autor: Fabián Vega Ramírez</remarks>
    Private Sub frmListarForos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ''
        Try
            dgResul.DataSource = GestorForo.listarForosPorUsuarioLog()
        Catch ex As Exception
            Dim ms As DialogResult = MessageBox.Show(ex.Message.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        ''
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If validarResul() Then
            Try
                Dim form As frmBuscarTema = New frmBuscarTema(dgResul.Item(0, dgResul.CurrentRow.Index).Value)
                form.ShowDialog()
            Catch ex As Exception
                MessageBox.Show("Debe seleccionar un registro." & ex.Message.ToString(), "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        End If
    End Sub
End Class