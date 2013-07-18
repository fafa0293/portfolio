<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAsignarProfesor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAsignarProfesor))
        Me.btnAsignar = New System.Windows.Forms.Button()
        Me.gbProfesor = New System.Windows.Forms.GroupBox()
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
        Me.gbCurso = New System.Windows.Forms.GroupBox()
        Me.cmbCurso = New System.Windows.Forms.ComboBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.lblCurso = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.gbGrupo = New System.Windows.Forms.GroupBox()
        Me.dgResul = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idCur = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cdGrupo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_grupo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbProfesor.SuspendLayout()
        CType(Me.dgDatosUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbCurso.SuspendLayout()
        Me.gbGrupo.SuspendLayout()
        CType(Me.dgResul, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAsignar
        '
        Me.btnAsignar.Image = CType(resources.GetObject("btnAsignar.Image"), System.Drawing.Image)
        Me.btnAsignar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAsignar.Location = New System.Drawing.Point(451, 234)
        Me.btnAsignar.Name = "btnAsignar"
        Me.btnAsignar.Size = New System.Drawing.Size(100, 30)
        Me.btnAsignar.TabIndex = 2
        Me.btnAsignar.Text = "Asignar"
        Me.btnAsignar.UseVisualStyleBackColor = True
        '
        'gbProfesor
        '
        Me.gbProfesor.Controls.Add(Me.dgDatosUsuario)
        Me.gbProfesor.Location = New System.Drawing.Point(34, 127)
        Me.gbProfesor.Name = "gbProfesor"
        Me.gbProfesor.Size = New System.Drawing.Size(411, 279)
        Me.gbProfesor.TabIndex = 3
        Me.gbProfesor.TabStop = False
        Me.gbProfesor.Text = "Profesor"
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
        Me.dgDatosUsuario.Size = New System.Drawing.Size(395, 250)
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
        Me.Column4.Visible = False
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "Genero"
        Me.Column5.HeaderText = "Género"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.ToolTipText = "Género M=Masculino F=Femenino"
        Me.Column5.Visible = False
        '
        'Correo
        '
        Me.Correo.DataPropertyName = "Correo"
        Me.Correo.HeaderText = "Correo Electrónico"
        Me.Correo.Name = "Correo"
        Me.Correo.ReadOnly = True
        Me.Correo.ToolTipText = "Dirección del Correo Electrónico"
        Me.Correo.Visible = False
        '
        'FechaNacimiento
        '
        Me.FechaNacimiento.DataPropertyName = "FechaNacimiento"
        Me.FechaNacimiento.HeaderText = "Fecha Nacimiento"
        Me.FechaNacimiento.Name = "FechaNacimiento"
        Me.FechaNacimiento.ReadOnly = True
        Me.FechaNacimiento.ToolTipText = "Fecha Nacimiento"
        Me.FechaNacimiento.Visible = False
        '
        'Dirección
        '
        Me.Dirección.DataPropertyName = "Direccion"
        Me.Dirección.HeaderText = "Dirección"
        Me.Dirección.Name = "Dirección"
        Me.Dirección.ReadOnly = True
        Me.Dirección.ToolTipText = "Dirección de Habitación"
        Me.Dirección.Visible = False
        '
        'TelefonoFijo
        '
        Me.TelefonoFijo.DataPropertyName = "TelefonoFijo"
        Me.TelefonoFijo.HeaderText = "Tel.Fijo"
        Me.TelefonoFijo.Name = "TelefonoFijo"
        Me.TelefonoFijo.ReadOnly = True
        Me.TelefonoFijo.ToolTipText = "Teléfono Fijo"
        Me.TelefonoFijo.Visible = False
        '
        'TelefonoCelular
        '
        Me.TelefonoCelular.DataPropertyName = "TelefonoCelular"
        Me.TelefonoCelular.HeaderText = "Tel.Celular"
        Me.TelefonoCelular.Name = "TelefonoCelular"
        Me.TelefonoCelular.ReadOnly = True
        Me.TelefonoCelular.ToolTipText = "Teléfono Celular"
        Me.TelefonoCelular.Visible = False
        '
        'gbCurso
        '
        Me.gbCurso.Controls.Add(Me.cmbCurso)
        Me.gbCurso.Controls.Add(Me.btnBuscar)
        Me.gbCurso.Controls.Add(Me.lblCurso)
        Me.gbCurso.Location = New System.Drawing.Point(34, 33)
        Me.gbCurso.Name = "gbCurso"
        Me.gbCurso.Size = New System.Drawing.Size(785, 66)
        Me.gbCurso.TabIndex = 5
        Me.gbCurso.TabStop = False
        Me.gbCurso.Text = "Búsqueda"
        '
        'cmbCurso
        '
        Me.cmbCurso.DisplayMember = "Nombre"
        Me.cmbCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCurso.FormattingEnabled = True
        Me.cmbCurso.Location = New System.Drawing.Point(123, 25)
        Me.cmbCurso.Name = "cmbCurso"
        Me.cmbCurso.Size = New System.Drawing.Size(200, 21)
        Me.cmbCurso.TabIndex = 7
        '
        'btnBuscar
        '
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(417, 19)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(100, 30)
        Me.btnBuscar.TabIndex = 6
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'lblCurso
        '
        Me.lblCurso.AutoSize = True
        Me.lblCurso.Location = New System.Drawing.Point(68, 28)
        Me.lblCurso.Name = "lblCurso"
        Me.lblCurso.Size = New System.Drawing.Size(37, 13)
        Me.lblCurso.TabIndex = 0
        Me.lblCurso.Text = "Curso:"
        '
        'btnCerrar
        '
        Me.btnCerrar.Image = Global.capaPresentacion.My.Resources.Resources.icono_volver
        Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerrar.Location = New System.Drawing.Point(719, 433)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(100, 30)
        Me.btnCerrar.TabIndex = 6
        Me.btnCerrar.Text = "Atrás"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'gbGrupo
        '
        Me.gbGrupo.Controls.Add(Me.dgResul)
        Me.gbGrupo.Location = New System.Drawing.Point(557, 127)
        Me.gbGrupo.Name = "gbGrupo"
        Me.gbGrupo.Size = New System.Drawing.Size(262, 280)
        Me.gbGrupo.TabIndex = 4
        Me.gbGrupo.TabStop = False
        Me.gbGrupo.Text = "Grupo"
        '
        'dgResul
        '
        Me.dgResul.AllowUserToAddRows = False
        Me.dgResul.AllowUserToDeleteRows = False
        Me.dgResul.AllowUserToOrderColumns = True
        Me.dgResul.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgResul.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.idCur, Me.cdGrupo, Me.nombre_grupo})
        Me.dgResul.Location = New System.Drawing.Point(9, 24)
        Me.dgResul.MultiSelect = False
        Me.dgResul.Name = "dgResul"
        Me.dgResul.ReadOnly = True
        Me.dgResul.RowTemplate.Height = 24
        Me.dgResul.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgResul.Size = New System.Drawing.Size(245, 236)
        Me.dgResul.TabIndex = 1
        '
        'id
        '
        Me.id.DataPropertyName = "IdGrupo"
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        '
        'idCur
        '
        Me.idCur.DataPropertyName = "IdCurso"
        Me.idCur.HeaderText = "idCurso"
        Me.idCur.Name = "idCur"
        Me.idCur.ReadOnly = True
        Me.idCur.Visible = False
        '
        'cdGrupo
        '
        Me.cdGrupo.DataPropertyName = "Codigo"
        Me.cdGrupo.HeaderText = "Codigo Grupo"
        Me.cdGrupo.Name = "cdGrupo"
        Me.cdGrupo.ReadOnly = True
        '
        'nombre_grupo
        '
        Me.nombre_grupo.DataPropertyName = "Nombre"
        Me.nombre_grupo.HeaderText = "Nombre Grupo"
        Me.nombre_grupo.Name = "nombre_grupo"
        Me.nombre_grupo.ReadOnly = True
        '
        'frmAsignarProfesor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 493)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.gbGrupo)
        Me.Controls.Add(Me.btnAsignar)
        Me.Controls.Add(Me.gbProfesor)
        Me.Controls.Add(Me.gbCurso)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAsignarProfesor"
        Me.Text = "Asignar Profesor a Grupo"
        Me.gbProfesor.ResumeLayout(False)
        CType(Me.dgDatosUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbCurso.ResumeLayout(False)
        Me.gbCurso.PerformLayout()
        Me.gbGrupo.ResumeLayout(False)
        CType(Me.dgResul, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnAsignar As System.Windows.Forms.Button
    Friend WithEvents gbProfesor As System.Windows.Forms.GroupBox
    Friend WithEvents gbCurso As System.Windows.Forms.GroupBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents lblCurso As System.Windows.Forms.Label
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents gbGrupo As System.Windows.Forms.GroupBox
    Friend WithEvents dgDatosUsuario As System.Windows.Forms.DataGridView
    Friend WithEvents cmbCurso As System.Windows.Forms.ComboBox
    Friend WithEvents dgResul As System.Windows.Forms.DataGridView
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idCur As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cdGrupo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre_grupo As System.Windows.Forms.DataGridViewTextBoxColumn
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