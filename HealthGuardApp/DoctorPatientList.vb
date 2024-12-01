Public Class DoctorPatientList
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        DoctorMenuPage.Show()
        Me.Hide()
    End Sub

    Private Sub CirclePictureBox1_Click(sender As Object, e As EventArgs) Handles CirclePictureBox1.Click
        DoctorPatientData.Show()
        Me.Hide()
    End Sub
End Class