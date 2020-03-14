Imports MySql.Data.MySqlClient

Public Class User_StraightVote
    Public Property FirstName As String
    Public GlobalFirstName As String
    Public Property StudentNum As String
    Public GlobalStudentNum As String


    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=vms")


    Private Sub User_StraightVote_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GlobalFirstName = User_Login.GlobalFirstName
        GlobalStudentNum = User_Login.GlobalStudentNum
        Label20.Text = GlobalFirstName
        Label21.Text = GlobalStudentNum
        DateBox.Text = DateTime.Now.ToString("yyyy-MM-dd, HH:MM:ss")

        Dim adapter As New MySqlDataAdapter("SELECT `party_name` FROM party_name", connection)
        Dim table As New DataTable()
        adapter.Fill(table)

        ComboBox1.DataSource = table
        ComboBox1.ValueMember = "party_name"
        ComboBox1.DisplayMember = "party_name"

    End Sub

    Private Sub Vote_Click(sender As Object, e As EventArgs) Handles Vote.Click

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to proceed?",
                           "Title",
                           MessageBoxButtons.YesNo)

        If (result = DialogResult.Yes) Then
            Try

                Dim command As New MySqlCommand("UPDATE candidate SET vote = vote + 1 WHERE party_name = @party_name", connection)

                command.Parameters.AddWithValue("@party_name", ComboBox1.SelectedValue)

                connection.Open()
                command.ExecuteNonQuery()
                connection.Close()
                insertvote()
                updatevoterstatus()

                MessageBox.Show("Successfully Voted!")
                User_Success_Straight.Show()
                Me.Hide()


            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If

    End Sub

    Private Sub Create_Click(sender As Object, e As EventArgs) Handles Create.Click
        User_Vote.Show()
        Me.Hide()
    End Sub

    Private Sub insertvote()
        connection.Close()
        Dim command1 As New MySqlCommand("INSERT INTO `vote_logs` (party_name, voter_name, voter_student_num,date) values(@party_name,@voter_name,@voter_student_num,@date)", connection)

        command1.Parameters.AddWithValue("@party_name", ComboBox1.SelectedValue)
        command1.Parameters.AddWithValue("@voter_name", Label20.Text)
        command1.Parameters.AddWithValue("@voter_student_num", Label21.Text)
        command1.Parameters.AddWithValue("@date", DateBox.Text)

        connection.Open()
        command1.ExecuteNonQuery()
        connection.Close()

    End Sub


    Private Sub updatevoterstatus()
        connection.Open()
        Dim command As New MySqlCommand("UPDATE voters SET voter_status = 'VOTED' WHERE student_number  = '" + Label21.Text + "'", connection)

        command.ExecuteNonQuery()

    End Sub

End Class