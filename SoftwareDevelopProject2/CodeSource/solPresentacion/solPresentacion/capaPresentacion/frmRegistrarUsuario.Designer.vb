<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistrarUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegistrarUsuario))
        Me.gbUsuario = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbRol = New System.Windows.Forms.ComboBox()
        Me.rbtF = New System.Windows.Forms.RadioButton()
        Me.rbtM = New System.Windows.Forms.RadioButton()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.txtaDireccion = New System.Windows.Forms.TextBox()
        Me.txtTelfCel = New System.Windows.Forms.TextBox()
        Me.txtTelfCasa = New System.Windows.Forms.TextBox()
        Me.txtContrasenna = New System.Windows.Forms.TextBox()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.txtApellido2 = New System.Windows.Forms.TextBox()
        Me.txtApellido1 = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtCarnet = New System.Windows.Forms.TextBox()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.lblCelular = New System.Windows.Forms.Label()
        Me.lblCasa = New System.Windows.Forms.Label()
        Me.lblContrasenna = New System.Windows.Forms.Label()
        Me.lblCorreo = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblGenero = New System.Windows.Forms.Label()
        Me.lblApellido2 = New System.Windows.Forms.Label()
        Me.lblApellido1 = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblCarnet = New System.Windows.Forms.Label()
        Me.lblCedula = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.bntRegistrar = New System.Windows.Forms.Button()
        Me.gbUsuario.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbUsuario
        '
        Me.gbUsuario.Controls.Add(Me.Label1)
        Me.gbUsuario.Controls.Add(Me.cmbRol)
        Me.gbUsuario.Controls.Add(Me.rbtF)
        Me.gbUsuario.Controls.Add(Me.rbtM)
        Me.gbUsuario.Controls.Add(Me.dtpFecha)
        Me.gbUsuario.Controls.Add(Me.txtaDireccion)
        Me.gbUsuario.Controls.Add(Me.txtTelfCel)
        Me.gbUsuario.Controls.Add(Me.txtTelfCasa)
        Me.gbUsuario.Controls.Add(Me.txtContrasenna)
        Me.gbUsuario.Controls.Add(Me.txtCorreo)
        Me.gbUsuario.Controls.Add(Me.txtApellido2)
        Me.gbUsuario.Controls.Add(Me.txtApellido1)
        Me.gbUsuario.Controls.Add(Me.txtNombre)
        Me.gbUsuario.Controls.Add(Me.txtCarnet)
        Me.gbUsuario.Controls.Add(Me.txtCedula)
        Me.gbUsuario.Controls.Add(Me.lblDireccion)
        Me.gbUsuario.Controls.Add(Me.lblCelular)
        Me.gbUsuario.Controls.Add(Me.lblCasa)
        Me.gbUsuario.Controls.Add(Me.lblContrasenna)
        Me.gbUsuario.Controls.Add(Me.lblCorreo)
        Me.gbUsuario.Controls.Add(Me.lblFecha)
        Me.gbUsuario.Controls.Add(Me.lblGenero)
        Me.gbUsuario.Controls.Add(Me.lblApellido2)
        Me.gbUsuario.Controls.Add(Me.lblApellido1)
        Me.gbUsuario.Controls.Add(Me.lblNombre)
        Me.gbUsuario.Controls.Add(Me.lblCarnet)
        Me.gbUsuario.Controls.Add(Me.lblCedula)
        Me.gbUsuario.Location = New System.Drawing.Point(40, 33)
        Me.gbUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.gbUsuario.Name = "gbUsuario"
        Me.gbUsuario.Padding = New System.Windows.Forms.Padding(2)
        Me.gbUsuario.Size = New System.Drawing.Size(670, 393)
        Me.gbUsuario.TabIndex = 0
        Me.gbUsuario.TabStop = False
        Me.gbUsuario.Text = "Datos de Usuario"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(364, 233)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Rol:"
        '
        'cmbRol
        '
        Me.cmbRol.DisplayMember = "Nombre"
        Me.cmbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRol.FormattingEnabled = True
        Me.cmbRol.Location = New System.Drawing.Point(464, 230)
        Me.cmbRol.Name = "cmbRol"
        Me.cmbRol.Size = New System.Drawing.Size(170, 21)
        Me.cmbRol.TabIndex = 30
        Me.cmbRol.ValueMember = "IdRol"
        '
        'rbtF
        '
        Me.rbtF.AutoSize = True
        Me.rbtF.Location = New System.Drawing.Point(563, 107)
        Me.rbtF.Margin = New System.Windows.Forms.Padding(2)
        Me.rbtF.Name = "rbtF"
        Me.rbtF.Size = New System.Drawing.Size(71, 17)
        Me.rbtF.TabIndex = 7
        Me.rbtF.TabStop = True
        Me.rbtF.Text = "Femenino"
        Me.rbtF.UseVisualStyleBackColor = True
        '
        'rbtM
        '
        Me.rbtM.AutoSize = True
        Me.rbtM.Location = New System.Drawing.Point(464, 107)
        Me.rbtM.Margin = New System.Windows.Forms.Padding(2)
        Me.rbtM.Name = "rbtM"
        Me.rbtM.Size = New System.Drawing.Size(73, 17)
        Me.rbtM.TabIndex = 6
        Me.rbtM.TabStop = True
        Me.rbtM.Text = "Masculino"
        Me.rbtM.UseVisualStyleBackColor = True
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(150, 141)
        Me.dtpFecha.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(170, 20)
        Me.dtpFecha.TabIndex = 8
        '
        'txtaDireccion
        '
        Me.txtaDireccion.Location = New System.Drawing.Point(152, 269)
        Me.txtaDireccion.Margin = New System.Windows.Forms.Padding(2)
        Me.txtaDireccion.Multiline = True
        Me.txtaDireccion.Name = "txtaDireccion"
        Me.txtaDireccion.Size = New System.Drawing.Size(482, 98)
        Me.txtaDireccion.TabIndex = 14
        '
        'txtTelfCel
        '
        Me.txtTelfCel.Location = New System.Drawing.Point(152, 230)
        Me.txtTelfCel.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTelfCel.Name = "txtTelfCel"
        Me.txtTelfCel.Size = New System.Drawing.Size(170, 20)
        Me.txtTelfCel.TabIndex = 13
        '
        'txtTelfCasa
        '
        Me.txtTelfCasa.Location = New System.Drawing.Point(464, 189)
        Me.txtTelfCasa.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTelfCasa.Name = "txtTelfCasa"
        Me.txtTelfCasa.Size = New System.Drawing.Size(170, 20)
        Me.txtTelfCasa.TabIndex = 12
        '
        'txtContrasenna
        '
        Me.txtContrasenna.Location = New System.Drawing.Point(150, 182)
        Me.txtContrasenna.Margin = New System.Windows.Forms.Padding(2)
        Me.txtContrasenna.Name = "txtContrasenna"
        Me.txtContrasenna.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContrasenna.Size = New System.Drawing.Size(170, 20)
        Me.txtContrasenna.TabIndex = 11
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(464, 144)
        Me.txtCorreo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(170, 20)
        Me.txtCorreo.TabIndex = 10
        '
        'txtApellido2
        '
        Me.txtApellido2.Location = New System.Drawing.Point(150, 102)
        Me.txtApellido2.Margin = New System.Windows.Forms.Padding(2)
        Me.txtApellido2.Name = "txtApellido2"
        Me.txtApellido2.Size = New System.Drawing.Size(170, 20)
        Me.txtApellido2.TabIndex = 5
        '
        'txtApellido1
        '
        Me.txtApellido1.Location = New System.Drawing.Point(464, 69)
        Me.txtApellido1.Margin = New System.Windows.Forms.Padding(2)
        Me.txtApellido1.Name = "txtApellido1"
        Me.txtApellido1.Size = New System.Drawing.Size(170, 20)
        Me.txtApellido1.TabIndex = 4
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(150, 66)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(170, 20)
        Me.txtNombre.TabIndex = 3
        '
        'txtCarnet
        '
        Me.txtCarnet.Location = New System.Drawing.Point(464, 28)
        Me.txtCarnet.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCarnet.Name = "txtCarnet"
        Me.txtCarnet.Size = New System.Drawing.Size(170, 20)
        Me.txtCarnet.TabIndex = 2
        '
        'txtCedula
        '
        Me.txtCedula.Location = New System.Drawing.Point(150, 30)
        Me.txtCedula.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(170, 20)
        Me.txtCedula.TabIndex = 1
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Location = New System.Drawing.Point(29, 269)
        Me.lblDireccion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(91, 13)
        Me.lblDireccion.TabIndex = 12
        Me.lblDireccion.Text = "Dirección Exacta:"
        '
        'lblCelular
        '
        Me.lblCelular.AutoSize = True
        Me.lblCelular.Location = New System.Drawing.Point(29, 233)
        Me.lblCelular.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCelular.Name = "lblCelular"
        Me.lblCelular.Size = New System.Drawing.Size(66, 13)
        Me.lblCelular.TabIndex = 11
        Me.lblCelular.Text = "Telf. Celular:"
        '
        'lblCasa
        '
        Me.lblCasa.AutoSize = True
        Me.lblCasa.Location = New System.Drawing.Point(364, 189)
        Me.lblCasa.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCasa.Name = "lblCasa"
        Me.lblCasa.Size = New System.Drawing.Size(58, 13)
        Me.lblCasa.TabIndex = 10
        Me.lblCasa.Text = "Telf. Casa:"
        '
        'lblContrasenna
        '
        Me.lblContrasenna.AutoSize = True
        Me.lblContrasenna.Location = New System.Drawing.Point(29, 189)
        Me.lblContrasenna.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblContrasenna.Name = "lblContrasenna"
        Me.lblContrasenna.Size = New System.Drawing.Size(64, 13)
        Me.lblContrasenna.TabIndex = 9
        Me.lblContrasenna.Text = "Contraseña:"
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Location = New System.Drawing.Point(364, 148)
        Me.lblCorreo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(97, 13)
        Me.lblCorreo.TabIndex = 8
        Me.lblCorreo.Text = "Correo Electrónico:"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(29, 143)
        Me.lblFecha.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(111, 13)
        Me.lblFecha.TabIndex = 6
        Me.lblFecha.Text = "Fecha de Nacimiento:"
        '
        'lblGenero
        '
        Me.lblGenero.AutoSize = True
        Me.lblGenero.Location = New System.Drawing.Point(364, 105)
        Me.lblGenero.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblGenero.Name = "lblGenero"
        Me.lblGenero.Size = New System.Drawing.Size(45, 13)
        Me.lblGenero.TabIndex = 5
        Me.lblGenero.Text = "Género:"
        '
        'lblApellido2
        '
        Me.lblApellido2.AutoSize = True
        Me.lblApellido2.Location = New System.Drawing.Point(29, 105)
        Me.lblApellido2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblApellido2.Name = "lblApellido2"
        Me.lblApellido2.Size = New System.Drawing.Size(93, 13)
        Me.lblApellido2.TabIndex = 4
        Me.lblApellido2.Text = "Segundo Apellido:"
        '
        'lblApellido1
        '
        Me.lblApellido1.AutoSize = True
        Me.lblApellido1.Location = New System.Drawing.Point(364, 69)
        Me.lblApellido1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblApellido1.Name = "lblApellido1"
        Me.lblApellido1.Size = New System.Drawing.Size(79, 13)
        Me.lblApellido1.TabIndex = 3
        Me.lblApellido1.Text = "Primer Apellido:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(29, 69)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(47, 13)
        Me.lblNombre.TabIndex = 2
        Me.lblNombre.Text = "Nombre:"
        '
        'lblCarnet
        '
        Me.lblCarnet.AutoSize = True
        Me.lblCarnet.Location = New System.Drawing.Point(364, 31)
        Me.lblCarnet.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCarnet.Name = "lblCarnet"
        Me.lblCarnet.Size = New System.Drawing.Size(38, 13)
        Me.lblCarnet.TabIndex = 1
        Me.lblCarnet.Text = "Carné:"
        '
        'lblCedula
        '
        Me.lblCedula.AutoSize = True
        Me.lblCedula.Location = New System.Drawing.Point(29, 30)
        Me.lblCedula.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(96, 13)
        Me.lblCedula.TabIndex = 0
        Me.lblCedula.Text = "Cédula/Pasaporte:"
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = Global.capaPresentacion.My.Resources.Resources.icono_volver
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(407, 431)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 30)
        Me.btnCancelar.TabIndex = 31
        Me.btnCancelar.Text = "Atrás"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'bntRegistrar
        '
        Me.bntRegistrar.Image = Global.capaPresentacion.My.Resources.Resources.save_update
        Me.bntRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bntRegistrar.Location = New System.Drawing.Point(290, 431)
        Me.bntRegistrar.Name = "bntRegistrar"
        Me.bntRegistrar.Size = New System.Drawing.Size(100, 30)
        Me.bntRegistrar.TabIndex = 30
        Me.bntRegistrar.Text = "Registrar"
        Me.bntRegistrar.UseVisualStyleBackColor = True
        '
        'frmRegistrarUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(776, 484)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.bntRegistrar)
        Me.Controls.Add(Me.gbUsuario)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRegistrarUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar Usuario"
        Me.gbUsuario.ResumeLayout(False)
        Me.gbUsuario.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbUsuario As System.Windows.Forms.GroupBox
    Friend WithEvents rbtF As System.Windows.Forms.RadioButton
    Friend WithEvents rbtM As System.Windows.Forms.RadioButton
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtaDireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtTelfCel As System.Windows.Forms.TextBox
    Friend WithEvents txtTelfCasa As System.Windows.Forms.TextBox
    Friend WithEvents txtContrasenna As System.Windows.Forms.TextBox
    Friend WithEvents txtCorreo As System.Windows.Forms.TextBox
    Friend WithEvents txtApellido2 As System.Windows.Forms.TextBox
    Friend WithEvents txtApellido1 As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtCarnet As System.Windows.Forms.TextBox
    Friend WithEvents txtCedula As System.Windows.Forms.TextBox
    Friend WithEvents lblDireccion As System.Windows.Forms.Label
    Friend WithEvents lblCelular As System.Windows.Forms.Label
    Friend WithEvents lblCasa As System.Windows.Forms.Label
    Friend WithEvents lblContrasenna As System.Windows.Forms.Label
    Friend WithEvents lblCorreo As System.Windows.Forms.Label
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents lblGenero As System.Windows.Forms.Label
    Friend WithEvents lblApellido2 As System.Windows.Forms.Label
    Friend WithEvents lblApellido1 As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblCarnet As System.Windows.Forms.Label
    Friend WithEvents lblCedula As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbRol As System.Windows.Forms.ComboBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents bntRegistrar As System.Windows.Forms.Button
End Class
