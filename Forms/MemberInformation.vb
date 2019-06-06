Public Class MemberInformation

    Dim TheMainWindow As MainWindow
    Dim ThisSession As UserSession
    Dim InfoName As String

    Delegate Sub UpdateMemberInfoCallback([nn] As String, [id] As String, [city] As String, [interests] As String)
    ' Delegate Callback

    Public Sub New(hwndMain As MainWindow, CurrentSession As UserSession, Member As String)
        TheMainWindow = hwndMain
        ThisSession = CurrentSession
        InfoName = Member
        InitializeComponent()
        If ThisSession.AllowInstantMessages = False Then
            Me.bnIM.Enabled = False
        Else
            Me.bnIM.Enabled = True
        End If
        If My.Settings.ModernStyle = True Then
            Me.BackColor = DefaultBackColor
            For Each cControl In Me.Controls
                CType(cControl, Control).BackColor = DefaultBackColor
                CType(cControl, Control).ForeColor = DefaultForeColor
                CType(cControl, Control).Font = DefaultFont
            Next
        End If

    End Sub

    Private Sub MemberInformation_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If Not IsNothing(WindowPointers.ChatRoom) Then WindowPointers.ChatRoom.tbToSend.Focus()
    End Sub


    Private Sub MemberInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterForm(Me)
        TheMainWindow.DoSendToServer("USER" + DELIMITER + "GETINFO" + DELIMITER + "0" + DELIMITER + "0" + DELIMITER + InfoName)
        '// Administration?
        If ThisSession.AccessLevel >= 2 And ThisSession.AdministratorFlagOn Then
            '// Show close room button
            bnDisconnectUser.Visible = True
        Else
            bnDisconnectUser.Visible = False
        End If
    End Sub

    Public Sub PopulateMemberInformationFields(ByVal [nn] As String, ByVal [id] As String, ByVal [city] As String, ByVal [interests] As String)
        If Me.lblNickName.InvokeRequired Or Me.lblID.InvokeRequired Or Me.lblCityState.InvokeRequired Or Me.lbInterests.InvokeRequired Then
            Dim d As New UpdateMemberInfoCallback(AddressOf PopulateMemberInformationFields)
            Me.Invoke(d, New Object() {[nn], [id], [city], [interests]})
        Else
            lblNickName.Text = [nn]
            lblID.Text = [id]
            lblCityState.Text = [city]
            lbInterests.Text = [interests]
        End If
    End Sub

    Private Sub bnContinue_Click(sender As Object, e As EventArgs) Handles bnContinue.Click
        Me.Close()
    End Sub

    Private Sub bnIM_Click(sender As Object, e As EventArgs) Handles bnIM.Click

        If Not Application.OpenForms().OfType(Of IMCenter).Any Then

            Dim IMWindow As New IMCenter(WindowPointers.MainWindow, ThisSession)
            WindowPointers.InstantMessageCenter = IMWindow
            Me.Invoke(Sub() WindowPointers.InstantMessageCenter.Show(TheMainWindow))
            WindowPointers.InstantMessageCenter.BringToFront()
        Else
            WindowPointers.InstantMessageCenter.Show()
            WindowPointers.InstantMessageCenter.BringToFront()

        End If
        WindowPointers.InstantMessageCenter.tbTo.Text = InfoName

    End Sub

    Private Sub MemberInformation_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub bnDisconnectUser_Click(sender As Object, e As EventArgs) Handles bnDisconnectUser.Click
        If Not (Application.OpenForms().OfType(Of AdminDisconnectUser).Any) Then
            Dim frmDiscoUser As New AdminDisconnectUser(TheMainWindow, ThisSession, lblNickName.Text)
            WindowPointers.AdminDisconnectUser = frmDiscoUser
            Me.Invoke(Sub() WindowPointers.AdminDisconnectUser.Show(Me))
        Else
            WindowPointers.AdminDisconnectUser.Show()
            WindowPointers.AdminDisconnectUser.BringToFront()
        End If
    End Sub
End Class