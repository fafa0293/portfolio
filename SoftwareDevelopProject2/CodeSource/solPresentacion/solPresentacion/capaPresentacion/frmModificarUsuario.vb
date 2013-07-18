Imports System.Text.RegularExpressions
Imports solLogica.Gestor
Imports solLogica.Estructura

Public Class frmModificarUsuario
    Dim _genero As Char
    Public _idUsuario As Integer = 0

    Public Sub New(ByVal idUsuario As Integer,
                    ByVal nombre As String,
                    ByVal apellido1 As String,
                    ByVal apellido2 As String,
                    ByVal carnet As String,
                    ByVal cedula As String,
                    ByVal genero As String,
                    ByVal correoElectronico As String,
                    ByVal fechaNacimiento As String,
                    ByVal direccion As String,
                    ByVal telefonoFijo As String,
                    ByVal telefonoCelular As String,
                    ByVal contrasenna As String)

        InitializeComponent()

        _idUsuario = idUsuario
        dtpFecha.Value = fechaNacimiento
        txtaDireccion.Text = direccion
        txtApellido1.Text = apellido1
        txtApellido2.Text = apellido2
        txtCarnet.Text = carnet
        txtCedula.Text = cedula
        txtCorreo.Text = correoElectronico
        txtNombre.Text = nombre
        txtTelfCasa.Text = telefonoFijo
        txtTelfCel.Text = telefonoCelular

        If genero = "M" Then
            rbtM.Checked = True
        Else
            rbtF.Checked = True
        End If
    End Sub

    ''' <summary>
    ''' Método de clase, encarga de evaluar que no queden espacios en blanco ningún componente
    ''' </summary>
    ''' <returns name="_result">retorna un valor boolean</returns>
    ''' <remarks>Autor: Ernesto Villarreal</remarks>
    Private Function validarCampos() As Boolean
        Dim _result = False

        If Me.txtCedula.Text.Trim() = "" Then
            MsgBox("La cédula es un dato requerido.", MsgBoxStyle.Information, "Modificar Usuario")
            Me.txtCedula.Focus()

            'ElseIf Not evaluarNumeros(Me.txtCedula.Text.Trim()) Then
            '    MsgBox("Ingrese solo caracteres numéricos.", MsgBoxStyle.Information, "Modificar Usuario")
            '    Me.txtCedula.Text = ""
            '    Me.txtCedula.Focus()

        ElseIf Me.txtCarnet.Text.Trim() = "" Then
            MsgBox("El carné es un dato requerido", MsgBoxStyle.Information, "Modificar Usuario")
            Me.txtCarnet.Focus()

        ElseIf Me.txtNombre.Text.Trim() = "" Then
            MsgBox("El Nombre del Usuario es un dato requerido", MsgBoxStyle.Information, "Modificar Usuario")
            Me.txtNombre.Focus()

        ElseIf Me.txtApellido1.Text.Trim() = "" Then
            MsgBox("El primer apellido es un dato requerido", MsgBoxStyle.Information, "Modificar Usuario")
            Me.txtApellido1.Focus()

        ElseIf Me.txtApellido2.Text.Trim() = "" Then
            MsgBox("El segundo apellido es un dato requerido", MsgBoxStyle.Information, "Modificar Usuario")
            Me.txtApellido2.Focus()

        ElseIf evaluar() Then
            MsgBox("El género es un dato requerido", MsgBoxStyle.Information, "Modificar Usuario")

        ElseIf Me.txtCorreo.Text.Trim() = "" Then
            MsgBox("El correo electrónico del usuario es un dato requerido", MsgBoxStyle.Information, "Modificar Usuario")
            Me.txtCorreo.Focus()

        ElseIf Not evaluarCorreo(Me.txtCorreo.Text.Trim()) Then
            MsgBox("El formato del correo electrónico es incorrecto. Debe tener la siguiente estructura: texto@texto.texto", MsgBoxStyle.Information, "Modificar Usuario")
            Me.txtCorreo.Text = ""
            Me.txtCorreo.Focus()

        ElseIf Me.txtTelfCasa.Text.Trim() = "" Then
            MsgBox("El teléfono de habitación es un dato requerido.", MsgBoxStyle.Information, "Modificar Usuario")
            Me.txtTelfCasa.Focus()

        ElseIf Not evaluarNumeros(Me.txtTelfCasa.Text.Trim()) Then
            MsgBox("Ingrese solamente caracteres numéricos", MsgBoxStyle.Information, "Modificar Usuario")
            Me.txtTelfCasa.Text = ""
            Me.txtTelfCasa.Focus()

        ElseIf Not evaluarNumeros(Me.txtTelfCel.Text.Trim()) Then
            MsgBox("Ingrese solamente caracteres numéricos", MsgBoxStyle.Information, "Modificar Usuario")
            Me.txtTelfCel.Focus()

        ElseIf Me.txtaDireccion.Text.Trim() = "" Then
            MsgBox("La dirección es un dato requerido", MsgBoxStyle.Information, "Modificar Usuario")
            Me.txtaDireccion.Focus()

        Else
            _result = True
        End If
        Return _result
    End Function
    ''' <summary>
    ''' Método de clase, encarga de evaluar el tipo de genero
    ''' </summary>
    ''' <remarks>Autor: Ernesto Villarreal</remarks>
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
    ''' <remarks>Autor: Ernesto Villarreal</remarks>
    Private Function evaluarNumeros(ByVal texto As String) As Boolean
        Dim _numero As Integer

        _numero = IsNumeric(texto)
        Return _numero
    End Function
    ''' <summary>
    ''' Método de clase, encarga de evaluar el formato del correo
    ''' </summary>
    ''' <returns name="_result">retorna un valor Boolean</returns>
    ''' <remarks>Autor:Ernesto Villarreal</remarks>
    Private Function evaluarCorreo(ByVal texto) As Boolean
        Dim expresion As Boolean = True
        Try
            expresion = Regex.IsMatch(texto, "\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+(?:[A-Za-z]{2}|com|org|net|gov|mil|biz|info|mobi|name|aero|jobs|museum)\b)\Z", RegexOptions.IgnoreCase)
        Catch ex As Exception
        End Try
        Return expresion
    End Function

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Dim _result As DialogResult

        _result = MessageBox.Show("¿Está seguro que desea cancelar la modificación del usuario?", "Modificar Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, 0, False)

        Try
            If _result = Windows.Forms.DialogResult.Yes Then
                Me.Close()

            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub bntModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click

        If validarCampos() = True Then
            Try
                If MessageBox.Show("¿Está seguro que desea modificar los datos del usuario?", "Modificar Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, 0, False) = Windows.Forms.DialogResult.Yes Then
                    Dim genero As String
                    If rbtM.Checked Then
                        genero = "M"
                    Else
                        genero = "F"
                    End If

                    GestorUsuario.modificarUsuario(
                        txtNombre.Text, txtApellido1.Text, txtApellido2.Text,
                        txtCedula.Text, txtCarnet.Text, genero, txtCorreo.Text,
                        txtContrasenna.Text, dtpFecha.Value, txtaDireccion.Text,
                        txtTelfCasa.Text, txtTelfCel.Text, _idUsuario)

                    MsgBox("Los datos del usuario han sido modificados.", MsgBoxStyle.Information, "Modificar Usuario")
                    Me.Close()
                Else
                    MsgBox("Los datos del usuario no son modificados.", MsgBoxStyle.Information, "Modificar Usuario")
                End If
            Catch ex As Exception
                MsgBox("Error: La cédula y el correo electrónico deben ser únicos.", MsgBoxStyle.Information, "Modificar Usuario")
            End Try
        End If
    End Sub

    Private Sub frmModificarUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class