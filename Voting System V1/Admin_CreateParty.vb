Imports MySql.Data.MySqlClient


Public Class Admin_CreateParty

    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=vms")
    Dim i As Integer
    Dim cmd As New MySqlCommand
    Dim table As New DataTable
    Dim adapter As New MySqlDataAdapter


    Private Sub Admin_CreateParty_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.ColumnCount = 11

        DataGridView1.Columns(0).Name = "party_id"
        DataGridView1.Columns(1).Name = "party_name"


        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        retrieve()
    End Sub


    Private Sub Populate(party_id As String, party_name As String)
        Dim row As String() = New String() {party_id, party_name}
        DataGridView1.Rows.Add(row)
    End Sub

    Private Sub retrieve()

        DataGridView1.Rows.Clear()

        Dim sql As String = "SELECT party_id, party_name FROM party_name"
        cmd = New MySqlCommand(sql, connection)

        Try

            connection.Open()
            adapter = New MySqlDataAdapter(cmd)
            adapter.Fill(table)

            For Each row In table.Rows
                Populate(row(0), row(1))

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

        TPartyName.Text = ""
        

    End Sub

    Private Sub UpdateDG(party_id As String)
        Dim sql As String = "UPDATE party_name SET party_name='" + TPartyName.Text + "' WHERE party_id='" + party_id + "'"

        Try
            connection.Open()
            adapter.UpdateCommand = connection.CreateCommand()
            adapter.UpdateCommand.CommandText = sql
            If MessageBox.Show("Are you sure you want to update this?", "Update", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.OK Then
                If adapter.UpdateCommand.ExecuteNonQuery() > 0 Then
                    MessageBox.Show("Successfully Updated!")
                    cleartext()
                    connection.Close()
                    retrieve()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            connection.Close()
        End Try
    End Sub

    Private Sub DeleteDG(party_id As String)
        Dim sql As String = "DELETE FROM party_name WHERE party_id='" + party_id + "'"
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
        Dim sql As String = "TRUNCATE party_name"
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
        TPartyName.Text = party_name
     
    End Sub


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim party_id As String = DataGridView1.SelectedRows(0).Cells(0).Value
        UpdateDG(party_id)
        retrieve()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim party_id As String = DataGridView1.SelectedRows(0).Cells(0).Value
        DeleteDG(party_id)
        retrieve()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Register_Partylist.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        retrieve()
    End Sub

    Private Sub BReset_Click(sender As Object, e As EventArgs) Handles BReset.Click
        reset()
        retrieve()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Admin_Dashboard2.Show()
        Me.Hide()
    End Sub
End Class