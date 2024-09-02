Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form3.Show()

        If CheckBox1.Checked Then
            Form1.score += 1
        End If
        If CheckBox2.Checked Then
            Form1.score += 1
        End If
        If CheckBox3.Checked Then
            Form1.score += 1
        End If
        If CheckBox4.Checked Then
            Form1.score += 1
        End If

    End Sub
End Class