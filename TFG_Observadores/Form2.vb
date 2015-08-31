Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonSalir_Click(sender As Object, e As EventArgs) Handles ButtonSalir.Click
        Me.Close()
    End Sub

    Private Sub ButtonLances_Click(sender As Object, e As EventArgs) Handles ButtonLances.Click
        Try
            LanceActivo = DimePrimerLance()
            If Not IsNothing(LanceActivo) Then
                Form3.Show()
            Else
                MsgBox("No existe ningún lance en la base de datos.", MsgBoxStyle.Information, "Aviso")
            End If
        Catch ex As Exception
            MsgBox("Error inesperado abriendo formulario de lances.", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub ButtonFaunistica_Click(sender As Object, e As EventArgs) Handles ButtonFaunistica.Click
        Try
            LanceActivo = DimePrimerLance()
            If Not IsNothing(LanceActivo) Then
                Form4.Show()
            Else
                MsgBox("No existe ningún lance en la base de datos.", MsgBoxStyle.Information, "Aviso")
            End If
        Catch ex As Exception
            MsgBox("Error inesperado abriendo formulario de faunística.", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub ButtonTallas_Click(sender As Object, e As EventArgs) Handles ButtonTallas.Click
        Try
            LanceActivo = DimePrimerLance()
            If Not IsNothing(LanceActivo) Then
                Form5.Show()
            Else
                MsgBox("No existe ningún lance en la base de datos.", MsgBoxStyle.Information, "Aviso")
            End If
        Catch ex As Exception
            MsgBox("Error inesperado abriendo formulario de tallas.", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub ButtonCtd_Click(sender As Object, e As EventArgs) Handles ButtonCtd.Click
        Try
            LanceActivo = DimePrimerLance()
            If Not IsNothing(LanceActivo) Then
                Form6.Show()
            Else
                MsgBox("No existe ningún lance en la base de datos.", MsgBoxStyle.Information, "Aviso")
            End If
        Catch ex As Exception
            MsgBox("Error inesperado abriendo formulario de CDT's", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub ButtonTrackings_Click(sender As Object, e As EventArgs) Handles ButtonTrackings.Click
        Try
            LanceActivo = DimePrimerLance()
            If Not IsNothing(LanceActivo) Then
                Form7.Show()
            Else
                MsgBox("No existe ningún lance en la base de datos.", MsgBoxStyle.Information, "Aviso")
            End If
        Catch ex As Exception
            MsgBox("Error inesperado abriendo formulario de Trackings.", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub ButtonGraficos_Click(sender As Object, e As EventArgs) Handles ButtonGraficos.Click
        Try
            LanceActivo = DimePrimerLance()
            If Not IsNothing(LanceActivo) Then
                Form8.Show()
            Else
                MsgBox("No existe ningún lance en la base de datos.", MsgBoxStyle.Information, "Aviso")
            End If
        Catch ex As Exception
            MsgBox("Error inesperado abriendo formulario de gráficos.", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class