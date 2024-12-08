Public Class SpecialistPage
    Private Sub RoundedButton3_Click(sender As Object, e As EventArgs) Handles RoundedButton3.Click
        SchedulePage.Show() ' Show the form
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        SymptomsPage.Show()
        Me.Hide()
    End Sub
End Class
