<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangePassword
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
        Me.lblCurPW = New System.Windows.Forms.Label()
        Me.tbCurrentPassword = New System.Windows.Forms.TextBox()
        Me.tbNewPassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbNewPasswordConfirmation = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bnOkay = New System.Windows.Forms.Button()
        Me.bnCancel = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblCurPW
        '
        Me.lblCurPW.AutoSize = True
        Me.lblCurPW.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurPW.ForeColor = System.Drawing.Color.Black
        Me.lblCurPW.Location = New System.Drawing.Point(50, 100)
        Me.lblCurPW.Name = "lblCurPW"
        Me.lblCurPW.Size = New System.Drawing.Size(114, 13)
        Me.lblCurPW.TabIndex = 99
        Me.lblCurPW.Text = "Current Password: "
        '
        'tbCurrentPassword
        '
        Me.tbCurrentPassword.BackColor = System.Drawing.Color.White
        Me.tbCurrentPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbCurrentPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tbCurrentPassword.ForeColor = System.Drawing.Color.Black
        Me.tbCurrentPassword.Location = New System.Drawing.Point(186, 96)
        Me.tbCurrentPassword.Margin = New System.Windows.Forms.Padding(2)
        Me.tbCurrentPassword.Name = "tbCurrentPassword"
        Me.tbCurrentPassword.Size = New System.Drawing.Size(123, 20)
        Me.tbCurrentPassword.TabIndex = 100
        Me.tbCurrentPassword.UseSystemPasswordChar = True
        '
        'tbNewPassword
        '
        Me.tbNewPassword.BackColor = System.Drawing.Color.White
        Me.tbNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbNewPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tbNewPassword.ForeColor = System.Drawing.Color.Black
        Me.tbNewPassword.Location = New System.Drawing.Point(186, 129)
        Me.tbNewPassword.Margin = New System.Windows.Forms.Padding(2)
        Me.tbNewPassword.Name = "tbNewPassword"
        Me.tbNewPassword.Size = New System.Drawing.Size(123, 20)
        Me.tbNewPassword.TabIndex = 102
        Me.tbNewPassword.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(70, 133)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 101
        Me.Label1.Text = "New Password:"
        '
        'tbNewPasswordConfirmation
        '
        Me.tbNewPasswordConfirmation.BackColor = System.Drawing.Color.White
        Me.tbNewPasswordConfirmation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbNewPasswordConfirmation.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tbNewPasswordConfirmation.ForeColor = System.Drawing.Color.Black
        Me.tbNewPasswordConfirmation.Location = New System.Drawing.Point(186, 158)
        Me.tbNewPasswordConfirmation.Margin = New System.Windows.Forms.Padding(2)
        Me.tbNewPasswordConfirmation.Name = "tbNewPasswordConfirmation"
        Me.tbNewPasswordConfirmation.Size = New System.Drawing.Size(123, 20)
        Me.tbNewPasswordConfirmation.TabIndex = 104
        Me.tbNewPasswordConfirmation.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(24, 162)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 13)
        Me.Label2.TabIndex = 103
        Me.Label2.Text = "Confirm New Password:"
        '
        'bnOkay
        '
        Me.bnOkay.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.bnOkay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnOkay.Location = New System.Drawing.Point(97, 203)
        Me.bnOkay.Name = "bnOkay"
        Me.bnOkay.Size = New System.Drawing.Size(67, 27)
        Me.bnOkay.TabIndex = 105
        Me.bnOkay.Text = "&OK"
        Me.bnOkay.UseVisualStyleBackColor = False
        '
        'bnCancel
        '
        Me.bnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.bnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnCancel.Location = New System.Drawing.Point(186, 203)
        Me.bnCancel.Name = "bnCancel"
        Me.bnCancel.Size = New System.Drawing.Size(67, 27)
        Me.bnCancel.TabIndex = 106
        Me.bnCancel.Text = "&Cancel"
        Me.bnCancel.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(16, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(300, 78)
        Me.Label3.TabIndex = 107
        Me.Label3.Text = "In order to change your password, you must first provide your current password. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Please choose a password at least 8 characters in length. Letters, numbers an" & _
    "d symbols are allowed."
        '
        'ChangePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(332, 235)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.bnCancel)
        Me.Controls.Add(Me.bnOkay)
        Me.Controls.Add(Me.tbNewPasswordConfirmation)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbNewPassword)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbCurrentPassword)
        Me.Controls.Add(Me.lblCurPW)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "ChangePassword"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.Text = "Change Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCurPW As System.Windows.Forms.Label
    Friend WithEvents tbCurrentPassword As System.Windows.Forms.TextBox
    Friend WithEvents tbNewPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbNewPasswordConfirmation As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents bnOkay As System.Windows.Forms.Button
    Friend WithEvents bnCancel As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
