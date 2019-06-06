
Public Class Options
    Dim PassCrypt As New AESEncrypter
    Dim HasSaved As Boolean = True
    Dim Reload As Boolean = False
    Sub New()

        InitializeComponent()
        With My.Settings
            ' // Fill in Form from Saved Settings
            cbStartWindows.Checked = .StartWithWin
            cbMinimize.Checked = .MinimizeToTask
            cbRememberPasswd.Checked = .RememberPasswd
            If .RememberPasswd = True Then
                cbAutoReconnect.Checked = .AutoRecon
            Else
                cbAutoReconnect.Enabled = False
            End If
            rbWindowsUI.Checked = .ModernStyle
            cbEnableSounds.Checked = .EnableNotify
            If Not IsNothing(.SoundDir) Then
                For a = 0 To .SoundDir.Count - 1
                    lbDirectories.Items.Add(.SoundDir(a))
                Next
            End If
            If Not String.IsNullOrEmpty(.ServerHost) Then txtHostname.Text = .ServerHost
            If Not String.IsNullOrEmpty(.ServerPort.ToString) Then txtPort.Text = .ServerPort.ToString
            rbClearText.Checked = .ClearText
            rbUseSSL.Checked = .UseSSL
            If .UseSSL = True Then
                cbAcceptUntrusted.Checked = .AcceptUntrusted
            Else
                cbAcceptUntrusted.Enabled = False
            End If

            If .UseProxy = True Then
                cbUseProxy.Checked = .UseProxy
                If Not String.IsNullOrEmpty(.ProxyHost) Then txtProxyHostname.Text = .ProxyHost
                If Not String.IsNullOrEmpty(.ProxyPort) Then txtProxyPort.Text = .ProxyPort.ToString
                If Not String.IsNullOrEmpty(.ProxyUser) Then txtProxyUser.Text = .ProxyUser
                If Not String.IsNullOrEmpty(.ProxyPass) Then txtProxyPass.Text = PassCrypt.Decrypt(.ProxyPass, "numbsku11")
            Else
                Label12.Enabled = False
                Label13.Enabled = False
                Label14.Enabled = False
                Label15.Enabled = False
                txtProxyHostname.Enabled = False
                txtProxyPort.Enabled = False
                txtProxyUser.Enabled = False
                txtProxyPass.Enabled = False
            End If
        End With
        bnSave.Enabled = False
        HasSaved = True
        Label4.Text = PRODDIR + "\Sounds\"
    End Sub
    Private Sub bnCancel_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterForm(Me)


    End Sub
    Protected Overrides Sub OnPaintBackground(ByVal e As System.Windows.Forms.PaintEventArgs)
        '// Border
        Dim Borderpen As New Pen(Color.Purple, 5)
        MyBase.OnPaintBackground(e)

        Dim rect As New Rectangle(0, 0, Me.ClientSize.Width - 1, Me.ClientSize.Height - 1)
        e.Graphics.DrawRectangle(Borderpen, rect)
    End Sub

    Private Sub TabControl1_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles TabControl1.DrawItem
        '// GDI Trickery to make Tab Control White

        '// Tabs
        Dim g As Graphics = e.Graphics
        Dim tp As TabPage = TabControl1.TabPages(e.Index)
        Dim br As Brush
        Dim sf As New StringFormat
        Dim r As New RectangleF(e.Bounds.X, e.Bounds.Y + 2, e.Bounds.Width, e.Bounds.Height - 2)
        TabControl1.BackColor = Color.White
        sf.Alignment = StringAlignment.Center


        '// Strip
        Dim rt As Rectangle = TabControl1.GetTabRect(TabControl1.TabPages.Count - 1)
        Dim rf As RectangleF = New RectangleF(rt.X + rt.Width, rt.Y - 5, TabControl1.Width - (rt.X + rt.Width), rt.Height + 5)
        Dim b As Brush = New SolidBrush(Color.White)
        e.Graphics.FillRectangle(b, rf)


        '// Text
        Dim strTitle As String = tp.Text
        If TabControl1.SelectedIndex = e.Index Then
            br = New SolidBrush(Color.White)
            g.FillRectangle(br, e.Bounds)
            br = New SolidBrush(Color.Purple)
            g.DrawString(strTitle, TabControl1.Font, br, r, sf)
        Else
            br = New SolidBrush(Color.White)
            g.FillRectangle(br, e.Bounds)
            br = New SolidBrush(Color.Black)
            g.DrawString(strTitle, TabControl1.Font, br, r, sf)
        End If

    End Sub


    Private Sub bnCancel_Click_1(sender As Object, e As EventArgs) Handles bnCancel.Click
        Dim rResult As DialogResult
        If HasSaved = False Then
            rResult = MessageBox.Show("You have changed settings without saving." + vbNewLine + vbNewLine + "Save now?", "ProdStar® Options - Reset?", MessageBoxButtons.YesNo)
            If rResult = DialogResult.Yes Then
                SaveProdOptions()
                If Reload = True Then
                    MessageBox.Show("Some of your changes require ProdStar® to be reloaded." + vbNewLine + vbNewLine + "Click OK to reload the Application now.", "ProdStar® Options - Reload Required", MessageBoxButtons.OK)
                    Application.Restart()
                Else
                    Me.Close()
                End If
            End If
        Else
            If Reload = True Then
                MessageBox.Show("Some of your changes require ProdStar® to be reloaded." + vbNewLine + vbNewLine + "Click OK to reload the Application now.", "ProdStar® Options - Reload Required", MessageBoxButtons.OK)
                Application.Restart()
            Else
                Me.Close()
            End If
        End If

    End Sub

    Private Sub bnSave_Click(sender As Object, e As EventArgs) Handles bnSave.Click
        SaveProdOptions()
    End Sub

    Private Sub SaveProdOptions()
        Dim retVal As Microsoft.Win32.RegistryKey
        With My.Settings
            If .ModernStyle <> rbWindowsUI.Checked Then Reload = True
            .StartWithWin = cbStartWindows.Checked
            If cbStartWindows.Checked = True Then
                My.Computer.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).SetValue(Application.ProductName, Application.ExecutablePath)
            Else
                Try
                    retVal = My.Computer.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)
                    If Not IsNothing(retVal) Then
                        My.Computer.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).DeleteValue(Application.ProductName)
                    End If
                Catch err As ArgumentException
                    'JIC.
                End Try

            End If
            .MinimizeToTask = cbMinimize.Checked
            .RememberPasswd = cbRememberPasswd.Checked
            .AutoRecon = cbAutoReconnect.Checked
            .ModernStyle = rbWindowsUI.Checked
            .EnableNotify = cbEnableSounds.Checked
            If IsNothing(.SoundDir) Then .SoundDir = New System.Collections.Specialized.StringCollection
            .SoundDir.Clear()
            For a = 0 To lbDirectories.Items.Count - 1
                .SoundDir.Add(lbDirectories.Items.Item(a).ToString)
            Next
            .ClearText = rbClearText.Checked
            .UseSSL = rbUseSSL.Checked
            .AcceptUntrusted = cbAcceptUntrusted.Checked
            .ServerHost = txtHostname.Text
            If txtPort.Text <> "" Then .ServerPort = Convert.ToInt32(txtPort.Text)
            .UseProxy = cbUseProxy.Checked
            .ProxyHost = txtProxyHostname.Text
            If txtProxyPort.Text <> "" Then .ProxyPort = Convert.ToInt32(txtProxyPort.Text)
            .ProxyUser = txtProxyUser.Text
            .ProxyPass = PassCrypt.Encrypt(txtProxyPass.Text, "numbsku11")
            .Save()
        End With
        bnSave.Enabled = False
        HasSaved = True
    End Sub
    Private Sub cbStartWindows_CheckedChanged(sender As Object, e As EventArgs) Handles cbStartWindows.CheckedChanged, cbMinimize.CheckedChanged, cbRememberPasswd.CheckedChanged, cbAcceptUntrusted.CheckedChanged, cbAutoReconnect.CheckedChanged, cbEnableSounds.CheckedChanged, cbRememberPasswd.CheckedChanged, cbAutoReconnect.CheckedChanged, cbUseProxy.CheckedChanged
        bnSave.Enabled = True
        HasSaved = False
        If sender Is cbRememberPasswd Then
            If cbRememberPasswd.Checked = False Then
                cbAutoReconnect.Enabled = False
            Else
                cbAutoReconnect.Enabled = True

            End If
        ElseIf sender Is cbUseProxy Then
            If cbUseProxy.Checked = False Then
                Label12.Enabled = False
                Label13.Enabled = False
                Label14.Enabled = False
                Label15.Enabled = False
                txtProxyHostname.Enabled = False
                txtProxyPort.Enabled = False
                txtProxyUser.Enabled = False
                txtProxyPass.Enabled = False
            Else
                Label12.Enabled = True
                Label13.Enabled = True
                Label14.Enabled = True
                Label15.Enabled = True
                txtProxyHostname.Enabled = True
                txtProxyPort.Enabled = True
                txtProxyUser.Enabled = True
                txtProxyPass.Enabled = True
            End If
        End If

    End Sub

    Private Sub rbUseSSL_CheckedChanged(sender As Object, e As EventArgs) Handles rbUseSSL.CheckedChanged, rbClearText.CheckedChanged
        bnSave.Enabled = True
        HasSaved = False
        If sender Is rbUseSSL Then
            If rbUseSSL.Checked = False Then
                cbAcceptUntrusted.Enabled = False
            Else
                cbAcceptUntrusted.Enabled = True
            End If
        End If
    End Sub

    Private Sub txtHostname_TextChanged(sender As Object, e As EventArgs) Handles txtHostname.TextChanged, txtPort.TextChanged, txtProxyHostname.TextChanged, txtProxyPort.TextChanged, txtProxyUser.TextChanged, txtProxyPass.TextChanged
        bnSave.Enabled = True
        HasSaved = False
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim DirBrowser As New FolderBrowserDialog
        With DirBrowser
            .RootFolder = Environment.SpecialFolder.MyComputer
            .Description = "Add Sound Directories for ProdStar to Play From"
            If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                lbDirectories.Items.Add(.SelectedPath)
                HasSaved = False
                bnSave.Enabled = True
            End If
        End With
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If Not IsNothing(lbDirectories.SelectedItem) Then
            lbDirectories.Items.Remove(lbDirectories.SelectedItem)
            HasSaved = False
            bnSave.Enabled = True
        End If
    End Sub

    Private Sub TrkVolume_ValueChanged(sender As Object, e As EventArgs)
        HasSaved = False
        bnSave.Enabled = True
    End Sub

    Private Sub bnDefaults_Click(sender As Object, e As EventArgs) Handles bnDefaults.Click
        If MessageBox.Show("Are you sure you wish to set this tab to defaults?", "ProdStar® Options - Reset?", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            If TabControl1.SelectedTab Is tabGeneral Then
                cbStartWindows.Checked = False
                cbMinimize.Checked = True
                cbRememberPasswd.Checked = False
                cbAutoReconnect.Checked = False
                rbClassicUI.Checked = True
                rbWindowsUI.Checked = False

            ElseIf TabControl1.SelectedTab Is tabSounds Then

                cbEnableSounds.Checked = True
                lbDirectories.Items.Clear()
            ElseIf TabControl1.SelectedTab Is tabConnection Then
                txtHostname.Text = "chat.prodigyclassic.com"
                txtPort.Text = "5300"
                rbUseSSL.Checked = True
                rbClearText.Checked = False
                cbAcceptUntrusted.Checked = True
                cbUseProxy.Checked = False
                txtProxyHostname.Text = ""
                txtProxyPort.Text = ""
                txtProxyUser.Text = ""
                txtProxyPass.Text = ""
            End If
            HasSaved = False
            bnSave.Enabled = True
        End If

    End Sub

    Private Sub rbClassicUI_CheckedChanged(sender As Object, e As EventArgs) Handles rbClassicUI.CheckedChanged
        If My.Settings.ModernStyle <> rbWindowsUI.Checked Then
            Reload = True
        Else
            Reload = False
        End If
        bnSave.Enabled = True
        HasSaved = False
    End Sub

    Private Sub rbWindowsUI_CheckedChanged(sender As Object, e As EventArgs) Handles rbWindowsUI.CheckedChanged
    End Sub
End Class