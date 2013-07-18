Imports System
Imports solLogica.Gestor
Imports solLogica.Estructura
Imports System.Collections.Generic
Imports System.Net
Imports System.IO
Imports System.Web.UI.WebControls

Public Class ComentariosAporte
    Inherits System.Web.UI.Page

    Dim idAporte As Integer


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'ModuloUtilitario.iniciarSesion(Me)
        idAporte = CType(Request.QueryString("ID"), Integer)
        cargarListas()
    End Sub
    ''' <summary>
    ''' Método de clase, encarga de cargar la lista
    ''' </summary>
    ''' <remarks>Autor:Christopher Vargas</remarks
    Private Sub cargarListas()
        Try
            listaComentariosAporte.DataSource = GestorComentario.listarComentariosDeAporte(idAporte)
            listaComentariosAporte.DataBind()
        Catch ex As Exception
            mostrarError(Me, ex.ToString())
        End Try

    End Sub

End Class