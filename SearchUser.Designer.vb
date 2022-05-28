<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchUser
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblrecordcount = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtsearchbox = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cbsearch = New System.Windows.Forms.ComboBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnview = New System.Windows.Forms.Button()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.lblrecordcount)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.btnview)
        Me.Panel3.Controls.Add(Me.txtsearchbox)
        Me.Panel3.Controls.Add(Me.DataGridView1)
        Me.Panel3.Controls.Add(Me.Label20)
        Me.Panel3.Controls.Add(Me.cbsearch)
        Me.Panel3.Location = New System.Drawing.Point(12, 12)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1128, 684)
        Me.Panel3.TabIndex = 57
        '
        'lblrecordcount
        '
        Me.lblrecordcount.AutoSize = True
        Me.lblrecordcount.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrecordcount.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblrecordcount.Location = New System.Drawing.Point(148, 651)
        Me.lblrecordcount.Name = "lblrecordcount"
        Me.lblrecordcount.Size = New System.Drawing.Size(0, 19)
        Me.lblrecordcount.TabIndex = 69
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label1.Location = New System.Drawing.Point(24, 651)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 19)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "Total Record(s):"
        '
        'txtsearchbox
        '
        Me.txtsearchbox.Enabled = False
        Me.txtsearchbox.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearchbox.ForeColor = System.Drawing.Color.Black
        Me.txtsearchbox.Location = New System.Drawing.Point(514, 18)
        Me.txtsearchbox.MaxLength = 40
        Me.txtsearchbox.Name = "txtsearchbox"
        Me.txtsearchbox.Size = New System.Drawing.Size(478, 26)
        Me.txtsearchbox.TabIndex = 19
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.Location = New System.Drawing.Point(21, 61)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.ShowCellErrors = False
        Me.DataGridView1.ShowCellToolTips = False
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.ShowRowErrors = False
        Me.DataGridView1.Size = New System.Drawing.Size(1087, 577)
        Me.DataGridView1.TabIndex = 65
        Me.DataGridView1.TabStop = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label20.Location = New System.Drawing.Point(24, 20)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(83, 19)
        Me.Label20.TabIndex = 66
        Me.Label20.Text = "Search By:"
        '
        'cbsearch
        '
        Me.cbsearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbsearch.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbsearch.FormattingEnabled = True
        Me.cbsearch.Items.AddRange(New Object() {"User Id", "Last Name", "Middle Name", "First Name", "Contact No", "Username", "Account Type", "Secret Question"})
        Me.cbsearch.Location = New System.Drawing.Point(134, 17)
        Me.cbsearch.Name = "cbsearch"
        Me.cbsearch.Size = New System.Drawing.Size(358, 27)
        Me.cbsearch.TabIndex = 18
        '
        'Timer1
        '
        '
        'btnview
        '
        Me.btnview.BackgroundImage = Global.Student_Information_System.My.Resources.Resources.ic_visibility_black_24dp_2x3
        Me.btnview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnview.Enabled = False
        Me.btnview.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.btnview.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue
        Me.btnview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnview.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnview.ForeColor = System.Drawing.Color.DarkBlue
        Me.btnview.Location = New System.Drawing.Point(1009, 5)
        Me.btnview.Name = "btnview"
        Me.btnview.Size = New System.Drawing.Size(99, 50)
        Me.btnview.TabIndex = 67
        Me.btnview.Text = "View"
        Me.btnview.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnview.UseVisualStyleBackColor = True
        '
        'SearchUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1152, 708)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(209, 0)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SearchUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "SearchUser"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txtsearchbox As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents cbsearch As System.Windows.Forms.ComboBox
    Friend WithEvents btnview As System.Windows.Forms.Button
    Friend WithEvents lblrecordcount As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
