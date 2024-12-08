Public Class DoctorPatientList
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        DoctorMenuPage.Show()
        Me.Hide()
    End Sub

    Private Sub CirclePictureBox1_Click(sender As Object, e As EventArgs) Handles CirclePictureBox1.Click
        PaatientData.Show()
        Me.Hide()
    End Sub

    Private Sub CirclePictureBox2_Click(sender As Object, e As EventArgs) Handles CirclePictureBox2.Click
        Patient1.Show()
        Me.Hide()
    End Sub

    Private Sub CirclePictureBox3_Click(sender As Object, e As EventArgs) Handles CirclePictureBox3.Click
        Patient2.Show()
        Me.Hide()
    End Sub

    Private Sub CirclePictureBox4_Click(sender As Object, e As EventArgs) Handles CirclePictureBox4.Click
        Patient3.Show()
        Me.Hide()
    End Sub

    Private Sub CirclePictureBox5_Click(sender As Object, e As EventArgs) Handles CirclePictureBox5.Click
        Patient4.Show()
        Me.Hide()
    End Sub
End Class