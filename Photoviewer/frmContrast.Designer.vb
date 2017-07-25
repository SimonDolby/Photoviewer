<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmContrast
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
        Me.btnContrast1 = New System.Windows.Forms.Button()
        Me.btnContrast5 = New System.Windows.Forms.Button()
        Me.btnContrast25 = New System.Windows.Forms.Button()
        Me.BtnContrast75 = New System.Windows.Forms.Button()
        Me.BtnContrast50 = New System.Windows.Forms.Button()
        Me.BtnContrast100 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnContrast1
        '
        Me.btnContrast1.Location = New System.Drawing.Point(267, 12)
        Me.btnContrast1.Name = "btnContrast1"
        Me.btnContrast1.Size = New System.Drawing.Size(47, 23)
        Me.btnContrast1.TabIndex = 22
        Me.btnContrast1.Text = "+1%"
        Me.btnContrast1.UseVisualStyleBackColor = True
        '
        'btnContrast5
        '
        Me.btnContrast5.Location = New System.Drawing.Point(214, 12)
        Me.btnContrast5.Name = "btnContrast5"
        Me.btnContrast5.Size = New System.Drawing.Size(47, 23)
        Me.btnContrast5.TabIndex = 21
        Me.btnContrast5.Text = "+5%"
        Me.btnContrast5.UseVisualStyleBackColor = True
        '
        'btnContrast25
        '
        Me.btnContrast25.Location = New System.Drawing.Point(161, 12)
        Me.btnContrast25.Name = "btnContrast25"
        Me.btnContrast25.Size = New System.Drawing.Size(47, 23)
        Me.btnContrast25.TabIndex = 19
        Me.btnContrast25.Text = "+25%"
        Me.btnContrast25.UseVisualStyleBackColor = True
        '
        'BtnContrast75
        '
        Me.BtnContrast75.Location = New System.Drawing.Point(55, 12)
        Me.BtnContrast75.Name = "BtnContrast75"
        Me.BtnContrast75.Size = New System.Drawing.Size(47, 23)
        Me.BtnContrast75.TabIndex = 18
        Me.BtnContrast75.Text = "+75%"
        Me.BtnContrast75.UseVisualStyleBackColor = True
        '
        'BtnContrast50
        '
        Me.BtnContrast50.Location = New System.Drawing.Point(108, 12)
        Me.BtnContrast50.Name = "BtnContrast50"
        Me.BtnContrast50.Size = New System.Drawing.Size(47, 23)
        Me.BtnContrast50.TabIndex = 17
        Me.BtnContrast50.Text = "+50%"
        Me.BtnContrast50.UseVisualStyleBackColor = True
        '
        'BtnContrast100
        '
        Me.BtnContrast100.Location = New System.Drawing.Point(2, 12)
        Me.BtnContrast100.Name = "BtnContrast100"
        Me.BtnContrast100.Size = New System.Drawing.Size(47, 23)
        Me.BtnContrast100.TabIndex = 16
        Me.BtnContrast100.Text = "+100%"
        Me.BtnContrast100.UseVisualStyleBackColor = True
        '
        'frmContrast
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(319, 44)
        Me.Controls.Add(Me.btnContrast1)
        Me.Controls.Add(Me.btnContrast5)
        Me.Controls.Add(Me.btnContrast25)
        Me.Controls.Add(Me.BtnContrast75)
        Me.Controls.Add(Me.BtnContrast50)
        Me.Controls.Add(Me.BtnContrast100)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmContrast"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Contrast"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnContrast1 As Button
    Friend WithEvents btnContrast5 As Button
    Friend WithEvents btnContrast25 As Button
    Friend WithEvents BtnContrast75 As Button
    Friend WithEvents BtnContrast50 As Button
    Friend WithEvents BtnContrast100 As Button
End Class
