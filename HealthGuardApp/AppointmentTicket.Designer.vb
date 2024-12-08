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
        Panel1 = New Panel()
        Label3 = New Label()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        RoundedPanel1 = New RoundedPanel()
        txt_AppointmentNote = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        Label2 = New Label()
        Label6 = New Label()
        lbl_AppointmentTime = New Label()
        lbl_AppointmentDate = New Label()
        Label1 = New Label()
        RoundedButton1 = New CustomControls.RJControls.RoundedButton()
        RoundedButton2 = New CustomControls.RJControls.RoundedButton()
        Panel1.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        RoundedPanel1.SuspendLayout()
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
        Panel1.TabIndex = 18
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
        RoundedPanel1.Controls.Add(txt_AppointmentNote)
        RoundedPanel1.Controls.Add(Label5)
        RoundedPanel1.Controls.Add(Label4)
        RoundedPanel1.Controls.Add(Label2)
        RoundedPanel1.Controls.Add(Label6)
        RoundedPanel1.Controls.Add(lbl_AppointmentTime)
        RoundedPanel1.Controls.Add(lbl_AppointmentDate)
        RoundedPanel1.Controls.Add(Label1)
        RoundedPanel1.CornerRadius = 20
        RoundedPanel1.Location = New Point(18, 236)
        RoundedPanel1.Name = "RoundedPanel1"
        RoundedPanel1.Size = New Size(345, 170)
        RoundedPanel1.TabIndex = 19
        ' 
        ' txt_AppointmentNote
        ' 
        txt_AppointmentNote.BorderStyle = BorderStyle.FixedSingle
        txt_AppointmentNote.Location = New Point(59, 98)
        txt_AppointmentNote.Multiline = True
        txt_AppointmentNote.Name = "txt_AppointmentNote"
        txt_AppointmentNote.ReadOnly = True
        txt_AppointmentNote.ScrollBars = ScrollBars.Vertical
        txt_AppointmentNote.Size = New Size(270, 55)
        txt_AppointmentNote.TabIndex = 4
        txt_AppointmentNote.Text = resources.GetString("txt_AppointmentNote.Text")
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(13, 97)
        Label5.Name = "Label5"
        Label5.Size = New Size(42, 17)
        Label5.TabIndex = 3
        Label5.Text = "Note:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(12, 68)
        Label4.Name = "Label4"
        Label4.Size = New Size(130, 17)
        Label4.TabIndex = 2
        Label4.Text = "Healthcare Provider"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(12, 41)
        Label2.Name = "Label2"
        Label2.Size = New Size(39, 17)
        Label2.TabIndex = 1
        Label2.Text = "Time"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(148, 68)
        Label6.Name = "Label6"
        Label6.Size = New Size(25, 17)
        Label6.TabIndex = 0
        Label6.Text = "Dr."
        ' 
        ' lbl_AppointmentTime
        ' 
        lbl_AppointmentTime.AutoSize = True
        lbl_AppointmentTime.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl_AppointmentTime.Location = New Point(57, 41)
        lbl_AppointmentTime.Name = "lbl_AppointmentTime"
        lbl_AppointmentTime.Size = New Size(39, 17)
        lbl_AppointmentTime.TabIndex = 0
        lbl_AppointmentTime.Text = "00:00"
        ' 
        ' lbl_AppointmentDate
        ' 
        lbl_AppointmentDate.AutoSize = True
        lbl_AppointmentDate.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl_AppointmentDate.Location = New Point(55, 15)
        lbl_AppointmentDate.Name = "lbl_AppointmentDate"
        lbl_AppointmentDate.Size = New Size(88, 17)
        lbl_AppointmentDate.TabIndex = 0
        lbl_AppointmentDate.Text = "YYYY-MM-DD"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(37, 17)
        Label1.TabIndex = 0
        Label1.Text = "Date"
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
        RoundedButton1.Location = New Point(18, 422)
        RoundedButton1.Name = "RoundedButton1"
        RoundedButton1.Size = New Size(345, 52)
        RoundedButton1.TabIndex = 36
        RoundedButton1.Text = "Save"
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
        RoundedButton2.Font = New Font("Segoe UI", 10F)
        RoundedButton2.ForeColor = Color.Black
        RoundedButton2.Location = New Point(18, 480)
        RoundedButton2.Name = "RoundedButton2"
        RoundedButton2.Size = New Size(345, 52)
        RoundedButton2.TabIndex = 37
        RoundedButton2.Text = "Cancel"
        RoundedButton2.TextColor = Color.Black
        RoundedButton2.UseVisualStyleBackColor = False
        ' 
        ' AppointmentTicket
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(384, 711)
        Controls.Add(RoundedButton2)
        Controls.Add(RoundedButton1)
        Controls.Add(RoundedPanel1)
        Controls.Add(Panel1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "AppointmentTicket"
        StartPosition = FormStartPosition.CenterScreen
        Text = "AppointmentTicket"
        Panel1.ResumeLayout(False)
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        RoundedPanel1.ResumeLayout(False)
        RoundedPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents RoundedButton1 As CustomControls.RJControls.RoundedButton
    Friend WithEvents RoundedButton2 As CustomControls.RJControls.RoundedButton
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lbl_AppointmentTime As Label
    Friend WithEvents lbl_AppointmentDate As Label
    Friend WithEvents txt_AppointmentNote As TextBox
End Class
