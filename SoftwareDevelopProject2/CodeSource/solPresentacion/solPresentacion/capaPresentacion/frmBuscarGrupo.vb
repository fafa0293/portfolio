Imports solLogica.Gestor
Public Class frmBuscarGrupo
    Dim estaConFilas As Boolean = False
    Dim estaSeleccionada As Boolean = False

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        estaConFilas = True
        'dgDatosGrupo.Rows.Clear()

        If rbCodigo.Checked And txtNombreCodigo.Text.Trim.Equals("") = False Then
            dgDatosGrupo.DataSource = solLogica.Gestor.GestorGrupo.buscarGrupoPorCodigo(txtNombreCodigo.Text)
        ElseIf rbNombre.Checked And txtNombreCodigo.Text.Trim.Equals("") = False Then
            dgDatosGrupo.DataSource = solLogica.Gestor.GestorGrupo.buscarGrupoPorNombre(txtNombreCodigo.Text)
        ElseIf rbCurso.Checked And cmbCurso.SelectedIndex <> -1 Then
            dgDatosGrupo.DataSource = GestorGrupo.listarGruposPorCursoId(cmbCurso.SelectedValue)
        Else
            dgDatosGrupo.DataSource = solLogica.Gestor.GestorGrupo.buscarGrupos()
        End If
        

    End Sub


    ''' <summary>
    ''' Metodo para validar que los campos del formulario no esten vacios 
    ''' y cumplan con el formato correcto.
    ''' </summary>
    ''' <returns>Valor booleano.</returns>
    ''' <remarks>Autor: Dylhann Obando</remarks>
    Private Function validar()
        Return True
    End Function



    Private Sub btnEliminar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If validarDataGrid() Then
            If validarPermiso("eliminarGrupo") = False Then
                Return
            End If

            Dim button As DialogResult = MessageBox.Show("¿Desea realizar la eliminación del grupo?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If button = DialogResult.Yes Then
                Try
                    GestorGrupo.eliminarGrupo(dgDatosGrupo.SelectedRows(0).Cells(2).Value)
                Catch ex As Exception

                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End Try

                dgDatosGrupo.DataSource = GestorGrupo.buscarGrupos()

            End If

        Else
            MessageBox.Show("Debe seleccionar un registro.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End If
        
    End Sub

    ''' <summary>
    ''' Metodo para validar que hayan registros en datagrid.
    ''' </summary>
    ''' <returns>Valor booleano.</returns>
    ''' <remarks>Autor: Dylhann Obando</remarks>
    Private Function validarDataGrid()
        If dgDatosGrupo.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function


    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        If validarDataGrid() Then

            If validarPermiso("modificarGrupo") = False Then
                Return
            End If

            Dim modificarGrupo As frmModicarGrupo = New frmModicarGrupo(dgDatosGrupo.Item(2, dgDatosGrupo.CurrentRow.Index).Value,
              dgDatosGrupo.Item(0, dgDatosGrupo.CurrentRow.Index).Value,
              dgDatosGrupo.Item(3, dgDatosGrupo.CurrentRow.Index).Value.ToString,
              dgDatosGrupo.Item(1, dgDatosGrupo.CurrentRow.Index).Value.ToString,
              dgDatosGrupo.Item(4, dgDatosGrupo.CurrentRow.Index).Value.ToString,
              dgDatosGrupo.Item(5, dgDatosGrupo.CurrentRow.Index).Value.ToString,
              Me)
            modificarGrupo.ShowDialog()
        Else
            MessageBox.Show("Debe seleccionar un registro.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End If

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        If validarDataGrid() Then
            Try
                'Intentar generar el documento.
                'Se adjunta un texto debajo del encabezado con la fecha actual del sistema.
                ExportarDatosExcel(dgDatosGrupo, "FECHA: " + Now.Date())
            Catch ex As Exception
                'Si el intento es fallido, mostrar MsgBox.
                MessageBox.Show("No se puede generar el documento Excel.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("No hay registros para exportar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End If
    End Sub

    Private Sub frmBuscarGrupo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dgDatosGrupo.DataSource = GestorGrupo.buscarGrupos()
        cmbCurso.DataSource = GestorCurso.listarCursos()
        cmbCurso.ValueMember = "IdCurso"
        cmbCurso.SelectedIndex = -1
    End Sub
End Class