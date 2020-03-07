Imports MySql.Data.MySqlClient


Public Class Admin_User

    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=vms")
    Dim i As Integer
    Dim cmd As New MySqlCommand
    Dim table As New DataTable
    Dim adapter As New MySqlDataAdapter

    Private Sub Admin_Voter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.ColumnCount = 11

        DataGridView1.Columns(0).Name = "voters_id"
        DataGridView1.Columns(1).Name = "first_name"
        DataGridView1.Columns(2).Name = "middle"
        DataGridView1.Columns(3).Name = "last_name"
        DataGridView1.Columns(4).Name = "password"
        DataGridView1.Columns(5).Name = "course"
        DataGridView1.Columns(6).Name = "year"
        DataGridView1.Columns(7).Name = "section"
        DataGridView1.Columns(8).Name = "student_number"
        DataGridView1.Columns(9).Name = "role"
        DataGridView1.Columns(10).Name = "voter_status"

        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        retrieve()
    End Sub

    Private Sub Create_Click(sender As Object, e As EventArgs) Handles Create.Click
        Register_User.Show()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim voters_id As String = DataGridView1.SelectedRows(0).Cells(0).Value
        DeleteDG(voters_id)
        retrieve()


    End Sub

    Private Sub Populate(voters_id As String, first_name As String, middle As String, last_name As String, password As String, course As String, year As String, section As String, student_number As String, role As String, voter_status As String)
        Dim row As String() = New String() {voters_id, first_name, middle, last_name, password, course, year, section, student_number, role, voter_status}
        DataGridView1.Rows.Add(row)
    End Sub

    Private Sub retrieve()

        DataGridView1.Rows.Clear()

        Dim sql As String = "SELECT voters_id, first_name, middle, last_name, password, course, year, section, student_number, role, voter_status FROM voters"
        cmd = New MySqlCommand(sql, connection)

        Try

            connection.Open()
            adapter = New MySqlDataAdapter(cmd)
            adapter.Fill(table)

            For Each row In table.Rows
                Populate(row(0), row(1), row(2), row(3), row(4), row(5), row(6), row(7), row(8), row(9), row(10))

            Next

            table.Rows.Clear()

            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connection.Close()
        End Try

    End Sub

    Private Sub cleartext()

        TFirstName.Text = ""
        TMiddle.Text = ""
        TLastName.Text = ""
        TPassword.Text = ""
        TCourse.Text = ""
        TYear.Text = ""
        TSection.Text = ""
        TStudentNumber.Text = ""
        CRole.Text = ""
        TStatus.Text = ""

    End Sub

    Private Sub UpdateDG(voters_id As String)
        Dim sql As String = "UPDATE voters SET first_name='" + TFirstName.Text + "', middle='" + TMiddle.Text + "', last_name='" + TLastName.Text + "',password= '" + TPassword.Text + "', course='" + TCourse.Text + "', year='" + TCourse.Text + "', section='" + TSection.Text + "', student_number='" + TStudentNumber.Text + "', role='" + CRole.Text + "', voter_status='" + TStatus.Text + "' WHERE voters_id='" + voters_id + "'"

        Try
            connection.Open()
            adapter.UpdateCommand = connection.CreateCommand()
            adapter.UpdateCommand.CommandText = sql
            If MessageBox.Show("Are you sure you want to update this?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.OK Then
                If adapter.UpdateCommand.ExecuteNonQuery() > 0 Then
                    MessageBox.Show("Successfully Updated!")
                    cleartext()
                    retrieve()
                    connection.Close()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            connection.Close()
        End Try
    End Sub

    Private Sub DeleteDG(voters_id As String)
        Dim sql As String = "DELETE FROM voters WHERE voters_id='" + voters_id + "'"
        cmd = New MySqlCommand(sql, connection)

        Try
            connection.Open()
            adapter.DeleteCommand = connection.CreateCommand()
            adapter.DeleteCommand.CommandText = sql

            If MessageBox.Show("Are you sure you want to delete this?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.OK Then
                If cmd.ExecuteNonQuery() > 0 Then
                    MessageBox.Show("Successfully Deleted!")
                    cleartext()
                End If
            End If

            connection.Close()
            retrieve()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            connection.Close()
        End Try

    End Sub

    Private Sub reset()
        Dim sql As String = "TRUNCATE voters"
        cmd = New MySqlCommand(sql, connection)

        Try
            connection.Open()
            adapter.DeleteCommand = connection.CreateCommand()
            adapter.DeleteCommand.CommandText = sql

            If MessageBox.Show("Are you sure you want to reset this table?", "Reset", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.OK Then
                If cmd.ExecuteNonQuery() > 0 Then
                    MessageBox.Show("Successfully Deleted!")
                    cleartext()
                End If
            End If

            connection.Close()
            retrieve()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            connection.Close()
        End Try
    End Sub


    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        Dim first_name As String = DataGridView1.SelectedRows(0).Cells(1).Value
        Dim middle As String = DataGridView1.SelectedRows(0).Cells(2).Value
        Dim last_name As String = DataGridView1.SelectedRows(0).Cells(3).Value
        Dim password As String = DataGridView1.SelectedRows(0).Cells(4).Value
        Dim course As String = DataGridView1.SelectedRows(0).Cells(5).Value
        Dim year As String = DataGridView1.SelectedRows(0).Cells(6).Value
        Dim section As String = DataGridView1.SelectedRows(0).Cells(7).Value
        Dim student_number As String = DataGridView1.SelectedRows(0).Cells(8).Value
        Dim role As String = DataGridView1.SelectedRows(0).Cells(9).Value
        Dim voter_status As String = DataGridView1.SelectedRows(0).Cells(10).Value

        TFirstName.Text = first_name
        TMiddle.Text = middle
        TLastName.Text = last_name
        TPassword.Text = password
        TCourse.Text = course
        TYear.Text = year
        TSection.Text = section
        TStudentNumber.Text = student_number
        CRole.Text = role
        TStatus.Text = voter_status

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim voters_id As String = DataGridView1.SelectedRows(0).Cells(0).Value
        UpdateDG(voters_id)
        retrieve()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        retrieve()
    End Sub

    Private Sub BReset_Click(sender As Object, e As EventArgs) Handles BReset.Click
        reset()
        retrieve()

    End Sub


   
End Class