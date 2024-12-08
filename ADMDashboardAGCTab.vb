Imports MySql.Data.MySqlClient
Imports Mysqlx

Public Class ADMDashboardAGCTab
    Private Sub ADMDashboardAGCTab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim query As String = "SELECT * FROM agency"
        agencyDataTable.Clear() ' Clear any existing data
        dgvAGC.DataSource = agencyDataTable ' Bind the DataTable to the DataGridView
        LoadToDGV(query, dgvAGC)
    End Sub

    Private agencyDataTable As New DataTable()


    'Public Sub refresh()

    '    Dim query As String = "SELECT * FROM agency"
    '    agencyDataTable.Clear() ' Clear any existing data
    '    dgvAGC.DataSource = agencyDataTable ' Bind the DataTable to the DataGridView
    '    LoadToDGV(query, dgvAGC)
    'End Sub

    Public Sub RefreshDataGrid()
        Dim query As String = "SELECT * FROM agency"
        agencyDataTable.Clear() ' Clear any existing data
        dgvAGC.DataSource = agencyDataTable ' Bind the DataTable to the DataGridView
        LoadToDGV(query, dgvAGC)
    End Sub

    Private Sub dataCount_DataSourceChanged(sender As Object, e As EventArgs) Handles dgvAGC.DataSourceChanged
        Dim rowCount As Integer = dgvAGC.Rows.Count
        lblAGCTally.Text = rowCount - 1
    End Sub

    'Private Sub btnADMDashOFW_Click(sender As Object, e As EventArgs) Handles btnADMDashOFW.Click
    '    Dim ADMDashOFW As New ADMDashboardOFWTab()
    '    Me.Close()
    '    ADMDashOFW.Show()
    'End Sub

    'Private Sub btnADMDashEMP_Click(sender As Object, e As EventArgs) Handles btnADMDashEMP.Click
    '    Dim ADMDashEMP As New ADMDashboardEMPTab()
    '    Me.Close()
    '    ADMDashEMP.Show()
    'End Sub

    'Private Sub btnADMDashSTAT_Click(sender As Object, e As EventArgs) Handles btnADMDashSTAT.Click
    '    Dim ADMDashStat As New ADMDashboardStatTab()
    '    Me.Close()
    '    ADMDashStat.Show()
    'End Sub
    'Private Sub btnADMDashJOB_Click(sender As Object, e As EventArgs) Handles btnADMDashJOB.Click
    '    Dim ADMDashJOB As New ADMDashboardJOBTab()
    '    Me.Close()s
    '    ADMDashJOB.Show()
    'End Sub

    'Private Sub btnADMDashDEP_Click(sender As Object, e As EventArgs) Handles btnADMDashDEP.Click

    'End Sub

    Private Sub btnADMDashAGC_Click(sender As Object, e As EventArgs) Handles btnADMDashAGC.Click
        Dim ADMDashAGC As New ADMDashboardAGCTab
        MyBase.Close()
        ADMDashAGC.Show()
    End Sub

    Private Sub btnADMDashDEP_Click(sender As Object, e As EventArgs) Handles btnADMDashDEP.Click
        Dim ADMDashDEP As New ADMDashboardDEPTab
        MyBase.Close()
        ADMDashDEP.Show()
    End Sub

    Private Sub btnADMDashEMP_Click(sender As Object, e As EventArgs) Handles btnADMDashEMP.Click
        Dim ADMDashEMP As New ADMDashboardEMPTab
        MyBase.Close()
        ADMDashEMP.Show()
    End Sub

    Private Sub btnADMDashJOB_Click(sender As Object, e As EventArgs) Handles btnADMDashJOB.Click
        Dim ADMDashJOB As New ADMDashboardJOBTab
        MyBase.Close()
        ADMDashJOB.Show()
    End Sub

    Private Sub btnADMDashOFW_Click(sender As Object, e As EventArgs) Handles btnADMDashOFW.Click
        Dim ADMDashOFW As New ADMDashboardOFWTab
        MyBase.Close()
        ADMDashOFW.Show()
    End Sub

    Private Sub btnADMDashStat_Click(sender As Object, e As EventArgs) Handles btnADMDashSTAT.Click
        Dim ADMDashStat As New ADMDashboardStatTab
        MyBase.Close()
        ADMDashStat.Show()
    End Sub

    Private Sub btnADD_Click(sender As Object, e As EventArgs) Handles btnADD.Click
        Dim AddAGC As New ADMAddAGC
        AddAGC.ShowDialog()
    End Sub

    'Private Sub Close_Click(sender As Object, e As EventArgs) Handles btnCLose.Click
    '    If MessageBox.Show("Are you sure you want to close the system?", "Confirm Closing",
    '                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) =
    '                        DialogResult.Yes Then
    '        Application.Exit()
    '    End If
    'End Sub

    'Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
    '    If MessageBox.Show("Are you sure you want to Log out?", "Confirm Log out",
    '                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) =
    '                        DialogResult.Yes Then
    '        Dim loginPage As New ADMloginPage()

    '        Me.btnCloseAGC()
    '        loginPage.Show()
    '    End If
    'End Sub

    Private Sub btnEDIT_Click(sender As Object, e As EventArgs) Handles btnEDIT.Click
        If dgvAGC.SelectedRows.Count > 0 Then  ' Check if a row is selected
            Dim selectedRow = dgvAGC.SelectedRows(0)
            Dim selectedAGCId As Integer = selectedRow.Cells("AgencyId").Value  ' Assuming "OFWId" is the column name for the ID

            Dim EditAGC As New ADMEditAGC(selectedAGCId)  ' Pass the selected ID to the constructor
            EditAGC.ShowDialog()
        Else
            MessageBox.Show("Please select an OFW record to edit!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnDLT_Click(sender As Object, e As EventArgs) Handles btnDLT.Click
        If dgvAGC.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvAGC.SelectedRows(0)
            Dim selectedAGCId As Integer = selectedRow.Cells("AgencyId").Value  ' Assuming "OFWId" is the column name for the ID

            If MessageBox.Show("Are you sure you want to delete this OFW record?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim query = $"DELETE FROM AGENCY WHERE AgencyId = {selectedAGCId}"
                readQuery(query)


                MessageBox.Show("Agency record deleted successfully!")
                Refresh()  ' Refresh the DataGridView
            End If
        Else
            MessageBox.Show("Please select an Agency record to delete!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        ApplyFilter()
    End Sub

    Private Sub ApplyFilter()
        ' Build the filter string based on user inputs
        Dim filter As String = ""

        If Not String.IsNullOrWhiteSpace(txtAGCIdFilt.Text) Then
            filter &= $"AgencyId LIKE '%{txtAGCIdFilt.Text}%' AND "
        End If
        If Not String.IsNullOrWhiteSpace(txtAGCNameFilt.Text) Then
            filter &= $"AgencyName LIKE '%{txtAGCNameFilt.Text}%' AND "
        End If
        If Not String.IsNullOrWhiteSpace(txtAGCLicNumFilt.Text) Then
            filter &= $"AgencyLicenseNumber LIKE '%{txtAGCLicNumFilt.Text}%' AND "
        End If
        If Not String.IsNullOrWhiteSpace(txtAGCWebFilt.Text) Then
            filter &= $"WebsiteUrl LIKE '%{txtAGCWebFilt.Text}%' AND "
        End If
        If Not String.IsNullOrWhiteSpace(txtAGCSpecFilt.Text) Then
            filter &= $"Specialization LIKE '%{txtAGCSpecFilt.Text}%' AND "
        End If
        If Not String.IsNullOrWhiteSpace(txtAGCZipFilt.Text) Then
            filter &= $"Zipcode LIKE '%{txtAGCZipFilt.Text}%' AND "
        End If
        If Not String.IsNullOrWhiteSpace(txtAGCContNumFilt.Text) Then
            filter &= $"ContactNum LIKE '%{txtAGCContNumFilt.Text}%' AND "
        End If
        If Not String.IsNullOrWhiteSpace(txtAGCEmailFilt.Text) Then
            filter &= $"Email LIKE '%{txtAGCEmailFilt.Text}%' AND "
        End If


        ' Remove the trailing " AND " if filter is not empty
        If filter.EndsWith(" AND ") Then
            filter = filter.Substring(0, filter.Length - 5)
        End If

        ' Apply the filter to the DataTable
        Dim dataView As New DataView(agencyDataTable)
        dataView.RowFilter = filter
        dgvAGC.DataSource = dataView

        ' Update the total number of OFWs shown
        lblAGCTally.Text = dataView.Count.ToString()
    End Sub

    Private Sub dgvAGC_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAGC.CellContentClick

    End Sub

    Private Sub btnLogoutAGC_Click(sender As Object, e As EventArgs) Handles btnLogoutAGC.Click
        ' Ask for confirmation before logging out
        If MessageBox.Show("Are you sure you want to log out?", "Confirm Log out", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            ' Perform the logout action here (for example, go to the login form)
            ' You can replace this with whatever action you'd like to perform on logout (like clearing session, etc.)

            ' Close the current form (which might be the main dashboard)
            Me.Close()

            ' Optionally, navigate to the login page or show a new login form
            Dim loginPage As New ADMloginPage() ' Replace with your login form
            loginPage.Show()
        End If
    End Sub

    Private Sub btnCloseAGC_Click(sender As Object, e As EventArgs) Handles btnCloseAGC.Click
        ' Ask for confirmation before closing the application
        If MessageBox.Show("Are you sure you want to close the system?", "Confirm Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            ' Close the form
            Me.Close()

            ' Optionally, you can call Application.Exit to completely exit the application if necessary
            Application.Exit()
        End If
    End Sub
End Class