Imports System.Data.SQLite

Public Class frmConfiguracao

    Private Sub CarregaGrid()
        Try
            'abre a conexão
            Dim oConn As New SQLiteConnection(RetornaStringConexao)
            oConn.Open()
            'define o comando SQL para retornar todos os dados da tabela Cadastro
            Dim daCadastro As New SQLiteDataAdapter("Select * From app order by seqapp", oConn)
            'define o dataset
            Dim ds As New DataSet()
            'preenche o dataset
            daCadastro.Fill(ds)
            'exibe os dados no datagridview
            dgvDados.DataSource = ds.Tables(0)
            'fecha a conexao
            oConn.Close()

            ' Define os tamanhos das colunas
            dgvDados.Columns(0).Width = 75 'seqapp
            dgvDados.Columns(1).Width = 90 'codbotao
            dgvDados.Columns(2).Width = 200 'nomebotao
            dgvDados.Columns(3).Width = 400 'caminho
        Catch ex As Exception
            MsgBox("Erro ao acessar o banco de dados SQLite: " & ex.Message)
        End Try
    End Sub

    Private Sub frmConfiguracao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtSeqbotao.Enabled = False
        CarregaGrid()
    End Sub

    Private Sub txtQtdeBtn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSeqbotao.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not e.KeyChar = vbBack Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnGravarSair_Click(sender As Object, e As EventArgs) Handles btnGravar.Click
        Try
            Dim oConn As New SQLiteConnection(RetornaStringConexao)
            oConn.Open()

            If Len(txtSeqbotao.Text) = 0 Then
                Dim cmd As New SQLiteCommand(oConn)
                cmd.CommandText = "insert into app(codbotao,nomebotao,caminho) values(@codbotao,@nomebotao,@caminho)"
                cmd.Parameters.AddWithValue("@codbotao", txtNumBotao.Text)
                cmd.Parameters.AddWithValue("@nomebotao", txtTextoBotao.Text)
                cmd.Parameters.AddWithValue("@caminho", txtCamEx.Text)
                cmd.ExecuteNonQuery()
                GravarLog("Dados inserido com sucesso !!!", "APP")
            ElseIf Len(txtSeqbotao.Text) > 0 Then
                Dim cmd As New SQLiteCommand(oConn)
                cmd.CommandText = "update app set codbotao=@codbotao, nomebotao=@nomebotao, caminho=@caminho where seqapp=@seqapp"
                cmd.Parameters.AddWithValue("@codbotao", txtNumBotao.Text)
                cmd.Parameters.AddWithValue("@nomebotao", txtTextoBotao.Text)
                cmd.Parameters.AddWithValue("@caminho", txtCamEx.Text)
                cmd.Parameters.AddWithValue("@seqapp", txtSeqbotao.Text)
                cmd.ExecuteNonQuery()
                GravarLog("Dados atualizados com sucesso !!!", "APP")
            End If
            CarregaGrid()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "MIPAMAX - Portable")
            GravarLog(sender.ToString & " - " & e.ToString & ex.Message)
        End Try
    End Sub

    Private Sub txtNumBotao_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumBotao.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not e.KeyChar = vbBack Then
            e.Handled = True
        End If
    End Sub

    Private Sub frmConfiguracao_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmPrincipal.Show()
        Me.Hide()
    End Sub

    Private Sub dgvDados_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDados.CellDoubleClick
        With dgvDados
            txtSeqbotao.Text = .CurrentRow.Cells(0).Value.ToString()
            txtNumBotao.Text = .CurrentRow.Cells(1).Value.ToString()
            txtTextoBotao.Text = .CurrentRow.Cells(2).Value.ToString()
            txtCamEx.Text = .CurrentRow.Cells(3).Value.ToString()
        End With
    End Sub

    Private Sub btnCamEx_Click(sender As Object, e As EventArgs) Handles btnCamEx.Click
        With OpenFileDialog1
            .Filter = "Executavel (*.EXE)|*.EXE|Todos arquivos (*.*)|*.*"
            .FileName = ""
            .ShowDialog()
            txtCamEx.Text = .FileName.ToString
        End With
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Application.Restart()
    End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        txtSeqbotao.Text = Nothing
        txtNumBotao.Text = Nothing
        txtCamEx.Text = Nothing
        txtTextoBotao.Text = Nothing
        txtNumBotao.Focus()
    End Sub
End Class