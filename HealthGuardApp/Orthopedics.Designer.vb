<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Orthopedics
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Orthopedics))
        RoundedPanel1 = New RoundedPanel()
        PictureBox2 = New PictureBox()
        RoundedPanel2 = New RoundedPanel()
        Label3 = New Label()
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        Panel1 = New Panel()
        Label1 = New Label()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        RoundedButton3 = New CustomControls.RJControls.RoundedButton()
        RoundedPanel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
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
        RoundedPanel1.Controls.Add(PictureBox2)
        RoundedPanel1.Controls.Add(RoundedPanel2)
        RoundedPanel1.Controls.Add(Panel1)
        RoundedPanel1.Controls.Add(RoundedButton3)
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
        PictureBox2.TabIndex = 74
        PictureBox2.TabStop = False
        ' 
        ' RoundedPanel2
        ' 
        RoundedPanel2.BackColor = Color.White
        RoundedPanel2.Controls.Add(Label3)
        RoundedPanel2.Controls.Add(Label2)
        RoundedPanel2.Controls.Add(PictureBox1)
        RoundedPanel2.CornerRadius = 20
        RoundedPanel2.Location = New Point(36, 155)
        RoundedPanel2.Name = "RoundedPanel2"
        RoundedPanel2.Size = New Size(304, 455)
        RoundedPanel2.TabIndex = 71
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(103, 379)
        Label3.Name = "Label3"
        Label3.Size = New Size(99, 21)
        Label3.TabIndex = 2
        Label3.Text = "Orthopedist"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(43, 354)
        Label2.Name = "Label2"
        Label2.Size = New Size(218, 25)
        Label2.TabIndex = 1
        Label2.Text = "Dr. Tanya Marquez Sale"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(20, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(264, 424)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
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
        Panel1.TabIndex = 73
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
        RoundedButton3.Font = New Font("Segoe UI", 10F)
        RoundedButton3.ForeColor = Color.Black
        RoundedButton3.Location = New Point(14, 638)
        RoundedButton3.Name = "RoundedButton3"
        RoundedButton3.Size = New Size(348, 52)
        RoundedButton3.TabIndex = 72
        RoundedButton3.Text = "Book Appointment"
        RoundedButton3.TextColor = Color.Black
        RoundedButton3.UseVisualStyleBackColor = False
        ' 
        ' Orthopedics
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(400, 750)
        Controls.Add(RoundedPanel1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "Orthopedics"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Orthopedics"
        RoundedPanel1.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents RoundedButton3 As CustomControls.RJControls.RoundedButton
    Friend WithEvents PictureBox2 As PictureBox
End Class
