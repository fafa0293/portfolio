<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAsignarEstudianteTema
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
        Me.btnAsignar = New System.Windows.Forms.Button()
        Me.gbEstudiantes = New System.Windows.Forms.GroupBox()
        Me.dgvEstudiantes = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbTema = New System.Windows.Forms.GroupBox()
        Me.lbTemas = New System.Windows.Forms.ListBox()
        Me.gbBusqueda = New System.Windows.Forms.GroupBox()
        Me.lblGrupo = New System.Windows.Forms.Label()
        Me.cbGrupos = New System.Windows.Forms.ComboBox()
        Me.bntBuscar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.gbEstudiantes.SuspendLayout()
        CType(Me.dgvEstudiantes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbTema.SuspendLayout()
        Me.gbBusqueda.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAsignar
        '
        Me.btnAsignar.Image = Global.capaPresentacion.My.Resources.Resources.assign
        Me.btnAsignar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAsignar.Location = New System.Drawing.Point(503, 234)
        Me.btnAsignar.Name = "btnAsignar"
        Me.btnAsignar.Size = New System.Drawing.Size(100, 30)
        Me.btnAsignar.TabIndex = 7
        Me.btnAsignar.Text = "Asignar "
        Me.btnAsignar.UseVisualStyleBackColor = True
        '
        'gbEstudiantes
        '
        Me.gbEstudiantes.Controls.Add(Me.dgvEstudiantes)
        Me.gbEstudiantes.Location = New System.Drawing.Point(34, 127)
        Me.gbEstudiantes.Name = "gbEstudiantes"
        Me.gbEstudiantes.Size = New System.Drawing.Size(463, 279)
        Me.gbEstudiantes.TabIndex = 6
        Me.gbEstudiantes.TabStop = False
        Me.gbEstudiantes.Text = "Estudiante"
        '
        'dgvEstudiantes
        '
        Me.dgvEstudiantes.AllowUserToAddRows = False
        Me.dgvEstudiantes.AllowUserToDeleteRows = False
        Me.dgvEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEstudiantes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.dgvEstudiantes.Location = New System.Drawing.Point(6, 24)
        Me.dgvEstudiantes.Name = "dgvEstudiantes"
        Me.dgvEstudiantes.ReadOnly = True
        Me.dgvEstudiantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEstudiantes.Size = New System.Drawing.Size(451, 246)
        Me.dgvEstudiantes.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "idUsuario"
        Me.Column1.HeaderText = "Id"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
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
        Me.Column5.HeaderText = "Cedula"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'gbTema
        '
        Me.gbTema.Controls.Add(Me.lbTemas)
        Me.gbTema.Location = New System.Drawing.Point(609, 127)
        Me.gbTema.Name = "gbTema"
        Me.gbTema.Size = New System.Drawing.Size(210, 280)
        Me.gbTema.TabIndex = 5
        Me.gbTema.TabStop = False
        Me.gbTema.Text = "Tema"
        '
        'lbTemas
        '
        Me.lbTemas.DisplayMember = "Titulo"
        Me.lbTemas.FormattingEnabled = True
        Me.lbTemas.Location = New System.Drawing.Point(6, 19)
        Me.lbTemas.Name = "lbTemas"
        Me.lbTemas.Size = New System.Drawing.Size(198, 251)
        Me.lbTemas.TabIndex = 0
        '
        'gbBusqueda
        '
        Me.gbBusqueda.Controls.Add(Me.lblGrupo)
        Me.gbBusqueda.Controls.Add(Me.cbGrupos)
        Me.gbBusqueda.Controls.Add(Me.bntBuscar)
        Me.gbBusqueda.Location = New System.Drawing.Point(34, 32)
        Me.gbBusqueda.Name = "gbBusqueda"
        Me.gbBusqueda.Size = New System.Drawing.Size(785, 76)
        Me.gbBusqueda.TabIndex = 4
        Me.gbBusqueda.TabStop = False
        Me.gbBusqueda.Text = "Búsqueda"
        '
        'lblGrupo
        '
        Me.lblGrupo.AutoSize = True
        Me.lblGrupo.Location = New System.Drawing.Point(68, 36)
        Me.lblGrupo.Name = "lblGrupo"
        Me.lblGrupo.Size = New System.Drawing.Size(39, 13)
        Me.lblGrupo.TabIndex = 2
        Me.lblGrupo.Text = "Grupo:"
        '
        'cbGrupos
        '
        Me.cbGrupos.DisplayMember = "Nombre"
        Me.cbGrupos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGrupos.FormattingEnabled = True
        Me.cbGrupos.Location = New System.Drawing.Point(124, 33)
        Me.cbGrupos.Name = "cbGrupos"
        Me.cbGrupos.Size = New System.Drawing.Size(200, 21)
        Me.cbGrupos.TabIndex = 1
        '
        'bntBuscar
        '
        Me.bntBuscar.Image = Global.capaPresentacion.My.Resources.Resources.search
        Me.bntBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bntBuscar.Location = New System.Drawing.Point(469, 27)
        Me.bntBuscar.Name = "bntBuscar"
        Me.bntBuscar.Size = New System.Drawing.Size(100, 30)
        Me.bntBuscar.TabIndex = 0
        Me.bntBuscar.Text = "Buscar"
        Me.bntBuscar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = Global.capaPresentacion.My.Resources.Resources.icono_volver
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(719, 435)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 30)
        Me.btnCancelar.TabIndex = 8
        Me.btnCancelar.Text = "Atrás"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'frmAsignarEstudianteTema
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 530)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAsignar)
        Me.Controls.Add(Me.gbEstudiantes)
        Me.Controls.Add(Me.gbTema)
        Me.Controls.Add(Me.gbBusqueda)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAsignarEstudianteTema"
        Me.Text = "Asignar Estudiante a un Tema."
        Me.gbEstudiantes.ResumeLayout(False)
        CType(Me.dgvEstudiantes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbTema.ResumeLayout(False)
        Me.gbBusqueda.ResumeLayout(False)
        Me.gbBusqueda.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbEstudiantes As System.Windows.Forms.GroupBox
    Friend WithEvents gbTema As System.Windows.Forms.GroupBox
    Friend WithEvents lbTemas As System.Windows.Forms.ListBox
    Friend WithEvents gbBusqueda As System.Windows.Forms.GroupBox
    Friend WithEvents lblGrupo As System.Windows.Forms.Label
    Friend WithEvents cbGrupos As System.Windows.Forms.ComboBox
    Private WithEvents btnAsignar As System.Windows.Forms.Button
    Private WithEvents bntBuscar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents dgvEstudiantes As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
