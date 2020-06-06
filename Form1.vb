Public Class FormSplashScreen
    Private Sub FormSplashScreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()

    End Sub
    Public Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(10)
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            'call login screen here
            Dim FormSplash = New FormSplashScreen()
            FormSplash.Close()
            Dim FormLogin = New FormLoginScreen()
            FormLogin.Show()
        End If

    End Sub

End Class
