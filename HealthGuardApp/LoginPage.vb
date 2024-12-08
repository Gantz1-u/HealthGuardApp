Imports System.Drawing.Drawing2D
Imports MySql.Data.MySqlClient

Public Class LoginPage
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

        Private DB As New DBConnection()
        Private passwordVisible As Boolean = False ' Track password visibility state
        Private _LoggedInUserID As Integer = 0 ' Initialize the LoggedInUserID to 0 (reset)

        ' Property to access and set LoggedInUserID
        Public Property LoggedInUserID As Integer
            Get
                Return _LoggedInUserID
            End Get
            Set(value As Integer)
                _LoggedInUserID = value
            End Set
        End Property

        ' Reset LoggedInUserID when the login page loads
        Private Sub LoginPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            LoggedInUserID = 0 ' Reset the LoggedInUserID when returning to the login page
        End Sub

        ' Link to navigate to another form (e.g., registration form)
        Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
            Form1.Show()
            Me.Hide()
        End Sub

        ' Inside the login button click event
        Private Sub RoundedButton3_Click(sender As Object, e As EventArgs) Handles RoundedButton3.Click
            Dim username As String = RoundedTextBox1.Text.Trim()
            Dim password As String = RoundedTextBox3.Text.Trim()

            If String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(password) Then
                MessageBox.Show("Please enter both username and password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Query to check credentials and retrieve the user's role, status, and ID
            Dim query As String = "SELECT UserID, Role, Status FROM accounts WHERE EmailUsername = @EmailUsername AND Password = @Password"

            Try
                Dim connection As MySqlConnection = DB.Open()
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@EmailUsername", username)
                    cmd.Parameters.AddWithValue("@Password", password)

                    Dim reader As MySqlDataReader = cmd.ExecuteReader()

                    If reader.HasRows Then
                        reader.Read()
                        ' Fetch the UserID, Role, and Status
                        LoggedInUserID = Convert.ToInt32(reader("UserID"))
                        Dim userRole As String = reader("Role").ToString().Trim()
                        Dim userStatus As String = reader("Status").ToString().Trim()

                        ' Check if the account status is active
                        If userStatus.ToLower() <> "active" Then
                            MessageBox.Show("Account is not activated, please wait for admin approval.", "Account Not Activated", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            reader.Close()
                            Exit Sub
                        End If

                        ' Debug: Show the UserID, Role, and Status
                        MessageBox.Show($"Logged-in User ID: {LoggedInUserID}, Role: {userRole}, Status: {userStatus}", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information)

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

        Private Sub LoginPage_Shown(sender As Object, e As EventArgs) Handles Me.Shown
            ' Reset the LoggedInUserID when showing the login form to ensure it's empty
            LoggedInUserID = 0
        End Sub

        ' Logout Functionality: Reset LoggedInUserID
        Public Sub Logout()
            LoggedInUserID = 0 ' Reset LoggedInUserID on logout
            MessageBox.Show("You have logged out successfully.", "Logged Out", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Show() ' Show login page after logging out
        End Sub
    End Class
