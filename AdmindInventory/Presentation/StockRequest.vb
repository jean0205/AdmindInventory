Public Class StockRequest
    Private Sub StockRequest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetItems()
        GetCategories()
        LoadDepartments()



    End Sub













#Region "Load Data"

    Sub GetItems()
        Dim itemList As New List(Of ProviderFrm)
        Dim item As New ItemDB
        DataGridView1.DataSource = item.GetItemTorequest()

        DataGridView1.Columns("Id").Visible = False
    End Sub

    Sub GetCategories()


        Dim category As New CategoryBL
        Dim categoryNames As New List(Of String)


        For Each name As String In category.GetCategoriesNames()
            ComboBoxCategory.Items.Add(name)

        Next

    End Sub
    Sub LoadDepartments()
        Dim department As New DepartmentBL

        For Each name As String In department.GetDepartmentsNames()
            ComboBoxDepartment.Items.Add(name)
        Next
    End Sub

    Sub CleanInterfaz()
        TextBoxAmount.Clear()
        TextBoxItem.Clear()

    End Sub


#End Region

#Region "Events"
    Private Sub ComboBoxCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCategory.SelectedIndexChanged
        If ComboBoxCategory.Text <> "All Categories" Then
            Dim category As String
            Dim item As New ItemDB

            category = ComboBoxCategory.SelectedItem
            DataGridView1.DataSource = item.GetItemsByCat(category)
            HideColumns()
            TextBoxItem.Clear()



        Else
            GetItems()
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

    Private Sub TextBoxItem_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBoxItem.KeyUp
        Dim item As New ItemDB
        ComboBoxCategory.SelectedIndex = 0
        DataGridView1.DataSource = item.GetItemsByName(TextBoxItem.Text)
        'HideColumns()

    End Sub
#End Region
    Sub HideColumns()
        DataGridView1.Columns(0).Visible = False
        DataGridView1.Columns(4).Visible = False
        DataGridView1.Columns(5).Visible = False
        DataGridView1.Columns(6).Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (ComboBoxDepartment.SelectedIndex < 0) Then
            MessageBox.Show("You must select some Department")
            Return
        End If
        If TextBoxAmount.Text.Length < 1 Then
            MessageBox.Show("You must enter the required amount")
            Return
        End If
        If Convert.ToInt32(TextBoxAmount.Text) < 1 Then
            MessageBox.Show("The required amount shoul be higer than 0. ")
            Return
        End If



        Dim itemId As Integer = DataGridView1.CurrentRow.Cells(0).Value
        Dim departmetName As String = ComboBoxDepartment.SelectedItem
        Dim amount As Integer = Convert.ToInt32(TextBoxAmount.Text)
        Dim todaysdate As Date = Format(DateTime.Now)
        Dim person As String = "AuthenticatedUser"
        Dim condition As Integer = 1 'pending
        Dim requested As Boolean = True ' it was not a request
        Dim name As String = DataGridView1.CurrentRow.Cells(1).Value

        Dim stockOut As New StockOutBL
        stockOut.InsertStockOut(itemId, departmetName, amount, todaysdate, person, condition, requested)

        MessageBox.Show("Your " & name.TrimEnd & "  request was successffully post it.")

        CleanInterfaz()





    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        TextBoxItem.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString.TrimEnd()


    End Sub


End Class