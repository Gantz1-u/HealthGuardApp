Public Class SymptomsPage
    Private Sub SymptomsPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RoundedButton3_Click(sender As Object, e As EventArgs) Handles RoundedButton3.Click
        SpecialistPage.Show()
        Me.Hide()
    End Sub
End Class