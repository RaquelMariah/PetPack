<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLoginScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLoginScreen))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextLogin = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextSenha = New System.Windows.Forms.TextBox()
        Me.ButtonLogin = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.ButtonLogin)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TextSenha)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TextLogin)
        Me.Panel1.Location = New System.Drawing.Point(182, 65)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 170)
        Me.Panel1.TabIndex = 0
        '
        'TextLogin
        '
        Me.TextLogin.Location = New System.Drawing.Point(13, 33)
        Me.TextLogin.Name = "TextLogin"
        Me.TextLogin.Size = New System.Drawing.Size(171, 20)
        Me.TextLogin.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(74, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Usuário: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(74, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Senha:"
        '
        'TextSenha
        '
        Me.TextSenha.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextSenha.Location = New System.Drawing.Point(9, 77)
        Me.TextSenha.Name = "TextSenha"
        Me.TextSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.TextSenha.Size = New System.Drawing.Size(171, 20)
        Me.TextSenha.TabIndex = 2
        Me.TextSenha.UseSystemPasswordChar = True
        '
        'ButtonLogin
        '
        Me.ButtonLogin.Location = New System.Drawing.Point(9, 113)
        Me.ButtonLogin.Name = "ButtonLogin"
        Me.ButtonLogin.Size = New System.Drawing.Size(171, 37)
        Me.ButtonLogin.TabIndex = 4
        Me.ButtonLogin.Text = "LOGIN"
        Me.ButtonLogin.UseVisualStyleBackColor = True
        '
        'FormLoginScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(584, 321)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormLoginScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login - Mary's Pet Shop"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents ButtonLogin As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TextSenha As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextLogin As TextBox
End Class
