<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AGENCYLoginPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AGENCYLoginPage))
        Label2 = New Label()
        LinkLabel1 = New LinkLabel()
        btnOkOFWLoginPg = New Button()
        txtbxOFWIdLogin = New TextBox()
        Label1 = New Label()
        btnADMLoginPg = New Button()
        btnCloseLoginPg = New Button()
        btnEMPLoginPg = New Button()
        btnAGCLoginPg = New Button()
        btnOFWLoginPg = New Button()
        imgLogoLoginPg = New PictureBox()
        imgLoginPg = New PictureBox()
        CType(imgLogoLoginPg, ComponentModel.ISupportInitialize).BeginInit()
        CType(imgLoginPg, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(830, 434)
        Label2.Name = "Label2"
        Label2.Size = New Size(150, 15)
        Label2.TabIndex = 33
        Label2.Text = "Don't have an account yet?"
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Location = New Point(986, 434)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(43, 15)
        LinkLabel1.TabIndex = 32
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Sign In"
        ' 
        ' btnOkOFWLoginPg
        ' 
        btnOkOFWLoginPg.FlatStyle = FlatStyle.Popup
        btnOkOFWLoginPg.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnOkOFWLoginPg.Location = New Point(920, 391)
        btnOkOFWLoginPg.Name = "btnOkOFWLoginPg"
        btnOkOFWLoginPg.Size = New Size(41, 28)
        btnOkOFWLoginPg.TabIndex = 31
        btnOkOFWLoginPg.Text = "OK"
        btnOkOFWLoginPg.UseVisualStyleBackColor = True
        ' 
        ' txtbxOFWIdLogin
        ' 
        txtbxOFWIdLogin.Font = New Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtbxOFWIdLogin.Location = New Point(867, 356)
        txtbxOFWIdLogin.Name = "txtbxOFWIdLogin"
        txtbxOFWIdLogin.PlaceholderText = "AGENCY-#####"
        txtbxOFWIdLogin.Size = New Size(146, 29)
        txtbxOFWIdLogin.TabIndex = 30
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(819, 329)
        Label1.Name = "Label1"
        Label1.Size = New Size(249, 24)
        Label1.TabIndex = 29
        Label1.Text = "Please enter your Agency ID"
        ' 
        ' btnADMLoginPg
        ' 
        btnADMLoginPg.BackColor = Color.Transparent
        btnADMLoginPg.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        btnADMLoginPg.ForeColor = Color.DeepSkyBlue
        btnADMLoginPg.Location = New Point(21, 725)
        btnADMLoginPg.Name = "btnADMLoginPg"
        btnADMLoginPg.Size = New Size(102, 30)
        btnADMLoginPg.TabIndex = 28
        btnADMLoginPg.Text = "Admin Login"
        btnADMLoginPg.UseVisualStyleBackColor = False
        ' 
        ' btnCloseLoginPg
        ' 
        btnCloseLoginPg.BackColor = Color.Crimson
        btnCloseLoginPg.FlatStyle = FlatStyle.Popup
        btnCloseLoginPg.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCloseLoginPg.ForeColor = Color.DeepSkyBlue
        btnCloseLoginPg.Location = New Point(1287, 11)
        btnCloseLoginPg.Name = "btnCloseLoginPg"
        btnCloseLoginPg.Size = New Size(70, 40)
        btnCloseLoginPg.TabIndex = 27
        btnCloseLoginPg.Text = "CLOSE"
        btnCloseLoginPg.UseVisualStyleBackColor = False
        ' 
        ' btnEMPLoginPg
        ' 
        btnEMPLoginPg.BackColor = Color.FromArgb(CByte(7), CByte(30), CByte(34))
        btnEMPLoginPg.FlatStyle = FlatStyle.Popup
        btnEMPLoginPg.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold)
        btnEMPLoginPg.ForeColor = Color.FromArgb(CByte(29), CByte(120), CByte(116))
        btnEMPLoginPg.Location = New Point(1069, 545)
        btnEMPLoginPg.Name = "btnEMPLoginPg"
        btnEMPLoginPg.Size = New Size(164, 56)
        btnEMPLoginPg.TabIndex = 26
        btnEMPLoginPg.Text = "EMPLOYER"
        btnEMPLoginPg.UseVisualStyleBackColor = False
        ' 
        ' btnAGCLoginPg
        ' 
        btnAGCLoginPg.BackColor = Color.FromArgb(CByte(7), CByte(30), CByte(34))
        btnAGCLoginPg.FlatStyle = FlatStyle.Popup
        btnAGCLoginPg.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold)
        btnAGCLoginPg.ForeColor = Color.FromArgb(CByte(29), CByte(120), CByte(116))
        btnAGCLoginPg.Location = New Point(858, 545)
        btnAGCLoginPg.Name = "btnAGCLoginPg"
        btnAGCLoginPg.Size = New Size(164, 56)
        btnAGCLoginPg.TabIndex = 25
        btnAGCLoginPg.Text = "AGENCY"
        btnAGCLoginPg.UseVisualStyleBackColor = False
        ' 
        ' btnOFWLoginPg
        ' 
        btnOFWLoginPg.BackColor = Color.FromArgb(CByte(7), CByte(30), CByte(34))
        btnOFWLoginPg.FlatStyle = FlatStyle.Popup
        btnOFWLoginPg.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnOFWLoginPg.ForeColor = Color.FromArgb(CByte(29), CByte(120), CByte(116))
        btnOFWLoginPg.Location = New Point(647, 545)
        btnOFWLoginPg.Name = "btnOFWLoginPg"
        btnOFWLoginPg.Size = New Size(164, 56)
        btnOFWLoginPg.TabIndex = 24
        btnOFWLoginPg.Text = "OFW"
        btnOFWLoginPg.UseVisualStyleBackColor = False
        ' 
        ' imgLogoLoginPg
        ' 
        imgLogoLoginPg.Image = My.Resources.Resources.Untitled_design__7_
        imgLogoLoginPg.Location = New Point(738, 188)
        imgLogoLoginPg.Name = "imgLogoLoginPg"
        imgLogoLoginPg.Size = New Size(379, 371)
        imgLogoLoginPg.TabIndex = 23
        imgLogoLoginPg.TabStop = False
        ' 
        ' imgLoginPg
        ' 
        imgLoginPg.Image = CType(resources.GetObject("imgLoginPg.Image"), Image)
        imgLoginPg.Location = New Point(0, -1)
        imgLoginPg.Name = "imgLoginPg"
        imgLoginPg.Size = New Size(669, 771)
        imgLoginPg.TabIndex = 22
        imgLoginPg.TabStop = False
        ' 
        ' AGENCYLoginPage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DeepSkyBlue
        ClientSize = New Size(1366, 768)
        Controls.Add(Label2)
        Controls.Add(LinkLabel1)
        Controls.Add(btnOkOFWLoginPg)
        Controls.Add(txtbxOFWIdLogin)
        Controls.Add(Label1)
        Controls.Add(btnADMLoginPg)
        Controls.Add(btnCloseLoginPg)
        Controls.Add(btnEMPLoginPg)
        Controls.Add(btnAGCLoginPg)
        Controls.Add(btnOFWLoginPg)
        Controls.Add(imgLogoLoginPg)
        Controls.Add(imgLoginPg)
        FormBorderStyle = FormBorderStyle.None
        Name = "AGENCYLoginPage"
        StartPosition = FormStartPosition.CenterScreen
        Text = "AGENYLoginPage"
        WindowState = FormWindowState.Maximized
        CType(imgLogoLoginPg, ComponentModel.ISupportInitialize).EndInit()
        CType(imgLoginPg, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents btnOkOFWLoginPg As Button
    Friend WithEvents txtbxOFWIdLogin As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnADMLoginPg As Button
    Friend WithEvents btnCloseLoginPg As Button
    Friend WithEvents btnEMPLoginPg As Button
    Friend WithEvents btnAGCLoginPg As Button
    Friend WithEvents btnOFWLoginPg As Button
    Friend WithEvents imgLogoLoginPg As PictureBox
    Friend WithEvents imgLoginPg As PictureBox
End Class
