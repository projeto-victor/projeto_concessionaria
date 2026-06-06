<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_alterar_cadastro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_alterar_cadastro))
        Me.txt_telefone_usuario = New System.Windows.Forms.MaskedTextBox()
        Me.txt_cpf_usuario = New System.Windows.Forms.MaskedTextBox()
        Me.txt_email_usuario = New System.Windows.Forms.TextBox()
        Me.txt_nome_usuario = New System.Windows.Forms.TextBox()
        Me.txt_senha_usuario = New System.Windows.Forms.TextBox()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.cbx_senha = New System.Windows.Forms.CheckBox()
        Me.btn_alterar_usuario = New System.Windows.Forms.Button()
        Me.btn_voltar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ckb_csenha = New System.Windows.Forms.CheckBox()
        Me.txt_csenha = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_telefone_usuario
        '
        Me.txt_telefone_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_telefone_usuario.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_telefone_usuario.Location = New System.Drawing.Point(446, 370)
        Me.txt_telefone_usuario.Mask = "(99) 00000-0000"
        Me.txt_telefone_usuario.Name = "txt_telefone_usuario"
        Me.txt_telefone_usuario.Size = New System.Drawing.Size(301, 35)
        Me.txt_telefone_usuario.TabIndex = 1
        Me.txt_telefone_usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_cpf_usuario
        '
        Me.txt_cpf_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cpf_usuario.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_cpf_usuario.Location = New System.Drawing.Point(446, 254)
        Me.txt_cpf_usuario.Mask = "999,999,999-99"
        Me.txt_cpf_usuario.Name = "txt_cpf_usuario"
        Me.txt_cpf_usuario.Size = New System.Drawing.Size(301, 35)
        Me.txt_cpf_usuario.TabIndex = 161
        Me.txt_cpf_usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_email_usuario
        '
        Me.txt_email_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_email_usuario.Location = New System.Drawing.Point(797, 370)
        Me.txt_email_usuario.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_email_usuario.Name = "txt_email_usuario"
        Me.txt_email_usuario.Size = New System.Drawing.Size(557, 35)
        Me.txt_email_usuario.TabIndex = 2
        '
        'txt_nome_usuario
        '
        Me.txt_nome_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome_usuario.Location = New System.Drawing.Point(797, 254)
        Me.txt_nome_usuario.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_nome_usuario.Name = "txt_nome_usuario"
        Me.txt_nome_usuario.Size = New System.Drawing.Size(557, 35)
        Me.txt_nome_usuario.TabIndex = 0
        '
        'txt_senha_usuario
        '
        Me.txt_senha_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_senha_usuario.Location = New System.Drawing.Point(446, 492)
        Me.txt_senha_usuario.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_senha_usuario.Name = "txt_senha_usuario"
        Me.txt_senha_usuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_senha_usuario.Size = New System.Drawing.Size(399, 35)
        Me.txt_senha_usuario.TabIndex = 3
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "excluir"
        Me.DataGridViewImageColumn1.Image = CType(resources.GetObject("DataGridViewImageColumn1.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn1.MinimumWidth = 8
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Width = 80
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Image = Global.projeto_confeitaria.My.Resources.Resources.cinza
        Me.Label13.Location = New System.Drawing.Point(559, 440)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(76, 24)
        Me.Label13.TabIndex = 184
        Me.Label13.Text = "SENHA"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Image = Global.projeto_confeitaria.My.Resources.Resources.cinza
        Me.Label12.Location = New System.Drawing.Point(1044, 345)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(66, 24)
        Me.Label12.TabIndex = 183
        Me.Label12.Text = "EMAIL"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Image = Global.projeto_confeitaria.My.Resources.Resources.cinza
        Me.Label11.Location = New System.Drawing.Point(547, 345)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(112, 24)
        Me.Label11.TabIndex = 182
        Me.Label11.Text = "TELEFONE"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Image = Global.projeto_confeitaria.My.Resources.Resources.cinza
        Me.Label8.Location = New System.Drawing.Point(1044, 229)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 24)
        Me.Label8.TabIndex = 181
        Me.Label8.Text = "NOME"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Image = Global.projeto_confeitaria.My.Resources.Resources.cinza
        Me.Label6.Location = New System.Drawing.Point(568, 229)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 24)
        Me.Label6.TabIndex = 180
        Me.Label6.Text = "CPF"
        '
        'PictureBox6
        '
        Me.PictureBox6.BackgroundImage = Global.projeto_confeitaria.My.Resources.Resources.azul_notuno
        Me.PictureBox6.Image = Global.projeto_confeitaria.My.Resources.Resources.azul_notuno
        Me.PictureBox6.Location = New System.Drawing.Point(-1, -3)
        Me.PictureBox6.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(1429, 20)
        Me.PictureBox6.TabIndex = 177
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackgroundImage = Global.projeto_confeitaria.My.Resources.Resources.azul_notuno
        Me.PictureBox5.Image = Global.projeto_confeitaria.My.Resources.Resources.azul_notuno
        Me.PictureBox5.Location = New System.Drawing.Point(11, 101)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(1429, 22)
        Me.PictureBox5.TabIndex = 176
        Me.PictureBox5.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.projeto_confeitaria.My.Resources.Resources.marrom_liso
        Me.PictureBox3.Location = New System.Drawing.Point(-1, 822)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(1429, 20)
        Me.PictureBox3.TabIndex = 175
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.projeto_confeitaria.My.Resources.Resources.azul_notuno
        Me.PictureBox1.Image = Global.projeto_confeitaria.My.Resources.Resources.azul_notuno
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 10)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(19, 830)
        Me.PictureBox1.TabIndex = 174
        Me.PictureBox1.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImage = Global.projeto_confeitaria.My.Resources.Resources.azul_notuno
        Me.PictureBox4.Image = Global.projeto_confeitaria.My.Resources.Resources.azul_notuno
        Me.PictureBox4.Location = New System.Drawing.Point(368, -2)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(19, 830)
        Me.PictureBox4.TabIndex = 173
        Me.PictureBox4.TabStop = False
        '
        'cbx_senha
        '
        Me.cbx_senha.Appearance = System.Windows.Forms.Appearance.Button
        Me.cbx_senha.AutoSize = True
        Me.cbx_senha.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx_senha.Image = Global.projeto_confeitaria.My.Resources.Resources.Pictogrammers_Material_Eye_lock_open_24
        Me.cbx_senha.Location = New System.Drawing.Point(849, 494)
        Me.cbx_senha.Margin = New System.Windows.Forms.Padding(2)
        Me.cbx_senha.Name = "cbx_senha"
        Me.cbx_senha.Size = New System.Drawing.Size(30, 30)
        Me.cbx_senha.TabIndex = 4
        Me.cbx_senha.UseVisualStyleBackColor = True
        '
        'btn_alterar_usuario
        '
        Me.btn_alterar_usuario.BackgroundImage = Global.projeto_confeitaria.My.Resources.Resources.azul_royal_escuro
        Me.btn_alterar_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_alterar_usuario.ForeColor = System.Drawing.Color.White
        Me.btn_alterar_usuario.Image = Global.projeto_confeitaria.My.Resources.Resources.azul_royal_escuro
        Me.btn_alterar_usuario.Location = New System.Drawing.Point(705, 579)
        Me.btn_alterar_usuario.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_alterar_usuario.Name = "btn_alterar_usuario"
        Me.btn_alterar_usuario.Size = New System.Drawing.Size(396, 73)
        Me.btn_alterar_usuario.TabIndex = 7
        Me.btn_alterar_usuario.Text = "ALTERAR MEU CADASTRO"
        Me.btn_alterar_usuario.UseVisualStyleBackColor = True
        '
        'btn_voltar
        '
        Me.btn_voltar.BackColor = System.Drawing.Color.White
        Me.btn_voltar.BackgroundImage = Global.projeto_confeitaria.My.Resources.Resources.azul_royal_escuro
        Me.btn_voltar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_voltar.ForeColor = System.Drawing.Color.White
        Me.btn_voltar.Image = Global.projeto_confeitaria.My.Resources.Resources.azul_royal_escuro
        Me.btn_voltar.Location = New System.Drawing.Point(104, 23)
        Me.btn_voltar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(172, 73)
        Me.btn_voltar.TabIndex = 8
        Me.btn_voltar.Text = "VOLTAR"
        Me.btn_voltar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Image = Global.projeto_confeitaria.My.Resources.Resources.cinza
        Me.Label1.Location = New System.Drawing.Point(1065, 440)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 24)
        Me.Label1.TabIndex = 188
        Me.Label1.Text = "CONFIRMAR SENHA"
        '
        'ckb_csenha
        '
        Me.ckb_csenha.Appearance = System.Windows.Forms.Appearance.Button
        Me.ckb_csenha.AutoSize = True
        Me.ckb_csenha.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckb_csenha.Image = Global.projeto_confeitaria.My.Resources.Resources.Pictogrammers_Material_Eye_lock_open_24
        Me.ckb_csenha.Location = New System.Drawing.Point(1324, 494)
        Me.ckb_csenha.Margin = New System.Windows.Forms.Padding(2)
        Me.ckb_csenha.Name = "ckb_csenha"
        Me.ckb_csenha.Size = New System.Drawing.Size(30, 30)
        Me.ckb_csenha.TabIndex = 6
        Me.ckb_csenha.UseVisualStyleBackColor = True
        '
        'txt_csenha
        '
        Me.txt_csenha.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_csenha.Location = New System.Drawing.Point(926, 492)
        Me.txt_csenha.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_csenha.Name = "txt_csenha"
        Me.txt_csenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_csenha.Size = New System.Drawing.Size(396, 35)
        Me.txt_csenha.TabIndex = 5
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.projeto_confeitaria.My.Resources.Resources.marrom_liso
        Me.PictureBox2.Location = New System.Drawing.Point(1409, -2)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(19, 842)
        Me.PictureBox2.TabIndex = 189
        Me.PictureBox2.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox7.BackgroundImage = CType(resources.GetObject("PictureBox7.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox7.Image = Global.projeto_confeitaria.My.Resources.Resources.logo2
        Me.PictureBox7.Location = New System.Drawing.Point(22, 254)
        Me.PictureBox7.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(346, 259)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 190
        Me.PictureBox7.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Image = Global.projeto_confeitaria.My.Resources.Resources.azul_royal_escuro
        Me.Label7.Location = New System.Drawing.Point(439, 41)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(864, 42)
        Me.Label7.TabIndex = 191
        Me.Label7.Text = "VERIFIQUE O ANDAMENDO DO SEUS PEDIDOS"
        '
        'PictureBox8
        '
        Me.PictureBox8.BackgroundImage = Global.projeto_confeitaria.My.Resources.Resources.azul_royal_escuro
        Me.PictureBox8.Image = Global.projeto_confeitaria.My.Resources.Resources.azul_royal_escuro
        Me.PictureBox8.Location = New System.Drawing.Point(-2, 10)
        Me.PictureBox8.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(1417, 99)
        Me.PictureBox8.TabIndex = 192
        Me.PictureBox8.TabStop = False
        '
        'form_alterar_cadastro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.BackgroundImage = Global.projeto_confeitaria.My.Resources.Resources.cinza
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ckb_csenha)
        Me.Controls.Add(Me.txt_csenha)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.cbx_senha)
        Me.Controls.Add(Me.txt_telefone_usuario)
        Me.Controls.Add(Me.txt_cpf_usuario)
        Me.Controls.Add(Me.btn_alterar_usuario)
        Me.Controls.Add(Me.btn_voltar)
        Me.Controls.Add(Me.txt_email_usuario)
        Me.Controls.Add(Me.txt_nome_usuario)
        Me.Controls.Add(Me.txt_senha_usuario)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox8)
        Me.Name = "form_alterar_cadastro"
        Me.Text = "form_alterar_cadastro"
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents cbx_senha As CheckBox
    Friend WithEvents txt_telefone_usuario As MaskedTextBox
    Friend WithEvents txt_cpf_usuario As MaskedTextBox
    Friend WithEvents btn_alterar_usuario As Button
    Friend WithEvents btn_voltar As Button
    Friend WithEvents txt_email_usuario As TextBox
    Friend WithEvents txt_nome_usuario As TextBox
    Friend WithEvents txt_senha_usuario As TextBox
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents ckb_csenha As CheckBox
    Friend WithEvents txt_csenha As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox8 As PictureBox
End Class
