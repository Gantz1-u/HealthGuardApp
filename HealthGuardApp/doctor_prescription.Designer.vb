<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class doctor_prescription
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(doctor_prescription))
        RoundedPanel1 = New RoundedPanel()
        RoundedPanel2 = New RoundedPanel()
        RoundedButton1 = New CustomControls.RJControls.RoundedButton()
        RoundedPanel3 = New RoundedPanel()
        PictureBox6 = New PictureBox()
        Button1 = New Button()
        PictureBox5 = New PictureBox()
        Label7 = New Label()
        Label2 = New Label()
        RoundedPanel4 = New RoundedPanel()
        Label6 = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        RoundedPanel5 = New RoundedPanel()
        Label4 = New Label()
        Label5 = New Label()
        PictureBox2 = New PictureBox()
        Panel1 = New Panel()
        Label3 = New Label()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        Label10 = New Label()
        RoundedPanel1.SuspendLayout()
        RoundedPanel2.SuspendLayout()
        RoundedPanel3.SuspendLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
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
        RoundedPanel1.Controls.Add(PictureBox2)
        RoundedPanel1.Controls.Add(Panel1)
        RoundedPanel1.Controls.Add(Label10)
        RoundedPanel1.CornerRadius = 35
        RoundedPanel1.Location = New Point(12, 26)
        RoundedPanel1.Name = "RoundedPanel1"
        RoundedPanel1.Size = New Size(376, 712)
        RoundedPanel1.TabIndex = 0
        ' 
        ' RoundedPanel2
        ' 
        RoundedPanel2.BackColor = SystemColors.ButtonFace
        RoundedPanel2.Controls.Add(RoundedButton1)
        RoundedPanel2.Controls.Add(RoundedPanel3)
        RoundedPanel2.CornerRadius = 20
        RoundedPanel2.Location = New Point(7, 199)
        RoundedPanel2.Name = "RoundedPanel2"
        RoundedPanel2.Size = New Size(363, 339)
        RoundedPanel2.TabIndex = 70
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
        RoundedButton1.Location = New Point(9, 149)
        RoundedButton1.Name = "RoundedButton1"
        RoundedButton1.Size = New Size(345, 40)
        RoundedButton1.TabIndex = 12
        RoundedButton1.Text = "EDIT"
        RoundedButton1.TextColor = Color.Black
        RoundedButton1.UseVisualStyleBackColor = False
        ' 
        ' RoundedPanel3
        ' 
        RoundedPanel3.BackColor = SystemColors.ButtonHighlight
        RoundedPanel3.Controls.Add(PictureBox6)
        RoundedPanel3.Controls.Add(Button1)
        RoundedPanel3.Controls.Add(PictureBox5)
        RoundedPanel3.Controls.Add(Label7)
        RoundedPanel3.Controls.Add(Label2)
        RoundedPanel3.Controls.Add(RoundedPanel4)
        RoundedPanel3.Controls.Add(Label6)
        RoundedPanel3.Controls.Add(Label1)
        RoundedPanel3.Controls.Add(PictureBox1)
        RoundedPanel3.Controls.Add(RoundedPanel5)
        RoundedPanel3.Controls.Add(Label4)
        RoundedPanel3.Controls.Add(Label5)
        RoundedPanel3.CornerRadius = 20
        RoundedPanel3.Location = New Point(13, 14)
        RoundedPanel3.Name = "RoundedPanel3"
        RoundedPanel3.Size = New Size(337, 128)
        RoundedPanel3.TabIndex = 11
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), Image)
        PictureBox6.Location = New Point(156, 98)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(16, 17)
        PictureBox6.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox6.TabIndex = 18
        PictureBox6.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(205, 10)
        Button1.Name = "Button1"
        Button1.Size = New Size(117, 21)
        Button1.TabIndex = 17
        Button1.Text = "Mark Complete"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(78, 99)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(16, 17)
        PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox5.TabIndex = 16
        PictureBox5.TabStop = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Lime
        Label7.ForeColor = Color.Black
        Label7.Location = New Point(148, 64)
        Label7.Name = "Label7"
        Label7.Size = New Size(79, 15)
        Label7.TabIndex = 15
        Label7.Text = "Every 8 Hours"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(178, 98)
        Label2.Name = "Label2"
        Label2.Size = New Size(117, 17)
        Label2.TabIndex = 2
        Label2.Text = "Dr. Ronald Dycoco"
        ' 
        ' RoundedPanel4
        ' 
        RoundedPanel4.BackColor = Color.Lime
        RoundedPanel4.CornerRadius = 20
        RoundedPanel4.Location = New Point(132, 61)
        RoundedPanel4.Name = "RoundedPanel4"
        RoundedPanel4.Size = New Size(112, 22)
        RoundedPanel4.TabIndex = 14
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.DarkViolet
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(28, 64)
        Label6.Name = "Label6"
        Label6.Size = New Size(74, 15)
        Label6.TabIndex = 13
        Label6.Text = "High Priority"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(5, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(111, 25)
        Label1.TabIndex = 1
        Label1.Text = "Amoxicillin"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(8, 99)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(16, 17)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 13
        PictureBox1.TabStop = False
        ' 
        ' RoundedPanel5
        ' 
        RoundedPanel5.BackColor = Color.DarkViolet
        RoundedPanel5.CornerRadius = 20
        RoundedPanel5.Location = New Point(9, 61)
        RoundedPanel5.Name = "RoundedPanel5"
        RoundedPanel5.Size = New Size(112, 22)
        RoundedPanel5.TabIndex = 12
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9.75F)
        Label4.Location = New Point(25, 98)
        Label4.Name = "Label4"
        Label4.Size = New Size(47, 17)
        Label4.TabIndex = 3
        Label4.Text = "7 Days"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9.75F)
        Label5.Location = New Point(97, 99)
        Label5.Name = "Label5"
        Label5.Size = New Size(52, 17)
        Label5.TabIndex = 12
        Label5.Text = "500 mg"
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
        PictureBox2.TabIndex = 72
        PictureBox2.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(PictureBox3)
        Panel1.Controls.Add(PictureBox4)
        Panel1.Location = New Point(-9, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(400, 68)
        Panel1.TabIndex = 71
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
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(130, 147)
        Label10.Name = "Label10"
        Label10.Size = New Size(120, 25)
        Label10.TabIndex = 69
        Label10.Text = "Prescription"
        ' 
        ' doctor_prescription
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(400, 750)
        Controls.Add(RoundedPanel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "doctor_prescription"
        StartPosition = FormStartPosition.CenterScreen
        Text = "doctor_prescription"
        RoundedPanel1.ResumeLayout(False)
        RoundedPanel1.PerformLayout()
        RoundedPanel2.ResumeLayout(False)
        RoundedPanel3.ResumeLayout(False)
        RoundedPanel3.PerformLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents RoundedPanel2 As RoundedPanel
    Friend WithEvents RoundedButton1 As CustomControls.RJControls.RoundedButton
    Friend WithEvents RoundedPanel3 As RoundedPanel
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents RoundedPanel4 As RoundedPanel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents RoundedPanel5 As RoundedPanel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label10 As Label
End Class
