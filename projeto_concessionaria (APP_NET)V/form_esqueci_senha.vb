Imports System.ComponentModel

Public Class form_esqueci_senha
    Private Sub link_entrar_conta_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles link_entrar_conta.LinkClicked
        Me.Close()
    End Sub

    Private Sub cbx_mostrar_confirmar_senha_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_mostrar_senha.CheckedChanged
        txt_senha_usuario.PasswordChar = If(cbx_mostrar_senha.Checked, "", "*"c)
    End Sub

    Private Sub cbx_mostrar_senha2_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_mostrar_senha2.CheckedChanged
        txt_csenha.PasswordChar = If(cbx_mostrar_senha2.Checked, "", "*"c)
    End Sub

    Private Sub btn_editar_senha_Click(sender As Object, e As EventArgs) Handles btn_editar_senha.Click
        Try
            If txt_cpf_usuario.Text = Nothing Or txt_csenha.Text = Nothing Or
               txt_email_usuario.Text = Nothing Or txt_senha_usuario.Text = Nothing Then
                MsgBox("Preencha todos os campos!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
                Return
            End If
            If txt_csenha.Text <> txt_senha_usuario.Text Then
                MsgBox("Senhas não coincidem", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
                txt_senha_usuario.Focus()
                Return
            End If

            Dim dt = ExecuteQuery($"SELECT * FROM usuarios WHERE cpf_usuario='{txt_cpf_usuario.Text}'")
            If dt.Rows.Count = 0 Then
                MsgBox("CPF não encontrado no sistema.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
                Return
            End If

            Dim row = dt.Rows(0)
            ident = row(5).ToString()
            If ident <> "CLIENTE" Then
                MsgBox("Só clientes podem alterar a senha por aqui. Contate um administrador.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
                Return
            End If

            email = row(3).ToString()
            If email.ToUpper() <> UCase(txt_email_usuario.Text) Then
                MsgBox("Informações da conta não coincidem", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
                Return
            End If

            resp = MsgBox("Tem certeza que deseja alterar a senha?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Atenção")
            If resp = vbYes Then
                ExecuteNonQuery($"UPDATE usuarios SET senha_usuario='{UCase(txt_senha_usuario.Text)}' WHERE cpf_usuario='{txt_cpf_usuario.Text}'")
                MsgBox("Senha alterada com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Sucesso")
                Me.Close()
            End If

        Catch ex As Exception
            MsgBox("Erro inesperado: " & ex.Message & vbCrLf & vbCrLf & ex.StackTrace, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
        End Try
    End Sub

    Private Sub form_esqueci_senha_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        txt_senha_usuario.Clear()
        txt_email_usuario.Clear()
        txt_cpf_usuario.Clear()
        txt_csenha.Clear()
    End Sub
End Class
