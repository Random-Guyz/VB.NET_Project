<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class step3
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
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Panel1 = New Panel()
        Label3 = New Label()
        txt_StepCnt = New Label()
        Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        btn_next3 = New Guna.UI2.WinForms.Guna2Button()
        link_signin = New LinkLabel()
        Label2 = New Label()
        txt_confirmPass = New Guna.UI2.WinForms.Guna2TextBox()
        txtStep2 = New Label()
        txt_createPass = New Guna.UI2.WinForms.Guna2TextBox()
        txt_createUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Panel1.SuspendLayout()
        CType(Guna2CirclePictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Lime
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(txt_StepCnt)
        Panel1.Controls.Add(Guna2CirclePictureBox1)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(417, 624)
        Panel1.TabIndex = 39
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.FromArgb(CByte(73), CByte(229), CByte(21))
        Label3.Font = New Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(98, 293)
        Label3.Name = "Label3"
        Label3.Size = New Size(224, 48)
        Label3.TabIndex = 25
        Label3.Text = "Completed"
        ' 
        ' txt_StepCnt
        ' 
        txt_StepCnt.BackColor = Color.FromArgb(CByte(73), CByte(229), CByte(21))
        txt_StepCnt.Font = New Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point)
        txt_StepCnt.ForeColor = Color.White
        txt_StepCnt.Location = New Point(142, 246)
        txt_StepCnt.Name = "txt_StepCnt"
        txt_StepCnt.Size = New Size(140, 48)
        txt_StepCnt.TabIndex = 24
        txt_StepCnt.Text = "Step 2"
        ' 
        ' Guna2CirclePictureBox1
        ' 
        Guna2CirclePictureBox1.FillColor = Color.FromArgb(CByte(73), CByte(229), CByte(21))
        Guna2CirclePictureBox1.ImageRotate = 0F
        Guna2CirclePictureBox1.Location = New Point(26, 124)
        Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Guna2CirclePictureBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges1
        Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Guna2CirclePictureBox1.Size = New Size(360, 360)
        Guna2CirclePictureBox1.TabIndex = 0
        Guna2CirclePictureBox1.TabStop = False
        ' 
        ' btn_next3
        ' 
        btn_next3.BorderRadius = 8
        btn_next3.CustomizableEdges = CustomizableEdges2
        btn_next3.DisabledState.BorderColor = Color.DarkGray
        btn_next3.DisabledState.CustomBorderColor = Color.DarkGray
        btn_next3.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btn_next3.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btn_next3.FillColor = Color.Lime
        btn_next3.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btn_next3.ForeColor = Color.White
        btn_next3.Location = New Point(689, 406)
        btn_next3.Name = "btn_next3"
        btn_next3.ShadowDecoration.CustomizableEdges = CustomizableEdges3
        btn_next3.Size = New Size(250, 45)
        btn_next3.TabIndex = 38
        btn_next3.Text = "Next"
        btn_next3.TextOffset = New Point(0, 2)
        ' 
        ' link_signin
        ' 
        link_signin.ActiveLinkColor = Color.Lime
        link_signin.AutoSize = True
        link_signin.BackColor = Color.Transparent
        link_signin.Font = New Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point)
        link_signin.LinkColor = Color.Lime
        link_signin.Location = New Point(887, 475)
        link_signin.Name = "link_signin"
        link_signin.Size = New Size(51, 17)
        link_signin.TabIndex = 37
        link_signin.TabStop = True
        link_signin.Text = "Sign in"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.ControlDark
        Label2.Location = New Point(689, 475)
        Label2.Name = "Label2"
        Label2.Size = New Size(202, 17)
        Label2.TabIndex = 36
        Label2.Text = "Already have an account? "
        ' 
        ' txt_confirmPass
        ' 
        txt_confirmPass.BorderColor = Color.Lime
        txt_confirmPass.BorderRadius = 8
        txt_confirmPass.BorderThickness = 2
        txt_confirmPass.CustomizableEdges = CustomizableEdges4
        txt_confirmPass.DefaultText = ""
        txt_confirmPass.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txt_confirmPass.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txt_confirmPass.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txt_confirmPass.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txt_confirmPass.FocusedState.BorderColor = Color.Lime
        txt_confirmPass.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point)
        txt_confirmPass.HoverState.BorderColor = Color.Lime
        txt_confirmPass.Location = New Point(689, 333)
        txt_confirmPass.Margin = New Padding(3, 4, 3, 4)
        txt_confirmPass.Name = "txt_confirmPass"
        txt_confirmPass.PasswordChar = ChrW(0)
        txt_confirmPass.PlaceholderForeColor = SystemColors.ControlDark
        txt_confirmPass.PlaceholderText = "Confirm Password"
        txt_confirmPass.SelectedText = ""
        txt_confirmPass.ShadowDecoration.CustomizableEdges = CustomizableEdges5
        txt_confirmPass.Size = New Size(250, 45)
        txt_confirmPass.TabIndex = 35
        ' 
        ' txtStep2
        ' 
        txtStep2.BackColor = Color.Transparent
        txtStep2.Font = New Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point)
        txtStep2.Location = New Point(486, 67)
        txtStep2.Name = "txtStep2"
        txtStep2.Size = New Size(133, 49)
        txtStep2.TabIndex = 34
        txtStep2.Text = "Step 3"
        ' 
        ' txt_createPass
        ' 
        txt_createPass.BorderColor = Color.Lime
        txt_createPass.BorderRadius = 8
        txt_createPass.BorderThickness = 2
        txt_createPass.CustomizableEdges = CustomizableEdges6
        txt_createPass.DefaultText = ""
        txt_createPass.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txt_createPass.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txt_createPass.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txt_createPass.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txt_createPass.FocusedState.BorderColor = Color.Lime
        txt_createPass.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point)
        txt_createPass.HoverState.BorderColor = Color.Lime
        txt_createPass.Location = New Point(689, 263)
        txt_createPass.Margin = New Padding(3, 4, 3, 4)
        txt_createPass.Name = "txt_createPass"
        txt_createPass.PasswordChar = ChrW(0)
        txt_createPass.PlaceholderForeColor = SystemColors.ControlDark
        txt_createPass.PlaceholderText = "Create Password"
        txt_createPass.SelectedText = ""
        txt_createPass.ShadowDecoration.CustomizableEdges = CustomizableEdges7
        txt_createPass.Size = New Size(250, 45)
        txt_createPass.TabIndex = 33
        ' 
        ' txt_createUsername
        ' 
        txt_createUsername.BorderColor = Color.Lime
        txt_createUsername.BorderRadius = 8
        txt_createUsername.BorderThickness = 2
        txt_createUsername.CustomizableEdges = CustomizableEdges8
        txt_createUsername.DefaultText = ""
        txt_createUsername.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txt_createUsername.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txt_createUsername.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txt_createUsername.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txt_createUsername.FocusedState.BorderColor = Color.Lime
        txt_createUsername.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point)
        txt_createUsername.HoverState.BorderColor = Color.Lime
        txt_createUsername.Location = New Point(689, 185)
        txt_createUsername.Margin = New Padding(3, 4, 3, 4)
        txt_createUsername.Name = "txt_createUsername"
        txt_createUsername.PasswordChar = ChrW(0)
        txt_createUsername.PlaceholderForeColor = SystemColors.ControlDark
        txt_createUsername.PlaceholderText = "Create Username"
        txt_createUsername.SelectedText = ""
        txt_createUsername.ShadowDecoration.CustomizableEdges = CustomizableEdges9
        txt_createUsername.Size = New Size(250, 45)
        txt_createUsername.TabIndex = 32
        ' 
        ' step3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1185, 624)
        Controls.Add(Panel1)
        Controls.Add(btn_next3)
        Controls.Add(link_signin)
        Controls.Add(Label2)
        Controls.Add(txt_confirmPass)
        Controls.Add(txtStep2)
        Controls.Add(txt_createPass)
        Controls.Add(txt_createUsername)
        Name = "step3"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Step 3"
        Panel1.ResumeLayout(False)
        CType(Guna2CirclePictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_StepCnt As Label
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents btn_next3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents link_signin As LinkLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_confirmPass As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtStep2 As Label
    Friend WithEvents txt_createPass As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_createUsername As Guna.UI2.WinForms.Guna2TextBox
End Class
