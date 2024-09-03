Public Class Form1
    Public txtSemGrade As Object
    Public txtPrelim As Object
    Public txtMidterm As Object
    Public txtFinal As Object
    Public txtEquivalent As Object
    Public txtRemarks As Object

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form2.Show()

        Dim response As Byte

        response = MessageBox.Show("all entries Correct?", "compute", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If response = DialogResult.Yes Then
            txtSemGrade.Text = (txtPrelim.Text / 100) * 25 + (txtMidterm.Text / 100) * 25 + (txtFinal.Text / 100) * 50

            If txtSemGrade.Text = 100 Then
                txtEquivalent.Text = "1.00"
                txtRemarks.Text = "Passed"
            ElseIf txtSemGrade.Text >= 95 Then
                txtEquivalent.Text = "1.50"
                txtRemarks.Text = "Passed"
            ElseIf txtSemGrade.Text >= 90 Then
                txtEquivalent.Text = "2.00"
                txtRemarks.Text = "Passed"
            ElseIf txtSemGrade.Text >= 85 Then
                txtEquivalent.Text = "2.50"
                txtRemarks.Text = "Passed"
            ElseIf txtSemGrade.Text >= 80 Then
                txtEquivalent.Text = "3.00"
                txtRemarks.Text = "Passed"
            ElseIf txtSemGrade.Text >= 75 Then
                txtEquivalent.Text = "3.50"
                txtRemarks.Text = "Passed"
            Else txtEquivalent.Text = "5.00"
                txtRemarks.Text = "Failed"
            End If
        End If
    End Sub
End Class
