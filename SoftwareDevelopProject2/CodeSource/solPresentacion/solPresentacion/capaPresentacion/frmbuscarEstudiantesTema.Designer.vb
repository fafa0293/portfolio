<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmbuscarEstudiantesTema
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmbuscarEstudiantesTema))
        Me.gbBusqueda = New System.Windows.Forms.GroupBox()
        Me.cmbTema = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
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
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnExportar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.gbBusqueda.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgDatosUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbBusqueda
        '
        Me.gbBusqueda.Controls.Add(Me.cmbTema)
        Me.gbBusqueda.Controls.Add(Me.Label1)
        Me.gbBusqueda.Controls.Add(Me.btnBuscar)
        Me.gbBusqueda.Location = New System.Drawing.Point(39, 34)
        Me.gbBusqueda.Name = "gbBusqueda"
        Me.gbBusqueda.Size = New System.Drawing.Size(683, 60)
        Me.gbBusqueda.TabIndex = 8
        Me.gbBusqueda.TabStop = False
        Me.gbBusqueda.Text = "Búsqueda"
        '
        'cmbTema
        '
        Me.cmbTema.DisplayMember = "Titulo"
        Me.cmbTema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTema.FormattingEnabled = True
        Me.cmbTema.Location = New System.Drawing.Point(126, 23)
        Me.cmbTema.Name = "cmbTema"
        Me.cmbTema.Size = New System.Drawing.Size(193, 21)
        Me.cmbTema.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tema:"
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(543, 17)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(100, 30)
        Me.btnBuscar.TabIndex = 9
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgDatosUsuario)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Location = New System.Drawing.Point(39, 125)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(683, 242)
        Me.GroupBox2.TabIndex = 9
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
        Me.dgDatosUsuario.Location = New System.Drawing.Point(24, 30)
        Me.dgDatosUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.dgDatosUsuario.MultiSelect = False
        Me.dgDatosUsuario.Name = "dgDatosUsuario"
        Me.dgDatosUsuario.ReadOnly = True
        Me.dgDatosUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgDatosUsuario.Size = New System.Drawing.Size(479, 192)
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
        Me.FechaNacimiento.Width = 120
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
        Me.GroupBox3.Controls.Add(Me.btnEliminar)
        Me.GroupBox3.Controls.Add(Me.btnExportar)
        Me.GroupBox3.Location = New System.Drawing.Point(523, 19)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(141, 98)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Opciones"
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.Location = New System.Drawing.Point(20, 54)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(100, 30)
        Me.btnEliminar.TabIndex = 5
        Me.btnEliminar.Text = "Bloquear"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnExportar
        '
        Me.btnExportar.Image = CType(resources.GetObject("btnExportar.Image"), System.Drawing.Image)
        Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExportar.Location = New System.Drawing.Point(20, 19)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(100, 30)
        Me.btnExportar.TabIndex = 4
        Me.btnExportar.Text = "Exportar"
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnCancelar.Image = Global.capaPresentacion.My.Resources.Resources.icono_volver
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(582, 373)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 30)
        Me.btnCancelar.TabIndex = 10
        Me.btnCancelar.Text = "Atrás"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'frmbuscarEstudiantesTema
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(761, 418)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.gbBusqueda)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmbuscarEstudiantesTema"
        Me.Text = "Buscar Estudiantes de un Tema"
        Me.gbBusqueda.ResumeLayout(False)
        Me.gbBusqueda.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgDatosUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbBusqueda As System.Windows.Forms.GroupBox
    Friend WithEvents cmbTema As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgDatosUsuario As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnExportar As System.Windows.Forms.Button
    Private WithEvents btnCancelar As System.Windows.Forms.Button
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
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
End Class
