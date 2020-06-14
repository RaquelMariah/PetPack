Public Class FormCadastroCliente

    Private Sub Carregar_foto_cli_Click(sender As Object, e As EventArgs) Handles carregar_foto_cli.Click
        Try
            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                carregar_foto_cli.Load(Me.OpenFileDialog1.FileName)
            Else
                MsgBox("Por favor escolha uma foto!")
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub carrega_foto_pet_Click(sender As Object, e As EventArgs) Handles carrega_foto_pet.Click
        Try
            If OpenFileDialog2.ShowDialog() = DialogResult.OK Then
                carrega_foto_pet.Load(Me.OpenFileDialog2.FileName)
            Else
                MsgBox("Por favor escolha uma foto!")
            End If

        Catch ex As Exception

        End Try
    End Sub
End Class