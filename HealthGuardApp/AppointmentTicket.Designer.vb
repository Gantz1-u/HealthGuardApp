<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AppointmentTicket
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AppointmentTicket))
        RoundedPanel1 = New RoundedPanel()
        RoundedPanel2 = New RoundedPanel()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label2 = New Label()
        lbl_Doctor = New Label()
        lbl_AppointmentTime = New Label()
        lbl_AppointmentDate = New Label()
        Label1 = New Label()
        PictureBox2 = New PictureBox()
        Panel1 = New Panel()
        Label3 = New Label()
        PictureBox1 = New PictureBox()
        PictureBox3 = New PictureBox()
        lbl_LoggedInUser = New Label()
        RoundedButton2 = New CustomControls.RJControls.RoundedButton()
        RoundedButton1 = New CustomControls.RJControls.RoundedButton()
        RoundedPanel1.SuspendLayout()
        RoundedPanel2.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' RoundedPanel1
        ' 
        RoundedPanel1.BackgroundImage = CType(resources.GetObject("RoundedPanel1.BackgroundImage"), Image)
        RoundedPanel1.BackgroundImageLayout = ImageLayout.Stretch
        RoundedPanel1.Controls.Add(RoundedPanel2)
        RoundedPanel1.Controls.Add(PictureBox2)
        RoundedPanel1.Controls.Add(Panel1)
        RoundedPanel1.Controls.Add(RoundedButton2)
        RoundedPanel1.Controls.Add(RoundedButton1)
        RoundedPanel1.CornerRadius = 35
        RoundedPanel1.Location = New Point(12, 26)
        RoundedPanel1.Name = "RoundedPanel1"
        RoundedPanel1.Size = New Size(376, 712)
        RoundedPanel1.TabIndex = 0
        ' 
        ' RoundedPanel2
        ' 
        RoundedPanel2.BackColor = Color.LightCyan
        RoundedPanel2.Controls.Add(Label6)
        RoundedPanel2.Controls.Add(Label5)
        RoundedPanel2.Controls.Add(Label4)
        RoundedPanel2.Controls.Add(Label2)
        RoundedPanel2.Controls.Add(lbl_Doctor)
        RoundedPanel2.Controls.Add(lbl_AppointmentTime)
        RoundedPanel2.Controls.Add(lbl_AppointmentDate)
        RoundedPanel2.Controls.Add(Label1)
        RoundedPanel2.CornerRadius = 20
        RoundedPanel2.Location = New Point(16, 186)
        RoundedPanel2.Name = "RoundedPanel2"
        RoundedPanel2.Size = New Size(345, 312)
        RoundedPanel2.TabIndex = 38
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold)
        Label6.Location = New Point(12, 237)
        Label6.Name = "Label6"
        Label6.Size = New Size(101, 20)
        Label6.TabIndex = 4
        Label6.Text = "Doctor Name"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label5.Location = New Point(10, 206)
        Label5.Name = "Label5"
        Label5.Size = New Size(52, 21)
        Label5.TabIndex = 3
        Label5.Text = "Note:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label4.Location = New Point(10, 126)
        Label4.Name = "Label4"
        Label4.Size = New Size(167, 21)
        Label4.TabIndex = 2
        Label4.Text = "Healthcare Provider:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label2.Location = New Point(10, 79)
        Label2.Name = "Label2"
        Label2.Size = New Size(52, 21)
        Label2.TabIndex = 1
        Label2.Text = "Time:"
        ' 
        ' lbl_Doctor
        ' 
        lbl_Doctor.AutoSize = True
        lbl_Doctor.BackColor = Color.Transparent
        lbl_Doctor.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold)
        lbl_Doctor.Location = New Point(12, 163)
        lbl_Doctor.Name = "lbl_Doctor"
        lbl_Doctor.Size = New Size(101, 20)
        lbl_Doctor.TabIndex = 0
        lbl_Doctor.Text = "Doctor Name"
        ' 
        ' lbl_AppointmentTime
        ' 
        lbl_AppointmentTime.AutoSize = True
        lbl_AppointmentTime.BackColor = Color.Transparent
        lbl_AppointmentTime.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold)
        lbl_AppointmentTime.Location = New Point(68, 80)
        lbl_AppointmentTime.Name = "lbl_AppointmentTime"
        lbl_AppointmentTime.Size = New Size(45, 20)
        lbl_AppointmentTime.TabIndex = 0
        lbl_AppointmentTime.Text = "00:00"
        ' 
        ' lbl_AppointmentDate
        ' 
        lbl_AppointmentDate.AutoSize = True
        lbl_AppointmentDate.BackColor = Color.Transparent
        lbl_AppointmentDate.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold)
        lbl_AppointmentDate.Location = New Point(66, 33)
        lbl_AppointmentDate.Name = "lbl_AppointmentDate"
        lbl_AppointmentDate.Size = New Size(107, 20)
        lbl_AppointmentDate.TabIndex = 0
        lbl_AppointmentDate.Text = "YYYY-MM-DD"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label1.Location = New Point(10, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(50, 21)
        Label1.TabIndex = 0
        Label1.Text = "Date:"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Cursor = Cursors.Hand
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(13, 81)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(38, 36)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 64
        PictureBox2.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(PictureBox3)
        Panel1.Controls.Add(lbl_LoggedInUser)
        Panel1.Location = New Point(-9, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(400, 68)
        Panel1.TabIndex = 63
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(322, 42)
        Label3.Name = "Label3"
        Label3.Size = New Size(47, 16)
        Label3.TabIndex = 25
        Label3.Text = "HOME"
        Label3.TextAlign = ContentAlignment.TopCenter
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Cursor = Cursors.Hand
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(325, 15)
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
        PictureBox3.Location = New Point(-9, -12)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(145, 90)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 23
        PictureBox3.TabStop = False
        ' 
        ' lbl_LoggedInUser
        ' 
        lbl_LoggedInUser.AutoSize = True
        lbl_LoggedInUser.BackColor = Color.Transparent
        lbl_LoggedInUser.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold)
        lbl_LoggedInUser.Location = New Point(220, 20)
        lbl_LoggedInUser.Name = "lbl_LoggedInUser"
        lbl_LoggedInUser.Size = New Size(0, 20)
        lbl_LoggedInUser.TabIndex = 0
        lbl_LoggedInUser.Visible = False
        ' 
        ' RoundedButton2
        ' 
        RoundedButton2.BackColor = SystemColors.ButtonHighlight
        RoundedButton2.BackgroundColor = SystemColors.ButtonHighlight
        RoundedButton2.BorderColor = Color.PaleVioletRed
        RoundedButton2.BorderRadius = 9
        RoundedButton2.BorderSize = 0
        RoundedButton2.Cursor = Cursors.Hand
        RoundedButton2.FlatAppearance.BorderColor = SystemColors.ButtonHighlight
        RoundedButton2.FlatAppearance.MouseDownBackColor = Color.White
        RoundedButton2.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        RoundedButton2.FlatStyle = FlatStyle.Flat
        RoundedButton2.Font = New Font("Segoe UI", 10F)
        RoundedButton2.ForeColor = Color.Black
        RoundedButton2.Location = New Point(16, 589)
        RoundedButton2.Name = "RoundedButton2"
        RoundedButton2.Size = New Size(345, 52)
        RoundedButton2.TabIndex = 40
        RoundedButton2.Text = "Cancel"
        RoundedButton2.TextColor = Color.Black
        RoundedButton2.UseVisualStyleBackColor = False
        ' 
        ' RoundedButton1
        ' 
        RoundedButton1.BackColor = SystemColors.ButtonHighlight
        RoundedButton1.BackgroundColor = SystemColors.ButtonHighlight
        RoundedButton1.BorderColor = Color.PaleVioletRed
        RoundedButton1.BorderRadius = 9
        RoundedButton1.BorderSize = 0
        RoundedButton1.Cursor = Cursors.Hand
        RoundedButton1.FlatAppearance.BorderColor = SystemColors.ButtonHighlight
        RoundedButton1.FlatAppearance.MouseDownBackColor = Color.White
        RoundedButton1.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        RoundedButton1.FlatStyle = FlatStyle.Flat
        RoundedButton1.Font = New Font("Segoe UI", 10F)
        RoundedButton1.ForeColor = Color.Black
        RoundedButton1.Location = New Point(16, 531)
        RoundedButton1.Name = "RoundedButton1"
        RoundedButton1.Size = New Size(345, 52)
        RoundedButton1.TabIndex = 39
        RoundedButton1.Text = "Save"
        RoundedButton1.TextColor = Color.Black
        RoundedButton1.UseVisualStyleBackColor = False
        ' 
        ' AppointmentTicket
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(400, 750)
        Controls.Add(RoundedPanel1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "AppointmentTicket"
        StartPosition = FormStartPosition.CenterScreen
        Text = "AppointmentTicket"
        RoundedPanel1.ResumeLayout(False)
        RoundedPanel2.ResumeLayout(False)
        RoundedPanel2.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents RoundedButton2 As CustomControls.RJControls.RoundedButton
    Friend WithEvents RoundedButton1 As CustomControls.RJControls.RoundedButton
    Friend WithEvents RoundedPanel2 As RoundedPanel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_Doctor As Label
    Friend WithEvents lbl_AppointmentTime As Label
    Friend WithEvents lbl_AppointmentDate As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lbl_LoggedInUser As Label
End Class
