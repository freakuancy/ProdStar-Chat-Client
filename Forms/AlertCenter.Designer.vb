<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AlertCenter
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
        Me.cbLanguage = New System.Windows.Forms.CheckBox()
        Me.cbScrolling = New System.Windows.Forms.CheckBox()
        Me.cbHarrassment = New System.Windows.Forms.CheckBox()
        Me.cbOffensiveNick = New System.Windows.Forms.CheckBox()
        Me.cbImpersonating = New System.Windows.Forms.CheckBox()
        Me.cbInsults = New System.Windows.Forms.CheckBox()
        Me.cbDisruptive = New System.Windows.Forms.CheckBox()
        Me.cbRepugnant = New System.Windows.Forms.CheckBox()
        Me.cbOffensiveRoom = New System.Windows.Forms.CheckBox()
        Me.cbIllegal = New System.Windows.Forms.CheckBox()
        Me.cbOther = New System.Windows.Forms.CheckBox()
        Me.tbOther = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.bnCancel = New System.Windows.Forms.Button()
        Me.bnOkay = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tbAlertNicks = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(230, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Type the Nickname(s) violating Chat Guidelines"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(12, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nickname(s):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(12, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(244, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Indicate the type of violation (check all that apply):"
        '
        'cbLanguage
        '
        Me.cbLanguage.AutoSize = True
        Me.cbLanguage.BackColor = System.Drawing.Color.White
        Me.cbLanguage.ForeColor = System.Drawing.Color.Black
        Me.cbLanguage.Location = New System.Drawing.Point(12, 140)
        Me.cbLanguage.Name = "cbLanguage"
        Me.cbLanguage.Size = New System.Drawing.Size(74, 17)
        Me.cbLanguage.TabIndex = 4
        Me.cbLanguage.Text = "Language"
        Me.cbLanguage.UseVisualStyleBackColor = False
        '
        'cbScrolling
        '
        Me.cbScrolling.AutoSize = True
        Me.cbScrolling.BackColor = System.Drawing.Color.White
        Me.cbScrolling.ForeColor = System.Drawing.Color.Black
        Me.cbScrolling.Location = New System.Drawing.Point(12, 163)
        Me.cbScrolling.Name = "cbScrolling"
        Me.cbScrolling.Size = New System.Drawing.Size(66, 17)
        Me.cbScrolling.TabIndex = 5
        Me.cbScrolling.Text = "Scrolling"
        Me.cbScrolling.UseVisualStyleBackColor = False
        '
        'cbHarrassment
        '
        Me.cbHarrassment.AutoSize = True
        Me.cbHarrassment.BackColor = System.Drawing.Color.White
        Me.cbHarrassment.ForeColor = System.Drawing.Color.Black
        Me.cbHarrassment.Location = New System.Drawing.Point(12, 186)
        Me.cbHarrassment.Name = "cbHarrassment"
        Me.cbHarrassment.Size = New System.Drawing.Size(85, 17)
        Me.cbHarrassment.TabIndex = 6
        Me.cbHarrassment.Text = "Harrassment"
        Me.cbHarrassment.UseVisualStyleBackColor = False
        '
        'cbOffensiveNick
        '
        Me.cbOffensiveNick.AutoSize = True
        Me.cbOffensiveNick.BackColor = System.Drawing.Color.White
        Me.cbOffensiveNick.ForeColor = System.Drawing.Color.Black
        Me.cbOffensiveNick.Location = New System.Drawing.Point(12, 209)
        Me.cbOffensiveNick.Name = "cbOffensiveNick"
        Me.cbOffensiveNick.Size = New System.Drawing.Size(122, 17)
        Me.cbOffensiveNick.TabIndex = 7
        Me.cbOffensiveNick.Text = "Offensive Nickname"
        Me.cbOffensiveNick.UseVisualStyleBackColor = False
        '
        'cbImpersonating
        '
        Me.cbImpersonating.AutoSize = True
        Me.cbImpersonating.BackColor = System.Drawing.Color.White
        Me.cbImpersonating.ForeColor = System.Drawing.Color.Black
        Me.cbImpersonating.Location = New System.Drawing.Point(12, 232)
        Me.cbImpersonating.Name = "cbImpersonating"
        Me.cbImpersonating.Size = New System.Drawing.Size(169, 17)
        Me.cbImpersonating.TabIndex = 8
        Me.cbImpersonating.Text = "Impersonating Staff/Personnel"
        Me.cbImpersonating.UseVisualStyleBackColor = False
        '
        'cbInsults
        '
        Me.cbInsults.AutoSize = True
        Me.cbInsults.BackColor = System.Drawing.Color.White
        Me.cbInsults.ForeColor = System.Drawing.Color.Black
        Me.cbInsults.Location = New System.Drawing.Point(159, 140)
        Me.cbInsults.Name = "cbInsults"
        Me.cbInsults.Size = New System.Drawing.Size(56, 17)
        Me.cbInsults.TabIndex = 9
        Me.cbInsults.Text = "Insults"
        Me.cbInsults.UseVisualStyleBackColor = False
        '
        'cbDisruptive
        '
        Me.cbDisruptive.AutoSize = True
        Me.cbDisruptive.BackColor = System.Drawing.Color.White
        Me.cbDisruptive.ForeColor = System.Drawing.Color.Black
        Me.cbDisruptive.Location = New System.Drawing.Point(159, 163)
        Me.cbDisruptive.Name = "cbDisruptive"
        Me.cbDisruptive.Size = New System.Drawing.Size(113, 17)
        Me.cbDisruptive.TabIndex = 10
        Me.cbDisruptive.Text = "Distruptive Activity"
        Me.cbDisruptive.UseVisualStyleBackColor = False
        '
        'cbRepugnant
        '
        Me.cbRepugnant.AutoSize = True
        Me.cbRepugnant.BackColor = System.Drawing.Color.White
        Me.cbRepugnant.ForeColor = System.Drawing.Color.Black
        Me.cbRepugnant.Location = New System.Drawing.Point(159, 186)
        Me.cbRepugnant.Name = "cbRepugnant"
        Me.cbRepugnant.Size = New System.Drawing.Size(116, 17)
        Me.cbRepugnant.TabIndex = 11
        Me.cbRepugnant.Text = "Grossly Repugnant"
        Me.cbRepugnant.UseVisualStyleBackColor = False
        '
        'cbOffensiveRoom
        '
        Me.cbOffensiveRoom.AutoSize = True
        Me.cbOffensiveRoom.BackColor = System.Drawing.Color.White
        Me.cbOffensiveRoom.ForeColor = System.Drawing.Color.Black
        Me.cbOffensiveRoom.Location = New System.Drawing.Point(159, 209)
        Me.cbOffensiveRoom.Name = "cbOffensiveRoom"
        Me.cbOffensiveRoom.Size = New System.Drawing.Size(133, 17)
        Me.cbOffensiveRoom.TabIndex = 12
        Me.cbOffensiveRoom.Text = "Offensive Room Name"
        Me.cbOffensiveRoom.UseVisualStyleBackColor = False
        '
        'cbIllegal
        '
        Me.cbIllegal.AutoSize = True
        Me.cbIllegal.BackColor = System.Drawing.Color.White
        Me.cbIllegal.ForeColor = System.Drawing.Color.Black
        Me.cbIllegal.Location = New System.Drawing.Point(284, 140)
        Me.cbIllegal.Name = "cbIllegal"
        Me.cbIllegal.Size = New System.Drawing.Size(90, 17)
        Me.cbIllegal.TabIndex = 13
        Me.cbIllegal.Text = "Illegal Activity"
        Me.cbIllegal.UseVisualStyleBackColor = False
        '
        'cbOther
        '
        Me.cbOther.AutoSize = True
        Me.cbOther.BackColor = System.Drawing.Color.White
        Me.cbOther.ForeColor = System.Drawing.Color.Black
        Me.cbOther.Location = New System.Drawing.Point(12, 255)
        Me.cbOther.Name = "cbOther"
        Me.cbOther.Size = New System.Drawing.Size(55, 17)
        Me.cbOther.TabIndex = 14
        Me.cbOther.Text = "Other:"
        Me.cbOther.UseVisualStyleBackColor = False
        '
        'tbOther
        '
        Me.tbOther.BackColor = System.Drawing.Color.White
        Me.tbOther.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbOther.ForeColor = System.Drawing.Color.Black
        Me.tbOther.Location = New System.Drawing.Point(81, 258)
        Me.tbOther.MaxLength = 260
        Me.tbOther.Multiline = True
        Me.tbOther.Name = "tbOther"
        Me.tbOther.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbOther.Size = New System.Drawing.Size(218, 81)
        Me.tbOther.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(58, 344)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(264, 39)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Use the Alert function only to report problems in Chat Rooms. You may only send a" & _
    "n alert once per hour. "
        '
        'bnCancel
        '
        Me.bnCancel.BackColor = System.Drawing.Color.Gray
        Me.bnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.bnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnCancel.ForeColor = System.Drawing.Color.Black
        Me.bnCancel.Location = New System.Drawing.Point(221, 400)
        Me.bnCancel.Name = "bnCancel"
        Me.bnCancel.Size = New System.Drawing.Size(100, 29)
        Me.bnCancel.TabIndex = 17
        Me.bnCancel.Text = "Cancel"
        Me.bnCancel.UseVisualStyleBackColor = False
        '
        'bnOkay
        '
        Me.bnOkay.BackColor = System.Drawing.Color.White
        Me.bnOkay.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.bnOkay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnOkay.ForeColor = System.Drawing.Color.Black
        Me.bnOkay.Location = New System.Drawing.Point(60, 400)
        Me.bnOkay.Name = "bnOkay"
        Me.bnOkay.Size = New System.Drawing.Size(100, 29)
        Me.bnOkay.TabIndex = 18
        Me.bnOkay.Text = "Send Alert"
        Me.bnOkay.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(12, 344)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Note:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.tbAlertNicks)
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(95, 36)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(189, 65)
        Me.Panel1.TabIndex = 20
        '
        'tbAlertNicks
        '
        Me.tbAlertNicks.BackColor = System.Drawing.Color.White
        Me.tbAlertNicks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbAlertNicks.Location = New System.Drawing.Point(0, 0)
        Me.tbAlertNicks.Multiline = True
        Me.tbAlertNicks.Name = "tbAlertNicks"
        Me.tbAlertNicks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbAlertNicks.Size = New System.Drawing.Size(189, 65)
        Me.tbAlertNicks.TabIndex = 0
        '
        'AlertCenter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(381, 436)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.bnOkay)
        Me.Controls.Add(Me.bnCancel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbOther)
        Me.Controls.Add(Me.cbOther)
        Me.Controls.Add(Me.cbIllegal)
        Me.Controls.Add(Me.cbOffensiveRoom)
        Me.Controls.Add(Me.cbRepugnant)
        Me.Controls.Add(Me.cbDisruptive)
        Me.Controls.Add(Me.cbInsults)
        Me.Controls.Add(Me.cbImpersonating)
        Me.Controls.Add(Me.cbOffensiveNick)
        Me.Controls.Add(Me.cbHarrassment)
        Me.Controls.Add(Me.cbScrolling)
        Me.Controls.Add(Me.cbLanguage)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "AlertCenter"
        Me.ShowInTaskbar = False
        Me.Text = "Alert CHAT Host"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbLanguage As System.Windows.Forms.CheckBox
    Friend WithEvents cbScrolling As System.Windows.Forms.CheckBox
    Friend WithEvents cbHarrassment As System.Windows.Forms.CheckBox
    Friend WithEvents cbOffensiveNick As System.Windows.Forms.CheckBox
    Friend WithEvents cbImpersonating As System.Windows.Forms.CheckBox
    Friend WithEvents cbInsults As System.Windows.Forms.CheckBox
    Friend WithEvents cbDisruptive As System.Windows.Forms.CheckBox
    Friend WithEvents cbRepugnant As System.Windows.Forms.CheckBox
    Friend WithEvents cbOffensiveRoom As System.Windows.Forms.CheckBox
    Friend WithEvents cbIllegal As System.Windows.Forms.CheckBox
    Friend WithEvents cbOther As System.Windows.Forms.CheckBox
    Friend WithEvents tbOther As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents bnCancel As System.Windows.Forms.Button
    Friend WithEvents bnOkay As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents tbAlertNicks As System.Windows.Forms.TextBox
End Class
