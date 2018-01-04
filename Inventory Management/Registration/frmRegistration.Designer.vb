<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistration
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
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtContactNo = New System.Windows.Forms.MaskedTextBox()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.btnGetDetails = New System.Windows.Forms.Button()
        Me.btnUpdate_record = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnNewRecord = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.LightGray
        Me.Label11.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(12, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(442, 35)
        Me.Label11.TabIndex = 57
        Me.Label11.Text = "User Registration"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtContactNo)
        Me.GroupBox1.Controls.Add(Me.txtFullName)
        Me.GroupBox1.Controls.Add(Me.txtUserName)
        Me.GroupBox1.Controls.Add(Me.txtPassword)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(391, 202)
        Me.GroupBox1.TabIndex = 55
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "User Details"
        '
        'txtContactNo
        '
        Me.txtContactNo.Location = New System.Drawing.Point(126, 151)
        Me.txtContactNo.Mask = "(999) 000-0000"
        Me.txtContactNo.Name = "txtContactNo"
        Me.txtContactNo.Size = New System.Drawing.Size(183, 32)
        Me.txtContactNo.TabIndex = 3
        '
        'txtFullName
        '
        Me.txtFullName.Location = New System.Drawing.Point(126, 114)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(183, 32)
        Me.txtFullName.TabIndex = 2
        '
        'txtUserName
        '
        Me.txtUserName.BackColor = System.Drawing.SystemColors.Window
        Me.txtUserName.Location = New System.Drawing.Point(126, 33)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(183, 32)
        Me.txtUserName.TabIndex = 1
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(126, 73)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(183, 32)
        Me.txtPassword.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(31, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 18)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Contact No."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(31, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 18)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Full Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 18)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 18)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "User Name"
        '
        'panel1
        '
        Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel1.Controls.Add(Me.btnGetDetails)
        Me.panel1.Controls.Add(Me.btnUpdate_record)
        Me.panel1.Controls.Add(Me.btnDelete)
        Me.panel1.Controls.Add(Me.btnSave)
        Me.panel1.Controls.Add(Me.btnNewRecord)
        Me.panel1.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panel1.Location = New System.Drawing.Point(409, 63)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(117, 176)
        Me.panel1.TabIndex = 56
        '
        'btnGetDetails
        '
        Me.btnGetDetails.BackColor = System.Drawing.SystemColors.Control
        Me.btnGetDetails.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGetDetails.Location = New System.Drawing.Point(14, 132)
        Me.btnGetDetails.Name = "btnGetDetails"
        Me.btnGetDetails.Size = New System.Drawing.Size(94, 28)
        Me.btnGetDetails.TabIndex = 4
        Me.btnGetDetails.Text = "&Get Data"
        Me.btnGetDetails.UseVisualStyleBackColor = False
        '
        'btnUpdate_record
        '
        Me.btnUpdate_record.BackColor = System.Drawing.SystemColors.Control
        Me.btnUpdate_record.Enabled = False
        Me.btnUpdate_record.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate_record.Location = New System.Drawing.Point(14, 102)
        Me.btnUpdate_record.Name = "btnUpdate_record"
        Me.btnUpdate_record.Size = New System.Drawing.Size(94, 27)
        Me.btnUpdate_record.TabIndex = 3
        Me.btnUpdate_record.Text = "&Update"
        Me.btnUpdate_record.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.SystemColors.Control
        Me.btnDelete.Enabled = False
        Me.btnDelete.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(14, 71)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(94, 27)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.Control
        Me.btnSave.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(14, 40)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(94, 27)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnNewRecord
        '
        Me.btnNewRecord.BackColor = System.Drawing.SystemColors.Control
        Me.btnNewRecord.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewRecord.Location = New System.Drawing.Point(14, 8)
        Me.btnNewRecord.Name = "btnNewRecord"
        Me.btnNewRecord.Size = New System.Drawing.Size(94, 27)
        Me.btnNewRecord.TabIndex = 0
        Me.btnNewRecord.Text = "&New"
        Me.btnNewRecord.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnClose.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Salmon
        Me.btnClose.Location = New System.Drawing.Point(465, 14)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(57, 26)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'frmRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 281)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.panel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRegistration"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "frmRegistration"
        Me.TransparencyKey = System.Drawing.SystemColors.Info
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtContactNo As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtFullName As System.Windows.Forms.TextBox
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents panel1 As System.Windows.Forms.Panel
    Public WithEvents btnGetDetails As System.Windows.Forms.Button
    Public WithEvents btnUpdate_record As System.Windows.Forms.Button
    Public WithEvents btnDelete As System.Windows.Forms.Button
    Public WithEvents btnSave As System.Windows.Forms.Button
    Public WithEvents btnNewRecord As System.Windows.Forms.Button
    Public WithEvents btnClose As System.Windows.Forms.Button
End Class
