Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports System.Drawing.Imaging
Imports System.Drawing
Imports UnitTests_Photoviewer.ConvolutionMatrices

Imports System.Threading
<TestClass()>
Public Class SmoothTests
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

    <TestMethod()>
    Public Sub SharpenImage()
        Dim im As Image = Image.FromFile("C:\Users\Simon\Pictures\DSC_9158.JPG")
        im = Laplacian3x3Filter(im, False)
        SaveFile(im, "C:\Users\Simon\Pictures\Contrast Tests\DSC_9158.JPG", "C: \Users\Simon\Pictures\DSC_9158.JPG")

    End Sub
    <TestMethod()>
    Public Sub EmbossImage()
        Dim im As Image = Image.FromFile("C:\Users\Simon\Pictures\DSC_9158.JPG")
        im = GetEmboss(im)
        SaveFile(im, "C:\Users\Simon\Pictures\Contrast Tests\DSC_9158.JPG", "C: \Users\Simon\Pictures\DSC_9158.JPG")

    End Sub
End Class
