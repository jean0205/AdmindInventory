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
        Me.ComboBoxCategory = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxFindByName = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBoxState.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBoxState)
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
        Me.GroupBox1.Location = New System.Drawing.Point(9, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(560, 211)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'GroupBoxState
        '
        Me.GroupBoxState.Controls.Add(Me.RadioButtonInactive)
        Me.GroupBoxState.Controls.Add(Me.RadioButtonActive)
        Me.GroupBoxState.Location = New System.Drawing.Point(300, 80)
        Me.GroupBoxState.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBoxState.Name = "GroupBoxState"
        Me.GroupBoxState.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBoxState.Size = New System.Drawing.Size(117, 118)
        Me.GroupBoxState.TabIndex = 20
        Me.GroupBoxState.TabStop = False
        Me.GroupBoxState.Text = "State:"
        '
        'RadioButtonInactive
        '
        Me.RadioButtonInactive.AutoSize = True
        Me.RadioButtonInactive.Location = New System.Drawing.Point(16, 62)
        Me.RadioButtonInactive.Margin = New System.Windows.Forms.Padding(2)
        Me.RadioButtonInactive.Name = "RadioButtonInactive"
        Me.RadioButtonInactive.Size = New System.Drawing.Size(63, 17)
        Me.RadioButtonInactive.TabIndex = 1
        Me.RadioButtonInactive.TabStop = True
        Me.RadioButtonInactive.Text = "Inactive"
        Me.RadioButtonInactive.UseVisualStyleBackColor = True
        '
        'RadioButtonActive
        '
        Me.RadioButtonActive.AutoSize = True
        Me.RadioButtonActive.Location = New System.Drawing.Point(16, 28)
        Me.RadioButtonActive.Margin = New System.Windows.Forms.Padding(2)
        Me.RadioButtonActive.Name = "RadioButtonActive"
        Me.RadioButtonActive.Size = New System.Drawing.Size(55, 17)
        Me.RadioButtonActive.TabIndex = 5
        Me.RadioButtonActive.TabStop = True
        Me.RadioButtonActive.Text = "Active"
        Me.RadioButtonActive.UseVisualStyleBackColor = True
        '
        'ComboBoxCat
        '
        Me.ComboBoxCat.FormattingEnabled = True
        Me.ComboBoxCat.Location = New System.Drawing.Point(103, 169)
        Me.ComboBoxCat.Name = "ComboBoxCat"
        Me.ComboBoxCat.Size = New System.Drawing.Size(174, 21)
        Me.ComboBoxCat.TabIndex = 4
        '
        'TextBoxPresentation
        '
        Me.TextBoxPresentation.Location = New System.Drawing.Point(103, 103)
        Me.TextBoxPresentation.Name = "TextBoxPresentation"
        Me.TextBoxPresentation.Size = New System.Drawing.Size(174, 20)
        Me.TextBoxPresentation.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Presentation:"
        '
        'TextBoxDescript
        '
        Me.TextBoxDescript.Location = New System.Drawing.Point(103, 46)
        Me.TextBoxDescript.Multiline = True
        Me.TextBoxDescript.Name = "TextBoxDescript"
        Me.TextBoxDescript.Size = New System.Drawing.Size(174, 43)
        Me.TextBoxDescript.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 61)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Description:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ButtonDelete)
        Me.GroupBox3.Controls.Add(Me.ButtonNew)
        Me.GroupBox3.Controls.Add(Me.ButtonUpdate)
        Me.GroupBox3.Location = New System.Drawing.Point(430, 19)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(119, 182)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Location = New System.Drawing.Point(21, 141)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(75, 23)
        Me.ButtonDelete.TabIndex = 13
        Me.ButtonDelete.Text = "Delete"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'ButtonNew
        '
        Me.ButtonNew.Location = New System.Drawing.Point(21, 17)
        Me.ButtonNew.Name = "ButtonNew"
        Me.ButtonNew.Size = New System.Drawing.Size(75, 23)
        Me.ButtonNew.TabIndex = 11
        Me.ButtonNew.Text = "Save"
        Me.ButtonNew.UseVisualStyleBackColor = True
        '
        'ButtonUpdate
        '
        Me.ButtonUpdate.Location = New System.Drawing.Point(21, 79)
        Me.ButtonUpdate.Name = "ButtonUpdate"
        Me.ButtonUpdate.Size = New System.Drawing.Size(75, 23)
        Me.ButtonUpdate.TabIndex = 12
        Me.ButtonUpdate.Text = "Update"
        Me.ButtonUpdate.UseVisualStyleBackColor = True
        '
        'TextBoxReorder
        '
        Me.TextBoxReorder.Location = New System.Drawing.Point(103, 137)
        Me.TextBoxReorder.Name = "TextBoxReorder"
        Me.TextBoxReorder.Size = New System.Drawing.Size(174, 20)
        Me.TextBoxReorder.TabIndex = 3
        '
        'TextBoxName
        '
        Me.TextBoxName.Location = New System.Drawing.Point(103, 12)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(174, 20)
        Me.TextBoxName.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Re-Order Level:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 172)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Category:"
        '
        'ComboBoxCategory
        '
        Me.ComboBoxCategory.FormattingEnabled = True
        Me.ComboBoxCategory.Items.AddRange(New Object() {"All Categories"})
        Me.ComboBoxCategory.Location = New System.Drawing.Point(327, 18)
        Me.ComboBoxCategory.Name = "ComboBoxCategory"
        Me.ComboBoxCategory.Size = New System.Drawing.Size(174, 21)
        Me.ComboBoxCategory.TabIndex = 2
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(9, 50)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(543, 300)
        Me.DataGridView1.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TextBoxFindByName)
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Controls.Add(Me.ComboBoxCategory)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 222)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(560, 359)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Find By Name:"
        '
        'TextBoxFindByName
        '
        Me.TextBoxFindByName.Location = New System.Drawing.Point(103, 19)
        Me.TextBoxFindByName.Name = "TextBoxFindByName"
        Me.TextBoxFindByName.Size = New System.Drawing.Size(174, 20)
        Me.TextBoxFindByName.TabIndex = 16
        '
        'New_Item
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(581, 587)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "New_Item"
        Me.Text = "Manage Items"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBoxState.ResumeLayout(False)
        Me.GroupBoxState.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBoxCategory As ComboBox
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
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxFindByName As TextBox
    Friend WithEvents TextBoxDescript As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxPresentation As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBoxCat As ComboBox
    Friend WithEvents GroupBoxState As GroupBox
    Friend WithEvents RadioButtonInactive As RadioButton
    Friend WithEvents RadioButtonActive As RadioButton
End Class
