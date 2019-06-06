Imports System.IO
Imports System.Environment
Public Class IncomingInstantMessage

    ' Main Window - For communication with the server
    Dim TheMainWindow As MainWindow
    Dim CurrentSession As UserSession
    ' Delegate Callback
    Delegate Sub UpdateIncomingInstantMessagesCallback([text] As String)
    Public Sub New(mainwindow As MainWindow, ThisSession As UserSession)
        Me.TheMainWindow = mainwindow
        Me.AcceptButton = bnView
        CurrentSession = ThisSession

        InitializeComponent()
        If My.Settings.ModernStyle = True Then
            Me.BackColor = DefaultBackColor
            For Each cControl In Me.Controls
                CType(cControl, Control).BackColor = DefaultBackColor
                CType(cControl, Control).ForeColor = DefaultForeColor
                CType(cControl, Control).Font = DefaultFont
            Next
            lbIncomingMessage.BackColor = SystemColors.Window
            lbIncomingMessage.ForeColor = DefaultForeColor
            lbIncomingMessage.BorderStyle = BorderStyle.Fixed3D
        End If
    End Sub
    Private Sub IncomingInstantMessage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        Me.BringToFront()
        If My.Settings.EnableNotify = True Then PlaySound("IMSG.WAV")
    End Sub

    Sub IncomingInstantMessage_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Hide()
        End If
    End Sub

    Public Sub UpdateIncomingMessages(ByVal [text] As String)
        ' InvokeRequired required compares the thread ID of the 
        ' calling thread to the thread ID of the creating thread. 
        ' If these threads are different, it returns true. 
        If Me.lbIncomingMessage.InvokeRequired Then
            Dim d As New UpdateIncomingInstantMessagesCallback(AddressOf UpdateIncomingMessages)
            Me.Invoke(d, New Object() {[text]})
        Else
            ' // Is the nickname already in the list?
            If Not lbIncomingMessage.Items.Contains([text] + " (NEW)") Then
                lbIncomingMessage.Items.Add([text] + " (NEW)")
                lbIncomingMessage.SelectedIndex = lbIncomingMessage.FindStringExact([text] + " (NEW)")
            End If
        End If
    End Sub

    Private Sub BnView_Click_1(sender As Object, e As EventArgs) Handles bnView.Click
        ' // Catch the instance where the user selects "View" after deleting all incoming messages.
        If Not (IsNothing(lbIncomingMessage.SelectedItem)) Then
            ' // View the instant message.
            Dim strNick As String = Strings.Left(lbIncomingMessage.SelectedItem.ToString, lbIncomingMessage.SelectedItem.ToString.Length - 6)
            ' // Check to see if the Instant Message Center is already open.
            If Not (Application.OpenForms().OfType(Of IMCenter).Any) Then
                SpawnIMCenter(strNick)
            End If
            ' // Close the Incoming IM window.
            Me.Close()
        Else
            ' // In this case, the user has cleared all his/her conversations and then proceeded to click "View".
            ' // Spawn the IM window.
            SpawnIMCenter(Nothing)
        End If
    End Sub

    Private Sub bnDelete_Click_1(sender As Object, e As EventArgs) Handles bnDelete.Click
        ' // Ensure the user doesn't try to click Delete when no row is selected.
        If Not (IsNothing(lbIncomingMessage.SelectedItem)) Then
            ' // We need to delete the conversation from memory.
            WindowPointers.InstantMessageCenter.UpdateSelection(lbIncomingMessage.SelectedItem.ToString)
            ' // Get a pointer to the conversation.
            Dim toRemove As InstantMessageConversation = WindowPointers.MainWindow.GetConversationPointer(lbIncomingMessage.SelectedItem.ToString)
            CurrentSession.InstantMessages.Remove(lbIncomingMessage.SelectedItem.ToString)
            'CurrentSession.Conversations.Remove(toRemove)
            ' // Remove the message from the view (the listbox.)
            lbIncomingMessage.Items.Remove(lbIncomingMessage.SelectedItem)
        End If
    End Sub

    Private Sub lbIncomingMessage_DoubleClick(sender As Object, e As EventArgs) Handles lbIncomingMessage.DoubleClick
        Dim strNick As String = Strings.Left(lbIncomingMessage.SelectedItem.ToString, lbIncomingMessage.SelectedItem.ToString.Length - 6)
        If Not (Application.OpenForms().OfType(Of IMCenter).Any) Then
            Dim IMWindow As New IMCenter(WindowPointers.MainWindow, CurrentSession)
            WindowPointers.InstantMessageCenter = IMWindow
            WindowPointers.InstantMessageCenter.Show(Form.ActiveForm)
        End If
        WindowPointers.InstantMessageCenter.UpdateSelection(strNick)
        Me.Close()
    End Sub

    Private Sub SpawnIMCenter(openToConvo As String)
        Dim pHandle As Form
        ' // Spawn the Instant Message Center.
        If CurrentSession.ClientHidden = True Then
            WindowPointers.MainWindow.NotifyIcon1.Visible = False
            TheMainWindow.RestoreWindows()
            CurrentSession.ClientHidden = False
        End If

        Dim IMWindow As New IMCenter(WindowPointers.MainWindow, CurrentSession)
        WindowPointers.InstantMessageCenter = IMWindow
        WindowPointers.InstantMessageCenter.Show(TheMainWindow)


        WindowPointers.InstantMessageCenter.BringToFront()
        ' // Do we need to push to a specific conversation?
        If Not (IsNothing(openToConvo)) Then
            ' // Invoke the method that displays the selected conversation.
            WindowPointers.InstantMessageCenter.UpdateSelection(openToConvo)
        End If
        ' // Hide this.
        Me.Close()
    End Sub

    Private Sub bnExclude_Click(sender As Object, e As EventArgs) Handles bnExclude.Click
        ' // Ensure the user has actually clicked on a row before executing this.
        If Not (IsNothing(lbIncomingMessage.SelectedItem)) Then
            ' // Spawn exclusion.
            Dim strExNick As String = lbIncomingMessage.SelectedItem.ToString.Replace(" (NEW)", "")
            Dim frmExclude As New Exclude(TheMainWindow, CurrentSession, strExNick)
            WindowPointers.Exclude = frmExclude
            WindowPointers.Exclude.ShowDialog(Me)
        End If
    End Sub

End Class