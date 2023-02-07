Imports System.Data.SqlClient
Imports WindowsApp1.Dados.dados
Public Class Destino
    Private _codigo As Integer
    Private _cidade As String
    Private _uf As String

    Public Property Codigo As Integer
        Set(value As Integer)
            _codigo = value
        End Set
        Get
            Return _codigo
        End Get
    End Property
    Public Property Cidade As String
        Get
            Return _cidade
        End Get
        Set(value As String)
            _cidade = value
        End Set
    End Property
    Public Property Uf As String
        Get
            Return _uf
        End Get
        Set(value As String)
            _uf = value
        End Set
    End Property

    Public strInstrucao As String = String.Empty
    Public objCommand As New SqlCommand(strInstrucao, objConexao)
    Public objConexao As New SqlConnection(StringConexao)


    Public Sub GravarDestino(ByVal destino As Destino)

        strInstrucao = "INSERT INTO Destino VALUES (@Cidade, @Uf)"
        objCommand.CommandText = strInstrucao
        objCommand.Connection = objConexao
        objCommand.Parameters.AddWithValue("@Cidade", destino.Cidade)
        objCommand.Parameters.AddWithValue("@Uf", destino.Uf)
        objConexao.Open()
        objCommand.ExecuteNonQuery()
        objConexao.Close()

    End Sub
    Public Sub ExcluirDestino(ByVal IdCliente As Integer)

        strInstrucao = "DELETE FROM Destino WHERE Codigo = @Codigo"
        objCommand.CommandText = strInstrucao
        objCommand.Connection = objConexao
        objCommand.Parameters.AddWithValue("@Codigo", IdCliente)

        objConexao.Open()
        objCommand.ExecuteNonQuery()
        objConexao.Close()

    End Sub

    Public Function ConsultarDestino() As DataTable

        Dim dt As New DataTable
        Dim ds As New DataSet()
        strInstrucao = $"SELECT * FROM Destino WHERE Codigo = {Codigo}"
        objCommand.CommandText = strInstrucao
        objCommand.Connection = objConexao

        objConexao.Open()
        Dim da As New SqlDataAdapter(objCommand)
        da.Fill(ds)
        dt = ds.Tables(0)
        If dt.Rows.Count <> 0 Then
            Cidade = dt(0)("Cidade")
            Uf = dt(0)("Uf")

        End If

        objConexao.Close()
        Return dt

    End Function

    Public Function TodosDestinos()


        Using con As SqlConnection = Dados.dados.GetConnectionSQServer

            Try
                con.Open()
                Dim sql As String = "SELECT * FROM Destino"
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
End Class
