Public Class frmContrast


    Private Sub BtnContrast25_Click(sender As Object, e As EventArgs) Handles btnContrast25.Click
        frmEditPhoto.UndoSteps.Push(frmEditPhoto.pictPhoto.Image)
        frmEditPhoto.pictPhoto.Image = Contrast(frmEditPhoto.pictPhoto.Image, 1.25)
    End Sub
    Private Sub BtnContrast50_Click(sender As Object, e As EventArgs) Handles BtnContrast50.Click
        frmEditPhoto.UndoSteps.Push(frmEditPhoto.pictPhoto.Image)
        frmEditPhoto.pictPhoto.Image = Contrast(frmEditPhoto.pictPhoto.Image, 1.5)
    End Sub

    Private Sub BtnContrast75_Click(sender As Object, e As EventArgs) Handles BtnContrast75.Click
        frmEditPhoto.UndoSteps.Push(frmEditPhoto.pictPhoto.Image)
        frmEditPhoto.pictPhoto.Image = Contrast(frmEditPhoto.pictPhoto.Image, 1.75)
    End Sub

    Private Sub BtnContrast100_Click(sender As Object, e As EventArgs) Handles BtnContrast100.Click
        frmEditPhoto.UndoSteps.Push(frmEditPhoto.pictPhoto.Image)
        frmEditPhoto.pictPhoto.Image = Contrast(frmEditPhoto.pictPhoto.Image, 2)
    End Sub


    Private Sub frmContrast_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub btnContrast1_Click(sender As Object, e As EventArgs) Handles btnContrast1.Click
        frmEditPhoto.UndoSteps.Push(frmEditPhoto.pictPhoto.Image)
        frmEditPhoto.pictPhoto.Image = Contrast(frmEditPhoto.pictPhoto.Image, 1.01)
    End Sub

    Private Sub btnContrast5_Click(sender As Object, e As EventArgs) Handles btnContrast5.Click
        frmEditPhoto.UndoSteps.Push(frmEditPhoto.pictPhoto.Image)
        frmEditPhoto.pictPhoto.Image = Contrast(frmEditPhoto.pictPhoto.Image, 1.05)
    End Sub
End Class