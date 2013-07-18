Imports System
Imports solLogica.Gestor
Imports solLogica.Estructura
Public Class ModificarEntrada
    Inherits System.Web.UI.Page
    Dim entrada As StrEntrada
    Dim idEntrada As Integer
    Dim idUser As Integer
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ModuloUtilitario.iniciarSesion(Me)
        idEntrada = CType(Request.QueryString("ID"), Integer)

        If IsPostBack = False Then
            Try
                Page.Title = generarTitulo("Modificar Entrada")
                entrada = GestorEntrada.entradaId(idEntrada)
                idUser = CInt(entrada.IdBlog)
                TextBox1.Text = entrada.Titulo
                TextBox2.Text = entrada.Contenido
                If Not (idUser = GestorSesion.getIdUsuario()) Then
                    mostrarError(Me, "No se encontró la Entrada especificada.")
                End If

            Catch ex As Exception
                mostrarError(Me, "No se encontró la Entrada especificada.")
            End Try
        End If
    End Sub


    Protected Sub Button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button3.Click

        entrada = GestorEntrada.entradaId(idEntrada)
        GestorEntrada.modificarEntrada(idEntrada, CType(entrada.IdBlog, Integer), DateTime.Parse(entrada.Fecha), TextBox1.Text, TextBox2.Text)
        Response.Redirect("Entrada.aspx?ID=" & idEntrada)

    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Response.Redirect("Entrada.aspx?ID=" & idEntrada)
    End Sub
End Class