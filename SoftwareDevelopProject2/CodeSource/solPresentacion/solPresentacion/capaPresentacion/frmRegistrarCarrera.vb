Imports solLogica.Gestor

Public Class frmRegistrarCarrera
    Private isDataSaved As Boolean = False

    ''' <summary>
    ''' Método de clase, encarga de evaluar que no queden espacios en blanco ningún componente
    ''' </summary>
    ''' <returns name="result">retorna un valor boolean</returns>
    ''' <remarks>Autor: Ernesto Villarreal</remarks>
    Private Function validarCampos() As Boolean
        Dim result As Boolean = False
        Dim titulo = Me.gbCarrera.Text

        If Me.txtCodigo.Text.Trim().Equals("") Then
            MessageBox.Show("Campo requerido. Ingrese el código de la carrera.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Me.txtCodigo.Text = ""
            Me.txtCodigo.Focus()

        ElseIf Me.txtNombre.Text.Trim().Equals("") Then
            MessageBox.Show("Campo requerido. Ingrese el nombre de la carrera.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Me.txtNombre.Text = ""
            Me.txtNombre.Focus()
        Else
            result = True
        End If
        Return result
    End Function

    Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
        Dim result As Boolean = validarCampos()

        Dim titulo As String = Me.gbCarrera.Text

        If result = True Then

            Dim dresult As DialogResult = MessageBox.Show("¿Está seguro que desea realizar el registro de la carrera?", titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            Try
                If dresult = Windows.Forms.DialogResult.Yes Then
                    GestorCarrera.registrarCarrera(txtCodigo.Text, txtNombre.Text)

                    MsgBox("Los datos de la carrera se han registrado.", MsgBoxStyle.Information, titulo)
                    Me.isDataSaved = True
                    Me.Close()
                End If

            Catch ex As Exception
                MsgBox("Los datos de la carrera se han registrado.", MsgBoxStyle.Information, titulo)
                Me.isDataSaved = True
                Me.Close()
            End Try
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub frmRegistrarCarrera_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Dim result As DialogResult
        Dim titulo As String = Me.gbCarrera.Text

        If isDataSaved Then
            Return
        End If

        result = MessageBox.Show("¿Está seguro que desea cancelar el registro?", titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, 0, False)

        Try
            If result <> Windows.Forms.DialogResult.Yes Then
                e.Cancel = True
                frmPrincipal.CloseCurrentTab()
                Me.txtCodigo.Focus()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnCancelar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class