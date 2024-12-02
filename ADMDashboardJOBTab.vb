Public Class ADMDashboardJOBTab
    Private Sub btnADMDashOFW_Click(sender As Object, e As EventArgs) Handles btnADMDashOFW.Click
        Dim ADMDashOFW As New ADMDashboardOFWTab()

        Me.Close()
        ADMDashOFW.Show()
    End Sub

    Private Sub btnADMDashEMP_Click(sender As Object, e As EventArgs) Handles btnADMDashEMP.Click
        Dim ADMDashEMP As New ADMDashboardEMPTab()
        Close()
        ADMDashEMP.Show()
    End Sub

    Private Sub BtnADMDashSTAT_Click(sender As Object, e As EventArgs) Handles btnADMDashSTAT.Click
        Dim ADMDashStat As New ADMDashboardStatTab()
        Me.Close()
        ADMDashStat.Show()
    End Sub
    Private Sub btnADMDashAGC_Click(sender As Object, e As EventArgs) Handles btnADMDashAGC.Click
        Dim ADMDashAGC As New ADMDashboardAGCTab
        Close()
        ADMDashAGC.Show()
    End Sub

    Private Sub dgvJOB_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvJOB.CellContentClick

    End Sub

    Private Sub ADMDashboardJOBTab_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class