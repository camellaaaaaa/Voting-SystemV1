Imports MySql.Data.MySqlClient


Public Class User_Success

    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=vms")

    Public Property FirstName As String
    Public GlobalFirstName As String
    Public Property StudentNum As String
    Public GlobalStudentNum As String


    Private Sub User_Success_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GlobalFirstName = User_Login.GlobalFirstName
        GlobalStudentNum = User_Login.GlobalStudentNum
        Label20.Text = GlobalFirstName



        Dim cmd As New MySqlCommand
        Dim rolereader As MySqlDataReader
        Dim query As String


        Try

            connection.Open()
            query = "SELECT president,vp_executive,vp_student,vp_academic,vp_relation,vp_organization,secretary,treasurer,auditor,business,control,head,fifth,fourth,third,second,date FROM vote_logs WHERE voter_name='" & Label20.Text & "'"
        cmd = New MySqlCommand(query, connection)

        rolereader = cmd.ExecuteReader
            While rolereader.Read
                TextBox1.Text = rolereader.GetString("president")
                TextBox2.Text = rolereader.GetString("vp_executive")
                TextBox3.Text = rolereader.GetString("vp_academic")
                TextBox4.Text = rolereader.GetString("vp_student")
                TextBox5.Text = rolereader.GetString("vp_relation")
                TextBox6.Text = rolereader.GetString("vp_organization")
                TextBox7.Text = rolereader.GetString("secretary")
                TextBox8.Text = rolereader.GetString("treasurer")
                TextBox9.Text = rolereader.GetString("auditor")
                TextBox10.Text = rolereader.GetString("business")
                TextBox11.Text = rolereader.GetString("control")
                TextBox12.Text = rolereader.GetString("head")
                TextBox13.Text = rolereader.GetString("fifth")
                TextBox14.Text = rolereader.GetString("fourth")
                TextBox15.Text = rolereader.GetString("third")
                TextBox16.Text = rolereader.GetString("second")
                DateBox.Text = rolereader.GetString("date")

            End While
            connection.Close()
        Catch ex As Exception
            connection.Close()
        End Try

    End Sub

 
    Private Sub Create_Click(sender As Object, e As EventArgs) Handles Create.Click
            Dim Login As New User_Login
            Login.Show()
            Me.Close()
    End Sub

    Private Sub DateBox_Click(sender As Object, e As EventArgs) Handles DateBox.Click

    End Sub

    Private Sub Label20_Click(sender As Object, e As EventArgs) Handles Label20.Click
        Label20.Text = GlobalFirstName
    End Sub
End Class