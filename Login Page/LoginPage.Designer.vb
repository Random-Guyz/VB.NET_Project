<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginPage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges13 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges14 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(LoginPage))
        Dim CustomizableEdges15 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges16 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(components)
        Label1 = New Label()
        txt_username = New Guna.UI2.WinForms.Guna2TextBox()
        txt_password = New Guna.UI2.WinForms.Guna2TextBox()
        btn_sign = New Guna.UI2.WinForms.Guna2Button()
        Label3 = New Label()
        LoginArtwork = New Guna.UI2.WinForms.Guna2PictureBox()
        CheckBox1 = New CheckBox()
        CType(LoginArtwork, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(803, 132)
        Label1.Name = "Label1"
        Label1.Size = New Size(198, 49)
        Label1.TabIndex = 1
        Label1.Text = "Welcome!"
        ' 
        ' txt_username
        ' 
        txt_username.BorderColor = Color.Lime
        txt_username.BorderRadius = 8
        txt_username.BorderThickness = 2
        txt_username.CustomizableEdges = CustomizableEdges9
        txt_username.DefaultText = ""
        txt_username.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txt_username.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txt_username.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txt_username.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txt_username.FocusedState.BorderColor = Color.Lime
        txt_username.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txt_username.HoverState.BorderColor = Color.Lime
        txt_username.Location = New Point(812, 234)
        txt_username.Margin = New Padding(3, 4, 3, 4)
        txt_username.Name = "txt_username"
        txt_username.PasswordChar = ChrW(0)
        txt_username.PlaceholderForeColor = SystemColors.ControlDark
        txt_username.PlaceholderText = "Username"
        txt_username.SelectedText = ""
        txt_username.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        txt_username.Size = New Size(250, 45)
        txt_username.TabIndex = 3
        ' 
        ' txt_password
        ' 
        txt_password.BorderColor = Color.Lime
        txt_password.BorderRadius = 8
        txt_password.BorderThickness = 2
        txt_password.CustomizableEdges = CustomizableEdges11
        txt_password.DefaultText = ""
        txt_password.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txt_password.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txt_password.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txt_password.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txt_password.FocusedState.BorderColor = Color.Lime
        txt_password.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txt_password.HoverState.BorderColor = Color.Lime
        txt_password.Location = New Point(812, 298)
        txt_password.Margin = New Padding(3, 4, 3, 4)
        txt_password.Name = "txt_password"
        txt_password.PasswordChar = "●"c
        txt_password.PlaceholderForeColor = SystemColors.ControlDark
        txt_password.PlaceholderText = "Password"
        txt_password.SelectedText = ""
        txt_password.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        txt_password.Size = New Size(250, 45)
        txt_password.TabIndex = 4
        ' 
        ' btn_sign
        ' 
        btn_sign.BorderRadius = 8
        btn_sign.CustomizableEdges = CustomizableEdges13
        btn_sign.DisabledState.BorderColor = Color.DarkGray
        btn_sign.DisabledState.CustomBorderColor = Color.DarkGray
        btn_sign.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btn_sign.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btn_sign.FillColor = Color.Lime
        btn_sign.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btn_sign.ForeColor = Color.White
        btn_sign.Location = New Point(812, 404)
        btn_sign.Name = "btn_sign"
        btn_sign.ShadowDecoration.CustomizableEdges = CustomizableEdges14
        btn_sign.Size = New Size(250, 45)
        btn_sign.TabIndex = 6
        btn_sign.Text = "Sign in"
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.ControlDark
        Label3.Location = New Point(813, 181)
        Label3.Name = "Label3"
        Label3.Size = New Size(144, 25)
        Label3.TabIndex = 8
        Label3.Text = "Sign in to continue"
        ' 
        ' LoginArtwork
        ' 
        LoginArtwork.BackColor = Color.Transparent
        LoginArtwork.BackgroundImage = CType(resources.GetObject("LoginArtwork.BackgroundImage"), Image)
        LoginArtwork.CustomizableEdges = CustomizableEdges15
        LoginArtwork.FillColor = Color.Transparent
        LoginArtwork.ImageRotate = 0F
        LoginArtwork.InitialImage = CType(resources.GetObject("LoginArtwork.InitialImage"), Image)
        LoginArtwork.Location = New Point(-125, -176)
        LoginArtwork.Name = "LoginArtwork"
        LoginArtwork.ShadowDecoration.CustomizableEdges = CustomizableEdges16
        LoginArtwork.Size = New Size(922, 871)
        LoginArtwork.SizeMode = PictureBoxSizeMode.StretchImage
        LoginArtwork.TabIndex = 9
        LoginArtwork.TabStop = False
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.FlatAppearance.BorderSize = 13
        CheckBox1.FlatStyle = FlatStyle.Popup
        CheckBox1.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        CheckBox1.ForeColor = Color.Lime
        CheckBox1.Location = New Point(825, 350)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(132, 22)
        CheckBox1.TabIndex = 13
        CheckBox1.Text = "show password"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' LoginPage
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1185, 624)
        Controls.Add(CheckBox1)
        Controls.Add(Label3)
        Controls.Add(btn_sign)
        Controls.Add(txt_password)
        Controls.Add(txt_username)
        Controls.Add(Label1)
        Controls.Add(LoginArtwork)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "LoginPage"
        StartPosition = FormStartPosition.CenterScreen
        Text = " Login"
        CType(LoginArtwork, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_username As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_password As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btn_sign As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label3 As Label
    Friend WithEvents LoginArtwork As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents CheckBox1 As CheckBox
End Class
