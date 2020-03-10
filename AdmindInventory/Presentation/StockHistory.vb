Public Class StockHistory
    Private Sub StockHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadData()



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
            total += row.Cells(6).Value


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
        Dim stockEntry As New StockEntryBL
        DataGridView1.DataSource = stockEntry.FilterStockHistoryByName(TextBoxItem.Text)
        PaintDatagrid()
        getTotal()

    End Sub

    Private Sub TextBoxInvoice_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBoxInvoice.KeyUp
        TextBoxItem.Clear()
        TextBox1.Clear()
        Dim stockEntry As New StockEntryBL
        DataGridView1.DataSource = stockEntry.FilterStockHistoryByInvoice(TextBoxInvoice.Text)
        PaintDatagrid()
        getTotal()

    End Sub

    Private Sub TextBox1_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyUp
        TextBoxItem.Clear()
        TextBoxInvoice.Clear()
        Dim stockEntry As New StockEntryBL
        DataGridView1.DataSource = stockEntry.FilterStockHistoryByProvider(TextBox1.Text)
        PaintDatagrid()
        getTotal()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.Checked Then
            Dim startdate As Date = DateTimePicker1.Value.Date
            Dim endDate As Date = DateTimePicker2.Value.Date
            Dim stockEntry As New StockEntryBL
            DataGridView1.DataSource = stockEntry.FilterStockHistoryByDate(startdate, endDate)
            PaintDatagrid()
            getTotal()

        Else
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
        Dim dateFrom As Date = DataGridView1.Rows(DataGridView1.Rows.Count - 2).Cells(10).Value
        Dim dateTo As Date = DataGridView1.Rows(0).Cells(10).Value

        Dim invoice As String = "All Invoices"
        Dim provider As String = "All Providers"


        For Each row As DataGridViewRow In DataGridView1.Rows
            Dim stockEntry As New ReportStockEntry

            stockEntry.Item_Name = row.Cells(2).Value
            StockEntry.Item_Presentationd = row.Cells(3).Value
            StockEntry.Amount = row.Cells(4).Value
            StockEntry.CostEach = row.Cells(5).Value
            StockEntry.CostTotal = row.Cells(6).Value
            StockEntry.InvoiceNo = row.Cells(7).Value
            StockEntry.Provider = row.Cells(8).Value
            stockEntry.Recived = row.Cells(9).Value
            stockEntry.DateReciv = row.Cells(10).Value



            stockEntryList.Add(stockEntry)



        Next
        stockEntryList.RemoveAt(stockEntryList.Count - 1)


        If Not String.IsNullOrWhiteSpace(TextBoxItem.Text) Then
            item = DataGridView1.Rows(0).Cells(2).Value
        End If
        If Not String.IsNullOrWhiteSpace(TextBoxInvoice.Text) Then
            invoice = DataGridView1.Rows(0).Cells(7).Value
        End If
        If Not String.IsNullOrWhiteSpace(TextBox1.Text) Then
            provider = DataGridView1.Rows(0).Cells(8).Value
        End If

        If CheckBox1.Checked Then
            dateFrom = DateTimePicker1.Value.Date
            dateTo = DateTimePicker2.Value.Date
        Else

        End If


        Dim reportFrm As New ReportEntryHistoryFrm(item, dateFrom, dateTo, totalcost, invoice, provider, stockEntryList)
        reportFrm.Show()


    End Sub





#End Region

End Class