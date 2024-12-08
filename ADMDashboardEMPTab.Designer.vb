<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ADMDashboardEMPTab
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label13 = New Label()
        btnClearFilter = New Button()
        lblEMPTally = New Label()
        Label12 = New Label()
        btnDLT = New Button()
        btnGEN = New Button()
        btnEDIT = New Button()
        btnADD = New Button()
        btnFilter = New Button()
        Label11 = New Label()
        txtEMPContNumFilt = New TextBox()
        Label10 = New Label()
        txtEMPEmailFilt = New TextBox()
        Label9 = New Label()
        txtEMPZipFilt = New TextBox()
        Label7 = New Label()
        Label6 = New Label()
        txtEMPLNameFilt = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        txtEMPFNameFilt = New TextBox()
        Label3 = New Label()
        txtEMPIdFilt = New TextBox()
        Label2 = New Label()
        btnLogout = New Button()
        dgvEMP = New DataGridView()
        txtEMPMNameFilt = New TextBox()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Panel4 = New Panel()
        btnCLose = New Button()
        Panel1 = New Panel()
        btnADMDashSTAT = New Button()
        btnADMDashDEP = New Button()
        btnADMDashJOB = New Button()
        btnADMDashAGC = New Button()
        btnADMDashEMP = New Button()
        btnADMDashOFW = New Button()
        Label8 = New Label()
        txtEMPCompanyFilt = New TextBox()
        Label14 = New Label()
        txtEMPIndustryFilt = New TextBox()
        btnCloseEMP = New Button()
        btnLogoutEMP = New Button()
        Label22 = New Label()
        txtbxEMPZIPCODEFilt = New TextBox()
        txtbxEMPLicenseExpiryFilt = New TextBox()
        Label24 = New Label()
        txtbxEMPAccreditationStaFilt = New TextBox()
        Label25 = New Label()
        txtbxEMPYearsOfOperationFilt = New TextBox()
        Label26 = New Label()
        txtbxEMPSpecializationFilt = New TextBox()
        Label27 = New Label()
        txtbxEMPWebsiteFilt = New TextBox()
        Label20 = New Label()
        txtbxEMPEmailFilt = New TextBox()
        Label21 = New Label()
        txtbxEMPContactFilt = New TextBox()
        Label23 = New Label()
        txtbxEMPLicenseNumFilt = New TextBox()
        Label28 = New Label()
        txtbxEMPNameFilt = New TextBox()
        Label29 = New Label()
        Label30 = New Label()
        txtbxEMPIdFilt = New TextBox()
        Label31 = New Label()
        CType(dgvEMP, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(2156, 266)
        Label13.Margin = New Padding(4, 0, 4, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(47, 21)
        Label13.TabIndex = 74
        Label13.Text = "EMP-"
        ' 
        ' btnClearFilter
        ' 
        btnClearFilter.FlatStyle = FlatStyle.Popup
        btnClearFilter.Location = New Point(2245, 770)
        btnClearFilter.Margin = New Padding(4)
        btnClearFilter.Name = "btnClearFilter"
        btnClearFilter.Size = New Size(98, 38)
        btnClearFilter.TabIndex = 73
        btnClearFilter.Text = "Clear"
        btnClearFilter.UseVisualStyleBackColor = True
        ' 
        ' lblEMPTally
        ' 
        lblEMPTally.AutoSize = True
        lblEMPTally.Location = New Point(2408, 815)
        lblEMPTally.Margin = New Padding(4, 0, 4, 0)
        lblEMPTally.Name = "lblEMPTally"
        lblEMPTally.Size = New Size(19, 21)
        lblEMPTally.TabIndex = 72
        lblEMPTally.Text = "0"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(2156, 815)
        Label12.Margin = New Padding(4, 0, 4, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(249, 21)
        Label12.TabIndex = 71
        Label12.Text = "Total number of Employers shown:"
        ' 
        ' btnDLT
        ' 
        btnDLT.BackColor = Color.MistyRose
        btnDLT.FlatStyle = FlatStyle.Popup
        btnDLT.ForeColor = Color.DarkRed
        btnDLT.Location = New Point(2350, 1403)
        btnDLT.Margin = New Padding(4)
        btnDLT.Name = "btnDLT"
        btnDLT.Size = New Size(94, 92)
        btnDLT.TabIndex = 70
        btnDLT.Text = "DELETE"
        btnDLT.UseVisualStyleBackColor = False
        ' 
        ' btnGEN
        ' 
        btnGEN.BackColor = Color.LightCyan
        btnGEN.FlatStyle = FlatStyle.Popup
        btnGEN.ForeColor = Color.DarkBlue
        btnGEN.Location = New Point(2350, 1302)
        btnGEN.Margin = New Padding(4)
        btnGEN.Name = "btnGEN"
        btnGEN.Size = New Size(94, 92)
        btnGEN.TabIndex = 69
        btnGEN.Text = "GENERATE"
        btnGEN.UseVisualStyleBackColor = False
        ' 
        ' btnEDIT
        ' 
        btnEDIT.BackColor = Color.LightCyan
        btnEDIT.FlatStyle = FlatStyle.Popup
        btnEDIT.ForeColor = Color.DarkBlue
        btnEDIT.Location = New Point(2249, 1302)
        btnEDIT.Margin = New Padding(4)
        btnEDIT.Name = "btnEDIT"
        btnEDIT.Size = New Size(94, 92)
        btnEDIT.TabIndex = 68
        btnEDIT.Text = "EDIT"
        btnEDIT.UseVisualStyleBackColor = False
        ' 
        ' btnADD
        ' 
        btnADD.BackColor = Color.LightCyan
        btnADD.FlatStyle = FlatStyle.Popup
        btnADD.ForeColor = Color.DarkBlue
        btnADD.Location = New Point(2148, 1302)
        btnADD.Margin = New Padding(4)
        btnADD.Name = "btnADD"
        btnADD.Size = New Size(94, 92)
        btnADD.TabIndex = 67
        btnADD.Text = "ADD"
        btnADD.UseVisualStyleBackColor = False
        ' 
        ' btnFilter
        ' 
        btnFilter.FlatStyle = FlatStyle.Popup
        btnFilter.Location = New Point(2350, 770)
        btnFilter.Margin = New Padding(4)
        btnFilter.Name = "btnFilter"
        btnFilter.Size = New Size(98, 38)
        btnFilter.TabIndex = 66
        btnFilter.Text = "Filter"
        btnFilter.UseVisualStyleBackColor = True
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(2152, 680)
        Label11.Margin = New Padding(4, 0, 4, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(125, 21)
        Label11.TabIndex = 64
        Label11.Text = "Contact Number"
        ' 
        ' txtEMPContNumFilt
        ' 
        txtEMPContNumFilt.Location = New Point(2152, 643)
        txtEMPContNumFilt.Margin = New Padding(4)
        txtEMPContNumFilt.Name = "txtEMPContNumFilt"
        txtEMPContNumFilt.PlaceholderText = "####"
        txtEMPContNumFilt.Size = New Size(175, 29)
        txtEMPContNumFilt.TabIndex = 63
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(2156, 743)
        Label10.Margin = New Padding(4, 0, 4, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(48, 21)
        Label10.TabIndex = 62
        Label10.Text = "Email"
        ' 
        ' txtEMPEmailFilt
        ' 
        txtEMPEmailFilt.Location = New Point(2152, 707)
        txtEMPEmailFilt.Margin = New Padding(4)
        txtEMPEmailFilt.Name = "txtEMPEmailFilt"
        txtEMPEmailFilt.PlaceholderText = "####"
        txtEMPEmailFilt.Size = New Size(175, 29)
        txtEMPEmailFilt.TabIndex = 61
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(2152, 616)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(65, 21)
        Label9.TabIndex = 60
        Label9.Text = "Zipcode"
        ' 
        ' txtEMPZipFilt
        ' 
        txtEMPZipFilt.Location = New Point(2152, 578)
        txtEMPZipFilt.Margin = New Padding(4)
        txtEMPZipFilt.Name = "txtEMPZipFilt"
        txtEMPZipFilt.PlaceholderText = "####"
        txtEMPZipFilt.Size = New Size(175, 29)
        txtEMPZipFilt.TabIndex = 59
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(1435, 564)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(0, 21)
        Label7.TabIndex = 57
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(2152, 487)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(84, 21)
        Label6.TabIndex = 54
        Label6.Text = "Last Name"
        ' 
        ' txtEMPLNameFilt
        ' 
        txtEMPLNameFilt.Location = New Point(2152, 449)
        txtEMPLNameFilt.Margin = New Padding(4)
        txtEMPLNameFilt.Name = "txtEMPLNameFilt"
        txtEMPLNameFilt.PlaceholderText = "Last Name"
        txtEMPLNameFilt.Size = New Size(291, 29)
        txtEMPLNameFilt.TabIndex = 53
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(2152, 423)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(104, 21)
        Label5.TabIndex = 52
        Label5.Text = "Middle Name"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(2152, 358)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(86, 21)
        Label4.TabIndex = 50
        Label4.Text = "First Name"
        ' 
        ' txtEMPFNameFilt
        ' 
        txtEMPFNameFilt.Location = New Point(2152, 321)
        txtEMPFNameFilt.Margin = New Padding(4)
        txtEMPFNameFilt.Name = "txtEMPFNameFilt"
        txtEMPFNameFilt.PlaceholderText = "First Name"
        txtEMPFNameFilt.Size = New Size(291, 29)
        txtEMPFNameFilt.TabIndex = 49
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(2152, 294)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(157, 21)
        Label3.TabIndex = 48
        Label3.Text = "Employer ID Number"
        ' 
        ' txtEMPIdFilt
        ' 
        txtEMPIdFilt.Location = New Point(2206, 259)
        txtEMPIdFilt.Margin = New Padding(4)
        txtEMPIdFilt.Name = "txtEMPIdFilt"
        txtEMPIdFilt.PlaceholderText = "#####"
        txtEMPIdFilt.Size = New Size(72, 29)
        txtEMPIdFilt.TabIndex = 47
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Rounded MT Bold", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(2143, 204)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(250, 43)
        Label2.TabIndex = 46
        Label2.Text = "Filter Search"
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.LightSlateGray
        btnLogout.FlatAppearance.BorderSize = 0
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Font = New Font("Arial Rounded MT Bold", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnLogout.ForeColor = Color.Black
        btnLogout.Location = New Point(2298, 17)
        btnLogout.Margin = New Padding(4)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(81, 29)
        btnLogout.TabIndex = 45
        btnLogout.Text = "LOGOUT"
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' dgvEMP
        ' 
        dgvEMP.BackgroundColor = SystemColors.ActiveCaption
        dgvEMP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvEMP.Location = New Point(445, 210)
        dgvEMP.Margin = New Padding(4)
        dgvEMP.Name = "dgvEMP"
        dgvEMP.RowHeadersWidth = 51
        dgvEMP.Size = New Size(1080, 870)
        dgvEMP.TabIndex = 44
        ' 
        ' txtEMPMNameFilt
        ' 
        txtEMPMNameFilt.Location = New Point(2152, 385)
        txtEMPMNameFilt.Margin = New Padding(4)
        txtEMPMNameFilt.Name = "txtEMPMNameFilt"
        txtEMPMNameFilt.PlaceholderText = "Middle Name"
        txtEMPMNameFilt.Size = New Size(291, 29)
        txtEMPMNameFilt.TabIndex = 51
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Maiandra GD", 48F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.MidnightBlue
        Label1.Location = New Point(445, 35)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(410, 96)
        Label1.TabIndex = 43
        Label1.Text = "Employers"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.Untitled_design__8_
        PictureBox1.Location = New Point(15, 10)
        PictureBox1.Margin = New Padding(4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(404, 469)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.MidnightBlue
        Panel4.Location = New Point(428, 160)
        Panel4.Margin = New Padding(4)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(1493, 35)
        Panel4.TabIndex = 42
        ' 
        ' btnCLose
        ' 
        btnCLose.BackColor = Color.Crimson
        btnCLose.FlatAppearance.BorderSize = 0
        btnCLose.FlatStyle = FlatStyle.Flat
        btnCLose.Font = New Font("Arial Rounded MT Bold", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCLose.ForeColor = Color.MistyRose
        btnCLose.Location = New Point(2386, 17)
        btnCLose.Margin = New Padding(4)
        btnCLose.Name = "btnCLose"
        btnCLose.Size = New Size(67, 29)
        btnCLose.TabIndex = 41
        btnCLose.Text = "CLOSE"
        btnCLose.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.MidnightBlue
        Panel1.Controls.Add(btnADMDashSTAT)
        Panel1.Controls.Add(btnADMDashDEP)
        Panel1.Controls.Add(btnADMDashJOB)
        Panel1.Controls.Add(btnADMDashAGC)
        Panel1.Controls.Add(btnADMDashEMP)
        Panel1.Controls.Add(btnADMDashOFW)
        Panel1.Controls.Add(PictureBox1)
        Panel1.ForeColor = SystemColors.ControlText
        Panel1.Location = New Point(-3, -1)
        Panel1.Margin = New Padding(4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(433, 1520)
        Panel1.TabIndex = 40
        ' 
        ' btnADMDashSTAT
        ' 
        btnADMDashSTAT.BackColor = Color.RoyalBlue
        btnADMDashSTAT.FlatAppearance.BorderSize = 0
        btnADMDashSTAT.FlatStyle = FlatStyle.Flat
        btnADMDashSTAT.Font = New Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnADMDashSTAT.ForeColor = Color.MidnightBlue
        btnADMDashSTAT.Location = New Point(65, 965)
        btnADMDashSTAT.Margin = New Padding(4)
        btnADMDashSTAT.Name = "btnADMDashSTAT"
        btnADMDashSTAT.Size = New Size(310, 65)
        btnADMDashSTAT.TabIndex = 19
        btnADMDashSTAT.Text = "Statistics"
        btnADMDashSTAT.UseVisualStyleBackColor = False
        ' 
        ' btnADMDashDEP
        ' 
        btnADMDashDEP.BackColor = Color.RoyalBlue
        btnADMDashDEP.FlatAppearance.BorderSize = 0
        btnADMDashDEP.FlatStyle = FlatStyle.Flat
        btnADMDashDEP.Font = New Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnADMDashDEP.ForeColor = Color.MidnightBlue
        btnADMDashDEP.Location = New Point(65, 875)
        btnADMDashDEP.Margin = New Padding(4)
        btnADMDashDEP.Name = "btnADMDashDEP"
        btnADMDashDEP.Size = New Size(310, 65)
        btnADMDashDEP.TabIndex = 18
        btnADMDashDEP.Text = "Deployments"
        btnADMDashDEP.UseVisualStyleBackColor = False
        ' 
        ' btnADMDashJOB
        ' 
        btnADMDashJOB.BackColor = Color.RoyalBlue
        btnADMDashJOB.FlatAppearance.BorderSize = 0
        btnADMDashJOB.FlatStyle = FlatStyle.Flat
        btnADMDashJOB.Font = New Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnADMDashJOB.ForeColor = Color.MidnightBlue
        btnADMDashJOB.Location = New Point(65, 790)
        btnADMDashJOB.Margin = New Padding(4)
        btnADMDashJOB.Name = "btnADMDashJOB"
        btnADMDashJOB.Size = New Size(310, 65)
        btnADMDashJOB.TabIndex = 17
        btnADMDashJOB.Text = "Job Placements"
        btnADMDashJOB.UseVisualStyleBackColor = False
        ' 
        ' btnADMDashAGC
        ' 
        btnADMDashAGC.BackColor = Color.RoyalBlue
        btnADMDashAGC.FlatAppearance.BorderSize = 0
        btnADMDashAGC.FlatStyle = FlatStyle.Flat
        btnADMDashAGC.Font = New Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnADMDashAGC.ForeColor = Color.MidnightBlue
        btnADMDashAGC.Location = New Point(65, 705)
        btnADMDashAGC.Margin = New Padding(4)
        btnADMDashAGC.Name = "btnADMDashAGC"
        btnADMDashAGC.Size = New Size(310, 65)
        btnADMDashAGC.TabIndex = 16
        btnADMDashAGC.Text = "Agencies"
        btnADMDashAGC.UseVisualStyleBackColor = False
        ' 
        ' btnADMDashEMP
        ' 
        btnADMDashEMP.BackColor = Color.DeepSkyBlue
        btnADMDashEMP.FlatAppearance.BorderSize = 0
        btnADMDashEMP.FlatStyle = FlatStyle.Flat
        btnADMDashEMP.Font = New Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnADMDashEMP.ForeColor = Color.MidnightBlue
        btnADMDashEMP.Location = New Point(65, 620)
        btnADMDashEMP.Margin = New Padding(4)
        btnADMDashEMP.Name = "btnADMDashEMP"
        btnADMDashEMP.Size = New Size(368, 65)
        btnADMDashEMP.TabIndex = 15
        btnADMDashEMP.Text = "Employers"
        btnADMDashEMP.UseVisualStyleBackColor = False
        ' 
        ' btnADMDashOFW
        ' 
        btnADMDashOFW.BackColor = Color.RoyalBlue
        btnADMDashOFW.FlatAppearance.BorderSize = 0
        btnADMDashOFW.FlatStyle = FlatStyle.Flat
        btnADMDashOFW.Font = New Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnADMDashOFW.ForeColor = Color.MidnightBlue
        btnADMDashOFW.Location = New Point(65, 535)
        btnADMDashOFW.Margin = New Padding(4)
        btnADMDashOFW.Name = "btnADMDashOFW"
        btnADMDashOFW.Size = New Size(310, 65)
        btnADMDashOFW.TabIndex = 14
        btnADMDashOFW.Text = "OFWs"
        btnADMDashOFW.UseVisualStyleBackColor = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(2152, 550)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(123, 21)
        Label8.TabIndex = 76
        Label8.Text = "Company Name"
        ' 
        ' txtEMPCompanyFilt
        ' 
        txtEMPCompanyFilt.Location = New Point(2152, 512)
        txtEMPCompanyFilt.Margin = New Padding(4)
        txtEMPCompanyFilt.Name = "txtEMPCompanyFilt"
        txtEMPCompanyFilt.PlaceholderText = "Company Name"
        txtEMPCompanyFilt.Size = New Size(175, 29)
        txtEMPCompanyFilt.TabIndex = 75
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(2336, 552)
        Label14.Margin = New Padding(4, 0, 4, 0)
        Label14.Name = "Label14"
        Label14.Size = New Size(67, 21)
        Label14.TabIndex = 78
        Label14.Text = "Industry"
        ' 
        ' txtEMPIndustryFilt
        ' 
        txtEMPIndustryFilt.Location = New Point(2336, 511)
        txtEMPIndustryFilt.Margin = New Padding(4)
        txtEMPIndustryFilt.Name = "txtEMPIndustryFilt"
        txtEMPIndustryFilt.PlaceholderText = "Industry"
        txtEMPIndustryFilt.Size = New Size(107, 29)
        txtEMPIndustryFilt.TabIndex = 77
        ' 
        ' btnCloseEMP
        ' 
        btnCloseEMP.Anchor = AnchorStyles.None
        btnCloseEMP.BackColor = Color.Crimson
        btnCloseEMP.FlatAppearance.BorderSize = 0
        btnCloseEMP.FlatStyle = FlatStyle.Flat
        btnCloseEMP.Font = New Font("Arial Rounded MT Bold", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCloseEMP.ForeColor = Color.MistyRose
        btnCloseEMP.Location = New Point(1835, 14)
        btnCloseEMP.Margin = New Padding(0)
        btnCloseEMP.Name = "btnCloseEMP"
        btnCloseEMP.Size = New Size(70, 25)
        btnCloseEMP.TabIndex = 152
        btnCloseEMP.Text = "CLOSE"
        btnCloseEMP.UseVisualStyleBackColor = False
        ' 
        ' btnLogoutEMP
        ' 
        btnLogoutEMP.Anchor = AnchorStyles.None
        btnLogoutEMP.BackColor = Color.LightSlateGray
        btnLogoutEMP.FlatAppearance.BorderSize = 0
        btnLogoutEMP.FlatStyle = FlatStyle.Flat
        btnLogoutEMP.Font = New Font("Arial Rounded MT Bold", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnLogoutEMP.ForeColor = Color.Black
        btnLogoutEMP.Location = New Point(1745, 14)
        btnLogoutEMP.Margin = New Padding(0)
        btnLogoutEMP.Name = "btnLogoutEMP"
        btnLogoutEMP.Size = New Size(80, 25)
        btnLogoutEMP.TabIndex = 151
        btnLogoutEMP.Text = "LOGOUT"
        btnLogoutEMP.UseVisualStyleBackColor = False
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label22.Location = New Point(1604, 814)
        Label22.Name = "Label22"
        Label22.Size = New Size(82, 23)
        Label22.TabIndex = 241
        Label22.Text = "Zip Code"
        ' 
        ' txtbxEMPZIPCODEFilt
        ' 
        txtbxEMPZIPCODEFilt.Location = New Point(1604, 840)
        txtbxEMPZIPCODEFilt.Name = "txtbxEMPZIPCODEFilt"
        txtbxEMPZIPCODEFilt.Size = New Size(82, 29)
        txtbxEMPZIPCODEFilt.TabIndex = 240
        ' 
        ' txtbxEMPLicenseExpiryFilt
        ' 
        txtbxEMPLicenseExpiryFilt.Location = New Point(1604, 778)
        txtbxEMPLicenseExpiryFilt.Name = "txtbxEMPLicenseExpiryFilt"
        txtbxEMPLicenseExpiryFilt.Size = New Size(245, 29)
        txtbxEMPLicenseExpiryFilt.TabIndex = 239
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Label24.Location = New Point(1604, 753)
        Label24.Name = "Label24"
        Label24.Size = New Size(123, 23)
        Label24.TabIndex = 238
        Label24.Text = "License Expiry"
        ' 
        ' txtbxEMPAccreditationStaFilt
        ' 
        txtbxEMPAccreditationStaFilt.Location = New Point(1604, 721)
        txtbxEMPAccreditationStaFilt.Name = "txtbxEMPAccreditationStaFilt"
        txtbxEMPAccreditationStaFilt.Size = New Size(245, 29)
        txtbxEMPAccreditationStaFilt.TabIndex = 237
        ' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Label25.Location = New Point(1604, 696)
        Label25.Name = "Label25"
        Label25.Size = New Size(173, 23)
        Label25.TabIndex = 236
        Label25.Text = "Accreditation Status"
        ' 
        ' txtbxEMPYearsOfOperationFilt
        ' 
        txtbxEMPYearsOfOperationFilt.Location = New Point(1604, 664)
        txtbxEMPYearsOfOperationFilt.Name = "txtbxEMPYearsOfOperationFilt"
        txtbxEMPYearsOfOperationFilt.Size = New Size(245, 29)
        txtbxEMPYearsOfOperationFilt.TabIndex = 235
        ' 
        ' Label26
        ' 
        Label26.AutoSize = True
        Label26.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Label26.Location = New Point(1604, 639)
        Label26.Name = "Label26"
        Label26.Size = New Size(158, 23)
        Label26.TabIndex = 234
        Label26.Text = "Years of Operation"
        ' 
        ' txtbxEMPSpecializationFilt
        ' 
        txtbxEMPSpecializationFilt.Location = New Point(1604, 607)
        txtbxEMPSpecializationFilt.Name = "txtbxEMPSpecializationFilt"
        txtbxEMPSpecializationFilt.Size = New Size(245, 29)
        txtbxEMPSpecializationFilt.TabIndex = 233
        ' 
        ' Label27
        ' 
        Label27.AutoSize = True
        Label27.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Label27.Location = New Point(1604, 582)
        Label27.Name = "Label27"
        Label27.Size = New Size(112, 23)
        Label27.TabIndex = 232
        Label27.Text = "Specilization"
        ' 
        ' txtbxEMPWebsiteFilt
        ' 
        txtbxEMPWebsiteFilt.Location = New Point(1604, 550)
        txtbxEMPWebsiteFilt.Name = "txtbxEMPWebsiteFilt"
        txtbxEMPWebsiteFilt.Size = New Size(245, 29)
        txtbxEMPWebsiteFilt.TabIndex = 231
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Label20.Location = New Point(1604, 525)
        Label20.Name = "Label20"
        Label20.Size = New Size(75, 23)
        Label20.TabIndex = 230
        Label20.Text = "Website"
        ' 
        ' txtbxEMPEmailFilt
        ' 
        txtbxEMPEmailFilt.Location = New Point(1604, 493)
        txtbxEMPEmailFilt.Name = "txtbxEMPEmailFilt"
        txtbxEMPEmailFilt.Size = New Size(245, 29)
        txtbxEMPEmailFilt.TabIndex = 229
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Label21.Location = New Point(1604, 468)
        Label21.Name = "Label21"
        Label21.Size = New Size(54, 23)
        Label21.TabIndex = 228
        Label21.Text = "Email"
        ' 
        ' txtbxEMPContactFilt
        ' 
        txtbxEMPContactFilt.Location = New Point(1604, 436)
        txtbxEMPContactFilt.Name = "txtbxEMPContactFilt"
        txtbxEMPContactFilt.Size = New Size(245, 29)
        txtbxEMPContactFilt.TabIndex = 227
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Label23.Location = New Point(1604, 411)
        Label23.Name = "Label23"
        Label23.Size = New Size(72, 23)
        Label23.TabIndex = 226
        Label23.Text = "Contact"
        ' 
        ' txtbxEMPLicenseNumFilt
        ' 
        txtbxEMPLicenseNumFilt.Location = New Point(1604, 379)
        txtbxEMPLicenseNumFilt.Name = "txtbxEMPLicenseNumFilt"
        txtbxEMPLicenseNumFilt.Size = New Size(245, 29)
        txtbxEMPLicenseNumFilt.TabIndex = 225
        ' 
        ' Label28
        ' 
        Label28.AutoSize = True
        Label28.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Label28.Location = New Point(1604, 354)
        Label28.Name = "Label28"
        Label28.Size = New Size(138, 23)
        Label28.TabIndex = 224
        Label28.Text = "License Number"
        ' 
        ' txtbxEMPNameFilt
        ' 
        txtbxEMPNameFilt.Location = New Point(1604, 320)
        txtbxEMPNameFilt.Name = "txtbxEMPNameFilt"
        txtbxEMPNameFilt.Size = New Size(245, 29)
        txtbxEMPNameFilt.TabIndex = 223
        ' 
        ' Label29
        ' 
        Label29.AutoSize = True
        Label29.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Label29.Location = New Point(1604, 295)
        Label29.Name = "Label29"
        Label29.Size = New Size(57, 23)
        Label29.TabIndex = 222
        Label29.Text = "Name"
        ' 
        ' Label30
        ' 
        Label30.AutoSize = True
        Label30.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label30.Location = New Point(1636, 275)
        Label30.Name = "Label30"
        Label30.Size = New Size(109, 23)
        Label30.TabIndex = 221
        Label30.Text = "Employer ID"
        ' 
        ' txtbxEMPIdFilt
        ' 
        txtbxEMPIdFilt.Location = New Point(1750, 272)
        txtbxEMPIdFilt.Name = "txtbxEMPIdFilt"
        txtbxEMPIdFilt.Size = New Size(60, 29)
        txtbxEMPIdFilt.TabIndex = 220
        ' 
        ' Label31
        ' 
        Label31.AutoSize = True
        Label31.BackColor = Color.Transparent
        Label31.Font = New Font("Arial Rounded MT Bold", 28.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label31.ForeColor = SystemColors.ActiveCaptionText
        Label31.Location = New Point(1565, 215)
        Label31.Margin = New Padding(4, 0, 4, 0)
        Label31.Name = "Label31"
        Label31.Size = New Size(319, 54)
        Label31.TabIndex = 219
        Label31.Text = "Filter Search"
        ' 
        ' ADMDashboardEMPTab
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DeepSkyBlue
        ClientSize = New Size(1920, 1080)
        Controls.Add(Label22)
        Controls.Add(txtbxEMPZIPCODEFilt)
        Controls.Add(txtbxEMPLicenseExpiryFilt)
        Controls.Add(Label24)
        Controls.Add(txtbxEMPAccreditationStaFilt)
        Controls.Add(Label25)
        Controls.Add(txtbxEMPYearsOfOperationFilt)
        Controls.Add(Label26)
        Controls.Add(txtbxEMPSpecializationFilt)
        Controls.Add(Label27)
        Controls.Add(txtbxEMPWebsiteFilt)
        Controls.Add(Label20)
        Controls.Add(txtbxEMPEmailFilt)
        Controls.Add(Label21)
        Controls.Add(txtbxEMPContactFilt)
        Controls.Add(Label23)
        Controls.Add(txtbxEMPLicenseNumFilt)
        Controls.Add(Label28)
        Controls.Add(txtbxEMPNameFilt)
        Controls.Add(Label29)
        Controls.Add(Label30)
        Controls.Add(txtbxEMPIdFilt)
        Controls.Add(Label31)
        Controls.Add(btnCloseEMP)
        Controls.Add(btnLogoutEMP)
        Controls.Add(Label14)
        Controls.Add(txtEMPIndustryFilt)
        Controls.Add(Label8)
        Controls.Add(txtEMPCompanyFilt)
        Controls.Add(Label13)
        Controls.Add(btnClearFilter)
        Controls.Add(lblEMPTally)
        Controls.Add(Label12)
        Controls.Add(btnDLT)
        Controls.Add(btnGEN)
        Controls.Add(btnEDIT)
        Controls.Add(btnADD)
        Controls.Add(btnFilter)
        Controls.Add(Label11)
        Controls.Add(txtEMPContNumFilt)
        Controls.Add(Label10)
        Controls.Add(txtEMPEmailFilt)
        Controls.Add(Label9)
        Controls.Add(txtEMPZipFilt)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(txtEMPLNameFilt)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(txtEMPFNameFilt)
        Controls.Add(Label3)
        Controls.Add(txtEMPIdFilt)
        Controls.Add(Label2)
        Controls.Add(btnLogout)
        Controls.Add(dgvEMP)
        Controls.Add(txtEMPMNameFilt)
        Controls.Add(Label1)
        Controls.Add(Panel4)
        Controls.Add(btnCLose)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4)
        Name = "ADMDashboardEMPTab"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ADMDashboardEMPTab"
        WindowState = FormWindowState.Maximized
        CType(dgvEMP, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label13 As Label
    Friend WithEvents btnClearFilter As Button
    Private lblEMPTally As Label
    Friend WithEvents lblOFWTally As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents btnDLT As Button
    Friend WithEvents btnGEN As Button
    Friend WithEvents btnEDIT As Button
    Friend WithEvents btnADD As Button
    Friend WithEvents btnFilter As Button
    Friend WithEvents chkOFWEmpStatFilt As CheckBox
    Friend WithEvents Label11 As Label
    Private txtEMPContNumFilt As TextBox
    Friend WithEvents txtbxOFWVisaFilt As TextBox
    Friend WithEvents Label10 As Label
    Private txtEMPEmailFilt As TextBox
    Friend WithEvents txtbxOFWOECFilt As TextBox
    Friend WithEvents Label9 As Label
    Private txtEMPZipFilt As TextBox
    Friend WithEvents txtbxOFWZipFilt As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Private txtEMPLNameFilt As TextBox
    Friend WithEvents txtbxOFWLNameFilt As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Private txtEMPFNameFilt As TextBox
    Friend WithEvents txtbxOFWFNameFilt As TextBox
    Friend WithEvents Label3 As Label
    Private txtEMPIdFilt As TextBox
    Friend WithEvents txtbxOFWIdFilt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents dgvEMP As DataGridView
    Private txtEMPMNameFilt As TextBox
    Friend WithEvents txtbxOFWMNameFilt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnCLose As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label8 As Label
    Private txtEMPCompanyFilt As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtEMPIndustryFilt As TextBox
    Friend WithEvents btnADMDashSTAT As Button
    Friend WithEvents btnADMDashDEP As Button
    Friend WithEvents btnADMDashJOB As Button
    Friend WithEvents btnADMDashAGC As Button
    Friend WithEvents btnADMDashEMP As Button
    Friend WithEvents btnADMDashOFW As Button
    Friend WithEvents btnCloseEMP As Button
    Friend WithEvents btnLogoutEMP As Button
    Friend WithEvents Label22 As Label
    Friend WithEvents txtbxEMPZIPCODEFilt As TextBox
    Friend WithEvents txtbxEMPLicenseExpiryFilt As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents txtbxEMPAccreditationStaFilt As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents txtbxEMPYearsOfOperationFilt As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents txtbxEMPSpecializationFilt As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents txtbxEMPWebsiteFilt As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txtbxEMPEmailFilt As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents txtbxEMPContactFilt As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents txtbxEMPLicenseNumFilt As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents txtbxEMPNameFilt As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents txtbxEMPIdFilt As TextBox
    Friend WithEvents Label31 As Label
End Class
