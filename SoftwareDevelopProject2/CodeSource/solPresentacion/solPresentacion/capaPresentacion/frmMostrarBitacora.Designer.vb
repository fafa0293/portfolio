<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMostrarBitacora
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMostrarBitacora))
        Me.gbBitacora = New System.Windows.Forms.GroupBox()
        Me.dgBitacora = New System.Windows.Forms.DataGridView()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdUsuario2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnExportar = New System.Windows.Forms.Button()
        Me.gbBitacora.SuspendLayout()
        CType(Me.dgBitacora, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbBitacora
        '
        Me.gbBitacora.Controls.Add(Me.dgBitacora)
        Me.gbBitacora.Location = New System.Drawing.Point(30, 30)
        Me.gbBitacora.Margin = New System.Windows.Forms.Padding(2)
        Me.gbBitacora.Name = "gbBitacora"
        Me.gbBitacora.Padding = New System.Windows.Forms.Padding(2)
        Me.gbBitacora.Size = New System.Drawing.Size(748, 397)
        Me.gbBitacora.TabIndex = 7
        Me.gbBitacora.TabStop = False
        Me.gbBitacora.Text = "Bitacóra de Usuario"
        '
        'dgBitacora
        '
        Me.dgBitacora.AllowUserToAddRows = False
        Me.dgBitacora.AllowUserToDeleteRows = False
        Me.dgBitacora.AllowUserToOrderColumns = True
        Me.dgBitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgBitacora.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.IdUsuario2, Me.fecah, Me.descripcion})
        Me.dgBitacora.Location = New System.Drawing.Point(17, 17)
        Me.dgBitacora.Margin = New System.Windows.Forms.Padding(2)
        Me.dgBitacora.MultiSelect = False
        Me.dgBitacora.Name = "dgBitacora"
        Me.dgBitacora.ReadOnly = True
        Me.dgBitacora.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgBitacora.Size = New System.Drawing.Size(727, 376)
        Me.dgBitacora.TabIndex = 0
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(678, 432)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 30)
        Me.btnCancelar.TabIndex = 8
        Me.btnCancelar.Text = "Cerrar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'Id
        '
        Me.Id.DataPropertyName = "IdBitacora"
        Me.Id.HeaderText = "Id"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        Me.Id.Visible = False
        '
        'IdUsuario2
        '
        Me.IdUsuario2.DataPropertyName = "IdUsuario"
        Me.IdUsuario2.HeaderText = "IdUsuario"
        Me.IdUsuario2.Name = "IdUsuario2"
        Me.IdUsuario2.ReadOnly = True
        Me.IdUsuario2.Visible = False
        '
        'fecah
        '
        Me.fecah.DataPropertyName = "Fecha"
        Me.fecah.HeaderText = "Fecha"
        Me.fecah.Name = "fecah"
        Me.fecah.ReadOnly = True
        '
        'descripcion
        '
        Me.descripcion.DataPropertyName = "Descripcion"
        Me.descripcion.FillWeight = 340.0!
        Me.descripcion.HeaderText = "Descripción"
        Me.descripcion.Name = "descripcion"
        Me.descripcion.ReadOnly = True
        Me.descripcion.Width = 640
        '
        'btnExportar
        '
        Me.btnExportar.Image = CType(resources.GetObject("btnExportar.Image"), System.Drawing.Image)
        Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExportar.Location = New System.Drawing.Point(572, 432)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(100, 30)
        Me.btnExportar.TabIndex = 5
        Me.btnExportar.Text = "Exportar"
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'frmMostrarBitacora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(790, 474)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnExportar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.gbBitacora)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmMostrarBitacora"
        Me.Text = "Bitácora"
        Me.gbBitacora.ResumeLayout(False)
        CType(Me.dgBitacora, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbBitacora As System.Windows.Forms.GroupBox
    Friend WithEvents dgBitacora As System.Windows.Forms.DataGridView
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents Id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdUsuario2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecah As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnExportar As System.Windows.Forms.Button
End Class
