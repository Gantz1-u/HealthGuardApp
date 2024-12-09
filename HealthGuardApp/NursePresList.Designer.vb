<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NursePresList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NursePresList))
        RoundedPanel1 = New RoundedPanel()
        RoundedPanel4 = New RoundedPanel()
        RoundedPanel2 = New RoundedPanel()
        Label3 = New Label()
        Label2 = New Label()
        CirclePictureBox1 = New CirclePictureBox()
        RoundedPanel3 = New RoundedPanel()
        RoundedTextBox1 = New RoundedTextBox()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        Panel1 = New Panel()
        Label1 = New Label()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        RoundedPanel1.SuspendLayout()
        RoundedPanel4.SuspendLayout()
        RoundedPanel2.SuspendLayout()
        CType(CirclePictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        RoundedPanel3.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
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
        RoundedPanel1.Controls.Add(RoundedPanel4)
        RoundedPanel1.Controls.Add(PictureBox1)
        RoundedPanel1.Controls.Add(Panel1)
        RoundedPanel1.CornerRadius = 35
        RoundedPanel1.Location = New Point(12, 26)
        RoundedPanel1.Name = "RoundedPanel1"
        RoundedPanel1.Size = New Size(376, 712)
        RoundedPanel1.TabIndex = 0
        ' 
        ' RoundedPanel4
        ' 
        RoundedPanel4.BackColor = Color.White
        RoundedPanel4.Controls.Add(RoundedPanel2)
        RoundedPanel4.Controls.Add(RoundedPanel3)
        RoundedPanel4.CornerRadius = 20
        RoundedPanel4.Location = New Point(11, 138)
        RoundedPanel4.Name = "RoundedPanel4"
        RoundedPanel4.Size = New Size(355, 555)
        RoundedPanel4.TabIndex = 70
        ' 
        ' RoundedPanel2
        ' 
        RoundedPanel2.BackColor = SystemColors.Control
        RoundedPanel2.Controls.Add(Label3)
        RoundedPanel2.Controls.Add(Label2)
        RoundedPanel2.Controls.Add(CirclePictureBox1)
        RoundedPanel2.CornerRadius = 20
        RoundedPanel2.Location = New Point(29, 67)
        RoundedPanel2.Name = "RoundedPanel2"
        RoundedPanel2.Size = New Size(296, 86)
        RoundedPanel2.TabIndex = 11
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 13F)
        Label3.Location = New Point(189, 30)
        Label3.Name = "Label3"
        Label3.Size = New Size(47, 25)
        Label3.TabIndex = 9
        Label3.Text = "Cruz"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 13F)
        Label2.Location = New Point(108, 30)
        Label2.Name = "Label2"
        Label2.Size = New Size(87, 25)
        Label2.TabIndex = 8
        Label2.Text = "Juan Dela"
        ' 
        ' CirclePictureBox1
        ' 
        CirclePictureBox1.BorderRadius = 20
        CirclePictureBox1.Image = CType(resources.GetObject("CirclePictureBox1.Image"), Image)
        CirclePictureBox1.Location = New Point(24, 11)
        CirclePictureBox1.Name = "CirclePictureBox1"
        CirclePictureBox1.Size = New Size(78, 62)
        CirclePictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        CirclePictureBox1.TabIndex = 8
        CirclePictureBox1.TabStop = False
        ' 
        ' RoundedPanel3
        ' 
        RoundedPanel3.BackColor = SystemColors.Control
        RoundedPanel3.Controls.Add(RoundedTextBox1)
        RoundedPanel3.Controls.Add(PictureBox2)
        RoundedPanel3.CornerRadius = 20
        RoundedPanel3.Location = New Point(12, 11)
        RoundedPanel3.Name = "RoundedPanel3"
        RoundedPanel3.Size = New Size(331, 35)
        RoundedPanel3.TabIndex = 10
        ' 
        ' RoundedTextBox1
        ' 
        RoundedTextBox1.BackColor = SystemColors.Control
        RoundedTextBox1.Location = New Point(13, 6)
        RoundedTextBox1.Name = "RoundedTextBox1"
        RoundedTextBox1.PlaceholderText = "Search"
        RoundedTextBox1.Size = New Size(280, 23)
        RoundedTextBox1.TabIndex = 7
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(297, 7)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(27, 20)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 8
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Cursor = Cursors.Hand
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(13, 81)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(38, 36)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 69
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
        Panel1.TabIndex = 68
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
        ' NursePresList
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(400, 750)
        Controls.Add(RoundedPanel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "NursePresList"
        StartPosition = FormStartPosition.CenterScreen
        Text = "NursePresList"
        RoundedPanel1.ResumeLayout(False)
        RoundedPanel4.ResumeLayout(False)
        RoundedPanel2.ResumeLayout(False)
        RoundedPanel2.PerformLayout()
        CType(CirclePictureBox1, ComponentModel.ISupportInitialize).EndInit()
        RoundedPanel3.ResumeLayout(False)
        RoundedPanel3.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents RoundedPanel4 As RoundedPanel
    Friend WithEvents RoundedPanel2 As RoundedPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CirclePictureBox1 As CirclePictureBox
    Friend WithEvents RoundedPanel3 As RoundedPanel
    Friend WithEvents RoundedTextBox1 As RoundedTextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
End Class
