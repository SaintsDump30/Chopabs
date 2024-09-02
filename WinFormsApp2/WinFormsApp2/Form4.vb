Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form5.show()

        If ComboBox1.SelectedItem = "workstation" Then
            Form1.score += 1
        End If




    End Sub
End Class