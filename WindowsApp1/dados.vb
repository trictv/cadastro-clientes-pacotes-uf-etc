Imports System.Data.SqlClient

Namespace Dados
    Public Class dados
        Public Shared Function GetConnectionSQServer() As SqlConnection
            Dim sql As String = "Data Source=trictv\SQL2014;Initial Catalog=CadastroClientes;Persist Security Info=True; Password=00000000!$"
            Return New SqlConnection(sql)
        End Function

        Public Shared Function StringConexao()
            Dim conexao As String
            conexao = "Data Source=trictv\SQL2014;Initial Catalog=CadastroClientes;Persist Security Info=True; Password=00000000"
            Return conexao
        End Function
    End Class

End Namespace
