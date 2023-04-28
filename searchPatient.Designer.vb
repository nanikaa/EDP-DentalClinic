<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class searchPatient
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(searchPatient))
        Me.btn_searchPatient = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBox_PatientID = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.viewPatientInfo_btn = New System.Windows.Forms.Button()
        Me.viewPatientRecords_btn = New System.Windows.Forms.Button()
        Me.label_FName = New System.Windows.Forms.Label()
        Me.label_LName = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_searchPatient
        '
        Me.btn_searchPatient.BackColor = System.Drawing.Color.PaleTurquoise
        Me.btn_searchPatient.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_searchPatient.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_searchPatient.Location = New System.Drawing.Point(189, 126)
        Me.btn_searchPatient.Name = "btn_searchPatient"
        Me.btn_searchPatient.Size = New System.Drawing.Size(54, 28)
        Me.btn_searchPatient.TabIndex = 33
        Me.btn_searchPatient.Text = "Search"
        Me.btn_searchPatient.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 9.75!)
        Me.Label3.Location = New System.Drawing.Point(44, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 17)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Patient ID Number:"
        '
        'txtBox_PatientID
        '
        Me.txtBox_PatientID.Location = New System.Drawing.Point(45, 97)
        Me.txtBox_PatientID.Name = "txtBox_PatientID"
        Me.txtBox_PatientID.Size = New System.Drawing.Size(200, 20)
        Me.txtBox_PatientID.TabIndex = 31
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.Transparent
        Me.label1.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 9.75!)
        Me.label1.Location = New System.Drawing.Point(45, 173)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(63, 17)
        Me.label1.TabIndex = 30
        Me.label1.Text = "First Name:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(283, 75)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(212, 190)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 34
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 9.75!)
        Me.Label2.Location = New System.Drawing.Point(44, 226)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 17)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Last Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(42, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 26)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Search for Patient"
        '
        'viewPatientInfo_btn
        '
        Me.viewPatientInfo_btn.BackColor = System.Drawing.Color.HotPink
        Me.viewPatientInfo_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.viewPatientInfo_btn.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.viewPatientInfo_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.viewPatientInfo_btn.Location = New System.Drawing.Point(47, 321)
        Me.viewPatientInfo_btn.Name = "viewPatientInfo_btn"
        Me.viewPatientInfo_btn.Size = New System.Drawing.Size(207, 31)
        Me.viewPatientInfo_btn.TabIndex = 37
        Me.viewPatientInfo_btn.Text = "View Patient Information"
        Me.viewPatientInfo_btn.UseVisualStyleBackColor = False
        '
        'viewPatientRecords_btn
        '
        Me.viewPatientRecords_btn.BackColor = System.Drawing.Color.HotPink
        Me.viewPatientRecords_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.viewPatientRecords_btn.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.viewPatientRecords_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.viewPatientRecords_btn.Location = New System.Drawing.Point(283, 321)
        Me.viewPatientRecords_btn.Name = "viewPatientRecords_btn"
        Me.viewPatientRecords_btn.Size = New System.Drawing.Size(212, 31)
        Me.viewPatientRecords_btn.TabIndex = 38
        Me.viewPatientRecords_btn.Text = "View Patient Records"
        Me.viewPatientRecords_btn.UseVisualStyleBackColor = False
        '
        'label_FName
        '
        Me.label_FName.AutoSize = True
        Me.label_FName.BackColor = System.Drawing.Color.Transparent
        Me.label_FName.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_FName.Location = New System.Drawing.Point(44, 251)
        Me.label_FName.Name = "label_FName"
        Me.label_FName.Size = New System.Drawing.Size(0, 22)
        Me.label_FName.TabIndex = 73
        '
        'label_LName
        '
        Me.label_LName.AutoSize = True
        Me.label_LName.BackColor = System.Drawing.Color.Transparent
        Me.label_LName.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_LName.Location = New System.Drawing.Point(44, 198)
        Me.label_LName.Name = "label_LName"
        Me.label_LName.Size = New System.Drawing.Size(0, 22)
        Me.label_LName.TabIndex = 74
        '
        'searchPatient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(545, 401)
        Me.Controls.Add(Me.label_LName)
        Me.Controls.Add(Me.label_FName)
        Me.Controls.Add(Me.viewPatientRecords_btn)
        Me.Controls.Add(Me.viewPatientInfo_btn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_searchPatient)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtBox_PatientID)
        Me.Controls.Add(Me.label1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "searchPatient"
        Me.Text = "Happi Tooth | Patient Search"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_searchPatient As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtBox_PatientID As TextBox
    Friend WithEvents label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents viewPatientInfo_btn As Button
    Friend WithEvents viewPatientRecords_btn As Button
    Friend WithEvents label_FName As Label
    Friend WithEvents label_LName As Label
End Class
