Imports System.ComponentModel
Imports MySql.Data.MySqlClient

Public Class form_criar_conta
    Private Sub btn_gravar_usuario_Click(sender As Object, e As EventArgs) Handles btn_gravar_usuario.Click
        Try
            If txt_cpf_usuario.Text = Nothing Or txt_csenha.Text = Nothing Or txt_email_usuario.Text = Nothing Or
               txt_nome_usuario.Text = Nothing Or txt_senha_usuario.Text = Nothing Or txt_telefone_usuario.Text = Nothing Then
                MsgBox("Preencha todos os campos!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
                Return
            End If

            If txt_csenha.Text <> txt_senha_usuario.Text Then
                MsgBox("As senhas não coincidem!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
                Return
            End If

            ' Verifica se CPF já existe
            Dim dt = ExecuteQuery($"SELECT cpf_usuario FROM usuarios WHERE cpf_usuario='{txt_cpf_usuario.Text}'")
            If dt.Rows.Count > 0 Then
                MsgBox("Já existe uma conta com esse CPF!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
                Return
            End If

            sql = $"INSERT INTO usuarios (cpf_usuario, nome_usuario, telefone_usuario, email_usuario, senha_usuario, identificador, bloqueado) VALUES
                   ('{txt_cpf_usuario.Text}', '{txt_nome_usuario.Text}',
                    '{txt_telefone_usuario.Text}', '{txt_email_usuario.Text}', '{UCase(txt_senha_usuario.Text)}', 'CLIENTE', 'NAO')"

            ExecuteNonQuery(sql)
            MsgBox("Conta criada com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCESSO")
            Me.Close()

        Catch ex As Exception
            MsgBox("Erro inesperado: " & ex.Message & vbCrLf & vbCrLf & ex.StackTrace, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
        End Try
    End Sub

    Private Sub cbx_senha_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_senha.CheckedChanged
        txt_csenha.PasswordChar = If(cbx_senha.Checked, "", "*"c)
    End Sub

    Private Sub cbx_senha2_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_senha2.CheckedChanged
        txt_senha_usuario.PasswordChar = If(cbx_senha2.Checked, "", "*"c)
    End Sub

    Private Sub link_entrar_conta_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles link_entrar_conta.LinkClicked
        Me.Close()
    End Sub

    Private Sub form_criar_conta_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        txt_cpf_usuario.Clear()
        txt_csenha.Clear()
        txt_email_usuario.Clear()
        txt_nome_usuario.Clear()
        txt_senha_usuario.Clear()
        txt_telefone_usuario.Clear()
    End Sub

    Private Sub form_criar_conta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
End Class
