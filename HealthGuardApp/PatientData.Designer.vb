﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PatientData
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PatientData))
        RoundedPanel1 = New RoundedPanel()
        RoundedPanel2 = New RoundedPanel()
        lbl_PrimaryDiagnoses = New Label()
        lbl_Age = New Label()
        lbl_BloodType = New Label()
        lbl_Sex = New Label()
        Label3 = New Label()
        lbl_Email = New Label()
        Label4 = New Label()
        lbl_ContactNumber = New Label()
        Label5 = New Label()
        lbl_ParentGuardian = New Label()
        Label6 = New Label()
        lbl_Address = New Label()
        Label7 = New Label()
        lbl_BirthDate = New Label()
        Label10 = New Label()
        lbl_LastName = New Label()
        Label9 = New Label()
        lbl_MiddleName = New Label()
        Label8 = New Label()
        lbl_FirstName = New Label()
        Label11 = New Label()
        PictureBox1 = New PictureBox()
        Panel1 = New Panel()
        Label1 = New Label()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        Label2 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        RoundedPanel1.SuspendLayout()
        RoundedPanel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' RoundedPanel1
        ' 
        RoundedPanel1.BackgroundImage = CType(resources.GetObject("RoundedPanel1.BackgroundImage"), Image)
        RoundedPanel1.BackgroundImageLayout = ImageLayout.Stretch
        RoundedPanel1.Controls.Add(RoundedPanel2)
        RoundedPanel1.Controls.Add(PictureBox1)
        RoundedPanel1.Controls.Add(Panel1)
        RoundedPanel1.CornerRadius = 35
        RoundedPanel1.Location = New Point(12, 26)
        RoundedPanel1.Name = "RoundedPanel1"
        RoundedPanel1.Size = New Size(376, 712)
        RoundedPanel1.TabIndex = 0
        ' 
        ' RoundedPanel2
        ' 
        RoundedPanel2.BackColor = Color.White
        RoundedPanel2.Controls.Add(lbl_PrimaryDiagnoses)
        RoundedPanel2.Controls.Add(lbl_Age)
        RoundedPanel2.Controls.Add(lbl_BloodType)
        RoundedPanel2.Controls.Add(lbl_Sex)
        RoundedPanel2.Controls.Add(Label3)
        RoundedPanel2.Controls.Add(lbl_Email)
        RoundedPanel2.Controls.Add(Label4)
        RoundedPanel2.Controls.Add(lbl_ContactNumber)
        RoundedPanel2.Controls.Add(Label2)
        RoundedPanel2.Controls.Add(Label5)
        RoundedPanel2.Controls.Add(lbl_ParentGuardian)
        RoundedPanel2.Controls.Add(Label13)
        RoundedPanel2.Controls.Add(Label12)
        RoundedPanel2.Controls.Add(Label6)
        RoundedPanel2.Controls.Add(lbl_Address)
        RoundedPanel2.Controls.Add(Label7)
        RoundedPanel2.Controls.Add(lbl_BirthDate)
        RoundedPanel2.Controls.Add(Label10)
        RoundedPanel2.Controls.Add(lbl_LastName)
        RoundedPanel2.Controls.Add(Label9)
        RoundedPanel2.Controls.Add(lbl_MiddleName)
        RoundedPanel2.Controls.Add(Label8)
        RoundedPanel2.Controls.Add(lbl_FirstName)
        RoundedPanel2.Controls.Add(Label11)
        RoundedPanel2.CornerRadius = 20
        RoundedPanel2.Location = New Point(7, 139)
        RoundedPanel2.Name = "RoundedPanel2"
        RoundedPanel2.Size = New Size(362, 564)
        RoundedPanel2.TabIndex = 8
        ' 
        ' lbl_PrimaryDiagnoses
        ' 
        lbl_PrimaryDiagnoses.AutoSize = True
        lbl_PrimaryDiagnoses.Location = New Point(209, 328)
        lbl_PrimaryDiagnoses.Name = "lbl_PrimaryDiagnoses"
        lbl_PrimaryDiagnoses.Size = New Size(105, 15)
        lbl_PrimaryDiagnoses.TabIndex = 58
        lbl_PrimaryDiagnoses.Text = "Primary Diagnoses"
        ' 
        ' lbl_Age
        ' 
        lbl_Age.AutoSize = True
        lbl_Age.Location = New Point(199, 252)
        lbl_Age.Name = "lbl_Age"
        lbl_Age.Size = New Size(28, 15)
        lbl_Age.TabIndex = 57
        lbl_Age.Text = "Age"
        ' 
        ' lbl_BloodType
        ' 
        lbl_BloodType.AutoSize = True
        lbl_BloodType.Location = New Point(199, 187)
        lbl_BloodType.Name = "lbl_BloodType"
        lbl_BloodType.Size = New Size(65, 15)
        lbl_BloodType.TabIndex = 56
        lbl_BloodType.Text = "Blood Type"
        ' 
        ' lbl_Sex
        ' 
        lbl_Sex.AutoSize = True
        lbl_Sex.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl_Sex.Location = New Point(198, 74)
        lbl_Sex.Name = "lbl_Sex"
        lbl_Sex.Size = New Size(28, 17)
        lbl_Sex.TabIndex = 55
        lbl_Sex.Text = "Sex"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label3.Location = New Point(18, 16)
        Label3.Name = "Label3"
        Label3.Size = New Size(75, 17)
        Label3.TabIndex = 38
        Label3.Text = "First Name"
        ' 
        ' lbl_Email
        ' 
        lbl_Email.AutoSize = True
        lbl_Email.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl_Email.Location = New Point(22, 525)
        lbl_Email.Name = "lbl_Email"
        lbl_Email.Size = New Size(39, 17)
        lbl_Email.TabIndex = 54
        lbl_Email.Text = "Email"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label4.Location = New Point(18, 83)
        Label4.Name = "Label4"
        Label4.Size = New Size(91, 17)
        Label4.TabIndex = 39
        Label4.Text = "Middle Name"
        ' 
        ' lbl_ContactNumber
        ' 
        lbl_ContactNumber.AutoSize = True
        lbl_ContactNumber.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl_ContactNumber.Location = New Point(22, 459)
        lbl_ContactNumber.Name = "lbl_ContactNumber"
        lbl_ContactNumber.Size = New Size(100, 17)
        lbl_ContactNumber.TabIndex = 53
        lbl_ContactNumber.Text = "ContactNumber"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label5.Location = New Point(18, 152)
        Label5.Name = "Label5"
        Label5.Size = New Size(73, 17)
        Label5.TabIndex = 40
        Label5.Text = "Last Name"
        ' 
        ' lbl_ParentGuardian
        ' 
        lbl_ParentGuardian.AutoSize = True
        lbl_ParentGuardian.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl_ParentGuardian.Location = New Point(22, 387)
        lbl_ParentGuardian.Name = "lbl_ParentGuardian"
        lbl_ParentGuardian.Size = New Size(98, 17)
        lbl_ParentGuardian.TabIndex = 52
        lbl_ParentGuardian.Text = "ParentGuardian"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label6.Location = New Point(19, 221)
        Label6.Name = "Label6"
        Label6.Size = New Size(71, 17)
        Label6.TabIndex = 41
        Label6.Text = "Birth Date"
        ' 
        ' lbl_Address
        ' 
        lbl_Address.AutoSize = True
        lbl_Address.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl_Address.Location = New Point(22, 311)
        lbl_Address.Name = "lbl_Address"
        lbl_Address.Size = New Size(56, 17)
        lbl_Address.TabIndex = 51
        lbl_Address.Text = "Address"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label7.Location = New Point(198, 43)
        Label7.Name = "Label7"
        Label7.Size = New Size(29, 17)
        Label7.TabIndex = 42
        Label7.Text = "Sex"
        ' 
        ' lbl_BirthDate
        ' 
        lbl_BirthDate.AutoSize = True
        lbl_BirthDate.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl_BirthDate.Location = New Point(22, 252)
        lbl_BirthDate.Name = "lbl_BirthDate"
        lbl_BirthDate.Size = New Size(88, 17)
        lbl_BirthDate.TabIndex = 50
        lbl_BirthDate.Text = "YYYY-MM-DD"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label10.Location = New Point(18, 287)
        Label10.Name = "Label10"
        Label10.Size = New Size(57, 17)
        Label10.TabIndex = 43
        Label10.Text = "Address"
        ' 
        ' lbl_LastName
        ' 
        lbl_LastName.AutoSize = True
        lbl_LastName.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl_LastName.Location = New Point(22, 183)
        lbl_LastName.Name = "lbl_LastName"
        lbl_LastName.Size = New Size(66, 17)
        lbl_LastName.TabIndex = 49
        lbl_LastName.Text = "LastName"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label9.Location = New Point(18, 357)
        Label9.Name = "Label9"
        Label9.Size = New Size(110, 17)
        Label9.TabIndex = 44
        Label9.Text = "Parent/Guardian"
        ' 
        ' lbl_MiddleName
        ' 
        lbl_MiddleName.AutoSize = True
        lbl_MiddleName.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl_MiddleName.Location = New Point(22, 116)
        lbl_MiddleName.Name = "lbl_MiddleName"
        lbl_MiddleName.Size = New Size(84, 17)
        lbl_MiddleName.TabIndex = 48
        lbl_MiddleName.Text = "MiddleName"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label8.Location = New Point(18, 428)
        Label8.Name = "Label8"
        Label8.Size = New Size(101, 17)
        Label8.TabIndex = 45
        Label8.Text = "Phone Number"
        ' 
        ' lbl_FirstName
        ' 
        lbl_FirstName.AutoSize = True
        lbl_FirstName.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl_FirstName.Location = New Point(22, 43)
        lbl_FirstName.Name = "lbl_FirstName"
        lbl_FirstName.Size = New Size(67, 17)
        lbl_FirstName.TabIndex = 47
        lbl_FirstName.Text = "FirstName"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label11.Location = New Point(19, 499)
        Label11.Name = "Label11"
        Label11.Size = New Size(42, 17)
        Label11.TabIndex = 46
        Label11.Text = "Email"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Cursor = Cursors.Hand
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(13, 81)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(38, 36)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 68
        PictureBox1.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox3)
        Panel1.Controls.Add(PictureBox4)
        Panel1.Location = New Point(-9, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(400, 68)
        Panel1.TabIndex = 67
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(322, 42)
        Label1.Name = "Label1"
        Label1.Size = New Size(47, 16)
        Label1.TabIndex = 25
        Label1.Text = "HOME"
        Label1.TextAlign = ContentAlignment.TopCenter
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
        PictureBox3.TabIndex = 24
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.Transparent
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(-9, -12)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(145, 90)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 23
        PictureBox4.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label2.Location = New Point(191, 152)
        Label2.Name = "Label2"
        Label2.Size = New Size(77, 17)
        Label2.TabIndex = 40
        Label2.Text = "Blood Type"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label12.Location = New Point(191, 221)
        Label12.Name = "Label12"
        Label12.Size = New Size(32, 17)
        Label12.TabIndex = 41
        Label12.Text = "Age"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label13.Location = New Point(194, 287)
        Label13.Name = "Label13"
        Label13.Size = New Size(125, 17)
        Label13.TabIndex = 41
        Label13.Text = "Primary Diagnoses"
        ' 
        ' PatientData
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(400, 750)
        Controls.Add(RoundedPanel1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "PatientData"
        StartPosition = FormStartPosition.CenterScreen
        Text = "PaatientData"
        RoundedPanel1.ResumeLayout(False)
        RoundedPanel2.ResumeLayout(False)
        RoundedPanel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents RoundedPanel2 As RoundedPanel
    Friend WithEvents lbl_PrimaryDiagnoses As Label
    Friend WithEvents lbl_Age As Label
    Friend WithEvents lbl_BloodType As Label
    Friend WithEvents lbl_Sex As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_Email As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lbl_ContactNumber As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_ParentGuardian As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lbl_Address As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lbl_BirthDate As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lbl_LastName As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lbl_MiddleName As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lbl_FirstName As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
End Class
