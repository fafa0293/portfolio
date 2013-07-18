<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPadre
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPadre))
        Me.panelAbajoMaster = New System.Windows.Forms.Panel()
        Me.panelCompannia = New System.Windows.Forms.Panel()
        Me.lblEmpresa = New System.Windows.Forms.Label()
        Me.lblModeForm = New System.Windows.Forms.Label()
        Me.panelArribaMaster = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.panelAbajoMaster.SuspendLayout()
        Me.panelCompannia.SuspendLayout()
        Me.panelArribaMaster.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelAbajoMaster
        '
        Me.panelAbajoMaster.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelAbajoMaster.Controls.Add(Me.panelCompannia)
        resources.ApplyResources(Me.panelAbajoMaster, "panelAbajoMaster")
        Me.panelAbajoMaster.Name = "panelAbajoMaster"
        '
        'panelCompannia
        '
        Me.panelCompannia.Controls.Add(Me.lblEmpresa)
        resources.ApplyResources(Me.panelCompannia, "panelCompannia")
        Me.panelCompannia.Name = "panelCompannia"
        '
        'lblEmpresa
        '
        resources.ApplyResources(Me.lblEmpresa, "lblEmpresa")
        Me.lblEmpresa.Name = "lblEmpresa"
        '
        'lblModeForm
        '
        resources.ApplyResources(Me.lblModeForm, "lblModeForm")
        Me.lblModeForm.Name = "lblModeForm"
        '
        'panelArribaMaster
        '
        Me.panelArribaMaster.BackColor = System.Drawing.Color.White
        Me.panelArribaMaster.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelArribaMaster.Controls.Add(Me.PictureBox1)
        Me.panelArribaMaster.Controls.Add(Me.lblDescripcion)
        Me.panelArribaMaster.Controls.Add(Me.lblTitulo)
        resources.ApplyResources(Me.panelArribaMaster, "panelArribaMaster")
        Me.panelArribaMaster.Name = "panelArribaMaster"
        '
        'PictureBox1
        '
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        '
        'lblDescripcion
        '
        resources.ApplyResources(Me.lblDescripcion, "lblDescripcion")
        Me.lblDescripcion.Name = "lblDescripcion"
        '
        'lblTitulo
        '
        resources.ApplyResources(Me.lblTitulo, "lblTitulo")
        Me.lblTitulo.ForeColor = System.Drawing.Color.Blue
        Me.lblTitulo.Name = "lblTitulo"
        '
        'frmPadre
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.panelArribaMaster)
        Me.Controls.Add(Me.panelAbajoMaster)
        Me.Controls.Add(Me.lblModeForm)
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.Name = "frmPadre"
        Me.panelAbajoMaster.ResumeLayout(False)
        Me.panelCompannia.ResumeLayout(False)
        Me.panelCompannia.PerformLayout()
        Me.panelArribaMaster.ResumeLayout(False)
        Me.panelArribaMaster.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents lblModeForm As System.Windows.Forms.Label
    Private WithEvents panelAbajoMaster As System.Windows.Forms.Panel
    Private WithEvents panelArribaMaster As System.Windows.Forms.Panel
    Friend WithEvents lblEmpresa As System.Windows.Forms.Label
    Private WithEvents panelCompannia As System.Windows.Forms.Panel
    Private WithEvents lblTitulo As System.Windows.Forms.Label
    Private WithEvents lblDescripcion As System.Windows.Forms.Label
    Private WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
