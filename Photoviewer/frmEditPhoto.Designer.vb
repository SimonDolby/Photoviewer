<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEditPhoto
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnSaveImage = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnContrast = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnSaturation = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnBrightness = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnGrayscale = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnUndoAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnSepia = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnBlackAndWhite = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnSharpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.EdgeDetectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnGaussian = New System.Windows.Forms.ToolStripMenuItem()
        Me.pictPhoto = New System.Windows.Forms.PictureBox()
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.btnLaplacian5x5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.pictPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.btnContrast, Me.BtnSaturation, Me.btnBrightness, Me.btnGrayscale, Me.ToolStripMenuItem1, Me.BtnUndoAll, Me.EditToolStripMenuItem, Me.btnSepia, Me.BtnBlackAndWhite, Me.btnSharpen, Me.EdgeDetectionToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1134, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSaveImage})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'btnSaveImage
        '
        Me.btnSaveImage.Name = "btnSaveImage"
        Me.btnSaveImage.Size = New System.Drawing.Size(134, 22)
        Me.btnSaveImage.Text = "Save Image"
        '
        'btnContrast
        '
        Me.btnContrast.Name = "btnContrast"
        Me.btnContrast.Size = New System.Drawing.Size(64, 20)
        Me.btnContrast.Text = "Contrast"
        '
        'BtnSaturation
        '
        Me.BtnSaturation.Name = "BtnSaturation"
        Me.BtnSaturation.Size = New System.Drawing.Size(73, 20)
        Me.BtnSaturation.Text = "Saturation"
        '
        'btnBrightness
        '
        Me.btnBrightness.Name = "btnBrightness"
        Me.btnBrightness.Size = New System.Drawing.Size(74, 20)
        Me.btnBrightness.Text = "Brightness"
        Me.btnBrightness.Visible = False
        '
        'btnGrayscale
        '
        Me.btnGrayscale.Name = "btnGrayscale"
        Me.btnGrayscale.Size = New System.Drawing.Size(69, 20)
        Me.btnGrayscale.Text = "Grayscale"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(12, 20)
        '
        'BtnUndoAll
        '
        Me.BtnUndoAll.Name = "BtnUndoAll"
        Me.BtnUndoAll.Size = New System.Drawing.Size(114, 20)
        Me.BtnUndoAll.Text = "Undo All Changes"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'btnSepia
        '
        Me.btnSepia.Name = "btnSepia"
        Me.btnSepia.Size = New System.Drawing.Size(47, 20)
        Me.btnSepia.Text = "Sepia"
        '
        'BtnBlackAndWhite
        '
        Me.BtnBlackAndWhite.Name = "BtnBlackAndWhite"
        Me.BtnBlackAndWhite.Size = New System.Drawing.Size(104, 20)
        Me.BtnBlackAndWhite.Text = "Black and White"
        '
        'btnSharpen
        '
        Me.btnSharpen.Name = "btnSharpen"
        Me.btnSharpen.Size = New System.Drawing.Size(62, 20)
        Me.btnSharpen.Text = "Sharpen"
        '
        'EdgeDetectionToolStripMenuItem
        '
        Me.EdgeDetectionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnGaussian, Me.btnLaplacian5x5})
        Me.EdgeDetectionToolStripMenuItem.Name = "EdgeDetectionToolStripMenuItem"
        Me.EdgeDetectionToolStripMenuItem.Size = New System.Drawing.Size(99, 20)
        Me.EdgeDetectionToolStripMenuItem.Text = "Edge Detection"
        '
        'BtnGaussian
        '
        Me.BtnGaussian.Name = "BtnGaussian"
        Me.BtnGaussian.Size = New System.Drawing.Size(152, 22)
        Me.BtnGaussian.Text = "Gaussian"
        '
        'pictPhoto
        '
        Me.pictPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pictPhoto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pictPhoto.Location = New System.Drawing.Point(0, 24)
        Me.pictPhoto.Name = "pictPhoto"
        Me.pictPhoto.Size = New System.Drawing.Size(1134, 587)
        Me.pictPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictPhoto.TabIndex = 2
        Me.pictPhoto.TabStop = False
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'btnLaplacian5x5
        '
        Me.btnLaplacian5x5.Name = "btnLaplacian5x5"
        Me.btnLaplacian5x5.Size = New System.Drawing.Size(152, 22)
        Me.btnLaplacian5x5.Text = "Laplacian 5x5"
        '
        'frmEditPhoto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1134, 611)
        Me.Controls.Add(Me.pictPhoto)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmEditPhoto"
        Me.Text = "EditPhoto"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.pictPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnContrast As ToolStripMenuItem
    Friend WithEvents BtnSaturation As ToolStripMenuItem
    Friend WithEvents btnGrayscale As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents BtnUndoAll As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnSaveImage As ToolStripMenuItem

    Friend WithEvents pictPhoto As PictureBox
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents btnBrightness As ToolStripMenuItem
    Friend WithEvents btnSepia As ToolStripMenuItem
    Friend WithEvents BtnBlackAndWhite As ToolStripMenuItem
    Friend WithEvents btnSharpen As ToolStripMenuItem
    Friend WithEvents EdgeDetectionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BtnGaussian As ToolStripMenuItem
    Friend WithEvents btnLaplacian5x5 As ToolStripMenuItem
End Class
