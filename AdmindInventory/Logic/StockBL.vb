Public Class StockBL

    Function GetStockList()
        Dim stock As New StockDB
        Return stock.GetStockList()
    End Function

    'get stock filterin by category
    Function GetStockListByCat(ByVal catName As String) As List(Of Stock)
        Dim stock As New StockDB
        Return stock.GetStockListByCat(catName)

    End Function
    Function GetStockByName(ByVal ItemName As String)
        Dim stock As New StockDB
        Return stock.GetStockByName(ItemName)
    End Function

    Sub InsertItemToStock(ByVal itemId As Integer)
        Dim stock As New StockDB
        stock.InsertItemToStock(itemId)
    End Sub

End Class
