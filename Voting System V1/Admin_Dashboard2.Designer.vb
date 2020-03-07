<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_Dashboard2
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
        Me.Candidates = New System.Windows.Forms.Button()
        Me.VoteResults = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Candidates
        '
        Me.Candidates.BackColor = System.Drawing.Color.OrangeRed
        Me.Candidates.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Candidates.FlatAppearance.BorderSize = 0
        Me.Candidates.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Candidates.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Candidates.ForeColor = System.Drawing.Color.White
        Me.Candidates.Image = Global.WindowsApplication1.My.Resources.Resources.icons8_edit_24
        Me.Candidates.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Candidates.Location = New System.Drawing.Point(-3, 176)
        Me.Candidates.Name = "Candidates"
        Me.Candidates.Size = New System.Drawing.Size(262, 86)
        Me.Candidates.TabIndex = 16
        Me.Candidates.Text = "Voters"
        Me.Candidates.UseVisualStyleBackColor = False
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
        Me.VoteResults.Location = New System.Drawing.Point(-3, 88)
        Me.VoteResults.Name = "VoteResults"
        Me.VoteResults.Size = New System.Drawing.Size(262, 86)
        Me.VoteResults.TabIndex = 15
        Me.VoteResults.Text = "Candidates"
        Me.VoteResults.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.OrangeRed
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = Global.WindowsApplication1.My.Resources.Resources.icons8_home_24
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(-3, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(262, 86)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Partylist"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Gray
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Image = Global.WindowsApplication1.My.Resources.Resources.icons8_edit_24
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(-3, 265)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(262, 40)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Go Back"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Admin_Dashboard2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(258, 305)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Candidates)
        Me.Controls.Add(Me.VoteResults)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Admin_Dashboard2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Register"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Candidates As System.Windows.Forms.Button
    Friend WithEvents VoteResults As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
