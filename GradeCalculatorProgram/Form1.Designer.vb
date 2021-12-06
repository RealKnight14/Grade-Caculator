<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCheck
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
        Me.lblScore = New System.Windows.Forms.Label()
        Me.txtScore = New System.Windows.Forms.TextBox()
        Me.btnGradeCheck = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblScore.Location = New System.Drawing.Point(22, 105)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(181, 25)
        Me.lblScore.TabIndex = 0
        Me.lblScore.Text = "Enter the test score"
        '
        'txtScore
        '
        Me.txtScore.Location = New System.Drawing.Point(209, 110)
        Me.txtScore.Name = "txtScore"
        Me.txtScore.Size = New System.Drawing.Size(232, 23)
        Me.txtScore.TabIndex = 1
        '
        'btnGradeCheck
        '
        Me.btnGradeCheck.Location = New System.Drawing.Point(283, 323)
        Me.btnGradeCheck.Name = "btnGradeCheck"
        Me.btnGradeCheck.Size = New System.Drawing.Size(217, 58)
        Me.btnGradeCheck.TabIndex = 2
        Me.btnGradeCheck.Text = "Grade Check"
        Me.btnGradeCheck.UseVisualStyleBackColor = True
        '
        'frmCheck
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnGradeCheck)
        Me.Controls.Add(Me.txtScore)
        Me.Controls.Add(Me.lblScore)
        Me.Name = "frmCheck"
        Me.Text = "Grade Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblScore As Label
    Friend WithEvents txtScore As TextBox
    Friend WithEvents btnGradeCheck As Button
End Class
