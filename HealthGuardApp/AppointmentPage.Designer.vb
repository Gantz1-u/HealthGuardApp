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
        Panel1 = New Panel()
        PictureBox2 = New PictureBox()
        RoundedButton2 = New CustomControls.RJControls.RoundedButton()
        RoundedButton4 = New CustomControls.RJControls.RoundedButton()
        btn_Home = New Button()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(btn_Home)
        Panel1.Location = New Point(-19, -6)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(422, 68)
        Panel1.TabIndex = 12
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
        PictureBox2.TabIndex = 10
        PictureBox2.TabStop = False
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
        RoundedButton2.Location = New Point(122, 348)
        RoundedButton2.Name = "RoundedButton2"
        RoundedButton2.Size = New Size(136, 118)
        RoundedButton2.TabIndex = 14
        RoundedButton2.Text = "Scheduled Appointment"
        RoundedButton2.TextAlign = ContentAlignment.BottomCenter
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
        RoundedButton4.FlatAppearance.BorderSize = 0
        RoundedButton4.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        RoundedButton4.FlatStyle = FlatStyle.Flat
        RoundedButton4.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RoundedButton4.ForeColor = Color.Black
        RoundedButton4.Image = CType(resources.GetObject("RoundedButton4.Image"), Image)
        RoundedButton4.Location = New Point(122, 194)
        RoundedButton4.Name = "RoundedButton4"
        RoundedButton4.Size = New Size(136, 118)
        RoundedButton4.TabIndex = 21
        RoundedButton4.Text = "New Appointment"
        RoundedButton4.TextAlign = ContentAlignment.BottomCenter
        RoundedButton4.TextColor = Color.Black
        RoundedButton4.UseVisualStyleBackColor = False
        ' 
        ' btn_Home
        ' 
        btn_Home.FlatStyle = FlatStyle.Flat
        btn_Home.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_Home.Image = Resources.icon_home
        btn_Home.ImageAlign = ContentAlignment.TopCenter
        btn_Home.Location = New Point(18, -1)
        btn_Home.Name = "btn_Home"
        btn_Home.Size = New Size(54, 68)
        btn_Home.TabIndex = 73
        btn_Home.Text = "Home"
        btn_Home.TextImageRelation = TextImageRelation.ImageAboveText
        btn_Home.UseVisualStyleBackColor = True
        ' 
        ' AppointmentPage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(384, 711)
        Controls.Add(RoundedButton4)
        Controls.Add(RoundedButton2)
        Controls.Add(Panel1)
        Controls.Add(PictureBox2)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "AppointmentPage"
        StartPosition = FormStartPosition.CenterScreen
        Text = "AppointmentPage"
        Panel1.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents RoundedButton2 As CustomControls.RJControls.RoundedButton
    Friend WithEvents RoundedButton4 As CustomControls.RJControls.RoundedButton
    Friend WithEvents btn_Home As Button
End Class
