<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class thoigianthuc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(thoigianthuc))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.theodoi = New System.IO.FileSystemWatcher()
        Me.maychuonline = New System.Windows.Forms.ComboBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        CType(Me.theodoi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 27)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(573, 20)
        Me.TextBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tập tin :"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(298, 79)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.ScrollAlwaysVisible = True
        Me.ListBox1.Size = New System.Drawing.Size(287, 147)
        Me.ListBox1.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(481, 255)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 38)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Về giao diện quét"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(372, 255)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(103, 38)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Thoát"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'theodoi
        '
        Me.theodoi.EnableRaisingEvents = True
        Me.theodoi.NotifyFilter = CType((System.IO.NotifyFilters.FileName Or System.IO.NotifyFilters.LastWrite), System.IO.NotifyFilters)
        Me.theodoi.Path = "C:\"
        Me.theodoi.SynchronizingObject = Me
        '
        'maychuonline
        '
        Me.maychuonline.AutoCompleteCustomSource.AddRange(New String() {"C:\"})
        Me.maychuonline.FormattingEnabled = True
        Me.maychuonline.Location = New System.Drawing.Point(15, 255)
        Me.maychuonline.Name = "maychuonline"
        Me.maychuonline.Size = New System.Drawing.Size(159, 21)
        Me.maychuonline.TabIndex = 22
        Me.maychuonline.Text = "Chọn máy chủ Quét Online"
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(12, 79)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.ScrollAlwaysVisible = True
        Me.ListBox2.Size = New System.Drawing.Size(280, 147)
        Me.ListBox2.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Danh sách đã quét..."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(295, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Tập tin nghi nhiễm..."
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(11, 229)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(573, 20)
        Me.TextBox2.TabIndex = 26
        '
        'thoigianthuc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(597, 295)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.maychuonline)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "thoigianthuc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bảo vệ thời gian thực"
        CType(Me.theodoi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents theodoi As IO.FileSystemWatcher
    Friend WithEvents maychuonline As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents TextBox2 As TextBox
End Class
