<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IMCenter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IMCenter))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbTo = New System.Windows.Forms.TextBox()
        Me.tbMessageToSend = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.bnSend = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bnHelp = New System.Windows.Forms.Button()
        Me.bnDelete = New System.Windows.Forms.Button()
        Me.bnSave = New System.Windows.Forms.Button()
        Me.bnExclude = New System.Windows.Forms.Button()
        Me.bnMI = New System.Windows.Forms.Button()
        Me.bnSetup = New System.Windows.Forms.Button()
        Me.bnCancel = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbMessages = New System.Windows.Forms.ListBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tbMessages = New System.Windows.Forms.RichTextBox()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.tbTo)
        Me.GroupBox1.Controls.Add(Me.tbMessageToSend)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.bnSend)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(14, 11)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(612, 79)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Send To: (nickname or ID)"
        '
        'tbTo
        '
        Me.tbTo.BackColor = System.Drawing.Color.White
        Me.tbTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tbTo.ForeColor = System.Drawing.Color.Black
        Me.tbTo.Location = New System.Drawing.Point(18, 31)
        Me.tbTo.Margin = New System.Windows.Forms.Padding(2)
        Me.tbTo.MaxLength = 20
        Me.tbTo.Name = "tbTo"
        Me.tbTo.Size = New System.Drawing.Size(123, 20)
        Me.tbTo.TabIndex = 0
        '
        'tbMessageToSend
        '
        Me.tbMessageToSend.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbMessageToSend.BackColor = System.Drawing.Color.White
        Me.tbMessageToSend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbMessageToSend.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tbMessageToSend.ForeColor = System.Drawing.Color.Black
        Me.tbMessageToSend.Location = New System.Drawing.Point(161, 13)
        Me.tbMessageToSend.Margin = New System.Windows.Forms.Padding(2)
        Me.tbMessageToSend.MaxLength = 310
        Me.tbMessageToSend.Multiline = True
        Me.tbMessageToSend.Name = "tbMessageToSend"
        Me.tbMessageToSend.Size = New System.Drawing.Size(295, 60)
        Me.tbMessageToSend.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(483, 45)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 28)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Clear Text"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'bnSend
        '
        Me.bnSend.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bnSend.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.bnSend.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.bnSend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.bnSend.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.bnSend.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnSend.Location = New System.Drawing.Point(483, 13)
        Me.bnSend.Margin = New System.Windows.Forms.Padding(2)
        Me.bnSend.Name = "bnSend"
        Me.bnSend.Size = New System.Drawing.Size(88, 28)
        Me.bnSend.TabIndex = 2
        Me.bnSend.Text = "&Send Text"
        Me.bnSend.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(91, 240)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 15)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Reminder:"
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(169, 240)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(455, 48)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = resources.GetString("Label2.Text")
        '
        'bnHelp
        '
        Me.bnHelp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bnHelp.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.bnHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnHelp.Location = New System.Drawing.Point(169, 206)
        Me.bnHelp.Margin = New System.Windows.Forms.Padding(2)
        Me.bnHelp.Name = "bnHelp"
        Me.bnHelp.Size = New System.Drawing.Size(41, 28)
        Me.bnHelp.TabIndex = 5
        Me.bnHelp.Text = "&Help"
        Me.bnHelp.UseVisualStyleBackColor = False
        '
        'bnDelete
        '
        Me.bnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bnDelete.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.bnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnDelete.Location = New System.Drawing.Point(214, 206)
        Me.bnDelete.Margin = New System.Windows.Forms.Padding(2)
        Me.bnDelete.Name = "bnDelete"
        Me.bnDelete.Size = New System.Drawing.Size(47, 28)
        Me.bnDelete.TabIndex = 6
        Me.bnDelete.Text = "Delete"
        Me.bnDelete.UseVisualStyleBackColor = False
        '
        'bnSave
        '
        Me.bnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bnSave.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.bnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnSave.Location = New System.Drawing.Point(265, 206)
        Me.bnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.bnSave.Name = "bnSave"
        Me.bnSave.Size = New System.Drawing.Size(40, 28)
        Me.bnSave.TabIndex = 7
        Me.bnSave.Text = "Save"
        Me.bnSave.UseVisualStyleBackColor = False
        '
        'bnExclude
        '
        Me.bnExclude.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bnExclude.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.bnExclude.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnExclude.Location = New System.Drawing.Point(309, 206)
        Me.bnExclude.Margin = New System.Windows.Forms.Padding(2)
        Me.bnExclude.Name = "bnExclude"
        Me.bnExclude.Size = New System.Drawing.Size(63, 28)
        Me.bnExclude.TabIndex = 8
        Me.bnExclude.Text = "&Exclude"
        Me.bnExclude.UseVisualStyleBackColor = False
        '
        'bnMI
        '
        Me.bnMI.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bnMI.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.bnMI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnMI.Location = New System.Drawing.Point(376, 206)
        Me.bnMI.Margin = New System.Windows.Forms.Padding(2)
        Me.bnMI.Name = "bnMI"
        Me.bnMI.Size = New System.Drawing.Size(81, 28)
        Me.bnMI.TabIndex = 9
        Me.bnMI.Text = "&Member Info"
        Me.bnMI.UseVisualStyleBackColor = False
        '
        'bnSetup
        '
        Me.bnSetup.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bnSetup.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.bnSetup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnSetup.Location = New System.Drawing.Point(461, 206)
        Me.bnSetup.Margin = New System.Windows.Forms.Padding(2)
        Me.bnSetup.Name = "bnSetup"
        Me.bnSetup.Size = New System.Drawing.Size(103, 28)
        Me.bnSetup.TabIndex = 10
        Me.bnSetup.Text = "Set-Up Options"
        Me.bnSetup.UseVisualStyleBackColor = False
        '
        'bnCancel
        '
        Me.bnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.bnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnCancel.Location = New System.Drawing.Point(568, 206)
        Me.bnCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.bnCancel.Name = "bnCancel"
        Me.bnCancel.Size = New System.Drawing.Size(55, 28)
        Me.bnCancel.TabIndex = 11
        Me.bnCancel.Text = "Cancel"
        Me.bnCancel.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lbMessages)
        Me.Panel2.Location = New System.Drawing.Point(14, 95)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(150, 139)
        Me.Panel2.TabIndex = 22
        '
        'lbMessages
        '
        Me.lbMessages.BackColor = System.Drawing.Color.White
        Me.lbMessages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbMessages.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbMessages.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMessages.ForeColor = System.Drawing.Color.Black
        Me.lbMessages.FormattingEnabled = True
        Me.lbMessages.ItemHeight = 15
        Me.lbMessages.Location = New System.Drawing.Point(0, 0)
        Me.lbMessages.Margin = New System.Windows.Forms.Padding(2)
        Me.lbMessages.Name = "lbMessages"
        Me.lbMessages.Size = New System.Drawing.Size(150, 139)
        Me.lbMessages.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.tbMessages)
        Me.Panel1.Location = New System.Drawing.Point(172, 95)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(451, 104)
        Me.Panel1.TabIndex = 21
        '
        'tbMessages
        '
        Me.tbMessages.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbMessages.BackColor = System.Drawing.Color.White
        Me.tbMessages.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbMessages.DetectUrls = False
        Me.tbMessages.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tbMessages.Location = New System.Drawing.Point(2, 2)
        Me.tbMessages.Margin = New System.Windows.Forms.Padding(2)
        Me.tbMessages.Name = "tbMessages"
        Me.tbMessages.ReadOnly = True
        Me.tbMessages.RightMargin = 336
        Me.tbMessages.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.tbMessages.Size = New System.Drawing.Size(445, 98)
        Me.tbMessages.TabIndex = 22
        Me.tbMessages.Text = ""
        '
        'IMCenter
        '
        Me.AcceptButton = Me.bnSend
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.bnCancel
        Me.ClientSize = New System.Drawing.Size(637, 290)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.bnCancel)
        Me.Controls.Add(Me.bnSetup)
        Me.Controls.Add(Me.bnMI)
        Me.Controls.Add(Me.bnExclude)
        Me.Controls.Add(Me.bnSave)
        Me.Controls.Add(Me.bnDelete)
        Me.Controls.Add(Me.bnHelp)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MinimumSize = New System.Drawing.Size(647, 322)
        Me.Name = "IMCenter"
        Me.ShowIcon = False
        Me.Text = "Instant Message Center"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents bnHelp As System.Windows.Forms.Button
    Friend WithEvents bnDelete As System.Windows.Forms.Button
    Friend WithEvents bnSave As System.Windows.Forms.Button
    Friend WithEvents bnExclude As System.Windows.Forms.Button
    Friend WithEvents bnMI As System.Windows.Forms.Button
    Friend WithEvents bnSetup As System.Windows.Forms.Button
    Friend WithEvents bnCancel As System.Windows.Forms.Button
    Friend WithEvents bnSend As System.Windows.Forms.Button
    Friend WithEvents tbTo As System.Windows.Forms.TextBox
    Friend WithEvents tbMessageToSend As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lbMessages As System.Windows.Forms.ListBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents tbMessages As System.Windows.Forms.RichTextBox
End Class
