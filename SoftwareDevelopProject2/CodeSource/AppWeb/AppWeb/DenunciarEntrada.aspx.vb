Imports solLogica.Gestor
Imports solLogica.Estructura
Imports System

Public Class DenunciarEntrada
    Inherits System.Web.UI.Page

    Private idEntrada As Integer
    Private idUsuario As Integer
    Private entrada As StrEntrada
    Dim usuario As StrUsuario
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ModuloUtilitario.iniciarSesion(Me)
        Page.Title = generarTitulo("Denunciar Entrada")

        If IsPostBack = False Then
            idEntrada = CType(Request.QueryString("ID"), Integer)
            cargarDatos()
        End If

    End Sub

    Private Sub cargarDatos()

        Dim usuarioLog As StrUsuario
        Dim blog As StrBlog
        Try
            entrada = GestorEntrada.entradaId(idEntrada)
            blog = GestorBlog.buscarBlogPorId(entrada.IdBlog)
            idUsuario = CType(blog.IdUsuario, Integer)
            usuario = GestorUsuario.buscarUsuarioPorId(idUsuario)
            usuarioLog = GestorUsuario.buscarUsuarioPorId(GestorSesion.getIdUsuario())
            txtDe.Text = usuarioLog.Correo
            txtPara.Text = usuario.Correo
        Catch ex As Exception

        End Try
    End Sub



    Private Sub btnDenunciar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDenunciar.Click
        Try
            enviarCorreo(txtPara.Text, "Denuncia de Entrada", "Denuncia hecha por: " + txtDe.Text + Environment.NewLine + txtMotivo.InnerText + System.Environment.NewLine + "En el Blog de: " + usuario.NombreCompleto + Environment.NewLine + "En la entrada: " + entrada.Titulo)

        Catch ex As Exception
            mostrarError(Me, "No se pudo enviar la denuncia correctamente")
        End Try
        Response.Redirect("Entrada.aspx?ID=" & idEntrada)

    End Sub

End Class