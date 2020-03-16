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
        DataGridView1.Columns(11).Visible = False
        PaintDatagrid()
        getDeactivatedItems()



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

    Sub PaintDatagrid()
        Dim x As Integer = 1

        For Each row As DataGridViewRow In DataGridView1.Rows

            x += 1
            If (x Mod 2) <> 0 Then
                row.DefaultCellStyle.BackColor = Color.Beige
            End If



        Next
    End Sub

    Sub getDeactivatedItems()
        Dim idList As New List(Of Integer)
        Dim stock As New StockBL
        idList = stock.GetStockItemId
        For Each row As DataGridViewRow In DataGridView1.Rows
            If Not idList.Contains(row.Cells(11).Value) Then
                row.DefaultCellStyle.BackColor = Color.Yellow
            End If
        Next

    End Sub


#End Region

#Region "Events"




    Private Sub TextBoxItem_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBoxItem.KeyUp
        ComboBoxcategory.SelectedIndex = 0
        ComboBoxDepartment.SelectedIndex = 0
        CheckBox1.Checked = False

        Dim stockOut As New StockOutBL
        DataGridView1.DataSource = stockOut.FilterStockOutByName(TextBoxItem.Text)

        getDeactivatedItems()




        PaintDatagrid()

    End Sub

    Private Sub ComboBoxcategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxcategory.SelectedIndexChanged

        CheckBox1.Checked = False
        If ComboBoxcategory.Text <> "All Categories" Then
            ComboBoxDepartment.SelectedIndex = 0

            Dim category As String
            Dim stockout As New StockOutBL

            category = ComboBoxcategory.SelectedItem
            DataGridView1.DataSource = stockout.FilterStockOutByCategory(category)

            getDeactivatedItems()

            PaintDatagrid()

            TextBoxItem.Clear()




        Else
            getStockOutHistory()
        End If


    End Sub

    Private Sub ComboBoxDepartment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxDepartment.SelectedIndexChanged
        CheckBox1.Checked = False

        If ComboBoxDepartment.Text <> "All Departments" Then
            ComboBoxcategory.SelectedIndex = 0
            Dim department As String
            Dim stockout As New StockOutBL

            department = ComboBoxDepartment.SelectedItem
            DataGridView1.DataSource = stockout.FilterStockOutByDepartment(department)
            PaintDatagrid()

            getDeactivatedItems()

            TextBoxItem.Clear()

        Else
            getStockOutHistory()
        End If

    End Sub



    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.Checked Then


            If ComboBoxDepartment.SelectedIndex > 0 Then
                Dim department As String = ComboBoxDepartment.SelectedItem
                Dim startdate As Date = DateTimePicker1.Value.Date
                Dim endDate As Date = DateTimePicker2.Value.Date
                Dim stockOut As New StockOutBL
                DataGridView1.DataSource = stockOut.FilterStockHistoryByDateAdDepartment(startdate, endDate, department)
                getDeactivatedItems()
                PaintDatagrid()
                Return
            Else

                Dim startdate As Date = DateTimePicker1.Value.Date
                Dim endDate As Date = DateTimePicker2.Value.Date
                Dim stockOut As New StockOutBL
                DataGridView1.DataSource = stockOut.FilterStockHistoryByDate(startdate, endDate)
                getDeactivatedItems()
                PaintDatagrid()

            End If
            If Not String.IsNullOrEmpty(TextBoxItem.Text) Then

                Dim item As String = TextBoxItem.Text
                Dim startdate As Date = DateTimePicker1.Value.Date
                Dim endDate As Date = DateTimePicker2.Value.Date
                Dim stockOut As New StockOutBL
                DataGridView1.DataSource = stockOut.FilterStockHistoryByDateAndItem(startdate, endDate, item)
                getDeactivatedItems()
                PaintDatagrid()
                Return
            End If
            If CheckBox2.Checked Then
                Dim startdate As Date = DateTimePicker1.Value.Date
                Dim endDate As Date = DateTimePicker2.Value.Date
                Dim stockOut As New StockOutBL
                DataGridView1.DataSource = stockOut.FilterstockOutBydateAndRefused(startdate, endDate)
                getDeactivatedItems()
                PaintDatagrid()
                Return
            End If


        Else
            getStockOutHistory()

            ComboBoxcategory.SelectedIndex = 0
            TextBoxItem.Clear()
            ComboBoxDepartment.SelectedIndex = 0

        End If





    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        CheckBox1.Checked = False

    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        CheckBox1.Checked = False
    End Sub

    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        TextBoxItem.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value

        Dim stockOut As New StockOutBL
        DataGridView1.DataSource = stockOut.FilterStockOutByName(TextBoxItem.Text)

        getDeactivatedItems()

        PaintDatagrid()


    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged

        If CheckBox2.Checked Then
            Dim stockOut As New StockOutBL
            DataGridView1.DataSource = stockOut.GetRequestRefused

            getDeactivatedItems()

            PaintDatagrid()

        Else
            getStockOutHistory()
            CheckBox1.Checked = False


        End If
        TextBoxItem.Clear()
        ComboBoxcategory.Text = String.Empty
        ComboBoxDepartment.Text = String.Empty
    End Sub



#End Region

#Region "Report"
    Private Sub ButtonReport_Click(sender As Object, e As EventArgs) Handles ButtonReport.Click

        Dim stockOutList As New List(Of ReportStockOut2)

        Dim item As String = "All Items"
        Dim dateFrom As Date = DataGridView1.Rows(DataGridView1.Rows.Count - 2).Cells(7).Value
        Dim dateTo As Date = DataGridView1.Rows(0).Cells(7).Value
        Dim department As String = "All Departments"
        Dim category As String = "All Categories"




        For Each row As DataGridViewRow In DataGridView1.Rows
            Dim stockOut As New ReportStockOut2

            stockOut.Item = row.Cells(1).Value
            stockOut.Attribute = row.Cells(2).Value
            stockOut.Category = row.Cells(3).Value
            stockOut.GL = row.Cells(4).Value
            stockOut.Department = row.Cells(5).Value
            stockOut.Amount = row.Cells(6).Value
            stockOut.DateRevic = row.Cells(7).Value
            stockOut.State = row.Cells(8).Value
            stockOut.Person = row.Cells(9).Value
            stockOut.Requested = row.Cells(10).Value



            stockOutList.Add(stockOut)



        Next
        stockOutList.RemoveAt(stockOutList.Count - 1)


        If Not String.IsNullOrWhiteSpace(TextBoxItem.Text) Then
            item = DataGridView1.Rows(0).Cells(1).Value
        End If
        If Not String.IsNullOrWhiteSpace(ComboBoxDepartment.SelectedItem) Then
            'department = DataGridView1.Rows(0).Cells(4).Value
            department = ComboBoxDepartment.SelectedItem
        End If
        If Not String.IsNullOrWhiteSpace(ComboBoxcategory.SelectedItem) Then
            'category = DataGridView1.Rows(0).Cells(2).Value
            category = ComboBoxcategory.SelectedItem
        End If

        If CheckBox1.Checked Then
            dateFrom = DateTimePicker1.Value.Date
            dateTo = DateTimePicker2.Value.Date
        Else

        End If
        If CheckBox2.Checked Then
            item = "Unapprbed Requests"

        End If



        Dim reportFrm As New ReportDistribution(item, dateFrom, dateTo, category, department, stockOutList)
        reportFrm.Show()

    End Sub

    Private Sub ButtonUpdate_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click

        ' verify if the item it is not disable

        Dim stock As New StockBL


        Dim outId As Integer = DataGridView1.CurrentRow.Cells(0).Value
        Dim itemId As Integer = DataGridView1.CurrentRow.Cells(11).Value
        Dim itemName As String = DataGridView1.CurrentRow.Cells(1).Value
        Dim attribute As String = DataGridView1.CurrentRow.Cells(2).Value
        Dim department As String = DataGridView1.CurrentRow.Cells(5).Value
        Dim Amount As Integer = DataGridView1.CurrentRow.Cells(6).Value

        If Not stock.GetStockItemId.Contains(itemId) Then
            MessageBox.Show("The selected record belongs to a deactivated item, it is not possible to modify or delete this record.",
                                "Error",
                                     MessageBoxButtons.OK,
                                        MessageBoxIcon.Error,
                                            MessageBoxDefaultButton.Button1)
            Return

        End If





        Dim stockDist As New FrmDistibuteStock(outId, itemName, attribute, department, Amount, True, itemId)
        stockDist.ShowDialog()

        getStockOutHistory()



    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click

        Dim stock1 As New StockBL
        Dim itemId As Integer = DataGridView1.CurrentRow.Cells(11).Value

        If Not stock1.GetStockItemId.Contains(itemId) Then
            MessageBox.Show("The selected record belongs to a deactivated item, it is not possible to modify or delete this record.",
                                "Error",
                                     MessageBoxButtons.OK,
                                        MessageBoxIcon.Error,
                                            MessageBoxDefaultButton.Button1)
            Return

        End If
        Dim entryId As Integer = DataGridView1.CurrentRow.Cells(0).Value
        Dim amount As String = DataGridView1.CurrentRow.Cells(6).Value








        Dim message As String = "Do you want to delete this record?"
        Dim title As String = "Delete item"
        Dim buttons As MessageBoxButtons = MessageBoxButtons.YesNo

        Dim result As DialogResult = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Try
                Dim stouOut As New StockOutBL

                stouOut.DeleteStockOutRecord(entryId)


                Dim stock As New StockBL
                stock.UpdateStock(itemId, amount)

                MessageBox.Show("Stock entry successfully deleted.",
                                "Delection Complete",
                                     MessageBoxButtons.OK,
                                        MessageBoxIcon.Information,
                                            MessageBoxDefaultButton.Button1)
                getStockOutHistory()
            Catch ex As Exception


            End Try
        End If


    End Sub




#End Region
End Class