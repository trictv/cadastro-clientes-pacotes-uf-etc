<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTodosAgendamentos
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
        Me.grvTodosDestinos = New System.Windows.Forms.DataGridView()
        Me.btnAtualizar = New System.Windows.Forms.Button()
        CType(Me.grvTodosDestinos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grvTodosDestinos
        '
        Me.grvTodosDestinos.AllowUserToAddRows = False
        Me.grvTodosDestinos.AllowUserToDeleteRows = False
        Me.grvTodosDestinos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grvTodosDestinos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.grvTodosDestinos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grvTodosDestinos.Location = New System.Drawing.Point(12, 74)
        Me.grvTodosDestinos.Name = "grvTodosDestinos"
        Me.grvTodosDestinos.ReadOnly = True
        Me.grvTodosDestinos.Size = New System.Drawing.Size(776, 364)
        Me.grvTodosDestinos.TabIndex = 60
        '
        'btnAtualizar
        '
        Me.btnAtualizar.Location = New System.Drawing.Point(12, 13)
        Me.btnAtualizar.Name = "btnAtualizar"
        Me.btnAtualizar.Size = New System.Drawing.Size(776, 55)
        Me.btnAtualizar.TabIndex = 61
        Me.btnAtualizar.Text = "Atualizar"
        Me.btnAtualizar.UseVisualStyleBackColor = True
        '
        'frmTodosAgendamentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnAtualizar)
        Me.Controls.Add(Me.grvTodosDestinos)
        Me.Name = "frmTodosAgendamentos"
        Me.Text = "frmTodosAgendamentos"
        CType(Me.grvTodosDestinos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grvTodosDestinos As DataGridView
    Friend WithEvents btnAtualizar As Button
End Class
