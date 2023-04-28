Imports MySql.Data.MySqlClient
Imports System.Data.Common
Imports Excel = Microsoft.Office.Interop.Excel

Public Class viewPatientRecords
    Public sqlColumns As String = "as Department_Name, dnumber as Dept_No"
    Private Sub viewPatientRecords_Load(sender As Object, e As EventArgs) Handles Me.Load

        With Me
            Dim patient_IDNum As String
            patient_IDNum = searchPatient.txt_PatientID.Text

            label_patientID.Text = patient_IDNum
        End With

        Call Connect_to_DB()
        With Me
            Dim mycmd As New MySqlCommand
            Dim myreader As MySqlDataReader


            strSQL = "Select patient_lastName, patient_firstName, balance from patients where patient_id = '" _
                    & .label_patientID.Text & "'"
            'MsgBox(strSQL)
            mycmd.CommandText = strSQL
            mycmd.Connection = myconn
            myreader = mycmd.ExecuteReader
            If myreader.HasRows Then
                While myreader.Read()
                    .label_LName.Text = myreader.GetString(0)
                    .label_FName.Text = myreader.GetString(1)
                    .txtbox_Balance.Text = myreader.GetString(2)
                End While
            Else
                MsgBox("Patient Number does not exist!")
            End If
            Call Disconnect_to_DB()
        End With

        Call Connect_to_DB()
        With Me
            Dim myreader As MySqlDataReader
            Dim mycmd As New MySqlCommand
            Dim myAdapter As New MySqlDataAdapter
            Dim myData As New DataTable
            Dim strSQL As String
            Try
                strSQL = "Select * from full_patientinfo where Patient_ID_Number = '" _
                    & .label_patientID.Text & "'"
                'MsgBox(strSQL)
                mycmd.CommandText = strSQL
                mycmd.Connection = myconn

                myAdapter.SelectCommand = mycmd
                myAdapter.Fill(myData)

                grdData.DataSource = myData
                grdData.AutoSize = True
                .grdData.Refresh()
                .grdData.EndEdit()
                .grdData.DataSource = myData
                .grdData.ReadOnly = True
                .grdData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
                '.dgreport.Columns("cost_price").DefaultCellStyle.Format = "#,##0.00"
                '.dgreport.Columns("dname").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                '.dgreport.Columns("username").DefaultCellStyle.Format = "#,##0.00"
                '.dgreport.Columns("dnumber").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Catch myerror As MySqlException
                MessageBox.Show("Error: " & myerror.Message)
            Finally
                myreader = Nothing
                mycmd = Nothing
                Call Disconnect_to_DB()
            End Try
        End With
    End Sub

    Private Sub btn_Print_Click(sender As Object, e As EventArgs) Handles btn_Print.Click
        Call importToExcel(Me.grdData, "samplereport.xlsx")
    End Sub
End Class