<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RoomInfo
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
        Me.lblRoomCapacity = New System.Windows.Forms.Label()
        Me.lblPasswords = New System.Windows.Forms.Label()
        Me.lblCreatedBy = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlRoomOccupants = New System.Windows.Forms.Panel()
        Me.lbMembersHere = New System.Windows.Forms.ListBox()
        Me.lblOccupants = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.bnIMSend = New System.Windows.Forms.Button()
        Me.bnCancel = New System.Windows.Forms.Button()
        Me.pnlRoomOccupants.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblRoomCapacity
        '
        Me.lblRoomCapacity.BackColor = System.Drawing.Color.White
        Me.lblRoomCapacity.ForeColor = System.Drawing.Color.Black
        Me.lblRoomCapacity.Location = New System.Drawing.Point(151, 95)
        Me.lblRoomCapacity.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRoomCapacity.Name = "lblRoomCapacity"
        Me.lblRoomCapacity.Size = New System.Drawing.Size(223, 16)
        Me.lblRoomCapacity.TabIndex = 28
        '
        'lblPasswords
        '
        Me.lblPasswords.BackColor = System.Drawing.Color.White
        Me.lblPasswords.ForeColor = System.Drawing.Color.Black
        Me.lblPasswords.Location = New System.Drawing.Point(151, 38)
        Me.lblPasswords.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPasswords.Name = "lblPasswords"
        Me.lblPasswords.Size = New System.Drawing.Size(223, 16)
        Me.lblPasswords.TabIndex = 26
        '
        'lblCreatedBy
        '
        Me.lblCreatedBy.BackColor = System.Drawing.Color.White
        Me.lblCreatedBy.ForeColor = System.Drawing.Color.Black
        Me.lblCreatedBy.Location = New System.Drawing.Point(151, 10)
        Me.lblCreatedBy.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCreatedBy.Name = "lblCreatedBy"
        Me.lblCreatedBy.Size = New System.Drawing.Size(223, 16)
        Me.lblCreatedBy.TabIndex = 25
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(14, 151)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(169, 13)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Double click for member info"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(14, 126)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Participants:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(31, 94)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Capacity:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(16, 38)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Passwords:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(13, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Created By:"
        '
        'pnlRoomOccupants
        '
        Me.pnlRoomOccupants.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlRoomOccupants.Controls.Add(Me.lbMembersHere)
        Me.pnlRoomOccupants.Location = New System.Drawing.Point(19, 173)
        Me.pnlRoomOccupants.Name = "pnlRoomOccupants"
        Me.pnlRoomOccupants.Size = New System.Drawing.Size(355, 98)
        Me.pnlRoomOccupants.TabIndex = 30
        '
        'lbMembersHere
        '
        Me.lbMembersHere.BackColor = System.Drawing.Color.White
        Me.lbMembersHere.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbMembersHere.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbMembersHere.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMembersHere.ForeColor = System.Drawing.Color.Black
        Me.lbMembersHere.FormattingEnabled = True
        Me.lbMembersHere.Location = New System.Drawing.Point(0, 0)
        Me.lbMembersHere.Name = "lbMembersHere"
        Me.lbMembersHere.Size = New System.Drawing.Size(353, 96)
        Me.lbMembersHere.TabIndex = 1
        '
        'lblOccupants
        '
        Me.lblOccupants.BackColor = System.Drawing.Color.White
        Me.lblOccupants.ForeColor = System.Drawing.Color.Black
        Me.lblOccupants.Location = New System.Drawing.Point(151, 67)
        Me.lblOccupants.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOccupants.Name = "lblOccupants"
        Me.lblOccupants.Size = New System.Drawing.Size(223, 16)
        Me.lblOccupants.TabIndex = 32
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(16, 66)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Occupants:"
        '
        'bnIMSend
        '
        Me.bnIMSend.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.bnIMSend.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnIMSend.Location = New System.Drawing.Point(120, 277)
        Me.bnIMSend.Name = "bnIMSend"
        Me.bnIMSend.Size = New System.Drawing.Size(140, 29)
        Me.bnIMSend.TabIndex = 34
        Me.bnIMSend.Text = "Instant Message"
        Me.bnIMSend.UseVisualStyleBackColor = False
        '
        'bnCancel
        '
        Me.bnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.bnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnCancel.Location = New System.Drawing.Point(266, 277)
        Me.bnCancel.Name = "bnCancel"
        Me.bnCancel.Size = New System.Drawing.Size(108, 29)
        Me.bnCancel.TabIndex = 36
        Me.bnCancel.Text = "Cancel"
        Me.bnCancel.UseVisualStyleBackColor = False
        '
        'RoomInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(384, 316)
        Me.Controls.Add(Me.bnIMSend)
        Me.Controls.Add(Me.bnCancel)
        Me.Controls.Add(Me.lblOccupants)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.pnlRoomOccupants)
        Me.Controls.Add(Me.lblRoomCapacity)
        Me.Controls.Add(Me.lblPasswords)
        Me.Controls.Add(Me.lblCreatedBy)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Name = "RoomInfo"
        Me.ShowInTaskbar = False
        Me.Text = "Room Info"
        Me.pnlRoomOccupants.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblRoomCapacity As System.Windows.Forms.Label
    Friend WithEvents lblPasswords As System.Windows.Forms.Label
    Friend WithEvents lblCreatedBy As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pnlRoomOccupants As System.Windows.Forms.Panel
    Friend WithEvents lblOccupants As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents bnIMSend As System.Windows.Forms.Button
    Friend WithEvents bnCancel As System.Windows.Forms.Button
    Friend WithEvents lbMembersHere As System.Windows.Forms.ListBox
End Class
