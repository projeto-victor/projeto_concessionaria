Imports System.ComponentModel

Public Class menu_cliente
    Private Sub menu_cliente_Load(sender As Object, e As EventArgs) Handles Me.Load
        form_login.Hide()
        carregar_pedidos_cliente()
    End Sub

    Private Sub menu_cliente_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        form_login.Show()
    End Sub

    Private Sub btn_historico_pedidos_Click(sender As Object, e As EventArgs) Handles btn_historico_pedidos.Click
        form_historico_pedidos.ShowDialog()
    End Sub

    Private Sub btn_encomendar_Click(sender As Object, e As EventArgs) Handles btn_encomendar.Click
        form_encomendar.ShowDialog()
    End Sub

    Private Sub btn_alterar_Click(sender As Object, e As EventArgs) Handles btn_alterar.Click
        form_alterar_cadastro.ShowDialog()
    End Sub

    Private Sub btn_encerrar_sessao_Click(sender As Object, e As EventArgs) Handles btn_encerrar_sessao.Click
        resp = MsgBox("Você realmente quer sair da conta?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "AVISO")
        If resp = vbYes Then
            form_login.Show()
            Me.Close()
        End If
    End Sub
End Class
