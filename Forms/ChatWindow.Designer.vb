<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChatWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChatWindow))
        Me.bnHelp = New System.Windows.Forms.Button()
        Me.bnAlert = New System.Windows.Forms.Button()
        Me.bnGuidelines = New System.Windows.Forms.Button()
        Me.bnSave = New System.Windows.Forms.Button()
        Me.bnLogging = New System.Windows.Forms.Button()
        Me.bnSend = New System.Windows.Forms.Button()
        Me.bnClear = New System.Windows.Forms.Button()
        Me.bnSetup = New System.Windows.Forms.Button()
        Me.bnPause = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bnInfo = New System.Windows.Forms.Button()
        Me.bnInstantMsg = New System.Windows.Forms.Button()
        Me.bnExclude = New System.Windows.Forms.Button()
        Me.bnClose = New System.Windows.Forms.Button()
        Me.bnChange = New System.Windows.Forms.Button()
        Me.btnBold = New System.Windows.Forms.Button()
        Me.btnItalic = New System.Windows.Forms.Button()
        Me.btnUnder = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboFonts = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.tbToSend = New HtmlRichText.HtmlRichTextBox()
        Me.cboSize = New System.Windows.Forms.ComboBox()
        Me.bnAdminMsg = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lbChatting = New System.Windows.Forms.ListBox()
        Me.Panel1 = New ProdStarCommunicate.BufferedPanel()
        Me.tbChatText = New ProdStarCommunicate.TransRTB()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'bnHelp
        '
        Me.bnHelp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bnHelp.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.bnHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnHelp.Location = New System.Drawing.Point(8, 427)
        Me.bnHelp.Margin = New System.Windows.Forms.Padding(2)
        Me.bnHelp.Name = "bnHelp"
        Me.bnHelp.Size = New System.Drawing.Size(51, 28)
        Me.bnHelp.TabIndex = 6
        Me.bnHelp.Text = "&Help"
        Me.bnHelp.UseVisualStyleBackColor = False
        '
        'bnAlert
        '
        Me.bnAlert.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bnAlert.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.bnAlert.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnAlert.Location = New System.Drawing.Point(63, 427)
        Me.bnAlert.Margin = New System.Windows.Forms.Padding(2)
        Me.bnAlert.Name = "bnAlert"
        Me.bnAlert.Size = New System.Drawing.Size(51, 28)
        Me.bnAlert.TabIndex = 7
        Me.bnAlert.Text = "Alert"
        Me.bnAlert.UseVisualStyleBackColor = False
        '
        'bnGuidelines
        '
        Me.bnGuidelines.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bnGuidelines.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.bnGuidelines.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnGuidelines.Location = New System.Drawing.Point(118, 427)
        Me.bnGuidelines.Margin = New System.Windows.Forms.Padding(2)
        Me.bnGuidelines.Name = "bnGuidelines"
        Me.bnGuidelines.Size = New System.Drawing.Size(85, 28)
        Me.bnGuidelines.TabIndex = 8
        Me.bnGuidelines.Text = "&Guidelines"
        Me.bnGuidelines.UseVisualStyleBackColor = False
        '
        'bnSave
        '
        Me.bnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bnSave.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.bnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnSave.Location = New System.Drawing.Point(207, 427)
        Me.bnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.bnSave.Name = "bnSave"
        Me.bnSave.Size = New System.Drawing.Size(98, 28)
        Me.bnSave.TabIndex = 9
        Me.bnSave.Text = "Save to Disk"
        Me.bnSave.UseVisualStyleBackColor = False
        '
        'bnLogging
        '
        Me.bnLogging.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bnLogging.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.bnLogging.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnLogging.Location = New System.Drawing.Point(309, 427)
        Me.bnLogging.Margin = New System.Windows.Forms.Padding(2)
        Me.bnLogging.Name = "bnLogging"
        Me.bnLogging.Size = New System.Drawing.Size(96, 28)
        Me.bnLogging.TabIndex = 10
        Me.bnLogging.Text = "Logging Off"
        Me.bnLogging.UseVisualStyleBackColor = False
        '
        'bnSend
        '
        Me.bnSend.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bnSend.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.bnSend.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnSend.Location = New System.Drawing.Point(407, 365)
        Me.bnSend.Margin = New System.Windows.Forms.Padding(2)
        Me.bnSend.Name = "bnSend"
        Me.bnSend.Size = New System.Drawing.Size(94, 28)
        Me.bnSend.TabIndex = 11
        Me.bnSend.Text = "&Send Text"
        Me.bnSend.UseVisualStyleBackColor = False
        '
        'bnClear
        '
        Me.bnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bnClear.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.bnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnClear.Location = New System.Drawing.Point(407, 395)
        Me.bnClear.Margin = New System.Windows.Forms.Padding(2)
        Me.bnClear.Name = "bnClear"
        Me.bnClear.Size = New System.Drawing.Size(94, 28)
        Me.bnClear.TabIndex = 12
        Me.bnClear.Text = "Clear Text"
        Me.bnClear.UseVisualStyleBackColor = False
        '
        'bnSetup
        '
        Me.bnSetup.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bnSetup.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.bnSetup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnSetup.Location = New System.Drawing.Point(507, 8)
        Me.bnSetup.Margin = New System.Windows.Forms.Padding(2)
        Me.bnSetup.Name = "bnSetup"
        Me.bnSetup.Size = New System.Drawing.Size(148, 28)
        Me.bnSetup.TabIndex = 13
        Me.bnSetup.Text = "Set-Up Options"
        Me.bnSetup.UseVisualStyleBackColor = False
        '
        'bnPause
        '
        Me.bnPause.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bnPause.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.bnPause.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnPause.Location = New System.Drawing.Point(507, 40)
        Me.bnPause.Margin = New System.Windows.Forms.Padding(2)
        Me.bnPause.Name = "bnPause"
        Me.bnPause.Size = New System.Drawing.Size(148, 28)
        Me.bnPause.TabIndex = 14
        Me.bnPause.Text = "&Pause Display"
        Me.bnPause.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(509, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Chatting: 4"
        '
        'bnInfo
        '
        Me.bnInfo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bnInfo.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.bnInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnInfo.Location = New System.Drawing.Point(506, 243)
        Me.bnInfo.Margin = New System.Windows.Forms.Padding(2)
        Me.bnInfo.Name = "bnInfo"
        Me.bnInfo.Size = New System.Drawing.Size(149, 28)
        Me.bnInfo.TabIndex = 16
        Me.bnInfo.Text = "&Member Info"
        Me.bnInfo.UseVisualStyleBackColor = False
        '
        'bnInstantMsg
        '
        Me.bnInstantMsg.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bnInstantMsg.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.bnInstantMsg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnInstantMsg.Location = New System.Drawing.Point(506, 273)
        Me.bnInstantMsg.Margin = New System.Windows.Forms.Padding(2)
        Me.bnInstantMsg.Name = "bnInstantMsg"
        Me.bnInstantMsg.Size = New System.Drawing.Size(149, 28)
        Me.bnInstantMsg.TabIndex = 17
        Me.bnInstantMsg.Text = "&Instant Message"
        Me.bnInstantMsg.UseVisualStyleBackColor = False
        '
        'bnExclude
        '
        Me.bnExclude.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bnExclude.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.bnExclude.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnExclude.Location = New System.Drawing.Point(506, 305)
        Me.bnExclude.Margin = New System.Windows.Forms.Padding(2)
        Me.bnExclude.Name = "bnExclude"
        Me.bnExclude.Size = New System.Drawing.Size(149, 28)
        Me.bnExclude.TabIndex = 18
        Me.bnExclude.Text = "&Exclude"
        Me.bnExclude.UseVisualStyleBackColor = False
        '
        'bnClose
        '
        Me.bnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bnClose.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.bnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnClose.Location = New System.Drawing.Point(506, 335)
        Me.bnClose.Margin = New System.Windows.Forms.Padding(2)
        Me.bnClose.Name = "bnClose"
        Me.bnClose.Size = New System.Drawing.Size(149, 28)
        Me.bnClose.TabIndex = 19
        Me.bnClose.Text = "Close Window"
        Me.bnClose.UseVisualStyleBackColor = False
        '
        'bnChange
        '
        Me.bnChange.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bnChange.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.bnChange.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.bnChange.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnChange.Location = New System.Drawing.Point(506, 427)
        Me.bnChange.Margin = New System.Windows.Forms.Padding(2)
        Me.bnChange.Name = "bnChange"
        Me.bnChange.Size = New System.Drawing.Size(143, 28)
        Me.bnChange.TabIndex = 20
        Me.bnChange.Text = "&Change Room"
        Me.bnChange.UseVisualStyleBackColor = False
        '
        'btnBold
        '
        Me.btnBold.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnBold.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBold.Location = New System.Drawing.Point(8, 339)
        Me.btnBold.Name = "btnBold"
        Me.btnBold.Size = New System.Drawing.Size(35, 24)
        Me.btnBold.TabIndex = 22
        Me.btnBold.Text = "B"
        Me.btnBold.UseVisualStyleBackColor = False
        Me.btnBold.Visible = False
        '
        'btnItalic
        '
        Me.btnItalic.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnItalic.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnItalic.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnItalic.Location = New System.Drawing.Point(90, 339)
        Me.btnItalic.Name = "btnItalic"
        Me.btnItalic.Size = New System.Drawing.Size(35, 24)
        Me.btnItalic.TabIndex = 23
        Me.btnItalic.Text = "I"
        Me.btnItalic.UseVisualStyleBackColor = False
        Me.btnItalic.Visible = False
        '
        'btnUnder
        '
        Me.btnUnder.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnUnder.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUnder.Location = New System.Drawing.Point(49, 339)
        Me.btnUnder.Name = "btnUnder"
        Me.btnUnder.Size = New System.Drawing.Size(35, 24)
        Me.btnUnder.TabIndex = 24
        Me.btnUnder.Text = "U"
        Me.btnUnder.UseVisualStyleBackColor = False
        Me.btnUnder.Visible = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(379, 341)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 21)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "A"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label2.Visible = False
        '
        'cboFonts
        '
        Me.cboFonts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboFonts.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFonts.FormattingEnabled = True
        Me.cboFonts.Location = New System.Drawing.Point(131, 341)
        Me.cboFonts.Name = "cboFonts"
        Me.cboFonts.Size = New System.Drawing.Size(195, 21)
        Me.cboFonts.TabIndex = 26
        Me.cboFonts.Visible = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.tbToSend)
        Me.Panel2.Location = New System.Drawing.Point(8, 365)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(395, 59)
        Me.Panel2.TabIndex = 27
        '
        'tbToSend
        '
        Me.tbToSend.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbToSend.BackColor = System.Drawing.Color.White
        Me.tbToSend.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbToSend.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbToSend.ForeColor = System.Drawing.Color.Black
        Me.tbToSend.Location = New System.Drawing.Point(0, 0)
        Me.tbToSend.MaxLength = 235
        Me.tbToSend.Name = "tbToSend"
        Me.tbToSend.Size = New System.Drawing.Size(393, 57)
        Me.tbToSend.TabIndex = 28
        Me.tbToSend.Text = ""
        '
        'cboSize
        '
        Me.cboSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSize.FormattingEnabled = True
        Me.cboSize.Items.AddRange(New Object() {"8", "10", "12", "14", "16", "18", "24"})
        Me.cboSize.Location = New System.Drawing.Point(332, 341)
        Me.cboSize.Name = "cboSize"
        Me.cboSize.Size = New System.Drawing.Size(42, 21)
        Me.cboSize.TabIndex = 28
        Me.cboSize.Visible = False
        '
        'bnAdminMsg
        '
        Me.bnAdminMsg.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bnAdminMsg.BackColor = System.Drawing.Color.Silver
        Me.bnAdminMsg.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.bnAdminMsg.FlatAppearance.BorderSize = 2
        Me.bnAdminMsg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bnAdminMsg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnAdminMsg.Location = New System.Drawing.Point(407, 426)
        Me.bnAdminMsg.Name = "bnAdminMsg"
        Me.bnAdminMsg.Size = New System.Drawing.Size(94, 29)
        Me.bnAdminMsg.TabIndex = 29
        Me.bnAdminMsg.Text = "Admin Msg"
        Me.bnAdminMsg.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.lbChatting)
        Me.Panel3.Location = New System.Drawing.Point(506, 84)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(149, 154)
        Me.Panel3.TabIndex = 30
        '
        'lbChatting
        '
        Me.lbChatting.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbChatting.BackColor = System.Drawing.Color.White
        Me.lbChatting.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbChatting.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbChatting.ForeColor = System.Drawing.Color.Black
        Me.lbChatting.FormattingEnabled = True
        Me.lbChatting.Location = New System.Drawing.Point(2, 0)
        Me.lbChatting.Name = "lbChatting"
        Me.lbChatting.Size = New System.Drawing.Size(146, 156)
        Me.lbChatting.Sorted = True
        Me.lbChatting.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlText
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.tbChatText)
        Me.Panel1.Location = New System.Drawing.Point(8, 7)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(494, 355)
        Me.Panel1.TabIndex = 21
        '
        'tbChatText
        '
        Me.tbChatText.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbChatText.BackColor = System.Drawing.Color.Transparent
        Me.tbChatText.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbChatText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbChatText.ForeColor = System.Drawing.Color.Black
        Me.tbChatText.Location = New System.Drawing.Point(0, 0)
        Me.tbChatText.Name = "tbChatText"
        Me.tbChatText.ReadOnly = True
        Me.tbChatText.RightMargin = 427
        Me.tbChatText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.tbChatText.Size = New System.Drawing.Size(492, 353)
        Me.tbChatText.TabIndex = 22
        Me.tbChatText.Text = ""
        '
        'frmChatWindow
        '
        Me.AcceptButton = Me.bnSend
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.bnClose
        Me.ClientSize = New System.Drawing.Size(660, 464)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.bnAdminMsg)
        Me.Controls.Add(Me.cboSize)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.cboFonts)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnUnder)
        Me.Controls.Add(Me.btnItalic)
        Me.Controls.Add(Me.btnBold)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.bnChange)
        Me.Controls.Add(Me.bnClose)
        Me.Controls.Add(Me.bnExclude)
        Me.Controls.Add(Me.bnInstantMsg)
        Me.Controls.Add(Me.bnInfo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bnPause)
        Me.Controls.Add(Me.bnSetup)
        Me.Controls.Add(Me.bnClear)
        Me.Controls.Add(Me.bnSend)
        Me.Controls.Add(Me.bnLogging)
        Me.Controls.Add(Me.bnSave)
        Me.Controls.Add(Me.bnGuidelines)
        Me.Controls.Add(Me.bnAlert)
        Me.Controls.Add(Me.bnHelp)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(670, 492)
        Me.Name = "frmChatWindow"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ProdStar® Service - CHAT"
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bnHelp As System.Windows.Forms.Button
    Friend WithEvents bnAlert As System.Windows.Forms.Button
    Friend WithEvents bnGuidelines As System.Windows.Forms.Button
    Friend WithEvents bnSave As System.Windows.Forms.Button
    Friend WithEvents bnLogging As System.Windows.Forms.Button
    Friend WithEvents bnSend As System.Windows.Forms.Button
    Friend WithEvents bnClear As System.Windows.Forms.Button
    Friend WithEvents bnSetup As System.Windows.Forms.Button
    Friend WithEvents bnPause As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bnInfo As System.Windows.Forms.Button
    Friend WithEvents bnInstantMsg As System.Windows.Forms.Button
    Friend WithEvents bnExclude As System.Windows.Forms.Button
    Friend WithEvents bnClose As System.Windows.Forms.Button
    Friend WithEvents bnChange As System.Windows.Forms.Button
    Friend WithEvents Panel1 As ProdStarCommunicate.BufferedPanel
    Friend WithEvents tbChatText As ProdStarCommunicate.TransRTB
    Friend WithEvents btnBold As System.Windows.Forms.Button
    Friend WithEvents btnItalic As System.Windows.Forms.Button
    Friend WithEvents btnUnder As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboFonts As System.Windows.Forms.ComboBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents tbToSend As HtmlRichText.HtmlRichTextBox
    Friend WithEvents cboSize As System.Windows.Forms.ComboBox
    Friend WithEvents bnAdminMsg As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lbChatting As System.Windows.Forms.ListBox
End Class
