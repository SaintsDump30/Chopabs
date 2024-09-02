Public Class Form1
    Public score As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form2.show()

        If RadioButton3.Checked = True Then
            score += 1
        Else
            score = 0

        End If

        If RadioButton5.Checked = True Then

            score += 1
        Else
            score = 0

        End If

        If RadioButton8.Checked = True Then
            score += 1

        Else
            score = 0

        End If




    End Sub

End Class
