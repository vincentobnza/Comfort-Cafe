Public Class login
    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        If username.Text = "" Or password.Text = "" Then
            MessageBox.Show("Please fill up all fields", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            If username.Text = "Comfort Cafe" And password.Text = "admin123" Then
                MessageBox.Show("Login Successfully", "Welcome to Comfort Cafe!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Hide()
                Form1.Show()
            Else
                MessageBox.Show("Failed to login", "System", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
        End If
    End Sub
End Class