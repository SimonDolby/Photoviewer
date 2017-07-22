<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPhotoviewer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPhotoviewer))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnOpenFolder = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.FlickrToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnAuthentication = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnUploadToFlickr = New System.Windows.Forms.ToolStripMenuItem()
        Me.pictImage = New System.Windows.Forms.PictureBox()
        Me.btnNextPhoto = New System.Windows.Forms.Button()
        Me.btnPreviousPhoto = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.lblSize = New System.Windows.Forms.ToolStripLabel()
        Me.lblResolution = New System.Windows.Forms.ToolStripLabel()
        Me.lblFileName = New System.Windows.Forms.ToolStripLabel()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.pictImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.btnEdit, Me.FlickrToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip1.Size = New System.Drawing.Size(1019, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnOpenFolder})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'btnOpenFolder
        '
        Me.btnOpenFolder.Name = "btnOpenFolder"
        Me.btnOpenFolder.Size = New System.Drawing.Size(139, 22)
        Me.btnOpenFolder.Text = "Open Folder"
        '
        'btnEdit
        '
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(39, 20)
        Me.btnEdit.Text = "Edit"
        '
        'FlickrToolStripMenuItem
        '
        Me.FlickrToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAuthentication, Me.btnUploadToFlickr})
        Me.FlickrToolStripMenuItem.Name = "FlickrToolStripMenuItem"
        Me.FlickrToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.FlickrToolStripMenuItem.Text = "Flickr"
        '
        'btnAuthentication
        '
        Me.btnAuthentication.Name = "btnAuthentication"
        Me.btnAuthentication.Size = New System.Drawing.Size(153, 22)
        Me.btnAuthentication.Text = "Authentication"
        '
        'btnUploadToFlickr
        '
        Me.btnUploadToFlickr.Name = "btnUploadToFlickr"
        Me.btnUploadToFlickr.Size = New System.Drawing.Size(153, 22)
        Me.btnUploadToFlickr.Text = "Upload"
        '
        'pictImage
        '
        Me.pictImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pictImage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pictImage.Location = New System.Drawing.Point(0, 24)
        Me.pictImage.Name = "pictImage"
        Me.pictImage.Size = New System.Drawing.Size(1019, 611)
        Me.pictImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictImage.TabIndex = 1
        Me.pictImage.TabStop = False
        '
        'btnNextPhoto
        '
        Me.btnNextPhoto.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnNextPhoto.AutoSize = True
        Me.btnNextPhoto.BackColor = System.Drawing.Color.Transparent
        Me.btnNextPhoto.FlatAppearance.BorderSize = 0
        Me.btnNextPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNextPhoto.Image = CType(resources.GetObject("btnNextPhoto.Image"), System.Drawing.Image)
        Me.btnNextPhoto.Location = New System.Drawing.Point(973, 311)
        Me.btnNextPhoto.Name = "btnNextPhoto"
        Me.btnNextPhoto.Size = New System.Drawing.Size(46, 36)
        Me.btnNextPhoto.TabIndex = 2
        Me.btnNextPhoto.UseVisualStyleBackColor = False
        '
        'btnPreviousPhoto
        '
        Me.btnPreviousPhoto.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnPreviousPhoto.AutoSize = True
        Me.btnPreviousPhoto.FlatAppearance.BorderSize = 0
        Me.btnPreviousPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPreviousPhoto.Image = CType(resources.GetObject("btnPreviousPhoto.Image"), System.Drawing.Image)
        Me.btnPreviousPhoto.Location = New System.Drawing.Point(0, 311)
        Me.btnPreviousPhoto.Name = "btnPreviousPhoto"
        Me.btnPreviousPhoto.Size = New System.Drawing.Size(46, 36)
        Me.btnPreviousPhoto.TabIndex = 3
        Me.btnPreviousPhoto.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblSize, Me.lblResolution, Me.lblFileName})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1019, 25)
        Me.ToolStrip1.TabIndex = 4
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'lblSize
        '
        Me.lblSize.Name = "lblSize"
        Me.lblSize.Size = New System.Drawing.Size(0, 22)
        '
        'lblResolution
        '
        Me.lblResolution.Name = "lblResolution"
        Me.lblResolution.Size = New System.Drawing.Size(0, 22)
        '
        'lblFileName
        '
        Me.lblFileName.Name = "lblFileName"
        Me.lblFileName.Size = New System.Drawing.Size(0, 22)
        '
        'frmPhotoviewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1019, 635)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.btnPreviousPhoto)
        Me.Controls.Add(Me.btnNextPhoto)
        Me.Controls.Add(Me.pictImage)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmPhotoviewer"
        Me.Text = "Photoviewer"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.pictImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents pictImage As PictureBox
    Friend WithEvents btnNextPhoto As Button
    Friend WithEvents btnPreviousPhoto As Button
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnOpenFolder As ToolStripMenuItem
    Friend WithEvents btnEdit As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents lblSize As ToolStripLabel
    Friend WithEvents lblResolution As ToolStripLabel
    Friend WithEvents lblFileName As ToolStripLabel
    Friend WithEvents FlickrToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnAuthentication As ToolStripMenuItem
    Friend WithEvents btnUploadToFlickr As ToolStripMenuItem
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
End Class
