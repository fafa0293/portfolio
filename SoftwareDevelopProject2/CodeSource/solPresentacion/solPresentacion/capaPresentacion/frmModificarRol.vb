Imports solLogica.Gestor

Public Class frmModificarRol
    Dim isDataSaved As Boolean
    Dim validado As Boolean
    Dim IdRol As Integer

    '' <summary>
    '' Método de la clase encargado de la funcionalidad del boton de Modificar
    ''</summary>
    '' <param name="btnModificar_Click"></param>
    '' <remarks>Autor: Fabián Vega Ramírez</remarks>
    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        validar()
        If validado = True Then
            Dim button As DialogResult = MessageBox.Show("¿Desea realizar la modificación del Rol?", "Modificar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If button = DialogResult.Yes Then

                Try
                    GestorRol.modificarRol(IdRol, nomb.Text)
                    isDataSaved = True
                Catch ex As Exception
                    MessageBox.Show(ex.Message.ToString, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
                If isDataSaved Then
                    MessageBox.Show("Se ha modificado el rol con éxito.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                End If

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
        If nomb.Text.Trim().Equals("") Then
            MessageBox.Show("Campo requerido. Ingrese el Nombre.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            nomb.Focus()
        Else

            validado = True
        End If
    End Sub
    '' <summary>
    '' Método de la clase encargado de la accion de cierre
    ''</summary>
    '' <param name="modificarRol_FormClosing"></param>
    '' <remarks>Autor: Fabián Vega Ramírez</remarks>
    Private Sub modificarRol_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If isDataSaved = False Then
            Dim button As DialogResult = MessageBox.Show("¿Desea cancelar la modificación del Rol?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If button = DialogResult.Yes Then
                e.Cancel = False
            Else
                nomb.Focus()
                e.Cancel = True
            End If
        End If
    End Sub
    '' <summary>
    '' Método de la clase encargada de ejecurtar acciones al ejecutar la ventana
    '' </summary>
    '' <param name="frmModificarRol_Load"></param>
    '' <remarks>Autor: Fabián Vega Ramírez</remarks>
    Public Sub New(ByVal id As String, ByVal nombre As String)
        InitializeComponent()
        IdRol = CInt(id)
        nomb.Text = nombre
    End Sub
End Class