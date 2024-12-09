Imports System.Drawing.Drawing2D
Imports MySql.Data.MySqlClient

Public Class Form1
    Inherits Form

    ' Define the radius for the rounded corners
    Private _cornerRadius As Integer = 50

    Private DB As New DBConnection()
    Private selectedRole As String

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

    ' Button click handlers to create accounts for different roles
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

    ' Create an empty account and optionally link it to a patient
    Private Sub CreateEmptyAccount(role As String)
        Dim newUserId As Integer = 0
        Dim newPatientId As Integer = 0

        Try
            Dim connection As MySqlConnection = DB.Open()

            ' Insert a new account into the `accounts` table
            Dim insertAccountQuery As String = "
                INSERT INTO accounts (Role, Status, CreationDate) 
                VALUES (@Role, @Status, NOW());
                SELECT LAST_INSERT_ID();"

            Dim accountStatus As String = If(role.ToLower() = "patient", "Active", "Pending")

            Using cmd As New MySqlCommand(insertAccountQuery, connection)
                cmd.Parameters.AddWithValue("@Role", role)
                cmd.Parameters.AddWithValue("@Status", accountStatus)
                newUserId = Convert.ToInt32(cmd.ExecuteScalar())
            End Using

            ' If the role is "Patient", create an entry in the `patients` table
            If role.ToLower() = "patient" Then
                Dim insertPatientQuery As String = "
                    INSERT INTO patients (FirstName, LastName) 
                    VALUES ('', '');
                    SELECT LAST_INSERT_ID();"

                Using cmd As New MySqlCommand(insertPatientQuery, connection)
                    newPatientId = Convert.ToInt32(cmd.ExecuteScalar())
                End Using

                ' Update the `PatientID` field in the `accounts` table
                Dim updateAccountQuery As String = "
                    UPDATE accounts 
                    SET PatientID = @PatientID 
                    WHERE UserID = @UserID;"

                Using cmd As New MySqlCommand(updateAccountQuery, connection)
                    cmd.Parameters.AddWithValue("@PatientID", newPatientId)
                    cmd.Parameters.AddWithValue("@UserID", newUserId)
                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show($"Empty patient account created successfully. UserID: {newUserId}, PatientID: {newPatientId}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show($"Empty account created successfully with UserID {newUserId}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            DB.Close()
        End Try

        ' Open the RegisterPage and pass UserID and PatientID for further configuration
        If newUserId > 0 Then
            Dim registerForm As New RegisterPage()
            registerForm.SetUserDetails(newUserId, newPatientId, selectedRole)
            registerForm.Show()
            Me.Hide()
        End If
    End Sub

    ' Navigate to LoginPage
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        LoginPage.Show()
        Hide()
    End Sub
End Class
