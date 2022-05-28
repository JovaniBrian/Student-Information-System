<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrintStudentRecord
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PrintStudentRecord))
        Me.btnreturn = New System.Windows.Forms.Button()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Form137A1 = New Student_Information_System.Form137A()
        Me.SuspendLayout()
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
        Me.btnreturn.Location = New System.Drawing.Point(1003, 2)
        Me.btnreturn.Name = "btnreturn"
        Me.btnreturn.Size = New System.Drawing.Size(153, 50)
        Me.btnreturn.TabIndex = 58
        Me.btnreturn.Text = "      &Close"
        Me.btnreturn.UseVisualStyleBackColor = False
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = 0
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(5, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Me.Form137A1
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1151, 768)
        Me.CrystalReportViewer1.TabIndex = 57
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'PrintStudentRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1156, 768)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnreturn)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(205, 0)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PrintStudentRecord"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student Information System"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents btnreturn As System.Windows.Forms.Button
    Friend WithEvents Form137A1 As Student_Information_System.Form137A
End Class
