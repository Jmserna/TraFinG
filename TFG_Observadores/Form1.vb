Imports System
Imports System.Security.Cryptography
Imports System.Text

Public Class Form1
    Public response As MsgBoxResult
    Public Micon As New SqlClient.SqlConnection
    
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeMyControl()
    End Sub
    Private Sub InitializeMyControl()
        ' Set to no text.
        TextBoxLogin.Text = ""
        ' The password character is an asterisk.
        TextBoxLogin.PasswordChar = "*"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Close()
    End Sub

    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        Try
            If Len(TextBoxUsuario.Text) = 0 Then
                response = MsgBox("Introduce Nombre de Usuario", MsgBoxStyle.Information, "Aviso")
                TextBoxUsuario.Focus()
            Else
                If Len(TextBoxLogin.Text) = 0 Then
                    response = MsgBox("Introduce Clave de Usuario", MsgBoxStyle.Information, "Aviso")
                    TextBoxLogin.Focus()
                Else
                    Dim Validado As Boolean
                    Validado = ValidaUsuario(TextBoxUsuario.Text, TextBoxLogin.Text)
                    If Validado = True Then
                        Form2.Show() 'Abrimos formulario 2
                        Me.Close() 'cerramos formulario de login
                    Else
                        MsgBox("Usuario no encontrado o clave errónea. Pruebe de nuevo", MsgBoxStyle.Information, "Aviso")
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Error inesperado en el proceso de login", MsgBoxStyle.Critical, "Error")
        End Try

    End Sub
    Public Function ValidaUsuario(ByVal Nombre As String, ByVal Passw As String) As Boolean
        Try
            Dim connectionString As String = GetConnectionString()
            Micon.ConnectionString = connectionString
            Micon.Open()
            Dim cmd As New SqlClient.SqlCommand
            cmd.Connection = Micon
            cmd.CommandText = "select TO_pass from Observadores where TO_nombre ='" & Nombre & "'"
            Dim x As String
            x = cmd.ExecuteScalar

            Dim md5Hash2 As MD5 = MD5.Create()
            Dim hash2 As String = GetMd5Hash(md5Hash2, TextBoxLogin.Text)
            If hash2 = x Then ' usuario validado
                cmd.CommandText = "select To_Codobservador from Observadores where To_nombre ='" & Nombre & "'"
                Dim x2 As String
                x2 = cmd.ExecuteScalar
                IDObservador = CInt(x2)
                Micon.Close()
                Return (True)
            Else
                Micon.Close()
                Return (False)
            End If

        Catch ex As Exception
            MsgBox("Error inesperado validando al usuario", MsgBoxStyle.Critical, "Error")
            Return (False)
        End Try

    End Function

    Public Function GetMd5Hash(ByVal md5Hash As MD5, ByVal input As String) As String
        Try
            ' Convert the input string to a byte array and compute the hash.
            Dim data As Byte() = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input))

            ' Create a new Stringbuilder to collect the bytes
            ' and create a string.
            Dim sBuilder As New StringBuilder()

            ' Loop through each byte of the hashed data
            ' and format each one as a hexadecimal string.
            Dim i As Integer
            For i = 0 To data.Length - 1
                sBuilder.Append(data(i).ToString("x2"))
            Next i

            ' Return the hexadecimal string.
            Return sBuilder.ToString()

        Catch ex As Exception
            MsgBox("Error inesperado obteniendo el hash de la password", MsgBoxStyle.Critical, "Error")
            Return Nothing
        End Try

    End Function 'GetMd5Hash

End Class
