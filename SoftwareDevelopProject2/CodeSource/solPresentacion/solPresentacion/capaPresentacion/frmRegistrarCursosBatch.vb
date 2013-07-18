Imports solLogica.Gestor
Imports Microsoft.VisualBasic.FileIO

Public Class frmRegistrarCursosBatch

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Dim op As New OpenFileDialog
        op.Filter = "Archivo de texto|*.txt|CSV|*.csv"
        op.ShowDialog()
        Dim fileName As String = op.FileName
        txtDirectorio.Text = fileName
    End Sub

    Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
        If validar() Then
            Dim button As DialogResult = MessageBox.Show("¿Desea realizar el registro de cursos?", "Registrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If button = DialogResult.Yes Then
                Dim parser As New TextFieldParser(txtDirectorio.Text)
                Dim datos As New List(Of List(Of String))
                Dim fila As String()

                parser.TextFieldType = FileIO.FieldType.Delimited
                parser.Delimiters = New String() {","}
                parser.ReadLine()
                While Not parser.EndOfData
                    Try
                        fila = parser.ReadFields()
                     
                        datos.Add(fila.ToList)
                    Catch ex As Exception
                        MsgBox("Line " & ex.Message &
                        "is not valid and will be skipped.")
                    End Try

                End While
                GestorCurso.registrarCursosPorBatch(datos)
                MessageBox.Show("Se han registrado los cursos con éxito.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If
        End If
    End Sub

    Private Function validar()
        If txtDirectorio.Text.Trim.Equals("") Then
            MessageBox.Show("Debe buscar un archivo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            txtDirectorio.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub frmRegistrarCursosBatch_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

    End Sub
End Class