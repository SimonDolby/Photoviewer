Imports FlickrNet


Public Class FlickrSetupvb
    Dim requestToken As OAuthRequestToken


    Private Sub btnAuthenticate_Click(sender As Object, e As EventArgs) Handles btnAuthenticate.Click
        Dim f As Flickr = FlickrManagement.GetInstance()

        requestToken = f.OAuthGetRequestToken("oob")

        Dim url As [String] = f.OAuthCalculateAuthorizationUrl(requestToken.Token, AuthLevel.Write)

        System.Diagnostics.Process.Start(url)
    End Sub

    Private Sub FlickrSetupvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CompleteAuthButton_Click(sender As Object, e As EventArgs) Handles CompleteAuthButton.Click
        If [String].IsNullOrEmpty(VerifierTextBox.Text) Then
            MessageBox.Show("You must paste the verifier code into the textbox above.")
            Return
        End If

        Dim f As Flickr = FlickrManagement.GetInstance()
        Try
            Dim accessToken As Object = f.OAuthGetAccessToken(requestToken, VerifierTextBox.Text)
            FlickrManagement.OAuthToken = accessToken
            ResultLabel.Text = "Successfully authenticated as " + accessToken.FullName
        Catch ex As FlickrApiException
            MessageBox.Show("Failed to get access token. Error message: " + ex.Message)
        End Try
    End Sub
End Class