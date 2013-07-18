Imports solLogica.Gestor
Imports solLogica.Estructura
Public Class frmAsignarCursoCarrera
    Dim isDataSaved As Boolean
    Dim validado As Boolean
    '' <summary>
    '' Método de la clase encargada de ejecurtar acciones al ejecutar la ventana
    '' </summary>
    '' <param name="aCursoCarrera_Load"></param>
    '' <remarks>Autor: Fabián Vega Ramírez</remarks>
    Private Sub aCursoCarrera_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarListas()
    End Sub
    '' <summary>
    '' Método de la clase encargada de cargar las listas de los comboBox
    '' </summary>
    '' <param name="cargarListas"></param>
    '' <remarks>Autor: Fabián Vega Ramírez</remarks>
    Private Sub cargarListas()
        Try
            cmbCarrera.DataSource = GestorCarrera.listarCarreras()
            cmbCurso.DataSource = GestorCurso.listarCursos()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    '' <summary>
    '' Método de la clase encargada de la funionalidad del boton de asignar
    '' </summary>
    '' <param name="btnAsignar_Click"></param>
    '' <remarks>Autor: Fabián Vega Ramírez</remarks>
    Private Sub btnAsignar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsignar.Click
        validar()
        If validado = True Then
            Dim button As DialogResult = MessageBox.Show("¿Desea realizar la asignación?", "Asignar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If button = DialogResult.Yes Then
                Try
                    Dim carrera As StrCarrera = cmbCarrera.SelectedValue()
                    Dim curso As StrCurso = cmbCurso.SelectedValue()
                    GestorCarrera.asignarCursoACarrera(curso.IdCurso, carrera.IdCarrera)
                    Dim button4 As DialogResult = MessageBox.Show("¡Asignación registrada exitosamente!", "Asignar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    isDataSaved = True
                    Me.Close()
                Catch ex As Exception
                    MsgBox("Los datos seleccionados para la asignación ya existen en la base de datos.", MsgBoxStyle.Information)
                End Try
                
            End If
        End If
    End Sub
    '' <summary>
    '' Método de la clase encargado de la validacion de los datos
    ''</summary>
    '' <param name="validar"></param>
    '' <remarks>Autor: Fabián Vega Ramírez</remarks>
    Private Sub validar()

        If cmbCurso.SelectedIndex = -1 Then
            MessageBox.Show("Campo requerido. Seleccione el Curso.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            cmbCurso.Focus()
        ElseIf cmbCarrera.SelectedIndex = -1 Then
            MessageBox.Show("Campo requerido. Seleccione la Carrera.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Hand)
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
    '' Método de la clase encargado de la accion de cierre
    ''</summary>
    '' <param name="agregarTema_FormClosing"></param>
    '' <remarks>Autor: Fabián Vega Ramírez</remarks>
    Private Sub aCursoCarrera_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If isDataSaved = False Then
            Dim button As DialogResult = MessageBox.Show("¿Desea cancelar la asignación?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If button = DialogResult.Yes Then
                e.Cancel = False
                frmPrincipal.CloseCurrentTab()
            Else
                e.Cancel = True
            End If
        End If
    End Sub

End Class