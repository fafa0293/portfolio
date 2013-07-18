Imports solLogica.Gestor

Public Class frmRegistrarGrupo
    Dim isDataSaved As Boolean = False
    Dim curso As List(Of solLogica.Estructura.StrCurso)

    ''' <summary>
    ''' Metodo que validar que los campos del formulario no esten vacios 
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
            MessageBox.Show("Campo requerido. Ingrese el código.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            txtCodigo.Focus()
            Return False
        ElseIf cmbPeriodo.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione el período.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            cmbPeriodo.Select()
            Return False
        ElseIf cmbCarrera.SelectedIndex = -1 Then
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

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub frmRegistrarGrupo_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If isDataSaved = False Then

            Dim button As DialogResult = MessageBox.Show("¿Desea cancelar el registro del grupo?", "Alerta", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning)

            If button = DialogResult.Yes Then
                e.Cancel = False
                frmPrincipal.CloseCurrentTab()
            ElseIf button = DialogResult.No Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub frmRegistrarGrupo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarPeriodos()
        cargarCarreras()
    End Sub

    Private Sub cargarPeriodos()
        cmbPeriodo.Items.Add("I Cuatrimestre")
        cmbPeriodo.Items.Add("II Cuatrimestre")
        cmbPeriodo.Items.Add("III Cuatrimestre")
    End Sub

    Private Sub cargarCarreras()

        cmbCarrera.DisplayMember = "Nombre"
        cmbCarrera.ValueMember = "IdCarrera"
        cmbCarrera.DataSource = GestorCarrera.listarCarreras
        cmbCarrera.SelectedIndex = -1

    End Sub

    Private Sub cargarCursos()
        ' cmbCurso.DataSource = Nothing
        cmbCurso.DisplayMember = "Nombre"
        cmbCurso.ValueMember = "IdCurso"
        ''MessageBox.Show(cmbCarrera)

        cmbCurso.DataSource = GestorCurso.listarCursosPorCarreraId(cmbCarrera.SelectedValue)
      
    End Sub

    Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
        If validar() = True Then
            Dim button As DialogResult = MessageBox.Show("¿Desea realizar el registro del grupo?", "Registrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If button = DialogResult.Yes Then
                Try
                    isDataSaved = True
                    solLogica.Gestor.GestorGrupo.registrarGrupo(cmbCurso.SelectedValue, txtCodigo.Text, txtNombre.Text, cmbPeriodo.SelectedItem)
                    MessageBox.Show("Se ha registrado el grupo con éxito.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                Catch ex As Exception
                    solLogica.Gestor.GestorGrupo.modificarGrupo(GestorGrupo.buscarGrupoExistente(txtCodigo.Text), cmbCurso.SelectedValue, txtCodigo.Text, txtNombre.Text, cmbPeriodo.SelectedItem, False)
                    MessageBox.Show("Se ha registrado el grupo con éxito.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()

                End Try
                
            End If

        End If
    End Sub

    Private Sub cmbCurso_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCarrera.SelectedIndexChanged
        cargarCursos()
    End Sub

   
End Class
