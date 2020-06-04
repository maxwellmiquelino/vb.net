Imports System.IO
Imports System.Text

Module modFuncao

    Public Declare Auto Function GetPrivateProfileString Lib "Kernel32" (ByVal lpAppName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As StringBuilder, ByVal nSize As Integer, ByVal lpFileName As String) As Integer
    Public Declare Auto Function WritePrivateProfileString Lib "Kernel32" (ByVal lpAppName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Integer
    Private Arquivo As String = Application.StartupPath & "\CONFIG.INI"

    ' Usa a função GetPrivateProfileString para obter os valores
    Public Function LeArquivoINI(ByVal section_name As String, ByVal key_name As String, ByVal default_value As String) As String
        Const MAX_LENGTH As Integer = 500
        Dim string_builder As New StringBuilder(MAX_LENGTH)
        GetPrivateProfileString(section_name, key_name, default_value, string_builder, MAX_LENGTH, Arquivo)
        Return string_builder.ToString()
    End Function

    Public Sub GravaINI(Config As String, Campo As String, Valor As String)
        WritePrivateProfileString(Config, Campo, Valor, Arquivo)
    End Sub

    Public Function lerConteudoArquivo() As String
        Dim ArqLer As StreamReader = New StreamReader(Arquivo)
        Dim Ler As String = ArqLer.ReadToEnd()
        ArqLer.Close()

        Return Ler
    End Function
End Module
