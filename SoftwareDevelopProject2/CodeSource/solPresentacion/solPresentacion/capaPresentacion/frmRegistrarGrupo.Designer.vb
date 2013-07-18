<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistrarGrupo
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
        Me.components = New System.ComponentModel.Container()
        Me.gbDatosGrupo = New System.Windows.Forms.GroupBox()
        Me.lblCarrera = New System.Windows.Forms.Label()
        Me.cmbPeriodo = New System.Windows.Forms.ComboBox()
        Me.cmbCarrera = New System.Windows.Forms.ComboBox()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.cmbCurso = New System.Windows.Forms.ComboBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblCurso = New System.Windows.Forms.Label()
        Me.lblPeriodo = New System.Windows.Forms.Label()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.ToolTipCarrre = New System.Windows.Forms.ToolTip(Me.components)
        Me.gbDatosGrupo.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbDatosGrupo
        '
        Me.gbDatosGrupo.BackColor = System.Drawing.SystemColors.Control
        Me.gbDatosGrupo.Controls.Add(Me.lblCarrera)
        Me.gbDatosGrupo.Controls.Add(Me.cmbPeriodo)
        Me.gbDatosGrupo.Controls.Add(Me.cmbCarrera)
        Me.gbDatosGrupo.Controls.Add(Me.btnRegistrar)
        Me.gbDatosGrupo.Controls.Add(Me.btnCancelar)
        Me.gbDatosGrupo.Controls.Add(Me.cmbCurso)
        Me.gbDatosGrupo.Controls.Add(Me.txtCodigo)
        Me.gbDatosGrupo.Controls.Add(Me.txtNombre)
        Me.gbDatosGrupo.Controls.Add(Me.lblCurso)
        Me.gbDatosGrupo.Controls.Add(Me.lblPeriodo)
        Me.gbDatosGrupo.Controls.Add(Me.lblCodigo)
        Me.gbDatosGrupo.Controls.Add(Me.lblNombre)
        Me.gbDatosGrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDatosGrupo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.gbDatosGrupo.Location = New System.Drawing.Point(123, 71)
        Me.gbDatosGrupo.Name = "gbDatosGrupo"
        Me.gbDatosGrupo.Size = New System.Drawing.Size(608, 332)
        Me.gbDatosGrupo.TabIndex = 2
        Me.gbDatosGrupo.TabStop = False
        Me.gbDatosGrupo.Text = "Datos Grupo"
        '
        'lblCarrera
        '
        Me.lblCarrera.AutoSize = True
        Me.lblCarrera.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblCarrera.Location = New System.Drawing.Point(44, 144)
        Me.lblCarrera.Name = "lblCarrera"
        Me.lblCarrera.Size = New System.Drawing.Size(44, 13)
        Me.lblCarrera.TabIndex = 17
        Me.lblCarrera.Text = "Carrera:"
        '
        'cmbPeriodo
        '
        Me.cmbPeriodo.DisplayMember = "Nombre"
        Me.cmbPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPeriodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmbPeriodo.FormattingEnabled = True
        Me.cmbPeriodo.Location = New System.Drawing.Point(176, 99)
        Me.cmbPeriodo.Name = "cmbPeriodo"
        Me.cmbPeriodo.Size = New System.Drawing.Size(283, 21)
        Me.cmbPeriodo.TabIndex = 16
        Me.cmbPeriodo.ValueMember = "IdCurso"
        '
        'cmbCarrera
        '
        Me.cmbCarrera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCarrera.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmbCarrera.FormattingEnabled = True
        Me.cmbCarrera.Location = New System.Drawing.Point(176, 141)
        Me.cmbCarrera.Name = "cmbCarrera"
        Me.cmbCarrera.Size = New System.Drawing.Size(283, 21)
        Me.cmbCarrera.TabIndex = 15
        Me.ToolTipCarrre.SetToolTip(Me.cmbCarrera, "Debe seleccionadar una carrera para mostrar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "los cursos pertenecientes en la caj" & _
        "a de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "selección de .")
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Image = Global.capaPresentacion.My.Resources.Resources.save_update
        Me.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegistrar.Location = New System.Drawing.Point(176, 241)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(100, 30)
        Me.btnRegistrar.TabIndex = 14
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCancelar.Image = Global.capaPresentacion.My.Resources.Resources.icono_volver
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(359, 241)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 30)
        Me.btnCancelar.TabIndex = 13
        Me.btnCancelar.Text = "Atrás"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'cmbCurso
        '
        Me.cmbCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCurso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmbCurso.FormattingEnabled = True
        Me.cmbCurso.Location = New System.Drawing.Point(176, 180)
        Me.cmbCurso.Name = "cmbCurso"
        Me.cmbCurso.Size = New System.Drawing.Size(283, 21)
        Me.cmbCurso.TabIndex = 3
        Me.ToolTipCarrre.SetToolTip(Me.cmbCurso, "Debe seleccionar una carrera de la" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "caja de seleción anterior para " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "desplegar su" & _
        "s cursos pertenecientes.")
        '
        'txtCodigo
        '
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtCodigo.Location = New System.Drawing.Point(176, 61)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(283, 20)
        Me.txtCodigo.TabIndex = 1
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtNombre.Location = New System.Drawing.Point(176, 25)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(283, 20)
        Me.txtNombre.TabIndex = 0
        '
        'lblCurso
        '
        Me.lblCurso.AutoSize = True
        Me.lblCurso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblCurso.Location = New System.Drawing.Point(44, 188)
        Me.lblCurso.Name = "lblCurso"
        Me.lblCurso.Size = New System.Drawing.Size(37, 13)
        Me.lblCurso.TabIndex = 7
        Me.lblCurso.Text = "Curso:"
        '
        'lblPeriodo
        '
        Me.lblPeriodo.AutoSize = True
        Me.lblPeriodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblPeriodo.Location = New System.Drawing.Point(44, 102)
        Me.lblPeriodo.Name = "lblPeriodo"
        Me.lblPeriodo.Size = New System.Drawing.Size(48, 13)
        Me.lblPeriodo.TabIndex = 6
        Me.lblPeriodo.Text = "Período:"
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblCodigo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCodigo.Location = New System.Drawing.Point(44, 64)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(43, 13)
        Me.lblCodigo.TabIndex = 5
        Me.lblCodigo.Text = "Código:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.BackColor = System.Drawing.SystemColors.Control
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblNombre.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblNombre.Location = New System.Drawing.Point(44, 28)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(47, 13)
        Me.lblNombre.TabIndex = 4
        Me.lblNombre.Text = "Nombre:"
        '
        'ToolTipCarrre
        '
        Me.ToolTipCarrre.IsBalloon = True
        Me.ToolTipCarrre.Tag = ""
        Me.ToolTipCarrre.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTipCarrre.ToolTipTitle = "Ayuda"
        '
        'frmRegistrarGrupo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(822, 468)
        Me.ControlBox = False
        Me.Controls.Add(Me.gbDatosGrupo)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmRegistrarGrupo"
        Me.Text = "Registrar Grupo"
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
    Private WithEvents btnRegistrar As System.Windows.Forms.Button
    Friend WithEvents lblCarrera As System.Windows.Forms.Label
    Friend WithEvents cmbPeriodo As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCarrera As System.Windows.Forms.ComboBox
    Friend WithEvents ToolTipCarrre As System.Windows.Forms.ToolTip

End Class
