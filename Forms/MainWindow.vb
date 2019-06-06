Imports System.Threading
Imports System.ComponentModel
Imports System.IO
Imports Microsoft.Win32

Public Class MainWindow
    'Class Members
    Dim altcount, shiftcount, controlcount As Integer
    'Main Networker
    Public MainNetworkingDevice As New ClientConnector(Me)
    ' User Session Object
    Dim UserSession As New UserSession
    ' Window Pointer
    Dim WindowPointer As WindowPointers
    ' From Server
    Public FromServer As Thread
    Dim GetRooms As Thread

    Dim _lockingObject As Object

    Public Sub New()
        WindowPointer = New WindowPointers 'Moved from Load
        WindowPointers.MainWindow = Me
        InitializeComponent()
    End Sub

    Private Sub MainWindow_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        LogConnection("User " + UserSession.UserID + " logged off.")
        Application.Exit()
    End Sub

    Private Sub MainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim regKey As RegistryKey
        Dim pRegKey As RegistryKey
        regKey = Registry.CurrentUser.OpenSubKey("SOFTWARE", True)
        regKey.CreateSubKey("ProdStarCommunicate")
        regKey.Close()
        pRegKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\ProdStarCommunicate", True)
        pRegKey.SetValue("Version", VERSION)
        pRegKey.Close()
        Me.KeyPreview = True
        altcount = 0
        shiftcount = 0
        controlcount = 0
        GetRooms = New Thread(Sub() TopRoomsDL())
        GetRooms.Start()
    End Sub
    Public Sub ConnectToServer(strID As String, strPass As String)
        Dim hwndConnection As New Connection(Me)
        WindowPointers.Connection = hwndConnection
        Me.Invoke(Sub() WindowPointers.Connection.Show())

        MainNetworkingDevice.DoConnect()
        ' Are we connected?
        If MainNetworkingDevice.GetClientSocket.Connected Then
            ' Thread to receive
            FromServer = New Thread(New ThreadStart(AddressOf receivedata))
            FromServer.IsBackground = True
            FromServer.Start()
            If CancelCon = False Then
                Me.Invoke(Sub() WindowPointers.Connection.SetText("Authenticating...."))
                Me.DoSendToServer("USER" + DELIMITER + "LOGIN" + DELIMITER + strID + DELIMITER + "0" + DELIMITER + strPass)
            End If
        End If
    End Sub
    Public Sub CheckAdministrativeMenu()
        '// Control access to the admin tool bar
        If (UserSession.AccessLevel > 0) Then
            AdministrativeContextMenu.Visible = True
            AdministratorToolStripMenuItem.Visible = True
            If (UserSession.AccessLevel > 1) Then
                DisconnectUserToolStripMenuItem1.Visible = True
                DisconnectUserToolStripMenuItem.Visible = True
            End If
            If (UserSession.AccessLevel > 2) Then
                SendGlobalMessageToolStripMenuItem.Visible = True
                AdminGlobalMsg.Visible = True
            End If
        End If
        '// Set AdminOn/Off
        If (UserSession.AdministratorFlagOn) Then
            ToggleAdmin.Checked = False
            ToggleAdministratorFlagToolStripMenuItem.Checked = False
        Else
            ToggleAdmin.Checked = True
            ToggleAdministratorFlagToolStripMenuItem.Checked = True
        End If
    End Sub
    Sub MainWindow_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        ' Alt
        If (e.KeyValue.ToString = 18 And shiftcount = 0 And controlcount = 0) Then
            altcount = altcount + 1
        ElseIf (e.KeyValue.ToString = 16 And altcount = 2 And controlcount = 0) Then
            shiftcount = shiftcount + 1
        ElseIf (e.KeyValue.ToString = 17 And altcount = 2 And shiftcount = 2) Then
            controlcount = controlcount + 1
        ElseIf (e.KeyValue.ToString = 57 And altcount = 2 And shiftcount = 2 And controlcount = 2) Then 'And altcount = 2 And shiftcount = 2 And controlcount = 1) Then
            MessageBox.Show("You found it!")
        Else
            altcount = 0
            shiftcount = 0
            controlcount = 0
        End If
    End Sub

    Public Sub DoSendToServer(command As String)
        If Not IsNothing(MainNetworkingDevice) Then MainNetworkingDevice.DoSend(command)
    End Sub

    '
    ' This code is run in a separate thread.  It passes data
    ' received from the server to the different forms of the
    ' application.
    '
    Private Sub receivedata()
        ' Buffer to hold everything received from the server.
        Dim receivedCommand As String
        While MainNetworkingDevice.GetClientSocket.Connected And Not IsNothing(UserSession) And Not CancelCon

            ' Receive a line into receivedCommand
            receivedCommand = MainNetworkingDevice.DoReceive
            ' Parse like a boss
            Dim strParsed() As String = Split(receivedCommand, DELIMITER)
            Select Case strParsed(0)
                Case "USER"
                    Me.Invoke(Sub() ParseUSER(Me, UserSession, receivedCommand))
                Case "IMSG"
                    Me.Invoke(Sub() ParseIMSG(Me, UserSession, receivedCommand))
                Case "CHAT"
                    Me.Invoke(Sub() ParseCHAT(Me, UserSession, receivedCommand))
                Case "ADMIN"
                    Me.Invoke(Sub() ParseADMIN(Me, UserSession, receivedCommand))
                Case "FAIL"
                    ' General Failure
                Case Else


            End Select
        End While
    End Sub
    Public Sub ClientDisconnected(Optional Recon As Boolean = False)
        If Not IsNothing(MainNetworkingDevice) Then
            MainNetworkingDevice.DoFlush()

            MainNetworkingDevice.GetClientSocket.Shutdown(Net.Sockets.SocketShutdown.Both)
            MainNetworkingDevice.GetClientSocket.Disconnect(False)
            LogConnection("Client Disconnected.")
            Try
                If Not IsNothing(Connector) Then Connector.Abort()
                If Not IsNothing(FromServer) Then FromServer.Abort()
                If Not IsNothing(CheckAlive) Then CheckAlive.CancelAsync()
            Catch Err As Exception
                '// Thread.Abort always throws exception, ignoring
                ' If VERBOSE = True Then LogError(Err.ToString)
            End Try
        End If
        UserSession.JumpRoom = Nothing
        UserSession.JumpArea = Nothing
        UserSession.AccessLevel = 0
        UserSession.AdministratorFlagOn = False
        AdministratorToolStripMenuItem.Visible = False
        Me.CheckAdministrativeMenu()

        If My.Settings.EnableNotify = True Then PlaySound("GOODBYEF.WAV")

        'Close forms
        If Not Application.OpenForms.OfType(Of SignOn).Any Then
            Try
                For Each frm In My.Application.OpenForms
                    If Not frm.Name.Equals(Me.Name) Then frm.Close()
                Next
            Catch Err As InvalidOperationException
                ' // Normal operation throws Exception, not logging
                ' If VERBOSE = True Then LogError(Err.ToString)
            End Try
            ReportBugToolStripMenuItem.Enabled = False

            Dim SignOnScreen As New SignOn(Me, UserSession)
            If My.Settings.RememberPasswd = True And My.Settings.AutoRecon = True And Recon = True Then UserSession.AutoReconnecting = True
            WindowPointers.SignOn = SignOnScreen
            Me.Invoke(Sub() WindowPointers.SignOn.Show(Me))
            CancelCon = False
        End If
    End Sub

    ' Spawn Member Information screen
    Public Sub OpenMemberInformation()
        Me.Invoke(Sub() WindowPointers.MemberInformation.Show())
    End Sub

    Private Sub InstantMessageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InstantMessageToolStripMenuItem.Click

        If Not Application.OpenForms().OfType(Of IMCenter).Any Then

            Dim IMWindow As New IMCenter(WindowPointers.MainWindow, UserSession)
            WindowPointers.InstantMessageCenter = IMWindow
            Me.Invoke(Sub() WindowPointers.InstantMessageCenter.Show(Me))
        Else
            WindowPointers.InstantMessageCenter.Show()
            WindowPointers.InstantMessageCenter.BringToFront()

        End If

    End Sub

    Public Function GetConversationPointer(Person As String)  ' Moved to MainWnd from IMCenter for accessibility
        '// Make a copy of the person's name
        Dim PersonCopy As String = Person
        '// Does PersonCopy have a (NEW) appended to it?
        If (InStr(PersonCopy, " (NEW)") <> 0) Then
            ' Yes.  Remove it.
            PersonCopy = Mid(PersonCopy, 1, InStr(PersonCopy, " (NEW)") - 1)
        End If
        '// Pull the conversation out of memory
            If Not IsNothing(UserSession.InstantMessages) Then
                '// Try to set the buffer.
                If (UserSession.InstantMessages.ContainsKey(PersonCopy)) Then
                    Return UserSession.InstantMessages.Item(PersonCopy)
                Else
                    Return Nothing
                End If
            Else
                Return Nothing
            End If
    End Function

    Private Sub MainWindow_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim SignOnScreen As New SignOn(Me, UserSession)
        WindowPointers.SignOn = SignOnScreen
        Me.Invoke(Sub() WindowPointers.SignOn.Show(Me))
        WindowPointers.SignOn.BringToFront()
        If My.Settings.ModernStyle = True Then
            NotifyIcon1.Visible = True
            Me.Hide()
        End If
    End Sub

    Private Sub ChatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChatToolStripMenuItem.Click
        If Not (Application.OpenForms().OfType(Of ChatLaunch).Any) Then
            Dim CLoader As New ChatLaunch(Me, UserSession)
            WindowPointers.ChatLaunch = CLoader
        End If
        Me.Invoke(Sub() WindowPointers.ChatLaunch.Show(Me))
        Me.Invoke(Sub() WindowPointers.ChatLaunch.BringToFront())
    End Sub

    Private Sub MainWindow_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        Try
            If Not IsNothing(MainNetworkingDevice) Then Me.Invoke(Sub() DoSendToServer("USER" + DELIMITER + "LOGOFF" + DELIMITER + "0" + DELIMITER + "0" + DELIMITER + "0"))
        Catch Err As NullReferenceException
            If VERBOSE = True Then LogError(Err.ToString)
        End Try
        If My.Settings.EnableNotify = True Then PlaySound("GOODBYEF.WAV", True)
    End Sub

    Private Sub LogoffQuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoffQuitToolStripMenuItem.Click
        LogConnection("Client disconnected.")
        Application.Exit()
    End Sub

    Private Sub LogoffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoffToolStripMenuItem.Click
        Me.Invoke(Sub() DoSendToServer("USER" + DELIMITER + "LOGOFF" + DELIMITER + "0" + DELIMITER + "0" + DELIMITER + "0"))
        ClientDisconnected()
    End Sub

    Public Sub CheckAlive_DoWork(sender As Object, e As DoWorkEventArgs) Handles CheckAlive.DoWork
        e.Cancel = False

        Do
            If CheckAlive.CancellationPending = True Then
                e.Cancel = True
                CheckAlive.Dispose()
                Exit Do
            End If
            If Not MainNetworkingDevice.IsConnected Then
                ShowChatMessage(Me, UserSession, "You have been unexpectedly disconnected from the server. Please sign-on again.", "ProdStar® CHAT - Disconnected")
                Try
                    WindowPointers.MainWindow.Invoke(Sub() ClientDisconnected(True))
                Catch ex As Exception

                End Try

                Exit Sub
            End If
            Thread.Sleep(5000)
        Loop
    End Sub

    Private Sub ChangePasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        Dim cPasswd As New ChangePassword(Me, UserSession)
        WindowPointers.ChangePassword = cPasswd
        WindowPointers.MainWindow.Invoke(Sub() WindowPointers.ChangePassword.Show(Me))
    End Sub

    Public Sub TopRoomsDL()
        '//Downloading Strings instead of saving the file to temp. Avoids local writes
        Dim wClient As New System.Net.WebClient
        Dim AESCrypt As New AESEncrypter
        Dim verstring As String

        If My.Settings.UseProxy = True Then
            Dim ProxyCred As New System.Net.NetworkCredential
            Dim wProxy As New System.Net.WebProxy
            Dim pURL As New Uri(My.Settings.ProxyHost + ":" + My.Settings.ProxyPort)

            With ProxyCred
                .UserName = My.Settings.ProxyUser
                .Password = AESCrypt.Decrypt(My.Settings.ProxyPass, "numbsku11")
            End With
            With wProxy
                .Address = pURL
                .Credentials = ProxyCred
            End With
            wClient.Proxy = wProxy
        End If

        AddHandler wClient.DownloadStringCompleted, AddressOf AsyncCallBackProc
        Dim URL As New Uri("https://www.prodigyclassic.com/clientres/toprooms.txt")
        Dim verUrl As New Uri("https://www.prodigyclassic.com/clientres/version.txt")

        Try
            verstring = wClient.DownloadString(verUrl).Trim
            wClient.DownloadStringAsync(URL)
        Catch Err As Exception
            LogError(Err.ToString)
            ShowChatMessage(Me, Nothing, "ProdStar® Chat - Error", "Error Downloading Top Rooms list. The server may be unavailable.")
        End Try

        If Not IsNothing(verstring) Then
            If verstring <> VERSION Then
                Dim uProc As New ProcessStartInfo
      
                ShowChatMessage(Me, Nothing, "ProdStar® Chat - Update Required", "A newer version of this program (Version " + verstring + ") is available." + vbNewLine + vbNewLine + "Click Okay to begin updating.")
                frmUpdater.Show()
                frmUpdater.Invoke(Sub() frmUpdater.BeginUpdate())
            Else
                UserSession.ClientUpdated = True
                Me.Invoke(Sub() WindowPointers.SignOn.EnableButton())
            End If
        End If
    End Sub

    Public Sub AsyncCallBackProc(ByVal sender As Object, ByVal e As System.Net.DownloadStringCompletedEventArgs)
        Dim RoomArray() As String = Split(e.Result, vbNewLine)
        For a = 0 To RoomArray.Count - 1
            If RoomArray(a).Trim <> "" Then WindowPointers.MainWindow.Invoke(Sub() WindowPointers.SignOn.AddItemToList(RoomArray(a).Replace(":", " - "), a))
        Next
    End Sub

    Private Sub AboutProdstarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutProdstarToolStripMenuItem.Click
        RestoreWindows()
        Dim frmAbout As New About(Me, UserSession)
        WindowPointers.AboutBox = frmAbout
        Me.Invoke(Sub() WindowPointers.AboutBox.Show())
    End Sub

    Private Sub HelpToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem1.Click
        MsgBox("Help Not Available.")
    End Sub

    Private Sub ReportBugToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportBugToolStripMenuItem.Click
        RestoreWindows()
        Dim frmReport As New BugReport(Me, UserSession, "", False)
        WindowPointers.BugReport = frmReport
        Me.Invoke(Sub() WindowPointers.BugReport.ShowDialog())
    End Sub

    Private Sub MainWindow_Resize(sender As Object, e As EventArgs) Handles Me.Resize

        ' Sometimes the collection is updated faster 
        ' than its processed And we end up out of bounds
        ' Using Resume Next rather than generate an exception

        If Me.WindowState = FormWindowState.Minimized Then
            For Each frm In My.Application.OpenForms
                On Error Resume Next
                frm.WindowState = FormWindowState.Minimized
            Next


            If My.Settings.MinimizeToTask = True Then
                'Me.Hide()
                NotifyIcon1.Visible = True
                NotifyIcon1.BalloonTipTitle = "ProdStar® Communicate"
                NotifyIcon1.BalloonTipText = "ProdStar has been minimized to the System Tray." + vbNewLine + vbNewLine + "Click Here to Re-Open the Application."
                NotifyIcon1.ShowBalloonTip(250)
                Me.Hide()
            End If
            UserSession.ClientHidden = True
        Else
            For Each Frm In My.Application.OpenForms
                On Error Resume Next
                Frm.WindowState = FormWindowState.Normal
            Next
        End If

    End Sub


    Private Sub NotifyIcon1_BalloonTipClicked(sender As Object, e As EventArgs) Handles NotifyIcon1.BalloonTipClicked
        '    Me.Show()
        '    Me.WindowState = FormWindowState.Normal
        '   NotifyIcon1.Visible = False
    End Sub

    Private Sub NotifyIcon1_Click(sender As Object, e As EventArgs) Handles NotifyIcon1.Click
        ContextMenuStrip1.Show()
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        RestoreWindows()

    End Sub


    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        NotifyIcon1.Visible = False
        RestoreWindows()

    End Sub

    Private Sub JumpInLobbyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JumpInLobbyToolStripMenuItem.Click
        RestoreWindows()
        If Not IsNothing(UserSession.CurrentChatRoom) Then DoSendToServer("CHAT" + DELIMITER + "PART" + DELIMITER + UserSession.CurrentArea + DELIMITER + "0" + DELIMITER + UserSession.CurrentChatRoom)
        DoSendToServer("CHAT" + DELIMITER + "JOIN" + DELIMITER + "Lobby" + DELIMITER + "Anything" + DELIMITER + "0")
    End Sub

    Private Sub FindRoomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FindRoomToolStripMenuItem.Click
        RestoreWindows()
        Dim frmArea As New AreaRoomSelect(Me, UserSession)
        WindowPointers.AreaSelect = frmArea
        Invoke(Sub() WindowPointers.AreaSelect.ShowDialog(WindowPointers.ChatLaunch))
    End Sub

    Private Sub CreateRoomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateRoomToolStripMenuItem.Click
        RestoreWindows()
        Dim frmCreateRoom As New CreateRoom(Me, UserSession)
        WindowPointers.CreateRoom = frmCreateRoom
        WindowPointers.CreateRoom.Show(WindowPointers.ChatLaunch)
    End Sub

    Private Sub ChatOptionsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ChatOptionsToolStripMenuItem1.Click
        RestoreWindows()
        Dim frmSetupOptions As New SetupOptions(Me, UserSession)
        WindowPointers.SetupOptions = frmSetupOptions
        WindowPointers.SetupOptions.Show(WindowPointers.ChatLaunch)
    End Sub

    Private Sub IMCenterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IMCenterToolStripMenuItem.Click
        RestoreWindows()

        If Not Application.OpenForms().OfType(Of IMCenter).Any Then

            Dim IMWindow As New IMCenter(WindowPointers.MainWindow, UserSession)
            WindowPointers.InstantMessageCenter = IMWindow
            Me.Invoke(Sub() WindowPointers.InstantMessageCenter.Show(WindowPointers.ChatLaunch))
        End If
        WindowPointers.InstantMessageCenter.Show()
        WindowPointers.InstantMessageCenter.BringToFront()
    End Sub


    Private Sub ChatOptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChatOptionsToolStripMenuItem.Click
        RestoreWindows()
        Dim frmSetupOptions As New SetupOptions(Me, UserSession)
        WindowPointers.SetupOptions = frmSetupOptions
        WindowPointers.SetupOptions.Show(WindowPointers.ChatLaunch)
    End Sub

    Private Sub GeneralOptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GeneralOptionsToolStripMenuItem.Click
        RestoreWindows()

        If Not Application.OpenForms().OfType(Of Options).Any Then
            Dim frmOptions As New Options
            frmOptions.Show()
            frmOptions.BringToFront()
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        RestoreWindows()
        LogConnection("Client disconnected.")
        Application.Exit()
    End Sub

    Private Sub SignOffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SignOffToolStripMenuItem.Click
        RestoreWindows()
        Me.Invoke(Sub() DoSendToServer("USER" + DELIMITER + "LOGOFF" + DELIMITER + "0" + DELIMITER + "0" + DELIMITER + "0"))
        ClientDisconnected()
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub ReportBugToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ReportBugToolStripMenuItem1.Click
        Dim frmReport As New BugReport(Me, UserSession, "", False)
        WindowPointers.BugReport = frmReport
        WindowPointers.BugReport.ShowDialog()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim frmAbout As New About(Me, UserSession)
        WindowPointers.AboutBox = frmAbout
        Me.Invoke(Sub() WindowPointers.AboutBox.Show())
    End Sub

    Private Sub HelpToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem2.Click
        MsgBox("Help Not Available.")
    End Sub

    Private Sub AdminGlobalMsg_Click(sender As Object, e As EventArgs) Handles AdminGlobalMsg.Click
        If Not (Application.OpenForms().OfType(Of AdminClientMessage).Any) Then
            Dim frmAdminMsg As New AdminClientMessage(Me, UserSession)
            WindowPointers.AdminClientMessage = frmAdminMsg
            Me.Invoke(Sub() WindowPointers.AdminClientMessage.Show(Me))
        Else
            WindowPointers.AdminClientMessage.Show()
            WindowPointers.AdminClientMessage.BringToFront()
        End If
    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub

    Private Sub DisconnectUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisconnectUserToolStripMenuItem.Click
        If Not (Application.OpenForms().OfType(Of AdminDisconnectUser).Any) Then
            Dim frmDiscoUser As New AdminDisconnectUser(Me, UserSession, Nothing)
            WindowPointers.AdminDisconnectUser = frmDiscoUser
            Me.Invoke(Sub() WindowPointers.AdminDisconnectUser.Show(Me))
        Else
            WindowPointers.AdminDisconnectUser.Show()
            WindowPointers.AdminDisconnectUser.BringToFront()
        End If
    End Sub


    Private Sub SendGlobalMessageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SendGlobalMessageToolStripMenuItem.Click
        RestoreWindows()
        If Not (Application.OpenForms().OfType(Of AdminClientMessage).Any) Then
            Dim frmAdminMsg As New AdminClientMessage(Me, UserSession)
            WindowPointers.AdminClientMessage = frmAdminMsg
            Me.Invoke(Sub() WindowPointers.AdminClientMessage.Show(Me))
        Else
            WindowPointers.AdminClientMessage.Show()
            WindowPointers.AdminClientMessage.BringToFront()
        End If
    End Sub

    Private Sub DisconnectUserToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DisconnectUserToolStripMenuItem1.Click
        RestoreWindows()

        If Not (Application.OpenForms().OfType(Of AdminDisconnectUser).Any) Then
            Dim frmDiscoUser As New AdminDisconnectUser(Me, UserSession, Nothing)
            WindowPointers.AdminDisconnectUser = frmDiscoUser
            Me.Invoke(Sub() WindowPointers.AdminDisconnectUser.Show(Me))
        Else
            WindowPointers.AdminDisconnectUser.Show()
            WindowPointers.AdminDisconnectUser.BringToFront()
        End If
    End Sub

    Private Sub ToggleAdministratorFlagToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToggleAdministratorFlagToolStripMenuItem.Click
        RestoreWindows()
        Dim onOff As String
        If (UserSession.AdministratorFlagOn) Then
            '// Turn the administrator flag off.
            UserSession.AdministratorFlagOn = False
            onOff = "OFF"
        Else
            '// Turn the administrator flag on
            onOff = "ON"
            UserSession.AdministratorFlagOn = True
        End If
        '// Send the command
        Me.Invoke(Sub() DoSendToServer("ADMIN" + DELIMITER + "ENABLEADMIN" + DELIMITER + "0" + DELIMITER + "0" + DELIMITER + "0" + DELIMITER + onOff))
    End Sub

    Private Sub ToggleAdmin_Click(sender As Object, e As EventArgs) Handles ToggleAdmin.Click
        Dim onOff As String
        If (UserSession.AdministratorFlagOn) Then
            '// Turn the administrator flag off.
            UserSession.AdministratorFlagOn = False
            onOff = "OFF"
        Else
            '// Turn the administrator flag on
            onOff = "ON"
            UserSession.AdministratorFlagOn = True
        End If
        '// Send the command
        Me.Invoke(Sub() DoSendToServer("ADMIN" + DELIMITER + "ENABLEADMIN" + DELIMITER + "0" + DELIMITER + "0" + DELIMITER + "0" + DELIMITER + onOff))
    End Sub
    Public Sub RestoreWindows()
        If Application.OpenForms().OfType(Of MainWindow).Any Then
            WindowPointers.MainWindow.Show()
            WindowPointers.MainWindow.WindowState = FormWindowState.Maximized
        End If
        If Not Application.OpenForms().OfType(Of ChatLaunch).Any Then
            Dim frmCL As New ChatLaunch(Me, UserSession)
            WindowPointers.ChatLaunch = frmCL
        End If
        For Each frm In My.Application.OpenForms
            On Error Resume Next
            frm.WindowState = FormWindowState.Normal
        Next
        If Application.OpenForms().OfType(Of ChatType).Any Then
            WindowPointers.ChatType.Show()
            WindowPointers.ChatType.WindowState = FormWindowState.Normal
            WindowPointers.ChatType.BringToFront()
        End If
        UserSession.ClientHidden = False
    End Sub
End Class