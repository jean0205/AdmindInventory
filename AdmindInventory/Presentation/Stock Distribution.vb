Public Class FrmDistibuteStock

#Region "Variable"

    Dim itemId As Integer
    Dim stockAmount As Integer
    Dim id As Integer
    Dim updating As Boolean = False
    Dim itemName As String
    Dim attribute As String
    Dim department As String
    Dim amountBefore As Integer
    Dim instock As Integer


#End Region

#Region "Objects"

    Dim itemDB As New ItemDB
#End Region




    Sub New(ByVal itemId As Integer, ByVal stockAmount As Integer)

        Me.itemId = itemId
        Me.stockAmount = stockAmount

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Sub New(ByVal id As Integer, ByVal itemName As String, attribute As String, department As String, amount As Integer, updating As Boolean, itemid As Integer)

        Me.id = id
        Me.itemName = itemName
        Me.attribute = attribute
        Me.department = department
        Me.amountBefore = amount
        Me.updating = updating
        Me.itemId = itemid


        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub FrmDistibuteStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDepartments()
        LoadItemInformation()

        If updating Then
            Me.TextBoxItem.Text = itemName
            Me.TextBoxPresentation.Text = attribute
            Me.ComboBoxDepartment.SelectedItem = ComboBoxDepartment.FindStringExact(department)
            Me.TextBoxAmount.Text = amountBefore

            Dim stock As New StockDB
            Me.TextBoxInStock.Text = stock.GetStockById(itemId).ToString


        End If



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If CheckInformation() Then
            Return
        End If

        'If ComboBoxDepartment.SelectedIndex < 0 Then
        '    MessageBox.Show("You must select the Department first. ")
        '    Return
        'End If
        'If TextBoxAmount.Text.Length = 0 Then
        '    MessageBox.Show("You must enter some amount. ")
        '    Return
        'End If
        'If Convert.ToInt32(TextBoxAmount.Text) = 0 Then
        '    MessageBox.Show("You must enter some amount other than 0. ")
        '    Return
        'End If

        Try
            Dim departmetName As String = ComboBoxDepartment.SelectedItem
            Dim amount As Integer = Convert.ToInt32(TextBoxAmount.Text)
            Dim todaysdate As Date = Format(DateTime.Now)
            Dim person As String = Label9.Text
            Dim condition As Integer = 2 'approved
            Dim requested As Boolean = False ' it was not a request

            Dim stockOut As New StockOutBL
            Dim stock As New StockBL

            If Not updating Then

                stockOut.InsertStockOut(itemId, departmetName, amount, todaysdate, person, condition, requested)



                stock.UpdateStock(itemId, -amount)


                MessageBox.Show("The item was correctly distributed to the department: " & ComboBoxDepartment.SelectedItem,
                                    "Distribution Complete",
                                         MessageBoxButtons.OK,
                                            MessageBoxIcon.Information,
                                                MessageBoxDefaultButton.Button1)

                TextBoxAmount.Clear()
                ComboBoxDepartment.SelectedIndex = -1

            Else
                stockOut.updateStockOut(Me.id, departmetName, amount)
                Dim diferencia As Integer = amount - amountBefore

                stock.UpdateStock(itemId, -diferencia)

                MessageBox.Show("The record was successfully updated",
                                   "Update Complete",
                                        MessageBoxButtons.OK,
                                           MessageBoxIcon.Information,
                                               MessageBoxDefaultButton.Button1)
                TextBoxAmount.Clear()
                ComboBoxDepartment.SelectedIndex = -1
                updating = False
                Me.Close()

            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try











    End Sub




#Region "Load Data"
    Sub LoadDepartments()
        Dim department As New DepartmentBL

        For Each name As String In department.GetDepartmentsNames()
            ComboBoxDepartment.Items.Add(name)
        Next
    End Sub
    Sub LoadItemInformation()
        Dim item As New Item

        item = itemDB.GetItemsById(itemId)
        TextBoxItem.Text = item.Name
        TextBoxDescription.Text = item.Description
        TextBoxPresentation.Text = item.Attribute
        TextBoxInStock.Text = stockAmount.ToString

    End Sub





#End Region
#Region "Events"
    Private Sub TextBoxAmount_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBoxAmount.KeyUp
        If TextBoxAmount.Text <> String.Empty Then
            Dim amount As Integer = Convert.ToInt32(TextBoxAmount.Text)
            Dim stock As Integer = Convert.ToInt32(TextBoxInStock.Text)



            If amount > stock Then
                TextBoxAmount.Text = TextBoxAmount.Text.Substring(0, TextBoxAmount.Text.Length - 1)

                MessageBox.Show("The amount you are trying to distribute exceeds stocks.")

            End If
        End If

    End Sub

    Private Sub TextBoxAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxAmount.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
#End Region

    Function CheckInformation() As Boolean
        If ComboBoxDepartment.SelectedIndex < 0 Then
            MessageBox.Show("You must select the Department.",
                                "Missing Information",
                                     MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation,
                                            MessageBoxDefaultButton.Button1)

            Return True
        End If
        If TextBoxAmount.Text.Length = 0 Then
            MessageBox.Show("You must enter some amount to distribute.",
                                "Missing Information",
                                     MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation,
                                            MessageBoxDefaultButton.Button1)

            Return True
        End If
        If Convert.ToInt32(TextBoxAmount.Text) = 0 Then
            MessageBox.Show("You must enter some amount to distribute, higer than 0.",
                                "Missing Information",
                                     MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation,
                                            MessageBoxDefaultButton.Button1)

            Return True
        End If

        Return False
    End Function
End Class