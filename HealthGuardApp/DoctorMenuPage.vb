Imports System.Drawing.Drawing2D
Imports MySql.Data.MySqlClient

Public Class DoctorMenuPage
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


    ' On form load, display the logged-in user's information
    Private Sub DoctorMenuPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayLoggedInUser()
    End Sub

    ' Method to display the logged-in user's first name
    Private Sub DisplayLoggedInUser()
        If LoginPage.LoggedInUserID <> 0 Then
            Dim firstName As String = GetFirstNameByUserID(LoginPage.LoggedInUserID)

            If Not String.IsNullOrEmpty(firstName) Then
                lbl_LoggedInUser.Text = $"Hello, Dr. {firstName}"
            Else
                lbl_LoggedInUser.Text = "User not found."
            End If
        Else
            lbl_LoggedInUser.Text = "ERROR"
            MessageBox.Show("Error fetching User ID")
        End If
    End Sub

    ' Function to retrieve the first name based on UserID
    Private Function GetFirstNameByUserID(userID As Integer) As String
        Dim query As String = "SELECT LastName FROM accounts WHERE UserID = @UserID"
        Dim firstName As String = String.Empty

        Try
            Dim connection As MySqlConnection = DB.Open()

            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@UserID", userID)

                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.HasRows Then
                    reader.Read()
                    firstName = reader("LastName").ToString()
                End If
                reader.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            DB.Close()
        End Try

        Return firstName
    End Function

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        LoginPage.LoggedInUserID = 0

        ' Show the LoginPage and hide the current form
        LoginPage.Show()
        Hide()
    End Sub

    Private Sub RoundedButton1_Click(sender As Object, e As EventArgs) Handles RoundedButton1.Click
        DoctorPatientList.Show()
        Me.Hide()
    End Sub

    Private Sub RoundedButton2_Click(sender As Object, e As EventArgs) Handles RoundedButton2.Click
        DoctorPrescriptionPatients.Show()
        Me.Hide()
    End Sub

    Private Sub RoundedButton3_Click(sender As Object, e As EventArgs) Handles RoundedButton3.Click
        DoctorAppointment.Show()
        Me.Hide()
    End Sub

    ' Event handlers for navigation buttons

End Class
