<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAsignarDirectorAcademicoCarrera
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAsignarDirectorAcademicoCarrera))
        Me.gbCurso = New System.Windows.Forms.GroupBox()
        Me.cmbDirectorAcademico = New System.Windows.Forms.ComboBox()
        Me.lblDirectorAcademico = New System.Windows.Forms.Label()
        Me.cmbCarrera = New System.Windows.Forms.ComboBox()
        Me.lblCarrera = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAsignar = New System.Windows.Forms.Button()
        Me.gbCarrera = New System.Windows.Forms.GroupBox()
        Me.gbCurso.SuspendLayout()
        Me.gbCarrera.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbCurso
        '
        Me.gbCurso.Controls.Add(Me.cmbDirectorAcademico)
        Me.gbCurso.Controls.Add(Me.lblDirectorAcademico)
        Me.gbCurso.Location = New System.Drawing.Point(156, 57)
        Me.gbCurso.Name = "gbCurso"
        Me.gbCurso.Size = New System.Drawing.Size(462, 66)
        Me.gbCurso.TabIndex = 14
        Me.gbCurso.TabStop = False
        Me.gbCurso.Text = "Director Académico a Asignar"
        '
        'cmbDirectorAcademico
        '
        Me.cmbDirectorAcademico.DisplayMember = "NombreCompleto"
        Me.cmbDirectorAcademico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDirectorAcademico.FormattingEnabled = True
        Me.cmbDirectorAcademico.Location = New System.Drawing.Point(193, 17)
        Me.cmbDirectorAcademico.Name = "cmbDirectorAcademico"
        Me.cmbDirectorAcademico.Size = New System.Drawing.Size(200, 21)
        Me.cmbDirectorAcademico.TabIndex = 2
        Me.cmbDirectorAcademico.ValueMember = "IdUsuario"
        '
        'lblDirectorAcademico
        '
        Me.lblDirectorAcademico.AutoSize = True
        Me.lblDirectorAcademico.Location = New System.Drawing.Point(34, 21)
        Me.lblDirectorAcademico.Name = "lblDirectorAcademico"
        Me.lblDirectorAcademico.Size = New System.Drawing.Size(100, 13)
        Me.lblDirectorAcademico.TabIndex = 0
        Me.lblDirectorAcademico.Text = "Director Académico"
        '
        'cmbCarrera
        '
        Me.cmbCarrera.DisplayMember = "Nombre"
        Me.cmbCarrera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCarrera.FormattingEnabled = True
        Me.cmbCarrera.Location = New System.Drawing.Point(193, 17)
        Me.cmbCarrera.Name = "cmbCarrera"
        Me.cmbCarrera.Size = New System.Drawing.Size(200, 21)
        Me.cmbCarrera.TabIndex = 3
        Me.cmbCarrera.ValueMember = "IdCarrera"
        '
        'lblCarrera
        '
        Me.lblCarrera.AutoSize = True
        Me.lblCarrera.Location = New System.Drawing.Point(34, 21)
        Me.lblCarrera.Name = "lblCarrera"
        Me.lblCarrera.Size = New System.Drawing.Size(44, 13)
        Me.lblCarrera.TabIndex = 1
        Me.lblCarrera.Text = "Carrera:"
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnCancelar.Image = Global.capaPresentacion.My.Resources.Resources.icono_volver
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(412, 345)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 30)
        Me.btnCancelar.TabIndex = 13
        Me.btnCancelar.Text = "Atrás"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAsignar
        '
        Me.btnAsignar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnAsignar.Image = CType(resources.GetObject("btnAsignar.Image"), System.Drawing.Image)
        Me.btnAsignar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAsignar.Location = New System.Drawing.Point(243, 345)
        Me.btnAsignar.Name = "btnAsignar"
        Me.btnAsignar.Size = New System.Drawing.Size(100, 30)
        Me.btnAsignar.TabIndex = 12
        Me.btnAsignar.Text = "Asignar"
        Me.btnAsignar.UseVisualStyleBackColor = True
        '
        'gbCarrera
        '
        Me.gbCarrera.Controls.Add(Me.cmbCarrera)
        Me.gbCarrera.Controls.Add(Me.lblCarrera)
        Me.gbCarrera.Location = New System.Drawing.Point(156, 188)
        Me.gbCarrera.Name = "gbCarrera"
        Me.gbCarrera.Size = New System.Drawing.Size(462, 66)
        Me.gbCarrera.TabIndex = 15
        Me.gbCarrera.TabStop = False
        Me.gbCarrera.Text = "Carrera a la que se Asignará"
        '
        'frmAsignarDirectorAcademicoCarrera
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(832, 482)
        Me.ControlBox = False
        Me.Controls.Add(Me.gbCurso)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAsignar)
        Me.Controls.Add(Me.gbCarrera)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAsignarDirectorAcademicoCarrera"
        Me.Text = "Asignar Director Académico a Carrera"
        Me.gbCurso.ResumeLayout(False)
        Me.gbCurso.PerformLayout()
        Me.gbCarrera.ResumeLayout(False)
        Me.gbCarrera.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbCurso As System.Windows.Forms.GroupBox
    Friend WithEvents cmbDirectorAcademico As System.Windows.Forms.ComboBox
    Friend WithEvents lblDirectorAcademico As System.Windows.Forms.Label
    Friend WithEvents cmbCarrera As System.Windows.Forms.ComboBox
    Friend WithEvents lblCarrera As System.Windows.Forms.Label
    Private WithEvents btnCancelar As System.Windows.Forms.Button
    Private WithEvents btnAsignar As System.Windows.Forms.Button
    Friend WithEvents gbCarrera As System.Windows.Forms.GroupBox
End Class
