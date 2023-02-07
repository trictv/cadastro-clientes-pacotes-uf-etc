Imports System.Data.SqlClient
Imports WindowsApp1.Dados.dados
Public Class Cliente

    Private Id As Integer
    Private Nome As String
    Private Sobrenome As String
    Private N_Documento As String
    Private TipoFJ As String
    Private Email As String
    Private Telefone As String
    Private Cep As String
    Private Cidade As String
    Private Estado As String
    Private Pais As String
    Private Rua As String
    Private Numero As String
    Private Bairro As String
    Private Ativo As Boolean

    Public Property IdCli() As Integer
        Get
            Return Id
        End Get
        Set(value As Integer)
            Id = value
        End Set
    End Property
    Public Property NomeCli() As String
        Get
            Return Nome
        End Get
        Set(ByVal Value As String)
            Nome = Value
        End Set
    End Property
    Public Property SobrenomeCli() As String
        Get
            Return Sobrenome
        End Get
        Set(value As String)
            Sobrenome = value
        End Set
    End Property
    Public Property N_DocumentoCli() As String
        Get
            Return N_Documento
        End Get
        Set(value As String)
            N_Documento = value
        End Set
    End Property
    Public Property TipoFJ_Cli() As String
        Get
            Return TipoFJ
        End Get
        Set(value As String)
            TipoFJ = value
        End Set
    End Property
    Public Property EmailCli() As String
        Get
            Return Email
        End Get
        Set(value As String)
            Email = value
        End Set
    End Property
    Public Property TelefoneCli() As String
        Get
            Return Telefone
        End Get
        Set(value As String)
            Telefone = value
        End Set
    End Property
    Public Property CepCli() As String
        Get
            Return Cep
        End Get
        Set(value As String)
            Cep = value
        End Set
    End Property
    Public Property CidadeCli() As String
        Get
            Return Cidade
        End Get
        Set(value As String)
            Cidade = value
        End Set
    End Property
    Public Property EstadoCli() As String
        Get
            Return Estado
        End Get
        Set(value As String)
            Estado = value
        End Set
    End Property
    Public Property PaisCli() As String
        Get
            Return Pais
        End Get
        Set(value As String)
            Pais = value
        End Set
    End Property
    Public Property RuaCli() As String
        Get
            Return Rua
        End Get
        Set(value As String)
            Rua = value
        End Set
    End Property
    Public Property NumeroCli() As String
        Get
            Return Numero
        End Get
        Set(value As String)
            Numero = value
        End Set
    End Property
    Public Property BairroCli() As String
        Get
            Return Bairro
        End Get
        Set(value As String)
            Bairro = value
        End Set
    End Property
    Public Property AtivoCli() As Boolean
        Get
            Return Ativo
        End Get
        Set(value As Boolean)
            Ativo = value
        End Set
    End Property



    Public strInstrucao As String = String.Empty
    Public objConexao As New SqlConnection(StringConexao)
    Public objCommand As New SqlCommand(strInstrucao, objConexao)
    Public Sub GravarCliente(ByVal cliente As Cliente)

        strInstrucao = "INSERT INTO Clientes VALUES (@Nome, @Sobrenome, @N_Documento, @TipoFJ, @Email, @Telefone, @Cep, @Cidade, @Estado, @Pais, @Rua, @Numero, @Bairro, @Ativo)"
        objCommand.CommandText = strInstrucao
        objCommand.Connection = objConexao
        objCommand.Parameters.AddWithValue("@Nome", cliente.NomeCli)
        objCommand.Parameters.AddWithValue("@Sobrenome", cliente.SobrenomeCli)
        objCommand.Parameters.AddWithValue("@N_Documento", cliente.N_DocumentoCli)
        objCommand.Parameters.AddWithValue("@TipoFJ", cliente.TipoFJ_Cli)
        objCommand.Parameters.AddWithValue("@Email", cliente.EmailCli)
        objCommand.Parameters.AddWithValue("@Telefone", cliente.TelefoneCli)
        objCommand.Parameters.AddWithValue("@Cep", cliente.CepCli)
        objCommand.Parameters.AddWithValue("@Cidade", cliente.CidadeCli)
        objCommand.Parameters.AddWithValue("@Estado", cliente.EstadoCli)
        objCommand.Parameters.AddWithValue("@Pais", cliente.PaisCli)
        objCommand.Parameters.AddWithValue("@Rua", cliente.RuaCli)
        objCommand.Parameters.AddWithValue("@Numero", cliente.NumeroCli)
        objCommand.Parameters.AddWithValue("@Bairro", cliente.BairroCli)
        objCommand.Parameters.AddWithValue("@Ativo", cliente.AtivoCli)
        objConexao.Open()
        objCommand.ExecuteNonQuery()
        objConexao.Close()

    End Sub

    Public Sub EditaCliente(ByVal cliente As Cliente)

        strInstrucao = "UPDATE Clientes SET nome=@Nome ,Sobrenome=@Sobrenome , N_Documento=@N_Documento, TipoFJ=@TipoFJ, Email=@Email, Telefone=@Telefone , Cep=@Cep, Cidade=@Cidade, Estado=@Estado, Pais=@Pais , Rua=@Rua, Numero=@Numero, Bairro=@Bairro, Ativo=@Ativo WHERE Id = @id"
        objCommand.CommandText = strInstrucao
        objCommand.Connection = objConexao
        objCommand.Parameters.AddWithValue("@Nome", cliente.NomeCli)
        objCommand.Parameters.AddWithValue("@Sobrenome", cliente.SobrenomeCli)
        objCommand.Parameters.AddWithValue("@N_Documento", cliente.N_DocumentoCli)
        objCommand.Parameters.AddWithValue("@TipoFJ", cliente.TipoFJ_Cli)
        objCommand.Parameters.AddWithValue("@Email", cliente.EmailCli)
        objCommand.Parameters.AddWithValue("@Telefone", cliente.TelefoneCli)
        objCommand.Parameters.AddWithValue("@Cep", cliente.CepCli)
        objCommand.Parameters.AddWithValue("@Cidade", cliente.CidadeCli)
        objCommand.Parameters.AddWithValue("@Estado", cliente.EstadoCli)
        objCommand.Parameters.AddWithValue("@Pais", cliente.PaisCli)
        objCommand.Parameters.AddWithValue("@Rua", cliente.RuaCli)
        objCommand.Parameters.AddWithValue("@Numero", cliente.NumeroCli)
        objCommand.Parameters.AddWithValue("@Bairro", cliente.BairroCli)
        objCommand.Parameters.AddWithValue("@Ativo", cliente.AtivoCli)
        objCommand.Parameters.AddWithValue("@Id", cliente.IdCli)
        objConexao.Open()
        objCommand.ExecuteNonQuery()
        objConexao.Close()

    End Sub
    Public Sub ExcluirCliente(ByVal IdCliente As Integer)

        strInstrucao = "DELETE FROM Clientes WHERE Id = @Id"
        objCommand.CommandText = strInstrucao
        objCommand.Connection = objConexao
        objCommand.Parameters.AddWithValue("@Id", IdCliente)

        objConexao.Open()
        objCommand.ExecuteNonQuery()
        objConexao.Close()

    End Sub

    Public Function ConsultarClientes() As DataTable

        Dim dt As New DataTable
        Dim ds As New DataSet()
        strInstrucao = $"SELECT * FROM Clientes WHERE Id = {IdCli}"
        objCommand.CommandText = strInstrucao
        objCommand.Connection = objConexao

        objConexao.Open()
        Dim da As New SqlDataAdapter(objCommand)
        da.Fill(ds)
        dt = ds.Tables(0)
        If dt.Rows.Count <> 0 Then
            NomeCli = dt(0)("Nome")
            SobrenomeCli = dt(0)("Sobrenome")
            N_DocumentoCli = dt(0)("N_Documento").ToString
            TipoFJ_Cli = dt(0)("TipoFJ")
            EmailCli = dt(0)("Email")
            TelefoneCli = dt(0)("Telefone")
            CepCli = dt(0)("Cep")
            CidadeCli = dt(0)("Cidade")
            EstadoCli = dt(0)("Estado")
            PaisCli = dt(0)("Pais")
            RuaCli = dt(0)("Rua")
            NumeroCli = dt(0)("Numero")
            BairroCli = dt(0)("Bairro")
            AtivoCli = dt(0)("Ativo")
        End If

        objConexao.Close()
        Return dt

    End Function
End Class


