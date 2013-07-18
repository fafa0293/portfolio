Imports solLogica.Gestor
Imports solLogica.Estructura

Public Class frmBuscarTema
    Private _pidForo As Integer

    Sub New(ByVal idForo As Integer)
        InitializeComponent()
        Me._pidForo = idForo
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Dim registroSeleccionado As DataGridViewRow = dgTemas.CurrentRow

        If registroSeleccionado Is Nothing Then
            MessageBox.Show("Debe seleccionar un registro.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim idTema As Integer = registroSeleccionado.Cells(0).Value
        Dim titulo As String = registroSeleccionado.Cells(3).Value
        Dim aportesMin As Integer = registroSeleccionado.Cells(6).Value
        Dim aportesMax As Integer = registroSeleccionado.Cells(7).Value
        Dim fechaInicio As DateTime = registroSeleccionado.Cells(8).Value
        Dim fechaFin As DateTime = registroSeleccionado.Cells(9).Value

        Dim frm As frmModificarTema = New frmModificarTema(idTema, titulo, aportesMin, aportesMax, fechaInicio, fechaFin, Me)

        frm.ShowDialog()
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Dim nombreTema As String

        nombreTema = ""

        If rbTituloTema.Checked Then
            nombreTema = txtGrupoTitulo.Text
        End If

        dgTemas.AutoGenerateColumns = False
        dgTemas.DataSource = GestorTema.buscarTemas(_pidForo, "", nombreTema)

        txtGrupoTitulo.Focus()
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim titulo As String = "Eliminar Tema"

        Dim registroSeleccionado As DataGridViewRow = dgTemas.CurrentRow
        Dim idTema As Integer

        If registroSeleccionado Is Nothing Then
            MessageBox.Show("Debe seleccionar un registro.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim dresult As DialogResult = MessageBox.Show("¿Desea realizar la eliminación de el tema?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        Try
            If dresult = Windows.Forms.DialogResult.Yes Then
                ' insertar codigo de eliminar aqui
                idTema = registroSeleccionado.Cells(0).Value
                GestorTema.eliminarTema(idTema)
                btnBuscar.PerformClick()

            End If

        Catch ex As Exception
            MsgBox("Error: " & ex.ToString(), MsgBoxStyle.Information, titulo)
        End Try
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub frmBuscarTema_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Dim button As DialogResult = MessageBox.Show("¿Desea cancelar la búsqueda de temas?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If button = DialogResult.Yes Then
            e.Cancel = False
        ElseIf button = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub frmBuscarTema_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Enter
        txtGrupoTitulo.Focus()
    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        Try
            'Intentar generar el documento.
            'Se adjunta un texto debajo del encabezado con la fecha actual del sistema.
            ExportarDatosExcel(dgTemas, "FECHA: " + Now.Date())
        Catch ex As Exception
            'Si el intento es fallido, mostrar MsgBox.
            MessageBox.Show("No se puede generar el documento Excel.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmBuscarTema_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim foro As StrForo = GestorForo.buscarForoPorIdGrupo(_pidForo)
        gbBusqueda.Text = "Búsqueda de temas del foro: " & foro.NombreForo
        btnBuscar.PerformClick()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim registroSeleccionado As DataGridViewRow = dgTemas.CurrentRow
        Dim idTema As Integer

        If registroSeleccionado Is Nothing Then
            MessageBox.Show("Debe seleccionar un registro.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            idTema = registroSeleccionado.Cells(0).Value
            btnBuscar.PerformClick()

            Dim frm As New frmbuscarEstudiantesTema(idTema)
            frm.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedToolWindow
            frm.ControlBox = False
            frm.ShowDialog()
        Catch ex As Exception
            MsgBox("Error: " & ex.ToString(), MsgBoxStyle.Information, "Buscar estudiantes del tema")
        End Try
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim registroSeleccionado As DataGridViewRow = dgTemas.CurrentRow
        Dim idTema As Integer

        If registroSeleccionado Is Nothing Then
            MessageBox.Show("Debe seleccionar un registro.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            idTema = registroSeleccionado.Cells(0).Value

            Dim frm As New frmListarAportesTema(_pidForo, idTema)
            frm.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedToolWindow
            frm.ControlBox = False
            frm.ShowDialog()
        Catch ex As Exception
            MsgBox("Error: " & ex.ToString(), MsgBoxStyle.Information, "Buscar estudiantes del tema")
        End Try
    End Sub
End Class