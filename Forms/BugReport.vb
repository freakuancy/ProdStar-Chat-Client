Public Class BugReport
    Dim TheMainWindow As MainWindow
    Dim ThisSession As UserSession
    Dim Drag As Boolean
    Dim MouseX As Integer
    Dim MouseY As Integer

    Public Sub New(hwndMain As MainWindow, CurrentSession As UserSession, Preload As String, Crash As Boolean)
        TheMainWindow = hwndMain
        ThisSession = CurrentSession

        InitializeComponent()
        If Crash = True Then
            cbBugType.SelectedItem = "Program Bug"
        Else
            cbBugType.SelectedItem = "CHAT Bug"
        End If
        tbDetails.Text = Preload
    End Sub

    Private Sub AlertCenter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterForm(Me)
    End Sub
    Protected Overrides Sub OnPaintBackground(ByVal e As System.Windows.Forms.PaintEventArgs)
        Dim Borderpen As New Pen(Color.Purple, 5)
        MyBase.OnPaintBackground(e)

        Dim rect As New Rectangle(0, 0, Me.ClientSize.Width - 1, Me.ClientSize.Height - 1)
        e.Graphics.DrawRectangle(Borderpen, rect)
    End Sub

    Private Sub bnCancel_Click(sender As Object, e As EventArgs) Handles bnCancel.Click
        Me.Close()
    End Sub

    Private Sub bnOkay_Click(sender As Object, e As EventArgs) Handles bnOkay.Click
        '// What option has been selected?
        Dim value As Integer
        If (cbBugType.SelectedItem.ToString = "CHAT Bug") Then
            value = 1027
        ElseIf (cbBugType.SelectedItem.ToString = "Instant Message Bug") Then
            value = 1028
        ElseIf (cbBugType.SelectedItem.ToString = "Interface Bug") Then
            value = 1026
        Else
            value = 1029
        End If
        If Len(tbDetails.Text) > 0 Then
            TheMainWindow.DoSendToServer("USER" + DELIMITER + "ALERT" + DELIMITER + value.ToString + DELIMITER + "0" + DELIMITER + tbDetails.Text)
            ShowChatMessage(TheMainWindow, ThisSession, "ProdStar® CHAT - Report Sent", "Your Bug Report has been sent. " + vbNewLine + "Thank you for helping us maintain a very important piece of internet history!")
            Me.Close()
        Else
            ShowChatMessage(TheMainWindow, ThisSession, "ProdStar® CHAT - Error", "You must enter one or more nicknames before using this feature.")
        End If

    End Sub

    Private Sub Label2_MouseDown(sender As Object, e As MouseEventArgs) Handles Label2.MouseDown, PictureBox1.MouseDown, Label6.MouseDown, Label4.MouseDown, Me.MouseDown
        Drag = True
        MouseX = Windows.Forms.Cursor.Position.X - Me.Left
        MouseY = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Label2_MouseMove(sender As Object, e As MouseEventArgs) Handles Label2.MouseMove, PictureBox1.MouseMove, Label6.MouseMove, Label4.MouseMove, Me.MouseMove
        If Drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - MouseY
            Me.Left = Windows.Forms.Cursor.Position.X - MouseX
        End If
    End Sub

    Private Sub Label2_MouseUp(sender As Object, e As MouseEventArgs) Handles Label2.MouseUp, PictureBox1.MouseUp, Label6.MouseUp, Label4.MouseUp, Me.MouseUp
        Drag = False
    End Sub

End Class