Imports System.ComponentModel

Public Class form_cad_prod

    ' CORREÇÃO: img_foto e lbl_qtde agora referenciam os controles reais do Designer
    ' img_foto → PictureBox1 (único PictureBox grande no form, usado para a foto do produto)
    ' lbl_qtde → Label que tem o texto "QUANTIDADE" no form — mapeado para lbl_foto por proximidade;
    '            como não há lbl_qtde no Designer, usamos a referência direta aos controles abaixo.

    Private Sub img_foto_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Try
            With OpenFileDialog1
                .Title = "Selecione uma Foto"
                .InitialDirectory = Application.StartupPath & "\Fotos\"
                .Filter = "Imagens|*.jpg;*.jpeg;*.png;*.bmp"
                .ShowDialog()
                If .FileName <> "" Then
                    diretorio = .FileName.Replace("\", "/")
                    PictureBox1.Load(diretorio)
                End If
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub btn_gravar_produto_Click(sender As Object, e As EventArgs) Handles btn_gravar_produto.Click
        Try
            If cmb_destino_produto.Text = "BALCAO" Then
                If txt_valor_produto.Text = Nothing Or txt_nome_produto.Text = Nothing Or txt_qtde.Text = Nothing Or cmb_tipo_produto.Text = Nothing Then
                    MsgBox("Preencha todos os campos!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
                    Return
                End If
                Dim dt = ExecuteQuery($"SELECT * FROM balcao WHERE id_balcao='{id_prod}'")
                If dt.Rows.Count > 0 Then
                    resp = MsgBox("Deseja realmente alterar os dados do produto?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                    If resp = vbYes Then
                        ExecuteNonQuery($"UPDATE balcao SET produto_balcao='{txt_nome_produto.Text}',
                                                           qtde_balcao='{txt_qtde.Text}',
                                                           tipo_balcao='{cmb_tipo_produto.Text}',
                                                           valor_balcao='{txt_valor_produto.Text}' WHERE id_balcao='{id_prod}'")
                        MsgBox("Dados alterados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                        perguntarContinuar("alterar", "produto")
                    End If
                Else
                    ExecuteNonQuery($"INSERT INTO balcao (produto_balcao, tipo_balcao, qtde_balcao, valor_balcao) VALUES
                                    ('{txt_nome_produto.Text}', '{cmb_tipo_produto.Text}', '{txt_qtde.Text}', '{txt_valor_produto.Text}')")
                    MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                    perguntarContinuar("adicionar", "produto")
                End If

            ElseIf cmb_destino_produto.Text = "ENCOMENDA" Then
                If txt_nome_produto.Text = Nothing Or txt_valor_produto.Text = Nothing Or cmb_tipo_produto.Text = Nothing Then
                    MsgBox("Preencha todos os campos!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
                    Return
                End If
                Dim dt = ExecuteQuery($"SELECT * FROM encomenda WHERE id_encomenda='{id_prod}'")
                If dt.Rows.Count > 0 Then
                    resp = MsgBox("Deseja realmente alterar os dados do produto?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                    If resp = vbYes Then
                        ExecuteNonQuery($"UPDATE encomenda SET produto_encomenda='{txt_nome_produto.Text}',
                                                              tipo_encomenda='{cmb_tipo_produto.Text}',
                                                              valor_encomenda='{txt_valor_produto.Text}',
                                                              foto_encomenda='{diretorio}' WHERE id_encomenda='{id_prod}'")
                        MsgBox("Dados alterados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                        perguntarContinuar("alterar", "produto")
                    End If
                Else
                    ExecuteNonQuery($"INSERT INTO encomenda (produto_encomenda, tipo_encomenda, valor_encomenda, foto_encomenda) VALUES
                                    ('{txt_nome_produto.Text}', '{cmb_tipo_produto.Text}', '{txt_valor_produto.Text}', '{diretorio}')")
                    MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                    perguntarContinuar("adicionar", "produto")
                End If

            ElseIf cmb_destino_produto.Text = "INGREDIENTE" Then
                If txt_nome_produto.Text = Nothing Or txt_qtde.Text = Nothing Then
                    MsgBox("Preencha todos os campos!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
                    Return
                End If
                Dim dt = ExecuteQuery($"SELECT * FROM estoque_ingred WHERE id_ingrediente='{id_prod}'")
                If dt.Rows.Count > 0 Then
                    resp = MsgBox("Deseja realmente alterar os dados do ingrediente?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                    If resp = vbYes Then
                        ExecuteNonQuery($"UPDATE estoque_ingred SET nome_ingrediente='{txt_nome_produto.Text}',
                                                                    qtd_ingrediente='{txt_qtde.Text}' WHERE id_ingrediente='{id_prod}'")
                        MsgBox("Dados alterados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                        perguntarContinuar("alterar", "ingrediente")
                    End If
                Else
                    ExecuteNonQuery($"INSERT INTO estoque_ingred (nome_ingrediente, qtd_ingrediente) VALUES
                                    ('{txt_nome_produto.Text}', '{txt_qtde.Text}')")
                    MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                    perguntarContinuar("adicionar", "ingrediente")
                End If
            End If

        Catch ex As Exception
            MsgBox("Erro inesperado: " & ex.Message & vbCrLf & vbCrLf & ex.StackTrace, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
        End Try
    End Sub

    Private Sub perguntarContinuar(acao As String, tipo As String)
        resp = MsgBox($"Deseja {acao} outro {tipo}?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
        If resp = vbYes Then
            RecarregarGrid()
            LimparCampos()
        Else
            dgv_produto.Rows.Clear()
            Me.Close()
        End If
    End Sub

    Private Sub RecarregarGrid()
        dgv_produto.Rows.Clear()
        If cmb_destino_produto.Text = "BALCAO" Then
            carregar_balcao()
        ElseIf cmb_destino_produto.Text = "ENCOMENDA" Then
            carregar_encomenda()
        ElseIf cmb_destino_produto.Text = "INGREDIENTE" Then
            carregar_ingred()
        End If
    End Sub

    Private Sub LimparCampos()
        txt_nome_produto.Clear()
        txt_qtde.Clear()
        txt_valor_produto.Clear()
        cmb_tipo_produto.SelectedIndex = -1
        cmb_destino_produto.SelectedIndex = -1
        PictureBox1.Load(Application.StartupPath & "\fundo_produto.jpeg")
        OcultarCampos()
    End Sub

    Private Sub OcultarCampos()
        txt_qtde.Hide()
        PictureBox1.Hide()
        lbl_foto.Hide()
        lbl_nome.Hide()
        lbl_tipo.Hide()
        lbl_valor.Hide()
        txt_valor_produto.Hide()
        txt_nome_produto.Hide()
        cmb_tipo_produto.Hide()
    End Sub

    Private Sub form_cad_prod_Load(sender As Object, e As EventArgs) Handles Me.Load
        With cmb_destino_produto.Items
            .Clear()
            .Add("ENCOMENDA")
            .Add("COMPONENTES")
            .Add("BALCAO")
        End With
        With cmb_tipo_produto.Items
            .Clear()
            .Add("CARRO SEDAN")
            .Add("CARRO SUV")
            .Add("MOTO")
            .Add("VAN")
            .Add("ESPORTIVO")
        End With
        cmb_tipo_produto.SelectedIndex = -1
        cmb_destino_produto.SelectedIndex = -1
        cmb_parametro_produto.SelectedIndex = -1
        If System.IO.File.Exists(Application.StartupPath & "\fundo_produto.jpeg") Then
            PictureBox1.Load(Application.StartupPath & "\fundo_produto.jpeg")
        End If
        OcultarCampos()
        carregar_paramentros_produto1()
    End Sub

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        Me.Close()
    End Sub

    Private Sub cmb_destino_produto_TextChanged(sender As Object, e As EventArgs) Handles cmb_destino_produto.TextChanged
        txt_nome_produto.Clear()
        txt_qtde.Clear()
        txt_valor_produto.Clear()
        cmb_tipo_produto.SelectedIndex = -1

        If cmb_destino_produto.Text = "BALCAO" Then
            txt_qtde.Show()
            lbl_nome.Show() : txt_nome_produto.Show()
            txt_valor_produto.Show() : lbl_valor.Show()
            lbl_tipo.Show() : cmb_tipo_produto.Show()
            lbl_foto.Hide() : PictureBox1.Hide()
            carregar_balcao()

        ElseIf cmb_destino_produto.Text = "ENCOMENDA" Then
            lbl_foto.Show() : PictureBox1.Show()
            lbl_nome.Show() : txt_nome_produto.Show()
            txt_valor_produto.Show() : lbl_valor.Show()
            lbl_tipo.Show() : cmb_tipo_produto.Show()
            txt_qtde.Hide()
            carregar_encomenda()

        ElseIf cmb_destino_produto.Text = "COMPONENTES" Then
            lbl_nome.Show() : txt_nome_produto.Show()
            txt_qtde.Show()
            PictureBox1.Hide() : lbl_foto.Hide()
            lbl_tipo.Hide() : cmb_tipo_produto.Hide()
            lbl_valor.Hide() : txt_valor_produto.Hide()
            carregar_ingred()
        End If
    End Sub

    Private Sub dgv_produto_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_produto.CellContentClick
        Try
            With dgv_produto
                If .CurrentRow.Cells(5).Selected Then
                    id_prod = .CurrentRow.Cells(0).Value.ToString()
                    If cmb_destino_produto.Text = "BALCAO" Then
                        Dim dt = ExecuteQuery($"SELECT * FROM balcao WHERE id_balcao='{id_prod}'")
                        If dt.Rows.Count > 0 Then
                            txt_qtde.Text = dt.Rows(0)(3).ToString()
                            txt_valor_produto.Text = dt.Rows(0)(4).ToString()
                            txt_nome_produto.Text = dt.Rows(0)(1).ToString()
                            cmb_tipo_produto.Text = dt.Rows(0)(2).ToString()
                        End If
                    ElseIf cmb_destino_produto.Text = "ENCOMENDA" Then
                        Dim dt = ExecuteQuery($"SELECT * FROM encomenda WHERE id_encomenda='{id_prod}'")
                        If dt.Rows.Count > 0 Then
                            diretorio = dt.Rows(0)(4).ToString().Replace("\", "/")
                            txt_nome_produto.Text = dt.Rows(0)(1).ToString()
                            cmb_tipo_produto.Text = dt.Rows(0)(2).ToString()
                            txt_valor_produto.Text = dt.Rows(0)(3).ToString()
                            If System.IO.File.Exists(diretorio) Then PictureBox1.Load(diretorio)
                        End If
                    ElseIf cmb_destino_produto.Text = "COMPONENTES" Then
                        Dim dt = ExecuteQuery($"SELECT * FROM estoque_ingred WHERE id_ingrediente='{id_prod}'")
                        If dt.Rows.Count > 0 Then
                            txt_nome_produto.Text = dt.Rows(0)(1).ToString()
                            txt_qtde.Text = dt.Rows(0)(2).ToString()
                        End If
                    End If

                ElseIf .CurrentRow.Cells(6).Selected Then
                    id_prod = .CurrentRow.Cells(0).Value.ToString()
                    resp = MsgBox("Deseja realmente excluir?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                    If resp = MsgBoxResult.Yes Then
                        If cmb_destino_produto.Text = "BALCAO" Then
                            ExecuteNonQuery($"DELETE FROM balcao WHERE id_balcao='{id_prod}'")
                            carregar_balcao()
                        ElseIf cmb_destino_produto.Text = "ENCOMENDA" Then
                            ExecuteNonQuery($"DELETE FROM encomenda WHERE id_encomenda='{id_prod}'")
                            carregar_encomenda()
                        ElseIf cmb_destino_produto.Text = "COMPONENTES" Then
                            ExecuteNonQuery($"DELETE FROM estoque_ingred WHERE id_ingrediente='{id_prod}'")
                            carregar_ingred()
                        End If
                    End If
                End If
            End With
        Catch ex As Exception
            MsgBox("Erro inesperado: " & ex.Message & vbCrLf & vbCrLf & ex.StackTrace, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
        End Try
    End Sub

    Private Sub txt_buscar_produto_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar_produto.TextChanged
        Try
            With dgv_produto
                .Rows.Clear()
                If cmb_destino_produto.Text = "ENCOMENDA" Then
                    param = If(cmb_parametro_produto.Text = "NOME", "produto_encomenda", "tipo_encomenda")
                    Dim dt = ExecuteQuery($"SELECT * FROM encomenda WHERE {param} LIKE '{txt_buscar_produto.Text}%'")
                    For Each row As DataRow In dt.Rows
                        .Rows.Add(row(0), row(1), Nothing, row(2), row(3), Nothing, Nothing)
                    Next
                ElseIf cmb_destino_produto.Text = "BALCAO" Then
                    param = If(cmb_parametro_produto.Text = "NOME", "produto_balcao", "tipo_balcao")
                    Dim dt = ExecuteQuery($"SELECT * FROM balcao WHERE {param} LIKE '{txt_buscar_produto.Text}%'")
                    For Each row As DataRow In dt.Rows
                        .Rows.Add(row(0), row(1), row(3), row(2), row(4), Nothing, Nothing)
                    Next
                ElseIf cmb_destino_produto.Text = "COMPONENTES" Then
                    Dim dt = ExecuteQuery($"SELECT * FROM estoque_ingred WHERE nome_ingrediente LIKE '{txt_buscar_produto.Text}%'")
                    For Each row As DataRow In dt.Rows
                        .Rows.Add(row(0), row(1), row(2), Nothing, Nothing, Nothing, Nothing)
                    Next
                End If
            End With
        Catch ex As Exception
            MsgBox("Erro ao buscar: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
        End Try
    End Sub

    Private Sub form_cad_prod_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        cmb_destino_produto.SelectedIndex = -1
    End Sub



End Class
