Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        If txtUser.Text = "" Then
            MsgBox("To improve the fuctionality of myself as a Chat Bot, please enter a name you would like to go by before continuing")
        Else
            Form2.Show()
            Me.Hide()
        End If
    End Sub


    Private Sub BtnBackHome_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Close()
        My.Computer.Audio.Stop()
    End Sub
End Class
