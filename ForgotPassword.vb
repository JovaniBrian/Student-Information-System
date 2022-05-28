Imports System.Data.SqlClient
Imports System.IO
Public Class ForgotPassword
    Dim conn As New SqlConnection("Server=LENOVO-PC\SQLEXPRESS;Database=SIS;Integrated Security=true")
    Dim cmd As New SqlCommand
    Dim dt As New System.Data.DataTable
    Dim dr As SqlDataReader

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        txtusername.Text = ""
        txtanswer.Text = ""
        lblpassword.Text = ""
        lblsecurity.Text = ""
        txtanswer.Text = "Secret Answer..."
        txtanswer.ForeColor = Color.Gray
        txtusername.Text = "Type your Username..."
        txtusername.ForeColor = Color.Gray
        btnconfirm.Enabled = False
        btncheck.Enabled = True
    End Sub

    Private Sub btncheck_Click(sender As Object, e As EventArgs) Handles btncheck.Click
        Dim sqlcon As New SqlCommand("Select * from userTbl where username='" & txtusername.Text & "'", conn)
        Dim da As New SqlDataAdapter(sqlcon)
        Dim dt As New DataTable
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            Me.lblsecurity.Text = dt.Rows(0).Item("secretquestion")
            btnconfirm.Enabled = True
        ElseIf txtusername.Text = "" Or txtusername.Text = "Type your Username..." Then
            MessageBox.Show("Username is Blank")
        Else
            MessageBox.Show("Username Does Not Exist")
        End If

    End Sub

    Private Sub btnconfirm_Click(sender As Object, e As EventArgs) Handles btnconfirm.Click
        Dim sqlcon As New SqlCommand("Select * from userTbl where secretanswer='" & txtanswer.Text & "' and username ='" & txtusername.Text & "'", conn)
        Dim da As New SqlDataAdapter(sqlcon)
        Dim dt As New DataTable
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            Me.lblpassword.Text = dt.Rows(0).Item("password")
        ElseIf txtanswer.Text = "" Or txtanswer.Text = "Secret Answer..." Then
            MessageBox.Show("Answer is Blank")
        Else
            MessageBox.Show("Your Answer is incorrect")
        End If
    End Sub

    Private Sub ForgotPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnconfirm.Enabled = False
        Timer2.Enabled = True
        Timer1.Start()
        Label8.Text = DateTime.Now.ToLongDateString()
        Label7.Text = DateTime.Now.ToLongTimeString()
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Me.Opacity = Me.Opacity + 0.1
        If Me.Opacity >= 1 Then
            Timer2.Enabled = True
            Me.Opacity = 1
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label7.Text = DateTime.Now.ToLongTimeString()
        Timer1.Start()

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Me.Opacity = Me.Opacity - 0.1
        If Me.Opacity < 0.1 Then
            Timer3.Enabled = False
        End If
    End Sub

    Private Sub btnreturn_Click(sender As Object, e As EventArgs) Handles btnreturn.Click
        txtusername.Text = ""
        txtanswer.Text = ""
        lblpassword.Text = ""
        lblsecurity.Text = ""
        btncheck.Enabled = True
        btnconfirm.Enabled = False
        btnclear.Enabled = True
        txtanswer.Text = "Secret Answer..."
        txtanswer.ForeColor = Color.Gray
        txtusername.Text = "Type your Username..."
        txtusername.ForeColor = Color.Gray
        Me.Hide()
        LoginForm.Show()
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        If MessageBox.Show("Are you Sure you want to Close the System?", "Exit", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub btnminimize_Click(sender As Object, e As EventArgs) Handles btnminimize.Click
        WindowState = FormWindowState.Minimized
    End Sub
    Private Sub txtusername_Enter(sender As Object, e As EventArgs) Handles txtusername.Enter
        If (txtusername.Text = "Type your Username...") Then
            txtusername.Text = ""
            txtusername.ForeColor = Color.Black
        End If
    End Sub
    Private Sub txtusername_Leave(sender As Object, e As EventArgs) Handles txtusername.Leave
        If (txtusername.Text = "") Then
            txtusername.Text = "Type your Username..."
            txtusername.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub txtanswer_Enter(sender As Object, e As EventArgs) Handles txtanswer.Enter
        If (txtanswer.Text = "Secret Answer...") Then
            txtanswer.Text = ""
            txtanswer.ForeColor = Color.Black
        End If
    End Sub
    Private Sub txtanswer_Leave(sender As Object, e As EventArgs) Handles txtanswer.Leave
        If (txtanswer.Text = "") Then
            txtanswer.Text = "Secret Answer..."
            txtanswer.ForeColor = Color.Gray
        End If
    End Sub
End Class