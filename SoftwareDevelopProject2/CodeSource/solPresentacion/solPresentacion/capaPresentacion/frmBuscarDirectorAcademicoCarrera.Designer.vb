<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarDirectorAcademicoCarrera
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuscarDirectorAcademicoCarrera))
        Me.gbResultado = New System.Windows.Forms.GroupBox()
        Me.gbOpciones = New System.Windows.Forms.GroupBox()
        Me.btnExportar = New System.Windows.Forms.Button()
        Me.btnBitacora = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.dgDirectoresAcademicos = New System.Windows.Forms.DataGridView()
        Me.IdUsuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cedula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Carnet = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apellido1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apellido2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Correo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoFijo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Celular = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Genero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Contrasenna = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaNacimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblCarrera = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.gbBusqueda = New System.Windows.Forms.GroupBox()
        Me.cmbCarrera = New System.Windows.Forms.ComboBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.gbResultado.SuspendLayout()
        Me.gbOpciones.SuspendLayout()
        CType(Me.dgDirectoresAcademicos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbBusqueda.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbResultado
        '
        Me.gbResultado.Controls.Add(Me.gbOpciones)
        Me.gbResultado.Controls.Add(Me.dgDirectoresAcademicos)
        Me.gbResultado.Location = New System.Drawing.Point(34, 192)
        Me.gbResultado.Margin = New System.Windows.Forms.Padding(2)
        Me.gbResultado.Name = "gbResultado"
        Me.gbResultado.Padding = New System.Windows.Forms.Padding(2)
        Me.gbResultado.Size = New System.Drawing.Size(777, 248)
        Me.gbResultado.TabIndex = 6
        Me.gbResultado.TabStop = False
        Me.gbResultado.Text = "Resultado"
        '
        'gbOpciones
        '
        Me.gbOpciones.Controls.Add(Me.btnExportar)
        Me.gbOpciones.Controls.Add(Me.btnBitacora)
        Me.gbOpciones.Controls.Add(Me.btnEliminar)
        Me.gbOpciones.Location = New System.Drawing.Point(623, 24)
        Me.gbOpciones.Name = "gbOpciones"
        Me.gbOpciones.Size = New System.Drawing.Size(134, 132)
        Me.gbOpciones.TabIndex = 3
        Me.gbOpciones.TabStop = False
        Me.gbOpciones.Text = "Opciones:"
        '
        'btnExportar
        '
        Me.btnExportar.Image = CType(resources.GetObject("btnExportar.Image"), System.Drawing.Image)
        Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExportar.Location = New System.Drawing.Point(16, 86)
        Me.btnExportar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(100, 30)
        Me.btnExportar.TabIndex = 8
        Me.btnExportar.Text = "Exportar"
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'btnBitacora
        '
        Me.btnBitacora.Image = CType(resources.GetObject("btnBitacora.Image"), System.Drawing.Image)
        Me.btnBitacora.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBitacora.Location = New System.Drawing.Point(16, 18)
        Me.btnBitacora.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBitacora.Name = "btnBitacora"
        Me.btnBitacora.Size = New System.Drawing.Size(100, 30)
        Me.btnBitacora.TabIndex = 4
        Me.btnBitacora.Text = "Bitácora"
        Me.btnBitacora.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.Location = New System.Drawing.Point(16, 52)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(100, 30)
        Me.btnEliminar.TabIndex = 2
        Me.btnEliminar.Text = "Desasignar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'dgDirectoresAcademicos
        '
        Me.dgDirectoresAcademicos.AllowUserToAddRows = False
        Me.dgDirectoresAcademicos.AllowUserToDeleteRows = False
        Me.dgDirectoresAcademicos.AllowUserToOrderColumns = True
        Me.dgDirectoresAcademicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDirectoresAcademicos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdUsuario, Me.cedula, Me.Carnet, Me.nombre, Me.apellido1, Me.apellido2, Me.Correo, Me.Direccion, Me.TelefonoFijo, Me.Celular, Me.Genero, Me.Contrasenna, Me.FechaNacimiento})
        Me.dgDirectoresAcademicos.Location = New System.Drawing.Point(11, 24)
        Me.dgDirectoresAcademicos.Margin = New System.Windows.Forms.Padding(2)
        Me.dgDirectoresAcademicos.MultiSelect = False
        Me.dgDirectoresAcademicos.Name = "dgDirectoresAcademicos"
        Me.dgDirectoresAcademicos.ReadOnly = True
        Me.dgDirectoresAcademicos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgDirectoresAcademicos.Size = New System.Drawing.Size(592, 192)
        Me.dgDirectoresAcademicos.TabIndex = 0
        '
        'IdUsuario
        '
        Me.IdUsuario.DataPropertyName = "IdUsuario"
        Me.IdUsuario.HeaderText = "id"
        Me.IdUsuario.Name = "IdUsuario"
        Me.IdUsuario.ReadOnly = True
        Me.IdUsuario.Visible = False
        '
        'cedula
        '
        Me.cedula.DataPropertyName = "Cedula"
        Me.cedula.HeaderText = "Cédula"
        Me.cedula.Name = "cedula"
        Me.cedula.ReadOnly = True
        Me.cedula.Width = 60
        '
        'Carnet
        '
        Me.Carnet.DataPropertyName = "Carnet"
        Me.Carnet.HeaderText = "Carnet"
        Me.Carnet.Name = "Carnet"
        Me.Carnet.ReadOnly = True
        Me.Carnet.Visible = False
        '
        'nombre
        '
        Me.nombre.DataPropertyName = "Nombre"
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Width = 80
        '
        'apellido1
        '
        Me.apellido1.DataPropertyName = "Apellido1"
        Me.apellido1.HeaderText = "Primer Apellido"
        Me.apellido1.Name = "apellido1"
        Me.apellido1.ReadOnly = True
        Me.apellido1.Width = 130
        '
        'apellido2
        '
        Me.apellido2.DataPropertyName = "Apellido2"
        Me.apellido2.HeaderText = "Segundo Apellido"
        Me.apellido2.Name = "apellido2"
        Me.apellido2.ReadOnly = True
        Me.apellido2.Width = 130
        '
        'Correo
        '
        Me.Correo.DataPropertyName = "Correo"
        Me.Correo.HeaderText = "Correo Electrónico"
        Me.Correo.Name = "Correo"
        Me.Correo.ReadOnly = True
        Me.Correo.Width = 120
        '
        'Direccion
        '
        Me.Direccion.DataPropertyName = "Direccion"
        Me.Direccion.HeaderText = "Dirección"
        Me.Direccion.Name = "Direccion"
        Me.Direccion.ReadOnly = True
        '
        'TelefonoFijo
        '
        Me.TelefonoFijo.DataPropertyName = "TelefonoFijo"
        Me.TelefonoFijo.HeaderText = "Teléfono Fijo"
        Me.TelefonoFijo.Name = "TelefonoFijo"
        Me.TelefonoFijo.ReadOnly = True
        '
        'Celular
        '
        Me.Celular.DataPropertyName = "TelefonoCelular"
        Me.Celular.HeaderText = "Celular"
        Me.Celular.Name = "Celular"
        Me.Celular.ReadOnly = True
        '
        'Genero
        '
        Me.Genero.DataPropertyName = "Genero"
        Me.Genero.HeaderText = "Genero"
        Me.Genero.Name = "Genero"
        Me.Genero.ReadOnly = True
        '
        'Contrasenna
        '
        Me.Contrasenna.DataPropertyName = "Contrasenna"
        Me.Contrasenna.HeaderText = "Contrasenna"
        Me.Contrasenna.Name = "Contrasenna"
        Me.Contrasenna.ReadOnly = True
        Me.Contrasenna.Visible = False
        '
        'FechaNacimiento
        '
        Me.FechaNacimiento.DataPropertyName = "FechaNacimiento"
        Me.FechaNacimiento.HeaderText = "FechaNacimiento"
        Me.FechaNacimiento.Name = "FechaNacimiento"
        Me.FechaNacimiento.ReadOnly = True
        Me.FechaNacimiento.Visible = False
        '
        'lblCarrera
        '
        Me.lblCarrera.AutoSize = True
        Me.lblCarrera.Location = New System.Drawing.Point(32, 24)
        Me.lblCarrera.Name = "lblCarrera"
        Me.lblCarrera.Size = New System.Drawing.Size(44, 13)
        Me.lblCarrera.TabIndex = 19
        Me.lblCarrera.Text = "Carrera:"
        '
        'btnBuscar
        '
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(639, 17)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(100, 30)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'gbBusqueda
        '
        Me.gbBusqueda.Controls.Add(Me.cmbCarrera)
        Me.gbBusqueda.Controls.Add(Me.lblCarrera)
        Me.gbBusqueda.Controls.Add(Me.btnBuscar)
        Me.gbBusqueda.Location = New System.Drawing.Point(34, 29)
        Me.gbBusqueda.Margin = New System.Windows.Forms.Padding(2)
        Me.gbBusqueda.Name = "gbBusqueda"
        Me.gbBusqueda.Padding = New System.Windows.Forms.Padding(2)
        Me.gbBusqueda.Size = New System.Drawing.Size(767, 56)
        Me.gbBusqueda.TabIndex = 5
        Me.gbBusqueda.TabStop = False
        Me.gbBusqueda.Text = "Búsqueda"
        '
        'cmbCarrera
        '
        Me.cmbCarrera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCarrera.FormattingEnabled = True
        Me.cmbCarrera.Location = New System.Drawing.Point(116, 21)
        Me.cmbCarrera.Name = "cmbCarrera"
        Me.cmbCarrera.Size = New System.Drawing.Size(209, 21)
        Me.cmbCarrera.TabIndex = 20
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = Global.capaPresentacion.My.Resources.Resources.icono_volver
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(673, 444)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 30)
        Me.btnCancelar.TabIndex = 7
        Me.btnCancelar.Text = "Atrás"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'frmBuscarDirectorAcademicoCarrera
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(848, 491)
        Me.ControlBox = False
        Me.Controls.Add(Me.gbResultado)
        Me.Controls.Add(Me.gbBusqueda)
        Me.Controls.Add(Me.btnCancelar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmBuscarDirectorAcademicoCarrera"
        Me.Text = "Buscar Director Académico por Carrera"
        Me.gbResultado.ResumeLayout(False)
        Me.gbOpciones.ResumeLayout(False)
        CType(Me.dgDirectoresAcademicos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbBusqueda.ResumeLayout(False)
        Me.gbBusqueda.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbResultado As System.Windows.Forms.GroupBox
    Friend WithEvents gbOpciones As System.Windows.Forms.GroupBox
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents dgDirectoresAcademicos As System.Windows.Forms.DataGridView
    Friend WithEvents lblCarrera As System.Windows.Forms.Label
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents gbBusqueda As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents cmbCarrera As System.Windows.Forms.ComboBox
    Friend WithEvents btnBitacora As System.Windows.Forms.Button
    Friend WithEvents btnExportar As System.Windows.Forms.Button
    Friend WithEvents IdUsuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cedula As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Carnet As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents apellido1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents apellido2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Correo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Direccion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelefonoFijo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Celular As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Genero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Contrasenna As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaNacimiento As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
