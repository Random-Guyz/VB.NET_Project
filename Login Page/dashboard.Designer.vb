<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dashboard
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(dashboard))
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        btn_teacher = New Guna.UI2.WinForms.Guna2Button()
        panel_Menu = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        btn_Fees = New Guna.UI2.WinForms.Guna2Button()
        btn_student = New Guna.UI2.WinForms.Guna2Button()
        btn_dashboard = New Guna.UI2.WinForms.Guna2Button()
        btn_signout = New Guna.UI2.WinForms.Guna2Button()
        panel_student = New Guna.UI2.WinForms.Guna2ShadowPanel()
        d1 = New Label()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        d3 = New Label()
        PictureBox2 = New PictureBox()
        Label3 = New Label()
        Guna2ShadowPanel2 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        d2 = New Label()
        PictureBox3 = New PictureBox()
        Label4 = New Label()
        Guna2ShadowPanel3 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        d4 = New Label()
        PictureBox4 = New PictureBox()
        Label6 = New Label()
        Label2 = New Label()
        panel_Menu.SuspendLayout()
        CType(Guna2PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        panel_student.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Guna2ShadowPanel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Guna2ShadowPanel2.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Guna2ShadowPanel3.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btn_teacher
        ' 
        btn_teacher.BorderRadius = 8
        btn_teacher.CustomizableEdges = CustomizableEdges1
        btn_teacher.DisabledState.BorderColor = Color.DarkGray
        btn_teacher.DisabledState.CustomBorderColor = Color.DarkGray
        btn_teacher.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btn_teacher.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btn_teacher.FillColor = Color.White
        btn_teacher.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btn_teacher.ForeColor = Color.Gray
        btn_teacher.Image = CType(resources.GetObject("btn_teacher.Image"), Image)
        btn_teacher.ImageAlign = HorizontalAlignment.Left
        btn_teacher.ImageOffset = New Point(5, 0)
        btn_teacher.ImageSize = New Size(30, 30)
        btn_teacher.Location = New Point(22, 445)
        btn_teacher.Margin = New Padding(3, 4, 3, 4)
        btn_teacher.Name = "btn_teacher"
        btn_teacher.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btn_teacher.Size = New Size(213, 52)
        btn_teacher.TabIndex = 60
        btn_teacher.Text = "Teacher"
        btn_teacher.TextOffset = New Point(0, 2)
        ' 
        ' panel_Menu
        ' 
        panel_Menu.BackColor = Color.Transparent
        panel_Menu.Controls.Add(btn_teacher)
        panel_Menu.Controls.Add(Guna2PictureBox1)
        panel_Menu.Controls.Add(btn_Fees)
        panel_Menu.Controls.Add(btn_student)
        panel_Menu.Controls.Add(btn_dashboard)
        panel_Menu.Controls.Add(btn_signout)
        panel_Menu.Dock = DockStyle.Left
        panel_Menu.FillColor = Color.White
        panel_Menu.Location = New Point(0, 0)
        panel_Menu.Name = "panel_Menu"
        panel_Menu.ShadowColor = Color.DimGray
        panel_Menu.ShadowDepth = 30
        panel_Menu.ShadowShift = 10
        panel_Menu.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal
        panel_Menu.Size = New Size(274, 835)
        panel_Menu.TabIndex = 96
        ' 
        ' Guna2PictureBox1
        ' 
        Guna2PictureBox1.CustomizableEdges = CustomizableEdges3
        Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), Image)
        Guna2PictureBox1.ImageRotate = 0F
        Guna2PictureBox1.Location = New Point(32, 35)
        Guna2PictureBox1.Name = "Guna2PictureBox1"
        Guna2PictureBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2PictureBox1.Size = New Size(201, 201)
        Guna2PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        Guna2PictureBox1.TabIndex = 59
        Guna2PictureBox1.TabStop = False
        ' 
        ' btn_Fees
        ' 
        btn_Fees.BorderRadius = 8
        btn_Fees.CustomizableEdges = CustomizableEdges5
        btn_Fees.DisabledState.BorderColor = Color.DarkGray
        btn_Fees.DisabledState.CustomBorderColor = Color.DarkGray
        btn_Fees.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btn_Fees.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btn_Fees.FillColor = Color.White
        btn_Fees.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btn_Fees.ForeColor = Color.Gray
        btn_Fees.Image = CType(resources.GetObject("btn_Fees.Image"), Image)
        btn_Fees.ImageAlign = HorizontalAlignment.Left
        btn_Fees.ImageOffset = New Point(5, 0)
        btn_Fees.ImageSize = New Size(30, 30)
        btn_Fees.Location = New Point(22, 517)
        btn_Fees.Margin = New Padding(3, 4, 3, 4)
        btn_Fees.Name = "btn_Fees"
        btn_Fees.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        btn_Fees.Size = New Size(213, 52)
        btn_Fees.TabIndex = 58
        btn_Fees.Text = "   Fees"
        btn_Fees.TextAlign = HorizontalAlignment.Left
        btn_Fees.TextOffset = New Point(0, 2)
        ' 
        ' btn_student
        ' 
        btn_student.BorderRadius = 8
        btn_student.CustomizableEdges = CustomizableEdges7
        btn_student.DisabledState.BorderColor = Color.DarkGray
        btn_student.DisabledState.CustomBorderColor = Color.DarkGray
        btn_student.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btn_student.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btn_student.FillColor = Color.White
        btn_student.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btn_student.ForeColor = Color.Gray
        btn_student.Image = CType(resources.GetObject("btn_student.Image"), Image)
        btn_student.ImageAlign = HorizontalAlignment.Left
        btn_student.ImageOffset = New Point(5, 0)
        btn_student.ImageSize = New Size(30, 30)
        btn_student.Location = New Point(22, 367)
        btn_student.Margin = New Padding(3, 4, 3, 4)
        btn_student.Name = "btn_student"
        btn_student.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        btn_student.Size = New Size(213, 52)
        btn_student.TabIndex = 57
        btn_student.Text = "Student"
        btn_student.TextOffset = New Point(0, 2)
        ' 
        ' btn_dashboard
        ' 
        btn_dashboard.BorderRadius = 8
        btn_dashboard.CustomizableEdges = CustomizableEdges9
        btn_dashboard.DisabledState.BorderColor = Color.DarkGray
        btn_dashboard.DisabledState.CustomBorderColor = Color.DarkGray
        btn_dashboard.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btn_dashboard.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btn_dashboard.FillColor = Color.Lime
        btn_dashboard.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btn_dashboard.ForeColor = Color.White
        btn_dashboard.Image = CType(resources.GetObject("btn_dashboard.Image"), Image)
        btn_dashboard.ImageAlign = HorizontalAlignment.Left
        btn_dashboard.ImageOffset = New Point(5, 0)
        btn_dashboard.ImageSize = New Size(30, 30)
        btn_dashboard.Location = New Point(22, 283)
        btn_dashboard.Margin = New Padding(3, 4, 3, 4)
        btn_dashboard.Name = "btn_dashboard"
        btn_dashboard.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        btn_dashboard.Size = New Size(213, 52)
        btn_dashboard.TabIndex = 56
        btn_dashboard.Text = "      Dashboard"
        btn_dashboard.TextOffset = New Point(0, 2)
        ' 
        ' btn_signout
        ' 
        btn_signout.BorderRadius = 8
        btn_signout.CustomizableEdges = CustomizableEdges11
        btn_signout.DisabledState.BorderColor = Color.DarkGray
        btn_signout.DisabledState.CustomBorderColor = Color.DarkGray
        btn_signout.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btn_signout.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btn_signout.FillColor = Color.Lime
        btn_signout.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point)
        btn_signout.ForeColor = Color.White
        btn_signout.Location = New Point(42, 745)
        btn_signout.Margin = New Padding(3, 4, 3, 4)
        btn_signout.Name = "btn_signout"
        btn_signout.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        btn_signout.Size = New Size(170, 45)
        btn_signout.TabIndex = 54
        btn_signout.Text = "Sign out"
        btn_signout.TextOffset = New Point(0, 2)
        ' 
        ' panel_student
        ' 
        panel_student.BackColor = Color.Transparent
        panel_student.Controls.Add(d1)
        panel_student.Controls.Add(PictureBox1)
        panel_student.Controls.Add(Label1)
        panel_student.FillColor = Color.White
        panel_student.Location = New Point(357, 201)
        panel_student.Margin = New Padding(3, 4, 3, 4)
        panel_student.Name = "panel_student"
        panel_student.Radius = 8
        panel_student.ShadowColor = Color.Gray
        panel_student.ShadowShift = 8
        panel_student.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal
        panel_student.Size = New Size(373, 217)
        panel_student.TabIndex = 97
        ' 
        ' d1
        ' 
        d1.AutoSize = True
        d1.BackColor = Color.Transparent
        d1.Font = New Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point)
        d1.Location = New Point(246, 69)
        d1.Name = "d1"
        d1.Size = New Size(37, 39)
        d1.TabIndex = 2
        d1.Text = "0"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(86, 52)
        PictureBox1.Margin = New Padding(3, 4, 3, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(57, 67)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(62, 134)
        Label1.Name = "Label1"
        Label1.Size = New Size(107, 29)
        Label1.TabIndex = 1
        Label1.Text = "Students"
        ' 
        ' Guna2ShadowPanel1
        ' 
        Guna2ShadowPanel1.BackColor = Color.Transparent
        Guna2ShadowPanel1.Controls.Add(d3)
        Guna2ShadowPanel1.Controls.Add(PictureBox2)
        Guna2ShadowPanel1.Controls.Add(Label3)
        Guna2ShadowPanel1.FillColor = Color.White
        Guna2ShadowPanel1.Location = New Point(357, 449)
        Guna2ShadowPanel1.Margin = New Padding(3, 4, 3, 4)
        Guna2ShadowPanel1.Name = "Guna2ShadowPanel1"
        Guna2ShadowPanel1.Radius = 8
        Guna2ShadowPanel1.ShadowColor = Color.Gray
        Guna2ShadowPanel1.ShadowShift = 8
        Guna2ShadowPanel1.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal
        Guna2ShadowPanel1.Size = New Size(373, 217)
        Guna2ShadowPanel1.TabIndex = 98
        ' 
        ' d3
        ' 
        d3.AutoSize = True
        d3.Font = New Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point)
        d3.Location = New Point(246, 68)
        d3.Name = "d3"
        d3.Size = New Size(37, 39)
        d3.TabIndex = 2
        d3.Text = "0"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(86, 50)
        PictureBox2.Margin = New Padding(3, 4, 3, 4)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(57, 67)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 0
        PictureBox2.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(51, 142)
        Label3.Name = "Label3"
        Label3.Size = New Size(150, 29)
        Label3.TabIndex = 1
        Label3.Text = "Departments"
        ' 
        ' Guna2ShadowPanel2
        ' 
        Guna2ShadowPanel2.BackColor = Color.Transparent
        Guna2ShadowPanel2.Controls.Add(d2)
        Guna2ShadowPanel2.Controls.Add(PictureBox3)
        Guna2ShadowPanel2.Controls.Add(Label4)
        Guna2ShadowPanel2.FillColor = Color.White
        Guna2ShadowPanel2.Location = New Point(773, 201)
        Guna2ShadowPanel2.Margin = New Padding(3, 4, 3, 4)
        Guna2ShadowPanel2.Name = "Guna2ShadowPanel2"
        Guna2ShadowPanel2.Radius = 8
        Guna2ShadowPanel2.ShadowColor = Color.Gray
        Guna2ShadowPanel2.ShadowShift = 8
        Guna2ShadowPanel2.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal
        Guna2ShadowPanel2.Size = New Size(373, 217)
        Guna2ShadowPanel2.TabIndex = 99
        ' 
        ' d2
        ' 
        d2.AutoSize = True
        d2.Font = New Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point)
        d2.Location = New Point(254, 69)
        d2.Name = "d2"
        d2.Size = New Size(37, 39)
        d2.TabIndex = 2
        d2.Text = "0"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(69, 50)
        PictureBox3.Margin = New Padding(3, 4, 3, 4)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(57, 67)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 0
        PictureBox3.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(44, 134)
        Label4.Name = "Label4"
        Label4.Size = New Size(115, 29)
        Label4.TabIndex = 1
        Label4.Text = "Teachers"
        ' 
        ' Guna2ShadowPanel3
        ' 
        Guna2ShadowPanel3.BackColor = Color.Transparent
        Guna2ShadowPanel3.Controls.Add(d4)
        Guna2ShadowPanel3.Controls.Add(PictureBox4)
        Guna2ShadowPanel3.Controls.Add(Label6)
        Guna2ShadowPanel3.FillColor = Color.White
        Guna2ShadowPanel3.Location = New Point(773, 449)
        Guna2ShadowPanel3.Margin = New Padding(3, 4, 3, 4)
        Guna2ShadowPanel3.Name = "Guna2ShadowPanel3"
        Guna2ShadowPanel3.Radius = 8
        Guna2ShadowPanel3.ShadowColor = Color.Gray
        Guna2ShadowPanel3.ShadowShift = 8
        Guna2ShadowPanel3.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal
        Guna2ShadowPanel3.Size = New Size(373, 217)
        Guna2ShadowPanel3.TabIndex = 100
        ' 
        ' d4
        ' 
        d4.AutoSize = True
        d4.Font = New Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point)
        d4.Location = New Point(178, 68)
        d4.Name = "d4"
        d4.Size = New Size(37, 39)
        d4.TabIndex = 2
        d4.Text = "0"
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(78, 50)
        PictureBox4.Margin = New Padding(3, 4, 3, 4)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(57, 67)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 0
        PictureBox4.TabStop = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(20, 142)
        Label6.Name = "Label6"
        Label6.Size = New Size(177, 29)
        Label6.TabIndex = 1
        Label6.Text = "Fees Collected"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        Label2.Location = New Point(333, 37)
        Label2.Name = "Label2"
        Label2.Size = New Size(193, 39)
        Label2.TabIndex = 101
        Label2.Text = "Dashboard"
        ' 
        ' dashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1221, 835)
        Controls.Add(Label2)
        Controls.Add(Guna2ShadowPanel3)
        Controls.Add(Guna2ShadowPanel2)
        Controls.Add(Guna2ShadowPanel1)
        Controls.Add(panel_student)
        Controls.Add(panel_Menu)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 4, 3, 4)
        Name = "dashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Dashboard"
        panel_Menu.ResumeLayout(False)
        CType(Guna2PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        panel_student.ResumeLayout(False)
        panel_student.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Guna2ShadowPanel1.ResumeLayout(False)
        Guna2ShadowPanel1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Guna2ShadowPanel2.ResumeLayout(False)
        Guna2ShadowPanel2.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Guna2ShadowPanel3.ResumeLayout(False)
        Guna2ShadowPanel3.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btn_teacher As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents panel_Menu As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents btn_Fees As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_student As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_dashboard As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_signout As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents panel_student As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents d1 As Label
    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents d3 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Guna2ShadowPanel2 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents d2 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Guna2ShadowPanel3 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents d4 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
End Class
