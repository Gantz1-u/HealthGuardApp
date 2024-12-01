Public Class PatientList
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        NurseMenuPage.Show()
        Me.Hide()
    End Sub

    Private Sub CirclePictureBox1_Click(sender As Object, e As EventArgs) Handles CirclePictureBox1.Click
        PaatientData.Show()
        Me.Hide()
    End Sub
End Class