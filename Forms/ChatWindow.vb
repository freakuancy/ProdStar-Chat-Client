Imports System
Imports System.Threading
Imports System.IO
Imports System.Environment
Imports System.Drawing.Text
Imports System.Text.RegularExpressions
Imports System.Windows.Forms


Public Class frmChatWindow

    Delegate Sub CloseCallback()
    Delegate Sub UpdateChatCallback(Nick As String, Msg As String)
    Delegate Sub UpdateListCallback(strNames As List(Of String), strArg As String)
    Delegate Sub UpdateTextCallback(strText As String)
    Delegate Sub UpdateFontCallBack(UseBold As Boolean)

    Dim BM As New Bitmap(My.Computer.Screen.Bounds.Width, My.Computer.Screen.Bounds.Height)
    Dim CurrentSession As UserSession
    Dim TheMainWindow As MainWindow
    Dim strLogFile As String

    '// Keeping this local so garbage collection cleans it up after
    '// Form is closed
    Dim PausedQueue As New ArrayList
    Dim img As Bitmap
    Dim toImg As Bitmap



    Public Sub New(mainwindow As MainWindow, ThisSession As UserSession)
        CurrentSession = ThisSession
        TheMainWindow = mainwindow
        InitializeComponent()
        If My.Settings.ModernStyle = True Then
            Me.BackColor = DefaultBackColor
            For Each cControl In Me.Controls

                If TypeOf cControl Is ComboBox Then
                    CType(cControl, ComboBox).FlatStyle = FlatStyle.Standard
                    CType(cControl, ComboBox).BackColor = SystemColors.Window
                Else
                    CType(cControl, Control).BackColor = DefaultBackColor
                    CType(cControl, Control).ForeColor = DefaultForeColor
                    CType(cControl, Control).Font = DefaultFont
                End If
            Next

            lbChatting.BorderStyle = BorderStyle.Fixed3D
            lbChatting.BackColor = Me.BackColor
            tbToSend.BorderStyle = BorderStyle.Fixed3D
            tbToSend.BackColor = Me.BackColor
            Label2.BorderStyle = BorderStyle.Fixed3D
            tbChatText.BorderStyle = BorderStyle.Fixed3D
            Panel1.BorderStyle = BorderStyle.None
            Panel2.BorderStyle = BorderStyle.None
        End If
        tbChatText.BackColor = My.Settings.ChatColor
        Panel1.BackColor = My.Settings.ChatColor
        GetDesktop()
        DrawTrans()
    End Sub
    Private Sub GetDesktop()
        Dim desktop_win As Int32 = FindWindowByClass("Progman", IntPtr.Zero)
        Dim desktop_dc As Int32 = GetDC(desktop_win)
        Dim desktop_bounds As Rectangle = Screen.GetBounds(New Point(1, 1))
        Dim desktop_wid As Int32 = desktop_bounds.Width
        Dim desktop_hgt As Int32 = desktop_bounds.Height
        Dim bm_gr As Graphics = Graphics.FromImage(BM)
        Dim bm_hdc As IntPtr = bm_gr.GetHdc
        StretchBlt(bm_hdc, 0, 0, desktop_wid, desktop_hgt, desktop_dc, 0, 0, desktop_wid, desktop_hgt, TernaryRasterOperations.SRCCOPY)
        bm_gr.ReleaseHdc(bm_hdc)
        ReleaseDC(desktop_win, desktop_dc)
    End Sub
    Private Sub bnSetup_Click(sender As Object, e As EventArgs) Handles bnSetup.Click
        Dim frmSetupOptions As New SetupOptions(TheMainWindow, CurrentSession)
        WindowPointers.SetupOptions = frmSetupOptions
        WindowPointers.SetupOptions.Show(Me)
    End Sub

    Private Sub bnSave_Click(sender As Object, e As EventArgs) Handles bnSave.Click
        Dim sDialog As New SaveFileDialog
        With sDialog
            .DefaultExt = ".txt"
            .FileName = Regex.Replace(CurrentSession.CurrentChatRoom, "[^\w\.@-]", "") ' Clean filenames
            .Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
            .FilterIndex = 0
            .OverwritePrompt = True
            .InitialDirectory = GetFolderPath(SpecialFolder.MyDocuments)
        End With
        If sDialog.ShowDialog() = DialogResult.OK Then
            File.WriteAllText(sDialog.FileName, tbChatText.Text.Replace(Chr(10), Environment.NewLine))
        End If
        tbToSend.Focus()
    End Sub

    Private Sub bnLogging_Click(sender As Object, e As EventArgs) Handles bnLogging.Click
        Select Case CurrentSession.LogChat
            Case True : bnLogging.Text = "Logging Off"
                CurrentSession.LogChat = False
            Case False
                Dim sDialog As New SaveFileDialog
                With sDialog
                    .DefaultExt = ".txt"
                    .FileName = Regex.Replace(CurrentSession.CurrentChatRoom, "[^\w\.@-]", "") ' Clean Filenames
                    .Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
                    .FilterIndex = 0
                    .OverwritePrompt = True
                    .InitialDirectory = PRODDIR
                End With
                If sDialog.ShowDialog() = DialogResult.OK Then
                    Using LogFile As StreamWriter = File.AppendText(sDialog.FileName)
                        LogFile.WriteLine("Session Begin: " + DateAndTime.Now)
                    End Using
                    strLogFile = sDialog.FileName
                    CurrentSession.LogChat = True
                    bnLogging.Text = "Logging On"
                End If
        End Select
        tbToSend.Focus()
    End Sub

    Private Sub bnClear_Click(sender As Object, e As EventArgs) Handles bnClear.Click
        tbToSend.Clear()
        If Not IsNothing(WindowPointers.ChatRoom) Then tbToSend.Focus()
    End Sub

    Private Sub bnClose_Click(sender As Object, e As EventArgs) Handles bnClose.Click
        Me.Close()
    End Sub

    Private Sub bnExclude_Click(sender As Object, e As EventArgs) Handles bnExclude.Click
        ' // Did we select anything?
        If Not (IsNothing(lbChatting.SelectedItem)) Then
            Dim strExNick As String = lbChatting.SelectedItem.ToString.Replace(" [SILENT]", "")
            Dim frmExclude As New Exclude(TheMainWindow, CurrentSession, strExNick)
            WindowPointers.Exclude = frmExclude
            WindowPointers.Exclude.ShowDialog(Me)
        Else
            ShowChatMessage(TheMainWindow, CurrentSession, "ProdStar® Service - ERROR", "You must first select a chat name before using this feature.")
        End If
    End Sub

    Private Sub bnInstantMsg_Click(sender As Object, e As EventArgs) Handles bnInstantMsg.Click
        ' // Did we select anything?
        Dim hwndParent As IWin32Window
        If My.Settings.ModernStyle = True Then
            hwndParent = TheMainWindow
        Else
            hwndParent = Me
        End If
        If Not (IsNothing(lbChatting.SelectedItem)) Then
            If Not (Application.OpenForms().OfType(Of IMCenter).Any) Then
                Dim NewIM As New IMCenter(TheMainWindow, CurrentSession)
                WindowPointers.InstantMessageCenter = NewIM
                Me.Invoke(Sub() WindowPointers.InstantMessageCenter.Show(hwndParent))
            Else
                WindowPointers.InstantMessageCenter.Show()
                WindowPointers.InstantMessageCenter.BringToFront()
            End If
            WindowPointers.InstantMessageCenter.SetSendTo(lbChatting.SelectedItem.ToString.Replace(" [SILENT]", ""))
        Else
            ShowChatMessage(TheMainWindow, CurrentSession, "ProdStar® Service - ERROR", "You must first select a chat name before using this feature.")
        End If
    End Sub

    Private Sub bnInfo_Click(sender As Object, e As EventArgs) Handles bnInfo.Click
        ' // Did we select anything?
        If Not (IsNothing(lbChatting.SelectedItem)) Then
            Dim MemberInfo As New MemberInformation(TheMainWindow, CurrentSession, lbChatting.SelectedItem.ToString.Replace(" [SILENT]", ""))
            WindowPointers.MemberInformation = MemberInfo
            Me.Invoke(Sub() WindowPointers.MemberInformation.Show(Me))
        Else
            ShowChatMessage(TheMainWindow, CurrentSession, "ProdStar® Service - ERROR", "You must first select a chat name before using this feature.")
        End If


    End Sub


    Private Sub frmChatWindow_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        TheMainWindow.Invoke(Sub() TheMainWindow.DoSendToServer("CHAT" + DELIMITER + "PART" + DELIMITER + CurrentSession.CurrentArea + DELIMITER + "0" + DELIMITER + CurrentSession.CurrentChatRoom))
        CurrentSession.CurrentChatRoom = Nothing
        CurrentSession.CurrentArea = Nothing
        If Not IsNothing(CurrentSession.RoomExcludeList) Then CurrentSession.RoomExcludeList.Clear()
        WindowPointers.ChatLaunch.Enabled = True
        ResumeDrawing(WindowPointers.ChatLaunch, True)

    End Sub



    Private Sub frmChatWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterForm(Me, TheMainWindow)
        tbChatText.SelectionTabs = New Integer() {1, 144, 244, 344, 400}
        If My.Settings.ModernStyle = False Then WindowPointers.ChatLaunch.Enabled = False

        Dim InstalledFonts As New InstalledFontCollection
        Dim fontfamilies() As FontFamily = InstalledFonts.Families()
        For Each fontFamily As FontFamily In fontfamilies
            cboFonts.Items.Add(fontFamily.Name)
        Next
        tbChatText.Font = My.Settings.ChatFont
        tbChatText.ForeColor = My.Settings.FontColor
        If My.Settings.ClassicChat = False Then
            Panel1.Height = 330
            tbChatText.Height = 330
            tbToSend.Font = My.Settings.UserFont
            tbToSend.ForeColor = My.Settings.UserColor
            btnBold.Visible = True
            btnItalic.Visible = True
            btnUnder.Visible = True
            cboFonts.Visible = True
            Label2.Visible = True
            cboSize.Visible = True
            cboSize.Text = My.Settings.UserFont.Size.ToString
            cboFonts.Text = My.Settings.UserFont.Name.ToString
            Label2.ForeColor = My.Settings.UserColor
            cboSize.Text = My.Settings.UserFont.Size.ToString
        Else
            Panel1.Height = 353
            tbChatText.Height = 353
            btnBold.Visible = False
            btnItalic.Visible = False
            btnUnder.Visible = False
            cboFonts.Visible = False
            Label2.Visible = False
            cboSize.Visible = False
            tbToSend.Font = My.Settings.ChatFont
            tbToSend.ForeColor = My.Settings.FontColor
        End If

        '// Administration?
        If CurrentSession.AccessLevel >= 2 And CurrentSession.AdministratorFlagOn Then
            '// Show close room button
            bnAdminMsg.Visible = True
        Else
            bnAdminMsg.Visible = False
        End If

        tbToSend.Focus()

    End Sub
    Public Sub UpdateTitle(strText As String)
        If Me.InvokeRequired Then
            Dim d As New UpdateTextCallback(AddressOf UpdateTitle)
            Me.Invoke(d, New Object() {strText})
        Else
            Me.Text = strText
        End If
    End Sub
    Public Sub OverwriteChat(strText As String)
        If Me.InvokeRequired Then
            Dim d As New UpdateTextCallback(AddressOf OverwriteChat)
            Me.Invoke(d, New Object() {strText})
        Else
            tbChatText.Text = strText
        End If
    End Sub
 
    Public Sub UpdateList(strNames As List(Of String), strArg As String)
        If Me.tbChatText.InvokeRequired Then
            Dim d As New UpdateListCallback(AddressOf UpdateList)
            Me.Invoke(d, New Object() {strNames, strArg})
        Else
            Select Case strArg
                Case "ADD"
                    'lbChatting.Items.Clear()
                    For a = 0 To strNames.Count - 1
                        lbChatting.Items.Add(strNames(a))
                    Next
                    If lbChatting.SelectedIndex = -1 Then
                        lbChatting.SelectedIndex = 0
                    End If
                Case "REM"
                    For a = 0 To strNames.Count - 1
                        lbChatting.Items.Remove(strNames(a))
                    Next
                    If lbChatting.SelectedIndex = -1 Then
                        lbChatting.SelectedIndex = 0
                    End If
                Case "CLR"
                    lbChatting.Items.Clear()
            End Select

            Label1.Text = "Chatting: " + lbChatting.Items.Count.ToString
        End If
    End Sub

    Public Sub UpdateChat(Nick As String, Msg As String)
        If Me.tbChatText.InvokeRequired Then
            Dim d As New UpdateChatCallback(AddressOf UpdateChat)
            Me.Invoke(d, New Object() {Nick, Msg})
        Else

            Dim oFont As Font
            Dim pSound As String
            Dim strStripped As String
            Dim NickLen As Integer = Nick.Length + 2
            Dim strConstructed As String
            If (Nick = "SYSTEM Greeter" And InStr(Msg, "left")) And CurrentSession.NotifyRoomDeparture = False Then Exit Sub
            If (Nick = "SYSTEM Greeter" And InStr(Msg, "joined")) And CurrentSession.NotifyRoomEntry = False Then Exit Sub
            If Not IsNothing(CurrentSession.RoomExcludeList) Then
                If CurrentSession.RoomExcludeList.Contains(Nick) Then Exit Sub
            End If
            If Not IsNothing(CurrentSession.GlobalExcludeList) Then
                If CurrentSession.GlobalExcludeList.Contains(Nick) Then Exit Sub
            End If

            Dim tmpChatBox As New HtmlRichText.HtmlRichTextBox
            tmpChatBox.SelectionTabs = New Integer() {1, 144, 244, 344, 400}
            If Msg = "" Then Msg = "<p> </p>"
            tmpChatBox.AddHTML(Msg)
            Nick = Nick + ":" + vbTab
            If Not IsNothing(Msg) Then
                If bnPause.Text = "&Pause Display" Then
                    With tmpChatBox
                        If My.Settings.ClassicChat = False Then
                            If Nick.Contains("SYSTEM Greeter") Then
                                .ForeColor = My.Settings.FontColor
                                .Font = My.Settings.ChatFont
                            Else
                                For a = 0 To .TextLength - 1
                                    .SelectionStart = 0 + a
                                    .SelectionLength = 1
                                    If My.Settings.ReverseColor = True Then
                                        If .SelectionColor = Color.Black Then
                                            .SelectionColor = Color.White
                                        Else
                                            .SelectionColor = ControlPaint.LightLight(.SelectionColor)
                                        End If
                                    End If
                                    If Not IsNothing(.SelectionFont) Then
                                        If .SelectionFont.SizeInPoints < 8.25 Then
                                            oFont = New Font(.SelectionFont.Name, 8.25, .SelectionFont.Style)
                                            .SelectionFont = oFont
                                        End If
                                    End If
                                Next a

                            End If
                            strConstructed = .Rtf
                        Else
                            .ForeColor = My.Settings.FontColor
                            .Font = My.Settings.ChatFont
                            strConstructed = .Rtf
                        End If
                        .Clear()
                        .AddHTML(Nick)
                        .Font = My.Settings.ChatFont
                        .ForeColor = My.Settings.FontColor
                        .SelectionStart = NickLen
                        .SelectedRtf = strConstructed
                        .SelectionStart = NickLen
                        .SelectionLength = tmpChatBox.TextLength - NickLen
                        .SelectionHangingIndent = 144
                        .SelectionStart = 0
                        .SelectionLength = strConstructed.Length + NickLen
                        tbChatText.SelectionStart = tbChatText.TextLength
                        tbChatText.SelectedRtf = .SelectedRtf
                        If CurrentSession.DoublespaceChatText = True Then tbChatText.AppendText(vbNewLine)
                    End With
                    SendMessage(tbChatText.Handle, WM_VSCROLL, SB_PAGEBOTTOM, IntPtr.Zero)
                    If CurrentSession.LogChat = True Then '//Logging on
                        Using Logfile As StreamWriter = File.AppendText(strLogFile)
                            Logfile.WriteLine("[" + DateAndTime.Now.ToShortTimeString + "] " + strConstructed)
                        End Using
                    End If
                    If InStr(Msg.ToLower, "{s") Then '// Sounds
                        If CurrentSession.AllowSounds = True Then
                            '//Dim strMatch As Match = Regex.Match(strStripped, "(?<={s \b)( *?)(\w*)", RegexOptions.IgnoreCase) 'omnomnom
                            Dim strMatch As Match = Regex.Match(Msg, "(?<={s \b)( *?)(\w*)", RegexOptions.IgnoreCase) 'omnomnom
                            pSound = strMatch.Value + ".wav"
                            PlaySound(pSound)
                        End If
                    End If

                Else '// Display Paused
                    Dim Queued As New QueuedMsg
                    With Queued
                        .Nick = Nick
                        .Msg = Msg
                    End With
                    If PausedQueue.Count <= 1024 Then '// Buffer up to 200 lines 
                        PausedQueue.Add(Queued)
                    Else '// Shift array to keep most recent 200 only
                        Dim tmpQueue As New ArrayList
                        PausedQueue.RemoveAt(0)
                        For a = 1 To PausedQueue.Count
                            tmpQueue.Insert(a - 1, PausedQueue(a - 1))  ' Preventing OutOfRangeException
                        Next a
                        PausedQueue.Clear()
                        PausedQueue = tmpQueue
                        PausedQueue.Add(Queued)
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub bnSend_Click(sender As Object, e As EventArgs) Handles bnSend.Click
        '// Ugly, will rewrite
        Dim htmlText As String
        If tbToSend.Text.Trim <> "" Then
            If My.Settings.ReverseColor = True And My.Settings.ClassicChat = False Then
                SuspendDrawing(tbToSend)
                For a = 0 To tbToSend.TextLength
                    tbToSend.SelectionStart = a
                    tbToSend.SelectionLength = 1
                    If tbToSend.SelectionColor = Color.White Then tbToSend.SelectionColor = Color.Black
                Next
                ResumeDrawing(tbToSend, False)
            End If
            If My.Settings.ClassicChat = True Then
                htmlText = tbToSend.Text
            Else
                htmlText = tbToSend.GetHTML(True, False)

            End If
            If htmlText.Length > 1024 Then
                ShowChatMessage(TheMainWindow, CurrentSession, "ProdStar® CHAT", "The message you have entered is too long or too complex.")
            Else
                '// Replace new line characters
                htmlText = htmlText.Replace(vbCr, "").Replace(vbLf, "")
                TheMainWindow.DoSendToServer("CHAT" + DELIMITER + "CHAT" + DELIMITER + "0" + DELIMITER + "0" + DELIMITER + htmlText)
                tbToSend.Clear()
            End If
        End If
    End Sub

    Private Sub bnChange_Click(sender As Object, e As EventArgs) Handles bnChange.Click
        Dim frmArea As New AreaRoomSelect(TheMainWindow, CurrentSession)
        WindowPointers.AreaSelect = frmArea
        Me.Invoke(Sub() WindowPointers.AreaSelect.Show(Me))
    End Sub

    Private Sub tbChatText_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbChatText.KeyPress
        e.Handled = True
    End Sub

    Private Sub frmChatWindow_Move(sender As Object, e As EventArgs) Handles Me.Move
        DrawTrans()
    End Sub
    Private Sub frmChatWindow_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            For Each frm In My.Application.OpenForms
                On Error Resume Next
                frm.WindowState = FormWindowState.Minimized
            Next
            CurrentSession.ClientHidden = True
        End If
    End Sub

    Private Sub lbChatting_DoubleClick(sender As Object, e As EventArgs)
        Dim MemberInfo As New MemberInformation(TheMainWindow, CurrentSession, lbChatting.SelectedItem.ToString)
        WindowPointers.MemberInformation = MemberInfo
        Me.Invoke(Sub() WindowPointers.MemberInformation.Show(Me))
    End Sub

    Private Sub bnPause_Click(sender As Object, e As EventArgs) Handles bnPause.Click
        Select Case bnPause.Text
            Case "&Pause Display" : bnPause.Text = "&Resume Display"
            Case "&Resume Display" : bnPause.Text = "&Pause Display"
                Dim Queued As New QueuedMsg
                For a = 0 To PausedQueue.Count - 1
                    Queued = PausedQueue(a)
                    UpdateChat(Queued.Nick, Queued.Msg)
                Next
                PausedQueue.Clear()
        End Select
        If Not IsNothing(WindowPointers.ChatRoom) Then tbToSend.Focus()
    End Sub

    Private Sub frmChatWindow_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        If Me.WindowState = FormWindowState.Normal Then
            tbChatText.ScrollToCaret()
            tbToSend.Focus()
            DrawTrans()
        End If
    End Sub

    Private Sub bnAlert_Click(sender As Object, e As EventArgs) Handles bnAlert.Click
        Dim frmAlert As New AlertCenter(TheMainWindow, CurrentSession)
        WindowPointers.AlertCenter = frmAlert
        TheMainWindow.Invoke(Sub() WindowPointers.AlertCenter.Show(Me))

    End Sub

    Private Sub bnGuidelines_Click(sender As Object, e As EventArgs) Handles bnGuidelines.Click
        MsgBox("Not Yet Implemented")
        If Not IsNothing(WindowPointers.ChatRoom) Then tbToSend.Focus()
    End Sub
    Private Sub cboFonts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFonts.SelectedIndexChanged
        Dim cFont As Font
        Dim cSize As Integer
        If cboSize.Text = "" Then
            cSize = My.Settings.UserFont.Size
        Else
            cSize = CInt(cboSize.Text)
        End If
        cFont = New Font(cboFonts.Text, cSize, tbToSend.SelectionFont.Style)
        tbToSend.SelectionFont = cFont
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Dim cColor As New ColorDialog
        Dim RevColor As Color
        With cColor
            .SolidColorOnly = True
            .AnyColor = False
            .AllowFullOpen = False
            .Color = tbToSend.SelectionColor
            .ShowDialog()

            tbToSend.ForeColor = .Color

            Label2.ForeColor = .Color
        End With
        If Not IsNothing(WindowPointers.ChatRoom) Then tbToSend.Focus()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnItalic.Click
        If tbToSend.SelectionFont.Italic = True Then
            SelItalic(tbToSend) = False
            btnItalic.ForeColor = DefaultForeColor
        Else
            SelItalic(tbToSend) = True
            btnItalic.ForeColor = Color.Purple
        End If
        If Not IsNothing(WindowPointers.ChatRoom) Then tbToSend.Focus()
    End Sub

    Private Sub tbToSend_SelectionChanged(sender As Object, e As EventArgs) Handles tbToSend.SelectionChanged

        cboFonts.Text = tbToSend.SelectionFont.Name.ToString
        cboSize.Text = tbToSend.SelectionFont.Size
        Label2.ForeColor = tbToSend.SelectionColor
        If tbToSend.SelectionFont.Bold Then
            btnBold.ForeColor = Color.Purple
        Else
            btnBold.ForeColor = DefaultForeColor
        End If
        If tbToSend.SelectionFont.Underline Then
            btnUnder.ForeColor = Color.Purple
        Else
            btnUnder.ForeColor = DefaultForeColor
        End If
        If tbToSend.SelectionFont.Italic Then
            btnItalic.ForeColor = Color.Purple
        Else
            btnItalic.ForeColor = DefaultForeColor
        End If
        If Not IsNothing(WindowPointers.ChatRoom) Then tbToSend.Focus()
    End Sub

    Public Property SelBold(ByVal oRTB As HtmlRichText.HtmlRichTextBox) As Boolean
        Get
            Return Style(oRTB, FontStyle.Bold)
        End Get
        Set(ByVal value As Boolean)
            Style(oRTB, FontStyle.Bold) = value
        End Set
    End Property

    Public Property SelItalic(ByVal oRTB As HtmlRichText.HtmlRichTextBox) As Boolean
        Get
            Return Style(oRTB, FontStyle.Italic)
        End Get
        Set(ByVal value As Boolean)
            Style(oRTB, FontStyle.Italic) = value
        End Set
    End Property

    Public Property SelUnderline(ByVal oRTB As HtmlRichText.HtmlRichTextBox) As Boolean
        Get
            Return Style(oRTB, FontStyle.Underline)
        End Get
        Set(ByVal value As Boolean)
            Style(oRTB, FontStyle.Underline) = value
        End Set
    End Property

    Public Property SelStrikeout(ByVal oRTB As HtmlRichText.HtmlRichTextBox) As Boolean
        Get
            Return Style(oRTB, FontStyle.Strikeout)
        End Get
        Set(ByVal value As Boolean)
            Style(oRTB, FontStyle.Strikeout) = value
        End Set
    End Property

    Private Property Style(ByVal oRTB As HtmlRichText.HtmlRichTextBox, _
    ByVal eStyle As FontStyle) As Boolean
        Get
            If Not oRTB.SelectionFont Is Nothing Then
                If oRTB.SelectionLength <> 0 Then
                    Return IsBitOn(CByte(oRTB.SelectionFont.Style), CByte(eStyle))
                Else
                    Return IsBitOn(CByte(oRTB.Font.Style), CByte(eStyle))
                End If
            Else
                Return False
            End If
        End Get
        Set(ByVal value As Boolean)
            If value Then
                SetFStyle(oRTB, eStyle)
            Else
                UnsetStyle(oRTB, eStyle)
            End If
        End Set
    End Property

    Private Function IsBitOn(ByVal expression1 As Byte, _
    ByVal expression2 As Byte) As Boolean
        Return CBool(expression1 And expression2)
    End Function

    Private Sub SetFStyle(ByVal oRTB As HtmlRichText.HtmlRichTextBox, ByVal eStyle As FontStyle)
        Dim currentFont As System.Drawing.Font
        Dim newFontStyle As System.Drawing.FontStyle
        If oRTB.SelectionLength <> 0 Then
            currentFont = oRTB.SelectionFont
        Else
            currentFont = oRTB.Font
        End If
        newFontStyle = currentFont.Style Or eStyle

        oRTB.SelectionFont = New Font(currentFont.FontFamily, _
                                      currentFont.Size, _
                                      newFontStyle)
    End Sub

    Private Sub UnsetStyle(ByVal oRTB As HtmlRichText.HtmlRichTextBox, ByVal eStyle As FontStyle)
        Dim currentFont As System.Drawing.Font
        Dim newFontStyle As System.Drawing.FontStyle
        If oRTB.SelectionLength <> 0 Then
            currentFont = oRTB.SelectionFont
        Else
            currentFont = oRTB.Font
        End If

        newFontStyle = currentFont.Style Xor eStyle

        oRTB.SelectionFont = New Font(currentFont.FontFamily, _
                                      currentFont.Size, _
                                      newFontStyle)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnUnder.Click
        If tbToSend.SelectionFont.Underline = True Then
            SelUnderline(tbToSend) = False
            btnUnder.ForeColor = DefaultForeColor
        Else
            SelUnderline(tbToSend) = True
            btnUnder.ForeColor = Color.Purple
        End If
        If Not IsNothing(WindowPointers.ChatRoom) Then tbToSend.Focus()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnBold.Click
        If tbToSend.SelectionFont.Bold = True Then
            SelBold(tbToSend) = False
            btnBold.ForeColor = DefaultForeColor
        Else
            SelBold(tbToSend) = True
            btnBold.ForeColor = Color.Purple
        End If
        If Not IsNothing(WindowPointers.ChatRoom) Then tbToSend.Focus()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSize.SelectedIndexChanged
        Dim cFont As Font
        cFont = New Font(tbToSend.SelectionFont.Name, CInt(cboSize.Text), tbToSend.SelectionFont.Style)
        tbToSend.SelectionFont = cFont
    End Sub


    Private Sub tbChatText_VScroll(sender As Object, e As EventArgs) Handles tbChatText.VScroll
        ResumeDrawing(tbChatText, True)
        ResumeDrawing(Panel1, True)
    End Sub
    Public Sub DrawTrans()
        If My.Settings.Opacity >= 0 Then
            Dim Trans As Single = My.Settings.Opacity * 0.1
            Dim arrMatrix As Single()() = {
                New Single() {1, 0, 0, 0, 0},
                New Single() {0, 1, 0, 0, 0},
                New Single() {0, 0, 1, 0, 0},
                New Single() {0, 0, 0, Trans, 0},
                New Single() {0, 0, 0, 0, 1}}
            Dim cMatrix As New System.Drawing.Imaging.ColorMatrix(arrMatrix)
            Dim cVals As New System.Drawing.Imaging.ImageAttributes
            Dim crop As Bitmap = New Bitmap(Panel1.Width, Panel1.Height)
            Dim bmcrop As Graphics = Graphics.FromImage(crop)
            Dim CropRect As New Rectangle(PointToScreen(Panel1.Location), Panel1.Size)
            Dim DestRect As New Rectangle(0, 0, Panel1.Size.Width, Panel1.Size.Height)
            cVals.SetColorMatrix(cMatrix, Imaging.ColorMatrixFlag.Default, Imaging.ColorAdjustType.Bitmap)
            bmcrop.DrawImage(BM, DestRect, CropRect.X, CropRect.Y, CropRect.Width, CropRect.Height, GraphicsUnit.Pixel)
            bmcrop.Dispose()
            Using dg As Graphics = Graphics.FromImage(crop)
                dg.CompositingMode = Drawing2D.CompositingMode.SourceCopy
                dg.CompositingQuality = Drawing2D.CompositingQuality.HighQuality
                dg.DrawImage(crop, DestRect, 0, 0, DestRect.Width, DestRect.Height, GraphicsUnit.Pixel, cVals)
                dg.Dispose()
            End Using
            Panel1.BackgroundImage = crop
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)

    End Sub

    Private Sub bnAdminMsg_Click(sender As Object, e As EventArgs) Handles bnAdminMsg.Click
        Dim frmAdminMsg As New AdminMessage(TheMainWindow, CurrentSession)
        WindowPointers.AdminMessage = frmAdminMsg
        Me.Invoke(Sub() WindowPointers.AdminMessage.Show(Me))
    End Sub
End Class