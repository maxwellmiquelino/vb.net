Public Class frmBingo

    Dim Pedra As Integer
    Dim Sorteado As Integer
    Dim Contagem As Integer

    Private Sub LimparTudo()
        lbl1.Visible = False
        lbl2.Visible = False
        lbl3.Visible = False
        lbl4.Visible = False
        lbl5.Visible = False
        lbl6.Visible = False
        lbl7.Visible = False
        lbl8.Visible = False
        lbl9.Visible = False
        lbl10.Visible = False
        lbl11.Visible = False
        lbl12.Visible = False
        lbl13.Visible = False
        lbl14.Visible = False
        lbl15.Visible = False
        lbl16.Visible = False
        lbl17.Visible = False
        lbl18.Visible = False
        lbl19.Visible = False
        lbl20.Visible = False
        lbl21.Visible = False
        lbl22.Visible = False
        lbl23.Visible = False
        lbl24.Visible = False
        lbl25.Visible = False
        lbl26.Visible = False
        lbl27.Visible = False
        lbl28.Visible = False
        lbl29.Visible = False
        lbl30.Visible = False
        lbl31.Visible = False
        lbl32.Visible = False
        lbl33.Visible = False
        lbl34.Visible = False
        lbl35.Visible = False
        lbl36.Visible = False
        lbl37.Visible = False
        lbl38.Visible = False
        lbl39.Visible = False
        lbl40.Visible = False
        lbl41.Visible = False
        lbl42.Visible = False
        lbl43.Visible = False
        lbl44.Visible = False
        lbl45.Visible = False
        lbl46.Visible = False
        lbl47.Visible = False
        lbl48.Visible = False
        lbl49.Visible = False
        lbl50.Visible = False
        lbl51.Visible = False
        lbl52.Visible = False
        lbl53.Visible = False
        lbl54.Visible = False
        lbl55.Visible = False
        lbl56.Visible = False
        lbl57.Visible = False
        lbl58.Visible = False
        lbl59.Visible = False
        lbl60.Visible = False
        lbl61.Visible = False
        lbl62.Visible = False
        lbl63.Visible = False
        lbl64.Visible = False
        lbl65.Visible = False
        lbl66.Visible = False
        lbl67.Visible = False
        lbl68.Visible = False
        lbl69.Visible = False
        lbl70.Visible = False
        lbl71.Visible = False
        lbl72.Visible = False
        lbl73.Visible = False
        lbl74.Visible = False
        lbl75.Visible = False
        txtPedra.Text = ""
        Sorteado = 0
    End Sub

    Private Sub btnSortear_Click(sender As Object, e As EventArgs) Handles btnSortear.Click
        Dim x, y As Integer
        Dim flag As Boolean = True
        Randomize()
        'Pedra = CInt(74 * Rnd() + 1)
        Contagem = Me.Controls.Count - 1

        ' Verifica se o número ja saiu
        ' ****************************
        If Sorteado >= 0 And Sorteado < 75 Then
            While flag
                Pedra = CInt(74 * Rnd() + 1)
                For x = 0 To Contagem
                    If TypeOf Me.Controls(x) Is Label Then
                        If Me.Controls(x).Text = Pedra Then
                            If Me.Controls(x).Visible = True Then
                                flag = True
                            Else
                                flag = False
                                Sorteado += 1
                                txtPedra.Text = Pedra
                            End If
                        End If
                    End If
                Next
            End While
        Else
            MsgBox("Se chegou aqui é por que não houve vencedor.", MsgBoxStyle.Information, "Bingo")
            txtPedra.Text = ""
        End If

        ' Mostra o número
        ' ***************
        For x = 0 To Contagem
            If TypeOf Me.Controls(x) Is Label Then
                If Me.Controls(x).Text = Pedra Then
                    Me.Controls(x).Visible = True
                    Exit For
                End If
            End If
        Next
    End Sub

    Private Sub frmBingo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        picLogo.Image = Image.FromFile(Application.StartupPath & "\LOGO.PNG")
        LimparTudo()
    End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        LimparTudo()
    End Sub
End Class
