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

Public Class home2
    Dim sv1 As String = "http://luutru360.com/"
    Dim sv2 As String = "http://presscoder.net/"
    '  Dim sv3 As String = "http://4online.net/"
    Dim mbox As New ListBox
    Private Sub exitfr_Click(sender As Object, e As EventArgs) Handles exitfr.Click
        End
    End Sub

    Private Sub exitfr_MouseMove(sender As Object, e As MouseEventArgs) Handles exitfr.MouseMove
        exitfr.BackColor = Color.Red
    End Sub

    Private Sub home2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each drivver As IO.DriveInfo In IO.DriveInfo.GetDrives
            Dim tenodia As String = drivver.Name
            mbox.Items.Add(tenodia)
        Next
    End Sub

    Private Sub home2_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        exitfr.BackColor = Color.LightCoral
        exitfr.BackColor = Color.DarkTurquoise
    End Sub

    Private Sub mimifr_Click(sender As Object, e As EventArgs) Handles mimifr.Click
        Try
            Me.WindowState = FormWindowState.Minimized
            If Me.WindowState = FormWindowState.Minimized Then
                If Me IsNot Nothing Then
                    If Me.Tag Is "StorePage" Then
                        Me.WindowState = FormWindowState.Minimized
                    End If
                End If
            End If
        Catch
        End Try
        Try
            If Me.WindowState = FormWindowState.Maximized Then
                If Me IsNot Nothing Then
                    If Me.Tag Is "StorePage" Then
                        Me.WindowState = FormWindowState.Maximized
                    End If
                End If
            End If
        Catch
        End Try
    End Sub

    Private Sub mimifr_MouseMove(sender As Object, e As MouseEventArgs) Handles mimifr.MouseMove
        exitfr.BackColor = Color.Aqua
        'exitfr.BackColor = Color.DarkTurquoise
    End Sub

    Private Sub quetsystem_Click(sender As Object, e As EventArgs) Handles quetsystem.Click
        home.lists.Items.Clear()

        prquet2.Show()
        Me.Enabled = False

        Try
            '  Me.Enabled = False
            canhbao.Show()
            ' odiakia.Enabled = False
            'Timer1.Start()
            '       lbvs.Text = "0"
            'quet.Text = "Quét"
            '   icosac.BorderColor = Color.Lime
            For Each dr As String In Directory.GetDirectories("C:\Windows")

                Dim listFile As String() = Directory.GetFiles(dr)
                    For Each fi As String In listFile
                        home.lists.Items.Add(fi)
                    Next

                'lbs.Text = lists.Items.Count + 1
                home.scan1.Start()

                Next

        Catch

        End Try

    End Sub
End Class