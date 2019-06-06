Public Class MessageDialog

    ' Main Window - For communication with the server
    Dim TheMainWindow As MainWindow
    Dim CurrentSession As UserSession
    Dim strLoad As String
    ' Delegate Callback
    Delegate Sub UpdateDialogMessageCallback([text] As String)

    Public Sub New(MainWindow As MainWindow, UserSession As UserSession, strLoadMsg As String, strTitleMessage As String)
        TheMainWindow = MainWindow
        CurrentSession = UserSession
        InitializeComponent()
        strLoad = strLoadMsg
        Me.Text = strTitleMessage
        If My.Settings.ModernStyle = True Then
            Me.BackColor = DefaultBackColor
            For Each cControl In Me.Controls
                CType(cControl, Control).BackColor = DefaultBackColor
                CType(cControl, Control).ForeColor = DefaultForeColor
                CType(cControl, Control).Font = DefaultFont
            Next
        End If
    End Sub

    Private Sub MessageDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

        If Not IsNothing(CurrentSession) Then
            lblMessage.Text = strLoad.Replace("${MYNICK}", CurrentSession.CurrentNickName)
        Else
            lblMessage.Text = strLoad
        End If
    End Sub

    Private Sub MessageDialog_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub bnClose_Click(sender As Object, e As EventArgs) Handles bnClose.Click
        Me.Close()
    End Sub
End Class