Public Class sosanh
    Dim sv1 As String = "http://luutru360.com"
    Dim sv2 As String = "http://presscoder.net"
    Dim sv3 As String = "http://4online.net"
    Private Sub sosanh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sosanh2()
    End Sub

    Sub sosanh2()

        Try
                Dim checksv1 As String = New System.Net.WebClient().DownloadString(sv1 + "/namvirus/tinhtrang.txt")
                If checksv1 = "online" Then

                Else
                    kn1.Visible = True
                End If
            Catch
                Dim checksv1 As String
                kn1.Visible = True
            End Try
            Try
                Dim checksv2 As String = New System.Net.WebClient().DownloadString(sv2 + "/namvirus/tinhtrang.txt")

                If checksv2 = "online" Then

                Else
                    kn2.Visible = True
                End If
            Catch
                Dim checksv2 As String
                kn2.Visible = True
            End Try
            Try
            Dim checksv3 As String = New System.Net.WebClient().DownloadString(sv3 + "/namvirus/tinhtrang.txt")
            If checksv3 = "online" Then

            Else
                kn3.Visible = True
            End If
        Catch
                Dim checksv3 As String
                kn3.Visible = True
            End Try



    End Sub
End Class