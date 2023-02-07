Public Class frmAgencia
    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Gravar()
        LimpaControles()
    End Sub
    Dim objeto As New Agencia
    Public Sub LimpaControles()
        txtID.Text = ""
        txtNome.Text = ""
        txtDataFundacao.Text = ""
        txtAgendamentos.Text = ""
        txtPacotesDisponiveis.Text = ""
        txtID.Focus()
        objeto.Tipo = 0
    End Sub

    Private Sub Gravar()

        'objeto.Id = txtID.Text
        objeto.Nome = txtNome.Text.Trim()
        objeto.DataFundacao = txtDataFundacao.Text.Trim()
        objeto.Agendamentos = Integer.Parse(txtAgendamentos.Text)
        objeto.PacotesDisponiveis = Integer.Parse(txtPacotesDisponiveis.Text)
        If objeto.Tipo = 0 Then
            Dim objeto As New Agencia
            objeto.Nome = txtNome.Text.Trim()
            objeto.DataFundacao = txtDataFundacao.Text.Trim()
            objeto.Agendamentos = Integer.Parse(txtAgendamentos.Text)
            objeto.PacotesDisponiveis = Integer.Parse(txtPacotesDisponiveis.Text)
            objeto.GravarAgencia(objeto)
        Else
            objeto.UpdateAgencia(objeto)
        End If
        '
        grvTodasAgencias.DataSource = objeto.TodasAgencias
        LimpaControles()
        'objeto.Tipo = objeto.eStatus.insert

    End Sub
    Public Sub TrazNome(ByRef objeto As Agencia)
        txtPacotesDisponiveis.Text = objeto.PacotesDisponiveis
        'IdCliente = Agendamento.Cliente
    End Sub
    Public Sub TrazNomeAgendamento(ByRef objeto As Agencia)
        txtAgendamentos.Text = objeto.Agendamentos
        ' IdCliente = agendamento.Cliente

    End Sub
    Private Sub btnBuscarPacotes_Click(sender As Object, e As EventArgs) Handles btnBuscarPacotes.Click
        frmTodosPacotes.Show()
        Me.Hide()
    End Sub

    Private Sub btnBuscarAgendamentos_Click(sender As Object, e As EventArgs) Handles btnBuscarAgendamentos.Click
        frmTodosAgendamentos.Show()
        Me.Hide()
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        ExcluirAgencia(Integer.Parse(txtID.Text.Trim))
        LimpaControles()

    End Sub

    Private Sub ExcluirAgencia(ByVal IdAgencia As Integer)

        Dim objDados As New Agencia()
        objDados.ExcluirAgencia(IdAgencia)
        grvTodasAgencias.DataSource = objDados.TodasAgencias

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        objeto.Id = Integer.Parse(txtID.Text.Trim)

        If objeto.ConsultarAgencia.Rows.Count = 0 Then
            MessageBox.Show("Agencia Não Cadastrada")
            txtID.Text = ""
            Exit Sub
        End If

        txtNome.Text = objeto.Nome
        txtDataFundacao.Text = objeto.DataFundacao
        txtAgendamentos.Text = objeto.Agendamentos
        txtPacotesDisponiveis.Text = objeto.PacotesDisponiveis
        objeto.Tipo = 1
    End Sub

    Private Sub frmAgencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        objeto.Tipo = 0
        grvTodasAgencias.DataSource = objeto.TodasAgencias
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        LimpaControles()
        objeto.Tipo = 0
    End Sub
End Class