Public Class Form1
    Private Sub BtnExeF1_Click(sender As Object, e As EventArgs) Handles BtnExeF1.Click
        Dim dblGP1, dblGP1W, dblGP2, dblGP2W, dblE1, dblE1W, dblF1 As Double
        dblGP1 = Convert.ToDouble(txtboxGP1F1.Text)
        dblGP1W = dblGP1 * 0.4
        dblGP2 = Convert.ToDouble(txtboxGP2F1.Text)
        dblGP2W = dblGP2 * 0.4
        dblE1 = Convert.ToDouble(txtboxE1F1.Text)
        dblE1W = dblE1 * 0.2
        dblF1 = dblGP1W + dblGP2W + dblE1W
        txtboxOutF1.Text = dblF1
    End Sub
End Class
