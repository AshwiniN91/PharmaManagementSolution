Public Class Splash
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Myprogressbar.Increment(1)
        If Myprogressbar.Value = 100 Then
            Me.Hide()
            Dim log = New Login
            log.Show()
            Timer1.Enabled() = False
        End If


    End Sub

    Private Sub Myprogressbar_Click(sender As Object, e As EventArgs) Handles Myprogressbar.Click
        Timer1.Start()

    End Sub
End Class
