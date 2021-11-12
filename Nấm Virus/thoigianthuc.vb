Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Security.Cryptography
Imports System.Text
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System.Windows.Forms
Imports System.Net.NetworkInformation
Imports System.Net
Imports Microsoft.Win32 'Assists in Registry Reading & Writing
Imports System.Management
Imports System.Security
Imports System.Security.AccessControl
Public Class thoigianthuc
    Dim sv1 As String = "http://luutru360.com/"
    Dim sv2 As String = "http://presscoder.net/"
    Dim sv3 As String = "http://4online.net/"
    Private Sub theodoi_Changed(sender As Object, e As IO.FileSystemEventArgs) Handles theodoi.Changed
        '  PictureBox1.ImageLocation = e.FullPath
        TextBox1.Text = e.FullPath
        ListBox2.Items.Add(e.FullPath)
        ListBox2.TopIndex = ListBox2.Items.Count - 1

        If home.maychuonline.Text = "Chọn máy chủ Quét Online" Then
            home.timeon.Text = "Bảo vệ thời gian thật : Tắt"

        Else

            home.timeon.Text = "Bảo vệ thời gian thật : Bật"
            If home.maychuonline.Text = "Máy chủ Lưu Trữ 360" Then
                Dim lt3601 As String = New System.Net.WebClient().DownloadString(sv1 + "/namvirus/tinhtrang.txt")
                If lt3601 = "online" Then
                    'testtt
                    Dim md5 As New MD5CryptoServiceProvider

                    Try
                        Dim f As New FileStream(e.FullPath, FileMode.Open, FileAccess.Read, FileShare.Read, &H2000)
                        f = New FileStream(e.FullPath, FileMode.Open, FileAccess.Read, FileShare.Read, &H2000)
                        md5.ComputeHash(f)

                        ' MsgBox(md5)
                        Dim hash As Byte() = md5.Hash
                        Dim buff As New StringBuilder
                        Dim hashByte As Byte
                        For Each hashByte In hash
                            buff.Append(String.Format("{0:X2}", hashByte))
                        Next


                        'check may chu virus sv2
                        Dim check10s As String = New System.Net.WebClient().DownloadString(sv1 + "/namvirus/index.php?mdh5=" + buff.ToString & "&madoc=bon7chin10bababaOPPO!")
                        ' TextBox1.Text = sv2 + "/namvirus/index.php?mdh5=" + buff.ToString + "&madoc=bon7chin10bababaOPPO!"
                        If check10s = "ok" Then
                            ListBox1.Items.Add(e.FullPath)
                            home.vss.Items.Add(e.FullPath)
                            '  covs.Text = "true"
                            '   icosac.BorderColor = Color.Red
                        End If
                    Catch

                    End Try
                    'end testtt
                Else

                End If
            End If
        End If
    End Sub

    Private Sub thoigianthuc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        theodoi.IncludeSubdirectories = True
        theodoi.NotifyFilter = NotifyFilters.FileName Or NotifyFilters.LastWrite

        AddHandler theodoi.Changed, AddressOf theodoi_Changed
        AddHandler theodoi.Created, AddressOf theodoi_Changed
        AddHandler theodoi.Deleted, AddressOf theodoi_Changed
        AddHandler theodoi.Renamed, AddressOf theodoi_Changed
        '  fsw.EnableRaisingEvents = True
        theodoi.EnableRaisingEvents = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        theodoi.EnableRaisingEvents = False
        theodoi.IncludeSubdirectories = False
        home.Show()
        Me.Hide()
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged
        TextBox2.Text = ListBox2.Text
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        TextBox2.Text = ListBox1.Text
    End Sub
End Class