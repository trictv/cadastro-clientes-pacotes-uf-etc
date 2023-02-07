Public Class frmAgendamentos
    Private Sub btnAdicionar_Click(sender As Object, e As EventArgs) Handles btnAdicionar.Click

        grvTodosAgendamentos.Rows.Add(txtID.Text, txtClliente.Text, txtPacotes.Text, txtData.Text, chkPago.Checked, IdCliente)


    End Sub
    Private Sub btnBuscarClientes_Click(sender As Object, e As EventArgs) Handles btnBuscarClientes.Click
        MyClass.Hide()
        frmTodosClientes.ShowDialog()

    End Sub

    Dim IdCliente, IdPAcote As Integer
    Public Sub TrazNome(ByRef agendamento As Agendamento)
        txtClliente.Text = agendamento.Nome
        IdCliente = agendamento.Cliente

    End Sub

    Public Sub TrazNomePacote(ByVal agendamento As Agendamento)
        IdPAcote = agendamento.NomePacote
        txtPacotes.Text = agendamento.Pacotes
    End Sub
    Private Sub btnBuscarPacotes_Click(sender As Object, e As EventArgs) Handles btnBuscarPacotes.Click
        MyClass.Hide()
        frmPacotes.Show()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        LimpaControle()
    End Sub

    Public Sub LimpaControle()
        txtClliente.Text = ""
        txtData.Text = ""
        txtID.Text = ""
        txtPacotes.Text = ""
        chkPago.Checked = False
        btnAdicionar.Enabled = True
        agendamentos.Tipo = Agendamento.eStatus.insert
        Try
            grvTodosAgendamentos.Rows.Clear()
        Catch ex As Exception
            grvTodosAgendamentos.DataSource = ""
            grvTodosAgendamentos.Columns.AddRange(ID, Column1, NOMECLIENTE, PacoteTurismo, data, PAGO, Column2)
        End Try

    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        ExcluirAgendamento(Integer.Parse(txtID.Text.Trim))
        txtID.Text = ""
        MessageBox.Show("Agendamento excluido")
        LimpaControle()
    End Sub

    Private Sub ExcluirAgendamento(ByVal IdAgendamento As Integer)

        Dim objDados As New Agendamento()
        objDados.ExcluirAgendamento(IdAgendamento)

    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        If VerificaVazio() = False Then
            MessageBox.Show("Adicione Agendamento")
            Exit Sub
        End If
        If
        Gravar()
        MessageBox.Show("Agendamento Salvo")
        LimpaControle()

    End Sub

    Public Function VerificaVazio() As Boolean
        If grvTodosAgendamentos.Rows.Count <= 0 Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Sub Gravar()

        Dim grid As Integer = 0
        Try
            For i As Integer = 0 To grvTodosAgendamentos.Rows.Count Step 1
                Dim objeto As New Agendamento
                objeto.Pacotes = grvTodosAgendamentos.Rows(i).Cells(6).Value
                objeto.Cliente = grvTodosAgendamentos.Rows(i).Cells(5).Value
                objeto.Data = grvTodosAgendamentos.Rows(i).Cells(3).Value
                objeto.Pago = grvTodosAgendamentos.Rows(i).Cells(4).Value
                objeto.GravarAgendamento(objeto)

            Next
        Catch ex As Exception

        End Try


    End Sub
    Dim agendamentos As New Agendamento
    Private Sub btnBuscarAgendamento_Click(sender As Object, e As EventArgs) Handles btnBuscarAgendamento.Click

        agendamentos.Id = Integer.Parse(txtIdAgendamento.Text)
        agendamentos.ConsultarAgendamentosId()
        If agendamentos.ConsultarAgendamentosId.Rows.Count = 0 Then
            MessageBox.Show("Não encontrei")
        End If
        grvTodosAgendamentos.Columns.Clear()
        txtClliente.Text = agendamentos.Cliente
        txtData.Text = agendamentos.Data
        txtPacotes.Text = agendamentos.Pacotes
        chkPago.Checked = agendamentos.Pago
        btnAdicionar.Enabled = False
        grvTodosAgendamentos.DataSource = agendamentos.ConsultarAgendamentosId
        agendamentos.Tipo = Agendamento.eStatus.update
    End Sub

    Private Sub grvTodosAgendamentos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grvTodosAgendamentos.CellContentClick
        agendamentos.Tipo = Agendamento.eStatus.insert
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        agendamentos.Cliente = Integer.Parse(txtID.Text)
        agendamentos.ConsultarAgendamentos()
        If agendamentos.ConsultarAgendamentos.Rows.Count = 0 Then
            MessageBox.Show("Não encontrei")
        End If
        grvTodosAgendamentos.Columns.Clear()
        grvTodosAgendamentos.DataSource = agendamentos.ConsultarAgendamentos
        'grvTodosAgendamentos.Columns(0).Name = "yg"

        'grvTodosAgendamentos.Columns.Add(dataGridViewColumn:=NOMECLIENTE)

    End Sub
End Class