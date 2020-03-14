Imports MySql.Data.MySqlClient
Public Class Register_Partylist

    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=vms")



    Private Sub Create_Click(sender As Object, e As EventArgs) Handles Create.Click

        Dim result As DialogResult = MessageBox.Show("Add Party?",
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
                TPartyName.Clear()



            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Admin_CreatePartyName.Show()
        Me.Hide()
    End Sub
End Class