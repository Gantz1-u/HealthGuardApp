Imports System.Drawing.Drawing2D
Imports MySql.Data.MySqlClient

Public Class PatientMenuPage
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
    ' Instance of DBConnection for database connectivity
    Private DB As New DBConnection()

    Private Sub PatientMenuPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Display the logged-in user's first name in the label
        DisplayLoggedInUser()
    End Sub

    Private Sub DisplayLoggedInUser()
        ' Check if the LoggedInUserID is set
        If LoginPage.LoggedInUserID <> 0 Then
            ' Fetch the FirstName from the database using the LoggedInUserID
            Dim firstName As String = GetFirstNameByUserID(LoginPage.LoggedInUserID)

            If Not String.IsNullOrEmpty(firstName) Then
                lbl_LoggedInUser.Text = $"Hello, {firstName}"
            Else
                lbl_LoggedInUser.Text = "User not found."
            End If
        Else
            lbl_LoggedInUser.Text = "ERROR"
            MessageBox.Show("Error fetching User ID")
        End If
    End Sub

    ' Function to retrieve the FirstName based on the UserID
    Private Function GetFirstNameByUserID(userID As Integer) As String
        ' SQL query to fetch the FirstName from the accounts table based on the UserID
        Dim query As String = "SELECT FirstName FROM accounts WHERE UserID = @UserID"
        Dim firstName As String = String.Empty

        Try
            ' Open database connection using DBConnection class
            Dim connection As MySqlConnection = DB.Open()

            ' Execute the query
            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@UserID", userID)

                ' Execute the reader to get the FirstName
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.HasRows Then
                    reader.Read()
                    firstName = reader("FirstName").ToString()
                End If

                reader.Close()
            End Using

        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            DB.Close() ' Ensure the connection is closed after the query
        End Try

        Return firstName
    End Function

    ' Handling the event when the user clicks the "Patient Record" button
    Private Sub RoundedButton1_Click(sender As Object, e As EventArgs) Handles RoundedButton1.Click
        PatientRecord.Show()
        Me.Hide()
    End Sub

    ' Handling the event when the user clicks the "Patient Prescription" button
    Private Sub RoundedButton2_Click(sender As Object, e As EventArgs) Handles RoundedButton2.Click
        PatientPrescriptionPage.Show()
        Me.Hide()
    End Sub

    ' Handling the event when the user clicks the "Appointment Page" button
    Private Sub RoundedButton4_Click(sender As Object, e As EventArgs) Handles RoundedButton4.Click
        AppointmentPage.Show()
        Me.Hide()
    End Sub

    ' Handling the logout event
    Private Sub Logout(sender As Object, e As EventArgs) Handles btn_Logout.Click
        ' Reset the LoggedInUserID to 0 (no user is logged in)
        LoginPage.LoggedInUserID = 0

        ' Show the LoginPage and hide the current form
        LoginPage.Show()
        Me.Hide()
    End Sub


    ' Optional: Add functionality for label click if needed
    Private Sub lbl_LoggedInUser_Click(sender As Object, e As EventArgs) Handles lbl_LoggedInUser.Click
        ' Placeholder for any additional functionality when the label is clicked
    End Sub
End Class
