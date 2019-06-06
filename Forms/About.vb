Public Class About
    Dim TheMainWindow As MainWindow
    Dim ThisSession As UserSession
    Dim Drag As Boolean
    Dim MouseX As Integer
    Dim MouseY As Integer


    Public Sub New(hwndMain As MainWindow, CurrentSession As UserSession)
        TheMainWindow = hwndMain
        ThisSession = CurrentSession

        InitializeComponent()

    End Sub
    Private Sub About_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterForm(Me)
        Label2.Text = "Version: " + VERSION.ToString
    End Sub
    Protected Overrides Sub OnPaintBackground(ByVal e As System.Windows.Forms.PaintEventArgs)
        Dim Borderpen As New Pen(Color.Purple, 5)
        MyBase.OnPaintBackground(e)

        Dim rect As New Rectangle(0, 0, Me.ClientSize.Width - 1, Me.ClientSize.Height - 1)
        e.Graphics.DrawRectangle(Borderpen, rect)
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        Process.Start("http://www.prodigyclassic.com")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim frmReport As New BugReport(TheMainWindow, ThisSession, "", False)
        WindowPointers.BugReport = frmReport
        Me.Close()
        TheMainWindow.Invoke(Sub() WindowPointers.BugReport.ShowDialog())

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Process.Start("mailto://diviniti@prodigyclassic.com")

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Process.Start("mailto://james@prodigyclassic.com")
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Process.Start("mailto://jeff@prodigyclassic.com")
    End Sub

    Private Sub About_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        Drag = True
        MouseX = Windows.Forms.Cursor.Position.X - Me.Left
        MouseY = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub About_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If Drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - MouseY
            Me.Left = Windows.Forms.Cursor.Position.X - MouseX
        End If
    End Sub

    Private Sub About_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        Drag = False
    End Sub
End Class