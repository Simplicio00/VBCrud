<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.MailContent = New System.Windows.Forms.TextBox()
		Me.NameContent = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.GridData = New System.Windows.Forms.DataGridView()
		Me.Nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.ListarBtn = New System.Windows.Forms.Button()
		Me.Sucess = New System.Windows.Forms.Label()
		CType(Me.GridData, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(40, 50)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(101, 15)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Digite o seu Email"
		'
		'MailContent
		'
		Me.MailContent.Location = New System.Drawing.Point(40, 77)
		Me.MailContent.Name = "MailContent"
		Me.MailContent.Size = New System.Drawing.Size(220, 23)
		Me.MailContent.TabIndex = 1
		'
		'NameContent
		'
		Me.NameContent.Location = New System.Drawing.Point(40, 181)
		Me.NameContent.Name = "NameContent"
		Me.NameContent.Size = New System.Drawing.Size(220, 23)
		Me.NameContent.TabIndex = 3
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(40, 145)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(105, 15)
		Me.Label2.TabIndex = 2
		Me.Label2.Text = "Digite o seu Nome"
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(40, 255)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(151, 48)
		Me.Button1.TabIndex = 4
		Me.Button1.Text = "Cadastrar"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'GridData
		'
		Me.GridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.GridData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nome})
		Me.GridData.Location = New System.Drawing.Point(435, 12)
		Me.GridData.Name = "GridData"
		Me.GridData.RowTemplate.Height = 25
		Me.GridData.Size = New System.Drawing.Size(343, 408)
		Me.GridData.TabIndex = 5
		'
		'Nome
		'
		Me.Nome.HeaderText = "EMAIL"
		Me.Nome.Name = "Nome"
		Me.Nome.Width = 300
		'
		'ListarBtn
		'
		Me.ListarBtn.Location = New System.Drawing.Point(40, 348)
		Me.ListarBtn.Name = "ListarBtn"
		Me.ListarBtn.Size = New System.Drawing.Size(151, 23)
		Me.ListarBtn.TabIndex = 6
		Me.ListarBtn.Text = "Listar"
		Me.ListarBtn.UseVisualStyleBackColor = True
		'
		'Sucess
		'
		Me.Sucess.AutoSize = True
		Me.Sucess.ForeColor = System.Drawing.Color.Blue
		Me.Sucess.Location = New System.Drawing.Point(208, 272)
		Me.Sucess.Name = "Sucess"
		Me.Sucess.Size = New System.Drawing.Size(104, 15)
		Me.Sucess.TabIndex = 7
		Me.Sucess.Text = "Cadastro efetuado"
		Me.Sucess.Visible = False
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.Sucess)
		Me.Controls.Add(Me.ListarBtn)
		Me.Controls.Add(Me.GridData)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.NameContent)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.MailContent)
		Me.Controls.Add(Me.Label1)
		Me.Name = "Form1"
		Me.Text = "Form1"
		CType(Me.GridData, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents MailContent As TextBox
	Friend WithEvents NameContent As TextBox
	Friend WithEvents Label2 As Label
	Friend WithEvents Button1 As Button
	Friend WithEvents GridData As DataGridView
	Friend WithEvents ListarBtn As Button
	Friend WithEvents Nome As DataGridViewTextBoxColumn
	Friend WithEvents Sucess As Label
End Class
