Imports solLogica.Gestor

Imports solLogica.Estructura
Imports System

Public Class denunciarAporte
    Inherits System.Web.UI.Page

    Private idUsuario As Integer
    Private idAporte As Integer
    Private aporte As StrAporte
    Dim usuario As StrUsuario

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ModuloUtilitario.iniciarSesion(Me)
        Page.Title = generarTitulo("Denunciar Aporte")

        If IsPostBack = False Then
            idAporte = CType(Request.QueryString("IdAporte"), Integer)
            cargarDatos()
        End If

    End Sub

    Private Sub btnDenunciar_Click(sender As Object, e As System.EventArgs) Handles btnDenunciar.Click
        idAporte = CType(Request.QueryString("IdAporte"), Integer)
        Dim aporte As StrAporte
        aporte = GestorAporte.buscarAportePorId(idAporte)

        Try
            enviarCorreo(txtPara.Text, "Denuncia de Aporte", "Denuncia hecha por: " + txtDe.Text + Environment.NewLine + txtMotivo.InnerText + System.Environment.NewLine + "En el Blog de: " + usuario.NombreCompleto + Environment.NewLine + "")
        Catch ex As Exception
            mostrarError(Me, "No se pudo enviar la denuncia correctamente")
        End Try
        Response.Redirect("Tema.aspx?ID=" & aporte.IdTema)
    End Sub

    Private Sub cargarDatos()
        Dim usuarioLog As StrUsuario
        Dim usuarioDe As StrUsuario
        Try
            aporte = GestorAporte.buscarAportePorId(idAporte)
            usuarioDe = GestorUsuario.buscarUsuarioPorId(aporte.IdUsuario)
            txtPara.Text = usuarioDe.Correo
            usuarioLog = GestorUsuario.buscarUsuarioPorId(GestorSesion.getIdUsuario())
            txtDe.Text = usuarioLog.Correo

        Catch ex As Exception

        End Try
    End Sub

End Class