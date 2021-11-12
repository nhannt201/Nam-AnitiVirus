Public Class canhbao
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub stopok_Click(sender As Object, e As EventArgs) Handles stopok.Click
        home.Timer1.Stop()
        home.scan1.Stop()
        ' home.Timer1.Stop()
    End Sub
End Class