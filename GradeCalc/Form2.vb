Public Class Form2
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim dblGP1, dblGP1W, dblGP2, dblGP2W, dblF1, dblF1W, dblE1 As Double
        Try
            dblGP1 = Convert.ToDouble(txtGP1.Text)
            dblGP2 = Convert.ToDouble(txtGP2.Text)
            dblF1 = Convert.ToDouble(txtF1.Text)
        Catch ex As Exception
            MessageBox.Show("Please enter a numeric answer between 0 and 100")
            Exit Sub
        End Try
        If (dblGP1 < 0 Or dblGP1 > 100) Or (dblGP2 < 0 Or dblGP2 > 100) Or (dblF1 < 0 Or dblF1 > 100) Then
            MessageBox.Show("Please enter a numeric value between 0 and 100")
            Exit Sub
        End If
        dblGP1W = dblGP1 * 0.4
        dblGP2W = dblGP2 * 0.4
        dblF1W = Nothing
        dblE1 = (dblF1 - dblGP1W - dblGP2W) * 5
        txtOut.Text = dblE1
    End Sub
End Class