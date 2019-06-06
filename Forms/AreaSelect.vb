Imports System.Threading
Imports System.Runtime.InteropServices

Public Class AreaRoomSelect

    ' Main Window - For communication with the server
    Dim TheMainWindow As MainWindow
    Dim ThisSession As UserSession
    Dim doShift As Boolean

    Public Sub New(hwndMain As MainWindow, CurrentSession As UserSession)
        TheMainWindow = hwndMain
        ThisSession = CurrentSession

        InitializeComponent()
        If My.Settings.ModernStyle = True Then
            Me.BackColor = DefaultBackColor
            For Each cControl In Me.Controls

                If TypeOf cControl Is ListBox Then
                    CType(cControl, ListBox).BorderStyle = BorderStyle.Fixed3D
                    CType(cControl, ListBox).BackColor = SystemColors.Window
                ElseIf TypeOf cControl Is ComboBox Then
                    CType(cControl, ComboBox).FlatStyle = FlatStyle.Standard
                    CType(cControl, ComboBox).BackColor = SystemColors.Window
                ElseIf TypeOf cControl Is TextBox Then
                    CType(cControl, TextBox).BorderStyle = BorderStyle.Fixed3D
                    CType(cControl, TextBox).BackColor = SystemColors.Window
                Else
                    CType(cControl, Control).BackColor = DefaultBackColor
                    CType(cControl, Control).Font = DefaultFont
                End If
                CType(cControl, Control).ForeColor = DefaultForeColor
            Next
            rbProdStar.BackColor = DefaultBackColor
            rbProdStar.ForeColor = DefaultForeColor
            rbAuditorium.BackColor = DefaultBackColor
            rbAuditorium.ForeColor = DefaultForeColor
            rbMember.BackColor = DefaultBackColor
            rbMember.ForeColor = DefaultForeColor

            tbRoomName.BorderStyle = BorderStyle.Fixed3D
            tbRoomName.BackColor = SystemColors.Window
            lbAreaSelect.BackColor = SystemColors.Window
            lbAreaSelect.ForeColor = DefaultForeColor
            lbRooms.BackColor = SystemColors.Window
            lbRooms.ForeColor = DefaultForeColor
        End If

    End Sub



    Private Const LB_SETTABSTOPS As Int32 = &H192
    Delegate Sub SetTextCallback([text] As String)
    Dim AllAreas As List(Of ChatArea)
    Dim RoomTypeSort As String

    Public Sub SetListboxTabs()
        Dim ListBoxTabs() As Integer = {145, 170}
        Dim result As Integer
        Dim ptr As IntPtr
        Dim pinnedArray As GCHandle

        pinnedArray = GCHandle.Alloc(ListBoxTabs, GCHandleType.Pinned)
        ptr = pinnedArray.AddrOfPinnedObject()
        'Send LB_SETTABSTOPS message to ListBox.
        result = SendMessage(Me.lbRooms.Handle, LB_SETTABSTOPS, _
          New IntPtr(ListBoxTabs.Length), ptr)
        pinnedArray.Free()

        'Refresh the ListBox control.
        Me.lbRooms.Refresh()
    End Sub

    Private Sub AreaRoomSelect_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Not (Application.OpenForms().OfType(Of frmChatWindow).Any) Then
            WindowPointers.ChatLaunch.Enabled = True
            ResumeDrawing(WindowPointers.ChatLaunch, False)
        End If
    End Sub

    Private Sub AreaRoomSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MoveForm(Me)
        AllAreas = New List(Of ChatArea)
        SetListboxTabs()
        rbProdStar.Checked = True
        RoomTypeSort = "ProdStar"
        lbRooms.UseTabStops = True
        TheMainWindow.DoSendToServer("CHAT" + DELIMITER + "LISTOFAREAS" + DELIMITER + "0" + DELIMITER + "0" + DELIMITER + "0")

        '// Administration?
        If ThisSession.AccessLevel >= 2 And ThisSession.AdministratorFlagOn Then
            '// Show close room button
            bnCloseRoom.Visible = True
            bnAdminJoin.Visible = True
        Else
            bnCloseRoom.Visible = False
            bnAdminJoin.Visible = False
        End If

    End Sub




    ' Returns a pointer to the chat area referenced by
    ' AreaName.  If not found, returns Nothing
    '
    ' According to the documentation, Collections.Contains is an O(n) 
    ' operation.  Because of this, we'll sort-of re-invent the wheel
    ' and implement our own linear search that returns a pointer to
    ' the needed object.
    Public Function GetAreaByName(AreaName As String) As ChatArea
        ' Was the Area List initialized?
        'If (Not AllAreas Is Nothing) Then
        ' The list was initialized.
        'For Each area As ChatArea In AllAreas
        ' Is this the area we need?
        'If area.ChatRoomArea.ToUpper = AreaName.ToUpper Then
        'Return area
        ' End If
        'Next
        'Return Nothing
        'Else
        'Return Nothing
        'End If
        Return ThisSession.ChatAreaCache.Item(AreaName)
    End Function

    '// This subroutine updates the list of chat areas from the 
    '// session cache.  The cache should always be updated prior
    '// calling this method.
    Public Sub UpdateAreaListFromSession()
        '// Buffer to hold the list
        Dim areaList As New List(Of ChatArea)
        '// Iterate over all of the areas in the cache and add them 
        For Each thisArea As ChatArea In ThisSession.ChatAreaCache.Values
            areaList.Add(thisArea)
        Next
        '// Sort before adding into the listbox.
        areaList.Sort(Function(x As ChatArea, y As ChatArea) String.Compare(x.ChatRoomArea, y.ChatRoomArea))
        ' // Clear anything currently in the area list.
        If (lbAreaSelect.Items.Count > 0) Then
            lbAreaSelect.Items.Clear()
        End If
        ' // Add the sorted list to the backing list of the listbox.
        For Each c As ChatArea In areaList
            If Not c.ChatRoomArea = "PRIVATE" Or ThisSession.AccessLevel > 0 Then
                lbAreaSelect.Items.Add(c.ChatRoomArea)
            End If
        Next
        If Not IsNothing(ThisSession.CurrentArea) Then
            lbAreaSelect.SelectedItem = ThisSession.CurrentArea
        Else
            lbAreaSelect.SelectedIndex = 0
        End If
    End Sub

    ' Threadsafe.
    Private Sub AddToAreaList(ByVal [text] As String)
        ' InvokeRequired required compares the thread ID of the 
        ' calling thread to the thread ID of the creating thread. 
        ' If these threads are different, it returns true. 
        If Me.lbAreaSelect.InvokeRequired Then
            Dim d As New SetTextCallback(AddressOf AddToAreaList)
            Me.Invoke(d, New Object() {[text]})
        Else
            If [text] <> "PRIVATE" Then Me.lbAreaSelect.Items.Add([text])
            If lbAreaSelect.SelectedIndex = -1 Then
                lbAreaSelect.SelectedIndex = 0
                PopulateRoomsForArea(lbAreaSelect.SelectedItem.ToString, GetRoomTypeSort())
            End If

        End If
    End Sub

    ' Threadsafe.
    Private Sub AddToRoomList(ByVal [text] As String)
        ' InvokeRequired required compares the thread ID of the 
        ' calling thread to the thread ID of the creating thread. 
        ' If these threads are different, it returns true. 
        If Me.lbRooms.InvokeRequired Then
            Dim d As New SetTextCallback(AddressOf AddToRoomList)
            Me.Invoke(d, New Object() {[text]})
        Else
            Me.lbRooms.Items.Add([text])
        End If
    End Sub

    '// Trigger the repopulation of the chat room list.
    Public Sub RepopulateChatRooms(theArea As ChatArea)
        '// Call the PopulateRoomsForArea sub.
        SuspendDrawing(lbRooms)
        PopulateRoomsForArea(theArea.ChatRoomArea, GetRoomTypeSort())
        If lbRooms.Items.Count = theArea.RoomsInArea.Count Then
            If lbAreaSelect.SelectedItem = ThisSession.CurrentArea And ThisSession.CurrentChatRoom <> Nothing Then
                Dim index As Integer = lbRooms.FindString(ThisSession.CurrentChatRoom)
                If index <> -1 Then lbRooms.SetSelected(index, True)
            Else
                lbRooms.SelectedIndex = 0
            End If
        End If
        ResumeDrawing(lbRooms, True)
    End Sub


    ' Populate Room Listbox.
    Public Sub PopulateRoomsForArea(Area As String, RoomType As ChatRoom.RoomType)
        ' Dims
        Dim RoomDisplayString As String
        Dim theArea As ChatArea
        ' Get the area pointer
        theArea = GetAreaByName(Area)
        '// Clear existing.
        lbRooms.Items.Clear()
        ' Did we actually get an area?
        If (Not IsNothing(theArea)) Then
            ' Iterate over the rooms in the area.
            For Each room As ChatRoom In theArea.RoomsInArea
                ' Are we looking at the appropriate room type?
                If room.ChatRoomType = RoomType Then
                    ' Add it to the list
                    RoomDisplayString = room.ChatRoomName & ControlChars.Tab & room.CurrentChatters & "/" & room.MaxChatters & ControlChars.Tab
                    ' Any passwords?
                    If room.HasPasswordEntry Then
                        RoomDisplayString = RoomDisplayString & "ENTRY"
                        ' Text?
                        If room.HasPasswordText Then
                            RoomDisplayString = RoomDisplayString & "/TEXT"
                        End If
                    Else
                        ' Text?
                        If room.HasPasswordText Then
                            RoomDisplayString = RoomDisplayString & "TEXT"
                        End If
                    End If
                    AddToRoomList(RoomDisplayString)
                End If

            Next room

            lbRooms.Sorted = True

        End If


    End Sub

    Private Sub lbRooms_DoubleClick(sender As Object, e As EventArgs) Handles lbRooms.DoubleClick
        '// Double-Click event on the listbox.
        '// If a chat room is double-clicked, attempt to enter
        '// that chat room.
        'Dim roomName As String
        'roomName = ExtractRoomNameFromAreaView(lbRooms.SelectedItem)
        ' Did we actually click on a room?
        'If (Not IsNothing(roomName)) Then
        ' We actually did select a room.  Do something with it.
        ' MessageBox.Show("Normally, this functionality would attempt to enter the " & roomName & " chat room.")
        'End If
        GoToChatRoom()
    End Sub

    Public Function GetRoomTypeSort() As ChatRoom.RoomType
        If RoomTypeSort = "MEMBER" Then
            Return ChatRoom.RoomType.MemberRoom
        ElseIf RoomTypeSort = "AUDITORIUM" Then
            Return ChatRoom.RoomType.AuditoriumRoom
        Else
            Return ChatRoom.RoomType.ProdStarRoom
        End If
    End Function

    Public Sub UpdateRoomSelections()
        If (Not IsNothing(lbAreaSelect.SelectedItem)) Then
            lbRooms.Items.Clear()
            PopulateRoomsForArea(lbAreaSelect.SelectedItem.ToString, GetRoomTypeSort())
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles rbProdStar.CheckedChanged
        RoomTypeSort = "ProdStar"
        ' Is an area selected?
        UpdateRoomSelections()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles rbMember.CheckedChanged
        RoomTypeSort = "MEMBER"
        UpdateRoomSelections()
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles rbAuditorium.CheckedChanged
        RoomTypeSort = "AUDITORIUM"
        UpdateRoomSelections()
    End Sub

    Private Sub lbAreaSelect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbAreaSelect.SelectedIndexChanged
        '// This should NEVER be a problem because this is a form event, but just in case something weird happens
        If Not (IsNothing(lbAreaSelect.SelectedItem)) Then
            '// New addition: Request the latest list of chat rooms for the selected area.
            TheMainWindow.DoSendToServer("CHAT" + DELIMITER + "AREALIST" + DELIMITER + "0" + DELIMITER + "0" + DELIMITER + lbAreaSelect.SelectedItem.ToString)
            '// Clear the current rooms in the list
            lbRooms.Items.Clear()
            '// Repopulate with the data from the area.
            PopulateRoomsForArea(lbAreaSelect.SelectedItem.ToString, GetRoomTypeSort())
        End If
    End Sub

    Private Sub bnCancel_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub

    Private Sub AreaRoomSelect_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
            'ElseIf e.KeyCode = Keys.Enter Then
            '   bnGoRoom.PerformClick()
        End If

    End Sub

    Private Sub bnGoRoom_Click(sender As Object, e As EventArgs) Handles bnGoRoom.Click
        'Dim frmChat As New frmChatWindow(TheMainWindow, ThisSession)
        'WindowPointers.ChatRoom = frmChat
        'Me.Invoke(Sub() WindowPointers.ChatRoom.Show(Me))
        '// Double-Click event on the listbox.
        '// If a chat room is double-clicked, attempt to enter
        '// that chat room.
        GoToChatRoom()
    End Sub

    Private Sub gbRoomType_Enter(sender As Object, e As EventArgs) Handles gbRoomType.Enter

    End Sub

    Private Sub bnRoomInfo_Click(sender As Object, e As EventArgs) Handles bnRoomInfo.Click
        Dim theroom As ChatRoom
        theroom = Nothing
        '// We begin by finding the ChatRoom object for the selected chat room.
        'Has the user selected anything?
        'If (Not lbRooms.SelectedItem = Nothing And Not lbAreaSelect.SelectedItem = Nothing) Then
        If (Not IsNothing(lbRooms.SelectedItem) And Not IsNothing(lbAreaSelect.SelectedItem)) Then
            ' First item holds the room name.  Get the chat area referenced by 
            ' the user's mouse click.
            Dim theArea As ChatArea
            theArea = GetAreaByName(lbAreaSelect.SelectedItem)
            ' Next, find a pointer to the actual chat room object
            Dim roomName As String
            roomName = ExtractRoomNameFromAreaView(lbRooms.SelectedItem)
            ' // *** CONSIDER MOVING THIS TO IT'S OWN SUB TO SAVE CYCLES IN THE LOOP ***
            ' // ** MOVED TO IT'S OWN FUNCTION.
            '            For Each room As ChatRoom In theArea.RoomsInArea
            ' Is this the room we're looking for?
            ' If roomName.ToUpper = room.ChatRoomName.ToUpper Then
            ' theroom = room
            'End If
            '   Next
            theroom = GetChatRoomByName(theArea, roomName)
            ' Did we actually 
            'Load the room information screen.
            If (Not IsNothing(theroom)) Then
                Dim roomInfo As New RoomInfo(TheMainWindow, ThisSession, theroom)
                WindowPointers.RoomInformation = roomInfo
                roomInfo.Show()
            End If
        Else
            MessageBox.Show("You must select an area and a room before using this feature.")
        End If
    End Sub

    Public Function GetChatRoomByName(theArea As ChatArea, roomname As String)
        ' Buffer to hold the chat room pointer.
        Dim theRoom As ChatRoom
        ' Initialize it to nothing
        theRoom = Nothing
        ' Get the chat room.
        For Each room As ChatRoom In theArea.RoomsInArea
            ' Is this the room we're looking for?
            If roomname.ToUpper = room.ChatRoomName.ToUpper Then
                theRoom = room
            End If
        Next
        ' Return the value
        Return theRoom
    End Function

    Public Function ExtractRoomNameFromAreaView(areaView As String)
        ' Local variable declarations
        Dim buffer As Array
        Dim roomName As String
        ' Split the areaView on the delimiter.  In this case, vbTab
        buffer = areaView.Split(vbTab)
        ' Extract the first parameter which, in this case, is the room name.
        roomName = buffer(0)
        ' Return the room name
        Return roomName
    End Function
    Private Sub tbRoomName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbRoomName.KeyPress ' Did the user press enter?
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then ' Attempt to join the chat room entered in Textbox1.
            ' // Was anything typed into the box?
            If (tbRoomName.Text.Length > 0) Then
                ' // Something was entered into the text box.  Is it a real room?
                For Each room As String In lbRooms.Items
                    ' // Is this our room?
                    If (room.IndexOf(tbRoomName.Text, 0, StringComparison.CurrentCultureIgnoreCase)) > -1 Then
                        lbRooms.SelectedItem = room
                        GoToChatRoom()
                        Exit For
                    End If
                Next
            End If
        End If
    End Sub

    Public Sub GoToChatRoom()
        '// Double-Click event on the listbox.
        '// If a chat room is double-clicked, attempt to enter
        '// that chat room.
        Dim roomName As String
        Dim strTextPass As String
        Dim strEntryPass As String
        Dim strPass As String = "0"
        ' Has the user actually selected a room?
        If (Not IsNothing(lbRooms.SelectedItem)) Then
            roomName = ExtractRoomNameFromAreaView(lbRooms.SelectedItem)
            ' Did we find a room name?
            If (Not IsNothing(roomName)) Then
                ' Did we actually click on a room?
                If (Not IsNothing(roomName)) Then
                    ' We actually did select a room.  Do something with it.
                    ' Need room password dialog for entry/text passwords
                    If ThisSession.CurrentChatRoom <> roomName Then
                        'If Not IsNothing(ThisSession.CurrentChatRoom) Then TheMainWindow.DoSendToServer("CHAT" + DELIMITER + "PART" + DELIMITER + ThisSession.CurrentArea + DELIMITER + "0" + DELIMITER + ThisSession.CurrentChatRoom)
                        ' ThisSession.CurrentChatRoom = roomName
                        ' ThisSession.CurrentArea = lbAreaSelect.SelectedItem.ToString
                        Dim EntryArea As ChatArea = GetAreaByName(lbAreaSelect.SelectedItem.ToString)   'ThisSession.CurrentArea)
                        Dim EntryRoom As ChatRoom = GetChatRoomByName(EntryArea, roomName) 'ThisSession.CurrentChatRoom)

                        ' //
                        ' // NEED TO HAVE THIS ROOMSPEC THE ROOM WITH THE SERVER TO KNOW
                        ' // MOST UP-TO-DATE PASSWORD STATUS.  VITAL FOR PRIVATE ROOMS
                        ' // SINCE NORMAL USERS CANNOT EVEN GET THE PRIVATE ROOM LIST.
                        ' //

                        If EntryRoom.HasPasswordEntry Then
                            Dim frmInput As New UserInput(TheMainWindow, ThisSession, "A password is required for this room", "Entry Password:", "Room Entry Password")
                            WindowPointers.UserInput = frmInput
                            Dim dResult As DialogResult = WindowPointers.UserInput.ShowDialog(Me)
                            Select Case dResult
                                Case vbOK
                                    strEntryPass = WindowPointers.UserInput.tbEntry.Text
                                    WindowPointers.UserInput.Close()
                                Case vbCancel
                                    WindowPointers.UserInput.Close()
                            End Select
                        End If
                        If EntryRoom.HasPasswordText Then
                            Dim frmInput As New UserInput(TheMainWindow, ThisSession, "A password is required for write access", "Text Password:", "Room Text Password")
                            WindowPointers.UserInput = frmInput
                            Dim dResult As DialogResult = WindowPointers.UserInput.ShowDialog(Me)
                            Select Case dResult
                                Case vbOK
                                    strTextPass = WindowPointers.UserInput.tbEntry.Text
                                    WindowPointers.UserInput.Close()
                                Case vbCancel
                                    WindowPointers.UserInput.Close()
                            End Select
                        End If
                        If EntryRoom.HasPasswordEntry And EntryRoom.HasPasswordText Then
                            strPass = strEntryPass + "," + strTextPass
                        ElseIf EntryRoom.HasPasswordEntry Then
                            strPass = strEntryPass + ",0"
                        ElseIf EntryRoom.HasPasswordText Then
                            strPass = "0," + strTextPass
                        End If
                        If doShift = True Then
                            TheMainWindow.DoSendToServer("ADMIN" + DELIMITER + "ADMINJOIN" + DELIMITER + lbAreaSelect.SelectedItem.ToString + DELIMITER + "0" + DELIMITER + "0" + DELIMITER + roomName)
                            doShift = False
                        Else
                            TheMainWindow.DoSendToServer("CHAT" + DELIMITER + "JOIN" + DELIMITER + lbAreaSelect.SelectedItem.ToString + DELIMITER + roomName + DELIMITER + strPass)
                        End If
                    End If
                End If
            End If
        End If

    End Sub


    Private Sub lbRooms_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbRooms.SelectedIndexChanged

    End Sub

    Private Sub bnSetupOptions_Click_1(sender As Object, e As EventArgs) Handles bnSetupOptions.Click
        Dim frmSetupOptions As New SetupOptions(TheMainWindow, ThisSession)
        WindowPointers.SetupOptions = frmSetupOptions
        WindowPointers.SetupOptions.Show(Me)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub bnCreateRoom_Click(sender As Object, e As EventArgs) Handles bnCreateRoom.Click
        Dim frmCreateRoom As New CreateRoom(TheMainWindow, ThisSession)
        WindowPointers.CreateRoom = frmCreateRoom
        WindowPointers.CreateRoom.Show(Me)
    End Sub

    Private Sub bnPrivateRoom_Click_1(sender As Object, e As EventArgs) Handles bnPrivateRoom.Click
        Dim frmInput As New UserInput(TheMainWindow, ThisSession, "Enter the name of the private chat you wish to join.", "Room Name:", "Enter Private Room")
        WindowPointers.UserInput = frmInput
        Dim dResult As DialogResult = WindowPointers.UserInput.ShowDialog(Me)
        Select Case dResult
            Case vbOK
                TheMainWindow.DoSendToServer("CHAT" + DELIMITER + "JOIN" + DELIMITER + "PRIVATE" + DELIMITER + frmInput.tbEntry.Text + DELIMITER + "0,0")
                WindowPointers.UserInput.Close()
            Case vbCancel
                WindowPointers.UserInput.Close()
        End Select
    End Sub
    Public Sub CloseForm()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf CloseForm))
            Exit Sub
        End If
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Not (Application.OpenForms().OfType(Of IMCenter).Any) Then
            Dim IMWindow As New IMCenter(WindowPointers.MainWindow, ThisSession)
            WindowPointers.InstantMessageCenter = IMWindow
            Me.Invoke(Sub() WindowPointers.InstantMessageCenter.Show(TheMainWindow))
        Else
            WindowPointers.InstantMessageCenter.Show()
            WindowPointers.InstantMessageCenter.BringToFront()
        End If

    End Sub



    Private Sub bnHelp_Click_1(sender As Object, e As EventArgs) Handles bnHelp.Click
        MsgBox("No Help Available.")
    End Sub

    Private Sub bnAlert_Click_1(sender As Object, e As EventArgs) Handles bnAlert.Click
        Dim frmAlert As New AlertCenter(TheMainWindow, ThisSession)
        WindowPointers.AlertCenter = frmAlert
        TheMainWindow.Invoke(Sub() WindowPointers.AlertCenter.Show(Me))
    End Sub

    Private Sub bnGoRoom_MouseDown(sender As Object, e As MouseEventArgs) Handles bnGoRoom.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            doShift = True
            GoToChatRoom()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles bnAdminJoin.Click
        doShift = True
        GoToChatRoom()
    End Sub

    Private Sub bnCloseRoom_Click(sender As Object, e As EventArgs) Handles bnCloseRoom.Click
        '// Do we have an area and a room selected?
        Dim chatArea As String
        Dim chatRoom As String
        If (lbAreaSelect.SelectedItem <> Nothing And lbRooms.SelectedItem <> Nothing) Then
            chatArea = lbAreaSelect.SelectedItem.ToString
            chatRoom = (lbRooms.SelectedItem.ToString.Split(vbTab))(0)
            '// Collect the reason.
            Dim closureReason As String
            '// Set a default reason
            closureReason = ""
            Dim frmInput As New UserInput(TheMainWindow, ThisSession, "Please provide a reason to close this room.", "Closure Reason:", "Administrative Closure Reason")
            WindowPointers.UserInput = frmInput
            Dim dResult As DialogResult = WindowPointers.UserInput.ShowDialog(Me)
            Select Case dResult
                Case vbOK
                    closureReason = WindowPointers.UserInput.tbEntry.Text
                    WindowPointers.UserInput.Close()
                Case vbCancel
                    WindowPointers.UserInput.Close()
            End Select
            '// Did we capture a reason?
            If Not String.IsNullOrEmpty(closureReason) Then
                '// Send the closure command to the server
                TheMainWindow.DoSendToServer("ADMIN" + DELIMITER + "CLOSECHAT" + DELIMITER + chatArea + DELIMITER + chatRoom + DELIMITER + "0" + DELIMITER + closureReason)
            Else
                ShowChatMessage(TheMainWindow, ThisSession, "Error", "You must enter a reason before performing this action.")
            End If
        Else
            ShowChatMessage(TheMainWindow, ThisSession, "Error", "You must select an area and a room before using this feature.")
        End If
    End Sub
    Public Sub ShowChatMessage(TheMainWindow As MainWindow, ThisSession As UserSession, strTitle As String, strMsg As String)
        Dim hwndMsg As New MessageDialog(TheMainWindow, ThisSession, strMsg, strTitle)
        WindowPointers.MessageDialog = hwndMsg
        TheMainWindow.Invoke(Sub() WindowPointers.MessageDialog.ShowDialog(TheMainWindow))
    End Sub

    Private Sub tbRoomName_TextChanged(sender As Object, e As EventArgs) Handles tbRoomName.TextChanged

    End Sub
End Class