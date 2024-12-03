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
        btnADMDashSTAT.Location = New Point(42, 703)
        btnADMDashSTAT.Name = "btnADMDashSTAT"
        btnADMDashSTAT.Size = New Size(237, 45)
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
        btnADMDashDEP.Location = New Point(42, 639)
        btnADMDashDEP.Name = "btnADMDashDEP"
        btnADMDashDEP.Size = New Size(295, 45)
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
        btnADMDashJOB.Location = New Point(42, 574)
        btnADMDashJOB.Name = "btnADMDashJOB"
        btnADMDashJOB.Size = New Size(237, 45)
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
        btnADMDashOFW.Location = New Point(42, 384)
        btnADMDashOFW.Name = "btnADMDashOFW"
        btnADMDashOFW.Size = New Size(237, 45)
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
        btnADMDashAGC.Location = New Point(42, 507)
        btnADMDashAGC.Name = "btnADMDashAGC"
        btnADMDashAGC.Size = New Size(237, 45)
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
        btnADMDashEMP.Location = New Point(42, 446)
        btnADMDashEMP.Name = "btnADMDashEMP"
        btnADMDashEMP.Size = New Size(237, 45)
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
        PictureBox1.Location = New Point(12, 7)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(314, 335)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(1679, 202)
        Label13.Name = "Label13"
        Label13.Size = New Size(36, 15)
        Label13.TabIndex = 142
        Label13.Text = "AGC-"
        ' 
        ' btnClearFilter
        ' 
        btnClearFilter.FlatStyle = FlatStyle.Popup
        btnClearFilter.Location = New Point(1710, 519)
        btnClearFilter.Name = "btnClearFilter"
        btnClearFilter.Size = New Size(76, 27)
        btnClearFilter.TabIndex = 141
        btnClearFilter.Text = "Clear"
        btnClearFilter.UseVisualStyleBackColor = True
        ' 
        ' lblDEPTally
        ' 
        lblDEPTally.AutoSize = True
        lblDEPTally.Location = New Point(1890, 562)
        lblDEPTally.Name = "lblDEPTally"
        lblDEPTally.Size = New Size(13, 15)
        lblDEPTally.TabIndex = 140
        lblDEPTally.Text = "0"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(1679, 562)
        Label12.Name = "Label12"
        Label12.Size = New Size(206, 15)
        Label12.TabIndex = 139
        Label12.Text = "Total number of Deployments shown:"
        ' 
        ' btnDLT
        ' 
        btnDLT.BackColor = Color.MistyRose
        btnDLT.FlatStyle = FlatStyle.Popup
        btnDLT.ForeColor = Color.DarkRed
        btnDLT.Location = New Point(1800, 986)
        btnDLT.Name = "btnDLT"
        btnDLT.Size = New Size(73, 66)
        btnDLT.TabIndex = 138
        btnDLT.Text = "DELETE"
        btnDLT.UseVisualStyleBackColor = False
        ' 
        ' btnGEN
        ' 
        btnGEN.BackColor = Color.LightCyan
        btnGEN.FlatStyle = FlatStyle.Popup
        btnGEN.ForeColor = Color.DarkBlue
        btnGEN.Location = New Point(1704, 986)
        btnGEN.Name = "btnGEN"
        btnGEN.Size = New Size(73, 66)
        btnGEN.TabIndex = 137
        btnGEN.Text = "GENERATE"
        btnGEN.UseVisualStyleBackColor = False
        ' 
        ' btnEDIT
        ' 
        btnEDIT.BackColor = Color.LightCyan
        btnEDIT.FlatStyle = FlatStyle.Popup
        btnEDIT.ForeColor = Color.DarkBlue
        btnEDIT.Location = New Point(1800, 903)
        btnEDIT.Name = "btnEDIT"
        btnEDIT.Size = New Size(73, 66)
        btnEDIT.TabIndex = 136
        btnEDIT.Text = "EDIT"
        btnEDIT.UseVisualStyleBackColor = False
        ' 
        ' btnADD
        ' 
        btnADD.BackColor = Color.LightCyan
        btnADD.FlatStyle = FlatStyle.Popup
        btnADD.ForeColor = Color.DarkBlue
        btnADD.Location = New Point(1704, 903)
        btnADD.Name = "btnADD"
        btnADD.Size = New Size(73, 66)
        btnADD.TabIndex = 135
        btnADD.Text = "ADD"
        btnADD.UseVisualStyleBackColor = False
        ' 
        ' btnFilter
        ' 
        btnFilter.FlatStyle = FlatStyle.Popup
        btnFilter.Location = New Point(1792, 519)
        btnFilter.Name = "btnFilter"
        btnFilter.Size = New Size(76, 27)
        btnFilter.TabIndex = 134
        btnFilter.Text = "Filter"
        btnFilter.UseVisualStyleBackColor = True
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(1676, 452)
        Label11.Name = "Label11"
        Label11.Size = New Size(39, 15)
        Label11.TabIndex = 133
        Label11.Text = "Status"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(1676, 498)
        Label10.Name = "Label10"
        Label10.Size = New Size(117, 15)
        Label10.TabIndex = 131
        Label10.Text = "Date of Contract End"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(1676, 406)
        Label9.Name = "Label9"
        Label9.Size = New Size(132, 15)
        Label9.TabIndex = 129
        Label9.Text = "Country of Deployment"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(1676, 406)
        Label7.Name = "Label7"
        Label7.Size = New Size(0, 15)
        Label7.TabIndex = 127
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(1676, 222)
        Label3.Name = "Label3"
        Label3.Size = New Size(108, 15)
        Label3.TabIndex = 122
        Label3.Text = "Agency ID Number"
        ' 
        ' txtAGCIdFilt
        ' 
        txtAGCIdFilt.Location = New Point(1718, 197)
        txtAGCIdFilt.Name = "txtAGCIdFilt"
        txtAGCIdFilt.PlaceholderText = "#####"
        txtAGCIdFilt.Size = New Size(57, 23)
        txtAGCIdFilt.TabIndex = 121
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Rounded MT Bold", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(1676, 151)
        Label2.Name = "Label2"
        Label2.Size = New Size(197, 33)
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
        btnLogout.Location = New Point(1786, 12)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(63, 21)
        btnLogout.TabIndex = 119
        btnLogout.Text = "LOGOUT"
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' dgvDEP
        ' 
        dgvDEP.BackgroundColor = SystemColors.ActiveCaption
        dgvDEP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDEP.Location = New Point(348, 151)
        dgvDEP.Name = "dgvDEP"
        dgvDEP.RowHeadersWidth = 51
        dgvDEP.Size = New Size(1307, 901)
        dgvDEP.TabIndex = 118
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Maiandra GD", 48F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.MidnightBlue
        Label1.Location = New Point(346, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(388, 77)
        Label1.TabIndex = 117
        Label1.Text = "Deployment"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.MidnightBlue
        Panel4.Location = New Point(335, 119)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(1586, 22)
        Panel4.TabIndex = 116
        ' 
        ' btnCLose
        ' 
        btnCLose.BackColor = Color.Crimson
        btnCLose.FlatAppearance.BorderSize = 0
        btnCLose.FlatStyle = FlatStyle.Flat
        btnCLose.Font = New Font("Arial Rounded MT Bold", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCLose.ForeColor = Color.MistyRose
        btnCLose.Location = New Point(1856, 12)
        btnCLose.Name = "btnCLose"
        btnCLose.Size = New Size(52, 21)
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
        Panel1.Location = New Point(-2, -1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(337, 1086)
        Panel1.TabIndex = 114
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(1679, 249)
        Label4.Name = "Label4"
        Label4.Size = New Size(38, 15)
        Label4.TabIndex = 149
        Label4.Text = "OFW-"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(1676, 269)
        Label6.Name = "Label6"
        Label6.Size = New Size(94, 15)
        Label6.TabIndex = 148
        Label6.Text = "OFW ID Number"
        ' 
        ' txtOFWIdFilt
        ' 
        txtOFWIdFilt.Location = New Point(1718, 244)
        txtOFWIdFilt.Name = "txtOFWIdFilt"
        txtOFWIdFilt.PlaceholderText = "#####"
        txtOFWIdFilt.Size = New Size(57, 23)
        txtOFWIdFilt.TabIndex = 147
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(1679, 294)
        Label5.Name = "Label5"
        Label5.Size = New Size(32, 15)
        Label5.TabIndex = 152
        Label5.Text = "JOB-"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(1676, 314)
        Label16.Name = "Label16"
        Label16.Size = New Size(145, 15)
        Label16.TabIndex = 151
        Label16.Text = "Job Placement ID Number"
        ' 
        ' txtJOBIdFilt
        ' 
        txtJOBIdFilt.Location = New Point(1718, 289)
        txtJOBIdFilt.Name = "txtJOBIdFilt"
        txtJOBIdFilt.PlaceholderText = "#####"
        txtJOBIdFilt.Size = New Size(57, 23)
        txtJOBIdFilt.TabIndex = 150
        ' 
        ' dateDEPdateFilt
        ' 
        dateDEPdateFilt.Format = DateTimePickerFormat.Short
        dateDEPdateFilt.Location = New Point(1676, 332)
        dateDEPdateFilt.Name = "dateDEPdateFilt"
        dateDEPdateFilt.Size = New Size(135, 23)
        dateDEPdateFilt.TabIndex = 153
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(1676, 358)
        Label8.Name = "Label8"
        Label8.Size = New Size(99, 15)
        Label8.TabIndex = 154
        Label8.Text = "Deployment Date"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(1793, 202)
        Label14.Name = "Label14"
        Label14.Size = New Size(36, 15)
        Label14.TabIndex = 157
        Label14.Text = "EMP-"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Location = New Point(1790, 222)
        Label17.Name = "Label17"
        Label17.Size = New Size(118, 15)
        Label17.TabIndex = 156
        Label17.Text = "Employer ID Number"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(1832, 197)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "#####"
        TextBox1.Size = New Size(57, 23)
        TextBox1.TabIndex = 155
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Location = New Point(1796, 249)
        Label18.Name = "Label18"
        Label18.Size = New Size(36, 15)
        Label18.TabIndex = 160
        Label18.Text = "AGC-"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Location = New Point(1793, 269)
        Label19.Name = "Label19"
        Label19.Size = New Size(108, 15)
        Label19.TabIndex = 159
        Label19.Text = "Agency ID Number"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(1835, 244)
        TextBox2.Name = "TextBox2"
        TextBox2.PlaceholderText = "#####"
        TextBox2.Size = New Size(57, 23)
        TextBox2.TabIndex = 158
        ' 
        ' txtDEPFilt
        ' 
        txtDEPFilt.Location = New Point(1676, 379)
        txtDEPFilt.Name = "txtDEPFilt"
        txtDEPFilt.PlaceholderText = "Country"
        txtDEPFilt.Size = New Size(137, 23)
        txtDEPFilt.TabIndex = 128
        ' 
        ' cbxDEPStatusFilt
        ' 
        cbxDEPStatusFilt.FormattingEnabled = True
        cbxDEPStatusFilt.Location = New Point(1676, 424)
        cbxDEPStatusFilt.Name = "cbxDEPStatusFilt"
        cbxDEPStatusFilt.Size = New Size(137, 23)
        cbxDEPStatusFilt.TabIndex = 161
        ' 
        ' dateDEPContractEndFilt
        ' 
        dateDEPContractEndFilt.Format = DateTimePickerFormat.Short
        dateDEPContractEndFilt.Location = New Point(1677, 470)
        dateDEPContractEndFilt.Name = "dateDEPContractEndFilt"
        dateDEPContractEndFilt.Size = New Size(136, 23)
        dateDEPContractEndFilt.TabIndex = 162
        ' 
        ' ADMDashboardDEPTab
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DeepSkyBlue
        ClientSize = New Size(1493, 771)
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
End Class

