Imports solLogica.Gestor
Imports solLogica.Estructura

Public Class frmBuscarDirectorAcademicoCarrera
    Private idCarrera As Integer

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
        frmPrincipal.CloseCurrentTab()
    End Sub

    Private Sub frmBuscarDirectorAcademicoCarrera_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Dim button As DialogResult = MessageBox.Show("¿Desea cancelar la búsqueda de los directores académicos?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If button = DialogResult.Yes Then
            e.Cancel = False
            frmPrincipal.CloseCurrentTab()
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim registroSeleccionado As DataGridViewRow = dgDirectoresAcademicos.CurrentRow()
        Dim idUsuario As Integer

        If registroSeleccionado Is Nothing Then
            MessageBox.Show("Debe seleccionar un registro.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        idUsuario = registroSeleccionado.Cells(0).Value
        Dim cedula As String = registroSeleccionado.Cells(1).Value
        Dim carnet As String = registroSeleccionado.Cells(2).Value
        Dim nombre As String = registroSeleccionado.Cells(3).Value
        Dim apellido1 As String = registroSeleccionado.Cells(4).Value
        Dim apellido2 As String = registroSeleccionado.Cells(5).Value
        Dim correoElectronico As String = registroSeleccionado.Cells(6).Value
        Dim direccion As String = registroSeleccionado.Cells(7).Value
        Dim telefonoFijo As String = registroSeleccionado.Cells(8).Value
        Dim telefonoCelular As String = registroSeleccionado.Cells(9).Value
        Dim genero As String = registroSeleccionado.Cells(10).Value
        Dim contrasenna As String = registroSeleccionado.Cells(11).Value
        Dim fechaNacimiento As String = registroSeleccionado.Cells(12).Value

        Dim frm As frmModificarUsuario = New frmModificarUsuario(
                                         idUsuario, nombre, apellido1, apellido2,
                                         carnet, cedula, genero, correoElectronico,
                                         fechaNacimiento, direccion, telefonoFijo, telefonoCelular,
                                         contrasenna)
        If frm.ShowDialog() Then
            ' refrescar lista
            btnBuscar.PerformClick()
        End If
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim titulo As String = "Desasignar director académico"

        Dim registroSeleccionado As DataGridViewRow = dgDirectoresAcademicos.CurrentRow()

        If registroSeleccionado Is Nothing Then
            MessageBox.Show("Debe seleccionar un registro.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim dresult As DialogResult = MessageBox.Show("¿Desea eliminar al director académico de esta carrera? El director académico ya no estará a cargo de la carrera.", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        Try
            Dim idUsuario As Integer = registroSeleccionado.Cells(0).Value
            If dresult = Windows.Forms.DialogResult.Yes Then
                GestorCarrera.eliminarAsignacionDeDirectorAcademico(idUsuario, idCarrera)
                btnBuscar.PerformClick()
                MessageBox.Show("El director académico ya no está a cargo de esta carrera.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

        Catch ex As Exception
            MsgBox("Error: " & ex.ToString(), MsgBoxStyle.Information, titulo)
        End Try
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click

        If cmbCarrera.SelectedIndex < 0 Then
            MessageBox.Show("Debe seleccionar una carrera.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        idCarrera = cmbCarrera.SelectedValue
        dgDirectoresAcademicos.AutoGenerateColumns = False

        Try
            dgDirectoresAcademicos.DataSource = GestorUsuario.buscarDirectorAcademicoPorCarrera(idCarrera)
        Catch ex As Exception
            MsgBox("Error: " & ex.ToString(), MsgBoxStyle.Information, "Error")
        End Try
    End Sub

    Private Sub btnBitacora_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBitacora.Click
        Dim registroSeleccionado As DataGridViewRow = dgDirectoresAcademicos.CurrentRow()

        If registroSeleccionado Is Nothing Then
            MessageBox.Show("Debe seleccionar un registro.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim idUsuario As Integer = registroSeleccionado.Cells(0).Value
        Dim frmMostrarBitacora As frmMostrarBitacora = New frmMostrarBitacora(idUsuario)
        frmMostrarBitacora.Show()
    End Sub

    Private Sub frmBuscarDirectorAcademicoCarrera_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Enter
        cmbCarrera.Focus()
    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        Try
            'Intentar generar el documento.
            'Se adjunta un texto debajo del encabezado con la fecha actual del sistema.
            ExportarDatosExcel(dgDirectoresAcademicos, "FECHA: " + Now.Date())
        Catch ex As Exception
            'Si el intento es fallido, mostrar MsgBox.
            MessageBox.Show("No se puede generar el documento Excel.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmBuscarDirectorAcademicoCarrera_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer = 0

        cmbCarrera.DisplayMember = "Nombre"
        cmbCarrera.ValueMember = "IdCarrera"
        cmbCarrera.DataSource = GestorCarrera.buscarCarreras("", "")

    End Sub
End Class