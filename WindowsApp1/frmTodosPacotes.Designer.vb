<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTodosPacotes
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
        Me.btnAtualizar = New System.Windows.Forms.Button()
        Me.grvTodosPacotes = New System.Windows.Forms.DataGridView()
        CType(Me.grvTodosPacotes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAtualizar
        '
        Me.btnAtualizar.Location = New System.Drawing.Point(0, 26)
        Me.btnAtualizar.Name = "btnAtualizar"
        Me.btnAtualizar.Size = New System.Drawing.Size(800, 37)
        Me.btnAtualizar.TabIndex = 43
        Me.btnAtualizar.Text = "Atualizar"
        Me.btnAtualizar.UseVisualStyleBackColor = True
        '
        'grvTodosPacotes
        '
        Me.grvTodosPacotes.AllowUserToAddRows = False
        Me.grvTodosPacotes.AllowUserToDeleteRows = False
        Me.grvTodosPacotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grvTodosPacotes.Location = New System.Drawing.Point(0, 69)
        Me.grvTodosPacotes.Name = "grvTodosPacotes"
        Me.grvTodosPacotes.ReadOnly = True
        Me.grvTodosPacotes.Size = New System.Drawing.Size(800, 358)
        Me.grvTodosPacotes.TabIndex = 42
        '
        'frmTodosPacotes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnAtualizar)
        Me.Controls.Add(Me.grvTodosPacotes)
        Me.Name = "frmTodosPacotes"
        Me.Text = "frmTodosPacotes"
        CType(Me.grvTodosPacotes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAtualizar As Button
    Friend WithEvents grvTodosPacotes As DataGridView
End Class
