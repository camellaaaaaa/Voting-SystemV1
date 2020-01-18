Imports MySql.Data.MySqlClient

Public Class Admin_Login

    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=vms")

    Private Sub BLogin_Click(sender As Object, e As EventArgs) Handles BLogin.Click
        Dim Homepage As New Admin_Dashboard

        Dim command As New MySqlCommand("SELECT `email`,`password` FROM `users` WHERE `email` = @email AND `password` = @password", connection)

        command.Parameters.Add("@email", MySqlDbType.VarChar).Value = TEmail.Text
        command.Parameters.Add("@password", MySqlDbType.VarChar).Value = TPassword.Text

        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        If table.Rows.Count = 0 Then

            MessageBox.Show("Invalid Username or Password")

        Else

            connection.Open()
            Admin_Dashboard.Show()
            Me.Hide()

        End If
    End Sub
End Class