
Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging
Imports System.Runtime.InteropServices
Imports System.Threading
Imports frmPhotoviewer.ConvolutionMatrices
Imports Photoviewer.Colors.Contrast
Imports System.IO

Public Class frmEditPhoto
    Public Shared UndoSteps As New Stack
    Public Shared RedoSteps As New Stack
    Public Shared PhotoToSend As Image
    Dim BackupPhoto As Bitmap
    Dim SharpenedPhoto As Image

    Public Sub SaveFile(ByVal PicBox As Image, ByVal Destination As String, ByVal Path As String)
        Dim Destinationpath As String
        Dim FileName As String
        Try
            FileName = Path
            Destinationpath = Destination
            PicBox.Save(Destinationpath)
            If IO.File.Exists(Destinationpath) Then

                IO.File.Delete(Destinationpath)
                PicBox.Save(Destinationpath)
            Else
                '  MsgBox("Save successful")
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub



    Public Sub EditPhoto_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        pictPhoto.Image = frmPhotoviewer.pictImage.Image
        pictPhoto.ImageLocation = frmPhotoviewer.pictImage.ImageLocation
        BackupPhoto = pictPhoto.Image

        SharpenedPhoto = Convolution_Matrices.Sharpen(pictPhoto.Image, 9)
        PhotoToSend = pictPhoto.Image

        btnUndo.Visible = False
        btnRedo.Visible = False

    End Sub



    Private Sub BtnGrayscale_Click(sender As Object, e As EventArgs) Handles btnGrayscale.Click
        UndoSteps.Push(pictPhoto.Image)
        pictPhoto.Image = Grayscale(pictPhoto.Image)
        GetCount()
    End Sub

    Private Sub pictPhoto_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnBlackandWhite_Click(sender As Object, e As EventArgs) Handles BtnBlackAndWhite.Click
        UndoSteps.Push(pictPhoto.Image)
        pictPhoto.Image = BlackAndWhite(pictPhoto.Image)
        GetCount()
    End Sub


    Private Sub BtnUndoAll_Click(sender As Object, e As EventArgs) Handles BtnUndoAll.Click
        pictPhoto.Image = BackupPhoto
        GetCount()
    End Sub



    Private Sub btnSharpen_Click(sender As Object, e As EventArgs) Handles btnSharpen.Click


        pictPhoto.Image = SharpenedPhoto

    End Sub

    Private Sub btnSaveImage_Click(sender As Object, e As EventArgs) Handles btnSaveImage.Click
        SaveFile(pictPhoto.Image, pictPhoto.ImageLocation, pictPhoto.ImageLocation)
    End Sub




    Private Sub BtnSaturation_Click(sender As Object, e As EventArgs) Handles btnSaturation.Click
        frmSaturation.Show()
    End Sub

    Private Sub btnContrast_Click(sender As Object, e As EventArgs) Handles BtnContrast.Click
        frmContrast.Show()
    End Sub

    Private Sub btnBrightness_Click(sender As Object, e As EventArgs) Handles btnBrightness.Click
        frmBrightness.Show()
    End Sub



    Private Sub btnSepia_Click(sender As Object, e As EventArgs) Handles btnSepia.Click
        UndoSteps.Push(pictPhoto.Image)
        pictPhoto.Image = Sepia(pictPhoto.Image)
        GetCount()
    End Sub

    Private Sub btnUndo_Click(sender As Object, e As EventArgs) Handles btnUndo.Click
        RedoSteps.Push(pictPhoto.Image) ' Pushes(Adds) the current image to RedoSteps stack
        pictPhoto.Image = UndoSteps.Peek() ' Sets the image as the last value of the undosteps stack.
        UndoSteps.Pop() 'Pops(Removes) the item from the stack.
        GetCount()
    End Sub

    Public Sub GetCount()
        'This sub routine controls the redo and undo buttons.

        Select Case RedoSteps.Count

            Case Is = 0
                ' If there are no images in the RedoSteps stack then sets all the buttons to being unseen by the user.

                btnRedo.Visible = False
                btnUndo.Visible = False

            Case Is > 0
                ' If there are more than 0 images in the redosteps stack, the routine allows the user to see the reset button and redo button.

                btnRedo.Visible = True

            Case Is > 1
                'If there are more than 1 image in the stack, then allows the routine to see the undo button.
                btnUndo.Visible = True

        End Select

        Select Case UndoSteps.Count
            Case Is = 0
                ' If there are no images in the undoSteps stack then sets all the buttons to being unseen by the user.

                btnRedo.Visible = True
                btnUndo.Visible = False

            Case Is > 0
                ' If there are more than 0 images in the undosteps stack, the routine allows the user to see the reset button and undo button.
                btnUndo.Visible = True

            Case Is > 1
                'If there are more than 1 image in the stack, then allows the routine to see the redo button.
                btnRedo.Visible = True
        End Select



    End Sub

    Private Sub btnRedo_Click(sender As Object, e As EventArgs) Handles btnRedo.Click
        UndoSteps.Push(pictPhoto.Image) 'Pushes the current image to the undo stack.
        pictPhoto.Image = RedoSteps.Peek ' Sets the current image to the top image of the stack
        RedoSteps.Pop() ' Pops the the top item form the top of the stack.
        GetCount() ' Activates the getCount routine to check if the undo or redo button needs to be set to be un seen
    End Sub

    Private Sub btmLaplacian3x3_Click(sender As Object, e As EventArgs) Handles btmLaplacian3x3.Click
        UndoSteps.Push(pictPhoto.Image)
        pictPhoto.Image = Convolution_Matrices.Laplacian3x3Filter(pictPhoto.Image)
        GetCount()
    End Sub

    Private Sub Laplacian3x3GrayScale_Click(sender As Object, e As EventArgs) Handles Laplacian3x3GrayScale.Click
        UndoSteps.Push(pictPhoto.Image)
        pictPhoto.Image = Convolution_Matrices.Laplacian3x3OfGaussian3x3FilterGrayscale(pictPhoto.Image)
        GetCount()
    End Sub

    Private Sub btnLaplaxian5x5Grayscale_Click(sender As Object, e As EventArgs) Handles btnLaplaxian5x5Grayscale.Click
        UndoSteps.Push(pictPhoto.Image)
        pictPhoto.Image = Convolution_Matrices.Laplacian5x5FilterGrayscale(pictPhoto.Image)
        GetCount()
    End Sub

    Private Sub btnLaplacianGausian_Click(sender As Object, e As EventArgs) Handles btnLaplacianGausian.Click
        UndoSteps.Push(pictPhoto.Image)
        pictPhoto.Image = Convolution_Matrices.LaplacianOfGaussianFilter(pictPhoto.Image)
        GetCount()
    End Sub

    Private Sub BtnLaplacian3x3ofGaussian3x3_Click(sender As Object, e As EventArgs) Handles BtnLaplacian3x3ofGaussian3x3.Click
        UndoSteps.Push(pictPhoto.Image)
        pictPhoto.Image = Convolution_Matrices.Laplacian3x3OfGaussian3x3Filter(pictPhoto.Image)
        GetCount()
    End Sub

    Private Sub btnLaplacian3x3ofGaussian5x5_Click(sender As Object, e As EventArgs) Handles btnLaplacian3x3ofGaussian5x5.Click
        UndoSteps.Push(pictPhoto.Image)
        pictPhoto.Image = Convolution_Matrices.Laplacian3x3OfGaussian5x5Filter1(pictPhoto.Image)
        GetCount()
    End Sub

    Private Sub btnaplacian5x5ofGaussian3x3_Click(sender As Object, e As EventArgs) Handles btnaplacian5x5ofGaussian3x3.Click
        UndoSteps.Push(pictPhoto.Image)
        pictPhoto.Image = Convolution_Matrices.Laplacian5x5OfGaussian3x3Filter(pictPhoto.Image)
        GetCount()
    End Sub

    Private Sub btnLaplacian5x5ofGaussian5x5_Click(sender As Object, e As EventArgs) Handles btnLaplacian5x5ofGaussian5x5.Click
        UndoSteps.Push(pictPhoto.Image)
        pictPhoto.Image = Convolution_Matrices.Laplacian5x5OfGaussian5x5Filter1(pictPhoto.Image)
        GetCount()
    End Sub

    Private Sub btnSobel3x3_Click(sender As Object, e As EventArgs) Handles btnSobel3x3.Click
        UndoSteps.Push(pictPhoto.Image)
        pictPhoto.Image = Convolution_Matrices.Sobel3x3Filter(pictPhoto.Image)
        GetCount()
    End Sub

    Private Sub btnSobel3x3Grayscale_Click(sender As Object, e As EventArgs) Handles btnSobel3x3Grayscale.Click
        UndoSteps.Push(pictPhoto.Image)
        pictPhoto.Image = Convolution_Matrices.Sobel3x3FilterGrayScale(pictPhoto.Image)
        GetCount()
    End Sub

    Private Sub btnPrewitt_Click(sender As Object, e As EventArgs) Handles btnPrewitt.Click
        UndoSteps.Push(pictPhoto.Image)
        pictPhoto.Image = Convolution_Matrices.PrewittFilter(pictPhoto.Image)
        GetCount()
    End Sub

    Private Sub btnPrewittGrayscale_Click(sender As Object, e As EventArgs) Handles btnPrewittGrayscale.Click
        UndoSteps.Push(pictPhoto.Image)
        pictPhoto.Image = Convolution_Matrices.PrewittFilterGrayscale(pictPhoto.Image)
        GetCount()
    End Sub

    Private Sub btnKirsch_Click(sender As Object, e As EventArgs) Handles btnKirsch.Click
        UndoSteps.Push(pictPhoto.Image)
        pictPhoto.Image = Convolution_Matrices.KirschFilter(pictPhoto.Image)
        GetCount()

    End Sub

    Private Sub btnKirschGrayscale_Click(sender As Object, e As EventArgs) Handles btnKirschGrayscale.Click
        UndoSteps.Push(pictPhoto.Image)
        pictPhoto.Image = Convolution_Matrices.KirschFilterGrayscale(pictPhoto.Image)
        GetCount()
    End Sub

    Private Sub RGBToBGR_Click(sender As Object, e As EventArgs) Handles btnRGBToBGR.Click
        UndoSteps.Push(pictPhoto.Image)
        pictPhoto.Image = RGBTOBGR(pictPhoto.Image)
        GetCount()
    End Sub

    Private Sub RGBToGBR_Click(sender As Object, e As EventArgs) Handles BtnRGBToGBR.Click
        UndoSteps.Push(pictPhoto.Image)
        pictPhoto.Image = RGBTOGBR(pictPhoto.Image)
        GetCount()
    End Sub

    Private Sub btnPolaroid_Click(sender As Object, e As EventArgs) Handles btnPolaroid.Click
        UndoSteps.Push(pictPhoto.Image)
        pictPhoto.Image = GetPolaroidColors(pictPhoto.Image)
        GetCount()
    End Sub
End Class