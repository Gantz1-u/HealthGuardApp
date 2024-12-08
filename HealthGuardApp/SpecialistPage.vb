Public Class SpecialistPage
    Private Sub RoundedButton3_Click(sender As Object, e As EventArgs) Handles RoundedButton3.Click
        appointment.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
        SymptomsPage.Show()
    End Sub

    Private Sub SpecialistPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class