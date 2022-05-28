Imports System.Data.SqlClient
Module Module1
    Public sqlconn As New SqlConnection
    Public strsql As String
    Public sqlds As New DataSet
    Public strreportname As String
    Public Sub connectme()
        Try
            If sqlconn.State = ConnectionState.Open Then
                sqlconn.Close()
            End If
            sqlconn.ConnectionString = "Server=LENOVO-PC\SQLEXPRESS; Database=SIS; Uid=jovanibrian; Pwd=jovani123;"
            sqlconn.Open()
            If sqlconn.State = ConnectionState.Open Then
                MessageBox.Show("Information is Ready to Print")
            Else
                MessageBox.Show("You Are Not Connected!")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Module
