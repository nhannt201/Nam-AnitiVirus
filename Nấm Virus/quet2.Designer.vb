<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class prquet2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(prquet2))
        Me.exitfr = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.kqquet = New System.Windows.Forms.Label()
        Me.sonhiem = New System.Windows.Forms.Label()
        Me.linkquet = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'exitfr
        '
        Me.exitfr.AutoSize = True
        Me.exitfr.BackColor = System.Drawing.Color.LightCoral
        Me.exitfr.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitfr.ForeColor = System.Drawing.Color.White
        Me.exitfr.Location = New System.Drawing.Point(580, 9)
        Me.exitfr.Name = "exitfr"
        Me.exitfr.Size = New System.Drawing.Size(27, 25)
        Me.exitfr.TabIndex = 2
        Me.exitfr.Text = "X"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.kqquet)
        Me.GroupBox1.Controls.Add(Me.sonhiem)
        Me.GroupBox1.Controls.Add(Me.linkquet)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 97)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(595, 85)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tiến trình quét"
        '
        'kqquet
        '
        Me.kqquet.AutoSize = True
        Me.kqquet.Location = New System.Drawing.Point(299, 54)
        Me.kqquet.Name = "kqquet"
        Me.kqquet.Size = New System.Drawing.Size(52, 13)
        Me.kqquet.TabIndex = 4
        Me.kqquet.Text = "Waiting..."
        '
        'sonhiem
        '
        Me.sonhiem.AutoSize = True
        Me.sonhiem.Location = New System.Drawing.Point(96, 54)
        Me.sonhiem.Name = "sonhiem"
        Me.sonhiem.Size = New System.Drawing.Size(13, 13)
        Me.sonhiem.TabIndex = 3
        Me.sonhiem.Text = "0"
        '
        'linkquet
        '
        Me.linkquet.BackColor = System.Drawing.Color.LavenderBlush
        Me.linkquet.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.linkquet.Enabled = False
        Me.linkquet.ForeColor = System.Drawing.Color.Black
        Me.linkquet.Location = New System.Drawing.Point(65, 27)
        Me.linkquet.MaxLength = 300
        Me.linkquet.Multiline = True
        Me.linkquet.Name = "linkquet"
        Me.linkquet.Size = New System.Drawing.Size(514, 13)
        Me.linkquet.TabIndex = 2
        Me.linkquet.Text = "C:\"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tập tin nhiễm:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tập tin:"
        '
        'prquet2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Nấm_Virus.My.Resources.Resources._2
        Me.ClientSize = New System.Drawing.Size(619, 296)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.exitfr)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "prquet2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nấm Virus - Quét"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents exitfr As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents kqquet As Label
    Friend WithEvents sonhiem As Label
    Friend WithEvents linkquet As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
