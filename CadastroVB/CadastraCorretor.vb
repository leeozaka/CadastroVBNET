Imports System.Data.SqlClient
Imports System.Configuration

Public Class CadastraCorretor
    Private Sub Cadastrar()
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("ConnectionString").ConnectionString
        Dim queryConsultor As String = "INSERT INTO Corretor (Codigo, Nome, CPF) VALUES (@Id, @Nome, @CPF)"

        Using connection As New SqlConnection(connectionString)
            Using commandCorretor As New SqlCommand(queryConsultor, connection)
                commandCorretor.Parameters.AddWithValue("@Id", CorretorId.Text)
                commandCorretor.Parameters.AddWithValue("@Nome", CorretorNome.Text)
                commandCorretor.Parameters.AddWithValue("@CPF", CorretorCPF.MaskedTextProvider.ToDisplayString())

                Try
                    connection.Open()
                    commandCorretor.ExecuteNonQuery()

                    MessageBox.Show("Corretor cadastrado com sucesso!")

                Catch ex As SqlException
                    MessageBox.Show("SQL error: " & ex.Message)
                Catch ex As Exception
                    MessageBox.Show("An error occurred: " & ex.Message)
                End Try
            End Using
        End Using

        Dim consultaClientesForm As New ConsultaClientes()
        consultaClientesForm.Show()
    End Sub

    Private Sub CadastraConsultor_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dim consultaClientesForm As New ConsultaClientes()
        consultaClientesForm.Show()
    End Sub

    Private Sub HnCadastrar_Click(sender As Object, e As EventArgs) Handles HnCadastrar.Click
        Cadastrar()
    End Sub
End Class