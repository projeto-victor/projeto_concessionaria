Public Class form_alterar_cadastro
    Private Sub form_alterar_cadastro_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Dim dt = ExecuteQuery($"SELECT * FROM usuarios WHERE cpf_usuario='{gcpf}'")
            If dt.Rows.Count > 0 Then
                Dim row = dt.Rows(0)
                txt_cpf_usuario.Text = row(0).ToString()
                txt_email_usuario.Text = row(3).ToString()
                txt_nome_usuario.Text = row(1).ToString()
                txt_telefone_usuario.Text = row(2).ToString()
                txt_senha_usuario.Text = row(4).ToString()
                txt_cpf_usuario.ReadOnly = True
            End If
        Catch ex As Exception
            MsgBox("Erro ao carregar dados: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
        End Try
    End Sub

    Private Sub btn_alterar_usuario_Click(sender As Object, e As EventArgs) Handles btn_alterar_usuario.Click
        Try
            If txt_cpf_usuario.Text = Nothing Or txt_csenha.Text = Nothing Or txt_email_usuario.Text = Nothing Or
               txt_nome_usuario.Text = Nothing Or txt_senha_usuario.Text = Nothing Or txt_telefone_usuario.Text = Nothing Then
                MsgBox("Preencha todos os campos!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
                Return
            End If
            If txt_csenha.Text <> txt_senha_usuario.Text Then
                MsgBox("Senhas não coincidem!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
                Return
            End If
            resp = MsgBox("Tem certeza que deseja alterar seus dados?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Atenção")
            If resp = vbYes Then
                ExecuteNonQuery($"UPDATE usuarios SET nome_usuario='{txt_nome_usuario.Text}',
                                                 email_usuario='{txt_email_usuario.Text}',
                                                 telefone_usuario='{txt_telefone_usuario.Text}',
                                                 senha_usuario='{UCase(txt_senha_usuario.Text)}' WHERE cpf_usuario='{txt_cpf_usuario.Text}'")
                MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
            End If
        Catch ex As Exception
            MsgBox("Erro inesperado: " & ex.Message & vbCrLf & vbCrLf & ex.StackTrace, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
        End Try
    End Sub

    Private Sub cbx_senha_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_senha.CheckedChanged
        txt_senha_usuario.PasswordChar = If(cbx_senha.Checked, "", "*"c)
    End Sub

    Private Sub ckb_csenha_CheckedChanged(sender As Object, e As EventArgs) Handles ckb_csenha.CheckedChanged
        txt_csenha.PasswordChar = If(ckb_csenha.Checked, "", "*"c)
    End Sub

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        Me.Close()
    End Sub

    Private Sub txt_cpf_usuario_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txt_cpf_usuario.MaskInputRejected
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
    End Sub
End Class
