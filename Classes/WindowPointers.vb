Public Class WindowPointers

    '// Members
    Private Shared m_AreaSelect As AreaRoomSelect
    Private Shared m_InstantMessageCenter As IMCenter
    Private Shared m_IncomingInstantMessage As IncomingInstantMessage
    Private Shared m_MainWindow As MainWindow
    Private Shared m_MemberInformation As MemberInformation
    Private Shared m_RoomInformation As RoomInfo
    Private Shared m_SetupOptions As SetupOptions
    Private Shared m_BugReport As BugReport
    Private Shared m_SignOn As SignOn
    Private Shared m_Exclude As Exclude
    Private Shared m_UserInput As UserInput
    Private Shared m_CreateRoom As CreateRoom
    Private Shared m_ChatLaunch As ChatLaunch
    Private Shared m_AlertCenter As AlertCenter
    Private Shared m_Connection As Connection
    Private Shared m_ChangePasswd As ChangePassword
    Private Shared m_AboutBox As About
    Private Shared m_ChatRoom As frmChatWindow
    Private Shared m_ChatType As ChatType
    Private Shared m_MessageDialog As MessageDialog
    Private Shared m_AdminMessage As AdminMessage
    Private Shared m_AdminClientMessage As AdminClientMessage
    Private Shared m_AdminDisconnectUser As AdminDisconnectUser



    '//Dataums
    Private Shared m_preview As String
    Private Shared m_BugCrash As Boolean
    Private Shared m_MemberName As String
    Private Shared m_Session As UserSession
    Private Shared m_LoadMessage As String
    Private Shared m_InputMessage As String
    Private Shared m_TitleMessage As String
    Public Shared Property ChatType() As ChatType
        Get
            If IsNothing(m_ChatType) Then
                m_ChatType = New ChatType(m_MainWindow, m_Session)
            End If
            Return m_ChatType
        End Get
        Set(ByVal Value As ChatType)
            m_ChatType = Value
        End Set
    End Property
    Public Shared Property AdminDisconnectUser() As AdminDisconnectUser
        Get
            If IsNothing(m_AdminDisconnectUser) Then
                m_AdminDisconnectUser = New AdminDisconnectUser(m_MainWindow, m_Session, Nothing)
            End If
            Return m_AdminDisconnectUser
        End Get
        Set(ByVal Value As AdminDisconnectUser)
            m_AdminDisconnectUser = Value
        End Set
    End Property
    Public Shared Property AdminClientMessage() As AdminClientMessage
        Get
            If IsNothing(m_AdminClientMessage) Then
                m_AdminClientMessage = New AdminClientMessage(m_MainWindow, m_Session)
            End If
            Return m_AdminClientMessage
        End Get
        Set(ByVal Value As AdminClientMessage)
            m_AdminClientMessage = Value
        End Set
    End Property
    Public Shared Property AdminMessage() As AdminMessage
        Get
            If IsNothing(m_AdminMessage) Then
                m_AdminMessage = New AdminMessage(m_MainWindow, m_Session)
            End If
            Return m_AdminMessage
        End Get
        Set(ByVal Value As AdminMessage)
            m_AdminMessage = Value
        End Set
    End Property
    Public Shared Property AboutBox() As About
        Get
            If IsNothing(m_AboutBox) Then
                m_AboutBox = New About(m_MainWindow, m_Session)
            End If
            Return m_AboutBox
        End Get
        Set(ByVal Value As About)
            m_AboutBox = Value
        End Set
    End Property
    Public Shared Property ChangePassword() As ChangePassword
        Get
            If IsNothing(m_ChangePasswd) Then
                m_ChangePasswd = New ChangePassword(m_MainWindow, m_Session)
            End If
            Return m_ChangePasswd
        End Get
        Set(ByVal Value As ChangePassword)
            m_ChangePasswd = Value
        End Set
    End Property
    Public Shared Property BugReport() As BugReport
        Get
            If IsNothing(m_BugReport) Then
                m_BugReport = New BugReport(m_MainWindow, m_Session, m_LoadMessage, m_Bugcrash)
            End If
            Return m_BugReport
        End Get
        Set(ByVal Value As BugReport)
            m_BugReport = Value
        End Set
    End Property
    Public Shared Property Connection() As Connection
        Get
            If IsNothing(m_Connection) Then
                m_Connection = New Connection(m_MainWindow)
            End If
            Return m_Connection
        End Get
        Set(ByVal Value As Connection)
            m_Connection = Value
        End Set
    End Property
    Public Shared Property Exclude() As Exclude
        Get
            If IsNothing(m_Exclude) Then
                m_Exclude = New Exclude(m_MainWindow, m_Session, m_MemberName)
            End If
            Return m_Exclude
        End Get
        Set(ByVal Value As Exclude)
            m_Exclude = Value
        End Set
    End Property
    Public Shared Property AlertCenter() As AlertCenter
        Get
            If IsNothing(m_AlertCenter) Then
                m_AlertCenter = New AlertCenter(m_MainWindow, m_Session)
            End If
            Return m_AlertCenter
        End Get
        Set(ByVal Value As AlertCenter)
            m_AlertCenter = Value
        End Set
    End Property

    Public Shared Property ChatLaunch() As ChatLaunch
        Get
            If IsNothing(m_ChatLaunch) Then
                m_ChatLaunch = New ChatLaunch(m_MainWindow, m_Session)
            End If
            Return m_ChatLaunch
        End Get
        Set(ByVal Value As ChatLaunch)
            m_ChatLaunch = Value
        End Set
    End Property
    Public Shared Property CreateRoom() As CreateRoom
        Get
            If IsNothing(m_CreateRoom) Then
                m_CreateRoom = New CreateRoom(m_MainWindow, m_Session)
            End If
            Return m_CreateRoom
        End Get
        Set(ByVal Value As CreateRoom)
            m_CreateRoom = Value
        End Set
    End Property

    Public Shared Property MessageDialog() As MessageDialog
        Get
            If IsNothing(m_MessageDialog) Then
                m_MessageDialog = New MessageDialog(m_MainWindow, m_Session, m_LoadMessage, m_TitleMessage)
            End If
            Return m_MessageDialog
        End Get
        Set(ByVal Value As MessageDialog)
            m_MessageDialog = Value
        End Set
    End Property
    Public Shared Property UserInput() As UserInput
        Get
            If IsNothing(m_UserInput) Then
                m_UserInput = New UserInput(m_MainWindow, m_Session, m_LoadMessage, m_InputMessage, m_TitleMessage, m_preview)
            End If
            Return m_UserInput
        End Get
        Set(ByVal Value As UserInput)
            m_UserInput = Value
        End Set
    End Property



    Public Shared Property AreaSelect() As AreaRoomSelect
        Get
            If IsNothing(m_AreaSelect) Then
                m_AreaSelect = New AreaRoomSelect(m_MainWindow, m_Session)
            End If
            Return m_AreaSelect
        End Get
        Set(ByVal Value As AreaRoomSelect)
            m_AreaSelect = Value
        End Set
    End Property


    Public Shared Property InstantMessageCenter() As IMCenter
        Get
            If IsNothing(m_InstantMessageCenter) Then
                m_InstantMessageCenter = New IMCenter(m_MainWindow, m_Session)
            End If
            Return m_InstantMessageCenter
        End Get
        Set(ByVal Value As IMCenter)
            m_InstantMessageCenter = Value
        End Set
    End Property

    Public Shared Property IncomingInstantMessage() As IncomingInstantMessage
        Get
            If IsNothing(m_IncomingInstantMessage) Then
                m_IncomingInstantMessage = New IncomingInstantMessage(m_MainWindow, m_Session)
            End If
            Return m_IncomingInstantMessage
        End Get
        Set(ByVal Value As IncomingInstantMessage)
            m_IncomingInstantMessage = Value
        End Set
    End Property

    Public Shared Property MainWindow() As MainWindow
        Get
            If IsNothing(m_MainWindow) Then
                m_MainWindow = New MainWindow
            End If
            Return m_MainWindow
        End Get
        Set(ByVal Value As MainWindow)
            m_MainWindow = Value
        End Set
    End Property

    Public Shared Property MemberInformation() As MemberInformation
        Get
            If IsNothing(m_MemberInformation) Then
                m_MemberInformation = New MemberInformation(m_MainWindow, m_Session, m_MemberName)
            End If
            Return m_MemberInformation
        End Get
        Set(ByVal Value As MemberInformation)
            m_MemberInformation = Value
        End Set
    End Property

    Public Shared Property RoomInformation() As RoomInfo
        Get
            If IsNothing(m_RoomInformation) Then
                m_RoomInformation = New RoomInfo(m_MainWindow, m_Session, Nothing)
            End If
            Return m_RoomInformation
        End Get
        Set(ByVal Value As RoomInfo)
            m_RoomInformation = Value
        End Set
    End Property

    Public Shared Property SetupOptions() As SetupOptions
        Get
            If IsNothing(m_SetupOptions) Then
                m_SetupOptions = New SetupOptions(m_MainWindow, m_Session)

            End If
            Return m_SetupOptions
        End Get
        Set(ByVal Value As SetupOptions)
            m_SetupOptions = Value
        End Set
    End Property

    Public Shared Property SignOn() As SignOn
        Get
            If IsNothing(m_SignOn) Then
                m_SignOn = New SignOn(m_MainWindow, m_Session)
            End If
            Return m_SignOn
        End Get
        Set(ByVal Value As SignOn)
            m_SignOn = Value
        End Set
    End Property

    Public Shared Property ChatRoom() As frmChatWindow
        Get
            If IsNothing(m_ChatRoom) Then
                m_ChatRoom = New frmChatWindow(m_MainWindow, m_Session)
            End If
            Return m_ChatRoom
        End Get
        Set(ByVal Value As frmChatWindow)
            m_ChatRoom = Value
        End Set
    End Property
End Class





