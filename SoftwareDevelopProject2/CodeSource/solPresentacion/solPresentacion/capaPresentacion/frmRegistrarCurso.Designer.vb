<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistrarCurso
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegistrarCurso))
        Me.gbCurso = New System.Windows.Forms.GroupBox()
        Me.txtCreditos = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.lblCreditos = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.bntRegistrar = New System.Windows.Forms.Button()
        Me.gbCurso.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbCurso
        '
        Me.gbCurso.Controls.Add(Me.txtCreditos)
        Me.gbCurso.Controls.Add(Me.txtNombre)
        Me.gbCurso.Controls.Add(Me.txtCodigo)
        Me.gbCurso.Controls.Add(Me.lblCreditos)
        Me.gbCurso.Controls.Add(Me.lblNombre)
        Me.gbCurso.Controls.Add(Me.lblCodigo)
        Me.gbCurso.Location = New System.Drawing.Point(131, 89)
        Me.gbCurso.Name = "gbCurso"
        Me.gbCurso.Size = New System.Drawing.Size(517, 200)
        Me.gbCurso.TabIndex = 0
        Me.gbCurso.TabStop = False
        Me.gbCurso.Text = "Datos de Curso"
        '
        'txtCreditos
        '
        Me.txtCreditos.Location = New System.Drawing.Point(176, 139)
        Me.txtCreditos.Name = "txtCreditos"
        Me.txtCreditos.Size = New System.Drawing.Size(283, 20)
        Me.txtCreditos.TabIndex = 6
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(176, 95)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(283, 20)
        Me.txtNombre.TabIndex = 5
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(176, 54)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(283, 20)
        Me.txtCodigo.TabIndex = 4
        '
        'lblCreditos
        '
        Me.lblCreditos.AutoSize = True
        Me.lblCreditos.Location = New System.Drawing.Point(44, 142)
        Me.lblCreditos.Name = "lblCreditos"
        Me.lblCreditos.Size = New System.Drawing.Size(48, 13)
        Me.lblCreditos.TabIndex = 2
        Me.lblCreditos.Text = "Créditos:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(44, 98)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(47, 13)
        Me.lblNombre.TabIndex = 1
        Me.lblNombre.Text = "Nombre:"
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(44, 54)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(73, 13)
        Me.lblCodigo.TabIndex = 0
        Me.lblCodigo.Text = "Código Curso:"
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = Global.capaPresentacion.My.Resources.Resources.icono_volver
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(436, 307)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 30)
        Me.btnCancelar.TabIndex = 9
        Me.btnCancelar.Text = "Atrás"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'bntRegistrar
        '
        Me.bntRegistrar.Image = Global.capaPresentacion.My.Resources.Resources.save_update
        Me.bntRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bntRegistrar.Location = New System.Drawing.Point(307, 307)
        Me.bntRegistrar.Name = "bntRegistrar"
        Me.bntRegistrar.Size = New System.Drawing.Size(100, 30)
        Me.bntRegistrar.TabIndex = 8
        Me.bntRegistrar.Text = "Registrar"
        Me.bntRegistrar.UseVisualStyleBackColor = True
        '
        'frmRegistrarCurso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(805, 563)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.gbCurso)
        Me.Controls.Add(Me.bntRegistrar)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRegistrarCurso"
        Me.Text = "Registrar Curso"
        Me.gbCurso.ResumeLayout(False)
        Me.gbCurso.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbCurso As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents bntRegistrar As System.Windows.Forms.Button
    Friend WithEvents txtCreditos As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents lblCreditos As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
End Class
