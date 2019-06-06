<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminMessage
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
        Me.tbAdminMsg = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbAdminMsgFrom = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bnSendAdminMessage = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tbAdminMsg
        '
        Me.tbAdminMsg.BackColor = System.Drawing.Color.White
        Me.tbAdminMsg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbAdminMsg.Location = New System.Drawing.Point(79, 39)
        Me.tbAdminMsg.MaxLength = 300
        Me.tbAdminMsg.Multiline = True
        Me.tbAdminMsg.Name = "tbAdminMsg"
        Me.tbAdminMsg.Size = New System.Drawing.Size(399, 93)
        Me.tbAdminMsg.TabIndex = 74
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(12, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 73
        Me.Label3.Text = "Message:"
        '
        'tbAdminMsgFrom
        '
        Me.tbAdminMsgFrom.BackColor = System.Drawing.Color.White
        Me.tbAdminMsgFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbAdminMsgFrom.Location = New System.Drawing.Point(79, 12)
        Me.tbAdminMsgFrom.MaxLength = 300
        Me.tbAdminMsgFrom.Multiline = True
        Me.tbAdminMsgFrom.Name = "tbAdminMsgFrom"
        Me.tbAdminMsgFrom.Size = New System.Drawing.Size(399, 21)
        Me.tbAdminMsgFrom.TabIndex = 76
        Me.tbAdminMsgFrom.Text = "CHAT Host"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(35, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 75
        Me.Label1.Text = "From:"
        '
        'bnSendAdminMessage
        '
        Me.bnSendAdminMessage.BackColor = System.Drawing.Color.Silver
        Me.bnSendAdminMessage.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.bnSendAdminMessage.FlatAppearance.BorderSize = 2
        Me.bnSendAdminMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bnSendAdminMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnSendAdminMessage.Location = New System.Drawing.Point(391, 138)
        Me.bnSendAdminMessage.Name = "bnSendAdminMessage"
        Me.bnSendAdminMessage.Size = New System.Drawing.Size(87, 29)
        Me.bnSendAdminMessage.TabIndex = 77
        Me.bnSendAdminMessage.Text = "Send Message"
        Me.bnSendAdminMessage.UseVisualStyleBackColor = False
        '
        'AdminMessage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(489, 176)
        Me.Controls.Add(Me.bnSendAdminMessage)
        Me.Controls.Add(Me.tbAdminMsgFrom)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbAdminMsg)
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "AdminMessage"
        Me.Text = "Administrative Message"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbAdminMsg As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbAdminMsgFrom As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bnSendAdminMessage As System.Windows.Forms.Button
End Class
