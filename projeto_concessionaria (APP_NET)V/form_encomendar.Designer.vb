<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form_encomendar
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_encomendar))
        Me.dgv_encomenda = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.escolha = New System.Windows.Forms.DataGridViewImageColumn()
        Me.img_foto_ecomenda = New System.Windows.Forms.PictureBox()
        Me.txt_valor_encomenda = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_encomenda = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_voltar = New System.Windows.Forms.Button()
        Me.txt_sabor = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.txt_buscar_produto = New System.Windows.Forms.TextBox()
        Me.cmb_parametro_produto = New System.Windows.Forms.ComboBox()
        Me.PictureBox14 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_qtde = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgv_encomenda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_foto_ecomenda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_encomenda
        '
        Me.dgv_encomenda.AllowUserToAddRows = False
        Me.dgv_encomenda.AllowUserToDeleteRows = False
        Me.dgv_encomenda.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.dgv_encomenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_encomenda.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.nome, Me.Tipo, Me.valor, Me.escolha})
        Me.dgv_encomenda.Location = New System.Drawing.Point(386, 120)
        Me.dgv_encomenda.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.dgv_encomenda.Name = "dgv_encomenda"
        Me.dgv_encomenda.ReadOnly = True
        Me.dgv_encomenda.RowHeadersWidth = 51
        Me.dgv_encomenda.RowTemplate.Height = 24
        Me.dgv_encomenda.Size = New System.Drawing.Size(1032, 708)
        Me.dgv_encomenda.TabIndex = 0
        '
        'id
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id.DefaultCellStyle = DataGridViewCellStyle1
        Me.id.HeaderText = "Nº do produto"
        Me.id.MinimumWidth = 6
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Width = 75
        '
        'nome
        '
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.nome.DefaultCellStyle = DataGridViewCellStyle2
        Me.nome.HeaderText = "Nome do produto"
        Me.nome.MinimumWidth = 6
        Me.nome.Name = "nome"
        Me.nome.ReadOnly = True
        Me.nome.Width = 200
        '
        'Tipo
        '
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Tipo.DefaultCellStyle = DataGridViewCellStyle3
        Me.Tipo.HeaderText = "Tipo do produto"
        Me.Tipo.MinimumWidth = 6
        Me.Tipo.Name = "Tipo"
        Me.Tipo.ReadOnly = True
        Me.Tipo.Width = 200
        '
        'valor
        '
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.valor.DefaultCellStyle = DataGridViewCellStyle4
        Me.valor.HeaderText = "Valor do Produto"
        Me.valor.MinimumWidth = 6
        Me.valor.Name = "valor"
        Me.valor.ReadOnly = True
        Me.valor.Width = 125
        '
        'escolha
        '
        Me.escolha.HeaderText = "Escolha"
        Me.escolha.Image = CType(resources.GetObject("escolha.Image"), System.Drawing.Image)
        Me.escolha.MinimumWidth = 6
        Me.escolha.Name = "escolha"
        Me.escolha.ReadOnly = True
        Me.escolha.Width = 125
        '
        'img_foto_ecomenda
        '
        Me.img_foto_ecomenda.Location = New System.Drawing.Point(335, 416)
        Me.img_foto_ecomenda.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.img_foto_ecomenda.Name = "img_foto_ecomenda"
        Me.img_foto_ecomenda.Size = New System.Drawing.Size(10, 10)
        Me.img_foto_ecomenda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_foto_ecomenda.TabIndex = 19
        Me.img_foto_ecomenda.TabStop = False
        '
        'txt_valor_encomenda
        '
        Me.txt_valor_encomenda.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_valor_encomenda.Location = New System.Drawing.Point(44, 249)
        Me.txt_valor_encomenda.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_valor_encomenda.Name = "txt_valor_encomenda"
        Me.txt_valor_encomenda.Size = New System.Drawing.Size(301, 28)
        Me.txt_valor_encomenda.TabIndex = 100
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Image = Global.projeto_confeitaria.My.Resources.Resources.cinza
        Me.Label3.Location = New System.Drawing.Point(155, 224)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 24)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "VALOR"
        '
        'btn_encomenda
        '
        Me.btn_encomenda.BackgroundImage = Global.projeto_confeitaria.My.Resources.Resources.azul_royal_escuro
        Me.btn_encomenda.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_encomenda.ForeColor = System.Drawing.Color.White
        Me.btn_encomenda.Image = Global.projeto_confeitaria.My.Resources.Resources.azul_royal_escuro
        Me.btn_encomenda.Location = New System.Drawing.Point(105, 451)
        Me.btn_encomenda.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btn_encomenda.Name = "btn_encomenda"
        Me.btn_encomenda.Size = New System.Drawing.Size(172, 73)
        Me.btn_encomenda.TabIndex = 2
        Me.btn_encomenda.Text = "ENCOMENDAR "
        Me.btn_encomenda.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Image = Global.projeto_confeitaria.My.Resources.Resources.cinza
        Me.Label4.Location = New System.Drawing.Point(155, 150)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 24)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "MODELO"
        '
        'btn_voltar
        '
        Me.btn_voltar.BackColor = System.Drawing.Color.White
        Me.btn_voltar.BackgroundImage = Global.projeto_confeitaria.My.Resources.Resources.azul_royal_escuro
        Me.btn_voltar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_voltar.ForeColor = System.Drawing.Color.White
        Me.btn_voltar.Image = Global.projeto_confeitaria.My.Resources.Resources.azul_royal_escuro
        Me.btn_voltar.Location = New System.Drawing.Point(105, 24)
        Me.btn_voltar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(172, 73)
        Me.btn_voltar.TabIndex = 5
        Me.btn_voltar.Text = "VOLTAR"
        Me.btn_voltar.UseVisualStyleBackColor = False
        '
        'txt_sabor
        '
        Me.txt_sabor.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_sabor.Location = New System.Drawing.Point(44, 176)
        Me.txt_sabor.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_sabor.Name = "txt_sabor"
        Me.txt_sabor.Size = New System.Drawing.Size(301, 28)
        Me.txt_sabor.TabIndex = 100
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Image = Global.projeto_confeitaria.My.Resources.Resources.cinza
        Me.Label6.Location = New System.Drawing.Point(155, 288)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 24)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "TOTAL"
        '
        'txt_total
        '
        Me.txt_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total.Location = New System.Drawing.Point(44, 323)
        Me.txt_total.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(301, 28)
        Me.txt_total.TabIndex = 51
        '
        'txt_buscar_produto
        '
        Me.txt_buscar_produto.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_buscar_produto.Location = New System.Drawing.Point(899, 58)
        Me.txt_buscar_produto.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_buscar_produto.Name = "txt_buscar_produto"
        Me.txt_buscar_produto.Size = New System.Drawing.Size(494, 28)
        Me.txt_buscar_produto.TabIndex = 4
        '
        'cmb_parametro_produto
        '
        Me.cmb_parametro_produto.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_parametro_produto.FormattingEnabled = True
        Me.cmb_parametro_produto.Location = New System.Drawing.Point(408, 55)
        Me.cmb_parametro_produto.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_parametro_produto.Name = "cmb_parametro_produto"
        Me.cmb_parametro_produto.Size = New System.Drawing.Size(480, 30)
        Me.cmb_parametro_produto.TabIndex = 3
        '
        'PictureBox14
        '
        Me.PictureBox14.BackgroundImage = Global.projeto_confeitaria.My.Resources.Resources.azul_notuno
        Me.PictureBox14.Image = Global.projeto_confeitaria.My.Resources.Resources.azul_notuno
        Me.PictureBox14.Location = New System.Drawing.Point(0, -2)
        Me.PictureBox14.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox14.Name = "PictureBox14"
        Me.PictureBox14.Size = New System.Drawing.Size(1429, 20)
        Me.PictureBox14.TabIndex = 142
        Me.PictureBox14.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.projeto_confeitaria.My.Resources.Resources.marrom_liso
        Me.PictureBox1.Location = New System.Drawing.Point(0, 823)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1429, 20)
        Me.PictureBox1.TabIndex = 143
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.projeto_confeitaria.My.Resources.Resources.azul_notuno
        Me.PictureBox2.Image = Global.projeto_confeitaria.My.Resources.Resources.azul_notuno
        Me.PictureBox2.Location = New System.Drawing.Point(0, 11)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(19, 818)
        Me.PictureBox2.TabIndex = 144
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.projeto_confeitaria.My.Resources.Resources.marrom_liso
        Me.PictureBox3.Location = New System.Drawing.Point(1410, 11)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(19, 818)
        Me.PictureBox3.TabIndex = 145
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImage = Global.projeto_confeitaria.My.Resources.Resources.azul_notuno
        Me.PictureBox4.Image = Global.projeto_confeitaria.My.Resources.Resources.azul_notuno
        Me.PictureBox4.Location = New System.Drawing.Point(369, -1)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(19, 830)
        Me.PictureBox4.TabIndex = 146
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackgroundImage = Global.projeto_confeitaria.My.Resources.Resources.azul_notuno
        Me.PictureBox5.Image = Global.projeto_confeitaria.My.Resources.Resources.azul_notuno
        Me.PictureBox5.Location = New System.Drawing.Point(-1, 104)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(1429, 20)
        Me.PictureBox5.TabIndex = 147
        Me.PictureBox5.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Image = Global.projeto_confeitaria.My.Resources.Resources.cinza
        Me.Label2.Location = New System.Drawing.Point(404, 32)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(514, 24)
        Me.Label2.TabIndex = 150
        Me.Label2.Text = "SELECIONE O TIPO DE PARAMETRO PARA PESQUISAR:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Image = Global.projeto_confeitaria.My.Resources.Resources.cinza
        Me.Label8.Location = New System.Drawing.Point(966, 34)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(364, 24)
        Me.Label8.TabIndex = 151
        Me.Label8.Text = "DIGITE UM PARAMETRO DE PESQUISA:"
        '
        'txt_qtde
        '
        Me.txt_qtde.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_qtde.Location = New System.Drawing.Point(44, 398)
        Me.txt_qtde.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_qtde.Name = "txt_qtde"
        Me.txt_qtde.Size = New System.Drawing.Size(301, 28)
        Me.txt_qtde.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Image = Global.projeto_confeitaria.My.Resources.Resources.cinza
        Me.Label1.Location = New System.Drawing.Point(125, 371)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 24)
        Me.Label1.TabIndex = 152
        Me.Label1.Text = "QUANTIDADE"
        '
        'form_encomendar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.projeto_confeitaria.My.Resources.Resources.cinza
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox14)
        Me.Controls.Add(Me.txt_buscar_produto)
        Me.Controls.Add(Me.cmb_parametro_produto)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.txt_sabor)
        Me.Controls.Add(Me.txt_qtde)
        Me.Controls.Add(Me.btn_voltar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btn_encomenda)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_valor_encomenda)
        Me.Controls.Add(Me.img_foto_ecomenda)
        Me.Controls.Add(Me.dgv_encomenda)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "form_encomendar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ENCOMENDAR"
        CType(Me.dgv_encomenda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_foto_ecomenda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_encomenda As DataGridView
    Friend WithEvents img_foto_ecomenda As PictureBox
    Friend WithEvents txt_valor_encomenda As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_encomenda As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_voltar As Button
    Friend WithEvents txt_sabor As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_total As TextBox
    Friend WithEvents txt_buscar_produto As TextBox
    Friend WithEvents cmb_parametro_produto As ComboBox
    Friend WithEvents PictureBox14 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents nome As DataGridViewTextBoxColumn
    Friend WithEvents Tipo As DataGridViewTextBoxColumn
    Friend WithEvents valor As DataGridViewTextBoxColumn
    Friend WithEvents escolha As DataGridViewImageColumn
    Friend WithEvents txt_qtde As TextBox
    Friend WithEvents Label1 As Label
End Class
