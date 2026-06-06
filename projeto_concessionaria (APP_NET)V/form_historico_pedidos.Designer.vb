<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_historico_pedidos
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_historico_pedidos))
        Me.dgv_pedidos = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cpf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.produto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.data = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_buscar_pedidos = New System.Windows.Forms.TextBox()
        Me.cmb_parametro_pedidos = New System.Windows.Forms.ComboBox()
        Me.lbl_texto = New System.Windows.Forms.Label()
        Me.lbl_txt = New System.Windows.Forms.Label()
        Me.lbl_cmb = New System.Windows.Forms.Label()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_voltar = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        CType(Me.dgv_pedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_pedidos
        '
        Me.dgv_pedidos.AllowUserToAddRows = False
        Me.dgv_pedidos.AllowUserToDeleteRows = False
        Me.dgv_pedidos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.dgv_pedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_pedidos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.cpf, Me.produto, Me.valor, Me.status, Me.data})
        Me.dgv_pedidos.Location = New System.Drawing.Point(381, 158)
        Me.dgv_pedidos.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.dgv_pedidos.Name = "dgv_pedidos"
        Me.dgv_pedidos.ReadOnly = True
        Me.dgv_pedidos.RowHeadersWidth = 51
        Me.dgv_pedidos.RowTemplate.Height = 24
        Me.dgv_pedidos.Size = New System.Drawing.Size(1036, 671)
        Me.dgv_pedidos.TabIndex = 79
        '
        'id
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.id.DefaultCellStyle = DataGridViewCellStyle1
        Me.id.HeaderText = "Nº Pedido"
        Me.id.MinimumWidth = 6
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Width = 50
        '
        'cpf
        '
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.cpf.DefaultCellStyle = DataGridViewCellStyle2
        Me.cpf.HeaderText = "CPF cliente"
        Me.cpf.MinimumWidth = 6
        Me.cpf.Name = "cpf"
        Me.cpf.ReadOnly = True
        Me.cpf.Width = 170
        '
        'produto
        '
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.produto.DefaultCellStyle = DataGridViewCellStyle3
        Me.produto.HeaderText = "Produto"
        Me.produto.MinimumWidth = 6
        Me.produto.Name = "produto"
        Me.produto.ReadOnly = True
        Me.produto.Width = 250
        '
        'valor
        '
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.valor.DefaultCellStyle = DataGridViewCellStyle4
        Me.valor.HeaderText = "Valor"
        Me.valor.MinimumWidth = 6
        Me.valor.Name = "valor"
        Me.valor.ReadOnly = True
        Me.valor.Width = 85
        '
        'status
        '
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.status.DefaultCellStyle = DataGridViewCellStyle5
        Me.status.HeaderText = "Status do pedido"
        Me.status.MinimumWidth = 6
        Me.status.Name = "status"
        Me.status.ReadOnly = True
        Me.status.Width = 150
        '
        'data
        '
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.data.DefaultCellStyle = DataGridViewCellStyle6
        Me.data.HeaderText = "Data pedido"
        Me.data.MinimumWidth = 6
        Me.data.Name = "data"
        Me.data.ReadOnly = True
        Me.data.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.data.Width = 125
        '
        'txt_buscar_pedidos
        '
        Me.txt_buscar_pedidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_buscar_pedidos.Location = New System.Drawing.Point(902, 84)
        Me.txt_buscar_pedidos.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_buscar_pedidos.Name = "txt_buscar_pedidos"
        Me.txt_buscar_pedidos.Size = New System.Drawing.Size(494, 28)
        Me.txt_buscar_pedidos.TabIndex = 81
        '
        'cmb_parametro_pedidos
        '
        Me.cmb_parametro_pedidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_parametro_pedidos.FormattingEnabled = True
        Me.cmb_parametro_pedidos.Location = New System.Drawing.Point(404, 81)
        Me.cmb_parametro_pedidos.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_parametro_pedidos.Name = "cmb_parametro_pedidos"
        Me.cmb_parametro_pedidos.Size = New System.Drawing.Size(480, 30)
        Me.cmb_parametro_pedidos.TabIndex = 80
        '
        'lbl_texto
        '
        Me.lbl_texto.AutoSize = True
        Me.lbl_texto.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.lbl_texto.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_texto.ForeColor = System.Drawing.Color.White
        Me.lbl_texto.Image = Global.projeto_confeitaria.My.Resources.Resources.cinza
        Me.lbl_texto.Location = New System.Drawing.Point(466, 16)
        Me.lbl_texto.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_texto.Name = "lbl_texto"
        Me.lbl_texto.Size = New System.Drawing.Size(851, 42)
        Me.lbl_texto.TabIndex = 159
        Me.lbl_texto.Text = "VERIFIQUE O HISTÓRICO DOS SEUS PEDIDOS"
        '
        'lbl_txt
        '
        Me.lbl_txt.AutoSize = True
        Me.lbl_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_txt.ForeColor = System.Drawing.Color.White
        Me.lbl_txt.Image = Global.projeto_confeitaria.My.Resources.Resources.cinza
        Me.lbl_txt.Location = New System.Drawing.Point(976, 58)
        Me.lbl_txt.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_txt.Name = "lbl_txt"
        Me.lbl_txt.Size = New System.Drawing.Size(364, 24)
        Me.lbl_txt.TabIndex = 158
        Me.lbl_txt.Text = "DIGITE UM PARAMETRO DE PESQUISA:"
        '
        'lbl_cmb
        '
        Me.lbl_cmb.AutoSize = True
        Me.lbl_cmb.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cmb.ForeColor = System.Drawing.Color.White
        Me.lbl_cmb.Image = Global.projeto_confeitaria.My.Resources.Resources.cinza
        Me.lbl_cmb.Location = New System.Drawing.Point(400, 58)
        Me.lbl_cmb.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_cmb.Name = "lbl_cmb"
        Me.lbl_cmb.Size = New System.Drawing.Size(514, 24)
        Me.lbl_cmb.TabIndex = 157
        Me.lbl_cmb.Text = "SELECIONE O TIPO DE PARAMETRO PARA PESQUISAR:"
        '
        'PictureBox11
        '
        Me.PictureBox11.Image = Global.projeto_confeitaria.My.Resources.Resources.marrom_liso
        Me.PictureBox11.Location = New System.Drawing.Point(1410, 11)
        Me.PictureBox11.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(17, 852)
        Me.PictureBox11.TabIndex = 156
        Me.PictureBox11.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.projeto_confeitaria.My.Resources.Resources.marrom_liso
        Me.PictureBox2.Location = New System.Drawing.Point(11, 823)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1432, 18)
        Me.PictureBox2.TabIndex = 155
        Me.PictureBox2.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackgroundImage = Global.projeto_confeitaria.My.Resources.Resources.azul_notuno
        Me.PictureBox7.Image = Global.projeto_confeitaria.My.Resources.Resources.azul_notuno
        Me.PictureBox7.Location = New System.Drawing.Point(-3, 0)
        Me.PictureBox7.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(1432, 18)
        Me.PictureBox7.TabIndex = 154
        Me.PictureBox7.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackgroundImage = Global.projeto_confeitaria.My.Resources.Resources.azul_notuno
        Me.PictureBox6.Image = Global.projeto_confeitaria.My.Resources.Resources.azul_notuno
        Me.PictureBox6.Location = New System.Drawing.Point(-3, -11)
        Me.PictureBox6.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(18, 852)
        Me.PictureBox6.TabIndex = 153
        Me.PictureBox6.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.BackgroundImage = Global.projeto_confeitaria.My.Resources.Resources.azul_notuno
        Me.PictureBox9.Image = Global.projeto_confeitaria.My.Resources.Resources.azul_notuno
        Me.PictureBox9.Location = New System.Drawing.Point(-3, 142)
        Me.PictureBox9.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(1432, 18)
        Me.PictureBox9.TabIndex = 151
        Me.PictureBox9.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BackgroundImage = Global.projeto_confeitaria.My.Resources.Resources.azul_notuno
        Me.PictureBox8.Image = Global.projeto_confeitaria.My.Resources.Resources.azul_notuno
        Me.PictureBox8.Location = New System.Drawing.Point(364, -6)
        Me.PictureBox8.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(19, 862)
        Me.PictureBox8.TabIndex = 150
        Me.PictureBox8.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.BackgroundImage = CType(resources.GetObject("PictureBox5.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox5.Image = Global.projeto_confeitaria.My.Resources.Resources.logo2
        Me.PictureBox5.Location = New System.Drawing.Point(11, 257)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(358, 385)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 152
        Me.PictureBox5.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.projeto_confeitaria.My.Resources.Resources.cinza
        Me.PictureBox1.Image = Global.projeto_confeitaria.My.Resources.Resources.cinza
        Me.PictureBox1.Location = New System.Drawing.Point(11, 149)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(358, 692)
        Me.PictureBox1.TabIndex = 149
        Me.PictureBox1.TabStop = False
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
        Me.btn_voltar.TabIndex = 0
        Me.btn_voltar.Text = "VOLTAR"
        Me.btn_voltar.UseVisualStyleBackColor = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImage = Global.projeto_confeitaria.My.Resources.Resources.cinza
        Me.PictureBox4.Image = Global.projeto_confeitaria.My.Resources.Resources.cinza
        Me.PictureBox4.Location = New System.Drawing.Point(-3, -6)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(1432, 158)
        Me.PictureBox4.TabIndex = 148
        Me.PictureBox4.TabStop = False
        '
        'form_historico_pedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.lbl_texto)
        Me.Controls.Add(Me.lbl_txt)
        Me.Controls.Add(Me.lbl_cmb)
        Me.Controls.Add(Me.PictureBox11)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txt_buscar_pedidos)
        Me.Controls.Add(Me.cmb_parametro_pedidos)
        Me.Controls.Add(Me.btn_voltar)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.dgv_pedidos)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "form_historico_pedidos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HISTORICO DE PEDIDOS"
        CType(Me.dgv_pedidos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_voltar As Button
    Friend WithEvents dgv_pedidos As DataGridView
    Friend WithEvents txt_buscar_pedidos As TextBox
    Friend WithEvents cmb_parametro_pedidos As ComboBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents lbl_cmb As Label
    Friend WithEvents lbl_txt As Label
    Friend WithEvents lbl_texto As Label
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents cpf As DataGridViewTextBoxColumn
    Friend WithEvents produto As DataGridViewTextBoxColumn
    Friend WithEvents valor As DataGridViewTextBoxColumn
    Friend WithEvents status As DataGridViewTextBoxColumn
    Friend WithEvents data As DataGridViewTextBoxColumn
End Class
