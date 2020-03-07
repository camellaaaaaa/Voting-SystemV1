Imports MySql.Data.MySqlClient

Public Class Register_User

    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=vms")

    Private Sub Create_Click(sender As Object, e As EventArgs) Handles Create.Click
        Dim testString As String
        testString = Space(1)

        Dim result As DialogResult = MessageBox.Show("Add Candidate?",
                             "Title",
                             MessageBoxButtons.YesNo)

        If (result = DialogResult.Yes) Then
            Try


                Dim command As New MySqlCommand("INSERT INTO `voters` (first_name,middle,last_name, password,year,section,course,student_number,role,full_name) values(@first_name,@middle,@last_name,@password,@year,@section,@course,@student_number,@role,@full_name)", connection)

                command.Parameters.AddWithValue("@first_name", TFirstName.Text)
                command.Parameters.AddWithValue("@middle", TMiddle.Text)
                command.Parameters.AddWithValue("@last_name", TLastName.Text)
                command.Parameters.AddWithValue("@password", TPassword.Text)
                command.Parameters.AddWithValue("@course", TCourse.Text)
                command.Parameters.AddWithValue("@year", TYear.Text)
                command.Parameters.AddWithValue("@section", TSection.Text)
                command.Parameters.AddWithValue("@student_number", TStudentNumber.Text)
                command.Parameters.AddWithValue("@role", CRole.SelectedItem)
                command.Parameters.AddWithValue("@full_name", TFirstName.Text + testString + TMiddle.Text + testString + TLastName.Text)

                connection.Open()
                command.ExecuteNonQuery()
                connection.Close()
                MessageBox.Show("Successfully Added!")
                TFirstName.Clear()
                TMiddle.Clear()
                TLastName.Clear()
                TPassword.Clear()
                TCourse.Clear()
                TYear.Clear()
                TSection.Clear()
                TStudentNumber.Clear()


            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If
    End Sub

    
    Private Sub Register_User_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class