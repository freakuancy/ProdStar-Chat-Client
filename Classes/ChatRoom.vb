Public Class ChatRoom
    ' Members
    Dim RoomName As String
    Dim Area As ChatArea
    Dim HasEntryPassword As Boolean
    Dim HasTextPassword As Boolean
    Dim TheRoomType As RoomType
    Dim CurChatters As Integer
    Dim MaximumChatters As Integer
    Dim CreatedBy As String

    Public Enum RoomType
        ProdStarRoom
        MemberRoom
        AuditoriumRoom
        PrivateRoom
    End Enum

    'Constructor
    Public Sub New(ChatArea As ChatArea, Name As String, Entry As Boolean, Text As Boolean, Type As RoomType, cur As Integer, max As Integer, maker As String)
        ' Initialize the members
        Area = ChatArea
        RoomName = Name
        HasEntryPassword = Entry
        HasTextPassword = Text
        TheRoomType = Type
        CurChatters = cur
        MaximumChatters = max
        CreatedBy = maker
    End Sub

    'Properties
    ReadOnly Property ChatRoomName() As String
        Get
            Return RoomName
        End Get
    End Property

    Property RoomMaker() As String
        Get
            Return CreatedBy
        End Get
        Set(value As String)
            CreatedBy = value
        End Set
    End Property

    'Properties
    ReadOnly Property ChatRoomArea() As ChatArea
        ' Getter
        Get
            Return Area
        End Get
    End Property

    Property ChatRoomType() As RoomType
        ' Getter
        Get
            Return TheRoomType
        End Get
        Set(value As RoomType)
            TheRoomType = value
        End Set
    End Property

    Property CurrentChatters() As Integer
        ' Getter
        Get
            Return CurChatters
        End Get
        Set(value As Integer)
            CurChatters = value
        End Set
    End Property

    Property MaxChatters() As Integer
        ' Getter
        Get
            Return MaximumChatters
        End Get
        Set(value As Integer)
            MaximumChatters = value
        End Set
    End Property

    Property HasPasswordEntry()
        Get
            Return HasEntryPassword
        End Get
        Set(value)
            HasEntryPassword = value
        End Set
    End Property

    Property HasPasswordText()
        Get
            Return HasTextPassword
        End Get
        Set(value)
            HasTextPassword = value
        End Set
    End Property

    Public Function GetPasswordsString(hasentry As Boolean, hastext As Boolean)
        Dim encoded As String
        ' Set a default value
        encoded = ""
        ' Do we have an entry password?
        If (hasentry) Then
            encoded = "ENTRY"
        End If
        ' Do we have a text password?
        If (hastext) Then
            ' Do we also have an entry password?
            If (hasentry) Then
                encoded += "/"
            End If
            encoded += "TEXT"
        End If
        Return encoded
    End Function

End Class