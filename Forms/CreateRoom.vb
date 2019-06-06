Public Class CreateRoom
    Dim TheMainWindow As MainWindow
    Dim ThisSession As UserSession
    Dim AllAreas As New ArrayList
    Delegate Sub SetTextCallback([text] As String)
    Public Sub New(hwndMain As MainWindow, CurrentSession As UserSession)
        TheMainWindow = hwndMain
        ThisSession = CurrentSession
        InitializeComponent()
        If My.Settings.ModernStyle = True Then
            Me.BackColor = DefaultBackColor
            For Each cControl In Me.Controls
                If TypeOf cControl Is GroupBox Then
                    CType(cControl, GroupBox).BackColor = DefaultBackColor
                    CType(cControl, GroupBox).ForeColor = DefaultForeColor
                    For Each gControl In CType(cControl, GroupBox).Controls
                        If TypeOf gControl Is ListBox Then
                            CType(gControl, ListBox).BorderStyle = BorderStyle.Fixed3D
                            CType(gControl, ListBox).BackColor = SystemColors.Window
                        ElseIf TypeOf gControl Is ListBox Then
                            CType(gControl, ListBox).BorderStyle = BorderStyle.Fixed3D
                            CType(gControl, ListBox).BackColor = SystemColors.Window
                        ElseIf TypeOf gControl Is TextBox Then
                            CType(gControl, TextBox).BorderStyle = BorderStyle.Fixed3D
                            CType(gControl, TextBox).BackColor = SystemColors.Window
                            CType(gControl, TextBox).ForeColor = DefaultForeColor
                        Else
                            CType(gControl, Control).BackColor = DefaultBackColor
                            CType(gControl, Control).ForeColor = DefaultForeColor
                            CType(gControl, Control).Font = DefaultFont
                        End If
                    Next gControl
                End If
            Next cControl
        End If
    End Sub
    Private Sub CreateRoom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MoveForm(Me)
        UpdateAreaListFromSession()

        '// Administrative Features
        If (ThisSession.AccessLevel > 0 AND ThisSession.AdministratorFlagOn) Then
            rbMakeNativeRoom.Visible = True
        Else
            rbMakeNativeRoom.Visible = False
        End If

        ''TheMainWindow.DoSendToServer("CHAT" + DELIMITER + "ROOMS" + DELIMITER + "0" + DELIMITER + "0" + DELIMITER + "0")
    End Sub

    Public Sub UpdateList(Recd As String)
        Dim Splitup() As String = Recd.Split("#")
        Dim alist As New ArrayList(Splitup)
        Dim thisEntry As Array
        For Each listing As String In alist
            If (listing.Length > 0) Then
                thisEntry = listing.Split(",")
                Dim buffer As ChatArea
                buffer = GetAreaByName(thisEntry(0))
                If IsNothing(buffer) Then
                    buffer = New ChatArea(thisEntry(0), New List(Of ChatRoom))
                    AllAreas.Add(buffer)
                    AddToAreaList(buffer.ChatRoomArea)
                End If
            End If
        Next listing
    End Sub

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
        If (lbChatArea.Items.Count > 0) Then
            lbChatArea.Items.Clear()
        End If
        ' // Add the sorted list to the backing list of the listbox.
        For Each c As ChatArea In areaList
            lbChatArea.Items.Add(c.ChatRoomArea)
        Next

    End Sub

    Public Function GetAreaByName(AreaName As String) As ChatArea
        If (Not AllAreas Is Nothing) Then
            For Each area As ChatArea In AllAreas
                If area.ChatRoomArea.ToUpper = AreaName.ToUpper Then
                    Return area
                End If
            Next
            Return Nothing
        Else
            Return Nothing
        End If
    End Function
    Private Sub AddToAreaList(ByVal [text] As String)
        If Me.lbChatArea.InvokeRequired Then
            Dim d As New SetTextCallback(AddressOf AddToAreaList)
            Me.Invoke(d, New Object() {[text]})
        Else
            Me.lbChatArea.Items.Add([text])
            If lbChatArea.SelectedIndex = -1 Then lbChatArea.SelectedIndex = 0
        End If
    End Sub

    Private Sub bnCancel_Click(sender As Object, e As EventArgs) Handles bnCancel.Click
        Me.Close()
    End Sub

    Private Sub bnOkay_Click(sender As Object, e As EventArgs) Handles bnOkay.Click
        Dim strType As String = "MEMBER"
        Dim strCapacity As String = tbCapacity.Text
        Dim strEntry As String
        Dim strText As String
        Dim strShowList As String = "Y"
        '// Did the user select an area?
        If (lbChatArea.SelectedItem <> Nothing) Then
            Dim RoomString As String = lbChatArea.SelectedItem.ToString + "_" + tbRoomName.Text
            If rbListed.Checked = True Then strType = "MEMBER"
            If cbListNames.Checked = False Then strShowList = "N"
            If rbPrivate.Checked = True Then
                RoomString = "PRIVATE" + "_" + tbRoomName.Text
                strType = "MEMBER"
            End If
            If rbMakeNativeRoom.Checked = True Then
                RoomString = lbChatArea.SelectedItem.ToString + "_" + tbRoomName.Text
                strType = "NATIVE"
            End If
            Dim TypeString As String = strType + "_" + strCapacity + "_" + strShowList
            If tbEntryPass.Text = "" Then
                strEntry = "0"
            Else
                strEntry = tbEntryPass.Text
            End If
            If tbTextPass.Text = "" Then
                strText = "0"
            Else
                strText = tbTextPass.Text
            End If
            Dim PassString As String = strEntry + "," + strText
            TheMainWindow.DoSendToServer("CHAT" + DELIMITER + "CREATE" + DELIMITER + RoomString + DELIMITER + TypeString + DELIMITER + PassString)
            Me.Close()
        Else
            ShowChatMessage(TheMainWindow, ThisSession, "ProdStar® CHAT - Error", "You must select an area before using this feature.")
        End If
    End Sub

    Private Sub rbPrivate_CheckedChanged(sender As Object, e As EventArgs) Handles rbPrivate.CheckedChanged
        lbChatArea.SelectedItem = "PRIVATE"
        '// Disable the ENTRY and TEXT passwords temporary until other solution can be found.
        tbEntryPass.Enabled = False
        tbTextPass.Enabled = False
    End Sub

    Private Sub rbListed_CheckedChanged(sender As Object, e As EventArgs) Handles rbListed.CheckedChanged
        lbChatArea.SelectedIndex = lbChatArea.Items.Count - 1
        '// Re-enable the passwords.
        tbEntryPass.Enabled = True
        tbTextPass.Enabled = True
    End Sub

    Private Sub lbChatArea_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbChatArea.SelectedIndexChanged
        If lbChatArea.SelectedItem = "PRIVATE" Then
            '// Disable the ENTRY and TEXT passwords temporary until other solution can be found.
            '// Re-enable the passwords.
            tbEntryPass.Text = ""
            tbTextPass.Text = ""
            tbEntryPass.Enabled = False
            tbTextPass.Enabled = False
        Else
            '// Re-enable the passwords.
            tbEntryPass.Enabled = True
            tbTextPass.Enabled = True
        End If
    End Sub

End Class