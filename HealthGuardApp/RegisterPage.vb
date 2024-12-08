Imports System.Drawing.Drawing2D
Imports MySql.Data.MySqlClient



Public Class RegisterPage
        Inherits Form

        ' Define the radius for the rounded corners
        Private _cornerRadius As Integer = 50

        Public Sub New()
            InitializeComponent()
            ' Optionally, you can set the form's border style to None to get rid of the default border
            Me.FormBorderStyle = FormBorderStyle.None
            ' Call this method to apply rounded corners to the form
            ApplyRoundedCorners()
        End Sub

        ' This method applies the rounded corners to the form
        Private Sub ApplyRoundedCorners()
            Dim path As New GraphicsPath()
            ' Create a rounded rectangle path
            path.AddArc(0, 0, _cornerRadius, _cornerRadius, 180, 90) ' Top-left corner
            path.AddArc(Me.Width - _cornerRadius, 0, _cornerRadius, _cornerRadius, 270, 90) ' Top-right corner
            path.AddArc(Me.Width - _cornerRadius, Me.Height - _cornerRadius, _cornerRadius, _cornerRadius, 0, 90) ' Bottom-right corner
            path.AddArc(0, Me.Height - _cornerRadius, _cornerRadius, _cornerRadius, 90, 90) ' Bottom-left corner
            path.CloseFigure() ' Close the figure to form the rounded rectangle

            ' Set the form's region to the rounded rectangle path
            Me.Region = New Region(path)
        End Sub

        ' Optionally, handle the resizing of the form
        Protected Overrides Sub OnResize(e As EventArgs)
            MyBase.OnResize(e)
            ApplyRoundedCorners() ' Reapply the rounded corners when resizing
        End Sub
        Public Property UserId As Integer
        Public Property UserRole As String ' Property to hold the user role

        Private DB As New DBConnection()

        ' Set the UserId and UserRole
        Public Sub SetUserId(newUserId As Integer, role As String)
            UserId = newUserId
            UserRole = role
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

            ' Set the account status based on the user role
            Dim accountStatus As String = If(UserRole.ToLower() = "patient", "Active", "Pending")

            ' Update the account details, including the status
            Dim query As String = "
            UPDATE accounts 
            SET FirstName = @FirstName, 
                MiddleName = @MiddleName, 
                LastName = @LastName, 
                ContactNumber = @PhoneNumber, 
                EmailUsername = @EmailUsername, 
                Password = @Password, 
                Status = @Status 
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
                    cmd.Parameters.AddWithValue("@Status", accountStatus) ' Use accountStatus based on role
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
