Public Class DistributionHistory

    Private Sub DistributionHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getStockOutHistory()
        LoadDepartments()
        GetCategories()




    End Sub



#Region "Load data to the interfaz"

    Sub getStockOutHistory()
        Dim stockOut As New StockOutBL
        DataGridView1.DataSource = stockOut.GetStockOutHystory
        DataGridView1.Columns(0).Visible = False

        Dim x As Integer = 1

        For Each row As DataGridViewRow In DataGridView1.Rows

            x += 1
            If (x Mod 2) <> 0 Then
                row.DefaultCellStyle.BackColor = Color.Beige
            End If



        Next

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
        ComboBoxDepartment.Text = String.Empty
        TextBoxItem.Clear()

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
        ComboBoxcategory.Text = String.Empty
        TextBoxItem.Clear()
    End Sub



    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.Checked Then


            If ComboBoxDepartment.SelectedIndex > 0 Then
                Dim department As String = ComboBoxDepartment.SelectedItem
                Dim startdate As Date = DateTimePicker1.Value.Date
                Dim endDate As Date = DateTimePicker2.Value.Date
                Dim stockOut As New StockOutBL
                DataGridView1.DataSource = stockOut.FilterStockHistoryByDateAdDepartment(startdate, endDate, department)
            Else

                Dim startdate As Date = DateTimePicker1.Value.Date
                Dim endDate As Date = DateTimePicker2.Value.Date
                Dim stockOut As New StockOutBL
                DataGridView1.DataSource = stockOut.FilterStockHistoryByDate(startdate, endDate)

            End If
            If Not String.IsNullOrEmpty(TextBoxItem.Text) Then

                Dim item As String = TextBoxItem.Text
                Dim startdate As Date = DateTimePicker1.Value.Date
                Dim endDate As Date = DateTimePicker2.Value.Date
                Dim stockOut As New StockOutBL
                DataGridView1.DataSource = stockOut.FilterStockHistoryByDateAndItem(startdate, endDate, item)
            End If
        Else
            getStockOutHistory()

        End If




    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged

        If CheckBox2.Checked Then
            Dim stockOut As New StockOutBL
            DataGridView1.DataSource = stockOut.GetRequestRefused
        Else
            getStockOutHistory()


        End If
    End Sub



#End Region

#Region "Report"
    Private Sub ButtonReport_Click(sender As Object, e As EventArgs) Handles ButtonReport.Click

        Dim stockOutList As New List(Of ReportStockOut)

        Dim item As String = "All Items"
        Dim dateFrom As Date = DataGridView1.Rows(DataGridView1.Rows.Count - 2).Cells(6).Value
        Dim dateTo As Date = DataGridView1.Rows(0).Cells(6).Value
        Dim department As String = "All Departments"
        Dim category As String = "All Categories"




        For Each row As DataGridViewRow In DataGridView1.Rows
            Dim stockOut As New ReportStockOut

            stockOut.Item_Name = row.Cells(1).Value
            stockOut.Category = row.Cells(2).Value
            stockOut.GL = row.Cells(3).Value
            stockOut.Department = row.Cells(4).Value
            stockOut.Amount = row.Cells(5).Value
            stockOut.DateRevic = row.Cells(6).Value
            stockOut.State = row.Cells(7).Value
            stockOut.Person = row.Cells(8).Value
            stockOut.Requested = row.Cells(9).Value



            stockOutList.Add(stockOut)



        Next
        stockOutList.RemoveAt(stockOutList.Count - 1)


        If Not String.IsNullOrWhiteSpace(TextBoxItem.Text) Then
            item = DataGridView1.Rows(0).Cells(1).Value
        End If
        If Not String.IsNullOrWhiteSpace(ComboBoxDepartment.SelectedItem) Then
            department = DataGridView1.Rows(0).Cells(4).Value
        End If
        If Not String.IsNullOrWhiteSpace(ComboBoxcategory.SelectedItem) Then
            category = DataGridView1.Rows(0).Cells(2).Value
        End If

        If CheckBox1.Checked Then
            dateFrom = DateTimePicker1.Value.Date
            dateTo = DateTimePicker2.Value.Date
        Else

        End If


        Dim reportFrm As New ReportDistribution(item, dateFrom, dateTo, category, department, stockOutList)
        reportFrm.Show()

    End Sub


#End Region
End Class