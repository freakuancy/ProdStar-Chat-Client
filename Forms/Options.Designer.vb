<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Options
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Options))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.bnSave = New System.Windows.Forms.Button()
        Me.bnCancel = New System.Windows.Forms.Button()
        Me.tabConnection = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtHostname = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbAcceptUntrusted = New System.Windows.Forms.CheckBox()
        Me.rbUseSSL = New System.Windows.Forms.RadioButton()
        Me.rbClearText = New System.Windows.Forms.RadioButton()
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtProxyPass = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtProxyUser = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtProxyPort = New System.Windows.Forms.TextBox()
        Me.txtProxyHostname = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cbUseProxy = New System.Windows.Forms.CheckBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tabSounds = New System.Windows.Forms.TabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbEnableSounds = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lbDirectories = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tabGeneral = New System.Windows.Forms.TabPage()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.rbWindowsUI = New System.Windows.Forms.RadioButton()
        Me.rbClassicUI = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cbAutoReconnect = New System.Windows.Forms.CheckBox()
        Me.cbRememberPasswd = New System.Windows.Forms.CheckBox()
        Me.cbMinimize = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbStartWindows = New System.Windows.Forms.CheckBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.bnDefaults = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabConnection.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.tabSounds.SuspendLayout()
        Me.tabGeneral.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 34)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(51, 311)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'bnSave
        '
        Me.bnSave.BackColor = System.Drawing.Color.Gray
        Me.bnSave.Enabled = False
        Me.bnSave.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.bnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnSave.ForeColor = System.Drawing.Color.Black
        Me.bnSave.Location = New System.Drawing.Point(218, 351)
        Me.bnSave.Name = "bnSave"
        Me.bnSave.Size = New System.Drawing.Size(80, 29)
        Me.bnSave.TabIndex = 23
        Me.bnSave.Text = "&Save"
        Me.bnSave.UseVisualStyleBackColor = False
        '
        'bnCancel
        '
        Me.bnCancel.BackColor = System.Drawing.Color.Gray
        Me.bnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.bnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnCancel.ForeColor = System.Drawing.Color.Black
        Me.bnCancel.Location = New System.Drawing.Point(304, 351)
        Me.bnCancel.Name = "bnCancel"
        Me.bnCancel.Size = New System.Drawing.Size(80, 29)
        Me.bnCancel.TabIndex = 22
        Me.bnCancel.Text = "&Close"
        Me.bnCancel.UseVisualStyleBackColor = False
        '
        'tabConnection
        '
        Me.tabConnection.BackColor = System.Drawing.Color.White
        Me.tabConnection.Controls.Add(Me.GroupBox3)
        Me.tabConnection.Controls.Add(Me.GroupBox4)
        Me.tabConnection.Location = New System.Drawing.Point(4, 22)
        Me.tabConnection.Name = "tabConnection"
        Me.tabConnection.Padding = New System.Windows.Forms.Padding(3)
        Me.tabConnection.Size = New System.Drawing.Size(310, 307)
        Me.tabConnection.TabIndex = 2
        Me.tabConnection.Text = "Connection"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.txtHostname)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.cbAcceptUntrusted)
        Me.GroupBox3.Controls.Add(Me.rbUseSSL)
        Me.GroupBox3.Controls.Add(Me.rbClearText)
        Me.GroupBox3.Controls.Add(Me.txtPort)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(13, 15)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(281, 123)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Server Options"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(214, 42)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(29, 13)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Port:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(11, 42)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Hostname or IP:"
        '
        'txtHostname
        '
        Me.txtHostname.BackColor = System.Drawing.Color.White
        Me.txtHostname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHostname.ForeColor = System.Drawing.Color.Black
        Me.txtHostname.Location = New System.Drawing.Point(14, 58)
        Me.txtHostname.Name = "txtHostname"
        Me.txtHostname.Size = New System.Drawing.Size(187, 20)
        Me.txtHostname.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Purple
        Me.Label10.Location = New System.Drawing.Point(11, 14)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(264, 30)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Options for Connecting to ProdStar. Do not change these values unless instructed " & _
    "to by an Administrator."
        '
        'cbAcceptUntrusted
        '
        Me.cbAcceptUntrusted.AutoSize = True
        Me.cbAcceptUntrusted.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAcceptUntrusted.ForeColor = System.Drawing.Color.Black
        Me.cbAcceptUntrusted.Location = New System.Drawing.Point(110, 101)
        Me.cbAcceptUntrusted.Name = "cbAcceptUntrusted"
        Me.cbAcceptUntrusted.Size = New System.Drawing.Size(164, 17)
        Me.cbAcceptUntrusted.TabIndex = 6
        Me.cbAcceptUntrusted.Text = "Accept Untrusted Certificates"
        Me.cbAcceptUntrusted.UseVisualStyleBackColor = True
        '
        'rbUseSSL
        '
        Me.rbUseSSL.AutoSize = True
        Me.rbUseSSL.Checked = True
        Me.rbUseSSL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbUseSSL.ForeColor = System.Drawing.Color.Black
        Me.rbUseSSL.Location = New System.Drawing.Point(104, 82)
        Me.rbUseSSL.Name = "rbUseSSL"
        Me.rbUseSSL.Size = New System.Drawing.Size(45, 17)
        Me.rbUseSSL.TabIndex = 5
        Me.rbUseSSL.TabStop = True
        Me.rbUseSSL.Text = "SSL"
        Me.rbUseSSL.UseVisualStyleBackColor = True
        '
        'rbClearText
        '
        Me.rbClearText.AutoSize = True
        Me.rbClearText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbClearText.ForeColor = System.Drawing.Color.Black
        Me.rbClearText.Location = New System.Drawing.Point(14, 82)
        Me.rbClearText.Name = "rbClearText"
        Me.rbClearText.Size = New System.Drawing.Size(70, 17)
        Me.rbClearText.TabIndex = 4
        Me.rbClearText.Text = "ClearText"
        Me.rbClearText.UseVisualStyleBackColor = True
        '
        'txtPort
        '
        Me.txtPort.BackColor = System.Drawing.Color.White
        Me.txtPort.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPort.ForeColor = System.Drawing.Color.Black
        Me.txtPort.Location = New System.Drawing.Point(217, 58)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(33, 20)
        Me.txtPort.TabIndex = 2
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtProxyPass)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.txtProxyUser)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.txtProxyPort)
        Me.GroupBox4.Controls.Add(Me.txtProxyHostname)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.cbUseProxy)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Black
        Me.GroupBox4.Location = New System.Drawing.Point(14, 144)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(280, 151)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Web Content"
        '
        'txtProxyPass
        '
        Me.txtProxyPass.BackColor = System.Drawing.Color.White
        Me.txtProxyPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProxyPass.ForeColor = System.Drawing.Color.Black
        Me.txtProxyPass.Location = New System.Drawing.Point(156, 120)
        Me.txtProxyPass.Name = "txtProxyPass"
        Me.txtProxyPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtProxyPass.Size = New System.Drawing.Size(108, 20)
        Me.txtProxyPass.TabIndex = 17
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(153, 104)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(56, 13)
        Me.Label15.TabIndex = 16
        Me.Label15.Text = "Password:"
        '
        'txtProxyUser
        '
        Me.txtProxyUser.BackColor = System.Drawing.Color.White
        Me.txtProxyUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProxyUser.ForeColor = System.Drawing.Color.Black
        Me.txtProxyUser.Location = New System.Drawing.Point(13, 120)
        Me.txtProxyUser.Name = "txtProxyUser"
        Me.txtProxyUser.Size = New System.Drawing.Size(108, 20)
        Me.txtProxyUser.TabIndex = 15
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(10, 104)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(58, 13)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "Username:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(213, 63)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(29, 13)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Port:"
        '
        'txtProxyPort
        '
        Me.txtProxyPort.BackColor = System.Drawing.Color.White
        Me.txtProxyPort.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProxyPort.ForeColor = System.Drawing.Color.Black
        Me.txtProxyPort.Location = New System.Drawing.Point(216, 79)
        Me.txtProxyPort.Name = "txtProxyPort"
        Me.txtProxyPort.Size = New System.Drawing.Size(33, 20)
        Me.txtProxyPort.TabIndex = 12
        '
        'txtProxyHostname
        '
        Me.txtProxyHostname.BackColor = System.Drawing.Color.White
        Me.txtProxyHostname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProxyHostname.ForeColor = System.Drawing.Color.Black
        Me.txtProxyHostname.Location = New System.Drawing.Point(13, 79)
        Me.txtProxyHostname.Name = "txtProxyHostname"
        Me.txtProxyHostname.Size = New System.Drawing.Size(187, 20)
        Me.txtProxyHostname.TabIndex = 11
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(10, 63)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(83, 13)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "Hostname or IP:"
        '
        'cbUseProxy
        '
        Me.cbUseProxy.AutoSize = True
        Me.cbUseProxy.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbUseProxy.ForeColor = System.Drawing.Color.Black
        Me.cbUseProxy.Location = New System.Drawing.Point(13, 43)
        Me.cbUseProxy.Name = "cbUseProxy"
        Me.cbUseProxy.Size = New System.Drawing.Size(108, 17)
        Me.cbUseProxy.TabIndex = 9
        Me.cbUseProxy.Text = "Use Proxy Server"
        Me.cbUseProxy.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Purple
        Me.Label11.Location = New System.Drawing.Point(10, 14)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(264, 28)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Some ProdStar features rely on Web Requests. If you utilize a Web Proxy for your " & _
    "Web traffic, enter it below."
        '
        'tabSounds
        '
        Me.tabSounds.BackColor = System.Drawing.Color.White
        Me.tabSounds.Controls.Add(Me.Label6)
        Me.tabSounds.Controls.Add(Me.cbEnableSounds)
        Me.tabSounds.Controls.Add(Me.Label5)
        Me.tabSounds.Controls.Add(Me.Label4)
        Me.tabSounds.Controls.Add(Me.Label3)
        Me.tabSounds.Controls.Add(Me.btnRemove)
        Me.tabSounds.Controls.Add(Me.btnAdd)
        Me.tabSounds.Controls.Add(Me.lbDirectories)
        Me.tabSounds.Controls.Add(Me.Label2)
        Me.tabSounds.Location = New System.Drawing.Point(4, 22)
        Me.tabSounds.Name = "tabSounds"
        Me.tabSounds.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSounds.Size = New System.Drawing.Size(310, 307)
        Me.tabSounds.TabIndex = 1
        Me.tabSounds.Text = "Sounds"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Purple
        Me.Label6.Location = New System.Drawing.Point(10, 38)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(161, 12)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Welcome, Goodbye, Instant Message"
        '
        'cbEnableSounds
        '
        Me.cbEnableSounds.AutoSize = True
        Me.cbEnableSounds.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEnableSounds.ForeColor = System.Drawing.Color.Black
        Me.cbEnableSounds.Location = New System.Drawing.Point(12, 22)
        Me.cbEnableSounds.Name = "cbEnableSounds"
        Me.cbEnableSounds.Size = New System.Drawing.Size(180, 17)
        Me.cbEnableSounds.TabIndex = 28
        Me.cbEnableSounds.Text = "Enable Notification Sounds"
        Me.cbEnableSounds.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Purple
        Me.Label5.Location = New System.Drawing.Point(169, 219)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(133, 42)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Use this feature to add any additiona sound directories you would like to search." & _
    ""
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(169, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 33)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "C:\Documents\ProdStar Chat\Sounds"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Purple
        Me.Label3.Location = New System.Drawing.Point(169, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 51)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "When a sound is played in Chat, this program will search"
        '
        'btnRemove
        '
        Me.btnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRemove.Location = New System.Drawing.Point(133, 215)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(30, 35)
        Me.btnRemove.TabIndex = 33
        Me.btnRemove.Text = "-"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Green
        Me.btnAdd.Location = New System.Drawing.Point(133, 174)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(30, 35)
        Me.btnAdd.TabIndex = 32
        Me.btnAdd.Text = "+"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lbDirectories
        '
        Me.lbDirectories.BackColor = System.Drawing.Color.White
        Me.lbDirectories.ForeColor = System.Drawing.Color.Black
        Me.lbDirectories.FormattingEnabled = True
        Me.lbDirectories.Location = New System.Drawing.Point(12, 174)
        Me.lbDirectories.Name = "lbDirectories"
        Me.lbDirectories.Size = New System.Drawing.Size(120, 121)
        Me.lbDirectories.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(9, 158)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Chat Sound Directories:"
        '
        'tabGeneral
        '
        Me.tabGeneral.BackColor = System.Drawing.Color.White
        Me.tabGeneral.Controls.Add(Me.GroupBox5)
        Me.tabGeneral.Controls.Add(Me.GroupBox2)
        Me.tabGeneral.Controls.Add(Me.GroupBox1)
        Me.tabGeneral.Location = New System.Drawing.Point(4, 22)
        Me.tabGeneral.Name = "tabGeneral"
        Me.tabGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.tabGeneral.Size = New System.Drawing.Size(310, 307)
        Me.tabGeneral.TabIndex = 0
        Me.tabGeneral.Text = "General"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.rbWindowsUI)
        Me.GroupBox5.Controls.Add(Me.rbClassicUI)
        Me.GroupBox5.Controls.Add(Me.Label1)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.Black
        Me.GroupBox5.Location = New System.Drawing.Point(15, 205)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(278, 91)
        Me.GroupBox5.TabIndex = 2
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Interface"
        '
        'rbWindowsUI
        '
        Me.rbWindowsUI.AutoSize = True
        Me.rbWindowsUI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbWindowsUI.ForeColor = System.Drawing.Color.Black
        Me.rbWindowsUI.Location = New System.Drawing.Point(150, 62)
        Me.rbWindowsUI.Name = "rbWindowsUI"
        Me.rbWindowsUI.Size = New System.Drawing.Size(106, 17)
        Me.rbWindowsUI.TabIndex = 10
        Me.rbWindowsUI.Text = "Default Windows"
        Me.rbWindowsUI.UseVisualStyleBackColor = True
        '
        'rbClassicUI
        '
        Me.rbClassicUI.AutoSize = True
        Me.rbClassicUI.Checked = True
        Me.rbClassicUI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbClassicUI.ForeColor = System.Drawing.Color.Black
        Me.rbClassicUI.Location = New System.Drawing.Point(12, 62)
        Me.rbClassicUI.Name = "rbClassicUI"
        Me.rbClassicUI.Size = New System.Drawing.Size(110, 17)
        Me.rbClassicUI.TabIndex = 9
        Me.rbClassicUI.TabStop = True
        Me.rbClassicUI.Text = "ProdStar® Classic"
        Me.rbClassicUI.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Purple
        Me.Label1.Location = New System.Drawing.Point(10, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(264, 36)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Choose between ProdStar® Classic or the default Windows Interface that is compati" & _
    "ble with your custom Windows themes and Settings"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.cbAutoReconnect)
        Me.GroupBox2.Controls.Add(Me.cbRememberPasswd)
        Me.GroupBox2.Controls.Add(Me.cbMinimize)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(15, 84)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(278, 115)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Behavior"
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Purple
        Me.Label17.Location = New System.Drawing.Point(6, 36)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(264, 16)
        Me.Label17.TabIndex = 8
        Me.Label17.Text = "Minimize to your System Tray Instead of the Task Bar"
        '
        'cbAutoReconnect
        '
        Me.cbAutoReconnect.AutoSize = True
        Me.cbAutoReconnect.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAutoReconnect.ForeColor = System.Drawing.Color.Black
        Me.cbAutoReconnect.Location = New System.Drawing.Point(32, 87)
        Me.cbAutoReconnect.Name = "cbAutoReconnect"
        Me.cbAutoReconnect.Size = New System.Drawing.Size(220, 17)
        Me.cbAutoReconnect.TabIndex = 2
        Me.cbAutoReconnect.Text = "Automatically Re-Connect on Disconnect"
        Me.cbAutoReconnect.UseVisualStyleBackColor = True
        '
        'cbRememberPasswd
        '
        Me.cbRememberPasswd.AutoSize = True
        Me.cbRememberPasswd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbRememberPasswd.ForeColor = System.Drawing.Color.Black
        Me.cbRememberPasswd.Location = New System.Drawing.Point(12, 68)
        Me.cbRememberPasswd.Name = "cbRememberPasswd"
        Me.cbRememberPasswd.Size = New System.Drawing.Size(126, 17)
        Me.cbRememberPasswd.TabIndex = 1
        Me.cbRememberPasswd.Text = "Remember Password"
        Me.cbRememberPasswd.UseVisualStyleBackColor = True
        '
        'cbMinimize
        '
        Me.cbMinimize.AutoSize = True
        Me.cbMinimize.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMinimize.ForeColor = System.Drawing.Color.Black
        Me.cbMinimize.Location = New System.Drawing.Point(12, 19)
        Me.cbMinimize.Name = "cbMinimize"
        Me.cbMinimize.Size = New System.Drawing.Size(139, 17)
        Me.cbMinimize.TabIndex = 0
        Me.cbMinimize.Text = "Minimize to System Tray"
        Me.cbMinimize.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbStartWindows)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(15, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(278, 67)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Startup"
        '
        'cbStartWindows
        '
        Me.cbStartWindows.AutoSize = True
        Me.cbStartWindows.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbStartWindows.ForeColor = System.Drawing.Color.Black
        Me.cbStartWindows.Location = New System.Drawing.Point(12, 19)
        Me.cbStartWindows.Name = "cbStartWindows"
        Me.cbStartWindows.Size = New System.Drawing.Size(120, 17)
        Me.cbStartWindows.TabIndex = 1
        Me.cbStartWindows.Text = "Start With Windows"
        Me.cbStartWindows.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Purple
        Me.Label16.Location = New System.Drawing.Point(6, 34)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(264, 11)
        Me.Label16.TabIndex = 8
        Me.Label16.Text = "Automatically Start ProdStar when you Start Windows"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabGeneral)
        Me.TabControl1.Controls.Add(Me.tabSounds)
        Me.TabControl1.Controls.Add(Me.tabConnection)
        Me.TabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(66, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(318, 333)
        Me.TabControl1.TabIndex = 21
        '
        'bnDefaults
        '
        Me.bnDefaults.BackColor = System.Drawing.Color.Gray
        Me.bnDefaults.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.bnDefaults.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnDefaults.ForeColor = System.Drawing.Color.Black
        Me.bnDefaults.Location = New System.Drawing.Point(132, 351)
        Me.bnDefaults.Name = "bnDefaults"
        Me.bnDefaults.Size = New System.Drawing.Size(80, 29)
        Me.bnDefaults.TabIndex = 24
        Me.bnDefaults.Text = "Defaults"
        Me.bnDefaults.UseVisualStyleBackColor = False
        '
        'Options
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(394, 388)
        Me.Controls.Add(Me.bnDefaults)
        Me.Controls.Add(Me.bnSave)
        Me.Controls.Add(Me.bnCancel)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Options"
        Me.Text = "ProdStar® CHAT - Options"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabConnection.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.tabSounds.ResumeLayout(False)
        Me.tabSounds.PerformLayout()
        Me.tabGeneral.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents bnSave As System.Windows.Forms.Button
    Friend WithEvents bnCancel As System.Windows.Forms.Button
    Friend WithEvents tabConnection As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtProxyPass As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtProxyUser As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtProxyPort As System.Windows.Forms.TextBox
    Friend WithEvents txtProxyHostname As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cbUseProxy As System.Windows.Forms.CheckBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cbAcceptUntrusted As System.Windows.Forms.CheckBox
    Friend WithEvents rbUseSSL As System.Windows.Forms.RadioButton
    Friend WithEvents rbClearText As System.Windows.Forms.RadioButton
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtPort As System.Windows.Forms.TextBox
    Friend WithEvents txtHostname As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tabSounds As System.Windows.Forms.TabPage
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbEnableSounds As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents lbDirectories As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tabGeneral As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cbAutoReconnect As System.Windows.Forms.CheckBox
    Friend WithEvents cbRememberPasswd As System.Windows.Forms.CheckBox
    Friend WithEvents cbMinimize As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbStartWindows As System.Windows.Forms.CheckBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents bnDefaults As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents rbWindowsUI As System.Windows.Forms.RadioButton
    Friend WithEvents rbClassicUI As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
