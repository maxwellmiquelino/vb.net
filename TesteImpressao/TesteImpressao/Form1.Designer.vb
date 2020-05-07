<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.cboImpressoras = New System.Windows.Forms.ComboBox()
        Me.txtFormulario = New System.Windows.Forms.TextBox()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pdcImprimir = New System.Drawing.Printing.PrintDocument()
        Me.cboFonte = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nudTamanho = New System.Windows.Forms.NumericUpDown()
        Me.btnVisualizar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnAtualizaImpressora = New System.Windows.Forms.Button()
        CType(Me.nudTamanho, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboImpressoras
        '
        Me.cboImpressoras.FormattingEnabled = True
        Me.cboImpressoras.Location = New System.Drawing.Point(82, 12)
        Me.cboImpressoras.Name = "cboImpressoras"
        Me.cboImpressoras.Size = New System.Drawing.Size(212, 21)
        Me.cboImpressoras.TabIndex = 0
        '
        'txtFormulario
        '
        Me.txtFormulario.Location = New System.Drawing.Point(12, 117)
        Me.txtFormulario.Multiline = True
        Me.txtFormulario.Name = "txtFormulario"
        Me.txtFormulario.Size = New System.Drawing.Size(315, 284)
        Me.txtFormulario.TabIndex = 3
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(242, 66)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(86, 23)
        Me.btnImprimir.TabIndex = 4
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Impressora :"
        '
        'pdcImprimir
        '
        '
        'cboFonte
        '
        Me.cboFonte.FormattingEnabled = True
        Me.cboFonte.Location = New System.Drawing.Point(82, 39)
        Me.cboFonte.Name = "cboFonte"
        Me.cboFonte.Size = New System.Drawing.Size(245, 21)
        Me.cboFonte.TabIndex = 1
        Me.cboFonte.Text = "Courier New"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Fonte :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Tamanho :"
        '
        'nudTamanho
        '
        Me.nudTamanho.Location = New System.Drawing.Point(82, 66)
        Me.nudTamanho.Minimum = New Decimal(New Integer() {6, 0, 0, 0})
        Me.nudTamanho.Name = "nudTamanho"
        Me.nudTamanho.Size = New System.Drawing.Size(62, 20)
        Me.nudTamanho.TabIndex = 2
        Me.nudTamanho.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudTamanho.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'btnVisualizar
        '
        Me.btnVisualizar.Location = New System.Drawing.Point(150, 66)
        Me.btnVisualizar.Name = "btnVisualizar"
        Me.btnVisualizar.Size = New System.Drawing.Size(86, 23)
        Me.btnVisualizar.TabIndex = 7
        Me.btnVisualizar.Text = "Visualizar"
        Me.btnVisualizar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Texto para impressão"
        '
        'btnAtualizaImpressora
        '
        Me.btnAtualizaImpressora.Image = CType(resources.GetObject("btnAtualizaImpressora.Image"), System.Drawing.Image)
        Me.btnAtualizaImpressora.Location = New System.Drawing.Point(300, 10)
        Me.btnAtualizaImpressora.Name = "btnAtualizaImpressora"
        Me.btnAtualizaImpressora.Size = New System.Drawing.Size(28, 23)
        Me.btnAtualizaImpressora.TabIndex = 9
        Me.btnAtualizaImpressora.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(340, 413)
        Me.Controls.Add(Me.btnAtualizaImpressora)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnVisualizar)
        Me.Controls.Add(Me.nudTamanho)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboFonte)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.txtFormulario)
        Me.Controls.Add(Me.cboImpressoras)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Teste de Impressão"
        CType(Me.nudTamanho, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboImpressoras As System.Windows.Forms.ComboBox
    Friend WithEvents txtFormulario As System.Windows.Forms.TextBox
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pdcImprimir As System.Drawing.Printing.PrintDocument
    Friend WithEvents cboFonte As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents nudTamanho As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnVisualizar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnAtualizaImpressora As System.Windows.Forms.Button

End Class
