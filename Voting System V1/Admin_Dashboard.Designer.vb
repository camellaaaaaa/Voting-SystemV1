<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_Dashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Profile = New System.Windows.Forms.Button()
        Me.CreateElection = New System.Windows.Forms.Button()
        Me.Registration = New System.Windows.Forms.Button()
        Me.Logout = New System.Windows.Forms.Button()
        Me.VoteResults = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(216, 33)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(96, 24)
        Me.Label19.TabIndex = 75
        Me.Label19.Text = "FirstName"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = Global.WindowsApplication1.My.Resources.Resources.icons8_create_24
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(105, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(324, 42)
        Me.Button1.TabIndex = 17
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Profile
        '
        Me.Profile.BackColor = System.Drawing.Color.OrangeRed
        Me.Profile.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Profile.FlatAppearance.BorderSize = 0
        Me.Profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Profile.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Profile.ForeColor = System.Drawing.Color.White
        Me.Profile.Image = Global.WindowsApplication1.My.Resources.Resources.icons8_edit_24
        Me.Profile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Profile.Location = New System.Drawing.Point(105, 336)
        Me.Profile.Name = "Profile"
        Me.Profile.Size = New System.Drawing.Size(324, 86)
        Me.Profile.TabIndex = 16
        Me.Profile.Text = "Change Password"
        Me.Profile.UseVisualStyleBackColor = False
        '
        'CreateElection
        '
        Me.CreateElection.BackColor = System.Drawing.Color.OrangeRed
        Me.CreateElection.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.CreateElection.FlatAppearance.BorderSize = 0
        Me.CreateElection.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CreateElection.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreateElection.ForeColor = System.Drawing.Color.White
        Me.CreateElection.Image = Global.WindowsApplication1.My.Resources.Resources.icons8_create_24
        Me.CreateElection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CreateElection.Location = New System.Drawing.Point(105, 247)
        Me.CreateElection.Name = "CreateElection"
        Me.CreateElection.Size = New System.Drawing.Size(324, 86)
        Me.CreateElection.TabIndex = 15
        Me.CreateElection.Text = "Create Election"
        Me.CreateElection.UseVisualStyleBackColor = False
        '
        'Registration
        '
        Me.Registration.BackColor = System.Drawing.Color.OrangeRed
        Me.Registration.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Registration.FlatAppearance.BorderSize = 0
        Me.Registration.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Registration.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Registration.ForeColor = System.Drawing.Color.White
        Me.Registration.Image = Global.WindowsApplication1.My.Resources.Resources.icons8_edit_24
        Me.Registration.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Registration.Location = New System.Drawing.Point(105, 158)
        Me.Registration.Name = "Registration"
        Me.Registration.Size = New System.Drawing.Size(324, 86)
        Me.Registration.TabIndex = 13
        Me.Registration.Text = "Registration"
        Me.Registration.UseVisualStyleBackColor = False
        '
        'Logout
        '
        Me.Logout.BackColor = System.Drawing.Color.DarkRed
        Me.Logout.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Logout.FlatAppearance.BorderSize = 0
        Me.Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Logout.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Logout.ForeColor = System.Drawing.Color.White
        Me.Logout.Image = Global.WindowsApplication1.My.Resources.Resources.icons8_logout_rounded_up_24
        Me.Logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Logout.Location = New System.Drawing.Point(105, 425)
        Me.Logout.Name = "Logout"
        Me.Logout.Size = New System.Drawing.Size(324, 43)
        Me.Logout.TabIndex = 14
        Me.Logout.Text = "Logout"
        Me.Logout.UseVisualStyleBackColor = False
        '
        'VoteResults
        '
        Me.VoteResults.BackColor = System.Drawing.Color.OrangeRed
        Me.VoteResults.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.VoteResults.FlatAppearance.BorderSize = 0
        Me.VoteResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.VoteResults.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VoteResults.ForeColor = System.Drawing.Color.White
        Me.VoteResults.Image = Global.WindowsApplication1.My.Resources.Resources.icons8_create_24
        Me.VoteResults.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.VoteResults.Location = New System.Drawing.Point(105, 69)
        Me.VoteResults.Name = "VoteResults"
        Me.VoteResults.Size = New System.Drawing.Size(324, 86)
        Me.VoteResults.TabIndex = 12
        Me.VoteResults.Text = "Vote Results"
        Me.VoteResults.UseVisualStyleBackColor = False
        '
        'Admin_Dashboard
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(535, 494)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Profile)
        Me.Controls.Add(Me.CreateElection)
        Me.Controls.Add(Me.Registration)
        Me.Controls.Add(Me.Logout)
        Me.Controls.Add(Me.VoteResults)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.MaximizeBox = False
        Me.Name = "Admin_Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin_Dashboard"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents VoteResults As System.Windows.Forms.Button
    Friend WithEvents Registration As System.Windows.Forms.Button
    Friend WithEvents Logout As System.Windows.Forms.Button
    Friend WithEvents CreateElection As System.Windows.Forms.Button
    Friend WithEvents Profile As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label19 As System.Windows.Forms.Label
End Class
