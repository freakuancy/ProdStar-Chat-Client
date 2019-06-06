<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminClientMessage
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
        Me.bnSendAdminMessage = New System.Windows.Forms.Button()
        Me.tbMsgTitle = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbMsg = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'bnSendAdminMessage
        '
        Me.bnSendAdminMessage.BackColor = System.Drawing.Color.Silver
        Me.bnSendAdminMessage.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.bnSendAdminMessage.FlatAppearance.BorderSize = 2
        Me.bnSendAdminMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bnSendAdminMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnSendAdminMessage.Location = New System.Drawing.Point(445, 134)
        Me.bnSendAdminMessage.Name = "bnSendAdminMessage"
        Me.bnSendAdminMessage.Size = New System.Drawing.Size(142, 29)
        Me.bnSendAdminMessage.TabIndex = 82
        Me.bnSendAdminMessage.Text = "Send Client Message"
        Me.bnSendAdminMessage.UseVisualStyleBackColor = False
        '
        'tbMsgTitle
        '
        Me.tbMsgTitle.BackColor = System.Drawing.Color.White
        Me.tbMsgTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbMsgTitle.Location = New System.Drawing.Point(122, 8)
        Me.tbMsgTitle.MaxLength = 300
        Me.tbMsgTitle.Multiline = True
        Me.tbMsgTitle.Name = "tbMsgTitle"
        Me.tbMsgTitle.Size = New System.Drawing.Size(465, 21)
        Me.tbMsgTitle.TabIndex = 81
        Me.tbMsgTitle.Text = "Service Advisory"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 80
        Me.Label1.Text = "Message Title:"
        '
        'tbMsg
        '
        Me.tbMsg.BackColor = System.Drawing.Color.White
        Me.tbMsg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbMsg.Location = New System.Drawing.Point(122, 35)
        Me.tbMsg.MaxLength = 300
        Me.tbMsg.Multiline = True
        Me.tbMsg.Name = "tbMsg"
        Me.tbMsg.Size = New System.Drawing.Size(465, 93)
        Me.tbMsg.TabIndex = 79
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(41, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 78
        Me.Label3.Text = "Message:"
        '
        'AdminClientMessage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(600, 175)
        Me.Controls.Add(Me.bnSendAdminMessage)
        Me.Controls.Add(Me.tbMsgTitle)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbMsg)
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "AdminClientMessage"
        Me.Text = "Send Client Message"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bnSendAdminMessage As System.Windows.Forms.Button
    Friend WithEvents tbMsgTitle As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbMsg As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
