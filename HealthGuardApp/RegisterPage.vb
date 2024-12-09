Imports System.Drawing.Drawing2D
Imports MySql.Data.MySqlClient

Public Class RegisterPage
    Inherits Form

    ' Define the radius for the rounded corners
    Private _cornerRadius As Integer = 50

    ' Properties for UserID and UserRole
    Public Property UserId As Integer
    Public Property UserRole As String

    Private DB As New DBConnection()

    Public Sub New()
        InitializeComponent()
        Me.FormBorderStyle = FormBorderStyle.None
        ApplyRoundedCorners()
    End Sub

    ' Apply rounded corners to the form
    Private Sub ApplyRoundedCorners()
        Dim path As New GraphicsPath()
        path.AddArc(0, 0, _cornerRadius, _cornerRadius, 180, 90)
        path.AddArc(Me.Width - _cornerRadius, 0, _cornerRadius, _cornerRadius, 270, 90)
        path.AddArc(Me.Width - _cornerRadius, Me.Height - _cornerRadius, _cornerRadius, _cornerRadius, 0, 90)
        path.AddArc(0, Me.Height - _cornerRadius, _cornerRadius, _cornerRadius, 90, 90)
        path.CloseFigure()
        Me.Region = New Region(path)
    End Sub

    ' Set the UserID and UserRole
    Public Sub SetUserDetails(newUserId As Integer, role As String)
        UserId = newUserId
        UserRole = role
    End Sub

    ' Handle the button click for saving user data and opening InputInfoPage
    Private Sub RoundedButton3_Click(sender As Object, e As EventArgs) Handles RoundedButton3.Click
        ' Collect user inputs
        Dim firstName = RoundedTextBox5.Text.Trim
        Dim lastName = RoundedTextBox6.Text.Trim
        Dim email = RoundedTextBox1.Text.Trim
        Dim phoneNumber = RoundedTextBox7.Text.Trim
        Dim password = RoundedTextBox2.Text.Trim
        Dim status = If(UserRole = "Patient", "Active", "Pending")

        ' Validate required fields
        If String.IsNullOrEmpty(firstName) OrElse String.IsNullOrEmpty(lastName) OrElse String.IsNullOrEmpty(phoneNumber) Then
            MessageBox.Show("Please fill all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Prepare query
        Dim query As String = If(UserId = 0,
                                  "INSERT INTO accounts (Role, FirstName, LastName, EmailUsername, Password, ContactNumber, Status, CreationDate) 
                                  VALUES (@Role, @FirstName, @LastName, @Email, @Password, @PhoneNumber, @Status, NOW()); 
                                  SELECT LAST_INSERT_ID();",
                                  "UPDATE accounts SET Role = @Role, FirstName = @FirstName, LastName = @LastName, 
                                  EmailUsername = @Email, Password = @Password, ContactNumber = @PhoneNumber, Status = @Status 
                                  WHERE UserID = @UserId;")

        Try
            Dim connection = DB.Open()
            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@Role", UserRole)
                cmd.Parameters.AddWithValue("@FirstName", firstName)
                cmd.Parameters.AddWithValue("@LastName", lastName)
                cmd.Parameters.AddWithValue("@Email", email)
                cmd.Parameters.AddWithValue("@Password", password)
                cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber)
                cmd.Parameters.AddWithValue("@Status", status)

                If UserId = 0 Then
                    UserId = Convert.ToInt32(cmd.ExecuteScalar())
                    MessageBox.Show($"Account successfully created! UserID: {UserId}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Open InputInfoPage without passing PatientID
                    Dim inputInfoPage As New InputInfoPage()
                    Try
                        inputInfoPage.Show()
                        Me.Hide() ' Optionally hide RegisterPage
                    Catch ex As Exception
                        MessageBox.Show($"Error opening InputInfoPage: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                Else
                    cmd.Parameters.AddWithValue("@UserId", UserId)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show($"Account successfully updated! UserID: {UserId}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            DB.Close()
        End Try
    End Sub

    Private Sub RegisterPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If UserId > 0 Then
            MessageBox.Show($"Updating details for UserID: {UserId}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Creating a new account record.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        LoginPage.Show()
        Hide()
    End Sub
End Class
