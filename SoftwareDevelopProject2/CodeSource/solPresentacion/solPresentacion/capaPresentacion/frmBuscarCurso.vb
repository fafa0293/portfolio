Imports solLogica.Gestor

Public Class frmBuscarCurso
    Dim _criterio As String
    Dim _idCurso As Integer
    Dim _codigoCurso As String
    Dim _nombreCurso As String
    Dim _creditos As Integer
    Dim _estado As String
    Dim id_Curso As Int16

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub


    Private Sub frmBuscarCurso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtCriterio.Focus()
        RadioButton1.Checked = True

        If RadioButton1.Checked = True Then
            txtCriterio.Enabled = False
        End If

    End Sub
    ''' <summary>
    ''' Método de clase, encarga de evaluar el tipo de busqueda
    ''' </summary>
    ''' <remarks>Autor: Christopher Vargas</remarks>
    Private Sub evaluar()

        If rbCodigoCarrera.Checked Then
            _criterio = "Codigo"
        End If

        If rbNombreCarrera.Checked Then
            _criterio = "Nombre"
        End If

        If RadioButton1.Checked Then
            _criterio = "Todos"
        End If
    End Sub
    ''' <summary>
    ''' Método de clase, encarga de evaluar que no queden espacios en blanco ningún componente
    ''' </summary>
    ''' <returns name="_result">retorna un valor boolean</returns>
    ''' <remarks>Autor:Christopher Vargas</remarks>
    Private Function validarCampos() As Boolean
        Dim _result = True

        If RadioButton1.Checked Then
            _result = True
        End If

        If rbCodigoCarrera.Checked = True And txtCriterio.Text.Trim.Length = 0 Then
            MsgBox("Debe ingresar el criterio para poder realizar la búsqueda", MsgBoxStyle.Information, "Buscar Curso")
            txtCriterio.Focus()
            _result = False
        End If

        If rbNombreCarrera.Checked = True And txtCriterio.Text.Trim() = "" Then
            MsgBox("Debe ingresar el criterio para poder realizar la búsqueda", MsgBoxStyle.Information, "Buscar Curso")
            txtCriterio.Focus()
            _result = False
        End If

        Return _result
    End Function
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        evaluar()
        Me.dgvCursos.AutoGenerateColumns = False

        If validarCampos() Then
            If _criterio = "Codigo" Then
                Me.dgvCursos.DataSource = GestorCurso.buscarCursoPorCodigo(Me.txtCriterio.Text)
            ElseIf _criterio = "Nombre" Then
                Me.dgvCursos.DataSource = GestorCurso.buscarCursoPorNombre(Me.txtCriterio.Text)
            ElseIf _criterio = "Todos" Then
                Me.dgvCursos.DataSource = GestorCurso.buscarCursoPorNombre("")
            End If
        End If

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If validarPermiso("eliminarCurso") = False Then
            Return
        End If

        Dim nombreCurso As String

        If Not dgvCursos.RowCount = 0 Then

            id_Curso = Me.dgvCursos.SelectedCells(0).Value
            nombreCurso = Me.dgvCursos.SelectedCells(1).Value

            Dim _result As DialogResult
            _result = MessageBox.Show("¿Está seguro que desea eliminar el curso de " & nombreCurso & "?", "Eliminar curso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, 0, False)
            Try
                If _result = Windows.Forms.DialogResult.Yes Then
                    GestorCurso.eliminarCurso(id_Curso)
                    MsgBox("Los datos del curso se han eliminado.", MsgBoxStyle.Information, "Eliminar curso")
                    btnBuscar.PerformClick()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        Else
            MsgBox("Debe seleccionar un Curso, para procesar la eliminación", MsgBoxStyle.Information, "Eliminar curso")
        End If
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        If validarPermiso("modificarCurso") = False Then
            Return
        End If

        If Not dgvCursos.RowCount = 0 Then
            _idCurso = dgvCursos.SelectedCells(0).Value
            _codigoCurso = dgvCursos.SelectedCells(1).Value
            _nombreCurso = dgvCursos.SelectedCells(2).Value
            _creditos = dgvCursos.SelectedCells(3).Value
            _estado = dgvCursos.SelectedCells(4).Value

            Try
                Dim _modificarCurso As New frmModificarCurso(_idCurso, _codigoCurso, _nombreCurso, _creditos, _estado)
             
                If _modificarCurso.ShowDialog() Then
                    btnBuscar.PerformClick()
                End If

            Catch ex As Exception
                MsgBox("Error, no se puede Modificar." & ex.Message, MsgBoxStyle.Information, "Modificar")
            End Try

        Else
            MsgBox("Debe seleccionar un Curso, para realizar una modificación", MsgBoxStyle.Information, "Buscar curso")
        End If

        

    End Sub

    Private Sub btnCAncelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCAncelar.Click
        Me.Close()
    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        If Not dgvCursos.RowCount = 0 Then
            Try
                ExportarDatosExcel(dgvCursos, "FECHA: " + Now.Date())
            Catch ex As Exception
                MessageBox.Show("No se puede generar el documento Excel.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MsgBox("Debe seleccionar un Curso, para exportar", MsgBoxStyle.Information, "Exportar")
        End If

    End Sub

    Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _registrarCurso As New frmRegistrarCurso()
        _registrarCurso.Show()
    End Sub

    ''' <summary>
    ''' Método de clase, encarga de limpiar el formulario de Buscar
    ''' </summary>
    ''' <remarks>Autor: Christopher Vargas</remarks>
    Private Sub limpiarFormulario()
        Me.txtCriterio.Text = ""
        Me.dgvCursos.DataSource = ""
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton1.CheckedChanged

        If RadioButton1.Checked = True Then
            txtCriterio.Enabled = False
        Else
            txtCriterio.Enabled = True
        End If

    End Sub
End Class