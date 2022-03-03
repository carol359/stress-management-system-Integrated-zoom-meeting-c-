
Imports System.Management
Imports System.Net.NetworkInformation


Public Class Form1
    Dim a, aa As Integer
    Dim b, bb As Integer
    Dim ll As Long
    Dim cfl, ctfl, cft As Integer
    Dim tt As Long
    Dim amt As Integer
    Dim win As Integer

    Dim gg As Long
    Dim ctt As Integer
    Dim bt As Integer
    Dim l As Long
    Dim iff As Integer
    Dim att As Integer

    Dim webClient As New System.Net.WebClient
    Public Declare Sub mouse_event Lib "user32" Alias "mouse_event" (ByVal dwFlags As Long) 'Long may have to change to type Int32 or DWORD
    'LEFTDOWN = &H2
    'LEFTUP = &H4
    'RIGHTDOWN = &H8
    'RIGHTUP = &H10
    'MIDDLEUP = &H40
    'MIDDLEDOWN = &H20

    Declare Function mouse_event1 Lib "user32" Alias "mouse_event" (ByVal dwFlags As Int32, ByVal dX As Int32, ByVal dY As Int32, ByVal cButtons As Int32, ByVal dwExtraInfo As Int32) As Boolean




    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Function getMacAddress()
        Dim nics() As NetworkInterface = NetworkInterface.GetAllNetworkInterfaces()
        Return nics(1).GetPhysicalAddress.ToString
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        TextBox24.Text = l

        Dim bmp As New Bitmap(1, 1)
        Using g As Graphics = Graphics.FromImage(bmp)
            g.CopyFromScreen(Windows.Forms.Cursor.Position, New Point(0, 0), New Size(1, 1))
        End Using
        Dim pixel As Drawing.Color = bmp.GetPixel(0, 0)


        Label1.Text = bmp.GetPixel(0, 0).ToString

        If Mid(Label1.Text, 20, 1) = "," Then
            TextBox4.Text = Mid(Label1.Text, 17, 3)

            If Mid(Label1.Text, 27, 1) = "," Then
                TextBox5.Text = Mid(Label1.Text, 24, 3)


                If Mid(Label1.Text, 34, 1) = "]" Then
                    TextBox6.Text = Mid(Label1.Text, 31, 3)
                End If
                If Mid(Label1.Text, 33, 1) = "]" Then
                    TextBox6.Text = Mid(Label1.Text, 31, 2)
                End If
                If Mid(Label1.Text, 32, 1) = "]" Then
                    TextBox6.Text = Mid(Label1.Text, 31, 1)
                End If



            End If
            If Mid(Label1.Text, 26, 1) = "," Then
                TextBox5.Text = Mid(Label1.Text, 24, 2)


                If Mid(Label1.Text, 33, 1) = "]" Then
                    TextBox6.Text = Mid(Label1.Text, 30, 3)
                End If
                If Mid(Label1.Text, 32, 1) = "]" Then
                    TextBox6.Text = Mid(Label1.Text, 30, 2)
                End If
                If Mid(Label1.Text, 31, 1) = "]" Then
                    TextBox6.Text = Mid(Label1.Text, 30, 1)
                End If



            End If
            If Mid(Label1.Text, 25, 1) = "," Then
                TextBox5.Text = Mid(Label1.Text, 24, 1)


                If Mid(Label1.Text, 32, 1) = "]" Then
                    TextBox6.Text = Mid(Label1.Text, 29, 3)
                End If
                If Mid(Label1.Text, 31, 1) = "]" Then
                    TextBox6.Text = Mid(Label1.Text, 29, 2)
                End If
                If Mid(Label1.Text, 30, 1) = "]" Then
                    TextBox6.Text = Mid(Label1.Text, 29, 1)
                End If



            End If


        End If



        If Mid(Label1.Text, 19, 1) = "," Then
            TextBox4.Text = Mid(Label1.Text, 17, 2)


            If Mid(Label1.Text, 26, 1) = "," Then
                TextBox5.Text = Mid(Label1.Text, 23, 3)


                If Mid(Label1.Text, 33, 1) = "]" Then
                    TextBox6.Text = Mid(Label1.Text, 30, 3)
                End If
                If Mid(Label1.Text, 32, 1) = "]" Then
                    TextBox6.Text = Mid(Label1.Text, 30, 2)
                End If
                If Mid(Label1.Text, 31, 1) = "]" Then
                    TextBox6.Text = Mid(Label1.Text, 30, 1)
                End If



            End If

            If Mid(Label1.Text, 25, 1) = "," Then
                TextBox5.Text = Mid(Label1.Text, 23, 2)


                If Mid(Label1.Text, 32, 1) = "]" Then
                    TextBox6.Text = Mid(Label1.Text, 29, 3)
                End If
                If Mid(Label1.Text, 31, 1) = "]" Then
                    TextBox6.Text = Mid(Label1.Text, 29, 2)
                End If
                If Mid(Label1.Text, 30, 1) = "]" Then
                    TextBox6.Text = Mid(Label1.Text, 29, 1)
                End If



            End If
            If Mid(Label1.Text, 24, 1) = "," Then
                TextBox5.Text = Mid(Label1.Text, 23, 1)


                If Mid(Label1.Text, 31, 1) = "]" Then
                    TextBox6.Text = Mid(Label1.Text, 28, 3)
                End If
                If Mid(Label1.Text, 30, 1) = "]" Then
                    TextBox6.Text = Mid(Label1.Text, 28, 2)
                End If
                If Mid(Label1.Text, 29, 1) = "]" Then
                    TextBox6.Text = Mid(Label1.Text, 28, 1)
                End If



            End If


        End If

        If Mid(Label1.Text, 18, 1) = "," Then
            TextBox4.Text = Mid(Label1.Text, 17, 1)




            If Mid(Label1.Text, 25, 1) = "," Then
                TextBox5.Text = Mid(Label1.Text, 22, 3)


                If Mid(Label1.Text, 32, 1) = "]" Then
                    TextBox6.Text = Mid(Label1.Text, 29, 3)
                End If
                If Mid(Label1.Text, 31, 1) = "]" Then
                    TextBox6.Text = Mid(Label1.Text, 29, 2)
                End If
                If Mid(Label1.Text, 30, 1) = "]" Then
                    TextBox6.Text = Mid(Label1.Text, 29, 1)
                End If



            End If

            If Mid(Label1.Text, 24, 1) = "," Then
                TextBox5.Text = Mid(Label1.Text, 22, 2)


                If Mid(Label1.Text, 31, 1) = "]" Then
                    TextBox6.Text = Mid(Label1.Text, 28, 3)
                End If
                If Mid(Label1.Text, 30, 1) = "]" Then
                    TextBox6.Text = Mid(Label1.Text, 28, 2)
                End If
                If Mid(Label1.Text, 29, 1) = "]" Then
                    TextBox6.Text = Mid(Label1.Text, 28, 1)
                End If



            End If
            If Mid(Label1.Text, 23, 1) = "," Then
                TextBox5.Text = Mid(Label1.Text, 22, 1)
                If Mid(Label1.Text, 30, 1) = "]" Then
                    TextBox6.Text = Mid(Label1.Text, 27, 3)
                End If
                If Mid(Label1.Text, 29, 1) = "]" Then
                    TextBox6.Text = Mid(Label1.Text, 27, 2)
                End If
                If Mid(Label1.Text, 28, 1) = "]" Then
                    TextBox6.Text = Mid(Label1.Text, 27, 1)
                End If

            End If
        End If


        If cft = 1 Then
            If Val(TextBox4.Text) > 54 And Val(TextBox4.Text) < 60 And Val(TextBox5.Text) > 54 And Val(TextBox5.Text) < 60 And Val(TextBox6.Text) > 54 And Val(TextBox6.Text) < 60 Then
                mouse_event1(&H2, 0, 0, 0, 0)
                mouse_event1(&H4, 0, 0, 0, 0)
                Cursor.Position = New Point(a, b)
                TextBox3.Text = TextBox3.Text + "Reset 3" + vbCrLf
            Else
                cft = 0
                'TextBox3.Text = TextBox3.Text + "Reset 4" + vbCrLf
                Cursor.Position = New Point(a, b)
            End If
        End If

        TextBox17.Text = cft

        If Val(TextBox4.Text) > 30 And Val(TextBox4.Text) < 60 Then
            If Val(TextBox5.Text) > 30 And Val(TextBox5.Text) < 60 Then
                If Val(TextBox6.Text) > 30 And Val(TextBox6.Text) < 60 Then
                    TextBox2.Text = Val(TextBox2.Text) + 1
                End If
            End If
        End If

        If Val(TextBox4.Text) > 180 And Val(TextBox4.Text) < 260 Then
            If Val(TextBox5.Text) > 10 And Val(TextBox5.Text) < 100 Then
                If Val(TextBox6.Text) >= 0 And Val(TextBox6.Text) < 80 Then
                    TextBox1.Text = Val(TextBox1.Text) + 1
                End If
            End If
        End If




        If Val(TextBox4.Text) > 250 And Val(TextBox4.Text) < 260 Then
            If Val(TextBox5.Text) >= 0 And Val(TextBox5.Text) < 10 Then
                If Val(TextBox6.Text) >= 0 And Val(TextBox6.Text) < 10 Then


                    If Val(TextBox18.Text) = 4 Then
                        If cfl = 0 Then
                            cfl = 1
                        ElseIf cfl = 1 Then
                            cfl = 2
                        ElseIf cfl = 2 Then
                            cfl = 3
                        ElseIf cfl = 3 Then
                            cfl = 4
                        Else
                            win = win - 155
                            cfl = 0
                        End If
                    End If


                    If Val(TextBox18.Text) = 3 Then
                        If cfl = 0 Then
                            cfl = 1
                        ElseIf cfl = 1 Then
                            cfl = 2
                        ElseIf cfl = 2 Then
                            cfl = 3
                        Else
                            win = win - 75
                            cfl = 0
                        End If
                    End If

                    If Val(TextBox18.Text) = 2 Then
                        If cfl = 0 Then
                            cfl = 1
                        ElseIf cfl = 1 Then
                            cfl = 2
                        Else
                            win = win - 35
                            cfl = 0
                        End If
                    End If


                    If Val(TextBox18.Text) = 1 Then
                        If cfl = 0 Then
                            cfl = 1
                        Else
                            win = win - 15
                            cfl = 0
                        End If
                    End If


                    If Val(TextBox18.Text) = 0 Then
                        If cfl = 0 Then
                            win = win - 5
                            cfl = 0
                        End If
                    End If



                    Cursor.Position = New Point(164, 180)
                    mouse_event1(&H2, 0, 0, 0, 0)
                    mouse_event1(&H4, 0, 0, 0, 0)

                    TextBox3.Text = TextBox3.Text + "Bet on Red" + vbCrLf
                End If
            End If
        End If

        If Val(TextBox4.Text) >= 0 And Val(TextBox4.Text) < 10 Then
            If Val(TextBox5.Text) >= 0 And Val(TextBox5.Text) < 10 Then
                If Val(TextBox6.Text) >= 0 And Val(TextBox6.Text) < 10 Then
                    ''TextBox3.Text = TextBox3.Text + "Bet on Red" + vbCrLf
                    If Val(TextBox18.Text) = 4 Then
                        If cfl = 0 Then
                            cfl = 1
                        ElseIf cfl = 1 Then
                            cfl = 2
                        ElseIf cfl = 2 Then
                            cfl = 3
                        ElseIf cfl = 3 Then
                            cfl = 4
                        Else
                            win = win - 155
                            cfl = 0
                        End If
                    End If


                    If Val(TextBox18.Text) = 3 Then
                        If cfl = 0 Then
                            cfl = 1
                        ElseIf cfl = 1 Then
                            cfl = 2
                        ElseIf cfl = 2 Then
                            cfl = 3
                        Else
                            win = win - 75
                            cfl = 0
                        End If
                    End If

                    If Val(TextBox18.Text) = 2 Then
                        If cfl = 0 Then
                            cfl = 1
                        ElseIf cfl = 1 Then
                            cfl = 2
                        Else
                            win = win - 35
                            cfl = 0
                        End If
                    End If


                    If Val(TextBox18.Text) = 1 Then
                        If cfl = 0 Then
                            cfl = 1
                        Else
                            win = win - 15
                            cfl = 0
                        End If
                    End If


                    If Val(TextBox18.Text) = 0 Then
                        If cfl = 0 Then
                            win = win - 5
                            cfl = 0
                        End If
                    End If



                    Cursor.Position = New Point(164, 180)
                    mouse_event1(&H2, 0, 0, 0, 0)
                    mouse_event1(&H4, 0, 0, 0, 0)
                    TextBox3.Text = TextBox3.Text + "Bet on Black" + vbCrLf
                End If
            End If
        End If

        If Val(TextBox4.Text) >= 0 And Val(TextBox4.Text) < 10 Then
            If Val(TextBox5.Text) >= 0 And Val(TextBox5.Text) < 10 Then
                If Val(TextBox6.Text) >= 10 And Val(TextBox6.Text) < 20 Then
                    ''TextBox3.Text = TextBox3.Text + "Bet on Red" + vbCrLf
                    Cursor.Position = New Point(164, 180)
                    mouse_event1(&H2, 0, 0, 0, 0)
                    mouse_event1(&H4, 0, 0, 0, 0)
                    cfl = 0
                    ctfl = 0
                    TextBox3.Text = TextBox3.Text + "Win Rs.5" + vbCrLf
                    tt = 0
                    win = win + 5
                End If
            End If
        End If

        TextBox14.Text = ctfl
        TextBox13.Text = cfl


        If Val(TextBox4.Text) > 160 And Val(TextBox4.Text) < 200 And Val(TextBox5.Text) > 10 And Val(TextBox5.Text) < 100 And Val(TextBox6.Text) >= 0 And Val(TextBox6.Text) < 80 Then
            If Val(TextBox11.Text) >= Val(TextBox7.Text) Then
                tt = 0
                If cfl = 0 Then
                    mouse_event1(&H2, 0, 0, 0, 0)
                    mouse_event1(&H4, 0, 0, 0, 0)

                    For bt = 1 To att
                        Cursor.Position = New Point(751, 484)
                        mouse_event1(&H2, 0, 0, 0, 0)
                        mouse_event1(&H4, 0, 0, 0, 0)
                    Next bt
                    Cursor.Position = New Point(780, 592)
                    ''Timer1.Enabled = False
                    TextBox3.Text = TextBox3.Text + "Red Rs.5" + vbCrLf
                    amt = amt + 5
                    ctfl = 1
                ElseIf cfl = 1 Then
                    mouse_event1(&H2, 0, 0, 0, 0)
                    mouse_event1(&H4, 0, 0, 0, 0)

                    For bt = 1 To att
                        Cursor.Position = New Point(751, 484)
                        mouse_event1(&H2, 0, 0, 0, 0)
                        mouse_event1(&H4, 0, 0, 0, 0)
                        Cursor.Position = New Point(751, 484)
                        mouse_event1(&H2, 0, 0, 0, 0)
                        mouse_event1(&H4, 0, 0, 0, 0)
                    Next bt
                    Cursor.Position = New Point(780, 592)
                    ''Timer1.Enabled = False
                    TextBox3.Text = TextBox3.Text + "Red Rs.10" + vbCrLf
                    amt = amt + 10

                    ctfl = 1
                ElseIf cfl = 2 Then
                    mouse_event1(&H2, 0, 0, 0, 0)
                    mouse_event1(&H4, 0, 0, 0, 0)

                    For bt = 1 To att

                        Cursor.Position = New Point(751, 484)
                        mouse_event1(&H2, 0, 0, 0, 0)
                        mouse_event1(&H4, 0, 0, 0, 0)
                        Cursor.Position = New Point(751, 484)
                        mouse_event1(&H2, 0, 0, 0, 0)
                        mouse_event1(&H4, 0, 0, 0, 0)
                        Cursor.Position = New Point(751, 484)
                        mouse_event1(&H2, 0, 0, 0, 0)
                        mouse_event1(&H4, 0, 0, 0, 0)
                        Cursor.Position = New Point(751, 484)
                        mouse_event1(&H2, 0, 0, 0, 0)
                        mouse_event1(&H4, 0, 0, 0, 0)
                    Next bt
                    Cursor.Position = New Point(780, 592)
                    ''Timer1.Enabled = False
                    TextBox3.Text = TextBox3.Text + "Red Rs.20" + vbCrLf
                    amt = amt + 20

                    ctfl = 1
                ElseIf cfl = 3 Then
                    mouse_event1(&H2, 0, 0, 0, 0)
                    mouse_event1(&H4, 0, 0, 0, 0)
                    For bt = 1 To att

                        Cursor.Position = New Point(751, 484)
                        mouse_event1(&H2, 0, 0, 0, 0)
                        mouse_event1(&H4, 0, 0, 0, 0)
                        Cursor.Position = New Point(751, 484)
                        mouse_event1(&H2, 0, 0, 0, 0)
                        mouse_event1(&H4, 0, 0, 0, 0)
                        Cursor.Position = New Point(751, 484)
                        mouse_event1(&H2, 0, 0, 0, 0)
                        mouse_event1(&H4, 0, 0, 0, 0)
                        Cursor.Position = New Point(751, 484)
                        mouse_event1(&H2, 0, 0, 0, 0)
                        mouse_event1(&H4, 0, 0, 0, 0)
                        Cursor.Position = New Point(751, 484)
                        mouse_event1(&H2, 0, 0, 0, 0)
                        mouse_event1(&H4, 0, 0, 0, 0)
                        Cursor.Position = New Point(751, 484)
                        mouse_event1(&H2, 0, 0, 0, 0)
                        mouse_event1(&H4, 0, 0, 0, 0)
                        Cursor.Position = New Point(751, 484)
                        mouse_event1(&H2, 0, 0, 0, 0)
                        mouse_event1(&H4, 0, 0, 0, 0)
                        Cursor.Position = New Point(751, 484)
                        mouse_event1(&H2, 0, 0, 0, 0)
                        mouse_event1(&H4, 0, 0, 0, 0)
                    Next bt
                    Cursor.Position = New Point(780, 592)
                    ''Timer1.Enabled = False
                    TextBox3.Text = TextBox3.Text + "Red Rs.40" + vbCrLf
                    amt = amt + 40

                    ctfl = 1
                ElseIf cfl = 4 Then
                    mouse_event1(&H2, 0, 0, 0, 0)
                    mouse_event1(&H4, 0, 0, 0, 0)

                    For bt = 1 To att

                        Cursor.Position = New Point(751, 484)
                        mouse_event1(&H2, 0, 0, 0, 0)
                        mouse_event1(&H4, 0, 0, 0, 0)
                        Cursor.Position = New Point(751, 484)
                        mouse_event1(&H2, 0, 0, 0, 0)
                        mouse_event1(&H4, 0, 0, 0, 0)
                        Cursor.Position = New Point(751, 484)
                        mouse_event1(&H2, 0, 0, 0, 0)
                        mouse_event1(&H4, 0, 0, 0, 0)
                        Cursor.Position = New Point(751, 484)
                        mouse_event1(&H2, 0, 0, 0, 0)
                        mouse_event1(&H4, 0, 0, 0, 0)
                        Cursor.Position = New Point(751, 484)
                        mouse_event1(&H2, 0, 0, 0, 0)
                        mouse_event1(&H4, 0, 0, 0, 0)
                        Cursor.Position = New Point(751, 484)
                        mouse_event1(&H2, 0, 0, 0, 0)
                        mouse_event1(&H4, 0, 0, 0, 0)
                        Cursor.Position = New Point(751, 484)
                        mouse_event1(&H2, 0, 0, 0, 0)
                        mouse_event1(&H4, 0, 0, 0, 0)
                        Cursor.Position = New Point(751, 484)
                        mouse_event1(&H2, 0, 0, 0, 0)
                        mouse_event1(&H4, 0, 0, 0, 0)
                        Cursor.Position = New Point(751, 484)
                        mouse_event1(&H2, 0, 0, 0, 0)
                        mouse_event1(&H4, 0, 0, 0, 0)
                        Cursor.Position = New Point(751, 484)
                        mouse_event1(&H2, 0, 0, 0, 0)
                        mouse_event1(&H4, 0, 0, 0, 0)
                        Cursor.Position = New Point(751, 484)
                        mouse_event1(&H2, 0, 0, 0, 0)
                        mouse_event1(&H4, 0, 0, 0, 0)
                        Cursor.Position = New Point(751, 484)
                        mouse_event1(&H2, 0, 0, 0, 0)
                        mouse_event1(&H4, 0, 0, 0, 0)
                        Cursor.Position = New Point(751, 484)
                        mouse_event1(&H2, 0, 0, 0, 0)
                        mouse_event1(&H4, 0, 0, 0, 0)
                        Cursor.Position = New Point(751, 484)
                        mouse_event1(&H2, 0, 0, 0, 0)
                        mouse_event1(&H4, 0, 0, 0, 0)
                        Cursor.Position = New Point(751, 484)
                        mouse_event1(&H2, 0, 0, 0, 0)
                        mouse_event1(&H4, 0, 0, 0, 0)
                        Cursor.Position = New Point(751, 484)
                        mouse_event1(&H2, 0, 0, 0, 0)
                        mouse_event1(&H4, 0, 0, 0, 0)
                    Next bt
                    Cursor.Position = New Point(780, 592)
                    ''Timer1.Enabled = False
                    TextBox3.Text = TextBox3.Text + "Red Rs.80" + vbCrLf
                    amt = amt + 80

                    ctfl = 1
                End If
            ElseIf Val(TextBox10.Text) >= Val(TextBox7.Text) Then
                tt = 0
                If cfl = 0 Then
                    mouse_event1(&H2, 0, 0, 0, 0)
                    mouse_event1(&H4, 0, 0, 0, 0)
                    For bt = 1 To att

                        Cursor.Position = New Point(814, 511)
                        mouse_event1(&H2, 0, 0, 0, 0)
                        mouse_event1(&H4, 0, 0, 0, 0)
                    Next bt
                    Cursor.Position = New Point(780, 592)
                    '' Timer1.Enabled = False
                    TextBox3.Text = TextBox3.Text + "Black Rs.5" + vbCrLf
                    amt = amt + 5

                    ctfl = 2
                ElseIf cfl = 1 Then
                    mouse_event1(&H2, 0, 0, 0, 0)
                    mouse_event1(&H4, 0, 0, 0, 0)

                    For bt = 1 To att

                        Cursor.Position = New Point(814, 511)
                        mouse_event1(&H2, 0, 0, 0, 0)
                        mouse_event1(&H4, 0, 0, 0, 0)
                        Cursor.Position = New Point(814, 511)
                        mouse_event1(&H2, 0, 0, 0, 0)
                        mouse_event1(&H4, 0, 0, 0, 0)
                    Next bt
                    Cursor.Position = New Point(780, 592)
                    '' Timer1.Enabled = False
                    TextBox3.Text = TextBox3.Text + "Black Rs.10" + vbCrLf
                    amt = amt + 10

                    ctfl = 2
                ElseIf cfl = 2 Then
                    mouse_event1(&H2, 0, 0, 0, 0)
                    mouse_event1(&H4, 0, 0, 0, 0)
                    For bt = 1 To att

                        Cursor.Position = New Point(814, 511)
                        mouse_event1(&H2, 0, 0, 0, 0)
                        mouse_event1(&H4, 0, 0, 0, 0)
                        Cursor.Position = New Point(814, 511)
                        mouse_event1(&H2, 0, 0, 0, 0)
                        mouse_event1(&H4, 0, 0, 0, 0)
                        Cursor.Position = New Point(814, 511)
                        mouse_event1(&H2, 0, 0, 0, 0)
                        mouse_event1(&H4, 0, 0, 0, 0)
                        Cursor.Position = New Point(814, 511)
                        mouse_event1(&H2, 0, 0, 0, 0)
                        mouse_event1(&H4, 0, 0, 0, 0)
                    Next bt

                    Cursor.Position = New Point(780, 592)
                    '' Timer1.Enabled = False
                    TextBox3.Text = TextBox3.Text + "Black Rs.20" + vbCrLf
                    amt = amt + 20

                    ctfl = 2
                ElseIf cfl = 3 Then
                    mouse_event1(&H2, 0, 0, 0, 0)
                    mouse_event1(&H4, 0, 0, 0, 0)
                    For bt = 1 To att

                        Cursor.Position = New Point(814, 511)
                        mouse_event1(&H2, 0, 0, 0, 0)
                        mouse_event1(&H4, 0, 0, 0, 0)
                        Cursor.Position = New Point(814, 511)


                        mouse_event1(&H2, 0, 0, 0, 0)
                        mouse_event1(&H4, 0, 0, 0, 0)
                        Cursor.Position = New Point(814, 511)
                        mouse_event1(&H2, 0, 0, 0, 0)
                        mouse_event1(&H4, 0, 0, 0, 0)
                        Cursor.Position = New Point(814, 511)
                        mouse_event1(&H2, 0, 0, 0, 0)
                        mouse_event1(&H4, 0, 0, 0, 0)
                        Cursor.Position = New Point(814, 511)
                        mouse_event1(&H2, 0, 0, 0, 0)
                        mouse_event1(&H4, 0, 0, 0, 0)
                        Cursor.Position = New Point(814, 511)
                        mouse_event1(&H2, 0, 0, 0, 0)
                        mouse_event1(&H4, 0, 0, 0, 0)
                        Cursor.Position = New Point(814, 511)
                        mouse_event1(&H2, 0, 0, 0, 0)
                        mouse_event1(&H4, 0, 0, 0, 0)
                        Cursor.Position = New Point(814, 511)
                        mouse_event1(&H2, 0, 0, 0, 0)
                        mouse_event1(&H4, 0, 0, 0, 0)
                    Next bt
                    Cursor.Position = New Point(780, 592)
                    '' Timer1.Enabled = False
                    TextBox3.Text = TextBox3.Text + "Black Rs.40" + vbCrLf
                    amt = amt + 40

                    ctfl = 2
                ElseIf cfl = 4 Then
                    mouse_event1(&H2, 0, 0, 0, 0)
                    mouse_event1(&H4, 0, 0, 0, 0)
                    For bt = 1 To 5

                        Cursor.Position = New Point(814, 511)
                        mouse_event1(&H2, 0, 0, 0, 0)
                        mouse_event1(&H4, 0, 0, 0, 0)
                        Cursor.Position = New Point(814, 511)
                        mouse_event1(&H2, 0, 0, 0, 0)
                        mouse_event1(&H4, 0, 0, 0, 0)
                        Cursor.Position = New Point(814, 511)
                        mouse_event1(&H2, 0, 0, 0, 0)
                        mouse_event1(&H4, 0, 0, 0, 0)
                        Cursor.Position = New Point(814, 511)
                        mouse_event1(&H2, 0, 0, 0, 0)
                        mouse_event1(&H4, 0, 0, 0, 0)
                        Cursor.Position = New Point(814, 511)
                        mouse_event1(&H2, 0, 0, 0, 0)
                        mouse_event1(&H4, 0, 0, 0, 0)
                        Cursor.Position = New Point(814, 511)
                        mouse_event1(&H2, 0, 0, 0, 0)
                        mouse_event1(&H4, 0, 0, 0, 0)
                        Cursor.Position = New Point(814, 511)
                        mouse_event1(&H2, 0, 0, 0, 0)
                        mouse_event1(&H4, 0, 0, 0, 0)
                        Cursor.Position = New Point(814, 511)
                        mouse_event1(&H2, 0, 0, 0, 0)
                        mouse_event1(&H4, 0, 0, 0, 0)
                        Cursor.Position = New Point(814, 511)
                        mouse_event1(&H2, 0, 0, 0, 0)
                        mouse_event1(&H4, 0, 0, 0, 0)
                        Cursor.Position = New Point(814, 511)
                        mouse_event1(&H2, 0, 0, 0, 0)
                        mouse_event1(&H4, 0, 0, 0, 0)
                        Cursor.Position = New Point(814, 511)
                        mouse_event1(&H2, 0, 0, 0, 0)
                        mouse_event1(&H4, 0, 0, 0, 0)
                        Cursor.Position = New Point(814, 511)
                        mouse_event1(&H2, 0, 0, 0, 0)
                        mouse_event1(&H4, 0, 0, 0, 0)
                        Cursor.Position = New Point(814, 511)
                        mouse_event1(&H2, 0, 0, 0, 0)
                        mouse_event1(&H4, 0, 0, 0, 0)
                        Cursor.Position = New Point(814, 511)
                        mouse_event1(&H2, 0, 0, 0, 0)
                        mouse_event1(&H4, 0, 0, 0, 0)
                        Cursor.Position = New Point(814, 511)
                        mouse_event1(&H2, 0, 0, 0, 0)
                        mouse_event1(&H4, 0, 0, 0, 0)
                        Cursor.Position = New Point(814, 511)
                        mouse_event1(&H2, 0, 0, 0, 0)
                        mouse_event1(&H4, 0, 0, 0, 0)
                    Next bt
                    Cursor.Position = New Point(780, 592)
                    '' Timer1.Enabled = False
                    TextBox3.Text = TextBox3.Text + "Black Rs.80" + vbCrLf
                    amt = amt + 80

                    ctfl = 2



                End If
            ElseIf tt >= Val(TextBox22.Text) Then
                TextBox3.Text = TextBox3.Text + "Double bet Rs.10" + vbCrLf
                mouse_event1(&H2, 0, 0, 0, 0)
                mouse_event1(&H4, 0, 0, 0, 0)
                Cursor.Position = New Point(751, 484)
                mouse_event1(&H2, 0, 0, 0, 0)
                mouse_event1(&H4, 0, 0, 0, 0)
                Cursor.Position = New Point(814, 511)
                mouse_event1(&H2, 0, 0, 0, 0)
                mouse_event1(&H4, 0, 0, 0, 0)
                Cursor.Position = New Point(780, 592)
                'amt = amt + 5
                tt = 0
            Else
                Cursor.Position = New Point(164, 180)
                mouse_event1(&H2, 0, 0, 0, 0)
                mouse_event1(&H4, 0, 0, 0, 0)
                'cfl = 0
                ctfl = 0
                'TextBox3.Text = TextBox3.Text + "Reset 2" + vbCrLf
            End If
        End If




        TextBox10.Text = Int(Val(TextBox1.Text) / 3)

        TextBox11.Text = Int(Val(TextBox2.Text) / 3)



        Dim p As New Point
        p.X = (Me.Width / 2) - (Label1.Width / 2)
        p.Y = Label1.Top
        Label1.Location = p
        PictureBox1.BackColor = pixel
        Me.Invalidate()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = False
        TextBox7.Text = 4
        TextBox18.Text = 4
        TextBox22.Text = 1500
        TextBox23.Text = 1

        Dim mac As String
        mac = getMacAddress()
        TextBox12.Text = mac
        'MsgBox(mac)
        'If TextBox12.Text <> "02A08C85C101" Then
        If TextBox12.Text <> "161731A954BD" Then
        End If



    End Sub




    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick

        If l < 2000 Then
            l = l + 1
        Else
            l = 0
        End If

        If TextBox7.Text = 6 Then
            If l < 10 Then
                Cursor.Position = New Point(978, 224)
            ElseIf l < 20 Then
                Cursor.Position = New Point(996, 224)
            ElseIf l < 30 Then
                Cursor.Position = New Point(1013, 224)
            ElseIf l < 40 Then
                Cursor.Position = New Point(1030, 224)
            ElseIf l < 50 Then
                Cursor.Position = New Point(1046, 224)
            ElseIf l < 60 Then
                Cursor.Position = New Point(1062, 224)
            ElseIf l < 70 Then
                Cursor.Position = New Point(710, 598)
                l = 80
            End If
        End If

        If TextBox7.Text = 5 Then
            If l < 10 Then
                Cursor.Position = New Point(978, 224)
            ElseIf l < 20 Then
                Cursor.Position = New Point(996, 224)
            ElseIf l < 30 Then
                Cursor.Position = New Point(1013, 224)
            ElseIf l < 40 Then
                Cursor.Position = New Point(1030, 224)
            ElseIf l < 50 Then
                Cursor.Position = New Point(1046, 224)
            ElseIf l < 60 Then
                Cursor.Position = New Point(710, 598)
                l = 80
            End If
        End If

        If TextBox7.Text = 4 Then
            If l < 10 Then
                Cursor.Position = New Point(978, 224)
            ElseIf l < 20 Then
                Cursor.Position = New Point(996, 224)
            ElseIf l < 30 Then
                Cursor.Position = New Point(1013, 224)
            ElseIf l < 40 Then
                Cursor.Position = New Point(1030, 224)
            ElseIf l < 50 Then
                Cursor.Position = New Point(710, 598)
                l = 80
            End If


        End If

        If TextBox7.Text = 2 Then
            If l < 10 Then
                Cursor.Position = New Point(978, 224)
            ElseIf l < 20 Then
                Cursor.Position = New Point(996, 224)
            ElseIf l < 30 Then
                Cursor.Position = New Point(710, 598)
                l = 80
            End If

        End If




    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        MsgBox("Click")
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        TextBox8.Text = MousePosition.X
        TextBox9.Text = MousePosition.Y


    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBox10.TextChanged

    End Sub


    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        'Timer7.Enabled = True
        'Process.Start("C:\Users\Acer-Predator\Desktop\Miner\WindowsApp1\unmine.exe")

        ' Create a request using a URL that can receive a post. 
        Dim webClient As New System.Net.WebClient
        Dim result As String = webClient.DownloadString("http://iotclouddata.com/project22/zoom/get-meetings.php")
        TextBox3.Text = result
        Dim ri As Integer
        For ri = 1 To 5000


            If Mid(result, ri, 8) = "duration" Then
                TextBox26.Text = Mid(result, ri + 10, 3)
                TextBox28.Text = Val(TextBox28.Text) + Val(TextBox26.Text)
            End If
        Next
    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick


        Dim bmp As New Bitmap(1, 1)
        Using g As Graphics = Graphics.FromImage(bmp)
            g.CopyFromScreen(Windows.Forms.Cursor.Position, New Point(0, 0), New Size(1, 1))
        End Using



        Dim pixel As Drawing.Color = bmp.GetPixel(0, 0)


        Label1.Text = bmp.GetPixel(0, 0).ToString



        If Mid(Label1.Text, 20, 1) = "," Then
            TextBox4.Text = Mid(Label1.Text, 17, 3)

            If Mid(Label1.Text, 27, 1) = "," Then
                TextBox5.Text = Mid(Label1.Text, 24, 3)


                If Mid(Label1.Text, 34, 1) = "]" Then
                    TextBox6.Text = Mid(Label1.Text, 31, 3)
                End If
                If Mid(Label1.Text, 33, 1) = "]" Then
                    TextBox6.Text = Mid(Label1.Text, 31, 2)
                End If
                If Mid(Label1.Text, 32, 1) = "]" Then
                    TextBox6.Text = Mid(Label1.Text, 31, 1)
                End If



            End If
            If Mid(Label1.Text, 26, 1) = "," Then
                TextBox5.Text = Mid(Label1.Text, 24, 2)


                If Mid(Label1.Text, 33, 1) = "]" Then
                    TextBox6.Text = Mid(Label1.Text, 30, 3)
                End If
                If Mid(Label1.Text, 32, 1) = "]" Then
                    TextBox6.Text = Mid(Label1.Text, 30, 2)
                End If
                If Mid(Label1.Text, 31, 1) = "]" Then
                    TextBox6.Text = Mid(Label1.Text, 30, 1)
                End If



            End If
            If Mid(Label1.Text, 25, 1) = "," Then
                TextBox5.Text = Mid(Label1.Text, 24, 1)


                If Mid(Label1.Text, 32, 1) = "]" Then
                    TextBox6.Text = Mid(Label1.Text, 29, 3)
                End If
                If Mid(Label1.Text, 31, 1) = "]" Then
                    TextBox6.Text = Mid(Label1.Text, 29, 2)
                End If
                If Mid(Label1.Text, 30, 1) = "]" Then
                    TextBox6.Text = Mid(Label1.Text, 29, 1)
                End If



            End If


        End If



        If Mid(Label1.Text, 19, 1) = "," Then
            TextBox4.Text = Mid(Label1.Text, 17, 2)


            If Mid(Label1.Text, 26, 1) = "," Then
                TextBox5.Text = Mid(Label1.Text, 23, 3)


                If Mid(Label1.Text, 33, 1) = "]" Then
                    TextBox6.Text = Mid(Label1.Text, 30, 3)
                End If
                If Mid(Label1.Text, 32, 1) = "]" Then
                    TextBox6.Text = Mid(Label1.Text, 30, 2)
                End If
                If Mid(Label1.Text, 31, 1) = "]" Then
                    TextBox6.Text = Mid(Label1.Text, 30, 1)
                End If



            End If

            If Mid(Label1.Text, 25, 1) = "," Then
                TextBox5.Text = Mid(Label1.Text, 23, 2)


                If Mid(Label1.Text, 32, 1) = "]" Then
                    TextBox6.Text = Mid(Label1.Text, 29, 3)
                End If
                If Mid(Label1.Text, 31, 1) = "]" Then
                    TextBox6.Text = Mid(Label1.Text, 29, 2)
                End If
                If Mid(Label1.Text, 30, 1) = "]" Then
                    TextBox6.Text = Mid(Label1.Text, 29, 1)
                End If



            End If
            If Mid(Label1.Text, 24, 1) = "," Then
                TextBox5.Text = Mid(Label1.Text, 23, 1)


                If Mid(Label1.Text, 31, 1) = "]" Then
                    TextBox6.Text = Mid(Label1.Text, 28, 3)
                End If
                If Mid(Label1.Text, 30, 1) = "]" Then
                    TextBox6.Text = Mid(Label1.Text, 28, 2)
                End If
                If Mid(Label1.Text, 29, 1) = "]" Then
                    TextBox6.Text = Mid(Label1.Text, 28, 1)
                End If



            End If


        End If

        If Mid(Label1.Text, 18, 1) = "," Then
            TextBox4.Text = Mid(Label1.Text, 17, 1)




            If Mid(Label1.Text, 25, 1) = "," Then
                TextBox5.Text = Mid(Label1.Text, 22, 3)


                If Mid(Label1.Text, 32, 1) = "]" Then
                    TextBox6.Text = Mid(Label1.Text, 29, 3)
                End If
                If Mid(Label1.Text, 31, 1) = "]" Then
                    TextBox6.Text = Mid(Label1.Text, 29, 2)
                End If
                If Mid(Label1.Text, 30, 1) = "]" Then
                    TextBox6.Text = Mid(Label1.Text, 29, 1)
                End If



            End If

            If Mid(Label1.Text, 24, 1) = "," Then
                TextBox5.Text = Mid(Label1.Text, 22, 2)


                If Mid(Label1.Text, 31, 1) = "]" Then
                    TextBox6.Text = Mid(Label1.Text, 28, 3)
                End If
                If Mid(Label1.Text, 30, 1) = "]" Then
                    TextBox6.Text = Mid(Label1.Text, 28, 2)
                End If
                If Mid(Label1.Text, 29, 1) = "]" Then
                    TextBox6.Text = Mid(Label1.Text, 28, 1)
                End If



            End If
            If Mid(Label1.Text, 23, 1) = "," Then
                TextBox5.Text = Mid(Label1.Text, 22, 1)
                If Mid(Label1.Text, 30, 1) = "]" Then
                    TextBox6.Text = Mid(Label1.Text, 27, 3)
                End If
                If Mid(Label1.Text, 29, 1) = "]" Then
                    TextBox6.Text = Mid(Label1.Text, 27, 2)
                End If
                If Mid(Label1.Text, 28, 1) = "]" Then
                    TextBox6.Text = Mid(Label1.Text, 27, 1)
                End If

            End If
        End If



    End Sub

    Private Sub Timer7_Tick(sender As Object, e As EventArgs) Handles Timer7.Tick

        TextBox27.Text = Val(TextBox27.Text) + 1
        If Val(TextBox25.Text) = 1 Then
            Cursor.Position = New Point(877, 559)
            TextBox25.Text = 2
        End If

        '877 559  - 255 219 74
        '62 196 109
        If Val(TextBox25.Text) = 2 Then
            If (Val(TextBox4.Text) = 255) Then
                If (Val(TextBox5.Text) = 219) Then
                    If (Val(TextBox6.Text) = 74) Then

                        mouse_event1(&H2, 0, 0, 0, 0)
                        mouse_event1(&H4, 0, 0, 0, 0)

                        For ll = 1 To 100000000
                            ll = ll
                        Next
                        TextBox25.Text = 3
                    End If
                End If
            End If

        End If

        If Val(TextBox25.Text) = 3 Then
            Cursor.Position = New Point(877, 559)
            TextBox25.Text = 4
        End If


        If Val(TextBox25.Text) = 4 Then
            If (Val(TextBox4.Text) = 255) Then
                If (Val(TextBox5.Text) = 219) Then
                    If (Val(TextBox6.Text) = 74) Then

                        mouse_event1(&H2, 0, 0, 0, 0)
                        mouse_event1(&H4, 0, 0, 0, 0)

                        For ll = 1 To 100000000
                            ll = ll
                        Next
                        TextBox25.Text = 5

                    End If
                End If
            End If
        End If


        If Val(TextBox25.Text) = 5 Then
            Cursor.Position = New Point(877, 559)
            TextBox25.Text = 6
        End If


        If Val(TextBox25.Text) = 6 Then
            If (Val(TextBox4.Text) = 62) Then
                If (Val(TextBox5.Text) = 196) Then
                    If (Val(TextBox6.Text) = 109) Then

                        mouse_event1(&H2, 0, 0, 0, 0)
                        mouse_event1(&H4, 0, 0, 0, 0)

                        For ll = 1 To 100000000
                            ll = ll
                        Next
                        TextBox25.Text = 7

                    End If
                End If
            End If
        End If

        '1139 252  74 74 74


        If Val(TextBox25.Text) = 7 Then
            Cursor.Position = New Point(1139, 252)
            TextBox25.Text = 10
        End If


        If Val(TextBox25.Text) = 9 Then
            If (Val(TextBox4.Text) = 74) Then
                If (Val(TextBox5.Text) = 74) Then
                    If (Val(TextBox6.Text) = 74) Then

                        mouse_event1(&H2, 0, 0, 0, 0)
                        mouse_event1(&H4, 0, 0, 0, 0)

                        For ll = 1 To 100000000
                            ll = ll
                        Next
                        TextBox25.Text = 11

                    End If
                End If
            End If
        End If



    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        SerialPort1.Open()
        Timer8.Enabled = True


    End Sub

    Private Sub TextBox14_TextChanged(sender As Object, e As EventArgs) Handles TextBox14.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox26_TextChanged(sender As Object, e As EventArgs) Handles TextBox26.TextChanged

    End Sub

    Private Sub TextBox29_TextChanged(sender As Object, e As EventArgs) Handles TextBox29.TextChanged

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub TextBox25_TextChanged(sender As Object, e As EventArgs) Handles TextBox25.TextChanged

    End Sub

    Private Sub Timer10_Tick(sender As Object, e As EventArgs) Handles Timer10.Tick
        TextBox29.Text = TextBox30.Text + (Rnd() * 10)
    End Sub

    Private Sub Timer9_Tick(sender As Object, e As EventArgs) Handles Timer9.Tick
        If Val(TextBox29.Text) > 0 Then
            If Val(TextBox28.Text) > Val(TextBox29.Text) Then
                Form2.Show()
            End If
        End If
    End Sub

    Private Sub TextBox11_TextChanged(sender As Object, e As EventArgs) Handles TextBox11.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox30_TextChanged(sender As Object, e As EventArgs) Handles TextBox30.TextChanged

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub TextBox31_TextChanged(sender As Object, e As EventArgs) Handles TextBox31.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Timer11_Tick(sender As Object, e As EventArgs) Handles Timer11.Tick
        TextBox2.Text = Val(TextBox2.Text) + 1
        If Val(TextBox2.Text) > Val(TextBox31.Text) Then
            Form2.Show()
            TextBox2.Text = ""
        End If
    End Sub

    Private Sub Timer8_Tick(sender As Object, e As EventArgs) Handles Timer8.Tick








        If iff = 1 Then
            TextBox27.Text = Val(TextBox27.Text) + 1
            If Val(TextBox25.Text) = 1 Then
                Cursor.Position = New Point(877, 559)
                TextBox25.Text = 2
            End If

            '877 559  - 255 219 74
            '62 196 109
            If Val(TextBox25.Text) = 2 Then
                If (Val(TextBox4.Text) = 255) Then
                    If (Val(TextBox5.Text) = 219) Then
                        If (Val(TextBox6.Text) = 74) Then

                            mouse_event1(&H2, 0, 0, 0, 0)
                            mouse_event1(&H4, 0, 0, 0, 0)

                            For ll = 1 To 100000000
                                ll = ll
                            Next
                            TextBox25.Text = 3
                        End If
                    End If
                End If

            End If

            If Val(TextBox25.Text) = 3 Then
                Cursor.Position = New Point(877, 559)
                TextBox25.Text = 4
            End If


            If Val(TextBox25.Text) = 4 Then
                If (Val(TextBox4.Text) = 255) Then
                    If (Val(TextBox5.Text) = 219) Then
                        If (Val(TextBox6.Text) = 74) Then

                            mouse_event1(&H2, 0, 0, 0, 0)
                            mouse_event1(&H4, 0, 0, 0, 0)

                            For ll = 1 To 100000000
                                ll = ll
                            Next
                            TextBox25.Text = 5

                        End If
                    End If
                End If
            End If


            If Val(TextBox25.Text) = 5 Then
                Cursor.Position = New Point(877, 559)
                TextBox25.Text = 6
            End If


            If Val(TextBox25.Text) = 6 Then
                If (Val(TextBox4.Text) = 62) Then
                    If (Val(TextBox5.Text) = 196) Then
                        If (Val(TextBox6.Text) = 109) Then

                            mouse_event1(&H2, 0, 0, 0, 0)
                            mouse_event1(&H4, 0, 0, 0, 0)

                            For ll = 1 To 100000000
                                ll = ll
                            Next
                            TextBox25.Text = 7

                        End If
                    End If
                End If
            End If

            '1139 252  74 74 74


            If Val(TextBox25.Text) = 7 Then
                Cursor.Position = New Point(1139, 252)
                TextBox25.Text = 10
            End If


            If Val(TextBox25.Text) = 9 Then
                If (Val(TextBox4.Text) = 74) Then
                    If (Val(TextBox5.Text) = 74) Then
                        If (Val(TextBox6.Text) = 74) Then

                            mouse_event1(&H2, 0, 0, 0, 0)
                            mouse_event1(&H4, 0, 0, 0, 0)

                            For ll = 1 To 100000000
                                ll = ll
                            Next
                            TextBox25.Text = 1
                            iff = 0
                        End If
                    End If
                End If
            End If
        End If




    End Sub

    Private Sub TextBox23_TextChanged(sender As Object, e As EventArgs) Handles TextBox23.TextChanged

    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        tt = tt + 1
        TextBox19.Text = tt
        TextBox20.Text = amt
        TextBox21.Text = win


    End Sub



    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        On Error Resume Next

        a = Val(TextBox8.Text)
        b = Val(TextBox9.Text)
        TextBox15.Text = a
        TextBox16.Text = b
        Cursor.Position = New Point(866, 426)
        For ll = 1 To 100000000
            ll = ll
        Next
        cft = 1



    End Sub




End Class

