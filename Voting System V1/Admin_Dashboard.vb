Public Class Admin_Dashboard


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub


    Private Sub Admin_Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles CreateElection.Click
        Admin_Create.Show()
        Me.Hide()
    End Sub
End Class