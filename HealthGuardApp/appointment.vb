Public Class appointment
    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub RoundedButton16_Click(sender As Object, e As EventArgs) Handles RoundedButton16.Click
        AppointmentTicket.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
        SpecialistPage.Show()
    End Sub
End Class