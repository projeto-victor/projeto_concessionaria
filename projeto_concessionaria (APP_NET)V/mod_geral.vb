Imports MySql.Data.MySqlClient

Module mod_geral
    Public diretorio, aux_id, sql, id_ped, resp, senha, cpf, bloqueado, ident, email, gcpf, data, nome, id_prod, aux_cpf, id_stq, stq, param As String
    Public cont As Integer
    Private connStr As String

    Sub New()
        Dim host As String = "localhost"
        Dim dbName As String = "att_concessionaria"
        Dim user As String = "root"
        Dim pass As String = "Domitila050107-"
        connStr = $"Server={host};Port=3307;Database={dbName};user={user};password={pass};charset=utf8;"
    End Sub

    Public Function GetConnection() As MySqlConnection
        Dim conn As New MySqlConnection(connStr)
        conn.Open()
        Return conn
    End Function

    ' ── Helpers internos ─────────────────────────────────────────────────────

    ''' <summary>Executa SELECT e retorna DataTable.</summary>
    Public Function ExecuteQuery(sql As String) As DataTable
        Dim dt As New DataTable()
        Using conn As MySqlConnection = GetConnection()
            Using cmd As New MySqlCommand(sql, conn)
                Using da As New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
        End Using
        Return dt
    End Function

    ''' <summary>Executa INSERT / UPDATE / DELETE e retorna linhas afetadas.</summary>
    Public Function ExecuteNonQuery(sql As String) As Integer
        Using conn As MySqlConnection = GetConnection()
            Using cmd As New MySqlCommand(sql, conn)
                Return cmd.ExecuteNonQuery()
            End Using
        End Using
    End Function

    ' ── Carregamentos de grid ─────────────────────────────────────────────────

    Sub carregar_usuarios()
        Try
            Dim dt = ExecuteQuery("SELECT * FROM usuarios ORDER BY nome_usuario ASC")
            With form_cad_usuarios.dgv_usuario
                .Rows.Clear()
                cont = 1
                For Each row As DataRow In dt.Rows
                    .Rows.Add(cont, row(0), row(3), row(5), row(6), Nothing, Nothing)
                    cont += 1
                Next
            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar usuários: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Sub carregar_pedidos_prop()
        Try
            Dim dt = ExecuteQuery("SELECT * FROM pedidos WHERE concluido<>'ENTREGUE' ORDER BY id_pedidos ASC")
            With menu_propietaria.dgv_pedidos
                .Rows.Clear()
                For Each row As DataRow In dt.Rows
                    .Rows.Add(row(0), row(1), row(2), row(3), row(6), Nothing)
                Next
            End With
        Catch ex As Exception
            MsgBox("Erro inesperado: " & ex.Message & vbCrLf & ex.StackTrace, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
        End Try
    End Sub

    Sub carregar_pedidos_func()
        Try
            Dim dt = ExecuteQuery("SELECT * FROM pedidos WHERE concluido<>'ENTREGUE' ORDER BY id_pedidos ASC")
            With menu_funcionarios.dgv_pedidos
                .Rows.Clear()
                For Each row As DataRow In dt.Rows
                    .Rows.Add(row(0), row(1), row(2), row(3), row(6), Nothing)
                Next
            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar pedidos: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Sub carregar_cardapio()
        Try
            Dim dt = ExecuteQuery("SELECT * FROM encomenda ORDER BY id_encomenda ASC")
            With form_encomendar.dgv_encomenda
                .Rows.Clear()
                For Each row As DataRow In dt.Rows
                    .Rows.Add(row(0), row(1), row(2), row(3), Nothing)
                Next
            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar cardápio: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Sub carregar_historico_cliente()
        Try
            Dim dt = ExecuteQuery($"SELECT * FROM pedidos WHERE concluido='ENTREGUE' AND cpf_cliente='{gcpf}' ORDER BY id_pedidos ASC")
            With form_historico_pedidos.dgv_pedidos
                .Rows.Clear()
                For Each row As DataRow In dt.Rows
                    .Rows.Add(row(0), row(1), row(2), row(3), row(6), row(5))
                Next
            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar histórico: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Sub carregar_historico_adm()
        Try
            Dim dt = ExecuteQuery("SELECT * FROM pedidos WHERE concluido='ENTREGUE' ORDER BY id_pedidos ASC")
            With form_historico_pedidos.dgv_pedidos
                .Rows.Clear()
                For Each row As DataRow In dt.Rows
                    .Rows.Add(row(0), row(1), row(2), row(3), row(6), row(5))
                Next
            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar histórico: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Sub carregar_pedidos_cliente()
        Try
            Dim dt = ExecuteQuery($"SELECT * FROM pedidos WHERE concluido<>'ENTREGUE' AND cpf_cliente='{gcpf}' ORDER BY id_pedidos ASC")
            With menu_cliente.dgv_pedidos
                .Rows.Clear()
                For Each row As DataRow In dt.Rows
                    .Rows.Add(row(0), row(1), row(2), row(3), row(6), row(5))
                Next
            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar pedidos: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Sub carregar_ingred()
        Try
            Dim dt = ExecuteQuery("SELECT * FROM estoque_ingred ORDER BY id_ingrediente ASC")
            With form_cad_prod.dgv_produto
                .Rows.Clear()
                For Each row As DataRow In dt.Rows
                    .Rows.Add(row(0), row(1), row(2), Nothing, Nothing, Nothing, Nothing)
                Next
            End With
        Catch ex As Exception
            MsgBox("Erro inesperado: " & ex.Message & vbCrLf & ex.StackTrace, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
        End Try
    End Sub

    Sub carregar_encomenda()
        Try
            Dim dt = ExecuteQuery("SELECT * FROM encomenda ORDER BY id_encomenda ASC")
            With form_cad_prod.dgv_produto
                .Rows.Clear()
                For Each row As DataRow In dt.Rows
                    .Rows.Add(row(0), row(1), Nothing, row(2), row(3), Nothing, Nothing)
                Next
            End With
        Catch ex As Exception
            MsgBox("Erro inesperado: " & ex.Message & vbCrLf & ex.StackTrace, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
        End Try
    End Sub

    Sub carregar_balcao()
        Try
            Dim dt = ExecuteQuery("SELECT * FROM balcao ORDER BY id_balcao ASC")
            With form_cad_prod.dgv_produto
                .Rows.Clear()
                For Each row As DataRow In dt.Rows
                    .Rows.Add(row(0), row(1), row(3), row(2), row(4), Nothing, Nothing)
                Next
            End With
        Catch ex As Exception
            MsgBox("Erro inesperado: " & ex.Message & vbCrLf & ex.StackTrace, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
        End Try
    End Sub

    Sub carregar_estq_vitrine()
        Try
            Dim dt = ExecuteQuery("SELECT * FROM balcao ORDER BY id_balcao ASC")
            With form_stq_vitrini.dgv_vitrini
                .Rows.Clear()
                For Each row As DataRow In dt.Rows
                    .Rows.Add(row(0), row(1), row(2), row(3), Nothing, Nothing)
                Next
                For Each dgvRow As DataGridViewRow In .Rows
                    If dgvRow.Cells(3).Value IsNot Nothing AndAlso CInt(dgvRow.Cells(3).Value) = 0 Then
                        dgvRow.Cells(3).Style.BackColor = Color.Red
                    Else
                        dgvRow.Cells(3).Style.BackColor = Color.White
                    End If
                Next
            End With
        Catch ex As Exception
            MsgBox("Erro inesperado: " & ex.Message & vbCrLf & ex.StackTrace, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
        End Try
    End Sub

    ' ── Carregamentos de ComboBox ─────────────────────────────────────────────

    Sub carregar_paramentros_produto1()
        With form_cad_prod.cmb_parametro_produto.Items
            .Clear()
            .Add("NOME")
            .Add("TIPO")
        End With
        form_cad_prod.cmb_parametro_produto.SelectedIndex = 1
    End Sub

    Sub carregar_paramentros_produto2()
        With form_encomendar.cmb_parametro_produto.Items
            .Clear()
            .Add("NOME")
            .Add("TIPO")
        End With
        form_encomendar.cmb_parametro_produto.SelectedIndex = 1
    End Sub

    Sub carregar_paramentros_produto3()
        With form_stq_vitrini.cmb_parametro_produto.Items
            .Clear()
            .Add("NOME")
            .Add("TIPO")
        End With
        form_stq_vitrini.cmb_parametro_produto.SelectedIndex = 1
    End Sub

    Sub carregar_paramentros_pedidos()
        With form_historico_pedidos.cmb_parametro_pedidos.Items
            .Clear()
            .Add("CPF")
            .Add("PRODUTO")
            .Add("DATA")
        End With
        form_historico_pedidos.cmb_parametro_pedidos.SelectedIndex = 1
    End Sub

    Sub carregar_paramentros_usuarios()
        With form_cad_usuarios.cmb_parametro_usuario.Items
            .Clear()
            .Add("CPF")
            .Add("EMAIL")
            .Add("FUNÇÃO")
            .Add("BLOQUEADO?")
        End With
        form_cad_usuarios.cmb_parametro_usuario.SelectedIndex = -1
    End Sub

End Module
