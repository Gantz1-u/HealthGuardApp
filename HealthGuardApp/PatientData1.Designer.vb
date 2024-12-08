<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_LoginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        pnl_Top = New Panel()
        lbl_HeaderText = New Label()
        tbl_CenterContainer = New TableLayoutPanel()
        pnl_LoginPanel = New TableLayoutPanel()
        Lbl_Password = New Label()
        Btn_LoginButton = New Button()
        Txb_StudentID = New TextBox()
        Txb_Password = New TextBox()
        Lbl_StudentID = New Label()
        pnl_Top.SuspendLayout()
        tbl_CenterContainer.SuspendLayout()
        pnl_LoginPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnl_Top
        ' 
        pnl_Top.BackColor = Color.FromArgb(CByte(157), CByte(154), CByte(149))
        pnl_Top.Controls.Add(lbl_HeaderText)
        pnl_Top.Dock = DockStyle.Top
        pnl_Top.Location = New Point(0, 0)
        pnl_Top.Name = "pnl_Top"
        pnl_Top.Size = New Size(1068, 77)
        pnl_Top.TabIndex = 0
        ' 
        ' lbl_HeaderText
        ' 
        lbl_HeaderText.BackColor = Color.FromArgb(CByte(159), CByte(150), CByte(144))
        lbl_HeaderText.CausesValidation = False
        lbl_HeaderText.Dock = DockStyle.Fill
        lbl_HeaderText.Enabled = False
        lbl_HeaderText.Font = New Font("Lucida Console", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_HeaderText.Location = New Point(0, 0)
        lbl_HeaderText.Name = "lbl_HeaderText"
        lbl_HeaderText.Size = New Size(1068, 77)
        lbl_HeaderText.TabIndex = 1
        lbl_HeaderText.Text = "QCU GRADE CALCULATOR"
        lbl_HeaderText.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' tbl_CenterContainer
        ' 
        tbl_CenterContainer.AutoSize = True
        tbl_CenterContainer.ColumnCount = 3
        tbl_CenterContainer.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        tbl_CenterContainer.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 60F))
        tbl_CenterContainer.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        tbl_CenterContainer.Controls.Add(pnl_LoginPanel, 1, 1)
        tbl_CenterContainer.Dock = DockStyle.Fill
        tbl_CenterContainer.Location = New Point(0, 77)
        tbl_CenterContainer.Name = "tbl_CenterContainer"
        tbl_CenterContainer.RowCount = 3
        tbl_CenterContainer.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        tbl_CenterContainer.RowStyles.Add(New RowStyle(SizeType.Percent, 60F))
        tbl_CenterContainer.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        tbl_CenterContainer.Size = New Size(1068, 511)
        tbl_CenterContainer.TabIndex = 1
        ' 
        ' pnl_LoginPanel
        ' 
        pnl_LoginPanel.BackColor = Color.FromArgb(CByte(159), CByte(153), CByte(145))
        pnl_LoginPanel.ColumnCount = 2
        pnl_LoginPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 30F))
        pnl_LoginPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 70F))
        pnl_LoginPanel.Controls.Add(Lbl_Password, 0, 1)
        pnl_LoginPanel.Controls.Add(Btn_LoginButton, 0, 2)
        pnl_LoginPanel.Controls.Add(Txb_StudentID, 1, 0)
        pnl_LoginPanel.Controls.Add(Txb_Password, 1, 1)
        pnl_LoginPanel.Controls.Add(Lbl_StudentID, 0, 0)
        pnl_LoginPanel.Dock = DockStyle.Fill
        pnl_LoginPanel.Location = New Point(218, 107)
        pnl_LoginPanel.Margin = New Padding(5)
        pnl_LoginPanel.Name = "pnl_LoginPanel"
        pnl_LoginPanel.Padding = New Padding(50)
        pnl_LoginPanel.RowCount = 3
        pnl_LoginPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 37.5F))
        pnl_LoginPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 37.5F))
        pnl_LoginPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
        pnl_LoginPanel.Size = New Size(630, 296)
        pnl_LoginPanel.TabIndex = 0
        ' 
        ' Lbl_Password
        ' 
        Lbl_Password.Anchor = AnchorStyles.None
        Lbl_Password.AutoEllipsis = True
        Lbl_Password.AutoSize = True
        Lbl_Password.Font = New Font("Segoe UI", 13F)
        Lbl_Password.Location = New Point(75, 144)
        Lbl_Password.Name = "Lbl_Password"
        Lbl_Password.Size = New Size(108, 30)
        Lbl_Password.TabIndex = 1
        Lbl_Password.Text = "Password:"
        ' 
        ' Btn_LoginButton
        ' 
        Btn_LoginButton.Anchor = AnchorStyles.None
        Btn_LoginButton.AutoSize = True
        Btn_LoginButton.BackColor = Color.FromArgb(CByte(231), CByte(233), CByte(236))
        pnl_LoginPanel.SetColumnSpan(Btn_LoginButton, 2)
        Btn_LoginButton.Font = New Font("Segoe UI", 13F)
        Btn_LoginButton.Location = New Point(265, 201)
        Btn_LoginButton.Name = "Btn_LoginButton"
        Btn_LoginButton.Size = New Size(99, 40)
        Btn_LoginButton.TabIndex = 2
        Btn_LoginButton.Text = "Login"
        Btn_LoginButton.UseVisualStyleBackColor = False
        ' 
        ' Txb_StudentID
        ' 
        Txb_StudentID.Anchor = AnchorStyles.Left
        Txb_StudentID.BackColor = Color.FromArgb(CByte(231), CByte(233), CByte(236))
        Txb_StudentID.BorderStyle = BorderStyle.FixedSingle
        Txb_StudentID.Font = New Font("Segoe UI", 13F)
        Txb_StudentID.Location = New Point(212, 68)
        Txb_StudentID.Name = "Txb_StudentID"
        Txb_StudentID.PlaceholderText = "23-0000"
        Txb_StudentID.Size = New Size(365, 36)
        Txb_StudentID.TabIndex = 3
        ' 
        ' Txb_Password
        ' 
        Txb_Password.Anchor = AnchorStyles.Left
        Txb_Password.BackColor = Color.FromArgb(CByte(231), CByte(233), CByte(236))
        Txb_Password.BorderStyle = BorderStyle.FixedSingle
        Txb_Password.Font = New Font("Segoe UI", 13F)
        Txb_Password.Location = New Point(212, 141)
        Txb_Password.Name = "Txb_Password"
        Txb_Password.PasswordChar = "*"c
        Txb_Password.PlaceholderText = "*****"
        Txb_Password.Size = New Size(365, 36)
        Txb_Password.TabIndex = 4
        ' 
        ' Lbl_StudentID
        ' 
        Lbl_StudentID.Anchor = AnchorStyles.None
        Lbl_StudentID.AutoEllipsis = True
        Lbl_StudentID.AutoSize = True
        Lbl_StudentID.Font = New Font("Segoe UI", 13F)
        Lbl_StudentID.Location = New Point(70, 71)
        Lbl_StudentID.Name = "Lbl_StudentID"
        Lbl_StudentID.Size = New Size(119, 30)
        Lbl_StudentID.TabIndex = 0
        Lbl_StudentID.Text = "Student ID:"
        ' 
        ' Frm_LoginForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(231), CByte(233), CByte(236))
        ClientSize = New Size(1068, 588)
        Controls.Add(tbl_CenterContainer)
        Controls.Add(pnl_Top)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximumSize = New Size(1086, 635)
        MinimumSize = New Size(1086, 635)
        Name = "Frm_LoginForm"
        Text = "QCU Grade Calculator"
        TopMost = True
        WindowState = FormWindowState.Minimized
        pnl_Top.ResumeLayout(False)
        tbl_CenterContainer.ResumeLayout(False)
        pnl_LoginPanel.ResumeLayout(False)
        pnl_LoginPanel.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pnl_Top As Panel
    Friend WithEvents lbl_HeaderText As Label
    Friend WithEvents tbl_CenterContainer As TableLayoutPanel
    Friend WithEvents pnl_LoginPanel As TableLayoutPanel
    Friend WithEvents Lbl_StudentID As Label
    Friend WithEvents Lbl_Password As Label
    Friend WithEvents Btn_LoginButton As Button
    Friend WithEvents Txb_StudentID As TextBox
    Friend WithEvents Txb_Password As TextBox

End Class
