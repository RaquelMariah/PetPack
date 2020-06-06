Public Class FormLoginScreen
    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        Dim FormMain = New FormMainScreen()
        FormMain.Show()
    End Sub
End Class