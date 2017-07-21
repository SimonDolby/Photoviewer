Public Class frmSaturation

    Private Sub BtnSaturation100m_Click(sender As Object, e As EventArgs) Handles BtnSaturation100m.Click
        frmEditPhoto.pictPhoto.Image = Saturation(frmEditPhoto.pictPhoto.Image, 0.1)
    End Sub

    Private Sub BtnSaturation75m_Click(sender As Object, e As EventArgs) Handles BtnSaturation75m.Click
        frmEditPhoto.pictPhoto.Image = Saturation(frmEditPhoto.pictPhoto.Image, 0.75)
    End Sub

    Private Sub BtnSaturation50m_Click(sender As Object, e As EventArgs) Handles BtnSaturation50m.Click
        frmEditPhoto.pictPhoto.Image = Saturation(frmEditPhoto.pictPhoto.Image, 0.5)
    End Sub

    Private Sub BtnSaturation25m_Click(sender As Object, e As EventArgs) Handles BtnSaturation25m.Click
        frmEditPhoto.pictPhoto.Image = Saturation(frmEditPhoto.pictPhoto.Image, 0.25)
    End Sub
    Private Sub BtnSaturation25_Click(sender As Object, e As EventArgs) Handles BtnSaturation25.Click
        frmEditPhoto.pictPhoto.Image = Saturation(frmEditPhoto.pictPhoto.Image, 1.25)
    End Sub
    Private Sub BtnSaturation50_Click(sender As Object, e As EventArgs) Handles BtnSaturation50.Click
        frmEditPhoto.pictPhoto.Image = Saturation(frmEditPhoto.pictPhoto.Image, 1.5)
    End Sub

    Private Sub BtnSaturation75_Click(sender As Object, e As EventArgs) Handles BtnSaturation75.Click
        frmEditPhoto.pictPhoto.Image = Saturation(frmEditPhoto.pictPhoto.Image, 1.75)
    End Sub

    Private Sub BtnSaturation100_Click(sender As Object, e As EventArgs) Handles BtnSaturation100.Click
        frmEditPhoto.pictPhoto.Image = Saturation(frmEditPhoto.pictPhoto.Image, 2)
    End Sub


    Private Sub frmSaturation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSaturation5m_Click(sender As Object, e As EventArgs) Handles btnSaturation5m.Click
        frmEditPhoto.pictPhoto.Image = Saturation(frmEditPhoto.pictPhoto.Image, 0.95)
    End Sub

    Private Sub btnSaturation1_Click(sender As Object, e As EventArgs) Handles btnSaturation1.Click
        frmEditPhoto.pictPhoto.Image = Saturation(frmEditPhoto.pictPhoto.Image, 1.01)
    End Sub

    Private Sub btnSaturation1m_Click(sender As Object, e As EventArgs) Handles btnSaturation1m.Click
        frmEditPhoto.pictPhoto.Image = Saturation(frmEditPhoto.pictPhoto.Image, 0.99)
    End Sub

    Private Sub btnSaturation5_Click(sender As Object, e As EventArgs) Handles btnSaturation5.Click
        frmEditPhoto.pictPhoto.Image = Saturation(frmEditPhoto.pictPhoto.Image, 1.05)
    End Sub
End Class