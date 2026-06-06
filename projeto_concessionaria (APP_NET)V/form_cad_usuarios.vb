Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class form_cad_usuarios
    Private Sub form_cad_usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With cmb_tipo_usuario.Items
            .Clear()
            .Add("FUNCIONARIO")
            .Add("CLIENTE")
        End With
        carregar_paramentros_usuarios()
        carregar_usuarios()
    End Sub

    Private Sub btn_gravar_usuario_Click(sender As Object, e As EventArgs) Handles btn_gravar_usuario.Click
        Try
            If txt_cpf_usuario.Text = Nothing Or txt_email_usuario.Text = Nothing Or txt_nome_usuario.Text = Nothing Or
               txt_senha_usuario.Text = Nothing Or txt_telefone_usuario.Text = Nothing Or cmb_tipo_usuario.Text = Nothing Then
                MsgBox("Preencha todos os campos!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
                Return
            End If

            Dim dt = ExecuteQuery($"SELECT * FROM usuarios WHERE cpf_usuario='{txt_cpf_usuario.Text}'")

            If dt.Rows.Count > 0 Then
                resp = MsgBox("Já existe esse CPF. Deseja alterá-lo?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Atenção")
                If resp = MsgBoxResult.Yes Then
                    sql = $"UPDATE usuarios SET nome_usuario='{txt_nome_usuario.Text}',
                                             email_usuario='{txt_email_usuario.Text}',
                                             telefone_usuario='{txt_telefone_usuario.Text}',
                                             identificador='{cmb_tipo_usuario.Text}',
                                             senha_usuario='{UCase(txt_senha_usuario.Text)}' WHERE cpf_usuario='{txt_cpf_usuario.Text}'"
                    ExecuteNonQuery(sql)
                    MsgBox("Dados alterados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                    carregar_usuarios()
                    resp = MsgBox("Deseja alterar outro usuário?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                    If resp = vbYes Then
                        LimparCampos()
                    Else
                        Me.Close()
                    End If
                End If
            Else
                sql = $"INSERT INTO usuarios (cpf_usuario, nome_usuario, telefone_usuario, email_usuario, senha_usuario, identificador, bloqueado) VALUES
                       ('{txt_cpf_usuario.Text}', '{txt_nome_usuario.Text}',
                        '{txt_telefone_usuario.Text}', '{txt_email_usuario.Text}', '{UCase(txt_senha_usuario.Text)}', '{cmb_tipo_usuario.Text}', 'NAO')"
                ExecuteNonQuery(sql)
                MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                carregar_usuarios()
                resp = MsgBox("Deseja adicionar outro usuário?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                If resp = vbYes Then
                    LimparCampos()
                Else
                    Me.Close()
                End If
            End If
        Catch ex As Exception
            MsgBox("Erro inesperado: " & ex.Message & vbCrLf & vbCrLf & ex.StackTrace, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
        End Try
    End Sub

    Private Sub LimparCampos()
        txt_cpf_usuario.Clear()
        txt_email_usuario.Clear()
        txt_nome_usuario.Clear()
        txt_senha_usuario.Clear()
        txt_telefone_usuario.Clear()
        cmb_tipo_usuario.SelectedIndex = -1
    End Sub

    Private Sub txt_cpf_usuario_LostFocus(sender As Object, e As EventArgs) Handles txt_cpf_usuario.LostFocus
        Try
            Dim dt = ExecuteQuery($"SELECT * FROM usuarios WHERE cpf_usuario='{txt_cpf_usuario.Text}'")
            If dt.Rows.Count > 0 Then
                Dim row = dt.Rows(0)
                txt_nome_usuario.Text = row(1).ToString()
                cmb_tipo_usuario.Text = row(5).ToString()
                txt_telefone_usuario.Text = row(2).ToString()
                txt_email_usuario.Text = row(3).ToString()
                txt_senha_usuario.Text = row(4).ToString()
            Else
                txt_nome_usuario.Focus()
            End If
        Catch ex As Exception
            MsgBox("Erro ao consultar: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub cbx_senha_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_senha.CheckedChanged
        txt_senha_usuario.PasswordChar = If(cbx_senha.Checked, "", "*"c)
    End Sub

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        Me.Close()
    End Sub

    Private Sub dgv_usuario_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_usuario.CellContentClick
        Try
            With dgv_usuario
                If .CurrentRow.Cells(4).Selected Then
                    aux_cpf = .CurrentRow.Cells(1).Value.ToString()
                    resp = MsgBox("Deseja alterar o status dessa conta?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Atenção")
                    If resp = MsgBoxResult.Yes Then
                        Dim novoStatus = If(.CurrentRow.Cells(4).Value.ToString() = "NAO", "SIM", "NAO")
                        ExecuteNonQuery($"UPDATE usuarios SET bloqueado='{novoStatus}' WHERE cpf_usuario='{aux_cpf}'")
                        carregar_usuarios()
                    End If

                ElseIf .CurrentRow.Cells(5).Selected Then
                    aux_cpf = .CurrentRow.Cells(1).Value.ToString()
                    resp = MsgBox("Deseja realmente excluir?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                    If resp = MsgBoxResult.Yes Then
                        ExecuteNonQuery($"DELETE FROM usuarios WHERE cpf_usuario='{aux_cpf}'")
                        carregar_usuarios()
                    End If
                End If
            End With
        Catch ex As Exception
            MsgBox("Erro inesperado: " & ex.Message & vbCrLf & vbCrLf & ex.StackTrace, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
        End Try
    End Sub

    Private Sub txt_buscar_usuario_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar_usuario.TextChanged
        Try
            If cmb_parametro_usuario.Text = "EMAIL" Then
                param = "email_usuario"
            ElseIf cmb_parametro_usuario.Text = "NOME" Then
                param = "nome_usuario"
            ElseIf cmb_parametro_usuario.Text = "BLOQUEADO?" Then
                param = "bloqueado"
            Else
                param = "identificador"
            End If

            Dim dt = ExecuteQuery($"SELECT * FROM usuarios WHERE {param} LIKE '{txt_buscar_usuario.Text}%'")
            cont = 1
            dgv_usuario.Rows.Clear()
            For Each row As DataRow In dt.Rows
                dgv_usuario.Rows.Add(cont, row(0), row(3), row(5), row(6), Nothing, Nothing)
                cont += 1
            Next
        Catch ex As Exception
            MsgBox("Erro ao buscar: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
        End Try
    End Sub
End Class
