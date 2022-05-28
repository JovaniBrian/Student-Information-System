<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminForm))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnminimize = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btndeleterecover = New System.Windows.Forms.Button()
        Me.btnlogout = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnhome = New System.Windows.Forms.Button()
        Me.llviewprofile = New System.Windows.Forms.LinkLabel()
        Me.btnsearchuser = New System.Windows.Forms.Button()
        Me.btnuser = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.AutoSize = True
        Me.Panel2.BackColor = System.Drawing.Color.DarkBlue
        Me.Panel2.Controls.Add(Me.btnclose)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.btnminimize)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1366, 55)
        Me.Panel2.TabIndex = 13
        '
        'btnclose
        '
        Me.btnclose.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnclose.BackColor = System.Drawing.Color.DarkBlue
        Me.btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnclose.FlatAppearance.BorderSize = 0
        Me.btnclose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.btnclose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue
        Me.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclose.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.ForeColor = System.Drawing.Color.White
        Me.btnclose.Location = New System.Drawing.Point(1340, 2)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(25, 25)
        Me.btnclose.TabIndex = 47
        Me.btnclose.Text = "X"
        Me.ToolTip1.SetToolTip(Me.btnclose, "Close")
        Me.btnclose.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(567, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(243, 42)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Administrator"
        '
        'btnminimize
        '
        Me.btnminimize.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnminimize.BackColor = System.Drawing.Color.DarkBlue
        Me.btnminimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnminimize.FlatAppearance.BorderSize = 0
        Me.btnminimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.btnminimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue
        Me.btnminimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnminimize.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnminimize.ForeColor = System.Drawing.Color.White
        Me.btnminimize.Location = New System.Drawing.Point(1307, 2)
        Me.btnminimize.Name = "btnminimize"
        Me.btnminimize.Size = New System.Drawing.Size(25, 25)
        Me.btnminimize.TabIndex = 46
        Me.btnminimize.Text = "_"
        Me.ToolTip1.SetToolTip(Me.btnminimize, "Minimize")
        Me.btnminimize.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btndeleterecover)
        Me.Panel1.Controls.Add(Me.btnlogout)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.btnhome)
        Me.Panel1.Controls.Add(Me.llviewprofile)
        Me.Panel1.Controls.Add(Me.btnsearchuser)
        Me.Panel1.Controls.Add(Me.btnuser)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Location = New System.Drawing.Point(0, 55)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(210, 714)
        Me.Panel1.TabIndex = 46
        '
        'btndeleterecover
        '
        Me.btndeleterecover.BackColor = System.Drawing.Color.DarkBlue
        Me.btndeleterecover.BackgroundImage = Global.Student_Information_System.My.Resources.Resources.DELETERECOVER
        Me.btndeleterecover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btndeleterecover.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.btndeleterecover.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue
        Me.btndeleterecover.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndeleterecover.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndeleterecover.ForeColor = System.Drawing.Color.White
        Me.btndeleterecover.Location = New System.Drawing.Point(1, 397)
        Me.btndeleterecover.Name = "btndeleterecover"
        Me.btndeleterecover.Size = New System.Drawing.Size(206, 55)
        Me.btndeleterecover.TabIndex = 22
        Me.btndeleterecover.Text = "             &Delete/Recover " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "          Student Information"
        Me.ToolTip1.SetToolTip(Me.btndeleterecover, "Delete/Recover Student Information")
        Me.btndeleterecover.UseVisualStyleBackColor = False
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
        Me.btnlogout.Location = New System.Drawing.Point(1, 630)
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
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Location = New System.Drawing.Point(-1, 147)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(210, 85)
        Me.Panel3.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label4.Location = New System.Drawing.Point(69, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 19)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Welcome"
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
        'btnsearchuser
        '
        Me.btnsearchuser.BackColor = System.Drawing.Color.DarkBlue
        Me.btnsearchuser.BackgroundImage = Global.Student_Information_System.My.Resources.Resources.Cute_Ball_Search
        Me.btnsearchuser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnsearchuser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.btnsearchuser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue
        Me.btnsearchuser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsearchuser.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearchuser.ForeColor = System.Drawing.Color.White
        Me.btnsearchuser.Location = New System.Drawing.Point(1, 343)
        Me.btnsearchuser.Name = "btnsearchuser"
        Me.btnsearchuser.Size = New System.Drawing.Size(206, 55)
        Me.btnsearchuser.TabIndex = 3
        Me.btnsearchuser.Text = "            &Search User"
        Me.ToolTip1.SetToolTip(Me.btnsearchuser, "Search User")
        Me.btnsearchuser.UseVisualStyleBackColor = False
        '
        'btnuser
        '
        Me.btnuser.BackColor = System.Drawing.Color.DarkBlue
        Me.btnuser.BackgroundImage = Global.Student_Information_System.My.Resources.Resources.add_a_button
        Me.btnuser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnuser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.btnuser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue
        Me.btnuser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnuser.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnuser.ForeColor = System.Drawing.Color.White
        Me.btnuser.Location = New System.Drawing.Point(1, 289)
        Me.btnuser.Name = "btnuser"
        Me.btnuser.Size = New System.Drawing.Size(206, 55)
        Me.btnuser.TabIndex = 2
        Me.btnuser.Text = "            &Add a User"
        Me.ToolTip1.SetToolTip(Me.btnuser, "Add a User")
        Me.btnuser.UseVisualStyleBackColor = False
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
        'AdminForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AdminForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdminForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnminimize As System.Windows.Forms.Button
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnlogout As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnhome As System.Windows.Forms.Button
    Friend WithEvents llviewprofile As System.Windows.Forms.LinkLabel
    Friend WithEvents btnsearchuser As System.Windows.Forms.Button
    Friend WithEvents btnuser As System.Windows.Forms.Button
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents btndeleterecover As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
