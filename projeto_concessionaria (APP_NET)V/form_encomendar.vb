Imports System.ComponentModel

Public Class form_encomendar
    Private Sub form_encomendar_Load(sender As Object, e As EventArgs) Handles Me.Load
        txt_valor_encomenda.ReadOnly = True
        txt_sabor.ReadOnly = True
        txt_total.ReadOnly = True
        If System.IO.File.Exists(Application.StartupPath & "\fundo_produto.jpeg") Then
            img_foto_ecomenda.Load(Application.StartupPath & "\fundo_produto.jpeg")
        End If
        carregar_cardapio()
        carregar_paramentros_produto2()
    End Sub

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        Me.Close()
        carregar_pedidos_cliente()
    End Sub

    Private Sub dgv_encomenda_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_encomenda.CellContentClick
        Try
            With dgv_encomenda
                If .CurrentRow.Cells(4).Selected Then
                    aux_id = .CurrentRow.Cells(0).Value.ToString()
                    Dim dt = ExecuteQuery($"SELECT * FROM encomenda WHERE id_encomenda='{aux_id}'")
                    If dt.Rows.Count > 0 Then
                        Dim row = dt.Rows(0)
                        diretorio = row(4).ToString().Replace("\", "/")
                        txt_valor_encomenda.Text = row(3).ToString()
                        txt_sabor.Text = row(1).ToString()
                        If System.IO.File.Exists(diretorio) Then
                            img_foto_ecomenda.Load(diretorio)
                        End If
                    End If
                End If
            End With
        Catch ex As Exception
            MsgBox("Erro inesperado: " & ex.Message & vbCrLf & vbCrLf & ex.StackTrace, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
        End Try
    End Sub

    Private Sub btn_encomenda_Click(sender As Object, e As EventArgs) Handles btn_encomenda.Click
        Try
            If txt_sabor.Text = Nothing Or txt_qtde.Text = Nothing Or txt_total.Text = Nothing Then
                MsgBox("Preencha todos os campos!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
                Return
            End If
            data = Now.Date.ToString("dd/MM/yyyy")
            ExecuteNonQuery($"INSERT INTO pedidos (cpf_cliente, produto_pedido, valor_pedido, qtde, data_pedido, concluido) VALUES
                            ('{gcpf}', '{aux_id}', '{txt_total.Text}', '{txt_qtde.Text}', '{data}', 'PENDENTE')")
            MsgBox("Pedido feito com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCESSO")
            resp = MsgBox("Deseja realizar outro pedido?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "AVISO")
            If resp = vbYes Then
                txt_valor_encomenda.Clear()
                txt_sabor.Clear()
                txt_qtde.Clear()
                If System.IO.File.Exists(Application.StartupPath & "\fundo_produto.jpeg") Then
                    img_foto_ecomenda.Load(Application.StartupPath & "\fundo_produto.jpeg")
                End If
            Else
                Me.Close()
                carregar_pedidos_cliente()
            End If
        Catch ex As Exception
            MsgBox("Erro inesperado: " & ex.Message & vbCrLf & vbCrLf & ex.StackTrace, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
        End Try
    End Sub

    Private Sub txt_qtde_LostFocus(sender As Object, e As EventArgs) Handles txt_qtde.LostFocus
        Try
            If txt_valor_encomenda.Text <> "" And txt_qtde.Text <> "" Then
                txt_total.Text = (CInt(txt_valor_encomenda.Text) * CInt(txt_qtde.Text)).ToString()
            End If
        Catch ex As Exception
            MsgBox("Preencha os campos corretamente!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub txt_buscar_produto_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar_produto.TextChanged
        Try
            param = If(cmb_parametro_produto.Text = "NOME", "produto_encomenda", "tipo_encomenda")
            Dim dt = ExecuteQuery($"SELECT * FROM encomenda WHERE {param} LIKE '{txt_buscar_produto.Text}%'")
            dgv_encomenda.Rows.Clear()
            For Each row As DataRow In dt.Rows
                dgv_encomenda.Rows.Add(row(0), row(1), row(2), row(3), Nothing)
            Next
        Catch ex As Exception
            MsgBox("Erro ao buscar: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
        End Try
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
    End Sub


End Class
