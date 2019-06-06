Public Class Connection
    Dim TheMainWindow As MainWindow
    Dim ThisSession As UserSession

    Public Sub New(hwndMain As MainWindow)
        TheMainWindow = hwndMain

        InitializeComponent()

    End Sub
    Delegate Sub SetTextCallback([text] As String)
    Private Sub Connection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterForm(Me)
    End Sub
    Protected Overrides Sub OnPaintBackground(ByVal e As System.Windows.Forms.PaintEventArgs)
        Dim Borderpen As New Pen(Color.Purple, 5)
        MyBase.OnPaintBackground(e)

        Dim rect As New Rectangle(0, 0, Me.ClientSize.Width - 1, Me.ClientSize.Height - 1)
        e.Graphics.DrawRectangle(Borderpen, rect)
    End Sub
    Sub SetText([Text] As String)
        If Me.lblStatus.InvokeRequired Then
            Dim d As New SetTextCallback(AddressOf SetText)
            Me.Invoke(d, New Object() {[Text]})
        Else
            lblStatus.Text = [Text]
            Threading.Thread.Sleep(300)
        End If
    End Sub

    Private Sub lblStatus_Click(sender As Object, e As EventArgs) Handles lblStatus.Click

    End Sub


    Private Sub bnCancel_Click(sender As Object, e As EventArgs) Handles bnCancel.Click
        CancelCon = True
        TheMainWindow.ClientDisconnected()
        bnCancel.Enabled = False
    End Sub
End Class