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
        Me.txtboxGP1F1 = New System.Windows.Forms.TextBox()
        Me.txtboxGP2F1 = New System.Windows.Forms.TextBox()
        Me.lblGP1F1 = New System.Windows.Forms.Label()
        Me.lblGP2F1 = New System.Windows.Forms.Label()
        Me.txtboxE1F1 = New System.Windows.Forms.TextBox()
        Me.lblE1F1 = New System.Windows.Forms.Label()
        Me.BtnExeF1 = New System.Windows.Forms.Button()
        Me.lblOutF1 = New System.Windows.Forms.Label()
        Me.txtboxOutF1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtboxGP1F1
        '
        Me.txtboxGP1F1.Location = New System.Drawing.Point(136, 17)
        Me.txtboxGP1F1.Name = "txtboxGP1F1"
        Me.txtboxGP1F1.Size = New System.Drawing.Size(100, 22)
        Me.txtboxGP1F1.TabIndex = 0
        '
        'txtboxGP2F1
        '
        Me.txtboxGP2F1.Location = New System.Drawing.Point(136, 47)
        Me.txtboxGP2F1.Name = "txtboxGP2F1"
        Me.txtboxGP2F1.Size = New System.Drawing.Size(100, 22)
        Me.txtboxGP2F1.TabIndex = 1
        '
        'lblGP1F1
        '
        Me.lblGP1F1.AutoSize = True
        Me.lblGP1F1.Location = New System.Drawing.Point(12, 19)
        Me.lblGP1F1.Name = "lblGP1F1"
        Me.lblGP1F1.Size = New System.Drawing.Size(122, 17)
        Me.lblGP1F1.TabIndex = 2
        Me.lblGP1F1.Text = "Enter GP1 Grade:"
        '
        'lblGP2F1
        '
        Me.lblGP2F1.AutoSize = True
        Me.lblGP2F1.Location = New System.Drawing.Point(12, 49)
        Me.lblGP2F1.Name = "lblGP2F1"
        Me.lblGP2F1.Size = New System.Drawing.Size(122, 17)
        Me.lblGP2F1.TabIndex = 3
        Me.lblGP2F1.Text = "Enter GP2 Grade:"
        '
        'txtboxE1F1
        '
        Me.txtboxE1F1.Location = New System.Drawing.Point(136, 77)
        Me.txtboxE1F1.Name = "txtboxE1F1"
        Me.txtboxE1F1.Size = New System.Drawing.Size(100, 22)
        Me.txtboxE1F1.TabIndex = 4
        '
        'lblE1F1
        '
        Me.lblE1F1.AutoSize = True
        Me.lblE1F1.Location = New System.Drawing.Point(12, 79)
        Me.lblE1F1.Name = "lblE1F1"
        Me.lblE1F1.Size = New System.Drawing.Size(111, 17)
        Me.lblE1F1.TabIndex = 5
        Me.lblE1F1.Text = "Enter E1 Grade:"
        '
        'BtnExeF1
        '
        Me.BtnExeF1.Location = New System.Drawing.Point(136, 106)
        Me.BtnExeF1.Name = "BtnExeF1"
        Me.BtnExeF1.Size = New System.Drawing.Size(100, 25)
        Me.BtnExeF1.TabIndex = 6
        Me.BtnExeF1.Text = "Submit"
        Me.BtnExeF1.UseVisualStyleBackColor = True
        '
        'lblOutF1
        '
        Me.lblOutF1.AutoSize = True
        Me.lblOutF1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.lblOutF1.Location = New System.Drawing.Point(12, 156)
        Me.lblOutF1.Name = "lblOutF1"
        Me.lblOutF1.Size = New System.Drawing.Size(120, 17)
        Me.lblOutF1.TabIndex = 7
        Me.lblOutF1.Text = "Your F1 Grade is:"
        '
        'txtboxOutF1
        '
        Me.txtboxOutF1.Location = New System.Drawing.Point(136, 154)
        Me.txtboxOutF1.Name = "txtboxOutF1"
        Me.txtboxOutF1.ReadOnly = True
        Me.txtboxOutF1.Size = New System.Drawing.Size(100, 22)
        Me.txtboxOutF1.TabIndex = 8
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

    Friend WithEvents txtboxGP1F1 As TextBox
    Friend WithEvents txtboxGP2F1 As TextBox
    Friend WithEvents lblGP1F1 As Label
    Friend WithEvents lblGP2F1 As Label
    Friend WithEvents txtboxE1F1 As TextBox
    Friend WithEvents lblE1F1 As Label
    Friend WithEvents BtnExeF1 As Button
    Friend WithEvents lblOutF1 As Label
    Friend WithEvents txtboxOutF1 As TextBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents CalcF1 As TabPage
    Friend WithEvents CalcE1 As TabPage
    Friend WithEvents txtboxE1E1 As TextBox
    Friend WithEvents lblE1E1 As Label
    Friend WithEvents txtboxGP1E1 As TextBox
    Friend WithEvents BtnExeE1 As Button
    Friend WithEvents txtboxGP2E1 As TextBox
    Friend WithEvents lblF1E1 As Label
    Friend WithEvents lblGP1E1 As Label
    Friend WithEvents txtboxF1E1 As TextBox
    Friend WithEvents lblGP2E1 As Label
End Class
