﻿Public Class PhysicalTherapy
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        SymptomsPage.Show()
        Me.Hide()
    End Sub

    Private Sub PhysicalTherapy_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RoundedButton3_Click(sender As Object, e As EventArgs) Handles RoundedButton3.Click
        SchedulePage.Show()
        Me.Hide()
    End Sub
End Class