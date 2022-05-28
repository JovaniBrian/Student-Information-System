Public Class AdminForm

    Private Sub AdminForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        If MessageBox.Show("Are you Sure you want to Close the System?", "Exit", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub btnminimize_Click(sender As Object, e As EventArgs) Handles btnminimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        If MessageBox.Show("Are You Sure You want to Logout?", "Logout", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
            LoginForm.Show()
        End If
    End Sub

    Private Sub btnhome_Click(sender As Object, e As EventArgs) Handles btnhome.Click
        HomeAdmin.Show()
        HomeAdmin.MdiParent = Me
        SearchUser.Close()
        UserForm.Close()
        ViewProfileAdmin.Hide()
        ViewProfile.CheckBox2.Checked = False
        ViewProfile.CheckBox3.Checked = False
        StudentRecoveryDelete.Close()
        StudentDeleteForm.Close()
        StudentRecoveryForm.Close()
    End Sub

    Private Sub btnsearchuser_Click(sender As Object, e As EventArgs) Handles btnsearchuser.Click
        SearchUser.Show()
        SearchUser.MdiParent = Me
        UserForm.Close()
        HomeAdmin.Close()
        ViewProfileAdmin.Hide()
        ViewProfile.CheckBox2.Checked = False
        ViewProfile.CheckBox3.Checked = False
        StudentRecoveryDelete.Close()
        StudentDeleteForm.Close()
        StudentRecoveryForm.Close()
    End Sub

    Private Sub btnuser_Click(sender As Object, e As EventArgs) Handles btnuser.Click
        UserForm.Close()
        UserForm.Show()
        UserForm.MdiParent = Me
        HomeAdmin.Close()
        SearchUser.Close()
        ViewProfileAdmin.Hide()
        ViewProfile.CheckBox2.Checked = False
        ViewProfile.CheckBox3.Checked = False
        StudentRecoveryDelete.Close()
        StudentDeleteForm.Close()
        StudentRecoveryForm.Close()
    End Sub

    Private Sub llviewprofile_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llviewprofile.LinkClicked
        ViewProfileAdmin.Show()
        ViewProfileAdmin.MdiParent = Me
        HomeAdmin.Close()
        SearchUser.Close()
        UserForm.Close()
        StudentRecoveryDelete.Close()
        StudentDeleteForm.Close()
        StudentRecoveryForm.Close()
    End Sub

    Private Sub btndeleterecover_Click(sender As Object, e As EventArgs) Handles btndeleterecover.Click
        StudentRecoveryDelete.Show()
        StudentRecoveryDelete.MdiParent = Me
        HomeAdmin.Close()
        SearchUser.Close()
        UserForm.Close()
        ViewProfileAdmin.Hide()
        ViewProfile.CheckBox2.Checked = False
        ViewProfile.CheckBox3.Checked = False
        StudentDeleteForm.Close()
        StudentRecoveryForm.Close()
    End Sub
End Class