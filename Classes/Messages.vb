Imports System.Threading
Imports System.ComponentModel
Imports System.IO
Module Messages
    Dim TMPCityState As String
    Dim TMPInterests As String
    Dim sThread As Thread
    '' // MAIN MESSAGE PARSING PROCEDURES

    Public Sub ParseUSER(TheMainWindow As MainWindow, ThisSession As UserSession, strMessageText As String)
        '// USER MESSAGES
        Dim strParsed() As String = Split(strMessageText, DELIMITER)

        Select Case strParsed(1)
            Case "LOGIN"                             '// Auth
                Select Case strParsed(2)
                    Case "SUCCESS"
                        '// Store the access level in the session
                        ThisSession.AccessLevel = strParsed(3)
                        TheMainWindow.Invoke(Sub() WindowPointers.Connection.SetText("Retreiving user settings..."))
                        If CancelCon = True Then TheMainWindow.Invoke(Sub() WindowPointers.MainWindow.ClientDisconnected())
                        TheMainWindow.DoSendToServer("USER" + DELIMITER + "GETSETTINGS" + DELIMITER + "0" + DELIMITER + "0" + DELIMITER + "0")
                        TheMainWindow.Invoke(Sub() WindowPointers.Connection.SetText("Login Successful!"))
                        Dim CLoader As New ChatLaunch(TheMainWindow, ThisSession)
                        WindowPointers.ChatLaunch = CLoader
                        WindowPointers.ChatLaunch.Show(TheMainWindow)
                        If My.Settings.EnableNotify = True Then PlaySound("WELCOMEF.WAV")
                        LogConnection("USER " + ThisSession.UserID + " successfully logged in.")
                        TheMainWindow.CheckAlive.RunWorkerAsync()
                        TheMainWindow.CheckAdministrativeMenu()
                    Case "FAIL"
                        CancelCon = True
                        LogConnection("AUTHENTICATION FAILED for user " + ThisSession.UserID + ".")
                        Dim strMsg As String = "The ID or Password you have entered is incorrect. Please check your CAPS-LOCK and spelling, and try again."
                        ShowChatMessage(TheMainWindow, Nothing, "ProdStar® Service - Login Failure", strMsg)
                        TheMainWindow.Invoke(Sub() WindowPointers.MainWindow.ClientDisconnected())
                End Select

            Case "NICK"                              '// Nick Changes
                Dim strMsg As String
                Dim msgTitle As String
                Select Case strParsed(2)
                    Case "SUCCESS"
                        ThisSession.CurrentNickName = strParsed(4)
                        strMsg = "Your new Nickname is " + strParsed(4)
                        msgTitle = "ProdStar® Service - Change Nickname"
                    Case "FAIL"

                        Select Case strParsed(4)
                            Case "TOOSOON"
                                strMsg = "You have already changed your Nickname today. You can only change your Nickname once per day."
                                msgTitle = "ProdStar® Service - ERROR"
                            Case "ALREADYEXISTS"
                                strMsg = "The Nickname you have chosen is already in use. Please choose another."
                                msgTitle = "ProdStar® Service - ERROR"
                            Case "REQUIREMENTS"
                                strMsg = "The Nickname you have chosen is invalid. Please choose a Nickname between 3-12 alpha-numeric characters long. Special characters and symbols are not allowed."
                                msgTitle = "ProdStar® Service - ERROR"
                            Case "FAIL"
                                strMsg = "An unexpected error has occured. Please try again later. If this issue persists, please submit a bug report via the Help menu."
                                msgTitle = "ProdStar® Service - ERROR"
                            Case "INCHAT"
                                strMsg = "You cannot change your nickname while inside a chat room.  Please exit the chat room before attempting to use this feature."
                                msgTitle = "ProdStar® Service - ERROR"
                        End Select
                End Select
                If VERBOSE = True Then LogError("USER::NICK FAILURE! (" + strParsed(4) + ")")
                ShowChatMessage(TheMainWindow, ThisSession, msgTitle, strMsg)

            Case "GETINFO"                            '// Get Member Info
                Dim strNick As String
                Dim strID As String
                Dim strCity As String
                Dim strInterests As String

                Select Case strParsed(2)
                    Case "FAIL"
                        strInterests = "N/A"
                        strNick = "N/A"
                        strID = "N/A"
                        strCity = "N/A"
                    Case Else
                        Dim strNNID() As String = Split(strParsed(2), ",")
                        If strNNID.Count = 1 Then 'No ID
                            strNick = strNNID(0)
                            strID = "N/A"
                        Else
                            strID = strNNID(0)
                            strNick = strNNID(1)
                        End If

                        Select Case strParsed(3)
                            Case "CITYSTATE"
                                strCity = strParsed(4)
                                If strNick = ThisSession.CurrentNickName Then ThisSession.CityStateInfo = strCity
                                TMPCityState = strCity
                            Case "INTERESTS"
                                strInterests = strParsed(4)
                                If strNick = ThisSession.CurrentNickName Then ThisSession.InterestsInfo = strInterests
                                TMPInterests = strInterests
                                If (Application.OpenForms().OfType(Of MemberInformation).Any) Then
                                    WindowPointers.MemberInformation.PopulateMemberInformationFields(strNick, strID, TMPCityState, TMPInterests)
                                Else
                                    TheMainWindow.Invoke(Sub() WindowPointers.Connection.Close())
                                End If

                        End Select
                End Select

            Case "SETINFO"                           '// Set Member Info
                Dim strMsg As String
                Select Case strParsed(2)
                    Case "SUCCESS"
                        TheMainWindow.Invoke(Sub() WindowPointers.SetupOptions.Close())
                        TheMainWindow.DoSendToServer("USER" + DELIMITER + "GETSETTINGS" + DELIMITER + "0" + DELIMITER + "0" + DELIMITER + "0")
                        strMsg = "Your Member Information has been updated."
                        ShowChatMessage(TheMainWindow, ThisSession, "ProdStar® Service - Member Information", strMsg)

                    Case "FAIL"
                        strMsg = "There was an error saving your Member Information to the server. Please see " + PRODDIR + "\error.log for details."
                        ShowChatMessage(TheMainWindow, ThisSession, "ProdStar® Service - ERROR", strMsg)
                        If VERBOSE = True Then LogError("USER::SETINFO ERROR! (" + strParsed(4) + ")")
                End Select

            Case "EXCLUDE"                            '// Exc;ide
                Dim strMsg As String
                Select Case strParsed(2)
                    Case "ADD"
                        strMsg = "User " + strParsed(4) + " has been excluded."
                    Case "REMOVE"
                        strMsg = "User " + strParsed(4) + " has been unexcluded."
                    Case "FAIL"
                        strMsg = "There was an error while attempting to exclude this user."
                        If VERBOSE = True Then LogError("USER::EXCLUDE ERROR! (" + strParsed(4) + ")")
                 
                End Select
                ShowChatMessage(TheMainWindow, ThisSession, "ProdStar® Service - Instant Message", strMsg)

            Case "IAM"                                 '// Don't think We actually need this
                ThisSession.CurrentNickName = strParsed(4)
            Case "SETTINGS"
                Dim strPayload As String = Convert.ToString(Convert.ToInt32(strParsed(4)), 2).PadLeft(9, "0")
                ThisSession.CurrentNickName = strParsed(3)
                Dim arSettings() As Char = strPayload.ToCharArray
                With ThisSession

                    .UseAdvanced = Convert.ToBoolean(Val(arSettings(0)))
                    .AllowInstantMessages = Convert.ToBoolean(Val(arSettings(1)))
                    .NotifyRoomEntry = Convert.ToBoolean(Val(arSettings(2)))
                    .NotifyRoomDeparture = Convert.ToBoolean(Val(arSettings(3)))
                    .DisplayMyID = Convert.ToBoolean(Val(arSettings(4)))
                    .AllowSounds = Convert.ToBoolean(Val(arSettings(5)))
                    .DoublespaceChatText = Convert.ToBoolean(Val(arSettings(6)))
                    .ClearChatOnRoomChange = Convert.ToBoolean(Val(arSettings(7)))
                    .UseBold = Convert.ToBoolean(Val(arSettings(8)))
                End With

                If Application.OpenForms().OfType(Of frmChatWindow).Any Then
                    ' Gone
                ElseIf ThisSession.UseBold = True And Application.OpenForms().OfType(Of IMCenter).Any Then
                    WindowPointers.InstantMessageCenter.UpdateFont(ThisSession.UseBold)
                End If
                TheMainWindow.DoSendToServer("USER" + DELIMITER + "GETINFO" + DELIMITER + "0" + DELIMITER + "0" + DELIMITER + ThisSession.CurrentNickName)

            Case "ALERT"
                Select Case strParsed(4)
                    Case "RECEIVED"
                        ' Did we receive confirmation for an Alert or for a Bug Report?
                        Dim theCode As Integer
                        theCode = Convert.ToInt32(strParsed(2))
                        ' // If we're dealing with an actual alert, continue. Otherwise
                        ' // simply drop off here as the Bug Report form does it's own popup.
                        If (theCode < 1000) Then
                            ShowChatMessage(TheMainWindow, ThisSession, "ProdStar Service - Alert Sent", "Your alert has been successfully received." + vbNewLine + vbNewLine + "Please keep in mind that Moderator staff is limited. If a Moderator is unavailable, your request will be placed in a queue. Please allow up to 24 hours for a response.")
                            WindowPointers.AlertCenter.Close()
                        End If
                End Select

            Case "CHANGEPW"
                Select Case strParsed(4)
                    Case "SUCCESS"
                        ShowChatMessage(TheMainWindow, ThisSession, "Password Changed", "Your password has been successfully changed.")
                        TheMainWindow.Invoke(Sub() WindowPointers.ChangePassword.Close())
                    Case "FAIL"
                        ShowChatMessage(TheMainWindow, ThisSession, "Password Not Changed", "We were unable to change your password at this time. Please see " + PRODDIR + "\error.log for details.")
                        LogError("USER::CHANGEPW Error! (" + strParsed(4) + ")")
                End Select

            Case "CLIENTMSG"
                Dim theTitle As String = strParsed(3)
                Dim theMessage As String = strParsed(4)
                ShowChatMessage(TheMainWindow, ThisSession, theTitle, theMessage)

            Case "FAIL"                                '// Generic USER Failure
                Dim strMsg As String = "An unexecpted error has occured. Please see " + PRODDIR + "\error.log for details."
                ShowChatMessage(TheMainWindow, ThisSession, "ProdStar® Service - ERROR", strMsg)
                LogError("Unexpected USER Error! (" + strParsed(4) + ")")
        End Select
    End Sub
    Public Sub ParseIMSG(TheMainWindow As MainWindow, ThisSession As UserSession, strMessageText As String)
        '// INSTANT MESSAGING

        Dim strParsed() As String = Split(strMessageText, DELIMITER)
        Select Case strParsed(1)

            Case "SUCCESS"
                Dim FirstMessage As QueuedMsg
                Dim SecondaryMessages As ArrayList
                If (ThisSession.OutgoingMessages.ContainsKey(strParsed(2))) Then
                    ' // Pull by chat name.
                    FirstMessage = ThisSession.OutgoingMessages.Item(strParsed(2).ToUpper)
                    SecondaryMessages = ThisSession.GetSecondaryMessages(strParsed(2).ToUpper)
                Else
                    '// Try by site id
                    FirstMessage = ThisSession.OutgoingMessages.Item(strParsed(3).ToUpper)
                    SecondaryMessages = ThisSession.GetSecondaryMessages(strParsed(3).ToUpper)
                End If

                If Not IsNothing(FirstMessage) Then
                    ' // Send the IM.
                    TheMainWindow.DoSendToServer("IMSG" + DELIMITER + "TO" + DELIMITER + FirstMessage.Nick + DELIMITER + FirstMessage.ID + DELIMITER + FirstMessage.Msg)

                    ThisSession.OutgoingMessages.Remove(FirstMessage.ID)
                    '// Update.
                    WindowPointers.InstantMessageCenter.IMResultSuccess(FirstMessage)
                    ' // Did we have any secondary messages to send?
                    If Not (IsNothing(SecondaryMessages)) Then
                        ' // Loop over them and send them.
                        For Each sndMsg As QueuedMsg In SecondaryMessages
                            ' // Send it.
                            TheMainWindow.DoSendToServer("IMSG" + DELIMITER + "TO" + DELIMITER + sndMsg.Nick + DELIMITER + sndMsg.ID + DELIMITER + sndMsg.Msg)
                            ' // Update.
                            WindowPointers.InstantMessageCenter.IMResultSuccess(sndMsg)
                        Next
                    End If
                End If

            Case "UNAVAILABLE"
                ' // The user we were trying to send to is unavailable.
                Dim strNick As String = strParsed(2)
                Dim strMsg As String = "User " + strNick + " is unavailable for Instant Message."
                ShowChatMessage(TheMainWindow, ThisSession, "ProdStar® Service - Instant Message", strMsg)
                ' ThisSession.OutgoingQueue.Clear()

            Case "FROM"
                Dim CurrentMsg As New QueuedMsg
                Dim hwndParent As Form = TheMainWindow
                Dim intLen As Integer = strParsed(0).Length + strParsed(1).Length + strParsed(2).Length + strParsed(3).Length + 8 '4 delimiters 2 chars each
                ' // Use the CurrentMsg struct to easily manage the message.
                With CurrentMsg
                    .Nick = strParsed(2)
                    .ID = strParsed(3)
                    .Msg = Strings.Right(strMessageText, strMessageText.Length - intLen)
                End With
                If CurrentMsg.Nick = "0" Then CurrentMsg.Nick = CurrentMsg.ID
 
                ThisSession.AddMessageToIMConversation(CurrentMsg.Nick, CurrentMsg)
                ' // Is the Incoming Instant Message screen open?
                If (Application.OpenForms().OfType(Of IncomingInstantMessage).Any) Then

                    WindowPointers.IncomingInstantMessage.UpdateIncomingMessages(CurrentMsg.Nick)
                    WindowPointers.IncomingInstantMessage.Show()
                    WindowPointers.IncomingInstantMessage.BringToFront()

                ElseIf (Application.OpenForms().OfType(Of IMCenter).Any) Then
                    ' // The Instant Message Center window was actually open.  Update the conversation.
                    WindowPointers.InstantMessageCenter.SetIMText(CurrentMsg)
                Else
                    ' // Grab a pointer to the new Instant Message window to service this request.
                    Dim IncomingIM As New IncomingInstantMessage(WindowPointers.MainWindow, ThisSession)
                    WindowPointers.IncomingInstantMessage = IncomingIM
                    ' // Spawn the window.
                    TheMainWindow.Invoke(Sub() WindowPointers.IncomingInstantMessage.Show())
                    WindowPointers.IncomingInstantMessage.BringToFront()
                    ' // Update the view.
                    WindowPointers.IncomingInstantMessage.UpdateIncomingMessages(CurrentMsg.Nick)
                End If

            Case "FAIL"
                Dim strMsg As String = "An unexecpted error has occured."
                ShowChatMessage(TheMainWindow, ThisSession, "ProdStar® Service - ERROR", strMsg)
        End Select
    End Sub

    Public Sub ParseCHAT(TheMainWindow As MainWindow, ThisSession As UserSession, strMessageText As String)
        '// CHAT MESSAGES
        Dim strParsed() As String = Split(strMessageText, DELIMITER)
        Select Case strParsed(1)
            Case "JOIN"

                Select Case strParsed(2)
                    Case "SUCCESS"
                        ' // Do we need to part from an existing room?
                        If Not IsNothing(ThisSession.CurrentChatRoom) Then TheMainWindow.DoSendToServer("CHAT" + DELIMITER + "PART" + DELIMITER + ThisSession.CurrentArea + DELIMITER + "0" + DELIMITER + ThisSession.CurrentChatRoom)
                        ' // Join the new room.
                        If Not (Application.OpenForms().OfType(Of frmChatWindow).Any) Then
                            If My.Settings.ModernStyle = False Then
                                If Not IsNothing(WindowPointers.ChatLaunch) Then SuspendDrawing(WindowPointers.ChatLaunch)
                            End If
                            Dim OpenChat As New frmChatWindow(TheMainWindow, ThisSession)
                            WindowPointers.ChatRoom = OpenChat
                            TheMainWindow.Invoke(Sub() WindowPointers.ChatRoom.Show(WindowPointers.ChatLaunch))
                        Else
                            WindowPointers.ChatRoom.UpdateList(Nothing, "CLR")
                            If ThisSession.ClearChatOnRoomChange = True Then WindowPointers.ChatRoom.OverwriteChat("")
                        End If
                        WindowPointers.ChatRoom.UpdateTitle(strParsed(3) + " / " + strParsed(4))
                        ThisSession.CurrentArea = strParsed(3)
                        ThisSession.CurrentChatRoom = strParsed(4)
                        TheMainWindow.DoSendToServer("CHAT" + DELIMITER + "NAMES" + DELIMITER + "0" + DELIMITER + "0" + DELIMITER + "0")
                        If My.Settings.ModernStyle = False Then TheMainWindow.Invoke(Sub() WindowPointers.AreaSelect.Close())
                        TheMainWindow.Invoke(Sub() WindowPointers.ChatRoom.tbToSend.Focus())

                    Case "FAIL"
                        Dim strMsg As String = strParsed(4)
                        ' // Handle the specific error conditions that can occur within a failure.
                        Dim failureMessage As String
                        Select Case strMsg
                            Case "ENTRY"
                                failureMessage = "You have entered an incorrect ENTRY password."
                            Case "FULL"
                                failureMessage = "The room is currently full."
                            Case Else
                                failureMessage = "Unable to join the room."
                        End Select
                        ShowChatMessage(TheMainWindow, ThisSession, "ProdStar® Service - ERROR", failureMessage)
                End Select

            Case "PART"                  ' // Not sure we're using PART responses
                Select Case strParsed(2)
                    Case "SUCCESS"
                    Case "FAIL"
                End Select

            Case "LISTOFAREAS"
                '// Update the session cache
                ThisSession.UpdateAreaListCache(strParsed(4))
                If Not Application.OpenForms().OfType(Of CreateRoom).Any Then
                    WindowPointers.AreaSelect.UpdateAreaListFromSession()
                Else
                    WindowPointers.CreateRoom.UpdateAreaListFromSession()
                End If

            Case "AREALIST"
                '// Update the chat rooms inside of an area
                Dim theChatArea As ChatArea = ThisSession.ChatAreaCache.Item(strParsed(3))
                '// Did we find a ptr to the chat area?
                If Not (IsNothing(theChatArea)) Then
                    '// Update the room cache for that area.
                    ThisSession.UpdateChatRoomsInArea(theChatArea.ChatRoomArea, strParsed(4))
                    '// Update the rooms in the Chat Room select listbox.
                    If Application.OpenForms().OfType(Of AreaRoomSelect).Any Then
                        WindowPointers.AreaSelect.RepopulateChatRooms(theChatArea)
                    End If
                Else
                    ShowChatMessage(TheMainWindow, ThisSession, "ProdStar® Service - ERROR", "You have selected an invalid chat area.")
                End If

            Case "CREATE"
                Select Case strParsed(2)
                    Case "SUCCESS"
                        ' Nothing to see here
                    Case "FAIL"
                        LogError("CHAT::CREATE Error! (" + strParsed(4) + ")")
                        ShowChatMessage(TheMainWindow, ThisSession, "ProdStar® Service - ERROR", "There was an error creating the room. Please see " + PRODDIR + "\error.log for details.")
                End Select

            Case "FROM"
                Dim intlen As Integer = strParsed(0).Length + strParsed(1).Length + strParsed(2).Length + strParsed(3).Length + 8
                Dim strChatTxt As String = Strings.Right(strMessageText, strMessageText.Length - intlen)
                Dim strNick As String = strParsed(2)
                If strNick = "SYSTEM Greeter" Then
                    If InStr(strChatTxt, "entered") Then
                        Dim strTemp() As String = Split(strChatTxt, Chr(34))
                        Dim strJoined As New List(Of String)
                        strJoined.Add(strTemp(1))
                        WindowPointers.ChatRoom.UpdateList(strJoined, "ADD")
                    ElseIf InStr(strChatTxt, "left") Then
                        Dim strTemp() As String = Split(strChatTxt, Chr(34))
                        Dim strParted As New List(Of String)
                        strParted.Add(strTemp(1))
                        WindowPointers.ChatRoom.UpdateList(strParted, "REM")
                    End If
                End If
                WindowPointers.ChatRoom.UpdateChat(strNick, strChatTxt.Trim)
            Case "ROOMINFOLIST"
                WindowPointers.RoomInformation.PopulateRoomUsers(strParsed(4))
            Case "NOWRITE"
            Case "NAMES"
                Dim strNames As New List(Of String)
                Dim strNameString() As String = Split(strParsed(4), ",")
                strNames.AddRange(Array.ConvertAll(Of String, String)(strNameString, Function(s As String) New String(s)))
                WindowPointers.ChatRoom.UpdateList(strNames, "ADD")
            Case "NOWRITE"

                Dim strMsg As String = "Cannot send to chat room."
                ShowChatMessage(TheMainWindow, ThisSession, "ProdStar® Service - CHAT", strMsg)

        End Select
    End Sub
    Public Sub ParseADMIN(TheMainWindow As MainWindow, ThisSession As UserSession, strMessageText As String)
        '// ADMIN MESSAGES
        Dim strParsed() As String = Split(strMessageText, DELIMITER)
        Select Case strParsed(1)
            Case "USERLIST"
                WindowPointers.RoomInformation.PopulateRoomUsers(strParsed(5))
            Case "ENABLEADMIN"
                '// Toggle admin flag
                ThisSession.AdministratorFlagOn = If(strParsed(5) = "ON", True, False)
                '// Refresh access level
                Dim AccessLevel As Integer
                ThisSession.AccessLevel = If(Not Integer.TryParse(strParsed(4), AccessLevel), 0, AccessLevel)
                '// Update main window.
                TheMainWindow.CheckAdministrativeMenu()
            Case "DISCONNECTUSER"
                If (strParsed(1).ToUpper = "FAIL") Then
                    ShowChatMessage(TheMainWindow, ThisSession, "Disconnect User", "Failed to disconnect user.")
                End If
        End Select

    End Sub

End Module
