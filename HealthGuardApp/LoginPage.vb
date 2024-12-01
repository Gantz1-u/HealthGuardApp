Imports MySql.Data.MySqlClient

Public Class LoginPage
    Private DB As New DBConnection()
    Private passwordVisible As Boolean = False ' Track password visibility state

    ' Link to navigate to another form (e.g., registration form)
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form1.Show()
        Me.Hide()
    End Sub

    ' Login button click event
    Private Sub RoundedButton3_Click(sender As Object, e As EventArgs) Handles RoundedButton3.Click
        ' Get the user inputs
        Dim username As String = RoundedTextBox1.Text.Trim()
        Dim password As String = RoundedTextBox3.Text.Trim()

        ' Validate user inputs
        If String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(password) Then
            MessageBox.Show("Please enter both username and password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Query to check credentials and retrieve the user's role
        Dim query As String = "SELECT Role FROM accounts WHERE EmailUsername = @EmailUsername AND Password = @Password"

        Try
            Dim connection As MySqlConnection = DB.Open()
            Using cmd As New MySqlCommand(query, connection)
                ' Add parameters to prevent SQL injection
                cmd.Parameters.AddWithValue("@EmailUsername", username)
                cmd.Parameters.AddWithValue("@Password", password)

                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                ' Check if the user exists
                If reader.HasRows Then
                    reader.Read()
                    Dim userRole As String = reader("Role").ToString().Trim() ' Trim whitespace

                    ' Debug: Show the role in a message box
                    MessageBox.Show($"Role retrieved: {userRole}", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Open the corresponding menu based on the user's role
                    Select Case userRole.ToLower() ' Ensure case-insensitivity
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


    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        ' Toggle password visibility
        If passwordVisible Then
            RoundedTextBox3.UseSystemPasswordChar = True ' Hide password
            PictureBox2.Text = "Show"           ' Update button text
        Else
            RoundedTextBox3.UseSystemPasswordChar = False ' Show password
            PictureBox2.Text = "Hide"            ' Update button text
        End If

        ' Toggle the state
        passwordVisible = Not passwordVisible
    End Sub
End Class
