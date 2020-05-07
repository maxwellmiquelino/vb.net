Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each impressora As String In Printing.PrinterSettings.InstalledPrinters
            cboImpressoras.Items.Add(impressora)
        Next

        For Each fontes As FontFamily In FontFamily.Families
            cboFonte.Items.Add(fontes.Name)
        Next

        txtFormulario.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        If Len(cboImpressoras.Text) = 0 Then
            MsgBox("Seleciona uma impressora")
            cboImpressoras.Focus()
            Exit Sub
        End If
        If Len(cboFonte.Text) = 0 Then
            MsgBox("Seleciona uma fonte")
            cboFonte.Focus()
            Exit Sub
        End If

        Dim pg As New Printing.PaperSize
        pg.RawKind = Printing.PaperKind.Custom
        pg.Height = 800
        pg.Width = 400
        pdcImprimir.PrinterSettings.PrinterName = cboImpressoras.Text
        pdcImprimir.DefaultPageSettings.PaperSize = pg
        pdcImprimir.Print()
    End Sub

    Private Sub pdcImprimir_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles pdcImprimir.PrintPage
        e.Graphics.DrawString(txtFormulario.Text, New Font(cboFonte.Text, Convert.ToInt32(nudTamanho.Value), FontStyle.Regular), Brushes.Black, 10, 10)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnVisualizar.Click
        txtFormulario.Text = ""
        txtFormulario.Text = "TITULO : " & Me.Text & vbNewLine
        txtFormulario.Text = txtFormulario.Text & "IMPRESSORA : " & cboImpressoras.Text & vbNewLine
        txtFormulario.Text = txtFormulario.Text & "FONTE : " & cboFonte.Text & vbNewLine
        txtFormulario.Text = txtFormulario.Text & "TAMANHO : " & nudTamanho.Value & vbNewLine & vbNewLine
        txtFormulario.Text = txtFormulario.Text & "SE VOCE ESTIVER LENDO ISSO DEPOIS DE IMPRESSO É SINAL QUE A PAGINA DE IMPRESSAO FOI IMPRESSO CORRETAMENTE."
        txtFormulario.Font = New Font(cboFonte.Text, Convert.ToInt32(nudTamanho.Value))
    End Sub

    Private Sub btnAtualizaImpressora_Click(sender As Object, e As EventArgs) Handles btnAtualizaImpressora.Click
        cboImpressoras.Items.Clear()

        For Each impressora As String In Printing.PrinterSettings.InstalledPrinters
            cboImpressoras.Items.Add(impressora)
        Next
    End Sub
End Class
