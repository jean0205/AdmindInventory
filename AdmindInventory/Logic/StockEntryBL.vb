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

End Class
