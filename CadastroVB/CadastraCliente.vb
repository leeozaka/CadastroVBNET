Imports System.Data.SqlClient
Imports System.Configuration

Public Class CadastraCliente
    Inherits System.Windows.Forms.Form

    Private Sub CadastraCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCorretores()
        LoadUF()
    End Sub

    Private Sub LoadCorretores()
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("ConnectionString").ConnectionString
        Dim query As String = "SELECT Codigo, Nome FROM Corretor"

        Using connection As New SqlConnection(connectionString)
            Dim command As New SqlCommand(query, connection)
            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()

            Try
                connection.Open()
                adapter.Fill(table)
                Corretor.DataSource = table
                Corretor.DisplayMember = "Nome"
                Corretor.ValueMember = "Codigo"
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub LoadUF()
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("ConnectionString").ConnectionString
        Dim query As String = "SELECT Id, Nome FROM UF"

        Using connection As New SqlConnection(connectionString)
            Dim command As New SqlCommand(query, connection)
            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()

            Try
                connection.Open()
                adapter.Fill(table)
                UF.DataSource = table
                UF.DisplayMember = "Nome"
                UF.ValueMember = "Id"
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles UF.SelectedIndexChanged
        Dim selectedValue As String = UF.SelectedValue.ToString()
        LoadCidades(selectedValue)
    End Sub

    Private Sub LoadCidades(value As String)
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("ConnectionString").ConnectionString
        Dim query As String = "SELECT Id, Nome FROM Cidade WHERE IdUF = @UF"

        Using connection As New SqlConnection(connectionString)
            Dim command As New SqlCommand(query, connection)
            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()

            command.Parameters.AddWithValue("@UF", value)

            Try
                connection.Open()
                adapter.Fill(table)
                Cidades.DataSource = table
                Cidades.DisplayMember = "Nome"
                Cidades.ValueMember = "Id"
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Cadastrar()
    End Sub

    Private Sub Cadastrar()
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("ConnectionString").ConnectionString

        Dim queryCliente As String = "INSERT INTO Cliente (Nome, Cidade, CPF, Endereco, UF, Ativo) " &
                                 "VALUES (@Nome, @Cidade, @CPF, @Endereco, @UF, @Ativo); " &
                                 "SELECT SCOPE_IDENTITY()"

        Dim queryClienteXCorretor As String = "INSERT INTO ClienteXCorretor (IdCorretor, IdCliente) " &
                                         "VALUES (@IdCorretor, @IdCliente)"

        Using connection As New SqlConnection(connectionString)
            Dim commandCliente As New SqlCommand(queryCliente, connection)

            commandCliente.Parameters.AddWithValue("@Nome", Nome.Text)
            commandCliente.Parameters.AddWithValue("@Cidade", CInt(Cidades.SelectedValue))
            commandCliente.Parameters.AddWithValue("@CPF", CPF.MaskedTextProvider.ToDisplayString())
            commandCliente.Parameters.AddWithValue("@Endereco", Endereco.Text)
            commandCliente.Parameters.AddWithValue("@UF", CInt(UF.SelectedValue))
            commandCliente.Parameters.AddWithValue("@Ativo", 1)

            Try
                connection.Open()
                Dim newClienteId As Integer = Convert.ToInt32(commandCliente.ExecuteScalar())

                Using commandCXC As New SqlCommand(queryClienteXCorretor, connection)
                    commandCXC.Parameters.AddWithValue("@IdCorretor", Corretor.SelectedValue)
                    commandCXC.Parameters.AddWithValue("@IdCliente", newClienteId)

                    commandCXC.ExecuteNonQuery()
                End Using

                MessageBox.Show("Cliente cadastrado com sucesso!")
            Catch ex As SqlException
                MessageBox.Show("SQL error: " & ex.Message)
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            End Try
        End Using

        Dim consultaClientesForm As New ConsultaClientes()
        consultaClientesForm.Show()
    End Sub

    Private Sub CadastraCliente_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dim consultaClientesForm As New ConsultaClientes()
        consultaClientesForm.Show()
    End Sub
End Class