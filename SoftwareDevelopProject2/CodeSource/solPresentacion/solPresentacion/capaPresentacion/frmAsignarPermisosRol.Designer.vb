<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAsignarPermisosRol
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAsignarPermisosRol))
        Me.gbPermisosRol = New System.Windows.Forms.GroupBox()
        Me.clListaPermisos = New System.Windows.Forms.CheckedListBox()
        Me.btnAsignar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.gbPermisosRol.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbPermisosRol
        '
        Me.gbPermisosRol.Controls.Add(Me.clListaPermisos)
        Me.gbPermisosRol.Location = New System.Drawing.Point(30, 30)
        Me.gbPermisosRol.Margin = New System.Windows.Forms.Padding(2)
        Me.gbPermisosRol.Name = "gbPermisosRol"
        Me.gbPermisosRol.Padding = New System.Windows.Forms.Padding(2)
        Me.gbPermisosRol.Size = New System.Drawing.Size(247, 186)
        Me.gbPermisosRol.TabIndex = 0
        Me.gbPermisosRol.TabStop = False
        Me.gbPermisosRol.Text = "Permisos del Rol"
        '
        'clListaPermisos
        '
        Me.clListaPermisos.FormattingEnabled = True
        Me.clListaPermisos.Location = New System.Drawing.Point(6, 19)
        Me.clListaPermisos.Name = "clListaPermisos"
        Me.clListaPermisos.Size = New System.Drawing.Size(234, 154)
        Me.clListaPermisos.TabIndex = 0
        '
        'btnAsignar
        '
        Me.btnAsignar.Image = CType(resources.GetObject("btnAsignar.Image"), System.Drawing.Image)
        Me.btnAsignar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAsignar.Location = New System.Drawing.Point(36, 220)
        Me.btnAsignar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAsignar.Name = "btnAsignar"
        Me.btnAsignar.Size = New System.Drawing.Size(100, 30)
        Me.btnAsignar.TabIndex = 1
        Me.btnAsignar.Text = "Asignar"
        Me.btnAsignar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(177, 220)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 30)
        Me.btnCancelar.TabIndex = 2
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'frmAsignarPermisosRol
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(316, 276)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.gbPermisosRol)
        Me.Controls.Add(Me.btnAsignar)
        Me.Name = "frmAsignarPermisosRol"
        Me.Text = "Asignar Permisos a Rol"
        Me.gbPermisosRol.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbPermisosRol As System.Windows.Forms.GroupBox
    Friend WithEvents btnAsignar As System.Windows.Forms.Button
    Friend WithEvents clListaPermisos As System.Windows.Forms.CheckedListBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
End Class
