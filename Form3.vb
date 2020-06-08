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
End Class