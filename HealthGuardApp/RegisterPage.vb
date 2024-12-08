Imports MySql.Data.MySqlClient

Public Class RegisterPage
    Public Property UserId As Integer

    Private DB As New DBConnection()
    Public Sub SetUserId(newUserId As Integer)
        UserId = newUserId
    End Sub

    Private Sub RoundedButton3_Click(sender As Object, e As EventArgs) Handles RoundedButton3.Click
        Dim firstName As String = RoundedTextBox1.Text.Trim()
        Dim middleName As String = RoundedTextBox3.Text.Trim()
        Dim lastName As String = RoundedTextBox2.Text.Trim()
        Dim phoneNumber As String = RoundedTextBox5.Text.Trim()
        Dim username As String = RoundedTextBox4.Text.Trim()
        Dim password As String = RoundedTextBox6.Text.Trim()
        Dim confirmPassword As String = RoundedTextBox7.Text.Trim()

        If String.IsNullOrEmpty(firstName) OrElse String.IsNullOrEmpty(lastName) OrElse
           String.IsNullOrEmpty(phoneNumber) OrElse String.IsNullOrEmpty(username) OrElse
           String.IsNullOrEmpty(password) OrElse String.IsNullOrEmpty(confirmPassword) Then

            MessageBox.Show("Please fill all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If password <> confirmPassword Then
            MessageBox.Show("Passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim query As String = "
            UPDATE accounts 
            SET FirstName = @FirstName, 
                MiddleName = @MiddleName, 
                LastName = @LastName, 
                ContactNumber = @PhoneNumber, 
                EmailUsername = @EmailUsername, 
                Password = @Password, 
                Status = 'Active' 
            WHERE UserID = @UserId"

        Try
            Dim connection As MySqlConnection = DB.Open()
            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@FirstName", firstName)
                cmd.Parameters.AddWithValue("@MiddleName", middleName)
                cmd.Parameters.AddWithValue("@LastName", lastName)
                cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber)
                cmd.Parameters.AddWithValue("@EmailUsername", username)
                cmd.Parameters.AddWithValue("@Password", password)
                cmd.Parameters.AddWithValue("@UserId", UserId)

                cmd.ExecuteNonQuery()
                MessageBox.Show("Account successfully registered!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Me.Hide()
                LoginPage.Show()
            End Using
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            DB.Close()
        End Try
    End Sub

    Private Sub RegisterPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If UserId <> 0 Then
            MessageBox.Show($"Registering account for UserID: {UserId}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        LoginPage.Show()
        Me.Hide()
    End Sub
End Class
