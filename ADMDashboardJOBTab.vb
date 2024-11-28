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
End Class