Imports System.Threading
Public Class SignOn

    ' Main Window - For communication with the server
    Dim TheMainWindow As MainWindow
    Dim CurrentSession As UserSession
    Dim AlreadyConnecting As Boolean
    Dim AESCrypt As New AESEncrypter
    Public Delegate Sub EnableButtonCallback()
    Dim AutoRecon As Boolean
    ' Constructor
    Public Sub New(mainwindow As MainWindow, ThisSession As UserSession)
        CurrentSession = ThisSession
        TheMainWindow = mainwindow
        AlreadyConnecting = False
        ' This call is required by the designer.
        InitializeComponent()
        If My.Settings.ModernStyle = True Then
            Me.BackColor = DefaultBackColor
            For Each cControl In Me.Controls

                If TypeOf cControl Is ListBox Then
                    CType(cControl, ListBox).BorderStyle = BorderStyle.Fixed3D
                    CType(cControl, ListBox).BackColor = SystemColors.Window
                ElseIf TypeOf cControl Is ComboBox Then
                    CType(cControl, ComboBox).FlatStyle = FlatStyle.Standard
                    CType(cControl, ComboBox).BackColor = SystemColors.Window
                ElseIf TypeOf cControl Is TextBox Then
                    CType(cControl, TextBox).BorderStyle = BorderStyle.Fixed3D
                    CType(cControl, TextBox).BackColor = SystemColors.Window
                Else
                    CType(cControl, Control).BackColor = DefaultBackColor
                    CType(cControl, Control).Font = DefaultFont
                End If
                CType(cControl, Control).ForeColor = DefaultForeColor
            Next
            lbJmp.BorderStyle = BorderStyle.Fixed3D
        End If
    End Sub


    Private Sub bnConnect_Click_1(sender As Object, e As EventArgs) Handles bnConnect.Click
        Try
            If tbID.Text <> "" And tbPW.Text <> "" Then
                CurrentSession.UserID = tbID.Text
                My.Settings.LastID = CurrentSession.UserID
                If My.Settings.RememberPasswd = True Then My.Settings.LastPass = AESCrypt.Encrypt(tbPW.Text, "numbsku11")
                My.Settings.Save()
                If tbJumpTo.Text <> "" Then
                    CurrentSession.JumpArea = "PRIVATE"
                    CurrentSession.JumpRoom = tbJumpTo.Text
                ElseIf Not IsNothing(lbJmp.SelectedItem) Then
                    Dim RoomSplit() As String = Split(lbJmp.SelectedItem.ToString, " - ")
                    CurrentSession.JumpArea = RoomSplit(0)
                    CurrentSession.JumpRoom = RoomSplit(1)
                End If
                ConnectToProd(tbID.Text, tbPW.Text)
            Else
                ShowChatMessage(TheMainWindow, Nothing, "ProdStar® CHAT - Error", "Please enter a valid username and password to connect.")
            End If
        Catch ex As Exception
            'MessageBox.Show("Unable to save.")
            LogError("ERROR -> " + ex.StackTrace)
        End Try
    End Sub
    Private Sub ConnectToProd(ID As String, PW As String)
        If AutoRecon = True Then
            CurrentSession.JumpArea = Nothing
            CurrentSession.UserID = My.Settings.LastID
        End If
        Connector = New Thread(Sub() TheMainWindow.ConnectToServer(ID, PW))
        Connector.Start()
        Connector.IsBackground = True
        CurrentSession.AutoReconnecting = False
    End Sub
    Public Sub AddItemToList(NewItem As String, Index As Integer)
        '// Does the list already contain this?
        If (Not lbJmp.Items.Contains(NewItem)) Then
            lbJmp.Items.Insert(0, NewItem)
        End If
    End Sub

    Private Sub bnSetup_Click_1(sender As Object, e As EventArgs) Handles bnSetup.Click
        Dim frmOptions As New Options
        frmOptions.Show()
    End Sub

    Private Sub bnHelp_Click_1(sender As Object, e As EventArgs) Handles bnHelp.Click
        MsgBox("Help functionality is not yet available.")
    End Sub

    Private Sub bnExit_Click_1(sender As Object, e As EventArgs) Handles bnExit.Click
        End
    End Sub

    Private Sub SignOn_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.TopMost = False
    End Sub

    Private Sub SignOn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If CurrentSession.ClientUpdated = True Then EnableButton()
        Label7.Text = "ProdStar Classic v" + VERSION + vbNewLine + "This application and its related components are not associated with the Prodigy® Service in any way." + vbNewLine + "This application is provided free-of-charge. All rights reserved."
        tbID.Text = My.Settings.LastID
        If My.Settings.RememberPasswd = True Then
            tbPW.Text = AESCrypt.Decrypt(My.Settings.LastPass, "numbsku11")
            If CurrentSession.AutoReconnecting = True Then
                ConnectToProd(My.Settings.LastID, AESCrypt.Decrypt(My.Settings.LastPass, "numbsku11"))
                CurrentSession.AutoReconnecting = False
            End If
        End If
        EnableButton()

        WindowPointers.MainWindow.InstantMessageToolStripMenuItem.Enabled = False
        WindowPointers.MainWindow.ChatToolStripMenuItem.Enabled = False
        WindowPointers.MainWindow.LogoffToolStripMenuItem.Enabled = False
    End Sub
    Public Sub EnableButton()
        If Me.bnConnect.InvokeRequired Then
            Dim d As New EnableButtonCallback(AddressOf EnableButton)
            Me.Invoke(d)
        Else
            bnConnect.Enabled = True
            lblUpdate.Text = "Ready to Connect!"
            Me.lblUpdate.Left = Me.Width \ 2 - Me.lblUpdate.Width \ 2
        End If
    End Sub


    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub lblUpdate_Click(sender As Object, e As EventArgs) Handles lblUpdate.Click

    End Sub

    Private Sub lblUpdate_DoubleClick(sender As Object, e As EventArgs) Handles lblUpdate.DoubleClick
        Dim myAppFolder As String = "C:\Users\Chris\Documents\Prodigy Restoration\Client"

        Dim myCoolFileLineCount As Integer = 0
        For Each myCoolFile As String In My.Computer.FileSystem.GetFiles _
        (myAppFolder, FileIO.SearchOption.SearchAllSubDirectories, "*.*") '// scan folder.
            If IO.Path.GetExtension(myCoolFile) = ".vb" Then '// get all files with the .vb file extension.
                If Not IO.Path.GetFileName(myCoolFile).Contains(".Designer.vb") Then '// remove files that are Designer files.
                    Dim myCoolForm As String = IO.Path.GetFullPath(myCoolFile) '// get full path of file.
                    Dim myCoolFileLines() As String = IO.File.ReadAllLines(myCoolForm) '// load your file as a string array.
                    myCoolFileLineCount += myCoolFileLines.Length '// count lines and add to the sum total.
                End If
            End If
        Next
        '// display your application's total code line count.
        'MsgBox(Application.ProductName & vbNewLine & "Total Code Lines Count: " & myCoolFileLineCount, MsgBoxStyle.Information)
    End Sub

    Private Sub lbJmp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbJmp.SelectedIndexChanged

    End Sub
End Class