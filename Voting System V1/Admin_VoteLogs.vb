Imports MySql.Data.MySqlClient
Public Class Admin_VoteLogs

    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=vms")


    Private Sub Admin_VoteLogs_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim cmd As New MySqlCommand
        Dim table As New DataTable
        Dim adapter As New MySqlDataAdapter
        Dim bind As New BindingSource

        Try
            connection.Open()
            Dim Query As String


            Query = "SELECT * FROM vote_logs"
         
            cmd = New MySqlCommand(Query, connection)
            adapter.SelectCommand = cmd
            adapter.Fill(table)
            bind.DataSource = table
            DataGridView1.DataSource = bind
            adapter.Update(table)



            connection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Admin_Dashboard.Show()
        Me.Hide()
    End Sub
End Class