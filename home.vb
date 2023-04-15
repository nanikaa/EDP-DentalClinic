Imports MySql.Data.MySqlClient

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

    Private Sub btnUploadData_Click(sender As Object, e As EventArgs) Handles btnUploadData.Click
        With Me
            viewUploadedData.Show()
        End With
    End Sub

    Private Sub btnBackUp_DB_Click(sender As Object, e As EventArgs) Handles btnBackUp_DB.Click
        Dim backup As New SaveFileDialog
        backup.InitialDirectory = "C:\"
        backup.Title = "Database BackUp"
        backup.CheckFileExists = False
        backup.CheckPathExists = False
        backup.DefaultExt = "sql"
        backup.Filter = "sql files (*.sql)|*.sql|All files (*.*)|*.*"
        backup.RestoreDirectory = True

        If backup.ShowDialog = Windows.Forms.DialogResult.OK Then
            Call Connect_to_DB()
            Dim cmd As MySqlCommand = New MySqlCommand
            cmd.Connection = myconn
            Dim mb As MySqlBackup = New MySqlBackup(cmd)

            mb.ExportToFile(backup.FileName)
            MessageBox.Show("Database Backup is Successful!", "Happi Tooth | Backup Database ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call Disconnect_to_DB()
        ElseIf backup.ShowDialog = Windows.Forms.DialogResult.Cancel Then
            Return
        End If

    End Sub
End Class