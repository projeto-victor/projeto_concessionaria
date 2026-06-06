<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_esqueci_senha
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_esqueci_senha))
        Me.cbx_mostrar_senha = New System.Windows.Forms.CheckBox()
        Me.txt_csenha = New System.Windows.Forms.TextBox()
        Me.txt_email_usuario = New System.Windows.Forms.TextBox()
        Me.txt_senha_usuario = New System.Windows.Forms.TextBox()
        Me.link_entrar_conta = New System.Windows.Forms.LinkLabel()
        Me.btn_editar_senha = New System.Windows.Forms.Button()
        Me.txt_cpf_usuario = New System.Windows.Forms.MaskedTextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbx_mostrar_senha2 = New System.Windows.Forms.CheckBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbx_mostrar_senha
        '
        Me.cbx_mostrar_senha.Appearance = System.Windows.Forms.Appearance.Button
        Me.cbx_mostrar_senha.AutoSize = True
        Me.cbx_mostrar_senha.BackColor = System.Drawing.SystemColors.Control
        Me.cbx_mostrar_senha.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx_mostrar_senha.Image = Global.projeto_confeitaria.My.Resources.Resources.Pictogrammers_Material_Eye_lock_open_24
        Me.cbx_mostrar_senha.Location = New System.Drawing.Point(919, 287)
        Me.cbx_mostrar_senha.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.cbx_mostrar_senha.Name = "cbx_mostrar_senha"
        Me.cbx_mostrar_senha.Size = New System.Drawing.Size(30, 30)
        Me.cbx_mostrar_senha.TabIndex = 3
        Me.cbx_mostrar_senha.UseVisualStyleBackColor = False
        '
        'txt_csenha
        '
        Me.txt_csenha.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_csenha.Location = New System.Drawing.Point(546, 369)
        Me.txt_csenha.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txt_csenha.Name = "txt_csenha"
        Me.txt_csenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_csenha.Size = New System.Drawing.Size(369, 31)
        Me.txt_csenha.TabIndex = 4
        '
        'txt_email_usuario
        '
        Me.txt_email_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_email_usuario.Location = New System.Drawing.Point(546, 202)
        Me.txt_email_usuario.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txt_email_usuario.Name = "txt_email_usuario"
        Me.txt_email_usuario.Size = New System.Drawing.Size(403, 31)
        Me.txt_email_usuario.TabIndex = 1
        '
        'txt_senha_usuario
        '
        Me.txt_senha_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_senha_usuario.Location = New System.Drawing.Point(546, 287)
        Me.txt_senha_usuario.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txt_senha_usuario.Name = "txt_senha_usuario"
        Me.txt_senha_usuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_senha_usuario.Size = New System.Drawing.Size(369, 31)
        Me.txt_senha_usuario.TabIndex = 2
        '
        'link_entrar_conta
        '
        Me.link_entrar_conta.AutoSize = True
        Me.link_entrar_conta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.link_entrar_conta.Image = Global.projeto_confeitaria.My.Resources.Resources.cinza
        Me.link_entrar_conta.Location = New System.Drawing.Point(646, 520)
        Me.link_entrar_conta.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.link_entrar_conta.Name = "link_entrar_conta"
        Me.link_entrar_conta.Size = New System.Drawing.Size(211, 20)
        Me.link_entrar_conta.TabIndex = 7
        Me.link_entrar_conta.TabStop = True
        Me.link_entrar_conta.Text = "ENTRAR COM SUA CONTA"
        '
        'btn_editar_senha
        '
        Me.btn_editar_senha.BackgroundImage = Global.projeto_confeitaria.My.Resources.Resources.azul_royal_escuro
        Me.btn_editar_senha.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_editar_senha.ForeColor = System.Drawing.Color.White
        Me.btn_editar_senha.Image = Global.projeto_confeitaria.My.Resources.Resources.azul_royal_escuro
        Me.btn_editar_senha.Location = New System.Drawing.Point(661, 427)
        Me.btn_editar_senha.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.btn_editar_senha.Name = "btn_editar_senha"
        Me.btn_editar_senha.Size = New System.Drawing.Size(181, 74)
        Me.btn_editar_senha.TabIndex = 6
        Me.btn_editar_senha.Text = "EDITAR SENHA"
        Me.btn_editar_senha.UseVisualStyleBackColor = True
        '
        'txt_cpf_usuario
        '
        Me.txt_cpf_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cpf_usuario.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_cpf_usuario.Location = New System.Drawing.Point(546, 125)
        Me.txt_cpf_usuario.Mask = "999,999,999-99"
        Me.txt_cpf_usuario.Name = "txt_cpf_usuario"
        Me.txt_cpf_usuario.Size = New System.Drawing.Size(403, 31)
        Me.txt_cpf_usuario.TabIndex = 0
        Me.txt_cpf_usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Image = Global.projeto_confeitaria.My.Resources.Resources.logo2
        Me.PictureBox1.Location = New System.Drawing.Point(16, 18)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(476, 553)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 121
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Image = Global.projeto_confeitaria.My.Resources.Resources.cinza
        Me.Label2.Location = New System.Drawing.Point(711, 96)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 31)
        Me.Label2.TabIndex = 122
        Me.Label2.Text = "CPF"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Image = Global.projeto_confeitaria.My.Resources.Resources.cinza
        Me.Label3.Location = New System.Drawing.Point(699, 174)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 31)
        Me.Label3.TabIndex = 123
        Me.Label3.Text = "EMAIL"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Image = Global.projeto_confeitaria.My.Resources.Resources.cinza
        Me.Label4.Location = New System.Drawing.Point(644, 253)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(192, 31)
        Me.Label4.TabIndex = 124
        Me.Label4.Text = "NOVA SENHA"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Image = Global.projeto_confeitaria.My.Resources.Resources.cinza
        Me.Label6.Location = New System.Drawing.Point(564, 336)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(365, 31)
        Me.Label6.TabIndex = 125
        Me.Label6.Text = "CONFIRMAR NOVA SENHA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Image = Global.projeto_confeitaria.My.Resources.Resources.cinza
        Me.Label1.Location = New System.Drawing.Point(563, 35)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(363, 37)
        Me.Label1.TabIndex = 126
        Me.Label1.Text = "ESQUECEU A SENHA?"
        '
        'cbx_mostrar_senha2
        '
        Me.cbx_mostrar_senha2.Appearance = System.Windows.Forms.Appearance.Button
        Me.cbx_mostrar_senha2.AutoSize = True
        Me.cbx_mostrar_senha2.BackColor = System.Drawing.SystemColors.Control
        Me.cbx_mostrar_senha2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx_mostrar_senha2.Image = Global.projeto_confeitaria.My.Resources.Resources.Pictogrammers_Material_Eye_lock_open_24
        Me.cbx_mostrar_senha2.Location = New System.Drawing.Point(919, 370)
        Me.cbx_mostrar_senha2.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.cbx_mostrar_senha2.Name = "cbx_mostrar_senha2"
        Me.cbx_mostrar_senha2.Size = New System.Drawing.Size(30, 30)
        Me.cbx_mostrar_senha2.TabIndex = 5
        Me.cbx_mostrar_senha2.UseVisualStyleBackColor = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackgroundImage = Global.projeto_confeitaria.My.Resources.Resources.azul_notuno
        Me.PictureBox5.Image = Global.projeto_confeitaria.My.Resources.Resources.azul_notuno
        Me.PictureBox5.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(990, 12)
        Me.PictureBox5.TabIndex = 131
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
        Me.PictureBox2.TabIndex = 132
        Me.PictureBox2.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BackgroundImage = Global.projeto_confeitaria.My.Resources.Resources.azul_notuno
        Me.PictureBox8.Image = Global.projeto_confeitaria.My.Resources.Resources.azul_notuno
        Me.PictureBox8.Location = New System.Drawing.Point(0, 11)
        Me.PictureBox8.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(12, 596)
        Me.PictureBox8.TabIndex = 133
        Me.PictureBox8.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.projeto_confeitaria.My.Resources.Resources.azul_notuno
        Me.PictureBox3.Image = Global.projeto_confeitaria.My.Resources.Resources.azul_notuno
        Me.PictureBox3.Location = New System.Drawing.Point(978, 11)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(12, 596)
        Me.PictureBox3.TabIndex = 134
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImage = Global.projeto_confeitaria.My.Resources.Resources.azul_notuno
        Me.PictureBox4.Image = Global.projeto_confeitaria.My.Resources.Resources.azul_notuno
        Me.PictureBox4.Location = New System.Drawing.Point(498, 11)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(12, 596)
        Me.PictureBox4.TabIndex = 135
        Me.PictureBox4.TabStop = False
        '
        'form_esqueci_senha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.projeto_confeitaria.My.Resources.Resources.cinza
        Me.ClientSize = New System.Drawing.Size(989, 614)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.cbx_mostrar_senha2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txt_cpf_usuario)
        Me.Controls.Add(Me.cbx_mostrar_senha)
        Me.Controls.Add(Me.txt_csenha)
        Me.Controls.Add(Me.txt_email_usuario)
        Me.Controls.Add(Me.txt_senha_usuario)
        Me.Controls.Add(Me.link_entrar_conta)
        Me.Controls.Add(Me.btn_editar_senha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.Name = "form_esqueci_senha"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "REDEFINIR SENHA"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbx_mostrar_senha As CheckBox
    Friend WithEvents txt_csenha As TextBox
    Friend WithEvents txt_email_usuario As TextBox
    Friend WithEvents txt_senha_usuario As TextBox
    Friend WithEvents link_entrar_conta As LinkLabel
    Friend WithEvents btn_editar_senha As Button
    Friend WithEvents txt_cpf_usuario As MaskedTextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cbx_mostrar_senha2 As CheckBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
End Class
