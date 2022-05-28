<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentRecoveryForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudentRecoveryForm))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtgenave = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbyeargrad = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtelementaryschool = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtoccupation = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtbrgy = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtparent = New System.Windows.Forms.TextBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txttown = New System.Windows.Forms.TextBox()
        Me.txtbirthplace = New System.Windows.Forms.TextBox()
        Me.txtlrn = New System.Windows.Forms.TextBox()
        Me.dtpdateofbirth = New System.Windows.Forms.DateTimePicker()
        Me.cbgender = New System.Windows.Forms.ComboBox()
        Me.btnrecover = New System.Windows.Forms.Button()
        Me.txtsearchbox = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cbsearch = New System.Windows.Forms.ComboBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Panel1)
        Me.Panel3.Controls.Add(Me.btnrecover)
        Me.Panel3.Controls.Add(Me.txtsearchbox)
        Me.Panel3.Controls.Add(Me.DataGridView1)
        Me.Panel3.Controls.Add(Me.Label20)
        Me.Panel3.Controls.Add(Me.cbsearch)
        Me.Panel3.Location = New System.Drawing.Point(12, 12)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1128, 684)
        Me.Panel3.TabIndex = 58
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txtgenave)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.cbyeargrad)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.txtelementaryschool)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.txtaddress)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.txtoccupation)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.txtbrgy)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.txtparent)
        Me.Panel1.Controls.Add(Me.txtname)
        Me.Panel1.Controls.Add(Me.txttown)
        Me.Panel1.Controls.Add(Me.txtbirthplace)
        Me.Panel1.Controls.Add(Me.txtlrn)
        Me.Panel1.Controls.Add(Me.dtpdateofbirth)
        Me.Panel1.Controls.Add(Me.cbgender)
        Me.Panel1.Location = New System.Drawing.Point(9, 54)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1105, 146)
        Me.Panel1.TabIndex = 70
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label2.Location = New System.Drawing.Point(10, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 15)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label3.Location = New System.Drawing.Point(402, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 15)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Date Of Birth:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label4.Location = New System.Drawing.Point(699, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 15)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Sex:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label5.Location = New System.Drawing.Point(837, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 15)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "LRN:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label6.Location = New System.Drawing.Point(10, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 15)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Birthplace/Province:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label7.Location = New System.Drawing.Point(479, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 15)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Town/City:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label8.Location = New System.Drawing.Point(835, 35)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 15)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Brgy:"
        '
        'txtgenave
        '
        Me.txtgenave.Enabled = False
        Me.txtgenave.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtgenave.ForeColor = System.Drawing.Color.Gray
        Me.txtgenave.Location = New System.Drawing.Point(1004, 116)
        Me.txtgenave.MaxLength = 3
        Me.txtgenave.Name = "txtgenave"
        Me.txtgenave.Size = New System.Drawing.Size(83, 22)
        Me.txtgenave.TabIndex = 13
        Me.txtgenave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label9.Location = New System.Drawing.Point(10, 63)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(103, 15)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Parent/Guardian:"
        '
        'cbyeargrad
        '
        Me.cbyeargrad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbyeargrad.Enabled = False
        Me.cbyeargrad.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbyeargrad.FormattingEnabled = True
        Me.cbyeargrad.Items.AddRange(New Object() {"1960", "1961", "1962", "1963", "1964", "1965", "1966", "1967", "1968", "1969", "1970", "1971", "1972", "1973", "1974", "1975", "1976", "1977", "1978", "1979", "1980", "1981", "1982", "1983", "1984", "1985", "1986", "1987", "1988", "1989", "1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030", "2031", "2032", "2033", "2034", "2035", "2036", "2037", "2038", "2039", "2040", "2041", "2042", "2043", "2044", "2045", "2046", "2047", "2048", "2049", "2050"})
        Me.cbyeargrad.Location = New System.Drawing.Point(828, 115)
        Me.cbyeargrad.Name = "cbyeargrad"
        Me.cbyeargrad.Size = New System.Drawing.Size(107, 23)
        Me.cbyeargrad.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label10.Location = New System.Drawing.Point(621, 67)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 15)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "Occupation:"
        '
        'txtelementaryschool
        '
        Me.txtelementaryschool.Enabled = False
        Me.txtelementaryschool.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtelementaryschool.ForeColor = System.Drawing.Color.Gray
        Me.txtelementaryschool.Location = New System.Drawing.Point(200, 116)
        Me.txtelementaryschool.MaxLength = 50
        Me.txtelementaryschool.Name = "txtelementaryschool"
        Me.txtelementaryschool.Size = New System.Drawing.Size(527, 22)
        Me.txtelementaryschool.TabIndex = 11
        Me.txtelementaryschool.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label11.Location = New System.Drawing.Point(10, 91)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(164, 15)
        Me.Label11.TabIndex = 39
        Me.Label11.Text = "Address of Parent/Guardian:"
        '
        'txtaddress
        '
        Me.txtaddress.Enabled = False
        Me.txtaddress.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaddress.ForeColor = System.Drawing.Color.Gray
        Me.txtaddress.Location = New System.Drawing.Point(180, 88)
        Me.txtaddress.MaxLength = 60
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(907, 22)
        Me.txtaddress.TabIndex = 10
        Me.txtaddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label12.Location = New System.Drawing.Point(10, 119)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(184, 15)
        Me.Label12.TabIndex = 41
        Me.Label12.Text = "Elem. Course Completed School:"
        '
        'txtoccupation
        '
        Me.txtoccupation.Enabled = False
        Me.txtoccupation.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtoccupation.ForeColor = System.Drawing.Color.Gray
        Me.txtoccupation.Location = New System.Drawing.Point(700, 60)
        Me.txtoccupation.MaxLength = 25
        Me.txtoccupation.Name = "txtoccupation"
        Me.txtoccupation.Size = New System.Drawing.Size(387, 22)
        Me.txtoccupation.TabIndex = 9
        Me.txtoccupation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label13.Location = New System.Drawing.Point(733, 119)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(89, 15)
        Me.Label13.TabIndex = 42
        Me.Label13.Text = "Year Graduate:"
        '
        'txtbrgy
        '
        Me.txtbrgy.Enabled = False
        Me.txtbrgy.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbrgy.ForeColor = System.Drawing.Color.Gray
        Me.txtbrgy.Location = New System.Drawing.Point(880, 32)
        Me.txtbrgy.MaxLength = 30
        Me.txtbrgy.Name = "txtbrgy"
        Me.txtbrgy.Size = New System.Drawing.Size(207, 22)
        Me.txtbrgy.TabIndex = 7
        Me.txtbrgy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label14.Location = New System.Drawing.Point(941, 119)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(57, 15)
        Me.Label14.TabIndex = 45
        Me.Label14.Text = "Gen. Ave:"
        '
        'txtparent
        '
        Me.txtparent.Enabled = False
        Me.txtparent.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtparent.ForeColor = System.Drawing.Color.Gray
        Me.txtparent.Location = New System.Drawing.Point(119, 60)
        Me.txtparent.MaxLength = 40
        Me.txtparent.Name = "txtparent"
        Me.txtparent.Size = New System.Drawing.Size(496, 22)
        Me.txtparent.TabIndex = 8
        Me.txtparent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtname
        '
        Me.txtname.Enabled = False
        Me.txtname.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.ForeColor = System.Drawing.Color.Gray
        Me.txtname.Location = New System.Drawing.Point(58, 4)
        Me.txtname.MaxLength = 40
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(335, 22)
        Me.txtname.TabIndex = 1
        Me.txtname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txttown
        '
        Me.txttown.Enabled = False
        Me.txttown.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttown.ForeColor = System.Drawing.Color.Gray
        Me.txttown.Location = New System.Drawing.Point(551, 33)
        Me.txttown.MaxLength = 30
        Me.txttown.Name = "txttown"
        Me.txttown.Size = New System.Drawing.Size(280, 22)
        Me.txttown.TabIndex = 6
        Me.txttown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtbirthplace
        '
        Me.txtbirthplace.Enabled = False
        Me.txtbirthplace.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbirthplace.ForeColor = System.Drawing.Color.Gray
        Me.txtbirthplace.Location = New System.Drawing.Point(137, 32)
        Me.txtbirthplace.MaxLength = 40
        Me.txtbirthplace.Name = "txtbirthplace"
        Me.txtbirthplace.Size = New System.Drawing.Size(336, 22)
        Me.txtbirthplace.TabIndex = 5
        Me.txtbirthplace.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtlrn
        '
        Me.txtlrn.Enabled = False
        Me.txtlrn.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlrn.ForeColor = System.Drawing.Color.Gray
        Me.txtlrn.Location = New System.Drawing.Point(880, 4)
        Me.txtlrn.MaxLength = 15
        Me.txtlrn.Name = "txtlrn"
        Me.txtlrn.Size = New System.Drawing.Size(207, 22)
        Me.txtlrn.TabIndex = 4
        Me.txtlrn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dtpdateofbirth
        '
        Me.dtpdateofbirth.CustomFormat = "MMMM dd, yyy"
        Me.dtpdateofbirth.Enabled = False
        Me.dtpdateofbirth.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpdateofbirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpdateofbirth.Location = New System.Drawing.Point(494, 4)
        Me.dtpdateofbirth.Name = "dtpdateofbirth"
        Me.dtpdateofbirth.Size = New System.Drawing.Size(198, 22)
        Me.dtpdateofbirth.TabIndex = 2
        '
        'cbgender
        '
        Me.cbgender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbgender.Enabled = False
        Me.cbgender.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbgender.FormattingEnabled = True
        Me.cbgender.Items.AddRange(New Object() {"FEMALE", "MALE"})
        Me.cbgender.Location = New System.Drawing.Point(736, 4)
        Me.cbgender.Name = "cbgender"
        Me.cbgender.Size = New System.Drawing.Size(95, 23)
        Me.cbgender.TabIndex = 3
        '
        'btnrecover
        '
        Me.btnrecover.BackgroundImage = Global.Student_Information_System.My.Resources.Resources.RECOVER
        Me.btnrecover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnrecover.Enabled = False
        Me.btnrecover.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.btnrecover.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue
        Me.btnrecover.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnrecover.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrecover.ForeColor = System.Drawing.Color.DarkBlue
        Me.btnrecover.Location = New System.Drawing.Point(998, 2)
        Me.btnrecover.Name = "btnrecover"
        Me.btnrecover.Size = New System.Drawing.Size(115, 50)
        Me.btnrecover.TabIndex = 67
        Me.btnrecover.Text = "Recover"
        Me.btnrecover.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnrecover.UseVisualStyleBackColor = True
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
        Me.DataGridView1.Location = New System.Drawing.Point(9, 206)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.ShowCellErrors = False
        Me.DataGridView1.ShowCellToolTips = False
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.ShowRowErrors = False
        Me.DataGridView1.Size = New System.Drawing.Size(1105, 432)
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
        Me.cbsearch.Items.AddRange(New Object() {"LRN", "NAME"})
        Me.cbsearch.Location = New System.Drawing.Point(134, 17)
        Me.cbsearch.Name = "cbsearch"
        Me.cbsearch.Size = New System.Drawing.Size(358, 27)
        Me.cbsearch.TabIndex = 18
        '
        'StudentRecoveryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1152, 708)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(209, 0)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "StudentRecoveryForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "StudentRecoveryForm"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnrecover As System.Windows.Forms.Button
    Friend WithEvents txtsearchbox As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents cbsearch As System.Windows.Forms.ComboBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtgenave As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cbyeargrad As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtelementaryschool As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtaddress As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtoccupation As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtbrgy As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtparent As System.Windows.Forms.TextBox
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents txttown As System.Windows.Forms.TextBox
    Friend WithEvents txtbirthplace As System.Windows.Forms.TextBox
    Friend WithEvents txtlrn As System.Windows.Forms.TextBox
    Friend WithEvents dtpdateofbirth As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbgender As System.Windows.Forms.ComboBox
End Class
