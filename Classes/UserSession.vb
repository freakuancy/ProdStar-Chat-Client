Imports System.Collections.Concurrent

Public Class UserSession
    ' Members
    Dim NickName As String
    Dim LogonID As String

    Private _AccessLevel As Integer



    ' User Preferences
    Dim InstantMessagesOn As Boolean
    Dim RoomEntryNotify As Boolean
    Dim RoomExitNotify As Boolean
    Dim DisplayID As Boolean
    Dim PlaySounds As Boolean
    Dim DoublespaceChat As Boolean
    Dim ClearChatBetweenRooms As Boolean
    Dim Advanced As Boolean
    Dim Bold As Boolean
    ' Member Information
    Dim CityState As String
    Dim Interests As String
    ' Instant Message Conversations
    Dim ListExcluded As New List(Of String)
    'Dim IMConversations As New ArrayList
    Dim InstantMessageConversations As Dictionary(Of String, InstantMessageConversation)
    Dim OutgoingMessageQueue As Dictionary(Of String, QueuedMsg)
    Dim msgOutGoing As New ArrayList
    Dim CurrentChat As String
    Dim LogChatRoom As Boolean
    Dim CurrentAreaName As String
    Dim JumpRoomName As String
    Dim JumpAreaName As String
    Dim RoomExclude As New ArrayList
    Dim GlobalExclude As New ArrayList
    Dim Updated As Boolean
    Dim AutoRecon As Boolean
    Dim AppHidden As Boolean
    Dim AdminOn As Boolean

    ' Constructor
    Dim ChatAreas As Dictionary(Of String, ChatArea)

    '// Constructor
    Public Sub New()
        ' Set values passed in

        ' Default settings
        InstantMessagesOn = False
        RoomEntryNotify = True
        RoomExitNotify = True
        DisplayID = False
        PlaySounds = True
        DoublespaceChat = False
        ClearChatBetweenRooms = False
        InstantMessageConversations = New Dictionary(Of String, InstantMessageConversation)(StringComparer.CurrentCultureIgnoreCase)
        OutgoingMessageQueue = New Dictionary(Of String, QueuedMsg)(StringComparer.CurrentCultureIgnoreCase)
        ChatAreas = New Dictionary(Of String, ChatArea)(StringComparer.CurrentCultureIgnoreCase)
        AccessLevel = 0
        AdminOn = False
    End Sub
    ReadOnly Property ChatAreaCache As Dictionary(Of String, ChatArea)
        Get
            Return ChatAreas
        End Get
    End Property
    '//
    '// The purpose of this subroutine is to refresh the list of areas cache.
    '//
    Public Sub UpdateAreaListCache(UpdatedAreaList As String)
        '// First, did we actually get anything from the server?
        If Not (IsNothing(UpdatedAreaList.Length)) Then
            '// Areas are recieved from the server as a comma-delimited list in the form:
            '// [Area-0],[Area-1], ..., [Area-N]
            SyncLock ChatAreas
                For Each nextArea As String In UpdatedAreaList.Split(",")
                    ' // Does this area already exist?
                    If Not (Me.ChatAreas.ContainsKey(nextArea)) Then
                        ' // Add the new area to the collection
                        ChatAreas.Add(nextArea, New ChatArea(nextArea, New List(Of ChatRoom)))
                    End If
                Next
            End SyncLock
        End If
    End Sub

    '//
    '// The purpose of this subroutine is to update the chat rooms within
    '// a given area.  If a chat room already exists within the area, 
    '// the subroutine simply updates all of the details about the room
    '// with the latest data from the server.
    '//
    Public Sub UpdateChatRoomsInArea(AreaName As String, EncodedChatRooms As String)
        '// First step, determine if the area exists in the cache.  If not, create it.
        If Not (ChatAreas.ContainsKey(AreaName)) Then
            ' // Mutex the shared area list
            SyncLock ChatAreas
                '// Create the area.
                ChatAreas.Add(AreaName, New ChatArea(AreaName, New List(Of ChatRoom)))
            End SyncLock
        End If
        '// Now that we're guaranteed to have the area given by AreaName, get a pointer to it.
        Dim theArea As ChatArea = ChatAreas.Item(AreaName)
        '// Next, decode the chat rooms and either add the new room to theArea
        '// or if the room already exists, update the properties.
        Dim encodedRooms() As String = EncodedChatRooms.Substring(0, EncodedChatRooms.Length() - 1).Split("#")
        '// Encoding schema from the server:
        ' // 0: [Area Name], 1: [Room Name],
        ' // 2: [Room Type], 3: [Has Entry Password], 
        ' // 4: [Has Text Password], 5: [Number of users currently here]
        ' // 6: [Maximum number of users allowed] 7: [Who created the room]

        '// This counter tracks how many rooms we add.  This is necessary to capture disparities if a room (member)
        '// is closed.  We need to do it this way because we can't simply replace the list of rooms each time this
        '// updates due to the fact that we maintain pointers to the objects in the cache.  
        Dim SanityCount As Integer = 0
        For Each thisRoom As String In encodedRooms
            '// Increment sanitycounter
            SanityCount = SanityCount + 1
            '// Iterate over each encoded room.
            Dim roomData() As String = thisRoom.Split(",")
            '// Determine what type of chat room this is.
            Dim roomType As ChatRoom.RoomType
            '// Set the chat room type variable.
            If (roomData(2).ToUpper = "MEMBER") Then
                roomType = ChatRoom.RoomType.MemberRoom
            ElseIf (roomData(2).ToUpper = "AUDITORIUM") Then
                roomType = ChatRoom.RoomType.AuditoriumRoom
            ElseIf (roomData(2).ToUpper = "PRIVATE") Then
                roomType = ChatRoom.RoomType.PrivateRoom
            Else
                roomType = ChatRoom.RoomType.ProdStarRoom
            End If
            '// Does this area already have a room by that name?
            Dim existingChatRoom As ChatRoom = theArea.DoesAreaHaveRoom(roomData(1))
            If Not (IsNothing(existingChatRoom)) Then
                '// Synclock in case we have multiple threads accessing this.
                SyncLock existingChatRoom
                    '//
                    '// The room already exists.  Update it's specifications.
                    '// Specifications are only updated if they differ from the new data.
                    '//
                    '// Entry password.
                    If Not (existingChatRoom.HasPasswordEntry = If(roomData(3).ToUpper = "ENTRY", True, False)) Then
                        existingChatRoom.HasPasswordEntry = If(roomData(3).ToUpper = "ENTRY", True, False)
                    End If
                    '// Text Password.
                    If Not (existingChatRoom.HasPasswordText = If(roomData(4).ToUpper = "TEXT", True, False)) Then
                        existingChatRoom.HasPasswordText = If(roomData(4).ToUpper = "TEXT", True, False)
                    End If
                    '// Room Type
                    If Not (existingChatRoom.ChatRoomType = roomType) Then
                        existingChatRoom.ChatRoomType = roomType
                    End If
                    '// Current Users
                    If Not (existingChatRoom.CurrentChatters = roomData(5)) Then
                        existingChatRoom.CurrentChatters = roomData(5)
                    End If
                    '// Max Users
                    If Not (existingChatRoom.RoomMaker = roomData(6)) Then
                        existingChatRoom.RoomMaker = roomData(6)
                    End If
                    '// Who created the room
                    If Not (existingChatRoom.RoomMaker = roomData(7)) Then
                        existingChatRoom.RoomMaker = roomData(7)
                    End If
                End SyncLock
            Else
                ' // The room is new.  Simply add it to the area.
                Dim theNewRoom As New ChatRoom(theArea,
                                               roomData(1),
                                               If(roomData(3).ToUpper = "ENTRY", True, False),
                                               If(roomData(4).ToUpper = "TEXT", True, False),
                                               roomType,
                                               roomData(5),
                                               roomData(6),
                                               roomData(7))
                '// Add the new room to the list.
                SyncLock theArea
                    theArea.RoomsInArea.Add(theNewRoom)
                End SyncLock
            End If
        Next thisRoom
        '// Check to see if our sanity count equals the number of rooms in the area.
        '// This has a horrible runtime... replace it later if possible.
        If (theArea.RoomsInArea.Count > SanityCount) Then
            '// Something is off.  We need to remove any rooms that are NOT in encodedRooms
            '// Sentinel
            Dim found As Boolean = False
            For cnt = (theArea.RoomsInArea.Count - 1) To 0 Step -1
                '// Sentinel
                found = False
                '// Check this chat room
                Dim thisRoom As ChatRoom = theArea.RoomsInArea.Item(cnt)
                '// Is this room in the newly sent list?
                For Each thisEncodedRoom As String In encodedRooms
                    '// Re-split.
                    Dim roomData() As String = thisEncodedRoom.Split(",")
                    '// Is this room in the encoded list?
                    If (roomData(1).ToUpper = thisRoom.ChatRoomName.ToUpper) Then
                        found = True
                    End If
                Next thisEncodedRoom
                '// Did we find this room in the latest?
                If Not found Then
                    theArea.RoomsInArea.Remove(thisRoom)
                End If
            Next
        End If
    End Sub
    Property AdministratorFlagOn As Boolean
        Get
            Return AdminOn
        End Get
        Set(value As Boolean)
            AdminOn = value
        End Set
    End Property

    Property ClientHidden As Boolean
        Get
            Return AppHidden
        End Get
        Set(value As Boolean)
            AppHidden = value
        End Set
    End Property
    Property AutoReconnecting As Boolean
        Get
            Return AutoRecon
        End Get
        Set(value As Boolean)
            AutoRecon = value
        End Set
    End Property
    Property ClientUpdated As Boolean
        Get
            Return Updated
        End Get
        Set(value As Boolean)
            Updated = value
        End Set
    End Property
    Property UserID
        Get
            Return LogonID
        End Get
        Set(value)
            LogonID = UCase(value)
        End Set
    End Property
    Property CurrentNickName
        Get
            If (AdministratorFlagOn) Then
                Return "CHAT Host"
            Else
                Return NickName
            End If
        End Get
        Set(value)
            NickName = value
        End Set
    End Property
    ReadOnly Property TrueNickName
        Get
            Return NickName
        End Get
    End Property
    Property JumpRoom
        Get
            Return JumpRoomName
        End Get
        Set(value)
            JumpRoomName = value
        End Set
    End Property
    Property JumpArea
        Get
            Return JumpAreaName
        End Get
        Set(value)
            JumpAreaName = value
        End Set
    End Property
    ' ReadOnly Property Conversations As ArrayList
    '     Get
    '         Return IMConversations
    '      End Get
    '  End Property

    ReadOnly Property InstantMessages As Dictionary(Of String, InstantMessageConversation)
        Get
            Return InstantMessageConversations
        End Get
    End Property


    Property CurrentChatRoom As String
        Get
            Return CurrentChat
        End Get
        Set(value As String)
            CurrentChat = value
        End Set
    End Property
    Property CurrentArea As String
        Get
            Return CurrentAreaName
        End Get
        Set(value As String)
            CurrentAreaName = value
        End Set
    End Property

    ReadOnly Property getcurrentid
        Get
            Return LogonID
        End Get
    End Property

    ReadOnly Property OutgoingMessages As Dictionary(Of String, QueuedMsg)
        Get
            Return OutgoingMessageQueue
        End Get
    End Property

    ' IMs on/off
    Property AllowInstantMessages As Boolean
        Get
            Return InstantMessagesOn
        End Get
        Set(value As Boolean)
            InstantMessagesOn = value
        End Set
    End Property

    ' Notify me when someone enters the room
    Property NotifyRoomEntry As Boolean
        Get
            Return RoomEntryNotify
        End Get
        Set(value As Boolean)
            RoomEntryNotify = value
        End Set
    End Property

    ' Notify me when someone leaves the room
    Property NotifyRoomDeparture As Boolean
        Get
            Return RoomExitNotify
        End Get
        Set(value As Boolean)
            RoomExitNotify = value
        End Set
    End Property

    ' Display my ID
    Property DisplayMyID As Boolean
        Get
            Return DisplayID
        End Get
        Set(value As Boolean)
            DisplayID = value
        End Set
    End Property

    ' Play sounds
    Property AllowSounds As Boolean
        Get
            Return PlaySounds
        End Get
        Set(value As Boolean)
            PlaySounds = value
        End Set
    End Property

    ' Doublespace Chat?
    Property DoublespaceChatText As Boolean
        Get
            Return DoublespaceChat
        End Get
        Set(value As Boolean)
            DoublespaceChat = value
        End Set
    End Property
    Property LogChat As Boolean
        Get
            Return LogChatRoom
        End Get
        Set(value As Boolean)
            LogChatRoom = value
        End Set
    End Property
    ' Clear chat between rooms? ClearChatBetweenRooms
    Property ClearChatOnRoomChange As Boolean
        Get
            Return ClearChatBetweenRooms
        End Get
        Set(value As Boolean)
            ClearChatBetweenRooms = value
        End Set
    End Property

    ReadOnly Property Excluded As List(Of String)
        Get
            Return ListExcluded
        End Get
    End Property

    Public Property AccessLevel As Integer
        Get
            Return _AccessLevel
        End Get
        Set(ByVal value As Integer)
            _AccessLevel = value
        End Set
    End Property

    'ReadOnly Property OutgoingQueue As ArrayList
    '    Get
    '        Return msgOutGoing
    '    End Get
    'End Property
    Property CityStateInfo As String
        Get
            Return CityState
        End Get
        Set(value As String)
            CityState = value
        End Set
    End Property

    Property InterestsInfo As String
        Get
            Return Interests
        End Get
        Set(value As String)
            Interests = value
        End Set
    End Property
    Property UseAdvanced As Boolean
        Get
            Return Advanced
        End Get
        Set(value As Boolean)
            Advanced = value
        End Set
    End Property
    Property UseBold As Boolean
        Get
            Return Bold
        End Get
        Set(value As Boolean)
            Bold = value
        End Set
    End Property

    Property RoomExcludeList As ArrayList
        Get
            Return RoomExclude
        End Get
        Set(value As ArrayList)
            RoomExclude = value
        End Set
    End Property
    Property GlobalExcludeList As ArrayList
        Get
            Return GlobalExclude
        End Get
        Set(value As ArrayList)
            GlobalExclude = value
        End Set
    End Property

    Function VolatileRead(Of T)(ByRef Address As T) As T
        VolatileRead = Address
        Threading.Thread.MemoryBarrier()
    End Function

    Sub VolatileWrite(Of T)(ByRef Address As T, ByVal Value As T)
        Threading.Thread.MemoryBarrier()
        Address = Value
    End Sub

    '// Add a message to a specific conversation
    Public Sub AddMessageToIMConversation(ConversationWith As String, TheMessage As QueuedMsg)
        ' // Synch-lock the Conversations
        SyncLock InstantMessageConversations
            ' // Lookup with whom the conversation is with.
            If (InstantMessageConversations.ContainsKey(ConversationWith)) Then
                ' // Conversation already exists.  Add the message to it.
                InstantMessageConversations.Item(ConversationWith).MessageQueue.Add(TheMessage)
            Else
                ' // Conversation does not exist.  Add it.
                Dim NewConversation As InstantMessageConversation = New InstantMessageConversation(TheMessage.Nick, TheMessage.ID)
                ' // Add the message to it.
                NewConversation.MessageQueue.Add(TheMessage)
                ' // Add this to my conversations.
                InstantMessageConversations.Add(ConversationWith, NewConversation)
            End If
            ' // Remove the message from the outgoing queue if it's there.
            OutgoingMessageQueue.Remove(TheMessage.Nick.ToUpper)
        End SyncLock
    End Sub

    '// Enqueue a message to be sent out.
    Public Sub AddMessageForSending(TheMessage As QueuedMsg)
        '// Ensure we are locking across threads.
        SyncLock OutgoingMessageQueue
            Try
                OutgoingMessageQueue.Add(TheMessage.Nick.ToUpper, TheMessage)
            Catch ae As ArgumentException
                ' // The message already exists in the queue.  Add it to the secondary list.
                msgOutGoing.Add(TheMessage)
            End Try
        End SyncLock
    End Sub

    '// Grab messages from the secondary queue.
    '// This is only necessary for the unlikely case where a user attempts to send
    '// multiple messages to someone before the initial check available returns from
    '// the server.
    Public Function GetSecondaryMessages(ChatName As String)
        '// First, is anything stored in the secondary list?
        If (msgOutGoing.Count > 0) Then
            '// Create a list of messages to return.
            Dim returnList As New ArrayList
            Dim newQueuedList As New ArrayList
            '// Find all messages for the given site id
            For Each thisMessage As QueuedMsg In msgOutGoing
                '// Is this a message we need?
                If (thisMessage.ID.ToUpper = ChatName.ToUpper) Then
                    '// Add it to our return list.
                    returnList.Add(thisMessage)
                Else
                    '// This is a message that we weren't looking for.  
                    '// Add it to the replacement list.
                    newQueuedList.Add(thisMessage)
                End If
            Next thisMessage
            '// Return the list
            msgOutGoing = newQueuedList
            GetSecondaryMessages = returnList
        Else
            GetSecondaryMessages = Nothing
        End If
    End Function

End Class