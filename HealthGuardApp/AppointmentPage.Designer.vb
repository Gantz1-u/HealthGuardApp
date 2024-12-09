<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AppointmentPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AppointmentPage))
        RoundedPanel1 = New RoundedPanel()
        PictureBox2 = New PictureBox()
        Panel1 = New Panel()
        Label3 = New Label()
        PictureBox1 = New PictureBox()
        PictureBox3 = New PictureBox()
        RoundedButton4 = New CustomControls.RJControls.RoundedButton()
        RoundedButton2 = New CustomControls.RJControls.RoundedButton()
        RoundedPanel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' RoundedPanel1
        ' 
        RoundedPanel1.BackgroundImage = CType(resources.GetObject("RoundedPanel1.BackgroundImage"), Image)
        RoundedPanel1.BackgroundImageLayout = ImageLayout.Stretch
        RoundedPanel1.Controls.Add(PictureBox2)
        RoundedPanel1.Controls.Add(Panel1)
        RoundedPanel1.Controls.Add(RoundedButton4)
        RoundedPanel1.Controls.Add(RoundedButton2)
        RoundedPanel1.CornerRadius = 35
        RoundedPanel1.Location = New Point(12, 26)
        RoundedPanel1.Name = "RoundedPanel1"
        RoundedPanel1.Size = New Size(376, 712)
        RoundedPanel1.TabIndex = 0
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
        PictureBox2.TabIndex = 62
        PictureBox2.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(PictureBox3)
        Panel1.Location = New Point(-9, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(400, 68)
        Panel1.TabIndex = 27
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
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Cursor = Cursors.Hand
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(325, 15)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(40, 25)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 24
        PictureBox1.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Transparent
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(-9, -12)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(145, 90)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 23
        PictureBox3.TabStop = False
        ' 
        ' RoundedButton4
        ' 
        RoundedButton4.BackColor = SystemColors.ButtonHighlight
        RoundedButton4.BackgroundColor = SystemColors.ButtonHighlight
        RoundedButton4.BorderColor = Color.PaleVioletRed
        RoundedButton4.BorderRadius = 9
        RoundedButton4.BorderSize = 0
        RoundedButton4.FlatAppearance.BorderSize = 0
        RoundedButton4.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        RoundedButton4.FlatStyle = FlatStyle.Flat
        RoundedButton4.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RoundedButton4.ForeColor = Color.Black
        RoundedButton4.Image = CType(resources.GetObject("RoundedButton4.Image"), Image)
        RoundedButton4.Location = New Point(120, 220)
        RoundedButton4.Name = "RoundedButton4"
        RoundedButton4.Size = New Size(136, 118)
        RoundedButton4.TabIndex = 23
        RoundedButton4.Text = "New Appointment"
        RoundedButton4.TextAlign = ContentAlignment.BottomCenter
        RoundedButton4.TextColor = Color.Black
        RoundedButton4.UseVisualStyleBackColor = False
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
        RoundedButton2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RoundedButton2.ForeColor = Color.Black
        RoundedButton2.Image = CType(resources.GetObject("RoundedButton2.Image"), Image)
        RoundedButton2.Location = New Point(120, 374)
        RoundedButton2.Name = "RoundedButton2"
        RoundedButton2.Size = New Size(136, 118)
        RoundedButton2.TabIndex = 22
        RoundedButton2.Text = "Scheduled Appointment"
        RoundedButton2.TextAlign = ContentAlignment.BottomCenter
        RoundedButton2.TextColor = Color.Black
        RoundedButton2.UseVisualStyleBackColor = False
        ' 
        ' AppointmentPage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(400, 750)
        Controls.Add(RoundedPanel1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "AppointmentPage"
        StartPosition = FormStartPosition.CenterScreen
        Text = "AppointmentPage"
        RoundedPanel1.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents RoundedButton4 As CustomControls.RJControls.RoundedButton
    Friend WithEvents RoundedButton2 As CustomControls.RJControls.RoundedButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
