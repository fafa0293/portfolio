'' <summary>
'' Formulario Buscar Bitacora: Realiza una busqueda de las bitacoras por rol
'' </summary>
'' <remarks>Autor: Jonathan Jara Morales/remarks>


Imports solLogica.Gestor
Imports solLogica.Estructura
Public Class frmBuscarBitacoraPorRol
    Dim roles As List(Of StrRol) = GestorRol.listarRoles()

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub frmBuscarBitacora_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Dim button As DialogResult = MessageBox.Show("¿Desea cancelar la búsqueda de las bitácoras?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If button = DialogResult.Yes Then
            e.Cancel = False
            frmPrincipal.CloseCurrentTab()
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub frmBuscarBitacora_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarListas()
    End Sub

    '' <summary>
    '' cargarListas: Carga la Lista de los roles
    '' </summary>
    '' <remarks>Autor: Jonathan Jara Morales</remarks>
    Private Sub cargarListas()
        Dim i As Integer = 0

        For Each rol As StrRol In roles
            cmbRol.Items.Insert(i, rol.Nombre)
            i += 1
        Next
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If cmbRol.SelectedIndex > -1 Then
            Try
                dgDatos.AutoGenerateColumns = False
                dgDatos.DataSource = GestorBitacora.mostrarBitacoraPorRol(cmbRol.SelectedItem)
            Catch ex As Exception
                MsgBox("Error: " & ex.ToString(), MsgBoxStyle.Information, "Error")
            End Try
        Else
            ''gestor.buscarTodasLasBitacoras()
        End If
        cmbRol.Focus()
    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            'Intentar generar el documento.
            'Se adjunta un texto debajo del encabezado con la fecha actual del sistema.
            ExportarDatosExcel(dgDatos, "FECHA: " + Now.Date())
        Catch ex As Exception
            'Si el intento es fallido, mostrar MsgBox.
            MessageBox.Show("No se puede generar el documento Excel.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
End Class