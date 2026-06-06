<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form_cad_usuarios
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_cad_usuarios))
        Me.dgv_usuario = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cpf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.funcao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bloqueado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.excluir = New System.Windows.Forms.DataGridViewImageColumn()
        Me.txt_email_usuario = New System.Windows.Forms.TextBox()
        Me.txt_nome_usuario = New System.Windows.Forms.TextBox()
        Me.txt_senha_usuario = New System.Windows.Forms.TextBox()
        Me.btn_voltar = New System.Windows.Forms.Button()
        Me.txt_buscar_usuario = New System.Windows.Forms.TextBox()
        Me.cmb_parametro_usuario = New System.Windows.Forms.ComboBox()
        Me.cmb_tipo_usuario = New System.Windows.Forms.ComboBox()
        Me.btn_gravar_usuario = New System.Windows.Forms.Button()
        Me.txt_cpf_usuario = New System.Windows.Forms.MaskedTextBox()
        Me.txt_telefone_usuario = New System.Windows.Forms.MaskedTextBox()
        Me.cbx_senha = New System.Windows.Forms.CheckBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        CType(Me.dgv_usuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_usuario
        '
        Me.dgv_usuario.AllowUserToAddRows = False
        Me.dgv_usuario.AllowUserToDeleteRows = False
        Me.dgv_usuario.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.dgv_usuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_usuario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.cpf, Me.email, Me.funcao, Me.bloqueado, Me.excluir})
        Me.dgv_usuario.Location = New System.Drawing.Point(386, 121)
        Me.dgv_usuario.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_usuario.Name = "dgv_usuario"
        Me.dgv_usuario.ReadOnly = True
        Me.dgv_usuario.RowHeadersWidth = 51
        Me.dgv_usuario.RowTemplate.Height = 24
        Me.dgv_usuario.Size = New System.Drawing.Size(1032, 708)
        Me.dgv_usuario.TabIndex = 10
        '
        'id
        '
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id.DefaultCellStyle = DataGridViewCellStyle11
        Me.id.HeaderText = "ID user"
        Me.id.MinimumWidth = 8
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Width = 50
        '
        'cpf
        '
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cpf.DefaultCellStyle = DataGridViewCellStyle12
        Me.cpf.HeaderText = "CPF user"
        Me.cpf.MinimumWidth = 8
        Me.cpf.Name = "cpf"
        Me.cpf.ReadOnly = True
        Me.cpf.Width = 200
        '
        'email
        '
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.email.DefaultCellStyle = DataGridViewCellStyle13
        Me.email.HeaderText = "Email user"
        Me.email.MinimumWidth = 8
        Me.email.Name = "email"
        Me.email.ReadOnly = True
        Me.email.Width = 200
        '
        'funcao
        '
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.funcao.DefaultCellStyle = DataGridViewCellStyle14
        Me.funcao.HeaderText = "Função"
        Me.funcao.MinimumWidth = 8
        Me.funcao.Name = "funcao"
        Me.funcao.ReadOnly = True
        Me.funcao.Width = 170
        '
        'bloqueado
        '
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bloqueado.DefaultCellStyle = DataGridViewCellStyle15
        Me.bloqueado.HeaderText = "Usuário Bloqueado?"
        Me.bloqueado.MinimumWidth = 8
        Me.bloqueado.Name = "bloqueado"
        Me.bloqueado.ReadOnly = True
        Me.bloqueado.Width = 150
        '
        'excluir
        '
        Me.excluir.HeaderText = "excluir"
        Me.excluir.Image = CType(resources.GetObject("excluir.Image"), System.Drawing.Image)
        Me.excluir.MinimumWidth = 8
        Me.excluir.Name = "excluir"
        Me.excluir.ReadOnly = True
        Me.excluir.Width = 80
        '
        'txt_email_usuario
        '
        Me.txt_email_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_email_usuario.Location = New System.Drawing.Point(44, 456)
        Me.txt_email_usuario.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_email_usuario.Name = "txt_email_usuario"
        Me.txt_email_usuario.Size = New System.Drawing.Size(301, 28)
        Me.txt_email_usuario.TabIndex = 3
        '
        'txt_nome_usuario
        '
        Me.txt_nome_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome_usuario.Location = New System.Drawing.Point(44, 276)
        Me.txt_nome_usuario.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_nome_usuario.Name = "txt_nome_usuario"
        Me.txt_nome_usuario.Size = New System.Drawing.Size(301, 28)
        Me.txt_nome_usuario.TabIndex = 1
        '
        'txt_senha_usuario
        '
        Me.txt_senha_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_senha_usuario.Location = New System.Drawing.Point(44, 548)
        Me.txt_senha_usuario.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_senha_usuario.Name = "txt_senha_usuario"
        Me.txt_senha_usuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_senha_usuario.Size = New System.Drawing.Size(274, 28)
        Me.txt_senha_usuario.TabIndex = 4
        '
        'btn_voltar
        '
        Me.btn_voltar.BackColor = System.Drawing.Color.White
        Me.btn_voltar.BackgroundImage = Global.projeto_confeitaria.My.Resources.Resources.azul_royal_escuro
        Me.btn_voltar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_voltar.ForeColor = System.Drawing.Color.White
        Me.btn_voltar.Image = Global.projeto_confeitaria.My.Resources.Resources.azul_royal_escuro
        Me.btn_voltar.Location = New System.Drawing.Point(105, 24)
        Me.btn_voltar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(172, 73)
        Me.btn_voltar.TabIndex = 10
        Me.btn_voltar.Text = "VOLTAR"
        Me.btn_voltar.UseVisualStyleBackColor = False
        '
        'txt_buscar_usuario
        '
        Me.txt_buscar_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_buscar_usuario.Location = New System.Drawing.Point(899, 58)
        Me.txt_buscar_usuario.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_buscar_usuario.Name = "txt_buscar_usuario"
        Me.txt_buscar_usuario.Size = New System.Drawing.Size(494, 28)
        Me.txt_buscar_usuario.TabIndex = 9
        '
        'cmb_parametro_usuario
        '
        Me.cmb_parametro_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_parametro_usuario.FormattingEnabled = True
        Me.cmb_parametro_usuario.Location = New System.Drawing.Point(408, 55)
        Me.cmb_parametro_usuario.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_parametro_usuario.Name = "cmb_parametro_usuario"
        Me.cmb_parametro_usuario.Size = New System.Drawing.Size(480, 30)
        Me.cmb_parametro_usuario.TabIndex = 8
        '
        'cmb_tipo_usuario
        '
        Me.cmb_tipo_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_tipo_usuario.FormattingEnabled = True
        Me.cmb_tipo_usuario.Location = New System.Drawing.Point(44, 639)
        Me.cmb_tipo_usuario.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_tipo_usuario.Name = "cmb_tipo_usuario"
        Me.cmb_tipo_usuario.Size = New System.Drawing.Size(301, 30)
        Me.cmb_tipo_usuario.TabIndex = 6
        '
        'btn_gravar_usuario
        '
        Me.btn_gravar_usuario.BackgroundImage = Global.projeto_confeitaria.My.Resources.Resources.azul_royal_escuro
        Me.btn_gravar_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_gravar_usuario.ForeColor = System.Drawing.Color.White
        Me.btn_gravar_usuario.Image = Global.projeto_confeitaria.My.Resources.Resources.azul_royal_escuro
        Me.btn_gravar_usuario.Location = New System.Drawing.Point(105, 705)
        Me.btn_gravar_usuario.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_gravar_usuario.Name = "btn_gravar_usuario"
        Me.btn_gravar_usuario.Size = New System.Drawing.Size(172, 73)
        Me.btn_gravar_usuario.TabIndex = 7
        Me.btn_gravar_usuario.Text = "GRAVAR NOVO USUARIO"
        Me.btn_gravar_usuario.UseVisualStyleBackColor = True
        '
        'txt_cpf_usuario
        '
        Me.txt_cpf_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cpf_usuario.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_cpf_usuario.Location = New System.Drawing.Point(44, 192)
        Me.txt_cpf_usuario.Mask = "999,999,999-99"
        Me.txt_cpf_usuario.Name = "txt_cpf_usuario"
        Me.txt_cpf_usuario.Size = New System.Drawing.Size(301, 28)
        Me.txt_cpf_usuario.TabIndex = 0
        Me.txt_cpf_usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_telefone_usuario
        '
        Me.txt_telefone_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_telefone_usuario.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_telefone_usuario.Location = New System.Drawing.Point(44, 365)
        Me.txt_telefone_usuario.Mask = "(99) 00000-0000"
        Me.txt_telefone_usuario.Name = "txt_telefone_usuario"
        Me.txt_telefone_usuario.Size = New System.Drawing.Size(301, 28)
        Me.txt_telefone_usuario.TabIndex = 2
        Me.txt_telefone_usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cbx_senha
        '
        Me.cbx_senha.Appearance = System.Windows.Forms.Appearance.Button
        Me.cbx_senha.AutoSize = True
        Me.cbx_senha.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx_senha.Image = Global.projeto_confeitaria.My.Resources.Resources.Pictogrammers_Material_Eye_lock_open_24
        Me.cbx_senha.Location = New System.Drawing.Point(321, 549)
        Me.cbx_senha.Margin = New System.Windows.Forms.Padding(2)
        Me.cbx_senha.Name = "cbx_senha"
        Me.cbx_senha.Size = New System.Drawing.Size(30, 30)
        Me.cbx_senha.TabIndex = 5
        Me.cbx_senha.UseVisualStyleBackColor = True
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImage = Global.projeto_confeitaria.My.Resources.Resources.azul_notuno
        Me.PictureBox4.Image = Global.projeto_confeitaria.My.Resources.Resources.azul_notuno
        Me.PictureBox4.Location = New System.Drawing.Point(369, -1)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(19, 830)
        Me.PictureBox4.TabIndex = 147
        Me.PictureBox4.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.projeto_confeitaria.My.Resources.Resources.azul_notuno
        Me.PictureBox1.Image = Global.projeto_confeitaria.My.Resources.Resources.azul_notuno
        Me.PictureBox1.Location = New System.Drawing.Point(0, 11)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(19, 830)
        Me.PictureBox1.TabIndex = 148
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.projeto_confeitaria.My.Resources.Resources.marrom_liso
        Me.PictureBox2.Location = New System.Drawing.Point(1410, 11)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(19, 830)
        Me.PictureBox2.TabIndex = 149
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.projeto_confeitaria.My.Resources.Resources.marrom_liso
        Me.PictureBox3.Location = New System.Drawing.Point(0, 823)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(1429, 20)
        Me.PictureBox3.TabIndex = 150
        Me.PictureBox3.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackgroundImage = Global.projeto_confeitaria.My.Resources.Resources.azul_notuno
        Me.PictureBox5.Image = Global.projeto_confeitaria.My.Resources.Resources.azul_notuno
        Me.PictureBox5.Location = New System.Drawing.Point(-1, 104)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(1429, 20)
        Me.PictureBox5.TabIndex = 151
        Me.PictureBox5.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackgroundImage = Global.projeto_confeitaria.My.Resources.Resources.azul_notuno
        Me.PictureBox6.Image = Global.projeto_confeitaria.My.Resources.Resources.azul_notuno
        Me.PictureBox6.Location = New System.Drawing.Point(0, -2)
        Me.PictureBox6.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(1429, 20)
        Me.PictureBox6.TabIndex = 152
        Me.PictureBox6.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Image = Global.projeto_confeitaria.My.Resources.Resources.cinza
        Me.Label9.Location = New System.Drawing.Point(404, 32)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(514, 24)
        Me.Label9.TabIndex = 153
        Me.Label9.Text = "SELECIONE O TIPO DE PARAMETRO PARA PESQUISAR:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Image = Global.projeto_confeitaria.My.Resources.Resources.cinza
        Me.Label10.Location = New System.Drawing.Point(966, 34)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(364, 24)
        Me.Label10.TabIndex = 154
        Me.Label10.Text = "DIGITE UM PARAMETRO DE PESQUISA:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Image = Global.projeto_confeitaria.My.Resources.Resources.cinza
        Me.Label6.Location = New System.Drawing.Point(166, 165)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 24)
        Me.Label6.TabIndex = 155
        Me.Label6.Text = "CPF"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Image = Global.projeto_confeitaria.My.Resources.Resources.cinza
        Me.Label8.Location = New System.Drawing.Point(166, 253)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 24)
        Me.Label8.TabIndex = 156
        Me.Label8.Text = "NOME"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Image = Global.projeto_confeitaria.My.Resources.Resources.cinza
        Me.Label11.Location = New System.Drawing.Point(145, 340)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(112, 24)
        Me.Label11.TabIndex = 157
        Me.Label11.Text = "TELEFONE"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Image = Global.projeto_confeitaria.My.Resources.Resources.cinza
        Me.Label12.Location = New System.Drawing.Point(164, 432)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(66, 24)
        Me.Label12.TabIndex = 158
        Me.Label12.Text = "EMAIL"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Image = Global.projeto_confeitaria.My.Resources.Resources.cinza
        Me.Label13.Location = New System.Drawing.Point(157, 521)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(76, 24)
        Me.Label13.TabIndex = 159
        Me.Label13.Text = "SENHA"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Image = Global.projeto_confeitaria.My.Resources.Resources.cinza
        Me.Label14.Location = New System.Drawing.Point(101, 616)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(203, 24)
        Me.Label14.TabIndex = 160
        Me.Label14.Text = "SELECIONAR O TIPO:"
        '
        'form_cad_usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.projeto_confeitaria.My.Resources.Resources.cinza
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.cbx_senha)
        Me.Controls.Add(Me.txt_telefone_usuario)
        Me.Controls.Add(Me.txt_cpf_usuario)
        Me.Controls.Add(Me.cmb_tipo_usuario)
        Me.Controls.Add(Me.btn_gravar_usuario)
        Me.Controls.Add(Me.txt_buscar_usuario)
        Me.Controls.Add(Me.cmb_parametro_usuario)
        Me.Controls.Add(Me.btn_voltar)
        Me.Controls.Add(Me.dgv_usuario)
        Me.Controls.Add(Me.txt_email_usuario)
        Me.Controls.Add(Me.txt_nome_usuario)
        Me.Controls.Add(Me.txt_senha_usuario)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "form_cad_usuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CADASTRO DE USUARIO"
        CType(Me.dgv_usuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv_usuario As DataGridView
    Friend WithEvents txt_email_usuario As TextBox
    Friend WithEvents txt_nome_usuario As TextBox
    Friend WithEvents txt_senha_usuario As TextBox
    Friend WithEvents btn_voltar As Button
    Friend WithEvents txt_buscar_usuario As TextBox
    Friend WithEvents cmb_parametro_usuario As ComboBox
    Friend WithEvents cmb_tipo_usuario As ComboBox
    Friend WithEvents btn_gravar_usuario As Button
    Friend WithEvents txt_cpf_usuario As MaskedTextBox
    Friend WithEvents txt_telefone_usuario As MaskedTextBox
    Friend WithEvents cbx_senha As CheckBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents cpf As DataGridViewTextBoxColumn
    Friend WithEvents email As DataGridViewTextBoxColumn
    Friend WithEvents funcao As DataGridViewTextBoxColumn
    Friend WithEvents bloqueado As DataGridViewTextBoxColumn
    Friend WithEvents excluir As DataGridViewImageColumn
End Class
