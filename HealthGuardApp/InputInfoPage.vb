Imports MySql.Data.MySqlClient

Public Class InputInfoPage
    Inherits Form
    Public Property PatientId As Integer
    Private DB As New DBConnection()

    ' Set PatientID and optionally load data
    Public Sub SetPatientId(patientId As Integer)
        Me.PatientId = patientId
        LoadPatientData()
    End Sub

    ' Calculate age based on DateOfBirth
    Private Sub CalculateAge()
        Dim birthDate As DateTime = dtp_DateOfBirth.Value
        Dim age As Integer = DateTime.Now.Year - birthDate.Year
        If DateTime.Now.Month < birthDate.Month OrElse (DateTime.Now.Month = birthDate.Month AndAlso DateTime.Now.Day < birthDate.Day) Then
            age -= 1
        End If
        lbl_Age.Text = $"Age: {age} years"
    End Sub

    ' Handle DateOfBirth change event
    Private Sub dtp_DateOfBirth_ValueChanged(sender As Object, e As EventArgs) Handles dtp_DateOfBirth.ValueChanged
        CalculateAge()
    End Sub

    ' Load patient data from the database
    Private Sub LoadPatientData()
        If PatientId > 0 Then
            Dim query As String = "SELECT * FROM patients WHERE PatientID = @PatientID"
            Try
                Dim connection = DB.Open()
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@PatientID", PatientId)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
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

    ' Save updated patient data
    Private Sub RoundedButton3_Click(sender As Object, e As EventArgs) Handles RoundedButton3.Click
        Dim query = "UPDATE patients SET DateOfBirth = @DateOfBirth, Sex = @Sex, BloodType = @BloodType, 
                     ParentGuardian = @ParentGuardian, Address = @Address WHERE PatientID = @PatientID"

        ' Collect data
        Dim dateOfBirth = dtp_DateOfBirth.Value
        Dim sex = cmb_Sex.SelectedItem.ToString
        Dim bloodType = cmb_BloodType.SelectedItem.ToString
        Dim parentGuardian = txt_ParentGuardian.Text.Trim
        Dim address = txt_Address.Text.Trim

        ' Validate inputs
        If String.IsNullOrEmpty(sex) OrElse String.IsNullOrEmpty(bloodType) OrElse String.IsNullOrEmpty(parentGuardian) OrElse String.IsNullOrEmpty(address) Then
            MessageBox.Show("Please fill all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim connection = DB.Open()
            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@DateOfBirth", dateOfBirth)
                cmd.Parameters.AddWithValue("@Sex", sex)
                cmd.Parameters.AddWithValue("@BloodType", bloodType)
                cmd.Parameters.AddWithValue("@ParentGuardian", parentGuardian)
                cmd.Parameters.AddWithValue("@Address", address)
                cmd.Parameters.AddWithValue("@PatientID", PatientId)

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
