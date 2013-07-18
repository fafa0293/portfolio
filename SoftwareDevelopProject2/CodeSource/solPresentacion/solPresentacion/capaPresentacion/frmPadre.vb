
'' <summary>
'' Formulario Padre: Utilizado para contener el formulario midi
'' </summary>
'' <remarks>Autor: Jonathan Jara Morales/remarks>

Public Class frmPadre

    '' <summary>
    '' setTitulo: Se encarga de agregar un titulo al formulario
    '' </summary>
    '' <param name="ptitulo"></param>
    '' <remarks>Autor: Jonathan Jara Morales</remarks>
    Public Sub setTitulo(ByVal ptitulo As String)
        lblTitulo.Text = ptitulo
    End Sub

    '' <summary>
    '' setDescripcion: Se encarga de agregar una descripcion al formulario
    '' </summary>
    '' <param name="pdescripcion"></param>
    '' <remarks>Autor: Jonathan Jara Morales</remarks>
    Public Sub setDescripcion(ByVal pdescripcion As String)
        lblDescripcion.Text = pdescripcion
    End Sub
End Class


