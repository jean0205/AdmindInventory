Public Class StockEntryBL
    'Function GetStockEntryList() As List(Of StockEntry)
    '    Dim stockEntry As New StockEntryDB
    '    Return stockEntry.GetStockEntryList()
    'End Function

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

    Function FilterStockHistoryByDateAAndProvider(ByVal date1 As Date, ByVal date2 As Date, provider As String) As DataTable
        Dim stockEntry As New StockEntryDB
        Return stockEntry.FilterStockHistoryByDateAdProvider(date1, date2, provider)

    End Function

    Function FilterStockHistoryCategory(category As String) As DataTable

        Dim stockEntry As New StockEntryDB
        Return stockEntry.FilterStockHistoryCategory(category)

    End Function

    Function FilterStockHistoryCategoryAndDate(ByVal date1 As Date, ByVal date2 As Date, category As String) As DataTable
        Dim stockEntry As New StockEntryDB
        Return stockEntry.FilterStockHistoryCategoryAndDate(date1, date2, category)


    End Function

    Function FilterStockHistoryByItemAndDate(ByVal date1 As Date, ByVal date2 As Date, item As String) As DataTable
        Dim stockEntry As New StockEntryDB
        Return stockEntry.FilterStockHistoryItemAndDate(date1, date2, item)

    End Function
    Sub UpdateStockEntry(ByVal id As Integer, ByVal invoiceNo As String, ByVal providerId As String,
                         ByVal amount As Integer, ByVal costEach As Decimal, ByVal costTotal As Decimal,
                         ByVal recived As String, ByVal daterecived As Date)

        Dim stockEntry As New StockEntryDB
        stockEntry.UpdateStockEntry(id, invoiceNo, providerId, amount, costEach, costTotal, recived, daterecived)
    End Sub

    Sub UpdateItemprovider(ByVal providerId As String,
                        ByVal costEach As Decimal, ByVal daterecived As Date, ByVal entryId As Integer)

        Dim stockEntry As New StockEntryDB
        stockEntry.UpdateItemprovider(providerId, costEach, daterecived, entryId)

    End Sub
    Sub DeleteStockEntry(ByVal entryId As Integer)
        Dim stockEntry As New StockEntryDB
        stockEntry.DeleteStockEntry(entryId)
    End Sub
    Sub DeleteItemprovider(ByVal entryId As Integer)
        Dim stockEntry As New StockEntryDB
        stockEntry.DeleteItemprovider(entryId)
    End Sub

    Function StockEntryAudit() As DataTable
        Dim stockEntry As New StockEntryDB
        Return stockEntry.StockEntryAudit
    End Function
    Function StockEntryAuditByUser(user As String) As DataTable
        Dim stockEntry As New StockEntryDB
        Return stockEntry.StockEntryAuditByUser(user)

    End Function
    Function StockEntryAuditByStation(station As String) As DataTable
        Dim stockEntry As New StockEntryDB
        Return stockEntry.StockEntryAuditByStation(station)

    End Function
    Function StockEntryAuditByOperation(operation As String) As DataTable
        Dim stockEntry As New StockEntryDB
        Return stockEntry.StockEntryAuditByOperation(operation)
    End Function

End Class
