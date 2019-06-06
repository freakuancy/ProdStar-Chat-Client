<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignOn
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbID = New System.Windows.Forms.TextBox()
        Me.tbPW = New System.Windows.Forms.TextBox()
        Me.bnConnect = New System.Windows.Forms.Button()
        Me.bnSetup = New System.Windows.Forms.Button()
        Me.bnHelp = New System.Windows.Forms.Button()
        Me.bnExit = New System.Windows.Forms.Button()
        Me.lbJmp = New System.Windows.Forms.ListBox()
        Me.tbJumpTo = New System.Windows.Forms.TextBox()
        Me.lblUpdate = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter your ID and password:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(12, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "User ID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(175, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Password:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(12, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Select destination:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(11, 206)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(216, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Or Enter a Private Room to Jump To:"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(13, 294)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(324, 64)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "ProdStar Classic 1.0 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This application and its related components are not associ" &
    "ated with the Prodigy® Service in any way. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This application is provided free-o" &
    "f-charge. All rights reserved."
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbID
        '
        Me.tbID.BackColor = System.Drawing.Color.White
        Me.tbID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbID.ForeColor = System.Drawing.Color.Black
        Me.tbID.Location = New System.Drawing.Point(72, 52)
        Me.tbID.MaxLength = 12
        Me.tbID.Name = "tbID"
        Me.tbID.Size = New System.Drawing.Size(97, 19)
        Me.tbID.TabIndex = 18
        '
        'tbPW
        '
        Me.tbPW.BackColor = System.Drawing.Color.White
        Me.tbPW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbPW.ForeColor = System.Drawing.Color.Black
        Me.tbPW.Location = New System.Drawing.Point(243, 52)
        Me.tbPW.Name = "tbPW"
        Me.tbPW.Size = New System.Drawing.Size(97, 19)
        Me.tbPW.TabIndex = 19
        Me.tbPW.UseSystemPasswordChar = True
        '
        'bnConnect
        '
        Me.bnConnect.Enabled = False
        Me.bnConnect.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.bnConnect.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnConnect.Location = New System.Drawing.Point(12, 247)
        Me.bnConnect.Name = "bnConnect"
        Me.bnConnect.Size = New System.Drawing.Size(78, 26)
        Me.bnConnect.TabIndex = 20
        Me.bnConnect.Text = "Connect"
        Me.bnConnect.UseVisualStyleBackColor = False
        '
        'bnSetup
        '
        Me.bnSetup.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.bnSetup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnSetup.Location = New System.Drawing.Point(96, 247)
        Me.bnSetup.Name = "bnSetup"
        Me.bnSetup.Size = New System.Drawing.Size(78, 26)
        Me.bnSetup.TabIndex = 21
        Me.bnSetup.Text = "Set-Up"
        Me.bnSetup.UseVisualStyleBackColor = False
        '
        'bnHelp
        '
        Me.bnHelp.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.bnHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnHelp.Location = New System.Drawing.Point(178, 247)
        Me.bnHelp.Name = "bnHelp"
        Me.bnHelp.Size = New System.Drawing.Size(78, 26)
        Me.bnHelp.TabIndex = 22
        Me.bnHelp.Text = "Help"
        Me.bnHelp.UseVisualStyleBackColor = False
        '
        'bnExit
        '
        Me.bnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bnExit.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.bnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnExit.Location = New System.Drawing.Point(262, 247)
        Me.bnExit.Name = "bnExit"
        Me.bnExit.Size = New System.Drawing.Size(78, 26)
        Me.bnExit.TabIndex = 23
        Me.bnExit.Text = "Exit"
        Me.bnExit.UseVisualStyleBackColor = False
        '
        'lbJmp
        '
        Me.lbJmp.BackColor = System.Drawing.Color.White
        Me.lbJmp.ForeColor = System.Drawing.Color.Black
        Me.lbJmp.FormattingEnabled = True
        Me.lbJmp.Items.AddRange(New Object() {"Lobby - Anything", "Communicator Development - Communicator Lobby", "Chit Chat - Code 3 Cafe"})
        Me.lbJmp.Location = New System.Drawing.Point(14, 114)
        Me.lbJmp.Name = "lbJmp"
        Me.lbJmp.ScrollAlwaysVisible = True
        Me.lbJmp.Size = New System.Drawing.Size(326, 82)
        Me.lbJmp.TabIndex = 24
        '
        'tbJumpTo
        '
        Me.tbJumpTo.BackColor = System.Drawing.Color.White
        Me.tbJumpTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbJumpTo.ForeColor = System.Drawing.Color.Black
        Me.tbJumpTo.Location = New System.Drawing.Point(12, 222)
        Me.tbJumpTo.Name = "tbJumpTo"
        Me.tbJumpTo.Size = New System.Drawing.Size(328, 19)
        Me.tbJumpTo.TabIndex = 25
        '
        'lblUpdate
        '
        Me.lblUpdate.AutoSize = True
        Me.lblUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUpdate.ForeColor = System.Drawing.Color.Purple
        Me.lblUpdate.Location = New System.Drawing.Point(104, 283)
        Me.lblUpdate.Name = "lblUpdate"
        Me.lblUpdate.Size = New System.Drawing.Size(142, 13)
        Me.lblUpdate.TabIndex = 26
        Me.lblUpdate.Text = "Checking for Updates..."
        '
        'SignOn
        '
        Me.AcceptButton = Me.bnConnect
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.bnExit
        Me.ClientSize = New System.Drawing.Size(351, 356)
        Me.Controls.Add(Me.lblUpdate)
        Me.Controls.Add(Me.tbJumpTo)
        Me.Controls.Add(Me.lbJmp)
        Me.Controls.Add(Me.bnExit)
        Me.Controls.Add(Me.bnHelp)
        Me.Controls.Add(Me.bnSetup)
        Me.Controls.Add(Me.bnConnect)
        Me.Controls.Add(Me.tbPW)
        Me.Controls.Add(Me.tbID)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximumSize = New System.Drawing.Size(416, 415)
        Me.Name = "SignOn"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ProdStar® Network - SIGN ON"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tbID As System.Windows.Forms.TextBox
    Friend WithEvents tbPW As System.Windows.Forms.TextBox
    Friend WithEvents bnConnect As System.Windows.Forms.Button
    Friend WithEvents bnSetup As System.Windows.Forms.Button
    Friend WithEvents bnHelp As System.Windows.Forms.Button
    Friend WithEvents bnExit As System.Windows.Forms.Button
    Friend WithEvents lbJmp As System.Windows.Forms.ListBox
    Friend WithEvents tbJumpTo As System.Windows.Forms.TextBox
    Friend WithEvents lblUpdate As System.Windows.Forms.Label
End Class
