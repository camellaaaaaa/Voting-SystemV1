Public Class Admin_Dashboard

    Public Property FirstName As String
    Public GlobalFirstName As String


    Private Sub VoteResults_Click(sender As Object, e As EventArgs) Handles VoteResults.Click
        Admin_Results.Show()
    End Sub

    Private Sub CreateElection_Click(sender As Object, e As EventArgs) Handles Registration.Click
        Admin_Dashboard2.Show()
        Me.Hide()
    End Sub

   
    Private Sub Admin_Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GlobalFirstName = User_Login.GlobalFirstName


    End Sub

    Private Sub CreateElection_Click_2(sender As Object, e As EventArgs) Handles CreateElection.Click
        Admin_Create.Show()
    End Sub

    Private Sub Profile_Click(sender As Object, e As EventArgs) Handles Profile.Click
        Admin_Changepass.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Label19_Click(sender As Object, e As EventArgs) Handles Label19.Click

    End Sub
End Class