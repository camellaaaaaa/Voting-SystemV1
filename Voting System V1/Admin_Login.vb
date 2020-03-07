Imports MySql.Data.MySqlClient

Public Class Admin_Login

    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=vms")



    Private Sub BLogin_Click(sender As Object, e As EventArgs) Handles BLogin.Click

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
            connection.Close()
            Me.Hide()


        End If

       
       
    End Sub

    Private Sub VoterLogin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles VoterLogin.LinkClicked
        User_Login.Show()
        Me.Hide()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Panel2_Paint_1(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class