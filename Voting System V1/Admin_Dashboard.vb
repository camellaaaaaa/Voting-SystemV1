Public Class Admin_Dashboard

    Public Property FirstName As String
    Public GlobalFirstNameAdmin As String


    Private Sub VoteResults_Click(sender As Object, e As EventArgs) Handles VoteResults.Click
        Admin_Results.Show()

    End Sub

    Private Sub CreateElection_Click(sender As Object, e As EventArgs) Handles Registration.Click
        Admin_Dashboard2.Show()
        Me.Hide()
    End Sub

   
    Private Sub Admin_Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GlobalFirstNameAdmin = User_Login.GlobalFirstNameAdmin
        Label19.Text = GlobalFirstNameAdmin

    End Sub

    Private Sub CreateElection_Click_2(sender As Object, e As EventArgs)
        Admin_Create.Show()
    End Sub

    Private Sub Profile_Click(sender As Object, e As EventArgs) Handles Profile.Click
        Admin_ChangePass.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Label19_Click(sender As Object, e As EventArgs) Handles Label19.Click

    End Sub

    Private Sub Logout_Click(sender As Object, e As EventArgs) Handles Logout.Click
        Dim Login As New User_Login
        Login.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Admin_VoteLogs.Show()
        Me.Hide()
    End Sub
End Class