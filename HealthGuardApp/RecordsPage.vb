Imports MySql.Data.MySqlClient

Public Class RecordsPage
    Private DB As New DBConnection()

    ' Method to load patient details from the database and display them in the labels inside the panel
    Private Sub LoadPatientDetails(patientId As String)
        ' SQL query to fetch patient data based on the patient ID
        Dim query As String = "SELECT FirstName, MiddleName, LastName, Age, Sex FROM patients WHERE PatientID = @P1"

        Try
            ' Open connection to the database
            Dim connection As MySqlConnection = DB.Open()

            Using cmd As New MySqlCommand(query, connection)
                ' Add the PatientID parameter to prevent SQL injection
                cmd.Parameters.AddWithValue("@P1", patientId)

                ' Execute the query
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                ' Check if any row is returned
                If reader.HasRows Then
                    reader.Read()

                    ' Assign the database values to the labels inside the panel
                    Label10.Text = reader("FirstName").ToString()
                    Label9.Text = reader("MiddleName").ToString()
                    Label11.Text = reader("LastName").ToString()
                    Label8.Text = reader("Age").ToString()
                    Label7.Text = reader("Sex").ToString()
                Else
                    MessageBox.Show("No patient found with the provided ID.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If

                ' Close the reader
                reader.Close()
            End Using
        Catch ex As Exception
            ' Handle any errors (e.g., connection issues)
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Close the database connection
            DB.Close()
        End Try
    End Sub

    ' Example: Load patient details on form load (or you can call this method manually later)
    Private Sub RecordsPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' For example, we are loading data for PatientID = 'P1'
        LoadPatientDetails("P1")
    End Sub

    Private Sub RoundedPanel1_Paint(sender As Object, e As PaintEventArgs) Handles RoundedPanel1.Paint
        InformationPage.Show()
        Me.Hide()


    End Sub
End Class
