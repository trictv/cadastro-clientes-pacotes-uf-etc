Imports System.Data.SqlClient
Imports WindowsApp1.Agendamento
Public Class frmTodosClientes
    Private Sub CadastrarClientesToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAtualizar.Click
        TodosClientes()
    End Sub

    Private Sub TodosClientes()

        Using con As SqlConnection = Dados.dados.GetConnectionSQServer

            Try
                con.Open()
                Dim sql As String = "SELECT * FROM Clientes"
                Dim cmd As SqlCommand = New SqlCommand(sql, con)
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                grvTodosClientes.DataSource = dt

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End Using
    End Sub

    Private Sub frmTodosClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub grvTodosClientes_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles grvTodosClientes.MouseDoubleClick
        Dim objeto As New Agendamento

        objeto.Nome = grvTodosClientes.Rows.Item(grvTodosClientes.CurrentCell.RowIndex).Cells.Item(1).Value
        objeto.Cliente = grvTodosClientes.Rows.Item(grvTodosClientes.CurrentCell.RowIndex).Cells.Item(0).Value

        frmAgendamentos.TrazNome(objeto)
        frmAgendamentos.Show()
        MyClass.Close()

    End Sub


End Class