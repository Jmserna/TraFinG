Public Class Form5
    Public OtraConexion As New SqlClient.SqlConnection
    Public HasBeenChangedDGVTallas As Boolean


    Public Sub LLena_listview1()
        Try
            Dim connectionString As String = GetConnectionString()
            OtraConexion.ConnectionString = connectionString
            OtraConexion.Open()

            Dim CMD As New SqlClient.SqlCommand
            CMD.Connection = OtraConexion
            CMD.CommandText = "select distinct tf_codespecie, te_nomcientifico, tf_fraccion from especies, faunistica where te_codespecie=tf_codespecie and TF_codlance='" + LanceActivoTallasTextBox.Text + "' order by te_nomcientifico, tf_fraccion"

            Dim miDataReader As SqlClient.SqlDataReader
            miDataReader = CMD.ExecuteReader
            ListView1.View = View.Details
            With ListView1
                .Items.Clear()
                .Columns.Add("Cod", 60, HorizontalAlignment.Left)
                .Columns.Add("Especie", 250, HorizontalAlignment.Left)
                .Columns.Add("Fracción", 80, HorizontalAlignment.Left)
                .GridLines = True
            End With

            While miDataReader.Read
                Dim LI As ListViewItem = ListView1.Items.Add(miDataReader("tf_codespecie").ToString())
                LI.SubItems.Add(miDataReader("Te_nomCientifico").ToString())
                LI.SubItems.Add(miDataReader("Tf_fraccion").ToString())
            End While

            OtraConexion.Close()
            miDataReader.Close()

        Catch ex As Exception
            MsgBox("Error inesperado en llenando faunística en formulario de tallas.", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub



    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BDpescamedDataSet1.Tallas' table. You can move, or remove it, as needed.
        Try
            Me.TallasTableAdapter.Fill(Me.BDpescamedDataSet1.Tallas)

            LanceActivoTallasTextBox.Text = LanceActivo
            LLena_listview1()
            ListView1.Focus()
            ListView1.Items(0).Selected = True
            LanceTallaTextBox.Text = LanceActivoTallasTextBox.Text
            EspecieTallaTextBox.Text = ListView1.SelectedItems(0).SubItems(0).Text
            FraccionTallaTextBox.Text = ListView1.SelectedItems(0).SubItems(2).Text
            ListView1.Items(0).Selected = True
            ' ListView1.Scrollable = False
            FiltraDGVTallas()
            HasBeenChangedDGVTallas = False
            BotonAceptarCambiosTAllas.Enabled = False
        Catch ex As Exception
            MsgBox("Error inesperado abriendo formulario de gestión de tallas.", MsgBoxStyle.Critical, "Error")

        End Try
    End Sub

    Private Sub BotonCambiaLanceEnTallas_Click(sender As Object, e As EventArgs) Handles BotonCambiaLanceEnTallas.Click
        Try
            If HasBeenChangedDGVTallas = False Then
                Dim ExisteLance As Boolean
                ExisteLance = ExisteLanceEnTallas(CInt(LanceActivoTallasTextBox.Text))
                If ExisteLance = True Then
                    LanceActivo = LanceActivoTallasTextBox.Text
                    LLena_listview1()
                    ListView1.Focus()
                    ListView1.Items(0).Selected = True
                    LanceTallaTextBox.Text = LanceActivoTallasTextBox.Text
                    EspecieTallaTextBox.Text = ListView1.SelectedItems(0).SubItems(0).Text
                    FraccionTallaTextBox.Text = ListView1.SelectedItems(0).SubItems(2).Text
                    ListView1.Items(0).Selected = True
                    FiltraDGVTallas()
                Else
                    MsgBox("Lance inexistente o lance sin tallas.", vbCritical)
                    LanceActivoTallasTextBox.Text = LanceActivo
                    LanceActivoTallasTextBox.Focus()
                End If
            Else
                MsgBox("Debe salvar antes de cambiar de lance.", vbOKOnly)
            End If
        Catch ex As Exception
            MsgBox("Error inesperado en cambiando lance en formulario de gestión de tallas.", MsgBoxStyle.Critical, "Error")

        End Try
    End Sub

    Private Sub LanceActivoTallasTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles LanceActivoTallasTextBox.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TallasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TallasBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.TallasBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.BDpescamedDataSet1)
        Catch ex As Exception
            MsgBox("Error inesperado salvando datos.", MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub ListView1_Click(sender As Object, e As EventArgs) Handles ListView1.Click
        LanceTallaTextBox.Text = LanceActivoTallasTextBox.Text
        EspecieTallaTextBox.Text = ListView1.SelectedItems(0).SubItems(0).Text
        FraccionTallaTextBox.Text = ListView1.SelectedItems(0).SubItems(2).Text
        FiltraDGVTallas()
    End Sub


    Private Sub FiltraDGVTallas()
        TallasBindingSource.Filter = "Tt_codlance=" & LanceActivoTallasTextBox.Text & " and Tt_codespecie=" & EspecieTallaTextBox.Text & " and TT_fraccion ='" & FraccionTallaTextBox.Text & "'"
    End Sub

    Private Sub BotonAceptarCambiosTAllas_Click(sender As Object, e As EventArgs) Handles BotonAceptarCambiosTAllas.Click
        Try
            'Actualizamos los datos
            Me.TallasTableAdapter.Update(BDpescamedDataSet1)

            BotonAceptarCambiosTAllas.Enabled = False
            HasBeenChangedDGVTallas = False


            ' Mostramos un mensaje
            MessageBox.Show("Se ha actualizado la distribución de tallas.")

        Catch ex As DBConcurrencyException
            MessageBox.Show("Error de concurrencia: " & vbCrLf & ex.Message)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim Buttons As MessageBoxButtons = MessageBoxButtons.YesNo
            Dim Result As DialogResult
            Result = MessageBox.Show("Borrar talla?", "Aviso", Buttons)
            If Result = System.Windows.Forms.DialogResult.Yes Then
                If TallasDataGridView.SelectedRows.Count = 1 Then
                    Me.TallasDataGridView.Rows.RemoveAt(TallasDataGridView.SelectedCells.Item(0).RowIndex)
                    BotonAceptarCambiosTAllas.Enabled = True
                    HasBeenChangedDGVTallas = True
                Else
                    MsgBox("Seleccione una talla de la lista", MsgBoxStyle.Information)
                End If
            End If
        Catch ex As Exception
            MsgBox("Error inesperado eliminando tallas.", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub TallasDataGridVTallasDataGridViewiew_DefaultValuesNeeded(sender As Object, e As DataGridViewRowEventArgs) Handles TallasDataGridView.DefaultValuesNeeded
        e.Row.Cells("DataGridViewTextBoxColumn1").Value = LanceTallaTextBox.Text
        e.Row.Cells("DataGridViewTextBoxColumn2").Value = EspecieTallaTextBox.Text
        e.Row.Cells("DataGridViewTextBoxColumn3").Value = FraccionTallaTextBox.Text
    End Sub

    Private Sub BotonEliminaMuestreo_Click(sender As Object, e As EventArgs) Handles BotonEliminaMuestreo.Click
        Try
            If TallasDataGridView.RowCount >= 1 Then
                For i As Integer = 0 To TallasDataGridView.RowCount - 2
                    Me.TallasDataGridView.Rows.Remove(Me.TallasDataGridView.CurrentRow)
                Next
                BotonAceptarCambiosTAllas.Enabled = True
                HasBeenChangedDGVTallas = True
            End If
        Catch ex As InvalidOperationException
            MsgBox("Error eliminando muestreo", vbCritical, "Error inesperado")
        End Try
    End Sub

    Private Sub BotonExportaTallasAExcel_Click(sender As Object, e As EventArgs) Handles BotonExportaTallasAExcel.Click
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
                Dim columnsCount As Integer = TallasDataGridView.Columns.Count
                For i As Integer = 0 To TallasDataGridView.Rows.Count - 2
                    For j As Integer = 0 To TallasDataGridView.Columns.Count - 1
                        If i = 0 Then 'pintamos cabecera
                            hoja_trabajo.Cells(i + 1, j + 1) = TallasDataGridView.Columns(j).HeaderText
                        Else 'pintamos datos
                            hoja_trabajo.Cells(i + 1, j + 1) = TallasDataGridView.Rows(i).Cells(j).Value.ToString()
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

    Private Sub TallasDataGridView_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles TallasDataGridView.CellValueChanged
        BotonAceptarCambiosTAllas.Enabled = True
        HasBeenChangedDGVTallas = True
    End Sub

    Private Sub Form5_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            If HasBeenChangedDGVTallas = False Then
            Else
                If HasBeenChangedDGVTallas AndAlso _
                           MessageBox.Show("¿Desea salir sin salvar?", "Guardar cambios", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
                Else
                    e.Cancel = True
                End If
            End If
        Catch ex As Exception
            MsgBox("Error inesperado cerrando formulario.", MsgBoxStyle.Critical, "Error")

        End Try
    End Sub


    Private Sub dataGridView1_EditingControlShowing( _
      ByVal sender As Object, _
      ByVal e As DataGridViewEditingControlShowingEventArgs) _
          Handles TallasDataGridView.EditingControlShowing
        ' referencia a la celda  
        Dim validar As TextBox = CType(e.Control, TextBox)
        ' agregar el controlador de eventos para el KeyPress  
        AddHandler validar.KeyPress, AddressOf validar_Keypress

    End Sub

    Private Sub validar_Keypress( _
        ByVal sender As Object, _
        ByVal e As System.Windows.Forms.KeyPressEventArgs)
        ' obtener indice de la columna  

        Try
            Dim columna As Integer = TallasDataGridView.CurrentCell.ColumnIndex

            If columna = 3 Then ' Si la columna es la correspondiente a la talla ingresa numeros decimales
                If Not IsNumeric(e.KeyChar) Then
                    If Char.IsPunctuation(e.KeyChar) Then 'permitimos el separador decimal
                        e.Handled = False
                    Else
                        e.Handled = True
                    End If
                End If
            End If

            If columna = 4 Then ' Si la columna es la correspondiente al num individuos solo puede ingresar números
                If Not IsNumeric(e.KeyChar) Then
                    e.Handled = True
                End If
            End If


        Catch ex As Exception
            MsgBox("Error inesperado validando datos de tallas.", MsgBoxStyle.Critical, "Error")
        End Try

    End Sub



End Class