<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrincipal
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CadastrarClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TodosClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PacotesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgendamentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DestinosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NovoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerTodosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgenciaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastrarClientesToolStripMenuItem, Me.TodosClientesToolStripMenuItem, Me.PacotesToolStripMenuItem, Me.AgendamentosToolStripMenuItem, Me.DestinosToolStripMenuItem, Me.AgenciaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CadastrarClientesToolStripMenuItem
        '
        Me.CadastrarClientesToolStripMenuItem.Name = "CadastrarClientesToolStripMenuItem"
        Me.CadastrarClientesToolStripMenuItem.Size = New System.Drawing.Size(114, 20)
        Me.CadastrarClientesToolStripMenuItem.Text = "Cadastrar Clientes"
        '
        'TodosClientesToolStripMenuItem
        '
        Me.TodosClientesToolStripMenuItem.Name = "TodosClientesToolStripMenuItem"
        Me.TodosClientesToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.TodosClientesToolStripMenuItem.Text = "Todos Clientes"
        '
        'PacotesToolStripMenuItem
        '
        Me.PacotesToolStripMenuItem.Name = "PacotesToolStripMenuItem"
        Me.PacotesToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.PacotesToolStripMenuItem.Text = "Pacotes"
        '
        'AgendamentosToolStripMenuItem
        '
        Me.AgendamentosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovoToolStripMenuItem, Me.VerTodosToolStripMenuItem})
        Me.AgendamentosToolStripMenuItem.Name = "AgendamentosToolStripMenuItem"
        Me.AgendamentosToolStripMenuItem.Size = New System.Drawing.Size(98, 20)
        Me.AgendamentosToolStripMenuItem.Text = "agendamentos"
        '
        'DestinosToolStripMenuItem
        '
        Me.DestinosToolStripMenuItem.Name = "DestinosToolStripMenuItem"
        Me.DestinosToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.DestinosToolStripMenuItem.Text = "Destinos"
        '
        'NovoToolStripMenuItem
        '
        Me.NovoToolStripMenuItem.Name = "NovoToolStripMenuItem"
        Me.NovoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.NovoToolStripMenuItem.Text = "novo"
        '
        'VerTodosToolStripMenuItem
        '
        Me.VerTodosToolStripMenuItem.Name = "VerTodosToolStripMenuItem"
        Me.VerTodosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.VerTodosToolStripMenuItem.Text = "ver todos"
        '
        'AgenciaToolStripMenuItem
        '
        Me.AgenciaToolStripMenuItem.Name = "AgenciaToolStripMenuItem"
        Me.AgenciaToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.AgenciaToolStripMenuItem.Text = "agencia"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmPrincipal"
        Me.Text = "frmPrincipal"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CadastrarClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TodosClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PacotesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgendamentosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DestinosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NovoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerTodosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgenciaToolStripMenuItem As ToolStripMenuItem
End Class
