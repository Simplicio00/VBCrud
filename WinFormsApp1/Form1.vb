Public Class Form1
	Private Sub CarregarDados()

		Dim objDados As New ContatoRepository()
		'griddata
		Dim dt As New DataTable



		For Each linha As DataRow In objDados.ConsultarContatos().Rows

			GridData.Rows.Add(linha("Email").ToString())


		Next



	End Sub


	Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

	End Sub

	Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles NameContent.TextChanged

	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

		Dim Rep As New ContatoRepository

		Dim objeto As New Contato

		objeto.Email = MailContent.Text
		objeto.Nome = NameContent.Text

		Rep.NovoContato(objeto)


	End Sub

	Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridData.CellContentClick

	End Sub

	Private Sub ListarBtn_Click(sender As Object, e As EventArgs) Handles ListarBtn.Click
		CarregarDados()

	End Sub
End Class
