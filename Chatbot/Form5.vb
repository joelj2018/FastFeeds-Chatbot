Public Class Form5

    Dim Secret_Word As String
    Const FLAG As Char = "!"
    Dim NumGuesses As Integer = 0
    Dim tempWord As String
    Dim NumWrong As Integer
    Dim play1 As String
    Dim Random As New Random()
    Dim Wordrandom As Integer


    Sub DisableButtons()
        btnA.Enabled = False
        btnB.Enabled = False
        btnC.Enabled = False
        btnD.Enabled = False
        btnE.Enabled = False
        btnF.Enabled = False
        btnG.Enabled = False
        btnH.Enabled = False
        btnI.Enabled = False
        btnJ.Enabled = False
        btnK.Enabled = False
        btnL.Enabled = False
        btnM.Enabled = False
        btnN.Enabled = False
        btnO.Enabled = False
        btnP.Enabled = False
        btnQ.Enabled = False
        btnR.Enabled = False
        btnS.Enabled = False
        btnT.Enabled = False
        btnU.Enabled = False
        btnV.Enabled = False
        btnW.Enabled = False
        btnX.Enabled = False
        btnY.Enabled = False
        btnZ.Enabled = False

    End Sub
    Sub EnableButtons()
        btnA.Enabled = True
        btnB.Enabled = True
        btnC.Enabled = True
        btnD.Enabled = True
        btnE.Enabled = True
        btnF.Enabled = True
        btnG.Enabled = True
        btnH.Enabled = True
        btnI.Enabled = True
        btnJ.Enabled = True
        btnK.Enabled = True
        btnL.Enabled = True
        btnM.Enabled = True
        btnN.Enabled = True
        btnO.Enabled = True
        btnP.Enabled = True
        btnQ.Enabled = True
        btnR.Enabled = True
        btnS.Enabled = True
        btnT.Enabled = True
        btnU.Enabled = True
        btnV.Enabled = True
        btnW.Enabled = True
        btnX.Enabled = True
        btnY.Enabled = True
        btnZ.Enabled = True
    End Sub

    Public Sub Loadlettershow()
        lblTempWord.Text = ""
        Dim lengthofsecretword As Integer
        lengthofsecretword = Secret_Word.Length - 1


        Dim LetterPosition As Integer
        For LetterPosition = 0 To lengthofsecretword
            lblTempWord.Text = lblTempWord.Text & "-"
        Next
    End Sub

    Sub GuessLetter(LetterGuess As String)
        Dim strGuessedTillNow As String = lblTempWord.Text
        Dim lengthofsecretword As Integer
        lengthofsecretword = Secret_Word.Length - 1
        tempWord = ""
        Dim LetterPosition As Integer
        For LetterPosition = 0 To lengthofsecretword
            If Secret_Word.Substring(LetterPosition, 1) = LetterGuess Then
                tempWord &= LetterGuess
            Else tempWord &= lblTempWord.Text.Substring(LetterPosition, 1)
            End If
        Next
        lblTempWord.Text = tempWord

        If lblTempWord.Text = Secret_Word Then
            DisableButtons()
            btnStart.Enabled = True
            MsgBox("Congratulations " & play1 & " For Guessing The Right Word, You Win!")

            Wordrandom = Random.Next(1, 15)
            If Wordrandom = 1 Then
                Secret_Word = "BURGER"
            ElseIf Wordrandom = 2 Then
                Secret_Word = "MCDONALDS"
            ElseIf Wordrandom = 3 Then
                Secret_Word = "CHICKEN"
            ElseIf Wordrandom = 4 Then
                Secret_Word = "VEGETARIAN"
            ElseIf Wordrandom = 5 Then
                Secret_Word = "CONSUMABLE"
            ElseIf Wordrandom = 6 Then
                Secret_Word = "HUNGRY"
            ElseIf Wordrandom = 7 Then
                Secret_Word = "BREAKFAST"
            ElseIf Wordrandom = 8 Then
                Secret_Word = "SWEETNESS"
            ElseIf Wordrandom = 9 Then
                Secret_Word = "BEVERAGE"
            ElseIf Wordrandom = 10 Then
                Secret_Word = "RESTAURANT"
            ElseIf Wordrandom = 11 Then
                Secret_Word = "CUISINE"
            ElseIf Wordrandom = 12 Then
                Secret_Word = "NUTRITION"
            ElseIf Wordrandom = 13 Then
                Secret_Word = "DELICIOUS"
            ElseIf Wordrandom = 14 Then
                Secret_Word = "SANDWICH"
            ElseIf Wordrandom = 15 Then
                Secret_Word = "UNHEALTHY"
            End If
            EnableButtons()
            btnStart.Enabled = False
            Loadlettershow()
            NumWrong = 0
            LoadLabelDisplay(NumWrong)

        End If
        If lblTempWord.Text = strGuessedTillNow Then
            NumWrong += 1
        End If
        LoadLabelDisplay(NumWrong)



    End Sub

    Public Sub LoadLabelDisplay(numwrong As Integer)
        If numwrong = 0 Then
            Me.PictureBox1.Image = My.Resources._0
            lblTries.Text = 11
        End If
        If numwrong = 1 Then
            Me.PictureBox1.Image = My.Resources._1
            lblTries.Text = 10
        End If
        If numwrong = 2 Then
            Me.PictureBox1.Image = My.Resources._2
            lblTries.Text = 9
        End If
        If numwrong = 3 Then
            Me.PictureBox1.Image = My.Resources._3
            lblTries.Text = 8
        End If
        If numwrong = 4 Then
            Me.PictureBox1.Image = My.Resources._4
            lblTries.Text = 7
        End If
        If numwrong = 5 Then
            Me.PictureBox1.Image = My.Resources._5
            lblTries.Text = 6
        End If
        If numwrong = 6 Then
            Me.PictureBox1.Image = My.Resources._6
            lblTries.Text = 5
        End If
        If numwrong = 7 Then
            Me.PictureBox1.Image = My.Resources._7
            lblTries.Text = 4
        End If
        If numwrong = 8 Then
            Me.PictureBox1.Image = My.Resources._8
            lblTries.Text = 3
        End If
        If numwrong = 9 Then
            Me.PictureBox1.Image = My.Resources._9
            lblTries.Text = 2
        End If
        If numwrong = 10 Then
            Me.PictureBox1.Image = My.Resources._10
            lblTries.Text = 1
        End If
        If numwrong = 11 Then
            Me.PictureBox1.Image = My.Resources._11
            lblTries.Text = 0

            If Secret_Word = "BURGER" Then
                MsgBox("Unlucky " & play1 & ", You Ran Out Of Tries, The Word Was Burger, Play Again For Another Word")
            ElseIf Secret_Word = "MCDONALDS" Then
                MsgBox("Unlucky " & play1 & ", You Ran Out Of Tries, The Word Was Mcdonalds, Play Again For Another Word")
            ElseIf Secret_Word = "CHICKEN" Then
                MsgBox("Unlucky " & play1 & ", You Ran Out Of Tries, The Word Was Chicken, Play Again For Another Word")
            ElseIf Secret_Word = "VEGETARIAN" Then
                MsgBox("Unlucky " & play1 & ", You Ran Out Of Tries, The Word Was Vegetarian, Play Again For Another Word")
            ElseIf Secret_Word = "CONSUMABLE" Then
                MsgBox("Unlucky " & play1 & ", You Ran Out Of Tries, The Word Was Consumable, Play Again For Another Word")
            ElseIf Secret_Word = "HUNGRY" Then
                MsgBox("Unlucky " & play1 & ", You Ran Out Of Tries, The Word Was Hungry, Play Again For Another Word")
            ElseIf Secret_Word = "BREAKFAST" Then
                MsgBox("Unlucky " & play1 & ", You Ran Out Of Tries, The Word Was Breakfast, Play Again For Another Word")
            ElseIf Secret_Word = "SWEETNESS" Then
                MsgBox("Unlucky " & play1 & ", You Ran Out Of Tries, The Word Was Sweetness, Play Again For Another Word")
            ElseIf Secret_Word = "BEVERAGE" Then
                MsgBox("Unlucky " & play1 & ", You Ran Out Of Tries, The Word Was Beverage, Play Again For Another Word")
            ElseIf Secret_Word = "CUISINE" Then
                MsgBox("Unlucky " & play1 & ", You Ran Out Of Tries, The Word Was Cuisine, Play Again For Another Word")
            ElseIf Secret_Word = "RESTAURANT" Then
                MsgBox("Unlucky " & play1 & ", You Ran Out Of Tries, The Word Was Restaurant, Play Again For Another Word")
            ElseIf Secret_Word = "NUTRITION" Then
                MsgBox("Unlucky " & play1 & ", You Ran Out Of Tries, The Word Was Nutrition, Play Again For Another Word")
            ElseIf Secret_Word = "DELICIOUS" Then
                MsgBox("Unlucky " & play1 & ", You Ran Out Of Tries, The Word Was Delicious, Play Again For Another Word")
            ElseIf Secret_Word = "SANDWICH" Then
                MsgBox("Unlucky " & play1 & ", You Ran Out Of Tries, The Word Was Sandwich, Play Again For Another Word")
            ElseIf Secret_Word = "UNHEALTHY" Then
                MsgBox("Unlucky " & play1 & ", You Ran Out Of Tries, The Word Was Unhealthy, Play Again For Another Word")

            End If


            Wordrandom = Random.Next(1, 15)
            If Wordrandom = 1 Then
                Secret_Word = "BURGER"
            ElseIf Wordrandom = 2 Then
                Secret_Word = "MCDONALDS"
            ElseIf Wordrandom = 3 Then
                Secret_Word = "CHICKEN"
            ElseIf Wordrandom = 4 Then
                Secret_Word = "VEGETARIAN"
            ElseIf Wordrandom = 5 Then
                Secret_Word = "CONSUMABLE"
            ElseIf Wordrandom = 6 Then
                Secret_Word = "HUNGRY"
            ElseIf Wordrandom = 7 Then
                Secret_Word = "BREAKFAST"
            ElseIf Wordrandom = 8 Then
                Secret_Word = "SWEETNESS"
            ElseIf Wordrandom = 9 Then
                Secret_Word = "BEVERAGE"
            ElseIf Wordrandom = 10 Then
                Secret_Word = "RESTAURANT"
            ElseIf Wordrandom = 11 Then
                Secret_Word = "CUISINE"
            ElseIf Wordrandom = 12 Then
                Secret_Word = "NUTRITION"
            ElseIf Wordrandom = 13 Then
                Secret_Word = "DELICIOUS"
            ElseIf Wordrandom = 14 Then
                Secret_Word = "SANDWICH"
            ElseIf Wordrandom = 15 Then
                Secret_Word = "UNHEALTHY"
            End If
            EnableButtons()
            btnStart.Enabled = False
            Loadlettershow()
            numwrong = 0
            LoadLabelDisplay(numwrong)

        End If
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load
        DisableButtons()
        lblTempWord.Text = ""
        My.Computer.Audio.Play(My.Resources.Mus, AudioPlayMode.BackgroundLoop)

        txtPlayer1.Enabled = False

        play1 = Form4.txtPlay1.Text

        txtPlayer1.Text = play1
    End Sub


    Private Sub Btn_startgame_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Wordrandom = Random.Next(1, 15)
        If Wordrandom = 1 Then
            Secret_Word = "BURGER"
        ElseIf Wordrandom = 2 Then
            Secret_Word = "MCDONALDS"
        ElseIf Wordrandom = 3 Then
            Secret_Word = "CHICKEN"
        ElseIf Wordrandom = 4 Then
            Secret_Word = "VEGETARIAN"
        ElseIf Wordrandom = 5 Then
            Secret_Word = "CONSUMABLE"
        ElseIf Wordrandom = 6 Then
            Secret_Word = "HUNGRY"
        ElseIf Wordrandom = 7 Then
            Secret_Word = "BREAKFAST"
        ElseIf Wordrandom = 8 Then
            Secret_Word = "SWEETNESS"
        ElseIf Wordrandom = 9 Then
            Secret_Word = "BEVERAGE"
        ElseIf Wordrandom = 10 Then
            Secret_Word = "RESTAURANT"
        ElseIf Wordrandom = 11 Then
            Secret_Word = "CUISINE"
        ElseIf Wordrandom = 12 Then
            Secret_Word = "NUTRITION"
        ElseIf Wordrandom = 13 Then
            Secret_Word = "DELICIOUS"
        ElseIf Wordrandom = 14 Then
            Secret_Word = "SANDWICH"
        ElseIf Wordrandom = 15 Then
            Secret_Word = "UNHEALTHY"
        End If
        EnableButtons()
        btnStart.Enabled = False
        Loadlettershow()
        NumWrong = 0
        LoadLabelDisplay(NumWrong)
    End Sub

    Private Sub BtnA_Click(sender As Object, e As EventArgs) Handles btnA.Click
        btnA.Enabled = False
        GuessLetter(btnA.Text)
    End Sub

    Private Sub BtnB_Click(sender As Object, e As EventArgs) Handles btnB.Click
        btnB.Enabled = False
        GuessLetter(btnB.Text)
    End Sub

    Private Sub BtnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        btnC.Enabled = False
        GuessLetter(btnC.Text)
    End Sub

    Private Sub BtnD_Click(sender As Object, e As EventArgs) Handles btnD.Click
        btnD.Enabled = False
        GuessLetter(btnD.Text)
    End Sub

    Private Sub BtnE_Click(sender As Object, e As EventArgs) Handles btnE.Click
        btnE.Enabled = False
        GuessLetter(btnE.Text)
    End Sub

    Private Sub BtnF_Click(sender As Object, e As EventArgs) Handles btnF.Click
        btnF.Enabled = False
        GuessLetter(btnF.Text)
    End Sub

    Private Sub BtnG_Click(sender As Object, e As EventArgs) Handles btnG.Click
        btnG.Enabled = False
        GuessLetter(btnG.Text)
    End Sub

    Private Sub BtnH_Click(sender As Object, e As EventArgs) Handles btnH.Click
        btnH.Enabled = False
        GuessLetter(btnH.Text)
    End Sub

    Private Sub BtnI_Click(sender As Object, e As EventArgs) Handles btnI.Click
        btnI.Enabled = False
        GuessLetter(btnI.Text)
    End Sub

    Private Sub BtnJ_Click(sender As Object, e As EventArgs) Handles btnJ.Click
        btnJ.Enabled = False
        GuessLetter(btnJ.Text)
    End Sub

    Private Sub BtnK_Click(sender As Object, e As EventArgs) Handles btnK.Click
        btnK.Enabled = False
        GuessLetter(btnK.Text)
    End Sub

    Private Sub BtnL_Click(sender As Object, e As EventArgs) Handles btnL.Click
        btnL.Enabled = False
        GuessLetter(btnL.Text)
    End Sub

    Private Sub BtnM_Click(sender As Object, e As EventArgs) Handles btnM.Click
        btnM.Enabled = False
        GuessLetter(btnM.Text)
    End Sub

    Private Sub BtnN_Click(sender As Object, e As EventArgs) Handles btnN.Click
        btnN.Enabled = False
        GuessLetter(btnN.Text)
    End Sub

    Private Sub BtnO_Click(sender As Object, e As EventArgs) Handles btnO.Click
        btnO.Enabled = False
        GuessLetter(btnO.Text)
    End Sub

    Private Sub BtnP_Click(sender As Object, e As EventArgs) Handles btnP.Click
        btnP.Enabled = False
        GuessLetter(btnP.Text)
    End Sub

    Private Sub BtnQ_Click(sender As Object, e As EventArgs) Handles btnQ.Click
        btnQ.Enabled = False
        GuessLetter(btnQ.Text)
    End Sub

    Private Sub BtnR_Click(sender As Object, e As EventArgs) Handles btnR.Click
        btnR.Enabled = False
        GuessLetter(btnR.Text)
    End Sub

    Private Sub BtnS_Click(sender As Object, e As EventArgs) Handles btnS.Click
        btnS.Enabled = False
        GuessLetter(btnS.Text)
    End Sub

    Private Sub BtnT_Click(sender As Object, e As EventArgs) Handles btnT.Click
        btnT.Enabled = False
        GuessLetter(btnT.Text)
    End Sub

    Private Sub BtnU_Click(sender As Object, e As EventArgs) Handles btnU.Click
        btnU.Enabled = False
        GuessLetter(btnU.Text)
    End Sub

    Private Sub BtnV_Click(sender As Object, e As EventArgs) Handles btnV.Click
        btnV.Enabled = False
        GuessLetter(btnV.Text)
    End Sub

    Private Sub BtnW_Click(sender As Object, e As EventArgs) Handles btnW.Click
        btnW.Enabled = False
        GuessLetter(btnW.Text)
    End Sub

    Private Sub BtnX_Click(sender As Object, e As EventArgs) Handles btnX.Click
        btnX.Enabled = False
        GuessLetter(btnX.Text)
    End Sub

    Private Sub BtnY_Click(sender As Object, e As EventArgs) Handles btnY.Click
        btnY.Enabled = False
        GuessLetter(btnY.Text)
    End Sub

    Private Sub BtnZ_Click(sender As Object, e As EventArgs) Handles btnZ.Click
        btnZ.Enabled = False
        GuessLetter(btnZ.Text)
    End Sub

    Private Sub BtnBackHome_Click(sender As Object, e As EventArgs) Handles btnBackHome.Click

        Form4.Show()
        Me.Hide()
        My.Computer.Audio.Stop()

    End Sub

End Class