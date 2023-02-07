Imports System.Data.SqlClient
Imports WindowsApp1.Dados.dados
Public Class Agendamento
    Private _id As Integer
    Private _cliente As Integer
    Private _data As Date
    Private _pago As Boolean
    Private _pacotes As Integer

    Public Property Id As Integer
        Get
            Return _id

        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property
    Public Property Cliente As Integer
        Get
            Return _cliente
        End Get
        Set(value As Integer)
            _cliente = value
        End Set
    End Property
    Public Property Data As Date
        Get
            Return _data
        End Get
        Set(value As Date)
            _data = value
        End Set
    End Property
    Public Property Pago As Boolean
        Get
            Return _pago
        End Get
        Set(value As Boolean)
            _pago = value
        End Set
    End Property
    Public Property Pacotes As Integer
        Get
            Return _pacotes
        End Get
        Set(value As Integer)
            _pacotes = value
        End Set
    End Property

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
    Public Property Nome As String
    Public strInstrucao As String = String.Empty
    Public objConexao As New SqlConnection(StringConexao)
    Public objCommand As New SqlCommand(strInstrucao, objConexao)
    Public Property NomePacote As String

    Public Sub ExcluirAgendamento(ByVal IdAgendamento As Integer)

        strInstrucao = "DELETE FROM Agendamento WHERE Id = @Id"
        objCommand.CommandText = strInstrucao
        objCommand.Connection = objConexao
        objCommand.Parameters.AddWithValue("@Id", IdAgendamento)

        objConexao.Open()
        objCommand.ExecuteNonQuery()
        objConexao.Close()

    End Sub


    Public Sub GravarAgendamento(ByVal objeto As Agendamento)

        strInstrucao = "INSERT INTO Agendamento VALUES (@Nome, @Dataa, @Pago, @Pacotes)"
        objCommand.CommandText = strInstrucao
        objCommand.Connection = objConexao
        objCommand.Parameters.AddWithValue("@Nome", objeto.Cliente)
        objCommand.Parameters.AddWithValue("@Dataa", objeto.Data)
        objCommand.Parameters.AddWithValue("@Pago", objeto.Pago)
        objCommand.Parameters.AddWithValue("@Pacotes", objeto.Pacotes)

        objConexao.Open()
        objCommand.ExecuteNonQuery()
        objConexao.Close()

    End Sub

    Public Sub UpdateAgendamento(ByVal objeto As Agendamento)

        strInstrucao = "Update Agendamento set nome=@Nome, Dataa=  @Dataa,Pago= @Pago,Pacotes @Pacotes WHERE Id = @Id"
        objCommand.CommandText = strInstrucao
        objCommand.Connection = objConexao
        objCommand.Parameters.AddWithValue("@Nome", objeto.Cliente)
        objCommand.Parameters.AddWithValue("@Dataa", objeto.Data)
        objCommand.Parameters.AddWithValue("@Pago", objeto.Pago)
        objCommand.Parameters.AddWithValue("@Pacotes", objeto.Pacotes)
        objCommand.Parameters.AddWithValue("@Id", objeto.Id)

        objConexao.Open()
        objCommand.ExecuteNonQuery()
        objConexao.Close()

    End Sub
    Function TodosAgendamentos()

        Using con As SqlConnection = Dados.dados.GetConnectionSQServer

            Try

                con.Open()
                Dim sql As String = "SELECT Agendamento.Id, Clientes.id as id_cliente, Clientes.Nome as Nome_Cliente,Agendamento.Pacotes, Agendamento.Dataa, Agendamento.Pago
FROM ((Clientes
INNER JOIN Agendamento ON Agendamento.Nome = Clientes.id)
INNER JOIN PacoteTurismo ON Agendamento.Pacotes = PacoteTurismo.Numero) where Agendamento.Nome > 0"
                Dim cmd As SqlCommand = New SqlCommand(sql, con)
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                Return dt

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End Using
    End Function

    Public Function ConsultarAgendamentos() As DataTable

        Dim dt As New DataTable
        Dim ds As New DataSet()
        strInstrucao = $"SELECT Agendamento.Id, Clientes.id as id_cliente, Clientes.Nome as Nome_Cliente,Agendamento.Pacotes, Agendamento.Dataa, Agendamento.Pago
FROM ((Clientes
INNER JOIN Agendamento ON Agendamento.Nome = Clientes.id)
INNER JOIN PacoteTurismo ON Agendamento.Pacotes = PacoteTurismo.Numero) where Agendamento.Nome =
  {Cliente}"
        objCommand.CommandText = strInstrucao
        objCommand.Connection = objConexao

        objConexao.Open()
        Dim da As New SqlDataAdapter(objCommand)
        da.Fill(ds)
        dt = ds.Tables(0)
        objConexao.Close()
        Return dt
    End Function
    Public Function ConsultarAgendamentosId() As DataTable

        Dim dt As New DataTable
        Dim ds As New DataSet()
        strInstrucao = $"SELECT Agendamento.Id, Clientes.id as id_cliente, Clientes.Nome as Nome_Cliente,Agendamento.Pacotes, Agendamento.Dataa, Agendamento.Pago
FROM ((Clientes
INNER JOIN Agendamento ON Agendamento.Nome = Clientes.id)
INNER JOIN PacoteTurismo ON Agendamento.Pacotes = PacoteTurismo.Numero) where Agendamento.Id =
  {Id}"
        objCommand.CommandText = strInstrucao
        objCommand.Connection = objConexao

        objConexao.Open()
        Dim da As New SqlDataAdapter(objCommand)
        da.Fill(ds)
        dt = ds.Tables(0)
        If dt.Rows.Count <> 0 Then
            Nome = dt(0)("Nome_Cliente")
            Cliente = dt(0)("id_cliente")
            Data = dt(0)("Dataa")
            Pago = dt(0)("Pago")
            Pacotes = dt(0)("Pacotes")
        End If
        objConexao.Close()
        Return dt
    End Function

End Class
