﻿Public Class Form1
    Private Sub BtnExeF1_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim dblGP1, dblGP1W, dblGP2, dblGP2W, dblE1, dblE1W, dblF1 As Double
        If (txtGP1.Text = Nothing) Or (txtGP1W.Text = Nothing) Or (txtGP2.Text = Nothing) Or (txtGP2W.Text = Nothing) Or (txtE1.Text = Nothing) Or (txtE1W.Text = Nothing) Then
            MessageBox.Show("Please enter a value in ALL text fields.")
            Exit Sub
        End If
        Try
            dblGP1 = Convert.ToDouble(txtGP1.Text)
            dblGP2 = Convert.ToDouble(txtGP2.Text)
            dblE1 = Convert.ToDouble(txtE1.Text)
        Catch ex As Exception
            MessageBox.Show("Please enter a grade between 0 and 100")
            Exit Sub
        End Try
        If (dblGP1 < 0 Or dblGP1 > 100) Or (dblGP2 < 0 Or dblGP2 > 100) Or (dblF1 < 0 Or dblF1 > 100) Then
            MessageBox.Show("Please enter a grade between 0 and 100")
            Exit Sub
        End If
        Try
            dblGP1W = Convert.ToDouble(txtGP1W.Text)
            dblGP2W = Convert.ToDouble(txtGP2W.Text)
            dblE1W = Convert.ToDouble(txtE1W.Text)
        Catch ex As Exception
            MessageBox.Show("Please enter a weight between 0 and 1")
            Exit Sub
        End Try
        If (dblGP1W < 0 Or dblGP1W > 1) Or (dblGP2W < 0 Or dblGP2W > 1) Or (dblE1W < 0 Or dblE1W > 1) Then
            MessageBox.Show("Please enter a weight between 0 and 1")
            Exit Sub
        End If
        dblGP1 *= dblGP1W
        dblGP2 *= dblGP2W
        dblE1 *= dblE1W
        dblF1 = dblGP1 + dblGP2 + dblE1
        txtOut.Text = dblF1
    End Sub

    Private Sub Form1_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Application.Exit()
    End Sub
End Class
