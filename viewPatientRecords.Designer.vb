<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class viewPatientRecords
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(viewPatientRecords))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtbox_Balance = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.label_patientID = New System.Windows.Forms.Label()
        Me.btn_updateBal = New System.Windows.Forms.Button()
        Me.grdData = New System.Windows.Forms.DataGridView()
        Me.btn_Print = New System.Windows.Forms.Button()
        Me.label_LName = New System.Windows.Forms.Label()
        Me.label_FName = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(305, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 17)
        Me.Label3.TabIndex = 78
        Me.Label3.Text = "First Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(183, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 17)
        Me.Label1.TabIndex = 77
        Me.Label1.Text = "Last Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(182, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 26)
        Me.Label2.TabIndex = 72
        Me.Label2.Text = "Patient Records"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(56, 38)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(120, 96)
        Me.PictureBox1.TabIndex = 71
        Me.PictureBox1.TabStop = False
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(575, 57)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(120, 21)
        Me.Label25.TabIndex = 112
        Me.Label25.Text = "Patient ID Number:"
        '
        'txtbox_Balance
        '
        Me.txtbox_Balance.Location = New System.Drawing.Point(643, 90)
        Me.txtbox_Balance.Name = "txtbox_Balance"
        Me.txtbox_Balance.Size = New System.Drawing.Size(125, 20)
        Me.txtbox_Balance.TabIndex = 113
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.HotPink
        Me.Label14.Font = New System.Drawing.Font("Franklin Gothic Heavy", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label14.Location = New System.Drawing.Point(60, 179)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(195, 24)
        Me.Label14.TabIndex = 117
        Me.Label14.Text = "TREATMENT HISTORY"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.HotPink
        Me.PictureBox2.Location = New System.Drawing.Point(56, 172)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(769, 37)
        Me.PictureBox2.TabIndex = 116
        Me.PictureBox2.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(575, 89)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 21)
        Me.Label7.TabIndex = 125
        Me.Label7.Text = "Balance:"
        '
        'label_patientID
        '
        Me.label_patientID.AutoSize = True
        Me.label_patientID.BackColor = System.Drawing.Color.Transparent
        Me.label_patientID.Font = New System.Drawing.Font("Cascadia Mono", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_patientID.ForeColor = System.Drawing.Color.HotPink
        Me.label_patientID.Location = New System.Drawing.Point(694, 50)
        Me.label_patientID.Name = "label_patientID"
        Me.label_patientID.Size = New System.Drawing.Size(60, 28)
        Me.label_patientID.TabIndex = 126
        Me.label_patientID.Text = "0000"
        '
        'btn_updateBal
        '
        Me.btn_updateBal.Location = New System.Drawing.Point(774, 87)
        Me.btn_updateBal.Name = "btn_updateBal"
        Me.btn_updateBal.Size = New System.Drawing.Size(51, 23)
        Me.btn_updateBal.TabIndex = 127
        Me.btn_updateBal.Text = "Update"
        Me.btn_updateBal.UseVisualStyleBackColor = True
        '
        'grdData
        '
        Me.grdData.AllowUserToAddRows = False
        Me.grdData.AllowUserToDeleteRows = False
        Me.grdData.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.grdData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdData.Location = New System.Drawing.Point(56, 215)
        Me.grdData.MaximumSize = New System.Drawing.Size(769, 150)
        Me.grdData.MinimumSize = New System.Drawing.Size(769, 150)
        Me.grdData.Name = "grdData"
        Me.grdData.ReadOnly = True
        Me.grdData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.grdData.Size = New System.Drawing.Size(769, 150)
        Me.grdData.TabIndex = 128
        '
        'btn_Print
        '
        Me.btn_Print.BackColor = System.Drawing.Color.PaleTurquoise
        Me.btn_Print.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Print.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Print.Location = New System.Drawing.Point(392, 435)
        Me.btn_Print.Name = "btn_Print"
        Me.btn_Print.Size = New System.Drawing.Size(86, 31)
        Me.btn_Print.TabIndex = 129
        Me.btn_Print.Text = "Print"
        Me.btn_Print.UseVisualStyleBackColor = False
        '
        'label_LName
        '
        Me.label_LName.AutoSize = True
        Me.label_LName.BackColor = System.Drawing.Color.Transparent
        Me.label_LName.Font = New System.Drawing.Font("Cascadia Mono", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_LName.ForeColor = System.Drawing.Color.Black
        Me.label_LName.Location = New System.Drawing.Point(188, 111)
        Me.label_LName.Name = "label_LName"
        Me.label_LName.Size = New System.Drawing.Size(60, 28)
        Me.label_LName.TabIndex = 130
        Me.label_LName.Text = "0000"
        '
        'label_FName
        '
        Me.label_FName.AutoSize = True
        Me.label_FName.BackColor = System.Drawing.Color.Transparent
        Me.label_FName.Font = New System.Drawing.Font("Cascadia Mono", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_FName.ForeColor = System.Drawing.Color.Black
        Me.label_FName.Location = New System.Drawing.Point(313, 111)
        Me.label_FName.Name = "label_FName"
        Me.label_FName.Size = New System.Drawing.Size(60, 28)
        Me.label_FName.TabIndex = 131
        Me.label_FName.Text = "0000"
        '
        'viewPatientRecords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(891, 487)
        Me.Controls.Add(Me.label_FName)
        Me.Controls.Add(Me.label_LName)
        Me.Controls.Add(Me.btn_Print)
        Me.Controls.Add(Me.grdData)
        Me.Controls.Add(Me.btn_updateBal)
        Me.Controls.Add(Me.label_patientID)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.txtbox_Balance)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "viewPatientRecords"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Happi Tooth | Patient Records"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label25 As Label
    Friend WithEvents txtbox_Balance As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents label_patientID As Label
    Friend WithEvents btn_updateBal As Button
    Friend WithEvents grdData As DataGridView
    Friend WithEvents btn_Print As Button
    Friend WithEvents label_LName As Label
    Friend WithEvents label_FName As Label
End Class
