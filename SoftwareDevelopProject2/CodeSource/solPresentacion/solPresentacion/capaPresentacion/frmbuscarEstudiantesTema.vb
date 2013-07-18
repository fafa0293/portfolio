Imports solLogica.Gestor
Imports solLogica.Estructura
Public Class frmbuscarEstudiantesTema
    Private idTema As Integer = 0

    Sub New(ByVal pidTema As Integer)
        InitializeComponent()

        If pidTema > 0 Then
            idTema = pidTema
        End If
    End Sub

    Private Sub buscarEstudiantesTema_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarLista()

        If idTema > 0 Then

            For Each item As Object In cmbTema.Items
                If item.IdTema = idTema Then
                    cmbTema.SelectedItem = item
                    Exit For
                End If
            Next

            btnBuscar.PerformClick()
        End If
    End Sub

    Private Sub cargarLista()
        cmbTema.DisplayMember = "Titulo"
        cmbTema.ValueMember = "IdTema"
        cmbTema.DataSource = GestorTema.listarTemas()
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If cmbTema.SelectedIndex > -1 Then
            Try
                dgDatosUsuario.AutoGenerateColumns = False
                dgDatosUsuario.DataSource = GestorUsuario.buscarEstudiantesTema(cmbTema.SelectedValue)
                idTema = cmbTema.SelectedValue
            Catch ex As Exception
                MsgBox("Error: " & ex.ToString(), MsgBoxStyle.Information, "Error")
            End Try
        End If
        cmbTema.Focus()
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim titulo As String = "Bloquear estudiante de tema"

        Dim registroSeleccionado As DataGridViewRow = dgDatosUsuario.CurrentRow()

        If registroSeleccionado Is Nothing Then
            MessageBox.Show("Debe seleccionar un registro.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim dresult As DialogResult = MessageBox.Show("¿Desea bloquear al estudiante de este tema? El estudiante no podrá hacer aportes ni ver el tema.", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        Try
            Dim idUsuario As Integer = registroSeleccionado.Cells(0).Value
            If dresult = Windows.Forms.DialogResult.Yes Then
                GestorTema.eliminarAsignacionEstudianteATema(idUsuario, idTema)
                btnBuscar.PerformClick()
                MessageBox.Show("El estudiante ha sido bloqueado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

        Catch ex As Exception
            MsgBox("Error: " & ex.ToString(), MsgBoxStyle.Information, titulo)
        End Try
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub frmbuscarEstudiantesTema_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Dim button As DialogResult = MessageBox.Show("¿Desea cancelar la búsqueda de estudiantes?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If button = DialogResult.Yes Then
            e.Cancel = False
        ElseIf button = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        Try
            'Intentar generar el documento.
            'Se adjunta un texto debajo del encabezado con la fecha actual del sistema.
            ExportarDatosExcel(dgDatosUsuario, "FECHA: " + Now.Date())
        Catch ex As Exception
            'Si el intento es fallido, mostrar MsgBox.
            MessageBox.Show("No se puede generar el documento Excel.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class