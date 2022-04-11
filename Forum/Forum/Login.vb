Public Class Login
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        TextBox2.PasswordChar = "*"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Register As New Register
        Register.Show()
        Me.Hide()
    End Sub

    Private Sub ForgotPassword_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ForgotPassword.LinkClicked
        Dim forgotpassword As New ForgotPassword
        forgotpassword.Show()
        Me.Hide()
    End Sub
End Class
