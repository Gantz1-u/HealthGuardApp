﻿Imports System.Drawing.Drawing2D
Imports MySql.Data.MySqlClient

Public Class Form1
    Inherits Form

    Private ReadOnly _cornerRadius As Integer = 50
    Private ReadOnly DB As New DBConnection()
    Private selectedRole As String

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

    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        ApplyRoundedCorners()
    End Sub

    ' Button click handlers for creating accounts
    Private Sub RoleButton_Click(sender As Object, e As EventArgs) Handles RoundedButton1.Click, RoundedButton2.Click, RoundedButton3.Click
        selectedRole = CType(sender, Button).Text
        CreateAccount(selectedRole)
    End Sub

    ' Create account and optionally link it to a patient
    Private Sub CreateAccount(role As String)
        Dim newUserId As Integer
        Dim newPatientId As Integer

        Try
            Using connection = DB.Open()
                ' Insert account
                newUserId = InsertAccount(connection, role)

                ' Insert patient if role is "Patient"
                If role.ToLower() = "patient" Then
                    newPatientId = InsertPatient(connection)
                    LinkPatientToAccount(connection, newUserId, newPatientId)
                    MessageBox.Show($"Patient account created. UserID: {newUserId}, PatientID: {newPatientId}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show($"Account created. UserID: {newUserId}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        ' Open RegisterPage
        If newUserId > 0 Then
            Dim registerForm As New RegisterPage()
            registerForm.SetUserDetails(newUserId, newPatientId)
            registerForm.Show()
            Me.Hide()
        End If
    End Sub

    ' Helper methods for database operations
    Private Function InsertAccount(connection As MySqlConnection, role As String) As Integer
        Dim query = "INSERT INTO accounts (Role, Status, CreationDate) VALUES (@Role, @Status, NOW()); SELECT LAST_INSERT_ID();"
        Dim status = If(role.ToLower() = "patient", "Active", "Pending")

        Using cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@Role", role)
            cmd.Parameters.AddWithValue("@Status", status)
            Return Convert.ToInt32(cmd.ExecuteScalar())
        End Using
    End Function

    Private Function InsertPatient(connection As MySqlConnection) As Integer
        Dim query = "INSERT INTO patients (FirstName, LastName) VALUES ('', ''); SELECT LAST_INSERT_ID();"

        Using cmd As New MySqlCommand(query, connection)
            Return Convert.ToInt32(cmd.ExecuteScalar())
        End Using
    End Function

    Private Sub LinkPatientToAccount(connection As MySqlConnection, userId As Integer, patientId As Integer)
        Dim query = "UPDATE accounts SET PatientID = @PatientID WHERE UserID = @UserID;"

        Using cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@PatientID", patientId)
            cmd.Parameters.AddWithValue("@UserID", userId)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    ' Navigate to LoginPage
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        LoginPage.Show()
        Me.Hide()
    End Sub
End Class
