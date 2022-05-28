<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentRecoveryDelete
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudentRecoveryDelete))
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnrecover = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btndelete
        '
        Me.btndelete.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btndelete.BackColor = System.Drawing.Color.White
        Me.btndelete.BackgroundImage = Global.Student_Information_System.My.Resources.Resources.close
        Me.btndelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btndelete.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.btndelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue
        Me.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndelete.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.ForeColor = System.Drawing.Color.DarkBlue
        Me.btndelete.Location = New System.Drawing.Point(244, 316)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(286, 50)
        Me.btndelete.TabIndex = 4
        Me.btndelete.Text = "&Delete Student Information"
        Me.btndelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'btnrecover
        '
        Me.btnrecover.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnrecover.BackColor = System.Drawing.Color.White
        Me.btnrecover.BackgroundImage = Global.Student_Information_System.My.Resources.Resources.RECOVER
        Me.btnrecover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnrecover.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.btnrecover.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue
        Me.btnrecover.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnrecover.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrecover.ForeColor = System.Drawing.Color.DarkBlue
        Me.btnrecover.Location = New System.Drawing.Point(635, 316)
        Me.btnrecover.Name = "btnrecover"
        Me.btnrecover.Size = New System.Drawing.Size(286, 50)
        Me.btnrecover.TabIndex = 5
        Me.btnrecover.Text = "&Recover Student Information"
        Me.btnrecover.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnrecover.UseVisualStyleBackColor = False
        '
        'StudentRecoveryDelete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1152, 708)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnrecover)
        Me.Controls.Add(Me.btndelete)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(209, 0)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "StudentRecoveryDelete"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "StudentRecoveryDelete"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnrecover As System.Windows.Forms.Button
End Class
