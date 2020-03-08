Public Class Admin_Dashboard2

    Public Property FirstName As String

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Admin_Dashboard.Show()
        
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Admin_CreateParty.Show()
        Me.Hide()
    End Sub

    Private Sub VoteResults_Click(sender As Object, e As EventArgs) Handles VoteResults.Click
        Admin_Candidate.Show()
        Me.Hide()

    End Sub

    Private Sub Candidates_Click(sender As Object, e As EventArgs) Handles Candidates.Click
        Admin_Voter.Show()
        Me.Hide()

    End Sub

    Private Sub Admin_Dashboard2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class