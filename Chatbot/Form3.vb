Public Class Form3
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBot.Click
        Form2.Show()
        Me.Hide()
    End Sub


End Class