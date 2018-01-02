<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.btnReset = New System.Windows.Forms.Button()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.btnSigin = New System.Windows.Forms.Button()
        Me.txtPwd = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnReset
        '
        Me.btnReset.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnReset.Location = New System.Drawing.Point(210, 211)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(132, 31)
        Me.btnReset.TabIndex = 10
        Me.btnReset.Text = "RESET"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'txtUserName
        '
        Me.txtUserName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtUserName.BackColor = System.Drawing.SystemColors.Window
        Me.txtUserName.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserName.ForeColor = System.Drawing.Color.Black
        Me.txtUserName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtUserName.Location = New System.Drawing.Point(57, 116)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(281, 32)
        Me.txtUserName.TabIndex = 9
        Me.txtUserName.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(20, 44)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(352, 235)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'ColorDialog1
        '
        Me.ColorDialog1.Color = System.Drawing.Color.Transparent
        '
        'btnSigin
        '
        Me.btnSigin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSigin.BackColor = System.Drawing.Color.Green
        Me.btnSigin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSigin.ForeColor = System.Drawing.Color.Honeydew
        Me.btnSigin.Location = New System.Drawing.Point(57, 211)
        Me.btnSigin.Name = "btnSigin"
        Me.btnSigin.Size = New System.Drawing.Size(132, 31)
        Me.btnSigin.TabIndex = 10
        Me.btnSigin.Text = "SINGIN"
        Me.btnSigin.UseVisualStyleBackColor = False
        '
        'txtPwd
        '
        Me.txtPwd.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPwd.BackColor = System.Drawing.SystemColors.Window
        Me.txtPwd.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPwd.ForeColor = System.Drawing.Color.Black
        Me.txtPwd.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtPwd.Location = New System.Drawing.Point(57, 163)
        Me.txtPwd.Name = "txtPwd"
        Me.txtPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPwd.Size = New System.Drawing.Size(281, 32)
        Me.txtPwd.TabIndex = 9
        Me.txtPwd.TabStop = False
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(393, 322)
        Me.Controls.Add(Me.btnSigin)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.txtPwd)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "frmLogin"
        Me.TransparencyKey = System.Drawing.SystemColors.ScrollBar
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents btnSigin As System.Windows.Forms.Button
    Friend WithEvents txtPwd As System.Windows.Forms.TextBox
End Class
