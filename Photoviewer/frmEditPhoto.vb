
Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging
Imports System.Runtime.InteropServices
Imports System.Threading
Imports frmPhotoviewer.ConvolutionMatrices
Imports Photoviewer.Colors.Contrast
Imports System.IO

Public Class frmEditPhoto


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

        SharpenedPhoto = Convolution_Matrices.Sharpen(pictPhoto.Image, 4)


    End Sub



    Private Sub BtnGrayscale_Click(sender As Object, e As EventArgs) Handles btnGrayscale.Click
        pictPhoto.Image = Grayscale(pictPhoto.Image)
    End Sub

    Private Sub pictPhoto_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnBlackandWhite_Click(sender As Object, e As EventArgs)
        pictPhoto.Image = BlackAndWhite(pictPhoto.Image)
    End Sub

    Private Sub btnContrast25_Click(sender As Object, e As EventArgs)
        Dim Stopwatch As New Stopwatch


        pictPhoto.Image = Contrast(pictPhoto.Image, 1.25)


    End Sub

    Private Sub btnContrast50_Click(sender As Object, e As EventArgs)
        pictPhoto.Image = Contrast(pictPhoto.Image, 1.5)
    End Sub

    Private Sub btnContrast75_Click(sender As Object, e As EventArgs)
        pictPhoto.Image = Contrast(pictPhoto.Image, 1.75)
    End Sub

    Private Sub btnContrast100_Click(sender As Object, e As EventArgs)
        pictPhoto.Image = Contrast(pictPhoto.Image, 2)
    End Sub


    Private Sub BtnUndoAll_Click(sender As Object, e As EventArgs) Handles BtnUndoAll.Click
        pictPhoto.Image = BackupPhoto
    End Sub



    Private Sub btnSharpen_Click(sender As Object, e As EventArgs) Handles btnSharpen.Click


        pictPhoto.Image = SharpenedPhoto

    End Sub

    Private Sub btnSaveImage_Click(sender As Object, e As EventArgs) Handles btnSaveImage.Click
        SaveFile(pictPhoto.Image, pictPhoto.ImageLocation, pictPhoto.ImageLocation)
    End Sub


    Private Sub EditPhoto_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnSaturation_Click(sender As Object, e As EventArgs) Handles BtnSaturation.Click
        frmSaturation.Show()
    End Sub

    Private Sub btnContrast_Click(sender As Object, e As EventArgs) Handles btnContrast.Click
        frmContrast.Show()
    End Sub

    Private Sub btnBrightness_Click(sender As Object, e As EventArgs) Handles btnBrightness.Click
        frmBrightness.Show()
    End Sub

    Private Sub BtnGaussian_Click(sender As Object, e As EventArgs) Handles BtnGaussian.Click
        pictPhoto.Image = Convolution_Matrices.Gaussian3x3(pictPhoto.Image)
    End Sub

    Private Sub BtnBlackAndWhite_Click_1(sender As Object, e As EventArgs) Handles BtnBlackAndWhite.Click

    End Sub

    Private Sub btnSepia_Click(sender As Object, e As EventArgs) Handles btnSepia.Click

    End Sub

    Private Sub btnLaplacian5x5_Click(sender As Object, e As EventArgs) Handles btnLaplacian5x5.Click
        pictPhoto.Image = Convolution_Matrices.Laplacian5x5(pictPhoto.Image)
    End Sub
End Class