Public Class Form1
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
End Class
