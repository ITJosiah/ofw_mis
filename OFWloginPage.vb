Imports System.IO

Public Class OFWloginPage

    Public Sub New()
        InitializeComponent()
        Me.KeyPreview = True ' Ensure the form captures key events
        AddHandler Me.KeyDown, AddressOf OFWloginPage_KeyDown
    End Sub

    ' Event handler for key presses
    Private Sub OFWloginPage_KeyDown(sender As Object, e As KeyEventArgs)
        ' Check if Shift + F is pressed
        If e.Shift AndAlso e.KeyCode = Keys.F Then
            UpdateConfigFile()
        End If

        ' Check if Shift + Q is pressed
        If e.Shift AndAlso e.KeyCode = Keys.Q Then
            OpenAdminLogin()
        End If
    End Sub

    ' Method to open the Admin Login page
    Private Sub OpenAdminLogin()
        Dim ADMLoginPage As New ADMloginPage()
        Me.Hide()
        ADMLoginPage.Show()
    End Sub

    ' Method to update the config.txt file
    Private Sub UpdateConfigFile()
        Dim filePath As String = "config.txt"
        Dim dbServer As String = "localhost"
        Dim dbUid As String = "root"
        Dim dbPwd As String = ""
        Dim dbName As String = "ofw_mis"

        ' Read current values from the file
        Try
            If File.Exists(filePath) Then
                Dim lines As String() = File.ReadAllLines(filePath)
                For Each line As String In lines
                    If line.StartsWith("db_server=") Then
                        dbServer = line.Substring("db_server=".Length)
                    ElseIf line.StartsWith("db_uid=") Then
                        dbUid = line.Substring("db_uid=".Length)
                    ElseIf line.StartsWith("db_pwd=") Then
                        dbPwd = line.Substring("db_pwd=".Length)
                    ElseIf line.StartsWith("db_name=") Then
                        dbName = line.Substring("db_name=".Length)
                    End If
                Next
            End If

            ' Prompt the user for updated values
            dbServer = InputBox("Enter the Database Server", "Database Configuration", dbServer)
            dbUid = InputBox("Enter the Database Username", "Database Configuration", dbUid)
            dbPwd = InputBox("Enter the Database Password", "Database Configuration", dbPwd)
            dbName = InputBox("Enter the Database Name", "Database Configuration", dbName)

            ' Update the config file with the new values
            Dim updatedLines As New List(Of String) From {
            "db_server=" & dbServer,
            "db_uid=" & dbUid,
            "db_pwd=" & dbPwd,
            "db_name=" & dbName
        }
            File.WriteAllLines(filePath, updatedLines)

            MessageBox.Show("config.txt updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Reload the page
            ReloadPage()

        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Method to reload the page
    Private Sub ReloadPage()
        Try
            ' Reinitialize database connection or any necessary components
            UpdateConnectionString()
            openConn(db_name)

            ' Optional: Reset form components or reload data as needed
            Me.Controls.Clear()
            InitializeComponent()
            MessageBox.Show("Page reloaded successfully!", "Reload", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show($"An error occurred while reloading the page: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Other event handlers...

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles imgLoginPg.Click
        ' Handle the picture box click event here if needed
    End Sub

    Private Sub btnCloseLoginPg_Click(sender As Object, e As EventArgs) Handles btnCloseLoginPg.Click
        Application.Exit()
    End Sub

    Private Sub btnADMLoginPg_Click(sender As Object, e As EventArgs)
        Dim ADMLoginPage As New ADMloginPage
        Hide()
        ADMLoginPage.Show()
    End Sub

    Private Sub btnAGCLoginPg_Click(sender As Object, e As EventArgs) Handles btnAGCLoginPg.Click
        Dim AGCLoginPage As New AGENCYLoginPage()
        Me.Hide()
        AGCLoginPage.Show()
    End Sub

    Private Sub OFWloginPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateConnectionString()
        openConn(db_name)
    End Sub

    Private Sub btnEMPLoginPg_Click(sender As Object, e As EventArgs) Handles btnEMPLoginPg.Click
        Dim EMPLoginPage As New EMPLoginPage()
        Me.Hide()
        EMPLoginPage.Show()
    End Sub

    Private Sub btnOFWLoginPg_Click(sender As Object, e As EventArgs) Handles btnOFWLoginPg.Click
        ' Handle the button click event here if needed
    End Sub

    Private Sub btnOkOFWLoginPg_Click(sender As Object, e As EventArgs) Handles btnOkOFWLoginPg.Click

    End Sub
End Class
