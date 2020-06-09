Public Class FormMainScreen
    Private Sub FormMainScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        Me.Close()
        'Inserir dialog p/ confirmar ação
    End Sub

    Private Sub VacinasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VacinasToolStripMenuItem.Click
        Dim FormTabVac = New FormTabelaVacinas()
        FormTabVac.Show()
    End Sub

    Private Sub BanhoETosaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BanhoETosaToolStripMenuItem.Click
        Dim FormTabBanho = New FormTabelaBanhoTosa()
        FormTabBanho.Show()
    End Sub

    Private Sub ConsultaVeterinárioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaVeterinárioToolStripMenuItem.Click
        Dim FormTabConsultaVet = New FormTabConsultaVeterinario()
        FormTabConsultaVet.Show()

    End Sub

    Private Sub TaxiPetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TaxiPetToolStripMenuItem.Click
        Dim FormTabTaxi = New FormTabTaxiPet()
        FormTabTaxi.Show()
    End Sub

    Private Sub PacotesPromocionaisToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PacotesPromocionaisToolStripMenuItem.Click
        Dim FormPacPromo = New FormTabPacPromocionais()
        FormPacPromo.Show()
    End Sub

    Private Sub PlanoVIPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlanoVIPToolStripMenuItem.Click
        Dim FormTabVip = New FormTabPlanoVip()
        FormTabVip.Show()
    End Sub

    Private Sub PróximasConsultasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PróximasConsultasToolStripMenuItem.Click
        Dim FormProxCons = New FormProximasConsultas()
        FormProxCons.Show()
    End Sub

    Private Sub DesmarcarConsultaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DesmarcarConsultaToolStripMenuItem.Click
        Dim FormDesmarcConsulta = New FormDesmarcarConsulta()
        FormDesmarcConsulta.Show()
    End Sub

    Private Sub ReagendarConsultaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReagendarConsultaToolStripMenuItem.Click
        Dim FormReConsulta = New FormReagendarConsulta()
        FormReConsulta.Show()
    End Sub

    Private Sub ConsultarPedidosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarPedidosToolStripMenuItem.Click
        Dim FormConsPedido = New FormConsultarPedidos()
        FormConsPedido.Show()
    End Sub

    Private Sub ProdutosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProdutosToolStripMenuItem.Click
        Dim FormDescProd = New FormDescontoProdutos()
        FormDescProd.Show()
    End Sub
    Private Sub BanhoETosaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BanhoETosaToolStripMenuItem1.Click
        Dim FormDescBanho = New FormDescBanho()
        FormDescBanho.Show()
    End Sub

    Private Sub ConsultaVeterinárioToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ConsultaVeterinárioToolStripMenuItem1.Click
        Dim FormDescVet = New FormDescConsultaVeterinario()
        FormDescVet.Show()
    End Sub

    Private Sub TáxiPetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TáxiPetToolStripMenuItem.Click
        Dim FormDescPet = New FormDescTaxiPet()
        FormDescPet.Show()
    End Sub

    Private Sub PlanoVIPToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PlanoVIPToolStripMenuItem1.Click
        Dim FormDescVip = New FormDescPlanoVIP()
        FormDescVip.Show()
    End Sub
    Private Sub DescontoPFuncionárioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DescontoPFuncionárioToolStripMenuItem.Click
        Dim FormDescFunc = New FormDescFuncionario()
        FormDescFunc.Show()
    End Sub

    Private Sub RelatóriosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RelatóriosToolStripMenuItem.Click
        Dim FormRelatAtend = New FormRelatorioAtendimento()
        FormRelatAtend.Show()
    End Sub
    Private Sub AtendimentoEmergencialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AtendimentoEmergencialToolStripMenuItem.Click
        Dim FormAtendEmerg = New FormAtendimentoEmergencial()
        FormAtendEmerg.Show()
    End Sub

    Private Sub CadastrarClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastrarClienteToolStripMenuItem.Click
        Dim FormCadCliente = New FormCadastroCliente()
        FormCadCliente.Show()
    End Sub

    Private Sub ConsultarCadastroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarCadastroToolStripMenuItem.Click
        Dim FormConsCad = New FormConsultaCadastro()
        FormConsCad.Show()
    End Sub

    Private Sub RegistrarVendaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarVendaToolStripMenuItem.Click
        Dim FormRegVenda = New FormRegistarVenda()
        FormRegVenda.Show()
    End Sub

    Private Sub ConsultarVendaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarVendaToolStripMenuItem.Click
        Dim FormConsVenda = New FormConsultarVenda()
        FormConsVenda.Show()
    End Sub
    Private Sub ConsultarEstoqueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarEstoqueToolStripMenuItem.Click
        Dim FormConsEstoque = New FormConsultarVenda()
        FormConsEstoque.Show()
    End Sub

    Private Sub RelatóriosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RelatóriosToolStripMenuItem1.Click
        Dim FormRelatVendas = New FormRelatVendas()
        FormRelatVendas.Show()
    End Sub

    Private Sub RecebimentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecebimentoToolStripMenuItem.Click
        Dim FormRecebEst = New FormRecebEstoque()
        FormRecebEst.Show()
    End Sub

    Private Sub RelatóriosToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles RelatóriosToolStripMenuItem2.Click
        Dim FormRelatEstoque = New FormRelatEstoque()
        FormRelatEstoque.Show()
    End Sub

    Private Sub EditarUsuárioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarUsuárioToolStripMenuItem.Click

    End Sub
End Class