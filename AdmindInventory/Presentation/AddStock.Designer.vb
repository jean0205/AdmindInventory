<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAddStock
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
        Me.ButtonNewprov = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBoxprovider = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ButtonClean = New System.Windows.Forms.Button()
        Me.TextBoxInvoice = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxTotalCost = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxCost = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxCategory = New System.Windows.Forms.TextBox()
        Me.ButtonReestock = New System.Windows.Forms.Button()
        Me.TextBoxAmount = New System.Windows.Forms.TextBox()
        Me.TextBoxPresentation = New System.Windows.Forms.TextBox()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ButtonNewprov)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.TextBoxprovider)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.ButtonClean)
        Me.GroupBox1.Controls.Add(Me.TextBoxInvoice)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TextBoxTotalCost)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TextBoxCost)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TextBoxCategory)
        Me.GroupBox1.Controls.Add(Me.ButtonReestock)
        Me.GroupBox1.Controls.Add(Me.TextBoxAmount)
        Me.GroupBox1.Controls.Add(Me.TextBoxPresentation)
        Me.GroupBox1.Controls.Add(Me.TextBoxName)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(354, 412)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'ButtonNewprov
        '
        Me.ButtonNewprov.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonNewprov.Location = New System.Drawing.Point(286, 188)
        Me.ButtonNewprov.Name = "ButtonNewprov"
        Me.ButtonNewprov.Size = New System.Drawing.Size(45, 22)
        Me.ButtonNewprov.TabIndex = 22
        Me.ButtonNewprov.Text = "New"
        Me.ButtonNewprov.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(178, 337)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Posted By:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(106, 337)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "PostedBy:"
        '
        'TextBoxprovider
        '
        Me.TextBoxprovider.Location = New System.Drawing.Point(87, 190)
        Me.TextBoxprovider.Name = "TextBoxprovider"
        Me.TextBoxprovider.Size = New System.Drawing.Size(193, 20)
        Me.TextBoxprovider.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 195)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Provider.:"
        '
        'ButtonClean
        '
        Me.ButtonClean.Location = New System.Drawing.Point(27, 374)
        Me.ButtonClean.Name = "ButtonClean"
        Me.ButtonClean.Size = New System.Drawing.Size(75, 23)
        Me.ButtonClean.TabIndex = 17
        Me.ButtonClean.Text = "Clean"
        Me.ButtonClean.UseVisualStyleBackColor = True
        '
        'TextBoxInvoice
        '
        Me.TextBoxInvoice.Location = New System.Drawing.Point(86, 154)
        Me.TextBoxInvoice.Name = "TextBoxInvoice"
        Me.TextBoxInvoice.Size = New System.Drawing.Size(245, 20)
        Me.TextBoxInvoice.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 159)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Invoice No.:"
        '
        'TextBoxTotalCost
        '
        Me.TextBoxTotalCost.Location = New System.Drawing.Point(232, 276)
        Me.TextBoxTotalCost.Name = "TextBoxTotalCost"
        Me.TextBoxTotalCost.ReadOnly = True
        Me.TextBoxTotalCost.Size = New System.Drawing.Size(97, 20)
        Me.TextBoxTotalCost.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(234, 252)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Total Cost:"
        '
        'TextBoxCost
        '
        Me.TextBoxCost.Location = New System.Drawing.Point(86, 273)
        Me.TextBoxCost.Name = "TextBoxCost"
        Me.TextBoxCost.Size = New System.Drawing.Size(69, 20)
        Me.TextBoxCost.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 278)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Cost Each:"
        '
        'TextBoxCategory
        '
        Me.TextBoxCategory.Location = New System.Drawing.Point(86, 31)
        Me.TextBoxCategory.Name = "TextBoxCategory"
        Me.TextBoxCategory.ReadOnly = True
        Me.TextBoxCategory.Size = New System.Drawing.Size(245, 20)
        Me.TextBoxCategory.TabIndex = 1
        '
        'ButtonReestock
        '
        Me.ButtonReestock.Location = New System.Drawing.Point(245, 374)
        Me.ButtonReestock.Name = "ButtonReestock"
        Me.ButtonReestock.Size = New System.Drawing.Size(75, 23)
        Me.ButtonReestock.TabIndex = 4
        Me.ButtonReestock.Text = "Accept"
        Me.ButtonReestock.UseVisualStyleBackColor = True
        '
        'TextBoxAmount
        '
        Me.TextBoxAmount.Location = New System.Drawing.Point(86, 232)
        Me.TextBoxAmount.Name = "TextBoxAmount"
        Me.TextBoxAmount.Size = New System.Drawing.Size(69, 20)
        Me.TextBoxAmount.TabIndex = 2
        '
        'TextBoxPresentation
        '
        Me.TextBoxPresentation.Location = New System.Drawing.Point(86, 113)
        Me.TextBoxPresentation.Name = "TextBoxPresentation"
        Me.TextBoxPresentation.ReadOnly = True
        Me.TextBoxPresentation.Size = New System.Drawing.Size(245, 20)
        Me.TextBoxPresentation.TabIndex = 3
        '
        'TextBoxName
        '
        Me.TextBoxName.Location = New System.Drawing.Point(86, 72)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.ReadOnly = True
        Me.TextBoxName.Size = New System.Drawing.Size(245, 20)
        Me.TextBoxName.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 237)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Amount:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Attribute:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Category:"
        '
        'FrmAddStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(374, 426)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmAddStock"
        Me.Text = "Restock Inventory"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ButtonReestock As Button
    Friend WithEvents TextBoxAmount As TextBox
    Friend WithEvents TextBoxPresentation As TextBox
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxTotalCost As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxCost As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxCategory As TextBox
    Friend WithEvents TextBoxInvoice As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ButtonClean As Button
    Friend WithEvents TextBoxprovider As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents ButtonNewprov As Button
End Class
