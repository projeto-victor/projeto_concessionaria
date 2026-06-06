<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form_cad_prod
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_cad_prod))
        Me.lbl_valor = New System.Windows.Forms.Label()
        Me.txt_valor_produto = New System.Windows.Forms.TextBox()
        Me.btn_gravar_produto = New System.Windows.Forms.Button()
        Me.lbl_nome = New System.Windows.Forms.Label()
        Me.txt_nome_produto = New System.Windows.Forms.TextBox()
        Me.btn_voltar = New System.Windows.Forms.Button()
        Me.txt_buscar_produto = New System.Windows.Forms.TextBox()
        Me.cmb_parametro_produto = New System.Windows.Forms.ComboBox()
        Me.dgv_produto = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantidade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.editar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Excluir = New System.Windows.Forms.DataGridViewImageColumn()
        Me.cmb_destino_produto = New System.Windows.Forms.ComboBox()
        Me.txt_qtde = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_tipo = New System.Windows.Forms.Label()
        Me.cmb_tipo_produto = New System.Windows.Forms.ComboBox()
        Me.lbl_foto = New System.Windows.Forms.Label()
        CType(Me.dgv_produto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_valor
        '
        Me.lbl_valor.AutoSize = True
        Me.lbl_valor.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_valor.ForeColor = System.Drawing.Color.White
        Me.lbl_valor.Image = Global.projeto_confeitaria.My.Resources.Resources.cinza
        Me.lbl_valor.Location = New System.Drawing.Point(153, 301)
        Me.lbl_valor.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_valor.Name = "lbl_valor"
        Me.lbl_valor.Size = New System.Drawing.Size(74, 24)
        Me.lbl_valor.TabIndex = 11
        Me.lbl_valor.Text = "VALOR"
        '
        'txt_valor_produto
        '
        Me.txt_valor_produto.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_valor_produto.Location = New System.Drawing.Point(44, 324)
        Me.txt_valor_produto.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_valor_produto.Name = "txt_valor_produto"
        Me.txt_valor_produto.Size = New System.Drawing.Size(301, 28)
        Me.txt_valor_produto.TabIndex = 3
        '
        'btn_gravar_produto
        '
        Me.btn_gravar_produto.BackgroundImage = Global.projeto_confeitaria.My.Resources.Resources.azul_royal_escuro
        Me.btn_gravar_produto.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_gravar_produto.ForeColor = System.Drawing.Color.White
        Me.btn_gravar_produto.Image = Global.projeto_confeitaria.My.Resources.Resources.azul_royal_escuro
        Me.btn_gravar_produto.Location = New System.Drawing.Point(105, 561)
        Me.btn_gravar_produto.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_gravar_produto.Name = "btn_gravar_produto"
        Me.btn_gravar_produto.Size = New System.Drawing.Size(172, 73)
        Me.btn_gravar_produto.TabIndex = 6
        Me.btn_gravar_produto.Text = "GRAVAR NOVO PRODUTO"
        Me.btn_gravar_produto.UseVisualStyleBackColor = True
        '
        'lbl_nome
        '
        Me.lbl_nome.AutoSize = True
        Me.lbl_nome.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nome.ForeColor = System.Drawing.Color.White
        Me.lbl_nome.Image = Global.projeto_confeitaria.My.Resources.Resources.cinza
        Me.lbl_nome.Location = New System.Drawing.Point(163, 221)
        Me.lbl_nome.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_nome.Name = "lbl_nome"
        Me.lbl_nome.Size = New System.Drawing.Size(68, 24)
        Me.lbl_nome.TabIndex = 13
        Me.lbl_nome.Text = "NOME"
        '
        'txt_nome_produto
        '
        Me.txt_nome_produto.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome_produto.Location = New System.Drawing.Point(44, 245)
        Me.txt_nome_produto.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_nome_produto.Name = "txt_nome_produto"
        Me.txt_nome_produto.Size = New System.Drawing.Size(301, 28)
        Me.txt_nome_produto.TabIndex = 2
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
        'txt_buscar_produto
        '
        Me.txt_buscar_produto.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_buscar_produto.Location = New System.Drawing.Point(899, 58)
        Me.txt_buscar_produto.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_buscar_produto.Name = "txt_buscar_produto"
        Me.txt_buscar_produto.Size = New System.Drawing.Size(494, 28)
        Me.txt_buscar_produto.TabIndex = 8
        '
        'cmb_parametro_produto
        '
        Me.cmb_parametro_produto.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_parametro_produto.FormattingEnabled = True
        Me.cmb_parametro_produto.Location = New System.Drawing.Point(408, 55)
        Me.cmb_parametro_produto.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_parametro_produto.Name = "cmb_parametro_produto"
        Me.cmb_parametro_produto.Size = New System.Drawing.Size(480, 30)
        Me.cmb_parametro_produto.TabIndex = 7
        '
        'dgv_produto
        '
        Me.dgv_produto.AllowUserToAddRows = False
        Me.dgv_produto.AllowUserToDeleteRows = False
        Me.dgv_produto.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.dgv_produto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_produto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.nome, Me.Quantidade, Me.tipo, Me.valor, Me.editar, Me.Excluir})
        Me.dgv_produto.Location = New System.Drawing.Point(383, 124)
        Me.dgv_produto.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_produto.Name = "dgv_produto"
        Me.dgv_produto.ReadOnly = True
        Me.dgv_produto.RowHeadersWidth = 51
        Me.dgv_produto.RowTemplate.Height = 24
        Me.dgv_produto.Size = New System.Drawing.Size(1035, 705)
        Me.dgv_produto.TabIndex = 9
        '
        'id
        '
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id.DefaultCellStyle = DataGridViewCellStyle11
        Me.id.HeaderText = "Nº"
        Me.id.MinimumWidth = 6
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Width = 45
        '
        'nome
        '
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nome.DefaultCellStyle = DataGridViewCellStyle12
        Me.nome.HeaderText = "Nome"
        Me.nome.MinimumWidth = 6
        Me.nome.Name = "nome"
        Me.nome.ReadOnly = True
        Me.nome.Width = 200
        '
        'Quantidade
        '
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Quantidade.DefaultCellStyle = DataGridViewCellStyle13
        Me.Quantidade.HeaderText = "Quantidade"
        Me.Quantidade.MinimumWidth = 6
        Me.Quantidade.Name = "Quantidade"
        Me.Quantidade.ReadOnly = True
        Me.Quantidade.Width = 70
        '
        'tipo
        '
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tipo.DefaultCellStyle = DataGridViewCellStyle14
        Me.tipo.HeaderText = "Tipo"
        Me.tipo.MinimumWidth = 6
        Me.tipo.Name = "tipo"
        Me.tipo.ReadOnly = True
        Me.tipo.Width = 200
        '
        'valor
        '
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valor.DefaultCellStyle = DataGridViewCellStyle15
        Me.valor.HeaderText = "Valor"
        Me.valor.MinimumWidth = 6
        Me.valor.Name = "valor"
        Me.valor.ReadOnly = True
        Me.valor.Width = 50
        '
        'editar
        '
        Me.editar.HeaderText = "EDITAR"
        Me.editar.Image = CType(resources.GetObject("editar.Image"), System.Drawing.Image)
        Me.editar.MinimumWidth = 6
        Me.editar.Name = "editar"
        Me.editar.ReadOnly = True
        Me.editar.Width = 70
        '
        'Excluir
        '
        Me.Excluir.HeaderText = "EXCLUIR"
        Me.Excluir.Image = CType(resources.GetObject("Excluir.Image"), System.Drawing.Image)
        Me.Excluir.MinimumWidth = 6
        Me.Excluir.Name = "Excluir"
        Me.Excluir.ReadOnly = True
        Me.Excluir.Width = 70
        '
        'cmb_destino_produto
        '
        Me.cmb_destino_produto.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_destino_produto.FormattingEnabled = True
        Me.cmb_destino_produto.Location = New System.Drawing.Point(44, 165)
        Me.cmb_destino_produto.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_destino_produto.Name = "cmb_destino_produto"
        Me.cmb_destino_produto.Size = New System.Drawing.Size(301, 30)
        Me.cmb_destino_produto.TabIndex = 1
        '
        'txt_qtde
        '
        Me.txt_qtde.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_qtde.Location = New System.Drawing.Point(44, 510)
        Me.txt_qtde.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_qtde.Name = "txt_qtde"
        Me.txt_qtde.Size = New System.Drawing.Size(301, 28)
        Me.txt_qtde.TabIndex = 5
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.projeto_confeitaria.My.Resources.Resources.azul_notuno
        Me.PictureBox1.Image = Global.projeto_confeitaria.My.Resources.Resources.azul_notuno
        Me.PictureBox1.Location = New System.Drawing.Point(0, 11)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(19, 830)
        Me.PictureBox1.TabIndex = 149
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.projeto_confeitaria.My.Resources.Resources.azul_notuno
        Me.PictureBox2.Image = Global.projeto_confeitaria.My.Resources.Resources.azul_notuno
        Me.PictureBox2.Location = New System.Drawing.Point(369, -1)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(19, 830)
        Me.PictureBox2.TabIndex = 150
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.projeto_confeitaria.My.Resources.Resources.marrom_liso
        Me.PictureBox3.Location = New System.Drawing.Point(1410, 11)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(19, 830)
        Me.PictureBox3.TabIndex = 151
        Me.PictureBox3.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackgroundImage = Global.projeto_confeitaria.My.Resources.Resources.azul_notuno
        Me.PictureBox6.Image = Global.projeto_confeitaria.My.Resources.Resources.azul_notuno
        Me.PictureBox6.Location = New System.Drawing.Point(-1, 104)
        Me.PictureBox6.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(1429, 20)
        Me.PictureBox6.TabIndex = 153
        Me.PictureBox6.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.projeto_confeitaria.My.Resources.Resources.marrom_liso
        Me.PictureBox4.Location = New System.Drawing.Point(0, 823)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(1429, 20)
        Me.PictureBox4.TabIndex = 154
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackgroundImage = Global.projeto_confeitaria.My.Resources.Resources.azul_notuno
        Me.PictureBox5.Image = Global.projeto_confeitaria.My.Resources.Resources.azul_notuno
        Me.PictureBox5.Location = New System.Drawing.Point(0, -2)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(1429, 20)
        Me.PictureBox5.TabIndex = 155
        Me.PictureBox5.TabStop = False
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
        Me.Label9.TabIndex = 156
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
        Me.Label10.TabIndex = 157
        Me.Label10.Text = "DIGITE UM PARAMETRO DE PESQUISA:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Image = Global.projeto_confeitaria.My.Resources.Resources.cinza
        Me.Label6.Location = New System.Drawing.Point(92, 141)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(218, 24)
        Me.Label6.TabIndex = 158
        Me.Label6.Text = "SELECIONAR DESTINO"
        '
        'lbl_tipo
        '
        Me.lbl_tipo.AutoSize = True
        Me.lbl_tipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tipo.ForeColor = System.Drawing.Color.White
        Me.lbl_tipo.Image = Global.projeto_confeitaria.My.Resources.Resources.cinza
        Me.lbl_tipo.Location = New System.Drawing.Point(101, 384)
        Me.lbl_tipo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_tipo.Name = "lbl_tipo"
        Me.lbl_tipo.Size = New System.Drawing.Size(178, 24)
        Me.lbl_tipo.TabIndex = 160
        Me.lbl_tipo.Text = "SELECIONAR TIPO"
        '
        'cmb_tipo_produto
        '
        Me.cmb_tipo_produto.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_tipo_produto.FormattingEnabled = True
        Me.cmb_tipo_produto.Location = New System.Drawing.Point(44, 408)
        Me.cmb_tipo_produto.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_tipo_produto.Name = "cmb_tipo_produto"
        Me.cmb_tipo_produto.Size = New System.Drawing.Size(301, 30)
        Me.cmb_tipo_produto.TabIndex = 4
        '
        'lbl_foto
        '
        Me.lbl_foto.AutoSize = True
        Me.lbl_foto.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_foto.ForeColor = System.Drawing.Color.White
        Me.lbl_foto.Image = Global.projeto_confeitaria.My.Resources.Resources.cinza
        Me.lbl_foto.Location = New System.Drawing.Point(109, 472)
        Me.lbl_foto.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_foto.Name = "lbl_foto"
        Me.lbl_foto.Size = New System.Drawing.Size(0, 24)
        Me.lbl_foto.TabIndex = 59
        '
        'form_cad_prod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.projeto_confeitaria.My.Resources.Resources.cinza
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.lbl_tipo)
        Me.Controls.Add(Me.cmb_tipo_produto)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txt_qtde)
        Me.Controls.Add(Me.lbl_foto)
        Me.Controls.Add(Me.cmb_destino_produto)
        Me.Controls.Add(Me.txt_buscar_produto)
        Me.Controls.Add(Me.cmb_parametro_produto)
        Me.Controls.Add(Me.btn_voltar)
        Me.Controls.Add(Me.lbl_nome)
        Me.Controls.Add(Me.txt_nome_produto)
        Me.Controls.Add(Me.lbl_valor)
        Me.Controls.Add(Me.txt_valor_produto)
        Me.Controls.Add(Me.btn_gravar_produto)
        Me.Controls.Add(Me.dgv_produto)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "form_cad_prod"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CADASTRO DE PRODUTOS"
        CType(Me.dgv_produto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_valor As Label
    Friend WithEvents txt_valor_produto As TextBox
    Friend WithEvents btn_gravar_produto As Button
    Friend WithEvents lbl_nome As Label
    Friend WithEvents txt_nome_produto As TextBox
    Friend WithEvents btn_voltar As Button
    Friend WithEvents txt_buscar_produto As TextBox
    Friend WithEvents cmb_parametro_produto As ComboBox
    Friend WithEvents dgv_produto As DataGridView
    Friend WithEvents cmb_destino_produto As ComboBox
    Friend WithEvents txt_qtde As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lbl_tipo As Label
    Friend WithEvents cmb_tipo_produto As ComboBox
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents nome As DataGridViewTextBoxColumn
    Friend WithEvents Quantidade As DataGridViewTextBoxColumn
    Friend WithEvents tipo As DataGridViewTextBoxColumn
    Friend WithEvents valor As DataGridViewTextBoxColumn
    Friend WithEvents editar As DataGridViewImageColumn
    Friend WithEvents Excluir As DataGridViewImageColumn
    Friend WithEvents lbl_foto As Label
End Class
