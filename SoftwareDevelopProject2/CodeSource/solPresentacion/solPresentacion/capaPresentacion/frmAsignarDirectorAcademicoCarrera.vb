Imports solLogica.Gestor
Imports solLogica.Estructura

Public Class frmAsignarDirectorAcademicoCarrera
    Private validado As Boolean = False
    Private isDataSaved As Boolean = False

    Private Sub frmAsignarDirectorAcademicoCarrera_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarListas()
    End Sub

    ''' <summary>
    ''' Método de la clase encargada de cargar las listas de los comboBox
    ''' </summary>
    ''' <remarks>Author: Ernesto Villarreal</remarks>
    Private Sub cargarListas()
        Try
            cmbCarrera.DataSource = GestorCarrera.listarCarreras()
            cmbDirectorAcademico.DataSource = GestorUsuario.buscarUsuarioPorRol("Director Académico")
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    ''' <summary>
    ''' Método de la clase encargado de la validacion de los datos
    '''</summary>
    ''' <remarks>Author: Ernesto Villarreal</remarks>
    Private Sub validar()

        If cmbDirectorAcademico.SelectedIndex = -1 Then
            MessageBox.Show("Campo requerido. Seleccione el Director Académico.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            cmbDirectorAcademico.Focus()
        ElseIf cmbCarrera.SelectedIndex = -1 Then
            MessageBox.Show("Campo requerido. Seleccione la Carrera.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            cmbCarrera.Focus()
        Else
            validado = True
        End If

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub frmAsignarDirectorAcademicoCarrera_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
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

    Private Sub btnAsignar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsignar.Click
        validar()
        If validado = True Then
            Dim button As DialogResult = MessageBox.Show("¿Desea realizar la asignación?", "Asignar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If button = DialogResult.Yes Then
                Try
                    GestorCarrera.asignarDirectorAcademicoACarrera(cmbDirectorAcademico.SelectedValue(), cmbCarrera.SelectedValue())
                    MessageBox.Show("¡Asignación registrada exitosamente!", "Asignar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    isDataSaved = True
                    Me.Close()
                Catch ex As Exception
                    MsgBox("Los datos seleccionados para la asignación ya existen en la base de datos.", MsgBoxStyle.Information)
                End Try

            End If
        End If
    End Sub
End Class