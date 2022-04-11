Public Class ForgotPassword
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Login As New Login
        Login.Show()
        Me.Hide()
    End Sub
End Class