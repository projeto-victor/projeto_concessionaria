<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_login))
        Me.cbx_senha = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.link_criar_conta = New System.Windows.Forms.LinkLabel()
        Me.txt_senha_login = New System.Windows.Forms.TextBox()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.btn_sair = New System.Windows.Forms.Button()
        Me.link_esqueci_senha = New System.Windows.Forms.LinkLabel()
        Me.txt_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbx_senha
        '
        Me.cbx_senha.Appearance = System.Windows.Forms.Appearance.Button
        Me.cbx_senha.AutoSize = True
        Me.cbx_senha.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx_senha.Image = Global.projeto_confeitaria.My.Resources.Resources.Pictogrammers_Material_Eye_lock_open_24
        Me.cbx_senha.Location = New System.Drawing.Point(909, 274)
        Me.cbx_senha.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.cbx_senha.Name = "cbx_senha"
        Me.cbx_senha.Size = New System.Drawing.Size(30, 30)
        Me.cbx_senha.TabIndex = 2
        Me.cbx_senha.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Image = Global.projeto_confeitaria.My.Resources.Resources.cinza
        Me.Label2.Location = New System.Drawing.Point(707, 121)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 31)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "CPF"
        '
        'link_criar_conta
        '
        Me.link_criar_conta.AutoSize = True
        Me.link_criar_conta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.link_criar_conta.Image = Global.projeto_confeitaria.My.Resources.Resources.cinza
        Me.link_criar_conta.Location = New System.Drawing.Point(647, 478)
        Me.link_criar_conta.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.link_criar_conta.Name = "link_criar_conta"
        Me.link_criar_conta.Size = New System.Drawing.Size(167, 20)
        Me.link_criar_conta.TabIndex = 5
        Me.link_criar_conta.TabStop = True
        Me.link_criar_conta.Text = "CRIAR NOVA CONTA"
        '
        'txt_senha_login
        '
        Me.txt_senha_login.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_senha_login.Location = New System.Drawing.Point(536, 274)
        Me.txt_senha_login.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txt_senha_login.Name = "txt_senha_login"
        Me.txt_senha_login.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_senha_login.Size = New System.Drawing.Size(369, 31)
        Me.txt_senha_login.TabIndex = 1
        '
        'btn_login
        '
        Me.btn_login.BackgroundImage = Global.projeto_confeitaria.My.Resources.Resources.azul_royal_escuro
        Me.btn_login.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_login.ForeColor = System.Drawing.Color.White
        Me.btn_login.Image = Global.projeto_confeitaria.My.Resources.Resources.azul_royal_escuro
        Me.btn_login.Location = New System.Drawing.Point(536, 378)
        Me.btn_login.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(181, 74)
        Me.btn_login.TabIndex = 3
        Me.btn_login.Text = "LOGIN"
        Me.btn_login.UseVisualStyleBackColor = True
        '
        'btn_sair
        '
        Me.btn_sair.BackgroundImage = Global.projeto_confeitaria.My.Resources.Resources.azul_royal_escuro
        Me.btn_sair.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sair.ForeColor = System.Drawing.Color.White
        Me.btn_sair.Image = Global.projeto_confeitaria.My.Resources.Resources.azul_royal_escuro
        Me.btn_sair.Location = New System.Drawing.Point(758, 378)
        Me.btn_sair.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.btn_sair.Name = "btn_sair"
        Me.btn_sair.Size = New System.Drawing.Size(181, 74)
        Me.btn_sair.TabIndex = 4
        Me.btn_sair.Text = "SAIR"
        Me.btn_sair.UseVisualStyleBackColor = True
        '
        'link_esqueci_senha
        '
        Me.link_esqueci_senha.AutoSize = True
        Me.link_esqueci_senha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.link_esqueci_senha.Image = Global.projeto_confeitaria.My.Resources.Resources.cinza
        Me.link_esqueci_senha.LinkColor = System.Drawing.Color.Red
        Me.link_esqueci_senha.Location = New System.Drawing.Point(628, 527)
        Me.link_esqueci_senha.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.link_esqueci_senha.Name = "link_esqueci_senha"
        Me.link_esqueci_senha.Size = New System.Drawing.Size(198, 20)
        Me.link_esqueci_senha.TabIndex = 6
        Me.link_esqueci_senha.TabStop = True
        Me.link_esqueci_senha.Text = "ESQUECI MINHA SENHA"
        '
        'txt_cpf
        '
        Me.txt_cpf.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cpf.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_cpf.Location = New System.Drawing.Point(536, 156)
        Me.txt_cpf.Mask = "999,999,999-99"
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(403, 31)
        Me.txt_cpf.TabIndex = 0
        Me.txt_cpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.projeto_confeitaria.My.Resources.Resources.cinza
        Me.PictureBox1.Image = Global.projeto_confeitaria.My.Resources.Resources.logo2
        Me.PictureBox1.Location = New System.Drawing.Point(25, 109)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(476, 498)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 59
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Image = Global.projeto_confeitaria.My.Resources.Resources.cinza
        Me.Label1.Location = New System.Drawing.Point(681, 241)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 31)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "SENHA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Image = Global.projeto_confeitaria.My.Resources.Resources.cinza
        Me.Label3.Location = New System.Drawing.Point(529, 45)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(406, 37)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "ENTRE COM SUA CONTA"
        '
        'PictureBox8
        '
        Me.PictureBox8.BackgroundImage = Global.projeto_confeitaria.My.Resources.Resources.azul_notuno
        Me.PictureBox8.Image = Global.projeto_confeitaria.My.Resources.Resources.azul_notuno
        Me.PictureBox8.Location = New System.Drawing.Point(498, 11)
        Me.PictureBox8.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(12, 596)
        Me.PictureBox8.TabIndex = 126
        Me.PictureBox8.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.projeto_confeitaria.My.Resources.Resources.azul_notuno
        Me.PictureBox2.Image = Global.projeto_confeitaria.My.Resources.Resources.azul_notuno
        Me.PictureBox2.Location = New System.Drawing.Point(978, 11)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(12, 596)
        Me.PictureBox2.TabIndex = 127
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.projeto_confeitaria.My.Resources.Resources.azul_notuno
        Me.PictureBox3.Image = Global.projeto_confeitaria.My.Resources.Resources.azul_notuno
        Me.PictureBox3.Location = New System.Drawing.Point(0, 11)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(12, 596)
        Me.PictureBox3.TabIndex = 128
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImage = Global.projeto_confeitaria.My.Resources.Resources.azul_notuno
        Me.PictureBox4.Image = Global.projeto_confeitaria.My.Resources.Resources.azul_notuno
        Me.PictureBox4.Location = New System.Drawing.Point(0, 603)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(990, 12)
        Me.PictureBox4.TabIndex = 129
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackgroundImage = Global.projeto_confeitaria.My.Resources.Resources.azul_notuno
        Me.PictureBox5.Image = Global.projeto_confeitaria.My.Resources.Resources.azul_notuno
        Me.PictureBox5.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(990, 12)
        Me.PictureBox5.TabIndex = 130
        Me.PictureBox5.TabStop = False
        '
        'form_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(989, 614)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txt_cpf)
        Me.Controls.Add(Me.link_esqueci_senha)
        Me.Controls.Add(Me.btn_sair)
        Me.Controls.Add(Me.cbx_senha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.link_criar_conta)
        Me.Controls.Add(Me.txt_senha_login)
        Me.Controls.Add(Me.btn_login)
        Me.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.Name = "form_login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "11"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbx_senha As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents link_criar_conta As LinkLabel
    Friend WithEvents txt_senha_login As TextBox
    Friend WithEvents btn_login As Button
    Friend WithEvents btn_sair As Button
    Friend WithEvents link_esqueci_senha As LinkLabel
    Friend WithEvents txt_cpf As MaskedTextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
End Class
