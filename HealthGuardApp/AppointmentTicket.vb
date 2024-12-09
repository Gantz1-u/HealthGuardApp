Imports System.Drawing.Drawing2D

Public Class AppointmentTicket
    Inherits Form

    ' Define the radius for the rounded corners
    Private _cornerRadius As Integer = 50

    ' Store the appointment details
    Private savedAppointmentDate As Date
    Private savedAppointmentTime As String
    Private savedAppointmentNote As String
    Private savedDoctor As String

    ' Constructor for initializing with appointment details
    Public Sub New(doctor As String, appointmentDate As Date, appointmentTime As String, appointmentNote As String)
        InitializeComponent()
        Me.savedDoctor = doctor
        Me.savedAppointmentDate = appointmentDate
        Me.savedAppointmentTime = appointmentTime
        Me.savedAppointmentNote = appointmentNote
    End Sub

    ' Default constructor for design mode
    Public Sub New()
        InitializeComponent()
    End Sub

    ' Form Load Event to display appointment details
    Private Sub AppointmentTicket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_AppointmentDate.Text = savedAppointmentDate.ToString("yyyy-MM-dd")
        lbl_AppointmentTime.Text = savedAppointmentTime
        lbl_Doctor.Text = SymptomsPage.SelectedDoctor
        Label6.Text = savedAppointmentNote
        lbl_LoggedInUser.Text = Convert.ToInt32(LoginPage.LoggedInUserID)
    End Sub

    ' Handle Cancel button click
    Private Sub Cancel(sender As Object, e As EventArgs)
        PatientMenuPage.Show()
        Hide()
    End Sub

    ' Handle Save button click
    Private Sub SaveAppointment(sender As Object, e As EventArgs) Handles RoundedButton1.Click
        savedAppointmentDate = DateTime.Parse(lbl_AppointmentDate.Text)
        savedAppointmentTime = lbl_AppointmentTime.Text
        savedAppointmentNote = Label6.Text
        savedDoctor = lbl_Doctor.Text

        MessageBox.Show("Appointment saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        PatientMenuPage.Show()
        Hide()
    End Sub

    ' Handle navigating to AppointmentPage
    Private Sub RoundedButton2_Click(sender As Object, e As EventArgs) Handles RoundedButton2.Click
        AppointmentPage.Show()
        Me.Hide()
    End Sub

    ' PictureBox Click Event to navigate to PatientMenuPage
    Private Sub PictureBox_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click, PictureBox1.Click
        PatientMenuPage.Show()
        Hide()
    End Sub
End Class
