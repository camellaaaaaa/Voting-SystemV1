Imports MySql.Data.MySqlClient

Public Class Admin_ChangePass

    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=vms")
    Dim i As Integer
    Dim cmd As New MySqlCommand
    Dim table As New DataTable
    Dim adapter As New MySqlDataAdapter

    Public Property FirstName As String
    Public GlobalFirstNameAdmin As String

   

    Private Sub Admin_ChangePass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        retrieve()
    End Sub

    Private Sub retrieve()
        GlobalFirstNameAdmin = User_Login.GlobalFirstNameAdmin
        'Label19.Text = GlobalFirstNameAdmin


        Dim cmd As New MySqlCommand
        Dim rolereader As MySqlDataReader
        Dim query As String


        Try

            connection.Open()
            query = "SELECT student_number, first_name, middle, last_name, password, course, year, section FROM voters WHERE first_name='" & GlobalFirstNameAdmin & "'"
            cmd = New MySqlCommand(query, connection)

            rolereader = cmd.ExecuteReader
            While rolereader.Read
                TStudentNumber.Text = rolereader.GetString("student_number")
                TFirstName.Text = rolereader.GetString("first_name")
                TMiddle.Text = rolereader.GetString("middle")
                TLastName.Text = rolereader.GetString("last_name")
                TPassword.Text = rolereader.GetString("password")
                TCourse.Text = rolereader.GetString("course")
                TYear.Text = rolereader.GetString("year")
                TSection.Text = rolereader.GetString("section")



            End While
            connection.Close()
        Catch ex As Exception
            connection.Close()
        End Try
    End Sub
    Private Sub UpdateDG()
        Dim sql As String = "UPDATE voters SET student_number='" + TStudentNumber.Text + "', first_name='" + TFirstName.Text + "', middle='" + TMiddle.Text + "', last_name='" + TLastName.Text + "', password='" + TPassword.Text + "', course='" + TCourse.Text + "', year='" + TCourse.Text + "', section='" + TSection.Text + "' WHERE first_name='" & GlobalFirstNameAdmin & "'"

        Try
            connection.Close()
            connection.Open()
            adapter.UpdateCommand = connection.CreateCommand()
            adapter.UpdateCommand.CommandText = sql
            If MessageBox.Show("Are you sure you want to update this?", "Update", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.OK Then
                If adapter.UpdateCommand.ExecuteNonQuery() > 0 Then
                    MessageBox.Show("Successfully Updated!")
                    connection.Close()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            connection.Close()
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Admin_Dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub Create_Click(sender As Object, e As EventArgs) Handles Create.Click
        UpdateDG()
        retrieve()

    End Sub
End Class