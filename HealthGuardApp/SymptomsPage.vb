Public Class SymptomsPage
    Private Sub SymptomsPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RoundedButton3_Click(sender As Object, e As EventArgs) Handles RoundedButton3.Click
        SpecialistPage.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
        AppointmentPage.Show()
    End Sub
End Class