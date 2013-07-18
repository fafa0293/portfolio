Imports solLogica.Gestor
Imports solLogica.Estructura

Public Class frmModificarCarrera

    Public idCarrera As Integer = 0
    Private isDataSaved As Boolean = False

    Public Sub New(ByVal idCarrera As Integer, ByVal nombre As String)
        InitializeComponent()
        Me.idCarrera = idCarrera
        txtNombre.Text = nombre
    End Sub

    ''' <summary>
    ''' Método de clase, encarga de evaluar que no queden espacios en blanco ningún componente
    ''' </summary>
    ''' <returns name="result">retorna un valor boolean</returns>
    ''' <remarks>Autor: Ernesto Villarreal</remarks>
    Private Function validarCampos() As Boolean
        Dim result As Boolean = False
        Dim titulo = Me.gbCarrera.Text

        If Me.txtNombre.Text.Trim().Equals("") Then
            MessageBox.Show("Campo requerido. Ingrese el nombre de la carrera.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Me.txtNombre.Text = ""
            Me.txtNombre.Focus()
        Else
            result = True
        End If
        Return result
    End Function

    Private Sub frmModificarCarrera_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Dim result As DialogResult
        Dim titulo As String = Me.gbCarrera.Text

        If isDataSaved Then
            Return
        End If

        result = MessageBox.Show("¿Está seguro que desea cancelar la modificación?", titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, 0, False)

        Try
            If result <> Windows.Forms.DialogResult.Yes Then
                e.Cancel = True
                Me.txtNombre.Focus()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnCancelar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnModificar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Dim result As Boolean = validarCampos()
        Dim titulo As String = Me.gbCarrera.Text

        Dim dresult As DialogResult = MessageBox.Show("¿Está seguro que desea realizar la modificación de la carrera?", titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        Try
            If dresult = Windows.Forms.DialogResult.Yes Then
                GestorCarrera.modificarCarrera(idCarrera, txtNombre.Text)
                MsgBox("Los datos de la carrera se han modificado.", MsgBoxStyle.Information, titulo)
                Me.isDataSaved = True
                Me.Close()
            End If

        Catch ex As Exception
            MsgBox("Error: " & ex.ToString(), MsgBoxStyle.Information, titulo)
        End Try
    End Sub
End Class