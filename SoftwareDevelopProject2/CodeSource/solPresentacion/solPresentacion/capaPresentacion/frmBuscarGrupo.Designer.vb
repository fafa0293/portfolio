<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarGrupo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.gbBusqueda = New System.Windows.Forms.GroupBox()
        Me.rbCurso = New System.Windows.Forms.RadioButton()
        Me.cmbCurso = New System.Windows.Forms.ComboBox()
        Me.rbNombre = New System.Windows.Forms.RadioButton()
        Me.rbCodigo = New System.Windows.Forms.RadioButton()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtNombreCodigo = New System.Windows.Forms.TextBox()
        Me.gbResultado = New System.Windows.Forms.GroupBox()
        Me.gbOpciones = New System.Windows.Forms.GroupBox()
        Me.btnExportar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.dgDatosGrupo = New System.Windows.Forms.DataGridView()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdCurso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Código = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Período = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Curso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.gbBusqueda.SuspendLayout()
        Me.gbResultado.SuspendLayout()
        Me.gbOpciones.SuspendLayout()
        CType(Me.dgDatosGrupo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbBusqueda
        '
        Me.gbBusqueda.Controls.Add(Me.rbCurso)
        Me.gbBusqueda.Controls.Add(Me.cmbCurso)
        Me.gbBusqueda.Controls.Add(Me.rbNombre)
        Me.gbBusqueda.Controls.Add(Me.rbCodigo)
        Me.gbBusqueda.Controls.Add(Me.btnBuscar)
        Me.gbBusqueda.Controls.Add(Me.txtNombreCodigo)
        Me.gbBusqueda.Location = New System.Drawing.Point(34, 32)
        Me.gbBusqueda.Name = "gbBusqueda"
        Me.gbBusqueda.Size = New System.Drawing.Size(767, 118)
        Me.gbBusqueda.TabIndex = 0
        Me.gbBusqueda.TabStop = False
        Me.gbBusqueda.Text = "Búsqueda"
        '
        'rbCurso
        '
        Me.rbCurso.AutoSize = True
        Me.rbCurso.Location = New System.Drawing.Point(22, 73)
        Me.rbCurso.Name = "rbCurso"
        Me.rbCurso.Size = New System.Drawing.Size(55, 17)
        Me.rbCurso.TabIndex = 8
        Me.rbCurso.TabStop = True
        Me.rbCurso.Text = "Curso:"
        Me.rbCurso.UseVisualStyleBackColor = True
        '
        'cmbCurso
        '
        Me.cmbCurso.DisplayMember = "Nombre"
        Me.cmbCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCurso.FormattingEnabled = True
        Me.cmbCurso.Location = New System.Drawing.Point(152, 72)
        Me.cmbCurso.Name = "cmbCurso"
        Me.cmbCurso.Size = New System.Drawing.Size(200, 21)
        Me.cmbCurso.TabIndex = 7
        '
        'rbNombre
        '
        Me.rbNombre.AutoSize = True
        Me.rbNombre.Location = New System.Drawing.Point(22, 51)
        Me.rbNombre.Margin = New System.Windows.Forms.Padding(2)
        Me.rbNombre.Name = "rbNombre"
        Me.rbNombre.Size = New System.Drawing.Size(114, 17)
        Me.rbNombre.TabIndex = 5
        Me.rbNombre.Text = "Nombre del Grupo:"
        Me.rbNombre.UseVisualStyleBackColor = True
        '
        'rbCodigo
        '
        Me.rbCodigo.AutoSize = True
        Me.rbCodigo.Checked = True
        Me.rbCodigo.Location = New System.Drawing.Point(22, 30)
        Me.rbCodigo.Margin = New System.Windows.Forms.Padding(2)
        Me.rbCodigo.Name = "rbCodigo"
        Me.rbCodigo.Size = New System.Drawing.Size(93, 17)
        Me.rbCodigo.TabIndex = 4
        Me.rbCodigo.TabStop = True
        Me.rbCodigo.Text = "Código Grupo:"
        Me.rbCodigo.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Image = Global.capaPresentacion.My.Resources.Resources.search
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(632, 33)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(100, 30)
        Me.btnBuscar.TabIndex = 3
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtNombreCodigo
        '
        Me.txtNombreCodigo.Location = New System.Drawing.Point(152, 39)
        Me.txtNombreCodigo.Name = "txtNombreCodigo"
        Me.txtNombreCodigo.Size = New System.Drawing.Size(200, 20)
        Me.txtNombreCodigo.TabIndex = 2
        '
        'gbResultado
        '
        Me.gbResultado.Controls.Add(Me.gbOpciones)
        Me.gbResultado.Controls.Add(Me.dgDatosGrupo)
        Me.gbResultado.Location = New System.Drawing.Point(34, 156)
        Me.gbResultado.Name = "gbResultado"
        Me.gbResultado.Size = New System.Drawing.Size(767, 248)
        Me.gbResultado.TabIndex = 1
        Me.gbResultado.TabStop = False
        Me.gbResultado.Text = "Resultado"
        '
        'gbOpciones
        '
        Me.gbOpciones.Controls.Add(Me.btnExportar)
        Me.gbOpciones.Controls.Add(Me.btnModificar)
        Me.gbOpciones.Controls.Add(Me.btnEliminar)
        Me.gbOpciones.Location = New System.Drawing.Point(627, 24)
        Me.gbOpciones.Name = "gbOpciones"
        Me.gbOpciones.Size = New System.Drawing.Size(117, 202)
        Me.gbOpciones.TabIndex = 16
        Me.gbOpciones.TabStop = False
        Me.gbOpciones.Text = "Opciones"
        '
        'btnExportar
        '
        Me.btnExportar.Image = Global.capaPresentacion.My.Resources.Resources.excel
        Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExportar.Location = New System.Drawing.Point(5, 90)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(100, 30)
        Me.btnExportar.TabIndex = 6
        Me.btnExportar.Text = "Exportar"
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Image = Global.capaPresentacion.My.Resources.Resources.edit
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificar.Location = New System.Drawing.Point(5, 18)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(100, 30)
        Me.btnModificar.TabIndex = 5
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = Global.capaPresentacion.My.Resources.Resources.delete
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.Location = New System.Drawing.Point(5, 54)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(100, 30)
        Me.btnEliminar.TabIndex = 4
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'dgDatosGrupo
        '
        Me.dgDatosGrupo.AllowUserToAddRows = False
        Me.dgDatosGrupo.AllowUserToDeleteRows = False
        Me.dgDatosGrupo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDatosGrupo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.IdCurso, Me.Nombre, Me.Código, Me.Período, Me.Estado, Me.Curso})
        Me.dgDatosGrupo.Location = New System.Drawing.Point(22, 24)
        Me.dgDatosGrupo.MultiSelect = False
        Me.dgDatosGrupo.Name = "dgDatosGrupo"
        Me.dgDatosGrupo.ReadOnly = True
        Me.dgDatosGrupo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgDatosGrupo.Size = New System.Drawing.Size(581, 202)
        Me.dgDatosGrupo.TabIndex = 0
        '
        'Id
        '
        Me.Id.DataPropertyName = "IdGrupo"
        Me.Id.HeaderText = "Id"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        Me.Id.Visible = False
        '
        'IdCurso
        '
        Me.IdCurso.DataPropertyName = "IdCurso"
        Me.IdCurso.HeaderText = "IdCurso"
        Me.IdCurso.Name = "IdCurso"
        Me.IdCurso.ReadOnly = True
        Me.IdCurso.Visible = False
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "Nombre"
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'Código
        '
        Me.Código.DataPropertyName = "Codigo"
        Me.Código.HeaderText = "Código"
        Me.Código.Name = "Código"
        Me.Código.ReadOnly = True
        '
        'Período
        '
        Me.Período.DataPropertyName = "Periodo"
        Me.Período.HeaderText = "Período"
        Me.Período.Name = "Período"
        Me.Período.ReadOnly = True
        '
        'Estado
        '
        Me.Estado.DataPropertyName = "Estado"
        Me.Estado.HeaderText = "Estado"
        Me.Estado.Name = "Estado"
        Me.Estado.ReadOnly = True
        '
        'Curso
        '
        Me.Curso.DataPropertyName = "Curso"
        Me.Curso.HeaderText = "Curso"
        Me.Curso.Name = "Curso"
        Me.Curso.ReadOnly = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = Global.capaPresentacion.My.Resources.Resources.icono_volver
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(666, 410)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 30)
        Me.btnCancelar.TabIndex = 16
        Me.btnCancelar.Text = "Atrás"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'frmBuscarGrupo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 460)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.gbResultado)
        Me.Controls.Add(Me.gbBusqueda)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmBuscarGrupo"
        Me.Text = "Buscar Grupo"
        Me.gbBusqueda.ResumeLayout(False)
        Me.gbBusqueda.PerformLayout()
        Me.gbResultado.ResumeLayout(False)
        Me.gbOpciones.ResumeLayout(False)
        CType(Me.dgDatosGrupo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbBusqueda As System.Windows.Forms.GroupBox
    Friend WithEvents txtNombreCodigo As System.Windows.Forms.TextBox
    Friend WithEvents gbResultado As System.Windows.Forms.GroupBox
    Friend WithEvents dgDatosGrupo As System.Windows.Forms.DataGridView
    Friend WithEvents gbOpciones As System.Windows.Forms.GroupBox
    Private WithEvents btnEliminar As System.Windows.Forms.Button
    Private WithEvents btnCancelar As System.Windows.Forms.Button
    Private WithEvents btnExportar As System.Windows.Forms.Button
    Friend WithEvents Id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdCurso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Código As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Período As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Estado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Curso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents rbNombre As System.Windows.Forms.RadioButton
    Friend WithEvents rbCodigo As System.Windows.Forms.RadioButton
    Friend WithEvents cmbCurso As System.Windows.Forms.ComboBox
    Friend WithEvents rbCurso As System.Windows.Forms.RadioButton
End Class
