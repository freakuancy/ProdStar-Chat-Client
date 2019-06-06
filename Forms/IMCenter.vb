Imports System.Threading
Imports System.IO
Imports System.Environment
Imports System.Text.RegularExpressions
Public Class IMCenter
    Dim TheMainWindow As MainWindow
    Dim CurrentSession As UserSession

    Public Delegate Sub UpdateCallback(Nick As String, ID As String, ByID As String, Msg As String)
    Public Delegate Sub SelectionCallback(Nick As String)
    Public Delegate Sub SetTextCallback(CurrentMsg As QueuedMsg)
    Public Delegate Sub SetStringCallback(text As String)
    Delegate Sub UpdateFontCallBack(UseBold As Boolean)


    ' Constructor
    Public Sub New(mainwindow As MainWindow, ThisSession As UserSession)
        CurrentSession = ThisSession
        TheMainWindow = mainwindow

        InitializeComponent()
        tbMessages.SelectionTabs = New Integer() {128, 208, 256}
        If My.Settings.ModernStyle = True Then
            Me.BackColor = DefaultBackColor
            For Each cControl In Me.Controls
                If TypeOf cControl Is TextBox Then
                    CType(cControl, TextBox).BorderStyle = BorderStyle.Fixed3D
                    CType(cControl, TextBox).BackColor = SystemColors.Window
                Else
                    CType(cControl, Control).BackColor = DefaultBackColor
                    CType(cControl, Control).ForeColor = DefaultForeColor
                    CType(cControl, Control).Font = DefaultFont
                End If
            Next
            For Each gControl In GroupBox1.Controls
                If TypeOf gControl Is TextBox Then
                    CType(gControl, TextBox).BorderStyle = BorderStyle.Fixed3D
                    CType(gControl, TextBox).BackColor = SystemColors.Window
                Else
                    CType(gControl, Control).BackColor = DefaultBackColor
                    CType(gControl, Control).ForeColor = DefaultForeColor
                    CType(gControl, Control).Font = DefaultFont
                End If
            Next
            lbMessages.BackColor = SystemColors.Window
            lbMessages.ForeColor = DefaultForeColor
            tbMessages.BackColor = SystemColors.Window
            tbMessages.ForeColor = DefaultForeColor
            tbMessages.BorderStyle = BorderStyle.Fixed3D
            Panel1.BorderStyle = BorderStyle.None
            Panel2.BorderStyle = BorderStyle.None
        End If
    End Sub

    Private Sub IMCenter_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        tbMessageToSend.Focus()
    End Sub

    Private Sub IMCenter_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate
        Me.Activate()
        Me.BringToFront()

    End Sub

    Private Sub IMCenter_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        Me.Activate()
        Me.BringToFront()

    End Sub


    Sub IMCenter_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        tbMessageToSend.Clear()
    End Sub


    Private Sub IMCenter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MoveForm(Me)
        ' // Set the default button for when enter is pressed.
        Me.AcceptButton = bnSend
        ' // Suspend updates to the form.
        SuspendDrawing(lbMessages)
        ' // Reload the conversations from the session.  The rationale for this is that
        ' // we want to completely be able to unload the form when it's closed.
        ' // May investigate alternative methods if this becomes a problem.
        ReloadExistingConversations()
        ' // End reload.
        ResumeDrawing(lbMessages, True)
        ' // If we actually have ongoing conversations, select the first one so that
        ' // it spawns in the form.
        'If CurrentSession.Conversations.Count > 0 Then lbMessages.SelectedIndex = 0
        If CurrentSession.InstantMessages.Count > 0 Then lbMessages.SelectedIndex = 0
    End Sub
    Public Sub UpdateFont(UseBold As Boolean)
        If Me.tbMessages.InvokeRequired Then
            Dim d As New UpdateFontCallBack(AddressOf UpdateFont)
            Me.Invoke(d, New Object() {UseBold})
        Else
            If UseBold = True Then
                tbMessages.Font = New Font(tbMessages.Font, FontStyle.Bold)
            Else
                tbMessages.Font = New Font(tbMessages.Font, FontStyle.Regular)
            End If
        End If
    End Sub
    Public Sub UpdateChat(Nick As String, Msg As String)
        ' // Construct the actual string to be added to the conversation.
        Dim strConstructed As String = Nick + ":" + vbTab + Msg
        '// Stop updating the view.
        SuspendDrawing(tbMessages) ' Force GDI NOPAINT 
        With tbMessages
            .AppendText(strConstructed)
            .SelectionStart = tbMessages.TextLength - Msg.Length
            .SelectionLength = Msg.Length
            .SelectionHangingIndent = 128
            .SelectionStart = .Text.Length
            .ScrollToCaret()
            .AppendText(vbNewLine) ' Not scrolling by itself, odd
        End With
        ' // Scroll to the bottom.
        tbMessages.Select(tbMessages.TextLength, 0)
        tbMessages.ScrollToCaret()
        '// Resume updates to the view
        ResumeDrawing(tbMessages, True) ' Resume PAINT after update
    End Sub
    Public Sub SetSendTo([Text])
        If Me.tbMessages.InvokeRequired Then
            Dim d As New SetStringCallback(AddressOf SetSendTo)
            Me.Invoke(d, New Object() {[Text]})
        Else
            tbTo.Text = [Text]
        End If

    End Sub
    Public Sub SetIMText(ByVal CurrentMsg As QueuedMsg)
        ' InvokeRequired required compares the thread ID of the 
        ' calling thread to the thread ID of the creating thread. 
        ' If these threads are different, it returns true. 
        If Me.tbMessages.InvokeRequired Then
            Dim d As New SetTextCallback(AddressOf SetIMText)
            Me.Invoke(d, New Object() {CurrentMsg})
        Else
            ' Does the message contain an instant message?
            ' // Check to see if the message is coming from an excluded user.
            If Not CurrentSession.Excluded.Contains(CurrentMsg.Nick) Then
                ' // It isn't.  Get a pointer to the confersation.
                Dim conversation As InstantMessageConversation = WindowPointers.MainWindow.GetConversationPointer(CurrentMsg.Nick)
                ' // Did the message come from the user that is currently in the "To" text box?
                If (lbMessages.SelectedItem.ToString.ToUpper = CurrentMsg.Nick.ToUpper) Then
                    ' // Yes.  Update the active chat scroll with the message.
                    UpdateChat(CurrentMsg.Nick, CurrentMsg.Msg)
                    conversation.MessageQueue.Clear()
                    conversation.ConversationText = tbMessages.Rtf
                Else
                    If lbMessages.FindStringExact(CurrentMsg.Nick) <> -1 Then
                        lbMessages.Items.Item(lbMessages.Items.IndexOf(CurrentMsg.Nick)) = CurrentMsg.Nick + " (NEW)"
                    ElseIf lbMessages.FindStringExact(CurrentMsg.Nick + " (NEW)") = -1 Then
                        lbMessages.Items.Add(CurrentMsg.Nick + " (NEW)")
                    End If
                End If
            End If
        End If

    End Sub
    Public Sub IMResultSuccess(msgOutGoing As QueuedMsg)
        ' Only fires on the first IM of a new convo the USER has started
        ' Seems like a round-about way to do this but we only want
        ' it to update  tbMessages if the IM goes through
        ' // Get a pointer to the conversation if it exists.
        Dim NewIM As InstantMessageConversation = WindowPointers.MainWindow.GetConversationPointer(msgOutGoing.Nick)
        ' // Does the conversation exist?
        If IsNothing(NewIM) Then
            ' // No.  Create a new conversation.
            Dim CurrentIM As New InstantMessageConversation(msgOutGoing.Nick, msgOutGoing.ID)
            ' //NewIM = CurrentIM
            ' // Add this new IM to the conversation dictionary.
            ' CurrentSession.Conversations.Add(NewIM)
            CurrentSession.InstantMessages.Add(msgOutGoing.Nick, CurrentIM)
            ' // Update
            IMResultUpdate(msgOutGoing.Nick, msgOutGoing.ID, msgOutGoing.Msg, msgOutGoing.ByID)
        End If
    End Sub
    Public Sub IMResultUpdate(strNick As String, strID As String, strMsg As String, ByID As Boolean)
        'Seperated from above in case of InvokeRequired
        Dim delProc As New UpdateCallback(AddressOf IMResultUpdate)
        If tbMessages.InvokeRequired Then
            Me.Invoke(delProc, New Object() {strNick, strMsg})
        Else
            ' // Get a pointer to the conversation we need to update.
            Dim NewIM As InstantMessageConversation = WindowPointers.MainWindow.GetConversationPointer(strNick)
            ' // Clear the existing content of the textbox.
            tbMessages.Clear()
            ' // Determine how we are updating this conversation.
            If ByID = True Then
                ' // Update the conversation by ID
                UpdateChat(CurrentSession.UserID, strMsg)
            Else
                ' // Update the conversation by NickName
                UpdateChat(CurrentSession.CurrentNickName, strMsg)
            End If
            NewIM.ConversationText = tbMessages.Rtf
            ' // If this conversation is taking place by ID, make the chat name the ID.
            If ByID = True Then
                ' // It is.  Set strNick to strID
                strNick = strID
            End If
            ' // Add the chat name / ID to the list of messages.
            lbMessages.Items.Add(strNick)
            ' // Select the newly updated IM.
            lbMessages.SelectedIndex = lbMessages.FindStringExact(strNick)
            ' // Clear the message text box.
            tbMessageToSend.Clear()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bnSend.Click
        ' // Verify that we have a chat name and a message before we attempt
        ' // to send a message.
        ' If tbTo.Text.Trim <> "" And tbMessageToSend.Text.Trim <> "" Then
        If (Trim(tbTo.Text).Length > 0 And Trim(tbMessageToSend.Text).Length > 0) Then
            ' // Use the QueuedMsg struct to create the message.
            Dim NewMsg As QueuedMsg
            '// Set the fields of the struct
            With NewMsg
                ' // Replace tabs.
                .Msg = tbMessageToSend.Text.Replace(vbTab, " ")
                ' // Check to see if we are IMing by ID
                Dim strMatch As Match = Regex.Match(tbTo.Text.Trim, "[A-Za-z]{4}\d{2}[A-Za-z]")
                If strMatch.Success Then
                    ' // We are IMing by ID.  Set the appropriate flag.
                    .ByID = True
                    .Nick = tbTo.Text.Trim
                    .ID = tbTo.Text.Trim
                Else
                    ' // We are IMing by chat name.  Set the appropriate flag.
                    .ByID = False
                    .Nick = tbTo.Text.Trim
                    .ID = "0"
                End If
            End With
            ' // Add the new message to any existing conversation.
            Dim theIM As InstantMessageConversation = WindowPointers.MainWindow.GetConversationPointer(NewMsg.Nick)
            ' // Did we find an existing conversation?
            If Not IsNothing(theIM) Then
                ' // No existing conversation exists.  Send the request to the server.
                '// Trim blank spaces.
                NewMsg.Msg = NewMsg.Msg.Replace(vbCr, "").Replace(vbLf, "")
                TheMainWindow.DoSendToServer("IMSG" + DELIMITER + "TO" + DELIMITER + NewMsg.Nick + DELIMITER + NewMsg.ID + DELIMITER + NewMsg.Msg)
                ' // Is this a conversation that is initiated by Site ID?
                If NewMsg.ByID = True Then
                    ' // Yes.  Update the view using my ID.
                    UpdateChat(CurrentSession.UserID, NewMsg.Msg)
                Else
                    ' // No.  Update the view using my nickname.
                    UpdateChat(CurrentSession.CurrentNickName, NewMsg.Msg)
                End If
                theIM.ConversationText = tbMessages.Rtf
                tbMessageToSend.Text = ""
            Else
                ' // The conversation does already exist.
                ' // Create an instance of the message struct 
                'Dim NewOutMsg As New QueuedMsg
                'NewOutMsg = NewMsg
                ' // Add it to the outgoing queue.
                'CurrentSession.OutgoingQueue.Add(NewOutMsg)
                'CurrentSession.OutgoingQueue.Add(NewMsg)
                CurrentSession.AddMessageForSending(NewMsg)
                ' // Check to see if the person we are messaging is available.
                TheMainWindow.DoSendToServer("IMSG" + DELIMITER + "CHECKAVAILABLE" + DELIMITER + "0" + DELIMITER + "0" + DELIMITER + NewMsg.Nick)
            End If
            End If
    End Sub

    Private Sub lbMessages_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbMessages.SelectedIndexChanged
        ' // This sub gets fired when the user selects a conversation from the list of active conversations.
        ' // Start first by verifying that the user actually clicked SOMETHING.
        If (lbMessages.SelectedItem IsNot Nothing) Then
            ' // Put the selected item in a buffer.
            Dim clickedItem As String = lbMessages.SelectedItem.ToString
            ' // Does the clicked have a (NEW) appended to it?  Remove it.
            'InStr(clickedItem, " (NEW)") <> 0) Then
            If (clickedItem.ToUpper.Contains(" (NEW")) Then
                ' // It does.  Remove it.
                Dim newname As String
                ' // Place our selected chat name into this buffer and remove the annotation.
                newname = clickedItem.Replace(" (NEW)", "")
                ' // Replace the item within the list collection with the newly created string in newname.
                lbMessages.Items.Item(lbMessages.Items.IndexOf(clickedItem)) = newname
                ' // Select the newly updated item.
                lbMessages.SetSelected(lbMessages.Items.IndexOf(newname), True)
                ' // Set clickedItem buffer to the newly modified name.
                clickedItem = newname
            End If
            ' // Set this as the person we're talking to
            tbTo.Text = clickedItem
            ' // Get any conversation with that person if any.
            Dim conversation As InstantMessageConversation = WindowPointers.MainWindow.GetConversationPointer(clickedItem)
            ' // Does any conversation exist?
            If (Not IsNothing(conversation)) Then
                ' // Yes.  Stop updating the form while we update.
                SuspendDrawing(tbMessages)
                ' // Put the text of the conversation into the text box.
                tbMessages.Clear()
                If conversation.ConversationText <> "" Then
                    tbMessages.Rtf = conversation.ConversationText
                    tbMessages.SelectionStart = tbMessages.TextLength
                    tbMessages.ScrollToCaret()
                End If
                ' // Update the actual chat content.
                For a = 0 To conversation.MessageQueue.Count - 1
                    UpdateChat(conversation.MessageQueue(a).Nick, conversation.MessageQueue(a).msg)
                Next
                conversation.MessageQueue.Clear()
            conversation.ConversationText = tbMessages.Rtf
            ' // Set the TO box with the user's name
            tbTo.Text = conversation.ConversationWith
            ' // Resume updating the view
            ResumeDrawing(tbMessages, True)
        End If
            End If
    End Sub

   

    Private Sub bnCancel_Click(sender As Object, e As EventArgs) Handles bnCancel.Click
        ' // Close the window.
        Me.Close()
    End Sub

    Private Sub bnSetup_Click(sender As Object, e As EventArgs) Handles bnSetup.Click
        ' // Spawn setup-options.
        Dim frmSetupOptions As New SetupOptions(TheMainWindow, CurrentSession)
        WindowPointers.SetupOptions = frmSetupOptions
        WindowPointers.SetupOptions.Show()
    End Sub

    Private Sub bnMI_Click(sender As Object, e As EventArgs) Handles bnMI.Click
        ' // Spawn Member Information.  First, ensure we actually clicked a chat name.
        If Not (IsNothing(lbMessages.SelectedItem)) Then
            Dim MemberInfo As New MemberInformation(TheMainWindow, CurrentSession, lbMessages.SelectedItem.ToString)
            WindowPointers.MemberInformation = MemberInfo
            Me.Invoke(Sub() WindowPointers.MemberInformation.Show(Me))
        Else
            ShowChatMessage(TheMainWindow, CurrentSession, "ProdStar® Service - ERROR", "You must first select a chat name before using this feature.")
        End If
    End Sub

    Private Sub bnExclude_Click(sender As Object, e As EventArgs) Handles bnExclude.Click
        ' // Spawn exclusion.
        If Not (IsNothing(lbMessages.SelectedItem)) Then
            Dim strExNick As String = lbMessages.SelectedItem.ToString.Replace(" (NEW)", "")
            Dim frmExclude As New Exclude(TheMainWindow, CurrentSession, strExNick)
            WindowPointers.Exclude = frmExclude
            WindowPointers.Exclude.ShowDialog(Me)
        Else
            ShowChatMessage(TheMainWindow, CurrentSession, "ProdStar® Service - ERROR", "You must first select a chat name before using this feature.")
        End If
    End Sub

    Private Sub bnSave_Click(sender As Object, e As EventArgs) Handles bnSave.Click
        ' Saving convo's as plain text. Some formatting will be lost but this keeps it
        ' easy for the user to work with, as opposed to requiring wordpad to read an rtf

        If Not (IsNothing(lbMessages.SelectedItem)) Then
            Dim sDialog As New SaveFileDialog
            With sDialog
                .DefaultExt = ".txt"
                .FileName = lbMessages.SelectedItem.ToString
                .Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
                .FilterIndex = 0
                .OverwritePrompt = True
                .InitialDirectory = GetFolderPath(SpecialFolder.MyDocuments)
            End With
            If sDialog.ShowDialog() = DialogResult.OK Then
                File.WriteAllText(sDialog.FileName, tbMessages.Text.Replace(Chr(10), Environment.NewLine))
            End If
        Else
            ShowChatMessage(TheMainWindow, CurrentSession, "ProdStar® Service - ERROR", "You must first select a chat name before using this feature.")
        End If
    End Sub

    Private Sub bnDelete_Click(sender As Object, e As EventArgs) Handles bnDelete.Click
        If Not (IsNothing(lbMessages.SelectedItem)) Then
            ' // We want to delete the conversation from memory.
            Dim toRemove As InstantMessageConversation = WindowPointers.MainWindow.GetConversationPointer(lbMessages.SelectedItem.ToString)
            ' // Remove it from our list of conversations.
            CurrentSession.InstantMessages.Remove(toRemove.ConversationWith)
            'CurrentSession.Conversations.Remove(toRemove)
            '// Remove the conversation from the list of ongoing conversations.
            lbMessages.Items.Remove(lbMessages.SelectedItem)
        Else
            ShowChatMessage(TheMainWindow, CurrentSession, "ProdStar® Service - ERROR", "You must first select a chat name before using this feature.")
        End If
    End Sub
    Private Sub bnHelp_Click(sender As Object, e As EventArgs) Handles bnHelp.Click
        'MsgBox("No Help Available.")
        ' // Moved to a Chat Message.
        ShowChatMessage(TheMainWindow, CurrentSession, "Instant Message - Help", "Help is unavailable for this feature.")
    End Sub
    Public Sub UpdateSelection(strNick As String)
        'Select user by NN, accessable
        Dim delProc As New SelectionCallback(AddressOf UpdateSelection)
        If tbMessages.InvokeRequired Then
            Me.Invoke(delProc, New Object() {strNick})
        Else
            lbMessages.SelectedIndex = lbMessages.FindStringExact(strNick)
        End If

    End Sub
    Private Sub tbMessages_KeyDown(sender As Object, e As KeyEventArgs) Handles tbMessages.KeyDown
        e.Handled = True 'Manually disable typing
    End Sub


    Private Sub IMCenter_Resize(sender As Object, e As EventArgs) Handles Me.Resize
    End Sub

    Private Sub IMCenter_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        tbMessages.ScrollToCaret()
    End Sub

    Public Sub ReloadExistingConversations()
        ' // Pull all of the conversations from the session.
        For Each conversation As InstantMessageConversation In CurrentSession.InstantMessages.Values
            'Dim SavedIM As InstantMessageConversation = CurrentSession.Conversations(a)
            ' // Add the target NN to the list.
            lbMessages.Items.Add(conversation.ConversationWith)
        Next
    End Sub

    Private Sub IMCenter_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        ActiveControl = tbTo
        tbTo.Focus()
    End Sub

    Private Sub tbTo_TextChanged(sender As Object, e As EventArgs) Handles tbTo.TextChanged
        Dim sIndex As Integer = lbMessages.FindString(tbTo.Text)
        If sIndex <> -1 Then lbMessages.SetSelected(sIndex, True)
    End Sub

End Class