Module Module1
    Public IDObservador As Integer
    Public MiConexion As String
    Public LanceActivo As Integer

    Public Function GetConnectionString() As String
        Return "Data Source=MIGALA;Initial Catalog=BDpescamed;Integrated Security=True"
    End Function

    Public Function ExisteLanceEnTallas(cl As Integer) As Boolean
        'Función F01ELT
        Try
            Dim Micon2 As New SqlClient.SqlConnection
            Dim connectionString As String = GetConnectionString()
            Micon2.ConnectionString = connectionString
            Micon2.Open()
            Dim Cri As String
            Cri = "select TT_codlance from tallas where Tt_codlance=" & cl
            Dim daX As New SqlClient.SqlDataAdapter(Cri, Micon2)
            Dim datTa As New DataTable
            daX.Fill(datTa)
            If datTa.Rows.Count > 0 Then
                ExisteLanceEnTallas = True
            Else
                ExisteLanceEnTallas = False
            End If
            daX.Dispose()
            datTa.Dispose()
            Micon2.Close()

        Catch ex As Exception
            MsgBox("Error inesperado en función F01ELT de module.vb", MsgBoxStyle.Critical, "Error")
            Return Nothing
        End Try

    End Function
   

    Public Function Dime_PesoTotal_del_Lance(cl As Integer) As Double
        'calcula el peso total de las especies comerciales del lance
        'Función F02DPTL
        Try
            If (DimeSIElLanceEXISTE(cl) = True And Dime_SIel_lance_tiene_pesoComercial(cl) = True) Then
                Dim Micon2 As New SqlClient.SqlConnection
                Dim connectionString As String = GetConnectionString()
                Micon2.ConnectionString = connectionString
                Micon2.Open()
                Dim cmd As New SqlClient.SqlCommand
                cmd.Connection = Micon2
                cmd.Parameters.AddWithValue("@codl", cl.ToString)
                cmd.CommandText = "select sum (TF_pesototal) from faunistica where tf_codlance=@codl and tf_fraccion='C'"
                Dime_PesoTotal_del_Lance = cmd.ExecuteScalar
                Micon2.Close()
            Else
                Dime_PesoTotal_del_Lance = 0
            End If
        Catch ex As Exception
            MsgBox("Error inesperado en función F02DPTL de module.vb", MsgBoxStyle.Critical, "Error")
            Return Nothing
        End Try
    End Function

    Public Function Dime_PesoTotal_dela_Muestra(cl As Integer) As Double
        'calcula el peso total de las especies descartadas del lance
        'Función F03DPTM
        Try
            If (DimeSIElLanceEXISTE(cl) = True And Dime_SIel_lance_tiene_pesoDescartado(cl) = True) Then
                Dim Micon2 As New SqlClient.SqlConnection
                Dim connectionString As String = GetConnectionString()
                Micon2.ConnectionString = connectionString
                Micon2.Open()
                Dim cmd As New SqlClient.SqlCommand
                cmd.Connection = Micon2
                cmd.Parameters.AddWithValue("@codl", cl.ToString)
                cmd.CommandText = "select sum (TF_pesomuestreado) from faunistica where tf_codlance=@codl and tf_fraccion='D'"
                Dime_PesoTotal_dela_Muestra = cmd.ExecuteScalar
                Micon2.Close()
            Else
                Dime_PesoTotal_dela_Muestra = 0
            End If
        Catch ex As Exception
            MsgBox("Error inesperado en función F03DPTM de module.vb", MsgBoxStyle.Critical, "Error")
            Return Nothing
        End Try
    End Function

    Public Function DimePrimerLance() As Integer
        Try
            Dim Micon2 As New SqlClient.SqlConnection
            Dim connectionString As String = GetConnectionString()
            Micon2.ConnectionString = connectionString
            Micon2.Open()
            Dim cmd As New SqlClient.SqlCommand
            cmd.Connection = Micon2
            cmd.CommandText = "select TL_codlance from Lances order by tl_codlance"
            DimePrimerLance = cmd.ExecuteScalar
            Micon2.Close()
        Catch ex As Exception
            MsgBox("Error inesperado obteniendo el primer lance de la base de datos", MsgBoxStyle.Critical, "Error")
            Return Nothing
        End Try
    End Function
    Public Function DimeSIElLanceTieneCTD(cl As Integer) As Boolean
        'Funcion F04DSLTCTD
        Try

            Dim Micon2 As New SqlClient.SqlConnection
            Dim connectionString As String = GetConnectionString()
            Micon2.ConnectionString = connectionString
            Micon2.Open()
            Dim Cri As String
            Cri = "select TC_codlance from CTD where TC_codlance=" & cl
            Dim daX As New SqlClient.SqlDataAdapter(Cri, Micon2)
            Dim datTa As New DataTable
            daX.Fill(datTa)
            If datTa.Rows.Count > 0 Then
                DimeSIElLanceTieneCTD = True
            Else
                DimeSIElLanceTieneCTD = False
            End If
            daX.Dispose()
            datTa.Dispose()
            Micon2.Close()
        Catch ex As Exception
            MsgBox("Error inesperado en función F04DSLTCTD de module.vb", MsgBoxStyle.Critical, "Error")
            Return Nothing
        End Try
    End Function

    Public Function Dime_SIel_lance_tiene_pesoComercial(cl As Integer) As Boolean
        'F08DSELTPC
        Try
            Dim Micon22 As New SqlClient.SqlConnection
            Dim connectionString As String = GetConnectionString()
            Micon22.ConnectionString = connectionString
            Micon22.Open()
            Dim Criteria As String
            Criteria = "select TF_codlance, TF_Codespecie, Tf_fraccion from FAUNISTICA where TF_Fraccion='C' and Tf_pesoTotal <>0 and TF_Codlance=" & cl
            Dim DataADaX As New SqlClient.SqlDataAdapter(Criteria, Micon22)
            Dim MidatTa As New DataTable
            DataADaX.Fill(MidatTa)
            If MidatTa.Rows.Count > 0 Then
                Dime_SIel_lance_tiene_pesoComercial = True
            Else
                Dime_SIel_lance_tiene_pesoComercial = False
            End If
            DataADaX.Dispose()
            MidatTa.Dispose()
            Micon22.Close()
        Catch ex As Exception
            MsgBox("Error inesperado en función F08DSELTPC de module.vb", MsgBoxStyle.Critical, "Error")
            Return Nothing
        End Try
    End Function
    Public Function Dime_SIel_lance_tiene_EspeciesEnFAunistica(cl As Integer) As Boolean
        'F10DSELTEEF
        Try
            Dim Micon22 As New SqlClient.SqlConnection
            Dim connectionString As String = GetConnectionString()
            Micon22.ConnectionString = connectionString
            Micon22.Open()
            Dim Criteria As String
            Criteria = "select TF_codlance, TF_Codespecie, Tf_fraccion from FAUNISTICA where TF_Codlance=" & cl
            Dim DataADaX As New SqlClient.SqlDataAdapter(Criteria, Micon22)
            Dim MidatTa As New DataTable
            DataADaX.Fill(MidatTa)
            If MidatTa.Rows.Count > 0 Then
                Dime_SIel_lance_tiene_EspeciesEnFAunistica = True
            Else
                Dime_SIel_lance_tiene_EspeciesEnFAunistica = False
            End If
            DataADaX.Dispose()
            MidatTa.Dispose()
            Micon22.Close()
        Catch ex As Exception
            MsgBox("Error inesperado en función F10DSELTEEF de module.vb", MsgBoxStyle.Critical, "Error")
            Return Nothing
        End Try
    End Function
    Public Function Dime_SIel_lance_tiene_pesoDescartado(cl As Integer) As Boolean
        'F09DSELTPD
        Try
            Dim Micon22 As New SqlClient.SqlConnection
            Dim connectionString As String = GetConnectionString()
            Micon22.ConnectionString = connectionString
            Micon22.Open()
            Dim Criteria As String
            Criteria = "select TF_codlance, TF_Codespecie, Tf_fraccion from FAUNISTICA where TF_Fraccion='D' and Tf_pesoMuestreado <>0 and TF_Codlance=" & cl
            Dim DataADaX As New SqlClient.SqlDataAdapter(Criteria, Micon22)
            Dim MidatTa As New DataTable
            DataADaX.Fill(MidatTa)
            If MidatTa.Rows.Count > 0 Then
                Dime_SIel_lance_tiene_pesoDescartado = True
            Else
                Dime_SIel_lance_tiene_pesoDescartado = False
            End If
            DataADaX.Dispose()
            MidatTa.Dispose()
            Micon22.Close()
        Catch ex As Exception
            MsgBox("Error inesperado en función F09DSELTPD de module.vb", MsgBoxStyle.Critical, "Error")
            Return Nothing
        End Try
    End Function

    Public Function DimeSIElLanceEXISTE(cl As Integer) As Boolean
        'Función F05DSELE
        Try
            Dim Micon22 As New SqlClient.SqlConnection
            Dim connectionString As String = GetConnectionString()
            Micon22.ConnectionString = connectionString
            Micon22.Open()
            Dim Criteria As String
            Criteria = "select TL_codlance from LANCES where TL_codlance=" & cl
            Dim DataADaX As New SqlClient.SqlDataAdapter(Criteria, Micon22)
            Dim MidatTa As New DataTable
            DataADaX.Fill(MidatTa)
            If MidatTa.Rows.Count > 0 Then
                DimeSIElLanceEXISTE = True
            Else
                DimeSIElLanceEXISTE = False
            End If
            DataADaX.Dispose()
            MidatTa.Dispose()
            Micon22.Close()
        Catch ex As Exception
            MsgBox("Error inesperado en función F05DSELE de module.vb", MsgBoxStyle.Critical, "Error")
            Return Nothing
        End Try
    End Function

    Public Function DimeNomCientificodelaEspecie(cspp As Integer) As String
        Try
            Dim Micon2 As New SqlClient.SqlConnection
            Dim connectionString As String = GetConnectionString()
            Micon2.ConnectionString = connectionString
            Micon2.Open()
            Dim cmd As New SqlClient.SqlCommand
            cmd.Connection = Micon2
            cmd.CommandText = "select Te_nomcientifico from especies where te_codespecie=" & cspp
            DimeNomCientificodelaEspecie = cmd.ExecuteScalar
            Micon2.Close()
        Catch ex As Exception
            MsgBox("Error inesperado en función obteniendo nombre científico de la especie", MsgBoxStyle.Critical, "Error")
            Return Nothing
        End Try
    End Function


    Public Function DimeSIElLanceTieneGPS(cl As Integer) As Boolean
        'Función F07DSELTGPS
        Try
            Dim Micon2 As New SqlClient.SqlConnection
            Dim connectionString As String = GetConnectionString()
            Micon2.ConnectionString = connectionString
            Micon2.Open()
            Dim Cri As String
            Cri = "select TT_codlance from tracking where TT_codlance=" & cl
            Dim daX As New SqlClient.SqlDataAdapter(Cri, Micon2)
            Dim datTa As New DataTable
            daX.Fill(datTa)
            If datTa.Rows.Count > 0 Then
                DimeSIElLanceTieneGPS = True
            Else
                DimeSIElLanceTieneGPS = False
            End If
            daX.Dispose()
            datTa.Dispose()
            Micon2.Close()
        Catch ex As Exception
            MsgBox("Error inesperado en función F07DSELTGPS de module.vb", MsgBoxStyle.Critical, "Error")
            Return Nothing
        End Try
    End Function


End Module
