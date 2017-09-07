Public Class Form1
    Private Sub BtnExe_Click(sender As Object, e As EventArgs) Handles BtnExe.Click
        Dim S1 As Integer
        Convert.ToInt32(txtboxS1.Text)
        S1 = txtboxS1.Text
        Dim S1A As Decimal
        S1A = S1 * 0.4
        Dim S2 As Integer
        Convert.ToInt32(txtboxS2.Text)
        S2 = txtboxS2.Text
        Dim S2A As Decimal
        S2A = S2 * 0.4
        Dim E1 As Integer
        Convert.ToInt32(txtboxE1.Text)
        E1 = txtboxE1.Text
        Dim E1A As Decimal
        E1A = E1 * 0.2
        Dim F1 As Decimal
        F1 = S1A + S2A + E1A
        txtboxOut.Text = F1
    End Sub
End Class
