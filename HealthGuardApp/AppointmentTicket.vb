Imports System.Drawing.Drawing2D

Public Class AppointmentTicket
    Inherits Form

    ' Define the radius for the rounded corners
    Private _cornerRadius As Integer = 50

    ' Store the appointment details for the entire session
    Private savedAppointmentDate As Date
    Private savedAppointmentTime As String
    Private savedAppointmentNote As String
    Private savedDoctor As String

    Public Sub New(doctor As String, appointmentDate As Date, appointmentTime As String, appointmentNote As String)
        InitializeComponent()
        Me.savedDoctor = doctor
        Me.savedAppointmentDate = appointmentDate
        Me.savedAppointmentTime = appointmentTime
        Me.savedAppointmentNote = appointmentNote
    End Sub

    ' Default constructor for design mode (required by Visual Studio Designer)
    Public Sub New()
        InitializeComponent()
    End Sub

    ' Form Load Event to display the appointment details
    Private Sub AppointmentTicket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Display the saved appointment details
        lbl_AppointmentDate.Text = savedAppointmentDate.ToString("yyyy-MM-dd")
        lbl_AppointmentTime.Text = savedAppointmentTime
        lbl_Doctor.Text = SymptomsPage.SelectedDoctor ' Fetch the doctor's name from SymptomsPage
        Label6.Text = savedAppointmentNote
        lbl_LoggedInUser.Text = Convert.ToInt32(LoginPage.LoggedInUserID)
    End Sub

    ' Handle Cancel button click
    Private Sub Cancel(sender As Object, e As EventArgs)
        PatientMenuPage.Show() ' Show the PatientMenuPage
        Hide() ' Hide the current form (AppointmentTicket)
    End Sub

    ' Handle Save button click
    Private Sub SaveButton(sender As Object, e As EventArgs)
        ' Store the current text values in the saved variables
        savedAppointmentDate = DateTime.Parse(lbl_AppointmentDate.Text)
        savedAppointmentTime = lbl_AppointmentTime.Text
        savedAppointmentNote = Label6.Text
        savedDoctor = lbl_Doctor.Text ' Store the doctor's name as well

        ' Notify the user that the appointment has been saved
        MessageBox.Show("Appointment saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        PatientMenuPage.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        PatientMenuPage.Show()
        Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        PatientMenuPage.Show()
        Hide()
    End Sub

    Private Sub SaveAppointment(sender As Object, e As EventArgs) Handles RoundedButton1.Click
        ' When save is pressed, hold the current values and prevent them from changing
        savedAppointmentDate = DateTime.Parse(lbl_AppointmentDate.Text)
        savedAppointmentTime = lbl_AppointmentTime.Text
        savedAppointmentNote = Label6.Text
        savedDoctor = lbl_Doctor.Text ' Store the doctor's name as well

        ' Optionally, save data to a database or another storage here

        MessageBox.Show("Appointment saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub RoundedButton2_Click(sender As Object, e As EventArgs) Handles RoundedButton2.Click
        AppointmentPage.Show()
        Me.Hide()
    End Sub
End Class
