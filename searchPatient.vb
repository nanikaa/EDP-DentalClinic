Public Class searchPatient
    Private Sub searchPatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
End Class