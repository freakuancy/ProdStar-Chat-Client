<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainWindow
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWindow))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoffQuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GoToToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InstantMessageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportBugToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutProdstarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.HelpToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministratorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminGlobalMsg = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisconnectUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToggleAdmin = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlUltima = New System.Windows.Forms.Panel()
        Me.CheckAlive = New System.ComponentModel.BackgroundWorker()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ChatRoomsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JumpInLobbyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.FindRoomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateRoomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ChatOptionsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InstantMessageToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.IMCenterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChatOptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GeneralOptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministrativeContextMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.SendGlobalMessageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisconnectUserToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToggleAdministratorFlagToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ProdStarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportBugToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripSeparator()
        Me.HelpToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.SignOffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.GoToToolStripMenuItem, Me.AccountToolStripMenuItem, Me.HelpToolStripMenuItem, Me.AdministratorToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(963, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "File"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoffToolStripMenuItem, Me.LogoffQuitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'LogoffToolStripMenuItem
        '
        Me.LogoffToolStripMenuItem.Name = "LogoffToolStripMenuItem"
        Me.LogoffToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.LogoffToolStripMenuItem.Text = "Logoff"
        '
        'LogoffQuitToolStripMenuItem
        '
        Me.LogoffQuitToolStripMenuItem.Name = "LogoffQuitToolStripMenuItem"
        Me.LogoffQuitToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.LogoffQuitToolStripMenuItem.Text = "Exit"
        '
        'GoToToolStripMenuItem
        '
        Me.GoToToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InstantMessageToolStripMenuItem, Me.ChatToolStripMenuItem})
        Me.GoToToolStripMenuItem.Name = "GoToToolStripMenuItem"
        Me.GoToToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.GoToToolStripMenuItem.Text = "&GoTo"
        '
        'InstantMessageToolStripMenuItem
        '
        Me.InstantMessageToolStripMenuItem.Name = "InstantMessageToolStripMenuItem"
        Me.InstantMessageToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.InstantMessageToolStripMenuItem.Text = "Instant Message"
        '
        'ChatToolStripMenuItem
        '
        Me.ChatToolStripMenuItem.Name = "ChatToolStripMenuItem"
        Me.ChatToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.ChatToolStripMenuItem.Text = "Chat"
        '
        'AccountToolStripMenuItem
        '
        Me.AccountToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangePasswordToolStripMenuItem})
        Me.AccountToolStripMenuItem.Name = "AccountToolStripMenuItem"
        Me.AccountToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.AccountToolStripMenuItem.Text = "&Account"
        '
        'ChangePasswordToolStripMenuItem
        '
        Me.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        Me.ChangePasswordToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.ChangePasswordToolStripMenuItem.Text = "Change Password..."
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReportBugToolStripMenuItem, Me.AboutProdstarToolStripMenuItem, Me.ToolStripMenuItem1, Me.HelpToolStripMenuItem1})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'ReportBugToolStripMenuItem
        '
        Me.ReportBugToolStripMenuItem.Enabled = False
        Me.ReportBugToolStripMenuItem.Image = CType(resources.GetObject("ReportBugToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ReportBugToolStripMenuItem.Name = "ReportBugToolStripMenuItem"
        Me.ReportBugToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.ReportBugToolStripMenuItem.Text = "Report Bug"
        '
        'AboutProdstarToolStripMenuItem
        '
        Me.AboutProdstarToolStripMenuItem.Image = CType(resources.GetObject("AboutProdstarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AboutProdstarToolStripMenuItem.Name = "AboutProdstarToolStripMenuItem"
        Me.AboutProdstarToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.AboutProdstarToolStripMenuItem.Text = "About Prodstar..."
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(160, 6)
        '
        'HelpToolStripMenuItem1
        '
        Me.HelpToolStripMenuItem1.Image = CType(resources.GetObject("HelpToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1"
        Me.HelpToolStripMenuItem1.ShortcutKeyDisplayString = "F1"
        Me.HelpToolStripMenuItem1.Size = New System.Drawing.Size(163, 22)
        Me.HelpToolStripMenuItem1.Text = "Help"
        '
        'AdministratorToolStripMenuItem
        '
        Me.AdministratorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdminGlobalMsg, Me.DisconnectUserToolStripMenuItem, Me.ToolStripSeparator2, Me.ToggleAdmin})
        Me.AdministratorToolStripMenuItem.Name = "AdministratorToolStripMenuItem"
        Me.AdministratorToolStripMenuItem.Size = New System.Drawing.Size(92, 20)
        Me.AdministratorToolStripMenuItem.Text = "Administrator"
        Me.AdministratorToolStripMenuItem.Visible = False
        '
        'AdminGlobalMsg
        '
        Me.AdminGlobalMsg.Name = "AdminGlobalMsg"
        Me.AdminGlobalMsg.Size = New System.Drawing.Size(186, 22)
        Me.AdminGlobalMsg.Text = "Send Global Message"
        Me.AdminGlobalMsg.Visible = False
        '
        'DisconnectUserToolStripMenuItem
        '
        Me.DisconnectUserToolStripMenuItem.Name = "DisconnectUserToolStripMenuItem"
        Me.DisconnectUserToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.DisconnectUserToolStripMenuItem.Text = "Disconnect User"
        Me.DisconnectUserToolStripMenuItem.Visible = False
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(183, 6)
        '
        'ToggleAdmin
        '
        Me.ToggleAdmin.Name = "ToggleAdmin"
        Me.ToggleAdmin.Size = New System.Drawing.Size(186, 22)
        Me.ToggleAdmin.Text = "Administrator Mode"
        '
        'pnlUltima
        '
        Me.pnlUltima.BackColor = System.Drawing.Color.MediumBlue
        Me.pnlUltima.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlUltima.CausesValidation = False
        Me.pnlUltima.Location = New System.Drawing.Point(1262, 706)
        Me.pnlUltima.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlUltima.Name = "pnlUltima"
        Me.pnlUltima.Size = New System.Drawing.Size(66, 29)
        Me.pnlUltima.TabIndex = 1
        '
        'CheckAlive
        '
        Me.CheckAlive.WorkerSupportsCancellation = True
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "ProdStar® Communicate"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.ToolStripMenuItem2, Me.ChatRoomsToolStripMenuItem, Me.InstantMessageToolStripMenuItem1, Me.OptionsToolStripMenuItem, Me.AdministrativeContextMenu, Me.ToolStripMenuItem5, Me.ProdStarToolStripMenuItem, Me.ToolStripMenuItem4, Me.SignOffToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(160, 198)
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(156, 6)
        '
        'ChatRoomsToolStripMenuItem
        '
        Me.ChatRoomsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.JumpInLobbyToolStripMenuItem, Me.ToolStripMenuItem3, Me.FindRoomToolStripMenuItem, Me.CreateRoomToolStripMenuItem, Me.ToolStripSeparator1, Me.ChatOptionsToolStripMenuItem1})
        Me.ChatRoomsToolStripMenuItem.Name = "ChatRoomsToolStripMenuItem"
        Me.ChatRoomsToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.ChatRoomsToolStripMenuItem.Text = "Chat Rooms"
        '
        'JumpInLobbyToolStripMenuItem
        '
        Me.JumpInLobbyToolStripMenuItem.Name = "JumpInLobbyToolStripMenuItem"
        Me.JumpInLobbyToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.JumpInLobbyToolStripMenuItem.Text = "Jump In (Lobby)"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(157, 6)
        '
        'FindRoomToolStripMenuItem
        '
        Me.FindRoomToolStripMenuItem.Name = "FindRoomToolStripMenuItem"
        Me.FindRoomToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.FindRoomToolStripMenuItem.Text = "Find Room..."
        '
        'CreateRoomToolStripMenuItem
        '
        Me.CreateRoomToolStripMenuItem.Name = "CreateRoomToolStripMenuItem"
        Me.CreateRoomToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.CreateRoomToolStripMenuItem.Text = "Create Room..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(157, 6)
        '
        'ChatOptionsToolStripMenuItem1
        '
        Me.ChatOptionsToolStripMenuItem1.Name = "ChatOptionsToolStripMenuItem1"
        Me.ChatOptionsToolStripMenuItem1.Size = New System.Drawing.Size(160, 22)
        Me.ChatOptionsToolStripMenuItem1.Text = "Chat Options.."
        '
        'InstantMessageToolStripMenuItem1
        '
        Me.InstantMessageToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IMCenterToolStripMenuItem})
        Me.InstantMessageToolStripMenuItem1.Name = "InstantMessageToolStripMenuItem1"
        Me.InstantMessageToolStripMenuItem1.Size = New System.Drawing.Size(159, 22)
        Me.InstantMessageToolStripMenuItem1.Text = "Instant Message"
        '
        'IMCenterToolStripMenuItem
        '
        Me.IMCenterToolStripMenuItem.Name = "IMCenterToolStripMenuItem"
        Me.IMCenterToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.IMCenterToolStripMenuItem.Text = "IM Center"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChatOptionsToolStripMenuItem, Me.GeneralOptionsToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'ChatOptionsToolStripMenuItem
        '
        Me.ChatOptionsToolStripMenuItem.Name = "ChatOptionsToolStripMenuItem"
        Me.ChatOptionsToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.ChatOptionsToolStripMenuItem.Text = "Chat Options"
        '
        'GeneralOptionsToolStripMenuItem
        '
        Me.GeneralOptionsToolStripMenuItem.Name = "GeneralOptionsToolStripMenuItem"
        Me.GeneralOptionsToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.GeneralOptionsToolStripMenuItem.Text = "General Options"
        '
        'AdministrativeContextMenu
        '
        Me.AdministrativeContextMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SendGlobalMessageToolStripMenuItem, Me.DisconnectUserToolStripMenuItem1, Me.ToolStripMenuItem8, Me.ToggleAdministratorFlagToolStripMenuItem})
        Me.AdministrativeContextMenu.Name = "AdministrativeContextMenu"
        Me.AdministrativeContextMenu.Size = New System.Drawing.Size(159, 22)
        Me.AdministrativeContextMenu.Text = "Administrator "
        '
        'SendGlobalMessageToolStripMenuItem
        '
        Me.SendGlobalMessageToolStripMenuItem.Name = "SendGlobalMessageToolStripMenuItem"
        Me.SendGlobalMessageToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.SendGlobalMessageToolStripMenuItem.Text = "Send Global Message"
        '
        'DisconnectUserToolStripMenuItem1
        '
        Me.DisconnectUserToolStripMenuItem1.Name = "DisconnectUserToolStripMenuItem1"
        Me.DisconnectUserToolStripMenuItem1.Size = New System.Drawing.Size(186, 22)
        Me.DisconnectUserToolStripMenuItem1.Text = "Disconnect User"
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(183, 6)
        '
        'ToggleAdministratorFlagToolStripMenuItem
        '
        Me.ToggleAdministratorFlagToolStripMenuItem.Name = "ToggleAdministratorFlagToolStripMenuItem"
        Me.ToggleAdministratorFlagToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.ToggleAdministratorFlagToolStripMenuItem.Text = "Administrator Mode"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(156, 6)
        '
        'ProdStarToolStripMenuItem
        '
        Me.ProdStarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReportBugToolStripMenuItem1, Me.AboutToolStripMenuItem, Me.ToolStripMenuItem6, Me.HelpToolStripMenuItem2})
        Me.ProdStarToolStripMenuItem.Name = "ProdStarToolStripMenuItem"
        Me.ProdStarToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.ProdStarToolStripMenuItem.Text = "Help"
        '
        'ReportBugToolStripMenuItem1
        '
        Me.ReportBugToolStripMenuItem1.Image = CType(resources.GetObject("ReportBugToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ReportBugToolStripMenuItem1.Name = "ReportBugToolStripMenuItem1"
        Me.ReportBugToolStripMenuItem1.Size = New System.Drawing.Size(142, 22)
        Me.ReportBugToolStripMenuItem1.Text = "Report Bug..."
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Image = CType(resources.GetObject("AboutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.AboutToolStripMenuItem.Text = "About..."
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(139, 6)
        '
        'HelpToolStripMenuItem2
        '
        Me.HelpToolStripMenuItem2.Image = CType(resources.GetObject("HelpToolStripMenuItem2.Image"), System.Drawing.Image)
        Me.HelpToolStripMenuItem2.Name = "HelpToolStripMenuItem2"
        Me.HelpToolStripMenuItem2.Size = New System.Drawing.Size(142, 22)
        Me.HelpToolStripMenuItem2.Text = "Help.."
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(156, 6)
        '
        'SignOffToolStripMenuItem
        '
        Me.SignOffToolStripMenuItem.Name = "SignOffToolStripMenuItem"
        Me.SignOffToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.SignOffToolStripMenuItem.Text = "Sign Off"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'MainWindow
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(963, 725)
        Me.Controls.Add(Me.pnlUltima)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximumSize = New System.Drawing.Size(1024, 768)
        Me.Name = "MainWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ProdStar® Network - SIGN ON"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GoToToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pnlUltima As System.Windows.Forms.Panel
    Friend WithEvents InstantMessageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoffQuitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutProdstarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents HelpToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoffToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CheckAlive As System.ComponentModel.BackgroundWorker
    Friend WithEvents AccountToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportBugToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ChatRoomsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JumpInLobbyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FindRoomToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreateRoomToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ChatOptionsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InstantMessageToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IMCenterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChatOptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GeneralOptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SignOffToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProdStarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportBugToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents HelpToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AdministratorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdminGlobalMsg As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DisconnectUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToggleAdmin As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdministrativeContextMenu As ToolStripMenuItem
    Friend WithEvents SendGlobalMessageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DisconnectUserToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem8 As ToolStripSeparator
    Friend WithEvents ToggleAdministratorFlagToolStripMenuItem As ToolStripMenuItem
End Class
