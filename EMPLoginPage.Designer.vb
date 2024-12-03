<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EMPLoginPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EMPLoginPage))
        LinkEMPSignIn = New LinkLabel()
        Label2 = New Label()
        btnOkEMPLoginPg = New Button()
        txtbxEMPIdLogin = New TextBox()
        Label1 = New Label()
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
        ' LinkEMPSignIn
        ' 
        LinkEMPSignIn.AutoSize = True
        LinkEMPSignIn.Location = New Point(1259, 608)
        LinkEMPSignIn.Margin = New Padding(4, 0, 4, 0)
        LinkEMPSignIn.Name = "LinkEMPSignIn"
        LinkEMPSignIn.Size = New Size(58, 21)
        LinkEMPSignIn.TabIndex = 35
        LinkEMPSignIn.TabStop = True
        LinkEMPSignIn.Text = "Sign In"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(1058, 608)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(187, 20)
        Label2.TabIndex = 34
        Label2.Text = "Don't have an account yet?"
        ' 
        ' btnOkEMPLoginPg
        ' 
        btnOkEMPLoginPg.FlatStyle = FlatStyle.Popup
        btnOkEMPLoginPg.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnOkEMPLoginPg.Location = New Point(1170, 549)
        btnOkEMPLoginPg.Margin = New Padding(4, 4, 4, 4)
        btnOkEMPLoginPg.Name = "btnOkEMPLoginPg"
        btnOkEMPLoginPg.Size = New Size(53, 39)
        btnOkEMPLoginPg.TabIndex = 33
        btnOkEMPLoginPg.Text = "OK"
        btnOkEMPLoginPg.UseVisualStyleBackColor = True
        ' 
        ' txtbxEMPIdLogin
        ' 
        txtbxEMPIdLogin.Font = New Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtbxEMPIdLogin.Location = New Point(1081, 500)
        txtbxEMPIdLogin.Margin = New Padding(4, 4, 4, 4)
        txtbxEMPIdLogin.Name = "txtbxEMPIdLogin"
        txtbxEMPIdLogin.PlaceholderText = "EMPLOYER-#####"
        txtbxEMPIdLogin.Size = New Size(219, 35)
        txtbxEMPIdLogin.TabIndex = 32
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(1018, 462)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(339, 29)
        Label1.TabIndex = 31
        Label1.Text = "Please enter your Employer ID"
        ' 

        ' 

        ' btnCloseLoginPg
        ' 
        btnCloseLoginPg.BackColor = Color.Crimson
        btnCloseLoginPg.FlatStyle = FlatStyle.Popup
        btnCloseLoginPg.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCloseLoginPg.ForeColor = Color.DeepSkyBlue
        btnCloseLoginPg.Location = New Point(1642, 17)
        btnCloseLoginPg.Margin = New Padding(4, 4, 4, 4)
        btnCloseLoginPg.Name = "btnCloseLoginPg"
        btnCloseLoginPg.Size = New Size(90, 56)
        btnCloseLoginPg.TabIndex = 29
        btnCloseLoginPg.Text = "CLOSE"
        btnCloseLoginPg.UseVisualStyleBackColor = False
        ' 
        ' btnEMPLoginPg
        ' 
        btnEMPLoginPg.BackColor = Color.FromArgb(CByte(7), CByte(30), CByte(34))
        btnEMPLoginPg.FlatStyle = FlatStyle.Popup
        btnEMPLoginPg.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold)
        btnEMPLoginPg.ForeColor = Color.FromArgb(CByte(29), CByte(120), CByte(116))
        btnEMPLoginPg.Location = New Point(1362, 764)
        btnEMPLoginPg.Margin = New Padding(4, 4, 4, 4)
        btnEMPLoginPg.Name = "btnEMPLoginPg"
        btnEMPLoginPg.Size = New Size(211, 78)
        btnEMPLoginPg.TabIndex = 28
        btnEMPLoginPg.Text = "EMPLOYER"
        btnEMPLoginPg.UseVisualStyleBackColor = False
        ' 
        ' btnAGCLoginPg
        ' 
        btnAGCLoginPg.BackColor = Color.FromArgb(CByte(7), CByte(30), CByte(34))
        btnAGCLoginPg.FlatStyle = FlatStyle.Popup
        btnAGCLoginPg.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold)
        btnAGCLoginPg.ForeColor = Color.FromArgb(CByte(29), CByte(120), CByte(116))
        btnAGCLoginPg.Location = New Point(1090, 764)
        btnAGCLoginPg.Margin = New Padding(4, 4, 4, 4)
        btnAGCLoginPg.Name = "btnAGCLoginPg"
        btnAGCLoginPg.Size = New Size(211, 78)
        btnAGCLoginPg.TabIndex = 27
        btnAGCLoginPg.Text = "AGENCY"
        btnAGCLoginPg.UseVisualStyleBackColor = False
        ' 
        ' btnOFWLoginPg
        ' 
        btnOFWLoginPg.BackColor = Color.FromArgb(CByte(7), CByte(30), CByte(34))
        btnOFWLoginPg.FlatStyle = FlatStyle.Popup
        btnOFWLoginPg.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnOFWLoginPg.ForeColor = Color.FromArgb(CByte(29), CByte(120), CByte(116))
        btnOFWLoginPg.Location = New Point(819, 764)
        btnOFWLoginPg.Margin = New Padding(4, 4, 4, 4)
        btnOFWLoginPg.Name = "btnOFWLoginPg"
        btnOFWLoginPg.Size = New Size(211, 78)
        btnOFWLoginPg.TabIndex = 26
        btnOFWLoginPg.Text = "OFW"
        btnOFWLoginPg.UseVisualStyleBackColor = False
        ' 
        ' imgLogoLoginPg
        ' 
        imgLogoLoginPg.Image = My.Resources.Resources.Untitled_design__7_
        imgLogoLoginPg.Location = New Point(936, 265)
        imgLogoLoginPg.Margin = New Padding(4, 4, 4, 4)
        imgLogoLoginPg.Name = "imgLogoLoginPg"
        imgLogoLoginPg.Size = New Size(487, 519)
        imgLogoLoginPg.TabIndex = 25
        imgLogoLoginPg.TabStop = False
        ' 
        ' imgLoginPg
        ' 
        imgLoginPg.Image = CType(resources.GetObject("imgLoginPg.Image"), Image)
        imgLoginPg.Location = New Point(-1, 0)
        imgLoginPg.Margin = New Padding(4, 4, 4, 4)
        imgLoginPg.Name = "imgLoginPg"
        imgLoginPg.Size = New Size(860, 1074)
        imgLoginPg.TabIndex = 24
        imgLoginPg.TabStop = False
        ' 
        ' EMPLoginPage
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DeepSkyBlue
        ClientSize = New Size(1756, 1075)
        Controls.Add(LinkEMPSignIn)
        Controls.Add(Label2)
        Controls.Add(btnOkEMPLoginPg)
        Controls.Add(txtbxEMPIdLogin)
        Controls.Add(Label1)
        Controls.Add(btnCloseLoginPg)
        Controls.Add(btnEMPLoginPg)
        Controls.Add(btnAGCLoginPg)
        Controls.Add(btnOFWLoginPg)
        Controls.Add(imgLogoLoginPg)
        Controls.Add(imgLoginPg)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 4, 4, 4)
        Name = "EMPLoginPage"
        StartPosition = FormStartPosition.CenterScreen
        Text = "EMPLoginPage"
        WindowState = FormWindowState.Maximized
        CType(imgLogoLoginPg, ComponentModel.ISupportInitialize).EndInit()
        CType(imgLoginPg, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LinkEMPSignIn As LinkLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents btnOkEMPLoginPg As Button
    Friend WithEvents txtbxEMPIdLogin As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCloseLoginPg As Button
    Friend WithEvents btnEMPLoginPg As Button
    Friend WithEvents btnAGCLoginPg As Button
    Friend WithEvents btnOFWLoginPg As Button
    Friend WithEvents imgLogoLoginPg As PictureBox
    Friend WithEvents imgLoginPg As PictureBox
End Class
