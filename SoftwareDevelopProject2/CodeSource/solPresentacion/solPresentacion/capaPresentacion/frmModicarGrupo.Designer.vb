<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModicarGrupo
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
        Me.gbDatosGrupo = New System.Windows.Forms.GroupBox()
        Me.cmbPeriodo = New System.Windows.Forms.ComboBox()
        Me.cmbCarrera = New System.Windows.Forms.ComboBox()
        Me.lblCarrera = New System.Windows.Forms.Label()
        Me.lblErrorCodigo = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.cmbCurso = New System.Windows.Forms.ComboBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblCurso = New System.Windows.Forms.Label()
        Me.lblPeriodo = New System.Windows.Forms.Label()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.gbDatosGrupo.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbDatosGrupo
        '
        Me.gbDatosGrupo.BackColor = System.Drawing.Color.Transparent
        Me.gbDatosGrupo.Controls.Add(Me.cmbEstado)
        Me.gbDatosGrupo.Controls.Add(Me.Label1)
        Me.gbDatosGrupo.Controls.Add(Me.cmbPeriodo)
        Me.gbDatosGrupo.Controls.Add(Me.cmbCarrera)
        Me.gbDatosGrupo.Controls.Add(Me.lblCarrera)
        Me.gbDatosGrupo.Controls.Add(Me.lblErrorCodigo)
        Me.gbDatosGrupo.Controls.Add(Me.btnCancelar)
        Me.gbDatosGrupo.Controls.Add(Me.btnModificar)
        Me.gbDatosGrupo.Controls.Add(Me.cmbCurso)
        Me.gbDatosGrupo.Controls.Add(Me.txtCodigo)
        Me.gbDatosGrupo.Controls.Add(Me.txtNombre)
        Me.gbDatosGrupo.Controls.Add(Me.lblCurso)
        Me.gbDatosGrupo.Controls.Add(Me.lblPeriodo)
        Me.gbDatosGrupo.Controls.Add(Me.lblCodigo)
        Me.gbDatosGrupo.Controls.Add(Me.lblNombre)
        Me.gbDatosGrupo.Location = New System.Drawing.Point(12, 12)
        Me.gbDatosGrupo.Name = "gbDatosGrupo"
        Me.gbDatosGrupo.Size = New System.Drawing.Size(294, 275)
        Me.gbDatosGrupo.TabIndex = 3
        Me.gbDatosGrupo.TabStop = False
        Me.gbDatosGrupo.Text = "Datos Grupo"
        '
        'cmbPeriodo
        '
        Me.cmbPeriodo.DisplayMember = "Nombre"
        Me.cmbPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPeriodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmbPeriodo.FormattingEnabled = True
        Me.cmbPeriodo.Location = New System.Drawing.Point(83, 87)
        Me.cmbPeriodo.Name = "cmbPeriodo"
        Me.cmbPeriodo.Size = New System.Drawing.Size(178, 21)
        Me.cmbPeriodo.TabIndex = 20
        Me.cmbPeriodo.ValueMember = "IdCurso"
        '
        'cmbCarrera
        '
        Me.cmbCarrera.DisplayMember = "Nombre"
        Me.cmbCarrera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCarrera.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmbCarrera.FormattingEnabled = True
        Me.cmbCarrera.Location = New System.Drawing.Point(83, 123)
        Me.cmbCarrera.Name = "cmbCarrera"
        Me.cmbCarrera.Size = New System.Drawing.Size(178, 21)
        Me.cmbCarrera.TabIndex = 19
        Me.cmbCarrera.ValueMember = "IdCarrera"
        '
        'lblCarrera
        '
        Me.lblCarrera.AutoSize = True
        Me.lblCarrera.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblCarrera.Location = New System.Drawing.Point(8, 126)
        Me.lblCarrera.Name = "lblCarrera"
        Me.lblCarrera.Size = New System.Drawing.Size(44, 13)
        Me.lblCarrera.TabIndex = 18
        Me.lblCarrera.Text = "Carrera:"
        '
        'lblErrorCodigo
        '
        Me.lblErrorCodigo.AutoSize = True
        Me.lblErrorCodigo.ForeColor = System.Drawing.Color.Red
        Me.lblErrorCodigo.Location = New System.Drawing.Point(80, 106)
        Me.lblErrorCodigo.Name = "lblErrorCodigo"
        Me.lblErrorCodigo.Size = New System.Drawing.Size(0, 13)
        Me.lblErrorCodigo.TabIndex = 15
        Me.lblErrorCodigo.Visible = False
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnCancelar.Image = Global.capaPresentacion.My.Resources.Resources.close
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(143, 239)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 30)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnModificar.Image = Global.capaPresentacion.My.Resources.Resources.save_update
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificar.Location = New System.Drawing.Point(37, 239)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(100, 30)
        Me.btnModificar.TabIndex = 4
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'cmbCurso
        '
        Me.cmbCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCurso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmbCurso.FormattingEnabled = True
        Me.cmbCurso.Location = New System.Drawing.Point(83, 160)
        Me.cmbCurso.Name = "cmbCurso"
        Me.cmbCurso.Size = New System.Drawing.Size(178, 21)
        Me.cmbCurso.TabIndex = 3
        '
        'txtCodigo
        '
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtCodigo.Location = New System.Drawing.Point(83, 58)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(181, 20)
        Me.txtCodigo.TabIndex = 1
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtNombre.Location = New System.Drawing.Point(83, 25)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(181, 20)
        Me.txtNombre.TabIndex = 0
        '
        'lblCurso
        '
        Me.lblCurso.AutoSize = True
        Me.lblCurso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblCurso.Location = New System.Drawing.Point(8, 163)
        Me.lblCurso.Name = "lblCurso"
        Me.lblCurso.Size = New System.Drawing.Size(37, 13)
        Me.lblCurso.TabIndex = 7
        Me.lblCurso.Text = "Curso:"
        '
        'lblPeriodo
        '
        Me.lblPeriodo.AutoSize = True
        Me.lblPeriodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblPeriodo.Location = New System.Drawing.Point(6, 90)
        Me.lblPeriodo.Name = "lblPeriodo"
        Me.lblPeriodo.Size = New System.Drawing.Size(48, 13)
        Me.lblPeriodo.TabIndex = 6
        Me.lblPeriodo.Text = "Período:"
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblCodigo.Location = New System.Drawing.Point(8, 61)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(43, 13)
        Me.lblCodigo.TabIndex = 5
        Me.lblCodigo.Text = "Código:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblNombre.Location = New System.Drawing.Point(4, 28)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(47, 13)
        Me.lblNombre.TabIndex = 4
        Me.lblNombre.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(6, 201)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Estado:"
        '
        'cmbEstado
        '
        Me.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Items.AddRange(New Object() {"Abierto", "Cerrado"})
        Me.cmbEstado.Location = New System.Drawing.Point(83, 198)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(178, 21)
        Me.cmbEstado.TabIndex = 22
        '
        'frmModicarGrupo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(318, 299)
        Me.ControlBox = False
        Me.Controls.Add(Me.gbDatosGrupo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmModicarGrupo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modicar Grupo"
        Me.gbDatosGrupo.ResumeLayout(False)
        Me.gbDatosGrupo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbDatosGrupo As System.Windows.Forms.GroupBox
    Friend WithEvents cmbCurso As System.Windows.Forms.ComboBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblCurso As System.Windows.Forms.Label
    Friend WithEvents lblPeriodo As System.Windows.Forms.Label
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Private WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents lblErrorCodigo As System.Windows.Forms.Label
    Private WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents lblCarrera As System.Windows.Forms.Label
    Friend WithEvents cmbCarrera As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPeriodo As System.Windows.Forms.ComboBox
    Friend WithEvents cmbEstado As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
