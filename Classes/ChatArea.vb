Public Class ChatArea
    ' Members
    Dim AreaName As String
    Dim ChatRooms As List(Of ChatRoom)

    'Constructor
    Public Sub New(Name As String, Rooms As List(Of ChatRoom))
        ' Initialize the members
        AreaName = Name.Trim
        ChatRooms = Rooms
    End Sub

    '// Does this ChatArea have the requested room?
    Public Function DoesAreaHaveRoom(RoomName As String)
        '// Migrate this to a dictionary eventually...
        For Each thisRoom As ChatRoom In ChatRooms
            If (thisRoom.ChatRoomName.ToUpper = RoomName.ToUpper) Then
                Return thisRoom
            End If
        Next thisRoom
        Return Nothing
    End Function

    'Properties
    ReadOnly Property RoomsInArea() As List(Of ChatRoom)
        Get
            Return ChatRooms
        End Get
    End Property

    'Properties
    ReadOnly Property ChatRoomArea() As String
        ' Getter
        Get
            Return AreaName
        End Get
    End Property





End Class
