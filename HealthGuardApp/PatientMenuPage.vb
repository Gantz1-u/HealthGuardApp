Public Class PatientMenuPage
    Private Sub PatientMenuPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RoundedButton1_Click(sender As Object, e As EventArgs) Handles RoundedButton1.Click
        PatientRecord.Show()
        Me.Hide()
    End Sub

    Private Sub RoundedButton2_Click(sender As Object, e As EventArgs) Handles RoundedButton2.Click
        PatientPrescriptionPage.Show()
        Me.Hide()
    End Sub

    Private Sub RoundedButton4_Click(sender As Object, e As EventArgs) Handles RoundedButton4.Click
        AppointmentPage.Show()
        Me.Hide()
    End Sub

    Private Sub Logout(sender As Object, e As EventArgs) Handles btn_Logout.Click
        LoginPage.Show()
        Me.Hide()
    End Sub
End Class