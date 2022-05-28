Imports System.Data.SqlClient
Imports System.IO
Public Class StudentDeleteForm
    Dim conn As New SqlConnection("Server=LENOVO-PC\SQLEXPRESS; Database=SIS; Integrated Security=true")
    Dim cmd As New SqlCommand
    Dim dt As New System.Data.DataTable
    Private Sub StudentDeleteForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showGrid()
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
        Dim command As New SqlCommand("SELECT * FROM studinfoTbl", conn)
        Dim imgc As New DataGridViewImageColumn
        Dim table As New DataTable
        Dim adapter As New SqlDataAdapter(command)
        adapter.Fill(table)
        DataGridView1.DataSource = table
        DataGridView1.VirtualMode = True
        Dim SDA As New SqlDataAdapter
        Dim dbDataset As New DataTable
        Dim bSource As New BindingSource
        Dim query As String
        query = "SELECT * FROM studinfoTbl"
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
    Private Sub txtsearchbox_TextChanged(sender As Object, e As EventArgs) Handles txtsearchbox.TextChanged
        Dim searchQuery As String
        Dim SDA As New SqlDataAdapter
        Dim dbDataset As New DataTable
        Dim bSource As New BindingSource

        If cbsearch.Text = "LRN" Then
            searchQuery = "SELECT * FROM studinfoTbl where lrn Like'" & txtsearchbox.Text & "%'"

        ElseIf cbsearch.Text = "NAME" Then
            searchQuery = "SELECT * FROM studinfoTbl where fullname Like'" & txtsearchbox.Text & "%'"

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
        If cbsearch.Text = "LRN" Then
            txtsearchbox.Text = ""
        ElseIf cbsearch.Text = "NAME" Then
            txtsearchbox.Text = ""
        End If
    End Sub
    Private Sub DataGridView1_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.DataGridView1.Rows(e.RowIndex)
            txtlrn.Text = row.Cells("lrn").Value.ToString
            txtname.Text = row.Cells("fullname").Value.ToString
            dtpdateofbirth.Text = row.Cells("dateofbirth").Value.ToString
            cbgender.Text = row.Cells("sex").Value.ToString
            txtbirthplace.Text = row.Cells("birthplace").Value.ToString
            txttown.Text = row.Cells("town").Value.ToString
            txtbrgy.Text = row.Cells("brgy").Value.ToString
            txtparent.Text = row.Cells("parent").Value.ToString
            txtoccupation.Text = row.Cells("occupation").Value.ToString
            txtaddress.Text = row.Cells("parentaddress").Value.ToString
            txtelementaryschool.Text = row.Cells("elemschool").Value.ToString
            cbyeargrad.Text = row.Cells("yeargrad").Value.ToString
            txtgenave.Text = row.Cells("genave").Value.ToString
            btndelete.Enabled = True
        End If
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Try

            Dim insertQuery1, deleteQuery1 As String
            If MessageBox.Show("You are about to delete the information Select Yes in order to proceed ", "Delete", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                conn.Open()
                insertQuery1 = "INSERT INTO studinforecoveryTbl(lrn,fullname,dateofbirth,sex,birthplace,town,brgy,parent,occupation,parentaddress,elemschool,yeargrad,genave) VALUES ('" & txtlrn.Text & "' , '" & txtname.Text & "' , '" & dtpdateofbirth.Text & "' , '" & cbgender.Text & "', '" & txtbirthplace.Text & "', '" & txttown.Text & "', '" & txtbrgy.Text & "', '" & txtparent.Text & "','" & txtoccupation.Text & "','" & txtaddress.Text & "', '" & txtelementaryschool.Text & "', '" & cbyeargrad.Text & "', '" & txtgenave.Text & "' )"
                deleteQuery1 = "Delete from studinfoTbl where lrn='" & txtlrn.Text & "'"
                Dim command1 As New SqlCommand(insertQuery1, conn)
                Dim command2 As New SqlCommand(deleteQuery1, conn)
                command1.ExecuteNonQuery()
                command2.ExecuteNonQuery()
                MessageBox.Show("Information Deleted")
                txtlrn.Text = ""
                txtname.Text = ""
                txtbirthplace.Text = ""
                txttown.Text = ""
                txtbrgy.Text = ""
                txtparent.Text = ""
                txtoccupation.Text = ""
                txtaddress.Text = ""
                txtelementaryschool.Text = ""
                txtgenave.Text = ""
                cbsearch.Text = Nothing
                txtsearchbox.Text = ""
                txtsearchbox.Enabled = False
                btndelete.Enabled = False
                conn.Close()
                showGrid()

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class