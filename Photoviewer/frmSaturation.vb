Public Class frmSaturation



    Private Sub BtnSaturation25_Click(sender As Object, e As EventArgs) Handles btnSaturation25.Click
        frmEditPhoto.UndoSteps.Push(frmEditPhoto.pictPhoto.Image)
        frmEditPhoto.pictPhoto.Image = Saturation(frmEditPhoto.pictPhoto.Image, 1.25)

    End Sub
    Private Sub BtnSaturation50_Click(sender As Object, e As EventArgs) Handles BtnSaturation50.Click
        frmEditPhoto.UndoSteps.Push(frmEditPhoto.pictPhoto.Image)
        frmEditPhoto.pictPhoto.Image = Saturation(frmEditPhoto.pictPhoto.Image, 1.5)
    End Sub

    Private Sub BtnSaturation75_Click(sender As Object, e As EventArgs) Handles BtnSaturation75.Click
        frmEditPhoto.UndoSteps.Push(frmEditPhoto.pictPhoto.Image)
        frmEditPhoto.pictPhoto.Image = Saturation(frmEditPhoto.pictPhoto.Image, 1.75)
    End Sub

    Private Sub BtnSaturation100_Click(sender As Object, e As EventArgs) Handles BtnSaturation100.Click
        frmEditPhoto.UndoSteps.Push(frmEditPhoto.pictPhoto.Image)
        frmEditPhoto.pictPhoto.Image = Saturation(frmEditPhoto.pictPhoto.Image, 2)
    End Sub


    Private Sub frmSaturation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSaturation1_Click(sender As Object, e As EventArgs) Handles btnSaturation1.Click
        frmEditPhoto.UndoSteps.Push(frmEditPhoto.pictPhoto.Image)
        frmEditPhoto.pictPhoto.Image = Saturation(frmEditPhoto.pictPhoto.Image, 1.01)
    End Sub


    Private Sub btnSaturation5_Click(sender As Object, e As EventArgs) Handles btnSaturation5.Click
        frmEditPhoto.UndoSteps.Push(frmEditPhoto.pictPhoto.Image)
        frmEditPhoto.pictPhoto.Image = Saturation(frmEditPhoto.pictPhoto.Image, 1.05)
    End Sub
End Class