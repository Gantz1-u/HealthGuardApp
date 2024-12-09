<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PatientRecord
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PatientRecord))
        RoundedPanel1 = New RoundedPanel()
        RoundedPanel2 = New RoundedPanel()
        RoundedPanel12 = New RoundedPanel()
        lbl_Email = New Label()
        RoundedPanel11 = New RoundedPanel()
        lbl_Address = New Label()
        RoundedPanel10 = New RoundedPanel()
        lbl_Phone = New Label()
        RoundedPanel9 = New RoundedPanel()
        lbl_PrimaryDiagnoses = New Label()
        RoundedPanel8 = New RoundedPanel()
        lbl_ParentGuardian = New Label()
        RoundedPanel7 = New RoundedPanel()
        lbl_DateOfBirth = New Label()
        RoundedPanel6 = New RoundedPanel()
        lbl_BloodType = New Label()
        Label1 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        RoundedPanel5 = New RoundedPanel()
        lbl_Sex = New Label()
        RoundedPanel4 = New RoundedPanel()
        lbl_Age = New Label()
        RoundedPanel3 = New RoundedPanel()
        lbl_FullName = New Label()
        Label20 = New Label()
        Label13 = New Label()
        Label12 = New Label()
        Label11 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Panel1 = New Panel()
        Label3 = New Label()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox2 = New PictureBox()
        RoundedPanel1.SuspendLayout()
        RoundedPanel2.SuspendLayout()
        RoundedPanel12.SuspendLayout()
        RoundedPanel11.SuspendLayout()
        RoundedPanel10.SuspendLayout()
        RoundedPanel9.SuspendLayout()
        RoundedPanel8.SuspendLayout()
        RoundedPanel7.SuspendLayout()
        RoundedPanel6.SuspendLayout()
        RoundedPanel5.SuspendLayout()
        RoundedPanel4.SuspendLayout()
        RoundedPanel3.SuspendLayout()
        Panel1.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' RoundedPanel1
        ' 
        RoundedPanel1.BackgroundImage = CType(resources.GetObject("RoundedPanel1.BackgroundImage"), Image)
        RoundedPanel1.BackgroundImageLayout = ImageLayout.Stretch
        RoundedPanel1.Controls.Add(RoundedPanel2)
        RoundedPanel1.Controls.Add(Panel1)
        RoundedPanel1.Controls.Add(PictureBox2)
        RoundedPanel1.CornerRadius = 35
        RoundedPanel1.Location = New Point(12, 26)
        RoundedPanel1.Name = "RoundedPanel1"
        RoundedPanel1.Size = New Size(376, 712)
        RoundedPanel1.TabIndex = 0
        ' 
        ' RoundedPanel2
        ' 
        RoundedPanel2.BackColor = Color.LightCyan
        RoundedPanel2.Controls.Add(RoundedPanel12)
        RoundedPanel2.Controls.Add(RoundedPanel11)
        RoundedPanel2.Controls.Add(RoundedPanel10)
        RoundedPanel2.Controls.Add(RoundedPanel9)
        RoundedPanel2.Controls.Add(RoundedPanel8)
        RoundedPanel2.Controls.Add(RoundedPanel7)
        RoundedPanel2.Controls.Add(RoundedPanel6)
        RoundedPanel2.Controls.Add(Label1)
        RoundedPanel2.Controls.Add(Label6)
        RoundedPanel2.Controls.Add(Label5)
        RoundedPanel2.Controls.Add(RoundedPanel5)
        RoundedPanel2.Controls.Add(RoundedPanel4)
        RoundedPanel2.Controls.Add(RoundedPanel3)
        RoundedPanel2.Controls.Add(Label20)
        RoundedPanel2.Controls.Add(Label13)
        RoundedPanel2.Controls.Add(Label12)
        RoundedPanel2.Controls.Add(Label11)
        RoundedPanel2.Controls.Add(Label9)
        RoundedPanel2.Controls.Add(Label8)
        RoundedPanel2.Controls.Add(Label7)
        RoundedPanel2.CornerRadius = 20
        RoundedPanel2.Location = New Point(9, 131)
        RoundedPanel2.Name = "RoundedPanel2"
        RoundedPanel2.Size = New Size(358, 571)
        RoundedPanel2.TabIndex = 64
        ' 
        ' RoundedPanel12
        ' 
        RoundedPanel12.BackColor = Color.White
        RoundedPanel12.Controls.Add(lbl_Email)
        RoundedPanel12.CornerRadius = 20
        RoundedPanel12.Location = New Point(30, 506)
        RoundedPanel12.Name = "RoundedPanel12"
        RoundedPanel12.Size = New Size(299, 29)
        RoundedPanel12.TabIndex = 89
        ' 
        ' lbl_Email
        ' 
        lbl_Email.AutoSize = True
        lbl_Email.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold)
        lbl_Email.Location = New Point(14, 4)
        lbl_Email.Name = "lbl_Email"
        lbl_Email.Size = New Size(115, 20)
        lbl_Email.TabIndex = 80
        lbl_Email.Text = "123 Main St, QC"
        ' 
        ' RoundedPanel11
        ' 
        RoundedPanel11.BackColor = Color.White
        RoundedPanel11.Controls.Add(lbl_Address)
        RoundedPanel11.CornerRadius = 20
        RoundedPanel11.Location = New Point(30, 430)
        RoundedPanel11.Name = "RoundedPanel11"
        RoundedPanel11.Size = New Size(299, 29)
        RoundedPanel11.TabIndex = 88
        ' 
        ' lbl_Address
        ' 
        lbl_Address.AutoSize = True
        lbl_Address.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold)
        lbl_Address.Location = New Point(13, 4)
        lbl_Address.Name = "lbl_Address"
        lbl_Address.Size = New Size(157, 20)
        lbl_Address.TabIndex = 78
        lbl_Address.Text = "juan.cruz@gmail.com"
        ' 
        ' RoundedPanel10
        ' 
        RoundedPanel10.BackColor = Color.White
        RoundedPanel10.Controls.Add(lbl_Phone)
        RoundedPanel10.CornerRadius = 20
        RoundedPanel10.Location = New Point(31, 361)
        RoundedPanel10.Name = "RoundedPanel10"
        RoundedPanel10.Size = New Size(299, 29)
        RoundedPanel10.TabIndex = 87
        ' 
        ' lbl_Phone
        ' 
        lbl_Phone.AutoSize = True
        lbl_Phone.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_Phone.Location = New Point(11, 4)
        lbl_Phone.Name = "lbl_Phone"
        lbl_Phone.Size = New Size(94, 20)
        lbl_Phone.TabIndex = 77
        lbl_Phone.Text = "09171234567"
        ' 
        ' RoundedPanel9
        ' 
        RoundedPanel9.BackColor = Color.White
        RoundedPanel9.Controls.Add(lbl_PrimaryDiagnoses)
        RoundedPanel9.CornerRadius = 20
        RoundedPanel9.Location = New Point(30, 286)
        RoundedPanel9.Name = "RoundedPanel9"
        RoundedPanel9.Size = New Size(299, 29)
        RoundedPanel9.TabIndex = 86
        ' 
        ' lbl_PrimaryDiagnoses
        ' 
        lbl_PrimaryDiagnoses.AutoSize = True
        lbl_PrimaryDiagnoses.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_PrimaryDiagnoses.Location = New Point(7, 4)
        lbl_PrimaryDiagnoses.Name = "lbl_PrimaryDiagnoses"
        lbl_PrimaryDiagnoses.Size = New Size(101, 20)
        lbl_PrimaryDiagnoses.TabIndex = 76
        lbl_PrimaryDiagnoses.Text = "Hypertension"
        ' 
        ' RoundedPanel8
        ' 
        RoundedPanel8.BackColor = Color.White
        RoundedPanel8.Controls.Add(lbl_ParentGuardian)
        RoundedPanel8.CornerRadius = 20
        RoundedPanel8.Location = New Point(176, 209)
        RoundedPanel8.Name = "RoundedPanel8"
        RoundedPanel8.Size = New Size(153, 29)
        RoundedPanel8.TabIndex = 86
        ' 
        ' lbl_ParentGuardian
        ' 
        lbl_ParentGuardian.AutoSize = True
        lbl_ParentGuardian.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold)
        lbl_ParentGuardian.Location = New Point(7, 4)
        lbl_ParentGuardian.Name = "lbl_ParentGuardian"
        lbl_ParentGuardian.Size = New Size(119, 20)
        lbl_ParentGuardian.TabIndex = 75
        lbl_ParentGuardian.Text = "Maria Dela Cruz"
        ' 
        ' RoundedPanel7
        ' 
        RoundedPanel7.BackColor = Color.White
        RoundedPanel7.Controls.Add(lbl_DateOfBirth)
        RoundedPanel7.CornerRadius = 20
        RoundedPanel7.Location = New Point(30, 209)
        RoundedPanel7.Name = "RoundedPanel7"
        RoundedPanel7.Size = New Size(140, 29)
        RoundedPanel7.TabIndex = 85
        ' 
        ' lbl_DateOfBirth
        ' 
        lbl_DateOfBirth.AutoSize = True
        lbl_DateOfBirth.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold)
        lbl_DateOfBirth.Location = New Point(8, 4)
        lbl_DateOfBirth.Name = "lbl_DateOfBirth"
        lbl_DateOfBirth.Size = New Size(84, 20)
        lbl_DateOfBirth.TabIndex = 73
        lbl_DateOfBirth.Text = "2005-01-04"
        ' 
        ' RoundedPanel6
        ' 
        RoundedPanel6.BackColor = Color.White
        RoundedPanel6.Controls.Add(lbl_BloodType)
        RoundedPanel6.CornerRadius = 20
        RoundedPanel6.Location = New Point(239, 133)
        RoundedPanel6.Name = "RoundedPanel6"
        RoundedPanel6.Size = New Size(90, 29)
        RoundedPanel6.TabIndex = 85
        ' 
        ' lbl_BloodType
        ' 
        lbl_BloodType.AutoSize = True
        lbl_BloodType.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_BloodType.Location = New Point(10, 4)
        lbl_BloodType.Name = "lbl_BloodType"
        lbl_BloodType.Size = New Size(31, 21)
        lbl_BloodType.TabIndex = 74
        lbl_BloodType.Text = "B+"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(30, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(56, 21)
        Label1.TabIndex = 85
        Label1.Text = "Name"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(133, 110)
        Label6.Name = "Label6"
        Label6.Size = New Size(37, 21)
        Label6.TabIndex = 62
        Label6.Text = "Sex"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(29, 110)
        Label5.Name = "Label5"
        Label5.Size = New Size(40, 21)
        Label5.TabIndex = 61
        Label5.Text = "Age"
        ' 
        ' RoundedPanel5
        ' 
        RoundedPanel5.BackColor = Color.White
        RoundedPanel5.Controls.Add(lbl_Sex)
        RoundedPanel5.CornerRadius = 20
        RoundedPanel5.Location = New Point(124, 133)
        RoundedPanel5.Name = "RoundedPanel5"
        RoundedPanel5.Size = New Size(105, 29)
        RoundedPanel5.TabIndex = 84
        ' 
        ' lbl_Sex
        ' 
        lbl_Sex.AutoSize = True
        lbl_Sex.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_Sex.Location = New Point(14, 4)
        lbl_Sex.Name = "lbl_Sex"
        lbl_Sex.Size = New Size(43, 20)
        lbl_Sex.TabIndex = 82
        lbl_Sex.Text = "Male"
        ' 
        ' RoundedPanel4
        ' 
        RoundedPanel4.BackColor = Color.White
        RoundedPanel4.Controls.Add(lbl_Age)
        RoundedPanel4.CornerRadius = 20
        RoundedPanel4.Location = New Point(30, 133)
        RoundedPanel4.Name = "RoundedPanel4"
        RoundedPanel4.Size = New Size(84, 29)
        RoundedPanel4.TabIndex = 84
        ' 
        ' lbl_Age
        ' 
        lbl_Age.AutoSize = True
        lbl_Age.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_Age.Location = New Point(13, 4)
        lbl_Age.Name = "lbl_Age"
        lbl_Age.Size = New Size(23, 20)
        lbl_Age.TabIndex = 81
        lbl_Age.Text = "19"
        ' 
        ' RoundedPanel3
        ' 
        RoundedPanel3.BackColor = Color.White
        RoundedPanel3.Controls.Add(lbl_FullName)
        RoundedPanel3.CornerRadius = 20
        RoundedPanel3.Location = New Point(30, 60)
        RoundedPanel3.Name = "RoundedPanel3"
        RoundedPanel3.Size = New Size(300, 29)
        RoundedPanel3.TabIndex = 83
        ' 
        ' lbl_FullName
        ' 
        lbl_FullName.AutoSize = True
        lbl_FullName.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_FullName.Location = New Point(8, 5)
        lbl_FullName.Name = "lbl_FullName"
        lbl_FullName.Size = New Size(75, 20)
        lbl_FullName.TabIndex = 59
        lbl_FullName.Text = "FullName"
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label20.Location = New Point(30, 262)
        Label20.Name = "Label20"
        Label20.Size = New Size(154, 21)
        Label20.TabIndex = 79
        Label20.Text = "Primary Diagnoses"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label13.Location = New Point(31, 482)
        Label13.Name = "Label13"
        Label13.Size = New Size(70, 21)
        Label13.TabIndex = 69
        Label13.Text = "Address"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label12.Location = New Point(31, 406)
        Label12.Name = "Label12"
        Label12.Size = New Size(53, 21)
        Label12.TabIndex = 68
        Label12.Text = "Email"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(30, 337)
        Label11.Name = "Label11"
        Label11.Size = New Size(126, 21)
        Label11.TabIndex = 67
        Label11.Text = "Phone Number"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label9.Location = New Point(175, 185)
        Label9.Name = "Label9"
        Label9.Size = New Size(137, 21)
        Label9.TabIndex = 65
        Label9.Text = "Parent/Guardian"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(234, 110)
        Label8.Name = "Label8"
        Label8.Size = New Size(95, 21)
        Label8.TabIndex = 64
        Label8.Text = "Blood Type"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label7.Location = New Point(30, 185)
        Label7.Name = "Label7"
        Label7.Size = New Size(107, 21)
        Label7.TabIndex = 63
        Label7.Text = "Date of Birth"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(PictureBox3)
        Panel1.Controls.Add(PictureBox4)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(376, 68)
        Panel1.TabIndex = 62
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(322, 42)
        Label3.Name = "Label3"
        Label3.Size = New Size(47, 16)
        Label3.TabIndex = 5
        Label3.Text = "HOME"
        Label3.TextAlign = ContentAlignment.TopCenter
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Transparent
        PictureBox3.Cursor = Cursors.Hand
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(325, 15)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(40, 25)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 3
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.Transparent
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(-9, -12)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(142, 90)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 2
        PictureBox4.TabStop = False
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
        PictureBox2.TabIndex = 61
        PictureBox2.TabStop = False
        ' 
        ' PatientRecord
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(400, 750)
        Controls.Add(RoundedPanel1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "PatientRecord"
        StartPosition = FormStartPosition.CenterScreen
        Text = "PatientRecord"
        RoundedPanel1.ResumeLayout(False)
        RoundedPanel2.ResumeLayout(False)
        RoundedPanel2.PerformLayout()
        RoundedPanel12.ResumeLayout(False)
        RoundedPanel12.PerformLayout()
        RoundedPanel11.ResumeLayout(False)
        RoundedPanel11.PerformLayout()
        RoundedPanel10.ResumeLayout(False)
        RoundedPanel10.PerformLayout()
        RoundedPanel9.ResumeLayout(False)
        RoundedPanel9.PerformLayout()
        RoundedPanel8.ResumeLayout(False)
        RoundedPanel8.PerformLayout()
        RoundedPanel7.ResumeLayout(False)
        RoundedPanel7.PerformLayout()
        RoundedPanel6.ResumeLayout(False)
        RoundedPanel6.PerformLayout()
        RoundedPanel5.ResumeLayout(False)
        RoundedPanel5.PerformLayout()
        RoundedPanel4.ResumeLayout(False)
        RoundedPanel4.PerformLayout()
        RoundedPanel3.ResumeLayout(False)
        RoundedPanel3.PerformLayout()
        Panel1.ResumeLayout(False)
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Label14 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents RoundedPanel2 As RoundedPanel
    Friend WithEvents lbl_Sex As Label
    Friend WithEvents lbl_Age As Label
    Friend WithEvents lbl_Email As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents lbl_Address As Label
    Friend WithEvents lbl_Phone As Label
    Friend WithEvents lbl_PrimaryDiagnoses As Label
    Friend WithEvents lbl_ParentGuardian As Label
    Friend WithEvents lbl_BloodType As Label
    Friend WithEvents lbl_DateOfBirth As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_FullName As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents RoundedPanel3 As RoundedPanel
    Friend WithEvents RoundedPanel5 As RoundedPanel
    Friend WithEvents RoundedPanel4 As RoundedPanel
    Friend WithEvents RoundedPanel6 As RoundedPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents RoundedPanel10 As RoundedPanel
    Friend WithEvents RoundedPanel9 As RoundedPanel
    Friend WithEvents RoundedPanel8 As RoundedPanel
    Friend WithEvents RoundedPanel7 As RoundedPanel
    Friend WithEvents RoundedPanel12 As RoundedPanel
    Friend WithEvents RoundedPanel11 As RoundedPanel
End Class
