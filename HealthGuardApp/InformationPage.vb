Imports MySql.Data.MySqlClient

Public Class InformationPage
    Private DB As New DBConnection()

    ' Method to load patient details
    Private Sub LoadPatientDetails(patientId As Integer)
        ' Query to get the patient details by their ID (or another identifier)
        Dim query As String = "SELECT * FROM patients WHERE PatientID = @P1"

        Try
            ' Open connection to the database
            Dim connection As MySqlConnection = DB.Open()

            Using cmd As New MySqlCommand(query, connection)
                ' Add parameter to prevent SQL injection
                cmd.Parameters.AddWithValue("@P1", patientId)

                ' Execute the query
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                ' Check if data exists
                If reader.HasRows Then
                    reader.Read()

                    ' Assign data to labels
                    Label2.Text = reader("FirstName").ToString()
                    Label4.Text = reader("MiddleName").ToString()
                    Label1.Text = reader("LastName").ToString()
                    Label6.Text = reader("Sex").ToString()
                    Label14.Text = Convert.ToDateTime(reader("DateOfBirth")).ToString("MM/dd/yyyy")
                    Label5.Text = reader("Age").ToString()
                    Label15.Text = reader("BloodType").ToString()
                    Label18.Text = reader("Phone").ToString()
                    Label16.Text = reader("ParentGuardian").ToString()
                    Label19.Text = reader("Email").ToString()
                    Label21.Text = reader("Address").ToString()
                    Label17.Text = reader("PrimaryDiagnoses").ToString()
                Else
                    MessageBox.Show("No patient found with the provided ID.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If

                ' Close the reader
                reader.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Close the database connection
            DB.Close()
        End Try
    End Sub

    ' This could be triggered when the form loads, or when an ID is passed to load a specific patient
    Private Sub PatientDetailsPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Example: Load patient with ID = 1
        LoadPatientDetails(1)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        RecordsPage.Show()
        Me.Hide()

    End Sub
End Class


