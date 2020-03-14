Imports MySql.Data.MySqlClient


Public Class Admin_CreateCandidate

    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=vms")
    Dim i As Integer
    Dim cmd As New MySqlCommand
    Dim table As New DataTable
    Dim adapter As New MySqlDataAdapter

    Private Sub Admin_Candidate_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DataGridView1.ColumnCount = 9

        DataGridView1.Columns(0).Name = "candidate_id"
        DataGridView1.Columns(1).Name = "party_name"
        DataGridView1.Columns(2).Name = "position"
        DataGridView1.Columns(3).Name = "first_name"
        DataGridView1.Columns(4).Name = "middle"
        DataGridView1.Columns(5).Name = "last_name"
        DataGridView1.Columns(6).Name = "course"
        DataGridView1.Columns(7).Name = "year"
        DataGridView1.Columns(8).Name = "section"

        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        Dim adapter As New MySqlDataAdapter("SELECT `pos_id`, `position` FROM position", connection)
        Dim adapter1 As New MySqlDataAdapter("SELECT `party_id`, `party_name` FROM party_name", connection)
        Dim table As New DataTable
        Dim table1 As New DataTable

        adapter.Fill(table)
        adapter1.Fill(table1)

        CPosition.DataSource = table
        CPosition.ValueMember = "position"
        CPosition.DisplayMember = "position"


        CPartyName.DataSource = table1
        CPartyName.ValueMember = "party_name"
        CPartyName.DisplayMember = "party_name"

        retrieve()

    End Sub


    Private Sub Create_Click(sender As Object, e As EventArgs) Handles Create.Click
        Register_Candidate.Show()
        Me.Hide()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim candidate_id As String = DataGridView1.SelectedRows(0).Cells(0).Value
        DeleteDG(candidate_id)
        retrieve()


    End Sub

    Private Sub Populate(candidate_id As String, party_name As String, position As String, first_name As String, middle As String, last_name As String, course As String, year As String, section As String)
        Dim row As String() = New String() {candidate_id, party_name, position, first_name, middle, last_name, course, year, section}
        DataGridView1.Rows.Add(row)
    End Sub

    Private Sub retrieve()

        DataGridView1.Rows.Clear()

        Dim sql As String = "SELECT candidate_id, party_name, position, first_name, middle, last_name, course, year, section FROM candidate"
        cmd = New MySqlCommand(sql, connection)

        Try

            connection.Open()
            adapter = New MySqlDataAdapter(cmd)
            adapter.Fill(table)

            For Each row In table.Rows
                Populate(row(0), row(1), row(2), row(3), row(4), row(5), row(6), row(7), row(8))

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
        CPartyName.Text = ""
        CPosition.Text = ""
        TFirstName.Text = ""
        TMiddle.Text = ""
        TLastName.Text = ""
        TCourse.Text = ""
        TYear.Text = ""
        TSection.Text = ""

    End Sub

    Private Sub UpdateDG(candidate_id As String)

        Dim testString As String
        testString = Space(1)

        Dim sql As String = "UPDATE candidate SET party_name='" + CPartyName.Text + "', position='" + CPosition.Text + "', first_name='" + TFirstName.Text + "', middle='" + TMiddle.Text + "', last_name='" + TLastName.Text + "', course='" + TCourse.Text + "', year='" + TYear.Text + "', section='" + TSection.Text + "', full_name='" + TFirstName.Text + testString + TMiddle.Text + testString + TLastName.Text + "' WHERE candidate_id='" + candidate_id + "'"

        Try
            connection.Open()
            adapter.UpdateCommand = connection.CreateCommand()
            adapter.UpdateCommand.CommandText = sql
            If MessageBox.Show("Are you sure you want to update this?", "Update", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.OK Then
                If adapter.UpdateCommand.ExecuteNonQuery() > 0 Then
                    MessageBox.Show("Successfully Updated!")
                    cleartext()
                    connection.Close()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            connection.Close()
        End Try
    End Sub

    Private Sub DeleteDG(candidate_id As String)
        Dim sql As String = "DELETE FROM candidate WHERE candidate_id='" + candidate_id + "'"
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
        Dim sql As String = "TRUNCATE candidate"
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
        Dim party_name As String = DataGridView1.SelectedRows(0).Cells(1).Value
        Dim position As String = DataGridView1.SelectedRows(0).Cells(2).Value
        Dim first_name As String = DataGridView1.SelectedRows(0).Cells(3).Value
        Dim middle As String = DataGridView1.SelectedRows(0).Cells(4).Value
        Dim last_name As String = DataGridView1.SelectedRows(0).Cells(5).Value
        Dim course As String = DataGridView1.SelectedRows(0).Cells(6).Value
        Dim year As String = DataGridView1.SelectedRows(0).Cells(7).Value
        Dim section As String = DataGridView1.SelectedRows(0).Cells(8).Value

        CPartyName.Text = party_name
        CPosition.Text = position
        TFirstName.Text = first_name
        TMiddle.Text = middle
        TLastName.Text = last_name
        TCourse.Text = course
        TYear.Text = year
        TSection.Text = section

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim candidate_id As String = DataGridView1.SelectedRows(0).Cells(0).Value
        UpdateDG(candidate_id)
        retrieve()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        retrieve()
    End Sub

    Private Sub BReset_Click(sender As Object, e As EventArgs) Handles BReset.Click
        reset()
        retrieve()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Admin_Dashboard2.Show()
        Me.Hide()
    End Sub
End Class