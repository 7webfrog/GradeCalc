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
        Me.SuspendLayout()
        '
        'txtOut
        '
        Me.txtOut.Location = New System.Drawing.Point(102, 125)
        Me.txtOut.Margin = New System.Windows.Forms.Padding(2)
        Me.txtOut.Name = "txtOut"
        Me.txtOut.ReadOnly = True
        Me.txtOut.Size = New System.Drawing.Size(76, 20)
        Me.txtOut.TabIndex = 4
        '
        'lblOutE1
        '
        Me.lblOutE1.AutoSize = True
        Me.lblOutE1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.lblOutE1.Location = New System.Drawing.Point(9, 127)
        Me.lblOutE1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblOutE1.Name = "lblOutE1"
        Me.lblOutE1.Size = New System.Drawing.Size(90, 13)
        Me.lblOutE1.TabIndex = 8
        Me.lblOutE1.Text = "Your E1 Grade is:"
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(102, 86)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 3
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'lblF1E1
        '
        Me.lblF1E1.AutoSize = True
        Me.lblF1E1.Location = New System.Drawing.Point(9, 64)
        Me.lblF1E1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblF1E1.Name = "lblF1E1"
        Me.lblF1E1.Size = New System.Drawing.Size(82, 13)
        Me.lblF1E1.TabIndex = 7
        Me.lblF1E1.Text = "Enter F1 Grade:"
        '
        'txtF1
        '
        Me.txtF1.Location = New System.Drawing.Point(102, 63)
        Me.txtF1.Margin = New System.Windows.Forms.Padding(2)
        Me.txtF1.Name = "txtF1"
        Me.txtF1.Size = New System.Drawing.Size(76, 20)
        Me.txtF1.TabIndex = 2
        '
        'lblGP2E1
        '
        Me.lblGP2E1.AutoSize = True
        Me.lblGP2E1.Location = New System.Drawing.Point(9, 40)
        Me.lblGP2E1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblGP2E1.Name = "lblGP2E1"
        Me.lblGP2E1.Size = New System.Drawing.Size(91, 13)
        Me.lblGP2E1.TabIndex = 6
        Me.lblGP2E1.Text = "Enter GP2 Grade:"
        '
        'lblGP1E1
        '
        Me.lblGP1E1.AutoSize = True
        Me.lblGP1E1.Location = New System.Drawing.Point(9, 15)
        Me.lblGP1E1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblGP1E1.Name = "lblGP1E1"
        Me.lblGP1E1.Size = New System.Drawing.Size(91, 13)
        Me.lblGP1E1.TabIndex = 5
        Me.lblGP1E1.Text = "Enter GP1 Grade:"
        '
        'txtGP2
        '
        Me.txtGP2.Location = New System.Drawing.Point(102, 38)
        Me.txtGP2.Margin = New System.Windows.Forms.Padding(2)
        Me.txtGP2.Name = "txtGP2"
        Me.txtGP2.Size = New System.Drawing.Size(76, 20)
        Me.txtGP2.TabIndex = 1
        '
        'txtGP1
        '
        Me.txtGP1.Location = New System.Drawing.Point(102, 14)
        Me.txtGP1.Margin = New System.Windows.Forms.Padding(2)
        Me.txtGP1.Name = "txtGP1"
        Me.txtGP1.Size = New System.Drawing.Size(76, 20)
        Me.txtGP1.TabIndex = 0
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
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
End Class
