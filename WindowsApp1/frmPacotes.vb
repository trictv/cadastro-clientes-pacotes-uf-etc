Imports System.Data.SqlClient

Public Class frmPacotes
    Private Sub txtBuscarDestinos_Click(sender As Object, e As EventArgs) Handles txtBuscarDestinos.Click
        frmDestino.Show()
        MyClass.Hide()
    End Sub
    Dim CodigoDestino As Integer
    Public Sub TrazNome(ByVal destino As PacoteTurismo)
        CodigoDestino = destino.Destino
        txtDestino.Text = destino.NomeDestino
    End Sub

    Private Sub grvTodosClientes_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles grvTodosClientes.MouseDoubleClick
        Dim objeto As New Agendamento

        objeto.NomePacote = grvTodosClientes.Rows.Item(grvTodosClientes.CurrentCell.RowIndex).Cells.Item(0).Value
        objeto.Pacotes = grvTodosClientes.Rows.Item(grvTodosClientes.CurrentCell.RowIndex).Cells.Item(0).Value

        frmAgendamentos.TrazNomePacote(objeto)
        frmAgendamentos.Show()
        MyClass.Close()
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        ExcluirPacote(Integer.Parse(txtID.Text))

    End Sub
    Private Sub ExcluirPacote(ByVal IdCliente As Integer)

        Dim objDados As New PacoteTurismo()
        objDados.ExcluirPacote(IdCliente)

    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        If Not VerificaVazio() Then
            Exit Sub
        End If
        Gravar()
        MessageBox.Show("cliente salvo")
        LimpaControle()
        TodosPacotes()

    End Sub

    Public Function VerificaVazio() As Boolean
        If txtDestino.Text <> "" And txtDiarias.Text <> "" And
           txtData.Text <> "" And txtPreco.Text <> "" And cbxTipoPasseio.Text <> "" Then
            Return True
        Else
            MessageBox.Show("POR FAVOR PREENCHER TODOS OS CAMPOS!")
            Return False
        End If
    End Function
    Private Sub Gravar()
        Dim objeto As New PacoteTurismo
        objeto.DataViagem = txtData.Text
        objeto.Diarias = Integer.Parse(txtDiarias.Text)
        objeto.Preco = Decimal.Parse(txtPreco.Text)
        objeto.Destino = CodigoDestino
        objeto.TipoPasseio = cbxTipoPasseio.SelectedIndex
        objeto.GravarPacote(objeto)
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        LimpaControle()
    End Sub
    Public Sub LimpaControle()
        txtID.Text = ""
        txtDiarias.Text = ""
        txtDestino.Text = ""
        txtData.Text = ""
        cbxTipoPasseio.SelectedIndex = -1
        'grvTodosClientes.Rows.Clear()
        'grvTodosClientes.Columns.Clear()
        grvTodosClientes.DataSource = ""

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim objeto As New PacoteTurismo
        objeto.Numero = Integer.Parse(txtID.Text.Trim)
        objeto.ConsultarPacote()
        If objeto.ConsultarPacote.Rows.Count = 0 Then
            MessageBox.Show("Cliente Não Cadastrado")
            txtID.Text = ""
            Exit Sub
        End If
        txtData.Text = objeto.DataViagem
        txtDestino.Text = objeto.Destino
        txtDiarias.Text = objeto.Diarias
        txtPreco.Text = objeto.Preco
        cbxTipoPasseio.SelectedIndex = objeto.TipoPasseio
        ' grvTodosClientes.DataSource = objeto
        'DataGridView1.DataSource = objeto.ConsultarPacote
        TodosPacotes()
    End Sub

    Private Sub TodosPacotes()

        Using con As SqlConnection = Dados.dados.GetConnectionSQServer

            Try
                con.Open()
                ' Dim sql As String = "SELECT * FROM PacoteTurismo"
                Dim sql As String = "SELECT PacoteTurismo.Numero, PacoteTurismo.TipoPasseio, PacoteTurismo.DataViagem,PacoteTurismo.Diarias,PacoteTurismo.Preco,PacoteTurismo.Destinos as id_destino, Destino.Uf as UF_destino
FROM ((PacoteTurismo
INNER JOIN Destino ON Destino.uf = Destino.Uf)) where PacoteTurismo.Numero > 0"
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

    Private Sub txtID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtID.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then

            e.Handled = True

        End If
    End Sub

    Private Sub frmPacotes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TodosPacotes()
    End Sub
End Class