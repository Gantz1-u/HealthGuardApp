Imports System.Drawing.Drawing2D
Imports MySql.Data.MySqlClient

Public Class RegisterPage
    Inherits Form

    ' Define the radius for the rounded corners
    Private _cornerRadius As Integer = 50

    ' Properties for UserID and PatientID
    Public Property UserId As Integer
    Public Property PatientId As Integer
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

    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        ApplyRoundedCorners()
    End Sub

    ' Set the UserID, PatientID, and UserRole
    Public Sub SetUserDetails(newUserId As Integer, newPatientId As Integer, role As String)
        UserId = newUserId
        PatientId = newPatientId
        UserRole = role
    End Sub

    Private Sub RoundedButton3_Click(sender As Object, e As EventArgs) Handles RoundedButton3.Click
        Dim firstName = RoundedTextBox5.Text.Trim
        Dim middleName = RoundedTextBox4.Text.Trim
        Dim lastName = RoundedTextBox6.Text.Trim
        Dim email = RoundedTextBox1.Text.Trim
        Dim phoneNumber = RoundedTextBox7.Text.Trim
        Dim password = RoundedTextBox2.Text.Trim
        Dim status As String

        ' Check if the role is "patient" and set status accordingly
        If UserRole = "Patient" Then
            status = "Active" ' Set status to active for patients
        Else
            status = "Pending" ' Default status for other roles
        End If

        ' Validate required fields
        If String.IsNullOrEmpty(firstName) OrElse String.IsNullOrEmpty(lastName) OrElse String.IsNullOrEmpty(phoneNumber) Then
            MessageBox.Show("Please fill all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim query As String
        If UserId = 0 Then
            ' Insert new user record if UserID is not set
            query = "
        INSERT INTO accounts 
        (Role, FirstName, MiddleName, LastName, EmailUsername, Password, ContactNumber, Status, CreationDate) 
        VALUES (@Role, @FirstName, @MiddleName, @LastName, @Email, @Password, @PhoneNumber, @Status, NOW());
        SELECT LAST_INSERT_ID();"
        Else
            ' Update existing user record if UserID is already set
            query = "
        UPDATE accounts 
        SET Role = @Role, 
            FirstName = @FirstName, 
            MiddleName = @MiddleName, 
            LastName = @LastName, 
            EmailUsername = @Email,
            Password = @Password,
            ContactNumber = @PhoneNumber,
            Status = @Status 
        WHERE UserID = @UserId;"
        End If

        Try
            Dim connection = DB.Open()
            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@Role", UserRole)
                cmd.Parameters.AddWithValue("@FirstName", firstName)
                cmd.Parameters.AddWithValue("@MiddleName", middleName)
                cmd.Parameters.AddWithValue("@LastName", lastName)
                cmd.Parameters.AddWithValue("@Email", email)
                cmd.Parameters.AddWithValue("@Password", password)
                cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber)
                cmd.Parameters.AddWithValue("@Status", status)

                ' Ensure PatientID is set correctly (null or a valid ID)
                If PatientId = 0 Then
                    cmd.Parameters.AddWithValue("@PatientID", DBNull.Value)
                Else
                    cmd.Parameters.AddWithValue("@PatientID", PatientId)
                End If

                If UserId = 0 Then
                    ' Execute insert and retrieve new UserID
                    UserId = Convert.ToInt32(cmd.ExecuteScalar())
                    MessageBox.Show($"Account successfully created! UserID: {UserId}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' After creating the account, open InputInfoPage with new PatientID
                    Dim inputInfoPage As New InputInfoPage()
                    inputInfoPage.SetPatientId(PatientId)
                    inputInfoPage.Show()
                    Me.Hide()
                Else
                    ' Execute update
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
