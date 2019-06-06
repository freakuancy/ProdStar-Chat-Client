<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BugReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BugReport))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.bnCancel = New System.Windows.Forms.Button()
        Me.bnOkay = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tbDetails = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbBugType = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(9, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Indicate the type of bug:"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(56, 315)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(400, 62)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Please provide specific details on the bug you've found.  Don't forget to include" & _
    " how the bug can be reproduced (e.g. exactly what you were doing when you found " & _
    "the bug.)"
        '
        'bnCancel
        '
        Me.bnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.bnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnCancel.Location = New System.Drawing.Point(356, 369)
        Me.bnCancel.Name = "bnCancel"
        Me.bnCancel.Size = New System.Drawing.Size(100, 29)
        Me.bnCancel.TabIndex = 17
        Me.bnCancel.Text = "Cancel"
        Me.bnCancel.UseVisualStyleBackColor = False
        '
        'bnOkay
        '
        Me.bnOkay.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.bnOkay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnOkay.Location = New System.Drawing.Point(250, 369)
        Me.bnOkay.Name = "bnOkay"
        Me.bnOkay.Size = New System.Drawing.Size(100, 29)
        Me.bnOkay.TabIndex = 18
        Me.bnOkay.Text = "Send Report"
        Me.bnOkay.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(12, 315)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Note:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.tbDetails)
        Me.Panel1.Location = New System.Drawing.Point(12, 176)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(444, 136)
        Me.Panel1.TabIndex = 20
        '
        'tbDetails
        '
        Me.tbDetails.BackColor = System.Drawing.Color.White
        Me.tbDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbDetails.ForeColor = System.Drawing.Color.Black
        Me.tbDetails.Location = New System.Drawing.Point(0, 0)
        Me.tbDetails.MaxLength = 2000
        Me.tbDetails.Multiline = True
        Me.tbDetails.Name = "tbDetails"
        Me.tbDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbDetails.Size = New System.Drawing.Size(444, 136)
        Me.tbDetails.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(9, 160)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(288, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Please provide us with information about the bug:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(179, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 18)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Submit a Bug"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(12, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(252, 67)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "We're sorry! Bugs happen. But that doesn't mean we don't have you covered. Submit" & _
    " any bugs you find and we'll address them as quickly as possible."
        '
        'cbBugType
        '
        Me.cbBugType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBugType.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cbBugType.FormattingEnabled = True
        Me.cbBugType.Items.AddRange(New Object() {"Interface Bug", "CHAT Bug", "Instant Message Bug", "Program Bug"})
        Me.cbBugType.Location = New System.Drawing.Point(12, 136)
        Me.cbBugType.Name = "cbBugType"
        Me.cbBugType.Size = New System.Drawing.Size(121, 21)
        Me.cbBugType.TabIndex = 29
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(301, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(155, 105)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'BugReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CancelButton = Me.bnCancel
        Me.ClientSize = New System.Drawing.Size(466, 415)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cbBugType)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.bnOkay)
        Me.Controls.Add(Me.bnCancel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BugReport"
        Me.ShowInTaskbar = False
        Me.Text = "Report a Bug"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents bnCancel As System.Windows.Forms.Button
    Friend WithEvents bnOkay As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents tbDetails As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbBugType As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
