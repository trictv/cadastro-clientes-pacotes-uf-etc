Public Class frmDestino
    Private Sub grvTodosClientes_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles grvTodosDestinos.MouseDoubleClick
        Dim destino As New PacoteTurismo


        destino.Destino = grvTodosDestinos.Rows.Item(grvTodosDestinos.CurrentCell.RowIndex).Cells.Item(0).Value
        destino.NomeDestino = grvTodosDestinos.Rows.Item(grvTodosDestinos.CurrentCell.RowIndex).Cells.Item(2).Value

        frmPacotes.TrazNome(destino)
        frmPacotes.Show()
        MyClass.Close()
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        If VerificaVazio() = False Then
            MessageBox.Show("algum campo vazio")
            Exit Sub
        End If
        Gravar()

    End Sub
    Private Sub Gravar()

        Dim objeto As New Destino
        objeto.Cidade = txtCidade.Text.Trim()
        objeto.Uf = cboUf.Text.Trim()
        objeto.GravarDestino(objeto)

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        LimpaControle()
    End Sub

    Public Function VerificaVazio() As Boolean
        If txtCidade.Text <> "" And cboUf.Text <> "" Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Sub LimpaControle()
       ' grvTodosDestinos.Rows.Clear()
        'grvTodosDestinos.Columns.Clear()
        txtCidade.Text = ""
        txtID.Text = ""
        cboUf.SelectedIndex = -1
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        ExcluiDestino(Integer.Parse(txtID.Text.Trim))
    End Sub
    Private Sub ExcluiDestino(ByVal IdCliente As Integer)
        Dim objDados As New Destino()
        objDados.ExcluirDestino(IdCliente)
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim objeto As New Destino
        objeto.Codigo = Integer.Parse(txtID.Text.Trim)
        objeto.ConsultarDestino()
        If objeto.ConsultarDestino.Rows.Count = 0 Then
            MessageBox.Show("Destino Não Cadastrado")
            txtID.Text = ""
            Exit Sub
        End If
        txtCidade.Text = objeto.Cidade
        cboUf.Text = objeto.Uf
    End Sub

    Private Sub frmDestino_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objeto As New Destino
        grvTodosDestinos.DataSource = objeto.TodosDestinos

    End Sub

    Private Sub btnCancelar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles btnCancelar.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub
End Class