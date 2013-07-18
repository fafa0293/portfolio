<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
    Inherits frmPadre

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
        Me.components = New System.ComponentModel.Container()
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Registrar Usuario")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Buscar Usuario")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Agregar Usuario por Batch")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Usuario", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3})
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Agregar Carrera")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Buscar Carrera")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Buscar Director Académico por Carrera")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Asignar Cursos a Carrera")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Asignar Director Académico a Carrera")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Carrera", New System.Windows.Forms.TreeNode() {TreeNode5, TreeNode6, TreeNode7, TreeNode8, TreeNode9})
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Agregar Curso")
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Buscar Curso")
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Buscar Curso por Carrera")
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Agregar Curso por Batch")
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Curso", New System.Windows.Forms.TreeNode() {TreeNode11, TreeNode12, TreeNode13, TreeNode14})
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Registrar Grupo")
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Buscar Grupo")
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Buscar Grupo de un Curso")
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Buscar Estudiantes por Grupo")
        Dim TreeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Buscar Profesor por Grupo")
        Dim TreeNode21 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Asignar Estudiante a Grupo")
        Dim TreeNode22 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Asignar Profesor a Grupo")
        Dim TreeNode23 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Listar Foros")
        Dim TreeNode24 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Grupo", New System.Windows.Forms.TreeNode() {TreeNode16, TreeNode17, TreeNode18, TreeNode19, TreeNode20, TreeNode21, TreeNode22, TreeNode23})
        Dim TreeNode25 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Buscar Tema")
        Dim TreeNode26 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Buscar Estudiantes por Tema")
        Dim TreeNode27 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Listar Aportes")
        Dim TreeNode28 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Registrar Tema")
        Dim TreeNode29 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tema", New System.Windows.Forms.TreeNode() {TreeNode25, TreeNode26, TreeNode27, TreeNode28})
        Dim TreeNode30 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Listar Permisos")
        Dim TreeNode31 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Permiso", New System.Windows.Forms.TreeNode() {TreeNode30})
        Dim TreeNode32 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Agregar Rol")
        Dim TreeNode33 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Listar Rol")
        Dim TreeNode34 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Asignar Rol a Usuario")
        Dim TreeNode35 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Rol", New System.Windows.Forms.TreeNode() {TreeNode32, TreeNode33, TreeNode34})
        Dim TreeNode36 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Asignar Estudiante a Grupo")
        Dim TreeNode37 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Asignar Profesor a Grupo")
        Dim TreeNode38 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Asignar Estudiante a Tema")
        Dim TreeNode39 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Asignar Curso a Carrera")
        Dim TreeNode40 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Asignar Director Académico a Carrera")
        Dim TreeNode41 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Asignar Rol a Usuario")
        Dim TreeNode42 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Asignar", New System.Windows.Forms.TreeNode() {TreeNode36, TreeNode37, TreeNode38, TreeNode39, TreeNode40, TreeNode41})
        Dim TreeNode43 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("No puedo registrar")
        Dim TreeNode44 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Error al registrar")
        Dim TreeNode45 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Ayuda", New System.Windows.Forms.TreeNode() {TreeNode43, TreeNode44})
        Dim TreeNode46 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cerrar Sesión")
        Dim TreeNode47 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cerrar Sesión", New System.Windows.Forms.TreeNode() {TreeNode46})
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TreeViewPrincipal = New System.Windows.Forms.TreeView()
        Me.ExtendedTabControl1 = New System.Windows.Forms.TabControl()
        Me.cmenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mclose = New System.Windows.Forms.ToolStripMenuItem()
        Me.mcloseallbutthis = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.cmenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 80)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TreeViewPrincipal)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ExtendedTabControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1125, 541)
        Me.SplitContainer1.SplitterDistance = 266
        Me.SplitContainer1.TabIndex = 1
        '
        'TreeViewPrincipal
        '
        Me.TreeViewPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeViewPrincipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeViewPrincipal.HideSelection = False
        Me.TreeViewPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.TreeViewPrincipal.Name = "TreeViewPrincipal"
        TreeNode1.Name = "NodoAgregarUsuario"
        TreeNode1.Text = "Registrar Usuario"
        TreeNode2.Name = "NodoBusquedaUsuario"
        TreeNode2.Text = "Buscar Usuario"
        TreeNode3.Name = "NodoAgregarUsuarioBatch"
        TreeNode3.Text = "Agregar Usuario por Batch"
        TreeNode4.Name = "NodoUsuario"
        TreeNode4.Text = "Usuario"
        TreeNode5.Name = "NodoAgregarCarrera"
        TreeNode5.Text = "Agregar Carrera"
        TreeNode6.Name = "NodoBuscarCarrera"
        TreeNode6.Text = "Buscar Carrera"
        TreeNode7.Name = "NodoBuscarDirectorAcademico"
        TreeNode7.Text = "Buscar Director Académico por Carrera"
        TreeNode8.Name = "Nodo3"
        TreeNode8.Text = "Asignar Cursos a Carrera"
        TreeNode9.Name = "Nodo4"
        TreeNode9.Text = "Asignar Director Académico a Carrera"
        TreeNode10.Name = "NodoCarrera"
        TreeNode10.Text = "Carrera"
        TreeNode10.ToolTipText = "Mostrar las opciones de las carreras"
        TreeNode11.Name = "NodoAgregarCurso"
        TreeNode11.Text = "Agregar Curso"
        TreeNode12.Name = "NodoBuscarCurso"
        TreeNode12.Text = "Buscar Curso"
        TreeNode13.Name = "NodoBuscarCursoPorCarrera"
        TreeNode13.Text = "Buscar Curso por Carrera"
        TreeNode14.Name = "NodoCursoPorBatch"
        TreeNode14.Text = "Agregar Curso por Batch"
        TreeNode15.Name = "NodoCurso"
        TreeNode15.Text = "Curso"
        TreeNode16.Name = "NodoRegistrarGrupo"
        TreeNode16.Text = "Registrar Grupo"
        TreeNode17.Name = "NodoBuscarGrupo"
        TreeNode17.Text = "Buscar Grupo"
        TreeNode18.Name = "NodoBuscarGrupoCurso"
        TreeNode18.Text = "Buscar Grupo de un Curso"
        TreeNode19.Name = "NodoBuscarEstudiantesGrupo"
        TreeNode19.Text = "Buscar Estudiantes por Grupo"
        TreeNode20.Name = "NodoBuscarProfesor"
        TreeNode20.Text = "Buscar Profesor por Grupo"
        TreeNode21.Name = "Nodo0"
        TreeNode21.Text = "Asignar Estudiante a Grupo"
        TreeNode22.Name = "Nodo1"
        TreeNode22.Text = "Asignar Profesor a Grupo"
        TreeNode23.Name = "NodoListarForos"
        TreeNode23.Text = "Listar Foros"
        TreeNode24.Name = "NodoGrupo"
        TreeNode24.Text = "Grupo"
        TreeNode25.Name = "NodoBuscarTema"
        TreeNode25.Text = "Buscar Tema"
        TreeNode26.Name = "NodoBuscarEstudiantesTema"
        TreeNode26.Text = "Buscar Estudiantes por Tema"
        TreeNode27.Name = "NodoListarAportes"
        TreeNode27.Text = "Listar Aportes"
        TreeNode28.Name = "NodoRegistrarTema"
        TreeNode28.Text = "Registrar Tema"
        TreeNode29.Name = "NodoTema"
        TreeNode29.Text = "Tema"
        TreeNode30.Name = "NodoListarPermisos"
        TreeNode30.Text = "Listar Permisos"
        TreeNode31.Name = "NodoPermisos"
        TreeNode31.Text = "Permiso"
        TreeNode32.Name = "NodoRegistrarRol"
        TreeNode32.Text = "Agregar Rol"
        TreeNode33.Name = "NodoListarRol"
        TreeNode33.Text = "Listar Rol"
        TreeNode34.Name = "Nodo5"
        TreeNode34.Text = "Asignar Rol a Usuario"
        TreeNode35.Name = "NodoRol"
        TreeNode35.Text = "Rol"
        TreeNode36.Name = "NodoAsignarEstudianteGrupo"
        TreeNode36.Text = "Asignar Estudiante a Grupo"
        TreeNode37.Name = "Nodo4"
        TreeNode37.Text = "Asignar Profesor a Grupo"
        TreeNode38.Name = "Nodo5"
        TreeNode38.Text = "Asignar Estudiante a Tema"
        TreeNode39.Name = "Nodo6"
        TreeNode39.Text = "Asignar Curso a Carrera"
        TreeNode40.Name = "Nodo7"
        TreeNode40.Text = "Asignar Director Académico a Carrera"
        TreeNode41.Name = "Nodo9"
        TreeNode41.Text = "Asignar Rol a Usuario"
        TreeNode42.Name = "NodoAsignar"
        TreeNode42.Text = "Asignar"
        TreeNode43.Name = "Nodo1"
        TreeNode43.Text = "No puedo registrar"
        TreeNode44.Name = "Nodo0"
        TreeNode44.Text = "Error al registrar"
        TreeNode45.Name = "NodoAyuda"
        TreeNode45.Text = "Ayuda"
        TreeNode46.Name = "Nodo3"
        TreeNode46.Text = "Cerrar Sesión"
        TreeNode47.Name = "Nodo2"
        TreeNode47.Text = "Cerrar Sesión"
        Me.TreeViewPrincipal.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode4, TreeNode10, TreeNode15, TreeNode24, TreeNode29, TreeNode31, TreeNode35, TreeNode42, TreeNode45, TreeNode47})
        Me.TreeViewPrincipal.Size = New System.Drawing.Size(266, 541)
        Me.TreeViewPrincipal.TabIndex = 999
        Me.TreeViewPrincipal.Tag = "999"
        '
        'ExtendedTabControl1
        '
        Me.ExtendedTabControl1.Location = New System.Drawing.Point(3, 0)
        Me.ExtendedTabControl1.Name = "ExtendedTabControl1"
        Me.ExtendedTabControl1.SelectedIndex = 0
        Me.ExtendedTabControl1.Size = New System.Drawing.Size(844, 530)
        Me.ExtendedTabControl1.TabIndex = 0
        '
        'cmenu
        '
        Me.cmenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mclose, Me.mcloseallbutthis})
        Me.cmenu.Name = "cmenu"
        Me.cmenu.Size = New System.Drawing.Size(214, 48)
        '
        'mclose
        '
        Me.mclose.Name = "mclose"
        Me.mclose.Size = New System.Drawing.Size(213, 22)
        Me.mclose.Text = "Cerrar"
        '
        'mcloseallbutthis
        '
        Me.mcloseallbutthis.Name = "mcloseallbutthis"
        Me.mcloseallbutthis.Size = New System.Drawing.Size(213, 22)
        Me.mcloseallbutthis.Text = "Cerrar todos menos actual"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1125, 645)
        Me.Controls.Add(Me.SplitContainer1)
        Me.IsMdiContainer = True
        Me.MaximumSize = New System.Drawing.Size(1133, 672)
        Me.MinimumSize = New System.Drawing.Size(1133, 672)
        Me.Name = "frmPrincipal"
        Me.Text = "Pantalla Principal"
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.cmenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents cmenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mclose As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mcloseallbutthis As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExtendedTabControl1 As TabControl
    Friend WithEvents TreeViewPrincipal As System.Windows.Forms.TreeView

End Class
