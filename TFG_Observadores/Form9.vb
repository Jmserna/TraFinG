Public Class Form9

    
    Private Sub BotonBuscaLances_Click(sender As Object, e As EventArgs) Handles BotonBuscaLances.Click
        Try
            Dim ponerAND As Boolean = False
            Dim CMD As New SqlClient.SqlCommand
            Dim SQL As String

            SQL = "SELECT distinct Lances.TL_CodLance, TL_nulo, TL_Codbarco, TB_Nombrebuque, Tl_fechalance, TA_Descripcion FROM (Buques INNER JOIN (Artes INNER JOIN Lances ON Artes.TA_CodArte = Lances.TL_TipoArte) ON Buques.TB_CodBuque = Lances.TL_CodBarco) INNER JOIN (Especies INNER JOIN Faunistica ON Especies.TE_CodEspecie = Faunistica.TF_CodEspecie) ON Lances.TL_CodLance = Faunistica.TF_CodLance where "

            If Not String.IsNullOrEmpty(TextBoxBarco.Text) Then
                SQL = SQL + " TB_nombrebuque like '%" + TextBoxBarco.Text + "%'"
                ponerAND = True
            End If

            If Not String.IsNullOrEmpty(ComboBoxNulo.Text) Then
                If ponerAND = True Then
                    SQL = SQL + " AND " + " TL_Nulo = '" + ComboBoxNulo.Text + "'"
                Else
                    SQL = SQL + " TL_Nulo = '" + ComboBoxNulo.Text + "'"
                End If
                ponerAND = True
            End If

            If Not String.IsNullOrEmpty(TextBoxEspecie.Text) Then
                If ponerAND = True Then
                    SQL = SQL + " AND " + " Te_Nomcientifico like '%" + TextBoxEspecie.Text + "%'"
                Else
                    SQL = SQL + " Te_Nomcientifico like '%" + TextBoxEspecie.Text + "%'"
                End If
                ponerAND = True
            End If

            If Not String.IsNullOrEmpty(TextBoxArte.Text) Then
                If ponerAND = True Then
                    SQL = SQL + " AND " + " Ta_descripcion like '%" + TextBoxArte.Text + "%'"
                Else
                    SQL = SQL + " Ta_descripcion like '%" + TextBoxArte.Text + "%'"
                End If
                ponerAND = True
            End If

            If Not String.IsNullOrEmpty(MaskedTextBoxFecha.Text) And MaskedTextBoxFecha.Text <> "    /  /" Then
                If ponerAND = True Then
                    SQL = SQL + " AND " + " TL_FechaLance = '" + MaskedTextBoxFecha.Text + "'"
                Else
                    SQL = SQL + " TL_FechaLance = '" + MaskedTextBoxFecha.Text + "'"
                End If
                ponerAND = True
            End If


            '--------------------------
            If ponerAND = True Then ' significa que algun criterio se ha metido
                Dim Micon22 As New SqlClient.SqlConnection
                Dim connectionString As String = GetConnectionString()
                Micon22.ConnectionString = connectionString
                Micon22.Open()
                Dim CMDX As New SqlClient.SqlCommand
                CMDX.Connection = Micon22
                CMDX.CommandText = SQL

                MsgBox(SQL)
                Dim miDataReader As SqlClient.SqlDataReader
                miDataReader = CMDX.ExecuteReader
                If miDataReader.HasRows Then
                    Dim dt As New DataTable
                    dt.Load(miDataReader)
                    DataGridView1.DataSource = dt
                    FormateaDGVBusqueda()
                    dt.Dispose()
                Else
                    MsgBox("No se ha encontrado nada.", vbOKOnly)
                End If
                Micon22.Close()
                miDataReader.Close()
            End If

        Catch ex As Exception
            MsgBox("Error inesperado ejecutando consulta.", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub FormateaDGVBusqueda()
        Try
            Me.DataGridView1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular)

            DataGridView1.Columns(0).HeaderText = "CodLance"
            DataGridView1.Columns(0).Width = 100

            DataGridView1.Columns(1).HeaderText = "Nulo"
            DataGridView1.Columns(1).Width = 100

            DataGridView1.Columns(2).HeaderText = "CodBarco"
            DataGridView1.Columns(2).Width = 100

            DataGridView1.Columns(3).HeaderText = "Buque"
            DataGridView1.Columns(3).Width = 200

            DataGridView1.Columns(4).HeaderText = "Fecha"
            DataGridView1.Columns(4).Width = 100

            DataGridView1.Columns(5).HeaderText = "Descripcion"
            DataGridView1.Columns(5).Width = 300
        Catch ex As Exception
            MsgBox("Error inesperado.", MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub BotonLimpiaCamposBusqueda_Click(sender As Object, e As EventArgs) Handles BotonLimpiaCamposBusqueda.Click
        Try
            TextBoxArte.Text = Nothing
            TextBoxBarco.Text = Nothing
            TextBoxEspecie.Text = Nothing
            ComboBoxNulo.SelectedItem = Nothing
            MaskedTextBoxFecha.Text = Nothing
            DataGridView1.DataSource = Nothing
        Catch ex As Exception
            MsgBox("Error inesperado limpiando campos del formulario.", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class