Imports MySql.Data.MySqlClient
Public Class Admin_Create


    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=vms")


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Dashboard.Click
        Admin_Dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Create.Click
        Admin_CreateParty.Show()
    End Sub
End Class