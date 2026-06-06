Public Class form_historico_pedidos
    Private Sub form_historico_pedidos_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            carregar_paramentros_pedidos()
            Dim dt = ExecuteQuery($"SELECT * FROM usuarios WHERE cpf_usuario='{gcpf}'")
            If dt.Rows.Count > 0 Then
                ident = dt.Rows(0)(5).ToString()
            End If
            If ident = "CLIENTE" Then
                carregar_historico_cliente()
                cmb_parametro_pedidos.Hide()
                txt_buscar_pedidos.Hide()
                lbl_cmb.Hide()
                lbl_txt.Hide()
            Else
                carregar_historico_adm()
                lbl_texto.Hide()
            End If
        Catch ex As Exception
            MsgBox("Erro ao carregar: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
        End Try
    End Sub

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        Me.Close()
    End Sub

    Private Sub txt_buscar_pedidos_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar_pedidos.TextChanged
        Try
            If cmb_parametro_pedidos.Text = "CPF" Then
                param = "cpf_cliente"
            ElseIf cmb_parametro_pedidos.Text = "PRODUTO" Then
                param = "produto_pedido"
            Else
                param = "data_pedido"
            End If
            Dim dt = ExecuteQuery($"SELECT * FROM pedidos WHERE {param} LIKE '{txt_buscar_pedidos.Text}%'")
            dgv_pedidos.Rows.Clear()
            For Each row As DataRow In dt.Rows
                dgv_pedidos.Rows.Add(row(0), row(1), row(2), row(3), row(6), row(5))
            Next
        Catch ex As Exception
            MsgBox("Erro ao buscar: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
        End Try
    End Sub
End Class
