Public Class StockMain


#Region "Buttoms"
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonAddStock.Click
        Dim itemId As Integer = DataGridView1.CurrentRow.Cells(0).Value

        Dim addStock As New FrmAddStock(itemId)
        addStock.ShowDialog()
        LoadStock()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim newItem As New New_Item
        newItem.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles ButtonDistrStock.Click

        Dim itemId As Integer = DataGridView1.CurrentRow.Cells(0).Value
        Dim stockAmount As Integer = DataGridView1.CurrentRow.Cells(5).Value
        Dim stockDist As New FrmDistibuteStock(itemId, stockAmount)
        stockDist.ShowDialog()
        LoadStock()


    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles ButtonMngitems.Click
        Dim newItem As New New_Item
        newItem.ShowDialog()
        LoadStock()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles ButtonMngDepart.Click
        Dim departmentF As New Departments
        departmentF.ShowDialog()


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles ButtonMngCat.Click
        Dim categoriesF As New Categories
        categoriesF.ShowDialog()
        LoadCategories()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles ButtonStockHistory.Click
        Dim stockHistoryFrm As New StockHistory
        stockHistoryFrm.ShowDialog()
        LoadStock()

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles ButtonDistrbHistory.Click
        Dim distrHistoryFrm As New DistributionHistory
        distrHistoryFrm.ShowDialog()
        LoadStock()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles ButtonPendingReqs.Click
        Dim pendinReqFrm As New PendingRequests
        pendinReqFrm.ShowDialog()
        LoadStock()

    End Sub
    Private Sub ButtonRequest_Click(sender As Object, e As EventArgs) Handles ButtonRequest.Click
        Dim stockRequest As New StockRequest
        stockRequest.ShowDialog()
        LoadStock()
        GetFlag()



    End Sub
    Private Sub Buttonbudget_Click(sender As Object, e As EventArgs) Handles Buttonbudget.Click
        Dim budgetfrm As New Budget
        budgetfrm.ShowDialog()
    End Sub

    'probando inactivar items o sea borrarlos de la tabla
    'Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
    '    Dim item As New ItemBL
    '    Dim stock As New StockBL
    '    Dim itemId As Integer = DataGridView1.CurrentRow.Cells(0).Value
    '    Dim stockremain As Integer = DataGridView1.CurrentRow.Cells(5).Value

    '    If stockremain = 0 Then
    '        item.ChangeItemState(itemId)
    '        stock.DeleteItemInactive(itemId)

    '        MessageBox.Show("Item state changed to inactive." & vbCrLf & "Item deleted from the stock table.")
    '        LoadStock()
    '    Else
    '        MessageBox.Show("This item have remaining stock." & vbCrLf & "Just items with no remaining stock can be inactivated.")
    '    End If




    'End Sub
    ' boton de prueba para los providers
    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Dim providerFrm As New ProviderFrm
        providerFrm.Show()
    End Sub
#End Region




    Private Sub StockMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStock()
        LoadCategories()


    End Sub

#Region "Events"

    Private Sub ComboBoxCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCategory.SelectedIndexChanged
        If ComboBoxCategory.SelectedIndex > 0 Then
            Dim stock As New StockBL
            DataGridView1.DataSource = stock.GetStockListByCat(ComboBoxCategory.SelectedItem)
            DataGridView1.Columns(0).Visible = False
            TextBoxName.Clear()
            GetFlag()

            Dim category As New CategoryBL
            For Each number As DataRow In category.getBudgetByCategory(ComboBoxCategory.SelectedItem).Rows
                TextBox1.Text = number(3).ToString
                TextBox2.Text = number(4).ToString
                TextBox3.Text = number(5).ToString
            Next

            showBudget(True)
        Else
            LoadStock()
            showBudget(False)
        End If

    End Sub

    Private Sub TextBoxName_TextChanged(sender As Object, e As EventArgs) Handles TextBoxName.TextChanged

    End Sub
    Private Sub TextBoxName_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBoxName.KeyUp
        Dim stock As New StockBL
        ComboBoxCategory.SelectedIndex = 0
        DataGridView1.DataSource = stock.GetStockByName(TextBoxName.Text)

        GetFlag()


    End Sub
    Private Sub CheckBoxReorder_Click(sender As Object, e As EventArgs) Handles CheckBoxReorder.Click
        If CheckBoxReorder.Checked Then
            Dim stock As New StockBL
            DataGridView1.DataSource = stock.GetStockToOrder()
            DataGridView1.Columns(0).Visible = False
            DataGridView1.Columns(6).Visible = False
            GetFlag()

        Else
            LoadStock()
        End If
    End Sub

#End Region

#Region "load data"

    Sub LoadStock()
        Dim stock As New StockBL
        DataGridView1.DataSource = stock.GetStockList()
        DataGridView1.Columns(0).Visible = False
        'DataGridView1.Columns(6).Visible = False


        GetFlag()


    End Sub

    Sub LoadCategories()
        ComboBoxCategory.Items.Clear()
        Dim category As New CategoryBL
        ComboBoxCategory.Items.Add("All Categories")

        For Each name As String In category.GetCategoriesNames()

            ComboBoxCategory.Items.Add(name)

        Next
        ComboBoxCategory.SelectedIndex = 0

    End Sub



    Sub GetFlag()
        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.Cells(5).Value <= row.Cells(4).Value Then
                row.DefaultCellStyle.BackColor = Color.Yellow

            End If
        Next
    End Sub

    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick

        Dim itemId As Integer = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        Dim itemProviderFrm As New ItemProviderFrm(itemId)
        itemProviderFrm.ShowDialog()

    End Sub





    Private Sub Button4_Click_2(sender As Object, e As EventArgs)
        'Dim report As New ReportEntryHistoryFrm
        ' Report.Show()
    End Sub

    Private Sub ButtonReport_Click(sender As Object, e As EventArgs) Handles ButtonReport.Click

        Dim category As String = "All Categories"
        Dim reorderList As String = String.Empty
        Dim total As Integer = DataGridView1.Rows.Count
        Dim stockList As New List(Of ReportStock)

        If ComboBoxCategory.SelectedIndex > 0 Then
            category = ComboBoxCategory.SelectedItem
        End If
        If CheckBoxReorder.Checked Then
            reorderList = "Items to Reorder"
            total = DataGridView1.Rows.Count - 1
        End If

        For Each row As DataGridViewRow In DataGridView1.Rows
            Dim stock As New ReportStock

            stock.ItemName = row.Cells(1).Value
            Stock.ItemCategory = row.Cells(2).Value
            Stock.ItemPresentation = row.Cells(3).Value
            Stock.ItemReorder = row.Cells(4).Value
            stock.StockRemains = row.Cells(5).Value

            stockList.Add(stock)



        Next

        Dim report As New ReportStockFrm(category, reorderList, total, stockList)
        report.Show()

        'CheckBoxReorder.Checked = False
        ComboBoxCategory.Text = String.Empty


    End Sub








#End Region



    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        If e.RowIndex >= 0 AndAlso e.ColumnIndex = 6 Then

            'Reference the GridView Row.
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

            'Set the CheckBox selection.
            row.Cells(6).Value = Convert.ToBoolean(row.Cells(6).EditedFormattedValue)

            'If CheckBox is checked, display Message Box.
            If Not Convert.ToBoolean(row.Cells(6).Value) Then

                Dim item As New ItemBL
                Dim stock As New StockBL
                Dim itemId As Integer = DataGridView1.CurrentRow.Cells(0).Value
                Dim stockremain As Integer = DataGridView1.CurrentRow.Cells(5).Value

                If stockremain = 0 Then
                    item.ChangeItemState(itemId)
                    stock.DeleteItemInactive(itemId)

                    MessageBox.Show("Item state changed to inactive." & vbCrLf & "Item deleted from the stock table.")

                    LoadStock()
                Else
                    MessageBox.Show("This item have remaining stock." & vbCrLf & "Just items with no remaining stock can be inactivated.")
                    LoadStock()
                End If
            End If
        End If

    End Sub

    Sub showBudget(ByVal state As Boolean)
        Label5.Visible = state
        Label2.Visible = state
        Label6.Visible = state
        TextBox1.Visible = state
        TextBox2.Visible = state
        TextBox3.Visible = state


    End Sub

End Class
