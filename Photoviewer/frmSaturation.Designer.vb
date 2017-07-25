<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSaturation
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
        Me.BtnSaturation100 = New System.Windows.Forms.Button()
        Me.BtnSaturation50 = New System.Windows.Forms.Button()
        Me.BtnSaturation75 = New System.Windows.Forms.Button()
        Me.btnSaturation25 = New System.Windows.Forms.Button()
        Me.btnSaturation5 = New System.Windows.Forms.Button()
        Me.btnSaturation1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnSaturation100
        '
        Me.BtnSaturation100.Location = New System.Drawing.Point(12, 12)
        Me.BtnSaturation100.Name = "BtnSaturation100"
        Me.BtnSaturation100.Size = New System.Drawing.Size(47, 23)
        Me.BtnSaturation100.TabIndex = 4
        Me.BtnSaturation100.Text = "+100%"
        Me.BtnSaturation100.UseVisualStyleBackColor = True
        '
        'BtnSaturation50
        '
        Me.BtnSaturation50.Location = New System.Drawing.Point(118, 12)
        Me.BtnSaturation50.Name = "BtnSaturation50"
        Me.BtnSaturation50.Size = New System.Drawing.Size(47, 23)
        Me.BtnSaturation50.TabIndex = 5
        Me.BtnSaturation50.Text = "+50%"
        Me.BtnSaturation50.UseVisualStyleBackColor = True
        '
        'BtnSaturation75
        '
        Me.BtnSaturation75.Location = New System.Drawing.Point(65, 12)
        Me.BtnSaturation75.Name = "BtnSaturation75"
        Me.BtnSaturation75.Size = New System.Drawing.Size(47, 23)
        Me.BtnSaturation75.TabIndex = 6
        Me.BtnSaturation75.Text = "+75%"
        Me.BtnSaturation75.UseVisualStyleBackColor = True
        '
        'btnSaturation25
        '
        Me.btnSaturation25.Location = New System.Drawing.Point(171, 12)
        Me.btnSaturation25.Name = "btnSaturation25"
        Me.btnSaturation25.Size = New System.Drawing.Size(47, 23)
        Me.btnSaturation25.TabIndex = 7
        Me.btnSaturation25.Text = "+25%"
        Me.btnSaturation25.UseVisualStyleBackColor = True
        '
        'btnSaturation5
        '
        Me.btnSaturation5.Location = New System.Drawing.Point(224, 12)
        Me.btnSaturation5.Name = "btnSaturation5"
        Me.btnSaturation5.Size = New System.Drawing.Size(47, 23)
        Me.btnSaturation5.TabIndex = 9
        Me.btnSaturation5.Text = "+5%"
        Me.btnSaturation5.UseVisualStyleBackColor = True
        '
        'btnSaturation1
        '
        Me.btnSaturation1.Location = New System.Drawing.Point(272, 12)
        Me.btnSaturation1.Name = "btnSaturation1"
        Me.btnSaturation1.Size = New System.Drawing.Size(47, 23)
        Me.btnSaturation1.TabIndex = 10
        Me.btnSaturation1.Text = "+1%"
        Me.btnSaturation1.UseVisualStyleBackColor = True
        '
        'frmSaturation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.ClientSize = New System.Drawing.Size(331, 47)
        Me.Controls.Add(Me.btnSaturation1)
        Me.Controls.Add(Me.btnSaturation5)
        Me.Controls.Add(Me.btnSaturation25)
        Me.Controls.Add(Me.BtnSaturation75)
        Me.Controls.Add(Me.BtnSaturation50)
        Me.Controls.Add(Me.BtnSaturation100)
        Me.Location = New System.Drawing.Point(518, 10)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSaturation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Saturation"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnSaturation100 As Button
    Friend WithEvents BtnSaturation50 As Button
    Friend WithEvents BtnSaturation75 As Button
    Friend WithEvents btnSaturation25 As Button
    Friend WithEvents btnSaturation5 As Button
    Friend WithEvents btnSaturation1 As Button
End Class
