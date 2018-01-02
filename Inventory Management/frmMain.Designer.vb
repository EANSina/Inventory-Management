<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.tsRegistration = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsCustomer = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsVendor = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsProduct = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsStock = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsOrder = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsInvoice = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsLogout = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsRegistration, Me.tsCustomer, Me.tsVendor, Me.tsProduct, Me.tsOrder, Me.tsStock, Me.tsInvoice, Me.tsLogout})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(762, 77)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBox1})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 376)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(762, 27)
        Me.MenuStrip2.TabIndex = 7
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 23)
        Me.ToolStripTextBox1.Text = "sssss"
        '
        'ListView1
        '
        Me.ListView1.FullRowSelect = True
        Me.ListView1.Location = New System.Drawing.Point(12, 92)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(725, 266)
        Me.ListView1.TabIndex = 8
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'tsRegistration
        '
        Me.tsRegistration.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsRegistration.Image = CType(resources.GetObject("tsRegistration.Image"), System.Drawing.Image)
        Me.tsRegistration.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsRegistration.Name = "tsRegistration"
        Me.tsRegistration.Size = New System.Drawing.Size(113, 73)
        Me.tsRegistration.Text = "Registration"
        Me.tsRegistration.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsCustomer
        '
        Me.tsCustomer.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsCustomer.Image = CType(resources.GetObject("tsCustomer.Image"), System.Drawing.Image)
        Me.tsCustomer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsCustomer.Name = "tsCustomer"
        Me.tsCustomer.Size = New System.Drawing.Size(103, 73)
        Me.tsCustomer.Text = "Distributor"
        Me.tsCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsVendor
        '
        Me.tsVendor.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem})
        Me.tsVendor.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsVendor.Image = CType(resources.GetObject("tsVendor.Image"), System.Drawing.Image)
        Me.tsVendor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsVendor.Name = "tsVendor"
        Me.tsVendor.ShowShortcutKeys = False
        Me.tsVendor.Size = New System.Drawing.Size(75, 73)
        Me.tsVendor.Text = "Vendor"
        Me.tsVendor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'tsProduct
        '
        Me.tsProduct.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsProduct.Image = CType(resources.GetObject("tsProduct.Image"), System.Drawing.Image)
        Me.tsProduct.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsProduct.Name = "tsProduct"
        Me.tsProduct.Size = New System.Drawing.Size(78, 73)
        Me.tsProduct.Text = "Product"
        Me.tsProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsStock
        '
        Me.tsStock.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsStock.Image = Global.Inventory_Management.My.Resources.Resources.stock_icon_v_3
        Me.tsStock.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsStock.Name = "tsStock"
        Me.tsStock.Size = New System.Drawing.Size(62, 73)
        Me.tsStock.Text = "Stock"
        Me.tsStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsOrder
        '
        Me.tsOrder.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsOrder.Image = CType(resources.GetObject("tsOrder.Image"), System.Drawing.Image)
        Me.tsOrder.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsOrder.Name = "tsOrder"
        Me.tsOrder.Size = New System.Drawing.Size(65, 73)
        Me.tsOrder.Text = "Order"
        Me.tsOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsInvoice
        '
        Me.tsInvoice.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsInvoice.Image = CType(resources.GetObject("tsInvoice.Image"), System.Drawing.Image)
        Me.tsInvoice.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsInvoice.Name = "tsInvoice"
        Me.tsInvoice.Size = New System.Drawing.Size(73, 73)
        Me.tsInvoice.Text = "Invoice"
        Me.tsInvoice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsLogout
        '
        Me.tsLogout.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsLogout.Image = CType(resources.GetObject("tsLogout.Image"), System.Drawing.Image)
        Me.tsLogout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsLogout.Name = "tsLogout"
        Me.tsLogout.Size = New System.Drawing.Size(70, 73)
        Me.tsLogout.Text = "Logout"
        Me.tsLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(762, 403)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Name = "frmMain"
        Me.Text = "frmMain"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents tsRegistration As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsCustomer As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsVendor As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsProduct As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsStock As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsOrder As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsInvoice As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip2 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents tsLogout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
