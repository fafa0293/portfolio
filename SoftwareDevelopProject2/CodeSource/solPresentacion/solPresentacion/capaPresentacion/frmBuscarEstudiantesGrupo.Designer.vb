<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarEstudiantesGrupo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuscarEstudiantesGrupo))
        Me.gbBusqueda = New System.Windows.Forms.GroupBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.cmbGrupo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbResul = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnExportar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.dgResul = New System.Windows.Forms.DataGridView()
        Me.idUsuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apellido2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cédula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Carnet = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Genero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Correo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefonoF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefonoC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cont = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.gbBusqueda.SuspendLayout()
        Me.gbResul.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgResul, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbBusqueda
        '
        Me.gbBusqueda.Controls.Add(Me.btnBuscar)
        Me.gbBusqueda.Controls.Add(Me.cmbGrupo)
        Me.gbBusqueda.Controls.Add(Me.Label1)
        Me.gbBusqueda.Location = New System.Drawing.Point(34, 28)
        Me.gbBusqueda.Name = "gbBusqueda"
        Me.gbBusqueda.Size = New System.Drawing.Size(767, 73)
        Me.gbBusqueda.TabIndex = 0
        Me.gbBusqueda.TabStop = False
        Me.gbBusqueda.Text = "Búsqueda"
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(637, 25)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(100, 30)
        Me.btnBuscar.TabIndex = 3
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'cmbGrupo
        '
        Me.cmbGrupo.DisplayMember = "Nombre"
        Me.cmbGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGrupo.FormattingEnabled = True
        Me.cmbGrupo.Location = New System.Drawing.Point(106, 31)
        Me.cmbGrupo.Name = "cmbGrupo"
        Me.cmbGrupo.Size = New System.Drawing.Size(193, 21)
        Me.cmbGrupo.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Grupo:"
        '
        'gbResul
        '
        Me.gbResul.Controls.Add(Me.GroupBox3)
        Me.gbResul.Controls.Add(Me.dgResul)
        Me.gbResul.Location = New System.Drawing.Point(34, 132)
        Me.gbResul.Name = "gbResul"
        Me.gbResul.Size = New System.Drawing.Size(767, 248)
        Me.gbResul.TabIndex = 1
        Me.gbResul.TabStop = False
        Me.gbResul.Text = "Resultado"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnExportar)
        Me.GroupBox3.Controls.Add(Me.btnEliminar)
        Me.GroupBox3.Location = New System.Drawing.Point(623, 24)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(126, 102)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Opciones"
        '
        'btnExportar
        '
        Me.btnExportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnExportar.Image = CType(resources.GetObject("btnExportar.Image"), System.Drawing.Image)
        Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExportar.Location = New System.Drawing.Point(14, 19)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(100, 30)
        Me.btnExportar.TabIndex = 3
        Me.btnExportar.Text = "Exportar"
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.Location = New System.Drawing.Point(14, 55)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(100, 30)
        Me.btnEliminar.TabIndex = 0
        Me.btnEliminar.Text = "Desasignar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'dgResul
        '
        Me.dgResul.AllowUserToAddRows = False
        Me.dgResul.AllowUserToDeleteRows = False
        Me.dgResul.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgResul.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idUsuario, Me.Nombre, Me.Apellido, Me.apellido2, Me.Cédula, Me.Carnet, Me.Genero, Me.Correo, Me.fechaN, Me.direccion, Me.telefonoF, Me.telefonoC, Me.cont})
        Me.dgResul.Location = New System.Drawing.Point(20, 24)
        Me.dgResul.MultiSelect = False
        Me.dgResul.Name = "dgResul"
        Me.dgResul.ReadOnly = True
        Me.dgResul.RowTemplate.Height = 24
        Me.dgResul.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgResul.Size = New System.Drawing.Size(581, 205)
        Me.dgResul.TabIndex = 0
        '
        'idUsuario
        '
        Me.idUsuario.DataPropertyName = "IdUsuario"
        Me.idUsuario.HeaderText = "IdUsuario"
        Me.idUsuario.Name = "idUsuario"
        Me.idUsuario.ReadOnly = True
        Me.idUsuario.Visible = False
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "Nombre"
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'Apellido
        '
        Me.Apellido.DataPropertyName = "Apellido1"
        Me.Apellido.HeaderText = "Primer Apellido"
        Me.Apellido.Name = "Apellido"
        Me.Apellido.ReadOnly = True
        Me.Apellido.Width = 120
        '
        'apellido2
        '
        Me.apellido2.DataPropertyName = "Apellido2"
        Me.apellido2.HeaderText = "Segundo Apellido"
        Me.apellido2.Name = "apellido2"
        Me.apellido2.ReadOnly = True
        Me.apellido2.Width = 120
        '
        'Cédula
        '
        Me.Cédula.DataPropertyName = "Cedula"
        Me.Cédula.HeaderText = "Cédula"
        Me.Cédula.Name = "Cédula"
        Me.Cédula.ReadOnly = True
        '
        'Carnet
        '
        Me.Carnet.DataPropertyName = "Carnet"
        Me.Carnet.HeaderText = "Carnet"
        Me.Carnet.Name = "Carnet"
        Me.Carnet.ReadOnly = True
        '
        'Genero
        '
        Me.Genero.DataPropertyName = "Genero"
        Me.Genero.HeaderText = "Genero"
        Me.Genero.Name = "Genero"
        Me.Genero.ReadOnly = True
        '
        'Correo
        '
        Me.Correo.DataPropertyName = "Correo"
        Me.Correo.HeaderText = "Correo"
        Me.Correo.Name = "Correo"
        Me.Correo.ReadOnly = True
        '
        'fechaN
        '
        Me.fechaN.DataPropertyName = "FechaNacimiento"
        Me.fechaN.HeaderText = "Fecha de Nacimiento"
        Me.fechaN.Name = "fechaN"
        Me.fechaN.ReadOnly = True
        Me.fechaN.Width = 150
        '
        'direccion
        '
        Me.direccion.DataPropertyName = "Direccion"
        Me.direccion.HeaderText = "Dirección"
        Me.direccion.Name = "direccion"
        Me.direccion.ReadOnly = True
        '
        'telefonoF
        '
        Me.telefonoF.DataPropertyName = "TelefonoFijo"
        Me.telefonoF.HeaderText = "Teléfono Fijo"
        Me.telefonoF.Name = "telefonoF"
        Me.telefonoF.ReadOnly = True
        Me.telefonoF.Width = 120
        '
        'telefonoC
        '
        Me.telefonoC.DataPropertyName = "TelefonoCelular"
        Me.telefonoC.HeaderText = "Teléfono Celular"
        Me.telefonoC.Name = "telefonoC"
        Me.telefonoC.ReadOnly = True
        Me.telefonoC.Width = 120
        '
        'cont
        '
        Me.cont.DataPropertyName = "Contrasenna"
        Me.cont.HeaderText = "cont"
        Me.cont.Name = "cont"
        Me.cont.ReadOnly = True
        Me.cont.Visible = False
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnCancelar.Image = Global.capaPresentacion.My.Resources.Resources.icono_volver
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(671, 386)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 30)
        Me.btnCancelar.TabIndex = 2
        Me.btnCancelar.Text = "Atrás"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'frmBuscarEstudiantesGrupo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(838, 441)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.gbResul)
        Me.Controls.Add(Me.gbBusqueda)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmBuscarEstudiantesGrupo"
        Me.Text = "Buscar Estudiantes de un Grupo"
        Me.gbBusqueda.ResumeLayout(False)
        Me.gbBusqueda.PerformLayout()
        Me.gbResul.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgResul, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbBusqueda As System.Windows.Forms.GroupBox
    Friend WithEvents cmbGrupo As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gbResul As System.Windows.Forms.GroupBox
    Friend WithEvents dgResul As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Private WithEvents btnBuscar As System.Windows.Forms.Button
    Private WithEvents btnCancelar As System.Windows.Forms.Button
    Private WithEvents btnEliminar As System.Windows.Forms.Button
    Private WithEvents btnExportar As System.Windows.Forms.Button
    Friend WithEvents idUsuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Apellido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents apellido2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cédula As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Carnet As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Genero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Correo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fechaN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents direccion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents telefonoF As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents telefonoC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cont As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
