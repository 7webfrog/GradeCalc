Public Class Form1
    Private Sub BtnExeF1_Click(sender As Object, e As EventArgs) Handles BtnExeF1.Click
        Convert.ToInt32(txtboxGP1F1.Text)
        Dim GP1 As Integer = txtboxGP1F1.Text
        Dim GP1A As Decimal = GP1 * 0.4
        Convert.ToInt32(txtboxGP2F1.Text)
        Dim GP2 As Integer = txtboxGP2F1.Text
        Dim GP2A As Decimal = GP2 * 0.4
        Convert.ToInt32(txtboxE1F1.Text)
        Dim E1 As Integer = txtboxE1F1.Text
        Dim E1A As Decimal = E1 * 0.2
        Dim F1 As Decimal = GP1A + GP2A + E1A
        txtboxOutF1.Text = F1
    End Sub

    Private Sub BtnExeE1_Click(sender As Object, e As EventArgs) Handles BtnExeE1.Click

    End Sub
End Class
