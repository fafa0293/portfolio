<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModificarCurso
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmModificarCurso))
        Me.gbCurso = New System.Windows.Forms.GroupBox()
        Me.cbEstado = New System.Windows.Forms.ComboBox()
        Me.txtCreditos = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.lblCreditos = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.bntGuardar = New System.Windows.Forms.Button()
        Me.gbCurso.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbCurso
        '
        Me.gbCurso.Controls.Add(Me.cbEstado)
        Me.gbCurso.Controls.Add(Me.txtCreditos)
        Me.gbCurso.Controls.Add(Me.txtNombre)
        Me.gbCurso.Controls.Add(Me.txtCodigo)
        Me.gbCurso.Controls.Add(Me.lblEstado)
        Me.gbCurso.Controls.Add(Me.lblCreditos)
        Me.gbCurso.Controls.Add(Me.lblNombre)
        Me.gbCurso.Controls.Add(Me.lblCodigo)
        Me.gbCurso.Location = New System.Drawing.Point(31, 25)
        Me.gbCurso.Margin = New System.Windows.Forms.Padding(2)
        Me.gbCurso.Name = "gbCurso"
        Me.gbCurso.Padding = New System.Windows.Forms.Padding(2)
        Me.gbCurso.Size = New System.Drawing.Size(430, 213)
        Me.gbCurso.TabIndex = 0
        Me.gbCurso.TabStop = False
        Me.gbCurso.Text = "Datos de Curso"
        '
        'cbEstado
        '
        Me.cbEstado.AutoCompleteCustomSource.AddRange(New String() {"Activo", "Inactivo"})
        Me.cbEstado.FormattingEnabled = True
        Me.cbEstado.Items.AddRange(New Object() {"Abierto", "Cerrado"})
        Me.cbEstado.Location = New System.Drawing.Point(191, 137)
        Me.cbEstado.Name = "cbEstado"
        Me.cbEstado.Size = New System.Drawing.Size(170, 21)
        Me.cbEstado.TabIndex = 15
        '
        'txtCreditos
        '
        Me.txtCreditos.Location = New System.Drawing.Point(191, 104)
        Me.txtCreditos.Name = "txtCreditos"
        Me.txtCreditos.Size = New System.Drawing.Size(170, 20)
        Me.txtCreditos.TabIndex = 14
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(191, 69)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(170, 20)
        Me.txtNombre.TabIndex = 13
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(191, 33)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(170, 20)
        Me.txtCodigo.TabIndex = 12
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Location = New System.Drawing.Point(50, 139)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(43, 13)
        Me.lblEstado.TabIndex = 11
        Me.lblEstado.Text = "Estado:"
        '
        'lblCreditos
        '
        Me.lblCreditos.AutoSize = True
        Me.lblCreditos.Location = New System.Drawing.Point(50, 106)
        Me.lblCreditos.Name = "lblCreditos"
        Me.lblCreditos.Size = New System.Drawing.Size(48, 13)
        Me.lblCreditos.TabIndex = 10
        Me.lblCreditos.Text = "Créditos:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(50, 71)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(47, 13)
        Me.lblNombre.TabIndex = 9
        Me.lblNombre.Text = "Nombre:"
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(50, 35)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(73, 13)
        Me.lblCodigo.TabIndex = 8
        Me.lblCodigo.Text = "Código Curso:"
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = Global.capaPresentacion.My.Resources.Resources.close1
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(292, 243)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 30)
        Me.btnCancelar.TabIndex = 19
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'bntGuardar
        '
        Me.bntGuardar.Image = Global.capaPresentacion.My.Resources.Resources.save_update
        Me.bntGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bntGuardar.Location = New System.Drawing.Point(139, 243)
        Me.bntGuardar.Name = "bntGuardar"
        Me.bntGuardar.Size = New System.Drawing.Size(100, 30)
        Me.bntGuardar.TabIndex = 18
        Me.bntGuardar.Text = "Modificar"
        Me.bntGuardar.UseVisualStyleBackColor = True
        '
        'frmModificarCurso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(523, 297)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.bntGuardar)
        Me.Controls.Add(Me.gbCurso)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmModificarCurso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar datos de un Curso"
        Me.gbCurso.ResumeLayout(False)
        Me.gbCurso.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbCurso As System.Windows.Forms.GroupBox
    Friend WithEvents cbEstado As System.Windows.Forms.ComboBox
    Friend WithEvents txtCreditos As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents lblEstado As System.Windows.Forms.Label
    Friend WithEvents lblCreditos As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents bntGuardar As System.Windows.Forms.Button
End Class
