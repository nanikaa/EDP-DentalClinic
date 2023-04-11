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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pass_txtBox = New System.Windows.Forms.TextBox()
        Me.usrName_txtBox = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.viewPatientInfo_btn = New System.Windows.Forms.Button()
        Me.viewPatientRecords_btn = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(100, 221)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 31)
        Me.Button1.TabIndex = 33
        Me.Button1.Text = "Go"
        Me.Button1.UseVisualStyleBackColor = False
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
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(45, 94)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(200, 20)
        Me.TextBox1.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 9.75!)
        Me.Label1.Location = New System.Drawing.Point(44, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 17)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "First Name:"
        '
        'pass_txtBox
        '
        Me.pass_txtBox.Location = New System.Drawing.Point(44, 177)
        Me.pass_txtBox.Name = "pass_txtBox"
        Me.pass_txtBox.Size = New System.Drawing.Size(200, 20)
        Me.pass_txtBox.TabIndex = 29
        '
        'usrName_txtBox
        '
        Me.usrName_txtBox.Location = New System.Drawing.Point(45, 135)
        Me.usrName_txtBox.Name = "usrName_txtBox"
        Me.usrName_txtBox.Size = New System.Drawing.Size(200, 20)
        Me.usrName_txtBox.TabIndex = 28
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
        Me.Label2.Location = New System.Drawing.Point(44, 158)
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
        'searchPatient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(545, 401)
        Me.Controls.Add(Me.viewPatientRecords_btn)
        Me.Controls.Add(Me.viewPatientInfo_btn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pass_txtBox)
        Me.Controls.Add(Me.usrName_txtBox)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "searchPatient"
        Me.Text = "Happi Tooth | Patient Search"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents pass_txtBox As TextBox
    Friend WithEvents usrName_txtBox As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents viewPatientInfo_btn As Button
    Friend WithEvents viewPatientRecords_btn As Button
End Class
