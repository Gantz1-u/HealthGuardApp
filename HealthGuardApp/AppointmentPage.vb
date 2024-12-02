Public Class AppointmentPage
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        PatientMenuPage.Show()
        Me.Hide()
    End Sub

    Private Sub RoundedButton4_Click(sender As Object, e As EventArgs) Handles RoundedButton4.Click
        SymptomsPage.Show()
        Me.Hide()
    End Sub

    Private Sub RoundedButton2_Click(sender As Object, e As EventArgs) Handles RoundedButton2.Click
        AppointmentTicket.Show()
        Me.Hide()
    End Sub
End Class