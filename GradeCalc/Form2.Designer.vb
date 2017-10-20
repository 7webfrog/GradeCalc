<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtOut = New System.Windows.Forms.TextBox()
        Me.lblOutE1 = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lblF1E1 = New System.Windows.Forms.Label()
        Me.txtF1 = New System.Windows.Forms.TextBox()
        Me.lblGP2E1 = New System.Windows.Forms.Label()
        Me.lblGP1E1 = New System.Windows.Forms.Label()
        Me.txtGP2 = New System.Windows.Forms.TextBox()
        Me.txtGP1 = New System.Windows.Forms.TextBox()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.txtGP1W = New System.Windows.Forms.TextBox()
        Me.txtGP2W = New System.Windows.Forms.TextBox()
        Me.txtE1W = New System.Windows.Forms.TextBox()
        Me.lblGrade = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtOut
        '
        Me.txtOut.Location = New System.Drawing.Point(173, 139)
        Me.txtOut.Margin = New System.Windows.Forms.Padding(2)
        Me.txtOut.Name = "txtOut"
        Me.txtOut.ReadOnly = True
        Me.txtOut.Size = New System.Drawing.Size(75, 20)
        Me.txtOut.TabIndex = 7
        Me.txtOut.TabStop = False
        '
        'lblOutE1
        '
        Me.lblOutE1.AutoSize = True
        Me.lblOutE1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.lblOutE1.Location = New System.Drawing.Point(9, 142)
        Me.lblOutE1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblOutE1.Name = "lblOutE1"
        Me.lblOutE1.Size = New System.Drawing.Size(162, 13)
        Me.lblOutE1.TabIndex = 11
        Me.lblOutE1.Text = "The E1 grade you need to get is:"
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(173, 100)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 6
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'lblF1E1
        '
        Me.lblF1E1.AutoSize = True
        Me.lblF1E1.Location = New System.Drawing.Point(9, 79)
        Me.lblF1E1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblF1E1.Name = "lblF1E1"
        Me.lblF1E1.Size = New System.Drawing.Size(144, 13)
        Me.lblF1E1.TabIndex = 10
        Me.lblF1E1.Text = "Enter the F1 grade you want:"
        '
        'txtF1
        '
        Me.txtF1.Location = New System.Drawing.Point(173, 76)
        Me.txtF1.Margin = New System.Windows.Forms.Padding(2)
        Me.txtF1.Name = "txtF1"
        Me.txtF1.Size = New System.Drawing.Size(75, 20)
        Me.txtF1.TabIndex = 4
        '
        'lblGP2E1
        '
        Me.lblGP2E1.AutoSize = True
        Me.lblGP2E1.Location = New System.Drawing.Point(9, 55)
        Me.lblGP2E1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblGP2E1.Name = "lblGP2E1"
        Me.lblGP2E1.Size = New System.Drawing.Size(91, 13)
        Me.lblGP2E1.TabIndex = 9
        Me.lblGP2E1.Text = "Enter GP2 Grade:"
        '
        'lblGP1E1
        '
        Me.lblGP1E1.AutoSize = True
        Me.lblGP1E1.Location = New System.Drawing.Point(9, 30)
        Me.lblGP1E1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblGP1E1.Name = "lblGP1E1"
        Me.lblGP1E1.Size = New System.Drawing.Size(91, 13)
        Me.lblGP1E1.TabIndex = 8
        Me.lblGP1E1.Text = "Enter GP1 Grade:"
        '
        'txtGP2
        '
        Me.txtGP2.Location = New System.Drawing.Point(173, 52)
        Me.txtGP2.Margin = New System.Windows.Forms.Padding(2)
        Me.txtGP2.Name = "txtGP2"
        Me.txtGP2.Size = New System.Drawing.Size(75, 20)
        Me.txtGP2.TabIndex = 2
        '
        'txtGP1
        '
        Me.txtGP1.Location = New System.Drawing.Point(173, 27)
        Me.txtGP1.Margin = New System.Windows.Forms.Padding(2)
        Me.txtGP1.Name = "txtGP1"
        Me.txtGP1.Size = New System.Drawing.Size(75, 20)
        Me.txtGP1.TabIndex = 0
        '
        'lblWeight
        '
        Me.lblWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblWeight.Location = New System.Drawing.Point(258, 9)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(86, 15)
        Me.lblWeight.TabIndex = 13
        Me.lblWeight.Text = "Weight (decimal)"
        Me.lblWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtGP1W
        '
        Me.txtGP1W.Location = New System.Drawing.Point(258, 27)
        Me.txtGP1W.Name = "txtGP1W"
        Me.txtGP1W.Size = New System.Drawing.Size(86, 20)
        Me.txtGP1W.TabIndex = 1
        '
        'txtGP2W
        '
        Me.txtGP2W.Location = New System.Drawing.Point(258, 52)
        Me.txtGP2W.Name = "txtGP2W"
        Me.txtGP2W.Size = New System.Drawing.Size(86, 20)
        Me.txtGP2W.TabIndex = 3
        '
        'txtE1W
        '
        Me.txtE1W.Location = New System.Drawing.Point(258, 139)
        Me.txtE1W.Name = "txtE1W"
        Me.txtE1W.Size = New System.Drawing.Size(86, 20)
        Me.txtE1W.TabIndex = 5
        '
        'lblGrade
        '
        Me.lblGrade.Location = New System.Drawing.Point(173, 9)
        Me.lblGrade.Name = "lblGrade"
        Me.lblGrade.Size = New System.Drawing.Size(75, 16)
        Me.lblGrade.TabIndex = 12
        Me.lblGrade.Text = "Grade"
        Me.lblGrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 261)
        Me.Controls.Add(Me.lblGrade)
        Me.Controls.Add(Me.txtE1W)
        Me.Controls.Add(Me.txtGP2W)
        Me.Controls.Add(Me.txtGP1W)
        Me.Controls.Add(Me.lblWeight)
        Me.Controls.Add(Me.txtOut)
        Me.Controls.Add(Me.lblOutE1)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblF1E1)
        Me.Controls.Add(Me.txtF1)
        Me.Controls.Add(Me.lblGP2E1)
        Me.Controls.Add(Me.lblGP1E1)
        Me.Controls.Add(Me.txtGP2)
        Me.Controls.Add(Me.txtGP1)
        Me.Name = "Form2"
        Me.Text = "Grade Calculator (E1)"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtOut As TextBox
    Friend WithEvents lblOutE1 As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents lblF1E1 As Label
    Friend WithEvents txtF1 As TextBox
    Friend WithEvents lblGP2E1 As Label
    Friend WithEvents lblGP1E1 As Label
    Friend WithEvents txtGP2 As TextBox
    Friend WithEvents txtGP1 As TextBox
    Friend WithEvents lblWeight As Label
    Friend WithEvents txtGP1W As TextBox
    Friend WithEvents txtGP2W As TextBox
    Friend WithEvents txtE1W As TextBox
    Friend WithEvents lblGrade As Label
End Class
