Public Class Form3

    Dim cny As Int16
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            If cny = 0 Then
                TextBox1.Text = 1
            End If
            If cny = 1 Then
                TextBox2.Text = 1
            End If
            If cny = 2 Then
                TextBox3.Text = 1
            End If
            If cny = 3 Then
                TextBox4.Text = 1
            End If
            If cny = 4 Then
                TextBox5.Text = 1
            End If

        End If
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            If cny = 0 Then
                TextBox1.Text = 0
            End If
            If cny = 1 Then
                TextBox2.Text = 0
            End If
            If cny = 2 Then
                TextBox3.Text = 0
            End If
            If cny = 3 Then
                TextBox4.Text = 0
            End If
            If cny = 4 Then
                TextBox5.Text = 0
            End If

        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            If cny = 0 Then
                TextBox1.Text = 0.5
            End If
            If cny = 1 Then
                TextBox2.Text = 0.5
            End If
            If cny = 2 Then
                TextBox3.Text = 0.5
            End If
            If cny = 3 Then
                TextBox4.Text = 0.5
            End If
            If cny = 4 Then
                TextBox5.Text = 0.5
            End If

        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            If cny = 0 Then
                TextBox1.Text = 0.75
            End If
            If cny = 1 Then
                TextBox2.Text = 0.75
            End If
            If cny = 2 Then
                TextBox3.Text = 0.75
            End If
            If cny = 3 Then
                TextBox4.Text = 0.75
            End If
            If cny = 4 Then
                TextBox5.Text = 0.75
            End If

        End If

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cny = cny + 1
        If cny = 1 Then
            Label2.Text = "Do You Experiance Headaches or  Muscle Tension"
        End If
        If cny = 2 Then
            Label2.Text = "During Work Hours Do You Have Trouble Focussing on Work"
        End If
        If cny = 3 Then
            Label2.Text = "Do You Feel Irritabe and annoyed over trivial issues"
        End If
        If cny = 4 Then
            Label2.Text = "Do You Feel Like withdrawing from family and friends and isolating yourself"
        End If

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox6.Text = Val(TextBox1.Text) + Val(TextBox2.Text) + Val(TextBox3.Text) + Val(TextBox4.Text) + Val(TextBox5.Text)
        If Val(TextBox6.Text) < 2.5 Then
            MsgBox("Thank You For Your Survey You are Stress Free")
            Form2.Close()
            Me.Close()
        End If
        If Val(TextBox6.Text) > 3.5 Then
            MsgBox("We Have Noticed Abnormal Stress Levels")
            Form4.Show()
            Me.Close()
        End If


    End Sub
End Class