Imports System.Drawing.Drawing2D

Public Class PatientList
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
        ShowPatientData("1") ' Pass the selected patient ID to PatientData
    End Sub

    Private Sub CirclePictureBox2_Click(sender As Object, e As EventArgs) Handles CirclePictureBox2.Click
        ShowPatientData("2") ' Pass the selected patient ID to PatientData
    End Sub

    Private Sub CirclePictureBox3_Click(sender As Object, e As EventArgs) Handles CirclePictureBox3.Click
        ShowPatientData("3") ' Pass the selected patient ID to PatientData
    End Sub

    Private Sub CirclePictureBox4_Click(sender As Object, e As EventArgs) Handles CirclePictureBox4.Click
        ShowPatientData("4") ' Pass the selected patient ID to PatientData
    End Sub

    Private Sub CirclePictureBox5_Click(sender As Object, e As EventArgs) Handles CirclePictureBox5.Click
        ShowPatientData("5") ' Pass the selected patient ID to PatientData
    End Sub

    ' Method to show PatientData form and pass the selected patient ID
    Private Sub ShowPatientData(patientID As String)
        Dim patientDataForm As New PatientData(patientID)
        patientDataForm.Show() ' Show the PatientData form
        Me.Hide() ' Hide the current form
    End Sub

    Private Sub Back_PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        NurseMenuPage.Show()
        Me.Close() ' You can replace this with code to show the previous form or navigate as required
    End Sub

    ' Home button functionality
    Private Sub Home_PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        NurseMenuPage.Show()
        Me.Hide()
    End Sub
End Class
