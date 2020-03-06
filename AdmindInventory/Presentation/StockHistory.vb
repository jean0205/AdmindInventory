Public Class StockHistory
    Private Sub StockHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadData()



    End Sub


#Region "Load data"

    Sub LoadData()
        Dim stockEntry As New StockEntryBL
        DataGridView1.DataSource = stockEntry.GetStockEntryHistory
        DataGridView1.Columns(0).Visible = False

        getTotal()


    End Sub



    Sub getTotal()

        Dim total As Decimal
        For Each row As DataGridViewRow In DataGridView1.Rows
            total += row.Cells(5).Value


        Next
        TextBoxTotalcost.Text = total.ToString
    End Sub


#End Region

    'Filter by date


    Private Sub ButtonFilter_Click(sender As Object, e As EventArgs) Handles ButtonFilter.Click
        Dim startdate As Date = DateTimePicker1.Value.Date
        Dim endDate As Date = DateTimePicker2.Value.Date
        Dim stockEntry As New StockEntryBL
        DataGridView1.DataSource = stockEntry.FilterStockHistoryByDate(startdate, endDate)
        getTotal()



    End Sub

#Region "Events"
    Private Sub TextBoxItem_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBoxItem.KeyUp
        TextBoxInvoice.Clear()
        Dim stockEntry As New StockEntryBL
        DataGridView1.DataSource = stockEntry.FilterStockHistoryByName(TextBoxItem.Text)
        getTotal()

    End Sub

    Private Sub TextBoxInvoice_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBoxInvoice.KeyUp
        TextBoxItem.Clear()
        Dim stockEntry As New StockEntryBL
        DataGridView1.DataSource = stockEntry.FilterStockHistoryByInvoice(TextBoxInvoice.Text)
        getTotal()

    End Sub


#End Region

End Class