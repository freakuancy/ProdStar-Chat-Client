

Public Class InstantMessageConversation
    ' Members

    Dim ConversationWithMember As String
    Dim Conversation As String
    Dim ConversationWithID As String
    Dim strMsgQueue As New System.Collections.ArrayList

    ' Constructor
    Public Sub New(convoWith As String, convoID As String)
        ' Initialize the members
        ConversationWithMember = convoWith
        ConversationWithID = convoID
        Conversation = ""
    End Sub

    'Properties
    Property ConversationText() As String
        Set(value As String)
            Conversation = value
        End Set
        Get
            Return Conversation
        End Get
    End Property



    ReadOnly Property ConversationWith() As String
        Get
            Return ConversationWithMember
        End Get
    End Property
    ReadOnly Property ConversationID() As String
        Get
            Return ConversationWithMember
        End Get
    End Property


    Property MessageQueue As System.Collections.ArrayList
        Get
            Return strMsgQueue
        End Get
        Set(value As System.Collections.ArrayList)
            strMsgQueue = value
        End Set
    End Property


End Class
