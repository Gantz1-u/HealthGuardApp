Imports System.Drawing.Drawing2D

Public Class SchedulePage
    Inherits Form

    ' Define the radius for the rounded corners
    Private _cornerRadius As Integer = 50
    Private AppointmentDate As Date
    Private AppointmentTime As String
    Private AppointmentNote As String
    Private lastSelectedButton As Button

    Public Sub New()
        InitializeComponent()
        Me.FormBorderStyle = FormBorderStyle.None
        ApplyRoundedCorners()
    End Sub

    ' Applies rounded corners to the form
    Private Sub ApplyRoundedCorners()
        Using path As New GraphicsPath()
            path.AddArc(0, 0, _cornerRadius, _cornerRadius, 180, 90) ' Top-left
            path.AddArc(Me.Width - _cornerRadius, 0, _cornerRadius, _cornerRadius, 270, 90) ' Top-right
            path.AddArc(Me.Width - _cornerRadius, Me.Height - _cornerRadius, _cornerRadius, _cornerRadius, 0, 90) ' Bottom-right
            path.AddArc(0, Me.Height - _cornerRadius, _cornerRadius, _cornerRadius, 90, 90) ' Bottom-left
            path.CloseFigure()
            Me.Region = New Region(path)
        End Using
    End Sub

    ' Form Load Event
    Private Sub SchedulePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AppointmentDate = Nothing
        AppointmentTime = String.Empty
        AppointmentNote = String.Empty
        txt_Note.Clear()

        If lastSelectedButton IsNot Nothing Then
            lastSelectedButton.BackColor = Color.White
            lastSelectedButton = Nothing
        End If
    End Sub

    ' Handles Confirm Appointment Button
    Private Sub ConfirmAppointment_Click(sender As Object, e As EventArgs) Handles RoundedButton16.Click
        AppointmentDate = dtp_AppointmentDate.Value.Date
        AppointmentNote = txt_Note.Text.Trim()

        If String.IsNullOrEmpty(AppointmentTime) Then
            MessageBox.Show("Please select an appointment time.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim ticketForm As New AppointmentTicket("Doctor Name", AppointmentDate, AppointmentTime, AppointmentNote)
        ticketForm.Show()
        Me.Hide()
    End Sub

    ' Handles Appointment Time Button Clicks
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
        SetAppointmentTime("1:00 PM", btn_13)
    End Sub

    Private Sub btn_1330_Click(sender As Object, e As EventArgs) Handles btn_1330.Click
        SetAppointmentTime("1:30 PM", btn_1330)
    End Sub

    Private Sub btn_14_Click(sender As Object, e As EventArgs) Handles btn_14.Click
        SetAppointmentTime("2:00 PM", btn_14)
    End Sub

    Private Sub btn_1430_Click(sender As Object, e As EventArgs) Handles btn_1430.Click
        SetAppointmentTime("2:30 PM", btn_1430)
    End Sub

    Private Sub btn_15_Click(sender As Object, e As EventArgs) Handles btn_15.Click
        SetAppointmentTime("3:00 PM", btn_15)
    End Sub

    Private Sub btn_1530_Click(sender As Object, e As EventArgs) Handles btn_1530.Click
        SetAppointmentTime("3:30 PM", btn_1530)
    End Sub

    Private Sub btn_16_Click(sender As Object, e As EventArgs) Handles btn_16.Click
        SetAppointmentTime("4:00 PM", btn_16)
    End Sub

    Private Sub btn_1630_Click(sender As Object, e As EventArgs) Handles btn_1630.Click
        SetAppointmentTime("4:30 PM", btn_1630)
    End Sub

    Private Sub btn_17_Click(sender As Object, e As EventArgs) Handles btn_17.Click
        SetAppointmentTime("5:00 PM", btn_17)
    End Sub

    Private Sub btn_1730_Click(sender As Object, e As EventArgs) Handles btn_1730.Click
        SetAppointmentTime("5:30 PM", btn_1730)
    End Sub

    Private Sub btn_18_Click(sender As Object, e As EventArgs) Handles btn_18.Click
        SetAppointmentTime("6:00 PM", btn_18)
    End Sub

    ' Sets appointment time and highlights the selected button
    Private Sub SetAppointmentTime(time As String, selectedButton As Button)
        AppointmentTime = time

        If lastSelectedButton IsNot Nothing Then
            lastSelectedButton.BackColor = Color.White
        End If

        selectedButton.BackColor = Color.SteelBlue
        lastSelectedButton = selectedButton
    End Sub

    ' Back Navigation Buttons
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        PatientMenuPage.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        SymptomsPage.Show()
        Me.Hide()
    End Sub


End Class
