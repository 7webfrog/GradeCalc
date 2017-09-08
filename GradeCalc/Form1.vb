Public Class Form1
    Private Sub BtnExeF1_Click(sender As Object, e As EventArgs) Handles BtnExeF1.Click
        Dim GP1 As Integer
        Convert.ToInt32(txtboxGP1F1.Text)
        GP1 = txtboxGP1F1.Text
        Dim GP1A As Decimal
        GP1A = GP1 * 0.4
        Dim GP2 As Integer
        Convert.ToInt32(txtboxGP2F1.Text)
        GP2 = txtboxGP2F1.Text
        Dim GP2A As Decimal
        GP2A = GP2 * 0.4
        Dim E1 As Integer
        Convert.ToInt32(txtboxE1F1.Text)
        E1 = txtboxE1F1.Text
        Dim E1A As Decimal
        E1A = E1 * 0.2
        Dim F1 As Decimal
        F1 = GP1A + GP2A + E1A
        txtboxOutF1.Text = F1
    End Sub
End Class
