Imports MySql.Data.MySqlClient

Public Class PatientRecord
    Private DB As New MySqlConnection("server=localhost;user id=root;password=;database=db_healthguard")

    ' Call this method to load patient data into labels
    Public Sub LoadPatientData(patientId As Integer)
        Try
            ' Open the database connection
            DB.Open()

            ' Query to retrieve the patient's data
            Dim query As String = "SELECT FirstName, MiddleName, LastName, Sex, DateOfBirth, Age, BloodType, Phone, 
                                   ParentGuardian, Email, Address, PrimaryDiagnoses FROM patients WHERE PatientID = @P1"
            Using cmd As New MySqlCommand(query, DB)
                cmd.Parameters.AddWithValue("@P1", patientId)  ' Pass PatientID to query

                ' Execute the query and read data
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        ' Populate the labels with the data retrieved from the database
                        Label2.Text = If(reader("FirstName") Is DBNull.Value, "N/A", reader("FirstName").ToString())
                        Label4.Text = If(reader("MiddleName") Is DBNull.Value, "N/A", reader("MiddleName").ToString())
                        Label1.Text = If(reader("LastName") Is DBNull.Value, "N/A", reader("LastName").ToString())
                        Label6.Text = If(reader("Sex") Is DBNull.Value, "N/A", reader("Sex").ToString())
                        Label14.Text = If(reader("DateOfBirth") Is DBNull.Value, "N/A", Convert.ToDateTime(reader("DateOfBirth")).ToString("yyyy-MM-dd"))
                        Label5.Text = If(reader("Age") Is DBNull.Value, "N/A", reader("Age").ToString())
                        Label15.Text = If(reader("BloodType") Is DBNull.Value, "N/A", reader("BloodType").ToString())
                        Label18.Text = If(reader("Phone") Is DBNull.Value, "N/A", reader("Phone").ToString())
                        Label16.Text = If(reader("ParentGuardian") Is DBNull.Value, "N/A", reader("ParentGuardian").ToString())
                        Label19.Text = If(reader("Email") Is DBNull.Value, "N/A", reader("Email").ToString())
                        Label21.Text = If(reader("Address") Is DBNull.Value, "N/A", reader("Address").ToString())
                        Label17.Text = If(reader("PrimaryDiagnoses") Is DBNull.Value, "N/A", reader("PrimaryDiagnoses").ToString())

                        ' Refresh the panel to ensure the labels are updated
                        Panel1.Refresh()  ' Ensure you replace "Panel1" with the correct panel name

                    Else
                        ' Show error if no data was returned
                        MessageBox.Show("Patient not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As Exception
            ' Show any exceptions that occur
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Close the connection
            DB.Close()
        End Try
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        ' Show the PatientMenuPage and hide the current form
        PatientMenuPage.Show()
        Me.Hide()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
