Imports MySql.Data.MySqlClient

Public Class PatientRecord
    ' Instance of DBConnection for database connectivity
    Private DB As New DBConnection()

    ' This will be called when the form loads
    Private Sub PatientRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Ensure the patient data reflects the currently logged-in user
        DisplayPatientData()
    End Sub

    ' Function to fetch and display patient data
    Private Sub DisplayPatientData()
        ' Check if the LoggedInUserID is set
        If LoginPage.LoggedInUserID <> 0 Then
            ' Fetch the PatientID from the accounts table based on the LoggedInUserID
            Dim patientID As Integer = GetPatientIDByUserID(LoginPage.LoggedInUserID)

            If patientID <> 0 Then
                ' Fetch the patient data from the patients table based on the PatientID
                Dim patientData As DataRow = GetPatientDataByPatientID(patientID)

                ' Check if the patient data is found
                If patientData IsNot Nothing Then
                    ' Display patient data on the labels
                    lbl_PatientID.Text = "Patient #" & patientData("PatientID").ToString()
                    lbl_FullName.Text = patientData("FirstName").ToString() & " " & If(patientData("MiddleName") Is DBNull.Value, "", patientData("MiddleName").ToString()) & " " & patientData("LastName").ToString()
                    lbl_Age.Text = If(patientData("Age") Is DBNull.Value, "N/A", patientData("Age").ToString())
                    lbl_Sex.Text = If(patientData("Sex") Is DBNull.Value, "N/A", patientData("Sex").ToString())
                    lbl_DateOfBirth.Text = If(patientData("DateOfBirth") Is DBNull.Value, "N/A", Convert.ToDateTime(patientData("DateOfBirth")).ToString("MM/dd/yyyy"))
                    lbl_BloodType.Text = If(patientData("BloodType") Is DBNull.Value, "N/A", patientData("BloodType").ToString())
                    lbl_ParentGuardian.Text = If(patientData("ParentGuardian") Is DBNull.Value, "N/A", patientData("ParentGuardian").ToString())
                    lbl_Phone.Text = If(patientData("Phone") Is DBNull.Value, "N/A", patientData("Phone").ToString())
                    lbl_Address.Text = If(patientData("Address") Is DBNull.Value, "N/A", patientData("Address").ToString())
                    lbl_Email.Text = If(patientData("Email") Is DBNull.Value, "N/A", patientData("Email").ToString())
                Else
                    MessageBox.Show("Patient data not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Patient ID not found for the logged-in user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Error fetching LoggedInUserID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' Function to get the PatientID from the accounts table based on the LoggedInUserID
    Private Function GetPatientIDByUserID(userID As Integer) As Integer
        ' SQL query to fetch the PatientID from the accounts table
        Dim query As String = "SELECT PatientID FROM accounts WHERE UserID = @UserID"
        Dim patientID As Integer = 0

        Try
            ' Open database connection
            Dim connection As MySqlConnection = DB.Open()

            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@UserID", userID)

                ' Execute the query to fetch the PatientID
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.HasRows Then
                    reader.Read()
                    ' Handle DBNull to prevent casting error
                    If Not IsDBNull(reader("PatientID")) Then
                        patientID = Convert.ToInt32(reader("PatientID"))
                    End If
                End If

                reader.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            DB.Close() ' Ensure the connection is closed after the query
        End Try

        Return patientID
    End Function

    ' Function to get the patient data from the patients table based on the PatientID
    Private Function GetPatientDataByPatientID(patientID As Integer) As DataRow
        ' SQL query to fetch patient data based on the PatientID
        Dim query As String = "SELECT PatientID, FirstName, MiddleName, LastName, Age, Sex, DateOfBirth, BloodType, Phone, 
                               ParentGuardian, Email, Address FROM patients WHERE PatientID = @PatientID"
        Dim patientData As DataTable = New DataTable()

        Try
            ' Open database connection
            Dim connection As MySqlConnection = DB.Open()

            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@PatientID", patientID)

                ' Fill the DataTable with the patient data
                Using adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(patientData)
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            DB.Close() ' Ensure the connection is closed after the query
        End Try

        ' Return the patient data (first row)
        If patientData.Rows.Count > 0 Then
            Return patientData.Rows(0)
        Else
            Return Nothing
        End If
    End Function

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        PatientMenuPage.Show()
        Me.Hide()
    End Sub
End Class
