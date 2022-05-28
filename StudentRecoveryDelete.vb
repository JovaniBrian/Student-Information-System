Public Class StudentRecoveryDelete

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        StudentDeleteForm.Show()
        StudentDeleteForm.MdiParent = AdminForm
        Me.Close()
    End Sub

    Private Sub btnrecover_Click(sender As Object, e As EventArgs) Handles btnrecover.Click
        StudentRecoveryForm.Show()
        StudentRecoveryForm.MdiParent = AdminForm
        Me.Close()
    End Sub
End Class