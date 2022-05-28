<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.btnminimize = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.llforgotpassword = New System.Windows.Forms.LinkLabel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.btnlogin = New System.Windows.Forms.Button()
        Me.llabout = New System.Windows.Forms.LinkLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtusername
        '
        Me.txtusername.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtusername.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusername.ForeColor = System.Drawing.Color.Gray
        Me.txtusername.Location = New System.Drawing.Point(56, 86)
        Me.txtusername.MaxLength = 15
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(230, 26)
        Me.txtusername.TabIndex = 1
        Me.txtusername.Text = "Type your Username..."
        '
        'txtpassword
        '
        Me.txtpassword.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtpassword.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassword.ForeColor = System.Drawing.Color.Gray
        Me.txtpassword.Location = New System.Drawing.Point(56, 160)
        Me.txtpassword.MaxLength = 15
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(230, 26)
        Me.txtpassword.TabIndex = 2
        Me.txtpassword.Text = "Password..."
        Me.txtpassword.UseSystemPasswordChar = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkBlue
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.btnclose)
        Me.Panel2.Controls.Add(Me.btnminimize)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1366, 30)
        Me.Panel2.TabIndex = 8
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(590, 5)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(196, 19)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "Student Information System"
        '
        'btnclose
        '
        Me.btnclose.BackColor = System.Drawing.Color.DarkBlue
        Me.btnclose.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue
        Me.btnclose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.btnclose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue
        Me.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclose.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.ForeColor = System.Drawing.Color.White
        Me.btnclose.Location = New System.Drawing.Point(1338, 1)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(25, 25)
        Me.btnclose.TabIndex = 8
        Me.btnclose.TabStop = False
        Me.btnclose.Text = "X"
        Me.ToolTip1.SetToolTip(Me.btnclose, "Close")
        Me.btnclose.UseVisualStyleBackColor = False
        '
        'btnminimize
        '
        Me.btnminimize.BackColor = System.Drawing.Color.DarkBlue
        Me.btnminimize.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue
        Me.btnminimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.btnminimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue
        Me.btnminimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnminimize.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnminimize.ForeColor = System.Drawing.Color.White
        Me.btnminimize.Location = New System.Drawing.Point(1305, 1)
        Me.btnminimize.Name = "btnminimize"
        Me.btnminimize.Size = New System.Drawing.Size(25, 25)
        Me.btnminimize.TabIndex = 7
        Me.btnminimize.TabStop = False
        Me.btnminimize.Text = "_"
        Me.ToolTip1.SetToolTip(Me.btnminimize, "Minimize")
        Me.btnminimize.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label5.Location = New System.Drawing.Point(1106, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 19)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Label5"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label6.Location = New System.Drawing.Point(1106, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 19)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Label6"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label7.Location = New System.Drawing.Point(1045, 76)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 19)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Time:"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label8.Location = New System.Drawing.Point(1045, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 19)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Today:"
        '
        'llforgotpassword
        '
        Me.llforgotpassword.AutoSize = True
        Me.llforgotpassword.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llforgotpassword.ForeColor = System.Drawing.Color.Transparent
        Me.llforgotpassword.LinkColor = System.Drawing.Color.Blue
        Me.llforgotpassword.Location = New System.Drawing.Point(52, 189)
        Me.llforgotpassword.Name = "llforgotpassword"
        Me.llforgotpassword.Size = New System.Drawing.Size(121, 19)
        Me.llforgotpassword.TabIndex = 5
        Me.llforgotpassword.TabStop = True
        Me.llforgotpassword.Text = "Forgot Password?"
        Me.ToolTip1.SetToolTip(Me.llforgotpassword, "Forgot Password")
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label3.Location = New System.Drawing.Point(52, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 19)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Password"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label2.Location = New System.Drawing.Point(52, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 19)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Username"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label1.Location = New System.Drawing.Point(1270, 740)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 19)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Version 1.0"
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'Timer3
        '
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label4.Location = New System.Drawing.Point(607, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(149, 15)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Brgy. Katuparan, Taguig City"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label9.Location = New System.Drawing.Point(528, 138)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(307, 15)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "SIGNAL VILLAGE NATIONAL HIGH SCHOOL - ANNEX"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label10.Location = New System.Drawing.Point(476, 113)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(409, 19)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "PRESIDENT DIOSDADO MACAPAGAL HIGH SCHOOL"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label11.Location = New System.Drawing.Point(594, 48)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(179, 60)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Republic of the Philippines" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Department of Education" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "National Capital Region" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Di" & _
    "vision of Taguig City and Pateros"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnexit)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.CheckBox1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btnlogin)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtpassword)
        Me.Panel1.Controls.Add(Me.txtusername)
        Me.Panel1.Controls.Add(Me.llforgotpassword)
        Me.Panel1.Location = New System.Drawing.Point(441, 246)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(476, 261)
        Me.Panel1.TabIndex = 22
        '
        'btnexit
        '
        Me.btnexit.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnexit.BackColor = System.Drawing.Color.White
        Me.btnexit.BackgroundImage = Global.Student_Information_System.My.Resources.Resources.panel_force_quit
        Me.btnexit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnexit.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.btnexit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue
        Me.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnexit.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.ForeColor = System.Drawing.Color.DarkBlue
        Me.btnexit.Location = New System.Drawing.Point(325, 146)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(106, 50)
        Me.btnexit.TabIndex = 4
        Me.btnexit.Text = "&Exit"
        Me.btnexit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btnexit, "Exit")
        Me.btnexit.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label12.Location = New System.Drawing.Point(198, 12)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 31)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Login"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(264, 166)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox1.TabIndex = 2
        Me.CheckBox1.TabStop = False
        Me.ToolTip1.SetToolTip(Me.CheckBox1, "Show Password")
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'btnlogin
        '
        Me.btnlogin.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnlogin.BackColor = System.Drawing.Color.White
        Me.btnlogin.BackgroundImage = Global.Student_Information_System.My.Resources.Resources.lock_open_blue1
        Me.btnlogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnlogin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.btnlogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue
        Me.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlogin.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogin.ForeColor = System.Drawing.Color.DarkBlue
        Me.btnlogin.Location = New System.Drawing.Point(325, 73)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(106, 50)
        Me.btnlogin.TabIndex = 3
        Me.btnlogin.Text = "&Login"
        Me.btnlogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btnlogin, "Login")
        Me.btnlogin.UseVisualStyleBackColor = False
        '
        'llabout
        '
        Me.llabout.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llabout.ForeColor = System.Drawing.Color.Transparent
        Me.llabout.Image = Global.Student_Information_System.My.Resources.Resources.ic_info_black_24dp_1x
        Me.llabout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.llabout.LinkColor = System.Drawing.Color.Blue
        Me.llabout.Location = New System.Drawing.Point(3, 715)
        Me.llabout.Name = "llabout"
        Me.llabout.Size = New System.Drawing.Size(76, 50)
        Me.llabout.TabIndex = 6
        Me.llabout.TabStop = True
        Me.llabout.Text = "About"
        Me.llabout.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.llabout, "About")
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.Student_Information_System.My.Resources.Resources.PDMHSLOGO
        Me.PictureBox1.Location = New System.Drawing.Point(345, 51)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(112, 108)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.llabout)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.PictureBox1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student Information System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnlogin As System.Windows.Forms.Button
    Friend WithEvents txtusername As System.Windows.Forms.TextBox
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents llforgotpassword As System.Windows.Forms.LinkLabel
    Friend WithEvents llabout As System.Windows.Forms.LinkLabel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents btnminimize As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

End Class
