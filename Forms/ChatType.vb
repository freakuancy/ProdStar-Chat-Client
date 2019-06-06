Public Class ChatType
    Public Sub New(hwndMain As MainWindow, CurrentSession As UserSession)
        MainWindow = hwndMain
        CurrentSession = CurrentSession
        ' This call is required by the designer.
        InitializeComponent()

        If My.Settings.ClassicChat = True Then
            chkReverse.Enabled = False
            tbUserFont.Enabled = False
            bnChooseUser.Enabled = False
            rbClassic.Checked = True
            rbModern.Checked = False
            tbFont.Enabled = False
            bnPickFont.Enabled = False
            TrackBar1.Enabled = False
            pbColor.Enabled = False
        Else
            chkReverse.Enabled = True
            tbUserFont.Enabled = True
            bnChooseUser.Enabled = True
            GroupBox2.Enabled = True
            rbModern.Checked = True
            rbClassic.Checked = False
            tbFont.Enabled = True
            bnPickFont.Enabled = True
            TrackBar1.Enabled = True
            pbColor.Enabled = True
        End If
        tbFont.Text = My.Settings.ChatFont.Name.ToString
        tbFont.Font = My.Settings.ChatFont
        tbFont.ForeColor = My.Settings.FontColor
        tbUserFont.Text = My.Settings.UserFont.Name.ToString
        tbUserFont.Font = My.Settings.UserFont
        tbUserFont.ForeColor = My.Settings.UserColor
        chkReverse.Checked = My.Settings.ReverseColor
        pbColor.BackColor = My.Settings.ChatColor
    End Sub
    Protected Overrides Sub OnPaintBackground(ByVal e As System.Windows.Forms.PaintEventArgs)
        Dim Borderpen As New Pen(Color.Purple, 5)
        MyBase.OnPaintBackground(e)

        Dim rect As New Rectangle(0, 0, Me.ClientSize.Width - 1, Me.ClientSize.Height - 1)
        e.Graphics.DrawRectangle(Borderpen, rect)
    End Sub

    Private Sub ChatType_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        SendMessage(WindowPointers.ChatRoom.tbChatText.Handle, WM_VSCROLL, SB_PAGEBOTTOM, IntPtr.Zero)
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MoveForm(Me)
    End Sub

    Private Sub bnPickFont_Click(sender As Object, e As EventArgs) Handles bnPickFont.Click
        Dim sFont As New FontDialog
        With sFont
            .AllowScriptChange = False
            .AllowSimulations = True
            .AllowVectorFonts = False
            .ShowColor = True
            .Color = tbFont.ForeColor
            .Font = tbFont.Font
            Try
                .ShowDialog()
                tbFont.Text = .Font.Name.ToString
                tbFont.Font = .Font
                tbFont.ForeColor = .Color
                If (Application.OpenForms().OfType(Of frmChatWindow).Any) Then
                    WindowPointers.ChatRoom.tbChatText.ForeColor = tbFont.ForeColor
                    WindowPointers.ChatRoom.tbChatText.Font = tbFont.Font
                End If

            Catch ex As Exception
                MessageBox.Show(Me, ex.Message + Environment.NewLine + "Font not changed.", "Font Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try

        End With

    End Sub

    Private Sub bnChooseUser_Click(sender As Object, e As EventArgs) Handles bnChooseUser.Click
        Dim sFont As New FontDialog
        With sFont
            .AllowScriptChange = False
            .AllowSimulations = True
            .AllowVectorFonts = False
            .ShowColor = True
            .Color = tbUserFont.ForeColor
            .Font = tbUserFont.Font
            Try
                .ShowDialog()
                tbUserFont.Text = .Font.Name.ToString
                tbUserFont.Font = .Font
                tbUserFont.ForeColor = .Color
                If (Application.OpenForms().OfType(Of frmChatWindow).Any) Then
                    WindowPointers.ChatRoom.tbToSend.BackColor = System.Drawing.Color.White
                    WindowPointers.ChatRoom.tbToSend.Font = tbFont.Font
                End If
            Catch ex As Exception
                MessageBox.Show(Me, ex.Message + Environment.NewLine + "Font not changed.", "Font Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try

        End With

    End Sub

    Private Sub bnCancel_Click(sender As Object, e As EventArgs) Handles bnCancel.Click

        Me.Close()

    End Sub

    Private Sub bnSave_Click(sender As Object, e As EventArgs) Handles bnSave.Click
        With My.Settings
            .ChatFont = tbFont.Font
            .FontColor = tbFont.ForeColor
            .UserFont = tbUserFont.Font
            .UserColor = tbUserFont.ForeColor
            .ClassicChat = rbClassic.Checked
            .ReverseColor = chkReverse.Checked
            .ChatColor = pbColor.BackColor
            .Save()
        End With
        If (Application.OpenForms().OfType(Of frmChatWindow).Any) Then
            If My.Settings.ClassicChat = False Then
                WindowPointers.ChatRoom.Panel1.Height = 330
                WindowPointers.ChatRoom.tbChatText.Height = 330

                WindowPointers.ChatRoom.btnBold.Visible = True
                WindowPointers.ChatRoom.btnItalic.Visible = True
                WindowPointers.ChatRoom.btnUnder.Visible = True
                WindowPointers.ChatRoom.cboFonts.Visible = True
                WindowPointers.ChatRoom.Label2.Visible = True
                WindowPointers.ChatRoom.cboSize.Visible = True
                WindowPointers.ChatRoom.cboSize.Text = My.Settings.UserFont.Size.ToString
                WindowPointers.ChatRoom.cboFonts.Text = My.Settings.UserFont.Name.ToString
                WindowPointers.ChatRoom.Label2.ForeColor = My.Settings.UserColor
                WindowPointers.ChatRoom.cboSize.Text = My.Settings.UserFont.Size.ToString
                WindowPointers.ChatRoom.tbToSend.Font = My.Settings.UserFont
                WindowPointers.ChatRoom.tbToSend.ForeColor = My.Settings.UserColor
            Else
                WindowPointers.ChatRoom.Panel1.Height = 353
                WindowPointers.ChatRoom.tbChatText.Height = 353
                WindowPointers.ChatRoom.btnBold.Visible = False
                WindowPointers.ChatRoom.btnItalic.Visible = False
                WindowPointers.ChatRoom.btnUnder.Visible = False
                WindowPointers.ChatRoom.cboFonts.Visible = False
                WindowPointers.ChatRoom.Label2.Visible = False
                WindowPointers.ChatRoom.cboSize.Visible = False
                WindowPointers.ChatRoom.tbToSend.Font = My.Settings.ChatFont
                WindowPointers.ChatRoom.tbToSend.ForeColor = DefaultForeColor
            End If

        End If

        Me.Close()
    End Sub

    Private Sub rbModern_Click(sender As Object, e As EventArgs) Handles rbModern.Click
        If rbModern.Checked = True Then
            chkReverse.Enabled = True
            tbUserFont.Enabled = True
            bnChooseUser.Enabled = True
            tbFont.Enabled = True
            bnPickFont.Enabled = True
            TrackBar1.Enabled = True
            pbColor.Enabled = True
        End If
    End Sub

    Private Sub rbClassic_Click(sender As Object, e As EventArgs) Handles rbClassic.Click
        If rbClassic.Checked = True Then
            chkReverse.Enabled = False
            tbUserFont.Enabled = False
            bnChooseUser.Enabled = False
            bnPickFont.Enabled = False
            tbFont.Enabled = False
            TrackBar1.Value = 0
            My.Settings.Opacity = TrackBar1.Value
            My.Settings.Save()
            pbColor.BackColor = System.Drawing.Color.White
            pbColor.Enabled = False

            TrackBar1.Enabled = False
            tbFont.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            tbFont.ForeColor = System.Drawing.Color.Black
            tbFont.BackColor = System.Drawing.Color.White
            tbFont.Text = tbFont.Font.Name.ToString

            If (Application.OpenForms().OfType(Of frmChatWindow).Any) Then
                WindowPointers.ChatRoom.Panel1.BackColor = System.Drawing.Color.White
                WindowPointers.ChatRoom.Panel1.Font = tbFont.Font
                WindowPointers.ChatRoom.tbChatText.Font = tbFont.Font
                WindowPointers.ChatRoom.tbChatText.ForeColor = tbFont.ForeColor
                WindowPointers.ChatRoom.DrawTrans()

            End If
        End If
    End Sub

    Private Sub pbColor_Click(sender As Object, e As EventArgs) Handles pbColor.Click
        Dim cColor As New ColorDialog
        With cColor
            .AllowFullOpen = True
            .AnyColor = True
            .SolidColorOnly = True
            .Color = WindowPointers.ChatRoom.tbChatText.BackColor
            .ShowDialog()
            pbColor.BackColor = .Color
            If (Application.OpenForms().OfType(Of frmChatWindow).Any) Then
                WindowPointers.ChatRoom.Panel1.BackColor = cColor.Color

            End If
        End With
        WindowPointers.ChatRoom.tbChatText.Font = tbFont.Font
        WindowPointers.ChatRoom.tbChatText.ForeColor = tbFont.ForeColor
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        My.Settings.Opacity = TrackBar1.Value
        My.Settings.Save()
        WindowPointers.ChatRoom.DrawTrans()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MsgBox("This version of ProdStar® Chat uses a faux-transparency that integrates the aesthetics of your desktop background into the Chat Window. Look for more tansparency options in future versions.", "ProdStar® Communicate")
    End Sub

    Private Sub ChatType_Resize(sender As Object, e As EventArgs) Handles Me.Resize
    End Sub
End Class