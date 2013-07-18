Imports solLogica.Gestor
Public Class frmRegistrarRol
    Dim isDataSaved As Boolean
    Dim validado As Boolean
    '' <summary>
    '' Método de la clase encargado de la funcionalidad del boton de Modificar
    ''</summary>
    '' <param name="btnModificar_Click"></param>
    '' <remarks>Autor: Fabián Vega Ramírez</remarks>
    Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
        validar()
        If validado = True Then
            Dim button As DialogResult = MessageBox.Show("¿Desea realizar el registro del Rol?", "Registrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If button = DialogResult.Yes Then
                Try
                    GestorRol.registrarRol(nomb.Text)
                    isDataSaved = True
                    Dim button4 As DialogResult = MessageBox.Show("¡Rol registrado exitosamente!", "Registrar", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
    '' <param name="registrarRol_FormClosing"></param>
    '' <remarks>Autor: Fabián Vega Ramírez</remarks>
    Private Sub registrarRol_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If isDataSaved = False Then
            Dim button As DialogResult = MessageBox.Show("¿Desea cancelar el registro del Rol?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If button = DialogResult.Yes Then
                e.Cancel = False
                frmPrincipal.CloseCurrentTab()
            Else
                nomb.Focus()
                e.Cancel = True
            End If
        End If
    End Sub
End Class