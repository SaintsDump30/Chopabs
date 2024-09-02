Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form4.Show()

        If ListBox1.SelectedIndex = 1 Then
            Form1.score += 1
        End If

    End Sub
End Class