Public Class DistributionHistory
    Private Sub DistributionHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getStockOutHistory()
        LoadDepartments()
        GetCategories()




    End Sub

    Private Sub ButtonFilter_Click(sender As Object, e As EventArgs) Handles ButtonFilter.Click

        Dim startdate As Date = DateTimePicker1.Value.Date
        Dim endDate As Date = DateTimePicker2.Value.Date
        Dim stockOut As New StockOutBL
        DataGridView1.DataSource = stockOut.FilterStockHistoryByDate(startdate, endDate)

    End Sub

#Region "Load data to the interfaz"

    Sub getStockOutHistory()
        Dim stockOut As New StockOutBL
        DataGridView1.DataSource = stockOut.GetStockOutHystory

    End Sub

    Sub LoadDepartments()
        Dim department As New DepartmentBL

        For Each name As String In department.GetDepartmentsNames()
            ComboBoxDepartment.Items.Add(name)
        Next
    End Sub

    Sub GetCategories()


        Dim category As New CategoryBL
        Dim categoryNames As New List(Of String)


        For Each name As String In category.GetCategoriesNames()
            ComboBoxcategory.Items.Add(name)

        Next

    End Sub


#End Region

#Region "Events"


    Private Sub TextBoxItem_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBoxItem.KeyUp

        Dim stockOut As New StockOutBL
        DataGridView1.DataSource = stockOut.FilterStockOutByName(TextBoxItem.Text)

    End Sub

    Private Sub ComboBoxcategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxcategory.SelectedIndexChanged
        If ComboBoxcategory.Text <> "All Categories" Then
            Dim category As String
            Dim stockout As New StockOutBL

            category = ComboBoxcategory.SelectedItem
            DataGridView1.DataSource = stockout.FilterStockOutByCategory(category)




        Else
            getStockOutHistory()
        End If

    End Sub

    Private Sub ComboBoxDepartment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxDepartment.SelectedIndexChanged
        If ComboBoxDepartment.Text <> "All Departments" Then
            Dim department As String
            Dim stockout As New StockOutBL

            department = ComboBoxDepartment.SelectedItem
            DataGridView1.DataSource = stockout.FilterStockOutByDepartment(department)

        Else
            getStockOutHistory()
        End If
    End Sub



#End Region
End Class