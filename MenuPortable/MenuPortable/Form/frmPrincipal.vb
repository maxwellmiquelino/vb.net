Imports System.Data.SQLite
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms.VisualStyles

Public Class frmPrincipal

    Private Function CantoArredondado() As GraphicsPath
        Dim p As New GraphicsPath()
        p.StartFigure()
        p.AddArc(New Rectangle(0, 0, 40, 40), 180, 90)
        p.AddLine(40, 0, Me.Width - 40, 0)
        p.AddArc(New Rectangle(Me.Width - 40, 0, 40, 40), -90, 90)
        p.AddLine(Me.Width, 40, Me.Width, Me.Height - 40)
        p.AddArc(New Rectangle(Me.Width - 40, Me.Height - 40, 40, 40), 0, 90)
        p.AddLine(Me.Width - 40, Me.Height, 40, Me.Height)
        p.AddArc(New Rectangle(0, Me.Height - 40, 40, 40), 90, 90)
        p.CloseFigure()
        Return p
    End Function

    Private Sub CriaBotao()
        Dim bt As String
        Dim pY As Integer
        pY = 0

        Try
            Dim oConn As New SQLiteConnection(RetornaStringConexao)
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
                botao.Dock = DockStyle.Top
                botao.FlatStyle = FlatStyle.Flat
                botao.FlatAppearance.BorderColor = Color.White
                botao.FlatAppearance.BorderSize = 0
                botao.FlatAppearance.MouseOverBackColor = Color.Blue
                botao.FlatAppearance.MouseDownBackColor = Color.Red
                botao.UseVisualStyleBackColor = BorderType.Ellipse
                botao.Text = ds.Tables(0).Rows(x).ItemArray(2).ToString
                botao.Size = New Size(CInt(My.Settings.TamX), CInt(My.Settings.TamY))
                botao.Location = New Point(CInt(My.Settings.PosX), CInt(pY + My.Settings.PosX))
                botao.BackColor = Color.Transparent
                botao.FlatAppearance.BorderSize = 0
                botao.Font = My.Settings.Fonte
                botao.TabIndex = x + 1

                AddHandler botao.Click, AddressOf btn_Click
                Panel1.Controls.Add(botao)
            Next

        Catch ex As Exception
        End Try
    End Sub

    Private Sub btn_Click(sender As Object, e As EventArgs)
        Try
            Select Case CType(sender, Button).Name
                Case CType(sender, Button).Name
                    Dim oConn As New SQLiteConnection(RetornaStringConexao)
                    oConn.Open()
                    'define o comando SQL para retornar todos os dados da tabela Cadastro
                    Dim daCadastro As New SQLiteDataAdapter("select caminho from app where nomebotao like '" & CType(sender, Button).Text & "'", oConn)
                    'define o dataset
                    Dim ds As New DataSet()
                    'preenche o dataset
                    daCadastro.Fill(ds)
                    'fecha a conexao
                    oConn.Close()
                    Shell(ds.Tables(0).Rows(0).ItemArray(0).ToString, AppWinStyle.MaximizedFocus)
            End Select
        Catch ex As Exception
            MsgBox("Caminho do executável não encontrado, favor verificar.")
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Region = New Region(CantoArredondado)

        If ExisteBancoDados() Then
            onCreate()
        End If

        CriaBotao()
        Me.Size = New Size(640, 560)
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F1 Then
            frmConfiguracao.Show()
            Me.Hide()
        ElseIf e.KeyCode = Keys.Escape Then
            Application.Exit()
        End If
    End Sub

    Private Sub frmPrincipal_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub
End Class
