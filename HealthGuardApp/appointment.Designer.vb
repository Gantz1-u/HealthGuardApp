<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class appointment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(appointment))
        Panel2 = New Panel()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        PictureBox5 = New PictureBox()
        PictureBox2 = New PictureBox()
        Label2 = New Label()
        RoundedButton3 = New CustomControls.RJControls.RoundedButton()
        DateTimePicker1 = New DateTimePicker()
        RoundedButton1 = New CustomControls.RJControls.RoundedButton()
        RoundedButton2 = New CustomControls.RJControls.RoundedButton()
        RoundedButton4 = New CustomControls.RJControls.RoundedButton()
        RoundedButton5 = New CustomControls.RJControls.RoundedButton()
        RoundedButton6 = New CustomControls.RJControls.RoundedButton()
        RoundedButton7 = New CustomControls.RJControls.RoundedButton()
        RoundedButton8 = New CustomControls.RJControls.RoundedButton()
        RoundedButton9 = New CustomControls.RJControls.RoundedButton()
        RoundedButton10 = New CustomControls.RJControls.RoundedButton()
        RoundedButton11 = New CustomControls.RJControls.RoundedButton()
        RoundedButton12 = New CustomControls.RJControls.RoundedButton()
        RoundedButton13 = New CustomControls.RJControls.RoundedButton()
        RoundedButton14 = New CustomControls.RJControls.RoundedButton()
        RoundedButton15 = New CustomControls.RJControls.RoundedButton()
        Label3 = New Label()
        RoundedTextBox1 = New RoundedTextBox()
        RoundedButton16 = New CustomControls.RJControls.RoundedButton()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Transparent
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(PictureBox1)
        Panel2.Controls.Add(PictureBox5)
        Panel2.Location = New Point(0, 3)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(422, 68)
        Panel2.TabIndex = 19
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(22, 42)
        Label1.Name = "Label1"
        Label1.Size = New Size(47, 16)
        Label1.TabIndex = 5
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
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = Color.Transparent
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(48, -11)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(142, 90)
        PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox5.TabIndex = 2
        PictureBox5.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Cursor = Cursors.Hand
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(28, 104)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(38, 36)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 13
        PictureBox2.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(104, 158)
        Label2.Name = "Label2"
        Label2.Size = New Size(166, 32)
        Label2.TabIndex = 20
        Label2.Text = "Appointment"
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
        RoundedButton3.FlatAppearance.MouseDownBackColor = Color.White
        RoundedButton3.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        RoundedButton3.FlatStyle = FlatStyle.Flat
        RoundedButton3.Font = New Font("Segoe UI", 10.0F)
        RoundedButton3.ForeColor = Color.Black
        RoundedButton3.Location = New Point(48, 253)
        RoundedButton3.Name = "RoundedButton3"
        RoundedButton3.Size = New Size(92, 35)
        RoundedButton3.TabIndex = 52
        RoundedButton3.Text = "9:00"
        RoundedButton3.TextColor = Color.Black
        RoundedButton3.UseVisualStyleBackColor = False
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(35, 209)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(313, 23)
        DateTimePicker1.TabIndex = 53
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
        RoundedButton1.Font = New Font("Segoe UI", 10.0F)
        RoundedButton1.ForeColor = Color.Black
        RoundedButton1.Location = New Point(146, 253)
        RoundedButton1.Name = "RoundedButton1"
        RoundedButton1.Size = New Size(92, 35)
        RoundedButton1.TabIndex = 54
        RoundedButton1.Text = "9:30"
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
        RoundedButton2.Cursor = Cursors.Hand
        RoundedButton2.FlatAppearance.BorderColor = SystemColors.ButtonHighlight
        RoundedButton2.FlatAppearance.MouseDownBackColor = Color.White
        RoundedButton2.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        RoundedButton2.FlatStyle = FlatStyle.Flat
        RoundedButton2.Font = New Font("Segoe UI", 10.0F)
        RoundedButton2.ForeColor = Color.Black
        RoundedButton2.Location = New Point(246, 253)
        RoundedButton2.Name = "RoundedButton2"
        RoundedButton2.Size = New Size(92, 35)
        RoundedButton2.TabIndex = 56
        RoundedButton2.Text = "10:00"
        RoundedButton2.TextColor = Color.Black
        RoundedButton2.UseVisualStyleBackColor = False
        ' 
        ' RoundedButton4
        ' 
        RoundedButton4.BackColor = SystemColors.ButtonHighlight
        RoundedButton4.BackgroundColor = SystemColors.ButtonHighlight
        RoundedButton4.BorderColor = Color.PaleVioletRed
        RoundedButton4.BorderRadius = 9
        RoundedButton4.BorderSize = 0
        RoundedButton4.Cursor = Cursors.Hand
        RoundedButton4.FlatAppearance.BorderColor = SystemColors.ButtonHighlight
        RoundedButton4.FlatAppearance.MouseDownBackColor = Color.White
        RoundedButton4.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        RoundedButton4.FlatStyle = FlatStyle.Flat
        RoundedButton4.Font = New Font("Segoe UI", 10.0F)
        RoundedButton4.ForeColor = Color.Black
        RoundedButton4.Location = New Point(246, 294)
        RoundedButton4.Name = "RoundedButton4"
        RoundedButton4.Size = New Size(92, 35)
        RoundedButton4.TabIndex = 59
        RoundedButton4.Text = "13:30"
        RoundedButton4.TextColor = Color.Black
        RoundedButton4.UseVisualStyleBackColor = False
        ' 
        ' RoundedButton5
        ' 
        RoundedButton5.BackColor = SystemColors.ButtonHighlight
        RoundedButton5.BackgroundColor = SystemColors.ButtonHighlight
        RoundedButton5.BorderColor = Color.PaleVioletRed
        RoundedButton5.BorderRadius = 9
        RoundedButton5.BorderSize = 0
        RoundedButton5.Cursor = Cursors.Hand
        RoundedButton5.FlatAppearance.BorderColor = SystemColors.ButtonHighlight
        RoundedButton5.FlatAppearance.MouseDownBackColor = Color.White
        RoundedButton5.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        RoundedButton5.FlatStyle = FlatStyle.Flat
        RoundedButton5.Font = New Font("Segoe UI", 10.0F)
        RoundedButton5.ForeColor = Color.Black
        RoundedButton5.Location = New Point(146, 294)
        RoundedButton5.Name = "RoundedButton5"
        RoundedButton5.Size = New Size(92, 35)
        RoundedButton5.TabIndex = 58
        RoundedButton5.Text = "13:00"
        RoundedButton5.TextColor = Color.Black
        RoundedButton5.UseVisualStyleBackColor = False
        ' 
        ' RoundedButton6
        ' 
        RoundedButton6.BackColor = SystemColors.ButtonHighlight
        RoundedButton6.BackgroundColor = SystemColors.ButtonHighlight
        RoundedButton6.BorderColor = Color.PaleVioletRed
        RoundedButton6.BorderRadius = 9
        RoundedButton6.BorderSize = 0
        RoundedButton6.Cursor = Cursors.Hand
        RoundedButton6.FlatAppearance.BorderColor = SystemColors.ButtonHighlight
        RoundedButton6.FlatAppearance.MouseDownBackColor = Color.White
        RoundedButton6.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        RoundedButton6.FlatStyle = FlatStyle.Flat
        RoundedButton6.Font = New Font("Segoe UI", 10.0F)
        RoundedButton6.ForeColor = Color.Black
        RoundedButton6.Location = New Point(48, 294)
        RoundedButton6.Name = "RoundedButton6"
        RoundedButton6.Size = New Size(92, 35)
        RoundedButton6.TabIndex = 57
        RoundedButton6.Text = "10:30"
        RoundedButton6.TextColor = Color.Black
        RoundedButton6.UseVisualStyleBackColor = False
        ' 
        ' RoundedButton7
        ' 
        RoundedButton7.BackColor = SystemColors.ButtonHighlight
        RoundedButton7.BackgroundColor = SystemColors.ButtonHighlight
        RoundedButton7.BorderColor = Color.PaleVioletRed
        RoundedButton7.BorderRadius = 9
        RoundedButton7.BorderSize = 0
        RoundedButton7.Cursor = Cursors.Hand
        RoundedButton7.FlatAppearance.BorderColor = SystemColors.ButtonHighlight
        RoundedButton7.FlatAppearance.MouseDownBackColor = Color.White
        RoundedButton7.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        RoundedButton7.FlatStyle = FlatStyle.Flat
        RoundedButton7.Font = New Font("Segoe UI", 10.0F)
        RoundedButton7.ForeColor = Color.Black
        RoundedButton7.Location = New Point(246, 335)
        RoundedButton7.Name = "RoundedButton7"
        RoundedButton7.Size = New Size(92, 35)
        RoundedButton7.TabIndex = 62
        RoundedButton7.Text = "15:00"
        RoundedButton7.TextColor = Color.Black
        RoundedButton7.UseVisualStyleBackColor = False
        ' 
        ' RoundedButton8
        ' 
        RoundedButton8.BackColor = SystemColors.ButtonHighlight
        RoundedButton8.BackgroundColor = SystemColors.ButtonHighlight
        RoundedButton8.BorderColor = Color.PaleVioletRed
        RoundedButton8.BorderRadius = 9
        RoundedButton8.BorderSize = 0
        RoundedButton8.Cursor = Cursors.Hand
        RoundedButton8.FlatAppearance.BorderColor = SystemColors.ButtonHighlight
        RoundedButton8.FlatAppearance.MouseDownBackColor = Color.White
        RoundedButton8.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        RoundedButton8.FlatStyle = FlatStyle.Flat
        RoundedButton8.Font = New Font("Segoe UI", 10.0F)
        RoundedButton8.ForeColor = Color.Black
        RoundedButton8.Location = New Point(146, 335)
        RoundedButton8.Name = "RoundedButton8"
        RoundedButton8.Size = New Size(92, 35)
        RoundedButton8.TabIndex = 61
        RoundedButton8.Text = "14:30"
        RoundedButton8.TextColor = Color.Black
        RoundedButton8.UseVisualStyleBackColor = False
        ' 
        ' RoundedButton9
        ' 
        RoundedButton9.BackColor = SystemColors.ButtonHighlight
        RoundedButton9.BackgroundColor = SystemColors.ButtonHighlight
        RoundedButton9.BorderColor = Color.PaleVioletRed
        RoundedButton9.BorderRadius = 9
        RoundedButton9.BorderSize = 0
        RoundedButton9.Cursor = Cursors.Hand
        RoundedButton9.FlatAppearance.BorderColor = SystemColors.ButtonHighlight
        RoundedButton9.FlatAppearance.MouseDownBackColor = Color.White
        RoundedButton9.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        RoundedButton9.FlatStyle = FlatStyle.Flat
        RoundedButton9.Font = New Font("Segoe UI", 10.0F)
        RoundedButton9.ForeColor = Color.Black
        RoundedButton9.Location = New Point(48, 335)
        RoundedButton9.Name = "RoundedButton9"
        RoundedButton9.Size = New Size(92, 35)
        RoundedButton9.TabIndex = 60
        RoundedButton9.Text = "14:00"
        RoundedButton9.TextColor = Color.Black
        RoundedButton9.UseVisualStyleBackColor = False
        ' 
        ' RoundedButton10
        ' 
        RoundedButton10.BackColor = SystemColors.ButtonHighlight
        RoundedButton10.BackgroundColor = SystemColors.ButtonHighlight
        RoundedButton10.BorderColor = Color.PaleVioletRed
        RoundedButton10.BorderRadius = 9
        RoundedButton10.BorderSize = 0
        RoundedButton10.Cursor = Cursors.Hand
        RoundedButton10.FlatAppearance.BorderColor = SystemColors.ButtonHighlight
        RoundedButton10.FlatAppearance.MouseDownBackColor = Color.White
        RoundedButton10.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        RoundedButton10.FlatStyle = FlatStyle.Flat
        RoundedButton10.Font = New Font("Segoe UI", 10.0F)
        RoundedButton10.ForeColor = Color.Black
        RoundedButton10.Location = New Point(246, 376)
        RoundedButton10.Name = "RoundedButton10"
        RoundedButton10.Size = New Size(92, 35)
        RoundedButton10.TabIndex = 65
        RoundedButton10.Text = "16:30"
        RoundedButton10.TextColor = Color.Black
        RoundedButton10.UseVisualStyleBackColor = False
        ' 
        ' RoundedButton11
        ' 
        RoundedButton11.BackColor = SystemColors.ButtonHighlight
        RoundedButton11.BackgroundColor = SystemColors.ButtonHighlight
        RoundedButton11.BorderColor = Color.PaleVioletRed
        RoundedButton11.BorderRadius = 9
        RoundedButton11.BorderSize = 0
        RoundedButton11.Cursor = Cursors.Hand
        RoundedButton11.FlatAppearance.BorderColor = SystemColors.ButtonHighlight
        RoundedButton11.FlatAppearance.MouseDownBackColor = Color.White
        RoundedButton11.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        RoundedButton11.FlatStyle = FlatStyle.Flat
        RoundedButton11.Font = New Font("Segoe UI", 10.0F)
        RoundedButton11.ForeColor = Color.Black
        RoundedButton11.Location = New Point(146, 376)
        RoundedButton11.Name = "RoundedButton11"
        RoundedButton11.Size = New Size(92, 35)
        RoundedButton11.TabIndex = 64
        RoundedButton11.Text = "16:00"
        RoundedButton11.TextColor = Color.Black
        RoundedButton11.UseVisualStyleBackColor = False
        ' 
        ' RoundedButton12
        ' 
        RoundedButton12.BackColor = SystemColors.ButtonHighlight
        RoundedButton12.BackgroundColor = SystemColors.ButtonHighlight
        RoundedButton12.BorderColor = Color.PaleVioletRed
        RoundedButton12.BorderRadius = 9
        RoundedButton12.BorderSize = 0
        RoundedButton12.Cursor = Cursors.Hand
        RoundedButton12.FlatAppearance.BorderColor = SystemColors.ButtonHighlight
        RoundedButton12.FlatAppearance.MouseDownBackColor = Color.White
        RoundedButton12.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        RoundedButton12.FlatStyle = FlatStyle.Flat
        RoundedButton12.Font = New Font("Segoe UI", 10.0F)
        RoundedButton12.ForeColor = Color.Black
        RoundedButton12.Location = New Point(48, 376)
        RoundedButton12.Name = "RoundedButton12"
        RoundedButton12.Size = New Size(92, 35)
        RoundedButton12.TabIndex = 63
        RoundedButton12.Text = "15:30"
        RoundedButton12.TextColor = Color.Black
        RoundedButton12.UseVisualStyleBackColor = False
        ' 
        ' RoundedButton13
        ' 
        RoundedButton13.BackColor = SystemColors.ButtonHighlight
        RoundedButton13.BackgroundColor = SystemColors.ButtonHighlight
        RoundedButton13.BorderColor = Color.PaleVioletRed
        RoundedButton13.BorderRadius = 9
        RoundedButton13.BorderSize = 0
        RoundedButton13.Cursor = Cursors.Hand
        RoundedButton13.FlatAppearance.BorderColor = SystemColors.ButtonHighlight
        RoundedButton13.FlatAppearance.MouseDownBackColor = Color.White
        RoundedButton13.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        RoundedButton13.FlatStyle = FlatStyle.Flat
        RoundedButton13.Font = New Font("Segoe UI", 10.0F)
        RoundedButton13.ForeColor = Color.Black
        RoundedButton13.Location = New Point(246, 417)
        RoundedButton13.Name = "RoundedButton13"
        RoundedButton13.Size = New Size(92, 35)
        RoundedButton13.TabIndex = 68
        RoundedButton13.Text = "18:00"
        RoundedButton13.TextColor = Color.Black
        RoundedButton13.UseVisualStyleBackColor = False
        ' 
        ' RoundedButton14
        ' 
        RoundedButton14.BackColor = SystemColors.ButtonHighlight
        RoundedButton14.BackgroundColor = SystemColors.ButtonHighlight
        RoundedButton14.BorderColor = Color.PaleVioletRed
        RoundedButton14.BorderRadius = 9
        RoundedButton14.BorderSize = 0
        RoundedButton14.Cursor = Cursors.Hand
        RoundedButton14.FlatAppearance.BorderColor = SystemColors.ButtonHighlight
        RoundedButton14.FlatAppearance.MouseDownBackColor = Color.White
        RoundedButton14.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        RoundedButton14.FlatStyle = FlatStyle.Flat
        RoundedButton14.Font = New Font("Segoe UI", 10.0F)
        RoundedButton14.ForeColor = Color.Black
        RoundedButton14.Location = New Point(146, 417)
        RoundedButton14.Name = "RoundedButton14"
        RoundedButton14.Size = New Size(92, 35)
        RoundedButton14.TabIndex = 67
        RoundedButton14.Text = "17:30"
        RoundedButton14.TextColor = Color.Black
        RoundedButton14.UseVisualStyleBackColor = False
        ' 
        ' RoundedButton15
        ' 
        RoundedButton15.BackColor = SystemColors.ButtonHighlight
        RoundedButton15.BackgroundColor = SystemColors.ButtonHighlight
        RoundedButton15.BorderColor = Color.PaleVioletRed
        RoundedButton15.BorderRadius = 9
        RoundedButton15.BorderSize = 0
        RoundedButton15.Cursor = Cursors.Hand
        RoundedButton15.FlatAppearance.BorderColor = SystemColors.ButtonHighlight
        RoundedButton15.FlatAppearance.MouseDownBackColor = Color.White
        RoundedButton15.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        RoundedButton15.FlatStyle = FlatStyle.Flat
        RoundedButton15.Font = New Font("Segoe UI", 10.0F)
        RoundedButton15.ForeColor = Color.Black
        RoundedButton15.Location = New Point(48, 417)
        RoundedButton15.Name = "RoundedButton15"
        RoundedButton15.Size = New Size(92, 35)
        RoundedButton15.TabIndex = 66
        RoundedButton15.Text = "17:00"
        RoundedButton15.TextColor = Color.Black
        RoundedButton15.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(30, 472)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 21)
        Label3.TabIndex = 69
        Label3.Text = "Note:"
        ' 
        ' RoundedTextBox1
        ' 
        RoundedTextBox1.Location = New Point(30, 496)
        RoundedTextBox1.Multiline = True
        RoundedTextBox1.Name = "RoundedTextBox1"
        RoundedTextBox1.Size = New Size(315, 85)
        RoundedTextBox1.TabIndex = 70
        ' 
        ' RoundedButton16
        ' 
        RoundedButton16.BackColor = SystemColors.ButtonHighlight
        RoundedButton16.BackgroundColor = SystemColors.ButtonHighlight
        RoundedButton16.BorderColor = Color.PaleVioletRed
        RoundedButton16.BorderRadius = 9
        RoundedButton16.BorderSize = 0
        RoundedButton16.Cursor = Cursors.Hand
        RoundedButton16.FlatAppearance.BorderColor = SystemColors.ButtonHighlight
        RoundedButton16.FlatAppearance.MouseDownBackColor = Color.White
        RoundedButton16.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        RoundedButton16.FlatStyle = FlatStyle.Flat
        RoundedButton16.Font = New Font("Segoe UI", 10.0F)
        RoundedButton16.ForeColor = Color.Black
        RoundedButton16.Location = New Point(18, 629)
        RoundedButton16.Name = "RoundedButton16"
        RoundedButton16.Size = New Size(345, 52)
        RoundedButton16.TabIndex = 71
        RoundedButton16.Text = "Confirm Appointment"
        RoundedButton16.TextColor = Color.Black
        RoundedButton16.UseVisualStyleBackColor = False
        ' 
        ' appointment
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(384, 711)
        Controls.Add(RoundedButton16)
        Controls.Add(RoundedTextBox1)
        Controls.Add(Label3)
        Controls.Add(RoundedButton13)
        Controls.Add(RoundedButton14)
        Controls.Add(RoundedButton15)
        Controls.Add(RoundedButton10)
        Controls.Add(RoundedButton11)
        Controls.Add(RoundedButton12)
        Controls.Add(RoundedButton7)
        Controls.Add(RoundedButton8)
        Controls.Add(RoundedButton9)
        Controls.Add(RoundedButton4)
        Controls.Add(RoundedButton5)
        Controls.Add(RoundedButton6)
        Controls.Add(RoundedButton2)
        Controls.Add(RoundedButton1)
        Controls.Add(DateTimePicker1)
        Controls.Add(RoundedButton3)
        Controls.Add(Label2)
        Controls.Add(Panel2)
        Controls.Add(PictureBox2)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "appointment"
        Text = " "
        Panel2.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents RoundedButton3 As CustomControls.RJControls.RoundedButton
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents RoundedButton1 As CustomControls.RJControls.RoundedButton
    Friend WithEvents RoundedButton2 As CustomControls.RJControls.RoundedButton
    Friend WithEvents RoundedButton4 As CustomControls.RJControls.RoundedButton
    Friend WithEvents RoundedButton5 As CustomControls.RJControls.RoundedButton
    Friend WithEvents RoundedButton6 As CustomControls.RJControls.RoundedButton
    Friend WithEvents RoundedButton7 As CustomControls.RJControls.RoundedButton
    Friend WithEvents RoundedButton8 As CustomControls.RJControls.RoundedButton
    Friend WithEvents RoundedButton9 As CustomControls.RJControls.RoundedButton
    Friend WithEvents RoundedButton10 As CustomControls.RJControls.RoundedButton
    Friend WithEvents RoundedButton11 As CustomControls.RJControls.RoundedButton
    Friend WithEvents RoundedButton12 As CustomControls.RJControls.RoundedButton
    Friend WithEvents RoundedButton13 As CustomControls.RJControls.RoundedButton
    Friend WithEvents RoundedButton14 As CustomControls.RJControls.RoundedButton
    Friend WithEvents RoundedButton15 As CustomControls.RJControls.RoundedButton
    Friend WithEvents Label3 As Label
    Friend WithEvents RoundedTextBox1 As RoundedTextBox
    Friend WithEvents RoundedButton16 As CustomControls.RJControls.RoundedButton
End Class
