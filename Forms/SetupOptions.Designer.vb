<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SetupOptions
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
        Me.lblNickName = New System.Windows.Forms.Label()
        Me.chkClearBetweenRooms = New System.Windows.Forms.CheckBox()
        Me.chkDoubleSpace = New System.Windows.Forms.CheckBox()
        Me.chkActivateSounds = New System.Windows.Forms.CheckBox()
        Me.chkDisplayMemberID = New System.Windows.Forms.CheckBox()
        Me.chkNotifyLeave = New System.Windows.Forms.CheckBox()
        Me.chkNotifyArrive = New System.Windows.Forms.CheckBox()
        Me.chkAllowIMS = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.bnSave = New System.Windows.Forms.Button()
        Me.bnCancel = New System.Windows.Forms.Button()
        Me.lbID = New System.Windows.Forms.Label()
        Me.tbInterests = New System.Windows.Forms.TextBox()
        Me.tbCityState = New System.Windows.Forms.TextBox()
        Me.bnChatType = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(35, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nickname:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(10, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "City and State:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(42, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Interests:"
        '
        'lblNickName
        '
        Me.lblNickName.AutoSize = True
        Me.lblNickName.ForeColor = System.Drawing.Color.Black
        Me.lblNickName.Location = New System.Drawing.Point(135, 20)
        Me.lblNickName.Name = "lblNickName"
        Me.lblNickName.Size = New System.Drawing.Size(69, 13)
        Me.lblNickName.TabIndex = 3
        Me.lblNickName.Text = "Nick Name"
        '
        'chkClearBetweenRooms
        '
        Me.chkClearBetweenRooms.AutoSize = True
        Me.chkClearBetweenRooms.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkClearBetweenRooms.ForeColor = System.Drawing.Color.Black
        Me.chkClearBetweenRooms.Location = New System.Drawing.Point(27, 359)
        Me.chkClearBetweenRooms.Margin = New System.Windows.Forms.Padding(4)
        Me.chkClearBetweenRooms.Name = "chkClearBetweenRooms"
        Me.chkClearBetweenRooms.Size = New System.Drawing.Size(199, 17)
        Me.chkClearBetweenRooms.TabIndex = 10
        Me.chkClearBetweenRooms.Text = "Clear Chat text between rooms"
        Me.chkClearBetweenRooms.UseVisualStyleBackColor = False
        '
        'chkDoubleSpace
        '
        Me.chkDoubleSpace.AutoSize = True
        Me.chkDoubleSpace.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDoubleSpace.ForeColor = System.Drawing.Color.Black
        Me.chkDoubleSpace.Location = New System.Drawing.Point(27, 337)
        Me.chkDoubleSpace.Margin = New System.Windows.Forms.Padding(4)
        Me.chkDoubleSpace.Name = "chkDoubleSpace"
        Me.chkDoubleSpace.Size = New System.Drawing.Size(203, 17)
        Me.chkDoubleSpace.TabIndex = 9
        Me.chkDoubleSpace.Text = "Double space text within rooms"
        Me.chkDoubleSpace.UseVisualStyleBackColor = False
        '
        'chkActivateSounds
        '
        Me.chkActivateSounds.AutoSize = True
        Me.chkActivateSounds.Checked = True
        Me.chkActivateSounds.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkActivateSounds.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkActivateSounds.ForeColor = System.Drawing.Color.Black
        Me.chkActivateSounds.Location = New System.Drawing.Point(27, 315)
        Me.chkActivateSounds.Margin = New System.Windows.Forms.Padding(4)
        Me.chkActivateSounds.Name = "chkActivateSounds"
        Me.chkActivateSounds.Size = New System.Drawing.Size(212, 17)
        Me.chkActivateSounds.TabIndex = 8
        Me.chkActivateSounds.Text = "Activate sound files (if available)"
        Me.chkActivateSounds.UseVisualStyleBackColor = False
        '
        'chkDisplayMemberID
        '
        Me.chkDisplayMemberID.AutoSize = True
        Me.chkDisplayMemberID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDisplayMemberID.ForeColor = System.Drawing.Color.Black
        Me.chkDisplayMemberID.Location = New System.Drawing.Point(27, 293)
        Me.chkDisplayMemberID.Margin = New System.Windows.Forms.Padding(4)
        Me.chkDisplayMemberID.Name = "chkDisplayMemberID"
        Me.chkDisplayMemberID.Size = New System.Drawing.Size(201, 17)
        Me.chkDisplayMemberID.TabIndex = 7
        Me.chkDisplayMemberID.Text = "Allow display of my member ID:"
        Me.chkDisplayMemberID.UseVisualStyleBackColor = False
        '
        'chkNotifyLeave
        '
        Me.chkNotifyLeave.AutoSize = True
        Me.chkNotifyLeave.Checked = True
        Me.chkNotifyLeave.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkNotifyLeave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkNotifyLeave.ForeColor = System.Drawing.Color.Black
        Me.chkNotifyLeave.Location = New System.Drawing.Point(27, 271)
        Me.chkNotifyLeave.Margin = New System.Windows.Forms.Padding(4)
        Me.chkNotifyLeave.Name = "chkNotifyLeave"
        Me.chkNotifyLeave.Size = New System.Drawing.Size(221, 17)
        Me.chkNotifyLeave.TabIndex = 6
        Me.chkNotifyLeave.Text = "Notify me as members leave rooms"
        Me.chkNotifyLeave.UseVisualStyleBackColor = False
        '
        'chkNotifyArrive
        '
        Me.chkNotifyArrive.AutoSize = True
        Me.chkNotifyArrive.Checked = True
        Me.chkNotifyArrive.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkNotifyArrive.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkNotifyArrive.ForeColor = System.Drawing.Color.Black
        Me.chkNotifyArrive.Location = New System.Drawing.Point(27, 249)
        Me.chkNotifyArrive.Margin = New System.Windows.Forms.Padding(4)
        Me.chkNotifyArrive.Name = "chkNotifyArrive"
        Me.chkNotifyArrive.Size = New System.Drawing.Size(245, 17)
        Me.chkNotifyArrive.TabIndex = 5
        Me.chkNotifyArrive.Text = "Notify me as members come into rooms"
        Me.chkNotifyArrive.UseVisualStyleBackColor = False
        '
        'chkAllowIMS
        '
        Me.chkAllowIMS.AutoSize = True
        Me.chkAllowIMS.Checked = True
        Me.chkAllowIMS.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAllowIMS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAllowIMS.ForeColor = System.Drawing.Color.Black
        Me.chkAllowIMS.Location = New System.Drawing.Point(27, 227)
        Me.chkAllowIMS.Margin = New System.Windows.Forms.Padding(4)
        Me.chkAllowIMS.Name = "chkAllowIMS"
        Me.chkAllowIMS.Size = New System.Drawing.Size(276, 17)
        Me.chkAllowIMS.TabIndex = 4
        Me.chkAllowIMS.Text = "Allow members to send me instant messages"
        Me.chkAllowIMS.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(3, 202)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(149, 13)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Room/Auditorium Display"
        '
        'bnSave
        '
        Me.bnSave.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.bnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnSave.Location = New System.Drawing.Point(195, 485)
        Me.bnSave.Name = "bnSave"
        Me.bnSave.Size = New System.Drawing.Size(102, 28)
        Me.bnSave.TabIndex = 3
        Me.bnSave.Text = "Save Settings"
        Me.bnSave.UseVisualStyleBackColor = False
        '
        'bnCancel
        '
        Me.bnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.bnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnCancel.Location = New System.Drawing.Point(303, 485)
        Me.bnCancel.Name = "bnCancel"
        Me.bnCancel.Size = New System.Drawing.Size(100, 29)
        Me.bnCancel.TabIndex = 12
        Me.bnCancel.Text = "Cancel"
        Me.bnCancel.UseVisualStyleBackColor = False
        '
        'lbID
        '
        Me.lbID.AutoSize = True
        Me.lbID.ForeColor = System.Drawing.Color.Black
        Me.lbID.Location = New System.Drawing.Point(284, 294)
        Me.lbID.Name = "lbID"
        Me.lbID.Size = New System.Drawing.Size(61, 13)
        Me.lbID.TabIndex = 48
        Me.lbID.Text = "AAAA01A"
        '
        'tbInterests
        '
        Me.tbInterests.BackColor = System.Drawing.Color.White
        Me.tbInterests.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbInterests.Location = New System.Drawing.Point(108, 95)
        Me.tbInterests.MaxLength = 300
        Me.tbInterests.Multiline = True
        Me.tbInterests.Name = "tbInterests"
        Me.tbInterests.Size = New System.Drawing.Size(295, 93)
        Me.tbInterests.TabIndex = 2
        '
        'tbCityState
        '
        Me.tbCityState.BackColor = System.Drawing.Color.White
        Me.tbCityState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbCityState.Location = New System.Drawing.Point(107, 55)
        Me.tbCityState.MaxLength = 100
        Me.tbCityState.Name = "tbCityState"
        Me.tbCityState.Size = New System.Drawing.Size(296, 19)
        Me.tbCityState.TabIndex = 1
        '
        'bnChatType
        '
        Me.bnChatType.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.bnChatType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnChatType.Location = New System.Drawing.Point(301, 378)
        Me.bnChatType.Name = "bnChatType"
        Me.bnChatType.Size = New System.Drawing.Size(100, 29)
        Me.bnChatType.TabIndex = 11
        Me.bnChatType.Text = "More Options..."
        Me.bnChatType.UseVisualStyleBackColor = False
        '
        'SetupOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(413, 520)
        Me.Controls.Add(Me.bnChatType)
        Me.Controls.Add(Me.tbCityState)
        Me.Controls.Add(Me.tbInterests)
        Me.Controls.Add(Me.bnSave)
        Me.Controls.Add(Me.bnCancel)
        Me.Controls.Add(Me.lbID)
        Me.Controls.Add(Me.chkClearBetweenRooms)
        Me.Controls.Add(Me.chkDoubleSpace)
        Me.Controls.Add(Me.chkActivateSounds)
        Me.Controls.Add(Me.chkDisplayMemberID)
        Me.Controls.Add(Me.chkNotifyLeave)
        Me.Controls.Add(Me.chkNotifyArrive)
        Me.Controls.Add(Me.chkAllowIMS)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblNickName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Name = "SetupOptions"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Set-Up Options"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblNickName As System.Windows.Forms.Label
    Friend WithEvents chkClearBetweenRooms As System.Windows.Forms.CheckBox
    Friend WithEvents chkDoubleSpace As System.Windows.Forms.CheckBox
    Friend WithEvents chkActivateSounds As System.Windows.Forms.CheckBox
    Friend WithEvents chkDisplayMemberID As System.Windows.Forms.CheckBox
    Friend WithEvents chkNotifyLeave As System.Windows.Forms.CheckBox
    Friend WithEvents chkNotifyArrive As System.Windows.Forms.CheckBox
    Friend WithEvents chkAllowIMS As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents bnSave As System.Windows.Forms.Button
    Friend WithEvents bnCancel As System.Windows.Forms.Button
    Friend WithEvents lbID As System.Windows.Forms.Label
    Friend WithEvents tbInterests As System.Windows.Forms.TextBox
    Friend WithEvents tbCityState As System.Windows.Forms.TextBox
    Friend WithEvents bnChatType As System.Windows.Forms.Button
End Class
