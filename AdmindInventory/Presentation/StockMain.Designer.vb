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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CheckBoxReorder = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxCategory = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ButtonAddStock = New System.Windows.Forms.Button()
        Me.ButtonDistrStock = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ButtonReports = New System.Windows.Forms.Button()
        Me.ButtonPendingReqs = New System.Windows.Forms.Button()
        Me.ButtonDistrbHistory = New System.Windows.Forms.Button()
        Me.ButtonStockHistory = New System.Windows.Forms.Button()
        Me.ButtonMngDepart = New System.Windows.Forms.Button()
        Me.ButtonMngCat = New System.Windows.Forms.Button()
        Me.ButtonMngitems = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeight = 29
        Me.DataGridView1.Location = New System.Drawing.Point(9, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(910, 400)
        Me.DataGridView1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.CheckBoxReorder)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TextBoxName)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ComboBoxCategory)
        Me.GroupBox1.Location = New System.Drawing.Point(127, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(927, 111)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(801, 71)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "inactive"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CheckBoxReorder
        '
        Me.CheckBoxReorder.AutoSize = True
        Me.CheckBoxReorder.Location = New System.Drawing.Point(769, 27)
        Me.CheckBoxReorder.Name = "CheckBoxReorder"
        Me.CheckBoxReorder.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxReorder.TabIndex = 7
        Me.CheckBoxReorder.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(790, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Items to re-order:"
        '
        'TextBoxName
        '
        Me.TextBoxName.Location = New System.Drawing.Point(517, 22)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(166, 20)
        Me.TextBoxName.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(421, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Search By Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(92, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Order By Category:"
        '
        'ComboBoxCategory
        '
        Me.ComboBoxCategory.FormattingEnabled = True
        Me.ComboBoxCategory.Location = New System.Drawing.Point(203, 23)
        Me.ComboBoxCategory.Name = "ComboBoxCategory"
        Me.ComboBoxCategory.Size = New System.Drawing.Size(171, 21)
        Me.ComboBoxCategory.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(134, 497)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "New Item"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ButtonAddStock
        '
        Me.ButtonAddStock.Location = New System.Drawing.Point(4, 146)
        Me.ButtonAddStock.Name = "ButtonAddStock"
        Me.ButtonAddStock.Size = New System.Drawing.Size(115, 38)
        Me.ButtonAddStock.TabIndex = 3
        Me.ButtonAddStock.Text = "Add Stock"
        Me.ButtonAddStock.UseVisualStyleBackColor = True
        '
        'ButtonDistrStock
        '
        Me.ButtonDistrStock.Location = New System.Drawing.Point(4, 191)
        Me.ButtonDistrStock.Name = "ButtonDistrStock"
        Me.ButtonDistrStock.Size = New System.Drawing.Size(115, 38)
        Me.ButtonDistrStock.TabIndex = 4
        Me.ButtonDistrStock.Text = "Distribute Stock"
        Me.ButtonDistrStock.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Location = New System.Drawing.Point(127, 116)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(927, 427)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "."
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ButtonReports)
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
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(121, 551)
        Me.Panel1.TabIndex = 8
        '
        'ButtonReports
        '
        Me.ButtonReports.Location = New System.Drawing.Point(2, 504)
        Me.ButtonReports.Name = "ButtonReports"
        Me.ButtonReports.Size = New System.Drawing.Size(115, 38)
        Me.ButtonReports.TabIndex = 11
        Me.ButtonReports.Text = "Reports"
        Me.ButtonReports.UseVisualStyleBackColor = True
        '
        'ButtonPendingReqs
        '
        Me.ButtonPendingReqs.Location = New System.Drawing.Point(3, 460)
        Me.ButtonPendingReqs.Name = "ButtonPendingReqs"
        Me.ButtonPendingReqs.Size = New System.Drawing.Size(115, 38)
        Me.ButtonPendingReqs.TabIndex = 10
        Me.ButtonPendingReqs.Text = "Pending Requests"
        Me.ButtonPendingReqs.UseVisualStyleBackColor = True
        '
        'ButtonDistrbHistory
        '
        Me.ButtonDistrbHistory.Location = New System.Drawing.Point(3, 416)
        Me.ButtonDistrbHistory.Name = "ButtonDistrbHistory"
        Me.ButtonDistrbHistory.Size = New System.Drawing.Size(115, 38)
        Me.ButtonDistrbHistory.TabIndex = 9
        Me.ButtonDistrbHistory.Text = "Distribution History"
        Me.ButtonDistrbHistory.UseVisualStyleBackColor = True
        '
        'ButtonStockHistory
        '
        Me.ButtonStockHistory.Location = New System.Drawing.Point(3, 371)
        Me.ButtonStockHistory.Name = "ButtonStockHistory"
        Me.ButtonStockHistory.Size = New System.Drawing.Size(115, 38)
        Me.ButtonStockHistory.TabIndex = 8
        Me.ButtonStockHistory.Text = "Stock History"
        Me.ButtonStockHistory.UseVisualStyleBackColor = True
        '
        'ButtonMngDepart
        '
        Me.ButtonMngDepart.Location = New System.Drawing.Point(4, 326)
        Me.ButtonMngDepart.Name = "ButtonMngDepart"
        Me.ButtonMngDepart.Size = New System.Drawing.Size(115, 38)
        Me.ButtonMngDepart.TabIndex = 7
        Me.ButtonMngDepart.Text = "Mange Departments"
        Me.ButtonMngDepart.UseVisualStyleBackColor = True
        '
        'ButtonMngCat
        '
        Me.ButtonMngCat.Location = New System.Drawing.Point(3, 281)
        Me.ButtonMngCat.Name = "ButtonMngCat"
        Me.ButtonMngCat.Size = New System.Drawing.Size(115, 38)
        Me.ButtonMngCat.TabIndex = 6
        Me.ButtonMngCat.Text = "Mange Categories"
        Me.ButtonMngCat.UseVisualStyleBackColor = True
        '
        'ButtonMngitems
        '
        Me.ButtonMngitems.Location = New System.Drawing.Point(3, 236)
        Me.ButtonMngitems.Name = "ButtonMngitems"
        Me.ButtonMngitems.Size = New System.Drawing.Size(115, 38)
        Me.ButtonMngitems.TabIndex = 5
        Me.ButtonMngitems.Text = "Mange Items"
        Me.ButtonMngitems.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(680, 71)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "TestProvider"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'StockMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1064, 551)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "StockMain"
        Me.Text = "Stock"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
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
    Friend WithEvents ButtonReports As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
