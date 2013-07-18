Imports solLogica.Gestor

Public Class frmRegistrarCurso

    Dim _isDataSaved As Boolean
    Dim _nombre As String
    Dim _codigo As String
    Dim _creditos As Integer
    Dim _estado As String

    ''' <summary>
    ''' Método de clase, encarga de evaluar que no queden espacios en blanco ningún componente
    ''' </summary>
    ''' <returns name="_result">retorna un valor boolean</returns>
    ''' <remarks>Autor:Christopher Vargas</remarks>
    Private Function validarCampos() As Boolean
        Dim _result = False

        If Me.txtCodigo.Text.Trim() = "" Then
            MsgBox("El código del curso es un dato requerido", MsgBoxStyle.Information, "Registrar Curso")
            Me.txtCodigo.Focus()

        ElseIf Me.txtNombre.Text.Trim() = "" Then
            MsgBox("El Nombre del curso es un dato requerido", MsgBoxStyle.Information, "Registrar Curso")
            Me.txtNombre.Focus()

        ElseIf Me.txtCreditos.Text.Trim() = "" Then
            MsgBox("Los créditos del curso es un dato requerido", MsgBoxStyle.Information, "Registrar Curso")
            Me.txtCreditos.Focus()

        ElseIf Not evaluarCreditos(txtCreditos.Text.Trim()) Then
            MsgBox("Ingrese unicamente caracteres numéricos", MsgBoxStyle.Information, "Registrar Curso")
            Me.txtCreditos.Text = ""
            Me.txtCreditos.Focus()
        Else
            _result = True
        End If
        Return _result
    End Function

    Private Sub bntRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bntRegistrar.Click
        Dim _result As DialogResult
        _result = validarCampos()

        If _result = True Then

            _codigo = Me.txtCodigo.Text 
            _nombre = Me.txtNombre.Text
            _creditos = Me.txtCreditos.Text



            _result = MessageBox.Show("¿Está seguro que desea Registrar los datos del Curso " & _nombre & "" & "?", "Registrar Curso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, 0, False)

            Try
                If _result = Windows.Forms.DialogResult.Yes Then
                    GestorCurso.registrarCurso(_codigo, _nombre, _creditos, "Cerrado")
                    MsgBox("Los datos del Curso son registrados.", MsgBoxStyle.Information, "Registrar Curso")
                    Me.Close()
                    limpiarFormulario()
                Else
                    MsgBox("Los datos del Curso no son registrados.", MsgBoxStyle.Information, "Registrar Curso")
                End If
            Catch ex As Exception
                MsgBox("Los datos del Curso son registrados.", MsgBoxStyle.Information, "Registrar Curso")
                Me.Close()
                limpiarFormulario()
            End Try
        End If

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Dim _result As DialogResult

        _result = MessageBox.Show("¿Está seguro que desea cancelar el registro?", "Registrar Curso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, 0, False)

        Try
            If _result = Windows.Forms.DialogResult.Yes Then
                Me.Close()
                frmPrincipal.CloseCurrentTab()
            End If
        Catch ex As Exception
        End Try

    End Sub
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

    ''' <summary>
    ''' Método de clase, encarga de limpiar el formulario de Registrar
    ''' </summary>
    ''' <remarks>Autor: Christopher Vargas</remarks>
    Private Sub limpiarFormulario()
        With Me
            .txtNombre.Text = ""
            .txtCreditos.Text = ""

        End With


    End Sub


End Class