Imports System.IO
Imports FlickrNet

Public Class frmPhotoviewer
    Dim ImagesInFolder As New Stack
    Dim index As New Integer

    Private Sub Stackinitialisation(ByVal GetLocation As String)


        For Each Image As String In My.Computer.FileSystem.GetFiles(GetLocation, FileIO.SearchOption.SearchTopLevelOnly, "*.jpg*", "*.gif*", "*.bmp*") ', "*.gif*", "*.jpg*", "*.bmp*", "*.png*")
            'For each image in the directory chosen by the above dialog box add the image name to the listbox
            ImagesInFolder.Push(Image)

        Next
    End Sub


    Private Sub btnOpenFolder_Click(sender As Object, e As EventArgs) Handles btnOpenFolder.Click
        Dim folderDlg As New FolderBrowserDialog

        folderDlg.ShowNewFolderButton = True

        'Opens up a dialog box enabling the user to select the folder they'd like to list photos from.
        If (folderDlg.ShowDialog() = DialogResult.OK) Then
            Stackinitialisation(folderDlg.SelectedPath)
            Dim root As Environment.SpecialFolder = folderDlg.RootFolder
        End If
        pictImage.ImageLocation = ImagesInFolder(index)
        Dim infoReader As System.IO.FileInfo
        Dim Size As Double
        infoReader = My.Computer.FileSystem.GetFileInfo(pictImage.ImageLocation)
        Size = infoReader.Length / 1024
        Size = Size / 1024
        Size = Math.Round(Size, 2)


        lblSize.Text = "Size: " + Size.ToString + "mb"
        Dim bmp As New Bitmap(pictImage.ImageLocation)
        lblResolution.Text = "Photo: " + bmp.Width.ToString + " x " + bmp.Height.ToString
        lblFileName.Text = Path.GetFileName(pictImage.ImageLocation).ToString
    End Sub

    Private Sub btnPreviousPhoto_Click(sender As Object, e As EventArgs) Handles btnPreviousPhoto.Click
        If index <> 0 Then
            index = index - 1
        End If


        pictImage.ImageLocation = ImagesInFolder(index)
        Dim infoReader As System.IO.FileInfo
        Dim Size As Double
        infoReader = My.Computer.FileSystem.GetFileInfo(pictImage.ImageLocation)
        Size = infoReader.Length / 1024
        Size = Size / 1024
        Size = Math.Round(Size, 1)


        lblSize.Text = "Size: " + Size.ToString + "Megabytes"

        Dim bmp As New Bitmap(pictImage.ImageLocation)
        lblResolution.Text = "Photo: " + bmp.Width.ToString + " x " + bmp.Height.ToString
        lblFileName.Text = Path.GetFileName(pictImage.ImageLocation).ToString
    End Sub

    Private Sub btnNextPhoto_Click(sender As Object, e As EventArgs) Handles btnNextPhoto.Click
        index = index + 1
        pictImage.ImageLocation = ImagesInFolder(index)
        Dim infoReader As System.IO.FileInfo
        Dim Size As Double
        infoReader = My.Computer.FileSystem.GetFileInfo(pictImage.ImageLocation)
        Size = infoReader.Length / 1024
        Size = Size / 1024
        Size = Math.Round(Size, 2)


        lblSize.Text = "Size: " + Size.ToString + "mb"
        Dim bmp As New Bitmap(pictImage.ImageLocation)
        lblResolution.Text = "Photo: " + bmp.Width.ToString + " x " + bmp.Height.ToString
        lblFileName.Text = Path.GetFileName(pictImage.ImageLocation).ToString
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        index = 0

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If pictImage.ImageLocation IsNot Nothing Then
            frmEditPhoto.Show()

        End If

    End Sub


End Class
