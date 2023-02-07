<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgendamentos
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
        Me.grvTodosAgendamentos = New System.Windows.Forms.DataGridView()
        Me.txtClliente = New System.Windows.Forms.TextBox()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.btnBuscarClientes = New System.Windows.Forms.Button()
        Me.btnBuscarPacotes = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPacotes = New System.Windows.Forms.TextBox()
        Me.chkPago = New System.Windows.Forms.CheckBox()
        Me.txtData = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAdicionar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMECLIENTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PacoteTurismo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.data = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PAGO = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnBuscarAgendamento = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtIdAgendamento = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grvTodosAgendamentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnBuscarAgendamento)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtIdAgendamento)
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
        Me.btnBuscar.Location = New System.Drawing.Point(118, 32)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(6, 15)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(66, 13)
        Me.lblId.TabIndex = 1
        Me.lblId.Text = "ID CLIENTE"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(6, 34)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(100, 20)
        Me.txtID.TabIndex = 0
        '
        'grvTodosAgendamentos
        '
        Me.grvTodosAgendamentos.AllowUserToAddRows = False
        Me.grvTodosAgendamentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grvTodosAgendamentos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.grvTodosAgendamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grvTodosAgendamentos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Column1, Me.NOMECLIENTE, Me.PacoteTurismo, Me.data, Me.PAGO, Me.Column2})
        Me.grvTodosAgendamentos.Location = New System.Drawing.Point(8, 135)
        Me.grvTodosAgendamentos.Name = "grvTodosAgendamentos"
        Me.grvTodosAgendamentos.ReadOnly = True
        Me.grvTodosAgendamentos.Size = New System.Drawing.Size(784, 346)
        Me.grvTodosAgendamentos.TabIndex = 41
        '
        'txtClliente
        '
        Me.txtClliente.Enabled = False
        Me.txtClliente.Location = New System.Drawing.Point(225, 28)
        Me.txtClliente.Name = "txtClliente"
        Me.txtClliente.Size = New System.Drawing.Size(135, 20)
        Me.txtClliente.TabIndex = 42
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Location = New System.Drawing.Point(222, 12)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(39, 13)
        Me.lblNome.TabIndex = 43
        Me.lblNome.Text = "Cliente"
        '
        'btnBuscarClientes
        '
        Me.btnBuscarClientes.Location = New System.Drawing.Point(366, 28)
        Me.btnBuscarClientes.Name = "btnBuscarClientes"
        Me.btnBuscarClientes.Size = New System.Drawing.Size(75, 21)
        Me.btnBuscarClientes.TabIndex = 3
        Me.btnBuscarClientes.Text = "Buscar"
        Me.btnBuscarClientes.UseVisualStyleBackColor = True
        '
        'btnBuscarPacotes
        '
        Me.btnBuscarPacotes.Location = New System.Drawing.Point(366, 80)
        Me.btnBuscarPacotes.Name = "btnBuscarPacotes"
        Me.btnBuscarPacotes.Size = New System.Drawing.Size(75, 21)
        Me.btnBuscarPacotes.TabIndex = 44
        Me.btnBuscarPacotes.Text = "Buscar"
        Me.btnBuscarPacotes.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(222, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Pacotes"
        '
        'txtPacotes
        '
        Me.txtPacotes.Enabled = False
        Me.txtPacotes.Location = New System.Drawing.Point(225, 80)
        Me.txtPacotes.Name = "txtPacotes"
        Me.txtPacotes.Size = New System.Drawing.Size(135, 20)
        Me.txtPacotes.TabIndex = 45
        '
        'chkPago
        '
        Me.chkPago.AutoSize = True
        Me.chkPago.Location = New System.Drawing.Point(454, 80)
        Me.chkPago.Name = "chkPago"
        Me.chkPago.Size = New System.Drawing.Size(51, 17)
        Me.chkPago.TabIndex = 47
        Me.chkPago.Text = "Pago"
        Me.chkPago.UseVisualStyleBackColor = True
        '
        'txtData
        '
        Me.txtData.Location = New System.Drawing.Point(451, 28)
        Me.txtData.Mask = "00/00/0000"
        Me.txtData.Name = "txtData"
        Me.txtData.Size = New System.Drawing.Size(100, 20)
        Me.txtData.TabIndex = 49
        Me.txtData.ValidatingType = GetType(Date)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(451, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Data"
        '
        'btnAdicionar
        '
        Me.btnAdicionar.Location = New System.Drawing.Point(596, 18)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(75, 21)
        Me.btnAdicionar.TabIndex = 51
        Me.btnAdicionar.Text = "Adicionar"
        Me.btnAdicionar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(596, 45)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 21)
        Me.btnCancelar.TabIndex = 52
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Location = New System.Drawing.Point(596, 72)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(75, 21)
        Me.btnExcluir.TabIndex = 53
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnSalvar
        '
        Me.btnSalvar.Location = New System.Drawing.Point(596, 99)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(75, 21)
        Me.btnSalvar.TabIndex = 54
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID CLIENTE"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'NOMECLIENTE
        '
        Me.NOMECLIENTE.HeaderText = "NOME CLIENTE"
        Me.NOMECLIENTE.Name = "NOMECLIENTE"
        Me.NOMECLIENTE.ReadOnly = True
        '
        'PacoteTurismo
        '
        Me.PacoteTurismo.HeaderText = "PACOTE"
        Me.PacoteTurismo.Name = "PacoteTurismo"
        Me.PacoteTurismo.ReadOnly = True
        '
        'data
        '
        Me.data.HeaderText = "DATA"
        Me.data.Name = "data"
        Me.data.ReadOnly = True
        '
        'PAGO
        '
        Me.PAGO.HeaderText = "PAGO"
        Me.PAGO.Name = "PAGO"
        Me.PAGO.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "ID PACOTE"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'btnBuscarAgendamento
        '
        Me.btnBuscarAgendamento.Location = New System.Drawing.Point(118, 78)
        Me.btnBuscarAgendamento.Name = "btnBuscarAgendamento"
        Me.btnBuscarAgendamento.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscarAgendamento.TabIndex = 5
        Me.btnBuscarAgendamento.Text = "Buscar"
        Me.btnBuscarAgendamento.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "ID AGENDAMENTO"
        '
        'txtIdAgendamento
        '
        Me.txtIdAgendamento.Location = New System.Drawing.Point(6, 80)
        Me.txtIdAgendamento.Name = "txtIdAgendamento"
        Me.txtIdAgendamento.Size = New System.Drawing.Size(100, 20)
        Me.txtIdAgendamento.TabIndex = 3
        '
        'frmAgendamentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 493)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAdicionar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtData)
        Me.Controls.Add(Me.chkPago)
        Me.Controls.Add(Me.btnBuscarPacotes)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPacotes)
        Me.Controls.Add(Me.btnBuscarClientes)
        Me.Controls.Add(Me.lblNome)
        Me.Controls.Add(Me.txtClliente)
        Me.Controls.Add(Me.grvTodosAgendamentos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmAgendamentos"
        Me.Text = "Agendamentos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grvTodosAgendamentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents lblId As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents grvTodosAgendamentos As DataGridView
    Friend WithEvents txtClliente As TextBox
    Friend WithEvents lblNome As Label
    Friend WithEvents btnBuscarClientes As Button
    Friend WithEvents btnBuscarPacotes As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPacotes As TextBox
    Friend WithEvents chkPago As CheckBox
    Friend WithEvents txtData As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAdicionar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btnSalvar As Button
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents NOMECLIENTE As DataGridViewTextBoxColumn
    Friend WithEvents PacoteTurismo As DataGridViewTextBoxColumn
    Friend WithEvents data As DataGridViewTextBoxColumn
    Friend WithEvents PAGO As DataGridViewCheckBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents btnBuscarAgendamento As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtIdAgendamento As TextBox
End Class
