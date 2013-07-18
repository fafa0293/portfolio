Imports System
Imports solLogica.Gestor
Imports solLogica.Estructura
Imports System.Collections.Generic
Imports System.Net
Imports System.IO
Imports System.Web.UI.WebControls

Public Class Blog1
    Inherits System.Web.UI.Page
    Private idUsuario As Integer = 0
    Private idBlog As Integer
    Private idUsuarioLog As Integer
    Private usuario As StrUsuario
    Private idTema As Integer = 0
    Private entradas As List(Of StrEntrada)
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ModuloUtilitario.iniciarSesion(Me)

        Try
            idUsuario = CType(Request.QueryString("ID"), Integer)
            idTema = CType(Request.QueryString("Tema"), Integer)
        Catch
        End Try


        If idUsuario = 0 Then
            idUsuario = GestorSesion.getIdUsuario()
        End If

        idBlog = idUsuario
        idUsuarioLog = GestorSesion.getIdUsuario()
        cargarTemasDeBlog()
        If Not IsPostBack Then
            cargarListas()
        End If

        If Not Session("txtTitulo") Is Nothing Then
            Dim txt As String = CStr(Session("txtTitulo"))
            txtTitulo.Text = txt
            buscarPorTitulo(txt)
            Session("txtTitulo") = Nothing
        End If

        If (idTema <> 0) Then
            Dim entradas As List(Of StrEntrada) = GestorEntrada.listarEntradasPorTema(idBlog, idTema)
            entradas = compContenido(entradas)
            listaEntradas.DataSource = entradas
            listaEntradas.DataBind()
        End If

        Try
            usuario = GestorUsuario.buscarUsuarioPorId(idUsuario)
            lblNombreUsuario.Text = usuario.NombreCompleto
            lblNombreUsuario2.Text = usuario.NombreCompleto
            Page.Title = generarTitulo("Blog de " & usuario.NombreCompleto)
            lblCorreoElectronico.Text = usuario.Correo
            Label3.Text = usuario.idUsuario
        Catch ex As Exception
            mostrarError(Me, "No se encontró el Blog especificado o se encuentra deshabilitado.")
        End Try

        validarDirector()
        If idUsuario = idUsuarioLog Then
            Button2.Visible = True
        End If


    End Sub
    Private Sub cargarListas()
        Dim entradas As List(Of StrEntrada) = GestorEntrada.listarEntradasPorBlogId(idBlog)
        entradas = compContenido(entradas)
        listaEntradas.DataSource = entradas
        listaEntradas.DataBind()
    End Sub

    Private Sub validarDirector()

        Dim directores As List(Of StrUsuario)
        Dim idUsuarioLog As Integer = GestorSesion.getIdUsuario()
        directores = GestorUsuario.buscarUsuarioPorRol("Director Académico")
        Dim encontrado As Boolean = False
        For Each director As StrUsuario In directores
            If (CInt(director.idUsuario) = idUsuarioLog) Then
                encontrado = True
            End If
        Next

        If encontrado Then
            Button1.Visible = True
        End If
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GestorBlog.deshabilitarBlog(CType(idBlog, String), CType(idUsuario, String))
    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try

            Dim temas() As String = txtTemas.Text.Split(New Char() {","c})

            GestorEntrada.registrarEntrada(idBlog, TextBox1.Text, TextBox2.Text)
            GestorEntrada.registrarTemasDeEntrada(idBlog, New List(Of String)(temas))
            TextBox1.Text = ""
            TextBox2.Text = ""
            txtTemas.Text = ""
            cargarListas()
        Catch ex As Exception
            mostrarError(Me, ex.ToString())
        End Try
    End Sub



    Protected Sub btnBuscar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBuscar.Click
        Dim txt As String = txtTitulo.Text
        buscarPorTitulo(txt)
    End Sub

    Public Sub buscarPorTitulo(ByVal titulo As String)
            Dim entradas As List(Of StrEntrada) = GestorEntrada.listarEntradasPorTitulo(idBlog, titulo)
            entradas = compContenido(entradas)
            listaEntradas.DataSource = entradas
            listaEntradas.DataBind()
    End Sub

    Public Function compContenido(ByVal entradas As List(Of StrEntrada)) AS List(Of StrEntrada)
        Dim i As Integer
        For i = 0 To (entradas.Count - 1)
            Dim entrada As StrEntrada = entradas.Item(i)

            If entrada.Contenido.ToString().Length() > 250 Then
                entrada.Contenido = entrada.Contenido.ToString().Substring(0, 250) & "..."
            End If
            entradas.Item(i) = entrada
        Next
        Return entradas
    End Function

    Private Sub cargarTemasDeBlog()
        listaTemasBlog.DataSource = GestorEntrada.buscarTemasPorBlog(idBlog)
        listaTemasBlog.DataBind()
    End Sub
End Class