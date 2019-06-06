Public Class ChatLaunch
    Dim TheMainWindow As MainWindow
    Dim ThisSession As UserSession
    Public Sub New(MainWindow As MainWindow, CurrentSession As UserSession)
        TheMainWindow = MainWindow
        ThisSession = CurrentSession
        ' This call is required by the designer.
        InitializeComponent()
        WebBrowser1.Navigate("https://www.prodigyclassic.com/clientres/MOTD.htm")

        If My.Settings.ModernStyle = True Then
            PictureBox3.Visible = False
            lblClose.Visible = True
            ckShow.Visible = True
            ckShow.Checked = My.Settings.LaunchShow
        End If
        If My.Settings.LaunchShow = False Then Me.Hide()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim frmArea As New AreaRoomSelect(TheMainWindow, ThisSession)
        WindowPointers.AreaSelect = frmArea
        If My.Settings.ModernStyle = False Then
            TheMainWindow.Invoke(Sub() WindowPointers.AreaSelect.ShowDialog(Me))
        Else
            TheMainWindow.Invoke(Sub() WindowPointers.AreaSelect.Show(TheMainWindow))
        End If
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        If Not IsNothing(ThisSession.CurrentChatRoom) Then TheMainWindow.DoSendToServer("CHAT" + DELIMITER + "PART" + DELIMITER + ThisSession.CurrentArea + DELIMITER + "0" + DELIMITER + ThisSession.CurrentChatRoom)
        TheMainWindow.DoSendToServer("CHAT" + DELIMITER + "JOIN" + DELIMITER + "Lobby" + DELIMITER + "Anything" + DELIMITER + "0")
    End Sub

    Private Sub ChatLaunch_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
        Invalidate()
    End Sub

    Private Sub ChatLaunch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TheMainWindow.ReportBugToolStripMenuItem.Enabled = True
        CenterForm(Me, TheMainWindow)
        ThisSession.ClientHidden = False
        If Not IsNothing(ThisSession.JumpArea) Then
            TheMainWindow.DoSendToServer("CHAT" + DELIMITER + "JOIN" + DELIMITER + ThisSession.JumpArea + DELIMITER + ThisSession.JumpRoom + DELIMITER + "0,0")
        End If
        WindowPointers.MainWindow.InstantMessageToolStripMenuItem.Enabled = True
        WindowPointers.MainWindow.ChatToolStripMenuItem.Enabled = True
        WindowPointers.MainWindow.LogoffToolStripMenuItem.Enabled = True
    End Sub

    Private Sub LinkLabel6_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel6.LinkClicked
        Dim strNewNick As String
        Dim frmInput As New UserInput(TheMainWindow, ThisSession, "Select/Change Nickname.", "New Nickname:", "Please choose a Chat Nickname between 3-12 characters in length.", ThisSession.TrueNickName)
        WindowPointers.UserInput = frmInput
        Dim dResult As DialogResult = WindowPointers.UserInput.ShowDialog(Me)
        Select Case dResult
            Case vbOK
                strNewNick = WindowPointers.UserInput.tbEntry.Text
                WindowPointers.UserInput.Close()
                TheMainWindow.DoSendToServer("USER" + DELIMITER + "NICK" + DELIMITER + "0" + DELIMITER + "0" + DELIMITER + strNewNick)
            Case vbCancel
                WindowPointers.UserInput.Close()
        End Select
    End Sub

    Private Sub LinkLabel7_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel7.LinkClicked
        Dim frmSetupOptions As New SetupOptions(TheMainWindow, ThisSession)
        WindowPointers.SetupOptions = frmSetupOptions
        WindowPointers.SetupOptions.Show(Me)
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        Dim frmAbout As New About(TheMainWindow, ThisSession)
        WindowPointers.AboutBox = frmAbout
        TheMainWindow.Invoke(Sub() WindowPointers.AboutBox.Show())
    End Sub
    Private Sub LinkLabel5_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        Process.Start("https://prodigy.dreamstruct.com/forums/index.php")
    End Sub

    Private Sub lblMOTD_Click(sender As Object, e As EventArgs) Handles lblMOTD.Click
        WebBrowser1.Navigate("https://www.prodigyclassic.com/clientres/MOTD.htm")
    End Sub

    Private Sub lblGuidelines_Click(sender As Object, e As EventArgs) Handles lblGuidelines.Click
        WebBrowser1.Navigate("https://www.prodigyclassic.com/clientres/guidelines.htm")
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        WebBrowser1.Navigate("https://www.prodigyclassic.com/clientres/newchats.htm")
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)
        WebBrowser1.Navigate("https://www.prodigyclassic.com/clientres/faq.htm", False)
    End Sub

    Private Sub ckShow_CheckedChanged(sender As Object, e As EventArgs) Handles ckShow.CheckedChanged
        If ckShow.Checked = True Then
            My.Settings.LaunchShow = True
        Else
            My.Settings.LaunchShow = False
        End If
    End Sub

    Private Sub bnClose_Click(sender As Object, e As EventArgs)
        Me.Hide()
        MainWindow.NotifyIcon1.BalloonTipText = "ProdStar® is still running in the System Tray." + vbNewLine + vbNewLine + "Right-Click the ProdStar® Icon for Navigation."
        MainWindow.NotifyIcon1.ShowBalloonTip(2000)
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblClose.LinkClicked
        Me.Hide()
    End Sub
End Class