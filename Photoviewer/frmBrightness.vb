Public Class frmBrightness

    Private Sub BtnBrightness100m_Click(sender As Object, e As EventArgs) Handles BtnBrightness100m.Click
        frmEditPhoto.UndoSteps.Push(frmEditPhoto.pictPhoto.Image)
        frmEditPhoto.pictPhoto.Image = Brightness(frmEditPhoto.pictPhoto.Image, 0.1)
        frmEditPhoto.GetCount()
    End Sub

    Private Sub BtnBrightness75m_Click(sender As Object, e As EventArgs) Handles BtnBrightness75m.Click
        frmEditPhoto.UndoSteps.Push(frmEditPhoto.pictPhoto.Image)
        frmEditPhoto.pictPhoto.Image = Brightness(frmEditPhoto.pictPhoto.Image, 0.75)
        frmEditPhoto.GetCount()
    End Sub

    Private Sub BtnBrightness50m_Click(sender As Object, e As EventArgs) Handles BtnBrightness50m.Click
        frmEditPhoto.UndoSteps.Push(frmEditPhoto.pictPhoto.Image)
        frmEditPhoto.pictPhoto.Image = Brightness(frmEditPhoto.pictPhoto.Image, 0.5)
        frmEditPhoto.GetCount()
    End Sub

    Private Sub BtnBrightness25m_Click(sender As Object, e As EventArgs) Handles BtnBrightness25m.Click
        frmEditPhoto.UndoSteps.Push(frmEditPhoto.pictPhoto.Image)
        frmEditPhoto.pictPhoto.Image = Brightness(frmEditPhoto.pictPhoto.Image, 0.25)
        frmEditPhoto.GetCount()
    End Sub
    Private Sub BtnBrightness25_Click(sender As Object, e As EventArgs) Handles btnBrightness25.Click
        frmEditPhoto.UndoSteps.Push(frmEditPhoto.pictPhoto.Image)
        frmEditPhoto.pictPhoto.Image = Brightness(frmEditPhoto.pictPhoto.Image, 1.25)
        frmEditPhoto.GetCount()
    End Sub
    Private Sub BtnBrightness50_Click(sender As Object, e As EventArgs) Handles BtnBrightness50.Click
        frmEditPhoto.UndoSteps.Push(frmEditPhoto.pictPhoto.Image)
        frmEditPhoto.pictPhoto.Image = Brightness(frmEditPhoto.pictPhoto.Image, 1.5)
        frmEditPhoto.GetCount()
    End Sub


    Private Sub BtnBrightness75_Click(sender As Object, e As EventArgs) Handles BtnBrightness75.Click
        frmEditPhoto.UndoSteps.Push(frmEditPhoto.pictPhoto.Image)
        frmEditPhoto.pictPhoto.Image = Brightness(frmEditPhoto.pictPhoto.Image, 1.75)
        frmEditPhoto.GetCount()
    End Sub

    Private Sub BtnBrightness100_Click(sender As Object, e As EventArgs) Handles BtnBrightness100.Click
        frmEditPhoto.UndoSteps.Push(frmEditPhoto.pictPhoto.Image)
        frmEditPhoto.pictPhoto.Image = Brightness(frmEditPhoto.pictPhoto.Image, 2)
        frmEditPhoto.GetCount()
    End Sub


    Private Sub frmBrightness_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnBrightness5m_Click(sender As Object, e As EventArgs) Handles btnBrightness5m.Click
        frmEditPhoto.UndoSteps.Push(frmEditPhoto.pictPhoto.Image)
        frmEditPhoto.pictPhoto.Image = Brightness(frmEditPhoto.pictPhoto.Image, 0.05)
        frmEditPhoto.GetCount()
    End Sub

    Private Sub btnBrightness1_Click(sender As Object, e As EventArgs) Handles btnBrightness1.Click
        frmEditPhoto.UndoSteps.Push(frmEditPhoto.pictPhoto.Image)
        frmEditPhoto.pictPhoto.Image = Brightness(frmEditPhoto.pictPhoto.Image, 1.01)
        frmEditPhoto.GetCount()
    End Sub

    Private Sub btnBrightness1m_Click(sender As Object, e As EventArgs) Handles btnBrightness1m.Click
        frmEditPhoto.UndoSteps.Push(frmEditPhoto.pictPhoto.Image)
        frmEditPhoto.pictPhoto.Image = Brightness(frmEditPhoto.pictPhoto.Image, 0.01)
        frmEditPhoto.GetCount()
    End Sub

    Private Sub btnBrightness5_Click(sender As Object, e As EventArgs) Handles btnBrightness5.Click
        frmEditPhoto.UndoSteps.Push(frmEditPhoto.pictPhoto.Image)

        frmEditPhoto.pictPhoto.Image = Brightness(frmEditPhoto.pictPhoto.Image, 1.05)
        frmEditPhoto.GetCount()
    End Sub

    Private Sub frmBrightness_Closed(sender As Object, e As EventArgs) Handles Me.Closed

    End Sub
End Class