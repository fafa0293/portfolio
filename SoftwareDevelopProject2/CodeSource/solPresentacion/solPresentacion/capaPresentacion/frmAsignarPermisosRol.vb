Imports solLogica.Gestor

Public Class frmAsignarPermisosRol

    Private isDataSaved As Boolean = False
    Private idRol As Integer

    Sub New(ByVal idRol As Integer)
        InitializeComponent()
        Me.idRol = idRol
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub frmAsignarPermisosRol_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Dim result As DialogResult
        Dim titulo As String = Me.gbPermisosRol.Text

        If isDataSaved Then
            Return
        End If

        result = MessageBox.Show("¿Está seguro que desea cancelar la asignación?", titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, 0, False)

        Try
            If result <> Windows.Forms.DialogResult.Yes Then
                e.Cancel = True
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnAsignar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsignar.Click

        Dim titulo As String = Me.gbPermisosRol.Text
        Dim dresult As DialogResult = MessageBox.Show("¿Desea realizar la asignación?", "Asignar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        Try
            If dresult = Windows.Forms.DialogResult.Yes Then
                Dim idsPermisos As List(Of Integer) = New List(Of Integer)

                For Each permiso As Object In clListaPermisos.CheckedItems()
                    idsPermisos.Add(permiso.IdPermiso)
                Next

                GestorRol.asignarPermisosARol(idsPermisos, idRol)

                MsgBox("Los permisos del rol se han asignado.", MsgBoxStyle.Information, titulo)
                Me.isDataSaved = True
                Me.Close()
            End If

        Catch ex As Exception
            MsgBox("Los datos seleccionados para la asignación ya estan asignados en la base de datos.", MsgBoxStyle.Information, "Asignar")
        End Try
    End Sub

    Private Sub frmAsignarPermisosRol_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' prueba
        clListaPermisos.DisplayMember = "Descripcion"
        Dim i As Integer = 0
        For Each permiso As Hashtable In GestorPermiso.buscarPermisosPorRolIU(idRol)

            clListaPermisos.Items.Add(permiso("permiso"))

            If permiso("checked") Then
                clListaPermisos.SetItemChecked(i, True)
            End If

            i += 1
        Next

    End Sub
End Class