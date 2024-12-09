Imports System.Drawing.Drawing2D

Public Class DoctorPrescriptionPatients
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
    ' Private field to store the selected patient ID
    Private _selectedPatient As Integer

    ' Public property to expose the selected patient ID
    Public Property SelectedPatient As Integer
        Get
            Return _selectedPatient
        End Get
        Private Set(value As Integer)
            _selectedPatient = value
        End Set
    End Property

    ' Back button to navigate to the menu page
    Private Sub BackButton(sender As Object, e As EventArgs) Handles PictureBox4.Click
        DoctorMenuPage.Show()
        Me.Hide()
    End Sub

    ' Event handlers for selecting a patient
    Private Sub SelectPatient1(sender As Object, e As EventArgs) Handles CirclePictureBox1.Click
        SelectedPatient = 1
        OpenPrescriptionForm()
    End Sub

    Private Sub SelectPatient2(sender As Object, e As EventArgs) Handles CirclePictureBox2.Click
        SelectedPatient = 2
        OpenPrescriptionForm()
    End Sub

    Private Sub SelectPatient3(sender As Object, e As EventArgs) Handles CirclePictureBox3.Click
        SelectedPatient = 3
        OpenPrescriptionForm()
    End Sub

    Private Sub SelectPatient4(sender As Object, e As EventArgs) Handles CirclePictureBox4.Click
        SelectedPatient = 4
        OpenPrescriptionForm()
    End Sub

    Private Sub SelectPatient5(sender As Object, e As EventArgs) Handles CirclePictureBox5.Click
        SelectedPatient = 5
        OpenPrescriptionForm()
    End Sub

    ' Method to open the DoctorPrescription form and pass the SelectedPatient
    Private Sub OpenPrescriptionForm()
        Dim prescriptionForm As New DoctorPrescription()
        prescriptionForm.SelectedPatientID = SelectedPatient ' Pass the selected patient ID
        prescriptionForm.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        DoctorMenuPage.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        DoctorMenuPage.Show()
        Me.Hide()
    End Sub
End Class
