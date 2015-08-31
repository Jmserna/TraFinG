Imports System.Windows.Forms.DataVisualization.Charting
Public Class Form8
    Public ConexionGraph As New SqlClient.SqlConnection
    Public temporal As String
    Public chartAreasCreada As Integer


    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            LanceActivoGraficos.Text = LanceActivo
            temporal = LanceActivo
            Fill_LV1()
            ListView1.Items(0).Selected = True
            EspecieGraficosTextBox.Text = ListView1.SelectedItems(0).SubItems(0).Text
            FraccionGraficosTextBox.Text = ListView1.SelectedItems(0).SubItems(2).Text
            ListView1.Focus()
            ListView1.Items(0).Selected = True
            chartAreasCreada = 0
        Catch ex As Exception
            MsgBox("Error abriendo formulario de gráficos.", MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Public Sub Fill_LV1()
        Try
            Dim connectionString As String = GetConnectionString()
            ConexionGraph.ConnectionString = connectionString
            ConexionGraph.Open()
            Dim CMD As New SqlClient.SqlCommand
            CMD.Connection = ConexionGraph
            CMD.CommandText = "select distinct tt_codespecie, te_nomcientifico, tt_fraccion from especies, tallas where te_codespecie=tt_codespecie and Tt_codlance='" + LanceActivoGraficos.Text + "' order by te_nomcientifico, tt_fraccion"

            Dim miDataReader As SqlClient.SqlDataReader
            miDataReader = CMD.ExecuteReader
            ListView1.View = View.Details
            With ListView1
                .Items.Clear()
                .Columns.Clear()
                .Columns.Add("Cod", 60, HorizontalAlignment.Left)
                .Columns.Add("Especie", 250, HorizontalAlignment.Left)
                .Columns.Add("Fracción", 80, HorizontalAlignment.Left)
                .GridLines = True
            End With

            While miDataReader.Read
                Dim LI As ListViewItem = ListView1.Items.Add(miDataReader("tt_codespecie").ToString())
                LI.SubItems.Add(miDataReader("Te_nomCientifico").ToString())
                LI.SubItems.Add(miDataReader("Tt_fraccion").ToString())
            End While

            ConexionGraph.Close()
            miDataReader.Close()

        Catch ex As Exception
            MsgBox("Error inesperado cargando lista de especies con talla.", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub BotonCambiaLanceGraficos_Click(sender As Object, e As EventArgs) Handles BotonCambiaLanceGraficos.Click
        Try
            Dim ExisteLance As Boolean
            ExisteLance = ExisteLanceEnTallas(CInt(LanceActivoGraficos.Text))
            If ExisteLance = True Then
                Fill_LV1()
                ListView1.Focus()
                ListView1.Items(0).Selected = True
                EspecieGraficosTextBox.Text = ListView1.SelectedItems(0).SubItems(0).Text
                FraccionGraficosTextBox.Text = ListView1.SelectedItems(0).SubItems(2).Text
                ListView1.Items(0).Selected = True

                'Limpia DataGridView
                If DataGridView1.RowCount >= 1 Then
                    For i As Integer = 0 To DataGridView1.RowCount - 2
                        DataGridView1.Rows.Remove(DataGridView1.CurrentRow)
                    Next
                End If

            Else
                MsgBox("Lance inexistente o Lance sin tallas.", vbInformation)
                LanceActivoGraficos.Text = temporal
                LanceActivoGraficos.Focus()
            End If
        Catch ex As Exception
            MsgBox("Error inesperado cambiando de lance.", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub LanceActivoGraficos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles LanceActivoGraficos.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub ListView1_Click_1(sender As Object, e As EventArgs) Handles ListView1.Click
        EspecieGraficosTextBox.Text = ListView1.SelectedItems(0).SubItems(0).Text
        FraccionGraficosTextBox.Text = ListView1.SelectedItems(0).SubItems(2).Text

    End Sub

    Private Sub LanceActivoGraficos_Enter(sender As Object, e As EventArgs) Handles LanceActivoGraficos.Enter
        temporal = LanceActivoGraficos.Text
    End Sub


    Private Sub BotonPintaGrafico_Click(sender As Object, e As EventArgs) Handles BotonPintaGrafico.Click
        Try
            Dim MiconGraph As New SqlClient.SqlConnection
            Dim connectionString As String = GetConnectionString()
            MiconGraph.ConnectionString = connectionString
            MiconGraph.Open()
            Dim Cri442 As String
            Cri442 = "select tt_talla, tt_numejemplares from Tallas where TT_codlance =" & LanceActivoGraficos.Text & " and tt_codespecie=" & EspecieGraficosTextBox.Text & " and tt_fraccion='" & FraccionGraficosTextBox.Text & "'"
            Dim daGraph As New SqlClient.SqlDataAdapter(Cri442, MiconGraph)
            Dim dataTableGraph As New DataTable
            daGraph.Fill(dataTableGraph)
            DataGridView1.DataSource = dataTableGraph
            Chart1.DataSource = dataTableGraph
            If chartAreasCreada = 0 Then ' primer gráfico que se crea
                Chart1.ChartAreas.Add("ChartAreas1")
                Dim Series1 As Series = Chart1.Series("Series1")
                Series1.Name = "Series1"
                Chart1.Series(Series1.Name).XValueMember = "tt_talla"
                Chart1.Series(Series1.Name).YValueMembers = "tt_numejemplares"
                chartAreasCreada = 1
                DataGridView1.Columns(0).HeaderText = "Talla"
                DataGridView1.Columns(1).HeaderText = "Nº"
            Else
                Chart1.Series(0).Points.Clear()
            End If
            Chart1.ChartAreas(0).AxisX.Title = "Talla - " & DimeNomCientificodelaEspecie(EspecieGraficosTextBox.Text)
            Chart1.ChartAreas(0).AxisY.Title = "Nº de Individuos"


            Chart1.Show()
            daGraph.Dispose()
            dataTableGraph.Dispose()
            MiconGraph.Close()

        Catch ex As Exception
            MsgBox("Error inesperado generando gráfico.", MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub BotonExportarGraficoABmp_Click(sender As Object, e As EventArgs) Handles BotonExportarGraficoABmp.Click
        Try
            Dim fichero As New SaveFileDialog()
            fichero.Filter = "Bitmap (*.bmp)|*.bmp"
            If fichero.ShowDialog() = DialogResult.OK Then
                ControlBmpToFile(Chart1, fichero.FileName)
            End If
        Catch ex As Exception
            MsgBox("Error inesperado exportando gráfico.", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Public Sub ControlBmpToFile(control As Control, file As String)
        Dim bmp As New Bitmap(control.Width, control.Height)
        control.DrawToBitmap(bmp, control.DisplayRectangle)
        bmp.Save(file, System.Drawing.Imaging.ImageFormat.Jpeg)
    End Sub

    
End Class