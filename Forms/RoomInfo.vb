Public Class RoomInfo

    ' Main Window - For communication with the server
    Dim TheMainWindow As MainWindow
    Dim ThisSession As UserSession
    Delegate Sub SetUsersCallback([users] As String)
    Delegate Sub RoomDetailsCallback([lblCreatedBy] As String, [lblPasswords] As String, [lblOccupants] As String, [lblRoomCapacity] As String)

    Public Sub New(hwndMain As MainWindow, CurrentSession As UserSession, pRoom As ChatRoom)
        '// Initial setup.
        TheMainWindow = hwndMain
        ThisSession = CurrentSession
        InitializeComponent()
        '// Populate the details of the chat room except the users.
        RoomDetails(pRoom.RoomMaker, pRoom.GetPasswordsString(pRoom.HasPasswordEntry, pRoom.HasPasswordText), pRoom.CurrentChatters, pRoom.MaxChatters)
        TheMainWindow.DoSendToServer("CHAT" + DELIMITER + "NAMES" + DELIMITER + pRoom.ChatRoomArea.ChatRoomArea + DELIMITER + "0" + DELIMITER + pRoom.ChatRoomName)
        If My.Settings.ModernStyle = True Then
            Me.BackColor = DefaultBackColor
            For Each cControl In Me.Controls
                CType(cControl, Control).BackColor = DefaultBackColor
                CType(cControl, Control).ForeColor = DefaultForeColor
                CType(cControl, Control).Font = DefaultFont
            Next
            lbMembersHere.ForeColor = DefaultForeColor
            lbMembersHere.BackColor = SystemColors.Window
            pnlRoomOccupants.BorderStyle = BorderStyle.None
            lbMembersHere.BorderStyle = BorderStyle.Fixed3D
        End If
    End Sub

    Private Sub lblMembersHere_DoubleClick(sender As Object, e As EventArgs) Handles bnCancel.Click
        '// Double-clicking a user here spawns the Instant Message Window.
        Dim doubleClickedUser As String
        doubleClickedUser = lbMembersHere.SelectedItem
        '// Spawn the Instant Message window with "doubleClickedUser"
        '// in the To field.
    End Sub

    Private Sub bnCancel_click(sender As Object, e As EventArgs) Handles bnCancel.Click
        Me.Hide()
    End Sub

    '//
    '// Update the information on the form.
    '//
    Public Sub PopulateRoomUsers(RoomUsers As String)
        '// Hold the comma-delimited list of users

        '// Hold the list of users to be displayed.
        Dim UsersInRoom As ArrayList

        '// Split it on a comma.
        UsersInRoom = New ArrayList(RoomUsers.Split(","))
        '// Did we initialize the users?
        If (Not IsNothing(UsersInRoom)) Then
            '// Update the dialog with the latest users in the room.
            For Each user As String In UsersInRoom
                AddToCurrentChatters(user.Trim())
            Next user
            lbMembersHere.SelectedIndex = 0
        End If
    End Sub

    ' Threadsafe.
    Private Sub AddToCurrentChatters(ByVal [users] As String)
        ' InvokeRequired required compares the thread ID of the 
        ' calling thread to the thread ID of the creating thread. 
        ' If these threads are different, it returns true. 
        If Me.lbMembersHere.InvokeRequired Then
            Dim d As New SetUsersCallback(AddressOf AddToCurrentChatters)
            Me.Invoke(d, New Object() {[users]})
        Else
            Me.lbMembersHere.Items.Add([users])
        End If
    End Sub

    ' Threadsafe.
    Private Sub RoomDetails([lblCreatedBy] As String, [lblPasswords] As String, [lblOccupants] As String, [lblRoomCapacity] As String)
        ' InvokeRequired required compares the thread ID of the 
        ' calling thread to the thread ID of the creating thread. 
        ' If these threads are different, it returns true. 
        If Me.lblCreatedBy.InvokeRequired Or Me.lblPasswords.InvokeRequired Or Me.lblOccupants.InvokeRequired Or Me.lblRoomCapacity.InvokeRequired Then
            Dim d As New RoomDetailsCallback(AddressOf RoomDetails)
            Me.Invoke(d, New Object() {[Created], [lblPasswords], [lblOccupants], [lblRoomCapacity]})
        Else
            '// Update the form.
            Me.lblCreatedBy.Text = [lblCreatedBy]
            Me.lblPasswords.Text = [lblPasswords]
            Me.lblOccupants.Text = [lblOccupants]
            Me.lblRoomCapacity.Text = [lblRoomCapacity]
        End If
    End Sub

    Private Sub RoomInfo_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub


    Sub RoomInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterForm(Me, Me.Owner)

    End Sub

 
    Private Sub lbMembersHere_DoubleClick(sender As Object, e As EventArgs)
        '// Double-Click event on the listbox.
        '// If a nick name is doubleclicked, spawn the member information
        '// screen with their MI populated.
        Dim nicknameClicked As String
        nicknameClicked = lbMembersHere.SelectedItem
        ' Did we actually click on a NN?
        If (Not IsNothing(nicknameClicked)) Then
            ' We actually did select a NN.  Do something with it.
            Dim memberInformation As New MemberInformation(TheMainWindow, ThisSession, nicknameClicked)
            WindowPointers.MemberInformation = memberInformation
            memberInformation.Show()
        End If
    End Sub



    Private Sub bnIMSend_Click(sender As Object, e As EventArgs) Handles bnIMSend.Click
        If Not Application.OpenForms().OfType(Of IMCenter).Any Then

            Dim IMWindow As New IMCenter(WindowPointers.MainWindow, ThisSession)
            WindowPointers.InstantMessageCenter = IMWindow
            Me.Invoke(Sub() WindowPointers.InstantMessageCenter.Show(TheMainWindow))
            WindowPointers.InstantMessageCenter.BringToFront()
        Else
            WindowPointers.InstantMessageCenter.Show()
            WindowPointers.InstantMessageCenter.BringToFront()

        End If
        WindowPointers.InstantMessageCenter.tbTo.Text = lbMembersHere.SelectedItem.ToString
    End Sub

    Private Sub bnOverrideList_Click(sender As Object, e As EventArgs)
        TheMainWindow.DoSendToServer("ADMIN" + DELIMITER + "USERLIST" + DELIMITER + "0" + DELIMITER + "0" + DELIMITER + "0" + DELIMITER + "0")
    End Sub

 
    Private Sub lbMembersHere_DoubleClick1(sender As Object, e As EventArgs) Handles lbMembersHere.DoubleClick
        '// Double-Click event on the listbox.
        '// If a nick name is doubleclicked, spawn the member information
        '// screen with their MI populated.
        Dim nicknameClicked As String
        nicknameClicked = lbMembersHere.SelectedItem
        ' Did we actually click on a NN?
        If (Not IsNothing(nicknameClicked)) Then
            ' We actually did select a NN.  Do something with it.
            Dim memberInformation As New MemberInformation(TheMainWindow, ThisSession, nicknameClicked)
            WindowPointers.MemberInformation = memberInformation
            memberInformation.Show()
        End If
    End Sub
End Class