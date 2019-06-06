<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminDisconnectUser
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
        Me.bnDisconnectUser = New System.Windows.Forms.Button()
        Me.tbNameToDisconnect = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbReasonForDisconnect = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'bnDisconnectUser
        '
        Me.bnDisconnectUser.BackColor = System.Drawing.Color.Silver
        Me.bnDisconnectUser.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.bnDisconnectUser.FlatAppearance.BorderSize = 2
        Me.bnDisconnectUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bnDisconnectUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnDisconnectUser.Location = New System.Drawing.Point(445, 134)
        Me.bnDisconnectUser.Name = "bnDisconnectUser"
        Me.bnDisconnectUser.Size = New System.Drawing.Size(142, 29)
        Me.bnDisconnectUser.TabIndex = 3
        Me.bnDisconnectUser.Text = "Disconnect User"
        Me.bnDisconnectUser.UseVisualStyleBackColor = False
        '
        'tbNameToDisconnect
        '
        Me.tbNameToDisconnect.BackColor = System.Drawing.Color.White
        Me.tbNameToDisconnect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbNameToDisconnect.Location = New System.Drawing.Point(122, 8)
        Me.tbNameToDisconnect.MaxLength = 300
        Me.tbNameToDisconnect.Multiline = True
        Me.tbNameToDisconnect.Name = "tbNameToDisconnect"
        Me.tbNameToDisconnect.Size = New System.Drawing.Size(465, 21)
        Me.tbNameToDisconnect.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 13)
        Me.Label1.TabIndex = 80
        Me.Label1.Text = "User Chat Name:"
        '
        'tbReasonForDisconnect
        '
        Me.tbReasonForDisconnect.BackColor = System.Drawing.Color.White
        Me.tbReasonForDisconnect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbReasonForDisconnect.Location = New System.Drawing.Point(122, 35)
        Me.tbReasonForDisconnect.MaxLength = 300
        Me.tbReasonForDisconnect.Multiline = True
        Me.tbReasonForDisconnect.Name = "tbReasonForDisconnect"
        Me.tbReasonForDisconnect.Size = New System.Drawing.Size(465, 93)
        Me.tbReasonForDisconnect.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(61, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 78
        Me.Label3.Text = "Reason:"
        '
        'AdminDisconnectUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(600, 175)
        Me.Controls.Add(Me.bnDisconnectUser)
        Me.Controls.Add(Me.tbNameToDisconnect)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbReasonForDisconnect)
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "AdminDisconnectUser"
        Me.Text = "Disconnect User"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bnDisconnectUser As System.Windows.Forms.Button
    Friend WithEvents tbNameToDisconnect As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbReasonForDisconnect As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
