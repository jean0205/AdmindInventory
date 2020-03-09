Public Class StockEntryBL
    Function GetStockEntryList() As List(Of StockEntry)
        Dim stockEntry As New StockEntryDB
        Return stockEntry.GetStockEntryList()
    End Function

    Sub InsertStockEntry(ByVal itemId As Integer, ByVal invoiceNo As String, ByVal providerId As String,
                         ByVal amount As Integer, ByVal costEach As Decimal, ByVal costTotal As Decimal,
                         ByVal recived As String, ByVal daterecived As Date)

        Dim stockEntry As New StockEntryDB
        stockEntry.InsertStockEntry(itemId, invoiceNo, providerId, amount, costEach, costTotal, recived, daterecived)


    End Sub

    Sub InsertItemprovider(ByVal itemId As Integer, ByVal providerId As String,
                         ByVal costEach As Decimal, ByVal daterecived As Date)
        Dim stockEntry As New StockEntryDB
        stockEntry.InsertItemprovider(itemId, providerId, costEach, daterecived)

    End Sub


    Function GetStockEntryHistory() As DataTable
        Dim stockEntry As New StockEntryDB
        Return stockEntry.GetStockEntryHistory()

    End Function

    Function FilterStockHistoryByName(ByVal ItemName As String) As DataTable
        Dim stockEntry As New StockEntryDB
        Return stockEntry.FilterStockHistoryByName(ItemName)

    End Function

    Function FilterStockHistoryByInvoice(ByVal invoice As String) As DataTable
        Dim stockEntry As New StockEntryDB
        Return stockEntry.FilterStockHistoryByInvoice(invoice)

    End Function

    Function FilterStockHistoryByProvider(ByVal provider As String) As DataTable
        Dim stockEntry As New StockEntryDB
        Return stockEntry.FilterStockHistoryByProvider(provider)

    End Function

    Function FilterStockHistoryByDate(ByVal date1 As Date, ByVal date2 As Date) As DataTable
        Dim stockEntry As New StockEntryDB
        Return stockEntry.FilterStockHistoryByDate(date1, date2)

    End Function

End Class
