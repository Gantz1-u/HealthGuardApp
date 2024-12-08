Imports MySql.Data.MySqlClient

Public Class LoginPage
    Private DB As New DBConnection()
    Private passwordVisible As Boolean = False ' Track password visibility state
    Public Shared LoggedInUserID As Integer ' Store the logged-in user's ID

    ' Link to navigate to another form (e.g., registration form)
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form1.Show()
        Me.Hide()
    End Sub

    ' Login button click event
    Private Sub RoundedButton3_Click(sender As Object, e As EventArgs) Handles RoundedButton3.Click
        Dim username As String = RoundedTextBox1.Text.Trim()
        Dim password As String = RoundedTextBox3.Text.Trim()

        If String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(password) Then
            MessageBox.Show("Please enter both username and password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Query to check credentials and retrieve the user's role and ID
        Dim query As String = "SELECT UserID, Role FROM accounts WHERE EmailUsername = @EmailUsername AND Password = @Password"

        Try
            Dim connection As MySqlConnection = DB.Open()
            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@EmailUsername", username)
                cmd.Parameters.AddWithValue("@Password", password)

                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.HasRows Then
                    reader.Read()
                    ' Fetch the UserID and Role
                    LoggedInUserID = Convert.ToInt32(reader("UserID"))
                    Dim userRole As String = reader("Role").ToString().Trim()

                    ' Debug: Show the UserID and Role
                    MessageBox.Show($"Logged-in User ID: {LoggedInUserID}, Role: {userRole}", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Open the corresponding menu based on the user's role
                    Select Case userRole.ToLower()
                        Case "patient"
                            Dim patientMenu As New PatientMenuPage()
                            patientMenu.Show()
                        Case "nurse"
                            Dim nurseMenu As New NurseMenuPage()
                            nurseMenu.Show()
                        Case "doctor"
                            Dim doctorMenu As New DoctorMenuPage()
                            doctorMenu.Show()
                        Case Else
                            MessageBox.Show("Role not recognized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Select

                    Me.Hide()
                Else
                    MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

                reader.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            DB.Close()
        End Try
    End Sub

    ' Toggle password visibility
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If passwordVisible Then
            RoundedTextBox3.UseSystemPasswordChar = True
        Else
            RoundedTextBox3.UseSystemPasswordChar = False
        End If

        passwordVisible = Not passwordVisible
    End Sub

    ' Prevent Enter key in RoundedTextBox1
    Private Sub RoundedTextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles RoundedTextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
    End Sub

    ' Trigger Login button when Enter is pressed in RoundedTextBox3
    Private Sub RoundedTextBox3_KeyDown(sender As Object, e As KeyEventArgs) Handles RoundedTextBox3.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            RoundedButton3.PerformClick()
        End If
    End Sub
End Class
