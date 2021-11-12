<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class home
    'Inherits MaterialSkin.Controls.MaterialForm

    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(home))
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.icosac = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.quet = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lists = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ol1 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.theodoi = New System.IO.FileSystemWatcher()
        Me.opens = New System.Windows.Forms.OpenFileDialog()
        Me.odiakia = New System.Windows.Forms.ComboBox()
        Me.ns1 = New System.Windows.Forms.Label()
        Me.lbs = New System.Windows.Forms.Label()
        Me.lbs1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.scan1 = New System.Windows.Forms.Timer(Me.components)
        Me.hienravs = New System.Windows.Forms.Timer(Me.components)
        Me.lbvs = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.maychuonline = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.quet1 = New System.Windows.Forms.Timer(Me.components)
        Me.thongbaos = New System.Windows.Forms.Label()
        Me.quet2 = New System.Windows.Forms.Timer(Me.components)
        Me.timeon = New System.Windows.Forms.Label()
        Me.vss = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.offhien = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button5 = New System.Windows.Forms.Button()
        CType(Me.theodoi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape3, Me.LineShape2, Me.LineShape1, Me.icosac})
        Me.ShapeContainer1.Size = New System.Drawing.Size(877, 411)
        Me.ShapeContainer1.TabIndex = 3
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape3
        '
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 301
        Me.LineShape3.X2 = 739
        Me.LineShape3.Y1 = 330
        Me.LineShape3.Y2 = 330
        '
        'LineShape2
        '
        Me.LineShape2.Enabled = False
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 887
        Me.LineShape2.X2 = 757
        Me.LineShape2.Y1 = 268
        Me.LineShape2.Y2 = 289
        '
        'LineShape1
        '
        Me.LineShape1.Enabled = False
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 757
        Me.LineShape1.X2 = 708
        Me.LineShape1.Y1 = 289
        Me.LineShape1.Y2 = 421
        '
        'icosac
        '
        Me.icosac.BackColor = System.Drawing.Color.Lime
        Me.icosac.BorderColor = System.Drawing.Color.Lime
        Me.icosac.BorderWidth = 20
        Me.icosac.Enabled = False
        Me.icosac.FillColor = System.Drawing.Color.White
        Me.icosac.FillGradientColor = System.Drawing.Color.White
        Me.icosac.Location = New System.Drawing.Point(760, 297)
        Me.icosac.Name = "icosac"
        Me.icosac.Size = New System.Drawing.Size(101, 102)
        '
        'quet
        '
        Me.quet.AutoSize = True
        Me.quet.BackColor = System.Drawing.Color.Transparent
        Me.quet.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quet.Location = New System.Drawing.Point(779, 335)
        Me.quet.Name = "quet"
        Me.quet.Size = New System.Drawing.Size(0, 25)
        Me.quet.TabIndex = 4
        '
        'Timer1
        '
        '
        'lists
        '
        Me.lists.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lists.FormattingEnabled = True
        Me.lists.Location = New System.Drawing.Point(300, 60)
        Me.lists.Name = "lists"
        Me.lists.Size = New System.Drawing.Size(286, 173)
        Me.lists.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(300, 273)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 43)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Quét ổ đĩa"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Location = New System.Drawing.Point(403, 273)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 43)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Quét thư mục"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Location = New System.Drawing.Point(505, 273)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(96, 43)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Quét tập tin"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Enabled = False
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Location = New System.Drawing.Point(607, 273)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(96, 43)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "Gửi mẫu virus"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'ol1
        '
        Me.ol1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ol1.Location = New System.Drawing.Point(301, 365)
        Me.ol1.Name = "ol1"
        Me.ol1.Size = New System.Drawing.Size(96, 43)
        Me.ol1.TabIndex = 10
        Me.ol1.Text = "Quét ổ đĩa"
        Me.ol1.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button6.Location = New System.Drawing.Point(404, 365)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(96, 43)
        Me.Button6.TabIndex = 11
        Me.Button6.Text = "Quét thư mục"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button7.Location = New System.Drawing.Point(506, 365)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(96, 43)
        Me.Button7.TabIndex = 12
        Me.Button7.Text = "Quét tập tin"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'theodoi
        '
        Me.theodoi.EnableRaisingEvents = True
        Me.theodoi.Path = "C:\"
        Me.theodoi.SynchronizingObject = Me
        '
        'odiakia
        '
        Me.odiakia.AutoCompleteCustomSource.AddRange(New String() {"C:\"})
        Me.odiakia.FormattingEnabled = True
        Me.odiakia.Location = New System.Drawing.Point(717, 239)
        Me.odiakia.Name = "odiakia"
        Me.odiakia.Size = New System.Drawing.Size(138, 21)
        Me.odiakia.TabIndex = 13
        Me.odiakia.Text = "Chọn ổ đĩa quét"
        '
        'ns1
        '
        Me.ns1.AutoSize = True
        Me.ns1.BackColor = System.Drawing.Color.Transparent
        Me.ns1.Location = New System.Drawing.Point(313, 12)
        Me.ns1.Name = "ns1"
        Me.ns1.Size = New System.Drawing.Size(84, 13)
        Me.ns1.TabIndex = 14
        Me.ns1.Text = "Tập tin sẽ quét :"
        '
        'lbs
        '
        Me.lbs.AutoSize = True
        Me.lbs.Location = New System.Drawing.Point(400, 12)
        Me.lbs.Name = "lbs"
        Me.lbs.Size = New System.Drawing.Size(13, 13)
        Me.lbs.TabIndex = 15
        Me.lbs.Text = "0"
        '
        'lbs1
        '
        Me.lbs1.AutoSize = True
        Me.lbs1.Location = New System.Drawing.Point(401, 34)
        Me.lbs1.Name = "lbs1"
        Me.lbs1.Size = New System.Drawing.Size(13, 13)
        Me.lbs1.TabIndex = 17
        Me.lbs1.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(314, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Tập tin đã quét :"
        '
        'scan1
        '
        Me.scan1.Interval = 10
        '
        'hienravs
        '
        Me.hienravs.Interval = 1
        '
        'lbvs
        '
        Me.lbvs.AutoSize = True
        Me.lbvs.Location = New System.Drawing.Point(573, 12)
        Me.lbvs.Name = "lbvs"
        Me.lbvs.Size = New System.Drawing.Size(13, 13)
        Me.lbvs.TabIndex = 19
        Me.lbvs.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(445, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Tập tin nghi nhiễm virus:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(297, 335)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(331, 16)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Quét Online - Quét đám mây - Quét ổ đĩa (Test)"
        '
        'maychuonline
        '
        Me.maychuonline.AutoCompleteCustomSource.AddRange(New String() {"C:\"})
        Me.maychuonline.FormattingEnabled = True
        Me.maychuonline.Location = New System.Drawing.Point(696, 12)
        Me.maychuonline.Name = "maychuonline"
        Me.maychuonline.Size = New System.Drawing.Size(159, 21)
        Me.maychuonline.TabIndex = 21
        Me.maychuonline.Text = "Chọn máy chủ Quét Online"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Enabled = False
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(298, 244)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(320, 16)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Quét Offline - Phiên bản Data : 1.0.0.0.0 (Test)"
        '
        'Button8
        '
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button8.Location = New System.Drawing.Point(607, 365)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(96, 43)
        Me.Button8.TabIndex = 23
        Me.Button8.Text = "Báo lỗi"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'quet1
        '
        '
        'thongbaos
        '
        Me.thongbaos.AutoSize = True
        Me.thongbaos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.thongbaos.Location = New System.Drawing.Point(445, 36)
        Me.thongbaos.Name = "thongbaos"
        Me.thongbaos.Size = New System.Drawing.Size(0, 16)
        Me.thongbaos.TabIndex = 24
        '
        'quet2
        '
        '
        'timeon
        '
        Me.timeon.AutoSize = True
        Me.timeon.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timeon.ForeColor = System.Drawing.Color.Green
        Me.timeon.Location = New System.Drawing.Point(46, 375)
        Me.timeon.Name = "timeon"
        Me.timeon.Size = New System.Drawing.Size(218, 20)
        Me.timeon.TabIndex = 25
        Me.timeon.Text = "Bảo vệ thời gian thật : Bật"
        '
        'vss
        '
        Me.vss.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.vss.FormattingEnabled = True
        Me.vss.Location = New System.Drawing.Point(591, 60)
        Me.vss.Name = "vss"
        Me.vss.Size = New System.Drawing.Size(271, 108)
        Me.vss.TabIndex = 28
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(709, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(156, 13)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Virus phát hiện từ thời gian thực"
        '
        'offhien
        '
        Me.offhien.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.offhien.Location = New System.Drawing.Point(592, 177)
        Me.offhien.Name = "offhien"
        Me.offhien.Size = New System.Drawing.Size(138, 56)
        Me.offhien.TabIndex = 30
        Me.offhien.Text = "Bảo vệ thời gian thực"
        Me.offhien.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Nấm_Virus.My.Resources.Resources.NamVirus
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(299, 361)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Button5
        '
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button5.Location = New System.Drawing.Point(736, 177)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(129, 56)
        Me.Button5.TabIndex = 31
        Me.Button5.Text = "Dọn danh sách"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(877, 411)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.offhien)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.vss)
        Me.Controls.Add(Me.timeon)
        Me.Controls.Add(Me.thongbaos)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.maychuonline)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbvs)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbs1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbs)
        Me.Controls.Add(Me.ns1)
        Me.Controls.Add(Me.odiakia)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.ol1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lists)
        Me.Controls.Add(Me.quet)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nấm Virus - Phiên bản  1.0.0"
        CType(Me.theodoi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents icosac As PowerPacks.OvalShape
    Friend WithEvents quet As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents LineShape1 As PowerPacks.LineShape
    Friend WithEvents LineShape2 As PowerPacks.LineShape
    Friend WithEvents lists As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents ol1 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents LineShape3 As PowerPacks.LineShape
    Friend WithEvents theodoi As IO.FileSystemWatcher
    Friend WithEvents opens As OpenFileDialog
    Friend WithEvents odiakia As ComboBox
    Friend WithEvents ns1 As Label
    Friend WithEvents lbs As Label
    Friend WithEvents lbs1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents scan1 As Timer
    Friend WithEvents hienravs As Timer
    Friend WithEvents lbvs As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents maychuonline As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button8 As Button
    Friend WithEvents quet1 As Timer
    Friend WithEvents thongbaos As Label
    Friend WithEvents quet2 As Timer
    Friend WithEvents timeon As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents vss As ListBox
    Friend WithEvents offhien As Button
    Friend WithEvents Button5 As Button
End Class
