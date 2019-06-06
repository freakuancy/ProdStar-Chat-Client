Public Class ChangePassword

    Dim CurrentSession As UserSession
    Friend TheMainWindow As MainWindow

    '// Keeping this local so garbage collection cleans it up after
    '// Form is closed


    Public Sub New(mainwind As MainWindow, ThisSession As UserSession)
        CurrentSession = ThisSession
        TheMainWindow = mainwind

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
        End If
    End Sub

    Private Sub bnOkay_Click(sender As Object, e As EventArgs) Handles bnOkay.Click
        '// Do the two new password fields match?
        If tbNewPassword.Text.Length >= 8 Then
            If (String.Equals(tbNewPassword.Text, tbNewPasswordConfirmation.Text)) Then
                '// Send the change password command.
                TheMainWindow.DoSendToServer("USER" + DELIMITER + "CHANGEPW" + DELIMITER + tbCurrentPassword.Text.Length.ToString + DELIMITER + tbCurrentPassword.Text + DELIMITER + tbNewPassword.Text)
            Else
                ShowChatMessage(TheMainWindow, CurrentSession, "Change Password", "Your new passwords do not match.")

            End If
        Else
            ShowChatMessage(TheMainWindow, CurrentSession, "Change Password", "Your new password is too short." + vbNewLine + vbNewLine + "Please choose a password at least 8 characters in length.")
        End If

    End Sub

    Private Sub ChangePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MoveForm(Me)
    End Sub

    Private Sub bnCancel_Click(sender As Object, e As EventArgs) Handles bnCancel.Click
        Me.Close()
    End Sub

    Private Sub tbCurrentPassword_TextChanged(sender As Object, e As EventArgs) Handles tbCurrentPassword.TextChanged

    End Sub
End Class