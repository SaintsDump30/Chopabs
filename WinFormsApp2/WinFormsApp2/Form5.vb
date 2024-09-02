Public Class Form5
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Form1.score = "9" Then
            Label1.Text = "Congratulations!! your Score is " & Form1.score & "out of 9"
        Else
            Label1.Text = "Your Score is " & Form1.score & "out of 9"
        End If
    End Sub
End Class