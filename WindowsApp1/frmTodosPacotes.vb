Public Class frmTodosPacotes
    Private Sub btnAtualizar_Click(sender As Object, e As EventArgs) Handles btnAtualizar.Click
        Dim objeto As New PacoteTurismo
        grvTodosPacotes.DataSource = objeto.TodosPacotes
    End Sub

    Private Sub grvTodosPacotes_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles grvTodosPacotes.MouseDoubleClick
        Dim objeto As New Agencia

        objeto.PacotesDisponiveis = grvTodosPacotes.Rows.Item(grvTodosPacotes.CurrentCell.RowIndex).Cells.Item(0).Value
        'objeto.Cliente = grvTodosPacotes.Rows.Item(grvTodosPacotes.CurrentCell.RowIndex).Cells.Item(0).Value


        frmAgencia.TrazNome(objeto)
        frmAgencia.Show()
        MyClass.Close()
    End Sub
End Class