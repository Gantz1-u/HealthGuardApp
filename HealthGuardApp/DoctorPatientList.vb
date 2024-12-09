Imports System.Drawing.Drawing2D

Public Class DoctorPatientList
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

    ' PictureBox click handlers for CirclePictureBox
    Private Sub CirclePictureBox1_Click(sender As Object, e As EventArgs) Handles CirclePictureBox1.Click
        ShowDoctorPatientData("1") ' Pass the selected patient ID to DoctorPatientData
    End Sub

    Private Sub CirclePictureBox2_Click(sender As Object, e As EventArgs) Handles CirclePictureBox2.Click
        ShowDoctorPatientData("2") ' Pass the selected patient ID to DoctorPatientData
    End Sub

    Private Sub CirclePictureBox3_Click(sender As Object, e As EventArgs) Handles CirclePictureBox3.Click
        ShowDoctorPatientData("3") ' Pass the selected patient ID to DoctorPatientData
    End Sub

    Private Sub CirclePictureBox4_Click(sender As Object, e As EventArgs) Handles CirclePictureBox4.Click
        ShowDoctorPatientData("4") ' Pass the selected patient ID to DoctorPatientData
    End Sub

    Private Sub CirclePictureBox5_Click(sender As Object, e As EventArgs) Handles CirclePictureBox5.Click
        ShowDoctorPatientData("5") ' Pass the selected patient ID to DoctorPatientData
    End Sub

    ' Method to show DoctorPatientData form and pass the selected patient ID
    Private Sub ShowDoctorPatientData(patientID As String)
        Dim doctorPatientDataForm As New DoctorPatientData(patientID)
        doctorPatientDataForm.Show() ' Show the DoctorPatientData form
        Me.Hide() ' Hide the current form
    End Sub

    ' Back button functionality
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        DoctorMenuPage.Show()
        Me.Hide() ' Navigate back to the DoctorMenuPage
    End Sub

    ' Home button functionality
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        DoctorMenuPage.Show()
        Me.Hide()
    End Sub
End Class
