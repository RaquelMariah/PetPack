Public Class FormRecebEstoque
    Private Sub FormRecebEstoque_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimerRecebimento.Start()
    End Sub

    Private Sub TimerRecebimento_Tick(sender As Object, e As EventArgs) Handles TimerRecebimento.Tick
        lbl_data.Text = Date.Today()
        lbl_hora.Text = DateTime.Now()
    End Sub
End Class