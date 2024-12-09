<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SchedulePage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SchedulePage))
        RoundedPanel1 = New RoundedPanel()
        Panel1 = New Panel()
        Label1 = New Label()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox2 = New PictureBox()
        RoundedButton16 = New CustomControls.RJControls.RoundedButton()
        txt_Note = New RoundedTextBox()
        Label3 = New Label()
        btn_18 = New CustomControls.RJControls.RoundedButton()
        btn_1730 = New CustomControls.RJControls.RoundedButton()
        btn_17 = New CustomControls.RJControls.RoundedButton()
        btn_1630 = New CustomControls.RJControls.RoundedButton()
        btn_16 = New CustomControls.RJControls.RoundedButton()
        btn_1530 = New CustomControls.RJControls.RoundedButton()
        btn_15 = New CustomControls.RJControls.RoundedButton()
        btn_1430 = New CustomControls.RJControls.RoundedButton()
        btn_14 = New CustomControls.RJControls.RoundedButton()
        btn_1330 = New CustomControls.RJControls.RoundedButton()
        btn_13 = New CustomControls.RJControls.RoundedButton()
        btn_1030 = New CustomControls.RJControls.RoundedButton()
        btn_10 = New CustomControls.RJControls.RoundedButton()
        btn_930 = New CustomControls.RJControls.RoundedButton()
        dtp_AppointmentDate = New DateTimePicker()
        btn_9 = New CustomControls.RJControls.RoundedButton()
        Label2 = New Label()
        RoundedPanel1.SuspendLayout()
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
        RoundedPanel1.Controls.Add(Panel1)
        RoundedPanel1.Controls.Add(PictureBox2)
        RoundedPanel1.Controls.Add(RoundedButton16)
        RoundedPanel1.Controls.Add(txt_Note)
        RoundedPanel1.Controls.Add(Label3)
        RoundedPanel1.Controls.Add(btn_18)
        RoundedPanel1.Controls.Add(btn_1730)
        RoundedPanel1.Controls.Add(btn_17)
        RoundedPanel1.Controls.Add(btn_1630)
        RoundedPanel1.Controls.Add(btn_16)
        RoundedPanel1.Controls.Add(btn_1530)
        RoundedPanel1.Controls.Add(btn_15)
        RoundedPanel1.Controls.Add(btn_1430)
        RoundedPanel1.Controls.Add(btn_14)
        RoundedPanel1.Controls.Add(btn_1330)
        RoundedPanel1.Controls.Add(btn_13)
        RoundedPanel1.Controls.Add(btn_1030)
        RoundedPanel1.Controls.Add(btn_10)
        RoundedPanel1.Controls.Add(btn_930)
        RoundedPanel1.Controls.Add(dtp_AppointmentDate)
        RoundedPanel1.Controls.Add(btn_9)
        RoundedPanel1.Controls.Add(Label2)
        RoundedPanel1.CornerRadius = 20
        RoundedPanel1.Location = New Point(12, 26)
        RoundedPanel1.Name = "RoundedPanel1"
        RoundedPanel1.Size = New Size(376, 712)
        RoundedPanel1.TabIndex = 0
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
        Panel1.TabIndex = 114
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
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Cursor = Cursors.Hand
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(13, 81)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(38, 36)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 113
        PictureBox2.TabStop = False
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
        RoundedButton16.Font = New Font("Segoe UI", 10F)
        RoundedButton16.ForeColor = Color.Black
        RoundedButton16.Location = New Point(16, 623)
        RoundedButton16.Name = "RoundedButton16"
        RoundedButton16.Size = New Size(345, 52)
        RoundedButton16.TabIndex = 112
        RoundedButton16.Text = "Confirm Appointment"
        RoundedButton16.TextColor = Color.Black
        RoundedButton16.UseVisualStyleBackColor = False
        ' 
        ' txt_Note
        ' 
        txt_Note.Location = New Point(28, 490)
        txt_Note.Multiline = True
        txt_Note.Name = "txt_Note"
        txt_Note.Size = New Size(315, 85)
        txt_Note.TabIndex = 111
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(28, 466)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 21)
        Label3.TabIndex = 110
        Label3.Text = "Note:"
        ' 
        ' btn_18
        ' 
        btn_18.BackColor = SystemColors.ButtonHighlight
        btn_18.BackgroundColor = SystemColors.ButtonHighlight
        btn_18.BorderColor = Color.PaleVioletRed
        btn_18.BorderRadius = 9
        btn_18.BorderSize = 0
        btn_18.Cursor = Cursors.Hand
        btn_18.FlatAppearance.BorderColor = SystemColors.ButtonHighlight
        btn_18.FlatAppearance.MouseDownBackColor = Color.White
        btn_18.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        btn_18.FlatStyle = FlatStyle.Flat
        btn_18.Font = New Font("Segoe UI", 10F)
        btn_18.ForeColor = Color.Black
        btn_18.Location = New Point(244, 411)
        btn_18.Name = "btn_18"
        btn_18.Size = New Size(92, 35)
        btn_18.TabIndex = 109
        btn_18.Text = "18:00"
        btn_18.TextColor = Color.Black
        btn_18.UseVisualStyleBackColor = False
        ' 
        ' btn_1730
        ' 
        btn_1730.BackColor = SystemColors.ButtonHighlight
        btn_1730.BackgroundColor = SystemColors.ButtonHighlight
        btn_1730.BorderColor = Color.PaleVioletRed
        btn_1730.BorderRadius = 9
        btn_1730.BorderSize = 0
        btn_1730.Cursor = Cursors.Hand
        btn_1730.FlatAppearance.BorderColor = SystemColors.ButtonHighlight
        btn_1730.FlatAppearance.MouseDownBackColor = Color.White
        btn_1730.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        btn_1730.FlatStyle = FlatStyle.Flat
        btn_1730.Font = New Font("Segoe UI", 10F)
        btn_1730.ForeColor = Color.Black
        btn_1730.Location = New Point(144, 411)
        btn_1730.Name = "btn_1730"
        btn_1730.Size = New Size(92, 35)
        btn_1730.TabIndex = 108
        btn_1730.Text = "17:30"
        btn_1730.TextColor = Color.Black
        btn_1730.UseVisualStyleBackColor = False
        ' 
        ' btn_17
        ' 
        btn_17.BackColor = SystemColors.ButtonHighlight
        btn_17.BackgroundColor = SystemColors.ButtonHighlight
        btn_17.BorderColor = Color.PaleVioletRed
        btn_17.BorderRadius = 9
        btn_17.BorderSize = 0
        btn_17.Cursor = Cursors.Hand
        btn_17.FlatAppearance.BorderColor = SystemColors.ButtonHighlight
        btn_17.FlatAppearance.MouseDownBackColor = Color.White
        btn_17.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        btn_17.FlatStyle = FlatStyle.Flat
        btn_17.Font = New Font("Segoe UI", 10F)
        btn_17.ForeColor = Color.Black
        btn_17.Location = New Point(46, 411)
        btn_17.Name = "btn_17"
        btn_17.Size = New Size(92, 35)
        btn_17.TabIndex = 107
        btn_17.Text = "17:00"
        btn_17.TextColor = Color.Black
        btn_17.UseVisualStyleBackColor = False
        ' 
        ' btn_1630
        ' 
        btn_1630.BackColor = SystemColors.ButtonHighlight
        btn_1630.BackgroundColor = SystemColors.ButtonHighlight
        btn_1630.BorderColor = Color.PaleVioletRed
        btn_1630.BorderRadius = 9
        btn_1630.BorderSize = 0
        btn_1630.Cursor = Cursors.Hand
        btn_1630.FlatAppearance.BorderColor = SystemColors.ButtonHighlight
        btn_1630.FlatAppearance.MouseDownBackColor = Color.White
        btn_1630.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        btn_1630.FlatStyle = FlatStyle.Flat
        btn_1630.Font = New Font("Segoe UI", 10F)
        btn_1630.ForeColor = Color.Black
        btn_1630.Location = New Point(244, 370)
        btn_1630.Name = "btn_1630"
        btn_1630.Size = New Size(92, 35)
        btn_1630.TabIndex = 106
        btn_1630.Text = "16:30"
        btn_1630.TextColor = Color.Black
        btn_1630.UseVisualStyleBackColor = False
        ' 
        ' btn_16
        ' 
        btn_16.BackColor = SystemColors.ButtonHighlight
        btn_16.BackgroundColor = SystemColors.ButtonHighlight
        btn_16.BorderColor = Color.PaleVioletRed
        btn_16.BorderRadius = 9
        btn_16.BorderSize = 0
        btn_16.Cursor = Cursors.Hand
        btn_16.FlatAppearance.BorderColor = SystemColors.ButtonHighlight
        btn_16.FlatAppearance.MouseDownBackColor = Color.White
        btn_16.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        btn_16.FlatStyle = FlatStyle.Flat
        btn_16.Font = New Font("Segoe UI", 10F)
        btn_16.ForeColor = Color.Black
        btn_16.Location = New Point(144, 370)
        btn_16.Name = "btn_16"
        btn_16.Size = New Size(92, 35)
        btn_16.TabIndex = 105
        btn_16.Text = "16:00"
        btn_16.TextColor = Color.Black
        btn_16.UseVisualStyleBackColor = False
        ' 
        ' btn_1530
        ' 
        btn_1530.BackColor = SystemColors.ButtonHighlight
        btn_1530.BackgroundColor = SystemColors.ButtonHighlight
        btn_1530.BorderColor = Color.PaleVioletRed
        btn_1530.BorderRadius = 9
        btn_1530.BorderSize = 0
        btn_1530.Cursor = Cursors.Hand
        btn_1530.FlatAppearance.BorderColor = SystemColors.ButtonHighlight
        btn_1530.FlatAppearance.MouseDownBackColor = Color.White
        btn_1530.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        btn_1530.FlatStyle = FlatStyle.Flat
        btn_1530.Font = New Font("Segoe UI", 10F)
        btn_1530.ForeColor = Color.Black
        btn_1530.Location = New Point(46, 370)
        btn_1530.Name = "btn_1530"
        btn_1530.Size = New Size(92, 35)
        btn_1530.TabIndex = 104
        btn_1530.Text = "15:30"
        btn_1530.TextColor = Color.Black
        btn_1530.UseVisualStyleBackColor = False
        ' 
        ' btn_15
        ' 
        btn_15.BackColor = SystemColors.ButtonHighlight
        btn_15.BackgroundColor = SystemColors.ButtonHighlight
        btn_15.BorderColor = Color.PaleVioletRed
        btn_15.BorderRadius = 9
        btn_15.BorderSize = 0
        btn_15.Cursor = Cursors.Hand
        btn_15.FlatAppearance.BorderColor = SystemColors.ButtonHighlight
        btn_15.FlatAppearance.MouseDownBackColor = Color.White
        btn_15.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        btn_15.FlatStyle = FlatStyle.Flat
        btn_15.Font = New Font("Segoe UI", 10F)
        btn_15.ForeColor = Color.Black
        btn_15.Location = New Point(244, 329)
        btn_15.Name = "btn_15"
        btn_15.Size = New Size(92, 35)
        btn_15.TabIndex = 103
        btn_15.Text = "15:00"
        btn_15.TextColor = Color.Black
        btn_15.UseVisualStyleBackColor = False
        ' 
        ' btn_1430
        ' 
        btn_1430.BackColor = SystemColors.ButtonHighlight
        btn_1430.BackgroundColor = SystemColors.ButtonHighlight
        btn_1430.BorderColor = Color.PaleVioletRed
        btn_1430.BorderRadius = 9
        btn_1430.BorderSize = 0
        btn_1430.Cursor = Cursors.Hand
        btn_1430.FlatAppearance.BorderColor = SystemColors.ButtonHighlight
        btn_1430.FlatAppearance.MouseDownBackColor = Color.White
        btn_1430.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        btn_1430.FlatStyle = FlatStyle.Flat
        btn_1430.Font = New Font("Segoe UI", 10F)
        btn_1430.ForeColor = Color.Black
        btn_1430.Location = New Point(144, 329)
        btn_1430.Name = "btn_1430"
        btn_1430.Size = New Size(92, 35)
        btn_1430.TabIndex = 102
        btn_1430.Text = "14:30"
        btn_1430.TextColor = Color.Black
        btn_1430.UseVisualStyleBackColor = False
        ' 
        ' btn_14
        ' 
        btn_14.BackColor = SystemColors.ButtonHighlight
        btn_14.BackgroundColor = SystemColors.ButtonHighlight
        btn_14.BorderColor = Color.PaleVioletRed
        btn_14.BorderRadius = 9
        btn_14.BorderSize = 0
        btn_14.Cursor = Cursors.Hand
        btn_14.FlatAppearance.BorderColor = SystemColors.ButtonHighlight
        btn_14.FlatAppearance.MouseDownBackColor = Color.White
        btn_14.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        btn_14.FlatStyle = FlatStyle.Flat
        btn_14.Font = New Font("Segoe UI", 10F)
        btn_14.ForeColor = Color.Black
        btn_14.Location = New Point(46, 329)
        btn_14.Name = "btn_14"
        btn_14.Size = New Size(92, 35)
        btn_14.TabIndex = 101
        btn_14.Text = "14:00"
        btn_14.TextColor = Color.Black
        btn_14.UseVisualStyleBackColor = False
        ' 
        ' btn_1330
        ' 
        btn_1330.BackColor = SystemColors.ButtonHighlight
        btn_1330.BackgroundColor = SystemColors.ButtonHighlight
        btn_1330.BorderColor = Color.PaleVioletRed
        btn_1330.BorderRadius = 9
        btn_1330.BorderSize = 0
        btn_1330.Cursor = Cursors.Hand
        btn_1330.FlatAppearance.BorderColor = SystemColors.ButtonHighlight
        btn_1330.FlatAppearance.MouseDownBackColor = Color.White
        btn_1330.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        btn_1330.FlatStyle = FlatStyle.Flat
        btn_1330.Font = New Font("Segoe UI", 10F)
        btn_1330.ForeColor = Color.Black
        btn_1330.Location = New Point(244, 288)
        btn_1330.Name = "btn_1330"
        btn_1330.Size = New Size(92, 35)
        btn_1330.TabIndex = 100
        btn_1330.Text = "13:30"
        btn_1330.TextColor = Color.Black
        btn_1330.UseVisualStyleBackColor = False
        ' 
        ' btn_13
        ' 
        btn_13.BackColor = SystemColors.ButtonHighlight
        btn_13.BackgroundColor = SystemColors.ButtonHighlight
        btn_13.BorderColor = Color.PaleVioletRed
        btn_13.BorderRadius = 9
        btn_13.BorderSize = 0
        btn_13.Cursor = Cursors.Hand
        btn_13.FlatAppearance.BorderColor = SystemColors.ButtonHighlight
        btn_13.FlatAppearance.MouseDownBackColor = Color.White
        btn_13.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        btn_13.FlatStyle = FlatStyle.Flat
        btn_13.Font = New Font("Segoe UI", 10F)
        btn_13.ForeColor = Color.Black
        btn_13.Location = New Point(144, 288)
        btn_13.Name = "btn_13"
        btn_13.Size = New Size(92, 35)
        btn_13.TabIndex = 99
        btn_13.Text = "13:00"
        btn_13.TextColor = Color.Black
        btn_13.UseVisualStyleBackColor = False
        ' 
        ' btn_1030
        ' 
        btn_1030.BackColor = SystemColors.ButtonHighlight
        btn_1030.BackgroundColor = SystemColors.ButtonHighlight
        btn_1030.BorderColor = Color.PaleVioletRed
        btn_1030.BorderRadius = 9
        btn_1030.BorderSize = 0
        btn_1030.Cursor = Cursors.Hand
        btn_1030.FlatAppearance.BorderColor = SystemColors.ButtonHighlight
        btn_1030.FlatAppearance.MouseDownBackColor = Color.White
        btn_1030.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        btn_1030.FlatStyle = FlatStyle.Flat
        btn_1030.Font = New Font("Segoe UI", 10F)
        btn_1030.ForeColor = Color.Black
        btn_1030.Location = New Point(46, 288)
        btn_1030.Name = "btn_1030"
        btn_1030.Size = New Size(92, 35)
        btn_1030.TabIndex = 98
        btn_1030.Text = "10:30"
        btn_1030.TextColor = Color.Black
        btn_1030.UseVisualStyleBackColor = False
        ' 
        ' btn_10
        ' 
        btn_10.BackColor = SystemColors.ButtonHighlight
        btn_10.BackgroundColor = SystemColors.ButtonHighlight
        btn_10.BorderColor = Color.PaleVioletRed
        btn_10.BorderRadius = 9
        btn_10.BorderSize = 0
        btn_10.Cursor = Cursors.Hand
        btn_10.FlatAppearance.BorderColor = SystemColors.ButtonHighlight
        btn_10.FlatAppearance.MouseDownBackColor = Color.White
        btn_10.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        btn_10.FlatStyle = FlatStyle.Flat
        btn_10.Font = New Font("Segoe UI", 10F)
        btn_10.ForeColor = Color.Black
        btn_10.Location = New Point(244, 247)
        btn_10.Name = "btn_10"
        btn_10.Size = New Size(92, 35)
        btn_10.TabIndex = 97
        btn_10.Text = "10:00"
        btn_10.TextColor = Color.Black
        btn_10.UseVisualStyleBackColor = False
        ' 
        ' btn_930
        ' 
        btn_930.BackColor = SystemColors.ButtonHighlight
        btn_930.BackgroundColor = SystemColors.ButtonHighlight
        btn_930.BorderColor = Color.PaleVioletRed
        btn_930.BorderRadius = 9
        btn_930.BorderSize = 0
        btn_930.Cursor = Cursors.Hand
        btn_930.FlatAppearance.BorderColor = SystemColors.ButtonHighlight
        btn_930.FlatAppearance.MouseDownBackColor = Color.White
        btn_930.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        btn_930.FlatStyle = FlatStyle.Flat
        btn_930.Font = New Font("Segoe UI", 10F)
        btn_930.ForeColor = Color.Black
        btn_930.Location = New Point(144, 247)
        btn_930.Name = "btn_930"
        btn_930.Size = New Size(92, 35)
        btn_930.TabIndex = 96
        btn_930.Text = "9:30"
        btn_930.TextColor = Color.Black
        btn_930.UseVisualStyleBackColor = False
        ' 
        ' dtp_AppointmentDate
        ' 
        dtp_AppointmentDate.CustomFormat = "yyyy-MM-dd"
        dtp_AppointmentDate.Format = DateTimePickerFormat.Custom
        dtp_AppointmentDate.Location = New Point(33, 203)
        dtp_AppointmentDate.MaxDate = New Date(2030, 12, 31, 0, 0, 0, 0)
        dtp_AppointmentDate.MinDate = New Date(2024, 12, 10, 0, 0, 0, 0)
        dtp_AppointmentDate.Name = "dtp_AppointmentDate"
        dtp_AppointmentDate.Size = New Size(313, 23)
        dtp_AppointmentDate.TabIndex = 95
        dtp_AppointmentDate.Value = New Date(2024, 12, 10, 0, 0, 0, 0)
        ' 
        ' btn_9
        ' 
        btn_9.BackColor = SystemColors.ButtonHighlight
        btn_9.BackgroundColor = SystemColors.ButtonHighlight
        btn_9.BorderColor = Color.PaleVioletRed
        btn_9.BorderRadius = 9
        btn_9.BorderSize = 0
        btn_9.Cursor = Cursors.Hand
        btn_9.FlatAppearance.BorderColor = SystemColors.ButtonHighlight
        btn_9.FlatAppearance.MouseDownBackColor = Color.White
        btn_9.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        btn_9.FlatStyle = FlatStyle.Flat
        btn_9.Font = New Font("Segoe UI", 10F)
        btn_9.ForeColor = Color.Black
        btn_9.Location = New Point(46, 247)
        btn_9.Name = "btn_9"
        btn_9.Size = New Size(92, 35)
        btn_9.TabIndex = 94
        btn_9.Text = "9:00"
        btn_9.TextColor = Color.Black
        btn_9.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(102, 152)
        Label2.Name = "Label2"
        Label2.Size = New Size(166, 32)
        Label2.TabIndex = 93
        Label2.Text = "Appointment"
        ' 
        ' SchedulePage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(400, 750)
        Controls.Add(RoundedPanel1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "SchedulePage"
        StartPosition = FormStartPosition.CenterScreen
        Text = "SchedulePage"
        RoundedPanel1.ResumeLayout(False)
        RoundedPanel1.PerformLayout()
        Panel1.ResumeLayout(False)
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents RoundedButton16 As CustomControls.RJControls.RoundedButton
    Friend WithEvents txt_Note As RoundedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_18 As CustomControls.RJControls.RoundedButton
    Friend WithEvents btn_1730 As CustomControls.RJControls.RoundedButton
    Friend WithEvents btn_17 As CustomControls.RJControls.RoundedButton
    Friend WithEvents btn_1630 As CustomControls.RJControls.RoundedButton
    Friend WithEvents btn_16 As CustomControls.RJControls.RoundedButton
    Friend WithEvents btn_1530 As CustomControls.RJControls.RoundedButton
    Friend WithEvents btn_15 As CustomControls.RJControls.RoundedButton
    Friend WithEvents btn_1430 As CustomControls.RJControls.RoundedButton
    Friend WithEvents btn_14 As CustomControls.RJControls.RoundedButton
    Friend WithEvents btn_1330 As CustomControls.RJControls.RoundedButton
    Friend WithEvents btn_13 As CustomControls.RJControls.RoundedButton
    Friend WithEvents btn_1030 As CustomControls.RJControls.RoundedButton
    Friend WithEvents btn_10 As CustomControls.RJControls.RoundedButton
    Friend WithEvents btn_930 As CustomControls.RJControls.RoundedButton
    Friend WithEvents dtp_AppointmentDate As DateTimePicker
    Friend WithEvents btn_9 As CustomControls.RJControls.RoundedButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
