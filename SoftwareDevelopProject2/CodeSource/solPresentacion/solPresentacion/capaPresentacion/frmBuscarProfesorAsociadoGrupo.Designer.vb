<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarProfesorAsociadoGrupo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuscarProfesorAsociadoGrupo))
        Me.gbBusqueda = New System.Windows.Forms.GroupBox()
        Me.cmbGrupo = New System.Windows.Forms.ComboBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.lblGrupo = New System.Windows.Forms.Label()
        Me.gbResultado = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnExportar = New System.Windows.Forms.Button()
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
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.gbBusqueda.SuspendLayout()
        Me.gbResultado.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgDatosUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbBusqueda
        '
        Me.gbBusqueda.Controls.Add(Me.cmbGrupo)
        Me.gbBusqueda.Controls.Add(Me.btnBuscar)
        Me.gbBusqueda.Controls.Add(Me.lblGrupo)
        Me.gbBusqueda.Location = New System.Drawing.Point(34, 28)
        Me.gbBusqueda.Name = "gbBusqueda"
        Me.gbBusqueda.Size = New System.Drawing.Size(767, 71)
        Me.gbBusqueda.TabIndex = 0
        Me.gbBusqueda.TabStop = False
        Me.gbBusqueda.Text = "Búsqueda"
        '
        'cmbGrupo
        '
        Me.cmbGrupo.DisplayMember = "Nombre"
        Me.cmbGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGrupo.FormattingEnabled = True
        Me.cmbGrupo.Location = New System.Drawing.Point(116, 30)
        Me.cmbGrupo.Name = "cmbGrupo"
        Me.cmbGrupo.Size = New System.Drawing.Size(193, 21)
        Me.cmbGrupo.TabIndex = 3
        '
        'btnBuscar
        '
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(639, 24)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(100, 30)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'lblGrupo
        '
        Me.lblGrupo.AutoSize = True
        Me.lblGrupo.Location = New System.Drawing.Point(54, 33)
        Me.lblGrupo.Name = "lblGrupo"
        Me.lblGrupo.Size = New System.Drawing.Size(39, 13)
        Me.lblGrupo.TabIndex = 0
        Me.lblGrupo.Text = "Grupo:"
        '
        'gbResultado
        '
        Me.gbResultado.Controls.Add(Me.GroupBox3)
        Me.gbResultado.Controls.Add(Me.dgDatosUsuario)
        Me.gbResultado.Location = New System.Drawing.Point(34, 126)
        Me.gbResultado.Name = "gbResultado"
        Me.gbResultado.Size = New System.Drawing.Size(767, 248)
        Me.gbResultado.TabIndex = 1
        Me.gbResultado.TabStop = False
        Me.gbResultado.Text = "Resultado"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.btnExportar)
        Me.GroupBox3.Location = New System.Drawing.Point(627, 24)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(112, 98)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Opciones"
        '
        'Button1
        '
        Me.Button1.Image = Global.capaPresentacion.My.Resources.Resources.delete
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(5, 55)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 30)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Desasignar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnExportar
        '
        Me.btnExportar.Image = CType(resources.GetObject("btnExportar.Image"), System.Drawing.Image)
        Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExportar.Location = New System.Drawing.Point(6, 19)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(100, 30)
        Me.btnExportar.TabIndex = 4
        Me.btnExportar.Text = "Exportar"
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'dgDatosUsuario
        '
        Me.dgDatosUsuario.AllowUserToAddRows = False
        Me.dgDatosUsuario.AllowUserToDeleteRows = False
        Me.dgDatosUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDatosUsuario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idUsuario, Me.Column6, Me.Column1, Me.Column2, Me.Apellido2, Me.Column3, Me.Column4, Me.Column5, Me.Correo, Me.FechaNacimiento, Me.Dirección, Me.TelefonoFijo, Me.TelefonoCelular})
        Me.dgDatosUsuario.Location = New System.Drawing.Point(20, 31)
        Me.dgDatosUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.dgDatosUsuario.MultiSelect = False
        Me.dgDatosUsuario.Name = "dgDatosUsuario"
        Me.dgDatosUsuario.ReadOnly = True
        Me.dgDatosUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgDatosUsuario.Size = New System.Drawing.Size(585, 202)
        Me.dgDatosUsuario.TabIndex = 6
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
        'btnCerrar
        '
        Me.btnCerrar.Image = Global.capaPresentacion.My.Resources.Resources.icono_volver
        Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerrar.Location = New System.Drawing.Point(666, 398)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(100, 30)
        Me.btnCerrar.TabIndex = 2
        Me.btnCerrar.Text = "Atrás"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'frmBuscarProfesorAsociadoGrupo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(838, 455)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.gbResultado)
        Me.Controls.Add(Me.gbBusqueda)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmBuscarProfesorAsociadoGrupo"
        Me.Text = "Buscar Profesor Asociado a un Grupo"
        Me.gbBusqueda.ResumeLayout(False)
        Me.gbBusqueda.PerformLayout()
        Me.gbResultado.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgDatosUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbBusqueda As System.Windows.Forms.GroupBox
    Friend WithEvents lblGrupo As System.Windows.Forms.Label
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents gbResultado As System.Windows.Forms.GroupBox
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnExportar As System.Windows.Forms.Button
    Friend WithEvents dgDatosUsuario As System.Windows.Forms.DataGridView
    Friend WithEvents cmbGrupo As System.Windows.Forms.ComboBox
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
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class