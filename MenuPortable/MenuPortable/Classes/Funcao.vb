Imports System.IO

Module Funcao

    ''' <summary>
    ''' Grava o log se gravou ou apresentou erro.
    ''' </summary>
    ''' <param name="texto">Texto para ser gravado no log.</param>
    ''' <param name="tipo">Tipo do log : LOG <default> ou APP</default></param>
    ''' <remarks></remarks>
    Public Sub GravarLog(ByRef texto As String, Optional ByRef tipo As String = "LOG")
        Dim ArqGra As StreamWriter
        Dim arqLog As String

        arqLog = Application.StartupPath & "\LOG\" & Format(CDate(Now.Date.ToString), "yyyyMMdd") & "-" & tipo & ".TXT"

        If Not My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\LOG\") Then
            My.Computer.FileSystem.CreateDirectory(Application.StartupPath & "\LOG\")
        End If

        If Not My.Computer.FileSystem.FileExists(arqLog) Then
            My.Computer.FileSystem.FileExists(arqLog)
            ArqGra = New IO.StreamWriter(arqLog)
            ArqGra.WriteLine(Now.ToString & " - " & texto & vbNewLine)
            ArqGra.Close()
        Else
            ArqGra = New IO.StreamWriter(arqLog, True)
            ArqGra.WriteLine(Now.ToString & " - " & texto & vbNewLine)
            ArqGra.Close()
        End If
    End Sub

End Module
