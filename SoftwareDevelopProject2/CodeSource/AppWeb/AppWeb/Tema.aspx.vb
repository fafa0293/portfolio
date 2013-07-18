Imports System
Imports solLogica.Gestor
Imports System.Web.UI.WebControls
Imports solLogica.Estructura

Public Class Tema
    Inherits System.Web.UI.Page

    Private idTema As Integer
    Private tema As StrTema
    Private estadoTema As Boolean

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        ModuloUtilitario.iniciarSesion(Me)
        hIdUsuarioLog.Value = GestorSesion.getIdUsuario().ToString()
        hIdAporteComentado.Value = "0"

        Try
            idTema = CType(Request.QueryString("ID"), Integer)
        Catch ex As Exception
            idTema = 0
        End Try

        Dim eliminarComentario As Integer = CType(Request.QueryString("EliminarComentario"), Integer)
        eliminarComentarioAporte(eliminarComentario)

        Try
            tema = GestorTema.buscarTemaId(idTema)
            Page.Title = generarTitulo(tema.Titulo & " :: " & tema.NombreForo)
            lblNombreTema.Text = tema.Titulo
            lNombreForo.Text = tema.NombreForo
            lNombreForo.NavigateUrl = "Foro.aspx?ID=" & GestorTema.obtenerIdForo(idTema)

            If lblNombreTema.Text.Length = 0 Then
                estadoTema = True
            End If

            If DateTime.Parse(tema.FechaFin) < DateTime.Today Or DateTime.Parse(tema.FechaInicio) > DateTime.Today Then
                pnlAgregarAporte.Visible = False
                pnlCerrado.Visible = True
            End If
        Catch ex As Exception
            mostrarError(Me, "No se encontró el Tema especificado.")
        End Try

        If Not GestorTema.usuarioTieneAccesoATema(GestorSesion.getIdUsuario(), CInt(tema.IdTema)) And Not GestorSesion.usuarioTieneRol("director académico") Then
            mostrarError(Me, "Usted no tiene permiso para acceder a este tema")
        End If

        If Not IsPostBack Then
            cargarListas()
        End If

        If GestorTema.usuarioTieneTema(GestorSesion.getIdUsuario(), CInt(tema.IdTema)) Then
            btnCerrar.Visible = True
            btnModificar.Visible = True
            btnEstudiantes.Visible = True
            lblOpciones.Visible = True
        End If

        If GestorSesion.usuarioTienePermiso("cerrarTema") Then
            btnCerrar.Visible = True
            lblOpciones.Visible = True
        End If

        btnCerrar.Visible = False

    End Sub

    Protected Sub Page_PreRenderComplete(ByVal sender As Object, ByVal e As EventArgs) Handles Me.PreRenderComplete

        inicializarCalificacion()

    End Sub

    Private Sub cargarListas()
        If estadoTema = False Then
            listaAportes.DataSource = GestorAporte.listarAportesPorTemaId(idTema)
            listaAportes.DataBind()
        End If
    End Sub


    Private Sub btnCerrar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Try
            GestorTema.cambiarEstadoDeTema(idTema, "Cerrado") ''idTema

        Catch ex As Exception
            mostrarError(Me, ex.ToString() & "No se encontró el Tema especificado.")
        End Try

        Response.Redirect(Request.Url.AbsoluteUri)
    End Sub

    Private Sub inicializarCalificacion()

        For Each item As RepeaterItem In listaAportes.Items

            Dim lbl As Label = CType(item.FindControl("lblCalificacion"), Label)
            Dim ddl As DropDownList = CType(item.FindControl("ddlCalificar"), DropDownList)
            Dim btn As Button = CType(item.FindControl("btnCalificar"), Button)
            Dim calificacion As Integer = CInt(lbl.ToolTip)

            Try
                Dim aporte As StrAporte = CType(item.DataItem, StrAporte)
                If GestorUsuario.usuarioTieneRol("estudiante", CInt(btn.ToolTip)) Then
                    If calificacion = 0 Then
                        If GestorSesion.usuarioTienePermiso("calificarAporte") Then
                            lbl.Visible = False
                            btn.Visible = True
                            ddl.Visible = True
                            ddl.DataSource = {1, 2, 3, 4, 5}
                            ddl.DataBind()
                        Else
                            lbl.Text = "<strong>Calificación:</strong> <i>El aporte no ha sido calificado aún</i>"
                        End If
                    End If
                Else
                    lbl.Text = ""
                End If
            Catch ex As Exception
            End Try
        Next
    End Sub

    Protected Sub listaTemas_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.RepeaterCommandEventArgs) Handles listaAportes.ItemCommand
        ModuloUtilitario.iniciarSesion(Me)
        If e.CommandName.ToString = "Calificar" And GestorSesion.usuarioTienePermiso("calificarAporte") Then
            Try
                Dim idAporte As Integer = CInt(e.CommandArgument.ToString)

                Dim btn As Button = CType(e.CommandSource, Button)
                Dim ddl As DropDownList = CType(btn.Parent.FindControl("ddlCalificar"), DropDownList)
                Dim calificacion As Integer = CInt(ddl.SelectedValue)

                GestorAporte.calificarAporte(idAporte, calificacion)
                cargarListas()

            Catch ex As Exception
                mostrarError(Me, ex.Message)
            End Try
        End If

        If e.CommandName.ToString = "Comentar" Then
            Try
                Dim idAporte As Integer = CInt(e.CommandArgument.ToString)

                Dim btn As Button = CType(e.CommandSource, Button)
                Dim txt As TextBox = CType(btn.Parent.FindControl("txtComentario"), TextBox)
                GestorComentario.agregarComentarioEntrada(GestorSesion.getIdUsuario(),
                                                          idAporte,
                                                          Nothing,
                                                          Date.Now,
                                                          txt.Text)
                txt.Text = ""
                hIdAporteComentado.Value = idAporte.ToString()

            Catch ex As Exception
                mostrarError(Me, ex.ToString())
            End Try
        End If
    End Sub

    Protected Sub btnModificar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnModificar.Click
        Response.Redirect("ModificarTema.aspx?ID=" & idTema)
    End Sub

    Protected Sub btnEstudiantes_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnEstudiantes.Click
        Response.Redirect("EstudiantesTema.aspx?ID=" & idTema)
    End Sub

    Protected Sub btnAporte_Click(sender As Object, e As EventArgs) Handles btnAporte.Click
        GestorAporte.agregarAporte(idTema, GestorSesion.getIdUsuario(), DateTime.Now, txtAporte.Text)
        txtAporte.Text = ""
        cargarListas()

    End Sub

    Private Sub eliminarComentarioAporte(ByVal eliminarComentario As Integer)
        Dim exito As Boolean = False
        If eliminarComentario <> 0 Then
            Try
                GestorComentario.eliminarComentrtarioDeAporte(eliminarComentario)
                exito = True
            Catch ex As Exception
                mostrarError(Me, "Usted no posee los permisos necesarios para realizar esta acción")
            End Try
        End If

        If exito Then
            Response.Redirect("Tema.aspx?ID=" & idTema)
        End If
    End Sub

End Class

