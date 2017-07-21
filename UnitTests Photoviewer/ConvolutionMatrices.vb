Imports System.Drawing.Drawing2D
Imports System.Runtime.InteropServices
Imports System.Drawing.Imaging
Imports System.Drawing
Imports System.Text
Imports System.Linq
Imports System.Collections.Generic
Imports System
Imports Photoviewer.Matrix




Public Class ConvolutionMatrices

    Public Shared Function CopyToSquareCanvas(sourceBitmap As Bitmap, canvasWidthLenght As Integer) As Bitmap
        Dim ratio As Single = 1.0F
        Dim maxSide As Integer = If(sourceBitmap.Width > sourceBitmap.Height, sourceBitmap.Width, sourceBitmap.Height)

        ratio = CType(maxSide, Single) / CType(canvasWidthLenght, Single)

        Dim bitmapResult As Bitmap = (If(sourceBitmap.Width > sourceBitmap.Height, New Bitmap(canvasWidthLenght, CType((sourceBitmap.Height / ratio), Integer)), New Bitmap(CType((sourceBitmap.Width / ratio), Integer), canvasWidthLenght)))

        Using graphicsResult As Graphics = Graphics.FromImage(bitmapResult)
            graphicsResult.CompositingQuality = CompositingQuality.HighQuality
            graphicsResult.InterpolationMode = InterpolationMode.HighQualityBicubic
            graphicsResult.PixelOffsetMode = PixelOffsetMode.HighQuality

            graphicsResult.DrawImage(sourceBitmap, New Rectangle(0, 0, bitmapResult.Width, bitmapResult.Height), New Rectangle(0, 0, sourceBitmap.Width, sourceBitmap.Height), GraphicsUnit.Pixel)
            graphicsResult.Flush()
        End Using

        Return bitmapResult
    End Function

    Private Shared Function ConvolutionFilter(sourceBitmap As Bitmap, filterMatrix As Double(,), Optional factor As Double = 1, Optional bias As Integer = 0, Optional grayscale As Boolean = False) As Bitmap
        Dim sourceData As BitmapData = sourceBitmap.LockBits(New Rectangle(0, 0, sourceBitmap.Width, sourceBitmap.Height), ImageLockMode.[ReadOnly], PixelFormat.Format32bppArgb)

        Dim pixelBuffer As Byte() = New Byte(sourceData.Stride * sourceData.Height) {}
        Dim resultBuffer As Byte() = New Byte(sourceData.Stride * sourceData.Height) {}

        Marshal.Copy(sourceData.Scan0, pixelBuffer, 0, pixelBuffer.Length)
        sourceBitmap.UnlockBits(sourceData)

        If grayscale = True Then
            Dim rgb As Single = 0

            Dim k As Integer = 0
            While k < pixelBuffer.Length
                rgb = pixelBuffer(k) * 0.11F
                rgb += pixelBuffer(k + 1) * 0.59F
                rgb += pixelBuffer(k + 2) * 0.3F


                pixelBuffer(k) = CType(rgb, Byte)
                pixelBuffer(k + 1) = pixelBuffer(k)
                pixelBuffer(k + 2) = pixelBuffer(k)
                pixelBuffer(k + 3) = 255
                k += 4
            End While
        End If

        Dim blue As Double = 0.0
        Dim green As Double = 0.0
        Dim red As Double = 0.0

        Dim filterWidth As Integer = filterMatrix.GetLength(1)
        Dim filterHeight As Integer = filterMatrix.GetLength(0)

        Dim filterOffset As Integer = (filterWidth - 1) / 2
        Dim calcOffset As Integer = 0

        Dim byteOffset As Integer = 0

        Dim offsetY As Integer = filterOffset
        While offsetY < sourceBitmap.Height - filterOffset
            Dim offsetX As Integer = filterOffset
            While offsetX < sourceBitmap.Width - filterOffset
                blue = 0
                green = 0
                red = 0

                byteOffset = offsetY * sourceData.Stride + offsetX * 4

                Dim filterY As Integer = -filterOffset
                While filterY <= filterOffset
                    Dim filterX As Integer = -filterOffset
                    While filterX <= filterOffset

                        calcOffset = byteOffset + (filterX * 4) + (filterY * sourceData.Stride)

                        blue += CType((pixelBuffer(calcOffset)), Double) * filterMatrix(filterY + filterOffset, filterX + filterOffset)

                        green += CType((pixelBuffer(calcOffset + 1)), Double) * filterMatrix(filterY + filterOffset, filterX + filterOffset)

                        red += CType((pixelBuffer(calcOffset + 2)), Double) * filterMatrix(filterY + filterOffset, filterX + filterOffset)
                        filterX += 1
                    End While
                    filterY += 1
                End While

                blue = factor * blue + bias
                green = factor * green + bias
                red = factor * red + bias

                If blue > 255 Then
                    blue = 255
                ElseIf blue < 0 Then
                    blue = 0
                End If

                If green > 255 Then
                    green = 255
                ElseIf green < 0 Then
                    green = 0
                End If

                If red > 255 Then
                    red = 255
                ElseIf red < 0 Then
                    red = 0
                End If

                resultBuffer(byteOffset) = CType((blue), Byte)
                resultBuffer(byteOffset + 1) = CType((green), Byte)
                resultBuffer(byteOffset + 2) = CType((red), Byte)
                resultBuffer(byteOffset + 3) = 255
                offsetX += 1
            End While
            offsetY += 1
        End While

        Dim resultBitmap As New Bitmap(sourceBitmap.Width, sourceBitmap.Height)

        Dim resultData As BitmapData = resultBitmap.LockBits(New Rectangle(0, 0, resultBitmap.Width, resultBitmap.Height), ImageLockMode.[WriteOnly], PixelFormat.Format32bppArgb)

        Marshal.Copy(resultBuffer, 0, resultData.Scan0, resultBuffer.Length)
        resultBitmap.UnlockBits(resultData)

        Return resultBitmap
    End Function


    Public Shared Function ConvolutionFilter(sourceBitmap As Bitmap, xFilterMatrix As Double(,), yFilterMatrix As Double(,), Optional factor As Double = 1, Optional bias As Integer = 0, Optional grayscale As Boolean = False) As Bitmap
        Dim sourceData As BitmapData = sourceBitmap.LockBits(New Rectangle(0, 0, sourceBitmap.Width, sourceBitmap.Height), ImageLockMode.[ReadOnly], PixelFormat.Format32bppArgb)

        Dim pixelBuffer As Byte() = New Byte(sourceData.Stride * sourceData.Height) {}
        Dim resultBuffer As Byte() = New Byte(sourceData.Stride * sourceData.Height) {}

        Marshal.Copy(sourceData.Scan0, pixelBuffer, 0, pixelBuffer.Length)
        sourceBitmap.UnlockBits(sourceData)

        If grayscale = True Then
            Dim rgb As Single = 0

            Dim k As Integer = 0
            While k < pixelBuffer.Length
                rgb = pixelBuffer(k) * 0.11F
                rgb += pixelBuffer(k + 1) * 0.59F
                rgb += pixelBuffer(k + 2) * 0.3F

                pixelBuffer(k) = CType(rgb, Byte)
                pixelBuffer(k + 1) = pixelBuffer(k)
                pixelBuffer(k + 2) = pixelBuffer(k)
                pixelBuffer(k + 3) = 255
                k += 4
            End While
        End If

        Dim blueX As Double = 0.0
        Dim greenX As Double = 0.0
        Dim redX As Double = 0.0

        Dim blueY As Double = 0.0
        Dim greenY As Double = 0.0
        Dim redY As Double = 0.0

        Dim blueTotal As Double = 0.0
        Dim greenTotal As Double = 0.0
        Dim redTotal As Double = 0.0

        Dim filterOffset As Integer = 1
        Dim calcOffset As Integer = 0

        Dim byteOffset As Integer = 0

        Dim offsetY As Integer = filterOffset
        While offsetY < sourceBitmap.Height - filterOffset
            Dim offsetX As Integer = filterOffset
            While offsetX < sourceBitmap.Width - filterOffset
                blueX = greenX = redX = 0
                blueY = greenY = redY = 0

                blueTotal = greenTotal = redTotal = 0.0

                byteOffset = offsetY * sourceData.Stride + offsetX * 4

                Dim filterY As Integer = -filterOffset
                While filterY <= filterOffset
                    Dim filterX As Integer = -filterOffset
                    While filterX <= filterOffset
                        calcOffset = byteOffset + (filterX * 4) + (filterY * sourceData.Stride)

                        blueX += CType((pixelBuffer(calcOffset)), Double) * xFilterMatrix(filterY + filterOffset, filterX + filterOffset)

                        greenX += CType((pixelBuffer(calcOffset + 1)), Double) * xFilterMatrix(filterY + filterOffset, filterX + filterOffset)

                        redX += CType((pixelBuffer(calcOffset + 2)), Double) * xFilterMatrix(filterY + filterOffset, filterX + filterOffset)

                        blueY += CType((pixelBuffer(calcOffset)), Double) * yFilterMatrix(filterY + filterOffset, filterX + filterOffset)

                        greenY += CType((pixelBuffer(calcOffset + 1)), Double) * yFilterMatrix(filterY + filterOffset, filterX + filterOffset)

                        redY += CType((pixelBuffer(calcOffset + 2)), Double) * yFilterMatrix(filterY + filterOffset, filterX + filterOffset)
                        filterX += 1
                    End While
                    filterY += 1
                End While

                blueTotal = Math.Sqrt((blueX * blueX) + (blueY * blueY))
                greenTotal = Math.Sqrt((greenX * greenX) + (greenY * greenY))
                redTotal = Math.Sqrt((redX * redX) + (redY * redY))

                If blueTotal > 255 Then
                    blueTotal = 255
                ElseIf blueTotal < 0 Then
                    blueTotal = 0
                End If

                If greenTotal > 255 Then
                    greenTotal = 255
                ElseIf greenTotal < 0 Then
                    greenTotal = 0
                End If

                If redTotal > 255 Then
                    redTotal = 255
                ElseIf redTotal < 0 Then
                    redTotal = 0
                End If

                resultBuffer(byteOffset) = CType((blueTotal), Byte)
                resultBuffer(byteOffset + 1) = CType((greenTotal), Byte)
                resultBuffer(byteOffset + 2) = CType((redTotal), Byte)
                resultBuffer(byteOffset + 3) = 255
                offsetX += 1
            End While
            offsetY += 1
        End While

        Dim resultBitmap As New Bitmap(sourceBitmap.Width, sourceBitmap.Height)

        Dim resultData As BitmapData = resultBitmap.LockBits(New Rectangle(0, 0, resultBitmap.Width, resultBitmap.Height), ImageLockMode.[WriteOnly], PixelFormat.Format32bppArgb)

        Marshal.Copy(resultBuffer, 0, resultData.Scan0, resultBuffer.Length)
        resultBitmap.UnlockBits(resultData)

        Return resultBitmap
    End Function


    Public Shared Function Laplacian3x3Filter(sourceBitmap As Bitmap, Optional grayscale As Boolean = True) As Bitmap
        Dim resultBitmap As Bitmap = ConvolutionFilter(sourceBitmap, Matrix.Laplacian3x3, 1.0, 0, grayscale)

        Return resultBitmap
    End Function


    Public Shared Function Laplacian5x5Filter(sourceBitmap As Bitmap, Optional grayscale As Boolean = True) As Bitmap
        Dim resultBitmap As Bitmap = ConvolutionFilter(sourceBitmap, Matrix.Laplacian5x5, 1.0, 0, grayscale)

        Return resultBitmap
    End Function


    Public Shared Function LaplacianOfGaussianFilter(sourceBitmap As Bitmap) As Bitmap
        Dim resultBitmap As Bitmap = ConvolutionFilter(sourceBitmap, Matrix.LaplacianOfGaussian, 1.0, 0, True)

        Return resultBitmap
    End Function


    Public Shared Function Laplacian3x3OfGaussian3x3Filter(sourceBitmap As Bitmap) As Bitmap
        Dim resultBitmap As Bitmap = ConvolutionFilter(sourceBitmap, Matrix.Gaussian3x3, 1.0 / 16.0, 0, True)

        resultBitmap = ConvolutionFilter(resultBitmap, Matrix.Laplacian3x3, 1.0, 0, False)

        Return resultBitmap
    End Function


    Public Shared Function Laplacian3x3OfGaussian5x5Filter1(sourceBitmap As Bitmap) As Bitmap
        Dim resultBitmap As Bitmap = ConvolutionFilter(sourceBitmap, Matrix.Gaussian5x5Type1, 1.0 / 159.0, 0, True)

        resultBitmap = ConvolutionFilter(resultBitmap, Matrix.Laplacian3x3, 1.0, 0, False)

        Return resultBitmap
    End Function


    Public Shared Function Laplacian3x3OfGaussian5x5Filter2(sourceBitmap As Bitmap) As Bitmap
        Dim resultBitmap As Bitmap = ConvolutionFilter(sourceBitmap, Matrix.Gaussian5x5Type2, 1.0 / 256.0, 0, True)

        resultBitmap = ConvolutionFilter(resultBitmap, Matrix.Laplacian3x3, 1.0, 0, False)

        Return resultBitmap
    End Function


    Public Shared Function Laplacian5x5OfGaussian3x3Filter(sourceBitmap As Bitmap) As Bitmap
        Dim resultBitmap As Bitmap = ConvolutionFilter(sourceBitmap, Matrix.Gaussian3x3, 1.0 / 16.0, 0, True)

        resultBitmap = ConvolutionFilter(resultBitmap, Matrix.Laplacian5x5, 1.0, 0, False)

        Return resultBitmap
    End Function


    Public Shared Function Laplacian5x5OfGaussian5x5Filter1(sourceBitmap As Bitmap) As Bitmap
        Dim resultBitmap As Bitmap = ConvolutionFilter(sourceBitmap, Matrix.Gaussian5x5Type1, 1.0 / 159.0, 0, True)

        resultBitmap = ConvolutionFilter(resultBitmap, Matrix.Laplacian5x5, 1.0, 0, False)

        Return resultBitmap
    End Function


    Public Shared Function Laplacian5x5OfGaussian5x5Filter2(sourceBitmap As Bitmap) As Bitmap
        Dim resultBitmap As Bitmap = ConvolutionFilter(sourceBitmap, Matrix.Gaussian5x5Type2, 1.0 / 256.0, 0, True)

        resultBitmap = ConvolutionFilter(resultBitmap, Matrix.Laplacian5x5, 1.0, 0, False)

        Return resultBitmap
    End Function


    Public Shared Function Sobel3x3Filter(sourceBitmap As Bitmap, Optional grayscale As Boolean = True) As Bitmap
        Dim resultBitmap As Bitmap = ConvolutionFilter(sourceBitmap, Matrix.Sobel3x3Horizontal, Matrix.Sobel3x3Vertical, 1.0, 0, grayscale)

        Return resultBitmap
    End Function


    Public Shared Function PrewittFilter(sourceBitmap As Bitmap, Optional grayscale As Boolean = True) As Bitmap
        Dim resultBitmap As Bitmap = ConvolutionFilter(sourceBitmap, Matrix.Prewitt3x3Horizontal, Matrix.Prewitt3x3Vertical, 1.0, 0, grayscale)

        Return resultBitmap
    End Function


    Public Shared Function KirschFilter(sourceBitmap As Bitmap, Optional grayscale As Boolean = True) As Bitmap
        Dim resultBitmap As Bitmap = ConvolutionFilter(sourceBitmap, Matrix.Kirsch3x3Horizontal, Matrix.Kirsch3x3Vertical, 1.0, 0, grayscale)

        Return resultBitmap
    End Function
    Public Shared Function GetEmboss(ByVal sourceBitmap As Bitmap, Optional ByVal bias As Integer = 0, Optional ByVal grayscale As Boolean = False, Optional ByVal mono As Boolean = False, Optional ByVal medianFilterSize As Integer = 0) As Bitmap
        Dim resultBitmap As Bitmap = ConvolutionFilter(sourceBitmap, Matrix.Emboss, 1.0, 0, grayscale)


        Return resultBitmap
    End Function

End Class
