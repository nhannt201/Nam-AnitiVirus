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


Public Class home
    ' Inherits MaterialSkin.Controls.MaterialForm

    Dim s1 As String = 0
    Dim ii As Integer = 0
    Dim ix As String = 0
    Dim loaddata As String = 0
    Dim danhbavs As New TextBox
    Dim virusa As New ListBox
    Dim covs As New Label
    Dim checkmd5 As New TextBox
    Dim campa As New TextBox
    Dim mofile As New OpenFileDialog
    Dim sv1 As String = "http://luutru360.com/"
    Dim sv2 As String = "http://presscoder.net/"
    Dim sv3 As String = "http://4online.net/"
    Dim myname As String = "Nấm Virus - Phiên bản  1.0.0"


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Dim watched As String = "C:\"
        ' Dim fsw As New FileSystemWatcher(watched)
        '  theodoi.IncludeSubdirectories = True
        '  theodoi.NotifyFilter = NotifyFilters.FileName Or NotifyFilters.LastWrite

        ' AddHandler theodoi.Changed, AddressOf theodoi_Changed
        'AddHandler theodoi.Created, AddressOf theodoi_Changed
        'AddHandler theodoi.Deleted, AddressOf theodoi_Changed
        'AddHandler theodoi.Renamed, AddressOf theodoi_Changed
        '  fsw.EnableRaisingEvents = True
        ' theodoi.EnableRaisingEvents = True

        '   For Each Dir As String In System.IO.Directory.GetDirectories("D:\")
        'Dim dirInfo As New System.IO.DirectoryInfo(Dir)
        '
        ' If dirInfo.FullName.IndexOf("$") > -1 Then
        'Documents and Settings


        'Else
        ' paths.Items.Add(dirInfo.FullName)
        '   End If
        '  Next
        '  Timer1.Start()
        '    For Each dr As String In Directory.GetDirectories("C:\")
        'Dim listFile As String() = Directory.GetFiles(dr)
        'For Each fi As String In listFile
        ' lists.Items.Add(fi)
        ' Next
        '  Next
        ''''''''''''
        Try

            For Each drivver As IO.DriveInfo In IO.DriveInfo.GetDrives
                Dim tenodia As String = drivver.Name
                odiakia.Items.Add(tenodia)
            Next
            quet.Text = "Start"
            danhbavs.Text = "1CDA9359F343A8279CF874D9B9568D6B B1EEC24DD3E904924E57EBC7F796E6D0"

            'load virus


            '  Dim lines() As String = IO.File.ReadAllLines("D:\coccoc_vi.exe")


            'end load
            'lists.Enabled = False
            Try
                Dim lt360 As String = New System.Net.WebClient().DownloadString(sv1 + "/namvirus/tinhtrang.txt")
                If lt360 = "online" Then
                    maychuonline.Items.Add("Máy chủ Lưu Trữ 360")
                    thoigianthuc.maychuonline.Items.Add("Máy chủ Lưu Trữ 360")
                End If
            Catch

            End Try
            'df
            Try
                Dim prs As String = New System.Net.WebClient().DownloadString(sv2 + "/namvirus/tinhtrang.txt")
                If prs = "online" Then
                    maychuonline.Items.Add("Máy chủ Presscoder")
                    thoigianthuc.maychuonline.Items.Add("Máy chủ Presscoder")
                End If
            Catch

            End Try
            'dsf
            Try
                Dim bonline As String = New System.Net.WebClient().DownloadString(sv3 + "/namvirus/tinhtrang.txt")
                If bonline = "online" Then
                    maychuonline.Items.Add("Máy chủ 4Online")
                    thoigianthuc.maychuonline.Items.Add("Máy chủ 4Online")
                End If
            Catch

            End Try
            '    maychuonline.Items.Add("Máy chủ Presscoder")
            '   maychuonline.Items.Add("Máy chủ 4Online")

        Catch

        End Try

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If s1 = 0 Then
            icosac.BorderStyle = Drawing2D.DashStyle.Dash
            s1 = s1 + 1


        ElseIf s1 = 1 Then
            icosac.BorderStyle = Drawing2D.DashStyle.DashDot
            s1 = s1 + 1


        ElseIf s1 = 2 Then
            icosac.BorderStyle = Drawing2D.DashStyle.DashDotDot
            s1 = s1 + 1

        ElseIf s1 = 3 Then
            icosac.BorderStyle = Drawing2D.DashStyle.Dot
            s1 = 0



        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' make a reference to a directory
        'Dim di As New IO.DirectoryInfo("c:\")
        'Dim diar1 As IO.FileInfo() = di.GetFiles
        'Dim dra As IO.FileInfo

        'list the names of all files in the specified directory
        'For Each dra In diar1

        '   If dra.FullName.IndexOf("$") > -1 Then
        'Documents and Settings

        '
        '  Else
        '       paths.Items.Add(dra.FullName)
        '    End If
        ' Next
        lists.Items.Clear()

        If odiakia.Text = "Chọn ổ đĩa quét" Then
            MsgBox("Bạn vui lòng chọn ổ đĩa!", vbInformation, "Thông báo")
        Else

            Try
                Me.Enabled = False
                canhbao.Show()
                odiakia.Enabled = False
                Timer1.Start()
                lbvs.Text = "0"
                quet.Text = "Quét"
                icosac.BorderColor = Color.Lime
                For Each dr As String In Directory.GetDirectories(odiakia.Text)

                    Dim listFile As String() = Directory.GetFiles(dr)
                    For Each fi As String In listFile
                        lists.Items.Add(fi)
                    Next
                    lbs.Text = lists.Items.Count + 1
                    scan1.Start()

                Next

            Catch

            End Try
        End If

    End Sub

    Private Sub quet_Click(sender As Object, e As EventArgs) Handles quet.Click
        'Timer1.Start()

    End Sub

    Private Sub icosac_Click(sender As Object, e As EventArgs) Handles icosac.Click

    End Sub

    Private Sub scan1_Tick(sender As Object, e As EventArgs) Handles scan1.Tick

        lbs1.Text = lbs1.Text + 1
        '  lists.SelectedItem(lbs1.Text)
        '  If lbs1.Text >= lbs.Text Then
        prquet2.linkquet.Text = lists.Text
        Try
        lists.SelectedIndex = lists.SelectedIndex + 1
        Catch

            hienravs.Start()

            scan1.Stop()
        End Try
        Dim paths1 As String = lists.Text
        Me.Text = paths1
        Dim md5 As New MD5CryptoServiceProvider

        Try
            Dim f As New FileStream(paths1, FileMode.Open, FileAccess.Read, FileShare.Read, &H2000)
            f = New FileStream(paths1, FileMode.Open, FileAccess.Read, FileShare.Read, &H2000)
            md5.ComputeHash(f)

            ' MsgBox(md5)
            Dim hash As Byte() = md5.Hash
            Dim buff As New StringBuilder
            Dim hashByte As Byte
            For Each hashByte In hash
                buff.Append(String.Format("{0:X2}", hashByte))
            Next

            If danhbavs.Text.Contains(buff.ToString) Then
                virusa.Items.Add(paths1)
                covs.Text = "true"
                icosac.BorderColor = Color.Red
            End If
        Catch
            '   MsgBox("Có tập tin không thể quét!")
            lbs1.Text = lbs1.Text + 1
            Try
                lists.SelectedIndex = lists.SelectedIndex + 1
            Catch
                hienravs.Start()

                scan1.Stop()
            End Try
        End Try
        '   Else
        '   scan1.Stop()
        '   End If
    End Sub

    Private Sub hienravs_Tick(sender As Object, e As EventArgs) Handles hienravs.Tick
        Try
            If ix = 0 Then
                lists.Items.Clear()
                ix = 1
            End If
            If covs.Text = "true" Then
                ' lists.Items.Clear()
                If lbvs.Text <= 0 Then
                    lbvs.Text = "0"

                    thongbaos.Text = ("Không phát hiện tập tin nghi virus!")
                    prquet2.kqquet.Text = thongbaos.Text
                    ' prquet2.kqquet.Visible = True

                Else
                    lbvs.Text = lists.Items.Count
                End If


                If ix = 1 And lbvs.Text >= 1 Then
                    ' prquet2.kqquet.Text = ("Các tập tin bị nghi ngờ")
                    thongbaos.Text = ("Các tập tin bị nghi ngờ")
                    prquet2.kqquet.Text = thongbaos.Text

                    ix = 2
                Else

                End If
                virusa.SelectedIndex = virusa.SelectedIndex + 1
                lists.Items.Add(virusa.Text)
                Me.Text = myname

            Else

                lbvs.Text = "0"
                '   prquet2.kqquet.Text = ("Không phát hiện tập tin nghi virus!")
                thongbaos.Text = ("Không phát hiện tập tin nghi virus!")
                prquet2.kqquet.Text = thongbaos.Text

                loihienra()

            End If
            lbvs.Text = lists.Items.Count
        Catch ex As Exception

            loihienra()
        End Try
    End Sub
    Sub loihienra()
        odiakia.Enabled = True
        Timer1.Stop()
        prquet2.kqquet.Visible = False
        icosac.BorderStyle = Drawing2D.DashStyle.Solid
        Me.Enabled = True
        lbs1.Text = 0
        ix = 0
        canhbao.Hide()
        Me.Show()
        Me.Text = myname
        '  covs.Text = "false"
        hienravs.Stop()
    End Sub
    Private Sub odiakia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles odiakia.SelectedIndexChanged
        lbs1.Text = 0
        lists.Items.Clear()
        virusa.Items.Clear()
        lbvs.Text = "0"
        theodoi.EnableRaisingEvents = False
        theodoi.IncludeSubdirectories = False
    End Sub

    Private Sub ol1_Click(sender As Object, e As EventArgs) Handles ol1.Click
        Try

            If maychuonline.Text = "Chọn máy chủ Quét Online" Then
                MsgBox("Bạn chưa chọn máy chủ để quét!", vbInformation, "Thông báo")
            Else
                Dim servers As String = maychuonline.Text
                'https://luutru360.com/namvirus/tinhtrang.txt

                If servers = "Máy chủ Lưu Trữ 360" Then
                    Dim checksv As String = New System.Net.WebClient().DownloadString(sv1 + "/namvirus/tinhtrang.txt")
                    If checksv = "online" Then
                        If odiakia.Text = "Chọn ổ đĩa quét" Then
                            MsgBox("Bạn vui lòng chọn ổ đĩa!", vbInformation, "Thông báo")
                        Else
                            'quet online sv1
                            Try
                                Me.Enabled = False
                                canhbao.Show()
                                odiakia.Enabled = False
                                Timer1.Start()
                                lbvs.Text = "0"
                                For Each dr As String In Directory.GetDirectories(odiakia.Text)

                                    Dim listFile As String() = Directory.GetFiles(dr)
                                    For Each fi As String In listFile
                                        lists.Items.Add(fi)
                                    Next
                                    lbs.Text = lists.Items.Count + 1
                                    quet1.Start()

                                Next

                            Catch

                            End Try
                            'end sv1
                        End If
                    Else
                        MsgBox("Máy chủ này hiện không hoạt động!", vbInformation, "Thông báo")
                    End If
                ElseIf servers = "Máy chủ Presscoder" Then
                    Dim checksv2 As String = New System.Net.WebClient().DownloadString(sv2 + "/namvirus/tinhtrang.txt")
                    If checksv2 = "online" Then
                        If odiakia.Text = "Chọn ổ đĩa quét" Then
                            MsgBox("Bạn vui lòng chọn ổ đĩa!", vbInformation, "Thông báo")
                        Else
                            'quet online sv2
                            Try
                                Me.Enabled = False
                                canhbao.Show()
                                odiakia.Enabled = False
                                Timer1.Start()
                                lbvs.Text = "0"
                                For Each dr As String In Directory.GetDirectories(odiakia.Text)

                                    Dim listFile As String() = Directory.GetFiles(dr)
                                    For Each fi As String In listFile
                                        lists.Items.Add(fi)
                                    Next
                                    lbs.Text = lists.Items.Count + 1
                                    quet2.Start()

                                Next

                            Catch

                            End Try
                            'end sv2
                        End If
                    Else
                        MsgBox("Máy chủ này hiện không hoạt động!", vbInformation, "Thông báo")
                    End If
                ElseIf servers = "Máy chủ 4Online" Then
                    Dim checksv3 As String = New System.Net.WebClient().DownloadString(sv3 + "/namvirus/tinhtrang.txt")
                    If checksv3 = "online" Then

                    Else
                        MsgBox("Máy chủ này hiện không hoạt động!", vbInformation, "Thông báo")
                    End If
                Else

                End If


            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub maychuonline_SelectedIndexChanged(sender As Object, e As EventArgs) Handles maychuonline.SelectedIndexChanged
        lbs1.Text = 0
        lists.Items.Clear()
        virusa.Items.Clear()
        thoigianthuc.maychuonline.Text = maychuonline.Text
        lbvs.Text = "0"
    End Sub

    Private Sub quet1_Tick(sender As Object, e As EventArgs) Handles quet1.Tick

        lbs1.Text = lbs1.Text + 1
        '  lists.SelectedItem(lbs1.Text)
        '  If lbs1.Text >= lbs.Text Then

        Try
            lists.SelectedIndex = lists.SelectedIndex + 1
        Catch

            hienravs.Start()

            quet1.Stop()
        End Try
        Dim paths1 As String = lists.Text
        Me.Text = paths1
        Dim md5 As New MD5CryptoServiceProvider

        Try
            Dim f As New FileStream(paths1, FileMode.Open, FileAccess.Read, FileShare.Read, &H2000)
            f = New FileStream(paths1, FileMode.Open, FileAccess.Read, FileShare.Read, &H2000)
            md5.ComputeHash(f)

            ' MsgBox(md5)
            Dim hash As Byte() = md5.Hash
            Dim buff As New StringBuilder
            Dim hashByte As Byte
            For Each hashByte In hash
                buff.Append(String.Format("{0:X2}", hashByte))
            Next


            'check may chu virus sv1
            Dim check1s As String = New System.Net.WebClient().DownloadString(sv1 + "/namvirus/index.php?mdh5=" + buff.ToString & "&madoc=bon7chin10bababaOPPO!")
            ' TextBox1.Text = sv1 + "/namvirus/index.php?mdh5=" + buff.ToString + "&madoc=bon7chin10bababaOPPO!"
            If check1s = "ok" Then
                virusa.Items.Add(paths1)
                covs.Text = "true"
                icosac.BorderColor = Color.Red
            End If
            'end check sv1
        Catch
            '   MsgBox("Có tập tin không thể quét!")
            lbs1.Text = lbs1.Text + 1
            Try
                lists.SelectedIndex = lists.SelectedIndex + 1
            Catch
                hienravs.Start()

                quet1.Stop()
            End Try
        End Try
        '   Else
        '   scan1.Stop()
        '   End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim folderDlg As New FolderBrowserDialog
        folderDlg.ShowNewFolderButton = True
        If (folderDlg.ShowDialog() = DialogResult.OK) Then
            lists.Items.Clear()
            campa.Text = folderDlg.SelectedPath
            Dim root As Environment.SpecialFolder = folderDlg.RootFolder
            'lay file
            Me.Enabled = False
            canhbao.Show()
            odiakia.Enabled = False
            Timer1.Start()
            lbvs.Text = "0"
            quet.Text = "Quét"
            icosac.BorderColor = Color.Lime
            Try
                For Each dr As String In Directory.GetDirectories(campa.Text)

                    Dim listFile As String() = Directory.GetFiles(dr)
                    For Each fi As String In listFile
                        lists.Items.Add(fi)
                    Next
                    lbs.Text = lists.Items.Count + 1
                    scan1.Start()

                Next
                'het lay file
            Catch

            End Try
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If mofile.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            lists.Items.Add(mofile.FileName)
            'lay file
            Me.Enabled = False
            canhbao.Show()
            odiakia.Enabled = False
            Timer1.Start()
            lbvs.Text = "0"
            quet.Text = "Quét"
            icosac.BorderColor = Color.Lime


            lbs.Text = lists.Items.Count + 1
            scan1.Start()

            'het lay file

        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try

            If maychuonline.Text = "Chọn máy chủ Quét Online" Then
                MsgBox("Bạn chưa chọn máy chủ để quét!", vbInformation, "Thông báo")
            Else
                Dim servers As String = maychuonline.Text
                'https://luutru360.com/namvirus/tinhtrang.txt

                If servers = "Máy chủ Lưu Trữ 360" Then
                    Dim checksv As String = New System.Net.WebClient().DownloadString(sv1 + "/namvirus/tinhtrang.txt")
                    If checksv = "online" Then

                        'quet online sv1
                        Try

                            Dim folderDlg As New FolderBrowserDialog
                            folderDlg.ShowNewFolderButton = True
                            If (folderDlg.ShowDialog() = DialogResult.OK) Then
                                lists.Items.Clear()
                                campa.Text = folderDlg.SelectedPath
                                Dim root As Environment.SpecialFolder = folderDlg.RootFolder
                                'lay file
                                Me.Enabled = False
                                canhbao.Show()
                                odiakia.Enabled = False
                                Timer1.Start()
                                lbvs.Text = "0"
                                quet.Text = "Quét"
                                icosac.BorderColor = Color.Lime
                                Try
                                    For Each dr As String In Directory.GetDirectories(campa.Text)

                                        Dim listFile As String() = Directory.GetFiles(dr)
                                        For Each fi As String In listFile
                                            lists.Items.Add(fi)
                                        Next
                                        lbs.Text = lists.Items.Count + 1
                                        quet1.Start()

                                    Next
                                    'het lay file
                                Catch

                                End Try
                            End If

                        Catch

                        End Try
                        'end sv1

                    Else
                        MsgBox("Máy chủ này hiện không hoạt động!", vbInformation, "Thông báo")
                    End If
                ElseIf servers = "Máy chủ Presscoder" Then
                    Dim checksv2 As String = New System.Net.WebClient().DownloadString(sv2 + "/namvirus/tinhtrang.txt")
                    If checksv2 = "online" Then

                        'quet online sv2
                        Try

                            Dim folderDlg As New FolderBrowserDialog
                            folderDlg.ShowNewFolderButton = True
                            If (folderDlg.ShowDialog() = DialogResult.OK) Then
                                lists.Items.Clear()
                                campa.Text = folderDlg.SelectedPath
                                Dim root As Environment.SpecialFolder = folderDlg.RootFolder
                                'lay file
                                Me.Enabled = False
                                canhbao.Show()
                                odiakia.Enabled = False
                                Timer1.Start()
                                lbvs.Text = "0"
                                quet.Text = "Quét"
                                icosac.BorderColor = Color.Lime
                                Try
                                    For Each dr As String In Directory.GetDirectories(campa.Text)

                                        Dim listFile As String() = Directory.GetFiles(dr)
                                        For Each fi As String In listFile
                                            lists.Items.Add(fi)
                                        Next
                                        lbs.Text = lists.Items.Count + 1
                                        quet2.Start()

                                    Next
                                    'het lay file
                                Catch

                                End Try
                            End If

                        Catch

                        End Try
                        'end sv2
                    Else
                        MsgBox("Máy chủ này hiện không hoạt động!", vbInformation, "Thông báo")
                    End If
                ElseIf servers = "Máy chủ 4Online" Then
                    Dim checksv3 As String = New System.Net.WebClient().DownloadString(sv3 + "/namvirus/tinhtrang.txt")
                    If checksv3 = "online" Then

                        'quet online sv3
                        Try

                            Dim folderDlg As New FolderBrowserDialog
                            folderDlg.ShowNewFolderButton = True
                            If (folderDlg.ShowDialog() = DialogResult.OK) Then
                                lists.Items.Clear()
                                campa.Text = folderDlg.SelectedPath
                                Dim root As Environment.SpecialFolder = folderDlg.RootFolder
                                'lay file
                                Me.Enabled = False
                                canhbao.Show()
                                odiakia.Enabled = False
                                Timer1.Start()
                                lbvs.Text = "0"
                                quet.Text = "Quét"
                                icosac.BorderColor = Color.Lime
                                Try
                                    For Each dr As String In Directory.GetDirectories(campa.Text)

                                        Dim listFile As String() = Directory.GetFiles(dr)
                                        For Each fi As String In listFile
                                            lists.Items.Add(fi)
                                        Next
                                        lbs.Text = lists.Items.Count + 1
                                        quet2.Start()

                                    Next
                                    'het lay file
                                Catch

                                End Try
                            End If

                        Catch

                        End Try
                        'end sv3
                    Else
                        MsgBox("Máy chủ này hiện không hoạt động!", vbInformation, "Thông báo")
                    End If
                Else

                End If


            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Try

            If maychuonline.Text = "Chọn máy chủ Quét Online" Then
                MsgBox("Bạn chưa chọn máy chủ để quét!", vbInformation, "Thông báo")
            Else
                Dim servers As String = maychuonline.Text
                'https://luutru360.com/namvirus/tinhtrang.txt

                If servers = "Máy chủ Lưu Trữ 360" Then
                    Dim checksv As String = New System.Net.WebClient().DownloadString(sv1 + "/namvirus/tinhtrang.txt")
                    If checksv = "online" Then

                        'quet online sv1
                        Try

                            If mofile.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
                                lists.Items.Add(mofile.FileName)
                                'lay file
                                Me.Enabled = False
                                canhbao.Show()
                                odiakia.Enabled = False
                                Timer1.Start()
                                lbvs.Text = "0"
                                quet.Text = "Quét"
                                icosac.BorderColor = Color.Lime


                                lbs.Text = lists.Items.Count + 1
                                quet1.Start()

                                'het lay file
                            End If

                        Catch

                        End Try
                        'end sv1

                    Else
                        MsgBox("Máy chủ này hiện không hoạt động!", vbInformation, "Thông báo")
                    End If
                ElseIf servers = "Máy chủ Presscoder" Then
                    Dim checksv2 As String = New System.Net.WebClient().DownloadString(sv2 + "/namvirus/tinhtrang.txt")
                    If checksv2 = "online" Then

                    Else
                        MsgBox("Máy chủ này hiện không hoạt động!", vbInformation, "Thông báo")
                    End If
                ElseIf servers = "Máy chủ 4Online" Then
                    Dim checksv3 As String = New System.Net.WebClient().DownloadString(sv3 + "/namvirus/tinhtrang.txt")
                    If checksv3 = "online" Then

                    Else
                        MsgBox("Máy chủ này hiện không hoạt động!", vbInformation, "Thông báo")
                    End If
                Else

                End If


            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub

    Private Sub quet2_Tick(sender As Object, e As EventArgs) Handles quet2.Tick

        lbs1.Text = lbs1.Text + 1
        '  lists.SelectedItem(lbs1.Text)
        '  If lbs1.Text >= lbs.Text Then

        Try
            lists.SelectedIndex = lists.SelectedIndex + 1
        Catch

            hienravs.Start()

            quet2.Stop()
        End Try
        Dim paths1 As String = lists.Text
        Me.Text = paths1
        Dim md5 As New MD5CryptoServiceProvider

        Try
            Dim f As New FileStream(paths1, FileMode.Open, FileAccess.Read, FileShare.Read, &H2000)
            f = New FileStream(paths1, FileMode.Open, FileAccess.Read, FileShare.Read, &H2000)
            md5.ComputeHash(f)

            ' MsgBox(md5)
            Dim hash As Byte() = md5.Hash
            Dim buff As New StringBuilder
            Dim hashByte As Byte
            For Each hashByte In hash
                buff.Append(String.Format("{0:X2}", hashByte))
            Next


            'check may chu virus sv2
            Dim check2s As String = New System.Net.WebClient().DownloadString(sv2 + "/namvirus/index.php?mdh5=" + buff.ToString & "&madoc=bon7chin10bababaOPPO!")
            ' TextBox1.Text = sv2 + "/namvirus/index.php?mdh5=" + buff.ToString + "&madoc=bon7chin10bababaOPPO!"
            If check2s = "ok" Then
                virusa.Items.Add(paths1)
                covs.Text = "true"
                icosac.BorderColor = Color.Red
            End If
            'end check sv2
        Catch
            '   MsgBox("Có tập tin không thể quét!")
            lbs1.Text = lbs1.Text + 1
            Try
                lists.SelectedIndex = lists.SelectedIndex + 1
            Catch
                hienravs.Start()

                quet2.Stop()
            End Try
        End Try
        '   Else
        '   scan1.Stop()
        '   End If
    End Sub



    Private Sub offhien_Click(sender As Object, e As EventArgs) Handles offhien.Click
        'theodoi.EnableRaisingEvents = False
        '  theodoi.IncludeSubdirectories = False
        thoigianthuc.theodoi.EnableRaisingEvents = True
        thoigianthuc.theodoi.IncludeSubdirectories = True
        thoigianthuc.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        vss.Items.Clear()
        thoigianthuc.ListBox1.Items.Clear()
    End Sub
End Class
