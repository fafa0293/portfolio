Imports solLogica.Gestor
Public Class frmModicarGrupo

    Dim isDataSaved As Boolean = False
    Private idGrupo
    Private _frmBuscarGrupo As frmBuscarGrupo
    Private _frmBuscarGrupoPorCurso As frmBuscarGruposCurso

    Public Sub New(ByVal idGrupo As Integer, ByVal idCurso As Integer, ByVal nombre As String,
                   ByVal codigo As String, ByVal nombreCurso As String, ByVal periodo As String, ByRef frmBuscarGrupo As frmBuscarGrupo)
        InitializeComponent()
        Me.idGrupo = idGrupo
        _frmBuscarGrupo = frmBuscarGrupo
        _frmBuscarGrupoPorCurso = frmBuscarGruposCurso
        cargarPeriodos()

        Dim lista As Dictionary(Of String, String) = New Dictionary(Of String, String)
        lista.Add(idCurso, nombreCurso)
        cmbCurso.DataSource = New BindingSource(lista, Nothing)
        cmbCurso.DisplayMember = "Value"
        cmbCurso.ValueMember = "Key"
        txtCodigo.Text = codigo
        txtNombre.Text = nombre
        Dim i As Integer
        For i = 0 To cmbPeriodo.GetItemText(i).Equals(periodo)
            cmbPeriodo.SelectedIndex = i
        Next
    End Sub

    


    Private Sub cargarPeriodos()
        cmbPeriodo.Items.Add("I Cuatrimestre")
        cmbPeriodo.Items.Add("II Cuatrimestre")
        cmbPeriodo.Items.Add("III Cuatrimestre")
    End Sub

    Private Sub cargarCarreras()

        'cmbCarrera.DisplayMember = "Nombre"
        'cmbCarrera.ValueMember = "IdCarrera"
        cmbCarrera.DataSource = GestorCarrera.listarCarreras
        cmbCarrera.SelectedIndex = -1
        cargarCursos()
    End Sub

    Private Sub cargarCursos()
        ' cmbCurso.DataSource = Nothing
        

        cmbCurso.DataSource = GestorCurso.listarCursosPorCarreraId(cmbCarrera.SelectedValue)
        cmbCurso.DisplayMember = "Nombre"
        cmbCurso.ValueMember = "IdCurso"
        cmbCurso.SelectedIndex = -1
    End Sub

    ''' <summary>
    ''' Metodo para validar que los campos del formulario no esten vacios 
    ''' y cumplan con el formato correcto.
    ''' </summary>
    ''' <returns>Valor booleano.</returns>
    ''' <remarks>Autor: Dylhann Obando</remarks>
    Private Function validar()
        If txtNombre.Text.Trim.Equals("") Then
            MessageBox.Show("Campo requerido. Ingrese el nombre.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            txtNombre.Focus()
            Return False
        ElseIf txtCodigo.Text.Trim.Equals("") Then
            MessageBox.Show("Campo requerido.Ingresar el código.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            txtCodigo.Focus()
            Return False
        ElseIf cmbPeriodo.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione el período.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            cmbPeriodo.Select()
            Return False
        ElseIf cmbCarrera.SelectedIndex = -1 And cmbCurso.SelectedItem.ToString.Trim.Equals("") Then
            MessageBox.Show("Seleccione una carrera.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            cmbCarrera.Select()
            Return False
        ElseIf cmbCurso.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione un curso.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            cmbCurso.Select()
            Return False
        End If
        Return True
    End Function

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub frmModficarGrupo_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If isDataSaved = False Then

            Dim button As DialogResult = MessageBox.Show("¿Desea cancelar la modificación del grupo?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If button = DialogResult.Yes Then
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        End If
    End Sub '

    Private Sub frmModificarGrupo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'cargarPeriodos()
        ' cargarCarreras()
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        If validar() Then
            Dim button As DialogResult = MessageBox.Show("¿Desea realizar la modificación del grupo?", "Modificar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If button = DialogResult.Yes Then
                isDataSaved = True

                Dim estado As Boolean

                If cmbEstado.SelectedItem.Equals("Abierto") Then
                    estado = True
                Else
                    estado = False
                End If

                solLogica.Gestor.GestorGrupo.modificarGrupo(idGrupo, cmbCurso.SelectedValue, txtCodigo.Text, txtNombre.Text, cmbPeriodo.SelectedItem, estado)
                If _frmBuscarGrupo IsNot Nothing Then
                    _frmBuscarGrupo.btnBuscar.PerformClick()
                ElseIf _frmBuscarGrupoPorCurso IsNot Nothing Then
                    _frmBuscarGrupoPorCurso.btnBuscar.PerformClick()
                End If
                MessageBox.Show("Se ha modificado el grupo con éxito.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If
        End If
    End Sub

    Private Sub btnCerrar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub


    Private Sub cmbCarrera_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCarrera.SelectedIndexChanged
        cargarCursos()
    End Sub

   
    Private Sub cmbCarrera_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles cmbCarrera.MouseClick
        cargarCarreras()
    End Sub
End Class