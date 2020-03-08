Imports MySql.Data.MySqlClient
Public Class Admin_Create


    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=vms")


    Private Sub Update_Click(sender As Object, e As EventArgs) Handles Update.Click
        Dim result As DialogResult = MessageBox.Show("Add Candidate?",
                            "Title",
                            MessageBoxButtons.YesNo)

        If (result = DialogResult.Yes) Then
            Try

                TStartDate.CustomFormat = "yyyy-MM-dd"
                TEndDate.CustomFormat = "yyyy-MM-dd"

                Dim command As New MySqlCommand("UPDATE `org` SET start_date=@start_date, end_date=@end_date WHERE org_id=1", connection)

                command.Parameters.AddWithValue("@start_date", TStartDate.Value)
                command.Parameters.AddWithValue("@end_date", TEndDate.Value)

                connection.Open()
                command.ExecuteNonQuery()
                connection.Close()
                MessageBox.Show("Successfully Updated!")

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Admin_Dashboard.Show()
        Me.Hide()
    End Sub



    Private Sub Button6_Click(sender As Object, e As EventArgs)
        Admin_Candidate.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Admin_Voter.Show()
        Me.Hide()
    End Sub

    Public Sub load_update()
        Dim Command As New MySqlCommand("SELECT start_date=@start_date,end_date=@end_date FROM org", connection)


      
        TStartDate.CustomFormat = "yyyy-MM-dd"
        TEndDate.CustomFormat = "yyyy-MM-dd"

        Command.Parameters.AddWithValue("@start_date", TStartDate.Value)
        Command.Parameters.AddWithValue("@end_date", TEndDate.Value)

    End Sub

    
    Private Sub Admin_Create_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_update()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Admin_Dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub TEndDate_ValueChanged(sender As Object, e As EventArgs) Handles TEndDate.ValueChanged

    End Sub
End Class