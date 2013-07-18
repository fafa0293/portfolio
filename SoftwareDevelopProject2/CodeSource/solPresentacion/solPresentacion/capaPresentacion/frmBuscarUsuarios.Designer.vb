<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarUsuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuscarUsuarios))
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgDatosUsuario = New System.Windows.Forms.DataGridView()
        Me.idUsuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Correo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaNacimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dirección = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoFijo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoCelular = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnBitacora = New System.Windows.Forms.Button()
        Me.btnExportar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.gbBusqueda = New System.Windows.Forms.GroupBox()
        Me.rbdTodos = New System.Windows.Forms.RadioButton()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.rdbNombre = New System.Windows.Forms.RadioButton()
        Me.cmbRol = New System.Windows.Forms.ComboBox()
        Me.rdbRol = New System.Windows.Forms.RadioButton()
        Me.rdbCedula = New System.Windows.Forms.RadioButton()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgDatosUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.gbBusqueda.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCerrar
        '
        Me.btnCerrar.Image = Global.capaPresentacion.My.Resources.Resources.icono_volver
        Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerrar.Location = New System.Drawing.Point(667, 432)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(100, 30)
        Me.btnCerrar.TabIndex = 3
        Me.btnCerrar.Text = "Atrás"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgDatosUsuario)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Location = New System.Drawing.Point(34, 178)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(767, 248)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Resultado"
        '
        'dgDatosUsuario
        '
        Me.dgDatosUsuario.AllowUserToAddRows = False
        Me.dgDatosUsuario.AllowUserToDeleteRows = False
        Me.dgDatosUsuario.AllowUserToOrderColumns = True
        Me.dgDatosUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDatosUsuario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idUsuario, Me.Column6, Me.Column1, Me.Column2, Me.Apellido2, Me.Column3, Me.Column4, Me.Column5, Me.Correo, Me.FechaNacimiento, Me.Dirección, Me.TelefonoFijo, Me.TelefonoCelular})
        Me.dgDatosUsuario.Location = New System.Drawing.Point(11, 24)
        Me.dgDatosUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.dgDatosUsuario.MultiSelect = False
        Me.dgDatosUsuario.Name = "dgDatosUsuario"
        Me.dgDatosUsuario.ReadOnly = True
        Me.dgDatosUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgDatosUsuario.Size = New System.Drawing.Size(592, 204)
        Me.dgDatosUsuario.TabIndex = 5
        '
        'idUsuario
        '
        Me.idUsuario.DataPropertyName = "idUsuario"
        Me.idUsuario.HeaderText = "Id"
        Me.idUsuario.Name = "idUsuario"
        Me.idUsuario.ReadOnly = True
        Me.idUsuario.Visible = False
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "Contrasenna"
        Me.Column6.HeaderText = "Contraseña"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Visible = False
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "Nombre"
        Me.Column1.HeaderText = "Nombre"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.ToolTipText = "Nombre del Usuario"
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "Apellido1"
        Me.Column2.HeaderText = "Primer Apellido"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.ToolTipText = "Primer Apellido"
        Me.Column2.Width = 120
        '
        'Apellido2
        '
        Me.Apellido2.DataPropertyName = "Apellido2"
        Me.Apellido2.HeaderText = "Segundo Apellido"
        Me.Apellido2.Name = "Apellido2"
        Me.Apellido2.ReadOnly = True
        Me.Apellido2.ToolTipText = "Segundo Apellido"
        Me.Apellido2.Width = 120
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "Cedula"
        Me.Column3.HeaderText = "Cédula"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.ToolTipText = "Número de Cédula"
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "Carnet"
        Me.Column4.HeaderText = "Carné"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.ToolTipText = "Número de Carné"
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "Genero"
        Me.Column5.HeaderText = "Género"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.ToolTipText = "Género M=Masculino F=Femenino"
        '
        'Correo
        '
        Me.Correo.DataPropertyName = "Correo"
        Me.Correo.HeaderText = "Correo Electrónico"
        Me.Correo.Name = "Correo"
        Me.Correo.ReadOnly = True
        Me.Correo.ToolTipText = "Dirección del Correo Electrónico"
        Me.Correo.Width = 130
        '
        'FechaNacimiento
        '
        Me.FechaNacimiento.DataPropertyName = "FechaNacimiento"
        Me.FechaNacimiento.HeaderText = "Fecha Nacimiento"
        Me.FechaNacimiento.Name = "FechaNacimiento"
        Me.FechaNacimiento.ReadOnly = True
        Me.FechaNacimiento.ToolTipText = "Fecha Nacimiento"
        Me.FechaNacimiento.Width = 130
        '
        'Dirección
        '
        Me.Dirección.DataPropertyName = "Direccion"
        Me.Dirección.HeaderText = "Dirección"
        Me.Dirección.Name = "Dirección"
        Me.Dirección.ReadOnly = True
        Me.Dirección.ToolTipText = "Dirección de Habitación"
        '
        'TelefonoFijo
        '
        Me.TelefonoFijo.DataPropertyName = "TelefonoFijo"
        Me.TelefonoFijo.HeaderText = "Tel.Fijo"
        Me.TelefonoFijo.Name = "TelefonoFijo"
        Me.TelefonoFijo.ReadOnly = True
        Me.TelefonoFijo.ToolTipText = "Teléfono Fijo"
        '
        'TelefonoCelular
        '
        Me.TelefonoCelular.DataPropertyName = "TelefonoCelular"
        Me.TelefonoCelular.HeaderText = "Tel.Celular"
        Me.TelefonoCelular.Name = "TelefonoCelular"
        Me.TelefonoCelular.ReadOnly = True
        Me.TelefonoCelular.ToolTipText = "Teléfono Celular"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnBitacora)
        Me.GroupBox3.Controls.Add(Me.btnExportar)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.btnEliminar)
        Me.GroupBox3.Location = New System.Drawing.Point(627, 24)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(111, 176)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Opciones"
        '
        'btnBitacora
        '
        Me.btnBitacora.Image = CType(resources.GetObject("btnBitacora.Image"), System.Drawing.Image)
        Me.btnBitacora.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBitacora.Location = New System.Drawing.Point(5, 18)
        Me.btnBitacora.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBitacora.Name = "btnBitacora"
        Me.btnBitacora.Size = New System.Drawing.Size(100, 30)
        Me.btnBitacora.TabIndex = 14
        Me.btnBitacora.Text = "Bitácora"
        Me.btnBitacora.UseVisualStyleBackColor = True
        '
        'btnExportar
        '
        Me.btnExportar.Image = CType(resources.GetObject("btnExportar.Image"), System.Drawing.Image)
        Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExportar.Location = New System.Drawing.Point(5, 129)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(100, 30)
        Me.btnExportar.TabIndex = 4
        Me.btnExportar.Text = "Exportar"
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(5, 57)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 30)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Modificar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.Location = New System.Drawing.Point(6, 93)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(100, 30)
        Me.btnEliminar.TabIndex = 0
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'gbBusqueda
        '
        Me.gbBusqueda.Controls.Add(Me.rbdTodos)
        Me.gbBusqueda.Controls.Add(Me.txtNombre)
        Me.gbBusqueda.Controls.Add(Me.btnBuscar)
        Me.gbBusqueda.Controls.Add(Me.txtCedula)
        Me.gbBusqueda.Controls.Add(Me.rdbNombre)
        Me.gbBusqueda.Controls.Add(Me.cmbRol)
        Me.gbBusqueda.Controls.Add(Me.rdbRol)
        Me.gbBusqueda.Controls.Add(Me.rdbCedula)
        Me.gbBusqueda.Location = New System.Drawing.Point(34, 37)
        Me.gbBusqueda.Name = "gbBusqueda"
        Me.gbBusqueda.Size = New System.Drawing.Size(767, 117)
        Me.gbBusqueda.TabIndex = 13
        Me.gbBusqueda.TabStop = False
        Me.gbBusqueda.Text = "Búsqueda"
        '
        'rbdTodos
        '
        Me.rbdTodos.AutoSize = True
        Me.rbdTodos.Location = New System.Drawing.Point(54, 89)
        Me.rbdTodos.Name = "rbdTodos"
        Me.rbdTodos.Size = New System.Drawing.Size(55, 17)
        Me.rbdTodos.TabIndex = 14
        Me.rbdTodos.TabStop = True
        Me.rbdTodos.Text = "Todos"
        Me.rbdTodos.UseVisualStyleBackColor = True
        '
        'txtNombre
        '
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(125, 19)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(200, 20)
        Me.txtNombre.TabIndex = 13
        '
        'btnBuscar
        '
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(632, 53)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(100, 30)
        Me.btnBuscar.TabIndex = 0
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtCedula
        '
        Me.txtCedula.Enabled = False
        Me.txtCedula.Location = New System.Drawing.Point(125, 42)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(200, 20)
        Me.txtCedula.TabIndex = 12
        '
        'rdbNombre
        '
        Me.rdbNombre.AutoSize = True
        Me.rdbNombre.Location = New System.Drawing.Point(54, 20)
        Me.rdbNombre.Name = "rdbNombre"
        Me.rdbNombre.Size = New System.Drawing.Size(65, 17)
        Me.rdbNombre.TabIndex = 9
        Me.rdbNombre.TabStop = True
        Me.rdbNombre.Text = "Nombre:"
        Me.rdbNombre.UseVisualStyleBackColor = True
        '
        'cmbRol
        '
        Me.cmbRol.DisplayMember = "Nombre"
        Me.cmbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRol.FormattingEnabled = True
        Me.cmbRol.Location = New System.Drawing.Point(125, 65)
        Me.cmbRol.Name = "cmbRol"
        Me.cmbRol.Size = New System.Drawing.Size(200, 21)
        Me.cmbRol.TabIndex = 8
        '
        'rdbRol
        '
        Me.rdbRol.AutoSize = True
        Me.rdbRol.Location = New System.Drawing.Point(54, 66)
        Me.rdbRol.Name = "rdbRol"
        Me.rdbRol.Size = New System.Drawing.Size(44, 17)
        Me.rdbRol.TabIndex = 11
        Me.rdbRol.TabStop = True
        Me.rdbRol.Text = "Rol:"
        Me.rdbRol.UseVisualStyleBackColor = True
        '
        'rdbCedula
        '
        Me.rdbCedula.AutoSize = True
        Me.rdbCedula.Location = New System.Drawing.Point(54, 43)
        Me.rdbCedula.Name = "rdbCedula"
        Me.rdbCedula.Size = New System.Drawing.Size(61, 17)
        Me.rdbCedula.TabIndex = 10
        Me.rdbCedula.TabStop = True
        Me.rdbCedula.Text = "Cédula:"
        Me.rdbCedula.UseVisualStyleBackColor = True
        '
        'frmBuscarUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(844, 473)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.gbBusqueda)
        Me.Controls.Add(Me.btnCerrar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmBuscarUsuarios"
        Me.Text = "Buscar Usuario"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgDatosUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.gbBusqueda.ResumeLayout(False)
        Me.gbBusqueda.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgDatosUsuario As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnExportar As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents gbBusqueda As System.Windows.Forms.GroupBox
    Friend WithEvents rbdTodos As System.Windows.Forms.RadioButton
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents txtCedula As System.Windows.Forms.TextBox
    Friend WithEvents rdbNombre As System.Windows.Forms.RadioButton
    Friend WithEvents cmbRol As System.Windows.Forms.ComboBox
    Friend WithEvents rdbRol As System.Windows.Forms.RadioButton
    Friend WithEvents rdbCedula As System.Windows.Forms.RadioButton
    Friend WithEvents btnBitacora As System.Windows.Forms.Button
    Friend WithEvents idUsuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Apellido2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Correo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaNacimiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Dirección As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelefonoFijo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelefonoCelular As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
