Public Class InitForm
    '7webfrog
    '10/20/17
    'Startup form; gives the user option of which calculator to use
    Private Sub Final_Click(sender As Object, e As EventArgs) Handles btnFinal.Click 'Final Grade
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Exam_Click(sender As Object, e As EventArgs) Handles btnExam.Click 'Exam Grade
        Form2.Show()
        Me.Close()
    End Sub
End Class