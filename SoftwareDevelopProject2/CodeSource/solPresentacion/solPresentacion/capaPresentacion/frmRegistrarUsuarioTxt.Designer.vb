<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistrarUsuarioTxt
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
        Me.gbRegistrarUsuarios = New System.Windows.Forms.GroupBox()
        Me.txtDirectorio = New System.Windows.Forms.TextBox()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.gbRegistrarUsuarios.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbRegistrarUsuarios
        '
        Me.gbRegistrarUsuarios.Controls.Add(Me.txtDirectorio)
        Me.gbRegistrarUsuarios.Controls.Add(Me.btnRegistrar)
        Me.gbRegistrarUsuarios.Controls.Add(Me.btnBuscar)
        Me.gbRegistrarUsuarios.Location = New System.Drawing.Point(188, 118)
        Me.gbRegistrarUsuarios.Name = "gbRegistrarUsuarios"
        Me.gbRegistrarUsuarios.Size = New System.Drawing.Size(449, 162)
        Me.gbRegistrarUsuarios.TabIndex = 15
        Me.gbRegistrarUsuarios.TabStop = False
        Me.gbRegistrarUsuarios.Tag = ""
        Me.gbRegistrarUsuarios.Text = "Registrar Usuarios"
        '
        'txtDirectorio
        '
        Me.txtDirectorio.Location = New System.Drawing.Point(6, 53)
        Me.txtDirectorio.Name = "txtDirectorio"
        Me.txtDirectorio.Size = New System.Drawing.Size(286, 20)
        Me.txtDirectorio.TabIndex = 17
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Image = Global.capaPresentacion.My.Resources.Resources.add
        Me.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegistrar.Location = New System.Drawing.Point(312, 89)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(100, 30)
        Me.btnRegistrar.TabIndex = 16
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Image = Global.capaPresentacion.My.Resources.Resources.search
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(312, 53)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(100, 30)
        Me.btnBuscar.TabIndex = 15
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCancelar.Image = Global.capaPresentacion.My.Resources.Resources.icono_volver
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(500, 304)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 30)
        Me.btnCancelar.TabIndex = 18
        Me.btnCancelar.Text = "Atrás"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'frmRegistrarUsuarioTxt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(838, 506)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.gbRegistrarUsuarios)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmRegistrarUsuarioTxt"
        Me.Text = "Registrar Estudiantes Por Batch"
        Me.gbRegistrarUsuarios.ResumeLayout(False)
        Me.gbRegistrarUsuarios.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbRegistrarUsuarios As System.Windows.Forms.GroupBox
    Private WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents txtDirectorio As System.Windows.Forms.TextBox
    Friend WithEvents btnRegistrar As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
End Class
