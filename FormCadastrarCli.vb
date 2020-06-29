Public Class FormCadastroCliente

    Private Sub Carregar_foto_cli_Click(sender As Object, e As EventArgs) Handles carregar_foto_cli.Click
        Try
            With carregar_foto_cli
                If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                    carregar_foto_cli.Load(Me.OpenFileDialog1.FileName)
                Else
                    MsgBox("Por favor escolha uma foto!")
                End If
            End With
        Catch ex As Exception
            MsgBox("Não foi possível concluir a solicitação!")
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

    Private Sub Label32_Click(sender As Object, e As EventArgs) Handles Label32.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) 

    End Sub

    Private Sub txt_cep_cliente_cadast_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txt_cep_cliente_cadast.MaskInputRejected
        Try
            sql = "select * from tb_cep-'" & txt_cep_cliente_cadast.Text & "'"

        Catch ex As Exception

        End Try
    End Sub

End Class