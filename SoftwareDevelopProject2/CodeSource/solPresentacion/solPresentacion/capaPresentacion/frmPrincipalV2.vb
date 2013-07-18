'' <summary>
'' Formulario Principal: Formulario Principal de la aplicacion 
'' Debe de heredar del formulario padre
'' </summary>
'' <remarks>Autor: Jonathan Jara Morales/remarks>
Imports solLogica.Gestor

Public Class frmPrincipalV2
    Inherits Form

    Private Sub AddFormInPanel(formHijo As Object)
        panelMenuPrincipal.Visible = False
        Dim fh As Form = formHijo
        fh.TopLevel = False
        fh.FormBorderStyle = FormBorderStyle.None
        fh.Dock = DockStyle.Fill
        Me.panelContenedor.Controls.Add(fh)
        Me.panelContenedor.Tag = fh
        fh.Show()
    End Sub

    Private Sub BuscarUsuarioToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        If validarPermiso("buscarUsuario") Then
            AddFormInPanel(New frmBuscarUsuarios())
        End If
    End Sub

    Private Sub panelContenedor_Paint(sender As System.Object, e As System.Windows.Forms.ControlEventArgs) Handles panelContenedor.ControlRemoved
        panelMenuPrincipal.Visible = True
    End Sub

    Private Sub registrarUsuario_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles registrarUsuario.LinkClicked
        If validarPermiso("registrarUsuario") Then
            AddFormInPanel(New frmRegistrarUsuario())
        End If
    End Sub

    Private Sub buscarUsuario_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles buscarUsuario.LinkClicked
        If validarPermiso("buscarUsuario") Then
            AddFormInPanel(New frmBuscarUsuarios())
        End If
    End Sub

    Private Sub agregarUsuarioBatch_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles agregarUsuarioBatch.LinkClicked
        If validarPermiso("registrarEstudiantesPorBatch") Then
            AddFormInPanel(New frmRegistrarUsuarioTxt())
        End If
    End Sub

    Private Sub registrarCurso_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles registrarCurso.LinkClicked
        If validarPermiso("registrarCurso") Then
            AddFormInPanel(New frmRegistrarCurso())
        End If
    End Sub

    Private Sub buscarCurso_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles buscarCurso.LinkClicked
        If validarPermiso("buscarCursoPorCarrera") Then ''Cambio
            AddFormInPanel(New frmBuscarCurso())
        End If
    End Sub

    Private Sub LinkLabel9_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel9.LinkClicked
        If validarPermiso("buscarCursoPorCarrera") Then ''Cambio
            AddFormInPanel(New frmBuscarCursoCarrera())
        End If
    End Sub

    Private Sub LinkLabel8_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel8.LinkClicked
        If validarPermiso("registrarCursosPorBatch") Then
            AddFormInPanel(New frmRegistrarCursosBatch())
        End If
    End Sub

    Private Sub LinkLabel24_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel24.LinkClicked
        If validarPermiso("registrarRol") Then
            AddFormInPanel(New frmRegistrarRol())
        End If
    End Sub

    Private Sub LinkLabel25_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel25.LinkClicked
        If validarPermiso("listarRol") Then '' Cambio
            AddFormInPanel(New frmListarRol())
        End If
    End Sub


    Private Sub LinkLabel27_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel27.LinkClicked
        If validarPermiso("asignarRolUsuario") Then
            AddFormInPanel(New frmAsignarRolAUsuario())
        End If
    End Sub

    Private Sub LinkLabel5_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        If validarPermiso("registrarCarrera") Then
            AddFormInPanel(New frmRegistrarCarrera())
        End If
    End Sub


    Private Sub LinkLabel4_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        If validarPermiso("buscarCarrera") Then
            AddFormInPanel(New frmBuscarCarrera())
        End If
    End Sub


    Private Sub LinkLabel3_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        If validarPermiso("buscarDirectorAcademicoCarrera") Then
            AddFormInPanel(New frmBuscarDirectorAcademicoCarrera())
        End If
    End Sub

    Private Sub LinkLabel6_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel6.LinkClicked
        If validarPermiso("asignarCursoCarrera") Then
            AddFormInPanel(New frmAsignarCursoCarrera())
        End If
    End Sub

    Private Sub LinkLabel7_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel7.LinkClicked
        If validarPermiso("asignarDirectorAcademico") Then
            AddFormInPanel(New frmAsignarDirectorAcademicoCarrera())
        End If
    End Sub


    Private Sub LinkLabel26_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel26.LinkClicked
        If validarPermiso("listarPermisos") Then ''Ver
            AddFormInPanel(New frmListarPermisos())
        End If
    End Sub


    Private Sub LinkLabel17_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel17.LinkClicked
        If validarPermiso("registrarGrupo") Then
            AddFormInPanel(New frmRegistrarGrupo())
        End If
    End Sub


    Private Sub LinkLabel16_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel16.LinkClicked
        If validarPermiso("buscarGrupo") Then
            AddFormInPanel(New frmBuscarGrupo())
        End If
    End Sub

    Private Sub LinkLabel15_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        If validarPermiso("buscarGrupoPorCurso") Then
            AddFormInPanel(New frmBuscarGruposCurso())
        End If
    End Sub


    Private Sub LinkLabel14_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel14.LinkClicked
        If validarPermiso("buscarEstudiantePorGrupo") Then
            AddFormInPanel(New frmBuscarEstudiantesGrupo())
        End If
    End Sub


    Private Sub LinkLabel10_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel10.LinkClicked
        If validarPermiso("buscarProfesorPorGrupo") Then
            AddFormInPanel(New frmBuscarProfesorAsociadoGrupo())
        End If
    End Sub


    Private Sub LinkLabel13_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel13.LinkClicked
        If validarPermiso("asignarEstudianteGrupo") Then
            AddFormInPanel(New frmAsignarEstudianteGrupo())
        End If
    End Sub

    Private Sub LinkLabel18_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel18.LinkClicked
        If validarPermiso("asignarProfesorGrupo") Then
            AddFormInPanel(New frmAsignarProfesor())
        End If
    End Sub


    Private Sub LinkLabel19_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel19.LinkClicked
        If validarPermiso("listarForo") Then
            AddFormInPanel(New frmListarForos())
        End If
    End Sub


    Private Sub LinkLabel30_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel30.LinkClicked
        AddFormInPanel(New frmAyuda())
    End Sub


    Private Sub LinkLabel29_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel29.LinkClicked
        GestorSesion.cerrarSesion()
        Application.Exit()
    End Sub

End Class