Imports MySql.Data.MySqlClient

Public Class Register_Candidate

    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=vms")

    Private Sub Create_Click(sender As Object, e As EventArgs) Handles Create.Click

        Dim testString As String
        testString = Space(1)

        Dim result As DialogResult = MessageBox.Show("Add Candidate?",
                             "Title",
                             MessageBoxButtons.YesNo)

        If (result = DialogResult.Yes) Then
            Try


                Dim command As New MySqlCommand("INSERT INTO `candidate` (party_name, position, first_name,middle,last_name,year,section,course,full_name) values(@party_name, @position,@first_name,@middle,@last_name,@year,@section,@course,@full_name)", connection)

                command.Parameters.AddWithValue("@party_name", CPartyName.SelectedValue)
                command.Parameters.AddWithValue("@position", CPosition.SelectedValue)
                command.Parameters.AddWithValue("@first_name", TFirstName.Text)
                command.Parameters.AddWithValue("@middle", TMiddle.Text)
                command.Parameters.AddWithValue("@last_name", TLastName.Text)
                command.Parameters.AddWithValue("@course", TCourse.Text)
                command.Parameters.AddWithValue("@year", TYear.Text)
                command.Parameters.AddWithValue("@section", TSection.Text)
                command.Parameters.AddWithValue("@full_name", TFirstName.Text + testString + TMiddle.Text + testString + TLastName.Text)

                connection.Open()
                command.ExecuteNonQuery()
                connection.Close()
                MessageBox.Show("Successfully Added!")
                TFirstName.Clear()
                TMiddle.Clear()
                TLastName.Clear()
                TCourse.Clear()
                TYear.Clear()
                TSection.Clear()


            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If
    End Sub

    Private Sub Register_Candidate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim adapter As New MySqlDataAdapter("SELECT `pos_id`, `position` FROM position", connection)
        Dim adapter1 As New MySqlDataAdapter("SELECT `party_id`, `party_name` FROM party_name", connection)
        Dim table As New DataTable()
        Dim table1 As New DataTable()

        adapter.Fill(table)
        adapter1.Fill(table1)

        CPosition.DataSource = table
        CPosition.ValueMember = "position"
        CPosition.DisplayMember = "position"


        CPartyName.DataSource = table1
        CPartyName.ValueMember = "party_name"
        CPartyName.DisplayMember = "party_name"

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
    End Sub
End Class