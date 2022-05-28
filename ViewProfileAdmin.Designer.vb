<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewProfileAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewProfileAdmin))
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.cbsecretquestion = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtsecretanswer = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtuserid = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtfirstname = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtlastname = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtcontactno = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.pbpicture = New System.Windows.Forms.PictureBox()
        Me.txtpasswordrtp = New System.Windows.Forms.TextBox()
        Me.txtmiddlename = New System.Windows.Forms.TextBox()
        Me.txtpasswordsignup = New System.Windows.Forms.TextBox()
        Me.txtusernamesignup = New System.Windows.Forms.TextBox()
        CType(Me.pbpicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.BackColor = System.Drawing.Color.White
        Me.CheckBox2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.ForeColor = System.Drawing.Color.White
        Me.CheckBox2.Location = New System.Drawing.Point(676, 401)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox2.TabIndex = 46
        Me.CheckBox2.TabStop = False
        Me.CheckBox2.UseVisualStyleBackColor = False
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.BackColor = System.Drawing.Color.White
        Me.CheckBox3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox3.ForeColor = System.Drawing.Color.White
        Me.CheckBox3.Location = New System.Drawing.Point(676, 436)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox3.TabIndex = 48
        Me.CheckBox3.TabStop = False
        Me.CheckBox3.UseVisualStyleBackColor = False
        '
        'cbsecretquestion
        '
        Me.cbsecretquestion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbsecretquestion.Enabled = False
        Me.cbsecretquestion.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbsecretquestion.ForeColor = System.Drawing.Color.Black
        Me.cbsecretquestion.FormattingEnabled = True
        Me.cbsecretquestion.Items.AddRange(New Object() {"What is your Favorite Movie?", "What is your Favorite Color?", "What is your Favorite Food?", "What is the Name of Your First Pet?", "Who is Your Oldest Cousin?"})
        Me.cbsecretquestion.Location = New System.Drawing.Point(442, 465)
        Me.cbsecretquestion.Name = "cbsecretquestion"
        Me.cbsecretquestion.Size = New System.Drawing.Size(256, 27)
        Me.cbsecretquestion.TabIndex = 39
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label17.Location = New System.Drawing.Point(295, 362)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(82, 19)
        Me.Label17.TabIndex = 47
        Me.Label17.Text = "Username:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label20.Location = New System.Drawing.Point(295, 503)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(110, 19)
        Me.Label20.TabIndex = 53
        Me.Label20.Text = "Secret Answer:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label16.Location = New System.Drawing.Point(295, 327)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(124, 19)
        Me.Label16.TabIndex = 45
        Me.Label16.Text = "Contact Number:"
        '
        'txtsecretanswer
        '
        Me.txtsecretanswer.Enabled = False
        Me.txtsecretanswer.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsecretanswer.ForeColor = System.Drawing.Color.Black
        Me.txtsecretanswer.Location = New System.Drawing.Point(442, 500)
        Me.txtsecretanswer.MaxLength = 25
        Me.txtsecretanswer.Name = "txtsecretanswer"
        Me.txtsecretanswer.Size = New System.Drawing.Size(256, 26)
        Me.txtsecretanswer.TabIndex = 41
        Me.txtsecretanswer.Text = "Secret Answer..."
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label15.Location = New System.Drawing.Point(295, 397)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(77, 19)
        Me.Label15.TabIndex = 49
        Me.Label15.Text = "Password:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label19.Location = New System.Drawing.Point(295, 468)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(121, 19)
        Me.Label19.TabIndex = 52
        Me.Label19.Text = "Secret Question:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label14.Location = New System.Drawing.Point(295, 291)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(84, 19)
        Me.Label14.TabIndex = 44
        Me.Label14.Text = "First Name"
        '
        'txtuserid
        '
        Me.txtuserid.Enabled = False
        Me.txtuserid.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtuserid.Location = New System.Drawing.Point(442, 183)
        Me.txtuserid.MaxLength = 15
        Me.txtuserid.Name = "txtuserid"
        Me.txtuserid.Size = New System.Drawing.Size(256, 26)
        Me.txtuserid.TabIndex = 31
        Me.txtuserid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label13.Location = New System.Drawing.Point(295, 256)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(106, 19)
        Me.Label13.TabIndex = 43
        Me.Label13.Text = "Middle Name:"
        '
        'txtfirstname
        '
        Me.txtfirstname.Enabled = False
        Me.txtfirstname.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfirstname.ForeColor = System.Drawing.Color.Black
        Me.txtfirstname.Location = New System.Drawing.Point(442, 288)
        Me.txtfirstname.MaxLength = 25
        Me.txtfirstname.Name = "txtfirstname"
        Me.txtfirstname.Size = New System.Drawing.Size(256, 26)
        Me.txtfirstname.TabIndex = 34
        Me.txtfirstname.Text = "Type your First Name..."
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label12.Location = New System.Drawing.Point(295, 221)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(88, 19)
        Me.Label12.TabIndex = 42
        Me.Label12.Text = "Last Name:"
        '
        'txtlastname
        '
        Me.txtlastname.Enabled = False
        Me.txtlastname.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlastname.ForeColor = System.Drawing.Color.Black
        Me.txtlastname.Location = New System.Drawing.Point(442, 218)
        Me.txtlastname.MaxLength = 25
        Me.txtlastname.Name = "txtlastname"
        Me.txtlastname.Size = New System.Drawing.Size(256, 26)
        Me.txtlastname.TabIndex = 32
        Me.txtlastname.Text = "Type your Last Name..."
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label11.Location = New System.Drawing.Point(295, 433)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(139, 19)
        Me.Label11.TabIndex = 50
        Me.Label11.Text = "Re-Type Password:"
        '
        'txtcontactno
        '
        Me.txtcontactno.Enabled = False
        Me.txtcontactno.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcontactno.ForeColor = System.Drawing.Color.Black
        Me.txtcontactno.Location = New System.Drawing.Point(442, 324)
        Me.txtcontactno.MaxLength = 11
        Me.txtcontactno.Name = "txtcontactno"
        Me.txtcontactno.Size = New System.Drawing.Size(256, 26)
        Me.txtcontactno.TabIndex = 35
        Me.txtcontactno.Text = "Mobile Number..."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label10.Location = New System.Drawing.Point(295, 186)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 19)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "User Id:"
        '
        'pbpicture
        '
        Me.pbpicture.BackColor = System.Drawing.Color.White
        Me.pbpicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbpicture.Location = New System.Drawing.Point(758, 183)
        Me.pbpicture.Name = "pbpicture"
        Me.pbpicture.Size = New System.Drawing.Size(100, 100)
        Me.pbpicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbpicture.TabIndex = 51
        Me.pbpicture.TabStop = False
        '
        'txtpasswordrtp
        '
        Me.txtpasswordrtp.Enabled = False
        Me.txtpasswordrtp.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpasswordrtp.ForeColor = System.Drawing.Color.Black
        Me.txtpasswordrtp.Location = New System.Drawing.Point(442, 430)
        Me.txtpasswordrtp.MaxLength = 15
        Me.txtpasswordrtp.Name = "txtpasswordrtp"
        Me.txtpasswordrtp.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpasswordrtp.Size = New System.Drawing.Size(256, 26)
        Me.txtpasswordrtp.TabIndex = 38
        Me.txtpasswordrtp.Text = "Confirm Password..."
        '
        'txtmiddlename
        '
        Me.txtmiddlename.Enabled = False
        Me.txtmiddlename.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmiddlename.ForeColor = System.Drawing.Color.Black
        Me.txtmiddlename.Location = New System.Drawing.Point(442, 253)
        Me.txtmiddlename.MaxLength = 25
        Me.txtmiddlename.Name = "txtmiddlename"
        Me.txtmiddlename.Size = New System.Drawing.Size(256, 26)
        Me.txtmiddlename.TabIndex = 33
        Me.txtmiddlename.Text = "Type your Middle Name..."
        '
        'txtpasswordsignup
        '
        Me.txtpasswordsignup.Enabled = False
        Me.txtpasswordsignup.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpasswordsignup.ForeColor = System.Drawing.Color.Black
        Me.txtpasswordsignup.Location = New System.Drawing.Point(442, 394)
        Me.txtpasswordsignup.MaxLength = 15
        Me.txtpasswordsignup.Name = "txtpasswordsignup"
        Me.txtpasswordsignup.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpasswordsignup.Size = New System.Drawing.Size(256, 26)
        Me.txtpasswordsignup.TabIndex = 37
        Me.txtpasswordsignup.Text = "Password..."
        '
        'txtusernamesignup
        '
        Me.txtusernamesignup.Enabled = False
        Me.txtusernamesignup.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusernamesignup.ForeColor = System.Drawing.Color.Black
        Me.txtusernamesignup.Location = New System.Drawing.Point(442, 359)
        Me.txtusernamesignup.MaxLength = 15
        Me.txtusernamesignup.Name = "txtusernamesignup"
        Me.txtusernamesignup.Size = New System.Drawing.Size(256, 26)
        Me.txtusernamesignup.TabIndex = 36
        Me.txtusernamesignup.Text = "Username..."
        '
        'ViewProfileAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1152, 708)
        Me.ControlBox = False
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.cbsecretquestion)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtsecretanswer)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtuserid)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtfirstname)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtlastname)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtcontactno)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.pbpicture)
        Me.Controls.Add(Me.txtpasswordrtp)
        Me.Controls.Add(Me.txtmiddlename)
        Me.Controls.Add(Me.txtpasswordsignup)
        Me.Controls.Add(Me.txtusernamesignup)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(209, 0)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ViewProfileAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "ViewProfileAdmin"
        CType(Me.pbpicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents cbsecretquestion As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtsecretanswer As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtuserid As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtfirstname As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtlastname As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtcontactno As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents pbpicture As System.Windows.Forms.PictureBox
    Friend WithEvents txtpasswordrtp As System.Windows.Forms.TextBox
    Friend WithEvents txtmiddlename As System.Windows.Forms.TextBox
    Friend WithEvents txtpasswordsignup As System.Windows.Forms.TextBox
    Friend WithEvents txtusernamesignup As System.Windows.Forms.TextBox
End Class
