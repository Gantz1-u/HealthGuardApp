<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InputInfoPage
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
        RoundedPanel1 = New RoundedPanel()
        RoundedButton3 = New CustomControls.RJControls.RoundedButton()
        cmb_BloodType = New ComboBox()
        cmb_Sex = New ComboBox()
        RoundedPanel5 = New RoundedPanel()
        txt_ParentGuardian = New RoundedTextBox()
        lbl_PatientID = New Label()
        lbl_Age = New Label()
        Label3 = New Label()
        Label7 = New Label()
        RoundedPanel6 = New RoundedPanel()
        txt_Address = New RoundedTextBox()
        dtp_DateOfBirth = New DateTimePicker()
        Label9 = New Label()
        Label4 = New Label()
        Label6 = New Label()
        Label10 = New Label()
        Label2 = New Label()
        lbl_FirstName = New Label()
        Label1 = New Label()
        RoundedPanel1.SuspendLayout()
        RoundedPanel5.SuspendLayout()
        RoundedPanel6.SuspendLayout()
        SuspendLayout()
        ' 
        ' RoundedPanel1
        ' 
        RoundedPanel1.BackColor = Color.White
        RoundedPanel1.Controls.Add(RoundedButton3)
        RoundedPanel1.Controls.Add(cmb_BloodType)
        RoundedPanel1.Controls.Add(cmb_Sex)
        RoundedPanel1.Controls.Add(RoundedPanel5)
        RoundedPanel1.Controls.Add(lbl_PatientID)
        RoundedPanel1.Controls.Add(lbl_Age)
        RoundedPanel1.Controls.Add(Label3)
        RoundedPanel1.Controls.Add(Label7)
        RoundedPanel1.Controls.Add(RoundedPanel6)
        RoundedPanel1.Controls.Add(dtp_DateOfBirth)
        RoundedPanel1.Controls.Add(Label9)
        RoundedPanel1.Controls.Add(Label4)
        RoundedPanel1.Controls.Add(Label6)
        RoundedPanel1.Controls.Add(Label10)
        RoundedPanel1.Controls.Add(Label2)
        RoundedPanel1.Controls.Add(lbl_FirstName)
        RoundedPanel1.Controls.Add(Label1)
        RoundedPanel1.CornerRadius = 20
        RoundedPanel1.Location = New Point(12, 26)
        RoundedPanel1.Name = "RoundedPanel1"
        RoundedPanel1.Size = New Size(376, 712)
        RoundedPanel1.TabIndex = 0
        ' 
        ' RoundedButton3
        ' 
        RoundedButton3.BackColor = SystemColors.ButtonFace
        RoundedButton3.BackgroundColor = SystemColors.ButtonFace
        RoundedButton3.BorderColor = Color.PaleVioletRed
        RoundedButton3.BorderRadius = 9
        RoundedButton3.BorderSize = 0
        RoundedButton3.Cursor = Cursors.Hand
        RoundedButton3.FlatAppearance.BorderColor = SystemColors.ButtonHighlight
        RoundedButton3.FlatAppearance.MouseDownBackColor = Color.White
        RoundedButton3.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        RoundedButton3.FlatStyle = FlatStyle.Flat
        RoundedButton3.Font = New Font("Segoe UI", 10F)
        RoundedButton3.ForeColor = Color.Black
        RoundedButton3.Location = New Point(16, 613)
        RoundedButton3.Name = "RoundedButton3"
        RoundedButton3.Size = New Size(345, 52)
        RoundedButton3.TabIndex = 52
        RoundedButton3.Text = "Submit"
        RoundedButton3.TextColor = Color.Black
        RoundedButton3.UseVisualStyleBackColor = False
        ' 
        ' cmb_BloodType
        ' 
        cmb_BloodType.FormattingEnabled = True
        cmb_BloodType.Items.AddRange(New Object() {"A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-"})
        cmb_BloodType.Location = New Point(171, 294)
        cmb_BloodType.Name = "cmb_BloodType"
        cmb_BloodType.Size = New Size(86, 23)
        cmb_BloodType.TabIndex = 48
        ' 
        ' cmb_Sex
        ' 
        cmb_Sex.FormattingEnabled = True
        cmb_Sex.Items.AddRange(New Object() {"Male", "Female"})
        cmb_Sex.Location = New Point(37, 294)
        cmb_Sex.Name = "cmb_Sex"
        cmb_Sex.Size = New Size(86, 23)
        cmb_Sex.TabIndex = 49
        ' 
        ' RoundedPanel5
        ' 
        RoundedPanel5.BackColor = SystemColors.ControlLight
        RoundedPanel5.Controls.Add(txt_ParentGuardian)
        RoundedPanel5.CornerRadius = 20
        RoundedPanel5.Location = New Point(37, 353)
        RoundedPanel5.Name = "RoundedPanel5"
        RoundedPanel5.Size = New Size(299, 34)
        RoundedPanel5.TabIndex = 51
        ' 
        ' txt_ParentGuardian
        ' 
        txt_ParentGuardian.BackColor = SystemColors.ControlLight
        txt_ParentGuardian.Location = New Point(3, 5)
        txt_ParentGuardian.Name = "txt_ParentGuardian"
        txt_ParentGuardian.Size = New Size(284, 23)
        txt_ParentGuardian.TabIndex = 5
        ' 
        ' lbl_PatientID
        ' 
        lbl_PatientID.AutoSize = True
        lbl_PatientID.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl_PatientID.Location = New Point(35, 29)
        lbl_PatientID.Name = "lbl_PatientID"
        lbl_PatientID.Size = New Size(59, 17)
        lbl_PatientID.TabIndex = 45
        lbl_PatientID.Text = "PatientID"
        ' 
        ' lbl_Age
        ' 
        lbl_Age.AutoSize = True
        lbl_Age.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl_Age.Location = New Point(282, 231)
        lbl_Age.Name = "lbl_Age"
        lbl_Age.Size = New Size(22, 17)
        lbl_Age.TabIndex = 45
        lbl_Age.Text = "00"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(171, 270)
        Label3.Name = "Label3"
        Label3.Size = New Size(73, 17)
        Label3.TabIndex = 46
        Label3.Text = "Blood Type"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(37, 273)
        Label7.Name = "Label7"
        Label7.Size = New Size(28, 17)
        Label7.TabIndex = 47
        Label7.Text = "Sex"
        ' 
        ' RoundedPanel6
        ' 
        RoundedPanel6.BackColor = SystemColors.ControlLight
        RoundedPanel6.Controls.Add(txt_Address)
        RoundedPanel6.CornerRadius = 20
        RoundedPanel6.Location = New Point(37, 424)
        RoundedPanel6.Name = "RoundedPanel6"
        RoundedPanel6.Padding = New Padding(10)
        RoundedPanel6.Size = New Size(299, 84)
        RoundedPanel6.TabIndex = 50
        ' 
        ' txt_Address
        ' 
        txt_Address.BackColor = SystemColors.ControlLight
        txt_Address.Dock = DockStyle.Fill
        txt_Address.Location = New Point(10, 10)
        txt_Address.Multiline = True
        txt_Address.Name = "txt_Address"
        txt_Address.ScrollBars = ScrollBars.Vertical
        txt_Address.Size = New Size(279, 64)
        txt_Address.TabIndex = 5
        ' 
        ' dtp_DateOfBirth
        ' 
        dtp_DateOfBirth.CustomFormat = "yyyy-MM-dd"
        dtp_DateOfBirth.Format = DateTimePickerFormat.Custom
        dtp_DateOfBirth.Location = New Point(35, 228)
        dtp_DateOfBirth.MaxDate = New Date(2025, 1, 1, 0, 0, 0, 0)
        dtp_DateOfBirth.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        dtp_DateOfBirth.Name = "dtp_DateOfBirth"
        dtp_DateOfBirth.Size = New Size(200, 23)
        dtp_DateOfBirth.TabIndex = 43
        dtp_DateOfBirth.Value = New Date(2000, 1, 1, 0, 0, 0, 0)
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(37, 333)
        Label9.Name = "Label9"
        Label9.Size = New Size(103, 17)
        Label9.TabIndex = 44
        Label9.Text = "Parent/Guardian"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(273, 205)
        Label4.Name = "Label4"
        Label4.Size = New Size(31, 17)
        Label4.TabIndex = 40
        Label4.Text = "Age"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(35, 205)
        Label6.Name = "Label6"
        Label6.Size = New Size(65, 17)
        Label6.TabIndex = 41
        Label6.Text = "Birth Date"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(37, 404)
        Label10.Name = "Label10"
        Label10.Size = New Size(56, 17)
        Label10.TabIndex = 42
        Label10.Text = "Address"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(36, 142)
        Label2.Name = "Label2"
        Label2.Size = New Size(308, 17)
        Label2.TabIndex = 39
        Label2.Text = "Only provide information that is true and correct."
        ' 
        ' lbl_FirstName
        ' 
        lbl_FirstName.AutoSize = True
        lbl_FirstName.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_FirstName.Location = New Point(33, 61)
        lbl_FirstName.Name = "lbl_FirstName"
        lbl_FirstName.Size = New Size(246, 40)
        lbl_FirstName.TabIndex = 37
        lbl_FirstName.Text = "Hello, FirstName"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(35, 121)
        Label1.Name = "Label1"
        Label1.Size = New Size(259, 21)
        Label1.TabIndex = 38
        Label1.Text = "Tell us something about yourself"
        ' 
        ' InputInfoPage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(400, 750)
        Controls.Add(RoundedPanel1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "InputInfoPage"
        StartPosition = FormStartPosition.CenterScreen
        RoundedPanel1.ResumeLayout(False)
        RoundedPanel1.PerformLayout()
        RoundedPanel5.ResumeLayout(False)
        RoundedPanel5.PerformLayout()
        RoundedPanel6.ResumeLayout(False)
        RoundedPanel6.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents RoundedButton3 As CustomControls.RJControls.RoundedButton
    Friend WithEvents cmb_BloodType As ComboBox
    Friend WithEvents cmb_Sex As ComboBox
    Friend WithEvents RoundedPanel5 As RoundedPanel
    Friend WithEvents txt_ParentGuardian As RoundedTextBox
    Friend WithEvents lbl_Age As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents RoundedPanel6 As RoundedPanel
    Friend WithEvents txt_Address As RoundedTextBox
    Friend WithEvents dtp_DateOfBirth As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_FirstName As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_PatientID As Label
End Class
