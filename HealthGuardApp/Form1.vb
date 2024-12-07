Imports MySql.Data.MySqlClient

Public Class Form1
    Private DB As New DBConnection()
    Private Sub RoundedButton1_Click(sender As Object, e As EventArgs) Handles RoundedButton1.Click
        CreateEmptyAccount("Patient")
    End Sub
    Private Sub RoundedButton2_Click(sender As Object, e As EventArgs) Handles RoundedButton2.Click
        CreateEmptyAccount("Nurse")
    End Sub
    Private Sub RoundedButton3_Click(sender As Object, e As EventArgs) Handles RoundedButton3.Click
        CreateEmptyAccount("Doctor")
    End Sub

    ' create empty account tuple
    Private Sub CreateEmptyAccount(role As String)
        Try
            Dim connection As MySqlConnection = DB.Open()

            Dim query As String = "
                INSERT INTO accounts (Role, Status, CreationDate) 
                VALUES (@Role, 'Pending', NOW());
                SELECT LAST_INSERT_ID();"

            Dim newUserId As Integer

            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@Role", role)
                newUserId = Convert.ToInt32(cmd.ExecuteScalar())
            End Using

            MessageBox.Show($"Empty account created successfully with UserID {newUserId}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Dim registerForm As New RegisterPage()
            registerForm.SetUserId(newUserId)
            registerForm.Show()
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            DB.Close()
        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        LoginPage.Show()
        Me.Hide()
    End Sub
End Class
