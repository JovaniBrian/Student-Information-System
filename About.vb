Public Class About

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Me.Hide()
        LoginForm.Show()
    End Sub

    Private Sub btnminimize_Click(sender As Object, e As EventArgs) Handles btnminimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        If MessageBox.Show("Are you Sure you want to Close the System?", "Exit", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub About_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class