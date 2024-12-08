Public Class AppointmentTicket

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
        txt_AppointmentNote.Text = appointmentNote ' Display the entered note
    End Sub

    ' Handle Cancel button click
    Private Sub Cancel(sender As Object, e As EventArgs) Handles RoundedButton2.Click
        PatientMenuPage.Show() ' Show the PatientMenuPage
        Me.Hide() ' Hide the current form (AppointmentTicket)
    End Sub

    ' Handle Save button click
    Private Sub SaveButton(sender As Object, e As EventArgs) Handles RoundedButton1.Click
        ' Implement save logic here (e.g., save to database or memory)
        MessageBox.Show("Appointment saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
