Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AxWindowsMediaPlayer1.uiMode = "full"


        If Val(Form3.TextBox6.Text) > 4 And Rnd() < 0.5 Then
            AxWindowsMediaPlayer1.URL = "C:\videos\y1.mp4"
            AxWindowsMediaPlayer1.Ctlcontrols.play()
        End If

        If Val(Form3.TextBox6.Text) > 4 And Rnd() > 0.5 Then
            AxWindowsMediaPlayer1.URL = "C:\videos\y2.mp4"
            AxWindowsMediaPlayer1.Ctlcontrols.play()

        End If

        If Val(Form3.TextBox6.Text) < 4 And Rnd() < 0.5 Then
            AxWindowsMediaPlayer1.URL = "C:\videos\y3.mp4"
            AxWindowsMediaPlayer1.Ctlcontrols.play()
        End If

        If Val(Form3.TextBox6.Text) < 4 And Rnd() > 0.5 Then
            AxWindowsMediaPlayer1.URL = "C:\videos\y4.mp4"
            AxWindowsMediaPlayer1.Ctlcontrols.play()
        End If




    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AxWindowsMediaPlayer1.uiMode = "full"



        If Val(Form3.TextBox6.Text) > 4 And Rnd() < 0.5 Then
            AxWindowsMediaPlayer1.URL = "C:\videos\b1.mp4"
            AxWindowsMediaPlayer1.Ctlcontrols.play()
        End If

        If Val(Form3.TextBox6.Text) > 4 And Rnd() > 0.5 Then
            AxWindowsMediaPlayer1.URL = "C:\videos\b2.mp4"
            AxWindowsMediaPlayer1.Ctlcontrols.play()

        End If

        If Val(Form3.TextBox6.Text) < 4 And Rnd() < 0.5 Then
            AxWindowsMediaPlayer1.URL = "C:\videos\b3.mp4"
            AxWindowsMediaPlayer1.Ctlcontrols.play()
        End If

        If Val(Form3.TextBox6.Text) < 4 And Rnd() > 0.5 Then
            AxWindowsMediaPlayer1.URL = "C:\videos\b4.mp4"
            AxWindowsMediaPlayer1.Ctlcontrols.play()
        End If



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AxWindowsMediaPlayer1.uiMode = "full"



        If Val(Form3.TextBox6.Text) > 4 And Rnd() < 0.5 Then
            AxWindowsMediaPlayer1.URL = "C:\videos\s1.mp4"
            AxWindowsMediaPlayer1.Ctlcontrols.play()
        End If

        If Val(Form3.TextBox6.Text) > 4 And Rnd() > 0.5 Then
            AxWindowsMediaPlayer1.URL = "C:\videos\s2.mp4"
            AxWindowsMediaPlayer1.Ctlcontrols.play()

        End If

        If Val(Form3.TextBox6.Text) < 4 And Rnd() < 0.5 Then
            AxWindowsMediaPlayer1.URL = "C:\videos\s3.mp4"
            AxWindowsMediaPlayer1.Ctlcontrols.play()
        End If

        If Val(Form3.TextBox6.Text) < 4 And Rnd() > 0.5 Then
            AxWindowsMediaPlayer1.URL = "C:\videos\s4.mp4"
            AxWindowsMediaPlayer1.Ctlcontrols.play()
        End If



    End Sub
End Class