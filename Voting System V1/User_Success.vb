Imports MySql.Data.MySqlClient


Public Class User_Success

    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=vms")

    Public Property FirstName As String
    Public GlobalFirstName As String
    Public Property StudentNum As String
    Public GlobalStudentNum As String

    Dim cmd As New MySqlCommand
    Dim table As New DataTable
    Dim adapter As New MySqlDataAdapter

    Private Sub User_Success_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GlobalFirstName = User_Login.GlobalFirstName
        GlobalStudentNum = User_Login.GlobalStudentNum
        Label20.Text = GlobalFirstName

        Dim sql As String = "SELECT president,vp_executive,vp_academic,vp_student,vp_relation,vp_organization,secretary,treasurer,auditor,business,control,head,second,third,fourth,fifth FROM candidate WHERE voter_name = '" & +Label20.Text + "'"
        cmd = New MySqlCommand(sql, connection)

        Try

            connection.Open()
            adapter = New MySqlDataAdapter(cmd)



            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            connection.Close()
        End Try

    End Sub

 
End Class