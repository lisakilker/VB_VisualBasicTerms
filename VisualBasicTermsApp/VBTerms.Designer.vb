<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVBTerms
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
        Me.picVBTermsLogo = New System.Windows.Forms.PictureBox()
        Me.btnVBTerm1 = New System.Windows.Forms.Button()
        Me.btnVBTerm2 = New System.Windows.Forms.Button()
        Me.btnVBTerm3 = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblVBTerms = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.picVBTermsLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picVBTermsLogo
        '
        Me.picVBTermsLogo.Location = New System.Drawing.Point(12, 12)
        Me.picVBTermsLogo.Name = "picVBTermsLogo"
        Me.picVBTermsLogo.Size = New System.Drawing.Size(99, 93)
        Me.picVBTermsLogo.TabIndex = 0
        Me.picVBTermsLogo.TabStop = False
        '
        'btnVBTerm1
        '
        Me.btnVBTerm1.Location = New System.Drawing.Point(113, 191)
        Me.btnVBTerm1.Name = "btnVBTerm1"
        Me.btnVBTerm1.Size = New System.Drawing.Size(75, 23)
        Me.btnVBTerm1.TabIndex = 2
        Me.btnVBTerm1.Text = "Term 1"
        Me.btnVBTerm1.UseVisualStyleBackColor = True
        '
        'btnVBTerm2
        '
        Me.btnVBTerm2.Location = New System.Drawing.Point(113, 238)
        Me.btnVBTerm2.Name = "btnVBTerm2"
        Me.btnVBTerm2.Size = New System.Drawing.Size(75, 23)
        Me.btnVBTerm2.TabIndex = 3
        Me.btnVBTerm2.Text = "Term 2"
        Me.btnVBTerm2.UseVisualStyleBackColor = True
        '
        'btnVBTerm3
        '
        Me.btnVBTerm3.Location = New System.Drawing.Point(113, 283)
        Me.btnVBTerm3.Name = "btnVBTerm3"
        Me.btnVBTerm3.Size = New System.Drawing.Size(75, 23)
        Me.btnVBTerm3.TabIndex = 4
        Me.btnVBTerm3.Text = "Term 3"
        Me.btnVBTerm3.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(385, 376)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblVBTerms
        '
        Me.lblVBTerms.AutoSize = True
        Me.lblVBTerms.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVBTerms.Location = New System.Drawing.Point(109, 130)
        Me.lblVBTerms.Name = "lblVBTerms"
        Me.lblVBTerms.Size = New System.Drawing.Size(254, 24)
        Me.lblVBTerms.TabIndex = 6
        Me.lblVBTerms.Text = "Visual Basic 2012 Terms"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(234, 196)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(234, 238)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(237, 283)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Label3"
        '
        'FrmVBTerms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(473, 413)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblVBTerms)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnVBTerm3)
        Me.Controls.Add(Me.btnVBTerm2)
        Me.Controls.Add(Me.btnVBTerm1)
        Me.Controls.Add(Me.picVBTermsLogo)
        Me.Name = "FrmVBTerms"
        Me.Text = "Visual Basic 2012 Terms Application"
        CType(Me.picVBTermsLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picVBTermsLogo As System.Windows.Forms.PictureBox
    Friend WithEvents btnVBTerm1 As System.Windows.Forms.Button
    Friend WithEvents btnVBTerm2 As System.Windows.Forms.Button
    Friend WithEvents btnVBTerm3 As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblVBTerms As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
