<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ADMDashboardDEPTab
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
        btnADMDashSTAT = New Button()
        btnADMDashDEP = New Button()
        btnADMDashJOB = New Button()
        btnADMDashOFW = New Button()
        btnADMDashAGC = New Button()
        btnADMDashEMP = New Button()
        Label15 = New Label()
        PictureBox1 = New PictureBox()
        Label13 = New Label()
        btnClearFilter = New Button()
        lblDEPTally = New Label()
        Label12 = New Label()
        btnDLT = New Button()
        btnGEN = New Button()
        btnEDIT = New Button()
        btnADD = New Button()
        btnFilter = New Button()
        Label11 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        Label7 = New Label()
        Label3 = New Label()
        txtAGCIdFilt = New TextBox()
        Label2 = New Label()
        btnLogout = New Button()
        dgvDEP = New DataGridView()
        Label1 = New Label()
        Panel4 = New Panel()
        btnCLose = New Button()
        Panel1 = New Panel()
        Label4 = New Label()
        Label6 = New Label()
        txtOFWIdFilt = New TextBox()
        Label5 = New Label()
        Label16 = New Label()
        txtJOBIdFilt = New TextBox()
        dateDEPdateFilt = New DateTimePicker()
        Label8 = New Label()
        Label14 = New Label()
        Label17 = New Label()
        TextBox1 = New TextBox()
        Label18 = New Label()
        Label19 = New Label()
        TextBox2 = New TextBox()
        txtDEPFilt = New TextBox()
        cbxDEPStatusFilt = New ComboBox()
        dateDEPContractEndFilt = New DateTimePicker()
        btnCloseDEP = New Button()
        btnLogoutDEP = New Button()
        Label22 = New Label()
        txtbxDEPZIPCODEFilt = New TextBox()
        txtbxDEPLicenseExpiryFilt = New TextBox()
        Label24 = New Label()
        txtbxDEPAccreditationStaFilt = New TextBox()
        Label25 = New Label()
        txtbxDEPYearsOfOperationFilt = New TextBox()
        Label26 = New Label()
        txtbxDEPSpecializationFilt = New TextBox()
        Label27 = New Label()
        txtbxDEPWebsiteFilt = New TextBox()
        Label20 = New Label()
        txtbxDEPEmailFilt = New TextBox()
        Label21 = New Label()
        txtbxDEPContactFilt = New TextBox()
        Label23 = New Label()
        txtbxDEPLicenseNumFilt = New TextBox()
        Label28 = New Label()
        txtbxDEPNameFilt = New TextBox()
        Label29 = New Label()
        Label30 = New Label()
        txtbxDEPIdFilt = New TextBox()
        Label31 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvDEP, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
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
        btnADMDashSTAT.TabIndex = 119
        btnADMDashSTAT.Text = "Statistics"
        btnADMDashSTAT.UseVisualStyleBackColor = False
        ' 
        ' btnADMDashDEP
        ' 
        btnADMDashDEP.BackColor = Color.DeepSkyBlue
        btnADMDashDEP.FlatAppearance.BorderSize = 0
        btnADMDashDEP.FlatStyle = FlatStyle.Flat
        btnADMDashDEP.Font = New Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnADMDashDEP.ForeColor = Color.MidnightBlue
        btnADMDashDEP.Location = New Point(65, 875)
        btnADMDashDEP.Margin = New Padding(4)
        btnADMDashDEP.Name = "btnADMDashDEP"
        btnADMDashDEP.Size = New Size(368, 65)
        btnADMDashDEP.TabIndex = 118
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
        btnADMDashJOB.TabIndex = 117
        btnADMDashJOB.Text = "Job Placements"
        btnADMDashJOB.UseVisualStyleBackColor = False
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
        btnADMDashOFW.TabIndex = 114
        btnADMDashOFW.Text = "OFWs"
        btnADMDashOFW.UseVisualStyleBackColor = False
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
        btnADMDashAGC.TabIndex = 116
        btnADMDashAGC.Text = "Agencies"
        btnADMDashAGC.UseVisualStyleBackColor = False
        ' 
        ' btnADMDashEMP
        ' 
        btnADMDashEMP.BackColor = Color.RoyalBlue
        btnADMDashEMP.FlatAppearance.BorderSize = 0
        btnADMDashEMP.FlatStyle = FlatStyle.Flat
        btnADMDashEMP.Font = New Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnADMDashEMP.ForeColor = Color.MidnightBlue
        btnADMDashEMP.Location = New Point(65, 620)
        btnADMDashEMP.Margin = New Padding(4)
        btnADMDashEMP.Name = "btnADMDashEMP"
        btnADMDashEMP.Size = New Size(310, 65)
        btnADMDashEMP.TabIndex = 115
        btnADMDashEMP.Text = "Employers"
        btnADMDashEMP.UseVisualStyleBackColor = False
        ' 
        ' Label15
        ' 
        Label15.Location = New Point(0, 0)
        Label15.Name = "Label15"
        Label15.Size = New Size(100, 23)
        Label15.TabIndex = 0
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
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(2159, 283)
        Label13.Margin = New Padding(4, 0, 4, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(47, 21)
        Label13.TabIndex = 142
        Label13.Text = "AGC-"
        ' 
        ' btnClearFilter
        ' 
        btnClearFilter.FlatStyle = FlatStyle.Popup
        btnClearFilter.Location = New Point(2199, 727)
        btnClearFilter.Margin = New Padding(4)
        btnClearFilter.Name = "btnClearFilter"
        btnClearFilter.Size = New Size(98, 38)
        btnClearFilter.TabIndex = 141
        btnClearFilter.Text = "Clear"
        btnClearFilter.UseVisualStyleBackColor = True
        ' 
        ' lblDEPTally
        ' 
        lblDEPTally.AutoSize = True
        lblDEPTally.Location = New Point(2430, 787)
        lblDEPTally.Margin = New Padding(4, 0, 4, 0)
        lblDEPTally.Name = "lblDEPTally"
        lblDEPTally.Size = New Size(19, 21)
        lblDEPTally.TabIndex = 140
        lblDEPTally.Text = "0"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(2159, 787)
        Label12.Margin = New Padding(4, 0, 4, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(268, 21)
        Label12.TabIndex = 139
        Label12.Text = "Total number of Deployments shown:"
        ' 
        ' btnDLT
        ' 
        btnDLT.BackColor = Color.MistyRose
        btnDLT.FlatStyle = FlatStyle.Popup
        btnDLT.ForeColor = Color.DarkRed
        btnDLT.Location = New Point(2314, 1380)
        btnDLT.Margin = New Padding(4)
        btnDLT.Name = "btnDLT"
        btnDLT.Size = New Size(94, 92)
        btnDLT.TabIndex = 138
        btnDLT.Text = "DELETE"
        btnDLT.UseVisualStyleBackColor = False
        ' 
        ' btnGEN
        ' 
        btnGEN.BackColor = Color.LightCyan
        btnGEN.FlatStyle = FlatStyle.Popup
        btnGEN.ForeColor = Color.DarkBlue
        btnGEN.Location = New Point(2191, 1380)
        btnGEN.Margin = New Padding(4)
        btnGEN.Name = "btnGEN"
        btnGEN.Size = New Size(94, 92)
        btnGEN.TabIndex = 137
        btnGEN.Text = "GENERATE"
        btnGEN.UseVisualStyleBackColor = False
        ' 
        ' btnEDIT
        ' 
        btnEDIT.BackColor = Color.LightCyan
        btnEDIT.FlatStyle = FlatStyle.Popup
        btnEDIT.ForeColor = Color.DarkBlue
        btnEDIT.Location = New Point(2314, 1264)
        btnEDIT.Margin = New Padding(4)
        btnEDIT.Name = "btnEDIT"
        btnEDIT.Size = New Size(94, 92)
        btnEDIT.TabIndex = 136
        btnEDIT.Text = "EDIT"
        btnEDIT.UseVisualStyleBackColor = False
        ' 
        ' btnADD
        ' 
        btnADD.BackColor = Color.LightCyan
        btnADD.FlatStyle = FlatStyle.Popup
        btnADD.ForeColor = Color.DarkBlue
        btnADD.Location = New Point(2191, 1264)
        btnADD.Margin = New Padding(4)
        btnADD.Name = "btnADD"
        btnADD.Size = New Size(94, 92)
        btnADD.TabIndex = 135
        btnADD.Text = "ADD"
        btnADD.UseVisualStyleBackColor = False
        ' 
        ' btnFilter
        ' 
        btnFilter.FlatStyle = FlatStyle.Popup
        btnFilter.Location = New Point(2304, 727)
        btnFilter.Margin = New Padding(4)
        btnFilter.Name = "btnFilter"
        btnFilter.Size = New Size(98, 38)
        btnFilter.TabIndex = 134
        btnFilter.Text = "Filter"
        btnFilter.UseVisualStyleBackColor = True
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(2155, 633)
        Label11.Margin = New Padding(4, 0, 4, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(52, 21)
        Label11.TabIndex = 133
        Label11.Text = "Status"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(2155, 697)
        Label10.Margin = New Padding(4, 0, 4, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(153, 21)
        Label10.TabIndex = 131
        Label10.Text = "Date of Contract End"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(2155, 568)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(173, 21)
        Label9.TabIndex = 129
        Label9.Text = "Country of Deployment"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(2155, 568)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(0, 21)
        Label7.TabIndex = 127
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(2155, 311)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(142, 21)
        Label3.TabIndex = 122
        Label3.Text = "Agency ID Number"
        ' 
        ' txtAGCIdFilt
        ' 
        txtAGCIdFilt.Location = New Point(2209, 276)
        txtAGCIdFilt.Margin = New Padding(4)
        txtAGCIdFilt.Name = "txtAGCIdFilt"
        txtAGCIdFilt.PlaceholderText = "#####"
        txtAGCIdFilt.Size = New Size(72, 29)
        txtAGCIdFilt.TabIndex = 121
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Rounded MT Bold", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(2155, 211)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(250, 43)
        Label2.TabIndex = 120
        Label2.Text = "Filter Search"
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.LightSlateGray
        btnLogout.FlatAppearance.BorderSize = 0
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Font = New Font("Arial Rounded MT Bold", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnLogout.ForeColor = Color.Black
        btnLogout.Location = New Point(2296, 17)
        btnLogout.Margin = New Padding(4)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(81, 29)
        btnLogout.TabIndex = 119
        btnLogout.Text = "LOGOUT"
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' dgvDEP
        ' 
        dgvDEP.BackgroundColor = SystemColors.ActiveCaption
        dgvDEP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDEP.Location = New Point(445, 210)
        dgvDEP.Margin = New Padding(4)
        dgvDEP.Name = "dgvDEP"
        dgvDEP.RowHeadersWidth = 51
        dgvDEP.Size = New Size(1080, 870)
        dgvDEP.TabIndex = 118
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
        Label1.Size = New Size(482, 96)
        Label1.TabIndex = 117
        Label1.Text = "Deployment"
        ' 
        ' Panel4
        ' 
        Panel4.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel4.BackColor = Color.MidnightBlue
        Panel4.Location = New Point(428, 160)
        Panel4.Margin = New Padding(4)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(1493, 35)
        Panel4.TabIndex = 116
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
        btnCLose.TabIndex = 115
        btnCLose.Text = "CLOSE"
        btnCLose.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.MidnightBlue
        Panel1.Controls.Add(btnADMDashSTAT)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(btnADMDashDEP)
        Panel1.Controls.Add(btnADMDashJOB)
        Panel1.Controls.Add(btnADMDashOFW)
        Panel1.Controls.Add(btnADMDashAGC)
        Panel1.Controls.Add(btnADMDashEMP)
        Panel1.ForeColor = SystemColors.ControlText
        Panel1.Location = New Point(-3, -1)
        Panel1.Margin = New Padding(4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(433, 1520)
        Panel1.TabIndex = 114
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(2159, 349)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(51, 21)
        Label4.TabIndex = 149
        Label4.Text = "OFW-"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(2155, 377)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(126, 21)
        Label6.TabIndex = 148
        Label6.Text = "OFW ID Number"
        ' 
        ' txtOFWIdFilt
        ' 
        txtOFWIdFilt.Location = New Point(2209, 342)
        txtOFWIdFilt.Margin = New Padding(4)
        txtOFWIdFilt.Name = "txtOFWIdFilt"
        txtOFWIdFilt.PlaceholderText = "#####"
        txtOFWIdFilt.Size = New Size(72, 29)
        txtOFWIdFilt.TabIndex = 147
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(2159, 412)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(43, 21)
        Label5.TabIndex = 152
        Label5.Text = "JOB-"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(2155, 440)
        Label16.Margin = New Padding(4, 0, 4, 0)
        Label16.Name = "Label16"
        Label16.Size = New Size(191, 21)
        Label16.TabIndex = 151
        Label16.Text = "Job Placement ID Number"
        ' 
        ' txtJOBIdFilt
        ' 
        txtJOBIdFilt.Location = New Point(2209, 405)
        txtJOBIdFilt.Margin = New Padding(4)
        txtJOBIdFilt.Name = "txtJOBIdFilt"
        txtJOBIdFilt.PlaceholderText = "#####"
        txtJOBIdFilt.Size = New Size(72, 29)
        txtJOBIdFilt.TabIndex = 150
        ' 
        ' dateDEPdateFilt
        ' 
        dateDEPdateFilt.Format = DateTimePickerFormat.Short
        dateDEPdateFilt.Location = New Point(2155, 465)
        dateDEPdateFilt.Margin = New Padding(4)
        dateDEPdateFilt.Name = "dateDEPdateFilt"
        dateDEPdateFilt.Size = New Size(172, 29)
        dateDEPdateFilt.TabIndex = 153
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(2155, 501)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(131, 21)
        Label8.TabIndex = 154
        Label8.Text = "Deployment Date"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(2305, 283)
        Label14.Margin = New Padding(4, 0, 4, 0)
        Label14.Name = "Label14"
        Label14.Size = New Size(47, 21)
        Label14.TabIndex = 157
        Label14.Text = "EMP-"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Location = New Point(2301, 311)
        Label17.Margin = New Padding(4, 0, 4, 0)
        Label17.Name = "Label17"
        Label17.Size = New Size(157, 21)
        Label17.TabIndex = 156
        Label17.Text = "Employer ID Number"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(2355, 276)
        TextBox1.Margin = New Padding(4)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "#####"
        TextBox1.Size = New Size(72, 29)
        TextBox1.TabIndex = 155
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Location = New Point(2309, 349)
        Label18.Margin = New Padding(4, 0, 4, 0)
        Label18.Name = "Label18"
        Label18.Size = New Size(47, 21)
        Label18.TabIndex = 160
        Label18.Text = "AGC-"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Location = New Point(2305, 377)
        Label19.Margin = New Padding(4, 0, 4, 0)
        Label19.Name = "Label19"
        Label19.Size = New Size(142, 21)
        Label19.TabIndex = 159
        Label19.Text = "Agency ID Number"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(2359, 342)
        TextBox2.Margin = New Padding(4)
        TextBox2.Name = "TextBox2"
        TextBox2.PlaceholderText = "#####"
        TextBox2.Size = New Size(72, 29)
        TextBox2.TabIndex = 158
        ' 
        ' txtDEPFilt
        ' 
        txtDEPFilt.Location = New Point(2155, 531)
        txtDEPFilt.Margin = New Padding(4)
        txtDEPFilt.Name = "txtDEPFilt"
        txtDEPFilt.PlaceholderText = "Country"
        txtDEPFilt.Size = New Size(175, 29)
        txtDEPFilt.TabIndex = 128
        ' 
        ' cbxDEPStatusFilt
        ' 
        cbxDEPStatusFilt.FormattingEnabled = True
        cbxDEPStatusFilt.Location = New Point(2155, 594)
        cbxDEPStatusFilt.Margin = New Padding(4)
        cbxDEPStatusFilt.Name = "cbxDEPStatusFilt"
        cbxDEPStatusFilt.Size = New Size(175, 29)
        cbxDEPStatusFilt.TabIndex = 161
        ' 
        ' dateDEPContractEndFilt
        ' 
        dateDEPContractEndFilt.Format = DateTimePickerFormat.Short
        dateDEPContractEndFilt.Location = New Point(2156, 658)
        dateDEPContractEndFilt.Margin = New Padding(4)
        dateDEPContractEndFilt.Name = "dateDEPContractEndFilt"
        dateDEPContractEndFilt.Size = New Size(174, 29)
        dateDEPContractEndFilt.TabIndex = 162
        ' 
        ' btnCloseDEP
        ' 
        btnCloseDEP.Anchor = AnchorStyles.None
        btnCloseDEP.BackColor = Color.Crimson
        btnCloseDEP.FlatAppearance.BorderSize = 0
        btnCloseDEP.FlatStyle = FlatStyle.Flat
        btnCloseDEP.Font = New Font("Arial Rounded MT Bold", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCloseDEP.ForeColor = Color.MistyRose
        btnCloseDEP.Location = New Point(1835, 14)
        btnCloseDEP.Margin = New Padding(0)
        btnCloseDEP.Name = "btnCloseDEP"
        btnCloseDEP.Size = New Size(70, 25)
        btnCloseDEP.TabIndex = 164
        btnCloseDEP.Text = "CLOSE"
        btnCloseDEP.UseVisualStyleBackColor = False
        ' 
        ' btnLogoutDEP
        ' 
        btnLogoutDEP.Anchor = AnchorStyles.None
        btnLogoutDEP.BackColor = Color.LightSlateGray
        btnLogoutDEP.FlatAppearance.BorderSize = 0
        btnLogoutDEP.FlatStyle = FlatStyle.Flat
        btnLogoutDEP.Font = New Font("Arial Rounded MT Bold", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnLogoutDEP.ForeColor = Color.Black
        btnLogoutDEP.Location = New Point(1745, 14)
        btnLogoutDEP.Margin = New Padding(0)
        btnLogoutDEP.Name = "btnLogoutDEP"
        btnLogoutDEP.Size = New Size(80, 25)
        btnLogoutDEP.TabIndex = 163
        btnLogoutDEP.Text = "LOGOUT"
        btnLogoutDEP.UseVisualStyleBackColor = False
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label22.Location = New Point(1602, 827)
        Label22.Name = "Label22"
        Label22.Size = New Size(82, 23)
        Label22.TabIndex = 218
        Label22.Text = "Zip Code"
        ' 
        ' txtbxDEPZIPCODEFilt
        ' 
        txtbxDEPZIPCODEFilt.Location = New Point(1602, 853)
        txtbxDEPZIPCODEFilt.Name = "txtbxDEPZIPCODEFilt"
        txtbxDEPZIPCODEFilt.Size = New Size(82, 29)
        txtbxDEPZIPCODEFilt.TabIndex = 217
        ' 
        ' txtbxDEPLicenseExpiryFilt
        ' 
        txtbxDEPLicenseExpiryFilt.Location = New Point(1602, 791)
        txtbxDEPLicenseExpiryFilt.Name = "txtbxDEPLicenseExpiryFilt"
        txtbxDEPLicenseExpiryFilt.Size = New Size(245, 29)
        txtbxDEPLicenseExpiryFilt.TabIndex = 216
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Label24.Location = New Point(1602, 766)
        Label24.Name = "Label24"
        Label24.Size = New Size(123, 23)
        Label24.TabIndex = 215
        Label24.Text = "License Expiry"
        ' 
        ' txtbxDEPAccreditationStaFilt
        ' 
        txtbxDEPAccreditationStaFilt.Location = New Point(1602, 734)
        txtbxDEPAccreditationStaFilt.Name = "txtbxDEPAccreditationStaFilt"
        txtbxDEPAccreditationStaFilt.Size = New Size(245, 29)
        txtbxDEPAccreditationStaFilt.TabIndex = 214
        ' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Label25.Location = New Point(1602, 709)
        Label25.Name = "Label25"
        Label25.Size = New Size(173, 23)
        Label25.TabIndex = 213
        Label25.Text = "Accreditation Status"
        ' 
        ' txtbxDEPYearsOfOperationFilt
        ' 
        txtbxDEPYearsOfOperationFilt.Location = New Point(1602, 677)
        txtbxDEPYearsOfOperationFilt.Name = "txtbxDEPYearsOfOperationFilt"
        txtbxDEPYearsOfOperationFilt.Size = New Size(245, 29)
        txtbxDEPYearsOfOperationFilt.TabIndex = 212
        ' 
        ' Label26
        ' 
        Label26.AutoSize = True
        Label26.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Label26.Location = New Point(1602, 652)
        Label26.Name = "Label26"
        Label26.Size = New Size(158, 23)
        Label26.TabIndex = 211
        Label26.Text = "Years of Operation"
        ' 
        ' txtbxDEPSpecializationFilt
        ' 
        txtbxDEPSpecializationFilt.Location = New Point(1602, 620)
        txtbxDEPSpecializationFilt.Name = "txtbxDEPSpecializationFilt"
        txtbxDEPSpecializationFilt.Size = New Size(245, 29)
        txtbxDEPSpecializationFilt.TabIndex = 210
        ' 
        ' Label27
        ' 
        Label27.AutoSize = True
        Label27.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Label27.Location = New Point(1602, 595)
        Label27.Name = "Label27"
        Label27.Size = New Size(112, 23)
        Label27.TabIndex = 209
        Label27.Text = "Specilization"
        ' 
        ' txtbxDEPWebsiteFilt
        ' 
        txtbxDEPWebsiteFilt.Location = New Point(1602, 563)
        txtbxDEPWebsiteFilt.Name = "txtbxDEPWebsiteFilt"
        txtbxDEPWebsiteFilt.Size = New Size(245, 29)
        txtbxDEPWebsiteFilt.TabIndex = 208
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Label20.Location = New Point(1602, 538)
        Label20.Name = "Label20"
        Label20.Size = New Size(75, 23)
        Label20.TabIndex = 207
        Label20.Text = "Website"
        ' 
        ' txtbxDEPEmailFilt
        ' 
        txtbxDEPEmailFilt.Location = New Point(1602, 506)
        txtbxDEPEmailFilt.Name = "txtbxDEPEmailFilt"
        txtbxDEPEmailFilt.Size = New Size(245, 29)
        txtbxDEPEmailFilt.TabIndex = 206
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Label21.Location = New Point(1602, 481)
        Label21.Name = "Label21"
        Label21.Size = New Size(54, 23)
        Label21.TabIndex = 205
        Label21.Text = "Email"
        ' 
        ' txtbxDEPContactFilt
        ' 
        txtbxDEPContactFilt.Location = New Point(1602, 449)
        txtbxDEPContactFilt.Name = "txtbxDEPContactFilt"
        txtbxDEPContactFilt.Size = New Size(245, 29)
        txtbxDEPContactFilt.TabIndex = 204
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Label23.Location = New Point(1602, 424)
        Label23.Name = "Label23"
        Label23.Size = New Size(72, 23)
        Label23.TabIndex = 203
        Label23.Text = "Contact"
        ' 
        ' txtbxDEPLicenseNumFilt
        ' 
        txtbxDEPLicenseNumFilt.Location = New Point(1602, 385)
        txtbxDEPLicenseNumFilt.Name = "txtbxDEPLicenseNumFilt"
        txtbxDEPLicenseNumFilt.Size = New Size(245, 29)
        txtbxDEPLicenseNumFilt.TabIndex = 202
        ' 
        ' Label28
        ' 
        Label28.AutoSize = True
        Label28.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Label28.Location = New Point(1602, 359)
        Label28.Name = "Label28"
        Label28.Size = New Size(138, 23)
        Label28.TabIndex = 201
        Label28.Text = "License Number"
        ' 
        ' txtbxDEPNameFilt
        ' 
        txtbxDEPNameFilt.Location = New Point(1602, 325)
        txtbxDEPNameFilt.Name = "txtbxDEPNameFilt"
        txtbxDEPNameFilt.Size = New Size(245, 29)
        txtbxDEPNameFilt.TabIndex = 200
        ' 
        ' Label29
        ' 
        Label29.AutoSize = True
        Label29.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Label29.Location = New Point(1602, 300)
        Label29.Name = "Label29"
        Label29.Size = New Size(57, 23)
        Label29.TabIndex = 199
        Label29.Text = "Name"
        ' 
        ' Label30
        ' 
        Label30.AutoSize = True
        Label30.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label30.Location = New Point(1614, 275)
        Label30.Name = "Label30"
        Label30.Size = New Size(132, 23)
        Label30.TabIndex = 198
        Label30.Text = "Deployment ID"
        ' 
        ' txtbxDEPIdFilt
        ' 
        txtbxDEPIdFilt.Location = New Point(1750, 272)
        txtbxDEPIdFilt.Name = "txtbxDEPIdFilt"
        txtbxDEPIdFilt.Size = New Size(60, 29)
        txtbxDEPIdFilt.TabIndex = 197
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
        Label31.TabIndex = 196
        Label31.Text = "Filter Search"
        ' 
        ' ADMDashboardDEPTab
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DeepSkyBlue
        ClientSize = New Size(1920, 1080)
        Controls.Add(Label22)
        Controls.Add(txtbxDEPZIPCODEFilt)
        Controls.Add(txtbxDEPLicenseExpiryFilt)
        Controls.Add(Label24)
        Controls.Add(txtbxDEPAccreditationStaFilt)
        Controls.Add(Label25)
        Controls.Add(txtbxDEPYearsOfOperationFilt)
        Controls.Add(Label26)
        Controls.Add(txtbxDEPSpecializationFilt)
        Controls.Add(Label27)
        Controls.Add(txtbxDEPWebsiteFilt)
        Controls.Add(Label20)
        Controls.Add(txtbxDEPEmailFilt)
        Controls.Add(Label21)
        Controls.Add(txtbxDEPContactFilt)
        Controls.Add(Label23)
        Controls.Add(txtbxDEPLicenseNumFilt)
        Controls.Add(Label28)
        Controls.Add(txtbxDEPNameFilt)
        Controls.Add(Label29)
        Controls.Add(Label30)
        Controls.Add(txtbxDEPIdFilt)
        Controls.Add(Label31)
        Controls.Add(btnCloseDEP)
        Controls.Add(btnLogoutDEP)
        Controls.Add(dateDEPContractEndFilt)
        Controls.Add(cbxDEPStatusFilt)
        Controls.Add(Label18)
        Controls.Add(Label19)
        Controls.Add(TextBox2)
        Controls.Add(Label14)
        Controls.Add(Label17)
        Controls.Add(TextBox1)
        Controls.Add(Label8)
        Controls.Add(dateDEPdateFilt)
        Controls.Add(Label5)
        Controls.Add(Label16)
        Controls.Add(txtJOBIdFilt)
        Controls.Add(Label4)
        Controls.Add(Label6)
        Controls.Add(txtOFWIdFilt)
        Controls.Add(Label13)
        Controls.Add(btnClearFilter)
        Controls.Add(lblDEPTally)
        Controls.Add(Label12)
        Controls.Add(btnDLT)
        Controls.Add(btnGEN)
        Controls.Add(btnEDIT)
        Controls.Add(btnADD)
        Controls.Add(btnFilter)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(txtDEPFilt)
        Controls.Add(Label7)
        Controls.Add(Label3)
        Controls.Add(txtAGCIdFilt)
        Controls.Add(Label2)
        Controls.Add(btnLogout)
        Controls.Add(dgvDEP)
        Controls.Add(Label1)
        Controls.Add(Panel4)
        Controls.Add(btnCLose)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4)
        Name = "ADMDashboardDEPTab"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ADMDashboardDEPTab"
        WindowState = FormWindowState.Maximized
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvDEP, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnADMDashSTAT As Button
    Friend WithEvents btnADMDashDEP As Button
    Friend WithEvents btnADMDashJOB As Button
    Friend WithEvents btnADMDashOFW As Button
    Friend WithEvents btnADMDashAGC As Button
    Friend WithEvents btnADMDashEMP As Button
    Friend WithEvents txtAGCSpecFilt As TextBox
    Friend WithEvents Label14 As Label
    Private Label15 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Private WithEvents txtAGCWebFilt As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents btnClearFilter As Button
    Private WithEvents lblDEPTally As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents btnDLT As Button
    Friend WithEvents btnGEN As Button
    Friend WithEvents btnEDIT As Button
    Friend WithEvents btnADD As Button
    Friend WithEvents btnFilter As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Private WithEvents txtAGCIdFilt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents dgvDEP As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnCLose As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Private WithEvents txtOFWIdFilt As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label16 As Label
    Private WithEvents txtJOBIdFilt As TextBox
    Friend WithEvents dateDEPdateFilt As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Label17 As Label
    Private WithEvents TextBox1 As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Private WithEvents TextBox2 As TextBox
    Private WithEvents txtDEPFilt As TextBox
    Friend WithEvents cbxDEPStatusFilt As ComboBox
    Friend WithEvents dateDEPContractEndFilt As DateTimePicker
    Friend WithEvents btnCloseDEP As Button
    Friend WithEvents btnLogoutDEP As Button
    Friend WithEvents Label22 As Label
    Friend WithEvents txtbxDEPZIPCODEFilt As TextBox
    Friend WithEvents txtbxDEPLicenseExpiryFilt As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents txtbxDEPAccreditationStaFilt As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents txtbxDEPYearsOfOperationFilt As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents txtbxDEPSpecializationFilt As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents txtbxDEPWebsiteFilt As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txtbxDEPEmailFilt As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents txtbxDEPContactFilt As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents txtbxDEPLicenseNumFilt As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents txtbxDEPNameFilt As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents txtbxDEPIdFilt As TextBox
    Friend WithEvents Label31 As Label
End Class

