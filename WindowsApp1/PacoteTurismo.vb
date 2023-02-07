Imports System.Data.SqlClient
Imports WindowsApp1.Dados.dados
Public Class PacoteTurismo
    Private _numero As Integer
    Private _tipoPasseio As [Enum]
    Private _dataViagem As Date
    Private _diarias As Integer
    Private _preco As Decimal
    Private _destino As Integer
    Public Property Numero As Integer
        Get
            Return _numero
        End Get
        Set(value As Integer)
            _numero = value
        End Set
    End Property
    Public Enum TipoPasseioo
        Excursao = 0
        Particular = 1
        Outros = 2

    End Enum
    Public Property TipoPasseio As TipoPasseioo
        Get
            Return _tipoPasseio
        End Get
        Set(value As TipoPasseioo)
            _tipoPasseio = value
        End Set
    End Property
    Public Property DataViagem As Date
        Get
            Return _dataViagem
        End Get
        Set(value As Date)
            _dataViagem = value
        End Set
    End Property
    Public Property Diarias As Integer
        Get
            Return _diarias
        End Get
        Set(value As Integer)
            _diarias = value
        End Set
    End Property
    Public Property Preco As Decimal
        Get
            Return _preco
        End Get
        Set(value As Decimal)
            _preco = value
        End Set
    End Property
    Public Property Destino As Integer
        Get
            Return _destino
        End Get
        Set(value As Integer)
            _destino = value
        End Set
    End Property


    Public Property NomeDestino As String
    Public strInstrucao As String = String.Empty
    Public objConexao As New SqlConnection(StringConexao)
    Public objCommand As New SqlCommand(strInstrucao, objConexao)
    Public Sub ExcluirPacote(ByVal IdPacote As Integer)

        strInstrucao = "DELETE FROM PacoteTurismo WHERE Numero = @Id"
        objCommand.CommandText = strInstrucao
        objCommand.Connection = objConexao
        objCommand.Parameters.AddWithValue("@Id", IdPacote)

        objConexao.Open()
        objCommand.ExecuteNonQuery()
        objConexao.Close()

    End Sub

    Public Sub GravarPacote(ByVal pacote As PacoteTurismo)


        strInstrucao = "INSERT INTO PacoteTurismo VALUES (@TipoPasseio, @DataViagem, @Diarias, @Preco, @Destinos)"
        objCommand.CommandText = strInstrucao
        objCommand.Connection = objConexao
        objCommand.Parameters.AddWithValue("@TipoPasseio", pacote.TipoPasseio)
        objCommand.Parameters.AddWithValue("@DataViagem", pacote.DataViagem)
        objCommand.Parameters.AddWithValue("@Diarias", pacote.Diarias)
        objCommand.Parameters.AddWithValue("@Preco", pacote.Preco)
        objCommand.Parameters.AddWithValue("@Destinos", _destino)
        objConexao.Open()
        objCommand.ExecuteNonQuery()
        objConexao.Close()

    End Sub

    Public Property Uf
    Public Function ConsultarPacote() As DataTable

        Dim dt As New DataTable
        Dim ds As New DataSet()
        strInstrucao = $"SELECT PacoteTurismo.Numero, PacoteTurismo.TipoPasseio, PacoteTurismo.DataViagem,PacoteTurismo.Diarias,PacoteTurismo.Preco,PacoteTurismo.Destinos as id_destino, Destino.Uf as UF_destino
FROM ((PacoteTurismo
INNER JOIN Destino ON Destino.uf = Destino.Uf)) where PacoteTurismo.Numero = {_numero}"
        objCommand.CommandText = strInstrucao
        objCommand.Connection = objConexao

        objConexao.Open()
        Dim da As New SqlDataAdapter(objCommand)
        da.Fill(ds)
        dt = ds.Tables(0)
        If dt.Rows.Count <> 0 Then
            TipoPasseio = dt(0)("TipoPasseio")
            DataViagem = dt(0)("DataViagem")
            Diarias = dt(0)("Diarias")
            Preco = dt(0)("Preco")
            Destino = dt(0)("id_destino")
            Uf = dt(0)("UF_destino")
        End If
        objConexao.Close()
        Return dt

    End Function

    Public Function TodosPacotes() As DataTable

        Dim dt As New DataTable
        Dim ds As New DataSet()
        strInstrucao = $"SELECT * FROM PacoteTurismo"
        objCommand.CommandText = strInstrucao
        objCommand.Connection = objConexao

        objConexao.Open()
        Dim da As New SqlDataAdapter(objCommand)
        da.Fill(ds)
        dt = ds.Tables(0)
        objConexao.Close()
        Return dt
    End Function
End Class
