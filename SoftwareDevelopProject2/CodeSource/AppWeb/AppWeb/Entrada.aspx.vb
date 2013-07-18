Imports System
Imports solLogica.Gestor
Imports solLogica.Estructura
Imports System.Collections.Generic
Imports System.Net
Imports System.IO
Imports System.Web.UI.WebControls
Imports System.Web

Public Class Entrada1
    Inherits System.Web.UI.Page
    Dim loguser As Integer
    Dim entrada As StrEntrada
    Dim _user As StrUsuario
    Dim idEntrada As Integer
    Public Shared idUser As Integer
    Dim idAporte As Integer

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ModuloUtilitario.iniciarSesion(Me)
        idEntrada = CType(Request.QueryString("ID"), Integer)
       
        loguser = GestorSesion.getIdUsuario()
        If Not IsPostBack Then
            cargarListas()
        End If
        Try
            entrada = GestorEntrada.entradaId(idEntrada)
            idUser = CInt(entrada.IdBlog)
            Label3.Text = HttpUtility.HtmlEncode(entrada.Titulo)
            Label2.Text = HttpUtility.HtmlEncode(entrada.Contenido).Replace(Environment.NewLine, "<br />")
            Label4.Text = entrada.Fecha
            Label5.Text = HttpUtility.HtmlEncode(entrada.Titulo)
            lblCalificacion.Text = entrada.Calificacion

            idUsuarioBlog.Value = CStr(idUser)
            idUsuarioLog.Value = CStr(loguser)

            _user = GestorUsuario.buscarUsuarioPorId(idUser)
            lblCorreoElectronico.Text = _user.Correo
            lblNombreUsuario2.Text = _user.NombreCompleto
            HyperLink1.Text = "Blog de " & _user.NombreCompleto
            HyperLink1.NavigateUrl = "Blog.aspx?ID=" & _user.idUsuario
            inicializarCalificacion()
            Page.Title = generarTitulo(entrada.Titulo & " :: Blog de " & _user.NombreCompleto)
            cargarTemasDeEntrada()
            cargarTemasDeBlog()
        Catch ex As Exception
            mostrarError(Me, "No se encontró la Entrada especificada.")
        End Try
        If (idUser = loguser) Then
            Button2.Visible = True
            Button3.Visible = False
        End If
    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        Response.Redirect("ModificarEntrada.aspx?ID=" & idEntrada)
    End Sub

    Protected Sub Button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button3.Click
        Response.Redirect("DenunciarEntrada.aspx?ID=" & idEntrada)
    End Sub

    Protected Sub btnBuscar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBuscar.Click
        Session("txtTitulo") = txtTitulo.Text
        Response.Redirect("Blog.aspx?ID=" & idUser)
    End Sub

    Private Sub cargarTemasDeEntrada()
        listaTemas.DataSource = GestorEntrada.buscarTemasPorEntrada(idEntrada)
        listaTemas.DataBind()
    End Sub

    Private Sub cargarTemasDeBlog()
        listaTemasBlog.DataSource = GestorEntrada.buscarTemasPorBlog(CInt(entrada.IdBlog))
        listaTemasBlog.DataBind()
    End Sub

    ''' <summary>
    ''' Método de clase, encarga de cargar la lista
    ''' </summary>
    ''' <remarks>Autor:Christopher Vargas</remarks
    Private Sub cargarListas()
        Try
            listaComentEntradas.DataSource = GestorComentario.listarComentariosDeEntrada(idEntrada)
            listaComentEntradas.DataBind()
        Catch ex As Exception
            '' mostrarError(Me, "No se pueden cargar los comentarios")
        End Try

    End Sub

    Private Sub inicializarCalificacion()
        Dim califUsuario As Integer = GestorEntrada.buscarCalificacionDeUsuario(idEntrada, loguser)

        If califUsuario = 0 And CInt(entrada.IdBlog) <> loguser Then
            lblCalificacion.Visible = False
            btnCalificar.Visible = True
            ddlCalificar.Visible = True
        Else
            If entrada.Calificacion = "0" Then
                lblCalificacion.Text = "<i>La entrada no ha sido calificada aún</i>"
            Else
                lblCalificacion.Text = entrada.Calificacion
            End If

        End If
    End Sub

    Protected Sub btnAgregar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAgregar.Click
        Try
            GestorComentario.agregarComentarioEntrada(loguser, idAporte, idEntrada, DateTime.Now, txtComentario.Text)
            txtComentario.Text = ""
            cargarListas()
        Catch ex As Exception
            mostrarError(Me, "No se Agrego el comentario a la entrada")
        End Try
    End Sub

    Protected Sub listaComentEntradas_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.RepeaterCommandEventArgs) Handles listaComentEntradas.ItemCommand
        If e.CommandName.ToString = "Eliminar" Then
            Try
                GestorComentario.eliminarComentrtarioDeEntrada(CInt(e.CommandArgument.ToString))
                cargarListas()
            Catch ex As Exception
                mostrarError(Me, ex.ToString())
            End Try
        End If
    End Sub

    Protected Sub btnCalificar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCalificar.Click
        GestorEntrada.registrarCalificacion(loguser, idEntrada, CInt(ddlCalificar.SelectedValue))
        Response.Redirect("Entrada.aspx?ID=" & idEntrada)
    End Sub
End Class