Imports MySql.Data.MySqlClient

Public Class searchPatient
    Private Sub searchPatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_PatientID = txtBox_PatientID
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles viewPatientInfo_btn.Click
        With Me
            viewPatientInfo.Show()
        End With
    End Sub

    Private Sub viewPatientRecords_btn_Click(sender As Object, e As EventArgs) Handles viewPatientRecords_btn.Click
        With Me
            viewPatientRecords.Show()
        End With
    End Sub

    Private Sub btn_searchPatient_Click(sender As Object, e As EventArgs) Handles btn_searchPatient.Click
        Call Connect_to_DB()
        With Me
            Dim mycmd As New MySqlCommand
            Dim myreader As MySqlDataReader


            strSQL = "Select patient_id, patient_firstName, patient_lastName from patients where patient_id = '" _
                    & .txtBox_PatientID.Text & "'"
            'MsgBox(strSQL)
            mycmd.CommandText = strSQL
            mycmd.Connection = myconn
            myreader = mycmd.ExecuteReader
            If myreader.HasRows Then
                While myreader.Read()
                    .txtBox_PatientID.Text = myreader.GetString(0)
                    .txtBox_PatientFName.Text = myreader.GetString(1)
                    .txtBox_PatientLName.Text = myreader.GetString(2)
                End While
                MessageBox.Show("Patient Record Exists!", "Happi Tooth | Search Patient ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MsgBox("Patient Number does not exist!")
            End If
            Call Disconnect_to_DB()
        End With
    End Sub

    Public Shared txt_PatientID As TextBox


End Class