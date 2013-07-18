Imports solLogica.Gestor
Imports System.Collections
Imports System

Public Class ModificarBlog
    Inherits System.Web.UI.Page
    Dim idUsuario As Integer
    Dim contrasenna As String
    Public update As Boolean

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim usuario(0 To 11) As String

        idUsuario = GestorSesion.getIdUsuario()
        contrasenna = GestorSesion.getContrasennaUsuario()

        If IsPostBack = False Then
            Page.Title = generarTitulo("Modificar Usuario")
            usuario = GestorUsuario.buscarUsuarioPorIdConvert(GestorUsuario.buscarUsuarioPorId(idUsuario))
            Dim genero As String
            contrasenna = usuario(11)
            txtCedula.Text = usuario(4)
            txtCarnet.Text = usuario(5)
            txtNombre.Text = usuario(1)
            txtApellido1.Text = usuario(2)
            txtApellido2.Text = usuario(3)
            genero = usuario(6)
            setGenero(genero)
            txtFechaNacimiento.Text = usuario(7)
            txtCorreoElectronico.Text = usuario(12)
            txtTelefonoCelular.Text = usuario(10)
            txtTelefonoCasa.Text = usuario(9)
            txtDireccion.InnerText = usuario(8)
        End If

    End Sub

    Private Sub setGenero(genero As String)
        If (genero.Equals("M")) Then
            rbdMasculino.Checked = True
        Else
            rbdMasculino.Checked = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click

        Dim fecha As Date
        fecha = CDate(txtFechaNacimiento.Text)
        Dim genero As String = getGenero()

        Try
            GestorUsuario.modificarUsuario(txtNombre.Text, txtApellido1.Text, txtApellido2.Text,
                                      txtCedula.Text, txtCarnet.Text, CChar(genero), txtCorreoElectronico.Text,
                                      contrasenna, fecha, txtDireccion.InnerText.ToString,
                                      txtTelefonoCasa.Text, txtTelefonoCelular.Text, idUsuario)
            update = True
        Catch ex As Exception
            update = False
        End Try

    End Sub

    Private Function getGenero() As String
        If (rbdFemenino.Checked) Then
            Return "F"
        Else
            Return "M"
        End If

        Return Nothing

    End Function



End Class