<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModificarTema
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
        Me.gbDatosTema = New System.Windows.Forms.GroupBox()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.txtAportesMax = New System.Windows.Forms.TextBox()
        Me.txtTitulo = New System.Windows.Forms.TextBox()
        Me.lblAportesMin = New System.Windows.Forms.Label()
        Me.lblFechaFin = New System.Windows.Forms.Label()
        Me.lblFechaInicio = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btmModificar = New System.Windows.Forms.Button()
        Me.gbDatosTema.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbDatosTema
        '
        Me.gbDatosTema.Controls.Add(Me.dtpFechaFin)
        Me.gbDatosTema.Controls.Add(Me.dtpFechaInicio)
        Me.gbDatosTema.Controls.Add(Me.txtAportesMax)
        Me.gbDatosTema.Controls.Add(Me.txtTitulo)
        Me.gbDatosTema.Controls.Add(Me.lblAportesMin)
        Me.gbDatosTema.Controls.Add(Me.lblFechaFin)
        Me.gbDatosTema.Controls.Add(Me.lblFechaInicio)
        Me.gbDatosTema.Controls.Add(Me.lblTitulo)
        Me.gbDatosTema.Location = New System.Drawing.Point(12, 12)
        Me.gbDatosTema.Name = "gbDatosTema"
        Me.gbDatosTema.Size = New System.Drawing.Size(425, 255)
        Me.gbDatosTema.TabIndex = 0
        Me.gbDatosTema.TabStop = False
        Me.gbDatosTema.Text = "Datos Tema"
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Location = New System.Drawing.Point(152, 120)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(254, 20)
        Me.dtpFechaFin.TabIndex = 2
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Location = New System.Drawing.Point(152, 76)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(254, 20)
        Me.dtpFechaInicio.TabIndex = 1
        '
        'txtAportesMax
        '
        Me.txtAportesMax.Location = New System.Drawing.Point(152, 164)
        Me.txtAportesMax.Name = "txtAportesMax"
        Me.txtAportesMax.Size = New System.Drawing.Size(254, 20)
        Me.txtAportesMax.TabIndex = 3
        '
        'txtTitulo
        '
        Me.txtTitulo.Location = New System.Drawing.Point(152, 30)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(254, 20)
        Me.txtTitulo.TabIndex = 0
        '
        'lblAportesMin
        '
        Me.lblAportesMin.AutoSize = True
        Me.lblAportesMin.Location = New System.Drawing.Point(36, 167)
        Me.lblAportesMin.Name = "lblAportesMin"
        Me.lblAportesMin.Size = New System.Drawing.Size(85, 13)
        Me.lblAportesMin.TabIndex = 10
        Me.lblAportesMin.Text = "Aportes Máximo:"
        '
        'lblFechaFin
        '
        Me.lblFechaFin.AutoSize = True
        Me.lblFechaFin.Location = New System.Drawing.Point(36, 126)
        Me.lblFechaFin.Name = "lblFechaFin"
        Me.lblFechaFin.Size = New System.Drawing.Size(57, 13)
        Me.lblFechaFin.TabIndex = 12
        Me.lblFechaFin.Text = "Fecha Fin:"
        '
        'lblFechaInicio
        '
        Me.lblFechaInicio.AutoSize = True
        Me.lblFechaInicio.Location = New System.Drawing.Point(36, 76)
        Me.lblFechaInicio.Name = "lblFechaInicio"
        Me.lblFechaInicio.Size = New System.Drawing.Size(68, 13)
        Me.lblFechaInicio.TabIndex = 14
        Me.lblFechaInicio.Text = "Fecha Inicio:"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Location = New System.Drawing.Point(36, 33)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(38, 13)
        Me.lblTitulo.TabIndex = 13
        Me.lblTitulo.Text = "Título:"
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = Global.capaPresentacion.My.Resources.Resources.close
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(318, 273)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 30)
        Me.btnCancelar.TabIndex = 6
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btmModificar
        '
        Me.btmModificar.Image = Global.capaPresentacion.My.Resources.Resources.save_update
        Me.btmModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btmModificar.Location = New System.Drawing.Point(164, 273)
        Me.btmModificar.Name = "btmModificar"
        Me.btmModificar.Size = New System.Drawing.Size(100, 30)
        Me.btmModificar.TabIndex = 5
        Me.btmModificar.Text = "Modificar"
        Me.btmModificar.UseVisualStyleBackColor = True
        '
        'frmModificarTema
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 315)
        Me.ControlBox = False
        Me.Controls.Add(Me.gbDatosTema)
        Me.Controls.Add(Me.btmModificar)
        Me.Controls.Add(Me.btnCancelar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmModificarTema"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar Tema"
        Me.gbDatosTema.ResumeLayout(False)
        Me.gbDatosTema.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbDatosTema As System.Windows.Forms.GroupBox
    Friend WithEvents dtpFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtAportesMax As System.Windows.Forms.TextBox
    Friend WithEvents txtTitulo As System.Windows.Forms.TextBox
    Friend WithEvents lblAportesMin As System.Windows.Forms.Label
    Friend WithEvents lblFechaFin As System.Windows.Forms.Label
    Friend WithEvents lblFechaInicio As System.Windows.Forms.Label
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Private WithEvents btnCancelar As System.Windows.Forms.Button
    Private WithEvents btmModificar As System.Windows.Forms.Button
End Class
