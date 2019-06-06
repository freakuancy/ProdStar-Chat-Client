Imports System.Runtime.InteropServices
Imports System.Text.RegularExpressions
Imports System.Environment
Imports System.IO
Public Module Globals

    '// Invokes ---------------------------/>
    <DllImport("user32.dll", ExactSpelling:=True, CharSet:=CharSet.Auto)> _
    Public Function GetParent(ByVal hWnd As IntPtr) As IntPtr
    End Function
    <DllImport("user32.dll")> _
    Public Function SendMessage(ByVal hWnd As IntPtr, ByVal wMsg As Int32, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr
    End Function
    <DllImport("user32.dll")> _
    Public Function PaintDesktop(ByVal hdc As IntPtr) As IntPtr
    End Function
    <DllImport("user32.dll")> _
    Public Function GetDC(ByVal hwnd As Integer) As Integer
    End Function
    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)> _
    Public Function PostMessage(ByVal hWnd As IntPtr, ByVal Msg As UInteger, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As Boolean
    End Function
    <DllImport("user32.dll", SetLastError:=False)> _
    Public Function GetDesktopWindow() As IntPtr
    End Function
    <DllImport("GDI32.DLL")> _
    Public Function BitBlt(ByVal hDestDC As IntPtr, ByVal x As Integer, ByVal y As Integer, ByVal nWidth As Integer, ByVal nHeight As Integer, ByVal hSrcDC As IntPtr, ByVal xSrc As Integer, ByVal ySrc As Integer, ByVal dwRop As Integer) As Boolean
    End Function
    <DllImport("gdi32.dll")> _
    Public Function StretchBlt(hdcDest As IntPtr, nXOriginDest As Integer, nYOriginDest As Integer, nWidthDest As Integer, nHeightDest As Integer, hdcSrc As IntPtr, nXOriginSrc As Integer, nYOriginSrc As Integer, nWidthSrc As Integer, nHeightSrc As Integer, dwRop As TernaryRasterOperations) As Boolean
    End Function
    <DllImport("user32.dll")> _
    Public Function ReleaseDC(ByVal hWnd As IntPtr, ByVal hDC As IntPtr) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function
    <DllImport("user32.dll", EntryPoint:="FindWindow", SetLastError:=True, CharSet:=CharSet.Auto)> _
    Public Function FindWindowByClass(ByVal lpClassName As String, ByVal zero As IntPtr) As IntPtr
    End Function

    Public Const GWL_EXSTYLE = (-20)
    Public Const WS_EX_LAYERED = &H80000
    Public Const LWA_ALPHA = &H2&
    '// Datums ---------------------------/>
    Enum TernaryRasterOperations As UInteger
        SRCCOPY = &HCC0020
        SRCPAINT = &HEE0086
        SRCAND = &H8800C6
        SRCINVERT = &H660046
        SRCERASE = &H440328
        NOTSRCCOPY = &H330008
        NOTSRCERASE = &H1100A6
        MERGECOPY = &HC000CA
        MERGEPAINT = &HBB0226
        PATCOPY = &HF00021
        PATPAINT = &HFB0A09
        PATINVERT = &H5A0049
        DSTINVERT = &H550009
        BLACKNESS = &H42
        WHITENESS = &HFF0062
        CAPTUREBLT = &H40000000
    End Enum
    Public Enum WindowLongFlags As Integer
        GWL_EXSTYLE = -20
        GWLP_HINSTANCE = -6
        GWLP_HWNDPARENT = -8
        GWL_ID = -12
        GWL_STYLE = -16
        GWL_USERDATA = -21
        GWL_WNDPROC = -4
        DWLP_USER = &H8
        DWLP_MSGRESULT = &H0
        DWLP_DLGPROC = &H4
    End Enum
    '// WIN32
    Public Const WM_PAINT = 15
    Public Const WM_HSCROLL = 276
    Public Const WM_LBUTTONDOWN = 513
    Public Const WM_MOUSEMOVE = 512
    Public Const WM_VSCROLL = 277
    Public Const WM_RBUTTONDOWN = 516
    Public Const WM_LBUTTONDBLCLK = 515
    Public Const WM_LBUTTONUP = 514
    Public Const WM_PRINTCLIENT = 792
    Public Const WM_MOUSELEAVE = 675
    Public Const PRF_CHECKVISIBLE As Long = 1
    Public Const PRF_NONCLIENT As Long = 2
    Public Const PRF_CLIENT As Long = 4
    Public Const PRF_ERASEBKGND As Long = 8
    Public Const PRF_CHILDREN As Long = 10
    Public Const PRF_OWNED As Long = 20
    Public Const WM_USER = &H400
    Public Const EM_POSFROMCHAR = (WM_USER + 38)
    Public Const WM_PRINT = 791
    Public Const SB_PAGEBOTTOM As Integer = 7
    '// App
    Public Const VERBOSE As Boolean = True        '//Verbose Logging for BETA
    Public Const VERSION As String = "1.1"     '//VERSION for Version Check
    Public Const DELIMITER As String = "::"       '// Setting aside to easily change delimiter if needed
    Public PRODDIR As String = GetFolderPath(SpecialFolder.MyDocuments) + "\ProdStar Communicate"
    Private Const WM_SETREDRAW As Integer = 11
    Public CancelCon As Boolean                   '// Cancel Connection flag. Moved from UserSession
    Public Connector As Threading.Thread          '//Connector thread, publically accessible
    Public Structure QueuedMsg                    '//MsgQueue struct for messages that have not been viewed yet
        Dim Msg As String
        Dim Nick As String
        Dim ID As String
        Dim ByID As Boolean
    End Structure

    '// Methods ---------------------------/>
    Public Sub CenterForm(ByVal frm As Form, Optional ByVal parent As Form = Nothing)
        Dim r As Rectangle
        If parent IsNot Nothing Then
            r = parent.RectangleToScreen(parent.ClientRectangle)
        Else
            r = Screen.FromPoint(frm.Location).WorkingArea
        End If

        Dim x = r.Left + (r.Width - frm.Width) \ 2
        Dim y = r.Top + (r.Height - frm.Height) \ 2
        frm.Location = New Point(x, y)
    End Sub
    Public Sub SuspendDrawing(ByVal Target As Control)
        'Eliminating chat and IM flicker during control update
        'without relying on double-buffering
        SendMessage(Target.Handle, WM_SETREDRAW, 0, 0)
    End Sub

    Public Sub ResumeDrawing(ByVal Target As Control, ByVal Redraw As Boolean)
        If Not IsNothing(Target.Handle) Then SendMessage(Target.Handle, WM_SETREDRAW, 1, 0)
        If Redraw Then
            Target.Refresh()
        End If
    End Sub
    Public Sub MoveForm(frm As Form)
        Dim rect As Rectangle
        rect = WindowPointers.MainWindow.RectangleToScreen(WindowPointers.MainWindow.ClientRectangle)
        frm.Location = New Point(rect.Right - frm.Width, rect.Top)
    End Sub
    Public Sub ShowChatMessage(TheMainWindow As MainWindow, ThisSession As UserSession, strTitle As String, strMsg As String)
        Dim hwndMsg As New MessageDialog(TheMainWindow, ThisSession, strMsg, strTitle)
        WindowPointers.MessageDialog = hwndMsg
        TheMainWindow.Invoke(Sub() WindowPointers.MessageDialog.ShowDialog(TheMainWindow))
    End Sub
    Public Sub PlaySound(strFileName As String, Optional Wait As Boolean = False)
        Dim DirName As String = PRODDIR + "\Sounds\"
        Dim zFile As String
        Try
            If Not File.Exists(strFileName) Then
                If Not File.Exists(DirName + strFileName) Then
                    For a = 0 To My.Settings.SoundDir.Count - 1
                        zFile = My.Settings.SoundDir(a).ToString + "\" + strFileName
                        If File.Exists(zFile) Then
                            DirName = My.Settings.SoundDir(a) + "\"
                            Exit For
                        End If
                    Next
                End If
                strFileName = DirName + strFileName
            End If
            If Wait = False Then My.Computer.Audio.Play(strFileName, AudioPlayMode.Background)
            If Wait = True Then My.Computer.Audio.Play(strFileName, AudioPlayMode.WaitToComplete)
        Catch Err As Exception
            LogError(Err.ToString)
        End Try
    End Sub
    Public Sub LogError(ErrorString As String)
        If Not Directory.Exists(PRODDIR) Then Directory.CreateDirectory(PRODDIR)
        Using fdLogFile As StreamWriter = File.AppendText(PRODDIR + "\error.log")
            If Not File.Exists(fdLogFile.ToString) Then File.Create(fdLogFile.ToString)
            Dim ErrConstruct As String = "[" + System.DateTime.Now.ToString("G") + "]" + ErrorString.Replace(vbNewLine, vbNewLine + "[" + System.DateTime.Now.ToString("G") + "]   " + "--->")
            fdLogFile.WriteLine(ErrConstruct)
        End Using
    End Sub
    Public Sub LogConnection(LogString As String)
        If Not Directory.Exists(PRODDIR) Then Directory.CreateDirectory(PRODDIR)
        Using fdLogFile As StreamWriter = File.AppendText(PRODDIR + "\connection.log")
            If Not File.Exists(fdLogFile.ToString) Then File.Create(fdLogFile.ToString)
            Dim ErrConstruct As String = "[" + System.DateTime.Now.ToString("G") + "]" + LogString.Replace(vbNewLine, vbNewLine + "[" + System.DateTime.Now.ToString("G") + "]   " + "--->")
            fdLogFile.WriteLine(ErrConstruct)
        End Using

    End Sub
    Public Sub RestartApp()
        Application.Restart()
    End Sub
End Module
