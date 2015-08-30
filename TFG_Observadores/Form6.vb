Imports System.IO
Public Class Form6

    Private Sub BotonImportaFicheroCTD_Click(sender As Object, e As EventArgs) Handles BotonImportaFicheroCTD.Click
        Try
            If DimeSIElLanceTieneCTD(LanceActivo) = False Then
                If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                    If Me.OpenFileDialog1.FileName <> "" Then
                        Dim fichero As String = OpenFileDialog1.FileName
                        Dim lineas As String() = File.ReadAllLines(fichero)
                        Dim NombresColumnas As String() = lineas(0).Split(";"c)
                        Dim dt As New DataTable()
                        For Each N As String In NombresColumnas
                            dt.Columns.Add(N, GetType(String))
                        Next

                        For i As Integer = 1 To lineas.Length - 1
                            Dim Columnas As String() = lineas(i).Split(";"c)
                            dt.Rows.Add(Columnas)
                        Next
                        DataGridView1.DataSource = dt
                        TextBoxNumeroFilasCTD.Text = DataGridView1.RowCount - 1
                    End If
                End If
            Else
                MsgBox("Ya existen datos de CTD para este lance.", MsgBoxStyle.Information)
            End If

        Catch ex As Exception
            MsgBox("Error importando datos, revise formato fichero ASCII.", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub


    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LanceActivoCTDs.Text = LanceActivo
        If (DimeSIElLanceTieneCTD(LanceActivo) = True) Then
            MsgBox("Este lance ya tiene datos de CTD, se mostrarán en pantalla.")
            Call muestraCTDexistente(LanceActivo)
        End If

    End Sub

    Private Sub muestraCTDexistente(cl As Integer)
        Try
            Dim sqlX As String = "select * from CTD where TC_codlance = " & LanceActivo
            Dim DaXX As New SqlClient.SqlDataAdapter(sqlX, GetConnectionString())
            Dim DTp As New DataTable
            DaXX.Fill(DTp)
            DataGridView1.DataSource = DTp
            TextBoxNumeroFilasCTD.Text = DataGridView1.RowCount - 1

            Me.DataGridView1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular)

            DataGridView1.Columns(0).HeaderText = "CODLANCE"
            DataGridView1.Columns(0).Name = "CODLANCE"
            DataGridView1.Columns(0).Width = 100 '

            DataGridView1.Columns(1).HeaderText = "PRES"
            DataGridView1.Columns(1).Name = "PRES"
            DataGridView1.Columns(1).Width = 100

            DataGridView1.Columns(2).HeaderText = "TEMP"
            DataGridView1.Columns(2).Name = "TEMP"
            DataGridView1.Columns(2).Width = 100
            '
            DataGridView1.Columns(3).HeaderText = "SALI"
            DataGridView1.Columns(3).Name = "SALI"
            DataGridView1.Columns(3).Width = 100

            DataGridView1.Columns(4).HeaderText = "PH"
            DataGridView1.Columns(4).Name = "PH"
            DataGridView1.Columns(4).Width = 100

            DataGridView1.Columns(5).HeaderText = "OXMG"
            DataGridView1.Columns(5).Name = "OXMG"
            DataGridView1.Columns(5).Width = 100

            DataGridView1.Columns(6).HeaderText = "FLUO"
            DataGridView1.Columns(6).Name = "FLUO"
            DataGridView1.Columns(6).Width = 100

            DataGridView1.Columns(7).HeaderText = "DiaMesAno"
            DataGridView1.Columns(7).Name = "DiaMesAno"
            DataGridView1.Columns(7).Width = 100

            DataGridView1.Columns(8).HeaderText = "HoraCTD"
            DataGridView1.Columns(8).Name = "HoraCTD"
            DataGridView1.Columns(8).Width = 100

        Catch ex As Exception
            MsgBox("Error inesperado cargando datos del CTD.", MsgBoxStyle.Critical, "Error")

        End Try

    End Sub

    Private Sub BotonSalvaCTDenBD_Click(sender As Object, e As EventArgs) Handles BotonSalvaCTDenBD.Click
        Try
            If DataGridView1.RowCount <= 0 Then
                MsgBox("No hay datos para salvar.", vbOKOnly)
                Exit Sub
            End If

            If DimeSIElLanceTieneCTD(LanceActivo) = False Then
                Dim Micon2 As New SqlClient.SqlConnection
                Dim connectionString As String = GetConnectionString()
                Micon2.ConnectionString = connectionString
                Micon2.Open()
                Dim agregar As New SqlClient.SqlCommand("insert into CTD values (@l, @p, @t, @S, @ph, @O, @F, @D, @H)", Micon2)
                Dim fila As DataGridViewRow = New DataGridViewRow
                For Each fila In DataGridView1.Rows
                    If fila.IsNewRow = False Then
                        agregar.Parameters.Clear()
                        agregar.Parameters.AddWithValue("@l", LanceActivo)
                        agregar.Parameters.AddWithValue("@p", Convert.ToInt32(fila.Cells("PRES").Value))
                        agregar.Parameters.AddWithValue("@t", Convert.ToDouble(fila.Cells("TEMP").Value))
                        agregar.Parameters.AddWithValue("@s", Convert.ToDouble(fila.Cells("SALI").Value))
                        agregar.Parameters.AddWithValue("@ph", Convert.ToDouble(fila.Cells("PH").Value))
                        agregar.Parameters.AddWithValue("@O", Convert.ToDouble(fila.Cells("OXMG").Value))
                        agregar.Parameters.AddWithValue("@F", Convert.ToDouble(fila.Cells("FLUO").Value))
                        agregar.Parameters.AddWithValue("@D", Convert.ToDateTime(fila.Cells("DiaMesANo").Value))
                        agregar.Parameters.AddWithValue("@H", Convert.ToDateTime(fila.Cells("HoraCTD").Value))
                        agregar.ExecuteNonQuery()
                    End If
                Next
                MsgBox("Datos añadidos correctamente la tabla de CTD's.", MsgBoxStyle.Information)
                Micon2.Close()
            Else ' Vamos a modificar
                Dim Buttons As MessageBoxButtons = MessageBoxButtons.YesNo
                Dim Result As DialogResult
                Result = MessageBox.Show("Reemplazar datos CTD?", "Aviso", Buttons)
                If Result = System.Windows.Forms.DialogResult.Yes Then
                    Dim Miconex As New SqlClient.SqlConnection
                    Dim connectionString3 As String = GetConnectionString()
                    Miconex.ConnectionString = connectionString3
                    Miconex.Open()
                    Dim cmd As New SqlClient.SqlCommand
                    cmd.Connection = Miconex
                    cmd.CommandText = "delete from CTD where TC_codlance=" & LanceActivo
                    Dim x5 As Integer
                    x5 = cmd.ExecuteNonQuery

                    Dim agregar As New SqlClient.SqlCommand("insert into CTD values (@l, @p, @t, @S, @ph, @O, @F, @D, @H)", Miconex)
                    Dim fila As DataGridViewRow = New DataGridViewRow
                    For Each fila In DataGridView1.Rows
                        If fila.IsNewRow = False Then
                            'MsgBox(Me.DataGridView1.Columns.Item(1).Name.ToString, vbOKOnly)
                            agregar.Parameters.Clear()
                            agregar.Parameters.AddWithValue("@l", LanceActivo)
                            agregar.Parameters.AddWithValue("@p", Convert.ToInt32(fila.Cells("PRES").Value))
                            agregar.Parameters.AddWithValue("@t", Convert.ToDouble(fila.Cells("TEMP").Value))
                            agregar.Parameters.AddWithValue("@s", Convert.ToDouble(fila.Cells("SALI").Value))
                            agregar.Parameters.AddWithValue("@ph", Convert.ToDouble(fila.Cells("PH").Value))
                            agregar.Parameters.AddWithValue("@O", Convert.ToDouble(fila.Cells("OXMG").Value))
                            agregar.Parameters.AddWithValue("@F", Convert.ToDouble(fila.Cells("FLUO").Value))
                            agregar.Parameters.AddWithValue("@D", Convert.ToDateTime(fila.Cells("DiaMesANo").Value))
                            agregar.Parameters.AddWithValue("@H", (fila.Cells("HoraCTD").Value))
                            agregar.ExecuteNonQuery()
                        End If
                    Next
                    MsgBox("Datos modificados correctamente.", MsgBoxStyle.Information)
                    Miconex.Close()
                End If
            End If
        Catch ex As Exception
            MsgBox("Error inesperado salvando datos del CTD.", MsgBoxStyle.Critical, "Error")

        End Try
    End Sub

    Private Sub BotonBorraDatosCTD_Click(sender As Object, e As EventArgs) Handles BotonBorraDatosCTD.Click
        Try
            If DimeSIElLanceTieneCTD(LanceActivo) Then

                Dim Buttons As MessageBoxButtons = MessageBoxButtons.YesNo
                Dim Result As DialogResult
                Result = MessageBox.Show("Borrar CTD?", "Aviso", Buttons)
                If Result = System.Windows.Forms.DialogResult.Yes Then

                    Dim Micon2 As New SqlClient.SqlConnection
                    Dim connectionString As String = GetConnectionString()
                    Micon2.ConnectionString = connectionString
                    Micon2.Open()
                    Dim cmd As New SqlClient.SqlCommand
                    cmd.Connection = Micon2
                    cmd.CommandText = "delete from CTD where TC_codlance=" & LanceActivo
                    Dim x As Integer
                    x = cmd.ExecuteNonQuery
                    DataGridView1.DataSource = Nothing
                    DataGridView1.Refresh()
                    Micon2.Close()
                    TextBoxNumeroFilasCTD.Text = DataGridView1.RowCount - 1
                End If
            Else
                MsgBox("No hay datos para borrar.", vbOKOnly)
            End If
        Catch ex As Exception
            MsgBox("Error inesperado borrando datos del CTD.", MsgBoxStyle.Critical, "Error")

        End Try
    End Sub

    Private Sub BotonExportaCTDaEXCEL_Click(sender As Object, e As EventArgs) Handles BotonExportaCTDaEXCEL.Click
        Try
            If DimeSIElLanceTieneCTD(LanceActivo) Then
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
                    Dim columnsCount As Integer = DataGridView1.Columns.Count
                    Me.Cursor = Cursors.WaitCursor
                    For i As Integer = 0 To DataGridView1.Rows.Count - 2
                        For j As Integer = 0 To DataGridView1.Columns.Count - 1
                            If i = 0 Then 'pintamos cabecera
                                hoja_trabajo.Cells(i + 1, j + 1) = DataGridView1.Columns(j).HeaderText
                            Else 'pintamos datos
                                hoja_trabajo.Cells(i + 1, j + 1) = DataGridView1.Rows(i).Cells(j).Value.ToString()
                            End If
                        Next
                    Next
                    Me.Cursor = Cursors.Default
                    libros_trabajo.SaveAs(fichero.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal)
                    libros_trabajo.Close(True)
                    aplicacion.Quit()
                    MsgBox("Los datos se han exportado correctamente.", vbOKOnly)
                End If
            Else
                MsgBox("No hay datos para exportar.", vbOKOnly)
            End If

        Catch ex As Exception
            MsgBox("Error inesperado exportando datos a Excel.", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class