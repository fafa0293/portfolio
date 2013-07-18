<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListarAportesTema
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListarAportesTema))
        Me.gbBusqueda = New System.Windows.Forms.GroupBox()
        Me.cmbTema = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnExportar = New System.Windows.Forms.Button()
        Me.dgResul = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idUsuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Contenido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.calificacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbResul = New System.Windows.Forms.GroupBox()
        Me.gbBusqueda.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgResul, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbResul.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbBusqueda
        '
        Me.gbBusqueda.Controls.Add(Me.cmbTema)
        Me.gbBusqueda.Controls.Add(Me.Label1)
        Me.gbBusqueda.Controls.Add(Me.btnBuscar)
        Me.gbBusqueda.Location = New System.Drawing.Point(19, 14)
        Me.gbBusqueda.Name = "gbBusqueda"
        Me.gbBusqueda.Size = New System.Drawing.Size(711, 81)
        Me.gbBusqueda.TabIndex = 6
        Me.gbBusqueda.TabStop = False
        Me.gbBusqueda.Text = "Búsqueda"
        '
        'cmbTema
        '
        Me.cmbTema.DisplayMember = "Titulo"
        Me.cmbTema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTema.FormattingEnabled = True
        Me.cmbTema.Location = New System.Drawing.Point(117, 31)
        Me.cmbTema.Name = "cmbTema"
        Me.cmbTema.Size = New System.Drawing.Size(193, 21)
        Me.cmbTema.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tema:"
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(568, 25)
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
        Me.btnCancelar.Location = New System.Drawing.Point(587, 354)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 30)
        Me.btnCancelar.TabIndex = 8
        Me.btnCancelar.Text = "Atrás"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificar.Location = New System.Drawing.Point(18, 19)
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
        Me.btnEliminar.Location = New System.Drawing.Point(18, 55)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(100, 30)
        Me.btnEliminar.TabIndex = 0
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnExportar)
        Me.GroupBox3.Controls.Add(Me.btnModificar)
        Me.GroupBox3.Controls.Add(Me.btnEliminar)
        Me.GroupBox3.Location = New System.Drawing.Point(550, 38)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(140, 183)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Opciones"
        '
        'btnExportar
        '
        Me.btnExportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnExportar.Image = CType(resources.GetObject("btnExportar.Image"), System.Drawing.Image)
        Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExportar.Location = New System.Drawing.Point(18, 91)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(100, 30)
        Me.btnExportar.TabIndex = 9
        Me.btnExportar.Text = "Exportar"
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'dgResul
        '
        Me.dgResul.AllowUserToAddRows = False
        Me.dgResul.AllowUserToDeleteRows = False
        Me.dgResul.AllowUserToOrderColumns = True
        Me.dgResul.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgResul.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.idT, Me.idUsuario, Me.Fecha, Me.Contenido, Me.usuario, Me.calificacion})
        Me.dgResul.Location = New System.Drawing.Point(23, 38)
        Me.dgResul.MultiSelect = False
        Me.dgResul.Name = "dgResul"
        Me.dgResul.RowTemplate.Height = 24
        Me.dgResul.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgResul.Size = New System.Drawing.Size(506, 183)
        Me.dgResul.TabIndex = 0
        '
        'id
        '
        Me.id.DataPropertyName = "IdAporte"
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.Visible = False
        '
        'idT
        '
        Me.idT.DataPropertyName = "IdTema"
        Me.idT.HeaderText = "idTema"
        Me.idT.Name = "idT"
        Me.idT.Visible = False
        '
        'idUsuario
        '
        Me.idUsuario.DataPropertyName = "IdUsuario"
        Me.idUsuario.HeaderText = "idUsuario"
        Me.idUsuario.Name = "idUsuario"
        Me.idUsuario.Visible = False
        '
        'Fecha
        '
        Me.Fecha.DataPropertyName = "Fecha"
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        '
        'Contenido
        '
        Me.Contenido.DataPropertyName = "Contenido"
        Me.Contenido.HeaderText = "Contenido"
        Me.Contenido.Name = "Contenido"
        Me.Contenido.Width = 360
        '
        'usuario
        '
        Me.usuario.DataPropertyName = "NomUsuario"
        Me.usuario.HeaderText = "Usuario"
        Me.usuario.Name = "usuario"
        '
        'calificacion
        '
        Me.calificacion.DataPropertyName = "Calificacion"
        Me.calificacion.HeaderText = "Calificación"
        Me.calificacion.Name = "calificacion"
        '
        'gbResul
        '
        Me.gbResul.Controls.Add(Me.GroupBox3)
        Me.gbResul.Controls.Add(Me.dgResul)
        Me.gbResul.Location = New System.Drawing.Point(19, 112)
        Me.gbResul.Name = "gbResul"
        Me.gbResul.Size = New System.Drawing.Size(711, 236)
        Me.gbResul.TabIndex = 7
        Me.gbResul.TabStop = False
        Me.gbResul.Text = "Resultado"
        '
        'frmListarAportesTema
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
        Me.Name = "frmListarAportesTema"
        Me.Text = "Listar Aportes por Tema"
        Me.gbBusqueda.ResumeLayout(False)
        Me.gbBusqueda.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgResul, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbResul.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbBusqueda As System.Windows.Forms.GroupBox
    Friend WithEvents cmbTema As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents btnBuscar As System.Windows.Forms.Button
    Private WithEvents btnCancelar As System.Windows.Forms.Button
    Private WithEvents btnModificar As System.Windows.Forms.Button
    Private WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dgResul As System.Windows.Forms.DataGridView
    Friend WithEvents gbResul As System.Windows.Forms.GroupBox
    Private WithEvents btnExportar As System.Windows.Forms.Button
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idUsuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Contenido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents usuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents calificacion As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
