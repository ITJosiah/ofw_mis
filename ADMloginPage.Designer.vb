<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ADMloginPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ADMloginPage))
        btnADMLoginPg = New Button()
        btnCloseLoginPg = New Button()
        btnEMPLoginPg = New Button()
        btnAGCLoginPg = New Button()
        btnOFWLoginPg = New Button()
        imgLogoLoginPg = New PictureBox()
        imgLoginPg = New PictureBox()
        Label1 = New Label()
        txtbxADMUserLoginPg = New TextBox()
        Label2 = New Label()
        txtbxADMPassLoginPg = New TextBox()
        btnLoginADMLoginPg = New Button()
        CType(imgLogoLoginPg, ComponentModel.ISupportInitialize).BeginInit()
        CType(imgLoginPg, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnADMLoginPg
        ' 
        btnADMLoginPg.BackColor = Color.Transparent
        btnADMLoginPg.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        btnADMLoginPg.ForeColor = Color.DeepSkyBlue
        btnADMLoginPg.Location = New Point(12, 733)
        btnADMLoginPg.Name = "btnADMLoginPg"
        btnADMLoginPg.Size = New Size(95, 23)
        btnADMLoginPg.TabIndex = 16
        btnADMLoginPg.Text = "Admin Login"
        btnADMLoginPg.UseVisualStyleBackColor = False
        ' 
        ' btnCloseLoginPg
        ' 
        btnCloseLoginPg.BackColor = Color.Crimson
        btnCloseLoginPg.FlatStyle = FlatStyle.Popup
        btnCloseLoginPg.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCloseLoginPg.ForeColor = Color.DeepSkyBlue
        btnCloseLoginPg.Location = New Point(1278, 12)
        btnCloseLoginPg.Name = "btnCloseLoginPg"
        btnCloseLoginPg.Size = New Size(70, 40)
        btnCloseLoginPg.TabIndex = 15
        btnCloseLoginPg.Text = "CLOSE"
        btnCloseLoginPg.UseVisualStyleBackColor = False
        ' 
        ' btnEMPLoginPg
        ' 
        btnEMPLoginPg.BackColor = Color.FromArgb(CByte(7), CByte(30), CByte(34))
        btnEMPLoginPg.FlatStyle = FlatStyle.Popup
        btnEMPLoginPg.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold)
        btnEMPLoginPg.ForeColor = Color.FromArgb(CByte(29), CByte(120), CByte(116))
        btnEMPLoginPg.Location = New Point(1030, 520)
        btnEMPLoginPg.Name = "btnEMPLoginPg"
        btnEMPLoginPg.Size = New Size(164, 56)
        btnEMPLoginPg.TabIndex = 14
        btnEMPLoginPg.Text = "EMPLOYER"
        btnEMPLoginPg.UseVisualStyleBackColor = False
        ' 
        ' btnAGCLoginPg
        ' 
        btnAGCLoginPg.BackColor = Color.FromArgb(CByte(7), CByte(30), CByte(34))
        btnAGCLoginPg.FlatStyle = FlatStyle.Popup
        btnAGCLoginPg.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold)
        btnAGCLoginPg.ForeColor = Color.FromArgb(CByte(29), CByte(120), CByte(116))
        btnAGCLoginPg.Location = New Point(819, 520)
        btnAGCLoginPg.Name = "btnAGCLoginPg"
        btnAGCLoginPg.Size = New Size(164, 56)
        btnAGCLoginPg.TabIndex = 13
        btnAGCLoginPg.Text = "AGENCY"
        btnAGCLoginPg.UseVisualStyleBackColor = False
        ' 
        ' btnOFWLoginPg
        ' 
        btnOFWLoginPg.BackColor = Color.FromArgb(CByte(7), CByte(30), CByte(34))
        btnOFWLoginPg.FlatStyle = FlatStyle.Popup
        btnOFWLoginPg.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnOFWLoginPg.ForeColor = Color.FromArgb(CByte(29), CByte(120), CByte(116))
        btnOFWLoginPg.Location = New Point(608, 520)
        btnOFWLoginPg.Name = "btnOFWLoginPg"
        btnOFWLoginPg.Size = New Size(164, 56)
        btnOFWLoginPg.TabIndex = 12
        btnOFWLoginPg.Text = "OFW"
        btnOFWLoginPg.UseVisualStyleBackColor = False
        ' 
        ' imgLogoLoginPg
        ' 
        imgLogoLoginPg.Image = My.Resources.Resources.Untitled_design__7_
        imgLogoLoginPg.Location = New Point(699, 163)
        imgLogoLoginPg.Name = "imgLogoLoginPg"
        imgLogoLoginPg.Size = New Size(379, 371)
        imgLogoLoginPg.TabIndex = 11
        imgLogoLoginPg.TabStop = False
        ' 
        ' imgLoginPg
        ' 
        imgLoginPg.Image = CType(resources.GetObject("imgLoginPg.Image"), Image)
        imgLoginPg.Location = New Point(0, -1)
        imgLoginPg.Name = "imgLoginPg"
        imgLoginPg.Size = New Size(668, 769)
        imgLoginPg.TabIndex = 10
        imgLoginPg.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(759, 237)
        Label1.Name = "Label1"
        Label1.Size = New Size(102, 24)
        Label1.TabIndex = 17
        Label1.Text = "Username:"
        ' 
        ' txtbxADMUserLoginPg
        ' 
        txtbxADMUserLoginPg.Font = New Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtbxADMUserLoginPg.Location = New Point(759, 264)
        txtbxADMUserLoginPg.Name = "txtbxADMUserLoginPg"
        txtbxADMUserLoginPg.Size = New Size(261, 29)
        txtbxADMUserLoginPg.TabIndex = 18
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(759, 305)
        Label2.Name = "Label2"
        Label2.Size = New Size(97, 24)
        Label2.TabIndex = 19
        Label2.Text = "Password:"
        ' 
        ' txtbxADMPassLoginPg
        ' 
        txtbxADMPassLoginPg.Font = New Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtbxADMPassLoginPg.Location = New Point(759, 332)
        txtbxADMPassLoginPg.Name = "txtbxADMPassLoginPg"
        txtbxADMPassLoginPg.Size = New Size(261, 29)
        txtbxADMPassLoginPg.TabIndex = 20
        txtbxADMPassLoginPg.UseSystemPasswordChar = True
        ' 
        ' btnLoginADMLoginPg
        ' 
        btnLoginADMLoginPg.FlatStyle = FlatStyle.Popup
        btnLoginADMLoginPg.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnLoginADMLoginPg.Location = New Point(950, 388)
        btnLoginADMLoginPg.Name = "btnLoginADMLoginPg"
        btnLoginADMLoginPg.Size = New Size(70, 28)
        btnLoginADMLoginPg.TabIndex = 21
        btnLoginADMLoginPg.Text = "Login"
        btnLoginADMLoginPg.UseVisualStyleBackColor = True
        ' 
        ' ADMloginPage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DeepSkyBlue
        ClientSize = New Size(1366, 768)
        Controls.Add(btnLoginADMLoginPg)
        Controls.Add(txtbxADMPassLoginPg)
        Controls.Add(Label2)
        Controls.Add(txtbxADMUserLoginPg)
        Controls.Add(Label1)
        Controls.Add(btnADMLoginPg)
        Controls.Add(btnCloseLoginPg)
        Controls.Add(btnEMPLoginPg)
        Controls.Add(btnAGCLoginPg)
        Controls.Add(btnOFWLoginPg)
        Controls.Add(imgLogoLoginPg)
        Controls.Add(imgLoginPg)
        FormBorderStyle = FormBorderStyle.None
        Name = "ADMloginPage"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ADMloginPage"
        WindowState = FormWindowState.Maximized
        CType(imgLogoLoginPg, ComponentModel.ISupportInitialize).EndInit()
        CType(imgLoginPg, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnADMLoginPg As Button
    Friend WithEvents btnCloseLoginPg As Button
    Friend WithEvents btnEMPLoginPg As Button
    Friend WithEvents btnAGCLoginPg As Button
    Friend WithEvents btnOFWLoginPg As Button
    Friend WithEvents imgLogoLoginPg As PictureBox
    Friend WithEvents imgLoginPg As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtbxADMUserLoginPg As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtbxADMPassLoginPg As TextBox
    Friend WithEvents btnLoginADMLoginPg As Button
End Class
