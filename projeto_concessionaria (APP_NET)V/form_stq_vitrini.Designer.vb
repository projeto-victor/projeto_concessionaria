<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_stq_vitrini
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_stq_vitrini))
        Me.btn_voltar = New System.Windows.Forms.Button()
        Me.dgv_vitrini = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qtde = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.aumentar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.diminuir = New System.Windows.Forms.DataGridViewImageColumn()
        Me.btn_salvar = New System.Windows.Forms.Button()
        Me.txt_buscar_produto = New System.Windows.Forms.TextBox()
        Me.cmb_parametro_produto = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        CType(Me.dgv_vitrini, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_voltar
        '
        Me.btn_voltar.BackColor = System.Drawing.Color.White
        Me.btn_voltar.BackgroundImage = Global.projeto_confeitaria.My.Resources.Resources.azul_royal_escuro
        Me.btn_voltar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_voltar.ForeColor = System.Drawing.Color.White
        Me.btn_voltar.Image = Global.projeto_confeitaria.My.Resources.Resources.azul_royal_escuro
        Me.btn_voltar.Location = New System.Drawing.Point(106, 47)
        Me.btn_voltar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(172, 73)
        Me.btn_voltar.TabIndex = 2
        Me.btn_voltar.Text = "VOLTAR"
        Me.btn_voltar.UseVisualStyleBackColor = False
        '
        'dgv_vitrini
        '
        Me.dgv_vitrini.AllowUserToAddRows = False
        Me.dgv_vitrini.AllowUserToDeleteRows = False
        Me.dgv_vitrini.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.dgv_vitrini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_vitrini.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.nome, Me.tipo, Me.qtde, Me.aumentar, Me.diminuir})
        Me.dgv_vitrini.Location = New System.Drawing.Point(386, 164)
        Me.dgv_vitrini.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_vitrini.Name = "dgv_vitrini"
        Me.dgv_vitrini.ReadOnly = True
        Me.dgv_vitrini.RowHeadersWidth = 51
        Me.dgv_vitrini.RowTemplate.Height = 24
        Me.dgv_vitrini.Size = New System.Drawing.Size(1031, 666)
        Me.dgv_vitrini.TabIndex = 0
        '
        'id
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.id.DefaultCellStyle = DataGridViewCellStyle1
        Me.id.HeaderText = "ID pedido"
        Me.id.MinimumWidth = 6
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Width = 50
        '
        'nome
        '
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.nome.DefaultCellStyle = DataGridViewCellStyle2
        Me.nome.HeaderText = "Nome Produto"
        Me.nome.MinimumWidth = 6
        Me.nome.Name = "nome"
        Me.nome.ReadOnly = True
        Me.nome.Width = 200
        '
        'tipo
        '
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.tipo.DefaultCellStyle = DataGridViewCellStyle3
        Me.tipo.HeaderText = "Tipo Produto"
        Me.tipo.MinimumWidth = 6
        Me.tipo.Name = "tipo"
        Me.tipo.ReadOnly = True
        Me.tipo.Width = 200
        '
        'qtde
        '
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.qtde.DefaultCellStyle = DataGridViewCellStyle4
        Me.qtde.HeaderText = "Quantidade"
        Me.qtde.MinimumWidth = 6
        Me.qtde.Name = "qtde"
        Me.qtde.ReadOnly = True
        Me.qtde.Width = 125
        '
        'aumentar
        '
        Me.aumentar.HeaderText = "AUMENTAR"
        Me.aumentar.Image = CType(resources.GetObject("aumentar.Image"), System.Drawing.Image)
        Me.aumentar.MinimumWidth = 6
        Me.aumentar.Name = "aumentar"
        Me.aumentar.ReadOnly = True
        Me.aumentar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.aumentar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.aumentar.Width = 105
        '
        'diminuir
        '
        Me.diminuir.HeaderText = "DIMINUIR"
        Me.diminuir.Image = CType(resources.GetObject("diminuir.Image"), System.Drawing.Image)
        Me.diminuir.MinimumWidth = 6
        Me.diminuir.Name = "diminuir"
        Me.diminuir.ReadOnly = True
        Me.diminuir.Width = 105
        '
        'btn_salvar
        '
        Me.btn_salvar.BackColor = System.Drawing.Color.White
        Me.btn_salvar.BackgroundImage = Global.projeto_confeitaria.My.Resources.Resources.azul_royal_escuro
        Me.btn_salvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salvar.ForeColor = System.Drawing.Color.White
        Me.btn_salvar.Location = New System.Drawing.Point(106, 698)
        Me.btn_salvar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_salvar.Name = "btn_salvar"
        Me.btn_salvar.Size = New System.Drawing.Size(172, 73)
        Me.btn_salvar.TabIndex = 1
        Me.btn_salvar.Text = "SALVAR ESTOQUE"
        Me.btn_salvar.UseVisualStyleBackColor = False
        '
        'txt_buscar_produto
        '
        Me.txt_buscar_produto.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_buscar_produto.Location = New System.Drawing.Point(902, 84)
        Me.txt_buscar_produto.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_buscar_produto.Name = "txt_buscar_produto"
        Me.txt_buscar_produto.Size = New System.Drawing.Size(494, 28)
        Me.txt_buscar_produto.TabIndex = 4
        '
        'cmb_parametro_produto
        '
        Me.cmb_parametro_produto.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_parametro_produto.FormattingEnabled = True
        Me.cmb_parametro_produto.Location = New System.Drawing.Point(404, 81)
        Me.cmb_parametro_produto.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_parametro_produto.Name = "cmb_parametro_produto"
        Me.cmb_parametro_produto.Size = New System.Drawing.Size(480, 30)
        Me.cmb_parametro_produto.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Image = Global.projeto_confeitaria.My.Resources.Resources.cinza
        Me.Label8.Location = New System.Drawing.Point(400, 58)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(514, 24)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "SELECIONE O TIPO DE PARAMETRO PARA PESQUISAR:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Image = Global.projeto_confeitaria.My.Resources.Resources.cinza
        Me.Label6.Location = New System.Drawing.Point(976, 58)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(364, 24)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "DIGITE UM PARAMETRO DE PESQUISA:"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImage = Global.projeto_confeitaria.My.Resources.Resources.cinza
        Me.PictureBox4.Image = Global.projeto_confeitaria.My.Resources.Resources.cinza
        Me.PictureBox4.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(1432, 150)
        Me.PictureBox4.TabIndex = 73
        Me.PictureBox4.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.projeto_confeitaria.My.Resources.Resources.cinza
        Me.PictureBox1.Image = Global.projeto_confeitaria.My.Resources.Resources.cinza
        Me.PictureBox1.Location = New System.Drawing.Point(14, 155)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(358, 692)
        Me.PictureBox1.TabIndex = 74
        Me.PictureBox1.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BackgroundImage = Global.projeto_confeitaria.My.Resources.Resources.azul_notuno
        Me.PictureBox8.Image = Global.projeto_confeitaria.My.Resources.Resources.azul_notuno
        Me.PictureBox8.Location = New System.Drawing.Point(370, 0)
        Me.PictureBox8.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(19, 862)
        Me.PictureBox8.TabIndex = 129
        Me.PictureBox8.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.BackgroundImage = Global.projeto_confeitaria.My.Resources.Resources.azul_notuno
        Me.PictureBox9.Image = Global.projeto_confeitaria.My.Resources.Resources.azul_notuno
        Me.PictureBox9.Location = New System.Drawing.Point(0, 149)
        Me.PictureBox9.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(1432, 18)
        Me.PictureBox9.TabIndex = 130
        Me.PictureBox9.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.BackgroundImage = Global.projeto_confeitaria.My.Resources.Resources.cinza
        Me.PictureBox5.Image = Global.projeto_confeitaria.My.Resources.Resources.logo2
        Me.PictureBox5.Location = New System.Drawing.Point(14, 228)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(358, 351)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 131
        Me.PictureBox5.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.projeto_confeitaria.My.Resources.Resources.cinza
        Me.PictureBox2.Image = Global.projeto_confeitaria.My.Resources.Resources.cinza
        Me.PictureBox2.Location = New System.Drawing.Point(0, 691)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(373, 150)
        Me.PictureBox2.TabIndex = 132
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.projeto_confeitaria.My.Resources.Resources.azul_notuno
        Me.PictureBox3.Image = Global.projeto_confeitaria.My.Resources.Resources.azul_notuno
        Me.PictureBox3.Location = New System.Drawing.Point(0, 675)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(373, 18)
        Me.PictureBox3.TabIndex = 133
        Me.PictureBox3.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackgroundImage = Global.projeto_confeitaria.My.Resources.Resources.azul_notuno
        Me.PictureBox6.Image = Global.projeto_confeitaria.My.Resources.Resources.azul_notuno
        Me.PictureBox6.Location = New System.Drawing.Point(0, -11)
        Me.PictureBox6.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(17, 852)
        Me.PictureBox6.TabIndex = 134
        Me.PictureBox6.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackgroundImage = Global.projeto_confeitaria.My.Resources.Resources.azul_notuno
        Me.PictureBox7.Image = Global.projeto_confeitaria.My.Resources.Resources.azul_notuno
        Me.PictureBox7.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox7.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(1432, 18)
        Me.PictureBox7.TabIndex = 135
        Me.PictureBox7.TabStop = False
        '
        'PictureBox10
        '
        Me.PictureBox10.Image = Global.projeto_confeitaria.My.Resources.Resources.marrom_liso
        Me.PictureBox10.Location = New System.Drawing.Point(14, 823)
        Me.PictureBox10.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(1432, 18)
        Me.PictureBox10.TabIndex = 136
        Me.PictureBox10.TabStop = False
        '
        'PictureBox11
        '
        Me.PictureBox11.Image = Global.projeto_confeitaria.My.Resources.Resources.marrom_liso
        Me.PictureBox11.Location = New System.Drawing.Point(1410, -11)
        Me.PictureBox11.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(17, 852)
        Me.PictureBox11.TabIndex = 137
        Me.PictureBox11.TabStop = False
        '
        'form_stq_vitrini
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.PictureBox11)
        Me.Controls.Add(Me.PictureBox10)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.txt_buscar_produto)
        Me.Controls.Add(Me.cmb_parametro_produto)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btn_salvar)
        Me.Controls.Add(Me.btn_voltar)
        Me.Controls.Add(Me.dgv_vitrini)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "form_stq_vitrini"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ESTOQUE DE PRODUTOS DA VITRINE"
        CType(Me.dgv_vitrini, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_voltar As Button
    Friend WithEvents dgv_vitrini As DataGridView
    Friend WithEvents btn_salvar As Button
    Friend WithEvents txt_buscar_produto As TextBox
    Friend WithEvents cmb_parametro_produto As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents nome As DataGridViewTextBoxColumn
    Friend WithEvents tipo As DataGridViewTextBoxColumn
    Friend WithEvents qtde As DataGridViewTextBoxColumn
    Friend WithEvents aumentar As DataGridViewImageColumn
    Friend WithEvents diminuir As DataGridViewImageColumn
End Class
