Public Class ADMDashboardDEPTab
    Private Sub dgvDEP_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDEP.CellContentClick

    End Sub
    Private Sub btnADMDashAGC_Click(sender As Object, e As EventArgs) Handles btnADMDashAGC.Click
        Dim ADMDashAGC As New ADMDashboardAGCTab
        Close()
        ADMDashAGC.Show()
    End Sub

    Private Sub btnADMDashDEP_Click(sender As Object, e As EventArgs) Handles btnADMDashDEP.Click
        Dim ADMDashDEP As New ADMDashboardDEPTab
        Close()
        ADMDashDEP.Show()
    End Sub

    Private Sub btnADMDashEMP_Click(sender As Object, e As EventArgs) Handles btnADMDashEMP.Click
        Dim ADMDashEMP As New ADMDashboardEMPTab
        Close()
        ADMDashEMP.Show()
    End Sub

    Private Sub btnADMDashJOB_Click(sender As Object, e As EventArgs) Handles btnADMDashJOB.Click
        Dim ADMDashJOB As New ADMDashboardJOBTab
        Close()
        ADMDashJOB.Show()
    End Sub

    Private Sub btnADMDashOFW_Click(sender As Object, e As EventArgs) Handles btnADMDashOFW.Click
        Dim ADMDashOFW As New ADMDashboardOFWTab
        Close()
        ADMDashOFW.Show()
    End Sub

    Private Sub btnADMDashStat_Click(sender As Object, e As EventArgs) Handles btnADMDashSTAT.Click
        Dim ADMDashStat As New ADMDashboardStatTab
        Close()
        ADMDashStat.Show()
    End Sub

    Private Sub btnCloseDEP_Click(sender As Object, e As EventArgs) Handles btnCloseDEP.Click
        If MessageBox.Show("Are you sure you want to close the system?", "Confirm Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.Close()
            Application.Exit() ' Optionally exits the entire application
        End If
    End Sub

    Private Sub btnLogoutDEP_Click(sender As Object, e As EventArgs) Handles btnLogoutDEP.Click
        If MessageBox.Show("Are you sure you want to log out?", "Confirm Log out", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.Close()
            Dim loginPage As New ADMloginPage() ' Replace with your login page form
            loginPage.Show()
        End If
    End Sub
End Class