Imports MySql.Data.MySqlClient

Public Class User_Success_Straight

    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=vms")

    Public Property FirstName As String
    Public GlobalFirstName As String
    Public Property StudentNum As String
    Public GlobalStudentNum As String

    Private Sub User_Success_Straight_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GlobalFirstName = User_Login.GlobalFirstName
        GlobalStudentNum = User_Login.GlobalStudentNum
        Label20.Text = GlobalFirstName



        Dim cmd As New MySqlCommand
        Dim rolereader As MySqlDataReader
        Dim query As String


        Try

            connection.Open()
            query = "SELECT party_name,date FROM vote_logs WHERE voter_name='" & Label20.Text & "'"
            cmd = New MySqlCommand(query, connection)

            rolereader = cmd.ExecuteReader
            While rolereader.Read
                TextBox1.Text = rolereader.GetString("party_name")
                DateBox.Text = rolereader.GetString("date")

            End While
            connection.Close()
        Catch ex As Exception
            connection.Close()
        End Try

    End Sub

    Private Sub Label20_Click(sender As Object, e As EventArgs) Handles Label20.Click
        Label20.Text = GlobalFirstName
    End Sub

    Private Sub Create_Click(sender As Object, e As EventArgs) Handles Create.Click
        Dim Login As New User_Login
        Login.Show()
        Me.Close()
    End Sub
End Class