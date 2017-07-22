<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FlickrSetupvb
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
        Me.btnAuthenticate = New System.Windows.Forms.Button()
        Me.VerifierTextBox = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.CompleteAuthButton = New System.Windows.Forms.Button()
        Me.ResultLabel = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAuthenticate
        '
        Me.btnAuthenticate.Location = New System.Drawing.Point(95, 69)
        Me.btnAuthenticate.Name = "btnAuthenticate"
        Me.btnAuthenticate.Size = New System.Drawing.Size(75, 23)
        Me.btnAuthenticate.TabIndex = 0
        Me.btnAuthenticate.Text = "Authenticate"
        Me.btnAuthenticate.UseVisualStyleBackColor = True
        '
        'VerifierTextBox
        '
        Me.VerifierTextBox.Location = New System.Drawing.Point(95, 124)
        Me.VerifierTextBox.Name = "VerifierTextBox"
        Me.VerifierTextBox.Size = New System.Drawing.Size(100, 20)
        Me.VerifierTextBox.TabIndex = 8
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(50, 127)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(39, 13)
        Me.label3.TabIndex = 7
        Me.label3.Text = "Verifier"
        '
        'CompleteAuthButton
        '
        Me.CompleteAuthButton.Location = New System.Drawing.Point(95, 164)
        Me.CompleteAuthButton.Name = "CompleteAuthButton"
        Me.CompleteAuthButton.Size = New System.Drawing.Size(75, 23)
        Me.CompleteAuthButton.TabIndex = 6
        Me.CompleteAuthButton.Text = "Complete"
        Me.CompleteAuthButton.UseVisualStyleBackColor = True
        '
        'ResultLabel
        '
        Me.ResultLabel.Location = New System.Drawing.Point(50, 201)
        Me.ResultLabel.Name = "ResultLabel"
        Me.ResultLabel.Size = New System.Drawing.Size(188, 51)
        Me.ResultLabel.TabIndex = 9
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(12, 9)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(260, 58)
        Me.label2.TabIndex = 10
        Me.label2.Text = "Click the Authenticate button to start authentication. You will be taken to the F" &
    "lickr web site. Once you have authenticated copy the Verifier code into the box " &
    "and press Complete."
        '
        'FlickrSetupvb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.ResultLabel)
        Me.Controls.Add(Me.VerifierTextBox)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.CompleteAuthButton)
        Me.Controls.Add(Me.btnAuthenticate)
        Me.Name = "FlickrSetupvb"
        Me.Text = "FlickrSetupvb"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAuthenticate As Button
    Private WithEvents VerifierTextBox As TextBox
    Private WithEvents label3 As Label
    Private WithEvents CompleteAuthButton As Button
    Private WithEvents ResultLabel As Label
    Private WithEvents label2 As Label
End Class
