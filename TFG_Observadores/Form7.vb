Imports System.IO
Public Class Form7

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LanceActivoTrackings.Text = LanceActivo
        If (DimeSIElLanceTieneGPS(LanceActivo) = True) Then
            MsgBox("Este lance ya tiene datos de GPS, se mostrarán en pantalla.")
            Call muestraGPSexistente(LanceActivo)
        End If
        Me.Controls("BotonImportarGPS").Select()
    End Sub

   
    Private Sub BotonImportarGPS_Click(sender As Object, e As EventArgs) Handles BotonImportarGPS.Click
        Try
            If DimeSIElLanceTieneGPS(LanceActivo) = False Then
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
                        DataGridViewTrackings.DataSource = dt
                        TextBoxNumeroREg.Text = DataGridViewTrackings.RowCount - 1
                    End If
                End If
            Else
                MsgBox("Ya existen datos de GPS para este lance.", MsgBoxStyle.Information)
            End If

        Catch ex As Exception
            MsgBox("Error importando datos, revise formato fichero ASCII.", MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub BotonBorrarGPS_Click(sender As Object, e As EventArgs) Handles BotonBorrarGPS.Click
        Try
            If DimeSIElLanceTieneGPS(LanceActivo) Then
                Dim Buttons As MessageBoxButtons = MessageBoxButtons.YesNo
                Dim Result As DialogResult
                Result = MessageBox.Show("Borrar Tracking?", "Aviso", Buttons)
                If Result = System.Windows.Forms.DialogResult.Yes Then

                    Dim Micon2 As New SqlClient.SqlConnection
                    Dim connectionString As String = GetConnectionString()
                    Micon2.ConnectionString = connectionString
                    Micon2.Open()
                    Dim cmd As New SqlClient.SqlCommand
                    cmd.Connection = Micon2
                    cmd.CommandText = "delete from TRACKING where TT_codlance=" & LanceActivo
                    Dim x As Integer
                    x = cmd.ExecuteNonQuery
                    DataGridViewTrackings.DataSource = Nothing
                    DataGridViewTrackings.Refresh()
                    Micon2.Close()
                    TextBoxNumeroREg.Text = DataGridViewTrackings.RowCount - 1
                End If
            Else
                MsgBox("No hay datos para borrar.", vbOKOnly)
            End If
        Catch ex As Exception
            MsgBox("Error inesperado borrando datos GPS.", MsgBoxStyle.Critical, "Error")
        End Try

    End Sub
    Private Sub muestraGPSexistente(cl As Integer)
        Try
            Dim sqlX As String = "select * from TRACKING where TT_codlance = " & LanceActivo
            Dim DaXX As New SqlClient.SqlDataAdapter(sqlX, GetConnectionString())
            Dim DTp As New DataTable
            DaXX.Fill(DTp)
            DataGridViewTrackings.DataSource = DTp
            TextBoxNumeroREg.Text = DataGridViewTrackings.RowCount - 1

            Me.DataGridViewTrackings.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular)

            DataGridViewTrackings.Columns(0).HeaderText = "CodLance"
            DataGridViewTrackings.Columns(0).Name = "CodLance"
            DataGridViewTrackings.Columns(0).Width = 100

            DataGridViewTrackings.Columns(1).HeaderText = "CodPosicion"
            DataGridViewTrackings.Columns(1).Name = "CodPosicion"
            DataGridViewTrackings.Columns(1).Width = 100

            DataGridViewTrackings.Columns(2).HeaderText = "RCR"
            DataGridViewTrackings.Columns(2).Name = "RCR"
            DataGridViewTrackings.Columns(2).Width = 50

            DataGridViewTrackings.Columns(3).HeaderText = "Fecha"
            DataGridViewTrackings.Columns(3).Name = "Fecha"
            DataGridViewTrackings.Columns(3).Width = 100
            '
            DataGridViewTrackings.Columns(4).HeaderText = "LocalTime"
            DataGridViewTrackings.Columns(4).Name = "LocalTime"
            DataGridViewTrackings.Columns(4).Width = 100

            DataGridViewTrackings.Columns(5).HeaderText = "Valid"
            DataGridViewTrackings.Columns(5).Name = "Valid"
            DataGridViewTrackings.Columns(5).Width = 60

            DataGridViewTrackings.Columns(6).HeaderText = "Latitud"
            DataGridViewTrackings.Columns(6).Name = "Latitud"
            DataGridViewTrackings.Columns(6).Width = 100

            DataGridViewTrackings.Columns(7).HeaderText = "N_S"
            DataGridViewTrackings.Columns(7).Name = "N_S"
            DataGridViewTrackings.Columns(7).Width = 100

            DataGridViewTrackings.Columns(8).HeaderText = "Longitud"
            DataGridViewTrackings.Columns(8).Name = "Longitud"
            DataGridViewTrackings.Columns(8).Width = 100

            DataGridViewTrackings.Columns(9).HeaderText = "E_W"
            DataGridViewTrackings.Columns(9).Name = "E_W"
            DataGridViewTrackings.Columns(9).Width = 100

            DataGridViewTrackings.Columns(10).HeaderText = "Speed"
            DataGridViewTrackings.Columns(10).Name = "Speed"
            DataGridViewTrackings.Columns(10).Width = 100

            DataGridViewTrackings.Columns(11).HeaderText = "N_Sat"
            DataGridViewTrackings.Columns(11).Name = "N_Sat"
            DataGridViewTrackings.Columns(11).Width = 100

            Me.DataGridViewTrackings.Columns("Localtime").DefaultCellStyle.Format = "t" ' Formato hora corta

        Catch ex As Exception
            MsgBox("Error inesperado mostrando datos GPS.", MsgBoxStyle.Critical, "Error")
        End Try


    End Sub


    Private Sub BotonSalvarGPS_Click(sender As Object, e As EventArgs) Handles BotonSalvarGPS.Click
        Try
            If DimeSIElLanceTieneGPS(LanceActivo) = False Then
                Dim Micon2 As New SqlClient.SqlConnection
                Dim connectionString As String = GetConnectionString()
                Micon2.ConnectionString = connectionString
                Micon2.Open()
                Dim agregar As New SqlClient.SqlCommand("insert into TRACKING values (@l, @p, @rcr, @F, @H, @V, @lati, @NS, @Longi, @EW, @Speed, @Nsat)", Micon2)
                Dim fila As DataGridViewRow = New DataGridViewRow
                For Each fila In DataGridViewTrackings.Rows
                    If fila.IsNewRow = False Then
                        agregar.Parameters.Clear()
                        agregar.Parameters.AddWithValue("@l", LanceActivo)
                        agregar.Parameters.AddWithValue("@p", Convert.ToInt32(fila.Cells("CodPosicion").Value))
                        agregar.Parameters.AddWithValue("@rcr", Convert.ToString(fila.Cells("RCR").Value))
                        agregar.Parameters.AddWithValue("@f", Convert.ToDateTime(fila.Cells("FECHA").Value))
                        agregar.Parameters.AddWithValue("@h", Convert.ToDateTime(fila.Cells("localtime").Value))
                        agregar.Parameters.AddWithValue("@v", Convert.ToString(fila.Cells("valid").Value))
                        agregar.Parameters.AddWithValue("@lati", Convert.ToDouble(fila.Cells("latitud").Value))
                        agregar.Parameters.AddWithValue("@NS", Convert.ToString(fila.Cells("N_S").Value))
                        agregar.Parameters.AddWithValue("@longi", Convert.ToDouble(fila.Cells("Longitud").Value))
                        agregar.Parameters.AddWithValue("@EW", Convert.ToString(fila.Cells("E_W").Value))
                        agregar.Parameters.AddWithValue("@speed", Convert.ToDouble(fila.Cells("Speed").Value))
                        agregar.Parameters.AddWithValue("@nsat", Convert.ToInt32(fila.Cells("N_sat").Value))

                        agregar.ExecuteNonQuery()
                    End If
                Next
                MsgBox("Datos añadidos correctamente la tabla de TRACKINGS.", MsgBoxStyle.Information)
                Micon2.Close()
            Else
                MsgBox("Ya existen datos GPS para este lance.", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox("Error inesperado salvando datos GPS.", MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub BotonExportaGPSaExCEL_Click(sender As Object, e As EventArgs) Handles BotonExportaGPSaExCEL.Click
        Try
            If DimeSIElLanceTieneGPS(LanceActivo) Then
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
                    Dim columnsCount As Integer = DataGridViewTrackings.Columns.Count
                    Me.Cursor = Cursors.WaitCursor
                    For i As Integer = 0 To DataGridViewTrackings.Rows.Count - 2
                        For j As Integer = 0 To DataGridViewTrackings.Columns.Count - 1
                            If i = 0 Then 'pintamos cabecera
                                hoja_trabajo.Cells(i + 1, j + 1) = DataGridViewTrackings.Columns(j).HeaderText
                            Else 'pintamos datos
                                hoja_trabajo.Cells(i + 1, j + 1) = DataGridViewTrackings.Rows(i).Cells(j).Value.ToString()
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