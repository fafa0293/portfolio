Imports solLogica.Gestor

Public Class frmModificarCurso
    Dim _nombreCurso As String
    Dim _creditos As Integer
    Dim _estado As String
    Dim _idCurso As Integer
    Dim _codigoCurso As String




    Sub New(ByVal pidCurso As Integer, ByRef pcodigoCurso As String, ByVal pnombreCurso As String, ByVal pcreditos As Integer, _
                   ByVal pestado As String)

        ' This call is required by the designer.
        InitializeComponent()
        cargarDatos(pidCurso, pcodigoCurso, pnombreCurso, pcreditos, pestado)
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    ''' <summary>
    ''' Método de clase, encarga de cargar los datos al formulario de modificar
    ''' </summary>
    ''' <remarks>Autor: Christopher Vargas</remarks>
    Public Sub cargarDatos(ByVal pidCurso As Integer, ByRef pcodigoCurso As String, ByVal pnombreCurso As String, ByVal pcreditos As Integer, _
                   ByVal pestado As String)
        txtCodigo.Text = pcodigoCurso
        txtNombre.Text = pnombreCurso
        txtCreditos.Text = pcreditos
        cbEstado.Text = pestado

        txtCodigo.ReadOnly = True
        _idCurso = pidCurso

    End Sub
    ''' <summary>
    ''' Método de clase, encarga de evaluar que no queden espacios en blanco ningún componente
    ''' </summary>
    ''' <returns name="_result">retorna un valor boolean</returns>
    ''' <remarks>Autor:Christopher Vargas</remarks>
    Private Function validarCampos() As Boolean
        Dim _result = False

        If Me.txtCodigo.Text.Trim() = "" Then
            MsgBox("El código del curso es un dato requerido", MsgBoxStyle.Information, "Modificar Curso")
            Me.txtCodigo.Focus()

        ElseIf Me.txtNombre.Text.Trim() = "" Then
            MsgBox("El Nombre del curso es un dato requerido", MsgBoxStyle.Information, "Modificar Curso")
            Me.txtNombre.Focus()

        ElseIf Not evaluarCreditos(txtCreditos.Text.Trim()) Then
            MsgBox("Los créditos del curso son un dato requerido y solo caracteres numéricos", MsgBoxStyle.Information, "Modificar Curso")
            Me.txtCreditos.Text = ""
            Me.txtCreditos.Focus()

        ElseIf Me.cbEstado.Text.Trim() = "" Then
            MsgBox("El estado del curso es un dato requerido", MsgBoxStyle.Information, "Modificar Curso")
            Me.txtCreditos.Focus()

        Else
            _result = True
        End If
        Return _result
    End Function
    ''' <summary>
    ''' Método de clase, encarga de evaluar si es un dato numerico
    ''' </summary>
    ''' <returns name="_result">retorna un valor Boolean</returns>
    ''' <remarks>Autor:Christopher Vargas</remarks>
    Private Function evaluarCreditos(ByVal texto As String) As Boolean
        Dim _numero As Integer

        _numero = IsNumeric(texto)
        Return _numero
    End Function


    Private Sub btnCancelar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Dim _result As DialogResult

        _result = MessageBox.Show("¿Está seguro que desea cancelar la modificación?", "Modificar Curso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, 0, False)

        Try
            If _result = Windows.Forms.DialogResult.Yes Then
                Me.Close()

            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub bntGuardar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bntGuardar.Click

        Dim _result As DialogResult
        _result = validarCampos()

        If _result = True Then

            'asignar a cada variable los valores indicados
            _nombreCurso = Me.txtNombre.Text
            _creditos = Me.txtCreditos.Text
            _estado = Me.cbEstado.Text
            _codigoCurso = Me.txtCodigo.Text


            _result = MessageBox.Show("¿Está seguro que desea modificar los datos del Curso de " & _nombreCurso & "?", "Modificar curso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, 0, False)

            Try
                If _result = Windows.Forms.DialogResult.Yes Then
                    GestorCurso.modificarCurso(_idCurso, _codigoCurso, _nombreCurso, _creditos, _estado)
                    MsgBox("Los datos del Curso han sido modificados.", MsgBoxStyle.Information, "Modificar curso")
                    Me.Close()

                Else
                    MsgBox("Los datos del curso no son modificados.", MsgBoxStyle.Information, "Modificar curso")
                End If
            Catch ex As Exception
                MsgBox("Error, no se puede Modificar." & ex.Message, MsgBoxStyle.Information, "Modificar")
            End Try
        End If
    End Sub
End Class