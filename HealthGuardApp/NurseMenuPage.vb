Public Class NurseMenuPage

    Private Sub RoundedButton1_Click_1(sender As Object, e As EventArgs) Handles RoundedButton1.Click
        RecordsPage.Show()
        Hide()
    End Sub

    Private Sub RoundedButton2_Click(sender As Object, e As EventArgs) Handles RoundedButton2.Click
        PrescriptionPage.Show()
        Me.Hide()

    End Sub
End Class
