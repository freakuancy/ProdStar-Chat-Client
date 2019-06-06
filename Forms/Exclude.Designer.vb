<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Exclude
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
        Me.rbView = New System.Windows.Forms.RadioButton()
        Me.rbRoom = New System.Windows.Forms.RadioButton()
        Me.rbChat = New System.Windows.Forms.RadioButton()
        Me.cbRefuse = New System.Windows.Forms.CheckBox()
        Me.bnOkay = New System.Windows.Forms.Button()
        Me.bnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(251, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Messages from nickname can be excluded."
        '
        'rbView
        '
        Me.rbView.AutoSize = True
        Me.rbView.Checked = True
        Me.rbView.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbView.ForeColor = System.Drawing.Color.Black
        Me.rbView.Location = New System.Drawing.Point(15, 47)
        Me.rbView.Name = "rbView"
        Me.rbView.Size = New System.Drawing.Size(231, 17)
        Me.rbView.TabIndex = 1
        Me.rbView.TabStop = True
        Me.rbView.Text = "View all messages from this member."
        Me.rbView.UseVisualStyleBackColor = False
        '
        'rbRoom
        '
        Me.rbRoom.AutoSize = True
        Me.rbRoom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbRoom.ForeColor = System.Drawing.Color.Black
        Me.rbRoom.Location = New System.Drawing.Point(15, 70)
        Me.rbRoom.Name = "rbRoom"
        Me.rbRoom.Size = New System.Drawing.Size(250, 17)
        Me.rbRoom.TabIndex = 2
        Me.rbRoom.Text = "Ignore messages until I leave this room."
        Me.rbRoom.UseVisualStyleBackColor = False
        '
        'rbChat
        '
        Me.rbChat.AutoSize = True
        Me.rbChat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbChat.ForeColor = System.Drawing.Color.Black
        Me.rbChat.Location = New System.Drawing.Point(15, 93)
        Me.rbChat.Name = "rbChat"
        Me.rbChat.Size = New System.Drawing.Size(225, 17)
        Me.rbChat.TabIndex = 3
        Me.rbChat.Text = "Ignore messages until I leave Chat."
        Me.rbChat.UseVisualStyleBackColor = False
        '
        'cbRefuse
        '
        Me.cbRefuse.AutoSize = True
        Me.cbRefuse.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbRefuse.ForeColor = System.Drawing.Color.Black
        Me.cbRefuse.Location = New System.Drawing.Point(15, 135)
        Me.cbRefuse.Name = "cbRefuse"
        Me.cbRefuse.Size = New System.Drawing.Size(249, 17)
        Me.cbRefuse.TabIndex = 4
        Me.cbRefuse.Text = "Refuse this member's Instant Messages"
        Me.cbRefuse.UseVisualStyleBackColor = False
        '
        'bnOkay
        '
        Me.bnOkay.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.bnOkay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnOkay.Location = New System.Drawing.Point(87, 175)
        Me.bnOkay.Name = "bnOkay"
        Me.bnOkay.Size = New System.Drawing.Size(67, 27)
        Me.bnOkay.TabIndex = 5
        Me.bnOkay.Text = "&OK"
        Me.bnOkay.UseVisualStyleBackColor = False
        '
        'bnCancel
        '
        Me.bnCancel.Cursor = System.Windows.Forms.Cursors.Default
        Me.bnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.bnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnCancel.Location = New System.Drawing.Point(176, 175)
        Me.bnCancel.Name = "bnCancel"
        Me.bnCancel.Size = New System.Drawing.Size(67, 27)
        Me.bnCancel.TabIndex = 6
        Me.bnCancel.Text = "&Cancel"
        Me.bnCancel.UseVisualStyleBackColor = False
        '
        'Exclude
        '
        Me.AcceptButton = Me.bnOkay
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.bnCancel
        Me.ClientSize = New System.Drawing.Size(330, 228)
        Me.ControlBox = False
        Me.Controls.Add(Me.bnCancel)
        Me.Controls.Add(Me.bnOkay)
        Me.Controls.Add(Me.cbRefuse)
        Me.Controls.Add(Me.rbChat)
        Me.Controls.Add(Me.rbRoom)
        Me.Controls.Add(Me.rbView)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Exclude"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Exclude Member"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rbView As System.Windows.Forms.RadioButton
    Friend WithEvents rbRoom As System.Windows.Forms.RadioButton
    Friend WithEvents rbChat As System.Windows.Forms.RadioButton
    Friend WithEvents cbRefuse As System.Windows.Forms.CheckBox
    Friend WithEvents bnOkay As System.Windows.Forms.Button
    Friend WithEvents bnCancel As System.Windows.Forms.Button
End Class
