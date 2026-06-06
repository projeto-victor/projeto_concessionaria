Imports Tulpep.NotificationWindow

Public Class form_stq_vitrini
    Private Sub form_vitrini_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregar_estq_vitrine()
        carregar_paramentros_produto3()
    End Sub

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        Me.Close()
    End Sub

    Private Sub dgv_vitrini_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_vitrini.CellContentClick
        Try
            If e.RowIndex < 0 OrElse e.ColumnIndex < 0 Then Exit Sub
            Dim linha = dgv_vitrini.Rows(e.RowIndex)
            id_stq = Convert.ToInt32(linha.Cells(0).Value).ToString()
            stq = Convert.ToInt32(linha.Cells(3).Value).ToString()
            Dim qtde = CInt(stq)

            If e.ColumnIndex = 4 Then
                qtde += 1
            ElseIf e.ColumnIndex = 5 Then
                If qtde > 0 Then qtde -= 1
            End If

            stq = qtde.ToString()
            linha.Cells(3).Value = qtde
            linha.Cells(3).Style.BackColor = If(qtde = 0, Color.Red, Color.Green)
        Catch ex As Exception
            MsgBox("Erro inesperado: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btn_salvar_Click(sender As Object, e As EventArgs) Handles btn_salvar.Click
        Try
            resp = MsgBox("Deseja alterar a quantidade deste item?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
            If resp = vbYes Then
                ExecuteNonQuery($"UPDATE balcao SET qtde_balcao='{stq}' WHERE id_balcao='{id_stq}'")
                carregar_estq_vitrine()
                MsgBox("Dados salvos com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
            End If
        Catch ex As Exception
            MsgBox("Erro inesperado: " & ex.Message & vbCrLf & ex.StackTrace, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub txt_buscar_produto_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar_produto.TextChanged
        Try
            param = If(cmb_parametro_produto.Text = "NOME", "produto_balcao", "tipo_balcao")
            Dim dt = ExecuteQuery($"SELECT * FROM balcao WHERE {param} LIKE '{txt_buscar_produto.Text}%'")
            dgv_vitrini.Rows.Clear()
            For Each row As DataRow In dt.Rows
                dgv_vitrini.Rows.Add(row(0), row(1), row(2), row(3), Nothing, Nothing)
            Next
        Catch ex As Exception
            MsgBox("Erro ao buscar: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
        End Try
    End Sub

    Private Sub cmb_parametro_produto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_parametro_produto.SelectedIndexChanged
    End Sub
End Class
