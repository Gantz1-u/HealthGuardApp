Imports MySql.Data.MySqlClient

Public Class InputInfoPage
    ' Property to store the PatientID
    Public Property PatientId As Integer

    ' Private instance of the DBConnection class
    Private DB As New DBConnection()

    ' Method to set the PatientID and load related data (optional)
    Public Sub SetPatientId(patientId As Integer)
        Me.PatientId = patientId
        ' Optionally, you can use PatientId to query the database and populate other fields
        LoadPatientData()
    End Sub

    ' Method to calculate age based on DateOfBirth
    Private Sub CalculateAge()
        Dim birthDate As DateTime = dtp_DateOfBirth.Value
        Dim today As DateTime = DateTime.Now
        Dim age As Integer = today.Year - birthDate.Year

        ' Adjust if the birthday hasn't occurred yet this year
        If today.Month < birthDate.Month OrElse (today.Month = birthDate.Month And today.Day < birthDate.Day) Then
            age -= 1
        End If

        lbl_Age.Text = $"Age: {age} years"
    End Sub

    ' Event handler for Date of Birth change to recalculate age
    Private Sub dtp_DateOfBirth_ValueChanged(sender As Object, e As EventArgs)
        CalculateAge()
    End Sub

    ' Load patient data based on PatientID (Optional)
    Private Sub LoadPatientData()
        ' Query database to get patient data (if needed)
        If PatientId > 0 Then
            Dim query As String = "SELECT * FROM patients WHERE PatientID = @PatientID"
            Try
                ' Use the DBConnection class to open a connection
                Dim connection = DB.Open()
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@PatientID", PatientId)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            ' Populate fields with the fetched data (example fields)
                            dtp_DateOfBirth.Value = Convert.ToDateTime(reader("DateOfBirth"))
                            cmb_Sex.SelectedItem = reader("Sex").ToString()
                            cmb_BloodType.SelectedItem = reader("BloodType").ToString()
                            txt_ParentGuardian.Text = reader("ParentGuardian").ToString()
                            txt_Address.Text = reader("Address").ToString()
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show($"An error occurred while loading patient data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                DB.Close()
            End Try
        End If
    End Sub

    ' Event handler for Save button click
    Private Sub RoundedButton3_Click(sender As Object, e As EventArgs) Handles RoundedButton3.Click
        ' Get the input data from controls
        Dim dateOfBirth = dtp_DateOfBirth.Value
        Dim sex = cmb_Sex.SelectedItem.ToString()
        Dim bloodType = cmb_BloodType.SelectedItem.ToString()
        Dim parentGuardian = txt_ParentGuardian.Text.Trim()
        Dim address = txt_Address.Text.Trim()

        ' Validate required fields
        If String.IsNullOrEmpty(sex) OrElse String.IsNullOrEmpty(bloodType) OrElse String.IsNullOrEmpty(parentGuardian) OrElse String.IsNullOrEmpty(address) Then
            MessageBox.Show("Please fill all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Update the patient data in the database
        Dim query = "
            UPDATE patients
            SET DateOfBirth = @DateOfBirth,
                Sex = @Sex,
                BloodType = @BloodType,
                ParentGuardian = @ParentGuardian,
                Address = @Address
            WHERE PatientID = @PatientID"

        Try
            ' Open database connection
            Dim connection = DB.Open()
            Using cmd As New MySqlCommand(query, connection)
                ' Add parameters to the query
                cmd.Parameters.AddWithValue("@DateOfBirth", dateOfBirth)
                cmd.Parameters.AddWithValue("@Sex", sex)
                cmd.Parameters.AddWithValue("@BloodType", bloodType)
                cmd.Parameters.AddWithValue("@ParentGuardian", parentGuardian)
                cmd.Parameters.AddWithValue("@Address", address)
                cmd.Parameters.AddWithValue("@PatientID", PatientId)

                ' Execute the update query
                cmd.ExecuteNonQuery()
                MessageBox.Show("Patient data updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        Catch ex As Exception
            MessageBox.Show($"An error occurred while updating patient data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            DB.Close()
        End Try
    End Sub

End Class
