Imports System.Drawing.Drawing2D
Imports MySql.Data.MySqlClient

Public Class DoctorPrescription
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

    Public Property SelectedPatientID As Integer

    ' Instance of DBConnection for database connectivity
    Private DB As New DBConnection()

    ' Form Load event to handle initialization
    Private Sub DoctorPrescription1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Fetch and display the patient's full name in the label
        DisplayPatientFullName()
    End Sub

    ' Method to fetch the patient's full name from the database
    Private Sub DisplayPatientFullName()
        If SelectedPatientID <> 0 Then
            ' Fetch the full name by concatenating FirstName, MiddleName, and LastName
            Dim fullName As String = GetPatientFullNameByID(SelectedPatientID)

            If Not String.IsNullOrEmpty(fullName) Then
                lbl_SelectedPatient.Text = $"{fullName}"
            Else
                lbl_SelectedPatient.Text = "Patient not found."
            End If
        Else
            lbl_SelectedPatient.Text = "ERROR"
            MessageBox.Show("Invalid Patient ID.")
        End If
    End Sub

    ' Function to retrieve the patient's full name based on SelectedPatientID
    Private Function GetPatientFullNameByID(patientID As Integer) As String
        ' SQL query to fetch the concatenated full name from the patients table
        Dim query As String = "SELECT CONCAT(FirstName, ' ', IFNULL(MiddleName, ''), ' ', LastName) AS FullName FROM patients WHERE PatientID = @PatientID"
        Dim fullName As String = String.Empty

        Try
            ' Open database connection using DBConnection class
            Dim connection As MySqlConnection = DB.Open()

            ' Execute the query
            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@PatientID", patientID)

                ' Execute the reader to get the full name
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.HasRows Then
                    reader.Read()
                    fullName = reader("FullName").ToString()
                End If

                reader.Close()
            End Using

        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            DB.Close() ' Ensure the connection is closed after the query
        End Try

        Return fullName
    End Function

    ' Navigate back to the previous form when the picture box is clicked


    ' Save the input data into the medicines table
    Private Sub SaveInput(sender As Object, e As EventArgs) Handles RoundedButton2.Click
        ' Check if the necessary fields are not empty
        If String.IsNullOrEmpty(txt_MedicineName.Text) Or String.IsNullOrEmpty(txt_Dosage.Text) Or
        String.IsNullOrEmpty(txt_Frequency.Text) Or String.IsNullOrEmpty(txt_Duration.Text) Or
        String.IsNullOrEmpty(txt_Instruction.Text) Then
            MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Prepare the SQL query to insert the data into the medicines table
        Dim query As String = "INSERT INTO medicines (MedicineName, PatientID, DoctorID, Dosage, Frequency, Duration, Instructions) " &
                           "VALUES (@MedicineName, @PatientID, @DoctorID, @Dosage, @Frequency, @Duration, @Instructions)"

        Try
            ' Open database connection using DBConnection class
            Dim connection As MySqlConnection = DB.Open()

            ' Execute the query
            Using cmd As New MySqlCommand(query, connection)
                ' Add parameters to the SQL query
                cmd.Parameters.AddWithValue("@MedicineName", txt_MedicineName.Text)
                cmd.Parameters.AddWithValue("@PatientID", SelectedPatientID)
                cmd.Parameters.AddWithValue("@DoctorID", LoginPage.LoggedInUserID) ' Assuming LoggedInUserID holds the DoctorID
                cmd.Parameters.AddWithValue("@Dosage", txt_Dosage.Text)
                cmd.Parameters.AddWithValue("@Frequency", txt_Frequency.Text)
                cmd.Parameters.AddWithValue("@Duration", txt_Duration.Text)
                cmd.Parameters.AddWithValue("@Instructions", txt_Instruction.Text)

                ' Execute the query
                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Medicine details saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            DB.Close() ' Ensure the connection is closed after the query
        End Try
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim previousForm As New DoctorPrescriptionPatients()
        previousForm.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        DoctorMenuPage.Show()
        Me.Hide()
    End Sub
End Class
