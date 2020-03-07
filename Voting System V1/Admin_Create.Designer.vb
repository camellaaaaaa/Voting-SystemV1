<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_Create
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TStartDate = New System.Windows.Forms.DateTimePicker()
        Me.TEndDate = New System.Windows.Forms.DateTimePicker()
        Me.Update = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 24)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Start Date:"
        '
        'TStartDate
        '
        Me.TStartDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TStartDate.Location = New System.Drawing.Point(121, 38)
        Me.TStartDate.MinDate = New Date(2020, 1, 19, 0, 0, 0, 0)
        Me.TStartDate.Name = "TStartDate"
        Me.TStartDate.RightToLeftLayout = True
        Me.TStartDate.Size = New System.Drawing.Size(245, 22)
        Me.TStartDate.TabIndex = 0
        '
        'TEndDate
        '
        Me.TEndDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TEndDate.Location = New System.Drawing.Point(121, 76)
        Me.TEndDate.MinDate = New Date(2020, 1, 19, 0, 0, 0, 0)
        Me.TEndDate.Name = "TEndDate"
        Me.TEndDate.RightToLeftLayout = True
        Me.TEndDate.Size = New System.Drawing.Size(245, 22)
        Me.TEndDate.TabIndex = 26
        '
        'Update
        '
        Me.Update.BackColor = System.Drawing.Color.LimeGreen
        Me.Update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Update.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Update.ForeColor = System.Drawing.Color.White
        Me.Update.Location = New System.Drawing.Point(96, 120)
        Me.Update.Name = "Update"
        Me.Update.Size = New System.Drawing.Size(97, 35)
        Me.Update.TabIndex = 29
        Me.Update.Text = "Update"
        Me.Update.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 24)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "End Date:"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Firebrick
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button5.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(225, 120)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(97, 35)
        Me.Button5.TabIndex = 68
        Me.Button5.Text = "Cancel"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Admin_Create
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(388, 178)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Update)
        Me.Controls.Add(Me.TEndDate)
        Me.Controls.Add(Me.TStartDate)
        Me.Controls.Add(Me.Label4)
        Me.MaximizeBox = False
        Me.Name = "Admin_Create"
        Me.RightToLeftLayout = True
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Create Election"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents TEndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Update As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
End Class
