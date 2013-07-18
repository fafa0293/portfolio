<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarGruposCurso
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuscarGruposCurso))
        Me.gbBusqueda = New System.Windows.Forms.GroupBox()
        Me.cmbCurso = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.gbResul = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnExportar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.dgResul = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idCur = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cdGrupo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_grupo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreCurso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Periodo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Activo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbBusqueda.SuspendLayout()
        Me.gbResul.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgResul, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbBusqueda
        '
        Me.gbBusqueda.Controls.Add(Me.cmbCurso)
        Me.gbBusqueda.Controls.Add(Me.Label1)
        Me.gbBusqueda.Controls.Add(Me.btnBuscar)
        Me.gbBusqueda.Location = New System.Drawing.Point(19, 14)
        Me.gbBusqueda.Name = "gbBusqueda"
        Me.gbBusqueda.Size = New System.Drawing.Size(711, 81)
        Me.gbBusqueda.TabIndex = 6
        Me.gbBusqueda.TabStop = False
        Me.gbBusqueda.Text = "Búsqueda"
        '
        'cmbCurso
        '
        Me.cmbCurso.DisplayMember = "Nombre"
        Me.cmbCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCurso.FormattingEnabled = True
        Me.cmbCurso.Location = New System.Drawing.Point(106, 31)
        Me.cmbCurso.Name = "cmbCurso"
        Me.cmbCurso.Size = New System.Drawing.Size(193, 21)
        Me.cmbCurso.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Curso:"
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(568, 24)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(100, 30)
        Me.btnBuscar.TabIndex = 9
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnCancelar.Image = Global.capaPresentacion.My.Resources.Resources.icono_volver
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(587, 366)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 30)
        Me.btnCancelar.TabIndex = 8
        Me.btnCancelar.Text = "Atrás"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'gbResul
        '
        Me.gbResul.Controls.Add(Me.GroupBox3)
        Me.gbResul.Controls.Add(Me.dgResul)
        Me.gbResul.Location = New System.Drawing.Point(19, 102)
        Me.gbResul.Name = "gbResul"
        Me.gbResul.Size = New System.Drawing.Size(711, 246)
        Me.gbResul.TabIndex = 7
        Me.gbResul.TabStop = False
        Me.gbResul.Text = "Resultado"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnExportar)
        Me.GroupBox3.Controls.Add(Me.btnModificar)
        Me.GroupBox3.Controls.Add(Me.btnEliminar)
        Me.GroupBox3.Location = New System.Drawing.Point(550, 38)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(140, 172)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Opciones"
        '
        'btnExportar
        '
        Me.btnExportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnExportar.Image = CType(resources.GetObject("btnExportar.Image"), System.Drawing.Image)
        Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExportar.Location = New System.Drawing.Point(18, 118)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(100, 30)
        Me.btnExportar.TabIndex = 3
        Me.btnExportar.Text = "Exportar"
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificar.Location = New System.Drawing.Point(18, 38)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(100, 30)
        Me.btnModificar.TabIndex = 1
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.Location = New System.Drawing.Point(18, 78)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(100, 30)
        Me.btnEliminar.TabIndex = 0
        Me.btnEliminar.Text = "Desasignar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'dgResul
        '
        Me.dgResul.AllowUserToAddRows = False
        Me.dgResul.AllowUserToDeleteRows = False
        Me.dgResul.AllowUserToOrderColumns = True
        Me.dgResul.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgResul.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.idCur, Me.cdGrupo, Me.nombre_grupo, Me.nombreCurso, Me.Periodo, Me.Activo})
        Me.dgResul.Location = New System.Drawing.Point(23, 38)
        Me.dgResul.MultiSelect = False
        Me.dgResul.Name = "dgResul"
        Me.dgResul.RowTemplate.Height = 24
        Me.dgResul.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgResul.Size = New System.Drawing.Size(506, 191)
        Me.dgResul.TabIndex = 0
        '
        'id
        '
        Me.id.DataPropertyName = "IdGrupo"
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.Visible = False
        '
        'idCur
        '
        Me.idCur.DataPropertyName = "IdCurso"
        Me.idCur.HeaderText = "idCurso"
        Me.idCur.Name = "idCur"
        Me.idCur.Visible = False
        '
        'cdGrupo
        '
        Me.cdGrupo.DataPropertyName = "Codigo"
        Me.cdGrupo.HeaderText = "Codigo Grupo"
        Me.cdGrupo.Name = "cdGrupo"
        '
        'nombre_grupo
        '
        Me.nombre_grupo.DataPropertyName = "Nombre"
        Me.nombre_grupo.HeaderText = "Nombre Grupo"
        Me.nombre_grupo.Name = "nombre_grupo"
        '
        'nombreCurso
        '
        Me.nombreCurso.DataPropertyName = "Curso"
        Me.nombreCurso.HeaderText = "Nombre Curso"
        Me.nombreCurso.Name = "nombreCurso"
        '
        'Periodo
        '
        Me.Periodo.DataPropertyName = "Periodo"
        Me.Periodo.HeaderText = "Periodo"
        Me.Periodo.Name = "Periodo"
        '
        'Activo
        '
        Me.Activo.DataPropertyName = "Estado"
        Me.Activo.HeaderText = "Estado"
        Me.Activo.Name = "Activo"
        '
        'frmBuscarGruposCurso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(748, 412)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.gbResul)
        Me.Controls.Add(Me.gbBusqueda)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmBuscarGruposCurso"
        Me.Text = "Buscar Grupos Por Curso"
        Me.gbBusqueda.ResumeLayout(False)
        Me.gbBusqueda.PerformLayout()
        Me.gbResul.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgResul, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbBusqueda As System.Windows.Forms.GroupBox
    Friend WithEvents cmbCurso As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents gbResul As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Private WithEvents btnModificar As System.Windows.Forms.Button
    Private WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents dgResul As System.Windows.Forms.DataGridView
    Private WithEvents btnExportar As System.Windows.Forms.Button
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idCur As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cdGrupo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre_grupo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombreCurso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Periodo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Activo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
End Class
