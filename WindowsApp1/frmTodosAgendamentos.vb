Public Class frmTodosAgendamentos
    Private Sub btnAtualizar_Click(sender As Object, e As EventArgs) Handles btnAtualizar.Click
        Dim todos As New Agendamento

        grvTodosDestinos.DataSource = todos.TodosAgendamentos
    End Sub

    Private Sub grvTodosDestinos_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles grvTodosDestinos.MouseDoubleClick
        Dim objeto As New Agencia
        objeto.Agendamentos = grvTodosDestinos.Rows.Item(grvTodosDestinos.CurrentCell.RowIndex).Cells.Item(0).Value
        frmAgencia.TrazNomeAgendamento(objeto)
        frmAgencia.Show()


    End Sub
End Class