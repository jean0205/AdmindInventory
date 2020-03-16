<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StockMain
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonReport = New System.Windows.Forms.Button()
        Me.CheckBoxReorder = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxCategory = New System.Windows.Forms.ComboBox()
        Me.ButtonRequest = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ButtonAddStock = New System.Windows.Forms.Button()
        Me.ButtonDistrStock = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Buttonbudget = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonPendingReqs = New System.Windows.Forms.Button()
        Me.ButtonDistrbHistory = New System.Windows.Forms.Button()
        Me.ButtonStockHistory = New System.Windows.Forms.Button()
        Me.ButtonMngDepart = New System.Windows.Forms.Button()
        Me.ButtonMngCat = New System.Windows.Forms.Button()
        Me.ButtonMngitems = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.ButtonReport)
        Me.GroupBox1.Controls.Add(Me.CheckBoxReorder)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TextBoxName)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ComboBoxCategory)
        Me.GroupBox1.Location = New System.Drawing.Point(169, 6)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(1300, 87)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'ButtonReport
        '
        Me.ButtonReport.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonReport.BackgroundImage = Global.AdmindInventory.My.Resources.Resources.pdf_xchange_editor_4144__250x250
        Me.ButtonReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonReport.FlatAppearance.BorderSize = 0
        Me.ButtonReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonReport.Location = New System.Drawing.Point(1213, 16)
        Me.ButtonReport.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonReport.Name = "ButtonReport"
        Me.ButtonReport.Size = New System.Drawing.Size(67, 62)
        Me.ButtonReport.TabIndex = 9
        Me.ButtonReport.UseVisualStyleBackColor = True
        '
        'CheckBoxReorder
        '
        Me.CheckBoxReorder.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBoxReorder.AutoSize = True
        Me.CheckBoxReorder.Location = New System.Drawing.Point(835, 36)
        Me.CheckBoxReorder.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CheckBoxReorder.Name = "CheckBoxReorder"
        Me.CheckBoxReorder.Size = New System.Drawing.Size(18, 17)
        Me.CheckBoxReorder.TabIndex = 7
        Me.CheckBoxReorder.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(863, 37)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Items to re-order:"
        '
        'TextBoxName
        '
        Me.TextBoxName.Location = New System.Drawing.Point(571, 32)
        Me.TextBoxName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(220, 22)
        Me.TextBoxName.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(443, 37)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Search By Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 37)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Order By Category:"
        '
        'ComboBoxCategory
        '
        Me.ComboBoxCategory.FormattingEnabled = True
        Me.ComboBoxCategory.Location = New System.Drawing.Point(183, 32)
        Me.ComboBoxCategory.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ComboBoxCategory.Name = "ComboBoxCategory"
        Me.ComboBoxCategory.Size = New System.Drawing.Size(227, 24)
        Me.ComboBoxCategory.TabIndex = 0
        '
        'ButtonRequest
        '
        Me.ButtonRequest.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonRequest.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ButtonRequest.Location = New System.Drawing.Point(8, 209)
        Me.ButtonRequest.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonRequest.Name = "ButtonRequest"
        Me.ButtonRequest.Size = New System.Drawing.Size(153, 47)
        Me.ButtonRequest.TabIndex = 10
        Me.ButtonRequest.Text = "StockRequest"
        Me.ButtonRequest.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button3.Location = New System.Drawing.Point(4, 519)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(153, 47)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Providers"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(179, 612)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 28)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "New Item"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ButtonAddStock
        '
        Me.ButtonAddStock.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonAddStock.Location = New System.Drawing.Point(4, 573)
        Me.ButtonAddStock.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonAddStock.Name = "ButtonAddStock"
        Me.ButtonAddStock.Size = New System.Drawing.Size(153, 47)
        Me.ButtonAddStock.TabIndex = 3
        Me.ButtonAddStock.Text = "Add Stock"
        Me.ButtonAddStock.UseVisualStyleBackColor = True
        '
        'ButtonDistrStock
        '
        Me.ButtonDistrStock.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonDistrStock.Location = New System.Drawing.Point(4, 627)
        Me.ButtonDistrStock.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonDistrStock.Name = "ButtonDistrStock"
        Me.ButtonDistrStock.Size = New System.Drawing.Size(153, 47)
        Me.ButtonDistrStock.TabIndex = 4
        Me.ButtonDistrStock.Text = "Distribute Stock"
        Me.ButtonDistrStock.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Location = New System.Drawing.Point(169, 92)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(1300, 705)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "."
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Buttonbudget)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.ButtonRequest)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.ButtonPendingReqs)
        Me.Panel1.Controls.Add(Me.ButtonDistrbHistory)
        Me.Panel1.Controls.Add(Me.ButtonStockHistory)
        Me.Panel1.Controls.Add(Me.ButtonMngDepart)
        Me.Panel1.Controls.Add(Me.ButtonMngCat)
        Me.Panel1.Controls.Add(Me.ButtonMngitems)
        Me.Panel1.Controls.Add(Me.ButtonDistrStock)
        Me.Panel1.Controls.Add(Me.ButtonAddStock)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(161, 853)
        Me.Panel1.TabIndex = 8
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(7, 174)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(153, 27)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Audit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Buttonbudget
        '
        Me.Buttonbudget.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Buttonbudget.Location = New System.Drawing.Point(4, 303)
        Me.Buttonbudget.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Buttonbudget.Name = "Buttonbudget"
        Me.Buttonbudget.Size = New System.Drawing.Size(153, 47)
        Me.Buttonbudget.TabIndex = 12
        Me.Buttonbudget.Text = "Budget"
        Me.Buttonbudget.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.AdmindInventory.My.Resources.Resources._4222333
        Me.PictureBox1.Location = New System.Drawing.Point(7, 14)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(151, 142)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'ButtonPendingReqs
        '
        Me.ButtonPendingReqs.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonPendingReqs.Location = New System.Drawing.Point(4, 789)
        Me.ButtonPendingReqs.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonPendingReqs.Name = "ButtonPendingReqs"
        Me.ButtonPendingReqs.Size = New System.Drawing.Size(153, 47)
        Me.ButtonPendingReqs.TabIndex = 10
        Me.ButtonPendingReqs.Text = "Pending Requests"
        Me.ButtonPendingReqs.UseVisualStyleBackColor = True
        '
        'ButtonDistrbHistory
        '
        Me.ButtonDistrbHistory.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonDistrbHistory.Location = New System.Drawing.Point(4, 735)
        Me.ButtonDistrbHistory.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonDistrbHistory.Name = "ButtonDistrbHistory"
        Me.ButtonDistrbHistory.Size = New System.Drawing.Size(153, 47)
        Me.ButtonDistrbHistory.TabIndex = 9
        Me.ButtonDistrbHistory.Text = "Stock Distribution History"
        Me.ButtonDistrbHistory.UseVisualStyleBackColor = True
        '
        'ButtonStockHistory
        '
        Me.ButtonStockHistory.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonStockHistory.Location = New System.Drawing.Point(4, 681)
        Me.ButtonStockHistory.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonStockHistory.Name = "ButtonStockHistory"
        Me.ButtonStockHistory.Size = New System.Drawing.Size(153, 47)
        Me.ButtonStockHistory.TabIndex = 8
        Me.ButtonStockHistory.Text = "Stock Entry History"
        Me.ButtonStockHistory.UseVisualStyleBackColor = True
        '
        'ButtonMngDepart
        '
        Me.ButtonMngDepart.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonMngDepart.Location = New System.Drawing.Point(4, 411)
        Me.ButtonMngDepart.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonMngDepart.Name = "ButtonMngDepart"
        Me.ButtonMngDepart.Size = New System.Drawing.Size(153, 47)
        Me.ButtonMngDepart.TabIndex = 7
        Me.ButtonMngDepart.Text = "Manage Departments"
        Me.ButtonMngDepart.UseVisualStyleBackColor = True
        '
        'ButtonMngCat
        '
        Me.ButtonMngCat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonMngCat.Location = New System.Drawing.Point(4, 357)
        Me.ButtonMngCat.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonMngCat.Name = "ButtonMngCat"
        Me.ButtonMngCat.Size = New System.Drawing.Size(153, 47)
        Me.ButtonMngCat.TabIndex = 6
        Me.ButtonMngCat.Text = "Manage Categories"
        Me.ButtonMngCat.UseVisualStyleBackColor = True
        '
        'ButtonMngitems
        '
        Me.ButtonMngitems.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonMngitems.Location = New System.Drawing.Point(4, 465)
        Me.ButtonMngitems.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonMngitems.Name = "ButtonMngitems"
        Me.ButtonMngitems.Size = New System.Drawing.Size(153, 47)
        Me.ButtonMngitems.TabIndex = 5
        Me.ButtonMngitems.Text = "Manage Items"
        Me.ButtonMngitems.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(613, 811)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(159, 22)
        Me.TextBox1.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(546, 816)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 17)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Budget:"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(874, 816)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 17)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Expenses:"
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.Location = New System.Drawing.Point(962, 811)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(159, 22)
        Me.TextBox2.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(1217, 816)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 17)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Available:"
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox3.Location = New System.Drawing.Point(1305, 811)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(159, 22)
        Me.TextBox3.TabIndex = 14
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(10, 22)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1283, 676)
        Me.DataGridView1.TabIndex = 0
        '
        'StockMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1482, 853)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "StockMain"
        Me.Text = "Stock Management System"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CheckBoxReorder As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBoxCategory As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ButtonAddStock As Button
    Friend WithEvents ButtonDistrStock As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ButtonMngDepart As Button
    Friend WithEvents ButtonMngCat As Button
    Friend WithEvents ButtonMngitems As Button
    Friend WithEvents ButtonDistrbHistory As Button
    Friend WithEvents ButtonStockHistory As Button
    Friend WithEvents ButtonPendingReqs As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents ButtonRequest As Button
    Friend WithEvents ButtonReport As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Buttonbudget As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
