Imports System.IO
Imports System.Text

Public Class viewUploadedData
    Dim dt As DataTable
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dt = New DataTable
        dt.Columns.Add("Patient ID", GetType(String))
        dt.Columns.Add("Last Name", GetType(String))
        dt.Columns.Add("FirstName", GetType(String))
        dt.Columns.Add("Barangay", GetType(String))
        dt.Columns.Add("City/Town", GetType(String))
        dt.Columns.Add("Province", GetType(String))
        dt.Columns.Add("Age", GetType(String))
        dt.Columns.Add("Balance", GetType(String))
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fName As String = ""
        OpenFileDialog1.InitialDirectory = "C:\sample"
        OpenFileDialog1.Filter = "CSV files(*.csv)|*.csv"
        OpenFileDialog1.FilterIndex = 2
        OpenFileDialog1.RestoreDirectory = True
        If (OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            fName = OpenFileDialog1.FileName
        End If
        TextBox1.Text = fName
        Dim TextLine As String = ""
        Dim SplitLine() As String

        If System.IO.File.Exists(fName) = True Then
            Dim objReader As New System.IO.StreamReader(TextBox1.Text, Encoding.ASCII)
            Dim index As Integer = 0
            Do While objReader.Peek() <> -1
                If index > 0 Then
                    TextLine = objReader.ReadLine()
                    SplitLine = Split(TextLine, ",")
                    dt.Rows.Add(SplitLine)
                Else
                    TextLine = objReader.ReadLine()
                End If
                index = index + 1
            Loop
            DataGridView1.DataSource = dt
        Else
            MsgBox("File Does Not Exist")
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class