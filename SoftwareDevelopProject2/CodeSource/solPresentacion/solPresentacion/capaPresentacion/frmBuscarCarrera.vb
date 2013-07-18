Imports solLogica.Gestor

'' <remarks>Autor: Ernesto Villalobos Cordero/remarks>

Public Class frmBuscarCarrera

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Dim nombreCarrera, codigoCarrera As String

        nombreCarrera = ""
        codigoCarrera = ""

        If rbCodigoCarrera.Checked Then
            codigoCarrera = txtCodigoNombre.Text
        End If

        If rbNombreCarrera.Checked Then
            nombreCarrera = txtCodigoNombre.Text
        End If

        Try
            dgCarreras.AutoGenerateColumns = False
            dgCarreras.DataSource = GestorCarrera.buscarCarreras(nombreCarrera, codigoCarrera)
        Catch ex As Exception
            MsgBox("Error: " & ex.ToString(), MsgBoxStyle.Information, "Error")
        End Try

        txtCodigoNombre.Focus()
    End Sub

    Private Sub btnCancelar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Dim registroSeleccionado As DataGridViewRow = dgCarreras.CurrentRow

        If validarPermiso("modificarCarrera") = False Then
            Return
        End If

        If registroSeleccionado Is Nothing Then
            MessageBox.Show("Debe seleccionar un registro.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim idCarrera As Integer = registroSeleccionado.Cells(0).Value
        Dim nombre As String = registroSeleccionado.Cells(2).Value
        If validarPermiso("modificarUsuario") Then
            Dim frm As frmModificarCarrera = New frmModificarCarrera(
                                         idCarrera,
                                         nombre)

            If frm.ShowDialog() Then
                ' lista las carreras de nuevo
                btnBuscar.PerformClick()
            End If
        End If
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim titulo As String = "Eliminar Carrera"
        Dim registroSeleccionado As DataGridViewRow = dgCarreras.CurrentRow
        Dim idCarrera As Integer

        If validarPermiso("eliminarCarrera") = False Then
            Return
        End If

        If registroSeleccionado Is Nothing Then
            MessageBox.Show("Debe seleccionar un registro.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        idCarrera = CType(registroSeleccionado.Cells(0).Value, Integer)
        ' insertar codigo de obtener id de carrera aqui
        Dim dresult As DialogResult = MessageBox.Show("¿Desea realizar la eliminación de la carrera?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        Try
            If dresult = Windows.Forms.DialogResult.Yes Then
                If validarPermiso("eliminarUsuario") Then
                    GestorCarrera.eliminarCarrera(idCarrera)
                    ' lista las carreras de nuevo
                    btnBuscar.PerformClick()
                    MessageBox.Show("Se ha eliminado la carrera.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        Try
            'Intentar generar el documento.
            'Se adjunta un texto debajo del encabezado con la fecha actual del sistema.
            ExportarDatosExcel(dgCarreras, "FECHA: " + Now.Date())
        Catch ex As Exception
            'Si el intento es fallido, mostrar MsgBox.
            MessageBox.Show("No se puede generar el documento Excel.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If frmRegistrarCarrera.ShowDialog() Then
            ' lista las carreras de nuevo
            btnBuscar.PerformClick()
        End If

    End Sub

    Private Sub frmBuscarCarrera_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        RadioButton1.Checked = True
        txtCodigoNombre.Enabled = False
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            txtCodigoNombre.Enabled = False
        Else
            txtCodigoNombre.Enabled = True
        End If
    End Sub
End Class