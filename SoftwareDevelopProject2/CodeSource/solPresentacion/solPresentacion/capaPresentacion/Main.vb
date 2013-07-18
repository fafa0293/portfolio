Module Main

    Private varSesionAbierta As Boolean = False

    Sub Main()
        Application.EnableVisualStyles()
        Dim frmInicioSesion As New frmInicioSesion()

        frmInicioSesion.ShowDialog()

        If (sesionAbierta) Then
            Try
                Application.Run(frmPrincipalV2)
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.ToString())
            End Try
        End If
    End Sub

    Public Property sesionAbierta() As Boolean
        Get
            Return varSesionAbierta
        End Get
        Set(ByVal value As Boolean)
            varSesionAbierta = value
        End Set
    End Property

End Module
