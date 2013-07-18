Imports solLogica.Gestor
Imports System.Text.RegularExpressions
Public Class frmModificarTema
    Dim isDataSaved As Boolean = False
    Private _idTema As Integer
    Private _frmBuscarTema As frmBuscarTema


    Public Sub New(ByVal idTema As Integer, ByVal titulo As String, ByVal aportesMin As Integer, ByVal aportesMax As Integer, ByVal fechaInicio As Date, ByVal fechaFin As Date, ByVal frmBuscarTema As frmBuscarTema)
        ' TODO: Complete member initialization 
        InitializeComponent()
        _idTema = idTema
        txtTitulo.Text = titulo
        txtAportesMax.Text = aportesMax
        dtpFechaInicio.Text = fechaInicio
        dtpFechaFin.Text = fechaFin
        _frmBuscarTema = frmBuscarTema
    End Sub

    

    Private Sub btmModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btmModificar.Click
        If validar() Then
            Dim button As DialogResult = MessageBox.Show("¿Desea realizar la modificación del tema?", "Modificar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If button = DialogResult.Yes Then
                isDataSaved = True
                GestorTema.modificarTema(_idTema, txtTitulo.Text, txtAportesMax.Text, 0, dtpFechaInicio.Value, dtpFechaFin.Value)
                MessageBox.Show("Se ha modificado el tema con éxito.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
                _frmBuscarTema.btnBuscar.PerformClick()
                Me.Close()
            End If
        End If
    End Sub

    ''' <summary>
    ''' Metodo para validar que los campos del formulario no esten vacios 
    ''' y cumplan con el formato correcto.
    ''' </summary>
    ''' <returns>Valor booleano.</returns>
    ''' <remarks>Autor: Dylhann Obando</remarks>
    Private Function validar()
        ''Dim reN As New Regex("[0-9]")
        If txtTitulo.Text.Trim.Equals("") Then
            MessageBox.Show("Campo requerido. Ingrese el título.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            txtTitulo.Focus()
            Return False
        ElseIf dtpFechaInicio.Value.Date > dtpFechaFin.Value.Date Then
            MessageBox.Show("La fecha de inicio debe menor a la fecha de fin.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            dtpFechaFin.Focus()
            Return False
        ElseIf txtAportesMax.Text.Trim.Equals("") Then
            MessageBox.Show("Campo requerido. Ingrese el aporte máximo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            txtAportesMax.Focus()
            Return False
        ElseIf IsNumeric(txtAportesMax.Text) = False Then
            MessageBox.Show("Formato incorrecto. El aporte máximo debe ser un valor númerico.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            txtAportesMax.Focus()
            Return False
        End If
        Return True
    End Function


    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub frmModificarTema_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If isDataSaved = False Then

            Dim button As DialogResult = MessageBox.Show("¿Desea cancelar la modificación del tema?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If button = DialogResult.Yes Then
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        End If
    End Sub
End Class

