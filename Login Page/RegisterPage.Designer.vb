<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registerform
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(registerform))
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        registerart = New Guna.UI2.WinForms.Guna2PictureBox()
        link_signin = New LinkLabel()
        btn_next1 = New Guna.UI2.WinForms.Guna2Button()
        txt_lastname = New Guna.UI2.WinForms.Guna2TextBox()
        txt_firstname = New Guna.UI2.WinForms.Guna2TextBox()
        Label2 = New Label()
        txtRegisterPlaceholder = New Label()
        txtRegisterText = New Label()
        Guna2ComboBox1 = New Guna.UI2.WinForms.Guna2ComboBox()
        CType(registerart, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' registerart
        ' 
        registerart.BackColor = Color.Transparent
        registerart.BackgroundImage = CType(resources.GetObject("registerart.BackgroundImage"), Image)
        registerart.CustomizableEdges = CustomizableEdges1
        registerart.FillColor = Color.Transparent
        registerart.Image = CType(resources.GetObject("registerart.Image"), Image)
        registerart.ImageRotate = 0F
        registerart.Location = New Point(466, -19)
        registerart.Name = "registerart"
        registerart.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        registerart.Size = New Size(731, 650)
        registerart.SizeMode = PictureBoxSizeMode.StretchImage
        registerart.TabIndex = 0
        registerart.TabStop = False
        ' 
        ' link_signin
        ' 
        link_signin.ActiveLinkColor = Color.Lime
        link_signin.AutoSize = True
        link_signin.BackColor = Color.Transparent
        link_signin.Font = New Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point)
        link_signin.LinkColor = Color.Lime
        link_signin.Location = New Point(248, 490)
        link_signin.Name = "link_signin"
        link_signin.Size = New Size(51, 17)
        link_signin.TabIndex = 13
        link_signin.TabStop = True
        link_signin.Text = "Sign in"
        ' 
        ' btn_next1
        ' 
        btn_next1.BorderRadius = 8
        btn_next1.CustomizableEdges = CustomizableEdges3
        btn_next1.DisabledState.BorderColor = Color.DarkGray
        btn_next1.DisabledState.CustomBorderColor = Color.DarkGray
        btn_next1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btn_next1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btn_next1.FillColor = Color.Lime
        btn_next1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btn_next1.ForeColor = Color.White
        btn_next1.Location = New Point(50, 422)
        btn_next1.Name = "btn_next1"
        btn_next1.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btn_next1.Size = New Size(250, 45)
        btn_next1.TabIndex = 12
        btn_next1.Text = "Next"
        btn_next1.TextOffset = New Point(0, 2)
        ' 
        ' txt_lastname
        ' 
        txt_lastname.BorderColor = Color.Lime
        txt_lastname.BorderRadius = 8
        txt_lastname.BorderThickness = 2
        txt_lastname.CustomizableEdges = CustomizableEdges5
        txt_lastname.DefaultText = ""
        txt_lastname.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txt_lastname.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txt_lastname.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txt_lastname.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txt_lastname.FocusedState.BorderColor = Color.Lime
        txt_lastname.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point)
        txt_lastname.HoverState.BorderColor = Color.Lime
        txt_lastname.Location = New Point(51, 286)
        txt_lastname.Margin = New Padding(3, 4, 3, 4)
        txt_lastname.Name = "txt_lastname"
        txt_lastname.PasswordChar = ChrW(0)
        txt_lastname.PlaceholderForeColor = SystemColors.ControlDark
        txt_lastname.PlaceholderText = "Enter Last Name"
        txt_lastname.SelectedText = ""
        txt_lastname.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        txt_lastname.Size = New Size(250, 45)
        txt_lastname.TabIndex = 10
        ' 
        ' txt_firstname
        ' 
        txt_firstname.BorderColor = Color.Lime
        txt_firstname.BorderRadius = 8
        txt_firstname.BorderThickness = 2
        txt_firstname.CustomizableEdges = CustomizableEdges7
        txt_firstname.DefaultText = ""
        txt_firstname.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txt_firstname.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txt_firstname.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txt_firstname.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txt_firstname.FocusedState.BorderColor = Color.Lime
        txt_firstname.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point)
        txt_firstname.HoverState.BorderColor = Color.Lime
        txt_firstname.Location = New Point(51, 217)
        txt_firstname.Margin = New Padding(3, 4, 3, 4)
        txt_firstname.Name = "txt_firstname"
        txt_firstname.PasswordChar = ChrW(0)
        txt_firstname.PlaceholderForeColor = SystemColors.ControlDark
        txt_firstname.PlaceholderText = "Enter First Name"
        txt_firstname.SelectedText = ""
        txt_firstname.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        txt_firstname.Size = New Size(250, 45)
        txt_firstname.TabIndex = 9
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.ControlDark
        Label2.Location = New Point(50, 490)
        Label2.Name = "Label2"
        Label2.Size = New Size(202, 17)
        Label2.TabIndex = 8
        Label2.Text = "Already have an account? "
        ' 
        ' txtRegisterPlaceholder
        ' 
        txtRegisterPlaceholder.BackColor = Color.Transparent
        txtRegisterPlaceholder.Font = New Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point)
        txtRegisterPlaceholder.ForeColor = SystemColors.ControlDark
        txtRegisterPlaceholder.Location = New Point(50, 145)
        txtRegisterPlaceholder.Name = "txtRegisterPlaceholder"
        txtRegisterPlaceholder.Size = New Size(299, 25)
        txtRegisterPlaceholder.TabIndex = 15
        txtRegisterPlaceholder.Text = "Register to explore your dashboard"
        ' 
        ' txtRegisterText
        ' 
        txtRegisterText.BackColor = Color.Transparent
        txtRegisterText.Font = New Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point)
        txtRegisterText.Location = New Point(43, 96)
        txtRegisterText.Name = "txtRegisterText"
        txtRegisterText.Size = New Size(326, 49)
        txtRegisterText.TabIndex = 14
        txtRegisterText.Text = "Register yourself"
        ' 
        ' Guna2ComboBox1
        ' 
        Guna2ComboBox1.BackColor = Color.Transparent
        Guna2ComboBox1.BorderColor = Color.Lime
        Guna2ComboBox1.BorderRadius = 8
        Guna2ComboBox1.BorderThickness = 2
        Guna2ComboBox1.CustomizableEdges = CustomizableEdges9
        Guna2ComboBox1.DrawMode = DrawMode.OwnerDrawFixed
        Guna2ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        Guna2ComboBox1.FocusedColor = Color.Lime
        Guna2ComboBox1.FocusedState.BorderColor = Color.Lime
        Guna2ComboBox1.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2ComboBox1.ForeColor = Color.FromArgb(CByte(68), CByte(88), CByte(112))
        Guna2ComboBox1.ItemHeight = 30
        Guna2ComboBox1.Items.AddRange(New Object() {"Male", "Female", "Other"})
        Guna2ComboBox1.Location = New Point(50, 355)
        Guna2ComboBox1.Name = "Guna2ComboBox1"
        Guna2ComboBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        Guna2ComboBox1.Size = New Size(250, 36)
        Guna2ComboBox1.TabIndex = 16
        Guna2ComboBox1.TextOffset = New Point(2, 0)
        ' 
        ' registerform
        ' 
        AutoScaleDimensions = New SizeF(9F, 18F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1185, 624)
        Controls.Add(Guna2ComboBox1)
        Controls.Add(txtRegisterPlaceholder)
        Controls.Add(txtRegisterText)
        Controls.Add(link_signin)
        Controls.Add(btn_next1)
        Controls.Add(txt_lastname)
        Controls.Add(txt_firstname)
        Controls.Add(Label2)
        Controls.Add(registerart)
        Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 4, 3, 4)
        Name = "registerform"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Step 1"
        CType(registerart, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents registerart As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents link_signin As LinkLabel
    Friend WithEvents btn_next1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txt_lastname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_firstname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtRegisterPlaceholder As Label
    Friend WithEvents txtRegisterText As Label
    Friend WithEvents Guna2ComboBox1 As Guna.UI2.WinForms.Guna2ComboBox
End Class
