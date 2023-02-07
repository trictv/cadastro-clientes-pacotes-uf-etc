Imports System.Data.SqlClient
Imports WindowsApp1.Dados.dados
Public Class Agencia
    Private _id As Integer
    Private _nome As String
    Private _dataFundacao As String
    Private _pacotesDisponieis As Integer
    Private _agendamentos As Integer

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property
    Public Property Nome As String
        Get
            Return _nome
        End Get
        Set(value As String)
            _nome = value
        End Set
    End Property
    Public Property DataFundacao As Date
        Get
            Return _dataFundacao
        End Get
        Set(value As Date)
            _dataFundacao = value
        End Set
    End Property
    Public Property PacotesDisponiveis As Integer
        Get
            Return _pacotesDisponieis
        End Get
        Set(value As Integer)
            _pacotesDisponieis = value
        End Set
    End Property
    Public Property Agendamentos As Integer
        Get
            Return _agendamentos
        End Get
        Set(value As Integer)
            _agendamentos = value
        End Set
    End Property


    Public strInstrucao As String = String.Empty
    Public objConexao As New SqlConnection(StringConexao)
    Public objCommand As New SqlCommand(strInstrucao, objConexao)

    Public Sub GravarAgencia(ByVal agencia As Agencia)

        'strInstrucao = $"INSERT INTO Agencia VALUES ({agencia.Nome},{agencia.DataFundacao}, {agencia.PacotesDisponiveis}, {agencia.Agendamentos})"
        strInstrucao = $"INSERT INTO Agencia VALUES (@Nome, @DataFundacao, @PacotesDisponiveis, @Agendamentos)"
        objCommand.CommandText = strInstrucao
        objCommand.Connection = objConexao
        objCommand.Parameters.AddWithValue("@Nome", agencia.Nome)
        objCommand.Parameters.AddWithValue("@DataFundacao", agencia.DataFundacao)
        objCommand.Parameters.AddWithValue("@PacotesDisponiveis", agencia.PacotesDisponiveis)
        objCommand.Parameters.AddWithValue("@Agendamentos", agencia.Agendamentos)

        objConexao.Open()
        objCommand.ExecuteNonQuery()
        objConexao.Close()
    End Sub


    Public Enum eStatus
        insert = 0
        update = 1
    End Enum
    Private _tipo As eStatus
    Public Property Tipo As eStatus
        Get
            Return _tipo
        End Get
        Set(value As eStatus)
            _tipo = value
        End Set
    End Property
    Public Sub ExcluirAgencia(ByVal IdAgencia As Integer)

        strInstrucao = "DELETE FROM Agencia WHERE Id = @Id"
        objCommand.CommandText = strInstrucao
        objCommand.Connection = objConexao
        objCommand.Parameters.AddWithValue("@Id", IdAgencia)

        objConexao.Open()
        objCommand.ExecuteNonQuery()
        objConexao.Close()

    End Sub

    Public Function TodasAgencias() As DataTable

        Dim dt As New DataTable
        Dim ds As New DataSet()
        strInstrucao = $"SELECT * FROM Agencia"
        objCommand.CommandText = strInstrucao
        objCommand.Connection = objConexao

        objConexao.Open()
        Dim da As New SqlDataAdapter(objCommand)
        da.Fill(ds)
        dt = ds.Tables(0)
        objConexao.Close()
        Return dt
    End Function

    Public Function ConsultarAgencia() As DataTable

        Dim dt As New DataTable
        Dim ds As New DataSet()
        strInstrucao = $"SELECT * FROM Agencia WHERE Id = {Id}"
        objCommand.CommandText = strInstrucao
        objCommand.Connection = objConexao

        objConexao.Open()
        Dim da As New SqlDataAdapter(objCommand)
        da.Fill(ds)
        dt = ds.Tables(0)
        If dt.Rows.Count <> 0 Then
            Nome = dt(0)("Nome")
            DataFundacao = dt(0)("DataFundacao")
            PacotesDisponiveis = dt(0)("PacotesDisponiveis")
            Agendamentos = dt(0)("Agendamentos")

        End If

        objConexao.Close()
        Return dt

    End Function

    Public Sub UpdateAgencia(ByVal agencia As Agencia)

        strInstrucao = "UPDATE Agencia SET nome=@Nome ,DataFundacao=@DataFundacao,PacotesDisponiveis= @PacotesDisponiveis,Agendamentos= @Agendamentos  WHERE Id = @Id"
        objCommand.CommandText = strInstrucao
        objCommand.Connection = objConexao
        objCommand.Parameters.AddWithValue("@Nome", agencia.Nome)
        objCommand.Parameters.AddWithValue("@DataFundacao", agencia.DataFundacao)
        objCommand.Parameters.AddWithValue("@PacotesDisponiveis", agencia.PacotesDisponiveis)
        objCommand.Parameters.AddWithValue("@Agendamentos", agencia.Agendamentos)
        objCommand.Parameters.AddWithValue("@Id", agencia.Id)
        objConexao.Open()
        objCommand.ExecuteNonQuery()
        objConexao.Close()

    End Sub
End Class
