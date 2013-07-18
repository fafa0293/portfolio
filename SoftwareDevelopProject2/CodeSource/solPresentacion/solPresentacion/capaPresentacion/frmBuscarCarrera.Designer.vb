<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarCarrera
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuscarCarrera))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.gbOpciones = New System.Windows.Forms.GroupBox()
        Me.btnExportar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.dgCarreras = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cursos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbBusqueda = New System.Windows.Forms.GroupBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.rbNombreCarrera = New System.Windows.Forms.RadioButton()
        Me.rbCodigoCarrera = New System.Windows.Forms.RadioButton()
        Me.txtCodigoNombre = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.gbOpciones.SuspendLayout()
        CType(Me.dgCarreras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbBusqueda.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.gbOpciones)
        Me.GroupBox2.Controls.Add(Me.dgCarreras)
        Me.GroupBox2.Location = New System.Drawing.Point(34, 138)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(767, 248)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Resultado"
        '
        'gbOpciones
        '
        Me.gbOpciones.Controls.Add(Me.btnExportar)
        Me.gbOpciones.Controls.Add(Me.btnModificar)
        Me.gbOpciones.Controls.Add(Me.btnEliminar)
        Me.gbOpciones.Location = New System.Drawing.Point(617, 24)
        Me.gbOpciones.Name = "gbOpciones"
        Me.gbOpciones.Size = New System.Drawing.Size(133, 208)
        Me.gbOpciones.TabIndex = 3
        Me.gbOpciones.TabStop = False
        Me.gbOpciones.Text = "Opciones:"
        '
        'btnExportar
        '
        Me.btnExportar.Image = CType(resources.GetObject("btnExportar.Image"), System.Drawing.Image)
        Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExportar.Location = New System.Drawing.Point(16, 86)
        Me.btnExportar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(100, 30)
        Me.btnExportar.TabIndex = 3
        Me.btnExportar.Text = "Exportar"
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificar.Location = New System.Drawing.Point(16, 18)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(100, 30)
        Me.btnModificar.TabIndex = 1
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.Location = New System.Drawing.Point(16, 52)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(100, 30)
        Me.btnEliminar.TabIndex = 2
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'dgCarreras
        '
        Me.dgCarreras.AllowUserToAddRows = False
        Me.dgCarreras.AllowUserToDeleteRows = False
        Me.dgCarreras.AllowUserToOrderColumns = True
        Me.dgCarreras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCarreras.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.Column1, Me.Column2, Me.cursos})
        Me.dgCarreras.Location = New System.Drawing.Point(11, 24)
        Me.dgCarreras.Margin = New System.Windows.Forms.Padding(2)
        Me.dgCarreras.MultiSelect = False
        Me.dgCarreras.Name = "dgCarreras"
        Me.dgCarreras.ReadOnly = True
        Me.dgCarreras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgCarreras.Size = New System.Drawing.Size(592, 208)
        Me.dgCarreras.TabIndex = 0
        '
        'id
        '
        Me.id.DataPropertyName = "IdCarrera"
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "Codigo"
        Me.Column1.HeaderText = "Código"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "Nombre"
        Me.Column2.HeaderText = "Nombre"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 300
        '
        'cursos
        '
        Me.cursos.DataPropertyName = "CantCursos"
        Me.cursos.HeaderText = "Cursos"
        Me.cursos.Name = "cursos"
        Me.cursos.ReadOnly = True
        '
        'gbBusqueda
        '
        Me.gbBusqueda.Controls.Add(Me.RadioButton1)
        Me.gbBusqueda.Controls.Add(Me.rbNombreCarrera)
        Me.gbBusqueda.Controls.Add(Me.rbCodigoCarrera)
        Me.gbBusqueda.Controls.Add(Me.txtCodigoNombre)
        Me.gbBusqueda.Controls.Add(Me.btnBuscar)
        Me.gbBusqueda.Location = New System.Drawing.Point(34, 26)
        Me.gbBusqueda.Margin = New System.Windows.Forms.Padding(2)
        Me.gbBusqueda.Name = "gbBusqueda"
        Me.gbBusqueda.Padding = New System.Windows.Forms.Padding(2)
        Me.gbBusqueda.Size = New System.Drawing.Size(767, 96)
        Me.gbBusqueda.TabIndex = 2
        Me.gbBusqueda.TabStop = False
        Me.gbBusqueda.Text = "Búsqueda"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(37, 66)
        Me.RadioButton1.Margin = New System.Windows.Forms.Padding(2)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(58, 17)
        Me.RadioButton1.TabIndex = 5
        Me.RadioButton1.Text = "Todos:"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'rbNombreCarrera
        '
        Me.rbNombreCarrera.AutoSize = True
        Me.rbNombreCarrera.Location = New System.Drawing.Point(37, 45)
        Me.rbNombreCarrera.Margin = New System.Windows.Forms.Padding(2)
        Me.rbNombreCarrera.Name = "rbNombreCarrera"
        Me.rbNombreCarrera.Size = New System.Drawing.Size(128, 17)
        Me.rbNombreCarrera.TabIndex = 4
        Me.rbNombreCarrera.Text = "Nombre de la Carrera:"
        Me.rbNombreCarrera.UseVisualStyleBackColor = True
        '
        'rbCodigoCarrera
        '
        Me.rbCodigoCarrera.AutoSize = True
        Me.rbCodigoCarrera.Checked = True
        Me.rbCodigoCarrera.Location = New System.Drawing.Point(37, 24)
        Me.rbCodigoCarrera.Margin = New System.Windows.Forms.Padding(2)
        Me.rbCodigoCarrera.Name = "rbCodigoCarrera"
        Me.rbCodigoCarrera.Size = New System.Drawing.Size(98, 17)
        Me.rbCodigoCarrera.TabIndex = 3
        Me.rbCodigoCarrera.TabStop = True
        Me.rbCodigoCarrera.Text = "Código Carrera:"
        Me.rbCodigoCarrera.UseVisualStyleBackColor = True
        '
        'txtCodigoNombre
        '
        Me.txtCodigoNombre.Location = New System.Drawing.Point(179, 30)
        Me.txtCodigoNombre.Name = "txtCodigoNombre"
        Me.txtCodigoNombre.Size = New System.Drawing.Size(200, 20)
        Me.txtCodigoNombre.TabIndex = 1
        '
        'btnBuscar
        '
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(633, 24)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(100, 30)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = Global.capaPresentacion.My.Resources.Resources.icono_volver
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(667, 390)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 30)
        Me.btnCancelar.TabIndex = 4
        Me.btnCancelar.Text = "Atrás"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'frmBuscarCarrera
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 438)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.gbBusqueda)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmBuscarCarrera"
        Me.Text = "Buscar Carrera"
        Me.GroupBox2.ResumeLayout(False)
        Me.gbOpciones.ResumeLayout(False)
        CType(Me.dgCarreras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbBusqueda.ResumeLayout(False)
        Me.gbBusqueda.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgCarreras As System.Windows.Forms.DataGridView
    Friend WithEvents gbBusqueda As System.Windows.Forms.GroupBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents txtCodigoNombre As System.Windows.Forms.TextBox
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents gbOpciones As System.Windows.Forms.GroupBox
    Friend WithEvents btnExportar As System.Windows.Forms.Button
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cursos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rbNombreCarrera As System.Windows.Forms.RadioButton
    Friend WithEvents rbCodigoCarrera As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
End Class
