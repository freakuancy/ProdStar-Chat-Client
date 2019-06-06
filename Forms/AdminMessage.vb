Public Class AdminMessage

    ' Main Window - For communication with the server
    Dim TheMainWindow As MainWindow
    Dim ThisSession As UserSession
    Dim doShift As Boolean

    Public Sub New(hwndMain As MainWindow, CurrentSession As UserSession)
        TheMainWindow = hwndMain
        ThisSession = CurrentSession
        InitializeComponent()
    End Sub


    Private Sub AdminMessage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub bnSendAdminMessage_Click(sender As Object, e As EventArgs) Handles bnSendAdminMessage.Click
        ' // Are we currently in a room?
        If (ThisSession.CurrentArea <> Nothing And ThisSession.CurrentChatRoom <> Nothing) Then
            ' // Did the user select a message and a from?
            If (tbAdminMsgFrom.TextLength > 0 And tbAdminMsg.TextLength > 0) Then
                TheMainWindow.DoSendToServer("ADMIN" + DELIMITER +
                                             "ADMINMESSAGE" + DELIMITER +
                                             ThisSession.CurrentArea + DELIMITER +
                                             ThisSession.CurrentChatRoom + DELIMITER +
                                             tbAdminMsgFrom.Text + DELIMITER +
                                             tbAdminMsg.Text)
                ' // Hide the form.
                Me.Hide()
            Else
                ShowChatMessage(TheMainWindow, ThisSession, "Error", "You must enter a message and a from in the form before using this feature.")
            End If
        Else
            ShowChatMessage(TheMainWindow, ThisSession, "Error", "You must be in a chat room to use this feature.")
        End If
    End Sub

    Public Sub ShowChatMessage(TheMainWindow As MainWindow, ThisSession As UserSession, strTitle As String, strMsg As String)
        Dim hwndMsg As New MessageDialog(TheMainWindow, ThisSession, strMsg, strTitle)
        WindowPointers.MessageDialog = hwndMsg
        TheMainWindow.Invoke(Sub() WindowPointers.MessageDialog.ShowDialog(TheMainWindow))
    End Sub
End Class