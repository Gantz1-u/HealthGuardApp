﻿

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginPage))
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label5 = New Label()
        LinkLabel1 = New LinkLabel()
        RoundedButton3 = New CustomControls.RJControls.RoundedButton()
        RoundedPanel3 = New RoundedPanel()
        RoundedTextBox1 = New RoundedTextBox()
        RoundedPanel2 = New RoundedPanel()
        PictureBox3 = New PictureBox()
        RoundedTextBox3 = New RoundedTextBox()
        PictureBox2 = New PictureBox()
        RoundedPanel1 = New RoundedPanel()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        RoundedPanel3.SuspendLayout()
        RoundedPanel2.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        RoundedPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(31, 71)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(289, 176)
        Panel1.TabIndex = 19
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(289, 176)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.SteelBlue
        Label1.Location = New Point(110, 250)
        Label1.Name = "Label1"
        Label1.Size = New Size(170, 21)
        Label1.TabIndex = 20
        Label1.Text = "Login to your account"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Location = New Point(80, 564)
        Label5.Name = "Label5"
        Label5.Size = New Size(131, 15)
        Label5.TabIndex = 21
        Label5.Text = "Don't have an account?"
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.ActiveLinkColor = Color.White
        LinkLabel1.AutoSize = True
        LinkLabel1.BackColor = Color.Transparent
        LinkLabel1.Cursor = Cursors.Hand
        LinkLabel1.Location = New Point(210, 564)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(87, 15)
        LinkLabel1.TabIndex = 22
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Create account"
        ' 
        ' RoundedButton3
        ' 
        RoundedButton3.BackColor = SystemColors.ButtonHighlight
        RoundedButton3.BackgroundColor = SystemColors.ButtonHighlight
        RoundedButton3.BorderColor = Color.PaleVioletRed
        RoundedButton3.BorderRadius = 9
        RoundedButton3.BorderSize = 0
        RoundedButton3.Cursor = Cursors.Hand
        RoundedButton3.FlatAppearance.BorderColor = SystemColors.ButtonHighlight
        RoundedButton3.FlatAppearance.BorderSize = 0
        RoundedButton3.FlatAppearance.MouseDownBackColor = Color.White
        RoundedButton3.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        RoundedButton3.FlatStyle = FlatStyle.Flat
        RoundedButton3.Font = New Font("Segoe UI", 10F)
        RoundedButton3.ForeColor = Color.Black
        RoundedButton3.Location = New Point(23, 592)
        RoundedButton3.Name = "RoundedButton3"
        RoundedButton3.Size = New Size(331, 52)
        RoundedButton3.TabIndex = 23
        RoundedButton3.Text = "Login"
        RoundedButton3.TextColor = Color.Black
        RoundedButton3.UseVisualStyleBackColor = False
        ' 
        ' RoundedPanel3
        ' 
        RoundedPanel3.BackColor = SystemColors.Window
        RoundedPanel3.Controls.Add(RoundedTextBox1)
        RoundedPanel3.CornerRadius = 20
        RoundedPanel3.Location = New Point(23, 297)
        RoundedPanel3.Name = "RoundedPanel3"
        RoundedPanel3.Size = New Size(331, 48)
        RoundedPanel3.TabIndex = 24
        ' 
        ' RoundedTextBox1
        ' 
        RoundedTextBox1.Location = New Point(9, 13)
        RoundedTextBox1.Multiline = True
        RoundedTextBox1.Name = "RoundedTextBox1"
        RoundedTextBox1.PlaceholderText = "Phone Number, Username or Email"
        RoundedTextBox1.Size = New Size(289, 22)
        RoundedTextBox1.TabIndex = 3
        ' 
        ' RoundedPanel2
        ' 
        RoundedPanel2.BackColor = SystemColors.Window
        RoundedPanel2.Controls.Add(PictureBox3)
        RoundedPanel2.Controls.Add(RoundedTextBox3)
        RoundedPanel2.Controls.Add(PictureBox2)
        RoundedPanel2.CornerRadius = 20
        RoundedPanel2.Location = New Point(23, 351)
        RoundedPanel2.Name = "RoundedPanel2"
        RoundedPanel2.Size = New Size(331, 48)
        RoundedPanel2.TabIndex = 25
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = SystemColors.Window
        PictureBox3.Cursor = Cursors.Hand
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(292, 17)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(19, 16)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 26
        PictureBox3.TabStop = False
        ' 
        ' RoundedTextBox3
        ' 
        RoundedTextBox3.Location = New Point(9, 14)
        RoundedTextBox3.Multiline = True
        RoundedTextBox3.Name = "RoundedTextBox3"
        RoundedTextBox3.PasswordChar = "*"c
        RoundedTextBox3.PlaceholderText = "Password"
        RoundedTextBox3.Size = New Size(276, 22)
        RoundedTextBox3.TabIndex = 3
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = SystemColors.Window
        PictureBox2.Cursor = Cursors.Hand
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(292, 17)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(19, 16)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 16
        PictureBox2.TabStop = False
        ' 
        ' RoundedPanel1
        ' 
        RoundedPanel1.BackgroundImage = CType(resources.GetObject("RoundedPanel1.BackgroundImage"), Image)
        RoundedPanel1.BackgroundImageLayout = ImageLayout.Stretch
        RoundedPanel1.Controls.Add(RoundedPanel2)
        RoundedPanel1.Controls.Add(RoundedPanel3)
        RoundedPanel1.Controls.Add(RoundedButton3)
        RoundedPanel1.Controls.Add(LinkLabel1)
        RoundedPanel1.Controls.Add(Label5)
        RoundedPanel1.Controls.Add(Label1)
        RoundedPanel1.Controls.Add(Panel1)
        RoundedPanel1.CornerRadius = 35
        RoundedPanel1.Location = New Point(12, 26)
        RoundedPanel1.Name = "RoundedPanel1"
        RoundedPanel1.Size = New Size(376, 712)
        RoundedPanel1.TabIndex = 0
        ' 
        ' LoginPage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(400, 750)
        Controls.Add(RoundedPanel1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "LoginPage"
        StartPosition = FormStartPosition.CenterScreen
        Text = "LoginPage"
        Panel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        RoundedPanel3.ResumeLayout(False)
        RoundedPanel3.PerformLayout()
        RoundedPanel2.ResumeLayout(False)
        RoundedPanel2.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        RoundedPanel1.ResumeLayout(False)
        RoundedPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents RoundedButton3 As CustomControls.RJControls.RoundedButton
    Friend WithEvents RoundedPanel3 As RoundedPanel
    Friend WithEvents RoundedTextBox1 As RoundedTextBox
    Friend WithEvents RoundedPanel2 As RoundedPanel
    Friend WithEvents RoundedTextBox3 As RoundedTextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents PictureBox3 As PictureBox
End Class
