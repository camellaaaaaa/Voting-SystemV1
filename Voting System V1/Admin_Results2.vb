Imports MySql.Data.MySqlClient

Public Class Admin_Results2

    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=vms")

    Private Sub Admin_Results_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cmd As New MySqlCommand
        Dim cmd1 As New MySqlCommand
        Dim cmd2 As New MySqlCommand
        Dim cmd3 As New MySqlCommand
        Dim cmd4 As New MySqlCommand
        Dim cmd5 As New MySqlCommand
        Dim cmd6 As New MySqlCommand
        Dim cmd7 As New MySqlCommand

        Dim table As New DataTable
        Dim table1 As New DataTable
        Dim table2 As New DataTable
        Dim table3 As New DataTable
        Dim table4 As New DataTable
        Dim table5 As New DataTable
        Dim table6 As New DataTable
        Dim table7 As New DataTable

        Dim adapter As New MySqlDataAdapter
        Dim adapter1 As New MySqlDataAdapter
        Dim adapter2 As New MySqlDataAdapter
        Dim adapter3 As New MySqlDataAdapter
        Dim adapter4 As New MySqlDataAdapter
        Dim adapter5 As New MySqlDataAdapter
        Dim adapter6 As New MySqlDataAdapter
        Dim adapter7 As New MySqlDataAdapter

        Dim bind As New BindingSource
        Dim bind1 As New BindingSource
        Dim bind2 As New BindingSource
        Dim bind3 As New BindingSource
        Dim bind4 As New BindingSource
        Dim bind5 As New BindingSource
        Dim bind6 As New BindingSource
        Dim bind7 As New BindingSource

        Try
            connection.Open()
            Dim Query As String
            Dim Query1 As String
            Dim Query2 As String
            Dim Query3 As String
            Dim Query4 As String
            Dim Query5 As String
            Dim Query6 As String
            Dim Query7 As String

            Query = "SELECT party_name, full_name, vote, course, year, section FROM candidate WHERE position='Auditor'"
            Query1 = "SELECT party_name, full_name, vote, course, year, section FROM candidate WHERE position='Business Manager'"
            Query2 = "SELECT  party_name, full_name, vote, course, year, section FROM candidate WHERE position='Control Officer'"
            Query3 = "SELECT  party_name, full_name, vote, course, year, section FROM candidate WHERE position='Head Governor'"
            Query4 = "SELECT  party_name, full_name, vote, course, year, section FROM candidate WHERE position='5th Year Governor'"
            Query5 = "SELECT  party_name, full_name, vote, course, year, section FROM candidate WHERE position='4th Year Governor'"
            Query6 = "SELECT party_name, full_name, vote, course, year, section FROM candidate WHERE position='3rd Year Governor'"
            Query7 = "SELECT  party_name, full_name, vote, course, year, section FROM candidate WHERE position='2nd Year Governor'"

            cmd = New MySqlCommand(Query, connection)
            adapter.SelectCommand = cmd
            adapter.Fill(table)
            bind.DataSource = table
            DataGridView1.DataSource = bind
            adapter.Update(table)

            cmd1 = New MySqlCommand(Query1, connection)
            adapter1.SelectCommand = cmd1
            adapter1.Fill(table1)
            bind1.DataSource = table1
            DataGridView2.DataSource = bind1
            adapter1.Update(table1)

            cmd2 = New MySqlCommand(Query2, connection)
            adapter2.SelectCommand = cmd2
            adapter2.Fill(table2)
            bind2.DataSource = table2
            DataGridView3.DataSource = bind2
            adapter2.Update(table2)

            cmd3 = New MySqlCommand(Query3, connection)
            adapter3.SelectCommand = cmd3
            adapter3.Fill(table3)
            bind3.DataSource = table3
            DataGridView4.DataSource = bind
            adapter3.Update(table3)

            cmd4 = New MySqlCommand(Query4, connection)
            adapter4.SelectCommand = cmd4
            adapter4.Fill(table4)
            bind4.DataSource = table4
            DataGridView5.DataSource = bind4
            adapter4.Update(table4)

            cmd5 = New MySqlCommand(Query5, connection)
            adapter5.SelectCommand = cmd5
            adapter5.Fill(table5)
            bind5.DataSource = table5
            DataGridView6.DataSource = bind5
            adapter5.Update(table5)

            cmd6 = New MySqlCommand(Query6, connection)
            adapter6.SelectCommand = cmd6
            adapter6.Fill(table6)
            bind6.DataSource = table6
            DataGridView7.DataSource = bind6
            adapter6.Update(table6)

            cmd7 = New MySqlCommand(Query7, connection)
            adapter7.SelectCommand = cmd7
            adapter7.Fill(table7)
            bind7.DataSource = table7
            DataGridView8.DataSource = bind7
            adapter7.Update(table7)



            connection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        
    End Sub

    Private Sub Create_Click(sender As Object, e As EventArgs) Handles Create.Click
        Admin_Results.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Admin_Dashboard.Show()
        Me.Hide()
    End Sub
End Class
