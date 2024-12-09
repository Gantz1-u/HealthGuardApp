Imports MySql.Data.MySqlClient

Public Class DoctorPrescription
    ' Public property to receive the selected patient ID
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
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim previousForm As New DoctorPrescriptionPatients()
        previousForm.Show()
        Me.Hide()
    End Sub

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
End Class
