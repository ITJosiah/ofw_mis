﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OFWloginPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OFWloginPage))
        imgLogoLoginPg = New PictureBox()
        btnOFWLoginPg = New Button()
        btnAGCLoginPg = New Button()
        btnEMPLoginPg = New Button()
        btnCloseLoginPg = New Button()
        Label1 = New Label()
        txtbxOFWIdLogin = New TextBox()
        btnOkOFWLoginPg = New Button()
        imgLoginPg = New PictureBox()
        Label2 = New Label()
        LinkOFWSignIn = New LinkLabel()
        CType(imgLogoLoginPg, ComponentModel.ISupportInitialize).BeginInit()
        CType(imgLoginPg, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' imgLogoLoginPg
        ' 
        imgLogoLoginPg.Image = My.Resources.Resources.Untitled_design__7_
        imgLogoLoginPg.Location = New Point(937, 265)
        imgLogoLoginPg.Margin = New Padding(4, 4, 4, 4)
        imgLogoLoginPg.Name = "imgLogoLoginPg"
        imgLogoLoginPg.Size = New Size(487, 519)
        imgLogoLoginPg.TabIndex = 1
        imgLogoLoginPg.TabStop = False
        ' 
        ' btnOFWLoginPg
        ' 
        btnOFWLoginPg.BackColor = Color.FromArgb(CByte(7), CByte(30), CByte(34))
        btnOFWLoginPg.FlatStyle = FlatStyle.Popup
        btnOFWLoginPg.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnOFWLoginPg.ForeColor = Color.FromArgb(CByte(29), CByte(120), CByte(116))
        btnOFWLoginPg.Location = New Point(820, 764)
        btnOFWLoginPg.Margin = New Padding(4, 4, 4, 4)
        btnOFWLoginPg.Name = "btnOFWLoginPg"
        btnOFWLoginPg.Size = New Size(211, 78)
        btnOFWLoginPg.TabIndex = 2
        btnOFWLoginPg.Text = "OFW"
        btnOFWLoginPg.UseVisualStyleBackColor = False
        ' 
        ' btnAGCLoginPg
        ' 
        btnAGCLoginPg.BackColor = Color.FromArgb(CByte(7), CByte(30), CByte(34))
        btnAGCLoginPg.FlatStyle = FlatStyle.Popup
        btnAGCLoginPg.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold)
        btnAGCLoginPg.ForeColor = Color.FromArgb(CByte(29), CByte(120), CByte(116))
        btnAGCLoginPg.Location = New Point(1092, 764)
        btnAGCLoginPg.Margin = New Padding(4, 4, 4, 4)
        btnAGCLoginPg.Name = "btnAGCLoginPg"
        btnAGCLoginPg.Size = New Size(211, 78)
        btnAGCLoginPg.TabIndex = 3
        btnAGCLoginPg.Text = "AGENCY"
        btnAGCLoginPg.UseVisualStyleBackColor = False
        ' 
        ' btnEMPLoginPg
        ' 
        btnEMPLoginPg.BackColor = Color.FromArgb(CByte(7), CByte(30), CByte(34))
        btnEMPLoginPg.FlatStyle = FlatStyle.Popup
        btnEMPLoginPg.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold)
        btnEMPLoginPg.ForeColor = Color.FromArgb(CByte(29), CByte(120), CByte(116))
        btnEMPLoginPg.Location = New Point(1363, 764)
        btnEMPLoginPg.Margin = New Padding(4, 4, 4, 4)
        btnEMPLoginPg.Name = "btnEMPLoginPg"
        btnEMPLoginPg.Size = New Size(211, 78)
        btnEMPLoginPg.TabIndex = 4
        btnEMPLoginPg.Text = "EMPLOYER"
        btnEMPLoginPg.UseVisualStyleBackColor = False
        ' 
        ' btnCloseLoginPg
        ' 
        btnCloseLoginPg.BackColor = Color.Crimson
        btnCloseLoginPg.FlatStyle = FlatStyle.Popup
        btnCloseLoginPg.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCloseLoginPg.ForeColor = Color.DeepSkyBlue
        btnCloseLoginPg.Location = New Point(1643, 17)
        btnCloseLoginPg.Margin = New Padding(4, 4, 4, 4)
        btnCloseLoginPg.Name = "btnCloseLoginPg"
        btnCloseLoginPg.Size = New Size(90, 56)
        btnCloseLoginPg.TabIndex = 5
        btnCloseLoginPg.Text = "CLOSE"
        btnCloseLoginPg.UseVisualStyleBackColor = False
        ' 

        '' btnADMLoginPg
        '' 
        'btnADMLoginPg.BackColor = Color.Transparent
        'btnADMLoginPg.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        'btnADMLoginPg.ForeColor = Color.DeepSkyBlue
        'btnADMLoginPg.Location = New Point(15, 1016)
        'btnADMLoginPg.Margin = New Padding(4, 4, 4, 4)
        'btnADMLoginPg.Name = "btnADMLoginPg"
        'btnADMLoginPg.Size = New Size(131, 42)
        'btnADMLoginPg.TabIndex = 6
        'btnADMLoginPg.Text = "Admin Login"
        'btnADMLoginPg.UseVisualStyleBackColor = False
        ' 

        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(1059, 462)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(287, 29)
        Label1.TabIndex = 7
        Label1.Text = "Please enter your User ID"
        ' 
        ' txtbxOFWIdLogin
        ' 
        txtbxOFWIdLogin.Font = New Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtbxOFWIdLogin.Location = New Point(1115, 500)
        txtbxOFWIdLogin.Margin = New Padding(4, 4, 4, 4)
        txtbxOFWIdLogin.Name = "txtbxOFWIdLogin"
        txtbxOFWIdLogin.PlaceholderText = "OFW-#####"
        txtbxOFWIdLogin.Size = New Size(158, 35)
        txtbxOFWIdLogin.TabIndex = 8
        ' 
        ' btnOkOFWLoginPg
        ' 
        btnOkOFWLoginPg.FlatStyle = FlatStyle.Popup
        btnOkOFWLoginPg.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnOkOFWLoginPg.Location = New Point(1171, 549)
        btnOkOFWLoginPg.Margin = New Padding(4, 4, 4, 4)
        btnOkOFWLoginPg.Name = "btnOkOFWLoginPg"
        btnOkOFWLoginPg.Size = New Size(53, 39)
        btnOkOFWLoginPg.TabIndex = 9
        btnOkOFWLoginPg.Text = "OK"
        btnOkOFWLoginPg.UseVisualStyleBackColor = True
        ' 
        ' imgLoginPg
        ' 
        imgLoginPg.Image = CType(resources.GetObject("imgLoginPg.Image"), Image)
        imgLoginPg.Location = New Point(0, 0)
        imgLoginPg.Margin = New Padding(4, 4, 4, 4)
        imgLoginPg.Name = "imgLoginPg"
        imgLoginPg.Size = New Size(860, 1074)
        imgLoginPg.TabIndex = 0
        imgLoginPg.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(1059, 608)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(187, 20)
        Label2.TabIndex = 22
        Label2.Text = "Don't have an account yet?"
        ' 
        ' LinkOFWSignIn
        ' 
        LinkOFWSignIn.AutoSize = True
        LinkOFWSignIn.Location = New Point(1260, 608)
        LinkOFWSignIn.Margin = New Padding(4, 0, 4, 0)
        LinkOFWSignIn.Name = "LinkOFWSignIn"
        LinkOFWSignIn.Size = New Size(58, 21)
        LinkOFWSignIn.TabIndex = 23
        LinkOFWSignIn.TabStop = True
        LinkOFWSignIn.Text = "Sign In"
        ' 
        ' OFWloginPage
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DeepSkyBlue
        ClientSize = New Size(1756, 1075)
        Controls.Add(LinkOFWSignIn)
        Controls.Add(Label2)
        Controls.Add(btnOkOFWLoginPg)
        Controls.Add(txtbxOFWIdLogin)
        Controls.Add(Label1)
        Controls.Add(btnCloseLoginPg)
        Controls.Add(btnEMPLoginPg)
        Controls.Add(btnAGCLoginPg)
        Controls.Add(btnOFWLoginPg)
        Controls.Add(imgLogoLoginPg)
        Controls.Add(imgLoginPg)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 4, 4, 4)
        Name = "OFWloginPage"
        StartPosition = FormStartPosition.CenterScreen
        Text = "loginPage"
        WindowState = FormWindowState.Maximized
        CType(imgLogoLoginPg, ComponentModel.ISupportInitialize).EndInit()
        CType(imgLoginPg, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents imgLogoLoginPg As PictureBox
    Friend WithEvents btnOFWLoginPg As Button
    Friend WithEvents btnAGCLoginPg As Button
    Friend WithEvents btnEMPLoginPg As Button
    Friend WithEvents btnCloseLoginPg As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtbxOFWIdLogin As TextBox
    Friend WithEvents btnOkOFWLoginPg As Button
    Friend WithEvents imgLoginPg As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents LinkOFWSignIn As LinkLabel
End Class
