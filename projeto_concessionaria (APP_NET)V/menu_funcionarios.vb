Imports System.ComponentModel

Public Class menu_funcionarios
    Private Sub menu_funcionarios_Load(sender As Object, e As EventArgs) Handles Me.Load
        form_login.Hide()
        carregar_pedidos_func()
    End Sub

    Private Sub menu_funcionarios_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        form_login.Show()
    End Sub

    Private Sub btn_vitrini_Click(sender As Object, e As EventArgs) Handles btn_vitrini.Click
        form_stq_vitrini.ShowDialog()
    End Sub

    Private Sub btn_historico_pedidos_Click(sender As Object, e As EventArgs) Handles btn_historico_pedidos.Click
        form_historico_pedidos.ShowDialog()
    End Sub

    Private Sub btn_encerrar_sessao_Click(sender As Object, e As EventArgs) Handles btn_encerrar_sessao.Click
        resp = MsgBox("Você realmente quer sair da conta?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "AVISO")
        If resp = vbYes Then
            form_login.Show()
            Me.Close()
        End If
    End Sub

    Private Sub dgv_pedidos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_pedidos.CellContentClick
        Try
            With dgv_pedidos
                If .CurrentRow.Cells(5).Selected Then
                    id_ped = .CurrentRow.Cells(0).Value.ToString()
                    resp = MsgBox("Deseja alterar o status desse pedido?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Atenção")
                    If resp = MsgBoxResult.Yes Then
                        Dim status = .CurrentRow.Cells(4).Value.ToString()
                        If status = "PENDENTE" Then
                            ExecuteNonQuery($"UPDATE pedidos SET concluido='PRONTO' WHERE id_pedidos='{id_ped}'")
                        ElseIf status = "PRONTO" Then
                            ExecuteNonQuery($"UPDATE pedidos SET concluido='ENTREGUE' WHERE id_pedidos='{id_ped}'")
                        End If
                        carregar_pedidos_func()
                    End If
                End If
            End With
        Catch ex As Exception
            MsgBox("Erro inesperado: " & ex.Message & vbCrLf & vbCrLf & ex.StackTrace, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
        End Try
    End Sub
End Class
