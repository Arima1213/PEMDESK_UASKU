Public Class FormLogin
    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        If TextBoxUsername.Text = "makijah" And TextBoxPassword.Text = "123" Then
            FormUtama.ShowDialog()
        Else

        End If

    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxUsername.Focus()
        Guna2CustomGradientPanel5.FillColor = Color.FromArgb(95, Color.Black)
        Guna2CustomGradientPanel5.FillColor2 = Color.FromArgb(95, Color.Black)
        Guna2CustomGradientPanel5.FillColor3 = Color.FromArgb(95, Color.Black)
        Guna2CustomGradientPanel5.FillColor4 = Color.FromArgb(95, Color.Black)

    End Sub


End Class