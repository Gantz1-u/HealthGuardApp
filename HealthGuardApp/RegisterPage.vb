Imports MySql.Data.MySqlClient

Public Class RegisterPage
    Public Property AssignedRole As String ' Property to hold the role passed from LoginPage

    Private DB As New DBConnection()

    ' Register button click event
    Private Sub RoundedButton3_Click(sender As Object, e As EventArgs) Handles RoundedButton3.Click
        ' Collect user input
        Dim firstName As String = RoundedTextBox1.Text.Trim()
        Dim middleName As String = RoundedTextBox3.Text.Trim()
        Dim lastName As String = RoundedTextBox2.Text.Trim()
        Dim phoneNumber As String = RoundedTextBox5.Text.Trim()
        Dim username As String = RoundedTextBox4.Text.Trim()
        Dim password As String = RoundedTextBox6.Text.Trim()
        Dim confirmPassword As String = RoundedTextBox7.Text.Trim()

        ' Validate input fields
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

        ' Insert data into the database
        Dim query As String = "INSERT INTO accounts (FirstName, MiddleName, LastName, ContactNumber, EmailUsername, Password) " &
                              "VALUES (@FirstName, @MiddleName, @LastName, @PhoneNumber, @EmailUsername, @Password)"

        Try
            Dim connection As MySqlConnection = DB.Open()
            Using cmd As New MySqlCommand(query, connection)
                ' Add parameters to avoid SQL injection
                cmd.Parameters.AddWithValue("@FirstName", firstName)
                cmd.Parameters.AddWithValue("@MiddleName", middleName)
                cmd.Parameters.AddWithValue("@LastName", lastName)
                cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber)
                cmd.Parameters.AddWithValue("@EmailUsername", username)
                cmd.Parameters.AddWithValue("@Password", password)

                cmd.ExecuteNonQuery()
                MessageBox.Show("Account successfully registered!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Redirect back to login page
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

    End Sub
End Class
