Public Class Form1
    Private Sub BtnExe_Click(sender As Object, e As EventArgs) Handles BtnExe.Click
        Dim GP1 As Integer
        Convert.ToInt32(txtboxGP1.Text)
        GP1 = txtboxGP1.Text
        Dim GP1A As Decimal
        GP1A = GP1 * 0.4
        Dim GP2 As Integer
        Convert.ToInt32(txtboxGP2.Text)
        GP2 = txtboxGP2.Text
        Dim GP2A As Decimal
        GP2A = GP2 * 0.4
        Dim E1 As Integer
        Convert.ToInt32(txtboxE1.Text)
        E1 = txtboxE1.Text
        Dim E1A As Decimal
        E1A = E1 * 0.2
        Dim F1 As Decimal
        F1 = GP1A + GP2A + E1A
        txtboxOut.Text = F1
    End Sub
End Class
