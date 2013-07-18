Imports System.Net.Mail
Imports System.IO
Imports solLogica.Gestor
Imports System.Net

Public Module ModuloUtilitario
    Public Sub mostrarError(ByRef page As System.Web.UI.Page, ByVal mensaje As String)
        page.Session("ErrorMostrado") = mensaje
        page.Response.Redirect("Error.aspx")
    End Sub

    Public Function generarTitulo(ByVal titulo As String) As String
        Return titulo & " :: Star Community System"
    End Function

    Public Function iniciarSesion(ByRef page As System.Web.UI.Page) As Boolean
        Dim sesionIniciada As Boolean = False
        With page
            Dim username As String = CType(.Session("loginUsername"), String)
            Dim password As String = CType(.Session("loginPassword"), String)

            '' quitar estas dos lineas cuando este todo listo o si
            '' se necesita probar algo con otro usuario
            ''username = "lmora@gmail.com"
            ''password = "password"
            ''
            ''

            If Not (username Is Nothing) And Not (password Is Nothing) Then
                sesionIniciada = GestorSesion.iniciarSesion(username, password, "web")
            End If

            If sesionIniciada Then

            ElseIf Not Path.GetFileName(.Request.PhysicalPath).Equals("IniciarSesion.aspx") Then
                .Response.Redirect("IniciarSesion.aspx")
            End If

            .Session("sesionIniciada") = sesionIniciada
        End With

        Return sesionIniciada
    End Function

    Public Sub enviarCorreo(ByVal correoDest As String, ByVal asunto As String, ByVal mensaje As String)
        Try
            Dim correo As New MailMessage()
            Dim cliente As New SmtpClient("smtp.gmail.com")

            correo.From = New MailAddress("starsolutions.cenfotec@gmail.com")
            correo.To.Add(correoDest)
            correo.Subject = asunto
            correo.Body = mensaje

            cliente.Port = 587
            cliente.EnableSsl = True
            cliente.Credentials = New System.Net.NetworkCredential("starsolutions.cenfotec", "mandarinalapapaya")
            cliente.Send(correo)
        Catch
            Throw
        End Try
    End Sub
End Module
