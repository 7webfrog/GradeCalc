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
        Me.txtboxGP1 = New System.Windows.Forms.TextBox()
        Me.txtboxGP2 = New System.Windows.Forms.TextBox()
        Me.lblGP1 = New System.Windows.Forms.Label()
        Me.lblGP2 = New System.Windows.Forms.Label()
        Me.txtboxE1 = New System.Windows.Forms.TextBox()
        Me.lblE1 = New System.Windows.Forms.Label()
        Me.BtnExe = New System.Windows.Forms.Button()
        Me.lblOut = New System.Windows.Forms.Label()
        Me.txtboxOut = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtboxGP1
        '
        Me.txtboxGP1.Location = New System.Drawing.Point(136, 17)
        Me.txtboxGP1.Name = "txtboxGP1"
        Me.txtboxGP1.Size = New System.Drawing.Size(100, 22)
        Me.txtboxGP1.TabIndex = 0
        '
        'txtboxGP2
        '
        Me.txtboxGP2.Location = New System.Drawing.Point(136, 47)
        Me.txtboxGP2.Name = "txtboxGP2"
        Me.txtboxGP2.Size = New System.Drawing.Size(100, 22)
        Me.txtboxGP2.TabIndex = 1
        '
        'lblGP1
        '
        Me.lblGP1.AutoSize = True
        Me.lblGP1.Location = New System.Drawing.Point(12, 19)
        Me.lblGP1.Name = "lblGP1"
        Me.lblGP1.Size = New System.Drawing.Size(122, 17)
        Me.lblGP1.TabIndex = 2
        Me.lblGP1.Text = "Enter GP1 Grade:"
        '
        'lblGP2
        '
        Me.lblGP2.AutoSize = True
        Me.lblGP2.Location = New System.Drawing.Point(12, 49)
        Me.lblGP2.Name = "lblGP2"
        Me.lblGP2.Size = New System.Drawing.Size(122, 17)
        Me.lblGP2.TabIndex = 3
        Me.lblGP2.Text = "Enter GP2 Grade:"
        '
        'txtboxE1
        '
        Me.txtboxE1.Location = New System.Drawing.Point(136, 77)
        Me.txtboxE1.Name = "txtboxE1"
        Me.txtboxE1.Size = New System.Drawing.Size(100, 22)
        Me.txtboxE1.TabIndex = 4
        '
        'lblE1
        '
        Me.lblE1.AutoSize = True
        Me.lblE1.Location = New System.Drawing.Point(12, 79)
        Me.lblE1.Name = "lblE1"
        Me.lblE1.Size = New System.Drawing.Size(111, 17)
        Me.lblE1.TabIndex = 5
        Me.lblE1.Text = "Enter E1 Grade:"
        '
        'BtnExe
        '
        Me.BtnExe.Location = New System.Drawing.Point(136, 106)
        Me.BtnExe.Name = "BtnExe"
        Me.BtnExe.Size = New System.Drawing.Size(100, 25)
        Me.BtnExe.TabIndex = 6
        Me.BtnExe.Text = "Submit"
        Me.BtnExe.UseVisualStyleBackColor = True
        '
        'lblOut
        '
        Me.lblOut.AutoSize = True
        Me.lblOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.lblOut.Location = New System.Drawing.Point(12, 156)
        Me.lblOut.Name = "lblOut"
        Me.lblOut.Size = New System.Drawing.Size(120, 17)
        Me.lblOut.TabIndex = 7
        Me.lblOut.Text = "Your F1 Grade is:"
        '
        'txtboxOut
        '
        Me.txtboxOut.Location = New System.Drawing.Point(136, 154)
        Me.txtboxOut.Name = "txtboxOut"
        Me.txtboxOut.ReadOnly = True
        Me.txtboxOut.Size = New System.Drawing.Size(100, 22)
        Me.txtboxOut.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1116, 526)
        Me.Controls.Add(Me.txtboxOutF1)
        Me.Controls.Add(Me.lblOutF1)
        Me.Controls.Add(Me.BtnExeF1)
        Me.Controls.Add(Me.lblE1F1)
        Me.Controls.Add(Me.txtboxE1F1)
        Me.Controls.Add(Me.lblGP2F1)
        Me.Controls.Add(Me.lblGP1F1)
        Me.Controls.Add(Me.txtboxGP2F1)
        Me.Controls.Add(Me.txtboxGP1F1)
        Me.Name = "Form1"
        Me.Text = "Grade Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtboxGP1 As TextBox
    Friend WithEvents txtboxGP2 As TextBox
    Friend WithEvents lblGP1 As Label
    Friend WithEvents lblGP2 As Label
    Friend WithEvents txtboxE1 As TextBox
    Friend WithEvents lblE1 As Label
    Friend WithEvents BtnExe As Button
    Friend WithEvents lblOut As Label
    Friend WithEvents txtboxOut As TextBox
End Class
