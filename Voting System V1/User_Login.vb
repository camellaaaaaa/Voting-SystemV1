Imports MySql.Data.MySqlClient

Public Class User_Login
    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=vms")
    Dim Home As New User_Vote
    Dim Admin As New Admin_Dashboard
    Dim Admin2 As New Admin_Dashboard2
    Public GlobalFirstName As String


    Public Sub BLogin_Click_1(sender As Object, e As EventArgs) Handles BLogin.Click
        If TStudentNumber.Text = "" Or TLastName.Text = "" Then
            MessageBox.Show("Please Fill in Empty Fields!")
        Else
            Dim cmd As MySqlCommand
            Dim rolereader As MySqlDataReader
            Try
                connection.Open()
                Dim query As String
                query = "select role from voters where student_number = '" & TStudentNumber.Text & "' and last_name = '" & TLastName.Text & "' "
                cmd = New MySqlCommand(query, connection)
                rolereader = cmd.ExecuteReader()

                Dim count As Integer
                count = 0
                While rolereader.Read
                    count = count + 1

                End While
                If count = 1 Then
                    Dim usertype = rolereader.GetString("role")
                    If usertype = "USER" Then
                        connection.Close()
                        connection.Open()

                        Dim command2 As New MySqlCommand("SELECT `first_name` FROM `voters` WHERE `student_number` = @student_number ", connection)
                        Dim reader As MySqlDataReader
                        command2.Parameters.Add("@student_number", MySqlDbType.VarChar).Value = TStudentNumber.Text


                        reader = command2.ExecuteReader()
                        reader.Read()
                        If reader.HasRows Then
                            Home.FirstName = reader("first_name").ToString()
                            GlobalFirstName = Home.FirstName

                        End If
                        Home.Show()
                        Me.Hide()
                        connection.Close()

                    ElseIf usertype = "ADMIN" Then
                        connection.Close()
                        connection.Open()

                        Dim command2 As New MySqlCommand("SELECT `first_name` FROM `voters` WHERE `student_number` = @student_number ", connection)
                        Dim reader As MySqlDataReader
                        command2.Parameters.Add("@student_number", MySqlDbType.VarChar).Value = TStudentNumber.Text


                        reader = command2.ExecuteReader()
                        reader.Read()
                        If reader.HasRows Then
                            Admin.FirstName = reader("first_name").ToString()
                            GlobalFirstName = Admin.FirstName


                        End If
                        Admin.Show()
                        Me.Hide()
                        connection.Close()

                    End If
                Else
                    MessageBox.Show("Invalid Username or Password")
                    connection.Close()

                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub


End Class