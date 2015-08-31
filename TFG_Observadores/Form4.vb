Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.IO
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Excel


Public Class Form4
    Public HasBeenChangedDGVFaunistica As Boolean
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BDpescamedDataSet1.Faunistica' table. You can move, or remove it, as needed.
        Try
            Me.FaunisticaTableAdapter.Fill(Me.BDpescamedDataSet1.Faunistica)
            LanceActivoTextBox.Text = LanceActivo.ToString
            Formatea_DGW()
            Dim x As Double
            x = Dime_PesoTotal_del_Lance(LanceActivo)
            PesoComercialTextBox.Text = x.ToString
            x = Dime_PesoTotal_dela_Muestra(LanceActivo)
            PesoMuestraDescTextBox.Text = x.ToString
            HasBeenChangedDGVFaunistica = False
            BotonAceptaCambiosFaunistica.Enabled = False
        Catch ex As Exception
            MsgBox("Error inesperado abriendo formulario de gestión de faunística.", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Public Sub Formatea_DGW()
        'Formateamos el DataGridView y filtramos para el lance.
        Try
            Me.FAunisticaDataGridViewB.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular)
            FAunisticaDataGridViewB.Columns(0).HeaderText = "Cod Lance"
            FAunisticaDataGridViewB.Columns(0).Width = 110
            FAunisticaDataGridViewB.Columns(1).HeaderText = "Cod Especie"
            FAunisticaDataGridViewB.Columns(1).Width = 200
            FAunisticaDataGridViewB.Columns(2).HeaderText = "Fracción"
            FAunisticaDataGridViewB.Columns(2).Width = 70

            FAunisticaDataGridViewB.Columns(3).HeaderText = "Peso Tot"
            FAunisticaDataGridViewB.Columns(3).Width = 110

            FAunisticaDataGridViewB.Columns(4).HeaderText = "Nº Ind"
            FAunisticaDataGridViewB.Columns(4).Width = 100

            FAunisticaDataGridViewB.Columns(5).HeaderText = "Peso Muest."
            FAunisticaDataGridViewB.Columns(5).Width = 130

            FAunisticaDataGridViewB.Columns(6).HeaderText = "Nº Ind Muestr."
            FAunisticaDataGridViewB.Columns(6).Width = 140

            FAunisticaDataGridViewB.Columns(7).HeaderText = "Talla I"
            FAunisticaDataGridViewB.Columns(7).Width = 100

            FAunisticaDataGridViewB.Columns(8).HeaderText = "Talla F"
            FAunisticaDataGridViewB.Columns(8).Width = 100

            If (CheckBoxComercial.Checked) And (CheckBoxDescarte.Checked) Then
                FaunisticaBindingSource.Filter = "TF_codlance=" & Me.LanceActivoTextBox.Text
            Else
                If (CheckBoxComercial.Checked = False) And (CheckBoxDescarte.Checked) Then
                    FaunisticaBindingSource.Filter = "TF_codlance=" & Me.LanceActivoTextBox.Text & " and TF_fraccion ='D'"
                Else
                    If (CheckBoxComercial.Checked = True) And (CheckBoxDescarte.Checked = False) Then
                        FaunisticaBindingSource.Filter = "TF_codlance=" & Me.LanceActivoTextBox.Text & " and TF_fraccion ='C'"
                    End If
                End If
            End If

            FaunisticaBindingSource.Sort = "TF_codespecie"
        Catch ex As Exception
            MsgBox("Error inesperado cargando tabla de faunística.", MsgBoxStyle.Critical, "Error")

        End Try
    End Sub

    Private Sub ButtonCambiaLAnce_Click(sender As Object, e As EventArgs) Handles ButtonCambiaLAnce.Click
        Try
            If HasBeenChangedDGVFaunistica = False Then
                If DimeSIElLanceEXISTE(LanceActivoTextBox.Text) = True Then
                    CheckBoxDescarte.Checked = True
                    CheckBoxComercial.Checked = True
                    Formatea_DGW()
                    LanceActivo = LanceActivoTextBox.Text
                    Dim x As Double
                    x = Dime_PesoTotal_del_Lance(LanceActivo)
                    PesoComercialTextBox.Text = x.ToString
                    x = Dime_PesoTotal_dela_Muestra(LanceActivo)
                    PesoMuestraDescTextBox.Text = x.ToString
                Else
                    MsgBox("El lance no existe en la base de datos", vbCritical)
                    LanceActivoTextBox.Text = LanceActivo
                End If
            Else
                MsgBox("Debe salvar antes de cambiar de lance.", vbOKOnly)
            End If
        Catch ex As Exception
            MsgBox("Error inesperado cambiando de lance.", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub BotonCAmbiaFraccion_Click(sender As Object, e As EventArgs) Handles BotonCAmbiaFraccion.Click
        Formatea_DGW()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Exportar a Excel
        Try
            Dim fichero As New SaveFileDialog()
            fichero.Filter = "Excel (*.xls)|*.xls"
            If fichero.ShowDialog() = DialogResult.OK Then
                Dim aplicacion As Microsoft.Office.Interop.Excel.Application
                Dim libros_trabajo As Microsoft.Office.Interop.Excel.Workbook
                Dim hoja_trabajo As Microsoft.Office.Interop.Excel.Worksheet
                aplicacion = New Microsoft.Office.Interop.Excel.Application()
                libros_trabajo = aplicacion.Workbooks.Add()
                hoja_trabajo = DirectCast(libros_trabajo.Worksheets.Item(1), Microsoft.Office.Interop.Excel.Worksheet)
                'Recorremos el DataGridView rellenando la hoja de trabajo
                Dim columnsCount As Integer = FAunisticaDataGridViewB.Columns.Count
                For i As Integer = 0 To FAunisticaDataGridViewB.Rows.Count - 2
                    For j As Integer = 0 To FAunisticaDataGridViewB.Columns.Count - 1
                        If i = 0 Then 'pintamos cabecera
                            hoja_trabajo.Cells(i + 1, j + 1) = FAunisticaDataGridViewB.Columns(j).HeaderText
                        Else 'pintamos datos
                            hoja_trabajo.Cells(i + 1, j + 1) = FAunisticaDataGridViewB.Rows(i).Cells(j).Value.ToString()
                        End If
                    Next
                Next
                libros_trabajo.SaveAs(fichero.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal)
                libros_trabajo.Close(True)
                aplicacion.Quit()
            End If
        Catch ex As Exception
            MsgBox("Error inesperado exportando a Excel.", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub BotonAbreTallas_Click(sender As Object, e As EventArgs) Handles BotonAbreTallas.Click
        form5.show()

    End Sub

    Private Sub LanceActivoTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles LanceActivoTextBox.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub BotonAceptaCambiosFaunistica_Click(sender As Object, e As EventArgs) Handles BotonAceptaCambiosFaunistica.Click
        Try
            'Actualizamos los datos
            Me.FaunisticaTableAdapter.Update(BDpescamedDataSet1)
            ' Mostramos un mensaje
            MessageBox.Show("Se ha actualizado la lista faunística.")
            BotonAceptaCambiosFaunistica.Enabled = False
            HasBeenChangedDGVFaunistica = False

        Catch ex As DBConcurrencyException
            MessageBox.Show("Error de concurrencia: " & vbCrLf & ex.Message)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BotonEliminaEspecieEnFaunistica_Click(sender As Object, e As EventArgs) Handles BotonEliminaEspecieEnFaunistica.Click
        Try
            If FAunisticaDataGridViewB.RowCount > 1 Then
                Dim Buttons As MessageBoxButtons = MessageBoxButtons.YesNo
                Dim Result As DialogResult
                Result = MessageBox.Show("Borrar especie?", "Aviso", Buttons)
                If Result = System.Windows.Forms.DialogResult.Yes Then
                    If FAunisticaDataGridViewB.SelectedRows.Count = 1 Then
                        Me.FAunisticaDataGridViewB.Rows.RemoveAt(FAunisticaDataGridViewB.SelectedCells.Item(0).RowIndex)
                        HasBeenChangedDGVFaunistica = True
                        BotonAceptaCambiosFaunistica.Enabled = True
                    Else
                        MsgBox("Seleccione una especie de la lista", MsgBoxStyle.Information)
                    End If
                End If
            Else
                MsgBox("Nada para eliminar.", vbOKOnly, "Aviso")
            End If
        Catch ex As Exception
            MsgBox("Error inesperado en eliminando especie.", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub FAunisticaDataGridViewB_DefaultValuesNeeded(sender As Object, e As DataGridViewRowEventArgs) Handles FAunisticaDataGridViewB.DefaultValuesNeeded
        e.Row.Cells("TFCodLanceDataGridViewTextBoxColumn").Value = LanceActivoTextBox.Text

    End Sub

    Private Sub FAunisticaDataGridViewB_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles FAunisticaDataGridViewB.CellValueChanged
        BotonAceptaCambiosFaunistica.Enabled = True
        HasBeenChangedDGVFaunistica = True
    End Sub

    Private Sub Form4_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If HasBeenChangedDGVFaunistica = False Then
        Else
            If HasBeenChangedDGVFaunistica AndAlso _
                       MessageBox.Show("¿Desea salir sin salvar?", "Guardar cambios", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
            Else
                e.Cancel = True
            End If
        End If

    End Sub

    Private Sub CheckBoxDescarte_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxDescarte.CheckedChanged
        If CheckBoxDescarte.Checked = False And CheckBoxComercial.Checked = False Then
            CheckBoxComercial.Checked = True
        End If
    End Sub

    Private Sub CheckBoxComercial_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxComercial.CheckedChanged
        If CheckBoxDescarte.Checked = False And CheckBoxComercial.Checked = False Then
            CheckBoxDescarte.Checked = True
        End If
    End Sub
End Class