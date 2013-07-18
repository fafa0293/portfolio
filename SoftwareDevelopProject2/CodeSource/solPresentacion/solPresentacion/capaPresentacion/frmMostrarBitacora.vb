Imports solLogica.Gestor

Public Class frmMostrarBitacora
    ' este id usuario se le tiene que settear antes de ser mostrado
    Private idUsuario As Integer = 0

    Public Sub New(ByVal idUsuario As Integer)
        InitializeComponent()
        Me.idUsuario = idUsuario
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub frmMostrarBitacora_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dgBitacora.DataSource = GestorBitacora.mostrarBitacora(idUsuario)
    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        Try
            'Intentar generar el documento.
            'Se adjunta un texto debajo del encabezado con la fecha actual del sistema.
            ExportarDatosExcel(dgBitacora, "FECHA: " + Now.Date())
        Catch ex As Exception
            'Si el intento es fallido, mostrar MsgBox.
            MessageBox.Show("No se puede generar el documento Excel.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class