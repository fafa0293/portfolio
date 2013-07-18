'' <summary>
'' Formulario Buscar Profesor Asociado a un Grupo: Realiza una busqueda de los profesores
'' </summary>
'' <remarks>Autor: Jonathan Jara Morales/remarks>
Imports solLogica.Gestor

Public Class frmBuscarProfesorAsociadoGrupo
    Dim idGrupo As Integer

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub frmBuscarProfesorAsociadoGrupo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarListas()
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If cmbGrupo.SelectedIndex > -1 Then
            Try

                dgDatosUsuario.AutoGenerateColumns = False
                dgDatosUsuario.DataSource = GestorUsuario.listarProfesoresPorGrupoId(cmbGrupo.SelectedValue())
            Catch ex As Exception
                MsgBox("Error: " & ex.ToString(), MsgBoxStyle.Information, "Error")
            End Try
            cmbGrupo.Focus()
        End If
    End Sub

    '' <summary>
    '' cargarListas: Carga la Lista de los grupos
    '' </summary>
    '' <remarks>Autor: Jonathan Jara Morales</remarks>
    Private Sub cargarListas()
        Try
            cmbGrupo.DataSource = GestorGrupo.listarGrupos()
            cmbGrupo.ValueMember = "IdGrupo"
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnExportar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        Try
            ExportarDatosExcel(dgDatosUsuario, "FECHA: " + Now.Date())
        Catch ex As Exception
             MessageBox.Show("No se puede generar el documento Excel.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim idProfesor As Integer = dgDatosUsuario.SelectedRows(0).Cells(0).Value
            Dim button As DialogResult = MessageBox.Show("¿Desea desasignar al profesor del grupo?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If button = DialogResult.Yes Then
                Try
                    GestorGrupo.eliminarAsignacionProfesor(idGrupo, idProfesor)
                    MsgBox("Se ha desasignado el profesor del grupo", MsgBoxStyle.OkOnly, "Alerta")
                    btnBuscar.PerformClick()
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Try
                
            End If

        Catch ex As Exception
            MessageBox.Show("Debe seleccionar un registro.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
End Class