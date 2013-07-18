<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarTema
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuscarTema))
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.gbOpciones = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnExportar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.dgTemas = New System.Windows.Forms.DataGridView()
        Me.gbBusqueda = New System.Windows.Forms.GroupBox()
        Me.rbTituloTema = New System.Windows.Forms.RadioButton()
        Me.rbCodigoGrupo = New System.Windows.Forms.RadioButton()
        Me.txtGrupoTitulo = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdForo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdUsuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaInicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaFin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2.SuspendLayout()
        Me.gbOpciones.SuspendLayout()
        CType(Me.dgTemas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbBusqueda.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = Global.capaPresentacion.My.Resources.Resources.icono_volver
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(666, 383)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 30)
        Me.btnCancelar.TabIndex = 7
        Me.btnCancelar.Text = "Atrás"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.gbOpciones)
        Me.GroupBox2.Controls.Add(Me.dgTemas)
        Me.GroupBox2.Location = New System.Drawing.Point(34, 131)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(767, 248)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Resultado"
        '
        'gbOpciones
        '
        Me.gbOpciones.Controls.Add(Me.Button2)
        Me.gbOpciones.Controls.Add(Me.Button1)
        Me.gbOpciones.Controls.Add(Me.btnExportar)
        Me.gbOpciones.Controls.Add(Me.btnEliminar)
        Me.gbOpciones.Controls.Add(Me.btnModificar)
        Me.gbOpciones.Location = New System.Drawing.Point(618, 24)
        Me.gbOpciones.Name = "gbOpciones"
        Me.gbOpciones.Size = New System.Drawing.Size(126, 208)
        Me.gbOpciones.TabIndex = 3
        Me.gbOpciones.TabStop = False
        Me.gbOpciones.Text = "Opciones:"
        '
        'Button2
        '
        Me.Button2.Image = Global.capaPresentacion.My.Resources.Resources.search
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(14, 128)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 30)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Aportes..."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(14, 60)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 30)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Estudiantes"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnExportar
        '
        Me.btnExportar.Image = CType(resources.GetObject("btnExportar.Image"), System.Drawing.Image)
        Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExportar.Location = New System.Drawing.Point(14, 162)
        Me.btnExportar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(100, 30)
        Me.btnExportar.TabIndex = 8
        Me.btnExportar.Text = "Exportar"
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.Location = New System.Drawing.Point(14, 94)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(100, 30)
        Me.btnEliminar.TabIndex = 2
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificar.Location = New System.Drawing.Point(14, 26)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(100, 30)
        Me.btnModificar.TabIndex = 1
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'dgTemas
        '
        Me.dgTemas.AllowUserToAddRows = False
        Me.dgTemas.AllowUserToDeleteRows = False
        Me.dgTemas.AllowUserToOrderColumns = True
        Me.dgTemas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgTemas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.IdForo, Me.IdUsuario, Me.Column1, Me.Column5, Me.Column2, Me.Column3, Me.Column4, Me.FechaInicio, Me.FechaFin})
        Me.dgTemas.Location = New System.Drawing.Point(11, 24)
        Me.dgTemas.Margin = New System.Windows.Forms.Padding(2)
        Me.dgTemas.MultiSelect = False
        Me.dgTemas.Name = "dgTemas"
        Me.dgTemas.ReadOnly = True
        Me.dgTemas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgTemas.Size = New System.Drawing.Size(592, 208)
        Me.dgTemas.TabIndex = 0
        '
        'gbBusqueda
        '
        Me.gbBusqueda.Controls.Add(Me.rbTituloTema)
        Me.gbBusqueda.Controls.Add(Me.rbCodigoGrupo)
        Me.gbBusqueda.Controls.Add(Me.txtGrupoTitulo)
        Me.gbBusqueda.Controls.Add(Me.btnBuscar)
        Me.gbBusqueda.Location = New System.Drawing.Point(34, 33)
        Me.gbBusqueda.Margin = New System.Windows.Forms.Padding(2)
        Me.gbBusqueda.Name = "gbBusqueda"
        Me.gbBusqueda.Padding = New System.Windows.Forms.Padding(2)
        Me.gbBusqueda.Size = New System.Drawing.Size(767, 76)
        Me.gbBusqueda.TabIndex = 5
        Me.gbBusqueda.TabStop = False
        Me.gbBusqueda.Text = "Búsqueda"
        '
        'rbTituloTema
        '
        Me.rbTituloTema.AutoSize = True
        Me.rbTituloTema.Checked = True
        Me.rbTituloTema.Location = New System.Drawing.Point(49, 22)
        Me.rbTituloTema.Margin = New System.Windows.Forms.Padding(2)
        Me.rbTituloTema.Name = "rbTituloTema"
        Me.rbTituloTema.Size = New System.Drawing.Size(103, 17)
        Me.rbTituloTema.TabIndex = 4
        Me.rbTituloTema.TabStop = True
        Me.rbTituloTema.Text = "Título del Tema:"
        Me.rbTituloTema.UseVisualStyleBackColor = True
        '
        'rbCodigoGrupo
        '
        Me.rbCodigoGrupo.AutoSize = True
        Me.rbCodigoGrupo.Location = New System.Drawing.Point(49, 43)
        Me.rbCodigoGrupo.Margin = New System.Windows.Forms.Padding(2)
        Me.rbCodigoGrupo.Name = "rbCodigoGrupo"
        Me.rbCodigoGrupo.Size = New System.Drawing.Size(58, 17)
        Me.rbCodigoGrupo.TabIndex = 3
        Me.rbCodigoGrupo.Text = "Todos:"
        Me.rbCodigoGrupo.UseVisualStyleBackColor = True
        '
        'txtGrupoTitulo
        '
        Me.txtGrupoTitulo.Location = New System.Drawing.Point(170, 22)
        Me.txtGrupoTitulo.Name = "txtGrupoTitulo"
        Me.txtGrupoTitulo.Size = New System.Drawing.Size(200, 20)
        Me.txtGrupoTitulo.TabIndex = 0
        '
        'btnBuscar
        '
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(632, 30)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(100, 30)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'Id
        '
        Me.Id.DataPropertyName = "IdTema"
        Me.Id.HeaderText = "IdTema"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        Me.Id.Visible = False
        '
        'IdForo
        '
        Me.IdForo.DataPropertyName = "IdForo"
        Me.IdForo.HeaderText = "IdForo"
        Me.IdForo.Name = "IdForo"
        Me.IdForo.ReadOnly = True
        Me.IdForo.Visible = False
        '
        'IdUsuario
        '
        Me.IdUsuario.DataPropertyName = "IdUsuario"
        Me.IdUsuario.HeaderText = "IdUsuario"
        Me.IdUsuario.Name = "IdUsuario"
        Me.IdUsuario.ReadOnly = True
        Me.IdUsuario.Visible = False
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "Titulo"
        Me.Column1.HeaderText = "Título"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 200
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "NombreForo"
        Me.Column5.HeaderText = "Foro"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "NombreUsuario"
        Me.Column2.HeaderText = "Creador"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "AportesMin"
        Me.Column3.HeaderText = "Mín. Aportes"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "AportesMax"
        Me.Column4.HeaderText = "Máx. Aportes"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'FechaInicio
        '
        Me.FechaInicio.DataPropertyName = "FechaInicio"
        Me.FechaInicio.HeaderText = "Fecha Inicio"
        Me.FechaInicio.Name = "FechaInicio"
        Me.FechaInicio.ReadOnly = True
        '
        'FechaFin
        '
        Me.FechaFin.DataPropertyName = "FechaFin"
        Me.FechaFin.HeaderText = "Fecha Fin"
        Me.FechaFin.Name = "FechaFin"
        Me.FechaFin.ReadOnly = True
        '
        'frmBuscarTema
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 451)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.gbBusqueda)
        Me.Name = "frmBuscarTema"
        Me.Text = "Buscar Tema"
        Me.GroupBox2.ResumeLayout(False)
        Me.gbOpciones.ResumeLayout(False)
        CType(Me.dgTemas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbBusqueda.ResumeLayout(False)
        Me.gbBusqueda.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents dgTemas As System.Windows.Forms.DataGridView
    Friend WithEvents gbBusqueda As System.Windows.Forms.GroupBox
    Friend WithEvents txtGrupoTitulo As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents gbOpciones As System.Windows.Forms.GroupBox
    Friend WithEvents btnExportar As System.Windows.Forms.Button
    Friend WithEvents rbTituloTema As System.Windows.Forms.RadioButton
    Friend WithEvents rbCodigoGrupo As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdForo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdUsuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaInicio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaFin As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
