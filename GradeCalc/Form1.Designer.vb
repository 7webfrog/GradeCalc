<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtGP1 = New System.Windows.Forms.TextBox()
        Me.txtGP2 = New System.Windows.Forms.TextBox()
        Me.lblGP1 = New System.Windows.Forms.Label()
        Me.lblGP2 = New System.Windows.Forms.Label()
        Me.txtE1 = New System.Windows.Forms.TextBox()
        Me.lblE1 = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lblOut = New System.Windows.Forms.Label()
        Me.txtOut = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtGP1
        '
        Me.txtGP1.Location = New System.Drawing.Point(102, 14)
        Me.txtGP1.Margin = New System.Windows.Forms.Padding(2)
        Me.txtGP1.Name = "txtGP1"
        Me.txtGP1.Size = New System.Drawing.Size(76, 20)
        Me.txtGP1.TabIndex = 0
        '
        'txtGP2
        '
        Me.txtGP2.Location = New System.Drawing.Point(102, 38)
        Me.txtGP2.Margin = New System.Windows.Forms.Padding(2)
        Me.txtGP2.Name = "txtGP2"
        Me.txtGP2.Size = New System.Drawing.Size(76, 20)
        Me.txtGP2.TabIndex = 1
        '
        'lblGP1
        '
        Me.lblGP1.AutoSize = True
        Me.lblGP1.Location = New System.Drawing.Point(9, 15)
        Me.lblGP1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblGP1.Name = "lblGP1"
        Me.lblGP1.Size = New System.Drawing.Size(91, 13)
        Me.lblGP1.TabIndex = 2
        Me.lblGP1.Text = "Enter GP1 Grade:"
        '
        'lblGP2
        '
        Me.lblGP2.AutoSize = True
        Me.lblGP2.Location = New System.Drawing.Point(9, 40)
        Me.lblGP2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblGP2.Name = "lblGP2"
        Me.lblGP2.Size = New System.Drawing.Size(91, 13)
        Me.lblGP2.TabIndex = 3
        Me.lblGP2.Text = "Enter GP2 Grade:"
        '
        'txtE1
        '
        Me.txtE1.Location = New System.Drawing.Point(102, 63)
        Me.txtE1.Margin = New System.Windows.Forms.Padding(2)
        Me.txtE1.Name = "txtE1"
        Me.txtE1.Size = New System.Drawing.Size(76, 20)
        Me.txtE1.TabIndex = 4
        '
        'lblE1
        '
        Me.lblE1.AutoSize = True
        Me.lblE1.Location = New System.Drawing.Point(9, 64)
        Me.lblE1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblE1.Name = "lblE1"
        Me.lblE1.Size = New System.Drawing.Size(83, 13)
        Me.lblE1.TabIndex = 5
        Me.lblE1.Text = "Enter E1 Grade:"
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(102, 86)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 6
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'lblOut
        '
        Me.lblOut.AutoSize = True
        Me.lblOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.lblOut.Location = New System.Drawing.Point(9, 127)
        Me.lblOut.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblOut.Name = "lblOut"
        Me.lblOut.Size = New System.Drawing.Size(89, 13)
        Me.lblOut.TabIndex = 7
        Me.lblOut.Text = "Your F1 Grade is:"
        '
        'txtOut
        '
        Me.txtOut.Location = New System.Drawing.Point(102, 125)
        Me.txtOut.Margin = New System.Windows.Forms.Padding(2)
        Me.txtOut.Name = "txtOut"
        Me.txtOut.ReadOnly = True
        Me.txtOut.Size = New System.Drawing.Size(76, 20)
        Me.txtOut.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.txtOut)
        Me.Controls.Add(Me.lblOut)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblE1)
        Me.Controls.Add(Me.txtE1)
        Me.Controls.Add(Me.lblGP2)
        Me.Controls.Add(Me.lblGP1)
        Me.Controls.Add(Me.txtGP2)
        Me.Controls.Add(Me.txtGP1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "Grade Calculator (F1)"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtGP1 As TextBox
    Friend WithEvents txtGP2 As TextBox
    Friend WithEvents lblGP1 As Label
    Friend WithEvents lblGP2 As Label
    Friend WithEvents txtE1 As TextBox
    Friend WithEvents lblE1 As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents lblOut As Label
    Friend WithEvents txtOut As TextBox
End Class
