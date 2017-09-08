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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.CalcF1 = New System.Windows.Forms.TabPage()
        Me.CalcE1 = New System.Windows.Forms.TabPage()
        Me.txtboxE1E1 = New System.Windows.Forms.TextBox()
        Me.lblE1E1 = New System.Windows.Forms.Label()
        Me.txtboxGP1E1 = New System.Windows.Forms.TextBox()
        Me.BtnExeE1 = New System.Windows.Forms.Button()
        Me.txtboxGP2E1 = New System.Windows.Forms.TextBox()
        Me.lblF1E1 = New System.Windows.Forms.Label()
        Me.lblGP1E1 = New System.Windows.Forms.Label()
        Me.txtboxF1E1 = New System.Windows.Forms.TextBox()
        Me.lblGP2E1 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.CalcF1.SuspendLayout()
        Me.CalcE1.SuspendLayout()
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
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.CalcF1)
        Me.TabControl1.Controls.Add(Me.CalcE1)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1120, 530)
        Me.TabControl1.TabIndex = 9
        '
        'CalcF1
        '
        Me.CalcF1.Controls.Add(Me.txtboxOutF1)
        Me.CalcF1.Controls.Add(Me.lblOutF1)
        Me.CalcF1.Controls.Add(Me.txtboxGP1F1)
        Me.CalcF1.Controls.Add(Me.BtnExeF1)
        Me.CalcF1.Controls.Add(Me.txtboxGP2F1)
        Me.CalcF1.Controls.Add(Me.lblE1F1)
        Me.CalcF1.Controls.Add(Me.lblGP1F1)
        Me.CalcF1.Controls.Add(Me.txtboxE1F1)
        Me.CalcF1.Controls.Add(Me.lblGP2F1)
        Me.CalcF1.Location = New System.Drawing.Point(4, 25)
        Me.CalcF1.Name = "CalcF1"
        Me.CalcF1.Padding = New System.Windows.Forms.Padding(3)
        Me.CalcF1.Size = New System.Drawing.Size(1112, 501)
        Me.CalcF1.TabIndex = 0
        Me.CalcF1.Text = "Calculate F1"
        Me.CalcF1.UseVisualStyleBackColor = True
        '
        'CalcE1
        '
        Me.CalcE1.Controls.Add(Me.txtboxE1E1)
        Me.CalcE1.Controls.Add(Me.lblE1E1)
        Me.CalcE1.Controls.Add(Me.txtboxGP1E1)
        Me.CalcE1.Controls.Add(Me.BtnExeE1)
        Me.CalcE1.Controls.Add(Me.txtboxGP2E1)
        Me.CalcE1.Controls.Add(Me.lblF1E1)
        Me.CalcE1.Controls.Add(Me.lblGP1E1)
        Me.CalcE1.Controls.Add(Me.txtboxF1E1)
        Me.CalcE1.Controls.Add(Me.lblGP2E1)
        Me.CalcE1.Location = New System.Drawing.Point(4, 25)
        Me.CalcE1.Name = "CalcE1"
        Me.CalcE1.Padding = New System.Windows.Forms.Padding(3)
        Me.CalcE1.Size = New System.Drawing.Size(1112, 501)
        Me.CalcE1.TabIndex = 1
        Me.CalcE1.Text = "Calculate E1"
        Me.CalcE1.UseVisualStyleBackColor = True
        '
        'txtboxE1E1
        '
        Me.txtboxE1E1.Location = New System.Drawing.Point(136, 154)
        Me.txtboxE1E1.Name = "txtboxE1E1"
        Me.txtboxE1E1.ReadOnly = True
        Me.txtboxE1E1.Size = New System.Drawing.Size(100, 22)
        Me.txtboxE1E1.TabIndex = 17
        '
        'lblE1E1
        '
        Me.lblE1E1.AutoSize = True
        Me.lblE1E1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.lblE1E1.Location = New System.Drawing.Point(12, 156)
        Me.lblE1E1.Name = "lblE1E1"
        Me.lblE1E1.Size = New System.Drawing.Size(121, 17)
        Me.lblE1E1.TabIndex = 16
        Me.lblE1E1.Text = "Your E1 Grade is:"
        '
        'txtboxGP1E1
        '
        Me.txtboxGP1E1.Location = New System.Drawing.Point(136, 17)
        Me.txtboxGP1E1.Name = "txtboxGP1E1"
        Me.txtboxGP1E1.Size = New System.Drawing.Size(100, 22)
        Me.txtboxGP1E1.TabIndex = 9
        '
        'BtnExeE1
        '
        Me.BtnExeE1.Location = New System.Drawing.Point(136, 106)
        Me.BtnExeE1.Name = "BtnExeE1"
        Me.BtnExeE1.Size = New System.Drawing.Size(100, 25)
        Me.BtnExeE1.TabIndex = 15
        Me.BtnExeE1.Text = "Submit"
        Me.BtnExeE1.UseVisualStyleBackColor = True
        '
        'txtboxGP2E1
        '
        Me.txtboxGP2E1.Location = New System.Drawing.Point(136, 47)
        Me.txtboxGP2E1.Name = "txtboxGP2E1"
        Me.txtboxGP2E1.Size = New System.Drawing.Size(100, 22)
        Me.txtboxGP2E1.TabIndex = 10
        '
        'lblF1E1
        '
        Me.lblF1E1.AutoSize = True
        Me.lblF1E1.Location = New System.Drawing.Point(12, 79)
        Me.lblF1E1.Name = "lblF1E1"
        Me.lblF1E1.Size = New System.Drawing.Size(110, 17)
        Me.lblF1E1.TabIndex = 14
        Me.lblF1E1.Text = "Enter F1 Grade:"
        '
        'lblGP1E1
        '
        Me.lblGP1E1.AutoSize = True
        Me.lblGP1E1.Location = New System.Drawing.Point(12, 19)
        Me.lblGP1E1.Name = "lblGP1E1"
        Me.lblGP1E1.Size = New System.Drawing.Size(122, 17)
        Me.lblGP1E1.TabIndex = 11
        Me.lblGP1E1.Text = "Enter GP1 Grade:"
        '
        'txtboxF1E1
        '
        Me.txtboxF1E1.Location = New System.Drawing.Point(136, 77)
        Me.txtboxF1E1.Name = "txtboxF1E1"
        Me.txtboxF1E1.Size = New System.Drawing.Size(100, 22)
        Me.txtboxF1E1.TabIndex = 13
        '
        'lblGP2E1
        '
        Me.lblGP2E1.AutoSize = True
        Me.lblGP2E1.Location = New System.Drawing.Point(12, 49)
        Me.lblGP2E1.Name = "lblGP2E1"
        Me.lblGP2E1.Size = New System.Drawing.Size(122, 17)
        Me.lblGP2E1.TabIndex = 12
        Me.lblGP2E1.Text = "Enter GP2 Grade:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1116, 526)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Grade Calculator"
        Me.TabControl1.ResumeLayout(False)
        Me.CalcF1.ResumeLayout(False)
        Me.CalcF1.PerformLayout()
        Me.CalcE1.ResumeLayout(False)
        Me.CalcE1.PerformLayout()
        Me.ResumeLayout(False)

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
