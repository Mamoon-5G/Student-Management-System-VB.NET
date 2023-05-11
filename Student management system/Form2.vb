Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Welcome User , " & LOGIN.TextBox1.Text
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form8.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form3.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        LOGIN.Show()
        Me.Hide()
        LOGIN.TextBox1.Text = ""
        LOGIN.TextBox2.Text = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form9.Show()
        Me.Hide()
    End Sub

    Private Sub Form2_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus
        LOGIN.Show()
        Me.Hide()
    End Sub
End Class