Public Class AdminClientMessage


    ' Main Window - For communication with the server
    Dim TheMainWindow As MainWindow
    Dim ThisSession As UserSession
    Dim doShift As Boolean

    Public Sub New(hwndMain As MainWindow, CurrentSession As UserSession)
        TheMainWindow = hwndMain
        ThisSession = CurrentSession
        InitializeComponent()
        ShowChatMessage(TheMainWindow, ThisSession, "WARNING", "This form is used to send a message to ALL currently connected users.  Please use with caution.")
    End Sub

    Private Sub AdminClientMessage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub ShowChatMessage(TheMainWindow As MainWindow, ThisSession As UserSession, strTitle As String, strMsg As String)
        Dim hwndMsg As New MessageDialog(TheMainWindow, ThisSession, strMsg, strTitle)
        WindowPointers.MessageDialog = hwndMsg
        TheMainWindow.Invoke(Sub() WindowPointers.MessageDialog.ShowDialog(TheMainWindow))
    End Sub

    Private Sub bnSendAdminMessage_Click(sender As Object, e As EventArgs) Handles bnSendAdminMessage.Click
        ' // Did the user select a message and a from?
        If (tbMsgTitle.TextLength > 0 And tbMsg.TextLength > 0) Then
            TheMainWindow.DoSendToServer("ADMIN" + DELIMITER +
                                         "CLIENTMSG" + DELIMITER +
                                         "0" + DELIMITER +
                                         "0" + DELIMITER +
                                         tbMsgTitle.Text + DELIMITER +
                                         tbMsg.Text)
            ' // Hide the form.
            Me.Hide()
        Else
            ShowChatMessage(TheMainWindow, ThisSession, "Error", "You must enter a message and a from in the form before using this feature.")
        End If

    End Sub
End Class