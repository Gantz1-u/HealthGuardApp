Imports System.Drawing.Drawing2D

Public Class SpecialistPage
    Inherits Form

    ' Define the radius for the rounded corners
    Private _cornerRadius As Integer = 50

    Public Sub New()
        InitializeComponent()
        ' Optionally, you can set the form's border style to None to get rid of the default border
        Me.FormBorderStyle = FormBorderStyle.None
        ' Call this method to apply rounded corners to the form
        ApplyRoundedCorners()
    End Sub

    ' This method applies the rounded corners to the form
    Private Sub ApplyRoundedCorners()
        Dim path As New GraphicsPath()
        ' Create a rounded rectangle path
        path.AddArc(0, 0, _cornerRadius, _cornerRadius, 180, 90) ' Top-left corner
        path.AddArc(Me.Width - _cornerRadius, 0, _cornerRadius, _cornerRadius, 270, 90) ' Top-right corner
        path.AddArc(Me.Width - _cornerRadius, Me.Height - _cornerRadius, _cornerRadius, _cornerRadius, 0, 90) ' Bottom-right corner
        path.AddArc(0, Me.Height - _cornerRadius, _cornerRadius, _cornerRadius, 90, 90) ' Bottom-left corner
        path.CloseFigure() ' Close the figure to form the rounded rectangle

        ' Set the form's region to the rounded rectangle path
        Me.Region = New Region(path)
    End Sub

    ' Optionally, handle the resizing of the form
    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        ApplyRoundedCorners() ' Reapply the rounded corners when resizing
    End Sub
    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) Handles PictureBox2.Click
        SymptomsPage.Show()
        Hide()
    End Sub

    Private Sub RoundedButton3_Click_1(sender As Object, e As EventArgs) Handles RoundedButton3.Click
        SchedulePage.Show() ' Show the form
        Hide()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        PatientMenuPage.Show()
        Hide()
    End Sub

    Private Sub SpecialistPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
