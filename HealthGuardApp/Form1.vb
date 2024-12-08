Imports MySql.Data.MySqlClient

Public Class Form1
    Private DB As New DBConnection()

    ' Declare a variable to hold the role
    Private selectedRole As String

    Private Sub RoundedButton1_Click(sender As Object, e As EventArgs) Handles RoundedButton1.Click
        selectedRole = "Patient"
        CreateEmptyAccount(selectedRole)
    End Sub

    Private Sub RoundedButton2_Click(sender As Object, e As EventArgs) Handles RoundedButton2.Click
        selectedRole = "Nurse"
        CreateEmptyAccount(selectedRole)
    End Sub

    Private Sub RoundedButton3_Click(sender As Object, e As EventArgs) Handles RoundedButton3.Click
        selectedRole = "Doctor"
        CreateEmptyAccount(selectedRole)
    End Sub

    ' Create empty account tuple
    Private Sub CreateEmptyAccount(role As String)
        Try
            Dim connection As MySqlConnection = DB.Open()

            Dim query As String = "
                INSERT INTO accounts (Role, Status, CreationDate) 
                VALUES (@Role, @Status, NOW());
                SELECT LAST_INSERT_ID();"

            ' Default status for "Patient" is Active, for "Nurse" and "Doctor" it is Pending
            Dim accountStatus As String = If(role.ToLower() = "patient", "Active", "Pending")

            Dim newUserId As Integer

            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@Role", role)
                cmd.Parameters.AddWithValue("@Status", accountStatus)
                newUserId = Convert.ToInt32(cmd.ExecuteScalar())
            End Using

            MessageBox.Show($"Empty account created successfully with UserID {newUserId}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Pass UserId and Role to RegisterPage
            Dim registerForm As New RegisterPage()
            registerForm.SetUserId(newUserId, role) ' Pass the role
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
