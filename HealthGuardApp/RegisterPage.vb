Imports System.Drawing.Drawing2D
Imports MySql.Data.MySqlClient

Public Class RegisterPage
    Inherits Form

    Private ReadOnly _cornerRadius As Integer = 50
    Private ReadOnly DB As New DBConnection()

    Public Property UserId As Integer
    Public Property UserRole As String

    Public Sub New()
        InitializeComponent()
        Me.FormBorderStyle = FormBorderStyle.None
        ApplyRoundedCorners()
    End Sub

    ' Apply rounded corners to the form
    Private Sub ApplyRoundedCorners()
        Dim path As New GraphicsPath()
        Dim width = Me.Width, height = Me.Height

        path.AddArc(0, 0, _cornerRadius, _cornerRadius, 180, 90)
        path.AddArc(width - _cornerRadius, 0, _cornerRadius, _cornerRadius, 270, 90)
        path.AddArc(width - _cornerRadius, height - _cornerRadius, _cornerRadius, _cornerRadius, 0, 90)
        path.AddArc(0, height - _cornerRadius, _cornerRadius, _cornerRadius, 90, 90)
        path.CloseFigure()

        Me.Region = New Region(path)
    End Sub

    ' Set user details
    Public Sub SetUserDetails(newUserId As Integer, role As String)
        UserId = newUserId
        UserRole = role
    End Sub

    ' Handle saving/updating user data
    Private Sub RoundedButton3_Click(sender As Object, e As EventArgs) Handles RoundedButton3.Click
        Dim firstName = RoundedTextBox5.Text.Trim()
        Dim lastName = RoundedTextBox6.Text.Trim()
        Dim email = RoundedTextBox1.Text.Trim()
        Dim phoneNumber = RoundedTextBox7.Text.Trim()
        Dim password = RoundedTextBox2.Text.Trim()
        Dim status = If(UserRole = "Patient", "Active", "Pending")

        If String.IsNullOrWhiteSpace(firstName) OrElse String.IsNullOrWhiteSpace(lastName) OrElse String.IsNullOrWhiteSpace(phoneNumber) Then
            MessageBox.Show("Please fill all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        SaveOrUpdateAccount(firstName, lastName, email, phoneNumber, password, status)
    End Sub

    ' Save or update account
    Private Sub SaveOrUpdateAccount(firstName As String, lastName As String, email As String, phoneNumber As String, password As String, status As String)
        Dim query = If(UserId = 0,
            "INSERT INTO accounts (Role, FirstName, LastName, EmailUsername, Password, ContactNumber, Status, CreationDate) 
             VALUES (@Role, @FirstName, @LastName, @Email, @Password, @PhoneNumber, @Status, NOW());
             SELECT LAST_INSERT_ID();",
            "UPDATE accounts SET Role = @Role, FirstName = @FirstName, LastName = @LastName, EmailUsername = @Email, 
             Password = @Password, ContactNumber = @PhoneNumber, Status = @Status WHERE UserID = @UserId;")

        Try
            Using connection = DB.Open(), cmd As New MySqlCommand(query, connection)
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

                    ' If the role is "Patient", insert a patient record
                    If UserRole.ToLower() = "patient" Then
                        Dim newPatientId = InsertPatient(connection)
                        LinkPatientToAccount(connection, UserId, newPatientId)
                        MessageBox.Show($"Patient record created and linked to the account. PatientID: {newPatientId}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Else
                    cmd.Parameters.AddWithValue("@UserId", UserId)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show($"Account successfully updated! UserID: {UserId}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Using

            Dim inputInfoPage As New InputInfoPage()
            inputInfoPage.Show()
            Me.Hide()

        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            DB.Close()
        End Try
    End Sub

    ' Insert patient if the role is patient
    Private Function InsertPatient(connection As MySqlConnection) As Integer
        Dim query = "INSERT INTO patients (FirstName, LastName) VALUES ('', ''); SELECT LAST_INSERT_ID();"

        Using cmd As New MySqlCommand(query, connection)
            Return Convert.ToInt32(cmd.ExecuteScalar())
        End Using
    End Function

    ' Link patient record to the account
    Private Sub LinkPatientToAccount(connection As MySqlConnection, userId As Integer, patientId As Integer)
        Dim query = "UPDATE accounts SET PatientID = @PatientID WHERE UserID = @UserID;"

        Using cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@PatientID", patientId)
            cmd.Parameters.AddWithValue("@UserID", userId)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    ' Handle form load
    Private Sub RegisterPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim message = If(UserId > 0, $"Updating details for UserID: {UserId}", "Creating a new account record.")
        MessageBox.Show(message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' Navigate to LoginPage
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        LoginPage.Show()
        Me.Hide()
    End Sub
End Class
