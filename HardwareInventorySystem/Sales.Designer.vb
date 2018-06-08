<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sales
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SalesBtn = New System.Windows.Forms.Button()
        Me.InventoryBtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.discountTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.itemCountLabel = New System.Windows.Forms.Label()
        Me.totalPaymentLabel = New System.Windows.Forms.Label()
        Me.serialLabel = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.RemoveBtn = New System.Windows.Forms.Button()
        Me.AddBtn = New System.Windows.Forms.Button()
        Me.PriceTxtBox = New System.Windows.Forms.TextBox()
        Me.QtyTxtBox = New System.Windows.Forms.TextBox()
        Me.ProductTxtBox = New System.Windows.Forms.TextBox()
        Me.modelTxtBox = New System.Windows.Forms.TextBox()
        Me.SerialTextBox = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ClearBtn = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.SalesBtn)
        Me.Panel1.Controls.Add(Me.InventoryBtn)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, -4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1168, 103)
        Me.Panel1.TabIndex = 17
        '
        'SalesBtn
        '
        Me.SalesBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SalesBtn.FlatAppearance.BorderSize = 0
        Me.SalesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SalesBtn.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.SalesBtn.ForeColor = System.Drawing.Color.White
        Me.SalesBtn.Location = New System.Drawing.Point(156, 49)
        Me.SalesBtn.Name = "SalesBtn"
        Me.SalesBtn.Size = New System.Drawing.Size(100, 49)
        Me.SalesBtn.TabIndex = 10
        Me.SalesBtn.Text = "Sales"
        Me.SalesBtn.UseVisualStyleBackColor = True
        '
        'InventoryBtn
        '
        Me.InventoryBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.InventoryBtn.FlatAppearance.BorderSize = 0
        Me.InventoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.InventoryBtn.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.InventoryBtn.ForeColor = System.Drawing.Color.White
        Me.InventoryBtn.Location = New System.Drawing.Point(50, 49)
        Me.InventoryBtn.Name = "InventoryBtn"
        Me.InventoryBtn.Size = New System.Drawing.Size(100, 49)
        Me.InventoryBtn.TabIndex = 9
        Me.InventoryBtn.Text = "Inventory"
        Me.InventoryBtn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(126, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(331, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Hardware Components Inventory System"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MediumTurquoise
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Altech Inc."
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.discountTextBox)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.itemCountLabel)
        Me.Panel4.Controls.Add(Me.totalPaymentLabel)
        Me.Panel4.Controls.Add(Me.serialLabel)
        Me.Panel4.Controls.Add(Me.Label15)
        Me.Panel4.Controls.Add(Me.CancelBtn)
        Me.Panel4.Controls.Add(Me.Label14)
        Me.Panel4.Controls.Add(Me.RemoveBtn)
        Me.Panel4.Controls.Add(Me.AddBtn)
        Me.Panel4.Controls.Add(Me.PriceTxtBox)
        Me.Panel4.Controls.Add(Me.QtyTxtBox)
        Me.Panel4.Controls.Add(Me.ProductTxtBox)
        Me.Panel4.Controls.Add(Me.modelTxtBox)
        Me.Panel4.Controls.Add(Me.SerialTextBox)
        Me.Panel4.Controls.Add(Me.Label13)
        Me.Panel4.Controls.Add(Me.ClearBtn)
        Me.Panel4.Controls.Add(Me.Label12)
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.Button2)
        Me.Panel4.Controls.Add(Me.DataGridView1)
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Location = New System.Drawing.Point(17, 105)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1134, 570)
        Me.Panel4.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 18.0!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(373, 298)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 30)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "%"
        '
        'discountTextBox
        '
        Me.discountTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.discountTextBox.Location = New System.Drawing.Point(306, 295)
        Me.discountTextBox.Name = "discountTextBox"
        Me.discountTextBox.Size = New System.Drawing.Size(59, 38)
        Me.discountTextBox.TabIndex = 37
        Me.discountTextBox.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(222, 306)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 21)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Discount"
        '
        'itemCountLabel
        '
        Me.itemCountLabel.AutoSize = True
        Me.itemCountLabel.Font = New System.Drawing.Font("Century Gothic", 15.0!)
        Me.itemCountLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.itemCountLabel.Location = New System.Drawing.Point(568, 397)
        Me.itemCountLabel.Name = "itemCountLabel"
        Me.itemCountLabel.Size = New System.Drawing.Size(21, 23)
        Me.itemCountLabel.TabIndex = 34
        Me.itemCountLabel.Text = "0"
        '
        'totalPaymentLabel
        '
        Me.totalPaymentLabel.AutoSize = True
        Me.totalPaymentLabel.Font = New System.Drawing.Font("Century Gothic", 20.0!)
        Me.totalPaymentLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.totalPaymentLabel.Location = New System.Drawing.Point(662, 446)
        Me.totalPaymentLabel.Name = "totalPaymentLabel"
        Me.totalPaymentLabel.Size = New System.Drawing.Size(67, 33)
        Me.totalPaymentLabel.TabIndex = 33
        Me.totalPaymentLabel.Text = "0.00"
        '
        'serialLabel
        '
        Me.serialLabel.AutoSize = True
        Me.serialLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.serialLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.serialLabel.Location = New System.Drawing.Point(17, 112)
        Me.serialLabel.Name = "serialLabel"
        Me.serialLabel.Size = New System.Drawing.Size(38, 21)
        Me.serialLabel.TabIndex = 32
        Me.serialLabel.Text = "SN: "
        Me.serialLabel.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 15.0!)
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label15.Location = New System.Drawing.Point(317, 251)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(48, 23)
        Me.Label15.TabIndex = 31
        Me.Label15.Text = "Php"
        '
        'CancelBtn
        '
        Me.CancelBtn.BackColor = System.Drawing.Color.OrangeRed
        Me.CancelBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.CancelBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.CancelBtn.Location = New System.Drawing.Point(21, 494)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(389, 63)
        Me.CancelBtn.TabIndex = 30
        Me.CancelBtn.Text = "CANCEL "
        Me.CancelBtn.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 15.0!)
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label14.Location = New System.Drawing.Point(445, 423)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(53, 23)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "VAT:"
        '
        'RemoveBtn
        '
        Me.RemoveBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RemoveBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RemoveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RemoveBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.RemoveBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.RemoveBtn.Location = New System.Drawing.Point(217, 426)
        Me.RemoveBtn.Name = "RemoveBtn"
        Me.RemoveBtn.Size = New System.Drawing.Size(192, 62)
        Me.RemoveBtn.TabIndex = 28
        Me.RemoveBtn.Text = "REMOVE ITEM"
        Me.RemoveBtn.UseVisualStyleBackColor = False
        '
        'AddBtn
        '
        Me.AddBtn.BackColor = System.Drawing.Color.LightSeaGreen
        Me.AddBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.AddBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.AddBtn.Location = New System.Drawing.Point(20, 351)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(389, 69)
        Me.AddBtn.TabIndex = 7
        Me.AddBtn.Text = "ADD"
        Me.AddBtn.UseVisualStyleBackColor = False
        '
        'PriceTxtBox
        '
        Me.PriceTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.PriceTxtBox.Location = New System.Drawing.Point(93, 241)
        Me.PriceTxtBox.Name = "PriceTxtBox"
        Me.PriceTxtBox.Size = New System.Drawing.Size(218, 38)
        Me.PriceTxtBox.TabIndex = 4
        Me.PriceTxtBox.Text = "0"
        '
        'QtyTxtBox
        '
        Me.QtyTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.QtyTxtBox.Location = New System.Drawing.Point(93, 295)
        Me.QtyTxtBox.Name = "QtyTxtBox"
        Me.QtyTxtBox.Size = New System.Drawing.Size(90, 38)
        Me.QtyTxtBox.TabIndex = 1
        Me.QtyTxtBox.Text = "1"
        '
        'ProductTxtBox
        '
        Me.ProductTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.ProductTxtBox.Location = New System.Drawing.Point(92, 137)
        Me.ProductTxtBox.Name = "ProductTxtBox"
        Me.ProductTxtBox.Size = New System.Drawing.Size(317, 38)
        Me.ProductTxtBox.TabIndex = 3
        '
        'modelTxtBox
        '
        Me.modelTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.modelTxtBox.Location = New System.Drawing.Point(92, 186)
        Me.modelTxtBox.Name = "modelTxtBox"
        Me.modelTxtBox.Size = New System.Drawing.Size(317, 38)
        Me.modelTxtBox.TabIndex = 2
        '
        'SerialTextBox
        '
        Me.SerialTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.SerialTextBox.Location = New System.Drawing.Point(92, 82)
        Me.SerialTextBox.Name = "SerialTextBox"
        Me.SerialTextBox.Size = New System.Drawing.Size(317, 38)
        Me.SerialTextBox.TabIndex = 0
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label13.Location = New System.Drawing.Point(36, 253)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(47, 21)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "Price"
        '
        'ClearBtn
        '
        Me.ClearBtn.BackColor = System.Drawing.Color.SteelBlue
        Me.ClearBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClearBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.ClearBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClearBtn.Location = New System.Drawing.Point(19, 426)
        Me.ClearBtn.Name = "ClearBtn"
        Me.ClearBtn.Size = New System.Drawing.Size(192, 62)
        Me.ClearBtn.TabIndex = 20
        Me.ClearBtn.Text = "CLEAR"
        Me.ClearBtn.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 20.0!)
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label12.Location = New System.Drawing.Point(445, 446)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(211, 33)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Total Payment:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 15.0!)
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label10.Location = New System.Drawing.Point(445, 397)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(126, 23)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Total Items: "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label8.Location = New System.Drawing.Point(36, 307)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 21)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Qty"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label7.Location = New System.Drawing.Point(17, 149)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 21)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Product"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Location = New System.Drawing.Point(31, 198)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 21)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Desc."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(45, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 21)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "SN: "
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button2.Location = New System.Drawing.Point(437, 493)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(666, 64)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "DONE"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.LightGray
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView1.Location = New System.Drawing.Point(437, 21)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(683, 373)
        Me.DataGridView1.TabIndex = 12
        '
        'Column1
        '
        Me.Column1.HeaderText = "SN"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 180
        '
        'Column2
        '
        Me.Column2.HeaderText = "Model"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 130
        '
        'Column3
        '
        Me.Column3.HeaderText = "Product"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 120
        '
        'Column4
        '
        Me.Column4.HeaderText = "Qty"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 80
        '
        'Column5
        '
        Me.Column5.HeaderText = "Price"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 120
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 15.0!)
        Me.Label11.Location = New System.Drawing.Point(89, 215)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(0, 23)
        Me.Label11.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 22.0!)
        Me.Label9.Location = New System.Drawing.Point(13, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(263, 37)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Sales Transaction"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(0, 681)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1168, 97)
        Me.Panel2.TabIndex = 15
        '
        'Sales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1163, 708)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Sales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sales"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents ClearBtn As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PriceTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents QtyTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents ProductTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents modelTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents SerialTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents RemoveBtn As System.Windows.Forms.Button
    Friend WithEvents AddBtn As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents CancelBtn As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents serialLabel As System.Windows.Forms.Label
    Friend WithEvents totalPaymentLabel As System.Windows.Forms.Label
    Friend WithEvents itemCountLabel As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SalesBtn As System.Windows.Forms.Button
    Friend WithEvents InventoryBtn As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents discountTextBox As System.Windows.Forms.TextBox
End Class
