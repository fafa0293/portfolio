Public Class frmMdiContainer

    Private Sub frmMdiContainer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim f = New frmAsignarProfesor
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub MariaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MariaToolStripMenuItem.Click
        Dim f = New frmBuscarUsuarios
        f.MdiParent = Me
        f.Show()
    End Sub
End Class
