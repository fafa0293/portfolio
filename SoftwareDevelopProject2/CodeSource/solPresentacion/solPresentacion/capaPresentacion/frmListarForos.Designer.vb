<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListarForos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListarForos))
        Me.gbResul = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnAgregarTema = New System.Windows.Forms.Button()
        Me.btnExportar = New System.Windows.Forms.Button()
        Me.dgResul = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idusuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idGrupo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.gbResul.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgResul, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbResul
        '
        Me.gbResul.Controls.Add(Me.GroupBox3)
        Me.gbResul.Controls.Add(Me.dgResul)
        Me.gbResul.Location = New System.Drawing.Point(108, 121)
        Me.gbResul.Margin = New System.Windows.Forms.Padding(2)
        Me.gbResul.Name = "gbResul"
        Me.gbResul.Padding = New System.Windows.Forms.Padding(2)
        Me.gbResul.Size = New System.Drawing.Size(596, 202)
        Me.gbResul.TabIndex = 11
        Me.gbResul.TabStop = False
        Me.gbResul.Text = "Resultado"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnBuscar)
        Me.GroupBox3.Controls.Add(Me.btnAgregarTema)
        Me.GroupBox3.Controls.Add(Me.btnExportar)
        Me.GroupBox3.Location = New System.Drawing.Point(470, 20)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Size = New System.Drawing.Size(108, 125)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Opciones"
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnBuscar.Image = Global.capaPresentacion.My.Resources.Resources.search
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(4, 17)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnBuscar.Size = New System.Drawing.Size(100, 30)
        Me.btnBuscar.TabIndex = 6
        Me.btnBuscar.Text = "Temas"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnAgregarTema
        '
        Me.btnAgregarTema.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnAgregarTema.Image = Global.capaPresentacion.My.Resources.Resources.add
        Me.btnAgregarTema.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregarTema.Location = New System.Drawing.Point(4, 51)
        Me.btnAgregarTema.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAgregarTema.Name = "btnAgregarTema"
        Me.btnAgregarTema.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnAgregarTema.Size = New System.Drawing.Size(100, 30)
        Me.btnAgregarTema.TabIndex = 5
        Me.btnAgregarTema.Text = "Crear Tema"
        Me.btnAgregarTema.UseVisualStyleBackColor = True
        '
        'btnExportar
        '
        Me.btnExportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnExportar.Image = CType(resources.GetObject("btnExportar.Image"), System.Drawing.Image)
        Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExportar.Location = New System.Drawing.Point(4, 85)
        Me.btnExportar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnExportar.Size = New System.Drawing.Size(100, 30)
        Me.btnExportar.TabIndex = 4
        Me.btnExportar.Text = "Exportar"
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'dgResul
        '
        Me.dgResul.AllowUserToAddRows = False
        Me.dgResul.AllowUserToDeleteRows = False
        Me.dgResul.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgResul.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.idusuario, Me.idGrupo, Me.nombre})
        Me.dgResul.Location = New System.Drawing.Point(13, 28)
        Me.dgResul.Margin = New System.Windows.Forms.Padding(2)
        Me.dgResul.MultiSelect = False
        Me.dgResul.Name = "dgResul"
        Me.dgResul.ReadOnly = True
        Me.dgResul.RowTemplate.Height = 24
        Me.dgResul.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgResul.Size = New System.Drawing.Size(444, 156)
        Me.dgResul.TabIndex = 0
        '
        'id
        '
        Me.id.DataPropertyName = "IdForo"
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        '
        'idusuario
        '
        Me.idusuario.DataPropertyName = "idUsuario"
        Me.idusuario.HeaderText = "usuario"
        Me.idusuario.Name = "idusuario"
        Me.idusuario.ReadOnly = True
        Me.idusuario.Visible = False
        '
        'idGrupo
        '
        Me.idGrupo.DataPropertyName = "idGrupo"
        Me.idGrupo.HeaderText = "grupo"
        Me.idGrupo.Name = "idGrupo"
        Me.idGrupo.ReadOnly = True
        Me.idGrupo.Visible = False
        '
        'nombre
        '
        Me.nombre.DataPropertyName = "NombreForo"
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Width = 400
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnCancelar.Image = Global.capaPresentacion.My.Resources.Resources.icono_volver
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(586, 327)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 30)
        Me.btnCancelar.TabIndex = 12
        Me.btnCancelar.Text = "Atrás"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'frmListarForos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(838, 506)
        Me.Controls.Add(Me.gbResul)
        Me.Controls.Add(Me.btnCancelar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmListarForos"
        Me.Text = "Listar Foros"
        Me.gbResul.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgResul, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbResul As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Private WithEvents btnExportar As System.Windows.Forms.Button
    Friend WithEvents dgResul As System.Windows.Forms.DataGridView
    Private WithEvents btnCancelar As System.Windows.Forms.Button
    Private WithEvents btnAgregarTema As System.Windows.Forms.Button
    Private WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idusuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idGrupo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
