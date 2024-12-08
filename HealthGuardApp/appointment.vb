Public Class appointment
    Private Sub RoundedButton16_Click(sender As Object, e As EventArgs) Handles RoundedButton16.Click
        AppointmentTicket.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
        SpecialistPage.Show()
    End Sub

End Class