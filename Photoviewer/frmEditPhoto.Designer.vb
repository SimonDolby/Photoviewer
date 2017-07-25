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
        Me.btnUndo = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnRedo = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnUndoAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnBrightness = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnGrayscale = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnSepia = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnBlackAndWhite = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnSharpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.EdgeDetectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btmLaplacian3x3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Laplacian3x3GrayScale = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnLaplacian5x5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnLaplaxian5x5Grayscale = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnLaplacianGausian = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnLaplacian3x3ofGaussian3x3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnLaplacian3x3ofGaussian5x5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnaplacian5x5ofGaussian3x3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnLaplacian5x5ofGaussian5x5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnSobel3x3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnSobel3x3Grayscale = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnPrewitt = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnPrewittGrayscale = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnKirsch = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnKirschGrayscale = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnColor = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnSaturation = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnContrast = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnRGBToBGR = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnRGBToGBR = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.pictPhoto = New System.Windows.Forms.PictureBox()
        Me.btnPolaroid = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.btnUndo, Me.btnRedo, Me.BtnUndoAll, Me.btnBrightness, Me.btnGrayscale, Me.ToolStripMenuItem1, Me.btnSepia, Me.BtnBlackAndWhite, Me.btnSharpen, Me.EdgeDetectionToolStripMenuItem, Me.btnColor})
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
        'btnUndo
        '
        Me.btnUndo.Name = "btnUndo"
        Me.btnUndo.Size = New System.Drawing.Size(48, 20)
        Me.btnUndo.Text = "Undo"
        '
        'btnRedo
        '
        Me.btnRedo.Name = "btnRedo"
        Me.btnRedo.Size = New System.Drawing.Size(46, 20)
        Me.btnRedo.Text = "Redo"
        '
        'BtnUndoAll
        '
        Me.BtnUndoAll.Name = "BtnUndoAll"
        Me.BtnUndoAll.Size = New System.Drawing.Size(114, 20)
        Me.BtnUndoAll.Text = "Undo All Changes"
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
        Me.EdgeDetectionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btmLaplacian3x3, Me.Laplacian3x3GrayScale, Me.btnLaplacian5x5, Me.btnLaplaxian5x5Grayscale, Me.btnLaplacianGausian, Me.BtnLaplacian3x3ofGaussian3x3, Me.btnLaplacian3x3ofGaussian5x5, Me.btnaplacian5x5ofGaussian3x3, Me.btnLaplacian5x5ofGaussian5x5, Me.btnSobel3x3, Me.btnSobel3x3Grayscale, Me.btnPrewitt, Me.btnPrewittGrayscale, Me.btnKirsch, Me.btnKirschGrayscale})
        Me.EdgeDetectionToolStripMenuItem.Name = "EdgeDetectionToolStripMenuItem"
        Me.EdgeDetectionToolStripMenuItem.Size = New System.Drawing.Size(99, 20)
        Me.EdgeDetectionToolStripMenuItem.Text = "Edge Detection"
        '
        'btmLaplacian3x3
        '
        Me.btmLaplacian3x3.Name = "btmLaplacian3x3"
        Me.btmLaplacian3x3.Size = New System.Drawing.Size(228, 22)
        Me.btmLaplacian3x3.Text = "Laplacian 3x3"
        '
        'Laplacian3x3GrayScale
        '
        Me.Laplacian3x3GrayScale.Name = "Laplacian3x3GrayScale"
        Me.Laplacian3x3GrayScale.Size = New System.Drawing.Size(228, 22)
        Me.Laplacian3x3GrayScale.Text = "Laplacian 3 x 3 Grayscale"
        '
        'btnLaplacian5x5
        '
        Me.btnLaplacian5x5.Name = "btnLaplacian5x5"
        Me.btnLaplacian5x5.Size = New System.Drawing.Size(228, 22)
        Me.btnLaplacian5x5.Text = "Laplacian 5x5"
        '
        'btnLaplaxian5x5Grayscale
        '
        Me.btnLaplaxian5x5Grayscale.Name = "btnLaplaxian5x5Grayscale"
        Me.btnLaplaxian5x5Grayscale.Size = New System.Drawing.Size(228, 22)
        Me.btnLaplaxian5x5Grayscale.Text = "Laplacian 5x5 Grayscale"
        '
        'btnLaplacianGausian
        '
        Me.btnLaplacianGausian.Name = "btnLaplacianGausian"
        Me.btnLaplacianGausian.Size = New System.Drawing.Size(228, 22)
        Me.btnLaplacianGausian.Text = "Laplacian of Gaussian"
        '
        'BtnLaplacian3x3ofGaussian3x3
        '
        Me.BtnLaplacian3x3ofGaussian3x3.Name = "BtnLaplacian3x3ofGaussian3x3"
        Me.BtnLaplacian3x3ofGaussian3x3.Size = New System.Drawing.Size(228, 22)
        Me.BtnLaplacian3x3ofGaussian3x3.Text = "Laplacian 3x3 of Gaussian 3x3"
        '
        'btnLaplacian3x3ofGaussian5x5
        '
        Me.btnLaplacian3x3ofGaussian5x5.Name = "btnLaplacian3x3ofGaussian5x5"
        Me.btnLaplacian3x3ofGaussian5x5.Size = New System.Drawing.Size(228, 22)
        Me.btnLaplacian3x3ofGaussian5x5.Text = "Laplacian 3x3 of Gaussian 5x5"
        '
        'btnaplacian5x5ofGaussian3x3
        '
        Me.btnaplacian5x5ofGaussian3x3.Name = "btnaplacian5x5ofGaussian3x3"
        Me.btnaplacian5x5ofGaussian3x3.Size = New System.Drawing.Size(228, 22)
        Me.btnaplacian5x5ofGaussian3x3.Text = "Laplacian 5x5 of Gaussian 3x3"
        '
        'btnLaplacian5x5ofGaussian5x5
        '
        Me.btnLaplacian5x5ofGaussian5x5.Name = "btnLaplacian5x5ofGaussian5x5"
        Me.btnLaplacian5x5ofGaussian5x5.Size = New System.Drawing.Size(228, 22)
        Me.btnLaplacian5x5ofGaussian5x5.Text = "Laplacian 5x5 of Gaussian 5x5"
        '
        'btnSobel3x3
        '
        Me.btnSobel3x3.Name = "btnSobel3x3"
        Me.btnSobel3x3.Size = New System.Drawing.Size(228, 22)
        Me.btnSobel3x3.Text = "Sobel 3x3"
        '
        'btnSobel3x3Grayscale
        '
        Me.btnSobel3x3Grayscale.Name = "btnSobel3x3Grayscale"
        Me.btnSobel3x3Grayscale.Size = New System.Drawing.Size(228, 22)
        Me.btnSobel3x3Grayscale.Text = "Sobel 3x3 Grayscale"
        '
        'btnPrewitt
        '
        Me.btnPrewitt.Name = "btnPrewitt"
        Me.btnPrewitt.Size = New System.Drawing.Size(228, 22)
        Me.btnPrewitt.Text = "Prewitt"
        '
        'btnPrewittGrayscale
        '
        Me.btnPrewittGrayscale.Name = "btnPrewittGrayscale"
        Me.btnPrewittGrayscale.Size = New System.Drawing.Size(228, 22)
        Me.btnPrewittGrayscale.Text = "Prewitt Grayscale"
        '
        'btnKirsch
        '
        Me.btnKirsch.Name = "btnKirsch"
        Me.btnKirsch.Size = New System.Drawing.Size(228, 22)
        Me.btnKirsch.Text = "Kirsch"
        '
        'btnKirschGrayscale
        '
        Me.btnKirschGrayscale.Name = "btnKirschGrayscale"
        Me.btnKirschGrayscale.Size = New System.Drawing.Size(228, 22)
        Me.btnKirschGrayscale.Text = "Kirsch Grayscale"
        '
        'btnColor
        '
        Me.btnColor.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSaturation, Me.BtnContrast, Me.btnRGBToBGR, Me.BtnRGBToGBR, Me.btnPolaroid})
        Me.btnColor.Name = "btnColor"
        Me.btnColor.Size = New System.Drawing.Size(48, 20)
        Me.btnColor.Text = "Color"
        '
        'btnSaturation
        '
        Me.btnSaturation.Name = "btnSaturation"
        Me.btnSaturation.Size = New System.Drawing.Size(152, 22)
        Me.btnSaturation.Text = "Saturation"
        '
        'BtnContrast
        '
        Me.BtnContrast.Name = "BtnContrast"
        Me.BtnContrast.Size = New System.Drawing.Size(152, 22)
        Me.BtnContrast.Text = "Contrast"
        '
        'btnRGBToBGR
        '
        Me.btnRGBToBGR.Name = "btnRGBToBGR"
        Me.btnRGBToBGR.Size = New System.Drawing.Size(152, 22)
        Me.btnRGBToBGR.Text = "RGB to BGR"
        '
        'BtnRGBToGBR
        '
        Me.BtnRGBToGBR.Name = "BtnRGBToGBR"
        Me.BtnRGBToGBR.Size = New System.Drawing.Size(152, 22)
        Me.BtnRGBToGBR.Text = "RGB to GBR"
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
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
        'btnPolaroid
        '
        Me.btnPolaroid.Name = "btnPolaroid"
        Me.btnPolaroid.Size = New System.Drawing.Size(152, 22)
        Me.btnPolaroid.Text = "Polaroid"
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
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnGrayscale As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents BtnUndoAll As ToolStripMenuItem
    Friend WithEvents btnUndo As ToolStripMenuItem
    Friend WithEvents btnSaveImage As ToolStripMenuItem
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents btnBrightness As ToolStripMenuItem
    Friend WithEvents btnSepia As ToolStripMenuItem
    Friend WithEvents BtnBlackAndWhite As ToolStripMenuItem
    Friend WithEvents btnSharpen As ToolStripMenuItem
    Friend WithEvents EdgeDetectionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnLaplacian5x5 As ToolStripMenuItem
    Friend WithEvents btnRedo As ToolStripMenuItem
    Friend WithEvents pictPhoto As PictureBox
    Friend WithEvents btmLaplacian3x3 As ToolStripMenuItem
    Friend WithEvents Laplacian3x3GrayScale As ToolStripMenuItem
    Friend WithEvents btnLaplaxian5x5Grayscale As ToolStripMenuItem
    Friend WithEvents btnLaplacianGausian As ToolStripMenuItem
    Friend WithEvents BtnLaplacian3x3ofGaussian3x3 As ToolStripMenuItem
    Friend WithEvents btnLaplacian3x3ofGaussian5x5 As ToolStripMenuItem
    Friend WithEvents btnaplacian5x5ofGaussian3x3 As ToolStripMenuItem
    Friend WithEvents btnLaplacian5x5ofGaussian5x5 As ToolStripMenuItem
    Friend WithEvents btnSobel3x3 As ToolStripMenuItem
    Friend WithEvents btnSobel3x3Grayscale As ToolStripMenuItem
    Friend WithEvents btnPrewitt As ToolStripMenuItem
    Friend WithEvents btnPrewittGrayscale As ToolStripMenuItem
    Friend WithEvents btnKirsch As ToolStripMenuItem
    Friend WithEvents btnKirschGrayscale As ToolStripMenuItem
    Friend WithEvents btnColor As ToolStripMenuItem
    Friend WithEvents btnSaturation As ToolStripMenuItem
    Friend WithEvents BtnContrast As ToolStripMenuItem
    Friend WithEvents btnRGBToBGR As ToolStripMenuItem
    Friend WithEvents BtnRGBToGBR As ToolStripMenuItem
    Friend WithEvents btnPolaroid As ToolStripMenuItem
End Class
