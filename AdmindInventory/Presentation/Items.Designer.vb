<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class New_Item
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
        Me.GroupBoxState = New System.Windows.Forms.GroupBox()
        Me.RadioButtonInactive = New System.Windows.Forms.RadioButton()
        Me.RadioButtonActive = New System.Windows.Forms.RadioButton()
        Me.ComboBoxCat = New System.Windows.Forms.ComboBox()
        Me.TextBoxPresentation = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxDescript = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.ButtonNew = New System.Windows.Forms.Button()
        Me.ButtonUpdate = New System.Windows.Forms.Button()
        Me.TextBoxReorder = New System.Windows.Forms.TextBox()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBoxState.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.ComboBoxCat)
        Me.GroupBox1.Controls.Add(Me.TextBoxPresentation)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBoxDescript)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.TextBoxReorder)
        Me.GroupBox1.Controls.Add(Me.TextBoxName)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 6)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(1141, 260)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'GroupBoxState
        '
        Me.GroupBoxState.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxState.Controls.Add(Me.RadioButtonInactive)
        Me.GroupBoxState.Controls.Add(Me.RadioButtonActive)
        Me.GroupBoxState.Location = New System.Drawing.Point(30, 43)
        Me.GroupBoxState.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBoxState.Name = "GroupBoxState"
        Me.GroupBoxState.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBoxState.Size = New System.Drawing.Size(156, 166)
        Me.GroupBoxState.TabIndex = 20
        Me.GroupBoxState.TabStop = False
        Me.GroupBoxState.Text = "State:"
        '
        'RadioButtonInactive
        '
        Me.RadioButtonInactive.AutoSize = True
        Me.RadioButtonInactive.Location = New System.Drawing.Point(21, 94)
        Me.RadioButtonInactive.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RadioButtonInactive.Name = "RadioButtonInactive"
        Me.RadioButtonInactive.Size = New System.Drawing.Size(77, 21)
        Me.RadioButtonInactive.TabIndex = 1
        Me.RadioButtonInactive.TabStop = True
        Me.RadioButtonInactive.Text = "Inactive"
        Me.RadioButtonInactive.UseVisualStyleBackColor = True
        '
        'RadioButtonActive
        '
        Me.RadioButtonActive.AutoSize = True
        Me.RadioButtonActive.Location = New System.Drawing.Point(21, 34)
        Me.RadioButtonActive.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RadioButtonActive.Name = "RadioButtonActive"
        Me.RadioButtonActive.Size = New System.Drawing.Size(67, 21)
        Me.RadioButtonActive.TabIndex = 5
        Me.RadioButtonActive.TabStop = True
        Me.RadioButtonActive.Text = "Active"
        Me.RadioButtonActive.UseVisualStyleBackColor = True
        '
        'ComboBoxCat
        '
        Me.ComboBoxCat.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBoxCat.FormattingEnabled = True
        Me.ComboBoxCat.Location = New System.Drawing.Point(137, 217)
        Me.ComboBoxCat.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxCat.MaximumSize = New System.Drawing.Size(350, 0)
        Me.ComboBoxCat.Name = "ComboBoxCat"
        Me.ComboBoxCat.Size = New System.Drawing.Size(347, 24)
        Me.ComboBoxCat.TabIndex = 4
        '
        'TextBoxPresentation
        '
        Me.TextBoxPresentation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxPresentation.Location = New System.Drawing.Point(137, 136)
        Me.TextBoxPresentation.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxPresentation.MaximumSize = New System.Drawing.Size(350, 55)
        Me.TextBoxPresentation.Name = "TextBoxPresentation"
        Me.TextBoxPresentation.Size = New System.Drawing.Size(347, 22)
        Me.TextBoxPresentation.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 142)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 17)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Attribute:"
        '
        'TextBoxDescript
        '
        Me.TextBoxDescript.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxDescript.Location = New System.Drawing.Point(137, 66)
        Me.TextBoxDescript.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxDescript.MaximumSize = New System.Drawing.Size(350, 55)
        Me.TextBoxDescript.Multiline = True
        Me.TextBoxDescript.Name = "TextBoxDescript"
        Me.TextBoxDescript.Size = New System.Drawing.Size(347, 55)
        Me.TextBoxDescript.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 84)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 17)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Description:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.GroupBoxState)
        Me.GroupBox3.Controls.Add(Me.ButtonDelete)
        Me.GroupBox3.Controls.Add(Me.ButtonNew)
        Me.GroupBox3.Controls.Add(Me.ButtonUpdate)
        Me.GroupBox3.Location = New System.Drawing.Point(775, 23)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(342, 224)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Location = New System.Drawing.Point(234, 178)
        Me.ButtonDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(100, 28)
        Me.ButtonDelete.TabIndex = 13
        Me.ButtonDelete.Text = "Delete"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'ButtonNew
        '
        Me.ButtonNew.Location = New System.Drawing.Point(234, 25)
        Me.ButtonNew.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonNew.Name = "ButtonNew"
        Me.ButtonNew.Size = New System.Drawing.Size(100, 28)
        Me.ButtonNew.TabIndex = 11
        Me.ButtonNew.Text = "Save"
        Me.ButtonNew.UseVisualStyleBackColor = True
        '
        'ButtonUpdate
        '
        Me.ButtonUpdate.Location = New System.Drawing.Point(234, 101)
        Me.ButtonUpdate.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonUpdate.Name = "ButtonUpdate"
        Me.ButtonUpdate.Size = New System.Drawing.Size(100, 28)
        Me.ButtonUpdate.TabIndex = 12
        Me.ButtonUpdate.Text = "Update"
        Me.ButtonUpdate.UseVisualStyleBackColor = True
        '
        'TextBoxReorder
        '
        Me.TextBoxReorder.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxReorder.Location = New System.Drawing.Point(137, 178)
        Me.TextBoxReorder.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxReorder.MaximumSize = New System.Drawing.Size(350, 55)
        Me.TextBoxReorder.Name = "TextBoxReorder"
        Me.TextBoxReorder.Size = New System.Drawing.Size(347, 22)
        Me.TextBoxReorder.TabIndex = 3
        '
        'TextBoxName
        '
        Me.TextBoxName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxName.Location = New System.Drawing.Point(137, 24)
        Me.TextBoxName.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxName.MaximumSize = New System.Drawing.Size(350, 55)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(347, 22)
        Me.TextBoxName.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 183)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Re-Order Level:"
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 31)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Name:"
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 221)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Category:"
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 23)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(1129, 407)
        Me.DataGridView1.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 273)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(1150, 442)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'New_Item
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1170, 722)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "New_Item"
        Me.Text = "Manage Items"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBoxState.ResumeLayout(False)
        Me.GroupBoxState.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxReorder As TextBox
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents ButtonNew As Button
    Friend WithEvents ButtonUpdate As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TextBoxDescript As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxPresentation As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBoxCat As ComboBox
    Friend WithEvents GroupBoxState As GroupBox
    Friend WithEvents RadioButtonInactive As RadioButton
    Friend WithEvents RadioButtonActive As RadioButton
End Class
