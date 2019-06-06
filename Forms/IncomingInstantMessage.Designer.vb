<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IncomingInstantMessage
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
        Me.bnDelete = New System.Windows.Forms.Button()
        Me.bnView = New System.Windows.Forms.Button()
        Me.bnExclude = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbIncomingMessage = New System.Windows.Forms.ListBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'bnDelete
        '
        Me.bnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.bnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.bnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.bnDelete.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.bnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnDelete.Location = New System.Drawing.Point(85, 158)
        Me.bnDelete.Margin = New System.Windows.Forms.Padding(2)
        Me.bnDelete.Name = "bnDelete"
        Me.bnDelete.Size = New System.Drawing.Size(76, 24)
        Me.bnDelete.TabIndex = 3
        Me.bnDelete.Text = "&Delete"
        Me.bnDelete.UseVisualStyleBackColor = False
        '
        'bnView
        '
        Me.bnView.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.bnView.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.bnView.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.bnView.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.bnView.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnView.Location = New System.Drawing.Point(5, 158)
        Me.bnView.Margin = New System.Windows.Forms.Padding(2)
        Me.bnView.Name = "bnView"
        Me.bnView.Size = New System.Drawing.Size(76, 24)
        Me.bnView.TabIndex = 4
        Me.bnView.Text = "&View"
        Me.bnView.UseVisualStyleBackColor = False
        '
        'bnExclude
        '
        Me.bnExclude.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.bnExclude.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.bnExclude.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.bnExclude.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.bnExclude.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnExclude.Location = New System.Drawing.Point(165, 158)
        Me.bnExclude.Margin = New System.Windows.Forms.Padding(2)
        Me.bnExclude.Name = "bnExclude"
        Me.bnExclude.Size = New System.Drawing.Size(76, 24)
        Me.bnExclude.TabIndex = 5
        Me.bnExclude.Text = "&Exclude"
        Me.bnExclude.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lbIncomingMessage)
        Me.Panel1.Location = New System.Drawing.Point(5, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(236, 150)
        Me.Panel1.TabIndex = 6
        '
        'lbIncomingMessage
        '
        Me.lbIncomingMessage.BackColor = System.Drawing.Color.White
        Me.lbIncomingMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbIncomingMessage.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbIncomingMessage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbIncomingMessage.ForeColor = System.Drawing.Color.Black
        Me.lbIncomingMessage.FormattingEnabled = True
        Me.lbIncomingMessage.Location = New System.Drawing.Point(0, 0)
        Me.lbIncomingMessage.Name = "lbIncomingMessage"
        Me.lbIncomingMessage.Size = New System.Drawing.Size(236, 150)
        Me.lbIncomingMessage.TabIndex = 1
        '
        'IncomingInstantMessage
        '
        Me.AcceptButton = Me.bnView
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(247, 186)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.bnExclude)
        Me.Controls.Add(Me.bnView)
        Me.Controls.Add(Me.bnDelete)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "IncomingInstantMessage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Incoming Instant Message"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bnDelete As System.Windows.Forms.Button
    Friend WithEvents bnView As System.Windows.Forms.Button
    Friend WithEvents bnExclude As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lbIncomingMessage As System.Windows.Forms.ListBox
End Class
