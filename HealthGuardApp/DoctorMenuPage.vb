Imports System.Drawing.Drawing2D
Imports MySql.Data.MySqlClient

Public Class DoctorMenuPage
    Inherits Form
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

    ' Event handlers for navigation buttons
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

    ' Handle logout
    Private Sub Logout(sender As Object, e As EventArgs) Handles btn_Logout.Click
        LoginPage.LoggedInUserID = 0 ' Reset the LoggedInUserID
        LoginPage.Show()
        Me.Hide()
    End Sub

    ' Optional label click event
    Private Sub lbl_LoggedInUser_Click(sender As Object, e As EventArgs) Handles lbl_LoggedInUser.Click
        ' Placeholder for additional functionality
    End Sub
End Class
