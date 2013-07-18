Imports System.Text.RegularExpressions
Imports solLogica.Gestor
Imports solLogica.Estructura

Public Class frmRegistrarUsuario
    Dim _genero As Char
    Dim _cedula As String
    Dim _carnet As String
    Dim _nombreUsuario As String
    Dim _apellido1 As String
    Dim _apellido2 As String
    Dim _fecha As DateTime
    Dim _correo As String
    Dim _contrasenna As String
    Dim _fijo As String
    Dim _celular As String
    Dim _direccion As String
    Dim _estado As Integer

    Private Sub frmRegistrarUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbRol.DataSource = GestorRol.listarRoles()
    End Sub
    ''' <summary>
    ''' Método de clase, encarga de evaluar que no queden espacios en blanco ningún componente
    ''' </summary>
    ''' <returns name="_result">retorna un valor boolean</returns>
    ''' <remarks>Autor:Christopher Vargas</remarks>
    Private Function validarCampos() As Boolean
        Dim _result = False

        If Me.txtCedula.Text.Trim() = "" Then
            MsgBox("La cédula es un dato requerido.", MsgBoxStyle.Information, "Registrar Usuario")
            Me.txtCedula.Focus()

            'ElseIf Not evaluarNumeros(Me.txtCedula.Text.Trim()) Then
            '    MsgBox("Ingrese solo caracteres numéricos.", MsgBoxStyle.Information, "Registrar Usuario")
            '    Me.txtCedula.Text = ""
            '    Me.txtCedula.Focus()

        ElseIf Me.txtCarnet.Text.Trim() = "" Then
            MsgBox("El carné es un dato requerido", MsgBoxStyle.Information, "Registrar Usuario")
            Me.txtCarnet.Focus()

        ElseIf Me.txtNombre.Text.Trim() = "" Then
            MsgBox("El Nombre del Usuario es un dato requerido", MsgBoxStyle.Information, "Registrar Usuario")
            Me.txtNombre.Focus()

        ElseIf Me.txtApellido1.Text.Trim() = "" Then
            MsgBox("El primer apellido es un dato requerido", MsgBoxStyle.Information, "Registrar Usuario")
            Me.txtApellido1.Focus()

        ElseIf Me.txtApellido2.Text.Trim() = "" Then
            MsgBox("El segundo apellido es un dato requerido", MsgBoxStyle.Information, "Registrar Usuario")
            Me.txtApellido2.Focus()

        ElseIf evaluar() Then
            MsgBox("El género es un dato requerido", MsgBoxStyle.Information, "Registrar Usuario")

        ElseIf Me.txtCorreo.Text.Trim() = "" Then
            MsgBox("El correo electrónico del usuario es un dato requerido", MsgBoxStyle.Information, "Registrar Usuario")
            Me.txtCorreo.Focus()

        ElseIf Not evaluarCorreo(Me.txtCorreo.Text.Trim()) Then
            MsgBox("El formato del correo electrónico es incorrecto. Debe tener la siguiente estructura: texto@texto.texto", MsgBoxStyle.Information, "Registrar Usuario")
            Me.txtCorreo.Text = ""
            Me.txtCorreo.Focus()

        ElseIf Me.txtContrasenna.Text.Trim() = "" Then
            MsgBox("La contraseña es un dato requerido", MsgBoxStyle.Information, "Registrar Usuario")
            Me.txtContrasenna.Focus()

        ElseIf Me.txtTelfCasa.Text.Trim() = "" Then
            MsgBox("El teléfono de habitación es un dato requerido.", MsgBoxStyle.Information, "Registrar Usuario")
            Me.txtTelfCasa.Focus()

        ElseIf Not evaluarNumeros(Me.txtTelfCasa.Text.Trim()) Then
            MsgBox("Ingrese solamente caracteres numéricos", MsgBoxStyle.Information, "Registrar Usuario")
            Me.txtTelfCasa.Text = ""
            Me.txtTelfCasa.Focus()

        ElseIf Not evaluarNumeros(Me.txtTelfCel.Text.Trim()) Then
            MsgBox("Ingrese solamente caracteres numéricos", MsgBoxStyle.Information, "Registrar Usuario")
            Me.txtTelfCel.Focus()

        ElseIf Me.txtaDireccion.Text.Trim() = "" Then
            MsgBox("La dirección es un dato requerido", MsgBoxStyle.Information, "Registrar Usuario")
            Me.txtaDireccion.Focus()

        Else
            _result = True
        End If
        Return _result
    End Function
    ''' <summary>
    ''' Método de clase, encarga de evaluar el tipo de genero
    ''' </summary>
    ''' <remarks>Autor: Christopher Vargas</remarks>
    Private Function evaluar() As Boolean
        Dim _evaluar As Boolean = False

        If rbtM.Checked Then
            _genero = "M"

        ElseIf rbtF.Checked Then
            _genero = "F"

        Else
            _evaluar = True

        End If
        Return _evaluar

    End Function

    ''' <summary>
    ''' Método de clase, encarga de evaluar si es un dato numerico
    ''' </summary>
    ''' <returns name="_result">retorna un valor Boolean</returns>
    ''' <remarks>Autor:Christopher Vargas</remarks>
    Private Function evaluarNumeros(ByVal texto As String) As Boolean
        Dim _numero As Integer

        _numero = IsNumeric(texto)
        Return _numero
    End Function
    ''' <summary>
    ''' Método de clase, encarga de evaluar el formato del correo
    ''' </summary>
    ''' <returns name="_result">retorna un valor Boolean</returns>
    ''' <remarks>Autor:Christopher Vargas</remarks>
    Private Function evaluarCorreo(ByVal texto) As Boolean
        Dim expresion As Boolean = True
        Try
            expresion = Regex.IsMatch(texto, "\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+(?:[AZ]{2}|com|org|net|gov|mil|biz|info|mobi|name|aero|jobs|museum)\b)\Z", RegexOptions.IgnoreCase)
        Catch ex As Exception
        End Try
        Return expresion
    End Function

    Private Sub btnCancelar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Dim _result As DialogResult

        _result = MessageBox.Show("¿Está seguro que desea cancelar el registro del usuario?", "Registrar Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, 0, False)

        Try
            If _result = Windows.Forms.DialogResult.Yes Then
                Me.Close()
                frmPrincipal.CloseCurrentTab()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub bntRegistrar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bntRegistrar.Click
        Dim _result As DialogResult
        _result = validarCampos()

        'asignar a cada variable los valores indicados
        _cedula = Me.txtCedula.Text
        _carnet = Me.txtCarnet.Text
        _nombreUsuario = Me.txtNombre.Text
        _apellido1 = Me.txtApellido1.Text
        _apellido2 = Me.txtApellido2.Text
        _fecha = Me.dtpFecha.Text
        _correo = Me.txtCorreo.Text
        _contrasenna = Me.txtContrasenna.Text
        _fijo = Me.txtTelfCasa.Text
        _celular = Me.txtTelfCel.Text
        _direccion = Me.txtaDireccion.Text

        Dim contrasenna As String

        contrasenna = GestorSeguridad.cifrarContrasenna(_contrasenna)

        If _result = True Then

            _result = MessageBox.Show("¿Está seguro que desea registrar los datos del usuario de " & _nombreUsuario & "?", "Registrar Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, 0, False)

            Try
                If _result = Windows.Forms.DialogResult.Yes Then
                    GestorUsuario.registrarUsuario(_nombreUsuario, _apellido1, _apellido2, _cedula, _carnet, _genero, _correo, _
                                                   contrasenna, _fecha, _direccion, _fijo, _celular)

                    Try
                        Dim usuarios As List(Of StrUsuario) = GestorUsuario.buscarUsuarioPorCedula(_cedula)
                        GestorRol.asignarRolAUsuario(usuarios(0).idUsuario, cmbRol.SelectedValue)

                        MsgBox("Los datos del Usuario han sido registrados.", MsgBoxStyle.Information, "Registrar Usuario")
                        Me.Close()
                        limpiarFormulario()
                    Catch ex As Exception
                        MsgBox("Los datos del Usuario han sido registrados.", MsgBoxStyle.Information, "Registrar Usuario")
                        Me.Close()
                        limpiarFormulario()
                    End Try
                Else
                    MsgBox("Los datos del usuario no son registrados.", MsgBoxStyle.Information, "Registrar Usuario")
                End If
            Catch ex As Exception
                MsgBox("Error, no se puede registrar el usuario, los datos ingresados ya están registrados." & ex.Message, MsgBoxStyle.Information, "Registrar")
            End Try
        End If
    End Sub

    ''' <summary>
    ''' Método de clase, encarga de limpiar el formulario de Registrar
    ''' </summary>
    ''' <remarks>Autor: Christopher Vargas</remarks>
    Private Sub limpiarFormulario()
        With Me
            .txtCedula.Text = ""
            .txtCarnet.Text = ""
            .txtNombre.Text = ""
            .txtApellido1.Text = ""
            .txtApellido2.Text = ""
            .dtpFecha.Text = ""
            .txtCorreo.Text = ""
            .txtContrasenna.Text = ""
            .txtTelfCasa.Text = ""
            .txtTelfCel.Text = ""
            .txtaDireccion.Text = ""
        End With
    End Sub

End Class