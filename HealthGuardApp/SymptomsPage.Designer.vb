<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SymptomsPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SymptomsPage))
        PictureBox3 = New PictureBox()
        PictureBox2 = New PictureBox()
        RoundedButton3 = New CustomControls.RJControls.RoundedButton()
        Panel1 = New Panel()
        Label1 = New Label()
        PictureBox4 = New PictureBox()
        RoundedButton1 = New CustomControls.RJControls.RoundedButton()
        RoundedButton2 = New CustomControls.RJControls.RoundedButton()
        RoundedButton4 = New CustomControls.RJControls.RoundedButton()
        RoundedButton5 = New CustomControls.RJControls.RoundedButton()
        Label2 = New Label()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Transparent
        PictureBox3.Cursor = Cursors.Hand
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(25, 14)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(40, 25)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 3
        PictureBox3.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Cursor = Cursors.Hand
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(27, 86)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(38, 36)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 13
        PictureBox2.TabStop = False
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
        RoundedButton3.Location = New Point(25, 611)
        RoundedButton3.Name = "RoundedButton3"
        RoundedButton3.Size = New Size(348, 52)
        RoundedButton3.TabIndex = 33
        RoundedButton3.Text = "Orthopedics"
        RoundedButton3.TextColor = Color.Black
        RoundedButton3.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(PictureBox3)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox4)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(400, 68)
        Panel1.TabIndex = 34
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(22, 42)
        Label1.Name = "Label1"
        Label1.Size = New Size(47, 16)
        Label1.TabIndex = 5
        Label1.Text = "HOME"
        Label1.TextAlign = ContentAlignment.TopCenter
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
        RoundedButton1.Location = New Point(25, 344)
        RoundedButton1.Name = "RoundedButton1"
        RoundedButton1.Size = New Size(348, 52)
        RoundedButton1.TabIndex = 35
        RoundedButton1.Text = "Dermatology"
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
        RoundedButton2.Location = New Point(25, 433)
        RoundedButton2.Name = "RoundedButton2"
        RoundedButton2.Size = New Size(348, 52)
        RoundedButton2.TabIndex = 36
        RoundedButton2.Text = "Physical Therapy"
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
        RoundedButton4.Font = New Font("Segoe UI", 10F)
        RoundedButton4.ForeColor = Color.Black
        RoundedButton4.Location = New Point(26, 522)
        RoundedButton4.Name = "RoundedButton4"
        RoundedButton4.Size = New Size(348, 52)
        RoundedButton4.TabIndex = 37
        RoundedButton4.Text = "Psychiatry"
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
        RoundedButton5.Font = New Font("Segoe UI", 10F)
        RoundedButton5.ForeColor = Color.Black
        RoundedButton5.Location = New Point(25, 255)
        RoundedButton5.Name = "RoundedButton5"
        RoundedButton5.Size = New Size(349, 52)
        RoundedButton5.TabIndex = 38
        RoundedButton5.Text = "Pediatrics "
        RoundedButton5.TextColor = Color.Black
        RoundedButton5.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(132, 178)
        Label2.Name = "Label2"
        Label2.Size = New Size(138, 25)
        Label2.TabIndex = 39
        Label2.Text = "Find Specialist"
        ' 
        ' SymptomsPage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(400, 750)
        Controls.Add(Label2)
        Controls.Add(RoundedButton5)
        Controls.Add(RoundedButton4)
        Controls.Add(RoundedButton2)
        Controls.Add(RoundedButton1)
        Controls.Add(Panel1)
        Controls.Add(RoundedButton3)
        Controls.Add(PictureBox2)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "SymptomsPage"
        StartPosition = FormStartPosition.CenterScreen
        Text = "SymptomsPage"
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents RoundedButton3 As CustomControls.RJControls.RoundedButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents RoundedButton1 As CustomControls.RJControls.RoundedButton
    Friend WithEvents RoundedButton2 As CustomControls.RJControls.RoundedButton
    Friend WithEvents RoundedButton4 As CustomControls.RJControls.RoundedButton
    Friend WithEvents RoundedButton5 As CustomControls.RJControls.RoundedButton
    Friend WithEvents Label2 As Label
End Class
