﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PatientMenuPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PatientMenuPage))
        RoundedButton1 = New CustomControls.RJControls.RoundedButton()
        RoundedButton2 = New CustomControls.RJControls.RoundedButton()
        Label2 = New Label()
        PictureBox4 = New PictureBox()
        PictureBox2 = New PictureBox()
        Panel1 = New Panel()
        lbl_LoggedInUser = New Label()
        btn_Logout = New Button()
        RoundedButton4 = New CustomControls.RJControls.RoundedButton()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        PictureBox3 = New PictureBox()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' RoundedButton1
        ' 
        RoundedButton1.BackColor = SystemColors.ButtonHighlight
        RoundedButton1.BackgroundColor = SystemColors.ButtonHighlight
        RoundedButton1.BorderColor = Color.PaleVioletRed
        RoundedButton1.BorderRadius = 9
        RoundedButton1.BorderSize = 0
        RoundedButton1.FlatAppearance.BorderSize = 0
        RoundedButton1.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        RoundedButton1.FlatStyle = FlatStyle.Flat
        RoundedButton1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RoundedButton1.ForeColor = Color.Black
        RoundedButton1.Image = CType(resources.GetObject("RoundedButton1.Image"), Image)
        RoundedButton1.Location = New Point(42, 399)
        RoundedButton1.Name = "RoundedButton1"
        RoundedButton1.Size = New Size(136, 118)
        RoundedButton1.TabIndex = 18
        RoundedButton1.Text = "Records"
        RoundedButton1.TextAlign = ContentAlignment.BottomCenter
        RoundedButton1.TextColor = Color.Black
        RoundedButton1.UseVisualStyleBackColor = False
        ' 
        ' RoundedButton2
        ' 
        RoundedButton2.BackColor = SystemColors.ButtonHighlight
        RoundedButton2.BackgroundColor = SystemColors.ButtonHighlight
        RoundedButton2.BorderColor = Color.PaleVioletRed
        RoundedButton2.BorderRadius = 9
        RoundedButton2.BorderSize = 0
        RoundedButton2.FlatAppearance.BorderSize = 0
        RoundedButton2.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        RoundedButton2.FlatStyle = FlatStyle.Flat
        RoundedButton2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RoundedButton2.ForeColor = Color.Black
        RoundedButton2.Image = CType(resources.GetObject("RoundedButton2.Image"), Image)
        RoundedButton2.Location = New Point(211, 399)
        RoundedButton2.Name = "RoundedButton2"
        RoundedButton2.Size = New Size(136, 118)
        RoundedButton2.TabIndex = 17
        RoundedButton2.Text = "Prescription"
        RoundedButton2.TextAlign = ContentAlignment.BottomCenter
        RoundedButton2.TextColor = Color.Black
        RoundedButton2.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(99, 336)
        Label2.Name = "Label2"
        Label2.Size = New Size(213, 42)
        Label2.TabIndex = 16
        Label2.Text = "PLEASE CHOOSE FROM " & vbCrLf & "THE FOLLOWING SERVICES"
        Label2.TextAlign = ContentAlignment.TopCenter
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.Transparent
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(34, 169)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(336, 192)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 15
        PictureBox4.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(7, 26)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(387, 300)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 14
        PictureBox2.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(PictureBox3)
        Panel1.Controls.Add(lbl_LoggedInUser)
        Panel1.Controls.Add(btn_Logout)
        Panel1.Location = New Point(-15, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(422, 68)
        Panel1.TabIndex = 19
        ' 
        ' lbl_LoggedInUser
        ' 
        lbl_LoggedInUser.AutoSize = True
        lbl_LoggedInUser.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_LoggedInUser.Location = New Point(196, 24)
        lbl_LoggedInUser.Name = "lbl_LoggedInUser"
        lbl_LoggedInUser.Size = New Size(112, 17)
        lbl_LoggedInUser.TabIndex = 22
        lbl_LoggedInUser.Text = "Hello, FirstName"
        ' 
        ' btn_Logout
        ' 
        btn_Logout.BackColor = Color.White
        btn_Logout.FlatStyle = FlatStyle.Flat
        btn_Logout.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_Logout.Location = New Point(327, 16)
        btn_Logout.Name = "btn_Logout"
        btn_Logout.Size = New Size(75, 35)
        btn_Logout.TabIndex = 21
        btn_Logout.Text = "Log out"
        btn_Logout.UseVisualStyleBackColor = False
        ' 
        ' RoundedButton4
        ' 
        RoundedButton4.BackColor = SystemColors.ButtonHighlight
        RoundedButton4.BackgroundColor = SystemColors.ButtonHighlight
        RoundedButton4.BorderColor = Color.PaleVioletRed
        RoundedButton4.BorderRadius = 9
        RoundedButton4.BorderSize = 0
        RoundedButton4.FlatAppearance.BorderSize = 0
        RoundedButton4.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        RoundedButton4.FlatStyle = FlatStyle.Flat
        RoundedButton4.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RoundedButton4.ForeColor = Color.Black
        RoundedButton4.Image = CType(resources.GetObject("RoundedButton4.Image"), Image)
        RoundedButton4.Location = New Point(127, 537)
        RoundedButton4.Name = "RoundedButton4"
        RoundedButton4.Size = New Size(136, 118)
        RoundedButton4.TabIndex = 20
        RoundedButton4.Text = "Appointment"
        RoundedButton4.TextAlign = ContentAlignment.BottomCenter
        RoundedButton4.TextColor = Color.Black
        RoundedButton4.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(22, 42)
        Label1.Name = "Label1"
        Label1.Size = New Size(47, 16)
        Label1.TabIndex = 25
        Label1.Text = "MENU"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Cursor = Cursors.Hand
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(24, 14)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(40, 25)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 24
        PictureBox1.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Transparent
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(48, -11)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(142, 90)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 23
        PictureBox3.TabStop = False
        ' 
        ' PatientMenuPage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(400, 750)
        Controls.Add(RoundedButton4)
        Controls.Add(Panel1)
        Controls.Add(RoundedButton1)
        Controls.Add(RoundedButton2)
        Controls.Add(Label2)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox2)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "PatientMenuPage"
        StartPosition = FormStartPosition.CenterScreen
        Text = "PatientMenuPage"
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents RoundedButton1 As CustomControls.RJControls.RoundedButton
    Friend WithEvents RoundedButton2 As CustomControls.RJControls.RoundedButton
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents RoundedButton4 As CustomControls.RJControls.RoundedButton
    Friend WithEvents btn_Logout As Button
    Friend WithEvents lbl_LoggedInUser As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
