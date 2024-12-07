﻿Public Class SchedulePage
    Private AppointmentDate As Date
    Private AppointmentTime As String
    Private AppointmentNote As String
    Private lastSelectedButton As Button

    ' Constructor to initialize the page with the selected doctor name


    ' Property to get and set the doctor name


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

        ' Create a new AppointmentTicket form and pass the doctor name, date, time, and note
        Dim ticketForm As New AppointmentTicket(" ", AppointmentDate, AppointmentTime, AppointmentNote)
        ticketForm.Show()
        Me.Hide()
    End Sub

    ' Handle Back button click
    Private Sub BackButton(sender As Object, e As EventArgs) Handles PictureBox2.Click
        SpecialistPage.Show()
        Me.Hide()
    End Sub

    ' Appointment time button click handlers
    Private Sub btn_9_Click(sender As Object, e As EventArgs) Handles btn_9.Click
        SetAppointmentTime("9:00 AM", btn_9)
    End Sub

    Private Sub btn_930_Click(sender As Object, e As EventArgs) Handles btn_930.Click
        SetAppointmentTime("9:30 AM", btn_930)
    End Sub

    Private Sub btn_10_Click(sender As Object, e As EventArgs) Handles btn_10.Click
        SetAppointmentTime("10:00 AM", btn_10)
    End Sub
    Private Sub btn_1030_Click(sender As Object, e As EventArgs) Handles btn_1030.Click
        SetAppointmentTime("10:30 AM", btn_1030)
    End Sub
    Private Sub btn_13_Click(sender As Object, e As EventArgs) Handles btn_13.Click
        SetAppointmentTime("11:00 AM", btn_13)
    End Sub
    Private Sub btn_1330_Click(sender As Object, e As EventArgs) Handles btn_1330.Click
        SetAppointmentTime("13:30 AM", btn_1330)
    End Sub
    Private Sub btn_14_Click(sender As Object, e As EventArgs) Handles btn_14.Click
        SetAppointmentTime("14:00 AM", btn_14)
    End Sub
    Private Sub btn_1430_Click(sender As Object, e As EventArgs) Handles btn_1430.Click
        SetAppointmentTime("14:30 AM", btn_1430)
    End Sub
    Private Sub btn_15_Click(sender As Object, e As EventArgs) Handles btn_15.Click
        SetAppointmentTime("15:00 AM", btn_15)
    End Sub
    Private Sub btn_1530_Click(sender As Object, e As EventArgs) Handles btn_1530.Click
        SetAppointmentTime("15:30 AM", btn_1530)
    End Sub
    Private Sub btn_16_Click(sender As Object, e As EventArgs) Handles btn_16.Click
        SetAppointmentTime("16:00 AM", btn_16)
    End Sub
    Private Sub btn_1630_Click(sender As Object, e As EventArgs) Handles btn_1630.Click
        SetAppointmentTime("16:30 AM", btn_1630)
    End Sub
    Private Sub btn_17_Click(sender As Object, e As EventArgs) Handles btn_17.Click
        SetAppointmentTime("17:00 AM", btn_17)
    End Sub
    Private Sub btn_1730_Click(sender As Object, e As EventArgs) Handles btn_1730.Click
        SetAppointmentTime("17:30 AM", btn_1730)
    End Sub
    Private Sub btn_18_Click(sender As Object, e As EventArgs) Handles btn_18.Click
        SetAppointmentTime("18:00 AM", btn_18)
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
