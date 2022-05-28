<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ForgotPassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ForgotPassword))
        Me.lblsecurity = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtanswer = New System.Windows.Forms.TextBox()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblpassword = New System.Windows.Forms.Label()
        Me.btnconfirm = New System.Windows.Forms.Button()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btncheck = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.btnminimize = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.btnreturn = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblsecurity
        '
        Me.lblsecurity.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblsecurity.AutoSize = True
        Me.lblsecurity.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsecurity.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblsecurity.Location = New System.Drawing.Point(201, 73)
        Me.lblsecurity.Name = "lblsecurity"
        Me.lblsecurity.Size = New System.Drawing.Size(0, 19)
        Me.lblsecurity.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label6.Location = New System.Drawing.Point(64, 135)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 19)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Your Password is:"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label5.Location = New System.Drawing.Point(64, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 19)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Answer:"
        '
        'txtanswer
        '
        Me.txtanswer.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtanswer.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtanswer.ForeColor = System.Drawing.Color.Gray
        Me.txtanswer.Location = New System.Drawing.Point(200, 100)
        Me.txtanswer.MaxLength = 30
        Me.txtanswer.Name = "txtanswer"
        Me.txtanswer.Size = New System.Drawing.Size(186, 26)
        Me.txtanswer.TabIndex = 3
        Me.txtanswer.Text = "Secret Answer..."
        '
        'txtusername
        '
        Me.txtusername.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtusername.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusername.ForeColor = System.Drawing.Color.Gray
        Me.txtusername.Location = New System.Drawing.Point(200, 35)
        Me.txtusername.MaxLength = 15
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(186, 26)
        Me.txtusername.TabIndex = 1
        Me.txtusername.Text = "Type your Username..."
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label4.Location = New System.Drawing.Point(62, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Security Question:"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label3.Location = New System.Drawing.Point(62, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Username:"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(49, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(293, 38)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Type your username and provide your" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "secret answer below for password retrieval"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label1.Location = New System.Drawing.Point(47, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(291, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Forgot Your Password?"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.lblpassword)
        Me.Panel2.Controls.Add(Me.lblsecurity)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.btnconfirm)
        Me.Panel2.Controls.Add(Me.txtanswer)
        Me.Panel2.Controls.Add(Me.btnclear)
        Me.Panel2.Controls.Add(Me.txtusername)
        Me.Panel2.Controls.Add(Me.btncheck)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(410, 362)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(546, 235)
        Me.Panel2.TabIndex = 3
        '
        'lblpassword
        '
        Me.lblpassword.AutoSize = True
        Me.lblpassword.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpassword.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblpassword.Location = New System.Drawing.Point(201, 135)
        Me.lblpassword.Name = "lblpassword"
        Me.lblpassword.Size = New System.Drawing.Size(0, 19)
        Me.lblpassword.TabIndex = 11
        '
        'btnconfirm
        '
        Me.btnconfirm.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnconfirm.BackColor = System.Drawing.Color.White
        Me.btnconfirm.BackgroundImage = Global.Student_Information_System.My.Resources.Resources._10799_check_mark_clip
        Me.btnconfirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnconfirm.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.btnconfirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue
        Me.btnconfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnconfirm.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnconfirm.ForeColor = System.Drawing.Color.DarkBlue
        Me.btnconfirm.Location = New System.Drawing.Point(404, 88)
        Me.btnconfirm.Name = "btnconfirm"
        Me.btnconfirm.Size = New System.Drawing.Size(120, 50)
        Me.btnconfirm.TabIndex = 4
        Me.btnconfirm.Text = "Confirm"
        Me.btnconfirm.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btnconfirm, "Confirm")
        Me.btnconfirm.UseVisualStyleBackColor = False
        '
        'btnclear
        '
        Me.btnclear.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnclear.BackColor = System.Drawing.Color.White
        Me.btnclear.BackgroundImage = Global.Student_Information_System.My.Resources.Resources.close
        Me.btnclear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnclear.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.btnclear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue
        Me.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclear.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclear.ForeColor = System.Drawing.Color.DarkBlue
        Me.btnclear.Location = New System.Drawing.Point(215, 172)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(120, 50)
        Me.btnclear.TabIndex = 5
        Me.btnclear.Text = "Clear"
        Me.btnclear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btnclear, "Clear")
        Me.btnclear.UseVisualStyleBackColor = False
        '
        'btncheck
        '
        Me.btncheck.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btncheck.BackColor = System.Drawing.Color.White
        Me.btncheck.BackgroundImage = Global.Student_Information_System.My.Resources.Resources.heritageblue_circle_check
        Me.btncheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btncheck.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.btncheck.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue
        Me.btncheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncheck.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncheck.ForeColor = System.Drawing.Color.DarkBlue
        Me.btncheck.Location = New System.Drawing.Point(404, 22)
        Me.btncheck.Name = "btncheck"
        Me.btncheck.Size = New System.Drawing.Size(120, 50)
        Me.btncheck.TabIndex = 2
        Me.btncheck.Text = "Check"
        Me.btncheck.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btncheck, "Check")
        Me.btncheck.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(410, 221)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(546, 142)
        Me.Panel1.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Image = Global.Student_Information_System.My.Resources.Resources.question
        Me.PictureBox1.Location = New System.Drawing.Point(381, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.AutoSize = True
        Me.Panel3.BackColor = System.Drawing.Color.DarkBlue
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.btnclose)
        Me.Panel3.Controls.Add(Me.btnminimize)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1366, 29)
        Me.Panel3.TabIndex = 9
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(590, 5)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(196, 19)
        Me.Label13.TabIndex = 48
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
        Me.btnclose.TabIndex = 47
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
        Me.btnminimize.TabIndex = 46
        Me.btnminimize.TabStop = False
        Me.btnminimize.Text = "_"
        Me.ToolTip1.SetToolTip(Me.btnminimize, "Minimize")
        Me.btnminimize.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label7.Location = New System.Drawing.Point(1106, 76)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 19)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Label7"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label8.Location = New System.Drawing.Point(1106, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 19)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Label8"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label9.Location = New System.Drawing.Point(1045, 76)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 19)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Time:"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label10.Location = New System.Drawing.Point(1045, 48)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 19)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Today:"
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
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label11.Location = New System.Drawing.Point(607, 158)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(149, 15)
        Me.Label11.TabIndex = 79
        Me.Label11.Text = "Brgy. Katuparan, Taguig City"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label12.Location = New System.Drawing.Point(528, 138)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(307, 15)
        Me.Label12.TabIndex = 78
        Me.Label12.Text = "SIGNAL VILLAGE NATIONAL HIGH SCHOOL - ANNEX"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label14.Location = New System.Drawing.Point(476, 113)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(409, 19)
        Me.Label14.TabIndex = 77
        Me.Label14.Text = "PRESIDENT DIOSDADO MACAPAGAL HIGH SCHOOL"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label21.Location = New System.Drawing.Point(594, 48)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(179, 60)
        Me.Label21.TabIndex = 76
        Me.Label21.Text = "Republic of the Philippines" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Department of Education" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "National Capital Region" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Di" & _
    "vision of Taguig City and Pateros"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnreturn
        '
        Me.btnreturn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnreturn.BackColor = System.Drawing.Color.White
        Me.btnreturn.BackgroundImage = Global.Student_Information_System.My.Resources.Resources.back
        Me.btnreturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnreturn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.btnreturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue
        Me.btnreturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnreturn.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreturn.ForeColor = System.Drawing.Color.DarkBlue
        Me.btnreturn.Location = New System.Drawing.Point(1029, 119)
        Me.btnreturn.Name = "btnreturn"
        Me.btnreturn.Size = New System.Drawing.Size(220, 50)
        Me.btnreturn.TabIndex = 6
        Me.btnreturn.Text = "&Return to Login Form"
        Me.btnreturn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btnreturn, "Return")
        Me.btnreturn.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Image = Global.Student_Information_System.My.Resources.Resources.PDMHSLOGO
        Me.PictureBox2.Location = New System.Drawing.Point(345, 51)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(112, 108)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'ForgotPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.btnreturn)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label9)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ForgotPassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ForgotPassword"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblsecurity As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnconfirm As System.Windows.Forms.Button
    Friend WithEvents btncheck As System.Windows.Forms.Button
    Friend WithEvents txtanswer As System.Windows.Forms.TextBox
    Friend WithEvents txtusername As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnreturn As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents lblpassword As System.Windows.Forms.Label
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents btnminimize As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
