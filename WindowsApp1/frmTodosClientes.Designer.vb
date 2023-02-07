<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTodosClientes
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
        Me.grvTodosClientes = New System.Windows.Forms.DataGridView()
        Me.btnAtualizar = New System.Windows.Forms.Button()
        CType(Me.grvTodosClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grvTodosClientes
        '
        Me.grvTodosClientes.AllowUserToAddRows = False
        Me.grvTodosClientes.AllowUserToDeleteRows = False
        Me.grvTodosClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grvTodosClientes.Location = New System.Drawing.Point(0, 89)
        Me.grvTodosClientes.Name = "grvTodosClientes"
        Me.grvTodosClientes.ReadOnly = True
        Me.grvTodosClientes.Size = New System.Drawing.Size(800, 358)
        Me.grvTodosClientes.TabIndex = 40
        '
        'btnAtualizar
        '
        Me.btnAtualizar.Location = New System.Drawing.Point(0, 43)
        Me.btnAtualizar.Name = "btnAtualizar"
        Me.btnAtualizar.Size = New System.Drawing.Size(800, 40)
        Me.btnAtualizar.TabIndex = 41
        Me.btnAtualizar.Text = "Atualizar"
        Me.btnAtualizar.UseVisualStyleBackColor = True
        '
        'frmTodosClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnAtualizar)
        Me.Controls.Add(Me.grvTodosClientes)
        Me.Name = "frmTodosClientes"
        Me.Text = "frmTodosClientes"
        CType(Me.grvTodosClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grvTodosClientes As DataGridView
    Friend WithEvents btnAtualizar As Button
End Class
