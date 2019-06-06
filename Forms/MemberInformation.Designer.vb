<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MemberInformation
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbInterests = New System.Windows.Forms.Label()
        Me.lblCityState = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblNickName = New System.Windows.Forms.Label()
        Me.bnIM = New System.Windows.Forms.Button()
        Me.bnContinue = New System.Windows.Forms.Button()
        Me.bnDisconnectUser = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(44, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nickname:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(37, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Member ID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(12, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "City and State:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(51, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Interests:"
        '
        'lbInterests
        '
        Me.lbInterests.ForeColor = System.Drawing.Color.Black
        Me.lbInterests.Location = New System.Drawing.Point(143, 109)
        Me.lbInterests.Name = "lbInterests"
        Me.lbInterests.Size = New System.Drawing.Size(203, 73)
        Me.lbInterests.TabIndex = 4
        Me.lbInterests.Text = "We were unable to update your member information.  Please try again later."
        '
        'lblCityState
        '
        Me.lblCityState.AutoSize = True
        Me.lblCityState.ForeColor = System.Drawing.Color.Black
        Me.lblCityState.Location = New System.Drawing.Point(143, 77)
        Me.lblCityState.Name = "lblCityState"
        Me.lblCityState.Size = New System.Drawing.Size(62, 13)
        Me.lblCityState.TabIndex = 5
        Me.lblCityState.Text = "City State"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.ForeColor = System.Drawing.Color.Black
        Me.lblID.Location = New System.Drawing.Point(143, 45)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(30, 13)
        Me.lblID.TabIndex = 6
        Me.lblID.Text = "N/A"
        '
        'lblNickName
        '
        Me.lblNickName.AutoSize = True
        Me.lblNickName.ForeColor = System.Drawing.Color.Black
        Me.lblNickName.Location = New System.Drawing.Point(143, 13)
        Me.lblNickName.Name = "lblNickName"
        Me.lblNickName.Size = New System.Drawing.Size(69, 13)
        Me.lblNickName.TabIndex = 7
        Me.lblNickName.Text = "Nick Name"
        '
        'bnIM
        '
        Me.bnIM.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.bnIM.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnIM.Location = New System.Drawing.Point(146, 204)
        Me.bnIM.Name = "bnIM"
        Me.bnIM.Size = New System.Drawing.Size(116, 26)
        Me.bnIM.TabIndex = 12
        Me.bnIM.Text = "Instant Message"
        Me.bnIM.UseVisualStyleBackColor = False
        '
        'bnContinue
        '
        Me.bnContinue.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.bnContinue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnContinue.Location = New System.Drawing.Point(268, 204)
        Me.bnContinue.Name = "bnContinue"
        Me.bnContinue.Size = New System.Drawing.Size(81, 26)
        Me.bnContinue.TabIndex = 12
        Me.bnContinue.Text = "Continue"
        Me.bnContinue.UseVisualStyleBackColor = False
        '
        'bnDisconnectUser
        '
        Me.bnDisconnectUser.BackColor = System.Drawing.Color.Silver
        Me.bnDisconnectUser.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.bnDisconnectUser.FlatAppearance.BorderSize = 2
        Me.bnDisconnectUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bnDisconnectUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnDisconnectUser.Location = New System.Drawing.Point(7, 204)
        Me.bnDisconnectUser.Name = "bnDisconnectUser"
        Me.bnDisconnectUser.Size = New System.Drawing.Size(124, 26)
        Me.bnDisconnectUser.TabIndex = 22
        Me.bnDisconnectUser.Text = "Disconnect User"
        Me.bnDisconnectUser.UseVisualStyleBackColor = False
        '
        'MemberInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(358, 242)
        Me.Controls.Add(Me.bnDisconnectUser)
        Me.Controls.Add(Me.bnContinue)
        Me.Controls.Add(Me.bnIM)
        Me.Controls.Add(Me.lblNickName)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.lblCityState)
        Me.Controls.Add(Me.lbInterests)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Name = "MemberInformation"
        Me.ShowInTaskbar = False
        Me.Text = "Member Information"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbInterests As System.Windows.Forms.Label
    Friend WithEvents lblCityState As System.Windows.Forms.Label
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents lblNickName As System.Windows.Forms.Label
    Friend WithEvents bnIM As System.Windows.Forms.Button
    Friend WithEvents bnContinue As System.Windows.Forms.Button
    Friend WithEvents bnDisconnectUser As System.Windows.Forms.Button
End Class
