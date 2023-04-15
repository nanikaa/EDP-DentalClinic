<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(home))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.homeNewPatient_btn = New System.Windows.Forms.Button()
        Me.homeSearch_btn = New System.Windows.Forms.Button()
        Me.homeNewRecord_btn = New System.Windows.Forms.Button()
        Me.btnUploadData = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnBackUp_DB = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(28, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(247, 242)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'homeNewPatient_btn
        '
        Me.homeNewPatient_btn.BackColor = System.Drawing.Color.HotPink
        Me.homeNewPatient_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.homeNewPatient_btn.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.homeNewPatient_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.homeNewPatient_btn.Location = New System.Drawing.Point(311, 88)
        Me.homeNewPatient_btn.Name = "homeNewPatient_btn"
        Me.homeNewPatient_btn.Size = New System.Drawing.Size(207, 31)
        Me.homeNewPatient_btn.TabIndex = 40
        Me.homeNewPatient_btn.Text = "New Patient"
        Me.homeNewPatient_btn.UseVisualStyleBackColor = False
        '
        'homeSearch_btn
        '
        Me.homeSearch_btn.BackColor = System.Drawing.Color.HotPink
        Me.homeSearch_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.homeSearch_btn.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.homeSearch_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.homeSearch_btn.Location = New System.Drawing.Point(311, 42)
        Me.homeSearch_btn.Name = "homeSearch_btn"
        Me.homeSearch_btn.Size = New System.Drawing.Size(207, 31)
        Me.homeSearch_btn.TabIndex = 39
        Me.homeSearch_btn.Text = "Search Patient"
        Me.homeSearch_btn.UseVisualStyleBackColor = False
        '
        'homeNewRecord_btn
        '
        Me.homeNewRecord_btn.BackColor = System.Drawing.Color.HotPink
        Me.homeNewRecord_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.homeNewRecord_btn.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.homeNewRecord_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.homeNewRecord_btn.Location = New System.Drawing.Point(311, 133)
        Me.homeNewRecord_btn.Name = "homeNewRecord_btn"
        Me.homeNewRecord_btn.Size = New System.Drawing.Size(207, 31)
        Me.homeNewRecord_btn.TabIndex = 41
        Me.homeNewRecord_btn.Text = "New Patient Record"
        Me.homeNewRecord_btn.UseVisualStyleBackColor = False
        '
        'btnUploadData
        '
        Me.btnUploadData.BackColor = System.Drawing.Color.HotPink
        Me.btnUploadData.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUploadData.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUploadData.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnUploadData.Location = New System.Drawing.Point(311, 178)
        Me.btnUploadData.Name = "btnUploadData"
        Me.btnUploadData.Size = New System.Drawing.Size(207, 31)
        Me.btnUploadData.TabIndex = 42
        Me.btnUploadData.Text = "Upload Data"
        Me.btnUploadData.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnBackUp_DB
        '
        Me.btnBackUp_DB.BackColor = System.Drawing.Color.HotPink
        Me.btnBackUp_DB.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBackUp_DB.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackUp_DB.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBackUp_DB.Location = New System.Drawing.Point(311, 222)
        Me.btnBackUp_DB.Name = "btnBackUp_DB"
        Me.btnBackUp_DB.Size = New System.Drawing.Size(207, 31)
        Me.btnBackUp_DB.TabIndex = 43
        Me.btnBackUp_DB.Text = "Backup Data"
        Me.btnBackUp_DB.UseVisualStyleBackColor = False
        '
        'home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(577, 299)
        Me.Controls.Add(Me.btnBackUp_DB)
        Me.Controls.Add(Me.btnUploadData)
        Me.Controls.Add(Me.homeNewRecord_btn)
        Me.Controls.Add(Me.homeNewPatient_btn)
        Me.Controls.Add(Me.homeSearch_btn)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Happi Tooth | Home"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents homeNewPatient_btn As Button
    Friend WithEvents homeSearch_btn As Button
    Friend WithEvents homeNewRecord_btn As Button
    Friend WithEvents btnUploadData As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btnBackUp_DB As Button
End Class
