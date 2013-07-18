<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAsignarRolAUsuario
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
        Me.gbRol = New System.Windows.Forms.GroupBox()
        Me.lbRol = New System.Windows.Forms.ListBox()
        Me.gbUsuario = New System.Windows.Forms.GroupBox()
        Me.dgvUsuario = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAsignar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.gbRol.SuspendLayout()
        Me.gbUsuario.SuspendLayout()
        CType(Me.dgvUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbRol
        '
        Me.gbRol.Controls.Add(Me.lbRol)
        Me.gbRol.Location = New System.Drawing.Point(31, 103)
        Me.gbRol.Name = "gbRol"
        Me.gbRol.Size = New System.Drawing.Size(142, 159)
        Me.gbRol.TabIndex = 0
        Me.gbRol.TabStop = False
        Me.gbRol.Text = "Rol"
        '
        'lbRol
        '
        Me.lbRol.DisplayMember = "Nombre"
        Me.lbRol.FormattingEnabled = True
        Me.lbRol.Location = New System.Drawing.Point(6, 24)
        Me.lbRol.Name = "lbRol"
        Me.lbRol.Size = New System.Drawing.Size(130, 121)
        Me.lbRol.TabIndex = 1
        '
        'gbUsuario
        '
        Me.gbUsuario.Controls.Add(Me.dgvUsuario)
        Me.gbUsuario.Location = New System.Drawing.Point(285, 103)
        Me.gbUsuario.Name = "gbUsuario"
        Me.gbUsuario.Size = New System.Drawing.Size(525, 159)
        Me.gbUsuario.TabIndex = 1
        Me.gbUsuario.TabStop = False
        Me.gbUsuario.Text = "Usuario"
        '
        'dgvUsuario
        '
        Me.dgvUsuario.AllowUserToAddRows = False
        Me.dgvUsuario.AllowUserToDeleteRows = False
        Me.dgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsuario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.Column5, Me.Column2, Me.Column3, Me.Column4})
        Me.dgvUsuario.Location = New System.Drawing.Point(6, 24)
        Me.dgvUsuario.Name = "dgvUsuario"
        Me.dgvUsuario.ReadOnly = True
        Me.dgvUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUsuario.Size = New System.Drawing.Size(514, 121)
        Me.dgvUsuario.TabIndex = 1
        '
        'id
        '
        Me.id.DataPropertyName = "IdUsuario"
        Me.id.HeaderText = "IdUsuario"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "Cedula"
        Me.Column5.HeaderText = "Cédula"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "Nombre"
        Me.Column2.HeaderText = "Nombre"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "Apellido1"
        Me.Column3.HeaderText = "Primer Apellido"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 120
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "Apellido2"
        Me.Column4.HeaderText = "Segundo Apellido"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 120
        '
        'btnAsignar
        '
        Me.btnAsignar.Image = Global.capaPresentacion.My.Resources.Resources.assign
        Me.btnAsignar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAsignar.Location = New System.Drawing.Point(179, 168)
        Me.btnAsignar.Name = "btnAsignar"
        Me.btnAsignar.Size = New System.Drawing.Size(100, 30)
        Me.btnAsignar.TabIndex = 2
        Me.btnAsignar.Text = "Asignar"
        Me.btnAsignar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = Global.capaPresentacion.My.Resources.Resources.icono_volver
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(710, 268)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 30)
        Me.btnCancelar.TabIndex = 3
        Me.btnCancelar.Text = "Atrás"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'frmAsignarRolAUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 473)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAsignar)
        Me.Controls.Add(Me.gbUsuario)
        Me.Controls.Add(Me.gbRol)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAsignarRolAUsuario"
        Me.Text = "Asignar Rol a Usuario"
        Me.gbRol.ResumeLayout(False)
        Me.gbUsuario.ResumeLayout(False)
        CType(Me.dgvUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbRol As System.Windows.Forms.GroupBox
    Friend WithEvents lbRol As System.Windows.Forms.ListBox
    Friend WithEvents gbUsuario As System.Windows.Forms.GroupBox
    Friend WithEvents btnAsignar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents dgvUsuario As System.Windows.Forms.DataGridView
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
