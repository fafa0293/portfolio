<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarCurso
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuscarCurso))
        Me.gbCurso = New System.Windows.Forms.GroupBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtCriterio = New System.Windows.Forms.TextBox()
        Me.rbNombreCarrera = New System.Windows.Forms.RadioButton()
        Me.rbCodigoCarrera = New System.Windows.Forms.RadioButton()
        Me.dgvCursos = New System.Windows.Forms.DataGridView()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbResultado = New System.Windows.Forms.GroupBox()
        Me.gbOpciones = New System.Windows.Forms.GroupBox()
        Me.btnExportar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnCAncelar = New System.Windows.Forms.Button()
        Me.gbCurso.SuspendLayout()
        CType(Me.dgvCursos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbResultado.SuspendLayout()
        Me.gbOpciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbCurso
        '
        Me.gbCurso.Controls.Add(Me.RadioButton1)
        Me.gbCurso.Controls.Add(Me.btnBuscar)
        Me.gbCurso.Controls.Add(Me.txtCriterio)
        Me.gbCurso.Controls.Add(Me.rbNombreCarrera)
        Me.gbCurso.Controls.Add(Me.rbCodigoCarrera)
        Me.gbCurso.Location = New System.Drawing.Point(34, 28)
        Me.gbCurso.Name = "gbCurso"
        Me.gbCurso.Size = New System.Drawing.Size(767, 107)
        Me.gbCurso.TabIndex = 0
        Me.gbCurso.TabStop = False
        Me.gbCurso.Text = "Búsqueda"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(29, 72)
        Me.RadioButton1.Margin = New System.Windows.Forms.Padding(2)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(55, 17)
        Me.RadioButton1.TabIndex = 5
        Me.RadioButton1.Text = "Todos"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Image = Global.capaPresentacion.My.Resources.Resources.search1
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(623, 34)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(100, 30)
        Me.btnBuscar.TabIndex = 4
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtCriterio
        '
        Me.txtCriterio.Location = New System.Drawing.Point(157, 40)
        Me.txtCriterio.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCriterio.Name = "txtCriterio"
        Me.txtCriterio.Size = New System.Drawing.Size(170, 20)
        Me.txtCriterio.TabIndex = 1
        '
        'rbNombreCarrera
        '
        Me.rbNombreCarrera.AutoSize = True
        Me.rbNombreCarrera.Location = New System.Drawing.Point(29, 51)
        Me.rbNombreCarrera.Margin = New System.Windows.Forms.Padding(2)
        Me.rbNombreCarrera.Name = "rbNombreCarrera"
        Me.rbNombreCarrera.Size = New System.Drawing.Size(112, 17)
        Me.rbNombreCarrera.TabIndex = 1
        Me.rbNombreCarrera.Text = "Nombre del Curso:"
        Me.rbNombreCarrera.UseVisualStyleBackColor = True
        '
        'rbCodigoCarrera
        '
        Me.rbCodigoCarrera.AutoSize = True
        Me.rbCodigoCarrera.Checked = True
        Me.rbCodigoCarrera.Location = New System.Drawing.Point(29, 30)
        Me.rbCodigoCarrera.Margin = New System.Windows.Forms.Padding(2)
        Me.rbCodigoCarrera.Name = "rbCodigoCarrera"
        Me.rbCodigoCarrera.Size = New System.Drawing.Size(91, 17)
        Me.rbCodigoCarrera.TabIndex = 0
        Me.rbCodigoCarrera.TabStop = True
        Me.rbCodigoCarrera.Text = "Código Curso:"
        Me.rbCodigoCarrera.UseVisualStyleBackColor = True
        '
        'dgvCursos
        '
        Me.dgvCursos.AllowUserToAddRows = False
        Me.dgvCursos.AllowUserToDeleteRows = False
        Me.dgvCursos.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCursos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCursos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCursos.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvCursos.Location = New System.Drawing.Point(20, 24)
        Me.dgvCursos.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvCursos.MultiSelect = False
        Me.dgvCursos.Name = "dgvCursos"
        Me.dgvCursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCursos.Size = New System.Drawing.Size(569, 207)
        Me.dgvCursos.TabIndex = 5
        '
        'Id
        '
        Me.Id.DataPropertyName = "IdCurso"
        Me.Id.HeaderText = "Id"
        Me.Id.Name = "Id"
        Me.Id.Visible = False
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "Codigo"
        Me.Column1.HeaderText = "Código Curso"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "Nombre"
        Me.Column2.HeaderText = "Nombre"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 200
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "Creditos"
        Me.Column3.HeaderText = "Créditos"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "Estado"
        Me.Column4.HeaderText = "Estado"
        Me.Column4.Name = "Column4"
        '
        'gbResultado
        '
        Me.gbResultado.BackColor = System.Drawing.SystemColors.Control
        Me.gbResultado.Controls.Add(Me.gbOpciones)
        Me.gbResultado.Controls.Add(Me.dgvCursos)
        Me.gbResultado.Location = New System.Drawing.Point(34, 154)
        Me.gbResultado.Margin = New System.Windows.Forms.Padding(2)
        Me.gbResultado.Name = "gbResultado"
        Me.gbResultado.Padding = New System.Windows.Forms.Padding(2)
        Me.gbResultado.Size = New System.Drawing.Size(767, 248)
        Me.gbResultado.TabIndex = 6
        Me.gbResultado.TabStop = False
        Me.gbResultado.Text = "Resultado"
        '
        'gbOpciones
        '
        Me.gbOpciones.Controls.Add(Me.btnExportar)
        Me.gbOpciones.Controls.Add(Me.btnEliminar)
        Me.gbOpciones.Controls.Add(Me.btnModificar)
        Me.gbOpciones.Location = New System.Drawing.Point(608, 24)
        Me.gbOpciones.Name = "gbOpciones"
        Me.gbOpciones.Size = New System.Drawing.Size(129, 126)
        Me.gbOpciones.TabIndex = 6
        Me.gbOpciones.TabStop = False
        Me.gbOpciones.Text = "Opciones"
        '
        'btnExportar
        '
        Me.btnExportar.Image = Global.capaPresentacion.My.Resources.Resources.excel
        Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExportar.Location = New System.Drawing.Point(15, 86)
        Me.btnExportar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(100, 30)
        Me.btnExportar.TabIndex = 8
        Me.btnExportar.Text = "Exportar"
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = Global.capaPresentacion.My.Resources.Resources.delete
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.Location = New System.Drawing.Point(15, 52)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(100, 30)
        Me.btnEliminar.TabIndex = 7
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Image = Global.capaPresentacion.My.Resources.Resources.edit
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificar.Location = New System.Drawing.Point(15, 18)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(100, 30)
        Me.btnModificar.TabIndex = 6
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnCAncelar
        '
        Me.btnCAncelar.Image = Global.capaPresentacion.My.Resources.Resources.icono_volver
        Me.btnCAncelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCAncelar.Location = New System.Drawing.Point(657, 407)
        Me.btnCAncelar.Name = "btnCAncelar"
        Me.btnCAncelar.Size = New System.Drawing.Size(100, 30)
        Me.btnCAncelar.TabIndex = 8
        Me.btnCAncelar.Text = "Atrás"
        Me.btnCAncelar.UseVisualStyleBackColor = True
        '
        'frmBuscarCurso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(844, 454)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCAncelar)
        Me.Controls.Add(Me.gbResultado)
        Me.Controls.Add(Me.gbCurso)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmBuscarCurso"
        Me.Text = "Buscar Curso"
        Me.gbCurso.ResumeLayout(False)
        Me.gbCurso.PerformLayout()
        CType(Me.dgvCursos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbResultado.ResumeLayout(False)
        Me.gbOpciones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbCurso As System.Windows.Forms.GroupBox
    Friend WithEvents dgvCursos As System.Windows.Forms.DataGridView
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents txtCriterio As System.Windows.Forms.TextBox
    Friend WithEvents rbNombreCarrera As System.Windows.Forms.RadioButton
    Friend WithEvents rbCodigoCarrera As System.Windows.Forms.RadioButton
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents gbResultado As System.Windows.Forms.GroupBox
    Friend WithEvents btnCAncelar As System.Windows.Forms.Button
    Friend WithEvents gbOpciones As System.Windows.Forms.GroupBox
    Friend WithEvents btnExportar As System.Windows.Forms.Button
    Friend WithEvents Id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
End Class
