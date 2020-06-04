Imports System.Data.SQLite
Imports System.Text

Public Class frmPrincipal

    Private sConnectionString As String = String.Format("Data Source={0}\{1};Password={2};",
                                                        Application.StartupPath,
                                                        My.Settings.DataSource.ToString,
                                                        My.Settings.password.ToString)

    Private Sub CriaBotao()
        Dim bt As String
        Dim pY As Integer
        pY = 0

        Try
            Dim oConn As New SQLiteConnection(sConnectionString)
            oConn.Open()
            'define o comando SQL para retornar todos os dados da tabela Cadastro
            Dim daCadastro As New SQLiteDataAdapter("select * From app order by codbotao", oConn)
            'define o dataset
            Dim ds As New DataSet()
            'preenche o dataset
            daCadastro.Fill(ds)
            'fecha a conexao
            oConn.Close()

            ' Monta os Botoes
            For x = 0 To ds.Tables(0).Rows.Count - 1
                Dim botao As New Button()
                pY += My.Settings.TamY

                bt = "btnapp" & ds.Tables(0).Rows(x).ItemArray(0).ToString
                botao.Name = bt
                botao.Text = ds.Tables(0).Rows(x).ItemArray(2).ToString
                'botao.Size = New Size(CInt(LeArquivoINI(bt, "tamx", "")), CInt(LeArquivoINI(bt, "tamy", "")))
                'botao.Location = New Point(CInt(LeArquivoINI(bt, "localx", "")), CInt(LeArquivoINI(bt, "localy", "")))
                botao.Size = New Size(CInt(My.Settings.TamX), CInt(My.Settings.TamY))
                botao.Location = New Point(CInt(My.Settings.PosX), CInt(pY + My.Settings.PosX))
                botao.BackColor = Color.Transparent
                botao.FlatAppearance.BorderSize = 0
                botao.Font = My.Settings.Fonte
                AddHandler botao.Click, AddressOf btn_Click
                Me.Controls.Add(botao)
            Next

        Catch ex As Exception
        End Try
    End Sub

    Private Sub btn_Click(sender As Object, e As EventArgs)
        Try
            Select Case CType(sender, Button).Name
                Case CType(sender, Button).Name
                    Dim oConn As New SQLiteConnection(sConnectionString)
                    oConn.Open()
                    'define o comando SQL para retornar todos os dados da tabela Cadastro
                    Dim daCadastro As New SQLiteDataAdapter("select caminho from app where nomebotao like '" & CType(sender, Button).Text & "'", oConn)
                    'define o dataset
                    Dim ds As New DataSet()
                    'preenche o dataset
                    daCadastro.Fill(ds)
                    'fecha a conexao
                    oConn.Close()
                    Shell(ds.Tables(0).Rows(0).ItemArray(0).ToString)
            End Select
        Catch ex As Exception
            MsgBox("Caminho do executável não encontrado, favor verificar." & vbnewline & vbnewline & ex.message)
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CriaBotao()
        Me.Size = New Size(640, 560)
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F1 Then
            frmConfiguracao.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub frmPrincipal_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub
End Class
