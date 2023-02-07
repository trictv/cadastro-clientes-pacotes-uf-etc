<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.lblId = New System.Windows.Forms.Label()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnBuscarVoltar = New System.Windows.Forms.Button()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSobrenome = New System.Windows.Forms.TextBox()
        Me.txtNDocumento = New System.Windows.Forms.TextBox()
        Me.lblNumeroDocumento = New System.Windows.Forms.Label()
        Me.cbxTipoFJ = New System.Windows.Forms.ComboBox()
        Me.lblTipoFJ = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtTelefone = New System.Windows.Forms.TextBox()
        Me.lblTelefone = New System.Windows.Forms.Label()
        Me.txtCep = New System.Windows.Forms.TextBox()
        Me.lblCep = New System.Windows.Forms.Label()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.lblCidade = New System.Windows.Forms.Label()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.txtPais = New System.Windows.Forms.TextBox()
        Me.lblPais = New System.Windows.Forms.Label()
        Me.txtRua = New System.Windows.Forms.TextBox()
        Me.lblRua = New System.Windows.Forms.Label()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.lblAtivo = New System.Windows.Forms.Label()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.txtBairro = New System.Windows.Forms.TextBox()
        Me.lblBairro = New System.Windows.Forms.Label()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.chkAtivo = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(6, 56)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(100, 20)
        Me.txtID.TabIndex = 0
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(6, 37)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(66, 13)
        Me.lblId.TabIndex = 1
        Me.lblId.Text = "ID CLIENTE"
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Location = New System.Drawing.Point(248, 42)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(35, 13)
        Me.lblNome.TabIndex = 2
        Me.lblNome.Text = "Nome"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnBuscarVoltar)
        Me.GroupBox1.Controls.Add(Me.lblId)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(204, 117)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'btnBuscarVoltar
        '
        Me.btnBuscarVoltar.Location = New System.Drawing.Point(113, 52)
        Me.btnBuscarVoltar.Name = "btnBuscarVoltar"
        Me.btnBuscarVoltar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscarVoltar.TabIndex = 2
        Me.btnBuscarVoltar.Text = "Buscar"
        Me.btnBuscarVoltar.UseVisualStyleBackColor = True
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(251, 59)
        Me.txtNome.MaxLength = 50
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(195, 20)
        Me.txtNome.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(449, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Sobrenome"
        '
        'txtSobrenome
        '
        Me.txtSobrenome.Location = New System.Drawing.Point(452, 59)
        Me.txtSobrenome.MaxLength = 50
        Me.txtSobrenome.Name = "txtSobrenome"
        Me.txtSobrenome.Size = New System.Drawing.Size(195, 20)
        Me.txtSobrenome.TabIndex = 6
        '
        'txtNDocumento
        '
        Me.txtNDocumento.Location = New System.Drawing.Point(655, 59)
        Me.txtNDocumento.MaxLength = 50
        Me.txtNDocumento.Name = "txtNDocumento"
        Me.txtNDocumento.Size = New System.Drawing.Size(99, 20)
        Me.txtNDocumento.TabIndex = 8
        '
        'lblNumeroDocumento
        '
        Me.lblNumeroDocumento.AutoSize = True
        Me.lblNumeroDocumento.Location = New System.Drawing.Point(652, 42)
        Me.lblNumeroDocumento.Name = "lblNumeroDocumento"
        Me.lblNumeroDocumento.Size = New System.Drawing.Size(102, 13)
        Me.lblNumeroDocumento.TabIndex = 7
        Me.lblNumeroDocumento.Text = "Numero Documento"
        '
        'cbxTipoFJ
        '
        Me.cbxTipoFJ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTipoFJ.FormattingEnabled = True
        Me.cbxTipoFJ.Items.AddRange(New Object() {"Fisico", "Juridico"})
        Me.cbxTipoFJ.Location = New System.Drawing.Point(776, 59)
        Me.cbxTipoFJ.Name = "cbxTipoFJ"
        Me.cbxTipoFJ.Size = New System.Drawing.Size(83, 21)
        Me.cbxTipoFJ.TabIndex = 9
        '
        'lblTipoFJ
        '
        Me.lblTipoFJ.AutoSize = True
        Me.lblTipoFJ.Location = New System.Drawing.Point(773, 42)
        Me.lblTipoFJ.Name = "lblTipoFJ"
        Me.lblTipoFJ.Size = New System.Drawing.Size(28, 13)
        Me.lblTipoFJ.TabIndex = 10
        Me.lblTipoFJ.Text = "Tipo"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(251, 126)
        Me.txtEmail.MaxLength = 50
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(195, 20)
        Me.txtEmail.TabIndex = 12
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(248, 109)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(32, 13)
        Me.lblEmail.TabIndex = 11
        Me.lblEmail.Text = "Email"
        '
        'txtTelefone
        '
        Me.txtTelefone.Location = New System.Drawing.Point(452, 126)
        Me.txtTelefone.MaxLength = 15
        Me.txtTelefone.Name = "txtTelefone"
        Me.txtTelefone.Size = New System.Drawing.Size(124, 20)
        Me.txtTelefone.TabIndex = 14
        '
        'lblTelefone
        '
        Me.lblTelefone.AutoSize = True
        Me.lblTelefone.Location = New System.Drawing.Point(449, 109)
        Me.lblTelefone.Name = "lblTelefone"
        Me.lblTelefone.Size = New System.Drawing.Size(49, 13)
        Me.lblTelefone.TabIndex = 13
        Me.lblTelefone.Text = "Telefone"
        '
        'txtCep
        '
        Me.txtCep.Location = New System.Drawing.Point(581, 126)
        Me.txtCep.MaxLength = 9
        Me.txtCep.Name = "txtCep"
        Me.txtCep.Size = New System.Drawing.Size(124, 20)
        Me.txtCep.TabIndex = 16
        '
        'lblCep
        '
        Me.lblCep.AutoSize = True
        Me.lblCep.Location = New System.Drawing.Point(578, 109)
        Me.lblCep.Name = "lblCep"
        Me.lblCep.Size = New System.Drawing.Size(26, 13)
        Me.lblCep.TabIndex = 15
        Me.lblCep.Text = "Cep"
        '
        'txtCidade
        '
        Me.txtCidade.Location = New System.Drawing.Point(710, 126)
        Me.txtCidade.MaxLength = 50
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(124, 20)
        Me.txtCidade.TabIndex = 18
        '
        'lblCidade
        '
        Me.lblCidade.AutoSize = True
        Me.lblCidade.Location = New System.Drawing.Point(707, 109)
        Me.lblCidade.Name = "lblCidade"
        Me.lblCidade.Size = New System.Drawing.Size(40, 13)
        Me.lblCidade.TabIndex = 17
        Me.lblCidade.Text = "Cidade"
        '
        'txtEstado
        '
        Me.txtEstado.Location = New System.Drawing.Point(251, 184)
        Me.txtEstado.MaxLength = 50
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(195, 20)
        Me.txtEstado.TabIndex = 20
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Location = New System.Drawing.Point(248, 167)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(40, 13)
        Me.lblEstado.TabIndex = 19
        Me.lblEstado.Text = "Estado"
        '
        'txtPais
        '
        Me.txtPais.Location = New System.Drawing.Point(452, 184)
        Me.txtPais.MaxLength = 50
        Me.txtPais.Name = "txtPais"
        Me.txtPais.Size = New System.Drawing.Size(124, 20)
        Me.txtPais.TabIndex = 22
        '
        'lblPais
        '
        Me.lblPais.AutoSize = True
        Me.lblPais.Location = New System.Drawing.Point(449, 167)
        Me.lblPais.Name = "lblPais"
        Me.lblPais.Size = New System.Drawing.Size(29, 13)
        Me.lblPais.TabIndex = 21
        Me.lblPais.Text = "País"
        '
        'txtRua
        '
        Me.txtRua.Location = New System.Drawing.Point(581, 184)
        Me.txtRua.MaxLength = 50
        Me.txtRua.Name = "txtRua"
        Me.txtRua.Size = New System.Drawing.Size(124, 20)
        Me.txtRua.TabIndex = 24
        '
        'lblRua
        '
        Me.lblRua.AutoSize = True
        Me.lblRua.Location = New System.Drawing.Point(578, 167)
        Me.lblRua.Name = "lblRua"
        Me.lblRua.Size = New System.Drawing.Size(27, 13)
        Me.lblRua.TabIndex = 23
        Me.lblRua.Text = "Rua"
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(710, 184)
        Me.txtNumero.MaxLength = 50
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(124, 20)
        Me.txtNumero.TabIndex = 26
        '
        'lblNumero
        '
        Me.lblNumero.AutoSize = True
        Me.lblNumero.Location = New System.Drawing.Point(707, 167)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(44, 13)
        Me.lblNumero.TabIndex = 25
        Me.lblNumero.Text = "Número"
        '
        'lblAtivo
        '
        Me.lblAtivo.AutoSize = True
        Me.lblAtivo.Location = New System.Drawing.Point(707, 212)
        Me.lblAtivo.Name = "lblAtivo"
        Me.lblAtivo.Size = New System.Drawing.Size(35, 13)
        Me.lblAtivo.TabIndex = 27
        Me.lblAtivo.Text = "status"
        '
        'btnNovo
        '
        Me.btnNovo.Location = New System.Drawing.Point(319, 291)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(92, 36)
        Me.btnNovo.TabIndex = 29
        Me.btnNovo.Text = "Gravar"
        Me.btnNovo.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Enabled = False
        Me.btnExcluir.Location = New System.Drawing.Point(515, 291)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(92, 36)
        Me.btnExcluir.TabIndex = 30
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Enabled = False
        Me.btnCancelar.Location = New System.Drawing.Point(613, 291)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(92, 36)
        Me.btnCancelar.TabIndex = 31
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'txtBairro
        '
        Me.txtBairro.Location = New System.Drawing.Point(251, 229)
        Me.txtBairro.MaxLength = 50
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(124, 20)
        Me.txtBairro.TabIndex = 35
        '
        'lblBairro
        '
        Me.lblBairro.AutoSize = True
        Me.lblBairro.Location = New System.Drawing.Point(248, 212)
        Me.lblBairro.Name = "lblBairro"
        Me.lblBairro.Size = New System.Drawing.Size(34, 13)
        Me.lblBairro.TabIndex = 34
        Me.lblBairro.Text = "Bairro"
        '
        'btnEditar
        '
        Me.btnEditar.Enabled = False
        Me.btnEditar.Location = New System.Drawing.Point(417, 291)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(92, 36)
        Me.btnEditar.TabIndex = 36
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'chkAtivo
        '
        Me.chkAtivo.AutoSize = True
        Me.chkAtivo.Location = New System.Drawing.Point(710, 229)
        Me.chkAtivo.Name = "chkAtivo"
        Me.chkAtivo.Size = New System.Drawing.Size(58, 17)
        Me.chkAtivo.TabIndex = 37
        Me.chkAtivo.Text = "Inativo"
        Me.chkAtivo.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(893, 363)
        Me.Controls.Add(Me.chkAtivo)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.txtBairro)
        Me.Controls.Add(Me.lblBairro)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.lblAtivo)
        Me.Controls.Add(Me.txtNumero)
        Me.Controls.Add(Me.lblNumero)
        Me.Controls.Add(Me.txtRua)
        Me.Controls.Add(Me.lblRua)
        Me.Controls.Add(Me.txtPais)
        Me.Controls.Add(Me.lblPais)
        Me.Controls.Add(Me.txtEstado)
        Me.Controls.Add(Me.lblEstado)
        Me.Controls.Add(Me.txtCidade)
        Me.Controls.Add(Me.lblCidade)
        Me.Controls.Add(Me.txtCep)
        Me.Controls.Add(Me.lblCep)
        Me.Controls.Add(Me.txtTelefone)
        Me.Controls.Add(Me.lblTelefone)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblTipoFJ)
        Me.Controls.Add(Me.cbxTipoFJ)
        Me.Controls.Add(Me.txtNDocumento)
        Me.Controls.Add(Me.lblNumeroDocumento)
        Me.Controls.Add(Me.txtSobrenome)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblNome)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtID As TextBox
    Friend WithEvents lblId As Label
    Friend WithEvents lblNome As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnBuscarVoltar As Button
    Friend WithEvents txtNome As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSobrenome As TextBox
    Friend WithEvents txtNDocumento As TextBox
    Friend WithEvents lblNumeroDocumento As Label
    Friend WithEvents cbxTipoFJ As ComboBox
    Friend WithEvents lblTipoFJ As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtTelefone As TextBox
    Friend WithEvents lblTelefone As Label
    Friend WithEvents txtCep As TextBox
    Friend WithEvents lblCep As Label
    Friend WithEvents txtCidade As TextBox
    Friend WithEvents lblCidade As Label
    Friend WithEvents txtEstado As TextBox
    Friend WithEvents lblEstado As Label
    Friend WithEvents txtPais As TextBox
    Friend WithEvents lblPais As Label
    Friend WithEvents txtRua As TextBox
    Friend WithEvents lblRua As Label
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents lblNumero As Label
    Friend WithEvents lblAtivo As Label
    Friend WithEvents btnNovo As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents txtBairro As TextBox
    Friend WithEvents lblBairro As Label
    Friend WithEvents btnEditar As Button
    Friend WithEvents chkAtivo As CheckBox
End Class
