Imports solLogica.Gestor
Imports solLogica.Estructura
Imports System
Imports System.Globalization
Imports System.Collections.Generic

Public Class ModificarTema
    Inherits System.Web.UI.Page
    Dim tema As StrTema
    Dim idTema As Int32
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            idTema = CType(Request.QueryString("ID"), Integer)
            tema = GestorTema.buscarTemaId(idTema)
            Page.Title = generarTitulo("Modificar Tema")

            If IsPostBack = False Then
                CargarForm()
            End If
        Catch ex As Exception
            mostrarError(Me, "No se encontró el tema especificado.")
        End Try
       
    End Sub

    Protected Sub CargarForm()
        Dim culture As CultureInfo = New CultureInfo("es-CR")
        Dim fechaInicio As DateTime = DateTime.Parse(tema.FechaInicio),
                fechaFin As DateTime = DateTime.Parse(tema.FechaFin)

        txtTitulo.Text = tema.Titulo
        txtFechaFin.Text = fechaFin.ToString("dd/MM/yyyy", culture)
        txtFechaInicio.Text = fechaInicio.ToString("dd/MM/yyyy", culture)
        txtAportesMaximos.Text = tema.AportesMax

    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click

        Try
            Dim culture As CultureInfo = New CultureInfo("es-CR")
            Dim fechaInicio As DateTime, fechaFin As DateTime

            fechaInicio = DateTime.ParseExact(txtFechaInicio.Text, "dd/MM/yyyy", culture)
            fechaFin = DateTime.ParseExact(txtFechaFin.Text, "dd/MM/yyyy", culture)

            GestorTema.modificarTema(idTema, txtTitulo.Text, 0, CInt(txtAportesMaximos.Text),
                                    fechaInicio, fechaFin)
        Catch ex As Exception
            mostrarError(Me, ex.ToString() & "No se pudo modificar el tema")
        End Try
        

        Response.Redirect("Tema.aspx?ID=" & idTema)
    End Sub


End Class