Public Class EMPLoginPage
    Private Sub btnAGCLoginPg_Click(sender As Object, e As EventArgs) Handles btnAGCLoginPg.Click
        Dim AGCLoginPage As New AGENCYLoginPage()
        Me.Hide()
        AGCLoginPage.Show()
    End Sub

    Private Sub btnCloseLoginPg_Click(sender As Object, e As EventArgs) Handles btnCloseLoginPg.Click
        Application.Exit()
    End Sub

    Private Sub OFWloginPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnOFWLoginPg_Click(sender As Object, e As EventArgs) Handles btnOFWLoginPg.Click
        Dim OFWLoginPage As New OFWloginPage()
        Me.Hide()
        OFWLoginPage.Show()
    End Sub

    Private Sub btnADMLoginPg_Click(sender As Object, e As EventArgs) Handles btnADMLoginPg.Click
        Dim ADMLoginPage As New ADMloginPage()
        Me.Hide()
        ADMLoginPage.Show()
    End Sub
End Class