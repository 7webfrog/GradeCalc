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
        Me.txtboxS1 = New System.Windows.Forms.TextBox()
        Me.txtboxS2 = New System.Windows.Forms.TextBox()
        Me.lblS1 = New System.Windows.Forms.Label()
        Me.lblS2 = New System.Windows.Forms.Label()
        Me.txtboxE1 = New System.Windows.Forms.TextBox()
        Me.lblE1 = New System.Windows.Forms.Label()
        Me.BtnExe = New System.Windows.Forms.Button()
        Me.lblOut = New System.Windows.Forms.Label()
        Me.txtboxOut = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtboxS1
        '
        Me.txtboxS1.Location = New System.Drawing.Point(130, 17)
        Me.txtboxS1.Name = "txtboxS1"
        Me.txtboxS1.Size = New System.Drawing.Size(100, 22)
        Me.txtboxS1.TabIndex = 0
        '
        'txtboxS2
        '
        Me.txtboxS2.Location = New System.Drawing.Point(130, 47)
        Me.txtboxS2.Name = "txtboxS2"
        Me.txtboxS2.Size = New System.Drawing.Size(100, 22)
        Me.txtboxS2.TabIndex = 1
        '
        'lblS1
        '
        Me.lblS1.AutoSize = True
        Me.lblS1.Location = New System.Drawing.Point(12, 19)
        Me.lblS1.Name = "lblS1"
        Me.lblS1.Size = New System.Drawing.Size(111, 17)
        Me.lblS1.TabIndex = 2
        Me.lblS1.Text = "Enter S1 Grade:"
        '
        'lblS2
        '
        Me.lblS2.AutoSize = True
        Me.lblS2.Location = New System.Drawing.Point(12, 49)
        Me.lblS2.Name = "lblS2"
        Me.lblS2.Size = New System.Drawing.Size(111, 17)
        Me.lblS2.TabIndex = 3
        Me.lblS2.Text = "Enter S2 Grade:"
        '
        'txtboxE1
        '
        Me.txtboxE1.Location = New System.Drawing.Point(130, 77)
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
        Me.BtnExe.Location = New System.Drawing.Point(130, 106)
        Me.BtnExe.Name = "BtnExe"
        Me.BtnExe.Size = New System.Drawing.Size(100, 25)
        Me.BtnExe.TabIndex = 6
        Me.BtnExe.Text = "Submit"
        Me.BtnExe.UseVisualStyleBackColor = True
        '
        'lblOut
        '
        Me.lblOut.AutoSize = True
        Me.lblOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.lblOut.Location = New System.Drawing.Point(12, 156)
        Me.lblOut.Name = "lblOut"
        Me.lblOut.Size = New System.Drawing.Size(111, 16)
        Me.lblOut.TabIndex = 7
        Me.lblOut.Text = "Your F1 Grade is:"
        '
        'txtboxOut
        '
        Me.txtboxOut.Location = New System.Drawing.Point(130, 154)
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
        Me.Controls.Add(Me.txtboxOut)
        Me.Controls.Add(Me.lblOut)
        Me.Controls.Add(Me.BtnExe)
        Me.Controls.Add(Me.lblE1)
        Me.Controls.Add(Me.txtboxE1)
        Me.Controls.Add(Me.lblS2)
        Me.Controls.Add(Me.lblS1)
        Me.Controls.Add(Me.txtboxS2)
        Me.Controls.Add(Me.txtboxS1)
        Me.Name = "Form1"
        Me.Text = "Grade Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtboxS1 As TextBox
    Friend WithEvents txtboxS2 As TextBox
    Friend WithEvents lblS1 As Label
    Friend WithEvents lblS2 As Label
    Friend WithEvents txtboxE1 As TextBox
    Friend WithEvents lblE1 As Label
    Friend WithEvents BtnExe As Button
    Friend WithEvents lblOut As Label
    Friend WithEvents txtboxOut As TextBox
End Class
