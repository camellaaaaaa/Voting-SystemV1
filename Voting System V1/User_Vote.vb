Imports MySql.Data.MySqlClient

Public Class User_Vote
    Public Property FirstName As String
    Public GlobalFirstName As String
    Public Property StudentNum As String
    Public GlobalStudentNum As String
 
    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=vms")


    Public Sub User_Vote_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GlobalFirstName = User_Login.GlobalFirstName
        GlobalStudentNum = User_Login.GlobalStudentNum
        Label20.Text = GlobalFirstName
        Label21.Text = GlobalStudentNum
        DateBox.Text = DateTime.Now.ToString("yyyy-MM-dd, HH:MM:ss")



        Dim adapter1 As New MySqlDataAdapter("SELECT 'party_name', `full_name` FROM candidate WHERE position='President'", connection)
        Dim adapter2 As New MySqlDataAdapter("SELECT 'party_name',`full_name` FROM candidate WHERE position='Executive Vice President'", connection)
        Dim adapter3 As New MySqlDataAdapter("SELECT 'party_name',`full_name` FROM candidate WHERE position='Vice President for Academic Affairs'", connection)
        Dim adapter4 As New MySqlDataAdapter("SELECT 'party_name',`full_name` FROM candidate WHERE position='Vice President for Student Affairs'", connection)
        Dim adapter5 As New MySqlDataAdapter("SELECT 'party_name',`full_name` FROM candidate WHERE position='Vice President for Research and Development'", connection)
        Dim adapter6 As New MySqlDataAdapter("SELECT 'party_name',`full_name` FROM candidate WHERE position='Vice President for Organization Relation'", connection)
        Dim adapter7 As New MySqlDataAdapter("SELECT 'party_name',`full_name` FROM candidate WHERE position='Secretary General'", connection)
        Dim adapter8 As New MySqlDataAdapter("SELECT 'party_name',`full_name` FROM candidate WHERE position='Treasurer'", connection)
        Dim adapter9 As New MySqlDataAdapter("SELECT 'party_name',`full_name` FROM candidate WHERE position='Auditor'", connection)
        Dim adapter10 As New MySqlDataAdapter("SELECT 'party_name',`full_name` FROM candidate WHERE position='Business Manager'", connection)
        Dim adapter11 As New MySqlDataAdapter("SELECT 'party_name',`full_name` FROM candidate WHERE position='Control Officer'", connection)
        Dim adapter12 As New MySqlDataAdapter("SELECT 'party_name',`full_name` FROM candidate WHERE position='Head Governor'", connection)
        Dim adapter13 As New MySqlDataAdapter("SELECT 'party_name',`full_name` FROM candidate WHERE position='5th Year Governor'", connection)
        Dim adapter14 As New MySqlDataAdapter("SELECT 'party_name',`full_name` FROM candidate WHERE position='4th Year Governor'", connection)
        Dim adapter15 As New MySqlDataAdapter("SELECT 'party_name',`full_name` FROM candidate WHERE position='3rd Year Governor'", connection)
        Dim adapter16 As New MySqlDataAdapter("SELECT 'party_name',`full_name` FROM candidate WHERE position='2nd Year Governor'", connection)



        Dim table1 As New DataTable()
        Dim table2 As New DataTable()
        Dim table3 As New DataTable()
        Dim table4 As New DataTable()
        Dim table5 As New DataTable()
        Dim table6 As New DataTable()
        Dim table7 As New DataTable()
        Dim table8 As New DataTable()
        Dim table9 As New DataTable()
        Dim table10 As New DataTable()
        Dim table11 As New DataTable()
        Dim table12 As New DataTable()
        Dim table13 As New DataTable()
        Dim table14 As New DataTable()
        Dim table15 As New DataTable()
        Dim table16 As New DataTable()


        adapter1.Fill(table1)
        adapter2.Fill(table2)
        adapter3.Fill(table3)
        adapter4.Fill(table4)
        adapter5.Fill(table5)
        adapter6.Fill(table6)
        adapter7.Fill(table7)
        adapter8.Fill(table8)
        adapter9.Fill(table9)
        adapter10.Fill(table10)
        adapter11.Fill(table11)
        adapter12.Fill(table12)
        adapter13.Fill(table13)
        adapter14.Fill(table14)
        adapter15.Fill(table15)
        adapter16.Fill(table16)

        ComboBox2.DataSource = table1
        ComboBox2.ValueMember = "full_name"
        ComboBox2.DisplayMember = "full_name"


        ComboBox3.DataSource = table2
        ComboBox3.ValueMember = "full_name"
        ComboBox3.DisplayMember = "full_name"

        ComboBox4.DataSource = table3
        ComboBox4.ValueMember = "full_name"
        ComboBox4.DisplayMember = "full_name"

        ComboBox5.DataSource = table4
        ComboBox5.ValueMember = "full_name"
        ComboBox5.DisplayMember = "full_name"

        ComboBox6.DataSource = table5
        ComboBox6.ValueMember = "full_name"
        ComboBox6.DisplayMember = "full_name"

        ComboBox7.DataSource = table6
        ComboBox7.ValueMember = "full_name"
        ComboBox7.DisplayMember = "full_name"

        ComboBox8.DataSource = table7
        ComboBox8.ValueMember = "full_name"
        ComboBox8.DisplayMember = "full_name"

        ComboBox9.DataSource = table8
        ComboBox9.ValueMember = "full_name"
        ComboBox9.DisplayMember = "full_name"

        ComboBox10.DataSource = table9
        ComboBox10.ValueMember = "full_name"
        ComboBox10.DisplayMember = "full_name"

        ComboBox11.DataSource = table10
        ComboBox11.ValueMember = "full_name"
        ComboBox11.DisplayMember = "full_name"

        ComboBox12.DataSource = table11
        ComboBox12.ValueMember = "full_name"
        ComboBox12.DisplayMember = "full_name"

        ComboBox13.DataSource = table12
        ComboBox13.ValueMember = "full_name"
        ComboBox13.DisplayMember = "full_name"

        ComboBox14.DataSource = table13
        ComboBox14.ValueMember = "full_name"
        ComboBox14.DisplayMember = "full_name"

        ComboBox15.DataSource = table14
        ComboBox15.ValueMember = "full_name"
        ComboBox15.DisplayMember = "full_name"

        ComboBox16.DataSource = table15
        ComboBox16.ValueMember = "full_name"
        ComboBox16.DisplayMember = "full_name"

        ComboBox17.DataSource = table16
        ComboBox17.ValueMember = "full_name"
        ComboBox17.DisplayMember = "full_name"

    End Sub

    Private Sub cleartext()

        ComboBox2.Text = ""
        ComboBox3.Text = ""
        ComboBox4.Text = ""
        ComboBox5.Text = ""
        ComboBox6.Text = ""
        ComboBox7.Text = ""
        ComboBox8.Text = ""
        ComboBox9.Text = ""
        ComboBox10.Text = ""
        ComboBox11.Text = ""
        ComboBox12.Text = ""
        ComboBox13.Text = ""
        ComboBox14.Text = ""
        ComboBox15.Text = ""
        ComboBox16.Text = ""
        ComboBox17.Text = ""
        

    End Sub


    Private Sub insertvote()
        connection.Close()
        Dim command1 As New MySqlCommand("INSERT INTO `vote_logs` (president,vp_executive,vp_academic,vp_student,vp_relation,vp_organization,secretary,treasurer,auditor,business,control,head,second,third,fourth,fifth,voter_name,voter_student_num,date) values(@president,@executive,@academic,@student,@relation,@organization,@secretary,@treasurer,@auditor,@business,@control,@head,@2nd,@3rd,@4th,@5th,@voter_name,@voter_student_num,@date)", connection)


        command1.Parameters.AddWithValue("@president", ComboBox2.SelectedValue)
        command1.Parameters.AddWithValue("@executive", ComboBox3.SelectedValue)
        command1.Parameters.AddWithValue("@academic", ComboBox4.SelectedValue)
        command1.Parameters.AddWithValue("@student", ComboBox5.SelectedValue)
        command1.Parameters.AddWithValue("@relation", ComboBox6.SelectedValue)
        command1.Parameters.AddWithValue("@organization", ComboBox7.SelectedValue)
        command1.Parameters.AddWithValue("@secretary", ComboBox8.SelectedValue)
        command1.Parameters.AddWithValue("@treasurer", ComboBox9.SelectedValue)
        command1.Parameters.AddWithValue("@auditor", ComboBox10.SelectedValue)
        command1.Parameters.AddWithValue("@business", ComboBox11.SelectedValue)
        command1.Parameters.AddWithValue("@control", ComboBox12.SelectedValue)
        command1.Parameters.AddWithValue("@head", ComboBox13.SelectedValue)
        command1.Parameters.AddWithValue("@2nd", ComboBox14.SelectedValue)
        command1.Parameters.AddWithValue("@3rd", ComboBox15.SelectedValue)
        command1.Parameters.AddWithValue("@4th", ComboBox16.SelectedValue)
        command1.Parameters.AddWithValue("@5th", ComboBox17.SelectedValue)
        command1.Parameters.AddWithValue("@voter_name", Label20.Text)
        command1.Parameters.AddWithValue("@voter_student_num", Label21.Text)
        command1.Parameters.AddWithValue("@date", DateBox.Text)

        connection.Open()
        command1.ExecuteNonQuery()
        connection.Close()


    End Sub

   
    Private Sub Update_Click(sender As Object, e As EventArgs) Handles Vote.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to proceed?",
                           "Title",
                           MessageBoxButtons.YesNo)

        If (result = DialogResult.Yes) Then
            Try

                Dim command As New MySqlCommand("UPDATE candidate SET vote = vote + 1 WHERE full_name = @president OR full_name=@executive OR full_name=@academic OR full_name=@student OR full_name=@relation OR full_name=@organization OR full_name=@secretary OR full_name=@treasurer OR full_name=@auditor OR full_name=@business OR full_name=@control OR full_name=@head OR full_name=@5th OR full_name=@4th OR full_name=@3rd OR full_name=@2nd", connection)

                command.Parameters.AddWithValue("@president", ComboBox2.SelectedValue)
                command.Parameters.AddWithValue("@executive", ComboBox3.SelectedValue)
                command.Parameters.AddWithValue("@academic", ComboBox4.SelectedValue)
                command.Parameters.AddWithValue("@student", ComboBox5.SelectedValue)
                command.Parameters.AddWithValue("@relation", ComboBox6.SelectedValue)
                command.Parameters.AddWithValue("@organization", ComboBox7.SelectedValue)
                command.Parameters.AddWithValue("@secretary", ComboBox8.SelectedValue)
                command.Parameters.AddWithValue("@treasurer", ComboBox9.SelectedValue)
                command.Parameters.AddWithValue("@auditor", ComboBox10.SelectedValue)
                command.Parameters.AddWithValue("@business", ComboBox11.SelectedValue)
                command.Parameters.AddWithValue("@control", ComboBox12.SelectedValue)
                command.Parameters.AddWithValue("@head", ComboBox13.SelectedValue)
                command.Parameters.AddWithValue("@2nd", ComboBox14.SelectedValue)
                command.Parameters.AddWithValue("@3rd", ComboBox15.SelectedValue)
                command.Parameters.AddWithValue("@4th", ComboBox16.SelectedValue)
                command.Parameters.AddWithValue("@5th", ComboBox17.SelectedValue)

                connection.Open()
                command.ExecuteNonQuery()
                connection.Close()
                insertvote()
                updatevoterstatus()


                MessageBox.Show("Successfully Voted!")
                User_Success.Show()
                Me.Hide()


            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If


    End Sub

    Private Sub updatevoterstatus()
        connection.Open()
        Dim command As New MySqlCommand("UPDATE voters SET voter_status = 'VOTED' WHERE student_number  = '" + Label21.Text + "'", connection)

        command.ExecuteNonQuery()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        User_StraightVote.Show()
        Me.Hide()
    End Sub

  
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        DateBox.Text = DateTime.Now.ToString("yyyy-MM-dd,HH:MM")
    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles DateBox.Click

    End Sub
End Class