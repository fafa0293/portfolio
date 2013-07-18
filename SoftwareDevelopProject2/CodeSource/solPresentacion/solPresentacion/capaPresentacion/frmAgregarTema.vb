Imports System.Text.RegularExpressions
Imports solLogica.Gestor

Public Class frmAgregarTema
    Dim isDataSaved As Boolean
    Dim validado As Boolean
    Dim idUsuario As Integer
    Dim idForo As Integer
    Public Sub New(ByVal idForo As Integer)
        InitializeComponent()
        Me.idForo = idForo
        Me.idUsuario = GestorSesion.getIdUsuario()
    End Sub

    '' <summary>
    '' Método de la clase encargado de la funcionalidad del boton de agregar
    ''</summary>
    '' <param name="btnAgregar_Click"></param>
    '' <remarks>Autor: Fabián Vega Ramírez</remarks>
    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        validar()
        If validado = True Then
            Dim button As DialogResult = MessageBox.Show("¿Desea agregar el Tema?", "Agregar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If button = DialogResult.Yes Then
                Try
                    GestorTema.agregarTema(idUsuario, idForo, titulo.Text, 0, CInt(Max.Text), dtpFechaInicio.Value, dtpFechaFin.Value)

                    isDataSaved = True
                    MessageBox.Show("¡Tema registrado exitosamente!", "Registrar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                Catch ex As Exception
                    Dim ms As DialogResult = MessageBox.Show(ex.Message.ToString, "Registrar", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If
    End Sub
    '' <summary>
    '' Método de la clase encargado de la funcionalidad del boton de Cancelar
    ''</summary>
    '' <param name="btnCancelar_Click"></param>
    '' <remarks>Autor: Fabián Vega Ramírez</remarks>
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
    '' <summary>
    '' Método de la clase encargado de la validacion de los datos
    ''</summary>
    '' <param name="validar"></param>
    '' <remarks>Autor: Fabián Vega Ramírez</remarks>
    Private Sub validar()
        If titulo.Text.Trim().Equals("") Then
            MessageBox.Show("Campo requerido. Ingrese el Título.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            titulo.Focus()
        Else
            Dim re As New Regex("\w")
            If Not re.IsMatch(titulo.Text) Then
                MessageBox.Show("Campo Incorrecto. El Título debe de tener máximo 50 caracteres Alfanuméricos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                titulo.Select()
            ElseIf Max.Text.Trim().Equals("") Then
                MessageBox.Show("Campo requerido. Ingrese el Máximo de Aportes.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Max.Focus()
            Else
                Dim reN As New Regex("[0-9]")
                If Not reN.IsMatch(Max.Text) Then
                    MessageBox.Show("Campo Incorrecto. El Máximo de Aportes debe de tener máximo 4 caracteres numéricos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                    Max.Select()
                ElseIf dtpFechaInicio.Value.Date.AddHours(24) < Date.Now Then
                    MessageBox.Show("La fecha de inicio debe ser mayor o igual a la fecha actual.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                    dtpFechaInicio.Focus()
                ElseIf dtpFechaFin.Value.Date.AddHours(24) < Date.Now Then
                    MessageBox.Show("La fecha de fin debe ser mayor a la fecha actual.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                    dtpFechaFin.Focus()
                ElseIf dtpFechaInicio.Value.Date > dtpFechaFin.Value.Date Then
                    MessageBox.Show("La fecha de inicio debe menor a la fecha de fin.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                    dtpFechaFin.Focus()
                Else
                    validado = True
                End If
            End If
        End If
    End Sub
    '' <summary>
    '' Método de la clase encargado de la accion de cierre
    ''</summary>
    '' <param name="agregarTema_FormClosing"></param>
    '' <remarks>Autor: Fabián Vega Ramírez</remarks>
    Private Sub agregarTema_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If isDataSaved = False Then
            Dim button As DialogResult = MessageBox.Show("¿Desea cancelar el agregar el Tema?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If button = DialogResult.Yes Then
                e.Cancel = False
            Else
                e.Cancel = True
                titulo.Focus()
            End If
        End If
    End Sub

End Class