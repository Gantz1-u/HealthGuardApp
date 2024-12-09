Imports MySql.Data.MySqlClient

Public Class InputInfoPage
    Inherits Form

    Public Property PatientId As Integer
    Private ReadOnly DB As New DBConnection()

    ' Set PatientID and load patient data
    Public Sub SetPatientId(patientId As Integer)
        Me.PatientId = patientId
        If patientId > 0 Then LoadPatientData()
    End Sub

    ' Calculate and display age
    Private Sub CalculateAge()
        Dim birthDate = dtp_DateOfBirth.Value
        Dim age = DateTime.Now.Year - birthDate.Year
        If DateTime.Now < birthDate.AddYears(age) Then age -= 1
        lbl_Age.Text = $"Age: {age} years"
    End Sub

    ' Handle DateOfBirth change
    Private Sub dtp_DateOfBirth_ValueChanged(sender As Object, e As EventArgs) Handles dtp_DateOfBirth.ValueChanged
        CalculateAge()
    End Sub

    ' Load patient data from the database
    Private Sub LoadPatientData()
        Dim query = "SELECT * FROM patients WHERE PatientID = @PatientID"

        Try
            Using connection = DB.Open(), cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@PatientID", PatientId)
                Using reader = cmd.ExecuteReader()
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
            MessageBox.Show($"Error loading patient data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            DB.Close()
        End Try
    End Sub

    ' Save patient data
    Private Sub RoundedButton3_Click(sender As Object, e As EventArgs) Handles RoundedButton3.Click
        If Not ValidateInputs() Then Return

        Dim query = "UPDATE patients SET DateOfBirth = @DateOfBirth, Sex = @Sex, BloodType = @BloodType, 
                     ParentGuardian = @ParentGuardian, Address = @Address WHERE PatientID = @PatientID"

        Try
            Using connection = DB.Open(), cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@DateOfBirth", dtp_DateOfBirth.Value)
                cmd.Parameters.AddWithValue("@Sex", cmb_Sex.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@BloodType", cmb_BloodType.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@ParentGuardian", txt_ParentGuardian.Text.Trim())
                cmd.Parameters.AddWithValue("@Address", txt_Address.Text.Trim())
                cmd.Parameters.AddWithValue("@PatientID", PatientId)

                cmd.ExecuteNonQuery()
                MessageBox.Show("Patient data updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error updating patient data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            DB.Close()
        End Try
    End Sub

    ' Validate inputs
    Private Function ValidateInputs() As Boolean
        If String.IsNullOrWhiteSpace(cmb_Sex.SelectedItem?.ToString()) OrElse
           String.IsNullOrWhiteSpace(cmb_BloodType.SelectedItem?.ToString()) OrElse
           String.IsNullOrWhiteSpace(txt_ParentGuardian.Text) OrElse
           String.IsNullOrWhiteSpace(txt_Address.Text) Then
            MessageBox.Show("Please fill all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        Return True
    End Function
End Class
