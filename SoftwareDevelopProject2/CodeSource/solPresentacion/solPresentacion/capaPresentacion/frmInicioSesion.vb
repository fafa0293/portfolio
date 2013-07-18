Imports System.Text.RegularExpressions

'' <summary>
'' Autor: Jonathan Jara Morales
'' Version: 1.0
'' Fecha Creacion: 14/10/2012
'' Ultima modificacion: 14/10/12
'' </summary>
Imports solLogica.Gestor
Imports solLogica.Estructura
Public Class frmInicioSesion

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim denegado As Boolean = False

        If validar() Then
            Dim inicio As Boolean
            Try
                inicio = GestorSesion.iniciarSesion(txtUsuario.Text, txtContrasenna.Text, "local")
                ''inicio = True
                If inicio Then
                    Main.sesionAbierta = inicio
                    Me.Hide()
                    frmPrincipalV2.Show()
                Else
                    denegado = True
                End If
            Catch ex As Exception
                denegado = True
            End Try

            txtUsuario.Focus()

        End If

        If denegado Then
            MsgBox("Error: " & "Acceso denegado", MsgBoxStyle.Information, "Error")
        End If

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Function validar() As Boolean
        If txtUsuario.Text.Trim().Length() = 0 Then
            MessageBox.Show("Ingrese el Nombre de Usuario")
            Me.txtUsuario.Focus()
            Return False
        End If

        If txtContrasenna.Text.Trim().Length() = 0 Then
            MessageBox.Show("Ingrese la contraseña")
            Me.txtContrasenna.Focus()
            Return False
        End If

        If comprobarFormatoCorreo() = False Then
            MessageBox.Show("Ingrese el correo con el siguiente formato, siga el ejemplo")
            Me.txtUsuario.Text = "juanperez@gmail.com"
            Me.txtUsuario.Focus()
            Return False
        End If

        Return True
    End Function


    Function comprobarFormatoCorreo() As Boolean
        Dim FoundMatch As Boolean = True
        Try
            FoundMatch = Regex.IsMatch(txtUsuario.Text, "\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+(?:[AZ]{2}|com|org|net|gov|mil|biz|info|mobi|name|aero|jobs|museum)\b)\Z", RegexOptions.IgnoreCase)
        Catch ex As Exception
        End Try
        Return FoundMatch

    End Function

    Private Sub frmInicioSesion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        setTitulo("")
        setDescripcion("" & vbCrLf & "")
    End Sub


    Private Sub frmInicioSesion_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        'Application.Exit()
    End Sub
End Class
