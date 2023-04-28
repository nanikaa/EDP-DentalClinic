Imports MySql.Data.MySqlClient

Public Class viewPatientInfo
    Private Sub viewPatientInfo_Load(sender As Object, e As EventArgs) Handles Me.Load
        With Me
            Dim patient_IDNum As String
            patient_IDNum = searchPatient.txt_PatientID.Text

            label_PatientID.Text = patient_IDNum
        End With

        Call Connect_to_DB()
        With Me
            Dim mycmd As New MySqlCommand
            Dim myreader As MySqlDataReader


            strSQL = "Select patient_lastName, patient_firstName, patient_address, patient_age from patients where patient_id = '" _
                    & .label_PatientID.Text & "'"
            'MsgBox(strSQL)
            mycmd.CommandText = strSQL
            mycmd.Connection = myconn
            myreader = mycmd.ExecuteReader
            If myreader.HasRows Then
                While myreader.Read()
                    '.txtBox_PatientID.Text = myreader.GetString(0)
                    .txtBox_LastName.Text = myreader.GetString(0)
                    .txtBox_FirstName.Text = myreader.GetString(1)
                    .txtBox_Address.Text = myreader.GetString(2)
                    .txtBox_Age.Text = myreader.GetString(3)
                End While
            Else
                MsgBox("Patient Number does not exists!")
            End If
            Call Disconnect_to_DB()
        End With
    End Sub

    Private Sub btn_Update_Click(sender As Object, e As EventArgs) Handles btn_Update.Click
        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand
            Try
                strSQL = "Update patients set patient_age = '" _
                & .txtBox_Age.Text & "', patient_address = '" _
                & .txtBox_Address.Text & "', patient_lastName = '" _
                & .txtBox_LastName.Text & "', patient_firstName = '" _
                & .txtBox_FirstName.Text & "' where patient_id = '" _
                & .label_PatientID.Text & "'"

                mycmd.CommandText = strSQL
                mycmd.Connection = myconn
                mycmd.ExecuteNonQuery()
                MsgBox("Record Successfully Updated")
            Catch ex As MySqlException
                MsgBox(ex.Number & " " & ex.Message)
            End Try
            Disconnect_to_DB()
        End With
    End Sub
End Class