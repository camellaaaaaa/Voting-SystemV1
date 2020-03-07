Imports MySql.Data.MySqlClient

Public Class Form2

    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=vms")

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim command As New MySqlCommand("SELECT `id`,`first_name` FROM `candidate` WHERE `id` = @id AND `first_name` = @first_name", connection)

        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)
    End Sub
End Class