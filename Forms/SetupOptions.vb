Public Class SetupOptions

    ' Main Window - For communication with the server
    Dim TheMainWindow As MainWindow
    Dim ThisSession As UserSession
    Dim img As Bitmap
    Dim toimg As Bitmap
    Public Sub New(hwndMain As MainWindow, CurrentSession As UserSession)
        TheMainWindow = hwndMain
        ThisSession = CurrentSession

        InitializeComponent()
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
        End If
        FillForm()

    End Sub

    Private Sub SetupOptions_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If Not IsNothing(WindowPointers.ChatRoom) Then WindowPointers.ChatRoom.tbToSend.Focus()
    End Sub
    Sub SetupOptions_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Hide()
        End If
    End Sub
    Private Sub FillForm()
        lblNickName.Text = ThisSession.CurrentNickName
        lbID.Text = ThisSession.UserID
        tbCityState.Text = ThisSession.CityStateInfo
        tbInterests.Text = ThisSession.InterestsInfo
        chkAllowIMS.Checked = ThisSession.AllowInstantMessages
        chkNotifyArrive.Checked = ThisSession.NotifyRoomEntry
        chkNotifyLeave.Checked = ThisSession.NotifyRoomDeparture
        chkDisplayMemberID.Checked = ThisSession.DisplayMyID
        chkActivateSounds.Checked = ThisSession.AllowSounds
        chkDoubleSpace.Checked = ThisSession.DoublespaceChatText
        chkClearBetweenRooms.Checked = ThisSession.ClearChatOnRoomChange


    End Sub
    Private Sub bnSave_Click(sender As Object, e As EventArgs) Handles bnSave.Click
        ' Get binary values from boolean properties
        Dim UseBold As String = "0"
        Dim UseAdvanced As String = "0"
        Dim strIMs As String = Convert.ToInt32(chkAllowIMS.Checked).ToString
        Dim strArrive As String = Convert.ToInt32(chkNotifyArrive.Checked).ToString
        Dim strLeave As String = Convert.ToInt32(chkNotifyLeave.Checked).ToString
        Dim strDisplayID As String = Convert.ToInt32(chkDisplayMemberID.Checked).ToString
        Dim strSounds As String = Convert.ToInt32(chkActivateSounds.Checked).ToString
        Dim strDoubleSpc As String = Convert.ToInt32(chkDoubleSpace.Checked).ToString
        Dim strClear As String = Convert.ToInt32(chkClearBetweenRooms.Checked).ToString
        'Toggle IMs
        If chkAllowIMS.Checked = True Then
            TheMainWindow.DoSendToServer("IMSG" + DELIMITER + "TOGGLE" + DELIMITER + "0" + DELIMITER + "0" + DELIMITER + "ON")
        Else
            TheMainWindow.DoSendToServer("IMSG" + DELIMITER + "TOGGLE" + DELIMITER + "0" + DELIMITER + "0" + DELIMITER + "OFF")
        End If

        ' Build binary in string format...
        Dim strBinary As String = strIMs + strArrive + strLeave + strDisplayID + strSounds + strDoubleSpc + strClear + UseBold + UseAdvanced
        ' Convert binary to base10
        Dim intMask As Integer = Convert.ToInt32(strBinary, 2)
        ' Send it off
        If (tbCityState.Text.Length = 0) Then
            tbCityState.Text = " "
        End If
        If (tbInterests.Text.Length = 0) Then
            tbInterests.Text = " "
        End If
        TheMainWindow.DoSendToServer("USER" + DELIMITER + "SETINFO" + DELIMITER + "CITYSTATE" + DELIMITER + "0" + DELIMITER + tbCityState.Text)
        TheMainWindow.DoSendToServer("USER" + DELIMITER + "SETINFO" + DELIMITER + "INTERESTS" + DELIMITER + "0" + DELIMITER + tbInterests.Text)
        TheMainWindow.DoSendToServer("USER" + DELIMITER + "SETINFO" + DELIMITER + "SETTINGS" + DELIMITER + "COMMIT" + DELIMITER + intMask.ToString)
        TheMainWindow.DoSendToServer("USER" + DELIMITER + "GETSETTINGS" + DELIMITER + "0" + DELIMITER + "0" + DELIMITER + "0")

    End Sub

    Private Sub SetupOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MoveForm(Me)
    End Sub

    Private Sub bnCancel_Click(sender As Object, e As EventArgs) Handles bnCancel.Click
        Me.Close()
        WindowPointers.ChatRoom.tbChatText.BackColor = My.Settings.ChatColor
    End Sub


    Private Sub bnChatType_Click(sender As Object, e As EventArgs) Handles bnChatType.Click
        If Not (Application.OpenForms().OfType(Of ChatType).Any) Then
            Dim frmChatType As New ChatType(TheMainWindow, ThisSession)
            WindowPointers.ChatType.Show(TheMainWindow)
            WindowPointers.ChatType.BringToFront()
        Else
            WindowPointers.ChatType.Show(TheMainWindow)
            WindowPointers.ChatType.BringToFront()
        End If
    End Sub


End Class