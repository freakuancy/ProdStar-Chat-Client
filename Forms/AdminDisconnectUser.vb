Public Class AdminDisconnectUser


    ' Main Window - For communication with the server
    Dim TheMainWindow As MainWindow
    Dim ThisSession As UserSession
    Dim doShift As Boolean
    Dim UserToDisconnect As String

    Public Sub New(hwndMain As MainWindow, CurrentSession As UserSession, DisconnectUser As String)
        TheMainWindow = hwndMain
        UserToDisconnect = DisconnectUser
        ThisSession = CurrentSession
        InitializeComponent()
    End Sub


    Private Sub bnDisconnectUser_click(sender As Object, e As EventArgs) Handles bnDisconnectUser.Click
        ' // Did the user select a message and a from?
        If (tbNameToDisconnect.TextLength > 0 And tbReasonForDisconnect.TextLength > 0) Then
            TheMainWindow.DoSendToServer("ADMIN" + DELIMITER +
                                         "ADMINDISCONNECT" + DELIMITER +
                                         tbNameToDisconnect.Text + DELIMITER +
                                         "0" + DELIMITER +
                                         "0" + DELIMITER +
                                         tbReasonForDisconnect.Text)
            ' // Acknowledge.
            ShowChatMessage(TheMainWindow, ThisSession, "Disconnect Requested", "User disconnection request was sent to the server.")
            ' // Hide the form.
            Me.Hide()
        Else
            ShowChatMessage(TheMainWindow, ThisSession, "Error", "You must enter a chat name to disconnect as well as a reason for the disconnect.")
        End If

    End Sub

    Private Sub AdminDisconnectUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (UserToDisconnect <> Nothing) Then
            tbNameToDisconnect.Text = UserToDisconnect
        End If
    End Sub
End Class