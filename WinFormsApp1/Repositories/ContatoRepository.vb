Imports System.Data.SqlClient

Public Class ContatoRepository
	Public Const stringConnection As String = "Data Source=LUCASSOLIVEIRA\SQLEXPRESS; Initial Catalog=Projvb; Integrated Security=True"
	Public strInstruc As String = String.Empty

	Public conexao As New SqlConnection(stringConnection)

	Public objCommand As New SqlCommand(strInstruc, conexao)



	'Criação de contatos
	Public Sub NovoContato(ByVal contato As Contato)
		strInstruc = "INSERT INTO contato VALUES (@Nome, @Email)"
		objCommand.CommandText = strInstruc
		objCommand.Connection = conexao

		objCommand.Parameters.AddWithValue("@Nome", contato.Nome)
		objCommand.Parameters.AddWithValue("@Email", contato.Email)

		conexao.Open()
		objCommand.ExecuteNonQuery()
		conexao.Close()


	End Sub


End Class
