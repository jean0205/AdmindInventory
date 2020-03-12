Public Class StockHistory
    Private Sub StockHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadData()
        GetCategories()



    End Sub


#Region "Load data"

    Sub LoadData()

        Dim stockEntry As New StockEntryBL
        DataGridView1.DataSource = stockEntry.GetStockEntryHistory
        DataGridView1.Columns(0).Visible = False
        DataGridView1.Columns(1).Visible = False

        getTotal()

        PaintDatagrid()


    End Sub



    Sub getTotal()

        Dim total As Decimal
        For Each row As DataGridViewRow In DataGridView1.Rows
            total += row.Cells(8).Value


        Next
        TextBoxTotalcost.Text = total.ToString
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

    Sub GetCategories()


        Dim category As New CategoryBL
        Dim categoryNames As New List(Of String)


        For Each name As String In category.GetCategoriesNames()
            ComboBoxCategory.Items.Add(name)

        Next

    End Sub


#End Region

    'Filter by date


    Private Sub ButtonFilter_Click(sender As Object, e As EventArgs)
        Dim startdate As Date = DateTimePicker1.Value.Date
        Dim endDate As Date = DateTimePicker2.Value.Date
        Dim stockEntry As New StockEntryBL
        DataGridView1.DataSource = stockEntry.FilterStockHistoryByDate(startdate, endDate)
        PaintDatagrid()
        getTotal()



    End Sub


#Region "Events"
    Private Sub TextBoxItem_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBoxItem.KeyUp
        TextBoxInvoice.Clear()
        TextBox1.Clear()
        CheckBox1.Checked = False

        ComboBoxCategory.SelectedIndex = 0

        Dim stockEntry As New StockEntryBL
        DataGridView1.DataSource = stockEntry.FilterStockHistoryByName(TextBoxItem.Text)
        PaintDatagrid()
        getTotal()

    End Sub

    Private Sub TextBoxInvoice_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBoxInvoice.KeyUp
        TextBoxItem.Clear()
        TextBox1.Clear()
        ComboBoxCategory.SelectedIndex = 0
        CheckBox1.Checked = False

        Dim stockEntry As New StockEntryBL
        DataGridView1.DataSource = stockEntry.FilterStockHistoryByInvoice(TextBoxInvoice.Text)
        PaintDatagrid()
        getTotal()

    End Sub

    Private Sub TextBox1_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyUp
        TextBoxItem.Clear()
        TextBoxInvoice.Clear()
        ComboBoxCategory.SelectedIndex = 0
        CheckBox1.Checked = False

        Dim stockEntry As New StockEntryBL
        DataGridView1.DataSource = stockEntry.FilterStockHistoryByProvider(TextBox1.Text)
        PaintDatagrid()
        getTotal()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub ComboBoxCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCategory.SelectedIndexChanged


        Dim stockEntry As New StockEntryBL
        If ComboBoxCategory.Text <> "All Categories" Then

            DataGridView1.DataSource = stockEntry.FilterStockHistoryCategory(ComboBoxCategory.SelectedItem)
            PaintDatagrid()
            getTotal()
            TextBoxItem.Clear()
            TextBoxInvoice.Clear()
            TextBox1.Clear()
            CheckBox1.Checked = False

        Else
            LoadData()

        End If



    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        Dim startdate As Date = DateTimePicker1.Value.Date
        Dim endDate As Date = DateTimePicker2.Value.Date

        Dim stockEntry As New StockEntryBL

        If CheckBox1.Checked Then
            If Not String.IsNullOrEmpty(TextBox1.Text) Then
                Dim provider As String = DataGridView1.Rows(0).Cells(10).Value
                TextBox1.Text = provider
                DataGridView1.DataSource = stockEntry.FilterStockHistoryByDateAAndProvider(startdate, endDate, provider)
                PaintDatagrid()
                getTotal()
                Return

            End If
            If Not String.IsNullOrEmpty(TextBoxItem.Text) Then
                Dim item As String = DataGridView1.Rows(0).Cells(2).Value
                TextBoxItem.Text = item

                DataGridView1.DataSource = stockEntry.FilterStockHistoryByItemAndDate(startdate, endDate, item)
                PaintDatagrid()
                getTotal()
                Return

            End If
            If ComboBoxCategory.SelectedIndex > 0 Then
                Dim category As String = ComboBoxCategory.SelectedItem
                Dim date1 As Date = DateTimePicker1.Value.Date
                Dim date2 As Date = DateTimePicker2.Value.Date
                DataGridView1.DataSource = stockEntry.FilterStockHistoryCategoryAndDate(date1, date2, category)
                PaintDatagrid()
                getTotal()
                Return

            End If

            DataGridView1.DataSource = stockEntry.FilterStockHistoryByDate(startdate, endDate)
            PaintDatagrid()
            getTotal()

        Else
            ComboBoxCategory.SelectedIndex = 0
            TextBoxItem.Clear()
            TextBoxInvoice.Clear()
            TextBox1.Clear()

            LoadData()


        End If


    End Sub
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        CheckBox1.Checked = False

    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        CheckBox1.Checked = False

    End Sub




#End Region

#Region "Report"
    Private Sub ButtonRport_Click(sender As Object, e As EventArgs) Handles ButtonRport.Click



        Dim stockEntryList As New List(Of ReportStockEntry)
        Dim totalcost As Decimal = Convert.ToDecimal(TextBoxTotalcost.Text)
        Dim item As String = "All Items"
        Dim dateFrom As Date = DataGridView1.Rows(DataGridView1.Rows.Count - 2).Cells(12).Value
        Dim dateTo As Date = DataGridView1.Rows(0).Cells(12).Value
        Dim category As String = "All Categories"

        Dim invoice As String = "All Invoices"
        Dim provider As String = "All Providers"


        For Each row As DataGridViewRow In DataGridView1.Rows
            Dim stockEntry As New ReportStockEntry

            stockEntry.Item_Name = row.Cells(2).Value
            stockEntry.Category = row.Cells(3).Value
            stockEntry.GlNumber = row.Cells(4).Value
            stockEntry.Item_Presentationd = row.Cells(5).Value
            stockEntry.Amount = row.Cells(6).Value
            stockEntry.CostEach = row.Cells(7).Value
            stockEntry.CostTotal = row.Cells(8).Value
            stockEntry.InvoiceNo = row.Cells(9).Value
            stockEntry.Provider = row.Cells(10).Value
            stockEntry.Recived = row.Cells(11).Value
            stockEntry.DateReciv = row.Cells(12).Value



            stockEntryList.Add(stockEntry)



        Next
        stockEntryList.RemoveAt(stockEntryList.Count - 1)


        If Not String.IsNullOrWhiteSpace(TextBoxItem.Text) Then
            item = DataGridView1.Rows(0).Cells(2).Value
        End If
        If Not String.IsNullOrWhiteSpace(TextBoxInvoice.Text) Then
            invoice = DataGridView1.Rows(0).Cells(9).Value
        End If
        If Not String.IsNullOrWhiteSpace(TextBox1.Text) Then
            provider = DataGridView1.Rows(0).Cells(10).Value
        End If
        If ComboBoxCategory.SelectedIndex > 0 Then
            category = ComboBoxCategory.SelectedItem
        End If

        If CheckBox1.Checked Then
            dateFrom = DateTimePicker1.Value.Date
            dateTo = DateTimePicker2.Value.Date
        Else

        End If


        Dim reportFrm As New ReportEntryHistoryFrm(item, dateFrom, dateTo, totalcost, invoice, provider, stockEntryList, category)
        reportFrm.Show()


    End Sub

    Private Sub ButtonUpdate_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click
        Dim itemId As Integer = DataGridView1.CurrentRow.Cells(1).Value
        Dim entryId As Integer = DataGridView1.CurrentRow.Cells(0).Value
        Dim invoice As String = DataGridView1.CurrentRow.Cells(9).Value
        Dim provider As String = DataGridView1.CurrentRow.Cells(10).Value
        Dim amount As Integer = DataGridView1.CurrentRow.Cells(6).Value
        Dim cost As Decimal = DataGridView1.CurrentRow.Cells(7).Value
        Dim totalcost As Decimal = DataGridView1.CurrentRow.Cells(8).Value



        Dim addStock As New FrmAddStock(itemId, entryId, True, invoice, provider, amount, cost, totalcost)
        addStock.ShowDialog()
        LoadData()
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click

        Dim itemId As Integer = DataGridView1.CurrentRow.Cells(1).Value
        Dim entryId As Integer = DataGridView1.CurrentRow.Cells(0).Value

        Dim amount As String = DataGridView1.CurrentRow.Cells(6).Value








        Dim message As String = "Do you want to delete this item?"
        Dim title As String = "Delete item"
        Dim buttons As MessageBoxButtons = MessageBoxButtons.YesNo

        Dim result As DialogResult = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Try
                Dim stockentry As New StockEntryBL
                stockentry.DeleteItemprovider(entryId)
                stockentry.DeleteStockEntry(entryId)


                Dim stock As New StockBL
                stock.UpdateStock(itemId, -amount)

                MessageBox.Show("Stock entry successfully deleted.",
                                "Delection Complete",
                                     MessageBoxButtons.OK,
                                        MessageBoxIcon.Information,
                                            MessageBoxDefaultButton.Button1)
                LoadData()
            Catch ex As Exception


            End Try
        End If





    End Sub







#End Region

End Class