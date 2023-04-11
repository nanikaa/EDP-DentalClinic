Public Class home
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles homeSearch_btn.Click
        With Me
            searchPatient.Show()
        End With
    End Sub

    Private Sub homeNewPatient_btn_Click(sender As Object, e As EventArgs) Handles homeNewPatient_btn.Click
        With Me
            addPatient.Show()
        End With
    End Sub

    Private Sub homeNewRecord_btn_Click(sender As Object, e As EventArgs) Handles homeNewRecord_btn.Click
        With Me
            addRecord.Show()
        End With
    End Sub
End Class