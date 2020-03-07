Imports MySql.Data.MySqlClient


Public Class Admin_CreateParty

    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=vms")
    Dim cmd As MySqlCommand


    Private Sub Create_Click(sender As Object, e As EventArgs) Handles Create.Click
        Dim result As DialogResult = MessageBox.Show("Submit?",
                          "Title",
                          MessageBoxButtons.YesNo)

        If (result = DialogResult.Yes) Then
            Try

                Dim command As New MySqlCommand("INSERT INTO `party_name` (party_name) values(@party_name)", connection)

                command.Parameters.AddWithValue("@party_name", TPartyName.Text)


                connection.Open()
                command.ExecuteNonQuery()
                connection.Close()
                MessageBox.Show("Successfully Added!")
                load_data()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If
    End Sub


    Public Sub load_data()
        Dim adapter As New MySqlDataAdapter
        Dim table As New DataTable
        Dim bind As New BindingSource
        Dim cmd As New MySqlCommand

        Try
            connection.Open()
            Dim Query As String
            Query = "select party_id, party_name from `party_name`"
            cmd = New MySqlCommand(Query, connection)
            adapter.SelectCommand = cmd
            adapter.Fill(table)
            bind.DataSource = table
            DataGridView1.DataSource = bind
            adapter.Update(table)



        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub Admin_CreateParty_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_data()
    End Sub
End Class