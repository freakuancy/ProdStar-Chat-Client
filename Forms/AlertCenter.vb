Public Class AlertCenter
    Dim TheMainWindow As MainWindow
    Dim ThisSession As UserSession


    Public Sub New(hwndMain As MainWindow, CurrentSession As UserSession)
        TheMainWindow = hwndMain
        ThisSession = CurrentSession

        InitializeComponent()
        If My.Settings.ModernStyle = True Then
            Me.BackColor = DefaultBackColor
            For Each cControl In Me.Controls
                CType(cControl, Control).BackColor = DefaultBackColor
                CType(cControl, Control).Font = DefaultFont
                CType(cControl, Control).ForeColor = DefaultForeColor
                If TypeOf cControl Is ListBox Then
                    CType(cControl, ListBox).BorderStyle = BorderStyle.Fixed3D
                    CType(cControl, ListBox).BackColor = SystemColors.Window
                ElseIf TypeOf cControl Is ComboBox Then
                    CType(cControl, ComboBox).FlatStyle = FlatStyle.Standard
                    CType(cControl, ComboBox).BackColor = SystemColors.Window
                ElseIf TypeOf cControl Is TextBox Then
                    CType(cControl, TextBox).BorderStyle = BorderStyle.Fixed3D
                    CType(cControl, TextBox).BackColor = SystemColors.Window


                End If

            Next
        End If
    End Sub

    Private Sub AlertCenter_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If Not IsNothing(WindowPointers.ChatRoom) Then WindowPointers.ChatRoom.tbToSend.Focus()
    End Sub

    Private Sub AlertCenter_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing


    End Sub

    Private Sub AlertCenter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterForm(Me, WindowPointers.ChatRoom)
    End Sub

    Private Sub bnCancel_Click(sender As Object, e As EventArgs) Handles bnCancel.Click
        Me.Close()
    End Sub

    Private Sub bnOkay_Click(sender As Object, e As EventArgs) Handles bnOkay.Click
        Dim strLanguage As String = Convert.ToInt32(cbLanguage.Checked).ToString
        Dim strScrolling As String = Convert.ToInt32(cbScrolling.Checked).ToString
        Dim strHarrassment As String = Convert.ToInt32(cbHarrassment.Checked).ToString
        Dim strONick As String = Convert.ToInt32(cbOffensiveNick.Checked).ToString
        Dim strImpersonating As String = Convert.ToInt32(cbImpersonating.Checked).ToString
        Dim strInsults As String = Convert.ToInt32(cbInsults.Checked).ToString
        Dim strDisruptive As String = Convert.ToInt32(cbDisruptive.Checked).ToString
        Dim strRepugnant As String = Convert.ToInt32(cbRepugnant.Checked).ToString
        Dim strORoom As String = Convert.ToInt32(cbOffensiveRoom.Checked).ToString
        Dim strIllegal As String = Convert.ToInt32(cbIllegal.Checked).ToString
        Dim strOther As String = "0"
        If cbOther.Checked = True And tbOther.Text <> "" Then strOther = tbOther.Text
        Dim strBinary As String = strLanguage + strScrolling + strHarrassment + strONick + strImpersonating + strInsults + strDisruptive + strORoom + strIllegal
        ' Convert binary to base10
        Dim intMask As Integer = Convert.ToInt32(strBinary, 2)
        Dim strTrimArray(1) As Char
        strTrimArray(0) = vbNewLine
        tbAlertNicks.Text = tbAlertNicks.Text.Replace(vbNewLine + vbNewLine, "") ' Remove blank lines
        tbAlertNicks.Text = tbAlertNicks.Text.TrimEnd(strTrimArray).Trim 'Trim trailing lines
        Dim strNickArray() As String = tbAlertNicks.Lines
        Dim strNickString As String = Nothing
        If Len(tbAlertNicks.Text) > 0 Then
            For intCnt = 0 To (strNickArray.GetUpperBound(0) - 1)
                If strNickArray(intCnt) <> "" Then strNickString = strNickString + strNickArray(intCnt) + ","
            Next
            strNickString = strNickString + strNickArray(strNickArray.GetUpperBound(0)) 'No Comma following last entry

            TheMainWindow.DoSendToServer("USER" + DELIMITER + "ALERT" + DELIMITER + intMask.ToString + DELIMITER + strNickString + DELIMITER + strOther)
        Else
            MsgBox("You must enter one or more nicknames before using this feature.")
        End If

    End Sub
End Class