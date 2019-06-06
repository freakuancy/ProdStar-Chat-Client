<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AreaRoomSelect
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
        Me.gbRoomType = New System.Windows.Forms.GroupBox()
        Me.rbAuditorium = New System.Windows.Forms.RadioButton()
        Me.rbMember = New System.Windows.Forms.RadioButton()
        Me.rbProdStar = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbRoomName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.bnGoRoom = New System.Windows.Forms.Button()
        Me.bnRoomInfo = New System.Windows.Forms.Button()
        Me.bnAlert = New System.Windows.Forms.Button()
        Me.bnHelp = New System.Windows.Forms.Button()
        Me.bnSetupOptions = New System.Windows.Forms.Button()
        Me.bnPrivateRoom = New System.Windows.Forms.Button()
        Me.bnCreateRoom = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbRooms = New System.Windows.Forms.ListBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbAreaSelect = New System.Windows.Forms.ListBox()
        Me.bnCloseRoom = New System.Windows.Forms.Button()
        Me.bnAdminJoin = New System.Windows.Forms.Button()
        Me.gbRoomType.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(7, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select an Area:"
        '
        'gbRoomType
        '
        Me.gbRoomType.BackColor = System.Drawing.Color.White
        Me.gbRoomType.Controls.Add(Me.rbAuditorium)
        Me.gbRoomType.Controls.Add(Me.rbMember)
        Me.gbRoomType.Controls.Add(Me.rbProdStar)
        Me.gbRoomType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbRoomType.ForeColor = System.Drawing.Color.Black
        Me.gbRoomType.Location = New System.Drawing.Point(340, 12)
        Me.gbRoomType.Name = "gbRoomType"
        Me.gbRoomType.Size = New System.Drawing.Size(291, 70)
        Me.gbRoomType.TabIndex = 2
        Me.gbRoomType.TabStop = False
        Me.gbRoomType.Text = "Room Type:"
        '
        'rbAuditorium
        '
        Me.rbAuditorium.AutoSize = True
        Me.rbAuditorium.BackColor = System.Drawing.Color.White
        Me.rbAuditorium.ForeColor = System.Drawing.Color.Black
        Me.rbAuditorium.Location = New System.Drawing.Point(192, 32)
        Me.rbAuditorium.Name = "rbAuditorium"
        Me.rbAuditorium.Size = New System.Drawing.Size(94, 19)
        Me.rbAuditorium.TabIndex = 3
        Me.rbAuditorium.TabStop = True
        Me.rbAuditorium.Text = "Auditorium"
        Me.rbAuditorium.UseVisualStyleBackColor = False
        '
        'rbMember
        '
        Me.rbMember.AutoSize = True
        Me.rbMember.BackColor = System.Drawing.Color.White
        Me.rbMember.ForeColor = System.Drawing.Color.Black
        Me.rbMember.Location = New System.Drawing.Point(100, 32)
        Me.rbMember.Name = "rbMember"
        Me.rbMember.Size = New System.Drawing.Size(78, 19)
        Me.rbMember.TabIndex = 1
        Me.rbMember.TabStop = True
        Me.rbMember.Text = "Member"
        Me.rbMember.UseVisualStyleBackColor = False
        '
        'rbProdStar
        '
        Me.rbProdStar.AutoSize = True
        Me.rbProdStar.BackColor = System.Drawing.Color.White
        Me.rbProdStar.ForeColor = System.Drawing.Color.Black
        Me.rbProdStar.Location = New System.Drawing.Point(6, 32)
        Me.rbProdStar.Name = "rbProdStar"
        Me.rbProdStar.Size = New System.Drawing.Size(81, 19)
        Me.rbProdStar.TabIndex = 0
        Me.rbProdStar.Text = "ProdStar"
        Me.rbProdStar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(7, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Room Name"
        '
        'tbRoomName
        '
        Me.tbRoomName.BackColor = System.Drawing.Color.White
        Me.tbRoomName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbRoomName.ForeColor = System.Drawing.Color.Black
        Me.tbRoomName.Location = New System.Drawing.Point(10, 148)
        Me.tbRoomName.Name = "tbRoomName"
        Me.tbRoomName.Size = New System.Drawing.Size(263, 21)
        Me.tbRoomName.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(279, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Chat/Max/Passwords"
        '
        'bnGoRoom
        '
        Me.bnGoRoom.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.bnGoRoom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnGoRoom.Location = New System.Drawing.Point(502, 102)
        Me.bnGoRoom.Name = "bnGoRoom"
        Me.bnGoRoom.Size = New System.Drawing.Size(129, 29)
        Me.bnGoRoom.TabIndex = 9
        Me.bnGoRoom.Text = "Go to Room"
        Me.bnGoRoom.UseVisualStyleBackColor = False
        '
        'bnRoomInfo
        '
        Me.bnRoomInfo.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.bnRoomInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnRoomInfo.Location = New System.Drawing.Point(502, 137)
        Me.bnRoomInfo.Name = "bnRoomInfo"
        Me.bnRoomInfo.Size = New System.Drawing.Size(129, 29)
        Me.bnRoomInfo.TabIndex = 10
        Me.bnRoomInfo.Text = "Room Info"
        Me.bnRoomInfo.UseVisualStyleBackColor = False
        '
        'bnAlert
        '
        Me.bnAlert.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.bnAlert.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnAlert.Location = New System.Drawing.Point(73, 312)
        Me.bnAlert.Name = "bnAlert"
        Me.bnAlert.Size = New System.Drawing.Size(51, 29)
        Me.bnAlert.TabIndex = 17
        Me.bnAlert.Text = "Alert"
        Me.bnAlert.UseVisualStyleBackColor = False
        '
        'bnHelp
        '
        Me.bnHelp.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.bnHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnHelp.Location = New System.Drawing.Point(10, 313)
        Me.bnHelp.Name = "bnHelp"
        Me.bnHelp.Size = New System.Drawing.Size(57, 28)
        Me.bnHelp.TabIndex = 16
        Me.bnHelp.Text = "Help"
        Me.bnHelp.UseVisualStyleBackColor = False
        '
        'bnSetupOptions
        '
        Me.bnSetupOptions.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.bnSetupOptions.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnSetupOptions.Location = New System.Drawing.Point(502, 278)
        Me.bnSetupOptions.Name = "bnSetupOptions"
        Me.bnSetupOptions.Size = New System.Drawing.Size(129, 29)
        Me.bnSetupOptions.TabIndex = 14
        Me.bnSetupOptions.Text = "Set-Up Options"
        Me.bnSetupOptions.UseVisualStyleBackColor = False
        '
        'bnPrivateRoom
        '
        Me.bnPrivateRoom.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.bnPrivateRoom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnPrivateRoom.Location = New System.Drawing.Point(502, 242)
        Me.bnPrivateRoom.Name = "bnPrivateRoom"
        Me.bnPrivateRoom.Size = New System.Drawing.Size(129, 29)
        Me.bnPrivateRoom.TabIndex = 13
        Me.bnPrivateRoom.Text = "Private Room"
        Me.bnPrivateRoom.UseVisualStyleBackColor = False
        '
        'bnCreateRoom
        '
        Me.bnCreateRoom.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.bnCreateRoom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnCreateRoom.Location = New System.Drawing.Point(502, 172)
        Me.bnCreateRoom.Name = "bnCreateRoom"
        Me.bnCreateRoom.Size = New System.Drawing.Size(129, 29)
        Me.bnCreateRoom.TabIndex = 11
        Me.bnCreateRoom.Text = "Create a Room"
        Me.bnCreateRoom.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(549, 312)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 29)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(502, 207)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(129, 29)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = "Instant Message"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lbRooms)
        Me.Panel1.Location = New System.Drawing.Point(12, 172)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(481, 134)
        Me.Panel1.TabIndex = 19
        '
        'lbRooms
        '
        Me.lbRooms.BackColor = System.Drawing.Color.White
        Me.lbRooms.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbRooms.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbRooms.ForeColor = System.Drawing.Color.Black
        Me.lbRooms.FormattingEnabled = True
        Me.lbRooms.ItemHeight = 15
        Me.lbRooms.Location = New System.Drawing.Point(0, 0)
        Me.lbRooms.Name = "lbRooms"
        Me.lbRooms.Size = New System.Drawing.Size(481, 134)
        Me.lbRooms.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lbAreaSelect)
        Me.Panel2.Location = New System.Drawing.Point(12, 20)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(319, 110)
        Me.Panel2.TabIndex = 20
        '
        'lbAreaSelect
        '
        Me.lbAreaSelect.BackColor = System.Drawing.Color.White
        Me.lbAreaSelect.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbAreaSelect.ForeColor = System.Drawing.Color.Black
        Me.lbAreaSelect.FormattingEnabled = True
        Me.lbAreaSelect.ItemHeight = 15
        Me.lbAreaSelect.Location = New System.Drawing.Point(0, 0)
        Me.lbAreaSelect.Name = "lbAreaSelect"
        Me.lbAreaSelect.Size = New System.Drawing.Size(319, 110)
        Me.lbAreaSelect.TabIndex = 1
        '
        'bnCloseRoom
        '
        Me.bnCloseRoom.BackColor = System.Drawing.Color.Silver
        Me.bnCloseRoom.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.bnCloseRoom.FlatAppearance.BorderSize = 2
        Me.bnCloseRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bnCloseRoom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnCloseRoom.Location = New System.Drawing.Point(406, 313)
        Me.bnCloseRoom.Name = "bnCloseRoom"
        Me.bnCloseRoom.Size = New System.Drawing.Size(87, 29)
        Me.bnCloseRoom.TabIndex = 21
        Me.bnCloseRoom.Text = "Close Room"
        Me.bnCloseRoom.UseVisualStyleBackColor = False
        '
        'bnAdminJoin
        '
        Me.bnAdminJoin.BackColor = System.Drawing.Color.Silver
        Me.bnAdminJoin.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.bnAdminJoin.FlatAppearance.BorderSize = 2
        Me.bnAdminJoin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bnAdminJoin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnAdminJoin.Location = New System.Drawing.Point(313, 313)
        Me.bnAdminJoin.Name = "bnAdminJoin"
        Me.bnAdminJoin.Size = New System.Drawing.Size(87, 29)
        Me.bnAdminJoin.TabIndex = 22
        Me.bnAdminJoin.Text = "Admin Join"
        Me.bnAdminJoin.UseVisualStyleBackColor = False
        '
        'AreaRoomSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(637, 348)
        Me.Controls.Add(Me.bnAdminJoin)
        Me.Controls.Add(Me.bnCloseRoom)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.bnGoRoom)
        Me.Controls.Add(Me.bnRoomInfo)
        Me.Controls.Add(Me.bnCreateRoom)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.bnPrivateRoom)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.bnSetupOptions)
        Me.Controls.Add(Me.bnHelp)
        Me.Controls.Add(Me.bnAlert)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbRoomName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.gbRoomType)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "AreaRoomSelect"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Area and Room List"
        Me.gbRoomType.ResumeLayout(False)
        Me.gbRoomType.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gbRoomType As System.Windows.Forms.GroupBox
    Friend WithEvents rbAuditorium As System.Windows.Forms.RadioButton
    Friend WithEvents rbMember As System.Windows.Forms.RadioButton
    Friend WithEvents rbProdStar As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbRoomName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents bnGoRoom As System.Windows.Forms.Button
    Friend WithEvents bnRoomInfo As System.Windows.Forms.Button
    Friend WithEvents bnAlert As System.Windows.Forms.Button
    Friend WithEvents bnHelp As System.Windows.Forms.Button
    Friend WithEvents bnSetupOptions As System.Windows.Forms.Button
    Friend WithEvents bnPrivateRoom As System.Windows.Forms.Button
    Friend WithEvents bnCreateRoom As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lbRooms As System.Windows.Forms.ListBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lbAreaSelect As System.Windows.Forms.ListBox
    Friend WithEvents bnCloseRoom As System.Windows.Forms.Button
    Friend WithEvents bnAdminJoin As System.Windows.Forms.Button
End Class
