Imports MySql.Data.MySqlClient

Public Class form_login
    Private Sub form_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_cpf.Clear()
        txt_senha_login.Clear()
    End Sub

    Private Sub link_criar_conta_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles link_criar_conta.LinkClicked
        form_criar_conta.ShowDialog()
    End Sub

    Private Sub link_esqueci_senha_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles link_esqueci_senha.LinkClicked
        form_esqueci_senha.ShowDialog()
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Try
            If txt_cpf.Text = Nothing Or txt_senha_login.Text = Nothing Then
                MsgBox("Preencha todos os campos!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
                Return
            End If

            Dim dt = ExecuteQuery($"SELECT * FROM usuarios WHERE cpf_usuario='{txt_cpf.Text}'")

            If dt.Rows.Count = 0 Then
                MsgBox("CPF não cadastrado", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
                txt_cpf.Focus()
                Return
            End If

            Dim row = dt.Rows(0)
            senha = row(4).ToString()
            cpf = row(0).ToString()
            bloqueado = row(6).ToString()
            ident = row(5).ToString()
            gcpf = txt_cpf.Text

            If UCase(txt_senha_login.Text) <> senha Then
                MsgBox("Senha incorreta", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
                txt_senha_login.Focus()
                Return
            End If

            If ident = "PROP" Then
                MsgBox("Login de ADM feito com sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atenção")
                txt_cpf.Clear()
                txt_senha_login.Clear()
                menu_propietaria.ShowDialog()

            ElseIf ident = "FUNCIONARIO" Then
                If bloqueado = "NAO" Then
                    MsgBox("Login de funcionário feito com sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atenção")
                    txt_cpf.Clear()
                    txt_senha_login.Clear()
                    menu_funcionarios.ShowDialog()
                Else
                    MsgBox("Sua conta foi bloqueada, contate um administrador", MsgBoxStyle.Critical + vbOKOnly, "Atenção")
                End If

            ElseIf ident = "CLIENTE" Then
                If bloqueado = "NAO" Then
                    MsgBox("Login de usuário feito com sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atenção")
                    txt_cpf.Clear()
                    txt_senha_login.Clear()
                    menu_cliente.ShowDialog()
                Else
                    MsgBox("Sua conta foi bloqueada, contate um administrador", MsgBoxStyle.Critical + vbOKOnly, "Atenção")
                End If
            End If

        Catch ex As Exception
            MsgBox("Erro ao fazer login: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub

    Private Sub cbx_mostrar_senha_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_senha.CheckedChanged
        txt_senha_login.PasswordChar = If(cbx_senha.Checked, "", "*"c)
    End Sub

    Private Sub btn_sair_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        If MessageBox.Show("Você realmente quer sair?", "ENCERRAR PROGRAMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub txt_cpf_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txt_cpf.MaskInputRejected
    End Sub
End Class
