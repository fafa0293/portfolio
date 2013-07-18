<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAsignarCursoCarrera
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAsignarCursoCarrera))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbCurso = New System.Windows.Forms.ComboBox()
        Me.cmbCarrera = New System.Windows.Forms.ComboBox()
        Me.btnAsignar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.gbCurso = New System.Windows.Forms.GroupBox()
        Me.gbCarrera = New System.Windows.Forms.GroupBox()
        Me.gbCurso.SuspendLayout()
        Me.gbCarrera.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Curso:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Carrera:"
        '
        'cmbCurso
        '
        Me.cmbCurso.DisplayMember = "Nombre"
        Me.cmbCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCurso.FormattingEnabled = True
        Me.cmbCurso.Location = New System.Drawing.Point(193, 17)
        Me.cmbCurso.Name = "cmbCurso"
        Me.cmbCurso.Size = New System.Drawing.Size(200, 21)
        Me.cmbCurso.TabIndex = 2
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
        '
        'btnAsignar
        '
        Me.btnAsignar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnAsignar.Image = CType(resources.GetObject("btnAsignar.Image"), System.Drawing.Image)
        Me.btnAsignar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAsignar.Location = New System.Drawing.Point(238, 244)
        Me.btnAsignar.Name = "btnAsignar"
        Me.btnAsignar.Size = New System.Drawing.Size(100, 30)
        Me.btnAsignar.TabIndex = 4
        Me.btnAsignar.Text = "Asignar"
        Me.btnAsignar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnCancelar.Image = Global.capaPresentacion.My.Resources.Resources.icono_volver
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(407, 244)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 30)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "Atrás"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'gbCurso
        '
        Me.gbCurso.Controls.Add(Me.cmbCurso)
        Me.gbCurso.Controls.Add(Me.Label1)
        Me.gbCurso.Location = New System.Drawing.Point(45, 39)
        Me.gbCurso.Name = "gbCurso"
        Me.gbCurso.Size = New System.Drawing.Size(462, 66)
        Me.gbCurso.TabIndex = 6
        Me.gbCurso.TabStop = False
        Me.gbCurso.Text = "Curso a Asignar"
        '
        'gbCarrera
        '
        Me.gbCarrera.Controls.Add(Me.cmbCarrera)
        Me.gbCarrera.Controls.Add(Me.Label2)
        Me.gbCarrera.Location = New System.Drawing.Point(45, 138)
        Me.gbCarrera.Name = "gbCarrera"
        Me.gbCarrera.Size = New System.Drawing.Size(462, 66)
        Me.gbCarrera.TabIndex = 7
        Me.gbCarrera.TabStop = False
        Me.gbCarrera.Text = "Carrera a la que se Asignará"
        '
        'frmAsignarCursoCarrera
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(554, 311)
        Me.ControlBox = False
        Me.Controls.Add(Me.gbCarrera)
        Me.Controls.Add(Me.gbCurso)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAsignar)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAsignarCursoCarrera"
        Me.Text = "Asignar Curso a Carrera"
        Me.gbCurso.ResumeLayout(False)
        Me.gbCurso.PerformLayout()
        Me.gbCarrera.ResumeLayout(False)
        Me.gbCarrera.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbCurso As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCarrera As System.Windows.Forms.ComboBox
    Friend WithEvents gbCurso As System.Windows.Forms.GroupBox
    Friend WithEvents gbCarrera As System.Windows.Forms.GroupBox
    Private WithEvents btnAsignar As System.Windows.Forms.Button
    Private WithEvents btnCancelar As System.Windows.Forms.Button

End Class
