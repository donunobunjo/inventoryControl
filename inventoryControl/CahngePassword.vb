Public Class CahngePassword
    ' Public Property oldpasswd As String
    Public Property user As String
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        txtNewPassword.Clear()
        txtOldPassword.Clear()
        txtConfirmPassword.Clear()
        txtOldPassword.Focus()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim changepasswd As New iGontrolTableAdapters.UserTableAdapter
        Dim dt As DataTable
        If txtOldPassword.Text = "" Then
            MessageBox.Show("Old password is required")
            txtOldPassword.Focus()
            Exit Sub
        End If
        '       If Not txtOldPassword.Text = Trim(oldpasswd) Then
        'MessageBox.Show("Your old password doesn't match")
        '        txtOldPassword.Focus()
        '       Exit Sub
        '      End If
        If txtNewPassword.Text = "" Then
            MessageBox.Show("New password is required")
            txtNewPassword.Focus()
            Exit Sub
        End If
        If txtConfirmPassword.Text = "" Then
            MessageBox.Show("Confirm password is required")
            txtConfirmPassword.Focus()
            Exit Sub
        End If
        If Not (txtNewPassword.Text) = (txtConfirmPassword.Text) Then
            MessageBox.Show("Your confirmation password does not match your new password")
            txtNewPassword.Clear()
            txtConfirmPassword.Clear()
            txtNewPassword.Focus()
            Exit Sub
        End If
        dt = changepasswd.GetDataBy3(user, txtOldPassword.Text)
        If dt.Rows.Count = 0 Then
            MessageBox.Show("You are not a valid user, please see the administrator")
            Exit Sub
        End If
        changepasswd.changePassword(txtNewPassword.Text, user)
        MessageBox.Show("Password change Successfull, you need to shut the application to complete the process ")
        Me.Close()
        ' Application.Exit()
    End Sub

    Private Sub CahngePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.MdiParent = Main
        Me.CenterToScreen()
        Me.Top = 5
    End Sub
End Class