Public Class Exclude
    Dim TheMainWindow As MainWindow
    Dim ThisSession As UserSession
    Dim ExcludeUser As String
    Public Sub New(hwndMain As MainWindow, CurrentSession As UserSession, Excluded As String)
        TheMainWindow = hwndMain
        ThisSession = CurrentSession
        ExcludeUser = Excluded
        InitializeComponent()
        If My.Settings.ModernStyle = True Then
            Me.BackColor = DefaultBackColor
            For Each cControl In Me.Controls
                If TypeOf cControl Is TextBox Then
                    CType(cControl, TextBox).BorderStyle = BorderStyle.Fixed3D
                End If
                CType(cControl, Control).BackColor = DefaultBackColor
                CType(cControl, Control).ForeColor = DefaultForeColor
                CType(cControl, Control).Font = DefaultFont
            Next
        End If
        Label1.Text = "Messages from " + ExcludeUser + " can be excluded."
    End Sub
    Private Sub bnOkay_Click(sender As Object, e As EventArgs) Handles bnOkay.Click
        If rbRoom.Checked = True Then
            ThisSession.RoomExcludeList.Add(ExcludeUser)
        Else
            If ThisSession.RoomExcludeList.Contains(ExcludeUser) Then ThisSession.RoomExcludeList.Remove(ExcludeUser)
        End If
        If rbChat.Checked = True Then
            ThisSession.GlobalExcludeList.Add(ExcludeUser)
        Else
            If ThisSession.GlobalExcludeList.Contains(ExcludeUser) Then ThisSession.GlobalExcludeList.Remove(ExcludeUser)
        End If

        If cbRefuse.Checked = True Then
            TheMainWindow.DoSendToServer("USER" + DELIMITER + "EXCLUDE" + DELIMITER + "ADD" + DELIMITER + "0" + DELIMITER + ExcludeUser)
            ThisSession.Excluded.Add(ExcludeUser)
        Else
            If ThisSession.Excluded.Contains(ExcludeUser) Then
                TheMainWindow.DoSendToServer("USER" + DELIMITER + "EXCLUDE" + DELIMITER + "REMOVE" + DELIMITER + "0" + DELIMITER + ExcludeUser)
                ThisSession.Excluded.Remove(ExcludeUser)
            End If

            End If
            Me.Close()
    End Sub

    Private Sub bnCancel_Click(sender As Object, e As EventArgs) Handles bnCancel.Click
        Me.Close()
    End Sub

    Private Sub Exclude_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If Not IsNothing(WindowPointers.ChatRoom) Then WindowPointers.ChatRoom.tbToSend.Focus()
    End Sub

    Private Sub Exclude_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (Application.OpenForms().OfType(Of IMCenter).Any) Then
            rbChat.Enabled = False
            rbRoom.Enabled = False
            rbView.Enabled = False
        End If
        CenterForm(Me, Me.Owner)
        If ThisSession.Excluded.Contains(ExcludeUser) Then cbRefuse.Checked = True
    End Sub
End Class