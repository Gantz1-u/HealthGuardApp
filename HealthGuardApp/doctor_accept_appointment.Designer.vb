﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class doctor_accept_appointment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(doctor_accept_appointment))
        Panel1 = New Panel()
        Label3 = New Label()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        RoundedPanel1 = New RoundedPanel()
        RoundedButton3 = New CustomControls.RJControls.RoundedButton()
        RoundedButton2 = New CustomControls.RJControls.RoundedButton()
        Label4 = New Label()
        Label2 = New Label()
        RoundedButton1 = New CustomControls.RJControls.RoundedButton()
        Label7 = New Label()
        CirclePictureBox2 = New CirclePictureBox()
        Label11 = New Label()
        Label8 = New Label()
        Label10 = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Panel1.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        RoundedPanel1.SuspendLayout()
        CType(CirclePictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(PictureBox3)
        Panel1.Controls.Add(PictureBox4)
        Panel1.Location = New Point(-19, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(422, 68)
        Panel1.TabIndex = 63
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
        ' RoundedPanel1
        ' 
        RoundedPanel1.BackColor = Color.PaleGreen
        RoundedPanel1.BorderStyle = BorderStyle.FixedSingle
        RoundedPanel1.Controls.Add(RoundedButton3)
        RoundedPanel1.Controls.Add(RoundedButton2)
        RoundedPanel1.Controls.Add(Label4)
        RoundedPanel1.Controls.Add(Label2)
        RoundedPanel1.Controls.Add(RoundedButton1)
        RoundedPanel1.Controls.Add(Label7)
        RoundedPanel1.Controls.Add(CirclePictureBox2)
        RoundedPanel1.Controls.Add(Label11)
        RoundedPanel1.Controls.Add(Label8)
        RoundedPanel1.Controls.Add(Label10)
        RoundedPanel1.CornerRadius = 20
        RoundedPanel1.Location = New Point(23, 165)
        RoundedPanel1.Name = "RoundedPanel1"
        RoundedPanel1.Size = New Size(324, 162)
        RoundedPanel1.TabIndex = 92
        ' 
        ' RoundedButton3
        ' 
        RoundedButton3.BackColor = SystemColors.ControlLight
        RoundedButton3.BackgroundColor = SystemColors.ControlLight
        RoundedButton3.BorderColor = Color.Black
        RoundedButton3.BorderRadius = 9
        RoundedButton3.BorderSize = 1
        RoundedButton3.FlatAppearance.BorderSize = 0
        RoundedButton3.FlatAppearance.MouseOverBackColor = Color.Red
        RoundedButton3.FlatStyle = FlatStyle.Flat
        RoundedButton3.ForeColor = Color.Black
        RoundedButton3.ImageAlign = ContentAlignment.MiddleLeft
        RoundedButton3.Location = New Point(160, 121)
        RoundedButton3.Name = "RoundedButton3"
        RoundedButton3.Size = New Size(86, 25)
        RoundedButton3.TabIndex = 28
        RoundedButton3.Text = "Decline"
        RoundedButton3.TextColor = Color.Black
        RoundedButton3.UseVisualStyleBackColor = False
        ' 
        ' RoundedButton2
        ' 
        RoundedButton2.BackColor = SystemColors.ControlLight
        RoundedButton2.BackgroundColor = SystemColors.ControlLight
        RoundedButton2.BorderColor = Color.Black
        RoundedButton2.BorderRadius = 9
        RoundedButton2.BorderSize = 1
        RoundedButton2.FlatAppearance.BorderSize = 0
        RoundedButton2.FlatAppearance.MouseOverBackColor = Color.Green
        RoundedButton2.FlatStyle = FlatStyle.Flat
        RoundedButton2.ForeColor = Color.Black
        RoundedButton2.ImageAlign = ContentAlignment.MiddleLeft
        RoundedButton2.Location = New Point(68, 121)
        RoundedButton2.Name = "RoundedButton2"
        RoundedButton2.Size = New Size(86, 25)
        RoundedButton2.TabIndex = 27
        RoundedButton2.Text = "Accept"
        RoundedButton2.TextColor = Color.Black
        RoundedButton2.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(6, 97)
        Label4.Name = "Label4"
        Label4.Size = New Size(122, 15)
        Label4.TabIndex = 26
        Label4.Text = "Healthcare Provider:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(6, 78)
        Label2.Name = "Label2"
        Label2.Size = New Size(38, 15)
        Label2.TabIndex = 25
        Label2.Text = "Time:"
        ' 
        ' RoundedButton1
        ' 
        RoundedButton1.BackColor = Color.Transparent
        RoundedButton1.BackgroundColor = Color.Transparent
        RoundedButton1.BorderColor = Color.Lime
        RoundedButton1.BorderRadius = 9
        RoundedButton1.BorderSize = 1
        RoundedButton1.FlatAppearance.BorderSize = 0
        RoundedButton1.FlatAppearance.MouseOverBackColor = Color.Lime
        RoundedButton1.FlatStyle = FlatStyle.Flat
        RoundedButton1.ForeColor = Color.Black
        RoundedButton1.Image = CType(resources.GetObject("RoundedButton1.Image"), Image)
        RoundedButton1.ImageAlign = ContentAlignment.MiddleLeft
        RoundedButton1.Location = New Point(233, 4)
        RoundedButton1.Name = "RoundedButton1"
        RoundedButton1.Size = New Size(86, 25)
        RoundedButton1.TabIndex = 24
        RoundedButton1.Text = "Inpatient"
        RoundedButton1.TextAlign = ContentAlignment.MiddleRight
        RoundedButton1.TextColor = Color.Black
        RoundedButton1.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(6, 59)
        Label7.Name = "Label7"
        Label7.Size = New Size(37, 15)
        Label7.TabIndex = 19
        Label7.Text = "Date:"
        ' 
        ' CirclePictureBox2
        ' 
        CirclePictureBox2.BackColor = SystemColors.Control
        CirclePictureBox2.BorderRadius = 20
        CirclePictureBox2.Image = CType(resources.GetObject("CirclePictureBox2.Image"), Image)
        CirclePictureBox2.Location = New Point(3, 4)
        CirclePictureBox2.Name = "CirclePictureBox2"
        CirclePictureBox2.Size = New Size(62, 43)
        CirclePictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        CirclePictureBox2.TabIndex = 8
        CirclePictureBox2.TabStop = False
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label11.Location = New Point(140, 4)
        Label11.Name = "Label11"
        Label11.Size = New Size(67, 15)
        Label11.TabIndex = 15
        Label11.Text = "First Name"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label8.Location = New Point(71, 24)
        Label8.Name = "Label8"
        Label8.Size = New Size(66, 15)
        Label8.TabIndex = 18
        Label8.Text = "Student Id"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label10.Location = New Point(71, 4)
        Label10.Name = "Label10"
        Label10.Size = New Size(65, 15)
        Label10.TabIndex = 16
        Label10.Text = "Last Name"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(109, 128)
        Label1.Name = "Label1"
        Label1.Size = New Size(131, 25)
        Label1.TabIndex = 91
        Label1.Text = "Appointment"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Cursor = Cursors.Hand
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(6, 97)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(38, 36)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 90
        PictureBox1.TabStop = False
        ' 
        ' doctor_accept_appointment
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(400, 750)
        Controls.Add(RoundedPanel1)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "doctor_accept_appointment"
        StartPosition = FormStartPosition.CenterScreen
        Text = "doctor_accept_appointment"
        Panel1.ResumeLayout(False)
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        RoundedPanel1.ResumeLayout(False)
        RoundedPanel1.PerformLayout()
        CType(CirclePictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents Label7 As Label
    Friend WithEvents CirclePictureBox2 As CirclePictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents RoundedButton1 As CustomControls.RJControls.RoundedButton
    Friend WithEvents RoundedButton3 As CustomControls.RJControls.RoundedButton
    Friend WithEvents RoundedButton2 As CustomControls.RJControls.RoundedButton
End Class
