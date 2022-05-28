Public Class Home

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
End Class