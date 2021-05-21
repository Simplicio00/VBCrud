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

	Public Function ConsultarContatos() As DataTable

		Dim dt As New DataTable
		Dim ds As New DataSet()
		strInstruc = "SELECT IdContato, Nome, Email FROM contato"
		objCommand.CommandText = strInstruc
		objCommand.Connection = conexao

		conexao.Open()
		Dim da As New SqlDataAdapter(objCommand)

		'Dim lista As New List(Of Contato)()

		da.Fill(ds)
		dt = ds.Tables(0)


		conexao.Close()
		Return dt

	End Function


End Class
