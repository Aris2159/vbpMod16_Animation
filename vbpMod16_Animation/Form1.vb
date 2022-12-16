'12/15/2022
'A simple animaton about a football passing through goalpost and falling down it will loop over and over again

Imports System.Net.Security

Public Class Form1
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'end the program
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Enable the timer function to start the timer
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        ' Check of the location of the football is less then 284 in X coordiants and then move it to that place with going letf and up at the same time
        If PictureBox2.Location.X < (284) Then
            PictureBox2.Location = New Point(PictureBox2.Location.X - 10, PictureBox2.Location.Y + 10)
            ' if not check if X is greater then 284 then it will go down from the goal post while going to the left.
        ElseIf PictureBox2.Location.X > (284) Then
            PictureBox2.Location = New Point(PictureBox2.Location.X - 10, PictureBox2.Location.Y - 10)
        End If
        ' If X is less then 0 then move it back to it's original place
        If PictureBox2.Location.X < 0 Then
            PictureBox2.Location = New Point(567, 297)
        End If
    End Sub
End Class