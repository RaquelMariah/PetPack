<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCadastroCliente
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCadastroCliente))
        Me.tabControl_cliente_cadastro = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btn_excluir_cliente_cadast = New System.Windows.Forms.Button()
        Me.btn_editar_cliente_cadast = New System.Windows.Forms.Button()
        Me.btn_salvar_cliente_cadast = New System.Windows.Forms.Button()
        Me.carregar_foto_cli = New System.Windows.Forms.PictureBox()
        Me.txt_uf_cliente_cadast = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_cidade_cliente_cadast = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_bairro_cliente_cadast = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_endereco_cliente_cadast = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_cep_cliente_cadast = New System.Windows.Forms.MaskedTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_texcel2_cliente_cadast = New System.Windows.Forms.MaskedTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_telcel1_cliente_cadast = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_telfixo_cliente_cadast = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtp_nasc_cliente_cadast = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmb_orgao_cliente_cadast = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_rg_cliente_cadast = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_cpf_cliente_cadast = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_nome_cliente_cadast = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.cmbMaisPet = New System.Windows.Forms.ComboBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.cmb_adestrado_pet_cadast = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_altura_pet_cadast = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.cmb_porte_pet_cadast = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cmb_sexo_pet_cadast = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_idade_pet_cadast = New System.Windows.Forms.TextBox()
        Me.txt_cor_pet_cadast = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txt_raca_pet_cadast = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txt_tipo_pet_cadast = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.carrega_foto_pet = New System.Windows.Forms.PictureBox()
        Me.txt_obs_pet_cadast = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_peso_pet_cadast = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.dtp_nasc_pet_cadast = New System.Windows.Forms.DateTimePicker()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cmb_microchip_pet_cadast = New System.Windows.Forms.ComboBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txt_rgcua_pet_cadast = New System.Windows.Forms.MaskedTextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txt_nmicrochip_pet_cadast = New System.Windows.Forms.MaskedTextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txt_nome_pet_cadast = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.cmb_modalidade_cadast = New System.Windows.Forms.ComboBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.cmb_formapagamento_cadast = New System.Windows.Forms.ComboBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txt_obs_cadast = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txt_exigencias_cadast = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.txt_vigencia_cadast = New System.Windows.Forms.TextBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.cmb_planoadq_cadast = New System.Windows.Forms.ComboBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.txt_medicamentos_cadast = New System.Windows.Forms.TextBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.cbm_historicomedico_cadast = New System.Windows.Forms.ComboBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.txt_patologias_cadast = New System.Windows.Forms.TextBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.tabControl_cliente_cadastro.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.carregar_foto_cli, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.carrega_foto_pet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabControl_cliente_cadastro
        '
        Me.tabControl_cliente_cadastro.Controls.Add(Me.TabPage1)
        Me.tabControl_cliente_cadastro.Controls.Add(Me.TabPage2)
        Me.tabControl_cliente_cadastro.Controls.Add(Me.TabPage3)
        Me.tabControl_cliente_cadastro.Location = New System.Drawing.Point(27, 21)
        Me.tabControl_cliente_cadastro.Name = "tabControl_cliente_cadastro"
        Me.tabControl_cliente_cadastro.SelectedIndex = 0
        Me.tabControl_cliente_cadastro.Size = New System.Drawing.Size(509, 422)
        Me.tabControl_cliente_cadastro.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btn_excluir_cliente_cadast)
        Me.TabPage1.Controls.Add(Me.btn_editar_cliente_cadast)
        Me.TabPage1.Controls.Add(Me.btn_salvar_cliente_cadast)
        Me.TabPage1.Controls.Add(Me.carregar_foto_cli)
        Me.TabPage1.Controls.Add(Me.txt_uf_cliente_cadast)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.txt_cidade_cliente_cadast)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.txt_bairro_cliente_cadast)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.txt_endereco_cliente_cadast)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.txt_cep_cliente_cadast)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.txt_texcel2_cliente_cadast)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.txt_telcel1_cliente_cadast)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.txt_telfixo_cliente_cadast)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.dtp_nasc_cliente_cadast)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.cmb_orgao_cliente_cadast)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.txt_rg_cliente_cadast)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.txt_cpf_cliente_cadast)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.txt_nome_cliente_cadast)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(501, 396)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Dados Pessoais"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btn_excluir_cliente_cadast
        '
        Me.btn_excluir_cliente_cadast.BackColor = System.Drawing.Color.Pink
        Me.btn_excluir_cliente_cadast.Location = New System.Drawing.Point(354, 329)
        Me.btn_excluir_cliente_cadast.Name = "btn_excluir_cliente_cadast"
        Me.btn_excluir_cliente_cadast.Size = New System.Drawing.Size(129, 44)
        Me.btn_excluir_cliente_cadast.TabIndex = 30
        Me.btn_excluir_cliente_cadast.Text = "EXCLUIR"
        Me.btn_excluir_cliente_cadast.UseVisualStyleBackColor = False
        '
        'btn_editar_cliente_cadast
        '
        Me.btn_editar_cliente_cadast.BackColor = System.Drawing.Color.LightBlue
        Me.btn_editar_cliente_cadast.Location = New System.Drawing.Point(181, 329)
        Me.btn_editar_cliente_cadast.Name = "btn_editar_cliente_cadast"
        Me.btn_editar_cliente_cadast.Size = New System.Drawing.Size(136, 44)
        Me.btn_editar_cliente_cadast.TabIndex = 29
        Me.btn_editar_cliente_cadast.Text = "EDITAR"
        Me.btn_editar_cliente_cadast.UseVisualStyleBackColor = False
        '
        'btn_salvar_cliente_cadast
        '
        Me.btn_salvar_cliente_cadast.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btn_salvar_cliente_cadast.Location = New System.Drawing.Point(12, 329)
        Me.btn_salvar_cliente_cadast.Name = "btn_salvar_cliente_cadast"
        Me.btn_salvar_cliente_cadast.Size = New System.Drawing.Size(143, 44)
        Me.btn_salvar_cliente_cadast.TabIndex = 28
        Me.btn_salvar_cliente_cadast.Text = "SALVAR"
        Me.btn_salvar_cliente_cadast.UseVisualStyleBackColor = False
        '
        'carregar_foto_cli
        '
        Me.carregar_foto_cli.BackgroundImage = CType(resources.GetObject("carregar_foto_cli.BackgroundImage"), System.Drawing.Image)
        Me.carregar_foto_cli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.carregar_foto_cli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.carregar_foto_cli.Location = New System.Drawing.Point(363, 49)
        Me.carregar_foto_cli.Name = "carregar_foto_cli"
        Me.carregar_foto_cli.Size = New System.Drawing.Size(120, 111)
        Me.carregar_foto_cli.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.carregar_foto_cli.TabIndex = 27
        Me.carregar_foto_cli.TabStop = False
        '
        'txt_uf_cliente_cadast
        '
        Me.txt_uf_cliente_cadast.Location = New System.Drawing.Point(242, 200)
        Me.txt_uf_cliente_cadast.Name = "txt_uf_cliente_cadast"
        Me.txt_uf_cliente_cadast.Size = New System.Drawing.Size(96, 20)
        Me.txt_uf_cliente_cadast.TabIndex = 9
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(239, 183)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(24, 13)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "UF:"
        '
        'txt_cidade_cliente_cadast
        '
        Me.txt_cidade_cliente_cadast.Location = New System.Drawing.Point(199, 291)
        Me.txt_cidade_cliente_cadast.Name = "txt_cidade_cliente_cadast"
        Me.txt_cidade_cliente_cadast.Size = New System.Drawing.Size(135, 20)
        Me.txt_cidade_cliente_cadast.TabIndex = 12
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(196, 274)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(43, 13)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Cidade:"
        '
        'txt_bairro_cliente_cadast
        '
        Me.txt_bairro_cliente_cadast.Location = New System.Drawing.Point(12, 291)
        Me.txt_bairro_cliente_cadast.Name = "txt_bairro_cliente_cadast"
        Me.txt_bairro_cliente_cadast.Size = New System.Drawing.Size(153, 20)
        Me.txt_bairro_cliente_cadast.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(9, 274)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 13)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Bairro:"
        '
        'txt_endereco_cliente_cadast
        '
        Me.txt_endereco_cliente_cadast.Location = New System.Drawing.Point(12, 251)
        Me.txt_endereco_cliente_cadast.Name = "txt_endereco_cliente_cadast"
        Me.txt_endereco_cliente_cadast.Size = New System.Drawing.Size(322, 20)
        Me.txt_endereco_cliente_cadast.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 234)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(110, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Endereço do Cliente:*"
        '
        'txt_cep_cliente_cadast
        '
        Me.txt_cep_cliente_cadast.Location = New System.Drawing.Point(130, 200)
        Me.txt_cep_cliente_cadast.Mask = "99999-999"
        Me.txt_cep_cliente_cadast.Name = "txt_cep_cliente_cadast"
        Me.txt_cep_cliente_cadast.Size = New System.Drawing.Size(93, 20)
        Me.txt_cep_cliente_cadast.TabIndex = 8
        Me.txt_cep_cliente_cadast.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(127, 183)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(28, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "CEP"
        '
        'txt_texcel2_cliente_cadast
        '
        Me.txt_texcel2_cliente_cadast.Location = New System.Drawing.Point(12, 200)
        Me.txt_texcel2_cliente_cadast.Mask = "(99)99999-9999"
        Me.txt_texcel2_cliente_cadast.Name = "txt_texcel2_cliente_cadast"
        Me.txt_texcel2_cliente_cadast.Size = New System.Drawing.Size(93, 20)
        Me.txt_texcel2_cliente_cadast.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 183)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Celular (2)"
        '
        'txt_telcel1_cliente_cadast
        '
        Me.txt_telcel1_cliente_cadast.Location = New System.Drawing.Point(242, 147)
        Me.txt_telcel1_cliente_cadast.Mask = "(99)99999-9999"
        Me.txt_telcel1_cliente_cadast.Name = "txt_telcel1_cliente_cadast"
        Me.txt_telcel1_cliente_cadast.Size = New System.Drawing.Size(96, 20)
        Me.txt_telcel1_cliente_cadast.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(239, 130)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Celular"
        '
        'txt_telfixo_cliente_cadast
        '
        Me.txt_telfixo_cliente_cadast.Location = New System.Drawing.Point(130, 147)
        Me.txt_telfixo_cliente_cadast.Mask = "(99)9999-9999"
        Me.txt_telfixo_cliente_cadast.Name = "txt_telfixo_cliente_cadast"
        Me.txt_telfixo_cliente_cadast.Size = New System.Drawing.Size(93, 20)
        Me.txt_telfixo_cliente_cadast.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(127, 130)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Telefone (Fixo)"
        '
        'dtp_nasc_cliente_cadast
        '
        Me.dtp_nasc_cliente_cadast.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_nasc_cliente_cadast.Location = New System.Drawing.Point(12, 147)
        Me.dtp_nasc_cliente_cadast.MaxDate = New Date(9950, 12, 31, 0, 0, 0, 0)
        Me.dtp_nasc_cliente_cadast.MinDate = New Date(1950, 12, 31, 0, 0, 0, 0)
        Me.dtp_nasc_cliente_cadast.Name = "dtp_nasc_cliente_cadast"
        Me.dtp_nasc_cliente_cadast.Size = New System.Drawing.Size(104, 20)
        Me.dtp_nasc_cliente_cadast.TabIndex = 4
        Me.dtp_nasc_cliente_cadast.Value = New Date(2020, 6, 28, 0, 0, 0, 0)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Data de Nascimento:"
        '
        'cmb_orgao_cliente_cadast
        '
        Me.cmb_orgao_cliente_cadast.AutoCompleteCustomSource.AddRange(New String() {"SSP", "Detran", "MTE", "DPF", "ABNC", "CGPI/DUREX/DPF", "CGPI", "CGPMAF", "CNIG", "COREN", "CRA", "CRAS", "CRB", "CRC", "FGTS", "SPTC", "OAB", "SECC", "POM", "(Outro)"})
        Me.cmb_orgao_cliente_cadast.FormattingEnabled = True
        Me.cmb_orgao_cliente_cadast.Items.AddRange(New Object() {"SSP", "Detran", "MTE", "DPF", "ABNC", "CGPI/DUREX/DPF", "CGPI", "CGPMAF", "CNIG", "COREN", "CRA", "CRAS", "CRB", "CRC", "FGTS", "SPTC", "OAB", "IGP", "SECC", "POM", "Outro"})
        Me.cmb_orgao_cliente_cadast.Location = New System.Drawing.Point(242, 93)
        Me.cmb_orgao_cliente_cadast.Name = "cmb_orgao_cliente_cadast"
        Me.cmb_orgao_cliente_cadast.Size = New System.Drawing.Size(96, 21)
        Me.cmb_orgao_cliente_cadast.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(239, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = " Órgão Expedidor:"
        '
        'txt_rg_cliente_cadast
        '
        Me.txt_rg_cliente_cadast.Location = New System.Drawing.Point(130, 93)
        Me.txt_rg_cliente_cadast.Mask = "99,999,999-9"
        Me.txt_rg_cliente_cadast.Name = "txt_rg_cliente_cadast"
        Me.txt_rg_cliente_cadast.Size = New System.Drawing.Size(84, 20)
        Me.txt_rg_cliente_cadast.TabIndex = 2
        Me.txt_rg_cliente_cadast.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(127, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "RG do Cliente:"
        '
        'txt_cpf_cliente_cadast
        '
        Me.txt_cpf_cliente_cadast.Location = New System.Drawing.Point(12, 93)
        Me.txt_cpf_cliente_cadast.Mask = "999,999,999-99"
        Me.txt_cpf_cliente_cadast.Name = "txt_cpf_cliente_cadast"
        Me.txt_cpf_cliente_cadast.Size = New System.Drawing.Size(93, 20)
        Me.txt_cpf_cliente_cadast.TabIndex = 1
        Me.txt_cpf_cliente_cadast.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "CPF do Cliente:*"
        '
        'txt_nome_cliente_cadast
        '
        Me.txt_nome_cliente_cadast.Location = New System.Drawing.Point(9, 49)
        Me.txt_nome_cliente_cadast.Name = "txt_nome_cliente_cadast"
        Me.txt_nome_cliente_cadast.Size = New System.Drawing.Size(329, 20)
        Me.txt_nome_cliente_cadast.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nome do Cliente:*"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.cmbMaisPet)
        Me.TabPage2.Controls.Add(Me.Label32)
        Me.TabPage2.Controls.Add(Me.cmb_adestrado_pet_cadast)
        Me.TabPage2.Controls.Add(Me.Label15)
        Me.TabPage2.Controls.Add(Me.txt_altura_pet_cadast)
        Me.TabPage2.Controls.Add(Me.Label28)
        Me.TabPage2.Controls.Add(Me.cmb_porte_pet_cadast)
        Me.TabPage2.Controls.Add(Me.Label18)
        Me.TabPage2.Controls.Add(Me.cmb_sexo_pet_cadast)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Controls.Add(Me.txt_idade_pet_cadast)
        Me.TabPage2.Controls.Add(Me.txt_cor_pet_cadast)
        Me.TabPage2.Controls.Add(Me.Label21)
        Me.TabPage2.Controls.Add(Me.txt_raca_pet_cadast)
        Me.TabPage2.Controls.Add(Me.Label20)
        Me.TabPage2.Controls.Add(Me.txt_tipo_pet_cadast)
        Me.TabPage2.Controls.Add(Me.Label27)
        Me.TabPage2.Controls.Add(Me.carrega_foto_pet)
        Me.TabPage2.Controls.Add(Me.txt_obs_pet_cadast)
        Me.TabPage2.Controls.Add(Me.Label16)
        Me.TabPage2.Controls.Add(Me.txt_peso_pet_cadast)
        Me.TabPage2.Controls.Add(Me.Label17)
        Me.TabPage2.Controls.Add(Me.Label19)
        Me.TabPage2.Controls.Add(Me.dtp_nasc_pet_cadast)
        Me.TabPage2.Controls.Add(Me.Label22)
        Me.TabPage2.Controls.Add(Me.cmb_microchip_pet_cadast)
        Me.TabPage2.Controls.Add(Me.Label23)
        Me.TabPage2.Controls.Add(Me.txt_rgcua_pet_cadast)
        Me.TabPage2.Controls.Add(Me.Label24)
        Me.TabPage2.Controls.Add(Me.txt_nmicrochip_pet_cadast)
        Me.TabPage2.Controls.Add(Me.Label25)
        Me.TabPage2.Controls.Add(Me.txt_nome_pet_cadast)
        Me.TabPage2.Controls.Add(Me.Label26)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(501, 396)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Pet"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'cmbMaisPet
        '
        Me.cmbMaisPet.AutoCompleteCustomSource.AddRange(New String() {"SSP", "Detran", "MTE", "DPF", "ABNC", "CGPI/DUREX/DPF", "CGPI", "CGPMAF", "CNIG", "COREN", "CRA", "CRAS", "CRB", "CRC", "FGTS", "SPTC", "OAB", "SECC", "POM", "(Outro)"})
        Me.cmbMaisPet.FormattingEnabled = True
        Me.cmbMaisPet.Items.AddRange(New Object() {"Sim", "Não"})
        Me.cmbMaisPet.Location = New System.Drawing.Point(18, 38)
        Me.cmbMaisPet.Name = "cmbMaisPet"
        Me.cmbMaisPet.Size = New System.Drawing.Size(96, 21)
        Me.cmbMaisPet.TabIndex = 71
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(15, 22)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(115, 13)
        Me.Label32.TabIndex = 70
        Me.Label32.Text = "Possui mais de 1 Pet?*"
        '
        'cmb_adestrado_pet_cadast
        '
        Me.cmb_adestrado_pet_cadast.AutoCompleteCustomSource.AddRange(New String() {"SSP", "Detran", "MTE", "DPF", "ABNC", "CGPI/DUREX/DPF", "CGPI", "CGPMAF", "CNIG", "COREN", "CRA", "CRAS", "CRB", "CRC", "FGTS", "SPTC", "OAB", "SECC", "POM", "(Outro)"})
        Me.cmb_adestrado_pet_cadast.FormattingEnabled = True
        Me.cmb_adestrado_pet_cadast.Items.AddRange(New Object() {"Sim", "Não", "N/E"})
        Me.cmb_adestrado_pet_cadast.Location = New System.Drawing.Point(251, 297)
        Me.cmb_adestrado_pet_cadast.Name = "cmb_adestrado_pet_cadast"
        Me.cmb_adestrado_pet_cadast.Size = New System.Drawing.Size(96, 21)
        Me.cmb_adestrado_pet_cadast.TabIndex = 26
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(248, 282)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(71, 13)
        Me.Label15.TabIndex = 68
        Me.Label15.Text = "É Adestrado?"
        '
        'txt_altura_pet_cadast
        '
        Me.txt_altura_pet_cadast.Location = New System.Drawing.Point(139, 298)
        Me.txt_altura_pet_cadast.Name = "txt_altura_pet_cadast"
        Me.txt_altura_pet_cadast.Size = New System.Drawing.Size(96, 20)
        Me.txt_altura_pet_cadast.TabIndex = 25
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(136, 282)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(58, 13)
        Me.Label28.TabIndex = 66
        Me.Label28.Text = "Altura(Cm):"
        '
        'cmb_porte_pet_cadast
        '
        Me.cmb_porte_pet_cadast.AutoCompleteCustomSource.AddRange(New String() {"SSP", "Detran", "MTE", "DPF", "ABNC", "CGPI/DUREX/DPF", "CGPI", "CGPMAF", "CNIG", "COREN", "CRA", "CRAS", "CRB", "CRC", "FGTS", "SPTC", "OAB", "SECC", "POM", "(Outro)"})
        Me.cmb_porte_pet_cadast.FormattingEnabled = True
        Me.cmb_porte_pet_cadast.Items.AddRange(New Object() {"Grande", "Médio", "Pequeno", "Micro/Toy", "N/E"})
        Me.cmb_porte_pet_cadast.Location = New System.Drawing.Point(251, 192)
        Me.cmb_porte_pet_cadast.Name = "cmb_porte_pet_cadast"
        Me.cmb_porte_pet_cadast.Size = New System.Drawing.Size(96, 21)
        Me.cmb_porte_pet_cadast.TabIndex = 20
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(248, 177)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(32, 13)
        Me.Label18.TabIndex = 64
        Me.Label18.Text = "Porte"
        '
        'cmb_sexo_pet_cadast
        '
        Me.cmb_sexo_pet_cadast.AutoCompleteCustomSource.AddRange(New String() {"SSP", "Detran", "MTE", "DPF", "ABNC", "CGPI/DUREX/DPF", "CGPI", "CGPMAF", "CNIG", "COREN", "CRA", "CRAS", "CRB", "CRC", "FGTS", "SPTC", "OAB", "SECC", "POM", "(Outro)"})
        Me.cmb_sexo_pet_cadast.FormattingEnabled = True
        Me.cmb_sexo_pet_cadast.Items.AddRange(New Object() {"Macho", "Fêmea", "N/E"})
        Me.cmb_sexo_pet_cadast.Location = New System.Drawing.Point(136, 141)
        Me.cmb_sexo_pet_cadast.Name = "cmb_sexo_pet_cadast"
        Me.cmb_sexo_pet_cadast.Size = New System.Drawing.Size(96, 21)
        Me.cmb_sexo_pet_cadast.TabIndex = 16
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(133, 124)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(34, 13)
        Me.Label14.TabIndex = 62
        Me.Label14.Text = "Sexo:"
        '
        'txt_idade_pet_cadast
        '
        Me.txt_idade_pet_cadast.Location = New System.Drawing.Point(136, 193)
        Me.txt_idade_pet_cadast.Name = "txt_idade_pet_cadast"
        Me.txt_idade_pet_cadast.Size = New System.Drawing.Size(96, 20)
        Me.txt_idade_pet_cadast.TabIndex = 19
        '
        'txt_cor_pet_cadast
        '
        Me.txt_cor_pet_cadast.Location = New System.Drawing.Point(251, 141)
        Me.txt_cor_pet_cadast.Name = "txt_cor_pet_cadast"
        Me.txt_cor_pet_cadast.Size = New System.Drawing.Size(96, 20)
        Me.txt_cor_pet_cadast.TabIndex = 17
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(248, 124)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(94, 13)
        Me.Label21.TabIndex = 59
        Me.Label21.Text = "Cor Predominante:"
        '
        'txt_raca_pet_cadast
        '
        Me.txt_raca_pet_cadast.Location = New System.Drawing.Point(18, 141)
        Me.txt_raca_pet_cadast.Name = "txt_raca_pet_cadast"
        Me.txt_raca_pet_cadast.Size = New System.Drawing.Size(96, 20)
        Me.txt_raca_pet_cadast.TabIndex = 15
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(15, 124)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(36, 13)
        Me.Label20.TabIndex = 57
        Me.Label20.Text = "Raça:"
        '
        'txt_tipo_pet_cadast
        '
        Me.txt_tipo_pet_cadast.Location = New System.Drawing.Point(251, 91)
        Me.txt_tipo_pet_cadast.Name = "txt_tipo_pet_cadast"
        Me.txt_tipo_pet_cadast.Size = New System.Drawing.Size(96, 20)
        Me.txt_tipo_pet_cadast.TabIndex = 14
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(248, 74)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(80, 13)
        Me.Label27.TabIndex = 55
        Me.Label27.Text = "Tipo de Animal:"
        '
        'carrega_foto_pet
        '
        Me.carrega_foto_pet.BackgroundImage = CType(resources.GetObject("carrega_foto_pet.BackgroundImage"), System.Drawing.Image)
        Me.carrega_foto_pet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.carrega_foto_pet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.carrega_foto_pet.Location = New System.Drawing.Point(365, 22)
        Me.carrega_foto_pet.Name = "carrega_foto_pet"
        Me.carrega_foto_pet.Size = New System.Drawing.Size(120, 111)
        Me.carrega_foto_pet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.carrega_foto_pet.TabIndex = 54
        Me.carrega_foto_pet.TabStop = False
        '
        'txt_obs_pet_cadast
        '
        Me.txt_obs_pet_cadast.Location = New System.Drawing.Point(18, 338)
        Me.txt_obs_pet_cadast.Name = "txt_obs_pet_cadast"
        Me.txt_obs_pet_cadast.Size = New System.Drawing.Size(329, 20)
        Me.txt_obs_pet_cadast.TabIndex = 27
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(15, 321)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(32, 13)
        Me.Label16.TabIndex = 48
        Me.Label16.Text = "OBS:"
        '
        'txt_peso_pet_cadast
        '
        Me.txt_peso_pet_cadast.Location = New System.Drawing.Point(18, 298)
        Me.txt_peso_pet_cadast.Name = "txt_peso_pet_cadast"
        Me.txt_peso_pet_cadast.Size = New System.Drawing.Size(96, 20)
        Me.txt_peso_pet_cadast.TabIndex = 24
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(15, 282)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(53, 13)
        Me.Label17.TabIndex = 46
        Me.Label17.Text = "Peso(Kg):"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(133, 177)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(90, 13)
        Me.Label19.TabIndex = 42
        Me.Label19.Text = "Idade (Ano/Mês):"
        '
        'dtp_nasc_pet_cadast
        '
        Me.dtp_nasc_pet_cadast.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_nasc_pet_cadast.Location = New System.Drawing.Point(18, 194)
        Me.dtp_nasc_pet_cadast.MaxDate = New Date(9950, 12, 31, 0, 0, 0, 0)
        Me.dtp_nasc_pet_cadast.MinDate = New Date(1950, 12, 31, 0, 0, 0, 0)
        Me.dtp_nasc_pet_cadast.Name = "dtp_nasc_pet_cadast"
        Me.dtp_nasc_pet_cadast.Size = New System.Drawing.Size(107, 20)
        Me.dtp_nasc_pet_cadast.TabIndex = 18
        Me.dtp_nasc_pet_cadast.Value = New Date(1950, 12, 31, 0, 0, 0, 0)
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(15, 177)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(107, 13)
        Me.Label22.TabIndex = 36
        Me.Label22.Text = "Data de Nascimento:"
        '
        'cmb_microchip_pet_cadast
        '
        Me.cmb_microchip_pet_cadast.AutoCompleteCustomSource.AddRange(New String() {"SSP", "Detran", "MTE", "DPF", "ABNC", "CGPI/DUREX/DPF", "CGPI", "CGPMAF", "CNIG", "COREN", "CRA", "CRAS", "CRB", "CRC", "FGTS", "SPTC", "OAB", "SECC", "POM", "(Outro)"})
        Me.cmb_microchip_pet_cadast.FormattingEnabled = True
        Me.cmb_microchip_pet_cadast.Items.AddRange(New Object() {"Sim", "Não"})
        Me.cmb_microchip_pet_cadast.Location = New System.Drawing.Point(136, 247)
        Me.cmb_microchip_pet_cadast.Name = "cmb_microchip_pet_cadast"
        Me.cmb_microchip_pet_cadast.Size = New System.Drawing.Size(96, 21)
        Me.cmb_microchip_pet_cadast.TabIndex = 22
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(133, 230)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(93, 13)
        Me.Label23.TabIndex = 34
        Me.Label23.Text = "Possui Microchip?"
        '
        'txt_rgcua_pet_cadast
        '
        Me.txt_rgcua_pet_cadast.Location = New System.Drawing.Point(18, 247)
        Me.txt_rgcua_pet_cadast.Mask = "99,999,999-9"
        Me.txt_rgcua_pet_cadast.Name = "txt_rgcua_pet_cadast"
        Me.txt_rgcua_pet_cadast.Size = New System.Drawing.Size(96, 20)
        Me.txt_rgcua_pet_cadast.TabIndex = 21
        Me.txt_rgcua_pet_cadast.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(15, 230)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(53, 13)
        Me.Label24.TabIndex = 32
        Me.Label24.Text = "RG/CUA:"
        '
        'txt_nmicrochip_pet_cadast
        '
        Me.txt_nmicrochip_pet_cadast.Location = New System.Drawing.Point(253, 246)
        Me.txt_nmicrochip_pet_cadast.Name = "txt_nmicrochip_pet_cadast"
        Me.txt_nmicrochip_pet_cadast.Size = New System.Drawing.Size(96, 20)
        Me.txt_nmicrochip_pet_cadast.TabIndex = 23
        Me.txt_nmicrochip_pet_cadast.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(250, 230)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(71, 13)
        Me.Label25.TabIndex = 30
        Me.Label25.Text = "Nº Microchip:"
        '
        'txt_nome_pet_cadast
        '
        Me.txt_nome_pet_cadast.Location = New System.Drawing.Point(18, 91)
        Me.txt_nome_pet_cadast.Name = "txt_nome_pet_cadast"
        Me.txt_nome_pet_cadast.Size = New System.Drawing.Size(217, 20)
        Me.txt_nome_pet_cadast.TabIndex = 13
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(15, 74)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(72, 13)
        Me.Label26.TabIndex = 28
        Me.Label26.Text = "Nome do Pet:"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.cmb_modalidade_cadast)
        Me.TabPage3.Controls.Add(Me.Label31)
        Me.TabPage3.Controls.Add(Me.cmb_formapagamento_cadast)
        Me.TabPage3.Controls.Add(Me.Label30)
        Me.TabPage3.Controls.Add(Me.txt_obs_cadast)
        Me.TabPage3.Controls.Add(Me.Label29)
        Me.TabPage3.Controls.Add(Me.txt_exigencias_cadast)
        Me.TabPage3.Controls.Add(Me.Label35)
        Me.TabPage3.Controls.Add(Me.txt_vigencia_cadast)
        Me.TabPage3.Controls.Add(Me.Label42)
        Me.TabPage3.Controls.Add(Me.cmb_planoadq_cadast)
        Me.TabPage3.Controls.Add(Me.Label40)
        Me.TabPage3.Controls.Add(Me.txt_medicamentos_cadast)
        Me.TabPage3.Controls.Add(Me.Label39)
        Me.TabPage3.Controls.Add(Me.cbm_historicomedico_cadast)
        Me.TabPage3.Controls.Add(Me.Label38)
        Me.TabPage3.Controls.Add(Me.txt_patologias_cadast)
        Me.TabPage3.Controls.Add(Me.Label41)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(501, 396)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Planos/Pacotes"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'cmb_modalidade_cadast
        '
        Me.cmb_modalidade_cadast.AutoCompleteCustomSource.AddRange(New String() {"SSP", "Detran", "MTE", "DPF", "ABNC", "CGPI/DUREX/DPF", "CGPI", "CGPMAF", "CNIG", "COREN", "CRA", "CRAS", "CRB", "CRC", "FGTS", "SPTC", "OAB", "SECC", "POM", "(Outro)"})
        Me.cmb_modalidade_cadast.FormattingEnabled = True
        Me.cmb_modalidade_cadast.Items.AddRange(New Object() {"Avulso", "Mensal", "Trimestral", "Semestral", "Anual"})
        Me.cmb_modalidade_cadast.Location = New System.Drawing.Point(315, 104)
        Me.cmb_modalidade_cadast.Name = "cmb_modalidade_cadast"
        Me.cmb_modalidade_cadast.Size = New System.Drawing.Size(123, 21)
        Me.cmb_modalidade_cadast.TabIndex = 32
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(312, 87)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(65, 13)
        Me.Label31.TabIndex = 65
        Me.Label31.Text = "Modalidade:"
        '
        'cmb_formapagamento_cadast
        '
        Me.cmb_formapagamento_cadast.AutoCompleteCustomSource.AddRange(New String() {"SSP", "Detran", "MTE", "DPF", "ABNC", "CGPI/DUREX/DPF", "CGPI", "CGPMAF", "CNIG", "COREN", "CRA", "CRAS", "CRB", "CRC", "FGTS", "SPTC", "OAB", "SECC", "POM", "(Outro)"})
        Me.cmb_formapagamento_cadast.FormattingEnabled = True
        Me.cmb_formapagamento_cadast.Items.AddRange(New Object() {"Cartão de Crédito (Automatico)", "Cartão de Débito (Automático)", "Cartão de Crédito/Débito (Loja)", "Cartão de Crédito/Débito (Em casa)", "Dinheiro (Loja)", "Dinheiro (Em casa)", "Voucher"})
        Me.cmb_formapagamento_cadast.Location = New System.Drawing.Point(26, 103)
        Me.cmb_formapagamento_cadast.Name = "cmb_formapagamento_cadast"
        Me.cmb_formapagamento_cadast.Size = New System.Drawing.Size(261, 21)
        Me.cmb_formapagamento_cadast.TabIndex = 31
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(23, 87)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(108, 13)
        Me.Label30.TabIndex = 63
        Me.Label30.Text = "Forma de Pagamento"
        '
        'txt_obs_cadast
        '
        Me.txt_obs_cadast.Location = New System.Drawing.Point(26, 312)
        Me.txt_obs_cadast.Name = "txt_obs_cadast"
        Me.txt_obs_cadast.Size = New System.Drawing.Size(412, 20)
        Me.txt_obs_cadast.TabIndex = 36
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(23, 295)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(32, 13)
        Me.Label29.TabIndex = 61
        Me.Label29.Text = "OBS:"
        '
        'txt_exigencias_cadast
        '
        Me.txt_exigencias_cadast.Location = New System.Drawing.Point(26, 259)
        Me.txt_exigencias_cadast.Name = "txt_exigencias_cadast"
        Me.txt_exigencias_cadast.Size = New System.Drawing.Size(412, 20)
        Me.txt_exigencias_cadast.TabIndex = 35
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(23, 242)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(61, 13)
        Me.Label35.TabIndex = 59
        Me.Label35.Text = "Exigências:"
        '
        'txt_vigencia_cadast
        '
        Me.txt_vigencia_cadast.Location = New System.Drawing.Point(149, 54)
        Me.txt_vigencia_cadast.Name = "txt_vigencia_cadast"
        Me.txt_vigencia_cadast.Size = New System.Drawing.Size(138, 20)
        Me.txt_vigencia_cadast.TabIndex = 29
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(146, 37)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(64, 13)
        Me.Label42.TabIndex = 57
        Me.Label42.Text = "Vigente até:"
        '
        'cmb_planoadq_cadast
        '
        Me.cmb_planoadq_cadast.AutoCompleteCustomSource.AddRange(New String() {"SSP", "Detran", "MTE", "DPF", "ABNC", "CGPI/DUREX/DPF", "CGPI", "CGPMAF", "CNIG", "COREN", "CRA", "CRAS", "CRB", "CRC", "FGTS", "SPTC", "OAB", "SECC", "POM", "(Outro)"})
        Me.cmb_planoadq_cadast.FormattingEnabled = True
        Me.cmb_planoadq_cadast.Items.AddRange(New Object() {"VIP", "Banho 1", "Banho 2", "Banho 3", "Banho 4", "Hotel Pet", "CheckUp 1", "CheckUp 2", "Alimentação", "Roupas + Brinquedo", "TaxiDog", "Outro", "Não possui"})
        Me.cmb_planoadq_cadast.Location = New System.Drawing.Point(26, 54)
        Me.cmb_planoadq_cadast.Name = "cmb_planoadq_cadast"
        Me.cmb_planoadq_cadast.Size = New System.Drawing.Size(96, 21)
        Me.cmb_planoadq_cadast.TabIndex = 28
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(23, 37)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(84, 13)
        Me.Label40.TabIndex = 55
        Me.Label40.Text = "Plano Adquirido:"
        '
        'txt_medicamentos_cadast
        '
        Me.txt_medicamentos_cadast.Location = New System.Drawing.Point(26, 205)
        Me.txt_medicamentos_cadast.Name = "txt_medicamentos_cadast"
        Me.txt_medicamentos_cadast.Size = New System.Drawing.Size(412, 20)
        Me.txt_medicamentos_cadast.TabIndex = 34
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(23, 188)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(79, 13)
        Me.Label39.TabIndex = 53
        Me.Label39.Text = "Medicamentos:"
        '
        'cbm_historicomedico_cadast
        '
        Me.cbm_historicomedico_cadast.AutoCompleteCustomSource.AddRange(New String() {"SSP", "Detran", "MTE", "DPF", "ABNC", "CGPI/DUREX/DPF", "CGPI", "CGPMAF", "CNIG", "COREN", "CRA", "CRAS", "CRB", "CRC", "FGTS", "SPTC", "OAB", "SECC", "POM", "(Outro)"})
        Me.cbm_historicomedico_cadast.FormattingEnabled = True
        Me.cbm_historicomedico_cadast.Items.AddRange(New Object() {"Sim", "Não", "N/E"})
        Me.cbm_historicomedico_cadast.Location = New System.Drawing.Point(315, 54)
        Me.cbm_historicomedico_cadast.Name = "cbm_historicomedico_cadast"
        Me.cbm_historicomedico_cadast.Size = New System.Drawing.Size(123, 21)
        Me.cbm_historicomedico_cadast.TabIndex = 30
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(312, 37)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(126, 13)
        Me.Label38.TabIndex = 33
        Me.Label38.Text = "Possui Histórico Médico?"
        '
        'txt_patologias_cadast
        '
        Me.txt_patologias_cadast.Location = New System.Drawing.Point(26, 154)
        Me.txt_patologias_cadast.Name = "txt_patologias_cadast"
        Me.txt_patologias_cadast.Size = New System.Drawing.Size(412, 20)
        Me.txt_patologias_cadast.TabIndex = 33
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(23, 137)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(59, 13)
        Me.Label41.TabIndex = 27
        Me.Label41.Text = "Patologias:"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.FileName = "OpenFileDialog2"
        '
        'FormCadastroCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(584, 501)
        Me.Controls.Add(Me.tabControl_cliente_cadastro)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormCadastroCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastrar Cliente"
        Me.tabControl_cliente_cadastro.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.carregar_foto_cli, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.carrega_foto_pet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabControl_cliente_cadastro As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_rg_cliente_cadast As MaskedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_cpf_cliente_cadast As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_nome_cliente_cadast As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents cmb_orgao_cliente_cadast As ComboBox
    Friend WithEvents carregar_foto_cli As PictureBox
    Friend WithEvents txt_uf_cliente_cadast As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txt_cidade_cliente_cadast As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txt_bairro_cliente_cadast As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_endereco_cliente_cadast As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_cep_cliente_cadast As MaskedTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_texcel2_cliente_cadast As MaskedTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_telcel1_cliente_cadast As MaskedTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_telfixo_cliente_cadast As MaskedTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents dtp_nasc_cliente_cadast As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents cmb_adestrado_pet_cadast As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txt_altura_pet_cadast As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents cmb_porte_pet_cadast As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents cmb_sexo_pet_cadast As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txt_idade_pet_cadast As TextBox
    Friend WithEvents txt_cor_pet_cadast As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents txt_raca_pet_cadast As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txt_tipo_pet_cadast As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents carrega_foto_pet As PictureBox
    Friend WithEvents txt_obs_pet_cadast As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txt_peso_pet_cadast As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents dtp_nasc_pet_cadast As DateTimePicker
    Friend WithEvents Label22 As Label
    Friend WithEvents cmb_microchip_pet_cadast As ComboBox
    Friend WithEvents Label23 As Label
    Friend WithEvents txt_rgcua_pet_cadast As MaskedTextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents txt_nmicrochip_pet_cadast As MaskedTextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents txt_nome_pet_cadast As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents cmb_planoadq_cadast As ComboBox
    Friend WithEvents Label40 As Label
    Friend WithEvents txt_medicamentos_cadast As TextBox
    Friend WithEvents Label39 As Label
    Friend WithEvents cbm_historicomedico_cadast As ComboBox
    Friend WithEvents Label38 As Label
    Friend WithEvents txt_patologias_cadast As TextBox
    Friend WithEvents Label41 As Label
    Friend WithEvents cmb_modalidade_cadast As ComboBox
    Friend WithEvents Label31 As Label
    Friend WithEvents cmb_formapagamento_cadast As ComboBox
    Friend WithEvents Label30 As Label
    Friend WithEvents txt_obs_cadast As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents txt_exigencias_cadast As TextBox
    Friend WithEvents Label35 As Label
    Friend WithEvents txt_vigencia_cadast As TextBox
    Friend WithEvents Label42 As Label
    Friend WithEvents btn_excluir_cliente_cadast As Button
    Friend WithEvents btn_editar_cliente_cadast As Button
    Friend WithEvents btn_salvar_cliente_cadast As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents OpenFileDialog2 As OpenFileDialog
    Friend WithEvents Label32 As Label
    Friend WithEvents cmbMaisPet As ComboBox
End Class
