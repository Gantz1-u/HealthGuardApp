<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DoctorPrescription
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DoctorPrescription))
        PictureBox2 = New PictureBox()
        RoundedPanel1 = New RoundedPanel()
        txt_Instruction = New RoundedTextBox()
        txt_Duration = New RoundedTextBox()
        txt_Frequency = New RoundedTextBox()
        txt_Dosage = New RoundedTextBox()
        txt_MedicineName = New RoundedTextBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        RoundedButton2 = New CustomControls.RJControls.RoundedButton()
        RoundedButton1 = New CustomControls.RJControls.RoundedButton()
        Panel1 = New Panel()
        Label3 = New Label()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        lbl_SelectedPatient = New Label()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        RoundedPanel1.SuspendLayout()
        Panel1.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Cursor = Cursors.Hand
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(15, 98)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(38, 36)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 14
        PictureBox2.TabStop = False
        ' 
        ' RoundedPanel1
        ' 
        RoundedPanel1.Controls.Add(txt_Instruction)
        RoundedPanel1.Controls.Add(txt_Duration)
        RoundedPanel1.Controls.Add(txt_Frequency)
        RoundedPanel1.Controls.Add(txt_Dosage)
        RoundedPanel1.Controls.Add(txt_MedicineName)
        RoundedPanel1.Controls.Add(Label6)
        RoundedPanel1.Controls.Add(Label5)
        RoundedPanel1.Controls.Add(Label4)
        RoundedPanel1.Controls.Add(Label2)
        RoundedPanel1.Controls.Add(Label1)
        RoundedPanel1.Controls.Add(RoundedButton2)
        RoundedPanel1.Controls.Add(RoundedButton1)
        RoundedPanel1.CornerRadius = 20
        RoundedPanel1.Location = New Point(17, 171)
        RoundedPanel1.Name = "RoundedPanel1"
        RoundedPanel1.Size = New Size(364, 266)
        RoundedPanel1.TabIndex = 13
        ' 
        ' txt_Instruction
        ' 
        txt_Instruction.BackColor = Color.White
        txt_Instruction.Location = New Point(95, 120)
        txt_Instruction.Name = "txt_Instruction"
        txt_Instruction.Size = New Size(221, 23)
        txt_Instruction.TabIndex = 24
        ' 
        ' txt_Duration
        ' 
        txt_Duration.BackColor = Color.White
        txt_Duration.Location = New Point(75, 94)
        txt_Duration.Name = "txt_Duration"
        txt_Duration.Size = New Size(221, 23)
        txt_Duration.TabIndex = 23
        ' 
        ' txt_Frequency
        ' 
        txt_Frequency.BackColor = Color.White
        txt_Frequency.Location = New Point(87, 65)
        txt_Frequency.Name = "txt_Frequency"
        txt_Frequency.Size = New Size(221, 23)
        txt_Frequency.TabIndex = 22
        ' 
        ' txt_Dosage
        ' 
        txt_Dosage.BackColor = Color.White
        txt_Dosage.Location = New Point(75, 40)
        txt_Dosage.Name = "txt_Dosage"
        txt_Dosage.Size = New Size(221, 23)
        txt_Dosage.TabIndex = 21
        ' 
        ' txt_MedicineName
        ' 
        txt_MedicineName.BackColor = Color.White
        txt_MedicineName.Location = New Point(124, 16)
        txt_MedicineName.Name = "txt_MedicineName"
        txt_MedicineName.Size = New Size(221, 23)
        txt_MedicineName.TabIndex = 20
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(8, 123)
        Label6.Name = "Label6"
        Label6.Size = New Size(81, 15)
        Label6.TabIndex = 19
        Label6.Text = "INSTRUCTION"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(8, 97)
        Label5.Name = "Label5"
        Label5.Size = New Size(64, 15)
        Label5.TabIndex = 18
        Label5.Text = "DURATION"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(8, 68)
        Label4.Name = "Label4"
        Label4.Size = New Size(73, 15)
        Label4.TabIndex = 17
        Label4.Text = "FREQUENCY"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(8, 43)
        Label2.Name = "Label2"
        Label2.Size = New Size(52, 15)
        Label2.TabIndex = 16
        Label2.Text = "DOSAGE"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(8, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(98, 15)
        Label1.TabIndex = 15
        Label1.Text = "MEDICINE NAME"
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
        RoundedButton2.ForeColor = Color.Black
        RoundedButton2.Location = New Point(8, 165)
        RoundedButton2.Name = "RoundedButton2"
        RoundedButton2.Size = New Size(345, 40)
        RoundedButton2.TabIndex = 14
        RoundedButton2.Text = "SAVE"
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
        RoundedButton1.FlatAppearance.BorderSize = 0
        RoundedButton1.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        RoundedButton1.FlatStyle = FlatStyle.Flat
        RoundedButton1.ForeColor = Color.Black
        RoundedButton1.Location = New Point(8, 211)
        RoundedButton1.Name = "RoundedButton1"
        RoundedButton1.Size = New Size(345, 40)
        RoundedButton1.TabIndex = 0
        RoundedButton1.Text = "EDIT"
        RoundedButton1.TextColor = Color.Black
        RoundedButton1.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(PictureBox3)
        Panel1.Controls.Add(PictureBox4)
        Panel1.Location = New Point(-12, -1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(422, 68)
        Panel1.TabIndex = 12
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
        ' lbl_SelectedPatient
        ' 
        lbl_SelectedPatient.AutoSize = True
        lbl_SelectedPatient.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl_SelectedPatient.Location = New Point(74, 104)
        lbl_SelectedPatient.Name = "lbl_SelectedPatient"
        lbl_SelectedPatient.Size = New Size(185, 25)
        lbl_SelectedPatient.TabIndex = 15
        lbl_SelectedPatient.Text = "FirstName LastName"
        ' 
        ' DoctorPrescription
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(400, 750)
        Controls.Add(PictureBox2)
        Controls.Add(RoundedPanel1)
        Controls.Add(Panel1)
        Controls.Add(lbl_SelectedPatient)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "DoctorPrescription"
        StartPosition = FormStartPosition.CenterScreen
        Text = "DoctorPrescription"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        RoundedPanel1.ResumeLayout(False)
        RoundedPanel1.PerformLayout()
        Panel1.ResumeLayout(False)
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents RoundedButton1 As CustomControls.RJControls.RoundedButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents RoundedButton2 As CustomControls.RJControls.RoundedButton
    Friend WithEvents txt_Instruction As RoundedTextBox
    Friend WithEvents txt_Duration As RoundedTextBox
    Friend WithEvents txt_Frequency As RoundedTextBox
    Friend WithEvents txt_Dosage As RoundedTextBox
    Friend WithEvents txt_MedicineName As RoundedTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_SelectedPatient As Label
End Class
