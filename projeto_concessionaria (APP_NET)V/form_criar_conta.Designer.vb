<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_criar_conta
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
        Me.cbx_senha = New System.Windows.Forms.CheckBox()
        Me.txt_telefone_usuario = New System.Windows.Forms.MaskedTextBox()
        Me.txt_cpf_usuario = New System.Windows.Forms.MaskedTextBox()
        Me.btn_gravar_usuario = New System.Windows.Forms.Button()
        Me.txt_email_usuario = New System.Windows.Forms.TextBox()
        Me.txt_nome_usuario = New System.Windows.Forms.TextBox()
        Me.txt_senha_usuario = New System.Windows.Forms.TextBox()
        Me.txt_csenha = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbx_senha2 = New System.Windows.Forms.CheckBox()
        Me.link_entrar_conta = New System.Windows.Forms.LinkLabel()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbx_senha
        '
        Me.cbx_senha.Appearance = System.Windows.Forms.Appearance.Button
        Me.cbx_senha.AutoSize = True
        Me.cbx_senha.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx_senha.Image = Global.projeto_confeitaria.My.Resources.Resources.Pictogrammers_Material_Eye_lock_open_24
        Me.cbx_senha.Location = New System.Drawing.Point(915, 464)
        Me.cbx_senha.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.cbx_senha.Name = "cbx_senha"
        Me.cbx_senha.Size = New System.Drawing.Size(30, 30)
        Me.cbx_senha.TabIndex = 7
        Me.cbx_senha.UseVisualStyleBackColor = True
        '
        'txt_telefone_usuario
        '
        Me.txt_telefone_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_telefone_usuario.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_telefone_usuario.Location = New System.Drawing.Point(542, 240)
        Me.txt_telefone_usuario.Mask = "(99) 00000-0000"
        Me.txt_telefone_usuario.Name = "txt_telefone_usuario"
        Me.txt_telefone_usuario.Size = New System.Drawing.Size(403, 31)
        Me.txt_telefone_usuario.TabIndex = 2
        Me.txt_telefone_usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_cpf_usuario
        '
        Me.txt_cpf_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cpf_usuario.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_cpf_usuario.Location = New System.Drawing.Point(542, 95)
        Me.txt_cpf_usuario.Mask = "999,999,999-99"
        Me.txt_cpf_usuario.Name = "txt_cpf_usuario"
        Me.txt_cpf_usuario.Size = New System.Drawing.Size(403, 31)
        Me.txt_cpf_usuario.TabIndex = 0
        Me.txt_cpf_usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_gravar_usuario
        '
        Me.btn_gravar_usuario.BackgroundImage = Global.projeto_confeitaria.My.Resources.Resources.azul_royal_escuro
        Me.btn_gravar_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_gravar_usuario.ForeColor = System.Drawing.Color.White
        Me.btn_gravar_usuario.Image = Global.projeto_confeitaria.My.Resources.Resources.azul_royal_escuro
        Me.btn_gravar_usuario.Location = New System.Drawing.Point(640, 508)
        Me.btn_gravar_usuario.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.btn_gravar_usuario.Name = "btn_gravar_usuario"
        Me.btn_gravar_usuario.Size = New System.Drawing.Size(215, 42)
        Me.btn_gravar_usuario.TabIndex = 8
        Me.btn_gravar_usuario.Text = "CRIAR CONTA"
        Me.btn_gravar_usuario.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_gravar_usuario.UseVisualStyleBackColor = True
        '
        'txt_email_usuario
        '
        Me.txt_email_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_email_usuario.Location = New System.Drawing.Point(542, 316)
        Me.txt_email_usuario.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txt_email_usuario.Name = "txt_email_usuario"
        Me.txt_email_usuario.Size = New System.Drawing.Size(403, 31)
        Me.txt_email_usuario.TabIndex = 3
        '
        'txt_nome_usuario
        '
        Me.txt_nome_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome_usuario.Location = New System.Drawing.Point(542, 167)
        Me.txt_nome_usuario.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txt_nome_usuario.Name = "txt_nome_usuario"
        Me.txt_nome_usuario.Size = New System.Drawing.Size(403, 31)
        Me.txt_nome_usuario.TabIndex = 1
        '
        'txt_senha_usuario
        '
        Me.txt_senha_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_senha_usuario.Location = New System.Drawing.Point(542, 390)
        Me.txt_senha_usuario.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txt_senha_usuario.Name = "txt_senha_usuario"
        Me.txt_senha_usuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_senha_usuario.Size = New System.Drawing.Size(369, 31)
        Me.txt_senha_usuario.TabIndex = 4
        '
        'txt_csenha
        '
        Me.txt_csenha.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_csenha.Location = New System.Drawing.Point(542, 463)
        Me.txt_csenha.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txt_csenha.Name = "txt_csenha"
        Me.txt_csenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_csenha.Size = New System.Drawing.Size(369, 31)
        Me.txt_csenha.TabIndex = 6
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.projeto_confeitaria.My.Resources.Resources.cinza
        Me.PictureBox1.Image = Global.projeto_confeitaria.My.Resources.Resources.logo2
        Me.PictureBox1.Location = New System.Drawing.Point(16, 23)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(476, 508)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 122
        Me.PictureBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Image = Global.projeto_confeitaria.My.Resources.Resources.cinza
        Me.Label7.Location = New System.Drawing.Point(622, 23)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(243, 37)
        Me.Label7.TabIndex = 127
        Me.Label7.Text = "CADASTRE-SE"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Image = Global.projeto_confeitaria.My.Resources.Resources.cinza
        Me.Label8.Location = New System.Drawing.Point(711, 67)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 31)
        Me.Label8.TabIndex = 128
        Me.Label8.Text = "CPF"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Image = Global.projeto_confeitaria.My.Resources.Resources.cinza
        Me.Label2.Location = New System.Drawing.Point(697, 139)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 31)
        Me.Label2.TabIndex = 129
        Me.Label2.Text = "NOME"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Image = Global.projeto_confeitaria.My.Resources.Resources.cinza
        Me.Label3.Location = New System.Drawing.Point(669, 211)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(158, 31)
        Me.Label3.TabIndex = 130
        Me.Label3.Text = "TELEFONE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Image = Global.projeto_confeitaria.My.Resources.Resources.cinza
        Me.Label4.Location = New System.Drawing.Point(698, 287)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 31)
        Me.Label4.TabIndex = 131
        Me.Label4.Text = "EMAIL"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Image = Global.projeto_confeitaria.My.Resources.Resources.cinza
        Me.Label5.Location = New System.Drawing.Point(691, 362)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 31)
        Me.Label5.TabIndex = 132
        Me.Label5.Text = "SENHA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Image = Global.projeto_confeitaria.My.Resources.Resources.cinza
        Me.Label1.Location = New System.Drawing.Point(609, 435)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(281, 31)
        Me.Label1.TabIndex = 133
        Me.Label1.Text = "CONFIRMAR SENHA"
        '
        'cbx_senha2
        '
        Me.cbx_senha2.Appearance = System.Windows.Forms.Appearance.Button
        Me.cbx_senha2.AutoSize = True
        Me.cbx_senha2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx_senha2.Image = Global.projeto_confeitaria.My.Resources.Resources.Pictogrammers_Material_Eye_lock_open_24
        Me.cbx_senha2.Location = New System.Drawing.Point(915, 391)
        Me.cbx_senha2.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.cbx_senha2.Name = "cbx_senha2"
        Me.cbx_senha2.Size = New System.Drawing.Size(30, 30)
        Me.cbx_senha2.TabIndex = 5
        Me.cbx_senha2.UseVisualStyleBackColor = True
        '
        'link_entrar_conta
        '
        Me.link_entrar_conta.AutoSize = True
        Me.link_entrar_conta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.link_entrar_conta.Image = Global.projeto_confeitaria.My.Resources.Resources.cinza
        Me.link_entrar_conta.Location = New System.Drawing.Point(641, 563)
        Me.link_entrar_conta.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.link_entrar_conta.Name = "link_entrar_conta"
        Me.link_entrar_conta.Size = New System.Drawing.Size(211, 20)
        Me.link_entrar_conta.TabIndex = 9
        Me.link_entrar_conta.TabStop = True
        Me.link_entrar_conta.Text = "ENTRAR COM SUA CONTA"
        '
        'PictureBox5
        '
        Me.PictureBox5.BackgroundImage = Global.projeto_confeitaria.My.Resources.Resources.azul_notuno
        Me.PictureBox5.Image = Global.projeto_confeitaria.My.Resources.Resources.azul_notuno
        Me.PictureBox5.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(990, 12)
        Me.PictureBox5.TabIndex = 136
        Me.PictureBox5.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.projeto_confeitaria.My.Resources.Resources.azul_notuno
        Me.PictureBox2.Image = Global.projeto_confeitaria.My.Resources.Resources.azul_notuno
        Me.PictureBox2.Location = New System.Drawing.Point(0, 603)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(990, 12)
        Me.PictureBox2.TabIndex = 137
        Me.PictureBox2.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImage = Global.projeto_confeitaria.My.Resources.Resources.azul_notuno
        Me.PictureBox4.Image = Global.projeto_confeitaria.My.Resources.Resources.azul_notuno
        Me.PictureBox4.Location = New System.Drawing.Point(0, 11)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(12, 596)
        Me.PictureBox4.TabIndex = 138
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.projeto_confeitaria.My.Resources.Resources.azul_notuno
        Me.PictureBox3.Image = Global.projeto_confeitaria.My.Resources.Resources.azul_notuno
        Me.PictureBox3.Location = New System.Drawing.Point(498, 11)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(12, 596)
        Me.PictureBox3.TabIndex = 139
        Me.PictureBox3.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackgroundImage = Global.projeto_confeitaria.My.Resources.Resources.azul_notuno
        Me.PictureBox6.Image = Global.projeto_confeitaria.My.Resources.Resources.azul_notuno
        Me.PictureBox6.Location = New System.Drawing.Point(978, 11)
        Me.PictureBox6.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(12, 596)
        Me.PictureBox6.TabIndex = 140
        Me.PictureBox6.TabStop = False
        '
        'form_criar_conta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.projeto_confeitaria.My.Resources.Resources.cinza
        Me.ClientSize = New System.Drawing.Size(989, 614)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.link_entrar_conta)
        Me.Controls.Add(Me.cbx_senha2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txt_csenha)
        Me.Controls.Add(Me.cbx_senha)
        Me.Controls.Add(Me.txt_telefone_usuario)
        Me.Controls.Add(Me.txt_cpf_usuario)
        Me.Controls.Add(Me.btn_gravar_usuario)
        Me.Controls.Add(Me.txt_email_usuario)
        Me.Controls.Add(Me.txt_nome_usuario)
        Me.Controls.Add(Me.txt_senha_usuario)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Name = "form_criar_conta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "form_criar_conta"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbx_senha As CheckBox
    Friend WithEvents txt_telefone_usuario As MaskedTextBox
    Friend WithEvents txt_cpf_usuario As MaskedTextBox
    Friend WithEvents btn_gravar_usuario As Button
    Friend WithEvents txt_email_usuario As TextBox
    Friend WithEvents txt_nome_usuario As TextBox
    Friend WithEvents txt_senha_usuario As TextBox
    Friend WithEvents txt_csenha As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cbx_senha2 As CheckBox
    Friend WithEvents link_entrar_conta As LinkLabel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
End Class
