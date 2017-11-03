Public Class Form1
    '7webfrog
    '10/20/17
    'F1 Grade Calculator
    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click 'When button is clicked
        Dim dblGP1, dblGP1W, dblGP2, dblGP2W, dblE1, dblE1W, dblF1 As Double 'Declare vars for all text boxes
        If (txtGP1.Text = Nothing) Or (txtGP1W.Text = Nothing) Or (txtGP2.Text = Nothing) Or (txtGP2W.Text = Nothing) Or (txtE1.Text = Nothing) Or (txtE1W.Text = Nothing) Then 'If any textboxes are left empty
            MessageBox.Show("Please enter a value in ALL text fields.") 'Tell user their mistake
            Exit Sub 'Exit subroutine so rest of code doesn't run, but user can try again
        End If
        Try 'Try to convert grade textboxes to double
            dblGP1 = Convert.ToDouble(txtGP1.Text)
            dblGP2 = Convert.ToDouble(txtGP2.Text)
            dblE1 = Convert.ToDouble(txtE1.Text)
        Catch ex As Exception 'If a conversion fails
            MessageBox.Show("Please enter a grade between 0 and 100 in ALL grade fields.") 'Tell user their mistake
            Exit Sub 'Exit
        End Try
        If (dblGP1 < 0 Or dblGP1 > 100) Or (dblGP2 < 0 Or dblGP2 > 100) Or (dblE1 < 0 Or dblE1 > 100) Then 'Grade data validation check to see if input is within grade range
            MessageBox.Show("Please enter a grade between 0 and 100 in ALL grade fields.") 'Tell user their mistake
            Exit Sub 'Exit
        End If
        Try
            dblGP1W = Convert.ToDouble(txtGP1W.Text)
            dblGP2W = Convert.ToDouble(txtGP2W.Text)
            dblE1W = Convert.ToDouble(txtE1W.Text)
        Catch ex As Exception 'If a conversion fails
            MessageBox.Show("Please enter a weight between 0 and 1 in ALL weight fields.") 'Tell user their mistake
            Exit Sub 'Exit
        End Try
        If (dblGP1W < 0 Or dblGP1W > 1) Or (dblGP2W < 0 Or dblGP2W > 1) Or (dblE1W < 0 Or dblE1W > 1) Then 'Weight data validation to see if weight is a decimal
            MessageBox.Show("Please enter a weight between 0 and 1 in ALL weight fields.") 'Tell user their mistake
            Exit Sub 'Exit
        End If
        dblGP1 *= dblGP1W 'Grading Period 1 is reduced by weight factor
        dblGP2 *= dblGP2W 'Grading Period 2 is reduced by weight factor
        dblE1 *= dblE1W 'Exam grade is reduced by weight factor
        dblF1 = dblGP1 + dblGP2 + dblE1 'Final grade is found
        txtOut.Text = dblF1.ToString() 'Output final grade
    End Sub

    Private Sub Form1_Closed(sender As Object, e As EventArgs) Handles Me.Closed 'Exits application when user exits (initform is hidden, so app doesn't end otherwise)
        Application.Exit()
    End Sub
End Class
