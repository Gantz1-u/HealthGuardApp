Public Class AppointmentTicket
    Private Sub AppointmentTicket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Display the appointment details using the public properties from the appointment class
        lbl_AppointmentDate.Text = appointment.SelectedAppointmentDate.ToString("yyyy-MM-dd") ' Format the date
        lbl_AppointmentTime.Text = appointment.SelectedAppointmentTime ' Display the selected time
        txt_AppointmentNote.Text = appointment.SelectedAppointmentNote ' Display the entered note
    End Sub

    Private Sub Cancel(sender As Object, e As EventArgs) Handles RoundedButton2.Click
        PatientMenuPage.Show()
        Me.Hide()
    End Sub

    Private Sub SaveButton(sender As Object, e As EventArgs) Handles RoundedButton1.Click
        ' Save logic here
    End Sub
End Class
