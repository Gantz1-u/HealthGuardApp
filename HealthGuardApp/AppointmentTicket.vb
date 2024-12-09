Imports System.Drawing.Drawing2D

Public Class AppointmentTicket
    Inherits Form

    ' Define the radius for the rounded corners
    Private _cornerRadius As Integer = 50

    Public Sub Old()
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

    Private appointmentDate As Date
    Private appointmentTime As String
    Private appointmentNote As String
    Private doctor As String ' To store the doctor's name

    ' Constructor to receive appointment details and doctor's name
    Public Sub New(doctor As String, appointmentDate As Date, appointmentTime As String, appointmentNote As String)
        InitializeComponent()
        Me.doctor = doctor ' Store the doctor's name
        Me.appointmentDate = appointmentDate
        Me.appointmentTime = appointmentTime
        Me.appointmentNote = appointmentNote
    End Sub

    ' Default constructor for design mode (required by Visual Studio Designer)
    Public Sub New()
        InitializeComponent()
    End Sub

    ' Form Load Event to display the appointment details
    Private Sub AppointmentTicket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Display the appointment details using the received parameters
        lbl_AppointmentDate.Text = appointmentDate.ToString("yyyy-MM-dd") ' Format the date
        lbl_AppointmentTime.Text = appointmentTime ' Display the selected time
        lbl_Doctor.Text = SymptomsPage.SelectedDoctor ' Display the doctor's name (Passed from SchedulePage)
        Label6.Text = appointmentNote ' Display the entered note
    End Sub

    ' Handle Cancel button click
    Private Sub Cancel(sender As Object, e As EventArgs)
        PatientMenuPage.Show() ' Show the PatientMenuPage
        Hide() ' Hide the current form (AppointmentTicket)
    End Sub

    ' Handle Save button click
    Private Sub SaveButton(sender As Object, e As EventArgs)
        ' Implement save logic here (e.g., save to database or memory)
        MessageBox.Show("Appointment saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        PatientMenuPage.Show()
        Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        PatientMenuPage.Show()
        Hide()
    End Sub


End Class
