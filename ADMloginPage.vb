Public Class ADMloginPage


    Private Sub btnOFWLoginPg_Click(sender As Object, e As EventArgs) Handles btnOFWLoginPg.Click
        Dim OFWLoginPage As New OFWloginPage()

        Me.Close()
        OFWLoginPage.Show()
    End Sub

    Private Sub btnCloseLoginPg_Click(sender As Object, e As EventArgs) Handles btnCloseLoginPg.Click
        Application.Exit()
    End Sub

    Private Sub Login_Click(sender As Object, e As EventArgs) Handles btnLoginADMLoginPg.Click
        If txtbxADMUserLoginPg.Text.ToLower = "admin" AndAlso
           txtbxADMPassLoginPg.Text.ToLower = "admin" Then
            Me.Hide()
            Dim ADMDashboard As New ADMDashboardStatTab()
            ADMDashboard.Show()
        Else MessageBox.Show("Invalid USERNAME or PASSWORD.", "Login Failed!",
                             MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtbxADMPassLoginPg.Clear()
            txtbxADMUserLoginPg.Clear()
        End If
    End Sub

    Private Sub ADMloginPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub btnAGCLoginPg_Click(sender As Object, e As EventArgs) Handles btnAGCLoginPg.Click
        Dim AGCLoginPage As New AGENCYLoginPage()
        Me.Hide()
        AGCLoginPage.Show()
    End Sub

    Private Sub btnEMPLoginPg_Click(sender As Object, e As EventArgs) Handles btnEMPLoginPg.Click
        Dim EMPLoginPage As New EMPLoginPage()
        Me.Hide()
        EMPLoginPage.Show()
    End Sub
End Class