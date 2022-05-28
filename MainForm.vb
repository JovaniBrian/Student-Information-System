Imports System.Data.SqlClient
Imports System.IO
Public Class MainForm
    Dim conn As New SqlConnection("Server=LENOVO-PC\SQLEXPRESS;Database=SIS;Integrated Security=true")
    Dim cmd As New SqlCommand
    Dim dt As New System.Data.DataTable

    Public Sub ExecuteQuery(query As String)
        Dim command As New SqlCommand(query, conn)
        conn.Open()
        command.ExecuteNonQuery()
        conn.Close()
    End Sub
    Private Sub ExecuteQuery(command As SqlCommand, p2 As String)
        conn.Open()
        If command.ExecuteNonQuery = 1 Then
            MessageBox.Show(p2)
        Else
            MessageBox.Show("Query Not Executed")
            End
        End If
        conn.Close()
    End Sub
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       
    End Sub


    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        If MessageBox.Show("Are you Sure you want to Close the System?", "Exit", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub btnminimize_Click(sender As Object, e As EventArgs) Handles btnminimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnhome_Click(sender As Object, e As EventArgs) Handles btnhome.Click
        Home.MdiParent = Me
        Home.Show()
        ViewProfile.Hide()
        ViewProfile.CheckBox2.Checked = False
        ViewProfile.CheckBox3.Checked = False
        StudentInformationAndRecord.Close()
        SearchStudentInformation.Close()
    End Sub

    Private Sub btnsearchstudent_Click(sender As Object, e As EventArgs) Handles btnsearchstudent.Click
        SearchStudentInformation.Show()
        SearchStudentInformation.MdiParent = Me
        ViewProfile.Hide()
        ViewProfile.CheckBox2.Checked = False
        ViewProfile.CheckBox3.Checked = False
        StudentInformationAndRecord.Close()
    End Sub

    Private Sub btnstudentinfo_Click(sender As Object, e As EventArgs) Handles btnstudentinfo.Click
        StudentInformationAndRecord.Close()
        StudentInformationAndRecord.MdiParent = Me
        StudentInformationAndRecord.Show()
        ViewProfile.Hide()
        ViewProfile.CheckBox2.Checked = False
        ViewProfile.CheckBox3.Checked = False
        Home.Close()
        SearchStudentInformation.Close()
    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        If MessageBox.Show("Are You Sure You want to Logout?", "Logout", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
            LoginForm.Show()
        End If
    End Sub

    Private Sub llviewprofile_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llviewprofile.LinkClicked
        ViewProfile.MdiParent = Me
        ViewProfile.Show()
        Home.Close()
        StudentInformationAndRecord.Close()
        SearchStudentInformation.Close()
    End Sub
End Class