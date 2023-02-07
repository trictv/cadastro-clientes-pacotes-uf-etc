<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgencia
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.lblId = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.txtDataFundacao = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.grvTodasAgencias = New System.Windows.Forms.DataGridView()
        Me.txtPacotesDisponiveis = New System.Windows.Forms.TextBox()
        Me.txtAgendamentos = New System.Windows.Forms.TextBox()
        Me.btnBuscarPacotes = New System.Windows.Forms.Button()
        Me.btnBuscarAgendamentos = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grvTodasAgencias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.lblId)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(204, 117)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(113, 52)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(6, 37)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(68, 13)
        Me.lblId.TabIndex = 1
        Me.lblId.Text = "ID AGENCIA"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(6, 56)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(100, 20)
        Me.txtID.TabIndex = 0
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(225, 43)
        Me.txtNome.MaxLength = 50
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(245, 20)
        Me.txtNome.TabIndex = 6
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Location = New System.Drawing.Point(222, 26)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(35, 13)
        Me.lblNome.TabIndex = 5
        Me.lblNome.Text = "Nome"
        '
        'txtDataFundacao
        '
        Me.txtDataFundacao.Location = New System.Drawing.Point(482, 42)
        Me.txtDataFundacao.Mask = "00/00/0000"
        Me.txtDataFundacao.Name = "txtDataFundacao"
        Me.txtDataFundacao.Size = New System.Drawing.Size(100, 20)
        Me.txtDataFundacao.TabIndex = 7
        Me.txtDataFundacao.ValidatingType = GetType(Date)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(479, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "DATA FUNDAÇÃO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(222, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Pacotes Disponiveis"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(479, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Agendamentos"
        '
        'btnSalvar
        '
        Me.btnSalvar.Location = New System.Drawing.Point(729, 41)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(75, 21)
        Me.btnSalvar.TabIndex = 61
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Location = New System.Drawing.Point(729, 96)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(75, 21)
        Me.btnExcluir.TabIndex = 60
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(729, 69)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 21)
        Me.btnCancelar.TabIndex = 59
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'grvTodasAgencias
        '
        Me.grvTodasAgencias.AllowUserToAddRows = False
        Me.grvTodasAgencias.AllowUserToDeleteRows = False
        Me.grvTodasAgencias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grvTodasAgencias.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.grvTodasAgencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grvTodasAgencias.Location = New System.Drawing.Point(12, 135)
        Me.grvTodasAgencias.Name = "grvTodasAgencias"
        Me.grvTodasAgencias.ReadOnly = True
        Me.grvTodasAgencias.Size = New System.Drawing.Size(792, 333)
        Me.grvTodasAgencias.TabIndex = 62
        '
        'txtPacotesDisponiveis
        '
        Me.txtPacotesDisponiveis.Enabled = False
        Me.txtPacotesDisponiveis.Location = New System.Drawing.Point(225, 92)
        Me.txtPacotesDisponiveis.Name = "txtPacotesDisponiveis"
        Me.txtPacotesDisponiveis.Size = New System.Drawing.Size(144, 20)
        Me.txtPacotesDisponiveis.TabIndex = 63
        '
        'txtAgendamentos
        '
        Me.txtAgendamentos.Enabled = False
        Me.txtAgendamentos.Location = New System.Drawing.Point(482, 90)
        Me.txtAgendamentos.Name = "txtAgendamentos"
        Me.txtAgendamentos.Size = New System.Drawing.Size(144, 20)
        Me.txtAgendamentos.TabIndex = 64
        '
        'btnBuscarPacotes
        '
        Me.btnBuscarPacotes.Location = New System.Drawing.Point(375, 91)
        Me.btnBuscarPacotes.Name = "btnBuscarPacotes"
        Me.btnBuscarPacotes.Size = New System.Drawing.Size(75, 21)
        Me.btnBuscarPacotes.TabIndex = 65
        Me.btnBuscarPacotes.Text = "buscar"
        Me.btnBuscarPacotes.UseVisualStyleBackColor = True
        '
        'btnBuscarAgendamentos
        '
        Me.btnBuscarAgendamentos.Location = New System.Drawing.Point(632, 89)
        Me.btnBuscarAgendamentos.Name = "btnBuscarAgendamentos"
        Me.btnBuscarAgendamentos.Size = New System.Drawing.Size(75, 21)
        Me.btnBuscarAgendamentos.TabIndex = 66
        Me.btnBuscarAgendamentos.Text = "buscar"
        Me.btnBuscarAgendamentos.UseVisualStyleBackColor = True
        '
        'frmAgencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(840, 511)
        Me.Controls.Add(Me.btnBuscarAgendamentos)
        Me.Controls.Add(Me.btnBuscarPacotes)
        Me.Controls.Add(Me.txtAgendamentos)
        Me.Controls.Add(Me.txtPacotesDisponiveis)
        Me.Controls.Add(Me.grvTodasAgencias)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDataFundacao)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.lblNome)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmAgencia"
        Me.Text = "frmAgencia"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grvTodasAgencias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents lblId As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtNome As TextBox
    Friend WithEvents lblNome As Label
    Friend WithEvents txtDataFundacao As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSalvar As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents grvTodasAgencias As DataGridView
    Friend WithEvents txtPacotesDisponiveis As TextBox
    Friend WithEvents txtAgendamentos As TextBox
    Friend WithEvents btnBuscarPacotes As Button
    Friend WithEvents btnBuscarAgendamentos As Button
End Class
