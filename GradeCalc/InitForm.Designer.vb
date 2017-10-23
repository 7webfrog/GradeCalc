<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InitForm
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
        Me.btnFinal = New System.Windows.Forms.Button()
        Me.btnExam = New System.Windows.Forms.Button()
        Me.lblPrompt = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnFinal
        '
        Me.btnFinal.Location = New System.Drawing.Point(59, 136)
        Me.btnFinal.Name = "btnFinal"
        Me.btnFinal.Size = New System.Drawing.Size(85, 37)
        Me.btnFinal.TabIndex = 0
        Me.btnFinal.Text = "Final Grade"
        Me.btnFinal.UseVisualStyleBackColor = True
        '
        'btnExam
        '
        Me.btnExam.Location = New System.Drawing.Point(150, 136)
        Me.btnExam.Name = "btnExam"
        Me.btnExam.Size = New System.Drawing.Size(85, 37)
        Me.btnExam.TabIndex = 1
        Me.btnExam.Text = "Exam Grade"
        Me.btnExam.UseVisualStyleBackColor = True
        '
        'lblPrompt
        '
        Me.lblPrompt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrompt.Location = New System.Drawing.Point(12, 9)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(260, 95)
        Me.lblPrompt.TabIndex = 2
        Me.lblPrompt.Text = "Would you like to open the Final Grade calculator or the Exam Grade calculator?"
        Me.lblPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'InitForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.lblPrompt)
        Me.Controls.Add(Me.btnExam)
        Me.Controls.Add(Me.btnFinal)
        Me.Name = "InitForm"
        Me.Text = "Select Calculator"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnFinal As Button
    Friend WithEvents btnExam As Button
    Friend WithEvents lblPrompt As Label
End Class
