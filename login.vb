Imports MySql.Data.MySqlClient

Public Class login
    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand
            Dim myreader As MySqlDataReader


            strSQL = "Select * from admin where username = '" _
                & .usrName_txtBox.Text & "' and password = md5('" _
                & .pass_txtBox.Text & "')"
            'MsgBox(strSQL)
            mycmd.CommandText = strSQL
            mycmd.Connection = myconn

            myreader = mycmd.ExecuteReader
            If myreader.HasRows Then
                .Hide()
                home.Show()
            Else
                MessageBox.Show("Invalid username or password")
            End If
            Call Disconnect_to_DB()
        End With
    End Sub
End Class
