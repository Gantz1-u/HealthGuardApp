Imports MySql.Data.MySqlClient

Public Class Form1
    Private DB As New DBConnection()

    ' When Patient Button is clicked
    Private Sub RoundedButton1_Click(sender As Object, e As EventArgs) Handles RoundedButton1.Click
        SaveRoleAndRedirect("patient")
    End Sub

    ' When Nurse Button is clicked
    Private Sub RoundedButton2_Click(sender As Object, e As EventArgs) Handles RoundedButton2.Click
        SaveRoleAndRedirect("nurse")
    End Sub

    ' Function to save the role and redirect to RegisterPage
    Private Sub SaveRoleAndRedirect(role As String)
        Try
            Dim connection As MySqlConnection = DB.Open()
            Dim query As String = "INSERT INTO accounts (Role) VALUES (@RoleName)"

            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@RoleName", role)
                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show($"Role '{role}' saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Open the RegisterPage
            Dim registerForm As New RegisterPage()
            registerForm.Show()
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            DB.Close()
        End Try
    End Sub
End Class
