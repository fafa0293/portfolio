Imports solLogica.Gestor
Imports solLogica.Estructura
Public Class frmBuscarCursoCarrera
    Dim validado As Boolean
    Dim IdCarrera As Integer
    '' <summary>
    '' Método de la clase encargada de cargar las listas de los comboBox
    '' </summary>
    '' <param name="cargarListas"></param>
    '' <remarks>Autor: Fabián Vega Ramírez</remarks>
    Private Sub cargarListas()
        Try
            cmbCarrera.DataSource = GestorCarrera.listarCarreras()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    '' <summary>
    '' Método de la clase encargado de la validacion de los datos
    ''</summary>
    '' <param name="validar"></param>
    '' <remarks>Autor: Fabián Vega Ramírez</remarks>
    Private Sub validar()

        If cmbCarrera.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione el criterio de búsqueda", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cmbCarrera.Focus()
        Else
            validado = True
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
    '' Método de la clase encargado de la funcionalidad del boton de buscar
    ''</summary>
    '' <param name="btnBuscar_Click"></param>
    '' <remarks>Autor: Fabián Vega Ramírez</remarks>
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        validar()
        If validado = True Then
            ''
            Dim carrera As StrCarrera = cmbCarrera.SelectedValue()
            IdCarrera = carrera.IdCarrera
            buscarCursos()
            ''
        End If
    End Sub
   
    '' <summary>
    '' Método de la clase encargada de ejecurtar acciones al ejecutar la ventana
    '' </summary>
    '' <param name="BuscarCursoCarrera_Load"></param>
    '' <remarks>Autor: Fabián Vega Ramírez</remarks>
    Private Sub BuscarCursoCarrera_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarListas()
    End Sub
    '' <summary>
    '' Método de la clase encargado de la funcionalidad del boton de modificar
    ''</summary>
    '' <param name="btnModificar_Click"></param>
    '' <remarks>Autor: Fabián Vega Ramírez</remarks>
    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If validarResul() Then
            Try
                Dim curso As String
                curso = dgResul.SelectedRows(0).Cells(0).Value
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

        If validarPermiso("eliminarGrupo") = False Then
            Return
        End If

        If validarResul() Then
            Try
                Dim button As DialogResult = MessageBox.Show("¿Desea desasignar el curso en esta carrera?", "Desasignar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If button = DialogResult.Yes Then
                    Dim curso As String
                    curso = dgResul.SelectedRows(0).Cells(0).Value
                    GestorCarrera.eliminarAsignacion(curso, IdCarrera)
                    MessageBox.Show("Se ha desasignado el curso con éxito.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    btnBuscar.PerformClick()
                End If
                ''
            Catch ex As Exception
                MessageBox.Show("Debe seleccionar un registro.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        End If
    End Sub
    '' <summary>
    '' Método de la clase encargado de la funcionalidad del boton de exportar
    ''</summary>
    '' <param name="btnExportar_Click"></param>
    '' <remarks>Autor: Jonathan Jara</remarks>
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
    '' Metodo que obtiene los resultados.
    '' </summary>
    '' <returns></returns>
    '' <remarks>Autor: Fabian Vega</remarks>
    Private Sub buscarCursos()
        Try
            dgResul.DataSource = GestorCurso.listarCursosPorCarreraId(IdCarrera)
        Catch ex As Exception
            Dim ms As DialogResult = MessageBox.Show(ex.Message.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class