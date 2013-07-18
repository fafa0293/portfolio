<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAsignarEstudianteGrupo
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
        Me.gbBusqueda = New System.Windows.Forms.GroupBox()
        Me.lblCurso = New System.Windows.Forms.Label()
        Me.cbCurso = New System.Windows.Forms.ComboBox()
        Me.bntBuscar = New System.Windows.Forms.Button()
        Me.gbGrupo = New System.Windows.Forms.GroupBox()
        Me.lbGrupos = New System.Windows.Forms.ListBox()
        Me.gbEstudiantes = New System.Windows.Forms.GroupBox()
        Me.dgvEstudiantes = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAsignar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.gbBusqueda.SuspendLayout()
        Me.gbGrupo.SuspendLayout()
        Me.gbEstudiantes.SuspendLayout()
        CType(Me.dgvEstudiantes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbBusqueda
        '
        Me.gbBusqueda.Controls.Add(Me.lblCurso)
        Me.gbBusqueda.Controls.Add(Me.cbCurso)
        Me.gbBusqueda.Controls.Add(Me.bntBuscar)
        Me.gbBusqueda.Location = New System.Drawing.Point(45, 45)
        Me.gbBusqueda.Name = "gbBusqueda"
        Me.gbBusqueda.Size = New System.Drawing.Size(774, 66)
        Me.gbBusqueda.TabIndex = 0
        Me.gbBusqueda.TabStop = False
        Me.gbBusqueda.Text = "Búsqueda"
        '
        'lblCurso
        '
        Me.lblCurso.AutoSize = True
        Me.lblCurso.Location = New System.Drawing.Point(84, 29)
        Me.lblCurso.Name = "lblCurso"
        Me.lblCurso.Size = New System.Drawing.Size(37, 13)
        Me.lblCurso.TabIndex = 2
        Me.lblCurso.Text = "Curso:"
        '
        'cbCurso
        '
        Me.cbCurso.AutoCompleteCustomSource.AddRange(New String() {""})
        Me.cbCurso.DisplayMember = "Nombre"
        Me.cbCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCurso.FormattingEnabled = True
        Me.cbCurso.Location = New System.Drawing.Point(127, 26)
        Me.cbCurso.Name = "cbCurso"
        Me.cbCurso.Size = New System.Drawing.Size(200, 21)
        Me.cbCurso.TabIndex = 1
        '
        'bntBuscar
        '
        Me.bntBuscar.Image = Global.capaPresentacion.My.Resources.Resources.search
        Me.bntBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bntBuscar.Location = New System.Drawing.Point(489, 20)
        Me.bntBuscar.Name = "bntBuscar"
        Me.bntBuscar.Size = New System.Drawing.Size(100, 30)
        Me.bntBuscar.TabIndex = 0
        Me.bntBuscar.Text = "Buscar"
        Me.bntBuscar.UseVisualStyleBackColor = True
        '
        'gbGrupo
        '
        Me.gbGrupo.Controls.Add(Me.lbGrupos)
        Me.gbGrupo.Location = New System.Drawing.Point(640, 127)
        Me.gbGrupo.Name = "gbGrupo"
        Me.gbGrupo.Size = New System.Drawing.Size(179, 280)
        Me.gbGrupo.TabIndex = 1
        Me.gbGrupo.TabStop = False
        Me.gbGrupo.Text = "Grupo"
        '
        'lbGrupos
        '
        Me.lbGrupos.DisplayMember = "Nombre"
        Me.lbGrupos.FormattingEnabled = True
        Me.lbGrupos.Location = New System.Drawing.Point(6, 24)
        Me.lbGrupos.Name = "lbGrupos"
        Me.lbGrupos.Size = New System.Drawing.Size(165, 251)
        Me.lbGrupos.TabIndex = 0
        '
        'gbEstudiantes
        '
        Me.gbEstudiantes.Controls.Add(Me.dgvEstudiantes)
        Me.gbEstudiantes.Location = New System.Drawing.Point(45, 128)
        Me.gbEstudiantes.Name = "gbEstudiantes"
        Me.gbEstudiantes.Size = New System.Drawing.Size(483, 279)
        Me.gbEstudiantes.TabIndex = 2
        Me.gbEstudiantes.TabStop = False
        Me.gbEstudiantes.Text = "Estudiante"
        '
        'dgvEstudiantes
        '
        Me.dgvEstudiantes.AllowUserToAddRows = False
        Me.dgvEstudiantes.AllowUserToDeleteRows = False
        Me.dgvEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEstudiantes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.dgvEstudiantes.Location = New System.Drawing.Point(6, 19)
        Me.dgvEstudiantes.Name = "dgvEstudiantes"
        Me.dgvEstudiantes.ReadOnly = True
        Me.dgvEstudiantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEstudiantes.Size = New System.Drawing.Size(471, 254)
        Me.dgvEstudiantes.TabIndex = 0
        '
        'id
        '
        Me.id.DataPropertyName = "IdUsuario"
        Me.id.HeaderText = "IdUsuario"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
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
        'Column5
        '
        Me.Column5.DataPropertyName = "Cedula"
        Me.Column5.HeaderText = "Cédula"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'btnAsignar
        '
        Me.btnAsignar.Image = Global.capaPresentacion.My.Resources.Resources.assign
        Me.btnAsignar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAsignar.Location = New System.Drawing.Point(534, 233)
        Me.btnAsignar.Name = "btnAsignar"
        Me.btnAsignar.Size = New System.Drawing.Size(100, 30)
        Me.btnAsignar.TabIndex = 3
        Me.btnAsignar.Text = "Asignar "
        Me.btnAsignar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = Global.capaPresentacion.My.Resources.Resources.icono_volver
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(711, 434)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 30)
        Me.btnCancelar.TabIndex = 4
        Me.btnCancelar.Text = "Atrás"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'frmAsignarEstudianteGrupo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 492)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAsignar)
        Me.Controls.Add(Me.gbEstudiantes)
        Me.Controls.Add(Me.gbGrupo)
        Me.Controls.Add(Me.gbBusqueda)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAsignarEstudianteGrupo"
        Me.Text = "Asignar Estudiante a Grupo"
        Me.gbBusqueda.ResumeLayout(False)
        Me.gbBusqueda.PerformLayout()
        Me.gbGrupo.ResumeLayout(False)
        Me.gbEstudiantes.ResumeLayout(False)
        CType(Me.dgvEstudiantes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbBusqueda As System.Windows.Forms.GroupBox
    Friend WithEvents lblCurso As System.Windows.Forms.Label
    Friend WithEvents cbCurso As System.Windows.Forms.ComboBox
    Friend WithEvents bntBuscar As System.Windows.Forms.Button
    Friend WithEvents gbGrupo As System.Windows.Forms.GroupBox
    Friend WithEvents lbGrupos As System.Windows.Forms.ListBox
    Friend WithEvents gbEstudiantes As System.Windows.Forms.GroupBox
    Friend WithEvents btnAsignar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents dgvEstudiantes As System.Windows.Forms.DataGridView
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
