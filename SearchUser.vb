Imports System.Data.SqlClient
Imports System.IO
Public Class SearchUser
    Dim conn As New SqlConnection("Server=LENOVO-PC\SQLEXPRESS;Database=SIS;Integrated Security=true")
    Dim cmd As New SqlCommand
    Dim dt As New System.Data.DataTable
    Private Sub SearchUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        showGrid()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim count As Integer
        count = DataGridView1.DataSource.Count
        lblrecordcount.Text = count.ToString
    End Sub
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
    Public Sub showGrid()
        Dim command As New SqlCommand("Select * from userTbl", conn)
        Dim imgc As New DataGridViewImageColumn
        Dim table As New DataTable
        Dim adapter As New SqlDataAdapter(command)
        adapter.Fill(table)
        DataGridView1.DataSource = table
        Dim SDA As New SqlDataAdapter
        Dim dbDataset As New DataTable
        Dim bSource As New BindingSource
        Dim query As String
        query = "Select * from userTbl"
        Dim cmd As New SqlCommand(query, conn)
        DataGridView1.AllowUserToAddRows = False
        imgc.ImageLayout = DataGridViewImageCellLayout.Stretch
        ExecuteQuery(query)
        SDA.SelectCommand = cmd
        SDA.Fill(dbDataset)
        bSource.DataSource = dbDataset
        DataGridView1.DataSource = bSource
        SDA.Update(dbDataset)
    End Sub

    Private Sub DataGridView1_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseClick
        Dim img As Byte()
        img = DataGridView1.CurrentRow.Cells(9).Value
        Dim ms As New MemoryStream(img)
        UpdateAccount.pbpicture.Image = Image.FromStream(ms)
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.DataGridView1.Rows(e.RowIndex)
            UpdateAccount.txtuserid.Text = row.Cells("userid").Value.ToString
            UpdateAccount.txtlastname.Text = row.Cells("lastname").Value.ToString
            UpdateAccount.txtmiddlename.Text = row.Cells("middlename").Value.ToString
            UpdateAccount.txtfirstname.Text = row.Cells("firstname").Value.ToString
            UpdateAccount.txtcontactno.Text = row.Cells("contactno").Value.ToString
            UpdateAccount.txtusernamesignup.Text = row.Cells("username").Value.ToString
            UpdateAccount.txtpasswordsignup.Text = row.Cells("password").Value.ToString
            UpdateAccount.txtpasswordrtp.Text = row.Cells("passwordrtp").Value.ToString
            UpdateAccount.cbaccounttype.Text = row.Cells("acctype").Value.ToString
            UpdateAccount.cbsecretquestion.Text = row.Cells("secretquestion").Value.ToString
            UpdateAccount.txtsecretanswer.Text = row.Cells("secretanswer").Value.ToString
            UpdateAccount.txtuserid.Enabled = False
            UpdateAccount.txtlastname.Enabled = False
            UpdateAccount.txtmiddlename.Enabled = False
            UpdateAccount.txtfirstname.Enabled = False
            UpdateAccount.txtcontactno.Enabled = False
            UpdateAccount.txtusernamesignup.Enabled = False
            UpdateAccount.txtpasswordsignup.Enabled = False
            UpdateAccount.txtpasswordrtp.Enabled = False
            UpdateAccount.cbaccounttype.Enabled = False
            UpdateAccount.cbsecretquestion.Enabled = False
            UpdateAccount.txtsecretanswer.Enabled = False
            btnview.Enabled = True
        End If
    End Sub
    Private Sub txtsearchbox_TextChanged(sender As Object, e As EventArgs) Handles txtsearchbox.TextChanged
        Dim searchQuery As String
        Dim SDA As New SqlDataAdapter
        Dim dbDataset As New DataTable
        Dim bSource As New BindingSource

        If cbsearch.Text = "User Id" Then
            searchQuery = "Select * from userTbl where userid Like'" & txtsearchbox.Text & "%'"

        ElseIf cbsearch.Text = "Last Name" Then
            searchQuery = "Select * from userTbl where lastname Like'" & txtsearchbox.Text & "%'"

        ElseIf cbsearch.Text = "Middle Name" Then
            searchQuery = "Select * from userTbl where middlename Like'" & txtsearchbox.Text & "%'"

        ElseIf cbsearch.Text = "First Name" Then
            searchQuery = "Select * from userTbl where firstname Like'" & txtsearchbox.Text & "%'"

        ElseIf cbsearch.Text = "Contact No" Then
            searchQuery = "Select * from userTbl where contactno Like'" & txtsearchbox.Text & "%'"

        ElseIf cbsearch.Text = "Username" Then
            searchQuery = "Select * from userTbl where username Like'" & txtsearchbox.Text & "%'"

        ElseIf cbsearch.Text = "Account Type" Then
            searchQuery = "Select * from userTbl where acctype Like'" & txtsearchbox.Text & "%'"

        ElseIf cbsearch.Text = "Secret Question" Then
            searchQuery = "Select * from userTbl where secretquestion Like'" & txtsearchbox.Text & "%'"

        End If
        Dim cmd As New SqlCommand(searchQuery, conn)
        ExecuteQuery(searchQuery)
        SDA.SelectCommand = cmd
        SDA.Fill(dbDataset)
        bSource.DataSource = dbDataset
        DataGridView1.DataSource = bSource
        SDA.Update(dbDataset)
    End Sub

    Private Sub cbsearch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbsearch.SelectedIndexChanged
        txtsearchbox.Enabled = True
        If cbsearch.Text = "User Id" Then
            txtsearchbox.Text = ""
        ElseIf cbsearch.Text = "Last Name" Then
            txtsearchbox.Text = ""
        ElseIf cbsearch.Text = "Middle Name" Then
            txtsearchbox.Text = ""
        ElseIf cbsearch.Text = "First Name" Then
            txtsearchbox.Text = ""
        ElseIf cbsearch.Text = "Contact No" Then
            txtsearchbox.Text = ""
        ElseIf cbsearch.Text = "Username" Then
            txtsearchbox.Text = ""
        ElseIf cbsearch.Text = "Account Type" Then
            txtsearchbox.Text = ""
        ElseIf cbsearch.Text = "Secret Question" Then
            txtsearchbox.Text = ""
        End If
    End Sub

    Private Sub btnview_Click(sender As Object, e As EventArgs) Handles btnview.Click
            UpdateAccount.btnupload.Enabled = False
            UpdateAccount.btnupdate.Enabled = False
            UpdateAccount.btnedit.Enabled = True
            UpdateAccount.btndelete.Enabled = True
            UpdateAccount.Show()
            UpdateAccount.MdiParent = AdminForm
            Me.Close()
    End Sub
End Class