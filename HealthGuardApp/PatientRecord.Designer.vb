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
        Panel1 = New Panel()
        Label3 = New Label()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox2 = New PictureBox()
        RoundedPanel1 = New RoundedPanel()
        lbl_Sex = New Label()
        lbl_Age = New Label()
        lbl_Email = New Label()
        Label20 = New Label()
        lbl_Address = New Label()
        lbl_Phone = New Label()
        lbl_PrimaryDiagnoses = New Label()
        lbl_ParentGuardian = New Label()
        lbl_BloodType = New Label()
        lbl_DateOfBirth = New Label()
        CirclePictureBox4 = New CirclePictureBox()
        CirclePictureBox3 = New CirclePictureBox()
        CirclePictureBox1 = New CirclePictureBox()
        Label13 = New Label()
        Label12 = New Label()
        Label11 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        lbl_FullName = New Label()
        lbl_PatientID = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        RoundedPanel1.SuspendLayout()
        CType(CirclePictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(CirclePictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(CirclePictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(PictureBox3)
        Panel1.Controls.Add(PictureBox4)
        Panel1.Location = New Point(-19, -5)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(422, 68)
        Panel1.TabIndex = 59
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(22, 42)
        Label3.Name = "Label3"
        Label3.Size = New Size(47, 16)
        Label3.TabIndex = 5
        Label3.Text = "MENU"
        Label3.TextAlign = ContentAlignment.TopCenter
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Transparent
        PictureBox3.Cursor = Cursors.Hand
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(24, 14)
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
        PictureBox4.Location = New Point(48, -11)
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
        PictureBox2.Location = New Point(27, 87)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(38, 36)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 58
        PictureBox2.TabStop = False
        ' 
        ' RoundedPanel1
        ' 
        RoundedPanel1.BackColor = SystemColors.ButtonHighlight
        RoundedPanel1.Controls.Add(lbl_Sex)
        RoundedPanel1.Controls.Add(lbl_Age)
        RoundedPanel1.Controls.Add(lbl_Email)
        RoundedPanel1.Controls.Add(Label20)
        RoundedPanel1.Controls.Add(lbl_Address)
        RoundedPanel1.Controls.Add(lbl_Phone)
        RoundedPanel1.Controls.Add(lbl_PrimaryDiagnoses)
        RoundedPanel1.Controls.Add(lbl_ParentGuardian)
        RoundedPanel1.Controls.Add(lbl_BloodType)
        RoundedPanel1.Controls.Add(lbl_DateOfBirth)
        RoundedPanel1.Controls.Add(CirclePictureBox4)
        RoundedPanel1.Controls.Add(CirclePictureBox3)
        RoundedPanel1.Controls.Add(CirclePictureBox1)
        RoundedPanel1.Controls.Add(Label13)
        RoundedPanel1.Controls.Add(Label12)
        RoundedPanel1.Controls.Add(Label11)
        RoundedPanel1.Controls.Add(Label10)
        RoundedPanel1.Controls.Add(Label9)
        RoundedPanel1.Controls.Add(Label8)
        RoundedPanel1.Controls.Add(Label7)
        RoundedPanel1.Controls.Add(Label6)
        RoundedPanel1.Controls.Add(Label5)
        RoundedPanel1.Controls.Add(lbl_FullName)
        RoundedPanel1.CornerRadius = 20
        RoundedPanel1.Location = New Point(12, 142)
        RoundedPanel1.Name = "RoundedPanel1"
        RoundedPanel1.Size = New Size(360, 543)
        RoundedPanel1.TabIndex = 60
        ' 
        ' lbl_Sex
        ' 
        lbl_Sex.AutoSize = True
        lbl_Sex.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_Sex.Location = New Point(159, 58)
        lbl_Sex.Name = "lbl_Sex"
        lbl_Sex.Size = New Size(43, 20)
        lbl_Sex.TabIndex = 82
        lbl_Sex.Text = "Male"
        ' 
        ' lbl_Age
        ' 
        lbl_Age.AutoSize = True
        lbl_Age.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_Age.Location = New Point(86, 58)
        lbl_Age.Name = "lbl_Age"
        lbl_Age.Size = New Size(23, 20)
        lbl_Age.TabIndex = 81
        lbl_Age.Text = "19"
        ' 
        ' lbl_Email
        ' 
        lbl_Email.AutoSize = True
        lbl_Email.Location = New Point(79, 507)
        lbl_Email.Name = "lbl_Email"
        lbl_Email.Size = New Size(91, 15)
        lbl_Email.TabIndex = 80
        lbl_Email.Text = "123 Main St, QC"
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        Label20.Location = New Point(41, 209)
        Label20.Name = "Label20"
        Label20.Size = New Size(125, 17)
        Label20.TabIndex = 79
        Label20.Text = "Primary Diagnoses"
        ' 
        ' lbl_Address
        ' 
        lbl_Address.AutoSize = True
        lbl_Address.Location = New Point(79, 438)
        lbl_Address.Name = "lbl_Address"
        lbl_Address.Size = New Size(123, 15)
        lbl_Address.TabIndex = 78
        lbl_Address.Text = "juan.cruz@gmail.com"
        ' 
        ' lbl_Phone
        ' 
        lbl_Phone.AutoSize = True
        lbl_Phone.Location = New Point(79, 375)
        lbl_Phone.Name = "lbl_Phone"
        lbl_Phone.Size = New Size(73, 15)
        lbl_Phone.TabIndex = 77
        lbl_Phone.Text = "09171234567"
        ' 
        ' lbl_PrimaryDiagnoses
        ' 
        lbl_PrimaryDiagnoses.AutoSize = True
        lbl_PrimaryDiagnoses.Location = New Point(42, 240)
        lbl_PrimaryDiagnoses.Name = "lbl_PrimaryDiagnoses"
        lbl_PrimaryDiagnoses.Size = New Size(78, 15)
        lbl_PrimaryDiagnoses.TabIndex = 76
        lbl_PrimaryDiagnoses.Text = "Hypertension"
        ' 
        ' lbl_ParentGuardian
        ' 
        lbl_ParentGuardian.AutoSize = True
        lbl_ParentGuardian.Location = New Point(42, 178)
        lbl_ParentGuardian.Name = "lbl_ParentGuardian"
        lbl_ParentGuardian.Size = New Size(90, 15)
        lbl_ParentGuardian.TabIndex = 75
        lbl_ParentGuardian.Text = "Maria Dela Cruz"
        ' 
        ' lbl_BloodType
        ' 
        lbl_BloodType.AutoSize = True
        lbl_BloodType.Location = New Point(201, 120)
        lbl_BloodType.Name = "lbl_BloodType"
        lbl_BloodType.Size = New Size(22, 15)
        lbl_BloodType.TabIndex = 74
        lbl_BloodType.Text = "B+"
        ' 
        ' lbl_DateOfBirth
        ' 
        lbl_DateOfBirth.AutoSize = True
        lbl_DateOfBirth.Location = New Point(40, 120)
        lbl_DateOfBirth.Name = "lbl_DateOfBirth"
        lbl_DateOfBirth.Size = New Size(65, 15)
        lbl_DateOfBirth.TabIndex = 73
        lbl_DateOfBirth.Text = "2005-01-04"
        ' 
        ' CirclePictureBox4
        ' 
        CirclePictureBox4.BorderRadius = 20
        CirclePictureBox4.Image = CType(resources.GetObject("CirclePictureBox4.Image"), Image)
        CirclePictureBox4.Location = New Point(41, 340)
        CirclePictureBox4.Name = "CirclePictureBox4"
        CirclePictureBox4.Size = New Size(39, 23)
        CirclePictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        CirclePictureBox4.TabIndex = 72
        CirclePictureBox4.TabStop = False
        ' 
        ' CirclePictureBox3
        ' 
        CirclePictureBox3.BorderRadius = 20
        CirclePictureBox3.Image = CType(resources.GetObject("CirclePictureBox3.Image"), Image)
        CirclePictureBox3.Location = New Point(41, 403)
        CirclePictureBox3.Name = "CirclePictureBox3"
        CirclePictureBox3.Size = New Size(39, 23)
        CirclePictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        CirclePictureBox3.TabIndex = 71
        CirclePictureBox3.TabStop = False
        ' 
        ' CirclePictureBox1
        ' 
        CirclePictureBox1.BorderRadius = 20
        CirclePictureBox1.Image = CType(resources.GetObject("CirclePictureBox1.Image"), Image)
        CirclePictureBox1.Location = New Point(42, 472)
        CirclePictureBox1.Name = "CirclePictureBox1"
        CirclePictureBox1.Size = New Size(39, 23)
        CirclePictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        CirclePictureBox1.TabIndex = 70
        CirclePictureBox1.TabStop = False
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label13.Location = New Point(81, 475)
        Label13.Name = "Label13"
        Label13.Size = New Size(57, 17)
        Label13.TabIndex = 69
        Label13.Text = "Address"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label12.Location = New Point(79, 407)
        Label12.Name = "Label12"
        Label12.Size = New Size(42, 17)
        Label12.TabIndex = 68
        Label12.Text = "Email"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label11.Location = New Point(75, 344)
        Label11.Name = "Label11"
        Label11.Size = New Size(101, 17)
        Label11.TabIndex = 67
        Label11.Text = "Phone Number"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        Label10.Location = New Point(40, 299)
        Label10.Name = "Label10"
        Label10.Size = New Size(152, 20)
        Label10.TabIndex = 66
        Label10.Text = "Contact Information"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label9.Location = New Point(40, 150)
        Label9.Name = "Label9"
        Label9.Size = New Size(110, 17)
        Label9.TabIndex = 65
        Label9.Text = "Parent/Guardian"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label8.Location = New Point(201, 93)
        Label8.Name = "Label8"
        Label8.Size = New Size(77, 17)
        Label8.TabIndex = 64
        Label8.Text = "Blood Type"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label7.Location = New Point(40, 93)
        Label7.Name = "Label7"
        Label7.Size = New Size(88, 17)
        Label7.TabIndex = 63
        Label7.Text = "Date of Birth"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        Label6.Location = New Point(117, 58)
        Label6.Name = "Label6"
        Label6.Size = New Size(45, 20)
        Label6.TabIndex = 62
        Label6.Text = "Sex : "
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        Label5.Location = New Point(42, 58)
        Label5.Name = "Label5"
        Label5.Size = New Size(45, 20)
        Label5.TabIndex = 61
        Label5.Text = "Age :"
        ' 
        ' lbl_FullName
        ' 
        lbl_FullName.AutoSize = True
        lbl_FullName.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        lbl_FullName.Location = New Point(42, 22)
        lbl_FullName.Name = "lbl_FullName"
        lbl_FullName.Size = New Size(76, 20)
        lbl_FullName.TabIndex = 59
        lbl_FullName.Text = "FullName"
        ' 
        ' lbl_PatientID
        ' 
        lbl_PatientID.AutoSize = True
        lbl_PatientID.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        lbl_PatientID.Location = New Point(79, 103)
        lbl_PatientID.Name = "lbl_PatientID"
        lbl_PatientID.Size = New Size(79, 20)
        lbl_PatientID.TabIndex = 59
        lbl_PatientID.Text = "Patient #?"
        ' 
        ' PatientRecord
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(384, 711)
        Controls.Add(RoundedPanel1)
        Controls.Add(Panel1)
        Controls.Add(PictureBox2)
        Controls.Add(lbl_PatientID)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "PatientRecord"
        StartPosition = FormStartPosition.CenterScreen
        Text = "PatientRecord"
        Panel1.ResumeLayout(False)
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        RoundedPanel1.ResumeLayout(False)
        RoundedPanel1.PerformLayout()
        CType(CirclePictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(CirclePictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(CirclePictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents lbl_Email As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents lbl_Address As Label
    Friend WithEvents lbl_Phone As Label
    Friend WithEvents lbl_PrimaryDiagnoses As Label
    Friend WithEvents lbl_ParentGuardian As Label
    Friend WithEvents lbl_BloodType As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents CirclePictureBox4 As CirclePictureBox
    Friend WithEvents CirclePictureBox3 As CirclePictureBox
    Friend WithEvents CirclePictureBox1 As CirclePictureBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents lbl_Age As Label
    Friend WithEvents lbl_PatientID As Label
    Friend WithEvents lbl_Sex As Label
    Friend WithEvents lbl_FullName As Label
    Friend WithEvents lbl_DateOfBirth As Label
End Class
