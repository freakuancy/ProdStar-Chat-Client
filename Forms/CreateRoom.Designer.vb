<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateRoom
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbChatArea = New System.Windows.Forms.ListBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbMakeNativeRoom = New System.Windows.Forms.RadioButton()
        Me.cbListNames = New System.Windows.Forms.CheckBox()
        Me.rbPrivate = New System.Windows.Forms.RadioButton()
        Me.rbListed = New System.Windows.Forms.RadioButton()
        Me.tbCapacity = New System.Windows.Forms.TextBox()
        Me.tbRoomName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.tbTextPass = New System.Windows.Forms.TextBox()
        Me.tbEntryPass = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.bnOkay = New System.Windows.Forms.Button()
        Me.bnCancel = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.lbChatArea)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(11, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(433, 108)
        Me.GroupBox1.TabIndex = 95
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select a Chat Area:"
        '
        'lbChatArea
        '
        Me.lbChatArea.BackColor = System.Drawing.Color.White
        Me.lbChatArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbChatArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbChatArea.ForeColor = System.Drawing.Color.Black
        Me.lbChatArea.FormattingEnabled = True
        Me.lbChatArea.Location = New System.Drawing.Point(163, 17)
        Me.lbChatArea.Name = "lbChatArea"
        Me.lbChatArea.ScrollAlwaysVisible = True
        Me.lbChatArea.Size = New System.Drawing.Size(252, 80)
        Me.lbChatArea.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.rbMakeNativeRoom)
        Me.GroupBox2.Controls.Add(Me.cbListNames)
        Me.GroupBox2.Controls.Add(Me.rbPrivate)
        Me.GroupBox2.Controls.Add(Me.rbListed)
        Me.GroupBox2.Controls.Add(Me.tbCapacity)
        Me.GroupBox2.Controls.Add(Me.tbRoomName)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(11, 126)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(433, 106)
        Me.GroupBox2.TabIndex = 94
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Create a room:"
        '
        'rbMakeNativeRoom
        '
        Me.rbMakeNativeRoom.AutoSize = True
        Me.rbMakeNativeRoom.BackColor = System.Drawing.Color.White
        Me.rbMakeNativeRoom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbMakeNativeRoom.ForeColor = System.Drawing.Color.Red
        Me.rbMakeNativeRoom.Location = New System.Drawing.Point(307, 53)
        Me.rbMakeNativeRoom.Name = "rbMakeNativeRoom"
        Me.rbMakeNativeRoom.Size = New System.Drawing.Size(104, 17)
        Me.rbMakeNativeRoom.TabIndex = 99
        Me.rbMakeNativeRoom.Text = "Communicator"
        Me.rbMakeNativeRoom.UseVisualStyleBackColor = False
        '
        'cbListNames
        '
        Me.cbListNames.AutoSize = True
        Me.cbListNames.BackColor = System.Drawing.Color.White
        Me.cbListNames.Checked = True
        Me.cbListNames.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbListNames.ForeColor = System.Drawing.Color.Black
        Me.cbListNames.Location = New System.Drawing.Point(98, 81)
        Me.cbListNames.Name = "cbListNames"
        Me.cbListNames.Size = New System.Drawing.Size(271, 17)
        Me.cbListNames.TabIndex = 98
        Me.cbListNames.Text = "Display participant Nicknames in Room List"
        Me.cbListNames.UseVisualStyleBackColor = False
        '
        'rbPrivate
        '
        Me.rbPrivate.AutoSize = True
        Me.rbPrivate.BackColor = System.Drawing.Color.White
        Me.rbPrivate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbPrivate.ForeColor = System.Drawing.Color.Black
        Me.rbPrivate.Location = New System.Drawing.Point(163, 55)
        Me.rbPrivate.Name = "rbPrivate"
        Me.rbPrivate.Size = New System.Drawing.Size(65, 17)
        Me.rbPrivate.TabIndex = 3
        Me.rbPrivate.Text = "Private"
        Me.rbPrivate.UseVisualStyleBackColor = False
        '
        'rbListed
        '
        Me.rbListed.AutoSize = True
        Me.rbListed.BackColor = System.Drawing.Color.White
        Me.rbListed.Checked = True
        Me.rbListed.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbListed.ForeColor = System.Drawing.Color.Black
        Me.rbListed.Location = New System.Drawing.Point(98, 55)
        Me.rbListed.Name = "rbListed"
        Me.rbListed.Size = New System.Drawing.Size(59, 17)
        Me.rbListed.TabIndex = 2
        Me.rbListed.TabStop = True
        Me.rbListed.Text = "Listed"
        Me.rbListed.UseVisualStyleBackColor = False
        '
        'tbCapacity
        '
        Me.tbCapacity.BackColor = System.Drawing.Color.White
        Me.tbCapacity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbCapacity.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCapacity.ForeColor = System.Drawing.Color.Black
        Me.tbCapacity.Location = New System.Drawing.Point(338, 22)
        Me.tbCapacity.Name = "tbCapacity"
        Me.tbCapacity.Size = New System.Drawing.Size(34, 20)
        Me.tbCapacity.TabIndex = 1
        Me.tbCapacity.Text = "25"
        Me.tbCapacity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbRoomName
        '
        Me.tbRoomName.BackColor = System.Drawing.Color.White
        Me.tbRoomName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbRoomName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbRoomName.ForeColor = System.Drawing.Color.Black
        Me.tbRoomName.Location = New System.Drawing.Point(93, 22)
        Me.tbRoomName.Name = "tbRoomName"
        Me.tbRoomName.Size = New System.Drawing.Size(163, 20)
        Me.tbRoomName.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(12, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Room Type:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(273, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 96
        Me.Label2.Text = "Capacity:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(8, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 97
        Me.Label1.Text = "Room Name:"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.tbTextPass)
        Me.GroupBox3.Controls.Add(Me.tbEntryPass)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(12, 238)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(432, 93)
        Me.GroupBox3.TabIndex = 93
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Passwords:"
        '
        'tbTextPass
        '
        Me.tbTextPass.BackColor = System.Drawing.Color.White
        Me.tbTextPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbTextPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTextPass.ForeColor = System.Drawing.Color.Black
        Me.tbTextPass.Location = New System.Drawing.Point(275, 58)
        Me.tbTextPass.Name = "tbTextPass"
        Me.tbTextPass.Size = New System.Drawing.Size(140, 20)
        Me.tbTextPass.TabIndex = 5
        '
        'tbEntryPass
        '
        Me.tbEntryPass.BackColor = System.Drawing.Color.White
        Me.tbEntryPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbEntryPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbEntryPass.ForeColor = System.Drawing.Color.Black
        Me.tbEntryPass.Location = New System.Drawing.Point(275, 26)
        Me.tbEntryPass.Name = "tbEntryPass"
        Me.tbEntryPass.Size = New System.Drawing.Size(140, 20)
        Me.tbEntryPass.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(33, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(238, 13)
        Me.Label4.TabIndex = 98
        Me.Label4.Text = "To restrict Room Entry, type a password:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(6, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(265, 13)
        Me.Label3.TabIndex = 99
        Me.Label3.Text = "To restrict Text Submission, type a password:"
        '
        'bnOkay
        '
        Me.bnOkay.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.bnOkay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnOkay.Location = New System.Drawing.Point(278, 337)
        Me.bnOkay.Name = "bnOkay"
        Me.bnOkay.Size = New System.Drawing.Size(77, 27)
        Me.bnOkay.TabIndex = 7
        Me.bnOkay.Text = "&OK"
        Me.bnOkay.UseVisualStyleBackColor = False
        '
        'bnCancel
        '
        Me.bnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.bnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnCancel.Location = New System.Drawing.Point(361, 337)
        Me.bnCancel.Name = "bnCancel"
        Me.bnCancel.Size = New System.Drawing.Size(81, 27)
        Me.bnCancel.TabIndex = 6
        Me.bnCancel.Text = "&Cancel"
        Me.bnCancel.UseVisualStyleBackColor = False
        '
        'CreateRoom
        '
        Me.AcceptButton = Me.bnOkay
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.bnCancel
        Me.ClientSize = New System.Drawing.Size(456, 369)
        Me.Controls.Add(Me.bnCancel)
        Me.Controls.Add(Me.bnOkay)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "CreateRoom"
        Me.ShowInTaskbar = False
        Me.Text = "Create a Member Room"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbChatArea As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rbPrivate As System.Windows.Forms.RadioButton
    Friend WithEvents rbListed As System.Windows.Forms.RadioButton
    Friend WithEvents tbCapacity As System.Windows.Forms.TextBox
    Friend WithEvents tbRoomName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbTextPass As System.Windows.Forms.TextBox
    Friend WithEvents tbEntryPass As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents bnOkay As System.Windows.Forms.Button
    Friend WithEvents bnCancel As System.Windows.Forms.Button
    Friend WithEvents cbListNames As System.Windows.Forms.CheckBox
    Friend WithEvents rbMakeNativeRoom As System.Windows.Forms.RadioButton
End Class
