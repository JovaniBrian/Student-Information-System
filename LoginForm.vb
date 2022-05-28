Imports System.Data.SqlClient
Imports System.IO

Public Class LoginForm
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

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer2.Enabled = True
        Timer1.Start()
        Label6.Text = DateTime.Now.ToLongDateString()
        Label5.Text = DateTime.Now.ToLongTimeString()
    End Sub

        Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
            Me.Opacity = Me.Opacity + 0.1
            If Me.Opacity >= 1 Then
                Timer2.Enabled = True
                Me.Opacity = 1
            End If
        End Sub

        Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
            Label5.Text = DateTime.Now.ToLongTimeString()
            Timer1.Start()
        End Sub

        Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
            Me.Opacity = Me.Opacity - 0.1
            If Me.Opacity < 0.1 Then
                Timer3.Enabled = False
            End If
        End Sub

        Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
            conn.Open()
        Try
            Dim command As New SqlCommand("Select * from userTbl where username ='" & txtusername.Text & "'and password = '" & txtpassword.Text & "' ", conn)
            Dim table As New DataTable()
            Dim adapter As New SqlDataAdapter(command)
            adapter.Fill(table)
            Dim img() As Byte
            img = table.Rows(0)(9)
            Dim ms As New MemoryStream(img)
            If table.Rows(0).Item("acctype") = "Admin" Then
                MessageBox.Show("Welcome Admin!!")
                Me.Hide()
                AdminForm.Show()
                txtusername.Text = "Type your Username..."
                txtpassword.Text = "Password..."
                txtusername.ForeColor = Color.Gray
                txtpassword.ForeColor = Color.Gray
                txtpassword.UseSystemPasswordChar = True
                CheckBox1.Checked = False
                HomeAdmin.MdiParent = AdminForm
                HomeAdmin.Show()
                If table.Rows.Count > 0 Then
                    AdminForm.Label7.Text = table.Rows(0).Item("firstname") + " " + table.Rows(0).Item("lastname")
                    AdminForm.PictureBox3.Image = Image.FromStream(ms)
                    ViewProfileAdmin.txtuserid.Text = table.Rows(0).Item("userid")
                    ViewProfileAdmin.txtlastname.Text = table.Rows(0).Item("lastname")
                    ViewProfileAdmin.txtmiddlename.Text = table.Rows(0).Item("middlename")
                    ViewProfileAdmin.txtfirstname.Text = table.Rows(0).Item("firstname")
                    ViewProfileAdmin.txtcontactno.Text = table.Rows(0).Item("contactno")
                    ViewProfileAdmin.txtusernamesignup.Text = table.Rows(0).Item("username")
                    ViewProfileAdmin.txtpasswordsignup.Text = table.Rows(0).Item("password")
                    ViewProfileAdmin.txtpasswordrtp.Text = table.Rows(0).Item("passwordrtp")
                    ViewProfileAdmin.cbsecretquestion.Text = table.Rows(0).Item("secretquestion")
                    ViewProfileAdmin.txtsecretanswer.Text = table.Rows(0).Item("secretanswer")
                    ViewProfileAdmin.pbpicture.Image = Image.FromStream(ms)
                End If
            ElseIf table.Rows(0).Item("acctype") = "Registrar" Then
                MessageBox.Show("Welcome Registrar!!")
                Me.Hide()
                MainForm.Show()
                txtusername.Text = "Type your Username..."
                txtpassword.Text = "Password..."
                txtusername.ForeColor = Color.Gray
                txtpassword.ForeColor = Color.Gray
                txtpassword.UseSystemPasswordChar = True
                CheckBox1.Checked = False
                Home.MdiParent = MainForm
                Home.Show()
                If table.Rows.Count > 0 Then
                    MainForm.Label7.Text = table.Rows(0).Item("firstname") + " " + table.Rows(0).Item("lastname")
                    MainForm.PictureBox3.Image = Image.FromStream(ms)
                    ViewProfile.txtuserid.Text = table.Rows(0).Item("userid")
                    ViewProfile.txtlastname.Text = table.Rows(0).Item("lastname")
                    ViewProfile.txtmiddlename.Text = table.Rows(0).Item("middlename")
                    ViewProfile.txtfirstname.Text = table.Rows(0).Item("firstname")
                    ViewProfile.txtcontactno.Text = table.Rows(0).Item("contactno")
                    ViewProfile.txtusernamesignup.Text = table.Rows(0).Item("username")
                    ViewProfile.txtpasswordsignup.Text = table.Rows(0).Item("password")
                    ViewProfile.txtpasswordrtp.Text = table.Rows(0).Item("passwordrtp")
                    ViewProfile.cbsecretquestion.Text = table.Rows(0).Item("secretquestion")
                    ViewProfile.txtsecretanswer.Text = table.Rows(0).Item("secretanswer")
                    ViewProfile.pbpicture.Image = Image.FromStream(ms)
                End If
            End If
        Catch ex As IndexOutOfRangeException
            Trace.WriteLine(ex.ToString)
            MsgBox("Incorrect Username or Password", MsgBoxStyle.Information, "Incorrect")
        End Try
        conn.Close()
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
    Private Sub txtpassword_Enter(sender As Object, e As EventArgs) Handles txtpassword.Enter
        If (txtpassword.Text = "Password...") Then
            txtpassword.Text = ""
            txtpassword.ForeColor = Color.Black
        End If
    End Sub
    Private Sub txtpassword_Leave(sender As Object, e As EventArgs) Handles txtpassword.Leave
        If (txtpassword.Text = "") Then
            txtpassword.Text = "Password..."
            txtpassword.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub llforgotpassword_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llforgotpassword.LinkClicked
        Me.Hide()
        ForgotPassword.Show()
        txtusername.Text = "Type your Username..."
        txtpassword.Text = "Password..."
        txtusername.ForeColor = Color.Gray
        txtpassword.ForeColor = Color.Gray
        txtpassword.UseSystemPasswordChar = True
        CheckBox1.Checked = False
    End Sub

    Private Sub txtusername_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtusername.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsLetterOrDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub

    Private Sub txtpassword_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtpassword.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsLetterOrDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub

    Private Sub llabout_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llabout.LinkClicked
        Me.Hide()
        About.Show()
        txtusername.Text = "Type your Username..."
        txtpassword.Text = "Password..."
        txtusername.ForeColor = Color.Gray
        txtpassword.ForeColor = Color.Gray
        txtpassword.UseSystemPasswordChar = True
        CheckBox1.Checked = False
    End Sub

    Private Sub btnminimize_Click(sender As Object, e As EventArgs) Handles btnminimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        If MessageBox.Show("Are you Sure you want to Close the System?", "Exit", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = False Then
            txtpassword.UseSystemPasswordChar = True
        Else
            txtpassword.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        If MessageBox.Show("Are you Sure you want to Close the System?", "Exit", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            End
        End If
    End Sub
End Class
