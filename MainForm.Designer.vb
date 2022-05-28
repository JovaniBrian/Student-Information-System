<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InstructionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnlogout = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnhome = New System.Windows.Forms.Button()
        Me.llviewprofile = New System.Windows.Forms.LinkLabel()
        Me.btnsearchstudent = New System.Windows.Forms.Button()
        Me.btnstudentinfo = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.btnminimize = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem1, Me.InstructionsToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(136, 22)
        Me.AboutToolStripMenuItem1.Text = "About"
        '
        'InstructionsToolStripMenuItem
        '
        Me.InstructionsToolStripMenuItem.Name = "InstructionsToolStripMenuItem"
        Me.InstructionsToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.InstructionsToolStripMenuItem.Text = "Instructions"
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnlogout)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.btnhome)
        Me.Panel1.Controls.Add(Me.llviewprofile)
        Me.Panel1.Controls.Add(Me.btnsearchstudent)
        Me.Panel1.Controls.Add(Me.btnstudentinfo)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Location = New System.Drawing.Point(0, 30)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(210, 740)
        Me.Panel1.TabIndex = 7
        '
        'btnlogout
        '
        Me.btnlogout.BackColor = System.Drawing.Color.DarkBlue
        Me.btnlogout.BackgroundImage = Global.Student_Information_System.My.Resources.Resources.panel_force_quit
        Me.btnlogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnlogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.btnlogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue
        Me.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlogout.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogout.ForeColor = System.Drawing.Color.White
        Me.btnlogout.Location = New System.Drawing.Point(1, 671)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Size = New System.Drawing.Size(206, 55)
        Me.btnlogout.TabIndex = 5
        Me.btnlogout.Text = "          &Logout"
        Me.ToolTip1.SetToolTip(Me.btnlogout, "Logout")
        Me.btnlogout.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Location = New System.Drawing.Point(-1, 147)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(210, 85)
        Me.Panel3.TabIndex = 21
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label6.Location = New System.Drawing.Point(69, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 19)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Welcome"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label7.Location = New System.Drawing.Point(-1, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(210, 19)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Label7"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnhome
        '
        Me.btnhome.BackColor = System.Drawing.Color.DarkBlue
        Me.btnhome.BackgroundImage = Global.Student_Information_System.My.Resources.Resources.logo_home_png
        Me.btnhome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnhome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.btnhome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue
        Me.btnhome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnhome.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhome.ForeColor = System.Drawing.Color.White
        Me.btnhome.Location = New System.Drawing.Point(1, 235)
        Me.btnhome.Name = "btnhome"
        Me.btnhome.Size = New System.Drawing.Size(206, 55)
        Me.btnhome.TabIndex = 1
        Me.btnhome.Text = "           &Home"
        Me.ToolTip1.SetToolTip(Me.btnhome, "Home")
        Me.btnhome.UseVisualStyleBackColor = False
        '
        'llviewprofile
        '
        Me.llviewprofile.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llviewprofile.ForeColor = System.Drawing.Color.Transparent
        Me.llviewprofile.Image = Global.Student_Information_System.My.Resources.Resources.account123
        Me.llviewprofile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.llviewprofile.LinkColor = System.Drawing.Color.Blue
        Me.llviewprofile.Location = New System.Drawing.Point(44, 116)
        Me.llviewprofile.Name = "llviewprofile"
        Me.llviewprofile.Size = New System.Drawing.Size(112, 28)
        Me.llviewprofile.TabIndex = 6
        Me.llviewprofile.TabStop = True
        Me.llviewprofile.Text = "View Profile"
        Me.llviewprofile.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.llviewprofile, "View Profile")
        '
        'btnsearchstudent
        '
        Me.btnsearchstudent.BackColor = System.Drawing.Color.DarkBlue
        Me.btnsearchstudent.BackgroundImage = Global.Student_Information_System.My.Resources.Resources.Cute_Ball_Search
        Me.btnsearchstudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnsearchstudent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.btnsearchstudent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue
        Me.btnsearchstudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsearchstudent.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearchstudent.ForeColor = System.Drawing.Color.White
        Me.btnsearchstudent.Location = New System.Drawing.Point(1, 343)
        Me.btnsearchstudent.Name = "btnsearchstudent"
        Me.btnsearchstudent.Size = New System.Drawing.Size(206, 55)
        Me.btnsearchstudent.TabIndex = 3
        Me.btnsearchstudent.Text = "            &Search Student" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "            Information"
        Me.ToolTip1.SetToolTip(Me.btnsearchstudent, "Search Student Information")
        Me.btnsearchstudent.UseVisualStyleBackColor = False
        '
        'btnstudentinfo
        '
        Me.btnstudentinfo.BackColor = System.Drawing.Color.DarkBlue
        Me.btnstudentinfo.BackgroundImage = Global.Student_Information_System.My.Resources.Resources.add_a_button
        Me.btnstudentinfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnstudentinfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.btnstudentinfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue
        Me.btnstudentinfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnstudentinfo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnstudentinfo.ForeColor = System.Drawing.Color.White
        Me.btnstudentinfo.Location = New System.Drawing.Point(1, 289)
        Me.btnstudentinfo.Name = "btnstudentinfo"
        Me.btnstudentinfo.Size = New System.Drawing.Size(206, 55)
        Me.btnstudentinfo.TabIndex = 2
        Me.btnstudentinfo.Text = "            &Add a Student " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "           Information/Record"
        Me.ToolTip1.SetToolTip(Me.btnstudentinfo, "Add Student Information")
        Me.btnstudentinfo.UseVisualStyleBackColor = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox3.Location = New System.Drawing.Point(55, 9)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 9
        Me.PictureBox3.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnclose)
        Me.Panel2.Controls.Add(Me.btnminimize)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1366, 30)
        Me.Panel2.TabIndex = 8
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
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(590, 5)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(196, 19)
        Me.Label13.TabIndex = 45
        Me.Label13.Text = "Student Information System"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student Information System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnstudentinfo As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnsearchstudent As System.Windows.Forms.Button
    Friend WithEvents AboutToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InstructionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents llviewprofile As System.Windows.Forms.LinkLabel
    Friend WithEvents btnhome As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnlogout As System.Windows.Forms.Button
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents btnminimize As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
