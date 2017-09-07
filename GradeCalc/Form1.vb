Public Class Form1
    Private Sub BtnExe_Click(sender As Object, e As EventArgs) Handles BtnExe.Click
        Dim S1 As Integer
        Dim S2 As Integer
        Dim E1 As Integer
        Convert.ToInt32(txtboxS1.Text)
        Convert.ToInt32(txtboxS2.Text)
        Convert.ToInt32(txtboxE1.Text)
        S1 = txtboxS1.Text
        S2 = txtboxS2.Text
        E1 = txtboxE1.Text
        Dim F1 As Decimal
        F1 = S1 + S1 + S2 + S2 + E1
        Dim F1A As Decimal
        F1A = F1 / 5
        txtboxOut.Text = F1A
    End Sub
End Class
