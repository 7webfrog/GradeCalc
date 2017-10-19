Public Class InitForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnFinal.Click 'Final Grade
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnExam.Click 'Exam Grade
        Form2.Show()
        Me.Hide()
    End Sub
End Class