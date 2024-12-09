Public Class Orthopedics
    Private Sub RoundedButton3_Click(sender As Object, e As EventArgs) Handles RoundedButton3.Click
        SchedulePage.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) Handles PictureBox2.Click
        SymptomsPage.Show()
        Hide()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        PatientMenuPage.Show()
        Me.Hide()
    End Sub
End Class