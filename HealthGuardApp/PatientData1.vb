Imports System.Drawing.Drawing2D
Public Class Frm_LoginForm
    Private studentID, password, in_studentID, in_password As String
    Private Sub Frm_LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        studentID = "1"
        password = "1"
        in_studentID = ""
        in_password = ""
    End Sub
    Private Sub Pnl_LoginPanel_Paint(sender As Object, e As PaintEventArgs) Handles pnl_LoginPanel.Paint
        Dim panelGraphicsPath As New GraphicsPath()
        Dim cornerRadius As Integer = 40 ' Adjust the corner radius
        Dim rect As New Rectangle(0, 0, pnl_LoginPanel.Width, pnl_LoginPanel.Height)

        ' Create rounded rectangle path
        panelGraphicsPath.AddArc(New Rectangle(rect.X, rect.Y, cornerRadius, cornerRadius), 180, 90)
        panelGraphicsPath.AddArc(New Rectangle(rect.Right - cornerRadius, rect.Y, cornerRadius, cornerRadius), 270, 90)
        panelGraphicsPath.AddArc(New Rectangle(rect.Right - cornerRadius, rect.Bottom - cornerRadius, cornerRadius, cornerRadius), 0, 90)
        panelGraphicsPath.AddArc(New Rectangle(rect.X, rect.Bottom - cornerRadius, cornerRadius, cornerRadius), 90, 90)
        panelGraphicsPath.CloseFigure()

        ' Set the Panel's Region to the rounded path
        pnl_LoginPanel.Region = New Region(panelGraphicsPath)
    End Sub
    Private Sub Txb_StudentID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txb_StudentID.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "-"c Then
            e.Handled = True
        End If
    End Sub
    Private Sub Txb_TextChanged(sender As Object, e As EventArgs) Handles Txb_Password.TextChanged, Txb_StudentID.TextChanged
        If sender Is Txb_Password Then
            in_password = Txb_Password.Text
        ElseIf sender Is Txb_StudentID Then
            in_studentID = Txb_StudentID.Text
        End If
    End Sub
    Private Sub Btn_LoginButton_Click(sender As Object, e As EventArgs) Handles Btn_LoginButton.Click
        If String.IsNullOrEmpty(in_studentID) AndAlso String.IsNullOrEmpty(in_password) Then
            MessageBox.Show("Must fill up all boxes")
        ElseIf in_studentID = studentID AndAlso in_password = password Then
            MessageBox.Show("Login Successful")
        Else
            MessageBox.Show("Invalid Student ID or Password, Please Try Again")
            Txb_Password.Clear()
            Txb_StudentID.Clear()
        End If
    End Sub
End Class
