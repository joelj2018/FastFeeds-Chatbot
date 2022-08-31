Public Class Form4
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Welcome to Hangman! Remember to press the instructions button to read the rules and other information before you play!", MsgBoxStyle.Information, "Welcome!")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnStart1.Click
        If txtPlay1.Text = "" Then
            MsgBox("Please enter a player name before continuing")
        Else
            Form5.Show()
            My.Computer.Audio.Play(My.Resources.Mus, AudioPlayMode.BackgroundLoop)
            Me.Hide()
        End If
    End Sub

    Private Sub BtnInstructions_Click(sender As Object, e As EventArgs) Handles btnInstructions.Click
        Form6.Show()
        Me.Hide()
    End Sub

    Private Sub BtnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit1.Click
        Form2.Show()
        Me.Hide()
        My.Computer.Audio.Stop()
    End Sub

End Class

