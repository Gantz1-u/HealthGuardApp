Public Class DoctorMenuPage
    Private Sub RoundedButton1_Click(sender As Object, e As EventArgs) Handles RoundedButton1.Click
        DoctorPatientList.Show()
        Me.Hide()
    End Sub

    Private Sub RoundedButton2_Click(sender As Object, e As EventArgs) Handles RoundedButton2.Click
        DoctorPrescription.Show()
        Me.Hide()
    End Sub

    Private Sub RoundedButton3_Click(sender As Object, e As EventArgs) Handles RoundedButton3.Click
        DoctorAppointment.Show()
        Me.Hide()
    End Sub

    Private Sub Logout(sender As Object, e As EventArgs) Handles btn_Logout.Click
        LoginPage.Show()
        Me.Hide()
    End Sub
End Class