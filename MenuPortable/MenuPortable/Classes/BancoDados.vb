Imports System.Data.SQLite
Imports System.Text

Module BancoDados

    Public Function RetornaStringConexao() As String
        Return String.Format("Data Source={0}\{1};Password={2};",
                                                    Application.StartupPath,
                                                    My.Settings.DataSource.ToString,
                                                    My.Settings.password.ToString)
    End Function

    Public Function ExisteBancoDados() As Boolean
        Dim retorno As Boolean = False
        Dim arq As String = String.Format("{0}\{1}", Application.StartupPath, My.Settings.DataSource.ToString)
        If Not My.Computer.FileSystem.FileExists(arq) Then
            retorno = True
        End If

        Return retorno
    End Function

    ''' <summary>
    ''' Cria o banco de dados caso não encontre e adicionas os parametros
    ''' </summary>
    Public Sub onCreate()

        ' Cria o banco de dados
        Try
            SQLiteConnection.CreateFile(String.Format("{0}{1}", Application.StartupPath, My.Settings.DataSource.ToString))
            GravarLog("Arquivo do banco de dados ( " & My.Settings.DataSource.ToString & " ) criado com sucesso !!!", "APP")
        Catch ex As Exception
            GravarLog("Modulo.onCreate() " & ex.Message)
        End Try

        ' Cria a tabela
        Try
            Dim sql As New StringBuilder
            Dim conn As New SQLiteConnection(RetornaStringConexao)
            conn.Open()

            sql.AppendLine("create table if not exists app (")
            sql.AppendLine("seqapp    Integer PRIMARY KEY ON CONFLICT ROLLBACK AUTOINCREMENT Not NULL,")
            sql.AppendLine("codbotao  Integer Not NULL On CONFLICT ROLLBACK,")
            sql.AppendLine("nomebotao Text    Not NULL On CONFLICT ROLLBACK,")
            sql.AppendLine("caminho   Text    Not NULL ON CONFLICT ROLLBACK)")
            Dim cmd As SQLiteCommand = New SQLiteCommand(sql.ToString, conn)
            cmd.ExecuteNonQuery()
            GravarLog("Tabela 'app' criado com sucesso !!!", "APP")
        Catch ex As Exception
            GravarLog("Modulo.onCreate() " & ex.Message)
        End Try
    End Sub

End Module
