<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmConfiguracao
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConfiguracao))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.btnCamEx = New System.Windows.Forms.Button()
        Me.dgvDados = New System.Windows.Forms.DataGridView()
        Me.txtNumBotao = New System.Windows.Forms.TextBox()
        Me.txtCamEx = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTextoBotao = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnGravar = New System.Windows.Forms.Button()
        Me.txtSeqbotao = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.btnLimpar)
        Me.Panel1.Controls.Add(Me.btnSair)
        Me.Panel1.Controls.Add(Me.btnCamEx)
        Me.Panel1.Controls.Add(Me.dgvDados)
        Me.Panel1.Controls.Add(Me.txtNumBotao)
        Me.Panel1.Controls.Add(Me.txtCamEx)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtTextoBotao)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.btnGravar)
        Me.Panel1.Controls.Add(Me.txtSeqbotao)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(708, 480)
        Me.Panel1.TabIndex = 5
        '
        'btnSair
        '
        Me.btnSair.Location = New System.Drawing.Point(552, 10)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(135, 64)
        Me.btnSair.TabIndex = 7
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'btnCamEx
        '
        Me.btnCamEx.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCamEx.Location = New System.Drawing.Point(667, 115)
        Me.btnCamEx.Name = "btnCamEx"
        Me.btnCamEx.Size = New System.Drawing.Size(27, 29)
        Me.btnCamEx.TabIndex = 4
        Me.btnCamEx.Text = "..."
        Me.btnCamEx.UseVisualStyleBackColor = True
        '
        'dgvDados
        '
        Me.dgvDados.AllowUserToAddRows = False
        Me.dgvDados.AllowUserToDeleteRows = False
        Me.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDados.Location = New System.Drawing.Point(10, 150)
        Me.dgvDados.Name = "dgvDados"
        Me.dgvDados.ReadOnly = True
        Me.dgvDados.RowHeadersWidth = 5
        Me.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDados.Size = New System.Drawing.Size(684, 316)
        Me.dgvDados.TabIndex = 10
        '
        'txtNumBotao
        '
        Me.txtNumBotao.Location = New System.Drawing.Point(164, 45)
        Me.txtNumBotao.Name = "txtNumBotao"
        Me.txtNumBotao.Size = New System.Drawing.Size(100, 29)
        Me.txtNumBotao.TabIndex = 2
        Me.txtNumBotao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCamEx
        '
        Me.txtCamEx.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCamEx.Location = New System.Drawing.Point(164, 115)
        Me.txtCamEx.Name = "txtCamEx"
        Me.txtCamEx.Size = New System.Drawing.Size(497, 29)
        Me.txtCamEx.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(62, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 24)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Caminho :"
        '
        'txtTextoBotao
        '
        Me.txtTextoBotao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTextoBotao.Location = New System.Drawing.Point(164, 80)
        Me.txtTextoBotao.Name = "txtTextoBotao"
        Me.txtTextoBotao.Size = New System.Drawing.Size(530, 29)
        Me.txtTextoBotao.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 24)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Num. Botão :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 24)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Texto do Botão :"
        '
        'btnGravar
        '
        Me.btnGravar.Location = New System.Drawing.Point(270, 10)
        Me.btnGravar.Name = "btnGravar"
        Me.btnGravar.Size = New System.Drawing.Size(135, 64)
        Me.btnGravar.TabIndex = 5
        Me.btnGravar.Text = "Gravar"
        Me.btnGravar.UseVisualStyleBackColor = True
        '
        'txtSeqbotao
        '
        Me.txtSeqbotao.Location = New System.Drawing.Point(164, 10)
        Me.txtSeqbotao.Name = "txtSeqbotao"
        Me.txtSeqbotao.Size = New System.Drawing.Size(100, 29)
        Me.txtSeqbotao.TabIndex = 1
        Me.txtSeqbotao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sequencia :"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Title = "Abrir"
        '
        'btnLimpar
        '
        Me.btnLimpar.Location = New System.Drawing.Point(411, 10)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(135, 64)
        Me.btnLimpar.TabIndex = 6
        Me.btnLimpar.Text = "Limpar"
        Me.btnLimpar.UseVisualStyleBackColor = True
        '
        'frmConfiguracao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(708, 480)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConfiguracao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuração"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtSeqbotao As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnGravar As Button
    Friend WithEvents txtTextoBotao As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCamEx As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNumBotao As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvDados As DataGridView
    Friend WithEvents btnCamEx As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btnSair As Button
    Friend WithEvents btnLimpar As Button
End Class
