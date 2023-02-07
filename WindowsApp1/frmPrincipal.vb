Public Class frmPrincipal
    Private Sub TodosClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TodosClientesToolStripMenuItem.Click

        frmTodosClientes.ShowDialog()
    End Sub

    Private Sub CadastrarClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastrarClientesToolStripMenuItem.Click

        Form1.ShowDialog()

    End Sub

    Private Sub AgendamentosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgendamentosToolStripMenuItem.Click

    End Sub

    Private Sub PacotesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PacotesToolStripMenuItem.Click
        frmPacotes.Show()

    End Sub

    Private Sub DestinosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DestinosToolStripMenuItem.Click
        frmDestino.Show()
    End Sub

    Private Sub NovoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NovoToolStripMenuItem.Click
        frmAgendamentos.Show()

    End Sub

    Private Sub VerTodosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerTodosToolStripMenuItem.Click
        frmTodosAgendamentos.Show()

    End Sub

    Private Sub AgenciaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgenciaToolStripMenuItem.Click
        frmAgencia.Show()
    End Sub
End Class