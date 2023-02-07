<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPacotes
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.lblId = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.cbxTipoPasseio = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtData = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDiarias = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDestino = New System.Windows.Forms.TextBox()
        Me.txtBuscarDestinos = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.grvTodosClientes = New System.Windows.Forms.DataGridView()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPreco = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grvTodosClientes, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(118, 54)
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
        Me.lblId.Size = New System.Drawing.Size(101, 13)
        Me.lblId.TabIndex = 1
        Me.lblId.Text = "NUMERO PACOTE"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(6, 56)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(100, 20)
        Me.txtID.TabIndex = 0
        '
        'cbxTipoPasseio
        '
        Me.cbxTipoPasseio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTipoPasseio.FormattingEnabled = True
        Me.cbxTipoPasseio.Items.AddRange(New Object() {"Excursao", "Particular", "Outros"})
        Me.cbxTipoPasseio.Location = New System.Drawing.Point(222, 41)
        Me.cbxTipoPasseio.Name = "cbxTipoPasseio"
        Me.cbxTipoPasseio.Size = New System.Drawing.Size(121, 21)
        Me.cbxTipoPasseio.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(222, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Tipo Passeio"
        '
        'txtData
        '
        Me.txtData.Location = New System.Drawing.Point(355, 41)
        Me.txtData.Mask = "00/00/0000"
        Me.txtData.Name = "txtData"
        Me.txtData.Size = New System.Drawing.Size(100, 20)
        Me.txtData.TabIndex = 7
        Me.txtData.ValidatingType = GetType(Date)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(352, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Data Viagem"
        '
        'txtDiarias
        '
        Me.txtDiarias.Location = New System.Drawing.Point(225, 91)
        Me.txtDiarias.Name = "txtDiarias"
        Me.txtDiarias.Size = New System.Drawing.Size(118, 20)
        Me.txtDiarias.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(222, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Diarias"
        '
        'txtDestino
        '
        Me.txtDestino.Enabled = False
        Me.txtDestino.Location = New System.Drawing.Point(355, 91)
        Me.txtDestino.Name = "txtDestino"
        Me.txtDestino.Size = New System.Drawing.Size(118, 20)
        Me.txtDestino.TabIndex = 11
        '
        'txtBuscarDestinos
        '
        Me.txtBuscarDestinos.Location = New System.Drawing.Point(479, 91)
        Me.txtBuscarDestinos.Name = "txtBuscarDestinos"
        Me.txtBuscarDestinos.Size = New System.Drawing.Size(75, 20)
        Me.txtBuscarDestinos.TabIndex = 3
        Me.txtBuscarDestinos.Text = "Buscar"
        Me.txtBuscarDestinos.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(352, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Destino"
        '
        'grvTodosClientes
        '
        Me.grvTodosClientes.AllowUserToAddRows = False
        Me.grvTodosClientes.AllowUserToDeleteRows = False
        Me.grvTodosClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grvTodosClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.grvTodosClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grvTodosClientes.Location = New System.Drawing.Point(12, 135)
        Me.grvTodosClientes.Name = "grvTodosClientes"
        Me.grvTodosClientes.ReadOnly = True
        Me.grvTodosClientes.Size = New System.Drawing.Size(675, 313)
        Me.grvTodosClientes.TabIndex = 42
        '
        'btnSalvar
        '
        Me.btnSalvar.Location = New System.Drawing.Point(572, 40)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(75, 21)
        Me.btnSalvar.TabIndex = 61
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Location = New System.Drawing.Point(572, 95)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(75, 21)
        Me.btnExcluir.TabIndex = 60
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(572, 68)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 21)
        Me.btnCancelar.TabIndex = 59
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(462, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = "Preco"
        '
        'txtPreco
        '
        Me.txtPreco.Location = New System.Drawing.Point(465, 41)
        Me.txtPreco.Name = "txtPreco"
        Me.txtPreco.Size = New System.Drawing.Size(89, 20)
        Me.txtPreco.TabIndex = 62
        '
        'frmPacotes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(740, 490)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtPreco)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.grvTodosClientes)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtBuscarDestinos)
        Me.Controls.Add(Me.txtDestino)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDiarias)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtData)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbxTipoPasseio)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmPacotes"
        Me.Text = "frmPacotes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grvTodosClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents lblId As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents cbxTipoPasseio As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtData As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDiarias As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDestino As TextBox
    Friend WithEvents txtBuscarDestinos As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents grvTodosClientes As DataGridView
    Friend WithEvents btnSalvar As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPreco As TextBox
End Class
