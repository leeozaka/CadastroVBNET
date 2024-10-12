Imports System.Configuration
Imports System.Data.SqlClient

Public Class ConsultaClientes

    Private Sub CadastraConsultor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeComponent()
        LoadData()
    End Sub

    Private Sub LoadData()
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("ConnectionString").ConnectionString
        Dim query As String = "SELECT c.Id, c.Nome AS NomeCliente, c.CPF AS CPF, c.Ativo, co.Nome AS NomeCorretor, co.Codigo AS CodCorretor, u.Nome AS UF, ci.Nome AS Cidade " &
                              "FROM Cliente c " &
                              "INNER JOIN ClienteXCorretor cc ON c.Id = cc.IdCliente " &
                              "INNER JOIN Corretor co ON cc.IdCorretor = co.Codigo " &
                              "INNER JOIN UF u ON c.UF = u.Id " &
                              "INNER JOIN Cidade ci ON c.Cidade = ci.Id"

        Dim qCidade As String = "SELECT Id, Nome FROM Cidade"
        Dim qUF As String = "SELECT Id, Nome FROM UF"

        Using connection As New SqlConnection(connectionString)
            Dim command As New SqlCommand(query, connection)
            Dim adapter As New SqlDataAdapter(command)


            Dim table As New DataTable()

            Try

                connection.Open()
                adapter.Fill(table)

                If DataGridView1 IsNot Nothing Then
                    DataGridView1.DataSource = table

                    Dim deleteButtonColumn As New DataGridViewButtonColumn()
                    With deleteButtonColumn
                        .Text = "❌"
                        .UseColumnTextForButtonValue = True
                        .Name = "Delete"
                    End With
                    DataGridView1.Columns.Add(deleteButtonColumn)

                Else
                    MessageBox.Show("DataGridView não foi inicializado corretamente!")
                End If

                LoadComboBoxData(connection, qCidade, Cidade)
                LoadComboBoxData(connection, qUF, Estado)

            Catch ex As Exception
                MessageBox.Show("Um erro aconteceu: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub LoadComboBoxData(connection As SqlConnection, query As String, comboBox As ComboBox)
        Dim command As New SqlCommand(query, connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)


        Dim emptyRow As DataRow = table.NewRow()
        emptyRow("Id") = DBNull.Value
        emptyRow("Nome") = ""
        table.Rows.InsertAt(emptyRow, 0)

        comboBox.DataSource = table
        comboBox.DisplayMember = "Nome"
        comboBox.ValueMember = "Id"
    End Sub

    Private Sub AplicarFiltros()
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("ConnectionString").ConnectionString
        Dim query As String = "SELECT c.Id, c.Nome AS NomeCliente, c.CPF AS CPF, c.Ativo, co.Nome AS NomeCorretor, co.Codigo AS CodCorretor, u.Nome AS UF, ci.Nome AS Cidade " &
                              "FROM Cliente c " &
                              "INNER JOIN ClienteXCorretor cc ON c.Id = cc.IdCliente " &
                              "INNER JOIN Corretor co ON cc.IdCorretor = co.Codigo " &
                              "INNER JOIN UF u ON c.UF = u.Id " &
                              "INNER JOIN Cidade ci ON c.Cidade = ci.Id " &
                              "WHERE 1=1"

        If NomeCliente.Text.Trim() <> "" Then
            query &= " AND c.Nome LIKE @NomeCliente"
        End If

        If CPF.Text.Trim() <> "" Then
            query &= " AND c.CPF LIKE @CPF"
        End If

        If chkAtivo.Checked Then
            query &= " AND c.Ativo = 1"
        End If

        If NomeCorretor.Text.Trim() <> "" Then
            query &= " AND co.Nome LIKE @NomeCorretor"
        End If

        If CodCorretor.Text.Trim() <> "" Then
            query &= " AND co.Codigo = @CodCorretor"
        End If

        If Estado.SelectedIndex > 0 Then
            query &= " AND u.Id = @Estado"
        End If

        If Cidade.SelectedIndex > 0 Then
            query &= " AND ci.Id = @Cidade"
        End If

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                If NomeCliente.Text.Trim() <> "" Then
                    command.Parameters.AddWithValue("@NomeCliente", "%" & NomeCliente.Text.Trim() & "%")
                End If

                If Estado.SelectedIndex > 0 Then
                    command.Parameters.AddWithValue("@Estado", Estado.SelectedValue)
                End If

                If Cidade.SelectedIndex > 0 Then
                    command.Parameters.AddWithValue("@Cidade", Cidade.SelectedValue)
                End If

                If CPF.Text.Trim() <> "" Then
                    command.Parameters.AddWithValue("@CPF", "%" & CPF.Text.Trim() & "%")
                End If

                If NomeCorretor.Text.Trim() <> "" Then
                    command.Parameters.AddWithValue("@NomeCorretor", "%" & NomeCorretor.Text.Trim() & "%")
                End If

                If CodCorretor.Text.Trim() <> "" Then
                    command.Parameters.AddWithValue("@CodCorretor", CodCorretor.Text.Trim())
                End If

                Dim adapter As New SqlDataAdapter(command)
                Dim table As New DataTable()

                Try
                    connection.Open()
                    adapter.Fill(table)

                    If DataGridView1 IsNot Nothing Then
                        DataGridView1.DataSource = table
                    Else
                        MessageBox.Show("DataGridView não foi inicializado corretamente")
                    End If

                Catch ex As Exception
                    MessageBox.Show("Um erro aconteceu: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub BtnCadastrarCliente_Click(sender As Object, e As EventArgs) Handles btnCadastrarCliente.Click
        Dim cadastraClienteForm As New CadastraCliente
        cadastraClienteForm.Show()
        Me.Hide()
    End Sub

    Private Sub BtnCadastrarConsultor_Click(sender As Object, e As EventArgs) Handles btnCadastrarCorretor.Click
        Dim cadastrarConsultorForm As New CadastraCorretor
        cadastrarConsultorForm.Show()
        Me.Hide()
    End Sub

    Private Sub ConsultaClientes_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub BtnPesquisar_Click(sender As Object, e As EventArgs) Handles btnPesquisar.Click
        AplicarFiltros()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.ColumnIndex = DataGridView1.Columns.IndexOf(DataGridView1.Columns("Delete")) Then
            If MessageBox.Show("Voce tem certeza que quer deletar esse cliente?", "Confirmar", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Dim clientId As Integer = CInt(DataGridView1.Rows(e.RowIndex).Cells("Id").Value)

                DeletarCliente(clientId)
                LoadData()
            End If
        End If

        If e.ColumnIndex = DataGridView1.Columns.IndexOf(DataGridView1.Columns("Ativo")) Then
            If MessageBox.Show("Voce tem certeza que deseja alterar se este cliente está ativo?", "Confirm Change", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Dim clientId As Integer = CInt(DataGridView1.Rows(e.RowIndex).Cells("Id").Value)
                Dim ativo As Boolean = CBool(DataGridView1.Rows(e.RowIndex).Cells("Ativo").Value)

                UpdateClienteAtivo(clientId, ativo)
            End If
        End If
    End Sub

    Private Sub DeletarCliente(clientId As Integer)
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("ConnectionString").ConnectionString

        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Using command As New SqlCommand("DeleteCliente", connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.AddWithValue("@Id", clientId)
                    command.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Cliente deletado com sucesso.")

        Catch ex As Exception
            MessageBox.Show("Um erro aconteceu ao deletar o cliente: " & ex.Message)
        End Try
    End Sub

    Private Sub UpdateClienteAtivo(clientId As Integer, ativo As Boolean)
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("ConnectionString").ConnectionString

        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Using command As New SqlCommand("UpdateClienteAtivo", connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.AddWithValue("@Id", clientId)
                    command.Parameters.AddWithValue("@Ativo", Not ativo)
                    command.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Cliente atualizado com sucesso.")

        Catch ex As Exception
            MessageBox.Show("Um erro aconteceu:" & ex.Message)
        End Try
    End Sub
End Class