Public Class appointment
    ' Private variables to store appointment details
    Private AppointmentDate As Date
    Private AppointmentTime As String
    Private AppointmentNote As String

    ' Public read-only properties to expose appointment details
    Public ReadOnly Property SelectedAppointmentDate As Date
        Get
            Return AppointmentDate
        End Get
    End Property

    Public ReadOnly Property SelectedAppointmentTime As String
        Get
            Return AppointmentTime
        End Get
    End Property

    Public ReadOnly Property SelectedAppointmentNote As String
        Get
            Return AppointmentNote
        End Get
    End Property

    ' Reference to the last selected button
    Private lastSelectedButton As Button

    ' Form Load Event
    Private Sub appointment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Clear private appointment variables
        AppointmentDate = Nothing
        AppointmentTime = String.Empty
        AppointmentNote = String.Empty

        ' Reset controls
        dtp_AppointmentDate.Value = Date.Today ' Default to today's date
        txt_Note.Clear()

        ' Reset button highlights
        If lastSelectedButton IsNot Nothing Then
            lastSelectedButton.BackColor = Color.White
            lastSelectedButton = Nothing
        End If
    End Sub

    ' Handle Confirm Appointment button click
    Private Sub ConfirmAppointment(sender As Object, e As EventArgs) Handles RoundedButton16.Click
        ' Store the selected date, time, and note
        AppointmentDate = dtp_AppointmentDate.Value.Date
        AppointmentNote = txt_Note.Text.Trim()

        ' Ensure AppointmentTime is selected before proceeding
        If String.IsNullOrEmpty(AppointmentTime) Then
            MessageBox.Show("Please select an appointment time.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Proceed to the AppointmentTicket form
        Dim ticketForm As New AppointmentTicket()
        ticketForm.Show()
        Me.Hide()
    End Sub

    ' Handle Back button click
    Private Sub BackButton(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
        SpecialistPage.Show()
    End Sub

    ' Appointment time button click handlers
    Private Sub btn_9_Click(sender As Object, e As EventArgs) Handles btn_9.Click
        SetAppointmentTime("9:00", btn_9)
    End Sub

    Private Sub btn_930_Click(sender As Object, e As EventArgs) Handles btn_930.Click
        SetAppointmentTime("9:30", btn_930)
    End Sub

    Private Sub btn_10_Click(sender As Object, e As EventArgs) Handles btn_10.Click
        SetAppointmentTime("10:00", btn_10)
    End Sub

    Private Sub btn_1030_Click(sender As Object, e As EventArgs) Handles btn_1030.Click
        SetAppointmentTime("10:30", btn_1030)
    End Sub

    Private Sub btn_13_Click(sender As Object, e As EventArgs) Handles btn_13.Click
        SetAppointmentTime("13:00", btn_13)
    End Sub

    Private Sub btn_1330_Click(sender As Object, e As EventArgs) Handles btn_1330.Click
        SetAppointmentTime("13:30", btn_1330)
    End Sub

    Private Sub btn_14_Click(sender As Object, e As EventArgs) Handles btn_14.Click
        SetAppointmentTime("14:00", btn_14)
    End Sub

    Private Sub btn_1430_Click(sender As Object, e As EventArgs) Handles btn_1430.Click
        SetAppointmentTime("14:30", btn_1430)
    End Sub

    Private Sub btn_15_Click(sender As Object, e As EventArgs) Handles btn_15.Click
        SetAppointmentTime("15:00", btn_15)
    End Sub

    Private Sub btn_1530_Click(sender As Object, e As EventArgs) Handles btn_1530.Click
        SetAppointmentTime("15:30", btn_1530)
    End Sub

    Private Sub btn_16_Click(sender As Object, e As EventArgs) Handles btn_16.Click
        SetAppointmentTime("16:00", btn_16)
    End Sub

    Private Sub btn_1630_Click(sender As Object, e As EventArgs) Handles btn_1630.Click
        SetAppointmentTime("16:30", btn_1630)
    End Sub

    Private Sub btn_17_Click(sender As Object, e As EventArgs) Handles btn_17.Click
        SetAppointmentTime("17:00", btn_17)
    End Sub

    Private Sub btn_1730_Click(sender As Object, e As EventArgs) Handles btn_1730.Click
        SetAppointmentTime("17:30", btn_1730)
    End Sub

    Private Sub btn_18_Click(sender As Object, e As EventArgs) Handles btn_18.Click
        SetAppointmentTime("18:00", btn_18)
    End Sub

    ' Method to set the appointment time and highlight the selected button
    Private Sub SetAppointmentTime(time As String, selectedButton As Button)
        ' Update the private AppointmentTime variable
        AppointmentTime = time

        ' Reset the background color of the last selected button
        If lastSelectedButton IsNot Nothing Then
            lastSelectedButton.BackColor = Color.White
        End If

        ' Set the background color of the selected button and store it as the last selected
        selectedButton.BackColor = Color.SteelBlue
        lastSelectedButton = selectedButton
    End Sub
End Class
